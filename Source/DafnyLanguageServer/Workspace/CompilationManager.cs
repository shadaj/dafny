using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Boogie;
using Microsoft.Dafny.LanguageServer.Language;
using Microsoft.Dafny.LanguageServer.Util;
using Microsoft.Dafny.LanguageServer.Workspace.Notifications;
using Microsoft.Extensions.Logging;
using OmniSharp.Extensions.LanguageServer.Protocol.Models;
using VC;
using Range = OmniSharp.Extensions.LanguageServer.Protocol.Models.Range;

namespace Microsoft.Dafny.LanguageServer.Workspace;

public delegate CompilationManager CreateCompilationManager(
  DafnyOptions options,
  ExecutionEngine boogieEngine,
  Compilation compilation,
  IReadOnlyDictionary<Uri, VerificationTree> migratedVerificationTrees);

/// <summary>
/// The compilation of a single document version.
/// The document will be parsed, resolved, translated to Boogie and verified.
///
/// Compilation may be configured to pause after translation,
/// requiring a call to CompilationManager.Verify for the document to be verified.
///
/// Compilation is agnostic to document updates, it does not handle the migration of old document state.
/// </summary>
public class CompilationManager {

  private readonly ILogger logger;
  private readonly ITextDocumentLoader documentLoader;
  private readonly IProgramVerifier verifier;
  private readonly IVerificationProgressReporter verificationProgressReporter;

  // TODO CompilationManager shouldn't be aware of migration
  private readonly IReadOnlyDictionary<Uri, VerificationTree> migratedVerificationTrees;

  private TaskCompletionSource started = new();
  private readonly IScheduler verificationUpdateScheduler = new EventLoopScheduler();
  private readonly CancellationTokenSource cancellationSource;

  private TaskCompletionSource verificationCompleted = new();
  private readonly DafnyOptions options;
  private readonly Compilation startingCompilation;
  private readonly ExecutionEngine boogieEngine;

  private readonly Subject<Compilation> compilationUpdates = new();
  public IObservable<Compilation> CompilationUpdates => compilationUpdates;

  public Task<CompilationAfterParsing> ParsedCompilation { get; }
  public Task<CompilationAfterResolution> ResolvedCompilation { get; }

  public CompilationManager(
    ILogger<CompilationManager> logger,
    ITextDocumentLoader documentLoader,
    IProgramVerifier verifier,
    IVerificationProgressReporter verificationProgressReporter,
    DafnyOptions options,
    ExecutionEngine boogieEngine,
    Compilation compilation,
    IReadOnlyDictionary<Uri, VerificationTree> migratedVerificationTrees
    ) {
    this.options = options;
    startingCompilation = compilation;
    this.boogieEngine = boogieEngine;
    this.migratedVerificationTrees = migratedVerificationTrees;

    this.documentLoader = documentLoader;
    this.logger = logger;
    this.verifier = verifier;
    this.verificationProgressReporter = verificationProgressReporter;
    cancellationSource = new();
    cancellationSource.Token.Register(() => started.TrySetCanceled(cancellationSource.Token));

    MarkVerificationFinished();

    ParsedCompilation = ParseAsync();
    ResolvedCompilation = ResolveAsync();
  }

  public void Start() {
    started.TrySetResult();
  }

  private async Task<CompilationAfterParsing> ParseAsync() {
    try {
      await started.Task;
      var parsedCompilation = await documentLoader.ParseAsync(options, startingCompilation, migratedVerificationTrees, cancellationSource.Token);
      foreach (var root in parsedCompilation.RootUris) {
        verificationProgressReporter.ReportRealtimeDiagnostics(parsedCompilation, root, false);
      }
      compilationUpdates.OnNext(parsedCompilation);
      logger.LogDebug($"Passed parsedCompilation to documentUpdates.OnNext, resolving ParsedCompilation task for version {parsedCompilation.Version}.");
      return parsedCompilation;

    } catch (Exception e) {
      compilationUpdates.OnError(e);
      throw;
    }
  }

