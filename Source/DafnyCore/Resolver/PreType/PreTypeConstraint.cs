//-----------------------------------------------------------------------------
//
// Copyright by the contributors to the Dafny Project
// SPDX-License-Identifier: MIT
//
//-----------------------------------------------------------------------------

using System;
using System.Diagnostics.Contracts;

namespace Microsoft.Dafny {
  abstract class PreTypeConstraint {
    public readonly IToken tok;

    // exactly one of "errorFormatString" and "errorFormatStringProducer" is non-null
    private readonly string errorFormatString;
    private readonly Func<string> errorFormatStringProducer;

    public string ErrorFormatString => errorFormatString ?? errorFormatStringProducer();

    public abstract string ErrorMessage();

    public PreTypeConstraint(IToken tok, string errorFormatString) {
      Contract.Requires(tok != null);
      Contract.Requires(errorFormatString != null);
      this.tok = tok;
      this.errorFormatString = errorFormatString;
    }

    public PreTypeConstraint(IToken tok, Func<string> errorFormatStringProducer) {
      Contract.Requires(tok != null);
      Contract.Requires(errorFormatStringProducer != null);
      this.tok = tok;
      this.errorFormatStringProducer = errorFormatStringProducer;
    }
  }
}
