﻿using System;
using Microsoft.Dafny.LanguageServer.Language.Symbols;
using Microsoft.Dafny.LanguageServer.Util;
using Microsoft.Extensions.Options;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Logging;
using Range = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;

namespace Microsoft.Dafny.LanguageServer.Language {
  /// <summary>
  /// Ghost state diagnostic collector that resolves the ghost states by recursively traversing
  /// through the given <see cref="Dafny.Program"/> instance.
  /// </summary>
  /// <remarks>
  /// To avoid diagnostic overload, the recursion will stop once a ghost state has been identified. Otherwise,
  /// diagnostics may overlap with each other, creating a large list of hover texts.
  /// </remarks>
  public class GhostStateDiagnosticCollector : IGhostStateDiagnosticCollector {
    private const string GhostStatementMessage = "Ghost statement";

    private readonly DafnyOptions options;
    private readonly ILogger<GhostStateDiagnosticCollector> logger;
    public GhostStateDiagnosticCollector(DafnyOptions options, ILogger<GhostStateDiagnosticCollector> logger) {
      this.options = options;
      this.logger = logger;
    }

    public IReadOnlyDictionary<Uri, IReadOnlyList<Range>> GetGhostStateDiagnostics(
      LegacySignatureAndCompletionTable signatureAndCompletionTable, CancellationToken cancellationToken) {
      if (!options.Get(ServerCommand.GhostIndicators)) {
        return ImmutableDictionary<Uri, IReadOnlyList<Range>>.Empty;
      }

      if (signatureAndCompletionTable.CompilationUnit.Program.Reporter.HasErrors) {
        return ImmutableDictionary<Uri, IReadOnlyList<Range>>.Empty; // TODO improve?
      }
      try {
        var visitor = new GhostStateSyntaxTreeVisitor(cancellationToken);
        visitor.Visit(signatureAndCompletionTable.CompilationUnit.Program);
        return visitor.GhostDiagnostics.ToDictionary(
          kv => kv.Key,
          kv => (IReadOnlyList<Range>)kv.Value);
      } catch (Exception e) {
        logger.LogDebug(e, "encountered an exception while getting ghost state diagnostics of {Name}", signatureAndCompletionTable.CompilationUnit.Name);
        return ImmutableDictionary<Uri, IReadOnlyList<Range>>.Empty;
      }
    }

    private class GhostStateSyntaxTreeVisitor : SyntaxTreeVisitor {
      private readonly CancellationToken cancellationToken;

      public Dictionary<Uri, List<Range>> GhostDiagnostics { get; } = new();

      public GhostStateSyntaxTreeVisitor(CancellationToken cancellationToken) {
        this.cancellationToken = cancellationToken;
      }

      public override void VisitUnknown(object node, IToken token) { }

      public override void Visit(Statement statement) {
        cancellationToken.ThrowIfCancellationRequested();
        if (IsGhostStatementToMark(statement)) {
          var list = GhostDiagnostics.GetOrCreate(statement.Tok.Uri, () => new List<Range>());
          list.Add(GetRange(statement));
        } else {
          base.Visit(statement);
        }
      }

      private bool IsGhostStatementToMark(Statement statement) {
        return statement.IsGhost && statement.Tok.line > 0;
      }

      private static Range GetRange(Statement statement) {
        return statement switch {
          UpdateStmt updateStatement => GetRange(updateStatement),
          _ => CreateRange(statement.RangeToken.StartToken, statement.RangeToken.EndToken)
        };
      }

      private static Range GetRange(UpdateStmt updateStatement) {
        IToken startToken;
        if (updateStatement.Lhss.Count > 0) {
          startToken = updateStatement.Lhss[0].tok;
        } else if (updateStatement.ResolvedStatements.Count > 0) {
          // This branch handles the case where the UpdateStmt consists of an CallStmt without of left hand side.
          // otherwise, we'd only mark parentheses and the semi-colon of the CallStmt. 
          startToken = GetStartTokenFromResolvedStatement(updateStatement.ResolvedStatements[0]);
        } else {
          startToken = updateStatement.Tok;
        }
        return CreateRange(startToken, updateStatement.RangeToken.EndToken);
      }

      private static IToken GetStartTokenFromResolvedStatement(Statement resolvedStatement) {
        return resolvedStatement switch {
          CallStmt callStatement => callStatement.MethodSelect.tok,
          _ => resolvedStatement.Tok
        };
      }

      private static Range CreateRange(IToken startToken, IToken endToken) {
        var endPosition = endToken.GetLspPosition();
        return new Range(
          startToken.GetLspPosition(),
          endPosition with { Character = endPosition.Character + endToken.val.Length }
        );
      }

      private static Diagnostic CreateGhostDiagnostic(Range range) {
        return new Diagnostic {
          Range = range,
          Message = GhostStatementMessage,
          Severity = DiagnosticSeverity.Hint
        };
      }
    }
  }
}