  private async Task<CompilationAfterResolution> ResolveAsync() {
    try {
      var parsedCompilation = await ParsedCompilation;
      var resolvedCompilation = await documentLoader.ResolveAsync(options, parsedCompilation, migratedVerificationTrees, cancellationSource.Token);

      if (!resolvedCompilation.Program.Reporter.HasErrors) {
        verificationProgressReporter.RecomputeVerificationTrees(resolvedCompilation);
        foreach (var root in resolvedCompilation.RootUris) {
          verificationProgressReporter.ReportRealtimeDiagnostics(resolvedCompilation, root, true);
        }
      }

      compilationUpdates.OnNext(resolvedCompilation);
      logger.LogDebug($"Passed resolvedCompilation to documentUpdates.OnNext, resolving ResolvedCompilation task for version {resolvedCompilation.Version}.");
      return resolvedCompilation;

    } catch (Exception e) {
      compilationUpdates.OnError(e);
      throw;
    }
  }

  private static string GetImplementationName(Implementation implementation) {
    var prefix = implementation.Name.Split(Translator.NameSeparator)[0];

    // Refining declarations get the token of what they're refining, so to distinguish them we need to
    // add the refining module name to the prefix.
    if (implementation.tok is RefinementToken refinementToken) {
      prefix += "." + refinementToken.InheritingModule.Name;
    }

    return prefix;
  }

  private int runningVerificationJobs;

