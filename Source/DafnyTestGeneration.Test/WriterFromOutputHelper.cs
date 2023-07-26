// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT

#nullable disable
using System.IO;
using System.Text;
using Xunit.Abstractions;

namespace DafnyTestGeneration.Test;

public class WriterFromOutputHelper : TextWriter {
  private readonly ITestOutputHelper output;
  private bool failed;

  public WriterFromOutputHelper(ITestOutputHelper output) {
    this.output = output;
  }

  public override void Write(char value) {
    if (!failed) {
      failed = true;
      WriteLine("Error: tried to write a single character, which WriterFromOutputHelper does not support.");
    }
  }

  public override Encoding Encoding => Encoding.Default;

  public override void WriteLine(string value) {
    output.WriteLine(value);
  }

  public override void WriteLine(string format, params object[] arg) {
    output.WriteLine(format, arg);
  }
}