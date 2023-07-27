﻿using System.Collections.Generic;
using System.Threading;
using Microsoft.Boogie;

namespace Microsoft.Dafny.LanguageServer.Language.Symbols {
  public class ScopeSymbol : Symbol, ILocalizableSymbol {
    public INode Node { get; }
    public readonly IToken BodyStartToken;
    public readonly IToken BodyEndToken;
    public List<ILegacySymbol> Symbols { get; } = new();
    public override IEnumerable<ILegacySymbol> Children => Symbols;

    public ScopeSymbol(ILegacySymbol? scope, INode region) : base(scope, string.Empty) {
      Node = region;
      BodyStartToken = region.RangeToken.StartToken;
      BodyEndToken = region.RangeToken.EndToken;
    }

    public override TResult Accept<TResult>(ISymbolVisitor<TResult> visitor) {
      return visitor.Visit(this);
    }

    public string GetDetailText(DafnyOptions options, CancellationToken cancellationToken) {
      return "";
    }
  }
}