  public async Task<bool> VerifySymbol(FilePosition verifiableLocation, bool actuallyVerifyTasks = true) {
    cancellationSource.Token.ThrowIfCancellationRequested();

    var compilation = await ResolvedCompilation;
    var verifiable = compilation.Program.FindNode<ICanVerify>(verifiableLocation.Uri, verifiableLocation.Position.ToDafnyPosition());
    if (verifiable == null) {
      return false;
    }

    if (compilation.ResolutionDiagnostics.Values.SelectMany(x => x).Any(d =>
          d.Level == ErrorLevel.Error &&
          d.Source != MessageSource.Compiler &&
          d.Source != MessageSource.Verifier)) {
      throw new TaskCanceledException();
    }

    var containingModule = verifiable.ContainingModule;

    IncrementJobs();

    IReadOnlyDictionary<FilePosition, IReadOnlyList<IImplementationTask>> tasksForModule;
    try {
      tasksForModule = await compilation.TranslatedModules.GetOrAdd(containingModule, async m => {
        var result = await verifier.GetVerificationTasksAsync(boogieEngine, compilation, containingModule,
          cancellationSource.Token);
        compilation.ResolutionDiagnostics = ((DiagnosticErrorReporter)compilation.Program.Reporter).AllDiagnosticsCopy;
        compilationUpdates.OnNext(compilation);
        foreach (var task in result) {
          cancellationSource.Token.Register(task.Cancel);
        }

        return result.GroupBy(t => ((IToken)t.Implementation.tok).GetFilePosition()).ToDictionary(
          g => g.Key,
          g => (IReadOnlyList<IImplementationTask>)g.ToList());
      });
    } catch (Exception e) {
      verificationCompleted.TrySetException(e);
      compilationUpdates.OnError(e);
      throw;
    }

    var updated = false;
    var implementations = compilation.ImplementationsPerVerifiable.GetOrAdd(verifiable, _ => {
      var tasksForVerifiable =
        tasksForModule.GetValueOrDefault(verifiable.NameToken.GetFilePosition()) ?? new List<IImplementationTask>(0);

      verificationProgressReporter.ReportImplementationsBeforeVerification(compilation,
        verifiable, tasksForVerifiable.Select(t => t.Implementation).ToArray());

      verificationProgressReporter.ReportRealtimeDiagnostics(compilation, verifiable.Tok.Uri, true);

      updated = true;
      return tasksForVerifiable.ToDictionary(
        t => GetImplementationName(t.Implementation),
        t => new ImplementationView(t, PublishedVerificationStatus.Stale, Array.Empty<DafnyDiagnostic>()));
    });
    if (updated) {
      compilationUpdates.OnNext(compilation);
    }

    if (actuallyVerifyTasks) {
      var tasks = implementations.Values.Select(t => t.Task).ToList();

      foreach (var task in tasks) {
        var statusUpdates = task.TryRun();
        if (statusUpdates == null) {
          if (task.CacheStatus is Completed completedCache) {
            foreach (var result in completedCache.Result.VCResults) {
              verificationProgressReporter.ReportVerifyImplementationRunning(compilation, task.Implementation);
              verificationProgressReporter.ReportAssertionBatchResult(compilation,
                new AssertionBatchResult(task.Implementation, result));
            }

            verificationProgressReporter.ReportEndVerifyImplementation(compilation, task.Implementation,
              completedCache.Result);
          }

          StatusUpdateHandlerFinally();
          return false;
        }

        var incrementedJobs = Interlocked.Increment(ref runningVerificationJobs);
        logger.LogDebug($"Incremented jobs for task, remaining jobs {incrementedJobs}, {compilation.Uri} version {compilation.Version}");

        statusUpdates.ObserveOn(verificationUpdateScheduler).Subscribe(
          update => {
            try {
              HandleStatusUpdate(compilation, verifiable, task, update);
            } catch (Exception e) {
              logger.LogError(e, "Caught exception in statusUpdates OnNext.");
            }
          },
          e => {
            if (e is not OperationCanceledException) {
              logger.LogError(e, $"Caught error in statusUpdates observable.");
            }

            StatusUpdateHandlerFinally();
          },
          StatusUpdateHandlerFinally
        );
      }

      void StatusUpdateHandlerFinally() {
        try {
          var remainingJobs = Interlocked.Decrement(ref runningVerificationJobs);
          logger.LogDebug(
            $"StatusUpdateHandlerFinally called, remaining jobs {remainingJobs}, {compilation.Uri} version {compilation.Version}, " +
            $"startingCompilation.version {startingCompilation.Version}.");
          if (remainingJobs == 0) {
            FinishedNotifications(compilation, verifiable);
          }
        } catch (Exception e) {
          logger.LogCritical(e, "Caught exception while handling finally code of statusUpdates handler.");
        }
      }
    }

    DecrementJobs();
    return true;
  }

  public void IncrementJobs() {
    MarkVerificationStarted();
    var verifyTaskIncrementedJobs = Interlocked.Increment(ref runningVerificationJobs);
    logger.LogDebug($"Incremented jobs for verifyTask, remaining jobs {verifyTaskIncrementedJobs}, {startingCompilation.Uri} version {startingCompilation.Version}");
  }

  public void DecrementJobs() {
    var remainingJobs = Interlocked.Decrement(ref runningVerificationJobs);
    logger.LogDebug($"Decremented jobs, remaining jobs {remainingJobs}, {startingCompilation.Uri} version {startingCompilation.Version}");
    if (remainingJobs == 0) {
      logger.LogDebug($"Calling MarkVerificationFinished because there are no remaining verification jobs for {startingCompilation.Uri}, version {startingCompilation.Version}.");
      MarkVerificationFinished();
    }
  }

  private void FinishedNotifications(CompilationAfterResolution compilation, ICanVerify canVerify) {
    if (ReportGutterStatus) {
      if (!cancellationSource.IsCancellationRequested) {
        // All unvisited trees need to set them as "verified"
        verificationProgressReporter.SetAllUnvisitedMethodsAsVerified(compilation, canVerify);
      }

      verificationProgressReporter.ReportRealtimeDiagnostics(compilation, canVerify.Tok.Uri, true);
    }

    MarkVerificationFinished();
  }

