using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace Microsoft.Dafny;

public class Formal : NonglobalVariable, ISymbol {
  public readonly bool InParam;  // true to in-parameter, false for out-parameter
  public override bool IsMutable {
    get {
      return !InParam;
    }
  }
  public readonly bool IsOld;
  public readonly Expression DefaultValue;
  public readonly bool IsNameOnly;
  public readonly bool IsOlder;
  public readonly string NameForCompilation;

  public Formal(IToken tok, string name, Type type, bool inParam, bool isGhost, Expression defaultValue,
    bool isOld = false, bool isNameOnly = false, bool isOlder = false, string nameForCompilation = null)
    : base(tok, name, type, isGhost) {
    Contract.Requires(tok != null);
    Contract.Requires(name != null);
    Contract.Requires(type != null);
    Contract.Requires(inParam || defaultValue == null);
    Contract.Requires(!isNameOnly || (inParam && !name.StartsWith("#")));
    InParam = inParam;
    IsOld = isOld;
    DefaultValue = defaultValue;
    IsNameOnly = isNameOnly;
    IsOlder = isOlder;
    NameForCompilation = nameForCompilation ?? name;
  }

  public bool HasName {
    get {
      return !Name.StartsWith("#");
    }
  }

  private string sanitizedName;
  public override string SanitizedName =>
    sanitizedName ??= SanitizeName(Name); // No unique-ification
  public override string CompileName =>
    compileName ??= SanitizeName(NameForCompilation);

  public override IEnumerable<Node> Children =>
    DefaultValue != null ? new List<Node>() { DefaultValue } : Enumerable.Empty<Node>();

  public override IEnumerable<Node> PreResolveChildren => Children;
  public DafnySymbolKind Kind => DafnySymbolKind.Variable;
}

/// <summary>
/// An ImplicitFormal is a parameter that is declared implicitly, in particular the "_k" depth parameter
/// of each extreme lemma (for use in the extreme-method body only, not the specification).
/// </summary>
public class ImplicitFormal : Formal {
  public ImplicitFormal(IToken tok, string name, Type type, bool inParam, bool isGhost)
    : base(tok, name, type, inParam, isGhost, null) {
    Contract.Requires(tok != null);
    Contract.Requires(name != null);
    Contract.Requires(type != null);
  }
}

/// <summary>
/// ThisSurrogate represents the implicit parameter "this". It is used to allow more uniform handling of
/// parameters. A pointer value of a ThisSurrogate object is not important, only the fact that it is
/// a ThisSurrogate is. ThisSurrogate objects are only used in specially marked places in the Dafny
/// implementation.
/// </summary>
public class ThisSurrogate : ImplicitFormal {
  public ThisSurrogate(IToken tok, Type type)
    : base(tok, "this", type, true, false) {
    Contract.Requires(tok != null);
    Contract.Requires(type != null);
  }
}