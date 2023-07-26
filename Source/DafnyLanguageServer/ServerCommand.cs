using System.Collections.Generic;
using System.CommandLine;
using System.CommandLine.Invocation;
using DafnyCore;
using Microsoft.Dafny.LanguageServer.Workspace;

namespace Microsoft.Dafny.LanguageServer;

public class ServerCommand : ICommandSpec {
  public static readonly ServerCommand Instance = new();

  private ServerCommand() {
  }

  static ServerCommand() {
    DafnyOptions.RegisterLegacyBinding(VerifySnapshots, (options, u) => options.VerifySnapshots = (int)u);

    DooFile.RegisterNoChecksNeeded(
      ProjectMode,
      Verification,
      GhostIndicators,
      LineVerificationStatus,
      VerifySnapshots,
      UseCaching
    );
  }

  public static readonly Option<bool> UseCaching = new("--use-caching", () => true,
    "Use caching to speed up analysis done by the Dafny IDE after each text edit.") {
    IsHidden = true
  };

  public static readonly Option<bool> GhostIndicators = new("--notify-ghostness",
    @"
(experimental, API will change)
Send notifications that indicate which lines are ghost.".TrimStart());

  public static readonly Option<VerifyOnMode> Verification = new("--verify-on", () => VerifyOnMode.Change, @"
(experimental)
Determine when to automatically verify the program. Choose from: Never, OnChange or OnSave.".TrimStart()) {
    ArgumentHelpName = "event"
  };

  public static readonly Option<bool> LineVerificationStatus = new("--notify-line-verification-status", @"
(experimental, API will change)
Send notifications about the verification status of each line in the program.
".TrimStart());

  public static readonly Option<bool> ProjectMode = new("--project-mode", () => false,
    "New mode with working with project files. Will become the default") {
    IsHidden = true
  };

  public static readonly Option<uint> VerifySnapshots = new("--cache-verification", @"
(experimental)
0 - do not use any verification result caching (default)
1 - use the basic verification result caching
2 - use the more advanced verification result caching
3 - use the more advanced caching and report errors according
  to the new source locations for errors and their
  related locations
".TrimStart()) {
    ArgumentHelpName = "level"
  };

  public IEnumerable<Option> Options => new Option[] {
    ProjectMode,
    BoogieOptionBag.NoVerify,
    Verification,
    GhostIndicators,
    LineVerificationStatus,
    VerifySnapshots,
    UseCaching,
    DeveloperOptionBag.BoogiePrint,
    CommonOptionBag.EnforceDeterminism,
    CommonOptionBag.UseJavadocLikeDocstringRewriterOption
  }.Concat(ICommandSpec.VerificationOptions).
    Concat(ICommandSpec.ResolverOptions);

  public Command Create() {
    return new Command("server", "Start the Dafny language server");
  }

  public void PostProcess(DafnyOptions dafnyOptions, Options options, InvocationContext context) {
    ConfigureDafnyOptionsForServer(dafnyOptions);
  }

  public static void ConfigureDafnyOptionsForServer(DafnyOptions dafnyOptions) {
    dafnyOptions.RunLanguageServer = true;
    dafnyOptions.Set(DafnyConsolePrinter.ShowSnippets, true);

    dafnyOptions.PrintIncludesMode = DafnyOptions.IncludesModes.None;

    // TODO This may be subject to change. See Microsoft.Boogie.Counterexample
    //      A dash means write to the textwriter instead of a file.
    // https://github.com/boogie-org/boogie/blob/b03dd2e4d5170757006eef94cbb07739ba50dddb/Source/VCGeneration/Couterexample.cs#L217
    dafnyOptions.ModelViewFile = "-";

    dafnyOptions.ProverOptions.AddRange(new List<string>()
    {
      "O:model_compress=false", // Replaced by "O:model.compact=false" if z3's version is > 4.8.6
      "O:model.completion=true",
      "O:model_evaluator.completion=true"
    });
  }
}