  private void HandleStatusUpdate(CompilationAfterResolution compilation, ICanVerify verifiable, IImplementationTask implementationTask, IVerificationStatus boogieStatus) {
    var status = StatusFromBoogieStatus(boogieStatus);

    var tokenString = implementationTask.Implementation.tok.TokenToString(options);
    var implementations = compilation.ImplementationsPerVerifiable[verifiable];

    var implementationName = GetImplementationName(implementationTask.Implementation);
    logger.LogDebug($"Received status {boogieStatus} for {tokenString}, version {compilation.Version}");
    if (boogieStatus is Running) {
      verificationProgressReporter.ReportVerifyImplementationRunning(compilation, implementationTask.Implementation);
    }

    DafnyDiagnostic[] newDiagnostics;
    if (boogieStatus is BatchCompleted batchCompleted) {
      verificationProgressReporter.ReportAssertionBatchResult(compilation,
        new AssertionBatchResult(implementationTask.Implementation, batchCompleted.VcResult));

      foreach (var counterExample in batchCompleted.VcResult.counterExamples) {
        compilation.Counterexamples.Add(counterExample);
      }

      newDiagnostics = GetDiagnosticsFromResult(compilation, implementationTask, batchCompleted.VcResult).ToArray();
    } else {
      newDiagnostics = Array.Empty<DafnyDiagnostic>();
    }

    var view = implementations.TryGetValue(implementationName, out var taskAndView)
      ? taskAndView
      : new ImplementationView(implementationTask, status, Array.Empty<DafnyDiagnostic>());
    implementations[implementationName] = view with { Status = status, Diagnostics = view.Diagnostics.Concat(newDiagnostics).ToArray() };

    if (boogieStatus is Completed completed) {
      var verificationResult = completed.Result;
      // Sometimes, the boogie status is set as Completed
      // but the assertion batches were not reported yet.
      // because they are on a different thread.
      // This loop will ensure that every vc result has been dealt with
      // before we report that the verification of the implementation is finished 
      foreach (var result in completed.Result.VCResults) {
        logger.LogDebug($"Possibly duplicate reporting assertion batch {result.vcNum} as completed in {tokenString}, version {compilation.Version}");
        verificationProgressReporter.ReportAssertionBatchResult(compilation,
          new AssertionBatchResult(implementationTask.Implementation, result));
      }
      verificationProgressReporter.ReportEndVerifyImplementation(compilation, implementationTask.Implementation, verificationResult);
    }
    compilationUpdates.OnNext(compilation);
  }

  private bool ReportGutterStatus => options.Get(ServerCommand.LineVerificationStatus);

  private List<DafnyDiagnostic> GetDiagnosticsFromResult(CompilationAfterResolution compilation, IImplementationTask task, VCResult result) {
    var errorReporter = new DiagnosticErrorReporter(options, compilation.Uri.ToUri());
    var outcome = GetOutcome(result.outcome);
    foreach (var counterExample in result.counterExamples) {
      errorReporter.ReportBoogieError(counterExample.CreateErrorInformation(outcome, options.ForceBplErrors));
    }

    var implementation = task.Implementation;
    boogieEngine.ReportOutcome(null, outcome, outcomeError => errorReporter.ReportBoogieError(outcomeError),
      implementation.VerboseName, implementation.tok, null, TextWriter.Null,
      implementation.GetTimeLimit(options), result.counterExamples);

    var diagnostics = errorReporter.AllDiagnosticsCopy.Values.SelectMany(x => x);
    return diagnostics.OrderBy(d => d.Token.GetLspPosition()).ToList();
  }

