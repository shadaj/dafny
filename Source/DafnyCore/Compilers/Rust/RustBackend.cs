using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Microsoft.Dafny.Compilers;

public class RustBackend : DafnyExecutableBackend {

  public override IReadOnlySet<string> SupportedExtensions => new HashSet<string> { ".rs" };
  public override string TargetName => "Rust";
  public override bool IsStable => false;
  public override string TargetExtension => "rs";
  public override int TargetIndentSize => 4;
  public override bool SupportsInMemoryCompilation => false;
  public override bool TextualTargetIsExecutable => false;

  public override string TargetBasename(string dafnyProgramName) =>
    Regex.Replace(base.TargetBasename(dafnyProgramName), "[^_A-Za-z0-9]", "_");

  public override string TargetBaseDir(string dafnyProgramName) =>
    $"{Path.GetFileNameWithoutExtension(dafnyProgramName)}-rust";

  protected override DafnyWrittenCompiler CreateDafnyWrittenCompiler() {
    return new RustCompiler();
  }

  private string ComputeExeName(string targetFilename) {
    return Path.ChangeExtension(Path.GetFullPath(targetFilename), "exe");
  }

  public override bool CompileTargetProgram(string dafnyProgramName, string targetProgramText,
      string /*?*/ callToMain, string /*?*/ targetFilename, ReadOnlyCollection<string> otherFileNames,
      bool runAfterCompile, TextWriter outputWriter, out object compilationResult) {
    var targetDirectory = Path.GetDirectoryName(targetFilename);
    var depsDirectory = Path.Combine(targetDirectory, "deps");
    if (Directory.Exists(depsDirectory)) {
      Directory.Delete(depsDirectory, true);
    }
    Directory.CreateDirectory(depsDirectory);

    var assembly = System.Reflection.Assembly.Load("DafnyPipeline");
    assembly.GetManifestResourceNames().Where(f => f.EndsWith(".rlib")).ToList().ForEach(f => {
      var stream = assembly.GetManifestResourceStream(f);
      using var outFile = new FileStream(Path.Combine(depsDirectory, f.Replace("DafnyPipeline.", "")), FileMode.Create, FileAccess.Write);
      stream.CopyTo(outFile);
    });

    compilationResult = null;
    var args = new List<string> {
      "-L", depsDirectory,
      "-o", ComputeExeName(targetFilename),
      targetFilename
    };

    if (callToMain == null) {
      args.Add("--crate-type=lib");
    }

    var psi = PrepareProcessStartInfo("rustc", args);
    return 0 == RunProcess(psi, outputWriter, outputWriter, "Error while compiling Rust files.");
  }

  public override bool RunTargetProgram(string dafnyProgramName, string targetProgramText, string /*?*/ callToMain,
    string targetFilename, ReadOnlyCollection<string> otherFileNames, object compilationResult, TextWriter outputWriter, TextWriter errorWriter) {
    Contract.Requires(targetFilename != null || otherFileNames.Count == 0);
    var psi = PrepareProcessStartInfo(ComputeExeName(targetFilename), Options.MainArgs);
    return 0 == RunProcess(psi, outputWriter, errorWriter);
  }

  public RustBackend(DafnyOptions options) : base(options) {
  }
}