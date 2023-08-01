// Dafny program Dafny-compiler-rust.dfy compiled into C#
// To recompile, you will need the libraries
//     System.Runtime.Numerics.dll System.Collections.Immutable.dll
// but the 'dotnet' tool in net6.0 should pick those up automatically.
// Optionally, you may want to include compiler switches like
//     /debug /nowarn:162,164,168,183,219,436,1717,1718

using System;
using System.Numerics;
using System.Collections;
namespace DAST {


  public interface _IModule {
    bool is_Module { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IModuleItem> dtor_body { get; }
    _IModule DowncastClone();
  }
  public class Module : _IModule {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IModuleItem> _body;
    public Module(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IModuleItem> body) {
      this._name = name;
      this._body = body;
    }
    public _IModule DowncastClone() {
      if (this is _IModule dt) { return dt; }
      return new Module(_name, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Module;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Module.Module";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly DAST._IModule theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IModuleItem>.Empty);
    public static DAST._IModule Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IModule> _TYPE = new Dafny.TypeDescriptor<DAST._IModule>(DAST.Module.Default());
    public static Dafny.TypeDescriptor<DAST._IModule> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IModule create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IModuleItem> body) {
      return new Module(name, body);
    }
    public static _IModule create_Module(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IModuleItem> body) {
      return create(name, body);
    }
    public bool is_Module { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<DAST._IModuleItem> dtor_body {
      get {
        return this._body;
      }
    }
  }

  public interface _IModuleItem {
    bool is_Module { get; }
    bool is_Class { get; }
    bool is_Trait { get; }
    bool is_Newtype { get; }
    bool is_Datatype { get; }
    DAST._IModule dtor_Module_a0 { get; }
    DAST._IClass dtor_Class_a0 { get; }
    DAST._ITrait dtor_Trait_a0 { get; }
    DAST._INewtype dtor_Newtype_a0 { get; }
    DAST._IDatatype dtor_Datatype_a0 { get; }
    _IModuleItem DowncastClone();
  }
  public abstract class ModuleItem : _IModuleItem {
    public ModuleItem() {
    }
    private static readonly DAST._IModuleItem theDefault = create_Module(DAST.Module.Default());
    public static DAST._IModuleItem Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IModuleItem> _TYPE = new Dafny.TypeDescriptor<DAST._IModuleItem>(DAST.ModuleItem.Default());
    public static Dafny.TypeDescriptor<DAST._IModuleItem> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IModuleItem create_Module(DAST._IModule _a0) {
      return new ModuleItem_Module(_a0);
    }
    public static _IModuleItem create_Class(DAST._IClass _a0) {
      return new ModuleItem_Class(_a0);
    }
    public static _IModuleItem create_Trait(DAST._ITrait _a0) {
      return new ModuleItem_Trait(_a0);
    }
    public static _IModuleItem create_Newtype(DAST._INewtype _a0) {
      return new ModuleItem_Newtype(_a0);
    }
    public static _IModuleItem create_Datatype(DAST._IDatatype _a0) {
      return new ModuleItem_Datatype(_a0);
    }
    public bool is_Module { get { return this is ModuleItem_Module; } }
    public bool is_Class { get { return this is ModuleItem_Class; } }
    public bool is_Trait { get { return this is ModuleItem_Trait; } }
    public bool is_Newtype { get { return this is ModuleItem_Newtype; } }
    public bool is_Datatype { get { return this is ModuleItem_Datatype; } }
    public DAST._IModule dtor_Module_a0 {
      get {
        var d = this;
        return ((ModuleItem_Module)d)._a0;
      }
    }
    public DAST._IClass dtor_Class_a0 {
      get {
        var d = this;
        return ((ModuleItem_Class)d)._a0;
      }
    }
    public DAST._ITrait dtor_Trait_a0 {
      get {
        var d = this;
        return ((ModuleItem_Trait)d)._a0;
      }
    }
    public DAST._INewtype dtor_Newtype_a0 {
      get {
        var d = this;
        return ((ModuleItem_Newtype)d)._a0;
      }
    }
    public DAST._IDatatype dtor_Datatype_a0 {
      get {
        var d = this;
        return ((ModuleItem_Datatype)d)._a0;
      }
    }
    public abstract _IModuleItem DowncastClone();
  }
  public class ModuleItem_Module : ModuleItem {
    public readonly DAST._IModule _a0;
    public ModuleItem_Module(DAST._IModule _a0) : base() {
      this._a0 = _a0;
    }
    public override _IModuleItem DowncastClone() {
      if (this is _IModuleItem dt) { return dt; }
      return new ModuleItem_Module(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ModuleItem_Module;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ModuleItem.Module";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class ModuleItem_Class : ModuleItem {
    public readonly DAST._IClass _a0;
    public ModuleItem_Class(DAST._IClass _a0) : base() {
      this._a0 = _a0;
    }
    public override _IModuleItem DowncastClone() {
      if (this is _IModuleItem dt) { return dt; }
      return new ModuleItem_Class(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ModuleItem_Class;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ModuleItem.Class";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class ModuleItem_Trait : ModuleItem {
    public readonly DAST._ITrait _a0;
    public ModuleItem_Trait(DAST._ITrait _a0) : base() {
      this._a0 = _a0;
    }
    public override _IModuleItem DowncastClone() {
      if (this is _IModuleItem dt) { return dt; }
      return new ModuleItem_Trait(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ModuleItem_Trait;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ModuleItem.Trait";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class ModuleItem_Newtype : ModuleItem {
    public readonly DAST._INewtype _a0;
    public ModuleItem_Newtype(DAST._INewtype _a0) : base() {
      this._a0 = _a0;
    }
    public override _IModuleItem DowncastClone() {
      if (this is _IModuleItem dt) { return dt; }
      return new ModuleItem_Newtype(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ModuleItem_Newtype;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ModuleItem.Newtype";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class ModuleItem_Datatype : ModuleItem {
    public readonly DAST._IDatatype _a0;
    public ModuleItem_Datatype(DAST._IDatatype _a0) : base() {
      this._a0 = _a0;
    }
    public override _IModuleItem DowncastClone() {
      if (this is _IModuleItem dt) { return dt; }
      return new ModuleItem_Datatype(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ModuleItem_Datatype;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ModuleItem.Datatype";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }

  public interface _INewtype {
    bool is_Newtype { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    DAST._IType dtor_base { get; }
    DAST._IOptional<DAST._IExpression> dtor_witnessExpr { get; }
    _INewtype DowncastClone();
  }
  public class Newtype : _INewtype {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly DAST._IType _base;
    public readonly DAST._IOptional<DAST._IExpression> _witnessExpr;
    public Newtype(Dafny.ISequence<Dafny.Rune> name, DAST._IType @base, DAST._IOptional<DAST._IExpression> witnessExpr) {
      this._name = name;
      this._base = @base;
      this._witnessExpr = witnessExpr;
    }
    public _INewtype DowncastClone() {
      if (this is _INewtype dt) { return dt; }
      return new Newtype(_name, _base, _witnessExpr);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Newtype;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._base, oth._base) && object.Equals(this._witnessExpr, oth._witnessExpr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._base));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._witnessExpr));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Newtype.Newtype";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._base);
      s += ", ";
      s += Dafny.Helpers.ToString(this._witnessExpr);
      s += ")";
      return s;
    }
    private static readonly DAST._INewtype theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, DAST.Type.Default(), DAST.Optional<DAST._IExpression>.Default());
    public static DAST._INewtype Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._INewtype> _TYPE = new Dafny.TypeDescriptor<DAST._INewtype>(DAST.Newtype.Default());
    public static Dafny.TypeDescriptor<DAST._INewtype> _TypeDescriptor() {
      return _TYPE;
    }
    public static _INewtype create(Dafny.ISequence<Dafny.Rune> name, DAST._IType @base, DAST._IOptional<DAST._IExpression> witnessExpr) {
      return new Newtype(name, @base, witnessExpr);
    }
    public static _INewtype create_Newtype(Dafny.ISequence<Dafny.Rune> name, DAST._IType @base, DAST._IOptional<DAST._IExpression> witnessExpr) {
      return create(name, @base, witnessExpr);
    }
    public bool is_Newtype { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public DAST._IType dtor_base {
      get {
        return this._base;
      }
    }
    public DAST._IOptional<DAST._IExpression> dtor_witnessExpr {
      get {
        return this._witnessExpr;
      }
    }
  }

  public interface _IType {
    bool is_Path { get; }
    bool is_Tuple { get; }
    bool is_Array { get; }
    bool is_Seq { get; }
    bool is_Set { get; }
    bool is_Multiset { get; }
    bool is_Map { get; }
    bool is_Arrow { get; }
    bool is_Primitive { get; }
    bool is_Passthrough { get; }
    bool is_TypeArg { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Path_a0 { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    DAST._IResolvedType dtor_resolved { get; }
    Dafny.ISequence<DAST._IType> dtor_Tuple_a0 { get; }
    DAST._IType dtor_element { get; }
    DAST._IType dtor_key { get; }
    DAST._IType dtor_value { get; }
    Dafny.ISequence<DAST._IType> dtor_args { get; }
    DAST._IType dtor_result { get; }
    DAST._IPrimitive dtor_Primitive_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_TypeArg_a0 { get; }
    _IType DowncastClone();
  }
  public abstract class Type : _IType {
    public Type() {
    }
    private static readonly DAST._IType theDefault = create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty, Dafny.Sequence<DAST._IType>.Empty, DAST.ResolvedType.Default());
    public static DAST._IType Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IType> _TYPE = new Dafny.TypeDescriptor<DAST._IType>(DAST.Type.Default());
    public static Dafny.TypeDescriptor<DAST._IType> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IType create_Path(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0, Dafny.ISequence<DAST._IType> typeArgs, DAST._IResolvedType resolved) {
      return new Type_Path(_a0, typeArgs, resolved);
    }
    public static _IType create_Tuple(Dafny.ISequence<DAST._IType> _a0) {
      return new Type_Tuple(_a0);
    }
    public static _IType create_Array(DAST._IType element) {
      return new Type_Array(element);
    }
    public static _IType create_Seq(DAST._IType element) {
      return new Type_Seq(element);
    }
    public static _IType create_Set(DAST._IType element) {
      return new Type_Set(element);
    }
    public static _IType create_Multiset(DAST._IType element) {
      return new Type_Multiset(element);
    }
    public static _IType create_Map(DAST._IType key, DAST._IType @value) {
      return new Type_Map(key, @value);
    }
    public static _IType create_Arrow(Dafny.ISequence<DAST._IType> args, DAST._IType result) {
      return new Type_Arrow(args, result);
    }
    public static _IType create_Primitive(DAST._IPrimitive _a0) {
      return new Type_Primitive(_a0);
    }
    public static _IType create_Passthrough(Dafny.ISequence<Dafny.Rune> _a0) {
      return new Type_Passthrough(_a0);
    }
    public static _IType create_TypeArg(Dafny.ISequence<Dafny.Rune> _a0) {
      return new Type_TypeArg(_a0);
    }
    public bool is_Path { get { return this is Type_Path; } }
    public bool is_Tuple { get { return this is Type_Tuple; } }
    public bool is_Array { get { return this is Type_Array; } }
    public bool is_Seq { get { return this is Type_Seq; } }
    public bool is_Set { get { return this is Type_Set; } }
    public bool is_Multiset { get { return this is Type_Multiset; } }
    public bool is_Map { get { return this is Type_Map; } }
    public bool is_Arrow { get { return this is Type_Arrow; } }
    public bool is_Primitive { get { return this is Type_Primitive; } }
    public bool is_Passthrough { get { return this is Type_Passthrough; } }
    public bool is_TypeArg { get { return this is Type_TypeArg; } }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Path_a0 {
      get {
        var d = this;
        return ((Type_Path)d)._a0;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_typeArgs {
      get {
        var d = this;
        return ((Type_Path)d)._typeArgs;
      }
    }
    public DAST._IResolvedType dtor_resolved {
      get {
        var d = this;
        return ((Type_Path)d)._resolved;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_Tuple_a0 {
      get {
        var d = this;
        return ((Type_Tuple)d)._a0;
      }
    }
    public DAST._IType dtor_element {
      get {
        var d = this;
        if (d is Type_Array) { return ((Type_Array)d)._element; }
        if (d is Type_Seq) { return ((Type_Seq)d)._element; }
        if (d is Type_Set) { return ((Type_Set)d)._element; }
        return ((Type_Multiset)d)._element;
      }
    }
    public DAST._IType dtor_key {
      get {
        var d = this;
        return ((Type_Map)d)._key;
      }
    }
    public DAST._IType dtor_value {
      get {
        var d = this;
        return ((Type_Map)d)._value;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_args {
      get {
        var d = this;
        return ((Type_Arrow)d)._args;
      }
    }
    public DAST._IType dtor_result {
      get {
        var d = this;
        return ((Type_Arrow)d)._result;
      }
    }
    public DAST._IPrimitive dtor_Primitive_a0 {
      get {
        var d = this;
        return ((Type_Primitive)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0 {
      get {
        var d = this;
        return ((Type_Passthrough)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_TypeArg_a0 {
      get {
        var d = this;
        return ((Type_TypeArg)d)._a0;
      }
    }
    public abstract _IType DowncastClone();
  }
  public class Type_Path : Type {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0;
    public readonly Dafny.ISequence<DAST._IType> _typeArgs;
    public readonly DAST._IResolvedType _resolved;
    public Type_Path(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0, Dafny.ISequence<DAST._IType> typeArgs, DAST._IResolvedType resolved) : base() {
      this._a0 = _a0;
      this._typeArgs = typeArgs;
      this._resolved = resolved;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Path(_a0, _typeArgs, _resolved);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Path;
      return oth != null && object.Equals(this._a0, oth._a0) && object.Equals(this._typeArgs, oth._typeArgs) && object.Equals(this._resolved, oth._resolved);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._resolved));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Path";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeArgs);
      s += ", ";
      s += Dafny.Helpers.ToString(this._resolved);
      s += ")";
      return s;
    }
  }
  public class Type_Tuple : Type {
    public readonly Dafny.ISequence<DAST._IType> _a0;
    public Type_Tuple(Dafny.ISequence<DAST._IType> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Tuple(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Tuple;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Tuple";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Type_Array : Type {
    public readonly DAST._IType _element;
    public Type_Array(DAST._IType element) : base() {
      this._element = element;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Array(_element);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Array;
      return oth != null && object.Equals(this._element, oth._element);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._element));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Array";
      s += "(";
      s += Dafny.Helpers.ToString(this._element);
      s += ")";
      return s;
    }
  }
  public class Type_Seq : Type {
    public readonly DAST._IType _element;
    public Type_Seq(DAST._IType element) : base() {
      this._element = element;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Seq(_element);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Seq;
      return oth != null && object.Equals(this._element, oth._element);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._element));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Seq";
      s += "(";
      s += Dafny.Helpers.ToString(this._element);
      s += ")";
      return s;
    }
  }
  public class Type_Set : Type {
    public readonly DAST._IType _element;
    public Type_Set(DAST._IType element) : base() {
      this._element = element;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Set(_element);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Set;
      return oth != null && object.Equals(this._element, oth._element);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._element));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Set";
      s += "(";
      s += Dafny.Helpers.ToString(this._element);
      s += ")";
      return s;
    }
  }
  public class Type_Multiset : Type {
    public readonly DAST._IType _element;
    public Type_Multiset(DAST._IType element) : base() {
      this._element = element;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Multiset(_element);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Multiset;
      return oth != null && object.Equals(this._element, oth._element);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._element));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Multiset";
      s += "(";
      s += Dafny.Helpers.ToString(this._element);
      s += ")";
      return s;
    }
  }
  public class Type_Map : Type {
    public readonly DAST._IType _key;
    public readonly DAST._IType _value;
    public Type_Map(DAST._IType key, DAST._IType @value) : base() {
      this._key = key;
      this._value = @value;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Map(_key, _value);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Map;
      return oth != null && object.Equals(this._key, oth._key) && object.Equals(this._value, oth._value);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 6;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._key));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Map";
      s += "(";
      s += Dafny.Helpers.ToString(this._key);
      s += ", ";
      s += Dafny.Helpers.ToString(this._value);
      s += ")";
      return s;
    }
  }
  public class Type_Arrow : Type {
    public readonly Dafny.ISequence<DAST._IType> _args;
    public readonly DAST._IType _result;
    public Type_Arrow(Dafny.ISequence<DAST._IType> args, DAST._IType result) : base() {
      this._args = args;
      this._result = result;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Arrow(_args, _result);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Arrow;
      return oth != null && object.Equals(this._args, oth._args) && object.Equals(this._result, oth._result);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._result));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Arrow";
      s += "(";
      s += Dafny.Helpers.ToString(this._args);
      s += ", ";
      s += Dafny.Helpers.ToString(this._result);
      s += ")";
      return s;
    }
  }
  public class Type_Primitive : Type {
    public readonly DAST._IPrimitive _a0;
    public Type_Primitive(DAST._IPrimitive _a0) : base() {
      this._a0 = _a0;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Primitive(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Primitive;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Primitive";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Type_Passthrough : Type {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public Type_Passthrough(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Passthrough(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Passthrough;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 9;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Passthrough";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Type_TypeArg : Type {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public Type_TypeArg(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_TypeArg(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_TypeArg;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 10;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.TypeArg";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }

  public interface _IPrimitive {
    bool is_String { get; }
    bool is_Bool { get; }
    bool is_Char { get; }
    _IPrimitive DowncastClone();
  }
  public abstract class Primitive : _IPrimitive {
    public Primitive() {
    }
    private static readonly DAST._IPrimitive theDefault = create_String();
    public static DAST._IPrimitive Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IPrimitive> _TYPE = new Dafny.TypeDescriptor<DAST._IPrimitive>(DAST.Primitive.Default());
    public static Dafny.TypeDescriptor<DAST._IPrimitive> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IPrimitive create_String() {
      return new Primitive_String();
    }
    public static _IPrimitive create_Bool() {
      return new Primitive_Bool();
    }
    public static _IPrimitive create_Char() {
      return new Primitive_Char();
    }
    public bool is_String { get { return this is Primitive_String; } }
    public bool is_Bool { get { return this is Primitive_Bool; } }
    public bool is_Char { get { return this is Primitive_Char; } }
    public static System.Collections.Generic.IEnumerable<_IPrimitive> AllSingletonConstructors {
      get {
        yield return Primitive.create_String();
        yield return Primitive.create_Bool();
        yield return Primitive.create_Char();
      }
    }
    public abstract _IPrimitive DowncastClone();
  }
  public class Primitive_String : Primitive {
    public Primitive_String() : base() {
    }
    public override _IPrimitive DowncastClone() {
      if (this is _IPrimitive dt) { return dt; }
      return new Primitive_String();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Primitive_String;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Primitive.String";
      return s;
    }
  }
  public class Primitive_Bool : Primitive {
    public Primitive_Bool() : base() {
    }
    public override _IPrimitive DowncastClone() {
      if (this is _IPrimitive dt) { return dt; }
      return new Primitive_Bool();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Primitive_Bool;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Primitive.Bool";
      return s;
    }
  }
  public class Primitive_Char : Primitive {
    public Primitive_Char() : base() {
    }
    public override _IPrimitive DowncastClone() {
      if (this is _IPrimitive dt) { return dt; }
      return new Primitive_Char();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Primitive_Char;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Primitive.Char";
      return s;
    }
  }

  public interface _IResolvedType {
    bool is_Datatype { get; }
    bool is_Trait { get; }
    bool is_Newtype { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path { get; }
    _IResolvedType DowncastClone();
  }
  public abstract class ResolvedType : _IResolvedType {
    public ResolvedType() {
    }
    private static readonly DAST._IResolvedType theDefault = create_Datatype(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Empty);
    public static DAST._IResolvedType Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IResolvedType> _TYPE = new Dafny.TypeDescriptor<DAST._IResolvedType>(DAST.ResolvedType.Default());
    public static Dafny.TypeDescriptor<DAST._IResolvedType> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IResolvedType create_Datatype(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) {
      return new ResolvedType_Datatype(path);
    }
    public static _IResolvedType create_Trait(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) {
      return new ResolvedType_Trait(path);
    }
    public static _IResolvedType create_Newtype() {
      return new ResolvedType_Newtype();
    }
    public bool is_Datatype { get { return this is ResolvedType_Datatype; } }
    public bool is_Trait { get { return this is ResolvedType_Trait; } }
    public bool is_Newtype { get { return this is ResolvedType_Newtype; } }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path {
      get {
        var d = this;
        if (d is ResolvedType_Datatype) { return ((ResolvedType_Datatype)d)._path; }
        return ((ResolvedType_Trait)d)._path;
      }
    }
    public abstract _IResolvedType DowncastClone();
  }
  public class ResolvedType_Datatype : ResolvedType {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
    public ResolvedType_Datatype(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) : base() {
      this._path = path;
    }
    public override _IResolvedType DowncastClone() {
      if (this is _IResolvedType dt) { return dt; }
      return new ResolvedType_Datatype(_path);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ResolvedType_Datatype;
      return oth != null && object.Equals(this._path, oth._path);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._path));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ResolvedType.Datatype";
      s += "(";
      s += Dafny.Helpers.ToString(this._path);
      s += ")";
      return s;
    }
  }
  public class ResolvedType_Trait : ResolvedType {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
    public ResolvedType_Trait(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) : base() {
      this._path = path;
    }
    public override _IResolvedType DowncastClone() {
      if (this is _IResolvedType dt) { return dt; }
      return new ResolvedType_Trait(_path);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ResolvedType_Trait;
      return oth != null && object.Equals(this._path, oth._path);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._path));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ResolvedType.Trait";
      s += "(";
      s += Dafny.Helpers.ToString(this._path);
      s += ")";
      return s;
    }
  }
  public class ResolvedType_Newtype : ResolvedType {
    public ResolvedType_Newtype() : base() {
    }
    public override _IResolvedType DowncastClone() {
      if (this is _IResolvedType dt) { return dt; }
      return new ResolvedType_Newtype();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ResolvedType_Newtype;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ResolvedType.Newtype";
      return s;
    }
  }

  public interface _IIdent {
    bool is_Ident { get; }
    Dafny.ISequence<Dafny.Rune> dtor_id { get; }
  }
  public class Ident : _IIdent {
    public readonly Dafny.ISequence<Dafny.Rune> _id;
    public Ident(Dafny.ISequence<Dafny.Rune> id) {
      this._id = id;
    }
    public static Dafny.ISequence<Dafny.Rune> DowncastClone(Dafny.ISequence<Dafny.Rune> _this) {
      return _this;
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Ident;
      return oth != null && object.Equals(this._id, oth._id);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._id));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Ident.Ident";
      s += "(";
      s += this._id.ToVerbatimString(true);
      s += ")";
      return s;
    }
    private static readonly Dafny.ISequence<Dafny.Rune> theDefault = Dafny.Sequence<Dafny.Rune>.Empty;
    public static Dafny.ISequence<Dafny.Rune> Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TYPE = new Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>>(Dafny.Sequence<Dafny.Rune>.Empty);
    public static Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IIdent create(Dafny.ISequence<Dafny.Rune> id) {
      return new Ident(id);
    }
    public static _IIdent create_Ident(Dafny.ISequence<Dafny.Rune> id) {
      return create(id);
    }
    public bool is_Ident { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_id {
      get {
        return this._id;
      }
    }
  }

  public interface _IClass {
    bool is_Class { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_superClasses { get; }
    Dafny.ISequence<DAST._IClassItem> dtor_body { get; }
    _IClass DowncastClone();
  }
  public class Class : _IClass {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _superClasses;
    public readonly Dafny.ISequence<DAST._IClassItem> _body;
    public Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IClassItem> body) {
      this._name = name;
      this._superClasses = superClasses;
      this._body = body;
    }
    public _IClass DowncastClone() {
      if (this is _IClass dt) { return dt; }
      return new Class(_name, _superClasses, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Class;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._superClasses, oth._superClasses) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._superClasses));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Class.Class";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._superClasses);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly DAST._IClass theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IClassItem>.Empty);
    public static DAST._IClass Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IClass> _TYPE = new Dafny.TypeDescriptor<DAST._IClass>(DAST.Class.Default());
    public static Dafny.TypeDescriptor<DAST._IClass> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IClass create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IClassItem> body) {
      return new Class(name, superClasses, body);
    }
    public static _IClass create_Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IClassItem> body) {
      return create(name, superClasses, body);
    }
    public bool is_Class { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_superClasses {
      get {
        return this._superClasses;
      }
    }
    public Dafny.ISequence<DAST._IClassItem> dtor_body {
      get {
        return this._body;
      }
    }
  }

  public interface _ITrait {
    bool is_Trait { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IClassItem> dtor_body { get; }
    _ITrait DowncastClone();
  }
  public class Trait : _ITrait {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IClassItem> _body;
    public Trait(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IClassItem> body) {
      this._name = name;
      this._body = body;
    }
    public _ITrait DowncastClone() {
      if (this is _ITrait dt) { return dt; }
      return new Trait(_name, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Trait;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Trait.Trait";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly DAST._ITrait theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IClassItem>.Empty);
    public static DAST._ITrait Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._ITrait> _TYPE = new Dafny.TypeDescriptor<DAST._ITrait>(DAST.Trait.Default());
    public static Dafny.TypeDescriptor<DAST._ITrait> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ITrait create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IClassItem> body) {
      return new Trait(name, body);
    }
    public static _ITrait create_Trait(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IClassItem> body) {
      return create(name, body);
    }
    public bool is_Trait { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<DAST._IClassItem> dtor_body {
      get {
        return this._body;
      }
    }
  }

  public interface _IDatatype {
    bool is_Datatype { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<Dafny.Rune> dtor_enclosingModule { get; }
    Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
    Dafny.ISequence<DAST._IDatatypeCtor> dtor_ctors { get; }
    Dafny.ISequence<DAST._IClassItem> dtor_body { get; }
    bool dtor_isCo { get; }
    _IDatatype DowncastClone();
  }
  public class Datatype : _IDatatype {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<Dafny.Rune> _enclosingModule;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IDatatypeCtor> _ctors;
    public readonly Dafny.ISequence<DAST._IClassItem> _body;
    public readonly bool _isCo;
    public Datatype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IClassItem> body, bool isCo) {
      this._name = name;
      this._enclosingModule = enclosingModule;
      this._typeParams = typeParams;
      this._ctors = ctors;
      this._body = body;
      this._isCo = isCo;
    }
    public _IDatatype DowncastClone() {
      if (this is _IDatatype dt) { return dt; }
      return new Datatype(_name, _enclosingModule, _typeParams, _ctors, _body, _isCo);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Datatype;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._enclosingModule, oth._enclosingModule) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._ctors, oth._ctors) && object.Equals(this._body, oth._body) && this._isCo == oth._isCo;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._enclosingModule));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._ctors));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isCo));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Datatype.Datatype";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._enclosingModule);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._ctors);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ", ";
      s += Dafny.Helpers.ToString(this._isCo);
      s += ")";
      return s;
    }
    private static readonly DAST._IDatatype theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IDatatypeCtor>.Empty, Dafny.Sequence<DAST._IClassItem>.Empty, false);
    public static DAST._IDatatype Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IDatatype> _TYPE = new Dafny.TypeDescriptor<DAST._IDatatype>(DAST.Datatype.Default());
    public static Dafny.TypeDescriptor<DAST._IDatatype> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IDatatype create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IClassItem> body, bool isCo) {
      return new Datatype(name, enclosingModule, typeParams, ctors, body, isCo);
    }
    public static _IDatatype create_Datatype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IClassItem> body, bool isCo) {
      return create(name, enclosingModule, typeParams, ctors, body, isCo);
    }
    public bool is_Datatype { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_enclosingModule {
      get {
        return this._enclosingModule;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public Dafny.ISequence<DAST._IDatatypeCtor> dtor_ctors {
      get {
        return this._ctors;
      }
    }
    public Dafny.ISequence<DAST._IClassItem> dtor_body {
      get {
        return this._body;
      }
    }
    public bool dtor_isCo {
      get {
        return this._isCo;
      }
    }
  }

  public interface _IDatatypeCtor {
    bool is_DatatypeCtor { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IFormal> dtor_args { get; }
    bool dtor_hasAnyArgs { get; }
    _IDatatypeCtor DowncastClone();
  }
  public class DatatypeCtor : _IDatatypeCtor {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IFormal> _args;
    public readonly bool _hasAnyArgs;
    public DatatypeCtor(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IFormal> args, bool hasAnyArgs) {
      this._name = name;
      this._args = args;
      this._hasAnyArgs = hasAnyArgs;
    }
    public _IDatatypeCtor DowncastClone() {
      if (this is _IDatatypeCtor dt) { return dt; }
      return new DatatypeCtor(_name, _args, _hasAnyArgs);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.DatatypeCtor;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._args, oth._args) && this._hasAnyArgs == oth._hasAnyArgs;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._hasAnyArgs));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.DatatypeCtor.DatatypeCtor";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._args);
      s += ", ";
      s += Dafny.Helpers.ToString(this._hasAnyArgs);
      s += ")";
      return s;
    }
    private static readonly DAST._IDatatypeCtor theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IFormal>.Empty, false);
    public static DAST._IDatatypeCtor Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IDatatypeCtor> _TYPE = new Dafny.TypeDescriptor<DAST._IDatatypeCtor>(DAST.DatatypeCtor.Default());
    public static Dafny.TypeDescriptor<DAST._IDatatypeCtor> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IDatatypeCtor create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IFormal> args, bool hasAnyArgs) {
      return new DatatypeCtor(name, args, hasAnyArgs);
    }
    public static _IDatatypeCtor create_DatatypeCtor(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IFormal> args, bool hasAnyArgs) {
      return create(name, args, hasAnyArgs);
    }
    public bool is_DatatypeCtor { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<DAST._IFormal> dtor_args {
      get {
        return this._args;
      }
    }
    public bool dtor_hasAnyArgs {
      get {
        return this._hasAnyArgs;
      }
    }
  }

  public interface _IClassItem {
    bool is_Method { get; }
    bool is_Field { get; }
    DAST._IMethod dtor_Method_a0 { get; }
    DAST._IFormal dtor_Field_a0 { get; }
    _IClassItem DowncastClone();
  }
  public abstract class ClassItem : _IClassItem {
    public ClassItem() {
    }
    private static readonly DAST._IClassItem theDefault = create_Method(DAST.Method.Default());
    public static DAST._IClassItem Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IClassItem> _TYPE = new Dafny.TypeDescriptor<DAST._IClassItem>(DAST.ClassItem.Default());
    public static Dafny.TypeDescriptor<DAST._IClassItem> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IClassItem create_Method(DAST._IMethod _a0) {
      return new ClassItem_Method(_a0);
    }
    public static _IClassItem create_Field(DAST._IFormal _a0) {
      return new ClassItem_Field(_a0);
    }
    public bool is_Method { get { return this is ClassItem_Method; } }
    public bool is_Field { get { return this is ClassItem_Field; } }
    public DAST._IMethod dtor_Method_a0 {
      get {
        var d = this;
        return ((ClassItem_Method)d)._a0;
      }
    }
    public DAST._IFormal dtor_Field_a0 {
      get {
        var d = this;
        return ((ClassItem_Field)d)._a0;
      }
    }
    public abstract _IClassItem DowncastClone();
  }
  public class ClassItem_Method : ClassItem {
    public readonly DAST._IMethod _a0;
    public ClassItem_Method(DAST._IMethod _a0) : base() {
      this._a0 = _a0;
    }
    public override _IClassItem DowncastClone() {
      if (this is _IClassItem dt) { return dt; }
      return new ClassItem_Method(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ClassItem_Method;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ClassItem.Method";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class ClassItem_Field : ClassItem {
    public readonly DAST._IFormal _a0;
    public ClassItem_Field(DAST._IFormal _a0) : base() {
      this._a0 = _a0;
    }
    public override _IClassItem DowncastClone() {
      if (this is _IClassItem dt) { return dt; }
      return new ClassItem_Field(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ClassItem_Field;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ClassItem.Field";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }

  public interface _IFormal {
    bool is_Formal { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    DAST._IType dtor_typ { get; }
    _IFormal DowncastClone();
  }
  public class Formal : _IFormal {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly DAST._IType _typ;
    public Formal(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ) {
      this._name = name;
      this._typ = typ;
    }
    public _IFormal DowncastClone() {
      if (this is _IFormal dt) { return dt; }
      return new Formal(_name, _typ);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Formal;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typ, oth._typ);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typ));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Formal.Formal";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typ);
      s += ")";
      return s;
    }
    private static readonly DAST._IFormal theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, DAST.Type.Default());
    public static DAST._IFormal Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IFormal> _TYPE = new Dafny.TypeDescriptor<DAST._IFormal>(DAST.Formal.Default());
    public static Dafny.TypeDescriptor<DAST._IFormal> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IFormal create(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ) {
      return new Formal(name, typ);
    }
    public static _IFormal create_Formal(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ) {
      return create(name, typ);
    }
    public bool is_Formal { get { return true; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public DAST._IType dtor_typ {
      get {
        return this._typ;
      }
    }
  }

  public interface _IMethod {
    bool is_Method { get; }
    bool dtor_isStatic { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
    Dafny.ISequence<DAST._IFormal> dtor_params { get; }
    Dafny.ISequence<DAST._IStatement> dtor_body { get; }
    Dafny.ISequence<DAST._IType> dtor_outTypes { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outVars { get; }
    _IMethod DowncastClone();
  }
  public class Method : _IMethod {
    public readonly bool _isStatic;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IFormal> _params;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public readonly Dafny.ISequence<DAST._IType> _outTypes;
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _outVars;
    public Method(bool isStatic, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars) {
      this._isStatic = isStatic;
      this._name = name;
      this._typeParams = typeParams;
      this._params = @params;
      this._body = body;
      this._outTypes = outTypes;
      this._outVars = outVars;
    }
    public _IMethod DowncastClone() {
      if (this is _IMethod dt) { return dt; }
      return new Method(_isStatic, _name, _typeParams, _params, _body, _outTypes, _outVars);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Method;
      return oth != null && this._isStatic == oth._isStatic && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._params, oth._params) && object.Equals(this._body, oth._body) && object.Equals(this._outTypes, oth._outTypes) && object.Equals(this._outVars, oth._outVars);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isStatic));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._params));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._outTypes));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._outVars));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Method.Method";
      s += "(";
      s += Dafny.Helpers.ToString(this._isStatic);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._params);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ", ";
      s += Dafny.Helpers.ToString(this._outTypes);
      s += ", ";
      s += Dafny.Helpers.ToString(this._outVars);
      s += ")";
      return s;
    }
    private static readonly DAST._IMethod theDefault = create(false, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IFormal>.Empty, Dafny.Sequence<DAST._IStatement>.Empty, Dafny.Sequence<DAST._IType>.Empty, DAST.Optional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>>.Default());
    public static DAST._IMethod Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IMethod> _TYPE = new Dafny.TypeDescriptor<DAST._IMethod>(DAST.Method.Default());
    public static Dafny.TypeDescriptor<DAST._IMethod> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IMethod create(bool isStatic, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars) {
      return new Method(isStatic, name, typeParams, @params, body, outTypes, outVars);
    }
    public static _IMethod create_Method(bool isStatic, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars) {
      return create(isStatic, name, typeParams, @params, body, outTypes, outVars);
    }
    public bool is_Method { get { return true; } }
    public bool dtor_isStatic {
      get {
        return this._isStatic;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        return this._name;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_typeParams {
      get {
        return this._typeParams;
      }
    }
    public Dafny.ISequence<DAST._IFormal> dtor_params {
      get {
        return this._params;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        return this._body;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_outTypes {
      get {
        return this._outTypes;
      }
    }
    public DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outVars {
      get {
        return this._outVars;
      }
    }
  }

  public interface _IOptional<T> {
    bool is_Some { get; }
    bool is_None { get; }
    T dtor_Some_a0 { get; }
    _IOptional<__T> DowncastClone<__T>(Func<T, __T> converter0);
  }
  public abstract class Optional<T> : _IOptional<T> {
    public Optional() {
    }
    public static DAST._IOptional<T> Default() {
      return create_None();
    }
    public static Dafny.TypeDescriptor<DAST._IOptional<T>> _TypeDescriptor() {
      return new Dafny.TypeDescriptor<DAST._IOptional<T>>(DAST.Optional<T>.Default());
    }
    public static _IOptional<T> create_Some(T _a0) {
      return new Optional_Some<T>(_a0);
    }
    public static _IOptional<T> create_None() {
      return new Optional_None<T>();
    }
    public bool is_Some { get { return this is Optional_Some<T>; } }
    public bool is_None { get { return this is Optional_None<T>; } }
    public T dtor_Some_a0 {
      get {
        var d = this;
        return ((Optional_Some<T>)d)._a0;
      }
    }
    public abstract _IOptional<__T> DowncastClone<__T>(Func<T, __T> converter0);
  }
  public class Optional_Some<T> : Optional<T> {
    public readonly T _a0;
    public Optional_Some(T _a0) : base() {
      this._a0 = _a0;
    }
    public override _IOptional<__T> DowncastClone<__T>(Func<T, __T> converter0) {
      if (this is _IOptional<__T> dt) { return dt; }
      return new Optional_Some<__T>(converter0(_a0));
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Optional_Some<T>;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Optional.Some";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Optional_None<T> : Optional<T> {
    public Optional_None() : base() {
    }
    public override _IOptional<__T> DowncastClone<__T>(Func<T, __T> converter0) {
      if (this is _IOptional<__T> dt) { return dt; }
      return new Optional_None<__T>();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Optional_None<T>;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Optional.None";
      return s;
    }
  }

  public interface _IStatement {
    bool is_DeclareVar { get; }
    bool is_Assign { get; }
    bool is_If { get; }
    bool is_While { get; }
    bool is_Call { get; }
    bool is_Return { get; }
    bool is_EarlyReturn { get; }
    bool is_Halt { get; }
    bool is_Print { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    DAST._IType dtor_typ { get; }
    DAST._IOptional<DAST._IExpression> dtor_maybeValue { get; }
    DAST._IExpression dtor_value { get; }
    DAST._IExpression dtor_cond { get; }
    Dafny.ISequence<DAST._IStatement> dtor_thn { get; }
    Dafny.ISequence<DAST._IStatement> dtor_els { get; }
    Dafny.ISequence<DAST._IStatement> dtor_body { get; }
    DAST._IExpression dtor_on { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<DAST._IExpression> dtor_args { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outs { get; }
    DAST._IExpression dtor_expr { get; }
    DAST._IExpression dtor_Print_a0 { get; }
    _IStatement DowncastClone();
  }
  public abstract class Statement : _IStatement {
    public Statement() {
    }
    private static readonly DAST._IStatement theDefault = create_DeclareVar(Dafny.Sequence<Dafny.Rune>.Empty, DAST.Type.Default(), DAST.Optional<DAST._IExpression>.Default());
    public static DAST._IStatement Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IStatement> _TYPE = new Dafny.TypeDescriptor<DAST._IStatement>(DAST.Statement.Default());
    public static Dafny.TypeDescriptor<DAST._IStatement> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IStatement create_DeclareVar(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, DAST._IOptional<DAST._IExpression> maybeValue) {
      return new Statement_DeclareVar(name, typ, maybeValue);
    }
    public static _IStatement create_Assign(Dafny.ISequence<Dafny.Rune> name, DAST._IExpression @value) {
      return new Statement_Assign(name, @value);
    }
    public static _IStatement create_If(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> thn, Dafny.ISequence<DAST._IStatement> els) {
      return new Statement_If(cond, thn, els);
    }
    public static _IStatement create_While(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_While(cond, body);
    }
    public static _IStatement create_Call(DAST._IExpression @on, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outs) {
      return new Statement_Call(@on, name, typeArgs, args, outs);
    }
    public static _IStatement create_Return(DAST._IExpression expr) {
      return new Statement_Return(expr);
    }
    public static _IStatement create_EarlyReturn() {
      return new Statement_EarlyReturn();
    }
    public static _IStatement create_Halt() {
      return new Statement_Halt();
    }
    public static _IStatement create_Print(DAST._IExpression _a0) {
      return new Statement_Print(_a0);
    }
    public bool is_DeclareVar { get { return this is Statement_DeclareVar; } }
    public bool is_Assign { get { return this is Statement_Assign; } }
    public bool is_If { get { return this is Statement_If; } }
    public bool is_While { get { return this is Statement_While; } }
    public bool is_Call { get { return this is Statement_Call; } }
    public bool is_Return { get { return this is Statement_Return; } }
    public bool is_EarlyReturn { get { return this is Statement_EarlyReturn; } }
    public bool is_Halt { get { return this is Statement_Halt; } }
    public bool is_Print { get { return this is Statement_Print; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        if (d is Statement_DeclareVar) { return ((Statement_DeclareVar)d)._name; }
        if (d is Statement_Assign) { return ((Statement_Assign)d)._name; }
        return ((Statement_Call)d)._name;
      }
    }
    public DAST._IType dtor_typ {
      get {
        var d = this;
        return ((Statement_DeclareVar)d)._typ;
      }
    }
    public DAST._IOptional<DAST._IExpression> dtor_maybeValue {
      get {
        var d = this;
        return ((Statement_DeclareVar)d)._maybeValue;
      }
    }
    public DAST._IExpression dtor_value {
      get {
        var d = this;
        return ((Statement_Assign)d)._value;
      }
    }
    public DAST._IExpression dtor_cond {
      get {
        var d = this;
        if (d is Statement_If) { return ((Statement_If)d)._cond; }
        return ((Statement_While)d)._cond;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_thn {
      get {
        var d = this;
        return ((Statement_If)d)._thn;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_els {
      get {
        var d = this;
        return ((Statement_If)d)._els;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        var d = this;
        return ((Statement_While)d)._body;
      }
    }
    public DAST._IExpression dtor_on {
      get {
        var d = this;
        return ((Statement_Call)d)._on;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_typeArgs {
      get {
        var d = this;
        return ((Statement_Call)d)._typeArgs;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_args {
      get {
        var d = this;
        return ((Statement_Call)d)._args;
      }
    }
    public DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outs {
      get {
        var d = this;
        return ((Statement_Call)d)._outs;
      }
    }
    public DAST._IExpression dtor_expr {
      get {
        var d = this;
        return ((Statement_Return)d)._expr;
      }
    }
    public DAST._IExpression dtor_Print_a0 {
      get {
        var d = this;
        return ((Statement_Print)d)._a0;
      }
    }
    public abstract _IStatement DowncastClone();
  }
  public class Statement_DeclareVar : Statement {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly DAST._IType _typ;
    public readonly DAST._IOptional<DAST._IExpression> _maybeValue;
    public Statement_DeclareVar(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, DAST._IOptional<DAST._IExpression> maybeValue) : base() {
      this._name = name;
      this._typ = typ;
      this._maybeValue = maybeValue;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_DeclareVar(_name, _typ, _maybeValue);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_DeclareVar;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typ, oth._typ) && object.Equals(this._maybeValue, oth._maybeValue);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typ));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._maybeValue));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.DeclareVar";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typ);
      s += ", ";
      s += Dafny.Helpers.ToString(this._maybeValue);
      s += ")";
      return s;
    }
  }
  public class Statement_Assign : Statement {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly DAST._IExpression _value;
    public Statement_Assign(Dafny.ISequence<Dafny.Rune> name, DAST._IExpression @value) : base() {
      this._name = name;
      this._value = @value;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Assign(_name, _value);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Assign;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._value, oth._value);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Assign";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._value);
      s += ")";
      return s;
    }
  }
  public class Statement_If : Statement {
    public readonly DAST._IExpression _cond;
    public readonly Dafny.ISequence<DAST._IStatement> _thn;
    public readonly Dafny.ISequence<DAST._IStatement> _els;
    public Statement_If(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> thn, Dafny.ISequence<DAST._IStatement> els) : base() {
      this._cond = cond;
      this._thn = thn;
      this._els = els;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_If(_cond, _thn, _els);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_If;
      return oth != null && object.Equals(this._cond, oth._cond) && object.Equals(this._thn, oth._thn) && object.Equals(this._els, oth._els);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._cond));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._thn));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._els));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.If";
      s += "(";
      s += Dafny.Helpers.ToString(this._cond);
      s += ", ";
      s += Dafny.Helpers.ToString(this._thn);
      s += ", ";
      s += Dafny.Helpers.ToString(this._els);
      s += ")";
      return s;
    }
  }
  public class Statement_While : Statement {
    public readonly DAST._IExpression _cond;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_While(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._cond = cond;
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_While(_cond, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_While;
      return oth != null && object.Equals(this._cond, oth._cond) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._cond));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.While";
      s += "(";
      s += Dafny.Helpers.ToString(this._cond);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Statement_Call : Statement {
    public readonly DAST._IExpression _on;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeArgs;
    public readonly Dafny.ISequence<DAST._IExpression> _args;
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _outs;
    public Statement_Call(DAST._IExpression @on, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outs) : base() {
      this._on = @on;
      this._name = name;
      this._typeArgs = typeArgs;
      this._args = args;
      this._outs = outs;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Call(_on, _name, _typeArgs, _args, _outs);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Call;
      return oth != null && object.Equals(this._on, oth._on) && object.Equals(this._name, oth._name) && object.Equals(this._typeArgs, oth._typeArgs) && object.Equals(this._args, oth._args) && object.Equals(this._outs, oth._outs);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._on));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._outs));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Call";
      s += "(";
      s += Dafny.Helpers.ToString(this._on);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeArgs);
      s += ", ";
      s += Dafny.Helpers.ToString(this._args);
      s += ", ";
      s += Dafny.Helpers.ToString(this._outs);
      s += ")";
      return s;
    }
  }
  public class Statement_Return : Statement {
    public readonly DAST._IExpression _expr;
    public Statement_Return(DAST._IExpression expr) : base() {
      this._expr = expr;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Return(_expr);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Return;
      return oth != null && object.Equals(this._expr, oth._expr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Return";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ")";
      return s;
    }
  }
  public class Statement_EarlyReturn : Statement {
    public Statement_EarlyReturn() : base() {
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_EarlyReturn();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_EarlyReturn;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 6;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.EarlyReturn";
      return s;
    }
  }
  public class Statement_Halt : Statement {
    public Statement_Halt() : base() {
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Halt();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Halt;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Halt";
      return s;
    }
  }
  public class Statement_Print : Statement {
    public readonly DAST._IExpression _a0;
    public Statement_Print(DAST._IExpression _a0) : base() {
      this._a0 = _a0;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Print(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Print;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Print";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }

  public interface _IExpression {
    bool is_Literal { get; }
    bool is_Ident { get; }
    bool is_Companion { get; }
    bool is_Tuple { get; }
    bool is_New { get; }
    bool is_NewArray { get; }
    bool is_DatatypeValue { get; }
    bool is_NewtypeValue { get; }
    bool is_SeqValue { get; }
    bool is_SetValue { get; }
    bool is_This { get; }
    bool is_Ite { get; }
    bool is_UnOp { get; }
    bool is_BinOp { get; }
    bool is_Select { get; }
    bool is_SelectFn { get; }
    bool is_TupleSelect { get; }
    bool is_Call { get; }
    bool is_Apply { get; }
    bool is_TypeTest { get; }
    bool is_InitializationValue { get; }
    DAST._ILiteral dtor_Literal_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Companion_a0 { get; }
    Dafny.ISequence<DAST._IExpression> dtor_Tuple_a0 { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path { get; }
    Dafny.ISequence<DAST._IExpression> dtor_args { get; }
    Dafny.ISequence<DAST._IExpression> dtor_dims { get; }
    Dafny.ISequence<Dafny.Rune> dtor_variant { get; }
    bool dtor_isCo { get; }
    Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> dtor_contents { get; }
    DAST._IType dtor_tpe { get; }
    DAST._IExpression dtor_value { get; }
    Dafny.ISequence<DAST._IExpression> dtor_elements { get; }
    DAST._IExpression dtor_cond { get; }
    DAST._IExpression dtor_thn { get; }
    DAST._IExpression dtor_els { get; }
    DAST._IUnaryOp dtor_unOp { get; }
    DAST._IExpression dtor_expr { get; }
    Dafny.ISequence<Dafny.Rune> dtor_op { get; }
    DAST._IExpression dtor_left { get; }
    DAST._IExpression dtor_right { get; }
    Dafny.ISequence<Dafny.Rune> dtor_field { get; }
    bool dtor_onDatatype { get; }
    BigInteger dtor_index { get; }
    DAST._IExpression dtor_on { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_dType { get; }
    DAST._IType dtor_typ { get; }
    _IExpression DowncastClone();
  }
  public abstract class Expression : _IExpression {
    public Expression() {
    }
    private static readonly DAST._IExpression theDefault = create_Literal(DAST.Literal.Default());
    public static DAST._IExpression Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IExpression> _TYPE = new Dafny.TypeDescriptor<DAST._IExpression>(DAST.Expression.Default());
    public static Dafny.TypeDescriptor<DAST._IExpression> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IExpression create_Literal(DAST._ILiteral _a0) {
      return new Expression_Literal(_a0);
    }
    public static _IExpression create_Ident(Dafny.ISequence<Dafny.Rune> _a0) {
      return new Expression_Ident(_a0);
    }
    public static _IExpression create_Companion(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0) {
      return new Expression_Companion(_a0);
    }
    public static _IExpression create_Tuple(Dafny.ISequence<DAST._IExpression> _a0) {
      return new Expression_Tuple(_a0);
    }
    public static _IExpression create_New(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<DAST._IExpression> args) {
      return new Expression_New(path, args);
    }
    public static _IExpression create_NewArray(Dafny.ISequence<DAST._IExpression> dims) {
      return new Expression_NewArray(dims);
    }
    public static _IExpression create_DatatypeValue(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<Dafny.Rune> variant, bool isCo, Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> contents) {
      return new Expression_DatatypeValue(path, variant, isCo, contents);
    }
    public static _IExpression create_NewtypeValue(DAST._IType tpe, DAST._IExpression @value) {
      return new Expression_NewtypeValue(tpe, @value);
    }
    public static _IExpression create_SeqValue(Dafny.ISequence<DAST._IExpression> elements) {
      return new Expression_SeqValue(elements);
    }
    public static _IExpression create_SetValue(Dafny.ISequence<DAST._IExpression> elements) {
      return new Expression_SetValue(elements);
    }
    public static _IExpression create_This() {
      return new Expression_This();
    }
    public static _IExpression create_Ite(DAST._IExpression cond, DAST._IExpression thn, DAST._IExpression els) {
      return new Expression_Ite(cond, thn, els);
    }
    public static _IExpression create_UnOp(DAST._IUnaryOp unOp, DAST._IExpression expr) {
      return new Expression_UnOp(unOp, expr);
    }
    public static _IExpression create_BinOp(Dafny.ISequence<Dafny.Rune> op, DAST._IExpression left, DAST._IExpression right) {
      return new Expression_BinOp(op, left, right);
    }
    public static _IExpression create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype) {
      return new Expression_Select(expr, field, onDatatype);
    }
    public static _IExpression create_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype) {
      return new Expression_SelectFn(expr, field, onDatatype);
    }
    public static _IExpression create_TupleSelect(DAST._IExpression expr, BigInteger index) {
      return new Expression_TupleSelect(expr, index);
    }
    public static _IExpression create_Call(DAST._IExpression @on, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) {
      return new Expression_Call(@on, name, typeArgs, args);
    }
    public static _IExpression create_Apply(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> args) {
      return new Expression_Apply(expr, args);
    }
    public static _IExpression create_TypeTest(DAST._IExpression @on, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dType, Dafny.ISequence<Dafny.Rune> variant) {
      return new Expression_TypeTest(@on, dType, variant);
    }
    public static _IExpression create_InitializationValue(DAST._IType typ) {
      return new Expression_InitializationValue(typ);
    }
    public bool is_Literal { get { return this is Expression_Literal; } }
    public bool is_Ident { get { return this is Expression_Ident; } }
    public bool is_Companion { get { return this is Expression_Companion; } }
    public bool is_Tuple { get { return this is Expression_Tuple; } }
    public bool is_New { get { return this is Expression_New; } }
    public bool is_NewArray { get { return this is Expression_NewArray; } }
    public bool is_DatatypeValue { get { return this is Expression_DatatypeValue; } }
    public bool is_NewtypeValue { get { return this is Expression_NewtypeValue; } }
    public bool is_SeqValue { get { return this is Expression_SeqValue; } }
    public bool is_SetValue { get { return this is Expression_SetValue; } }
    public bool is_This { get { return this is Expression_This; } }
    public bool is_Ite { get { return this is Expression_Ite; } }
    public bool is_UnOp { get { return this is Expression_UnOp; } }
    public bool is_BinOp { get { return this is Expression_BinOp; } }
    public bool is_Select { get { return this is Expression_Select; } }
    public bool is_SelectFn { get { return this is Expression_SelectFn; } }
    public bool is_TupleSelect { get { return this is Expression_TupleSelect; } }
    public bool is_Call { get { return this is Expression_Call; } }
    public bool is_Apply { get { return this is Expression_Apply; } }
    public bool is_TypeTest { get { return this is Expression_TypeTest; } }
    public bool is_InitializationValue { get { return this is Expression_InitializationValue; } }
    public DAST._ILiteral dtor_Literal_a0 {
      get {
        var d = this;
        return ((Expression_Literal)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 {
      get {
        var d = this;
        return ((Expression_Ident)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_Companion_a0 {
      get {
        var d = this;
        return ((Expression_Companion)d)._a0;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_Tuple_a0 {
      get {
        var d = this;
        return ((Expression_Tuple)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_path {
      get {
        var d = this;
        if (d is Expression_New) { return ((Expression_New)d)._path; }
        return ((Expression_DatatypeValue)d)._path;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_args {
      get {
        var d = this;
        if (d is Expression_New) { return ((Expression_New)d)._args; }
        if (d is Expression_Call) { return ((Expression_Call)d)._args; }
        return ((Expression_Apply)d)._args;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_dims {
      get {
        var d = this;
        return ((Expression_NewArray)d)._dims;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_variant {
      get {
        var d = this;
        if (d is Expression_DatatypeValue) { return ((Expression_DatatypeValue)d)._variant; }
        return ((Expression_TypeTest)d)._variant;
      }
    }
    public bool dtor_isCo {
      get {
        var d = this;
        return ((Expression_DatatypeValue)d)._isCo;
      }
    }
    public Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> dtor_contents {
      get {
        var d = this;
        return ((Expression_DatatypeValue)d)._contents;
      }
    }
    public DAST._IType dtor_tpe {
      get {
        var d = this;
        return ((Expression_NewtypeValue)d)._tpe;
      }
    }
    public DAST._IExpression dtor_value {
      get {
        var d = this;
        return ((Expression_NewtypeValue)d)._value;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_elements {
      get {
        var d = this;
        if (d is Expression_SeqValue) { return ((Expression_SeqValue)d)._elements; }
        return ((Expression_SetValue)d)._elements;
      }
    }
    public DAST._IExpression dtor_cond {
      get {
        var d = this;
        return ((Expression_Ite)d)._cond;
      }
    }
    public DAST._IExpression dtor_thn {
      get {
        var d = this;
        return ((Expression_Ite)d)._thn;
      }
    }
    public DAST._IExpression dtor_els {
      get {
        var d = this;
        return ((Expression_Ite)d)._els;
      }
    }
    public DAST._IUnaryOp dtor_unOp {
      get {
        var d = this;
        return ((Expression_UnOp)d)._unOp;
      }
    }
    public DAST._IExpression dtor_expr {
      get {
        var d = this;
        if (d is Expression_UnOp) { return ((Expression_UnOp)d)._expr; }
        if (d is Expression_Select) { return ((Expression_Select)d)._expr; }
        if (d is Expression_SelectFn) { return ((Expression_SelectFn)d)._expr; }
        if (d is Expression_TupleSelect) { return ((Expression_TupleSelect)d)._expr; }
        return ((Expression_Apply)d)._expr;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_op {
      get {
        var d = this;
        return ((Expression_BinOp)d)._op;
      }
    }
    public DAST._IExpression dtor_left {
      get {
        var d = this;
        return ((Expression_BinOp)d)._left;
      }
    }
    public DAST._IExpression dtor_right {
      get {
        var d = this;
        return ((Expression_BinOp)d)._right;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_field {
      get {
        var d = this;
        if (d is Expression_Select) { return ((Expression_Select)d)._field; }
        return ((Expression_SelectFn)d)._field;
      }
    }
    public bool dtor_onDatatype {
      get {
        var d = this;
        if (d is Expression_Select) { return ((Expression_Select)d)._onDatatype; }
        return ((Expression_SelectFn)d)._onDatatype;
      }
    }
    public BigInteger dtor_index {
      get {
        var d = this;
        return ((Expression_TupleSelect)d)._index;
      }
    }
    public DAST._IExpression dtor_on {
      get {
        var d = this;
        if (d is Expression_Call) { return ((Expression_Call)d)._on; }
        return ((Expression_TypeTest)d)._on;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        return ((Expression_Call)d)._name;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_typeArgs {
      get {
        var d = this;
        return ((Expression_Call)d)._typeArgs;
      }
    }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_dType {
      get {
        var d = this;
        return ((Expression_TypeTest)d)._dType;
      }
    }
    public DAST._IType dtor_typ {
      get {
        var d = this;
        return ((Expression_InitializationValue)d)._typ;
      }
    }
    public abstract _IExpression DowncastClone();
  }
  public class Expression_Literal : Expression {
    public readonly DAST._ILiteral _a0;
    public Expression_Literal(DAST._ILiteral _a0) : base() {
      this._a0 = _a0;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Literal(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Literal;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Literal";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Expression_Ident : Expression {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public Expression_Ident(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Ident(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Ident;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Ident";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expression_Companion : Expression {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0;
    public Expression_Companion(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Companion(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Companion;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Companion";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Expression_Tuple : Expression {
    public readonly Dafny.ISequence<DAST._IExpression> _a0;
    public Expression_Tuple(Dafny.ISequence<DAST._IExpression> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Tuple(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Tuple;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Tuple";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Expression_New : Expression {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
    public readonly Dafny.ISequence<DAST._IExpression> _args;
    public Expression_New(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<DAST._IExpression> args) : base() {
      this._path = path;
      this._args = args;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_New(_path, _args);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_New;
      return oth != null && object.Equals(this._path, oth._path) && object.Equals(this._args, oth._args);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._path));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.New";
      s += "(";
      s += Dafny.Helpers.ToString(this._path);
      s += ", ";
      s += Dafny.Helpers.ToString(this._args);
      s += ")";
      return s;
    }
  }
  public class Expression_NewArray : Expression {
    public readonly Dafny.ISequence<DAST._IExpression> _dims;
    public Expression_NewArray(Dafny.ISequence<DAST._IExpression> dims) : base() {
      this._dims = dims;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_NewArray(_dims);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_NewArray;
      return oth != null && object.Equals(this._dims, oth._dims);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._dims));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.NewArray";
      s += "(";
      s += Dafny.Helpers.ToString(this._dims);
      s += ")";
      return s;
    }
  }
  public class Expression_DatatypeValue : Expression {
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _path;
    public readonly Dafny.ISequence<Dafny.Rune> _variant;
    public readonly bool _isCo;
    public readonly Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _contents;
    public Expression_DatatypeValue(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path, Dafny.ISequence<Dafny.Rune> variant, bool isCo, Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> contents) : base() {
      this._path = path;
      this._variant = variant;
      this._isCo = isCo;
      this._contents = contents;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_DatatypeValue(_path, _variant, _isCo, _contents);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_DatatypeValue;
      return oth != null && object.Equals(this._path, oth._path) && object.Equals(this._variant, oth._variant) && this._isCo == oth._isCo && object.Equals(this._contents, oth._contents);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 6;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._path));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._variant));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isCo));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._contents));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.DatatypeValue";
      s += "(";
      s += Dafny.Helpers.ToString(this._path);
      s += ", ";
      s += this._variant.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._isCo);
      s += ", ";
      s += Dafny.Helpers.ToString(this._contents);
      s += ")";
      return s;
    }
  }
  public class Expression_NewtypeValue : Expression {
    public readonly DAST._IType _tpe;
    public readonly DAST._IExpression _value;
    public Expression_NewtypeValue(DAST._IType tpe, DAST._IExpression @value) : base() {
      this._tpe = tpe;
      this._value = @value;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_NewtypeValue(_tpe, _value);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_NewtypeValue;
      return oth != null && object.Equals(this._tpe, oth._tpe) && object.Equals(this._value, oth._value);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._tpe));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.NewtypeValue";
      s += "(";
      s += Dafny.Helpers.ToString(this._tpe);
      s += ", ";
      s += Dafny.Helpers.ToString(this._value);
      s += ")";
      return s;
    }
  }
  public class Expression_SeqValue : Expression {
    public readonly Dafny.ISequence<DAST._IExpression> _elements;
    public Expression_SeqValue(Dafny.ISequence<DAST._IExpression> elements) : base() {
      this._elements = elements;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SeqValue(_elements);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SeqValue;
      return oth != null && object.Equals(this._elements, oth._elements);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._elements));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SeqValue";
      s += "(";
      s += Dafny.Helpers.ToString(this._elements);
      s += ")";
      return s;
    }
  }
  public class Expression_SetValue : Expression {
    public readonly Dafny.ISequence<DAST._IExpression> _elements;
    public Expression_SetValue(Dafny.ISequence<DAST._IExpression> elements) : base() {
      this._elements = elements;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SetValue(_elements);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SetValue;
      return oth != null && object.Equals(this._elements, oth._elements);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 9;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._elements));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SetValue";
      s += "(";
      s += Dafny.Helpers.ToString(this._elements);
      s += ")";
      return s;
    }
  }
  public class Expression_This : Expression {
    public Expression_This() : base() {
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_This();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_This;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 10;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.This";
      return s;
    }
  }
  public class Expression_Ite : Expression {
    public readonly DAST._IExpression _cond;
    public readonly DAST._IExpression _thn;
    public readonly DAST._IExpression _els;
    public Expression_Ite(DAST._IExpression cond, DAST._IExpression thn, DAST._IExpression els) : base() {
      this._cond = cond;
      this._thn = thn;
      this._els = els;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Ite(_cond, _thn, _els);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Ite;
      return oth != null && object.Equals(this._cond, oth._cond) && object.Equals(this._thn, oth._thn) && object.Equals(this._els, oth._els);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 11;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._cond));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._thn));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._els));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Ite";
      s += "(";
      s += Dafny.Helpers.ToString(this._cond);
      s += ", ";
      s += Dafny.Helpers.ToString(this._thn);
      s += ", ";
      s += Dafny.Helpers.ToString(this._els);
      s += ")";
      return s;
    }
  }
  public class Expression_UnOp : Expression {
    public readonly DAST._IUnaryOp _unOp;
    public readonly DAST._IExpression _expr;
    public Expression_UnOp(DAST._IUnaryOp unOp, DAST._IExpression expr) : base() {
      this._unOp = unOp;
      this._expr = expr;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_UnOp(_unOp, _expr);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_UnOp;
      return oth != null && object.Equals(this._unOp, oth._unOp) && object.Equals(this._expr, oth._expr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 12;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._unOp));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.UnOp";
      s += "(";
      s += Dafny.Helpers.ToString(this._unOp);
      s += ", ";
      s += Dafny.Helpers.ToString(this._expr);
      s += ")";
      return s;
    }
  }
  public class Expression_BinOp : Expression {
    public readonly Dafny.ISequence<Dafny.Rune> _op;
    public readonly DAST._IExpression _left;
    public readonly DAST._IExpression _right;
    public Expression_BinOp(Dafny.ISequence<Dafny.Rune> op, DAST._IExpression left, DAST._IExpression right) : base() {
      this._op = op;
      this._left = left;
      this._right = right;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_BinOp(_op, _left, _right);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_BinOp;
      return oth != null && object.Equals(this._op, oth._op) && object.Equals(this._left, oth._left) && object.Equals(this._right, oth._right);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 13;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._op));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._left));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._right));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.BinOp";
      s += "(";
      s += this._op.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._left);
      s += ", ";
      s += Dafny.Helpers.ToString(this._right);
      s += ")";
      return s;
    }
  }
  public class Expression_Select : Expression {
    public readonly DAST._IExpression _expr;
    public readonly Dafny.ISequence<Dafny.Rune> _field;
    public readonly bool _onDatatype;
    public Expression_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype) : base() {
      this._expr = expr;
      this._field = field;
      this._onDatatype = onDatatype;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Select(_expr, _field, _onDatatype);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Select;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._field, oth._field) && this._onDatatype == oth._onDatatype;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 14;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._field));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._onDatatype));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Select";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += this._field.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._onDatatype);
      s += ")";
      return s;
    }
  }
  public class Expression_SelectFn : Expression {
    public readonly DAST._IExpression _expr;
    public readonly Dafny.ISequence<Dafny.Rune> _field;
    public readonly bool _onDatatype;
    public Expression_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype) : base() {
      this._expr = expr;
      this._field = field;
      this._onDatatype = onDatatype;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SelectFn(_expr, _field, _onDatatype);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SelectFn;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._field, oth._field) && this._onDatatype == oth._onDatatype;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 15;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._field));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._onDatatype));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SelectFn";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += this._field.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._onDatatype);
      s += ")";
      return s;
    }
  }
  public class Expression_TupleSelect : Expression {
    public readonly DAST._IExpression _expr;
    public readonly BigInteger _index;
    public Expression_TupleSelect(DAST._IExpression expr, BigInteger index) : base() {
      this._expr = expr;
      this._index = index;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_TupleSelect(_expr, _index);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_TupleSelect;
      return oth != null && object.Equals(this._expr, oth._expr) && this._index == oth._index;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 16;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._index));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.TupleSelect";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._index);
      s += ")";
      return s;
    }
  }
  public class Expression_Call : Expression {
    public readonly DAST._IExpression _on;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeArgs;
    public readonly Dafny.ISequence<DAST._IExpression> _args;
    public Expression_Call(DAST._IExpression @on, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) : base() {
      this._on = @on;
      this._name = name;
      this._typeArgs = typeArgs;
      this._args = args;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Call(_on, _name, _typeArgs, _args);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Call;
      return oth != null && object.Equals(this._on, oth._on) && object.Equals(this._name, oth._name) && object.Equals(this._typeArgs, oth._typeArgs) && object.Equals(this._args, oth._args);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 17;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._on));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeArgs));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Call";
      s += "(";
      s += Dafny.Helpers.ToString(this._on);
      s += ", ";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeArgs);
      s += ", ";
      s += Dafny.Helpers.ToString(this._args);
      s += ")";
      return s;
    }
  }
  public class Expression_Apply : Expression {
    public readonly DAST._IExpression _expr;
    public readonly Dafny.ISequence<DAST._IExpression> _args;
    public Expression_Apply(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> args) : base() {
      this._expr = expr;
      this._args = args;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Apply(_expr, _args);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Apply;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._args, oth._args);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 18;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._args));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Apply";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._args);
      s += ")";
      return s;
    }
  }
  public class Expression_TypeTest : Expression {
    public readonly DAST._IExpression _on;
    public readonly Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _dType;
    public readonly Dafny.ISequence<Dafny.Rune> _variant;
    public Expression_TypeTest(DAST._IExpression @on, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dType, Dafny.ISequence<Dafny.Rune> variant) : base() {
      this._on = @on;
      this._dType = dType;
      this._variant = variant;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_TypeTest(_on, _dType, _variant);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_TypeTest;
      return oth != null && object.Equals(this._on, oth._on) && object.Equals(this._dType, oth._dType) && object.Equals(this._variant, oth._variant);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 19;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._on));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._dType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._variant));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.TypeTest";
      s += "(";
      s += Dafny.Helpers.ToString(this._on);
      s += ", ";
      s += Dafny.Helpers.ToString(this._dType);
      s += ", ";
      s += this._variant.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Expression_InitializationValue : Expression {
    public readonly DAST._IType _typ;
    public Expression_InitializationValue(DAST._IType typ) : base() {
      this._typ = typ;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_InitializationValue(_typ);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_InitializationValue;
      return oth != null && object.Equals(this._typ, oth._typ);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 20;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typ));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.InitializationValue";
      s += "(";
      s += Dafny.Helpers.ToString(this._typ);
      s += ")";
      return s;
    }
  }

  public interface _IUnaryOp {
    bool is_Not { get; }
    bool is_BitwiseNot { get; }
    bool is_Cardinality { get; }
    _IUnaryOp DowncastClone();
  }
  public abstract class UnaryOp : _IUnaryOp {
    public UnaryOp() {
    }
    private static readonly DAST._IUnaryOp theDefault = create_Not();
    public static DAST._IUnaryOp Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IUnaryOp> _TYPE = new Dafny.TypeDescriptor<DAST._IUnaryOp>(DAST.UnaryOp.Default());
    public static Dafny.TypeDescriptor<DAST._IUnaryOp> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IUnaryOp create_Not() {
      return new UnaryOp_Not();
    }
    public static _IUnaryOp create_BitwiseNot() {
      return new UnaryOp_BitwiseNot();
    }
    public static _IUnaryOp create_Cardinality() {
      return new UnaryOp_Cardinality();
    }
    public bool is_Not { get { return this is UnaryOp_Not; } }
    public bool is_BitwiseNot { get { return this is UnaryOp_BitwiseNot; } }
    public bool is_Cardinality { get { return this is UnaryOp_Cardinality; } }
    public static System.Collections.Generic.IEnumerable<_IUnaryOp> AllSingletonConstructors {
      get {
        yield return UnaryOp.create_Not();
        yield return UnaryOp.create_BitwiseNot();
        yield return UnaryOp.create_Cardinality();
      }
    }
    public abstract _IUnaryOp DowncastClone();
  }
  public class UnaryOp_Not : UnaryOp {
    public UnaryOp_Not() : base() {
    }
    public override _IUnaryOp DowncastClone() {
      if (this is _IUnaryOp dt) { return dt; }
      return new UnaryOp_Not();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.UnaryOp_Not;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.UnaryOp.Not";
      return s;
    }
  }
  public class UnaryOp_BitwiseNot : UnaryOp {
    public UnaryOp_BitwiseNot() : base() {
    }
    public override _IUnaryOp DowncastClone() {
      if (this is _IUnaryOp dt) { return dt; }
      return new UnaryOp_BitwiseNot();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.UnaryOp_BitwiseNot;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.UnaryOp.BitwiseNot";
      return s;
    }
  }
  public class UnaryOp_Cardinality : UnaryOp {
    public UnaryOp_Cardinality() : base() {
    }
    public override _IUnaryOp DowncastClone() {
      if (this is _IUnaryOp dt) { return dt; }
      return new UnaryOp_Cardinality();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.UnaryOp_Cardinality;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.UnaryOp.Cardinality";
      return s;
    }
  }

  public interface _ILiteral {
    bool is_BoolLiteral { get; }
    bool is_IntLiteral { get; }
    bool is_DecLiteral { get; }
    bool is_StringLiteral { get; }
    bool is_CharLiteral { get; }
    bool is_Null { get; }
    bool dtor_BoolLiteral_a0 { get; }
    BigInteger dtor_IntLiteral_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_StringLiteral_a0 { get; }
    Dafny.Rune dtor_CharLiteral_a0 { get; }
    _ILiteral DowncastClone();
  }
  public abstract class Literal : _ILiteral {
    public Literal() {
    }
    private static readonly DAST._ILiteral theDefault = create_BoolLiteral(false);
    public static DAST._ILiteral Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._ILiteral> _TYPE = new Dafny.TypeDescriptor<DAST._ILiteral>(DAST.Literal.Default());
    public static Dafny.TypeDescriptor<DAST._ILiteral> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ILiteral create_BoolLiteral(bool _a0) {
      return new Literal_BoolLiteral(_a0);
    }
    public static _ILiteral create_IntLiteral(BigInteger _a0) {
      return new Literal_IntLiteral(_a0);
    }
    public static _ILiteral create_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0) {
      return new Literal_DecLiteral(_a0);
    }
    public static _ILiteral create_StringLiteral(Dafny.ISequence<Dafny.Rune> _a0) {
      return new Literal_StringLiteral(_a0);
    }
    public static _ILiteral create_CharLiteral(Dafny.Rune _a0) {
      return new Literal_CharLiteral(_a0);
    }
    public static _ILiteral create_Null() {
      return new Literal_Null();
    }
    public bool is_BoolLiteral { get { return this is Literal_BoolLiteral; } }
    public bool is_IntLiteral { get { return this is Literal_IntLiteral; } }
    public bool is_DecLiteral { get { return this is Literal_DecLiteral; } }
    public bool is_StringLiteral { get { return this is Literal_StringLiteral; } }
    public bool is_CharLiteral { get { return this is Literal_CharLiteral; } }
    public bool is_Null { get { return this is Literal_Null; } }
    public bool dtor_BoolLiteral_a0 {
      get {
        var d = this;
        return ((Literal_BoolLiteral)d)._a0;
      }
    }
    public BigInteger dtor_IntLiteral_a0 {
      get {
        var d = this;
        return ((Literal_IntLiteral)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0 {
      get {
        var d = this;
        return ((Literal_DecLiteral)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_StringLiteral_a0 {
      get {
        var d = this;
        return ((Literal_StringLiteral)d)._a0;
      }
    }
    public Dafny.Rune dtor_CharLiteral_a0 {
      get {
        var d = this;
        return ((Literal_CharLiteral)d)._a0;
      }
    }
    public abstract _ILiteral DowncastClone();
  }
  public class Literal_BoolLiteral : Literal {
    public readonly bool _a0;
    public Literal_BoolLiteral(bool _a0) : base() {
      this._a0 = _a0;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_BoolLiteral(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_BoolLiteral;
      return oth != null && this._a0 == oth._a0;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.BoolLiteral";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Literal_IntLiteral : Literal {
    public readonly BigInteger _a0;
    public Literal_IntLiteral(BigInteger _a0) : base() {
      this._a0 = _a0;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_IntLiteral(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_IntLiteral;
      return oth != null && this._a0 == oth._a0;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.IntLiteral";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Literal_DecLiteral : Literal {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public Literal_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_DecLiteral(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_DecLiteral;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.DecLiteral";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Literal_StringLiteral : Literal {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public Literal_StringLiteral(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_StringLiteral(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_StringLiteral;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.StringLiteral";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Literal_CharLiteral : Literal {
    public readonly Dafny.Rune _a0;
    public Literal_CharLiteral(Dafny.Rune _a0) : base() {
      this._a0 = _a0;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_CharLiteral(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_CharLiteral;
      return oth != null && this._a0 == oth._a0;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 4;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.CharLiteral";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class Literal_Null : Literal {
    public Literal_Null() : base() {
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_Null();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_Null;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.Null";
      return s;
    }
  }
} // end of namespace DAST
namespace DCOMP {

  public partial class __default {
    public static Dafny.ISequence<Dafny.Rune> natToString(BigInteger n) {
      if ((n).Sign == 0) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("0");
      } else if ((n) == (BigInteger.One)) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("1");
      } else if ((n) == (new BigInteger(2))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("2");
      } else if ((n) == (new BigInteger(3))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("3");
      } else if ((n) == (new BigInteger(4))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("4");
      } else if ((n) == (new BigInteger(5))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("5");
      } else if ((n) == (new BigInteger(6))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("6");
      } else if ((n) == (new BigInteger(7))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("7");
      } else if ((n) == (new BigInteger(8))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("8");
      } else if ((n) == (new BigInteger(9))) {
        return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("9");
      } else {
        return Dafny.Sequence<Dafny.Rune>.Concat(DCOMP.__default.natToString(Dafny.Helpers.EuclideanDivision(n, new BigInteger(10))), DCOMP.__default.natToString(Dafny.Helpers.EuclideanModulus(n, new BigInteger(10))));
      }
    }
  }

  public partial class stringNat {
    private static readonly Dafny.ISequence<Dafny.Rune> Witness = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("1");
    public static Dafny.ISequence<Dafny.Rune> Default() {
      return Witness;
    }
    private static readonly Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TYPE = new Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>>(DCOMP.stringNat.Default());
    public static Dafny.TypeDescriptor<Dafny.ISequence<Dafny.Rune>> _TypeDescriptor() {
      return _TYPE;
    }
  }

  public partial class COMP {
    public COMP() {
    }
    public static Dafny.ISequence<Dafny.Rune> GenModule(DAST._IModule mod, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> body;
      Dafny.ISequence<Dafny.Rune> _out0;
      _out0 = DCOMP.COMP.GenModuleBody((mod).dtor_body, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((mod).dtor_name)));
      body = _out0;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("mod r#"), (mod).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenModuleBody(Dafny.ISequence<DAST._IModuleItem> body, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger i;
      i = BigInteger.Zero;
      while ((i) < (new BigInteger((body).Count))) {
        Dafny.ISequence<Dafny.Rune> generated = Dafny.Sequence<Dafny.Rune>.Empty;
        DAST._IModuleItem _source0 = (body).Select(i);
        if (_source0.is_Module) {
          DAST._IModule __mcc_h0 = _source0.dtor_Module_a0;
          DAST._IModule m = __mcc_h0;
          Dafny.ISequence<Dafny.Rune> _out1;
          _out1 = DCOMP.COMP.GenModule(m, containingPath);
          generated = _out1;
        } else if (_source0.is_Class) {
          DAST._IClass __mcc_h1 = _source0.dtor_Class_a0;
          DAST._IClass c = __mcc_h1;
          Dafny.ISequence<Dafny.Rune> _out2;
          _out2 = DCOMP.COMP.GenClass(c);
          generated = _out2;
        } else if (_source0.is_Trait) {
          DAST._ITrait __mcc_h2 = _source0.dtor_Trait_a0;
          DAST._ITrait t = __mcc_h2;
          Dafny.ISequence<Dafny.Rune> _out3;
          _out3 = DCOMP.COMP.GenTrait(t, containingPath);
          generated = _out3;
        } else if (_source0.is_Newtype) {
          DAST._INewtype __mcc_h3 = _source0.dtor_Newtype_a0;
          DAST._INewtype _10_n = __mcc_h3;
          Dafny.ISequence<Dafny.Rune> _out4;
          _out4 = DCOMP.COMP.GenNewtype(_10_n);
          generated = _out4;
        } else {
          DAST._IDatatype _11___mcc_h4 = _source0.dtor_Datatype_a0;
          DAST._IDatatype _12_d = _11___mcc_h4;
          Dafny.ISequence<Dafny.Rune> _out5;
          _out5 = DCOMP.COMP.GenDatatype(_12_d);
          generated = _out5;
        }
        if ((i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, generated);
        i = (i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenClass(DAST._IClass c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _13_implBody;
      Dafny.ISequence<Dafny.Rune> _out6;
      _out6 = DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements())), Dafny.Set<DAST._IType>.FromElements());
      _13_implBody = _out6;
      _13_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn new() -> Self {\n"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n")), _13_implBody);
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub struct r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _13_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      if ((new BigInteger(((c).dtor_superClasses).Count)).Sign == 1) {
        BigInteger _14_i;
        _14_i = BigInteger.Zero;
        while ((_14_i) < (new BigInteger(((c).dtor_superClasses).Count))) {
          DAST._IType _15_superClass;
          _15_superClass = ((c).dtor_superClasses).Select(_14_i);
          DAST._IType _source1 = _15_superClass;
          if (_source1.is_Path) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _16___mcc_h0 = _source1.dtor_Path_a0;
            Dafny.ISequence<DAST._IType> _17___mcc_h1 = _source1.dtor_typeArgs;
            DAST._IResolvedType _18___mcc_h2 = _source1.dtor_resolved;
            DAST._IResolvedType _source2 = _18___mcc_h2;
            if (_source2.is_Datatype) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _19___mcc_h6 = _source2.dtor_path;
            } else if (_source2.is_Trait) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _20___mcc_h8 = _source2.dtor_path;
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _21_path = _16___mcc_h0;
              {
                Dafny.ISequence<Dafny.Rune> _22_pathStr;
                Dafny.ISequence<Dafny.Rune> _out7;
                _out7 = DCOMP.COMP.GenPath(_21_path);
                _22_pathStr = _out7;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nimpl ")), _22_pathStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" for ::std::rc::Rc<r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> {}"));
              }
            } else {
            }
          } else if (_source1.is_Tuple) {
            Dafny.ISequence<DAST._IType> _23___mcc_h10 = _source1.dtor_Tuple_a0;
          } else if (_source1.is_Array) {
            DAST._IType _24___mcc_h12 = _source1.dtor_element;
          } else if (_source1.is_Seq) {
            DAST._IType _25___mcc_h14 = _source1.dtor_element;
          } else if (_source1.is_Set) {
            DAST._IType _26___mcc_h16 = _source1.dtor_element;
          } else if (_source1.is_Multiset) {
            DAST._IType _27___mcc_h18 = _source1.dtor_element;
          } else if (_source1.is_Map) {
            DAST._IType _28___mcc_h20 = _source1.dtor_key;
            DAST._IType _29___mcc_h21 = _source1.dtor_value;
          } else if (_source1.is_Arrow) {
            Dafny.ISequence<DAST._IType> _30___mcc_h24 = _source1.dtor_args;
            DAST._IType _31___mcc_h25 = _source1.dtor_result;
          } else if (_source1.is_Primitive) {
            DAST._IPrimitive _32___mcc_h28 = _source1.dtor_Primitive_a0;
          } else if (_source1.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _33___mcc_h30 = _source1.dtor_Passthrough_a0;
          } else {
            Dafny.ISequence<Dafny.Rune> _34___mcc_h32 = _source1.dtor_TypeArg_a0;
          }
          _14_i = (_14_i) + (BigInteger.One);
        }
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTrait(DAST._ITrait t, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _35_fullPath;
      _35_fullPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((t).dtor_name));
      Dafny.ISequence<Dafny.Rune> _36_implBody;
      Dafny.ISequence<Dafny.Rune> _out8;
      _out8 = DCOMP.COMP.GenClassImplBody((t).dtor_body, true, DAST.Type.create_Path(_35_fullPath, Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Trait(_35_fullPath)), Dafny.Set<DAST._IType>.FromElements());
      _36_implBody = _out8;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait r#"), (t).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _36_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenNewtype(DAST._INewtype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _37_underlyingType;
      Dafny.ISequence<Dafny.Rune> _out9;
      _out9 = DCOMP.COMP.GenType((c).dtor_base, false);
      _37_underlyingType = _out9;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Clone, PartialEq)]\npub struct r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(pub ")), _37_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ::std::default::Default for r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      DAST._IOptional<DAST._IExpression> _source3 = (c).dtor_witnessExpr;
      if (_source3.is_Some) {
        DAST._IExpression _38___mcc_h0 = _source3.dtor_Some_a0;
        DAST._IExpression _39_e = _38___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _40_eStr;
          bool _41___v4;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _42___v5;
          Dafny.ISequence<Dafny.Rune> _out10;
          bool _out11;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out12;
          DCOMP.COMP.GenExpr(_39_e, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out10, out _out11, out _out12);
          _40_eStr = _out10;
          _41___v4 = _out11;
          _42___v5 = _out12;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _40_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(::std::default::Default::default())\n"));
        }
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, f: &mut ::std::fmt::Formatter) -> ::std::fmt::Result {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyPrint::fmt_print(&self.0, f)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
      Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>> _43_ops;
      _43_ops = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std::ops::Add"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("add")), _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std::ops::Sub"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("sub")), _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std::ops::Mul"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("mul")), _System.Tuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>.create(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std::ops::Div"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("div")));
      BigInteger _44_i;
      _44_i = BigInteger.Zero;
      while ((_44_i) < (new BigInteger((_43_ops).Count))) {
        _System._ITuple2<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>> _let_tmp_rhs0 = (_43_ops).Select(_44_i);
        Dafny.ISequence<Dafny.Rune> _45_traitName = _let_tmp_rhs0.dtor__0;
        Dafny.ISequence<Dafny.Rune> _46_methodName = _let_tmp_rhs0.dtor__1;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _45_traitName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name);
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" where ")), _37_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _45_traitName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<")), _37_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", Output = ")), _37_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> {\n"));
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Output = r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn ")), _46_methodName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(self, other: r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _45_traitName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _46_methodName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(self.0, other.0))\n"));
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
        _44_i = (_44_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenDatatype(DAST._IDatatype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _47_typeParamsSet;
      _47_typeParamsSet = Dafny.Set<DAST._IType>.FromElements();
      Dafny.ISequence<Dafny.Rune> _48_typeParams;
      _48_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _49_tpI;
      _49_tpI = BigInteger.Zero;
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _48_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_49_tpI) < (new BigInteger(((c).dtor_typeParams).Count))) {
          DAST._IType _50_tp;
          _50_tp = ((c).dtor_typeParams).Select(_49_tpI);
          _47_typeParamsSet = Dafny.Set<DAST._IType>.Union(_47_typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_50_tp));
          Dafny.ISequence<Dafny.Rune> _51_genTp;
          Dafny.ISequence<Dafny.Rune> _out13;
          _out13 = DCOMP.COMP.GenType(_50_tp, false);
          _51_genTp = _out13;
          _48_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_48_typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _51_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          _49_tpI = (_49_tpI) + (BigInteger.One);
        }
        _48_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(_48_typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.Rune> _52_ctors;
      _52_ctors = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _53_i;
      _53_i = BigInteger.Zero;
      while ((_53_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _54_ctor;
        _54_ctor = ((c).dtor_ctors).Select(_53_i);
        Dafny.ISequence<Dafny.Rune> _55_ctorBody;
        _55_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_54_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        BigInteger _56_j;
        _56_j = BigInteger.Zero;
        while ((_56_j) < (new BigInteger(((_54_ctor).dtor_args).Count))) {
          DAST._IFormal _57_formal;
          _57_formal = ((_54_ctor).dtor_args).Select(_56_j);
          Dafny.ISequence<Dafny.Rune> _58_formalType;
          Dafny.ISequence<Dafny.Rune> _out14;
          _out14 = DCOMP.COMP.GenType((_57_formal).dtor_typ, false);
          _58_formalType = _out14;
          if ((c).dtor_isCo) {
            _55_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_55_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_57_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper<")), _58_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">, "));
          } else {
            _55_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_55_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_57_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _58_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          _56_j = (_56_j) + (BigInteger.One);
        }
        _55_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(_55_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        _52_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_52_ctors, _55_ctorBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
        _53_i = (_53_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _59_selfPath;
      _59_selfPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((c).dtor_name);
      Dafny.ISequence<Dafny.Rune> _60_implBody;
      Dafny.ISequence<Dafny.Rune> _out15;
      _out15 = DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(_59_selfPath)), _47_typeParamsSet);
      _60_implBody = _out15;
      _53_i = BigInteger.Zero;
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _61_emittedFields;
      _61_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      while ((_53_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _62_ctor;
        _62_ctor = ((c).dtor_ctors).Select(_53_i);
        BigInteger _63_j;
        _63_j = BigInteger.Zero;
        while ((_63_j) < (new BigInteger(((_62_ctor).dtor_args).Count))) {
          DAST._IFormal _64_formal;
          _64_formal = ((_62_ctor).dtor_args).Select(_63_j);
          if (!((_61_emittedFields).Contains((_64_formal).dtor_name))) {
            _61_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_61_emittedFields, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_64_formal).dtor_name));
            Dafny.ISequence<Dafny.Rune> _65_formalType;
            Dafny.ISequence<Dafny.Rune> _out16;
            _out16 = DCOMP.COMP.GenType((_64_formal).dtor_typ, false);
            _65_formalType = _out16;
            Dafny.ISequence<Dafny.Rune> _66_methodBody;
            _66_methodBody = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n");
            BigInteger _67_k;
            _67_k = BigInteger.Zero;
            while ((_67_k) < (new BigInteger(((c).dtor_ctors).Count))) {
              DAST._IDatatypeCtor _68_ctor2;
              _68_ctor2 = ((c).dtor_ctors).Select(_67_k);
              Dafny.ISequence<Dafny.Rune> _69_ctorMatch;
              _69_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_68_ctor2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
              BigInteger _70_l;
              _70_l = BigInteger.Zero;
              bool _71_hasMatchingField;
              _71_hasMatchingField = false;
              while ((_70_l) < (new BigInteger(((_68_ctor2).dtor_args).Count))) {
                DAST._IFormal _72_formal2;
                _72_formal2 = ((_68_ctor2).dtor_args).Select(_70_l);
                if (((_64_formal).dtor_name).Equals((_72_formal2).dtor_name)) {
                  _71_hasMatchingField = true;
                }
                _69_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_69_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_72_formal2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                _70_l = (_70_l) + (BigInteger.One);
              }
              if (_71_hasMatchingField) {
                if ((c).dtor_isCo) {
                  _69_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_69_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ::std::ops::Deref::deref(&")), (_64_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0),\n"));
                } else {
                  _69_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_69_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ")), (_64_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
                }
              } else {
                _69_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_69_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => panic!(\"field does not exist on this variant\"),\n"));
              }
              _66_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_66_methodBody, _69_ctorMatch);
              _67_k = (_67_k) + (BigInteger.One);
            }
            _66_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_66_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            _60_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_60_implBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#")), (_64_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&self) -> &")), _65_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _66_methodBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
          }
          _63_j = (_63_j) + (BigInteger.One);
        }
        _53_i = (_53_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.Rune> _73_constrainedTypeParams;
      _73_constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _49_tpI = BigInteger.Zero;
        _73_constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_49_tpI) < (new BigInteger(((c).dtor_typeParams).Count))) {
          if ((_49_tpI).Sign == 1) {
            _73_constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(_73_constrainedTypeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          DAST._IType _74_tp;
          _74_tp = ((c).dtor_typeParams).Select(_49_tpI);
          Dafny.ISequence<Dafny.Rune> _75_genTp;
          Dafny.ISequence<Dafny.Rune> _out17;
          _out17 = DCOMP.COMP.GenType(_74_tp, false);
          _75_genTp = _out17;
          _73_constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_73_constrainedTypeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _75_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _49_tpI = (_49_tpI) + (BigInteger.One);
        }
        _73_constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(_73_constrainedTypeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.Rune> _76_enumBody;
      _76_enumBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(PartialEq)]\npub enum r#"), (c).dtor_name), _48_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _52_ctors), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _73_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _48_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _60_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _77_printImpl;
      _77_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _73_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _48_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, f: &mut ::std::fmt::Formatter) -> std::fmt::Result {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n"));
      _53_i = BigInteger.Zero;
      while ((_53_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _78_ctor;
        _78_ctor = ((c).dtor_ctors).Select(_53_i);
        Dafny.ISequence<Dafny.Rune> _79_ctorMatch;
        _79_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_78_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        Dafny.ISequence<Dafny.Rune> _80_modulePrefix;
        _80_modulePrefix = (((((c).dtor_enclosingModule)).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_module"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(((c).dtor_enclosingModule), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("."))));
        Dafny.ISequence<Dafny.Rune> _81_printRhs;
        _81_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(f, \""), _80_modulePrefix), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (_78_ctor).dtor_name), (((_78_ctor).dtor_hasAnyArgs) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(\")?;")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"))));
        BigInteger _82_j;
        _82_j = BigInteger.Zero;
        while ((_82_j) < (new BigInteger(((_78_ctor).dtor_args).Count))) {
          DAST._IFormal _83_formal;
          _83_formal = ((_78_ctor).dtor_args).Select(_82_j);
          _79_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_79_ctorMatch, (_83_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          if ((_82_j).Sign == 1) {
            _81_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_81_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(f, \", \")?;"));
          }
          _81_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_81_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(")), (_83_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", f)?;"));
          _82_j = (_82_j) + (BigInteger.One);
        }
        _79_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_79_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        if ((_78_ctor).dtor_hasAnyArgs) {
          _81_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_81_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(f, \")\")?;"));
        }
        _81_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_81_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())"));
        _77_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_77_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _79_ctorMatch), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" => {\n")), _81_printRhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
        _53_i = (_53_i) + (BigInteger.One);
      }
      _77_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_77_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _84_defaultImpl;
      _84_defaultImpl = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_ctors).Count)).Sign == 1) {
        _84_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _73_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _48_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (((c).dtor_ctors).Select(BigInteger.Zero)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        _53_i = BigInteger.Zero;
        while ((_53_i) < (new BigInteger(((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Count))) {
          DAST._IFormal _85_formal;
          _85_formal = ((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Select(_53_i);
          _84_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_84_defaultImpl, (_85_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": std::default::Default::default(),\n"));
          _53_i = (_53_i) + (BigInteger.One);
        }
        _84_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_84_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_76_enumBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _77_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _84_defaultImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenPath(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      if ((new BigInteger((p).Count)).Sign == 0) {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Self");
        return s;
      } else {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("super::");
        BigInteger _86_i;
        _86_i = BigInteger.Zero;
        while ((_86_i) < (new BigInteger((p).Count))) {
          if ((_86_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((p).Select(_86_i)));
          _86_i = (_86_i) + (BigInteger.One);
        }
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenType(DAST._IType c, bool inBinding) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      DAST._IType _source4 = c;
      if (_source4.is_Path) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _87___mcc_h0 = _source4.dtor_Path_a0;
        Dafny.ISequence<DAST._IType> _88___mcc_h1 = _source4.dtor_typeArgs;
        DAST._IResolvedType _89___mcc_h2 = _source4.dtor_resolved;
        DAST._IResolvedType _90_resolved = _89___mcc_h2;
        Dafny.ISequence<DAST._IType> _91_args = _88___mcc_h1;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _92_p = _87___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _out18;
          _out18 = DCOMP.COMP.GenPath(_92_p);
          s = _out18;
          if ((new BigInteger((_91_args).Count)).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
            BigInteger _93_i;
            _93_i = BigInteger.Zero;
            while ((_93_i) < (new BigInteger((_91_args).Count))) {
              if ((_93_i).Sign == 1) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _94_genTp;
              Dafny.ISequence<Dafny.Rune> _out19;
              _out19 = DCOMP.COMP.GenType((_91_args).Select(_93_i), inBinding);
              _94_genTp = _out19;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _94_genTp);
              _93_i = (_93_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          DAST._IResolvedType _source5 = _90_resolved;
          if (_source5.is_Datatype) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _95___mcc_h16 = _source5.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source5.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _96___mcc_h18 = _source5.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IResolvedType _97_Primitive = _90_resolved;
          }
        }
      } else if (_source4.is_Tuple) {
        Dafny.ISequence<DAST._IType> _98___mcc_h3 = _source4.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _99_types = _98___mcc_h3;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _100_i;
          _100_i = BigInteger.Zero;
          while ((_100_i) < (new BigInteger((_99_types).Count))) {
            if ((_100_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _101_generated;
            Dafny.ISequence<Dafny.Rune> _out20;
            _out20 = DCOMP.COMP.GenType((_99_types).Select(_100_i), inBinding);
            _101_generated = _out20;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _101_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _100_i = (_100_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source4.is_Array) {
        DAST._IType _102___mcc_h4 = _source4.dtor_element;
        DAST._IType _103_element = _102___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _104_elemStr;
          Dafny.ISequence<Dafny.Rune> _out21;
          _out21 = DCOMP.COMP.GenType(_103_element, inBinding);
          _104_elemStr = _out21;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _104_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source4.is_Seq) {
        DAST._IType _105___mcc_h5 = _source4.dtor_element;
        DAST._IType _106_element = _105___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _107_elemStr;
          Dafny.ISequence<Dafny.Rune> _out22;
          _out22 = DCOMP.COMP.GenType(_106_element, inBinding);
          _107_elemStr = _out22;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _107_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source4.is_Set) {
        DAST._IType _108___mcc_h6 = _source4.dtor_element;
        DAST._IType _109_element = _108___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _110_elemStr;
          Dafny.ISequence<Dafny.Rune> _out23;
          _out23 = DCOMP.COMP.GenType(_109_element, inBinding);
          _110_elemStr = _out23;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _110_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source4.is_Multiset) {
        DAST._IType _111___mcc_h7 = _source4.dtor_element;
        DAST._IType _112_element = _111___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _113_elemStr;
          Dafny.ISequence<Dafny.Rune> _out24;
          _out24 = DCOMP.COMP.GenType(_112_element, inBinding);
          _113_elemStr = _out24;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _113_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source4.is_Map) {
        DAST._IType _114___mcc_h8 = _source4.dtor_key;
        DAST._IType _115___mcc_h9 = _source4.dtor_value;
        DAST._IType _116_value = _115___mcc_h9;
        DAST._IType _117_key = _114___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _118_keyStr;
          Dafny.ISequence<Dafny.Rune> _out25;
          _out25 = DCOMP.COMP.GenType(_117_key, inBinding);
          _118_keyStr = _out25;
          Dafny.ISequence<Dafny.Rune> _119_valueStr;
          Dafny.ISequence<Dafny.Rune> _out26;
          _out26 = DCOMP.COMP.GenType(_116_value, inBinding);
          _119_valueStr = _out26;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _118_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _119_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source4.is_Arrow) {
        Dafny.ISequence<DAST._IType> _120___mcc_h10 = _source4.dtor_args;
        DAST._IType _121___mcc_h11 = _source4.dtor_result;
        DAST._IType _122_result = _121___mcc_h11;
        Dafny.ISequence<DAST._IType> _123_args = _120___mcc_h10;
        {
          if (inBinding) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl Fn(");
            BigInteger _124_i;
            _124_i = BigInteger.Zero;
            while ((_124_i) < (new BigInteger((_123_args).Count))) {
              if ((_124_i).Sign == 1) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _125_generated;
              Dafny.ISequence<Dafny.Rune> _out27;
              _out27 = DCOMP.COMP.GenType((_123_args).Select(_124_i), inBinding);
              _125_generated = _out27;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _125_generated);
              _124_i = (_124_i) + (BigInteger.One);
            }
            Dafny.ISequence<Dafny.Rune> _126_resultType;
            Dafny.ISequence<Dafny.Rune> _out28;
            _out28 = DCOMP.COMP.GenType(_122_result, inBinding);
            _126_resultType = _out28;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _126_resultType);
          }
        }
      } else if (_source4.is_Primitive) {
        DAST._IPrimitive _127___mcc_h12 = _source4.dtor_Primitive_a0;
        DAST._IPrimitive _128_p = _127___mcc_h12;
        {
          DAST._IPrimitive _source6 = _128_p;
          if (_source6.is_String) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Vec<char>");
          } else if (_source6.is_Bool) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("bool");
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char");
          }
        }
      } else if (_source4.is_Passthrough) {
        Dafny.ISequence<Dafny.Rune> _129___mcc_h13 = _source4.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _130_v = _129___mcc_h13;
        s = _130_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _131___mcc_h14 = _source4.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source7 = _131___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _132___mcc_h15 = _source7;
        Dafny.ISequence<Dafny.Rune> _133_name = _132___mcc_h15;
        s = _133_name;
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenClassImplBody(Dafny.ISequence<DAST._IClassItem> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _134_i;
      _134_i = BigInteger.Zero;
      while ((_134_i) < (new BigInteger((body).Count))) {
        Dafny.ISequence<Dafny.Rune> _135_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        DAST._IClassItem _source8 = (body).Select(_134_i);
        if (_source8.is_Method) {
          DAST._IMethod _136___mcc_h0 = _source8.dtor_Method_a0;
          DAST._IMethod _137_m = _136___mcc_h0;
          Dafny.ISequence<Dafny.Rune> _out29;
          _out29 = DCOMP.COMP.GenMethod(_137_m, forTrait, enclosingType, enclosingTypeParams);
          _135_generated = _out29;
        } else {
          DAST._IFormal _138___mcc_h1 = _source8.dtor_Field_a0;
          DAST._IFormal _139_f = _138___mcc_h1;
          _135_generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("TODO");
        }
        if ((_134_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _135_generated);
        _134_i = (_134_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _140_i;
      _140_i = BigInteger.Zero;
      while ((_140_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _141_param;
        _141_param = (@params).Select(_140_i);
        Dafny.ISequence<Dafny.Rune> _142_paramType;
        Dafny.ISequence<Dafny.Rune> _out30;
        _out30 = DCOMP.COMP.GenType((_141_param).dtor_typ, false);
        _142_paramType = _out30;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_141_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _142_paramType);
        if ((_140_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _140_i = (_140_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _143_params;
      Dafny.ISequence<Dafny.Rune> _out31;
      _out31 = DCOMP.COMP.GenParams((m).dtor_params);
      _143_params = _out31;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _144_paramNames;
      _144_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _145_paramI;
      _145_paramI = BigInteger.Zero;
      while ((_145_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _144_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_144_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_145_paramI)).dtor_name));
        _145_paramI = (_145_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _143_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _143_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _146_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out32;
          _out32 = DCOMP.COMP.GenType(enclosingType, false);
          _146_enclosingTypeString = _out32;
          _143_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _146_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _143_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _147_retType;
      _147_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _148_typeI;
      _148_typeI = BigInteger.Zero;
      while ((_148_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_148_typeI).Sign == 1) {
          _147_retType = Dafny.Sequence<Dafny.Rune>.Concat(_147_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _149_typeString;
        Dafny.ISequence<Dafny.Rune> _out33;
        _out33 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_148_typeI), false);
        _149_typeString = _out33;
        _147_retType = Dafny.Sequence<Dafny.Rune>.Concat(_147_retType, _149_typeString);
        _148_typeI = (_148_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _147_retType = Dafny.Sequence<Dafny.Rune>.Concat(_147_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _150_typeParamsFiltered;
      _150_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _151_typeParamI;
      _151_typeParamI = BigInteger.Zero;
      while ((_151_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _152_typeParam;
        _152_typeParam = ((m).dtor_typeParams).Select(_151_typeParamI);
        if (!((enclosingTypeParams).Contains(_152_typeParam))) {
          _150_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_150_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_152_typeParam));
        }
        _151_typeParamI = (_151_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_150_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _153_i;
        _153_i = BigInteger.Zero;
        while ((_153_i) < (new BigInteger((_150_typeParamsFiltered).Count))) {
          if ((_153_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _154_typeString;
          Dafny.ISequence<Dafny.Rune> _out34;
          _out34 = DCOMP.COMP.GenType((_150_typeParamsFiltered).Select(_153_i), false);
          _154_typeString = _out34;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _154_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _153_i = (_153_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.Rune> _155_earlyReturn;
      _155_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
      DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source9 = (m).dtor_outVars;
      if (_source9.is_Some) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _156___mcc_h0 = _source9.dtor_Some_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _157_outVars = _156___mcc_h0;
        {
          _155_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
          BigInteger _158_outI;
          _158_outI = BigInteger.Zero;
          while ((_158_outI) < (new BigInteger((_157_outVars).Count))) {
            if ((_158_outI).Sign == 1) {
              _155_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_155_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _159_outVar;
            _159_outVar = (_157_outVars).Select(_158_outI);
            _155_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_155_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_159_outVar));
            _158_outI = (_158_outI) + (BigInteger.One);
          }
          _155_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_155_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else {
      }
      Dafny.ISequence<Dafny.Rune> _160_body;
      Dafny.ISequence<Dafny.Rune> _out35;
      _out35 = DCOMP.COMP.GenStmts((m).dtor_body, _144_paramNames, _155_earlyReturn);
      _160_body = _out35;
      DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (m).dtor_outVars;
      if (_source10.is_Some) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _161___mcc_h1 = _source10.dtor_Some_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _162_outVars = _161___mcc_h1;
        {
          _160_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_160_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _155_earlyReturn);
        }
      } else {
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _143_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _147_retType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _160_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenStmts(Dafny.ISequence<DAST._IStatement> stmts, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, Dafny.ISequence<Dafny.Rune> earlyReturn) {
      Dafny.ISequence<Dafny.Rune> generated = Dafny.Sequence<Dafny.Rune>.Empty;
      generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _163_i;
      _163_i = BigInteger.Zero;
      while ((_163_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _164_stmt;
        _164_stmt = (stmts).Select(_163_i);
        Dafny.ISequence<Dafny.Rune> _165_stmtString;
        Dafny.ISequence<Dafny.Rune> _out36;
        _out36 = DCOMP.COMP.GenStmt(_164_stmt, @params, earlyReturn);
        _165_stmtString = _out36;
        if ((_163_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _165_stmtString);
        _163_i = (_163_i) + (BigInteger.One);
      }
      return generated;
    }
    public static Dafny.ISequence<Dafny.Rune> GenStmt(DAST._IStatement stmt, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, Dafny.ISequence<Dafny.Rune> earlyReturn) {
      Dafny.ISequence<Dafny.Rune> generated = Dafny.Sequence<Dafny.Rune>.Empty;
      DAST._IStatement _source11 = stmt;
      if (_source11.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _166___mcc_h0 = _source11.dtor_name;
        DAST._IType _167___mcc_h1 = _source11.dtor_typ;
        DAST._IOptional<DAST._IExpression> _168___mcc_h2 = _source11.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source12 = _168___mcc_h2;
        if (_source12.is_Some) {
          DAST._IExpression _169___mcc_h3 = _source12.dtor_Some_a0;
          DAST._IExpression _170_expression = _169___mcc_h3;
          DAST._IType _171_typ = _167___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _172_name = _166___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _173_expr;
            bool _174___v8;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _175___v9;
            Dafny.ISequence<Dafny.Rune> _out37;
            bool _out38;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out39;
            DCOMP.COMP.GenExpr(_170_expression, @params, true, out _out37, out _out38, out _out39);
            _173_expr = _out37;
            _174___v8 = _out38;
            _175___v9 = _out39;
            Dafny.ISequence<Dafny.Rune> _176_typeString;
            Dafny.ISequence<Dafny.Rune> _out40;
            _out40 = DCOMP.COMP.GenType(_171_typ, true);
            _176_typeString = _out40;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _172_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _176_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _173_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        } else {
          DAST._IType _177_typ = _167___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _178_name = _166___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _179_typeString;
            Dafny.ISequence<Dafny.Rune> _out41;
            _out41 = DCOMP.COMP.GenType(_177_typ, true);
            _179_typeString = _out41;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _178_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _179_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source11.is_Assign) {
        Dafny.ISequence<Dafny.Rune> _180___mcc_h4 = _source11.dtor_name;
        DAST._IExpression _181___mcc_h5 = _source11.dtor_value;
        DAST._IExpression _182_expression = _181___mcc_h5;
        Dafny.ISequence<Dafny.Rune> _183_name = _180___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _184_expr;
          bool _185___v10;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _186___v11;
          Dafny.ISequence<Dafny.Rune> _out42;
          bool _out43;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out44;
          DCOMP.COMP.GenExpr(_182_expression, @params, true, out _out42, out _out43, out _out44);
          _184_expr = _out42;
          _185___v10 = _out43;
          _186___v11 = _out44;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _183_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _184_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
        }
      } else if (_source11.is_If) {
        DAST._IExpression _187___mcc_h6 = _source11.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _188___mcc_h7 = _source11.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _189___mcc_h8 = _source11.dtor_els;
        Dafny.ISequence<DAST._IStatement> _190_els = _189___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _191_thn = _188___mcc_h7;
        DAST._IExpression _192_cond = _187___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _193_condString;
          bool _194___v12;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _195___v13;
          Dafny.ISequence<Dafny.Rune> _out45;
          bool _out46;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out47;
          DCOMP.COMP.GenExpr(_192_cond, @params, true, out _out45, out _out46, out _out47);
          _193_condString = _out45;
          _194___v12 = _out46;
          _195___v13 = _out47;
          Dafny.ISequence<Dafny.Rune> _196_thnString;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenStmts(_191_thn, @params, earlyReturn);
          _196_thnString = _out48;
          Dafny.ISequence<Dafny.Rune> _197_elsString;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenStmts(_190_els, @params, earlyReturn);
          _197_elsString = _out49;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _193_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _196_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _197_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source11.is_While) {
        DAST._IExpression _198___mcc_h9 = _source11.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _199___mcc_h10 = _source11.dtor_body;
        Dafny.ISequence<DAST._IStatement> _200_body = _199___mcc_h10;
        DAST._IExpression _201_cond = _198___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _202_condString;
          bool _203___v14;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _204___v15;
          Dafny.ISequence<Dafny.Rune> _out50;
          bool _out51;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out52;
          DCOMP.COMP.GenExpr(_201_cond, @params, true, out _out50, out _out51, out _out52);
          _202_condString = _out50;
          _203___v14 = _out51;
          _204___v15 = _out52;
          Dafny.ISequence<Dafny.Rune> _205_bodyString;
          Dafny.ISequence<Dafny.Rune> _out53;
          _out53 = DCOMP.COMP.GenStmts(_200_body, @params, earlyReturn);
          _205_bodyString = _out53;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _202_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _205_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source11.is_Call) {
        DAST._IExpression _206___mcc_h11 = _source11.dtor_on;
        Dafny.ISequence<Dafny.Rune> _207___mcc_h12 = _source11.dtor_name;
        Dafny.ISequence<DAST._IType> _208___mcc_h13 = _source11.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _209___mcc_h14 = _source11.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _210___mcc_h15 = _source11.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _211_maybeOutVars = _210___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _212_args = _209___mcc_h14;
        Dafny.ISequence<DAST._IType> _213_typeArgs = _208___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _214_name = _207___mcc_h12;
        DAST._IExpression _215_on = _206___mcc_h11;
        {
          Dafny.ISequence<Dafny.Rune> _216_typeArgString;
          _216_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_213_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _217_typeI;
            _217_typeI = BigInteger.Zero;
            _216_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_217_typeI) < (new BigInteger((_213_typeArgs).Count))) {
              if ((_217_typeI).Sign == 1) {
                _216_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_216_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _218_typeString;
              Dafny.ISequence<Dafny.Rune> _out54;
              _out54 = DCOMP.COMP.GenType((_213_typeArgs).Select(_217_typeI), false);
              _218_typeString = _out54;
              _216_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_216_typeArgString, _218_typeString);
              _217_typeI = (_217_typeI) + (BigInteger.One);
            }
            _216_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_216_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _219_argString;
          _219_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _220_i;
          _220_i = BigInteger.Zero;
          while ((_220_i) < (new BigInteger((_212_args).Count))) {
            if ((_220_i).Sign == 1) {
              _219_argString = Dafny.Sequence<Dafny.Rune>.Concat(_219_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _221_argExpr;
            bool _222_isOwned;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _223___v16;
            Dafny.ISequence<Dafny.Rune> _out55;
            bool _out56;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out57;
            DCOMP.COMP.GenExpr((_212_args).Select(_220_i), @params, false, out _out55, out _out56, out _out57);
            _221_argExpr = _out55;
            _222_isOwned = _out56;
            _223___v16 = _out57;
            _219_argString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_219_argString, ((_222_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _221_argExpr);
            _220_i = (_220_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _224_enclosingString;
          bool _225___v17;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _226___v18;
          Dafny.ISequence<Dafny.Rune> _out58;
          bool _out59;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out60;
          DCOMP.COMP.GenExpr(_215_on, @params, true, out _out58, out _out59, out _out60);
          _224_enclosingString = _out58;
          _225___v17 = _out59;
          _226___v18 = _out60;
          DAST._IExpression _source13 = _215_on;
          if (_source13.is_Literal) {
            DAST._ILiteral _227___mcc_h18 = _source13.dtor_Literal_a0;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _228___mcc_h20 = _source13.dtor_Ident_a0;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _229___mcc_h22 = _source13.dtor_Companion_a0;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_224_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source13.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _230___mcc_h24 = _source13.dtor_Tuple_a0;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _231___mcc_h26 = _source13.dtor_path;
            Dafny.ISequence<DAST._IExpression> _232___mcc_h27 = _source13.dtor_args;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _233___mcc_h30 = _source13.dtor_dims;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _234___mcc_h32 = _source13.dtor_path;
            Dafny.ISequence<Dafny.Rune> _235___mcc_h33 = _source13.dtor_variant;
            bool _236___mcc_h34 = _source13.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _237___mcc_h35 = _source13.dtor_contents;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_NewtypeValue) {
            DAST._IType _238___mcc_h40 = _source13.dtor_tpe;
            DAST._IExpression _239___mcc_h41 = _source13.dtor_value;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _240___mcc_h44 = _source13.dtor_elements;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _241___mcc_h46 = _source13.dtor_elements;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_This) {
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_Ite) {
            DAST._IExpression _242___mcc_h48 = _source13.dtor_cond;
            DAST._IExpression _243___mcc_h49 = _source13.dtor_thn;
            DAST._IExpression _244___mcc_h50 = _source13.dtor_els;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_UnOp) {
            DAST._IUnaryOp _245___mcc_h54 = _source13.dtor_unOp;
            DAST._IExpression _246___mcc_h55 = _source13.dtor_expr;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _247___mcc_h58 = _source13.dtor_op;
            DAST._IExpression _248___mcc_h59 = _source13.dtor_left;
            DAST._IExpression _249___mcc_h60 = _source13.dtor_right;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_Select) {
            DAST._IExpression _250___mcc_h64 = _source13.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _251___mcc_h65 = _source13.dtor_field;
            bool _252___mcc_h66 = _source13.dtor_onDatatype;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_SelectFn) {
            DAST._IExpression _253___mcc_h70 = _source13.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _254___mcc_h71 = _source13.dtor_field;
            bool _255___mcc_h72 = _source13.dtor_onDatatype;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_TupleSelect) {
            DAST._IExpression _256___mcc_h76 = _source13.dtor_expr;
            BigInteger _257___mcc_h77 = _source13.dtor_index;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_Call) {
            DAST._IExpression _258___mcc_h80 = _source13.dtor_on;
            Dafny.ISequence<Dafny.Rune> _259___mcc_h81 = _source13.dtor_name;
            Dafny.ISequence<DAST._IType> _260___mcc_h82 = _source13.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _261___mcc_h83 = _source13.dtor_args;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_Apply) {
            DAST._IExpression _262___mcc_h88 = _source13.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _263___mcc_h89 = _source13.dtor_args;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source13.is_TypeTest) {
            DAST._IExpression _264___mcc_h92 = _source13.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _265___mcc_h93 = _source13.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _266___mcc_h94 = _source13.dtor_variant;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _267___mcc_h98 = _source13.dtor_typ;
            {
              _224_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _268_receiver;
          _268_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source14 = _211_maybeOutVars;
          if (_source14.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _269___mcc_h100 = _source14.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _270_outVars = _269___mcc_h100;
            {
              if ((new BigInteger((_270_outVars).Count)) > (BigInteger.One)) {
                _268_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _271_outI;
              _271_outI = BigInteger.Zero;
              while ((_271_outI) < (new BigInteger((_270_outVars).Count))) {
                if ((_271_outI).Sign == 1) {
                  _268_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_268_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _272_outVar;
                _272_outVar = (_270_outVars).Select(_271_outI);
                _268_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_268_receiver, (_272_outVar));
                _271_outI = (_271_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_270_outVars).Count)) > (BigInteger.One)) {
                _268_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_268_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_268_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_268_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _224_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _214_name), _216_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _219_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source11.is_Return) {
        DAST._IExpression _273___mcc_h16 = _source11.dtor_expr;
        DAST._IExpression _274_expr = _273___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _275_exprString;
          bool _276___v21;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _277___v22;
          Dafny.ISequence<Dafny.Rune> _out61;
          bool _out62;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out63;
          DCOMP.COMP.GenExpr(_274_expr, @params, true, out _out61, out _out62, out _out63);
          _275_exprString = _out61;
          _276___v21 = _out62;
          _277___v22 = _out63;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _275_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
        }
      } else if (_source11.is_EarlyReturn) {
        {
          generated = earlyReturn;
        }
      } else if (_source11.is_Halt) {
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("panic!(\"Halt\");");
        }
      } else {
        DAST._IExpression _278___mcc_h17 = _source11.dtor_Print_a0;
        DAST._IExpression _279_e = _278___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _280_printedExpr;
          bool _281_isOwned;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _282___v23;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out66;
          DCOMP.COMP.GenExpr(_279_e, @params, false, out _out64, out _out65, out _out66);
          _280_printedExpr = _out64;
          _281_isOwned = _out65;
          _282___v23 = _out66;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_281_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _280_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
        }
      }
      return generated;
    }
    public static void GenExpr(DAST._IExpression e, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source15 = e;
      if (_source15.is_Literal) {
        DAST._ILiteral _283___mcc_h0 = _source15.dtor_Literal_a0;
        DAST._ILiteral _source16 = _283___mcc_h0;
        if (_source16.is_BoolLiteral) {
          bool _284___mcc_h1 = _source16.dtor_BoolLiteral_a0;
          if ((_284___mcc_h1) == (false)) {
            {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("false");
              isOwned = true;
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
            }
          } else {
            {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("true");
              isOwned = true;
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
            }
          }
        } else if (_source16.is_IntLiteral) {
          BigInteger _285___mcc_h2 = _source16.dtor_IntLiteral_a0;
          BigInteger _286_i = _285___mcc_h2;
          {
            if ((_286_i).Sign == -1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("-"), DCOMP.__default.natToString((BigInteger.Zero) - (_286_i)));
            } else {
              s = DCOMP.__default.natToString(_286_i);
            }
            isOwned = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source16.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _287___mcc_h3 = _source16.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _288_l = _287___mcc_h3;
          {
            s = _288_l;
            isOwned = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source16.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _289___mcc_h4 = _source16.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _290_l = _289___mcc_h4;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _290_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source16.is_CharLiteral) {
          Dafny.Rune _291___mcc_h5 = _source16.dtor_CharLiteral_a0;
          Dafny.Rune _292_c = _291___mcc_h5;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_292_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
            isOwned = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else {
          {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("None");
            isOwned = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _293___mcc_h6 = _source15.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _294_name = _293___mcc_h6;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _294_name);
          if ((@params).Contains(_294_name)) {
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
              isOwned = true;
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              isOwned = false;
            }
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_294_name);
        }
      } else if (_source15.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _295___mcc_h7 = _source15.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _296_path = _295___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _out67;
          _out67 = DCOMP.COMP.GenPath(_296_path);
          s = _out67;
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _297___mcc_h8 = _source15.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _298_values = _297___mcc_h8;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _299_i;
          _299_i = BigInteger.Zero;
          while ((_299_i) < (new BigInteger((_298_values).Count))) {
            if ((_299_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _300_recursiveGen;
            bool _301___v24;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _302_recIdents;
            Dafny.ISequence<Dafny.Rune> _out68;
            bool _out69;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out70;
            DCOMP.COMP.GenExpr((_298_values).Select(_299_i), @params, true, out _out68, out _out69, out _out70);
            _300_recursiveGen = _out68;
            _301___v24 = _out69;
            _302_recIdents = _out70;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _300_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _302_recIdents);
            _299_i = (_299_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
        }
      } else if (_source15.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _303___mcc_h9 = _source15.dtor_path;
        Dafny.ISequence<DAST._IExpression> _304___mcc_h10 = _source15.dtor_args;
        Dafny.ISequence<DAST._IExpression> _305_args = _304___mcc_h10;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _306_path = _303___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _307_path;
          Dafny.ISequence<Dafny.Rune> _out71;
          _out71 = DCOMP.COMP.GenPath(_306_path);
          _307_path = _out71;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _307_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _308_i;
          _308_i = BigInteger.Zero;
          while ((_308_i) < (new BigInteger((_305_args).Count))) {
            if ((_308_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _309_recursiveGen;
            bool _310___v25;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _311_recIdents;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out74;
            DCOMP.COMP.GenExpr((_305_args).Select(_308_i), @params, true, out _out72, out _out73, out _out74);
            _309_recursiveGen = _out72;
            _310___v25 = _out73;
            _311_recIdents = _out74;
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _309_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _311_recIdents);
            _308_i = (_308_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
        }
      } else if (_source15.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _312___mcc_h11 = _source15.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _313_dims = _312___mcc_h11;
        {
          BigInteger _314_i;
          _314_i = (new BigInteger((_313_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_314_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _315_recursiveGen;
            bool _316___v26;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _317_recIdents;
            Dafny.ISequence<Dafny.Rune> _out75;
            bool _out76;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out77;
            DCOMP.COMP.GenExpr((_313_dims).Select(_314_i), @params, true, out _out75, out _out76, out _out77);
            _315_recursiveGen = _out75;
            _316___v26 = _out76;
            _317_recIdents = _out77;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; (")), _315_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as usize]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _317_recIdents);
            _314_i = (_314_i) - (BigInteger.One);
          }
          isOwned = true;
        }
      } else if (_source15.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _318___mcc_h12 = _source15.dtor_path;
        Dafny.ISequence<Dafny.Rune> _319___mcc_h13 = _source15.dtor_variant;
        bool _320___mcc_h14 = _source15.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _321___mcc_h15 = _source15.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _322_values = _321___mcc_h15;
        bool _323_isCo = _320___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _324_variant = _319___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _325_path = _318___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _326_path;
          Dafny.ISequence<Dafny.Rune> _out78;
          _out78 = DCOMP.COMP.GenPath(_325_path);
          _326_path = _out78;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _326_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _324_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _327_i;
          _327_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_327_i) < (new BigInteger((_322_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs1 = (_322_values).Select(_327_i);
            Dafny.ISequence<Dafny.Rune> _328_name = _let_tmp_rhs1.dtor__0;
            DAST._IExpression _329_value = _let_tmp_rhs1.dtor__1;
            if ((_327_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_323_isCo) {
              Dafny.ISequence<Dafny.Rune> _330_recursiveGen;
              bool _331___v27;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _332_recIdents;
              Dafny.ISequence<Dafny.Rune> _out79;
              bool _out80;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out81;
              DCOMP.COMP.GenExpr(_329_value, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out79, out _out80, out _out81);
              _330_recursiveGen = _out79;
              _331___v27 = _out80;
              _332_recIdents = _out81;
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _332_recIdents);
              Dafny.ISequence<Dafny.Rune> _333_allReadCloned;
              _333_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_332_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _334_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_332_recIdents).Elements) {
                  _334_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_332_recIdents).Contains(_334_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 809)");
              after__ASSIGN_SUCH_THAT_0:;
                _333_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_333_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _334_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _334_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _332_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_332_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_334_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _328_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(Box::new({\n")), _333_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _330_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _335_recursiveGen;
              bool _336___v28;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _337_recIdents;
              Dafny.ISequence<Dafny.Rune> _out82;
              bool _out83;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
              DCOMP.COMP.GenExpr(_329_value, @params, true, out _out82, out _out83, out _out84);
              _335_recursiveGen = _out82;
              _336___v28 = _out83;
              _337_recIdents = _out84;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _328_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _335_recursiveGen);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _337_recIdents);
            }
            _327_i = (_327_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
        }
      } else if (_source15.is_NewtypeValue) {
        DAST._IType _338___mcc_h16 = _source15.dtor_tpe;
        DAST._IExpression _339___mcc_h17 = _source15.dtor_value;
        DAST._IExpression _340_expr = _339___mcc_h17;
        DAST._IType _341_tpe = _338___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _342_typeString;
          Dafny.ISequence<Dafny.Rune> _out85;
          _out85 = DCOMP.COMP.GenType(_341_tpe, false);
          _342_typeString = _out85;
          Dafny.ISequence<Dafny.Rune> _343_recursiveGen;
          bool _344___v29;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _345_recIdents;
          Dafny.ISequence<Dafny.Rune> _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_340_expr, @params, true, out _out86, out _out87, out _out88);
          _343_recursiveGen = _out86;
          _344___v29 = _out87;
          _345_recIdents = _out88;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_342_typeString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _343_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          readIdents = _345_recIdents;
        }
      } else if (_source15.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _346___mcc_h18 = _source15.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _347_exprs = _346___mcc_h18;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _348_generatedValues;
          _348_generatedValues = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _349_i;
          _349_i = BigInteger.Zero;
          while ((_349_i) < (new BigInteger((_347_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _350_recursiveGen;
            bool _351___v30;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _352_recIdents;
            Dafny.ISequence<Dafny.Rune> _out89;
            bool _out90;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out91;
            DCOMP.COMP.GenExpr((_347_exprs).Select(_349_i), @params, true, out _out89, out _out90, out _out91);
            _350_recursiveGen = _out89;
            _351___v30 = _out90;
            _352_recIdents = _out91;
            _348_generatedValues = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_348_generatedValues, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(_350_recursiveGen));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _352_recIdents);
            _349_i = (_349_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _349_i = BigInteger.Zero;
          while ((_349_i) < (new BigInteger((_348_generatedValues).Count))) {
            if ((_349_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, (_348_generatedValues).Select(_349_i));
            _349_i = (_349_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
        }
      } else if (_source15.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _353___mcc_h19 = _source15.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _354_exprs = _353___mcc_h19;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _355_generatedValues;
          _355_generatedValues = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _356_i;
          _356_i = BigInteger.Zero;
          while ((_356_i) < (new BigInteger((_354_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _357_recursiveGen;
            bool _358___v31;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _359_recIdents;
            Dafny.ISequence<Dafny.Rune> _out92;
            bool _out93;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
            DCOMP.COMP.GenExpr((_354_exprs).Select(_356_i), @params, true, out _out92, out _out93, out _out94);
            _357_recursiveGen = _out92;
            _358___v31 = _out93;
            _359_recIdents = _out94;
            _355_generatedValues = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_355_generatedValues, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(_357_recursiveGen));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _359_recIdents);
            _356_i = (_356_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _356_i = BigInteger.Zero;
          while ((_356_i) < (new BigInteger((_355_generatedValues).Count))) {
            if ((_356_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, (_355_generatedValues).Select(_356_i));
            _356_i = (_356_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
        }
      } else if (_source15.is_This) {
        {
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.clone()");
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
            isOwned = false;
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"));
        }
      } else if (_source15.is_Ite) {
        DAST._IExpression _360___mcc_h20 = _source15.dtor_cond;
        DAST._IExpression _361___mcc_h21 = _source15.dtor_thn;
        DAST._IExpression _362___mcc_h22 = _source15.dtor_els;
        DAST._IExpression _363_f = _362___mcc_h22;
        DAST._IExpression _364_t = _361___mcc_h21;
        DAST._IExpression _365_cond = _360___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _366_condString;
          bool _367___v32;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _368_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out95;
          bool _out96;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out97;
          DCOMP.COMP.GenExpr(_365_cond, @params, true, out _out95, out _out96, out _out97);
          _366_condString = _out95;
          _367___v32 = _out96;
          _368_recIdentsCond = _out97;
          Dafny.ISequence<Dafny.Rune> _369___v33;
          bool _370_tHasToBeOwned;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _371___v34;
          Dafny.ISequence<Dafny.Rune> _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_364_t, @params, mustOwn, out _out98, out _out99, out _out100);
          _369___v33 = _out98;
          _370_tHasToBeOwned = _out99;
          _371___v34 = _out100;
          Dafny.ISequence<Dafny.Rune> _372_fString;
          bool _373_fOwned;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _374_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out101;
          bool _out102;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out103;
          DCOMP.COMP.GenExpr(_363_f, @params, _370_tHasToBeOwned, out _out101, out _out102, out _out103);
          _372_fString = _out101;
          _373_fOwned = _out102;
          _374_recIdentsF = _out103;
          Dafny.ISequence<Dafny.Rune> _375_tString;
          bool _376___v35;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _377_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out104;
          bool _out105;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out106;
          DCOMP.COMP.GenExpr(_364_t, @params, _373_fOwned, out _out104, out _out105, out _out106);
          _375_tString = _out104;
          _376___v35 = _out105;
          _377_recIdentsT = _out106;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _366_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _375_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _372_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _373_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_368_recIdentsCond, _377_recIdentsT), _374_recIdentsF);
        }
      } else if (_source15.is_UnOp) {
        DAST._IUnaryOp _378___mcc_h23 = _source15.dtor_unOp;
        DAST._IExpression _379___mcc_h24 = _source15.dtor_expr;
        DAST._IUnaryOp _source17 = _378___mcc_h23;
        if (_source17.is_Not) {
          DAST._IExpression _380_e = _379___mcc_h24;
          {
            Dafny.ISequence<Dafny.Rune> _381_recursiveGen;
            bool _382___v36;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _383_recIdents;
            Dafny.ISequence<Dafny.Rune> _out107;
            bool _out108;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out109;
            DCOMP.COMP.GenExpr(_380_e, @params, true, out _out107, out _out108, out _out109);
            _381_recursiveGen = _out107;
            _382___v36 = _out108;
            _383_recIdents = _out109;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _381_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _383_recIdents;
          }
        } else if (_source17.is_BitwiseNot) {
          DAST._IExpression _384_e = _379___mcc_h24;
          {
            Dafny.ISequence<Dafny.Rune> _385_recursiveGen;
            bool _386___v37;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _387_recIdents;
            Dafny.ISequence<Dafny.Rune> _out110;
            bool _out111;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out112;
            DCOMP.COMP.GenExpr(_384_e, @params, true, out _out110, out _out111, out _out112);
            _385_recursiveGen = _out110;
            _386___v37 = _out111;
            _387_recIdents = _out112;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _385_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _387_recIdents;
          }
        } else {
          DAST._IExpression _388_e = _379___mcc_h24;
          {
            Dafny.ISequence<Dafny.Rune> _389_recursiveGen;
            bool _390___v38;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _391_recIdents;
            Dafny.ISequence<Dafny.Rune> _out113;
            bool _out114;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
            DCOMP.COMP.GenExpr(_388_e, @params, false, out _out113, out _out114, out _out115);
            _389_recursiveGen = _out113;
            _390___v38 = _out114;
            _391_recIdents = _out115;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _389_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len()"));
            isOwned = true;
            readIdents = _391_recIdents;
          }
        }
      } else if (_source15.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _392___mcc_h25 = _source15.dtor_op;
        DAST._IExpression _393___mcc_h26 = _source15.dtor_left;
        DAST._IExpression _394___mcc_h27 = _source15.dtor_right;
        DAST._IExpression _395_r = _394___mcc_h27;
        DAST._IExpression _396_l = _393___mcc_h26;
        Dafny.ISequence<Dafny.Rune> _397_op = _392___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _398_left;
          bool _399___v39;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _400_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out116;
          bool _out117;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out118;
          DCOMP.COMP.GenExpr(_396_l, @params, true, out _out116, out _out117, out _out118);
          _398_left = _out116;
          _399___v39 = _out117;
          _400_recIdentsL = _out118;
          Dafny.ISequence<Dafny.Rune> _401_right;
          bool _402___v40;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _403_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_395_r, @params, true, out _out119, out _out120, out _out121);
          _401_right = _out119;
          _402___v40 = _out120;
          _403_recIdentsR = _out121;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _398_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _397_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _401_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_400_recIdentsL, _403_recIdentsR);
        }
      } else if (_source15.is_Select) {
        DAST._IExpression _404___mcc_h28 = _source15.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _405___mcc_h29 = _source15.dtor_field;
        bool _406___mcc_h30 = _source15.dtor_onDatatype;
        bool _407_isDatatype = _406___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _408_field = _405___mcc_h29;
        DAST._IExpression _409_on = _404___mcc_h28;
        {
          Dafny.ISequence<Dafny.Rune> _410_onString;
          bool _411___v44;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _412_recIdents;
          Dafny.ISequence<Dafny.Rune> _out122;
          bool _out123;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out124;
          DCOMP.COMP.GenExpr(_409_on, @params, false, out _out122, out _out123, out _out124);
          _410_onString = _out122;
          _411___v44 = _out123;
          _412_recIdents = _out124;
          if (_407_isDatatype) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _410_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _408_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _410_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _408_field);
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          }
          readIdents = _412_recIdents;
        }
      } else if (_source15.is_SelectFn) {
        DAST._IExpression _413___mcc_h31 = _source15.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _414___mcc_h32 = _source15.dtor_field;
        bool _415___mcc_h33 = _source15.dtor_onDatatype;
        bool _416_isDatatype = _415___mcc_h33;
        Dafny.ISequence<Dafny.Rune> _417_field = _414___mcc_h32;
        DAST._IExpression _418_on = _413___mcc_h31;
        {
          Dafny.ISequence<Dafny.Rune> _419_onString;
          bool _420___v41;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _421_recIdents;
          Dafny.ISequence<Dafny.Rune> _out125;
          bool _out126;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out127;
          DCOMP.COMP.GenExpr(_418_on, @params, false, out _out125, out _out126, out _out127);
          _419_onString = _out125;
          _420___v41 = _out126;
          _421_recIdents = _out127;
          Dafny.Helpers.Print((_418_on));
          DAST._IExpression _source18 = _418_on;
          if (_source18.is_Literal) {
            DAST._ILiteral _422___mcc_h46 = _source18.dtor_Literal_a0;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _423___mcc_h48 = _source18.dtor_Ident_a0;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _424___mcc_h50 = _source18.dtor_Companion_a0;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _425___mcc_h52 = _source18.dtor_Tuple_a0;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _426___mcc_h54 = _source18.dtor_path;
            Dafny.ISequence<DAST._IExpression> _427___mcc_h55 = _source18.dtor_args;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _428___mcc_h58 = _source18.dtor_dims;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _429___mcc_h60 = _source18.dtor_path;
            Dafny.ISequence<Dafny.Rune> _430___mcc_h61 = _source18.dtor_variant;
            bool _431___mcc_h62 = _source18.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _432___mcc_h63 = _source18.dtor_contents;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_NewtypeValue) {
            DAST._IType _433___mcc_h68 = _source18.dtor_tpe;
            DAST._IExpression _434___mcc_h69 = _source18.dtor_value;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _435___mcc_h72 = _source18.dtor_elements;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _436___mcc_h74 = _source18.dtor_elements;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_This) {
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Ite) {
            DAST._IExpression _437___mcc_h76 = _source18.dtor_cond;
            DAST._IExpression _438___mcc_h77 = _source18.dtor_thn;
            DAST._IExpression _439___mcc_h78 = _source18.dtor_els;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_UnOp) {
            DAST._IUnaryOp _440___mcc_h82 = _source18.dtor_unOp;
            DAST._IExpression _441___mcc_h83 = _source18.dtor_expr;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _442___mcc_h86 = _source18.dtor_op;
            DAST._IExpression _443___mcc_h87 = _source18.dtor_left;
            DAST._IExpression _444___mcc_h88 = _source18.dtor_right;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Select) {
            DAST._IExpression _445___mcc_h92 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _446___mcc_h93 = _source18.dtor_field;
            bool _447___mcc_h94 = _source18.dtor_onDatatype;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_SelectFn) {
            DAST._IExpression _448___mcc_h98 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _449___mcc_h99 = _source18.dtor_field;
            bool _450___mcc_h100 = _source18.dtor_onDatatype;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_TupleSelect) {
            DAST._IExpression _451___mcc_h104 = _source18.dtor_expr;
            BigInteger _452___mcc_h105 = _source18.dtor_index;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Call) {
            DAST._IExpression _453___mcc_h108 = _source18.dtor_on;
            Dafny.ISequence<Dafny.Rune> _454___mcc_h109 = _source18.dtor_name;
            Dafny.ISequence<DAST._IType> _455___mcc_h110 = _source18.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _456___mcc_h111 = _source18.dtor_args;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_Apply) {
            DAST._IExpression _457___mcc_h116 = _source18.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _458___mcc_h117 = _source18.dtor_args;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else if (_source18.is_TypeTest) {
            DAST._IExpression _459___mcc_h120 = _source18.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _460___mcc_h121 = _source18.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _461___mcc_h122 = _source18.dtor_variant;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          } else {
            DAST._IType _462___mcc_h126 = _source18.dtor_typ;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_419_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _417_field);
              isOwned = true;
              readIdents = _421_recIdents;
            }
          }
        }
      } else if (_source15.is_TupleSelect) {
        DAST._IExpression _463___mcc_h34 = _source15.dtor_expr;
        BigInteger _464___mcc_h35 = _source15.dtor_index;
        BigInteger _465_idx = _464___mcc_h35;
        DAST._IExpression _466_on = _463___mcc_h34;
        {
          Dafny.ISequence<Dafny.Rune> _467_onString;
          bool _468___v45;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _469_recIdents;
          Dafny.ISequence<Dafny.Rune> _out128;
          bool _out129;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
          DCOMP.COMP.GenExpr(_466_on, @params, false, out _out128, out _out129, out _out130);
          _467_onString = _out128;
          _468___v45 = _out129;
          _469_recIdents = _out130;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _467_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_465_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          readIdents = _469_recIdents;
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _470___mcc_h36 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _471___mcc_h37 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _472___mcc_h38 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _473___mcc_h39 = _source15.dtor_args;
        Dafny.ISequence<DAST._IExpression> _474_args = _473___mcc_h39;
        Dafny.ISequence<DAST._IType> _475_typeArgs = _472___mcc_h38;
        Dafny.ISequence<Dafny.Rune> _476_name = _471___mcc_h37;
        DAST._IExpression _477_on = _470___mcc_h36;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _478_typeArgString;
          _478_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_475_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _479_typeI;
            _479_typeI = BigInteger.Zero;
            _478_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_479_typeI) < (new BigInteger((_475_typeArgs).Count))) {
              if ((_479_typeI).Sign == 1) {
                _478_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_478_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _480_typeString;
              Dafny.ISequence<Dafny.Rune> _out131;
              _out131 = DCOMP.COMP.GenType((_475_typeArgs).Select(_479_typeI), false);
              _480_typeString = _out131;
              _478_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_478_typeArgString, _480_typeString);
              _479_typeI = (_479_typeI) + (BigInteger.One);
            }
            _478_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_478_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _481_argString;
          _481_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _482_i;
          _482_i = BigInteger.Zero;
          while ((_482_i) < (new BigInteger((_474_args).Count))) {
            if ((_482_i).Sign == 1) {
              _481_argString = Dafny.Sequence<Dafny.Rune>.Concat(_481_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _483_argExpr;
            bool _484_isOwned;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _485_recIdents;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out134;
            DCOMP.COMP.GenExpr((_474_args).Select(_482_i), @params, false, out _out132, out _out133, out _out134);
            _483_argExpr = _out132;
            _484_isOwned = _out133;
            _485_recIdents = _out134;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _485_recIdents);
            _481_argString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_481_argString, ((_484_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _483_argExpr);
            _482_i = (_482_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _486_enclosingString;
          bool _487___v46;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _488_recIdents;
          Dafny.ISequence<Dafny.Rune> _out135;
          bool _out136;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out137;
          DCOMP.COMP.GenExpr(_477_on, @params, false, out _out135, out _out136, out _out137);
          _486_enclosingString = _out135;
          _487___v46 = _out136;
          _488_recIdents = _out137;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _488_recIdents);
          DAST._IExpression _source19 = _477_on;
          if (_source19.is_Literal) {
            DAST._ILiteral _489___mcc_h128 = _source19.dtor_Literal_a0;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _490___mcc_h130 = _source19.dtor_Ident_a0;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _491___mcc_h132 = _source19.dtor_Companion_a0;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_486_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source19.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _492___mcc_h134 = _source19.dtor_Tuple_a0;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _493___mcc_h136 = _source19.dtor_path;
            Dafny.ISequence<DAST._IExpression> _494___mcc_h137 = _source19.dtor_args;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _495___mcc_h140 = _source19.dtor_dims;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _496___mcc_h142 = _source19.dtor_path;
            Dafny.ISequence<Dafny.Rune> _497___mcc_h143 = _source19.dtor_variant;
            bool _498___mcc_h144 = _source19.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _499___mcc_h145 = _source19.dtor_contents;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_NewtypeValue) {
            DAST._IType _500___mcc_h150 = _source19.dtor_tpe;
            DAST._IExpression _501___mcc_h151 = _source19.dtor_value;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _502___mcc_h154 = _source19.dtor_elements;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _503___mcc_h156 = _source19.dtor_elements;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_This) {
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Ite) {
            DAST._IExpression _504___mcc_h158 = _source19.dtor_cond;
            DAST._IExpression _505___mcc_h159 = _source19.dtor_thn;
            DAST._IExpression _506___mcc_h160 = _source19.dtor_els;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_UnOp) {
            DAST._IUnaryOp _507___mcc_h164 = _source19.dtor_unOp;
            DAST._IExpression _508___mcc_h165 = _source19.dtor_expr;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _509___mcc_h168 = _source19.dtor_op;
            DAST._IExpression _510___mcc_h169 = _source19.dtor_left;
            DAST._IExpression _511___mcc_h170 = _source19.dtor_right;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Select) {
            DAST._IExpression _512___mcc_h174 = _source19.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _513___mcc_h175 = _source19.dtor_field;
            bool _514___mcc_h176 = _source19.dtor_onDatatype;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_SelectFn) {
            DAST._IExpression _515___mcc_h180 = _source19.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _516___mcc_h181 = _source19.dtor_field;
            bool _517___mcc_h182 = _source19.dtor_onDatatype;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_TupleSelect) {
            DAST._IExpression _518___mcc_h186 = _source19.dtor_expr;
            BigInteger _519___mcc_h187 = _source19.dtor_index;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Call) {
            DAST._IExpression _520___mcc_h190 = _source19.dtor_on;
            Dafny.ISequence<Dafny.Rune> _521___mcc_h191 = _source19.dtor_name;
            Dafny.ISequence<DAST._IType> _522___mcc_h192 = _source19.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _523___mcc_h193 = _source19.dtor_args;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_Apply) {
            DAST._IExpression _524___mcc_h198 = _source19.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _525___mcc_h199 = _source19.dtor_args;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source19.is_TypeTest) {
            DAST._IExpression _526___mcc_h202 = _source19.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _527___mcc_h203 = _source19.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _528___mcc_h204 = _source19.dtor_variant;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _529___mcc_h208 = _source19.dtor_typ;
            {
              _486_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _486_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_486_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _476_name), _478_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _481_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
        }
      } else if (_source15.is_Apply) {
        DAST._IExpression _530___mcc_h40 = _source15.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _531___mcc_h41 = _source15.dtor_args;
        Dafny.ISequence<DAST._IExpression> _532_args = _531___mcc_h41;
        DAST._IExpression _533_func = _530___mcc_h40;
        {
          Dafny.ISequence<Dafny.Rune> _534_funcString;
          bool _535___v49;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _536_recIdents;
          Dafny.ISequence<Dafny.Rune> _out138;
          bool _out139;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out140;
          DCOMP.COMP.GenExpr(_533_func, @params, false, out _out138, out _out139, out _out140);
          _534_funcString = _out138;
          _535___v49 = _out139;
          _536_recIdents = _out140;
          readIdents = _536_recIdents;
          Dafny.ISequence<Dafny.Rune> _537_argString;
          _537_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _538_i;
          _538_i = BigInteger.Zero;
          while ((_538_i) < (new BigInteger((_532_args).Count))) {
            if ((_538_i).Sign == 1) {
              _537_argString = Dafny.Sequence<Dafny.Rune>.Concat(_537_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _539_argExpr;
            bool _540_isOwned;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _541_recIdents;
            Dafny.ISequence<Dafny.Rune> _out141;
            bool _out142;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out143;
            DCOMP.COMP.GenExpr((_532_args).Select(_538_i), @params, false, out _out141, out _out142, out _out143);
            _539_argExpr = _out141;
            _540_isOwned = _out142;
            _541_recIdents = _out143;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _541_recIdents);
            _537_argString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_537_argString, ((_540_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _539_argExpr);
            _538_i = (_538_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _534_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _537_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
        }
      } else if (_source15.is_TypeTest) {
        DAST._IExpression _542___mcc_h42 = _source15.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _543___mcc_h43 = _source15.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _544___mcc_h44 = _source15.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _545_variant = _544___mcc_h44;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _546_dType = _543___mcc_h43;
        DAST._IExpression _547_on = _542___mcc_h42;
        {
          Dafny.ISequence<Dafny.Rune> _548_exprGen;
          bool _549___v50;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _550_recIdents;
          Dafny.ISequence<Dafny.Rune> _out144;
          bool _out145;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out146;
          DCOMP.COMP.GenExpr(_547_on, @params, false, out _out144, out _out145, out _out146);
          _548_exprGen = _out144;
          _549___v50 = _out145;
          _550_recIdents = _out146;
          Dafny.ISequence<Dafny.Rune> _551_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out147;
          _out147 = DCOMP.COMP.GenPath(_546_dType);
          _551_dTypePath = _out147;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _548_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _551_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _545_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          readIdents = _550_recIdents;
        }
      } else {
        DAST._IType _552___mcc_h45 = _source15.dtor_typ;
        DAST._IType _553_typ = _552___mcc_h45;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("std::default::Default::default()");
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      }
    }
    public static Dafny.ISequence<Dafny.Rune> Compile(Dafny.ISequence<DAST._IModule> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#![allow(warnings, unconditional_panic)]\n");
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("extern crate dafny_runtime;\n"));
      BigInteger _554_i;
      _554_i = BigInteger.Zero;
      while ((_554_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _555_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out148;
        _out148 = DCOMP.COMP.GenModule((p).Select(_554_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _555_generated = _out148;
        if ((_554_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _555_generated);
        _554_i = (_554_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _556_i;
      _556_i = BigInteger.Zero;
      while ((_556_i) < (new BigInteger((fullName).Count))) {
        if ((_556_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_556_i));
        _556_i = (_556_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