  private ConditionGeneration.Outcome GetOutcome(ProverInterface.Outcome outcome) {
    switch (outcome) {
      case ProverInterface.Outcome.Valid:
        return ConditionGeneration.Outcome.Correct;
      case ProverInterface.Outcome.Invalid:
        return ConditionGeneration.Outcome.Errors;
      case ProverInterface.Outcome.TimeOut:
        return ConditionGeneration.Outcome.TimedOut;
      case ProverInterface.Outcome.OutOfMemory:
        return ConditionGeneration.Outcome.OutOfMemory;
      case ProverInterface.Outcome.OutOfResource:
        return ConditionGeneration.Outcome.OutOfResource;
      case ProverInterface.Outcome.Undetermined:
        return ConditionGeneration.Outcome.Inconclusive;
      case ProverInterface.Outcome.Bounded:
        return ConditionGeneration.Outcome.ReachedBound;
      default:
        throw new ArgumentOutOfRangeException(nameof(outcome), outcome, null);
    }
  }

  private static PublishedVerificationStatus StatusFromBoogieStatus(IVerificationStatus verificationStatus) {
    switch (verificationStatus) {
      case Stale:
        return PublishedVerificationStatus.Stale;
      case Queued:
        return PublishedVerificationStatus.Queued;
      case Running:
      case BatchCompleted:
        return PublishedVerificationStatus.Running;
      case Completed completed:
        return completed.Result.Outcome == ConditionGeneration.Outcome.Correct
          ? PublishedVerificationStatus.Correct
          : PublishedVerificationStatus.Error;
      default:
        throw new ArgumentOutOfRangeException();
    }
  }

  public void CancelPendingUpdates() {
    cancellationSource.Cancel();
  }

  private void MarkVerificationStarted() {
    logger.LogDebug($"MarkVerificationStarted called for {startingCompilation.Uri} version {startingCompilation.Version}");
    if (verificationCompleted.Task.IsCompleted) {
      verificationCompleted = new TaskCompletionSource();
    }
  }

  private void MarkVerificationFinished() {
    logger.LogDebug($"MarkVerificationFinished called for {startingCompilation.Uri} version {startingCompilation.Version}");
    verificationCompleted.TrySetResult();
  }

  public Task<CompilationAfterParsing> LastDocument {
    get {
      logger.LogDebug($"LastDocument {startingCompilation.Uri} will return document version {startingCompilation.Version}");
      return ResolvedCompilation.ContinueWith(
        t => {
          if (t.IsCompletedSuccessfully) {
#pragma warning disable VSTHRD103
            return verificationCompleted.Task.ContinueWith(
              verificationCompletedTask => {
                logger.LogDebug(
                  $"LastDocument returning translated compilation {startingCompilation.Uri} with status {verificationCompletedTask.Status}");
                return Task.FromResult<CompilationAfterParsing>(t.Result);
              }, TaskScheduler.Current).Unwrap();
#pragma warning restore VSTHRD103
          }

          return ParsedCompilation;
        }, TaskScheduler.Current).Unwrap();
    }
  }

  public async Task<TextEditContainer?> GetTextEditToFormatCode(Uri uri) {
    // TODO https://github.com/dafny-lang/dafny/issues/3416
    var parsedDocument = await ParsedCompilation;
    if (parsedDocument.GetDiagnostics(uri).Any(diagnostic =>
          diagnostic.Level == ErrorLevel.Error &&
          diagnostic.Source == MessageSource.Parser
        )) {
      return null;
    }

    var firstToken = parsedDocument.Program.GetFirstTopLevelToken();
    if (firstToken == null) {
      return null;
    }
    var result = Formatting.__default.ReindentProgramFromFirstToken(firstToken,
      IndentationFormatter.ForProgram(parsedDocument.Program));

    var lastToken = firstToken;
    while (lastToken.Next != null) {
      lastToken = lastToken.Next;
    }
    // TODO: https://github.com/dafny-lang/dafny/issues/3415
    return new TextEditContainer(new TextEdit[] {
      // TODO end position doesn't take into account trailing trivia
      new() {NewText = result, Range = new Range(new Position(0,0), lastToken.GetLspPosition())}
    });

  }
}
