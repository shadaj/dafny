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

  public interface _IType {
    bool is_Path { get; }
    bool is_Nullable { get; }
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
    DAST._IType dtor_Nullable_a0 { get; }
    Dafny.ISequence<DAST._IType> dtor_Tuple_a0 { get; }
    DAST._IType dtor_element { get; }
    BigInteger dtor_dims { get; }
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
    public static _IType create_Nullable(DAST._IType _a0) {
      return new Type_Nullable(_a0);
    }
    public static _IType create_Tuple(Dafny.ISequence<DAST._IType> _a0) {
      return new Type_Tuple(_a0);
    }
    public static _IType create_Array(DAST._IType element, BigInteger dims) {
      return new Type_Array(element, dims);
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
    public bool is_Nullable { get { return this is Type_Nullable; } }
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
    public DAST._IType dtor_Nullable_a0 {
      get {
        var d = this;
        return ((Type_Nullable)d)._a0;
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
    public BigInteger dtor_dims {
      get {
        var d = this;
        return ((Type_Array)d)._dims;
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
  public class Type_Nullable : Type {
    public readonly DAST._IType _a0;
    public Type_Nullable(DAST._IType _a0) : base() {
      this._a0 = _a0;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Nullable(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Nullable;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Nullable";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
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
      hash = ((hash << 5) + hash) + 2;
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
    public readonly BigInteger _dims;
    public Type_Array(DAST._IType element, BigInteger dims) : base() {
      this._element = element;
      this._dims = dims;
    }
    public override _IType DowncastClone() {
      if (this is _IType dt) { return dt; }
      return new Type_Array(_element, _dims);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Type_Array;
      return oth != null && object.Equals(this._element, oth._element) && this._dims == oth._dims;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._element));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._dims));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Type.Array";
      s += "(";
      s += Dafny.Helpers.ToString(this._element);
      s += ", ";
      s += Dafny.Helpers.ToString(this._dims);
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
      hash = ((hash << 5) + hash) + 4;
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
      hash = ((hash << 5) + hash) + 5;
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
      hash = ((hash << 5) + hash) + 6;
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
      hash = ((hash << 5) + hash) + 7;
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
      hash = ((hash << 5) + hash) + 8;
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
      hash = ((hash << 5) + hash) + 9;
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
      hash = ((hash << 5) + hash) + 10;
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
      hash = ((hash << 5) + hash) + 11;
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
    bool is_Int { get; }
    bool is_Real { get; }
    bool is_String { get; }
    bool is_Bool { get; }
    bool is_Char { get; }
    _IPrimitive DowncastClone();
  }
  public abstract class Primitive : _IPrimitive {
    public Primitive() {
    }
    private static readonly DAST._IPrimitive theDefault = create_Int();
    public static DAST._IPrimitive Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IPrimitive> _TYPE = new Dafny.TypeDescriptor<DAST._IPrimitive>(DAST.Primitive.Default());
    public static Dafny.TypeDescriptor<DAST._IPrimitive> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IPrimitive create_Int() {
      return new Primitive_Int();
    }
    public static _IPrimitive create_Real() {
      return new Primitive_Real();
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
    public bool is_Int { get { return this is Primitive_Int; } }
    public bool is_Real { get { return this is Primitive_Real; } }
    public bool is_String { get { return this is Primitive_String; } }
    public bool is_Bool { get { return this is Primitive_Bool; } }
    public bool is_Char { get { return this is Primitive_Char; } }
    public static System.Collections.Generic.IEnumerable<_IPrimitive> AllSingletonConstructors {
      get {
        yield return Primitive.create_Int();
        yield return Primitive.create_Real();
        yield return Primitive.create_String();
        yield return Primitive.create_Bool();
        yield return Primitive.create_Char();
      }
    }
    public abstract _IPrimitive DowncastClone();
  }
  public class Primitive_Int : Primitive {
    public Primitive_Int() : base() {
    }
    public override _IPrimitive DowncastClone() {
      if (this is _IPrimitive dt) { return dt; }
      return new Primitive_Int();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Primitive_Int;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Primitive.Int";
      return s;
    }
  }
  public class Primitive_Real : Primitive {
    public Primitive_Real() : base() {
    }
    public override _IPrimitive DowncastClone() {
      if (this is _IPrimitive dt) { return dt; }
      return new Primitive_Real();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Primitive_Real;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Primitive.Real";
      return s;
    }
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
      hash = ((hash << 5) + hash) + 2;
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
      hash = ((hash << 5) + hash) + 3;
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
      hash = ((hash << 5) + hash) + 4;
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
    DAST._IType dtor_Newtype_a0 { get; }
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
    public static _IResolvedType create_Newtype(DAST._IType _a0) {
      return new ResolvedType_Newtype(_a0);
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
    public DAST._IType dtor_Newtype_a0 {
      get {
        var d = this;
        return ((ResolvedType_Newtype)d)._a0;
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
    public readonly DAST._IType _a0;
    public ResolvedType_Newtype(DAST._IType _a0) : base() {
      this._a0 = _a0;
    }
    public override _IResolvedType DowncastClone() {
      if (this is _IResolvedType dt) { return dt; }
      return new ResolvedType_Newtype(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ResolvedType_Newtype;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.ResolvedType.Newtype";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
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
    Dafny.ISequence<Dafny.Rune> dtor_enclosingModule { get; }
    Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
    Dafny.ISequence<DAST._IType> dtor_superClasses { get; }
    Dafny.ISequence<DAST._IField> dtor_fields { get; }
    Dafny.ISequence<DAST._IMethod> dtor_body { get; }
    _IClass DowncastClone();
  }
  public class Class : _IClass {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<Dafny.Rune> _enclosingModule;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IType> _superClasses;
    public readonly Dafny.ISequence<DAST._IField> _fields;
    public readonly Dafny.ISequence<DAST._IMethod> _body;
    public Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body) {
      this._name = name;
      this._enclosingModule = enclosingModule;
      this._typeParams = typeParams;
      this._superClasses = superClasses;
      this._fields = fields;
      this._body = body;
    }
    public _IClass DowncastClone() {
      if (this is _IClass dt) { return dt; }
      return new Class(_name, _enclosingModule, _typeParams, _superClasses, _fields, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Class;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._enclosingModule, oth._enclosingModule) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._superClasses, oth._superClasses) && object.Equals(this._fields, oth._fields) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._enclosingModule));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._superClasses));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._fields));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Class.Class";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._enclosingModule);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._superClasses);
      s += ", ";
      s += Dafny.Helpers.ToString(this._fields);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly DAST._IClass theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IField>.Empty, Dafny.Sequence<DAST._IMethod>.Empty);
    public static DAST._IClass Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IClass> _TYPE = new Dafny.TypeDescriptor<DAST._IClass>(DAST.Class.Default());
    public static Dafny.TypeDescriptor<DAST._IClass> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IClass create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body) {
      return new Class(name, enclosingModule, typeParams, superClasses, fields, body);
    }
    public static _IClass create_Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body) {
      return create(name, enclosingModule, typeParams, superClasses, fields, body);
    }
    public bool is_Class { get { return true; } }
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
    public Dafny.ISequence<DAST._IType> dtor_superClasses {
      get {
        return this._superClasses;
      }
    }
    public Dafny.ISequence<DAST._IField> dtor_fields {
      get {
        return this._fields;
      }
    }
    public Dafny.ISequence<DAST._IMethod> dtor_body {
      get {
        return this._body;
      }
    }
  }

  public interface _ITrait {
    bool is_Trait { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
    Dafny.ISequence<DAST._IMethod> dtor_body { get; }
    _ITrait DowncastClone();
  }
  public class Trait : _ITrait {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IMethod> _body;
    public Trait(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IMethod> body) {
      this._name = name;
      this._typeParams = typeParams;
      this._body = body;
    }
    public _ITrait DowncastClone() {
      if (this is _ITrait dt) { return dt; }
      return new Trait(_name, _typeParams, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Trait;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Trait.Trait";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
    private static readonly DAST._ITrait theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IMethod>.Empty);
    public static DAST._ITrait Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._ITrait> _TYPE = new Dafny.TypeDescriptor<DAST._ITrait>(DAST.Trait.Default());
    public static Dafny.TypeDescriptor<DAST._ITrait> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ITrait create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IMethod> body) {
      return new Trait(name, typeParams, body);
    }
    public static _ITrait create_Trait(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IMethod> body) {
      return create(name, typeParams, body);
    }
    public bool is_Trait { get { return true; } }
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
    public Dafny.ISequence<DAST._IMethod> dtor_body {
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
    Dafny.ISequence<DAST._IMethod> dtor_body { get; }
    bool dtor_isCo { get; }
    _IDatatype DowncastClone();
  }
  public class Datatype : _IDatatype {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<Dafny.Rune> _enclosingModule;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IDatatypeCtor> _ctors;
    public readonly Dafny.ISequence<DAST._IMethod> _body;
    public readonly bool _isCo;
    public Datatype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IMethod> body, bool isCo) {
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
    private static readonly DAST._IDatatype theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IDatatypeCtor>.Empty, Dafny.Sequence<DAST._IMethod>.Empty, false);
    public static DAST._IDatatype Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IDatatype> _TYPE = new Dafny.TypeDescriptor<DAST._IDatatype>(DAST.Datatype.Default());
    public static Dafny.TypeDescriptor<DAST._IDatatype> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IDatatype create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IMethod> body, bool isCo) {
      return new Datatype(name, enclosingModule, typeParams, ctors, body, isCo);
    }
    public static _IDatatype create_Datatype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<Dafny.Rune> enclosingModule, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IDatatypeCtor> ctors, Dafny.ISequence<DAST._IMethod> body, bool isCo) {
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
    public Dafny.ISequence<DAST._IMethod> dtor_body {
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

  public interface _INewtype {
    bool is_Newtype { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
    DAST._IType dtor_base { get; }
    Dafny.ISequence<DAST._IStatement> dtor_witnessStmts { get; }
    DAST._IOptional<DAST._IExpression> dtor_witnessExpr { get; }
    _INewtype DowncastClone();
  }
  public class Newtype : _INewtype {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly DAST._IType _base;
    public readonly Dafny.ISequence<DAST._IStatement> _witnessStmts;
    public readonly DAST._IOptional<DAST._IExpression> _witnessExpr;
    public Newtype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, DAST._IType @base, Dafny.ISequence<DAST._IStatement> witnessStmts, DAST._IOptional<DAST._IExpression> witnessExpr) {
      this._name = name;
      this._typeParams = typeParams;
      this._base = @base;
      this._witnessStmts = witnessStmts;
      this._witnessExpr = witnessExpr;
    }
    public _INewtype DowncastClone() {
      if (this is _INewtype dt) { return dt; }
      return new Newtype(_name, _typeParams, _base, _witnessStmts, _witnessExpr);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Newtype;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._base, oth._base) && object.Equals(this._witnessStmts, oth._witnessStmts) && object.Equals(this._witnessExpr, oth._witnessExpr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typeParams));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._base));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._witnessStmts));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._witnessExpr));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Newtype.Newtype";
      s += "(";
      s += this._name.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeParams);
      s += ", ";
      s += Dafny.Helpers.ToString(this._base);
      s += ", ";
      s += Dafny.Helpers.ToString(this._witnessStmts);
      s += ", ";
      s += Dafny.Helpers.ToString(this._witnessExpr);
      s += ")";
      return s;
    }
    private static readonly DAST._INewtype theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, DAST.Type.Default(), Dafny.Sequence<DAST._IStatement>.Empty, DAST.Optional<DAST._IExpression>.Default());
    public static DAST._INewtype Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._INewtype> _TYPE = new Dafny.TypeDescriptor<DAST._INewtype>(DAST.Newtype.Default());
    public static Dafny.TypeDescriptor<DAST._INewtype> _TypeDescriptor() {
      return _TYPE;
    }
    public static _INewtype create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, DAST._IType @base, Dafny.ISequence<DAST._IStatement> witnessStmts, DAST._IOptional<DAST._IExpression> witnessExpr) {
      return new Newtype(name, typeParams, @base, witnessStmts, witnessExpr);
    }
    public static _INewtype create_Newtype(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, DAST._IType @base, Dafny.ISequence<DAST._IStatement> witnessStmts, DAST._IOptional<DAST._IExpression> witnessExpr) {
      return create(name, typeParams, @base, witnessStmts, witnessExpr);
    }
    public bool is_Newtype { get { return true; } }
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
    public DAST._IType dtor_base {
      get {
        return this._base;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_witnessStmts {
      get {
        return this._witnessStmts;
      }
    }
    public DAST._IOptional<DAST._IExpression> dtor_witnessExpr {
      get {
        return this._witnessExpr;
      }
    }
  }

  public interface _IClassItem {
    bool is_Method { get; }
    DAST._IMethod dtor_Method_a0 { get; }
  }
  public class ClassItem : _IClassItem {
    public readonly DAST._IMethod _a0;
    public ClassItem(DAST._IMethod _a0) {
      this._a0 = _a0;
    }
    public static DAST._IMethod DowncastClone(DAST._IMethod _this) {
      return _this;
    }
    public override bool Equals(object other) {
      var oth = other as DAST.ClassItem;
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
    private static readonly DAST._IMethod theDefault = DAST.Method.Default();
    public static DAST._IMethod Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IMethod> _TYPE = new Dafny.TypeDescriptor<DAST._IMethod>(DAST.Method.Default());
    public static Dafny.TypeDescriptor<DAST._IMethod> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IClassItem create(DAST._IMethod _a0) {
      return new ClassItem(_a0);
    }
    public static _IClassItem create_Method(DAST._IMethod _a0) {
      return create(_a0);
    }
    public bool is_Method { get { return true; } }
    public DAST._IMethod dtor_Method_a0 {
      get {
        return this._a0;
      }
    }
  }

  public interface _IField {
    bool is_Field { get; }
    DAST._IFormal dtor_formal { get; }
    DAST._IOptional<DAST._IExpression> dtor_defaultValue { get; }
    _IField DowncastClone();
  }
  public class Field : _IField {
    public readonly DAST._IFormal _formal;
    public readonly DAST._IOptional<DAST._IExpression> _defaultValue;
    public Field(DAST._IFormal formal, DAST._IOptional<DAST._IExpression> defaultValue) {
      this._formal = formal;
      this._defaultValue = defaultValue;
    }
    public _IField DowncastClone() {
      if (this is _IField dt) { return dt; }
      return new Field(_formal, _defaultValue);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Field;
      return oth != null && object.Equals(this._formal, oth._formal) && object.Equals(this._defaultValue, oth._defaultValue);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._formal));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._defaultValue));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Field.Field";
      s += "(";
      s += Dafny.Helpers.ToString(this._formal);
      s += ", ";
      s += Dafny.Helpers.ToString(this._defaultValue);
      s += ")";
      return s;
    }
    private static readonly DAST._IField theDefault = create(DAST.Formal.Default(), DAST.Optional<DAST._IExpression>.Default());
    public static DAST._IField Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IField> _TYPE = new Dafny.TypeDescriptor<DAST._IField>(DAST.Field.Default());
    public static Dafny.TypeDescriptor<DAST._IField> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IField create(DAST._IFormal formal, DAST._IOptional<DAST._IExpression> defaultValue) {
      return new Field(formal, defaultValue);
    }
    public static _IField create_Field(DAST._IFormal formal, DAST._IOptional<DAST._IExpression> defaultValue) {
      return create(formal, defaultValue);
    }
    public bool is_Field { get { return true; } }
    public DAST._IFormal dtor_formal {
      get {
        return this._formal;
      }
    }
    public DAST._IOptional<DAST._IExpression> dtor_defaultValue {
      get {
        return this._defaultValue;
      }
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
    bool dtor_hasBody { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_overridingPath { get; }
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
    public readonly bool _hasBody;
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _overridingPath;
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IFormal> _params;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public readonly Dafny.ISequence<DAST._IType> _outTypes;
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _outVars;
    public Method(bool isStatic, bool hasBody, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> overridingPath, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars) {
      this._isStatic = isStatic;
      this._hasBody = hasBody;
      this._overridingPath = overridingPath;
      this._name = name;
      this._typeParams = typeParams;
      this._params = @params;
      this._body = body;
      this._outTypes = outTypes;
      this._outVars = outVars;
    }
    public _IMethod DowncastClone() {
      if (this is _IMethod dt) { return dt; }
      return new Method(_isStatic, _hasBody, _overridingPath, _name, _typeParams, _params, _body, _outTypes, _outVars);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Method;
      return oth != null && this._isStatic == oth._isStatic && this._hasBody == oth._hasBody && object.Equals(this._overridingPath, oth._overridingPath) && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._params, oth._params) && object.Equals(this._body, oth._body) && object.Equals(this._outTypes, oth._outTypes) && object.Equals(this._outVars, oth._outVars);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isStatic));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._hasBody));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._overridingPath));
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
      s += Dafny.Helpers.ToString(this._hasBody);
      s += ", ";
      s += Dafny.Helpers.ToString(this._overridingPath);
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
    private static readonly DAST._IMethod theDefault = create(false, false, DAST.Optional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>>.Default(), Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IFormal>.Empty, Dafny.Sequence<DAST._IStatement>.Empty, Dafny.Sequence<DAST._IType>.Empty, DAST.Optional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>>.Default());
    public static DAST._IMethod Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IMethod> _TYPE = new Dafny.TypeDescriptor<DAST._IMethod>(DAST.Method.Default());
    public static Dafny.TypeDescriptor<DAST._IMethod> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IMethod create(bool isStatic, bool hasBody, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> overridingPath, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars) {
      return new Method(isStatic, hasBody, overridingPath, name, typeParams, @params, body, outTypes, outVars);
    }
    public static _IMethod create_Method(bool isStatic, bool hasBody, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> overridingPath, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IFormal> @params, Dafny.ISequence<DAST._IStatement> body, Dafny.ISequence<DAST._IType> outTypes, DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> outVars) {
      return create(isStatic, hasBody, overridingPath, name, typeParams, @params, body, outTypes, outVars);
    }
    public bool is_Method { get { return true; } }
    public bool dtor_isStatic {
      get {
        return this._isStatic;
      }
    }
    public bool dtor_hasBody {
      get {
        return this._hasBody;
      }
    }
    public DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_overridingPath {
      get {
        return this._overridingPath;
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
    bool is_Labeled { get; }
    bool is_While { get; }
    bool is_Foreach { get; }
    bool is_Call { get; }
    bool is_Return { get; }
    bool is_EarlyReturn { get; }
    bool is_Break { get; }
    bool is_TailRecursive { get; }
    bool is_JumpTailCallStart { get; }
    bool is_Halt { get; }
    bool is_Print { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    DAST._IType dtor_typ { get; }
    DAST._IOptional<DAST._IExpression> dtor_maybeValue { get; }
    DAST._IAssignLhs dtor_lhs { get; }
    DAST._IExpression dtor_value { get; }
    DAST._IExpression dtor_cond { get; }
    Dafny.ISequence<DAST._IStatement> dtor_thn { get; }
    Dafny.ISequence<DAST._IStatement> dtor_els { get; }
    Dafny.ISequence<Dafny.Rune> dtor_lbl { get; }
    Dafny.ISequence<DAST._IStatement> dtor_body { get; }
    Dafny.ISequence<Dafny.Rune> dtor_boundName { get; }
    DAST._IType dtor_boundType { get; }
    DAST._IExpression dtor_over { get; }
    DAST._IExpression dtor_on { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<DAST._IExpression> dtor_args { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> dtor_outs { get; }
    DAST._IExpression dtor_expr { get; }
    DAST._IOptional<Dafny.ISequence<Dafny.Rune>> dtor_toLabel { get; }
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
    public static _IStatement create_Assign(DAST._IAssignLhs lhs, DAST._IExpression @value) {
      return new Statement_Assign(lhs, @value);
    }
    public static _IStatement create_If(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> thn, Dafny.ISequence<DAST._IStatement> els) {
      return new Statement_If(cond, thn, els);
    }
    public static _IStatement create_Labeled(Dafny.ISequence<Dafny.Rune> lbl, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_Labeled(lbl, body);
    }
    public static _IStatement create_While(DAST._IExpression cond, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_While(cond, body);
    }
    public static _IStatement create_Foreach(Dafny.ISequence<Dafny.Rune> boundName, DAST._IType boundType, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_Foreach(boundName, boundType, over, body);
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
    public static _IStatement create_Break(DAST._IOptional<Dafny.ISequence<Dafny.Rune>> toLabel) {
      return new Statement_Break(toLabel);
    }
    public static _IStatement create_TailRecursive(Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_TailRecursive(body);
    }
    public static _IStatement create_JumpTailCallStart() {
      return new Statement_JumpTailCallStart();
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
    public bool is_Labeled { get { return this is Statement_Labeled; } }
    public bool is_While { get { return this is Statement_While; } }
    public bool is_Foreach { get { return this is Statement_Foreach; } }
    public bool is_Call { get { return this is Statement_Call; } }
    public bool is_Return { get { return this is Statement_Return; } }
    public bool is_EarlyReturn { get { return this is Statement_EarlyReturn; } }
    public bool is_Break { get { return this is Statement_Break; } }
    public bool is_TailRecursive { get { return this is Statement_TailRecursive; } }
    public bool is_JumpTailCallStart { get { return this is Statement_JumpTailCallStart; } }
    public bool is_Halt { get { return this is Statement_Halt; } }
    public bool is_Print { get { return this is Statement_Print; } }
    public Dafny.ISequence<Dafny.Rune> dtor_name {
      get {
        var d = this;
        if (d is Statement_DeclareVar) { return ((Statement_DeclareVar)d)._name; }
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
    public DAST._IAssignLhs dtor_lhs {
      get {
        var d = this;
        return ((Statement_Assign)d)._lhs;
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
    public Dafny.ISequence<Dafny.Rune> dtor_lbl {
      get {
        var d = this;
        return ((Statement_Labeled)d)._lbl;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        var d = this;
        if (d is Statement_Labeled) { return ((Statement_Labeled)d)._body; }
        if (d is Statement_While) { return ((Statement_While)d)._body; }
        if (d is Statement_Foreach) { return ((Statement_Foreach)d)._body; }
        return ((Statement_TailRecursive)d)._body;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_boundName {
      get {
        var d = this;
        return ((Statement_Foreach)d)._boundName;
      }
    }
    public DAST._IType dtor_boundType {
      get {
        var d = this;
        return ((Statement_Foreach)d)._boundType;
      }
    }
    public DAST._IExpression dtor_over {
      get {
        var d = this;
        return ((Statement_Foreach)d)._over;
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
    public DAST._IOptional<Dafny.ISequence<Dafny.Rune>> dtor_toLabel {
      get {
        var d = this;
        return ((Statement_Break)d)._toLabel;
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
    public readonly DAST._IAssignLhs _lhs;
    public readonly DAST._IExpression _value;
    public Statement_Assign(DAST._IAssignLhs lhs, DAST._IExpression @value) : base() {
      this._lhs = lhs;
      this._value = @value;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Assign(_lhs, _value);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Assign;
      return oth != null && object.Equals(this._lhs, oth._lhs) && object.Equals(this._value, oth._value);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._lhs));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Assign";
      s += "(";
      s += Dafny.Helpers.ToString(this._lhs);
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
  public class Statement_Labeled : Statement {
    public readonly Dafny.ISequence<Dafny.Rune> _lbl;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_Labeled(Dafny.ISequence<Dafny.Rune> lbl, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._lbl = lbl;
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Labeled(_lbl, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Labeled;
      return oth != null && object.Equals(this._lbl, oth._lbl) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._lbl));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Labeled";
      s += "(";
      s += this._lbl.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
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
      hash = ((hash << 5) + hash) + 4;
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
  public class Statement_Foreach : Statement {
    public readonly Dafny.ISequence<Dafny.Rune> _boundName;
    public readonly DAST._IType _boundType;
    public readonly DAST._IExpression _over;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_Foreach(Dafny.ISequence<Dafny.Rune> boundName, DAST._IType boundType, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._boundName = boundName;
      this._boundType = boundType;
      this._over = over;
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Foreach(_boundName, _boundType, _over, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Foreach;
      return oth != null && object.Equals(this._boundName, oth._boundName) && object.Equals(this._boundType, oth._boundType) && object.Equals(this._over, oth._over) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._boundName));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._boundType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._over));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Foreach";
      s += "(";
      s += this._boundName.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._boundType);
      s += ", ";
      s += Dafny.Helpers.ToString(this._over);
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
      hash = ((hash << 5) + hash) + 6;
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
      hash = ((hash << 5) + hash) + 7;
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
      hash = ((hash << 5) + hash) + 8;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.EarlyReturn";
      return s;
    }
  }
  public class Statement_Break : Statement {
    public readonly DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _toLabel;
    public Statement_Break(DAST._IOptional<Dafny.ISequence<Dafny.Rune>> toLabel) : base() {
      this._toLabel = toLabel;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Break(_toLabel);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Break;
      return oth != null && object.Equals(this._toLabel, oth._toLabel);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 9;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._toLabel));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Break";
      s += "(";
      s += Dafny.Helpers.ToString(this._toLabel);
      s += ")";
      return s;
    }
  }
  public class Statement_TailRecursive : Statement {
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_TailRecursive(Dafny.ISequence<DAST._IStatement> body) : base() {
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_TailRecursive(_body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_TailRecursive;
      return oth != null && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 10;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.TailRecursive";
      s += "(";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Statement_JumpTailCallStart : Statement {
    public Statement_JumpTailCallStart() : base() {
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_JumpTailCallStart();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_JumpTailCallStart;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 11;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.JumpTailCallStart";
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
      hash = ((hash << 5) + hash) + 12;
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
      hash = ((hash << 5) + hash) + 13;
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

  public interface _IAssignLhs {
    bool is_Ident { get; }
    bool is_Select { get; }
    bool is_Index { get; }
    Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 { get; }
    DAST._IExpression dtor_expr { get; }
    Dafny.ISequence<Dafny.Rune> dtor_field { get; }
    Dafny.ISequence<DAST._IExpression> dtor_indices { get; }
    _IAssignLhs DowncastClone();
  }
  public abstract class AssignLhs : _IAssignLhs {
    public AssignLhs() {
    }
    private static readonly DAST._IAssignLhs theDefault = create_Ident(Dafny.Sequence<Dafny.Rune>.Empty);
    public static DAST._IAssignLhs Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IAssignLhs> _TYPE = new Dafny.TypeDescriptor<DAST._IAssignLhs>(DAST.AssignLhs.Default());
    public static Dafny.TypeDescriptor<DAST._IAssignLhs> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IAssignLhs create_Ident(Dafny.ISequence<Dafny.Rune> _a0) {
      return new AssignLhs_Ident(_a0);
    }
    public static _IAssignLhs create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field) {
      return new AssignLhs_Select(expr, field);
    }
    public static _IAssignLhs create_Index(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> indices) {
      return new AssignLhs_Index(expr, indices);
    }
    public bool is_Ident { get { return this is AssignLhs_Ident; } }
    public bool is_Select { get { return this is AssignLhs_Select; } }
    public bool is_Index { get { return this is AssignLhs_Index; } }
    public Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 {
      get {
        var d = this;
        return ((AssignLhs_Ident)d)._a0;
      }
    }
    public DAST._IExpression dtor_expr {
      get {
        var d = this;
        if (d is AssignLhs_Select) { return ((AssignLhs_Select)d)._expr; }
        return ((AssignLhs_Index)d)._expr;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_field {
      get {
        var d = this;
        return ((AssignLhs_Select)d)._field;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_indices {
      get {
        var d = this;
        return ((AssignLhs_Index)d)._indices;
      }
    }
    public abstract _IAssignLhs DowncastClone();
  }
  public class AssignLhs_Ident : AssignLhs {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public AssignLhs_Ident(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_Ident(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.AssignLhs_Ident;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.AssignLhs.Ident";
      s += "(";
      s += Dafny.Helpers.ToString(this._a0);
      s += ")";
      return s;
    }
  }
  public class AssignLhs_Select : AssignLhs {
    public readonly DAST._IExpression _expr;
    public readonly Dafny.ISequence<Dafny.Rune> _field;
    public AssignLhs_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field) : base() {
      this._expr = expr;
      this._field = field;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_Select(_expr, _field);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.AssignLhs_Select;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._field, oth._field);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._field));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.AssignLhs.Select";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += this._field.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class AssignLhs_Index : AssignLhs {
    public readonly DAST._IExpression _expr;
    public readonly Dafny.ISequence<DAST._IExpression> _indices;
    public AssignLhs_Index(DAST._IExpression expr, Dafny.ISequence<DAST._IExpression> indices) : base() {
      this._expr = expr;
      this._indices = indices;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_Index(_expr, _indices);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.AssignLhs_Index;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._indices, oth._indices);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._indices));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.AssignLhs.Index";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._indices);
      s += ")";
      return s;
    }
  }

  public interface _ICollKind {
    bool is_Seq { get; }
    bool is_Array { get; }
    bool is_Map { get; }
    _ICollKind DowncastClone();
  }
  public abstract class CollKind : _ICollKind {
    public CollKind() {
    }
    private static readonly DAST._ICollKind theDefault = create_Seq();
    public static DAST._ICollKind Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._ICollKind> _TYPE = new Dafny.TypeDescriptor<DAST._ICollKind>(DAST.CollKind.Default());
    public static Dafny.TypeDescriptor<DAST._ICollKind> _TypeDescriptor() {
      return _TYPE;
    }
    public static _ICollKind create_Seq() {
      return new CollKind_Seq();
    }
    public static _ICollKind create_Array() {
      return new CollKind_Array();
    }
    public static _ICollKind create_Map() {
      return new CollKind_Map();
    }
    public bool is_Seq { get { return this is CollKind_Seq; } }
    public bool is_Array { get { return this is CollKind_Array; } }
    public bool is_Map { get { return this is CollKind_Map; } }
    public static System.Collections.Generic.IEnumerable<_ICollKind> AllSingletonConstructors {
      get {
        yield return CollKind.create_Seq();
        yield return CollKind.create_Array();
        yield return CollKind.create_Map();
      }
    }
    public abstract _ICollKind DowncastClone();
  }
  public class CollKind_Seq : CollKind {
    public CollKind_Seq() : base() {
    }
    public override _ICollKind DowncastClone() {
      if (this is _ICollKind dt) { return dt; }
      return new CollKind_Seq();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.CollKind_Seq;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.CollKind.Seq";
      return s;
    }
  }
  public class CollKind_Array : CollKind {
    public CollKind_Array() : base() {
    }
    public override _ICollKind DowncastClone() {
      if (this is _ICollKind dt) { return dt; }
      return new CollKind_Array();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.CollKind_Array;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.CollKind.Array";
      return s;
    }
  }
  public class CollKind_Map : CollKind {
    public CollKind_Map() : base() {
    }
    public override _ICollKind DowncastClone() {
      if (this is _ICollKind dt) { return dt; }
      return new CollKind_Map();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.CollKind_Map;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.CollKind.Map";
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
    bool is_Convert { get; }
    bool is_SeqValue { get; }
    bool is_SetValue { get; }
    bool is_MapValue { get; }
    bool is_This { get; }
    bool is_Ite { get; }
    bool is_UnOp { get; }
    bool is_BinOp { get; }
    bool is_ArrayLen { get; }
    bool is_Select { get; }
    bool is_SelectFn { get; }
    bool is_Index { get; }
    bool is_IndexRange { get; }
    bool is_TupleSelect { get; }
    bool is_Call { get; }
    bool is_Lambda { get; }
    bool is_BetaRedex { get; }
    bool is_IIFE { get; }
    bool is_Apply { get; }
    bool is_TypeTest { get; }
    bool is_InitializationValue { get; }
    bool is_BoolBoundedPool { get; }
    bool is_IntRange { get; }
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
    DAST._IExpression dtor_value { get; }
    DAST._IType dtor_from { get; }
    DAST._IType dtor_typ { get; }
    Dafny.ISequence<DAST._IExpression> dtor_elements { get; }
    Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> dtor_mapElems { get; }
    DAST._IExpression dtor_cond { get; }
    DAST._IExpression dtor_thn { get; }
    DAST._IExpression dtor_els { get; }
    DAST._IUnaryOp dtor_unOp { get; }
    DAST._IExpression dtor_expr { get; }
    Dafny.ISequence<Dafny.Rune> dtor_op { get; }
    DAST._IExpression dtor_left { get; }
    DAST._IExpression dtor_right { get; }
    BigInteger dtor_dim { get; }
    Dafny.ISequence<Dafny.Rune> dtor_field { get; }
    bool dtor_isConstant { get; }
    bool dtor_onDatatype { get; }
    bool dtor_isStatic { get; }
    BigInteger dtor_arity { get; }
    DAST._ICollKind dtor_collKind { get; }
    Dafny.ISequence<DAST._IExpression> dtor_indices { get; }
    bool dtor_isArray { get; }
    DAST._IOptional<DAST._IExpression> dtor_low { get; }
    DAST._IOptional<DAST._IExpression> dtor_high { get; }
    BigInteger dtor_index { get; }
    DAST._IExpression dtor_on { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<DAST._IFormal> dtor_params { get; }
    DAST._IType dtor_retType { get; }
    Dafny.ISequence<DAST._IStatement> dtor_body { get; }
    Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> dtor_values { get; }
    DAST._IExpression dtor_iifeBody { get; }
    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_dType { get; }
    DAST._IExpression dtor_lo { get; }
    DAST._IExpression dtor_hi { get; }
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
    public static _IExpression create_Convert(DAST._IExpression @value, DAST._IType @from, DAST._IType typ) {
      return new Expression_Convert(@value, @from, typ);
    }
    public static _IExpression create_SeqValue(Dafny.ISequence<DAST._IExpression> elements) {
      return new Expression_SeqValue(elements);
    }
    public static _IExpression create_SetValue(Dafny.ISequence<DAST._IExpression> elements) {
      return new Expression_SetValue(elements);
    }
    public static _IExpression create_MapValue(Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> mapElems) {
      return new Expression_MapValue(mapElems);
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
    public static _IExpression create_ArrayLen(DAST._IExpression expr, BigInteger dim) {
      return new Expression_ArrayLen(expr, dim);
    }
    public static _IExpression create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool isConstant, bool onDatatype) {
      return new Expression_Select(expr, field, isConstant, onDatatype);
    }
    public static _IExpression create_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype, bool isStatic, BigInteger arity) {
      return new Expression_SelectFn(expr, field, onDatatype, isStatic, arity);
    }
    public static _IExpression create_Index(DAST._IExpression expr, DAST._ICollKind collKind, Dafny.ISequence<DAST._IExpression> indices) {
      return new Expression_Index(expr, collKind, indices);
    }
    public static _IExpression create_IndexRange(DAST._IExpression expr, bool isArray, DAST._IOptional<DAST._IExpression> low, DAST._IOptional<DAST._IExpression> high) {
      return new Expression_IndexRange(expr, isArray, low, high);
    }
    public static _IExpression create_TupleSelect(DAST._IExpression expr, BigInteger index) {
      return new Expression_TupleSelect(expr, index);
    }
    public static _IExpression create_Call(DAST._IExpression @on, Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeArgs, Dafny.ISequence<DAST._IExpression> args) {
      return new Expression_Call(@on, name, typeArgs, args);
    }
    public static _IExpression create_Lambda(Dafny.ISequence<DAST._IFormal> @params, DAST._IType retType, Dafny.ISequence<DAST._IStatement> body) {
      return new Expression_Lambda(@params, retType, body);
    }
    public static _IExpression create_BetaRedex(Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> values, DAST._IType retType, DAST._IExpression expr) {
      return new Expression_BetaRedex(values, retType, expr);
    }
    public static _IExpression create_IIFE(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, DAST._IExpression @value, DAST._IExpression iifeBody) {
      return new Expression_IIFE(name, typ, @value, iifeBody);
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
    public static _IExpression create_BoolBoundedPool() {
      return new Expression_BoolBoundedPool();
    }
    public static _IExpression create_IntRange(DAST._IExpression lo, DAST._IExpression hi) {
      return new Expression_IntRange(lo, hi);
    }
    public bool is_Literal { get { return this is Expression_Literal; } }
    public bool is_Ident { get { return this is Expression_Ident; } }
    public bool is_Companion { get { return this is Expression_Companion; } }
    public bool is_Tuple { get { return this is Expression_Tuple; } }
    public bool is_New { get { return this is Expression_New; } }
    public bool is_NewArray { get { return this is Expression_NewArray; } }
    public bool is_DatatypeValue { get { return this is Expression_DatatypeValue; } }
    public bool is_Convert { get { return this is Expression_Convert; } }
    public bool is_SeqValue { get { return this is Expression_SeqValue; } }
    public bool is_SetValue { get { return this is Expression_SetValue; } }
    public bool is_MapValue { get { return this is Expression_MapValue; } }
    public bool is_This { get { return this is Expression_This; } }
    public bool is_Ite { get { return this is Expression_Ite; } }
    public bool is_UnOp { get { return this is Expression_UnOp; } }
    public bool is_BinOp { get { return this is Expression_BinOp; } }
    public bool is_ArrayLen { get { return this is Expression_ArrayLen; } }
    public bool is_Select { get { return this is Expression_Select; } }
    public bool is_SelectFn { get { return this is Expression_SelectFn; } }
    public bool is_Index { get { return this is Expression_Index; } }
    public bool is_IndexRange { get { return this is Expression_IndexRange; } }
    public bool is_TupleSelect { get { return this is Expression_TupleSelect; } }
    public bool is_Call { get { return this is Expression_Call; } }
    public bool is_Lambda { get { return this is Expression_Lambda; } }
    public bool is_BetaRedex { get { return this is Expression_BetaRedex; } }
    public bool is_IIFE { get { return this is Expression_IIFE; } }
    public bool is_Apply { get { return this is Expression_Apply; } }
    public bool is_TypeTest { get { return this is Expression_TypeTest; } }
    public bool is_InitializationValue { get { return this is Expression_InitializationValue; } }
    public bool is_BoolBoundedPool { get { return this is Expression_BoolBoundedPool; } }
    public bool is_IntRange { get { return this is Expression_IntRange; } }
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
    public DAST._IExpression dtor_value {
      get {
        var d = this;
        if (d is Expression_Convert) { return ((Expression_Convert)d)._value; }
        return ((Expression_IIFE)d)._value;
      }
    }
    public DAST._IType dtor_from {
      get {
        var d = this;
        return ((Expression_Convert)d)._from;
      }
    }
    public DAST._IType dtor_typ {
      get {
        var d = this;
        if (d is Expression_Convert) { return ((Expression_Convert)d)._typ; }
        if (d is Expression_IIFE) { return ((Expression_IIFE)d)._typ; }
        return ((Expression_InitializationValue)d)._typ;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_elements {
      get {
        var d = this;
        if (d is Expression_SeqValue) { return ((Expression_SeqValue)d)._elements; }
        return ((Expression_SetValue)d)._elements;
      }
    }
    public Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> dtor_mapElems {
      get {
        var d = this;
        return ((Expression_MapValue)d)._mapElems;
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
        if (d is Expression_ArrayLen) { return ((Expression_ArrayLen)d)._expr; }
        if (d is Expression_Select) { return ((Expression_Select)d)._expr; }
        if (d is Expression_SelectFn) { return ((Expression_SelectFn)d)._expr; }
        if (d is Expression_Index) { return ((Expression_Index)d)._expr; }
        if (d is Expression_IndexRange) { return ((Expression_IndexRange)d)._expr; }
        if (d is Expression_TupleSelect) { return ((Expression_TupleSelect)d)._expr; }
        if (d is Expression_BetaRedex) { return ((Expression_BetaRedex)d)._expr; }
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
    public BigInteger dtor_dim {
      get {
        var d = this;
        return ((Expression_ArrayLen)d)._dim;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_field {
      get {
        var d = this;
        if (d is Expression_Select) { return ((Expression_Select)d)._field; }
        return ((Expression_SelectFn)d)._field;
      }
    }
    public bool dtor_isConstant {
      get {
        var d = this;
        return ((Expression_Select)d)._isConstant;
      }
    }
    public bool dtor_onDatatype {
      get {
        var d = this;
        if (d is Expression_Select) { return ((Expression_Select)d)._onDatatype; }
        return ((Expression_SelectFn)d)._onDatatype;
      }
    }
    public bool dtor_isStatic {
      get {
        var d = this;
        return ((Expression_SelectFn)d)._isStatic;
      }
    }
    public BigInteger dtor_arity {
      get {
        var d = this;
        return ((Expression_SelectFn)d)._arity;
      }
    }
    public DAST._ICollKind dtor_collKind {
      get {
        var d = this;
        return ((Expression_Index)d)._collKind;
      }
    }
    public Dafny.ISequence<DAST._IExpression> dtor_indices {
      get {
        var d = this;
        return ((Expression_Index)d)._indices;
      }
    }
    public bool dtor_isArray {
      get {
        var d = this;
        return ((Expression_IndexRange)d)._isArray;
      }
    }
    public DAST._IOptional<DAST._IExpression> dtor_low {
      get {
        var d = this;
        return ((Expression_IndexRange)d)._low;
      }
    }
    public DAST._IOptional<DAST._IExpression> dtor_high {
      get {
        var d = this;
        return ((Expression_IndexRange)d)._high;
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
        if (d is Expression_Call) { return ((Expression_Call)d)._name; }
        return ((Expression_IIFE)d)._name;
      }
    }
    public Dafny.ISequence<DAST._IType> dtor_typeArgs {
      get {
        var d = this;
        return ((Expression_Call)d)._typeArgs;
      }
    }
    public Dafny.ISequence<DAST._IFormal> dtor_params {
      get {
        var d = this;
        return ((Expression_Lambda)d)._params;
      }
    }
    public DAST._IType dtor_retType {
      get {
        var d = this;
        if (d is Expression_Lambda) { return ((Expression_Lambda)d)._retType; }
        return ((Expression_BetaRedex)d)._retType;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        var d = this;
        return ((Expression_Lambda)d)._body;
      }
    }
    public Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> dtor_values {
      get {
        var d = this;
        return ((Expression_BetaRedex)d)._values;
      }
    }
    public DAST._IExpression dtor_iifeBody {
      get {
        var d = this;
        return ((Expression_IIFE)d)._iifeBody;
      }
    }
    public Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> dtor_dType {
      get {
        var d = this;
        return ((Expression_TypeTest)d)._dType;
      }
    }
    public DAST._IExpression dtor_lo {
      get {
        var d = this;
        return ((Expression_IntRange)d)._lo;
      }
    }
    public DAST._IExpression dtor_hi {
      get {
        var d = this;
        return ((Expression_IntRange)d)._hi;
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
  public class Expression_Convert : Expression {
    public readonly DAST._IExpression _value;
    public readonly DAST._IType _from;
    public readonly DAST._IType _typ;
    public Expression_Convert(DAST._IExpression @value, DAST._IType @from, DAST._IType typ) : base() {
      this._value = @value;
      this._from = @from;
      this._typ = typ;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Convert(_value, _from, _typ);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Convert;
      return oth != null && object.Equals(this._value, oth._value) && object.Equals(this._from, oth._from) && object.Equals(this._typ, oth._typ);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 7;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._from));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typ));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Convert";
      s += "(";
      s += Dafny.Helpers.ToString(this._value);
      s += ", ";
      s += Dafny.Helpers.ToString(this._from);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typ);
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
  public class Expression_MapValue : Expression {
    public readonly Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _mapElems;
    public Expression_MapValue(Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> mapElems) : base() {
      this._mapElems = mapElems;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_MapValue(_mapElems);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_MapValue;
      return oth != null && object.Equals(this._mapElems, oth._mapElems);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 10;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._mapElems));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.MapValue";
      s += "(";
      s += Dafny.Helpers.ToString(this._mapElems);
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
      hash = ((hash << 5) + hash) + 11;
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
      hash = ((hash << 5) + hash) + 12;
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
      hash = ((hash << 5) + hash) + 13;
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
      hash = ((hash << 5) + hash) + 14;
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
  public class Expression_ArrayLen : Expression {
    public readonly DAST._IExpression _expr;
    public readonly BigInteger _dim;
    public Expression_ArrayLen(DAST._IExpression expr, BigInteger dim) : base() {
      this._expr = expr;
      this._dim = dim;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_ArrayLen(_expr, _dim);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_ArrayLen;
      return oth != null && object.Equals(this._expr, oth._expr) && this._dim == oth._dim;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 15;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._dim));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.ArrayLen";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._dim);
      s += ")";
      return s;
    }
  }
  public class Expression_Select : Expression {
    public readonly DAST._IExpression _expr;
    public readonly Dafny.ISequence<Dafny.Rune> _field;
    public readonly bool _isConstant;
    public readonly bool _onDatatype;
    public Expression_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool isConstant, bool onDatatype) : base() {
      this._expr = expr;
      this._field = field;
      this._isConstant = isConstant;
      this._onDatatype = onDatatype;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Select(_expr, _field, _isConstant, _onDatatype);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Select;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._field, oth._field) && this._isConstant == oth._isConstant && this._onDatatype == oth._onDatatype;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 16;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._field));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isConstant));
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
      s += Dafny.Helpers.ToString(this._isConstant);
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
    public readonly bool _isStatic;
    public readonly BigInteger _arity;
    public Expression_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype, bool isStatic, BigInteger arity) : base() {
      this._expr = expr;
      this._field = field;
      this._onDatatype = onDatatype;
      this._isStatic = isStatic;
      this._arity = arity;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SelectFn(_expr, _field, _onDatatype, _isStatic, _arity);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SelectFn;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._field, oth._field) && this._onDatatype == oth._onDatatype && this._isStatic == oth._isStatic && this._arity == oth._arity;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 17;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._field));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._onDatatype));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isStatic));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._arity));
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
      s += ", ";
      s += Dafny.Helpers.ToString(this._isStatic);
      s += ", ";
      s += Dafny.Helpers.ToString(this._arity);
      s += ")";
      return s;
    }
  }
  public class Expression_Index : Expression {
    public readonly DAST._IExpression _expr;
    public readonly DAST._ICollKind _collKind;
    public readonly Dafny.ISequence<DAST._IExpression> _indices;
    public Expression_Index(DAST._IExpression expr, DAST._ICollKind collKind, Dafny.ISequence<DAST._IExpression> indices) : base() {
      this._expr = expr;
      this._collKind = collKind;
      this._indices = indices;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Index(_expr, _collKind, _indices);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Index;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._collKind, oth._collKind) && object.Equals(this._indices, oth._indices);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 18;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._collKind));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._indices));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Index";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._collKind);
      s += ", ";
      s += Dafny.Helpers.ToString(this._indices);
      s += ")";
      return s;
    }
  }
  public class Expression_IndexRange : Expression {
    public readonly DAST._IExpression _expr;
    public readonly bool _isArray;
    public readonly DAST._IOptional<DAST._IExpression> _low;
    public readonly DAST._IOptional<DAST._IExpression> _high;
    public Expression_IndexRange(DAST._IExpression expr, bool isArray, DAST._IOptional<DAST._IExpression> low, DAST._IOptional<DAST._IExpression> high) : base() {
      this._expr = expr;
      this._isArray = isArray;
      this._low = low;
      this._high = high;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_IndexRange(_expr, _isArray, _low, _high);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_IndexRange;
      return oth != null && object.Equals(this._expr, oth._expr) && this._isArray == oth._isArray && object.Equals(this._low, oth._low) && object.Equals(this._high, oth._high);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 19;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._isArray));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._low));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._high));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.IndexRange";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._isArray);
      s += ", ";
      s += Dafny.Helpers.ToString(this._low);
      s += ", ";
      s += Dafny.Helpers.ToString(this._high);
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
      hash = ((hash << 5) + hash) + 20;
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
      hash = ((hash << 5) + hash) + 21;
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
      s += Dafny.Helpers.ToString(this._name);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typeArgs);
      s += ", ";
      s += Dafny.Helpers.ToString(this._args);
      s += ")";
      return s;
    }
  }
  public class Expression_Lambda : Expression {
    public readonly Dafny.ISequence<DAST._IFormal> _params;
    public readonly DAST._IType _retType;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Expression_Lambda(Dafny.ISequence<DAST._IFormal> @params, DAST._IType retType, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._params = @params;
      this._retType = retType;
      this._body = body;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Lambda(_params, _retType, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Lambda;
      return oth != null && object.Equals(this._params, oth._params) && object.Equals(this._retType, oth._retType) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 22;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._params));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._retType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Lambda";
      s += "(";
      s += Dafny.Helpers.ToString(this._params);
      s += ", ";
      s += Dafny.Helpers.ToString(this._retType);
      s += ", ";
      s += Dafny.Helpers.ToString(this._body);
      s += ")";
      return s;
    }
  }
  public class Expression_BetaRedex : Expression {
    public readonly Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _values;
    public readonly DAST._IType _retType;
    public readonly DAST._IExpression _expr;
    public Expression_BetaRedex(Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> values, DAST._IType retType, DAST._IExpression expr) : base() {
      this._values = values;
      this._retType = retType;
      this._expr = expr;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_BetaRedex(_values, _retType, _expr);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_BetaRedex;
      return oth != null && object.Equals(this._values, oth._values) && object.Equals(this._retType, oth._retType) && object.Equals(this._expr, oth._expr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 23;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._values));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._retType));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.BetaRedex";
      s += "(";
      s += Dafny.Helpers.ToString(this._values);
      s += ", ";
      s += Dafny.Helpers.ToString(this._retType);
      s += ", ";
      s += Dafny.Helpers.ToString(this._expr);
      s += ")";
      return s;
    }
  }
  public class Expression_IIFE : Expression {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly DAST._IType _typ;
    public readonly DAST._IExpression _value;
    public readonly DAST._IExpression _iifeBody;
    public Expression_IIFE(Dafny.ISequence<Dafny.Rune> name, DAST._IType typ, DAST._IExpression @value, DAST._IExpression iifeBody) : base() {
      this._name = name;
      this._typ = typ;
      this._value = @value;
      this._iifeBody = iifeBody;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_IIFE(_name, _typ, _value, _iifeBody);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_IIFE;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typ, oth._typ) && object.Equals(this._value, oth._value) && object.Equals(this._iifeBody, oth._iifeBody);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 24;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._typ));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._iifeBody));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.IIFE";
      s += "(";
      s += Dafny.Helpers.ToString(this._name);
      s += ", ";
      s += Dafny.Helpers.ToString(this._typ);
      s += ", ";
      s += Dafny.Helpers.ToString(this._value);
      s += ", ";
      s += Dafny.Helpers.ToString(this._iifeBody);
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
      hash = ((hash << 5) + hash) + 25;
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
      hash = ((hash << 5) + hash) + 26;
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
      hash = ((hash << 5) + hash) + 27;
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
  public class Expression_BoolBoundedPool : Expression {
    public Expression_BoolBoundedPool() : base() {
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_BoolBoundedPool();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_BoolBoundedPool;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 28;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.BoolBoundedPool";
      return s;
    }
  }
  public class Expression_IntRange : Expression {
    public readonly DAST._IExpression _lo;
    public readonly DAST._IExpression _hi;
    public Expression_IntRange(DAST._IExpression lo, DAST._IExpression hi) : base() {
      this._lo = lo;
      this._hi = hi;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_IntRange(_lo, _hi);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_IntRange;
      return oth != null && object.Equals(this._lo, oth._lo) && object.Equals(this._hi, oth._hi);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 29;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._lo));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._hi));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.IntRange";
      s += "(";
      s += Dafny.Helpers.ToString(this._lo);
      s += ", ";
      s += Dafny.Helpers.ToString(this._hi);
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
    Dafny.ISequence<Dafny.Rune> dtor_IntLiteral_a0 { get; }
    DAST._IType dtor_IntLiteral_a1 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a1 { get; }
    DAST._IType dtor_DecLiteral_a2 { get; }
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
    public static _ILiteral create_IntLiteral(Dafny.ISequence<Dafny.Rune> _a0, DAST._IType _a1) {
      return new Literal_IntLiteral(_a0, _a1);
    }
    public static _ILiteral create_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0, Dafny.ISequence<Dafny.Rune> _a1, DAST._IType _a2) {
      return new Literal_DecLiteral(_a0, _a1, _a2);
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
    public Dafny.ISequence<Dafny.Rune> dtor_IntLiteral_a0 {
      get {
        var d = this;
        return ((Literal_IntLiteral)d)._a0;
      }
    }
    public DAST._IType dtor_IntLiteral_a1 {
      get {
        var d = this;
        return ((Literal_IntLiteral)d)._a1;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0 {
      get {
        var d = this;
        return ((Literal_DecLiteral)d)._a0;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a1 {
      get {
        var d = this;
        return ((Literal_DecLiteral)d)._a1;
      }
    }
    public DAST._IType dtor_DecLiteral_a2 {
      get {
        var d = this;
        return ((Literal_DecLiteral)d)._a2;
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
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public readonly DAST._IType _a1;
    public Literal_IntLiteral(Dafny.ISequence<Dafny.Rune> _a0, DAST._IType _a1) : base() {
      this._a0 = _a0;
      this._a1 = _a1;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_IntLiteral(_a0, _a1);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_IntLiteral;
      return oth != null && object.Equals(this._a0, oth._a0) && object.Equals(this._a1, oth._a1);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a1));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.IntLiteral";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._a1);
      s += ")";
      return s;
    }
  }
  public class Literal_DecLiteral : Literal {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public readonly Dafny.ISequence<Dafny.Rune> _a1;
    public readonly DAST._IType _a2;
    public Literal_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0, Dafny.ISequence<Dafny.Rune> _a1, DAST._IType _a2) : base() {
      this._a0 = _a0;
      this._a1 = _a1;
      this._a2 = _a2;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_DecLiteral(_a0, _a1, _a2);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_DecLiteral;
      return oth != null && object.Equals(this._a0, oth._a0) && object.Equals(this._a1, oth._a1) && object.Equals(this._a2, oth._a2);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a1));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a2));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.DecLiteral";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ", ";
      s += this._a1.ToVerbatimString(true);
      s += ", ";
      s += Dafny.Helpers.ToString(this._a2);
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
          _out2 = DCOMP.COMP.GenClass(c, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((c).dtor_name)));
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
    public static void GenTypeParameters(Dafny.ISequence<DAST._IType> @params, out Dafny.ISet<DAST._IType> typeParamsSet, out Dafny.ISequence<Dafny.Rune> typeParams, out Dafny.ISequence<Dafny.Rune> constrainedTypeParams) {
      typeParamsSet = Dafny.Set<DAST._IType>.Empty;
      typeParams = Dafny.Sequence<Dafny.Rune>.Empty;
      constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Empty;
      typeParamsSet = Dafny.Set<DAST._IType>.FromElements();
      typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _13_tpI;
      _13_tpI = BigInteger.Zero;
      if ((new BigInteger((@params).Count)).Sign == 1) {
        typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_13_tpI) < (new BigInteger((@params).Count))) {
          DAST._IType _14_tp;
          _14_tp = (@params).Select(_13_tpI);
          typeParamsSet = Dafny.Set<DAST._IType>.Union(typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_14_tp));
          Dafny.ISequence<Dafny.Rune> _15_genTp;
          Dafny.ISequence<Dafny.Rune> _out6;
          _out6 = DCOMP.COMP.GenType(_14_tp, false, false);
          _15_genTp = _out6;
          typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(typeParams, _15_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(constrainedTypeParams, _15_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _15_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static, "));
          _13_tpI = (_13_tpI) + (BigInteger.One);
        }
        typeParams = Dafny.Sequence<Dafny.Rune>.Concat(typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(constrainedTypeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenClass(DAST._IClass c, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _16_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _17_typeParams;
      Dafny.ISequence<Dafny.Rune> _18_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out7;
      Dafny.ISequence<Dafny.Rune> _out8;
      Dafny.ISequence<Dafny.Rune> _out9;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out7, out _out8, out _out9);
      _16_typeParamsSet = _out7;
      _17_typeParams = _out8;
      _18_constrainedTypeParams = _out9;
      Dafny.ISequence<Dafny.Rune> _19_fields;
      _19_fields = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      Dafny.ISequence<Dafny.Rune> _20_fieldInits;
      _20_fieldInits = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _21_fieldI;
      _21_fieldI = BigInteger.Zero;
      while ((_21_fieldI) < (new BigInteger(((c).dtor_fields).Count))) {
        DAST._IField _22_field;
        _22_field = ((c).dtor_fields).Select(_21_fieldI);
        Dafny.ISequence<Dafny.Rune> _23_fieldType;
        Dafny.ISequence<Dafny.Rune> _out10;
        _out10 = DCOMP.COMP.GenType(((_22_field).dtor_formal).dtor_typ, false, false);
        _23_fieldType = _out10;
        _19_fields = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_19_fields, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub r#")), ((_22_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::cell::RefCell<")), _23_fieldType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">,\n"));
        DAST._IOptional<DAST._IExpression> _source1 = (_22_field).dtor_defaultValue;
        if (_source1.is_Some) {
          DAST._IExpression _24___mcc_h0 = _source1.dtor_Some_a0;
          DAST._IExpression _25_e = _24___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _26_eStr;
            bool _27___v1;
            bool _28___v2;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _29___v3;
            Dafny.ISequence<Dafny.Rune> _out11;
            bool _out12;
            bool _out13;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out14;
            DCOMP.COMP.GenExpr(_25_e, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out11, out _out12, out _out13, out _out14);
            _26_eStr = _out11;
            _27___v1 = _out12;
            _28___v2 = _out13;
            _29___v3 = _out14;
            _20_fieldInits = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_20_fieldInits, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((_22_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::cell::RefCell::new(")), _26_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("),\n"));
          }
        } else {
          {
            _20_fieldInits = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_20_fieldInits, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((_22_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::cell::RefCell::new(::std::default::Default::default()),\n"));
          }
        }
        _21_fieldI = (_21_fieldI) + (BigInteger.One);
      }
      BigInteger _30_typeParamI;
      _30_typeParamI = BigInteger.Zero;
      while ((_30_typeParamI) < (new BigInteger(((c).dtor_typeParams).Count))) {
        Dafny.ISequence<Dafny.Rune> _31_tpeGen;
        Dafny.ISequence<Dafny.Rune> _out15;
        _out15 = DCOMP.COMP.GenType(((c).dtor_typeParams).Select(_30_typeParamI), false, false);
        _31_tpeGen = _out15;
        _19_fields = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_19_fields, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_phantom_type_param_")), DCOMP.__default.natToString(_30_typeParamI)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::marker::PhantomData<")), _31_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">,\n"));
        _20_fieldInits = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_20_fieldInits, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_phantom_type_param_")), DCOMP.__default.natToString(_30_typeParamI)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::marker::PhantomData,\n"));
        _30_typeParamI = (_30_typeParamI) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub struct r#"), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _19_fields), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _32_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _33_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out16;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out17;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(path)), Dafny.Set<DAST._IType>.FromElements(), out _out16, out _out17);
      _32_implBody = _out16;
      _33_traitBodies = _out17;
      _32_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn new() -> Self {\n"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _20_fieldInits), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n")), _32_implBody);
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _32_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      if ((new BigInteger(((c).dtor_superClasses).Count)).Sign == 1) {
        BigInteger _34_i;
        _34_i = BigInteger.Zero;
        while ((_34_i) < (new BigInteger(((c).dtor_superClasses).Count))) {
          DAST._IType _35_superClass;
          _35_superClass = ((c).dtor_superClasses).Select(_34_i);
          DAST._IType _source2 = _35_superClass;
          if (_source2.is_Path) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _36___mcc_h1 = _source2.dtor_Path_a0;
            Dafny.ISequence<DAST._IType> _37___mcc_h2 = _source2.dtor_typeArgs;
            DAST._IResolvedType _38___mcc_h3 = _source2.dtor_resolved;
            DAST._IResolvedType _source3 = _38___mcc_h3;
            if (_source3.is_Datatype) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _39___mcc_h7 = _source3.dtor_path;
            } else if (_source3.is_Trait) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _40___mcc_h9 = _source3.dtor_path;
              Dafny.ISequence<DAST._IType> _41_typeArgs = _37___mcc_h2;
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _42_traitPath = _36___mcc_h1;
              {
                Dafny.ISequence<Dafny.Rune> _43_pathStr;
                Dafny.ISequence<Dafny.Rune> _out18;
                _out18 = DCOMP.COMP.GenPath(_42_traitPath);
                _43_pathStr = _out18;
                Dafny.ISequence<Dafny.Rune> _44_typeArgs;
                Dafny.ISequence<Dafny.Rune> _out19;
                _out19 = DCOMP.COMP.GenTypeArgs(_41_typeArgs, false, false);
                _44_typeArgs = _out19;
                Dafny.ISequence<Dafny.Rune> _45_body;
                _45_body = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
                if ((_33_traitBodies).Contains(_42_traitPath)) {
                  _45_body = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(_33_traitBodies, _42_traitPath);
                }
                Dafny.ISequence<Dafny.Rune> _46_genSelfPath;
                Dafny.ISequence<Dafny.Rune> _out20;
                _out20 = DCOMP.COMP.GenPath(path);
                _46_genSelfPath = _out20;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nimpl ")), _43_pathStr), _44_typeArgs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" for ::std::rc::Rc<")), _46_genSelfPath), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> {\n")), _45_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
              }
            } else {
              DAST._IType _47___mcc_h11 = _source3.dtor_Newtype_a0;
            }
          } else if (_source2.is_Nullable) {
            DAST._IType _48___mcc_h13 = _source2.dtor_Nullable_a0;
          } else if (_source2.is_Tuple) {
            Dafny.ISequence<DAST._IType> _49___mcc_h15 = _source2.dtor_Tuple_a0;
          } else if (_source2.is_Array) {
            DAST._IType _50___mcc_h17 = _source2.dtor_element;
            BigInteger _51___mcc_h18 = _source2.dtor_dims;
          } else if (_source2.is_Seq) {
            DAST._IType _52___mcc_h21 = _source2.dtor_element;
          } else if (_source2.is_Set) {
            DAST._IType _53___mcc_h23 = _source2.dtor_element;
          } else if (_source2.is_Multiset) {
            DAST._IType _54___mcc_h25 = _source2.dtor_element;
          } else if (_source2.is_Map) {
            DAST._IType _55___mcc_h27 = _source2.dtor_key;
            DAST._IType _56___mcc_h28 = _source2.dtor_value;
          } else if (_source2.is_Arrow) {
            Dafny.ISequence<DAST._IType> _57___mcc_h31 = _source2.dtor_args;
            DAST._IType _58___mcc_h32 = _source2.dtor_result;
          } else if (_source2.is_Primitive) {
            DAST._IPrimitive _59___mcc_h35 = _source2.dtor_Primitive_a0;
          } else if (_source2.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _60___mcc_h37 = _source2.dtor_Passthrough_a0;
          } else {
            Dafny.ISequence<Dafny.Rune> _61___mcc_h39 = _source2.dtor_TypeArg_a0;
          }
          _34_i = (_34_i) + (BigInteger.One);
        }
      }
      Dafny.ISequence<Dafny.Rune> _62_defaultImpl;
      _62_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _62_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_62_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      _62_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_62_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new()\n"));
      _62_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_62_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      _62_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_62_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      Dafny.ISequence<Dafny.Rune> _63_printImpl;
      _63_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n"));
      _63_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_63_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"")), ((c).dtor_enclosingModule)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _64_ptrPartialEqImpl;
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_64_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_64_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_64_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _62_defaultImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _63_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _64_ptrPartialEqImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTrait(DAST._ITrait t, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _65_typeParamsSet;
      _65_typeParamsSet = Dafny.Set<DAST._IType>.FromElements();
      Dafny.ISequence<Dafny.Rune> _66_typeParams;
      _66_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _67_tpI;
      _67_tpI = BigInteger.Zero;
      if ((new BigInteger(((t).dtor_typeParams).Count)).Sign == 1) {
        _66_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_67_tpI) < (new BigInteger(((t).dtor_typeParams).Count))) {
          DAST._IType _68_tp;
          _68_tp = ((t).dtor_typeParams).Select(_67_tpI);
          _65_typeParamsSet = Dafny.Set<DAST._IType>.Union(_65_typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_68_tp));
          Dafny.ISequence<Dafny.Rune> _69_genTp;
          Dafny.ISequence<Dafny.Rune> _out21;
          _out21 = DCOMP.COMP.GenType(_68_tp, false, false);
          _69_genTp = _out21;
          _66_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_66_typeParams, _69_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          _67_tpI = (_67_tpI) + (BigInteger.One);
        }
        _66_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(_66_typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _70_fullPath;
      _70_fullPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((t).dtor_name));
      Dafny.ISequence<Dafny.Rune> _71_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _72___v6;
      Dafny.ISequence<Dafny.Rune> _out22;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out23;
      DCOMP.COMP.GenClassImplBody((t).dtor_body, true, DAST.Type.create_Path(_70_fullPath, Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Trait(_70_fullPath)), _65_typeParamsSet, out _out22, out _out23);
      _71_implBody = _out22;
      _72___v6 = _out23;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait r#"), (t).dtor_name), _66_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _71_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenNewtype(DAST._INewtype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _73_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _74_typeParams;
      Dafny.ISequence<Dafny.Rune> _75_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out24;
      Dafny.ISequence<Dafny.Rune> _out25;
      Dafny.ISequence<Dafny.Rune> _out26;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out24, out _out25, out _out26);
      _73_typeParamsSet = _out24;
      _74_typeParams = _out25;
      _75_constrainedTypeParams = _out26;
      Dafny.ISequence<Dafny.Rune> _76_underlyingType;
      Dafny.ISequence<Dafny.Rune> _out27;
      _out27 = DCOMP.COMP.GenType((c).dtor_base, false, false);
      _76_underlyingType = _out27;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Clone, PartialEq)]\n#[repr(transparent)]\npub struct r#"), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(pub ")), _76_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _75_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = ")), _76_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase(&self) -> &Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase_owned(self) -> Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _75_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), _76_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &")), _76_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unsafe { &*(x as *const ")), _76_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as *const r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") }\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: ")), _76_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(x)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _75_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _75_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      DAST._IOptional<DAST._IExpression> _source4 = (c).dtor_witnessExpr;
      if (_source4.is_Some) {
        DAST._IExpression _77___mcc_h0 = _source4.dtor_Some_a0;
        DAST._IExpression _78_e = _77___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _79_eStr;
          bool _80___v7;
          bool _81___v8;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _82___v9;
          Dafny.ISequence<Dafny.Rune> _out28;
          bool _out29;
          bool _out30;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out31;
          DCOMP.COMP.GenExpr(_78_e, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out28, out _out29, out _out30, out _out31);
          _79_eStr = _out28;
          _80___v7 = _out29;
          _81___v8 = _out30;
          _82___v9 = _out31;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _79_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(::std::default::Default::default())\n"));
        }
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _75_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _74_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, in_seq: bool) -> ::std::fmt::Result {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyPrint::fmt_print(&self.0, __fmt_print_formatter, in_seq)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenDatatype(DAST._IDatatype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _83_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _84_typeParams;
      Dafny.ISequence<Dafny.Rune> _85_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out32;
      Dafny.ISequence<Dafny.Rune> _out33;
      Dafny.ISequence<Dafny.Rune> _out34;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out32, out _out33, out _out34);
      _83_typeParamsSet = _out32;
      _84_typeParams = _out33;
      _85_constrainedTypeParams = _out34;
      Dafny.ISequence<Dafny.Rune> _86_ctors;
      _86_ctors = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _87_i;
      _87_i = BigInteger.Zero;
      while ((_87_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _88_ctor;
        _88_ctor = ((c).dtor_ctors).Select(_87_i);
        Dafny.ISequence<Dafny.Rune> _89_ctorBody;
        _89_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_88_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        BigInteger _90_j;
        _90_j = BigInteger.Zero;
        while ((_90_j) < (new BigInteger(((_88_ctor).dtor_args).Count))) {
          DAST._IFormal _91_formal;
          _91_formal = ((_88_ctor).dtor_args).Select(_90_j);
          Dafny.ISequence<Dafny.Rune> _92_formalType;
          Dafny.ISequence<Dafny.Rune> _out35;
          _out35 = DCOMP.COMP.GenType((_91_formal).dtor_typ, false, false);
          _92_formalType = _out35;
          if ((c).dtor_isCo) {
            _89_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_89_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_91_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper<")), _92_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">, "));
          } else {
            _89_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_89_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_91_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _92_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          _90_j = (_90_j) + (BigInteger.One);
        }
        _89_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(_89_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        _86_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_86_ctors, _89_ctorBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
        _87_i = (_87_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _93_selfPath;
      _93_selfPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((c).dtor_name);
      Dafny.ISequence<Dafny.Rune> _94_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _95_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out36;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out37;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(_93_selfPath)), _83_typeParamsSet, out _out36, out _out37);
      _94_implBody = _out36;
      _95_traitBodies = _out37;
      _87_i = BigInteger.Zero;
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _96_emittedFields;
      _96_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      while ((_87_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _97_ctor;
        _97_ctor = ((c).dtor_ctors).Select(_87_i);
        BigInteger _98_j;
        _98_j = BigInteger.Zero;
        while ((_98_j) < (new BigInteger(((_97_ctor).dtor_args).Count))) {
          DAST._IFormal _99_formal;
          _99_formal = ((_97_ctor).dtor_args).Select(_98_j);
          if (!((_96_emittedFields).Contains((_99_formal).dtor_name))) {
            _96_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_96_emittedFields, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_99_formal).dtor_name));
            Dafny.ISequence<Dafny.Rune> _100_formalType;
            Dafny.ISequence<Dafny.Rune> _out38;
            _out38 = DCOMP.COMP.GenType((_99_formal).dtor_typ, false, false);
            _100_formalType = _out38;
            Dafny.ISequence<Dafny.Rune> _101_methodBody;
            _101_methodBody = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n");
            BigInteger _102_k;
            _102_k = BigInteger.Zero;
            while ((_102_k) < (new BigInteger(((c).dtor_ctors).Count))) {
              DAST._IDatatypeCtor _103_ctor2;
              _103_ctor2 = ((c).dtor_ctors).Select(_102_k);
              Dafny.ISequence<Dafny.Rune> _104_ctorMatch;
              _104_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_103_ctor2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
              BigInteger _105_l;
              _105_l = BigInteger.Zero;
              bool _106_hasMatchingField;
              _106_hasMatchingField = false;
              while ((_105_l) < (new BigInteger(((_103_ctor2).dtor_args).Count))) {
                DAST._IFormal _107_formal2;
                _107_formal2 = ((_103_ctor2).dtor_args).Select(_105_l);
                if (((_99_formal).dtor_name).Equals((_107_formal2).dtor_name)) {
                  _106_hasMatchingField = true;
                }
                _104_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_104_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_107_formal2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                _105_l = (_105_l) + (BigInteger.One);
              }
              if (_106_hasMatchingField) {
                if ((c).dtor_isCo) {
                  _104_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_104_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ::std::ops::Deref::deref(&")), (_99_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0),\n"));
                } else {
                  _104_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_104_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ")), (_99_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
                }
              } else {
                _104_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_104_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => panic!(\"field does not exist on this variant\"),\n"));
              }
              _101_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_101_methodBody, _104_ctorMatch);
              _102_k = (_102_k) + (BigInteger.One);
            }
            if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
              _101_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_101_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => panic!(),\n"));
            }
            _101_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_101_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            _94_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_94_implBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#")), (_99_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&self) -> &")), _100_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _101_methodBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
          }
          _98_j = (_98_j) + (BigInteger.One);
        }
        _87_i = (_87_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _86_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_86_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_PhantomVariant("));
        BigInteger _108_typeI;
        _108_typeI = BigInteger.Zero;
        while ((_108_typeI) < (new BigInteger(((c).dtor_typeParams).Count))) {
          if ((_108_typeI).Sign == 1) {
            _86_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_86_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _109_genTp;
          Dafny.ISequence<Dafny.Rune> _out39;
          _out39 = DCOMP.COMP.GenType(((c).dtor_typeParams).Select(_108_typeI), false, false);
          _109_genTp = _out39;
          _86_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_86_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::marker::PhantomData::<")), _109_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          _108_typeI = (_108_typeI) + (BigInteger.One);
        }
        _86_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_86_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      Dafny.ISequence<Dafny.Rune> _110_enumBody;
      _110_enumBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(PartialEq)]\npub enum r#"), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _86_ctors), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _85_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _94_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _111_identEraseImpls;
      _111_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _85_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = Self;\nfn erase(&self) -> &Self::Erased { self }\nfn erase_owned(self) -> Self::Erased { self }}\n"));
      _111_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_111_identEraseImpls, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _85_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn unerase(x: &Self) -> &Self { x }\nfn unerase_owned(x: Self) -> Self { x }}\n"));
      Dafny.ISequence<Dafny.Rune> _112_printImpl;
      _112_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _85_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n"));
      _87_i = BigInteger.Zero;
      while ((_87_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _113_ctor;
        _113_ctor = ((c).dtor_ctors).Select(_87_i);
        Dafny.ISequence<Dafny.Rune> _114_ctorMatch;
        _114_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_113_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        Dafny.ISequence<Dafny.Rune> _115_modulePrefix;
        _115_modulePrefix = (((((c).dtor_enclosingModule)).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_module"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(((c).dtor_enclosingModule), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("."))));
        Dafny.ISequence<Dafny.Rune> _116_printRhs;
        _116_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \""), _115_modulePrefix), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (_113_ctor).dtor_name), (((_113_ctor).dtor_hasAnyArgs) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(\")?;")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"))));
        BigInteger _117_j;
        _117_j = BigInteger.Zero;
        while ((_117_j) < (new BigInteger(((_113_ctor).dtor_args).Count))) {
          DAST._IFormal _118_formal;
          _118_formal = ((_113_ctor).dtor_args).Select(_117_j);
          _114_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_114_ctorMatch, (_118_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          if ((_117_j).Sign == 1) {
            _116_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_116_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
          }
          _116_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_116_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(")), (_118_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", __fmt_print_formatter, false)?;"));
          _117_j = (_117_j) + (BigInteger.One);
        }
        _114_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_114_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        if ((_113_ctor).dtor_hasAnyArgs) {
          _116_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_116_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
        }
        _116_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_116_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())"));
        _112_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_112_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _114_ctorMatch), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" => {\n")), _116_printRhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
        _87_i = (_87_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _112_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_112_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => {panic!()\n}\n"));
      }
      _112_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_112_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _119_defaultImpl;
      _119_defaultImpl = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_ctors).Count)).Sign == 1) {
        _119_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _85_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _84_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (((c).dtor_ctors).Select(BigInteger.Zero)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        _87_i = BigInteger.Zero;
        while ((_87_i) < (new BigInteger(((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Count))) {
          DAST._IFormal _120_formal;
          _120_formal = ((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Select(_87_i);
          _119_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_119_defaultImpl, (_120_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": std::default::Default::default(),\n"));
          _87_i = (_87_i) + (BigInteger.One);
        }
        _119_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_119_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_110_enumBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _111_identEraseImpls), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _112_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _119_defaultImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenPath(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      if ((new BigInteger((p).Count)).Sign == 0) {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Self");
        return s;
      } else {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("super::");
        BigInteger _121_i;
        _121_i = BigInteger.Zero;
        while ((_121_i) < (new BigInteger((p).Count))) {
          if ((_121_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((p).Select(_121_i)));
          _121_i = (_121_i) + (BigInteger.One);
        }
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTypeArgs(Dafny.ISequence<DAST._IType> args, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger((args).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _122_i;
        _122_i = BigInteger.Zero;
        while ((_122_i) < (new BigInteger((args).Count))) {
          if ((_122_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _123_genTp;
          Dafny.ISequence<Dafny.Rune> _out40;
          _out40 = DCOMP.COMP.GenType((args).Select(_122_i), inBinding, inFn);
          _123_genTp = _out40;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _123_genTp);
          _122_i = (_122_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenType(DAST._IType c, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      DAST._IType _source5 = c;
      if (_source5.is_Path) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _124___mcc_h0 = _source5.dtor_Path_a0;
        Dafny.ISequence<DAST._IType> _125___mcc_h1 = _source5.dtor_typeArgs;
        DAST._IResolvedType _126___mcc_h2 = _source5.dtor_resolved;
        DAST._IResolvedType _127_resolved = _126___mcc_h2;
        Dafny.ISequence<DAST._IType> _128_args = _125___mcc_h1;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _129_p = _124___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _out41;
          _out41 = DCOMP.COMP.GenPath(_129_p);
          s = _out41;
          Dafny.ISequence<Dafny.Rune> _130_typeArgs;
          Dafny.ISequence<Dafny.Rune> _out42;
          _out42 = DCOMP.COMP.GenTypeArgs(_128_args, inBinding, inFn);
          _130_typeArgs = _out42;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _130_typeArgs);
          DAST._IResolvedType _source6 = _127_resolved;
          if (_source6.is_Datatype) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _131___mcc_h18 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _132___mcc_h20 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IType _133___mcc_h22 = _source6.dtor_Newtype_a0;
            DAST._IResolvedType _134_Primitive = _127_resolved;
          }
        }
      } else if (_source5.is_Nullable) {
        DAST._IType _135___mcc_h3 = _source5.dtor_Nullable_a0;
        DAST._IType _136_inner = _135___mcc_h3;
        {
          Dafny.ISequence<Dafny.Rune> _137_innerStr;
          Dafny.ISequence<Dafny.Rune> _out43;
          _out43 = DCOMP.COMP.GenType(_136_inner, inBinding, inFn);
          _137_innerStr = _out43;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::option::Option<"), _137_innerStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Tuple) {
        Dafny.ISequence<DAST._IType> _138___mcc_h4 = _source5.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _139_types = _138___mcc_h4;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _140_i;
          _140_i = BigInteger.Zero;
          while ((_140_i) < (new BigInteger((_139_types).Count))) {
            if ((_140_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _141_generated;
            Dafny.ISequence<Dafny.Rune> _out44;
            _out44 = DCOMP.COMP.GenType((_139_types).Select(_140_i), inBinding, inFn);
            _141_generated = _out44;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _141_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _140_i = (_140_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source5.is_Array) {
        DAST._IType _142___mcc_h5 = _source5.dtor_element;
        BigInteger _143___mcc_h6 = _source5.dtor_dims;
        BigInteger _144_dims = _143___mcc_h6;
        DAST._IType _145_element = _142___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _146_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_145_element, inBinding, inFn);
          _146_elemStr = _out45;
          s = _146_elemStr;
          BigInteger _147_i;
          _147_i = BigInteger.Zero;
          while ((_147_i) < (_144_dims)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<::std::cell::RefCell<::std::vec::Vec<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>>"));
            _147_i = (_147_i) + (BigInteger.One);
          }
        }
      } else if (_source5.is_Seq) {
        DAST._IType _148___mcc_h7 = _source5.dtor_element;
        DAST._IType _149_element = _148___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _150_elemStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_149_element, inBinding, inFn);
          _150_elemStr = _out46;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _150_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _151___mcc_h8 = _source5.dtor_element;
        DAST._IType _152_element = _151___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _153_elemStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_152_element, inBinding, inFn);
          _153_elemStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _153_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _154___mcc_h9 = _source5.dtor_element;
        DAST._IType _155_element = _154___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _156_elemStr;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenType(_155_element, inBinding, inFn);
          _156_elemStr = _out48;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _156_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _157___mcc_h10 = _source5.dtor_key;
        DAST._IType _158___mcc_h11 = _source5.dtor_value;
        DAST._IType _159_value = _158___mcc_h11;
        DAST._IType _160_key = _157___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _161_keyStr;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenType(_160_key, inBinding, inFn);
          _161_keyStr = _out49;
          Dafny.ISequence<Dafny.Rune> _162_valueStr;
          Dafny.ISequence<Dafny.Rune> _out50;
          _out50 = DCOMP.COMP.GenType(_159_value, inBinding, inFn);
          _162_valueStr = _out50;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _161_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _162_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _163___mcc_h12 = _source5.dtor_args;
        DAST._IType _164___mcc_h13 = _source5.dtor_result;
        DAST._IType _165_result = _164___mcc_h13;
        Dafny.ISequence<DAST._IType> _166_args = _163___mcc_h12;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::rc::Rc<dyn ::std::ops::Fn(");
          BigInteger _167_i;
          _167_i = BigInteger.Zero;
          while ((_167_i) < (new BigInteger((_166_args).Count))) {
            if ((_167_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _168_generated;
            Dafny.ISequence<Dafny.Rune> _out51;
            _out51 = DCOMP.COMP.GenType((_166_args).Select(_167_i), inBinding, true);
            _168_generated = _out51;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _168_generated);
            _167_i = (_167_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _169_resultType;
          Dafny.ISequence<Dafny.Rune> _out52;
          _out52 = DCOMP.COMP.GenType(_165_result, inBinding, (inFn) || (inBinding));
          _169_resultType = _out52;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _169_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _170___mcc_h14 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _171_p = _170___mcc_h14;
        {
          DAST._IPrimitive _source7 = _171_p;
          if (_source7.is_Int) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt");
          } else if (_source7.is_Real) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational");
          } else if (_source7.is_String) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Vec<char>");
          } else if (_source7.is_Bool) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("bool");
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char");
          }
        }
      } else if (_source5.is_Passthrough) {
        Dafny.ISequence<Dafny.Rune> _172___mcc_h15 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _173_v = _172___mcc_h15;
        s = _173_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _174___mcc_h16 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _174___mcc_h16;
        Dafny.ISequence<Dafny.Rune> _175___mcc_h17 = _source8;
        Dafny.ISequence<Dafny.Rune> _176_name = _175___mcc_h17;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _176_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _177_i;
      _177_i = BigInteger.Zero;
      while ((_177_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_177_i);
        DAST._IMethod _178___mcc_h0 = _source9;
        DAST._IMethod _179_m = _178___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_179_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _180___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _181_p = _180___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _182_existing;
              _182_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_181_p)) {
                _182_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _181_p);
              }
              if ((new BigInteger((_182_existing).Count)).Sign == 1) {
                _182_existing = Dafny.Sequence<Dafny.Rune>.Concat(_182_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _183_genMethod;
              Dafny.ISequence<Dafny.Rune> _out53;
              _out53 = DCOMP.COMP.GenMethod(_179_m, true, enclosingType, enclosingTypeParams);
              _183_genMethod = _out53;
              _182_existing = Dafny.Sequence<Dafny.Rune>.Concat(_182_existing, _183_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_181_p, _182_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _184_generated;
              Dafny.ISequence<Dafny.Rune> _out54;
              _out54 = DCOMP.COMP.GenMethod(_179_m, forTrait, enclosingType, enclosingTypeParams);
              _184_generated = _out54;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _184_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _177_i = (_177_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _185_i;
      _185_i = BigInteger.Zero;
      while ((_185_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _186_param;
        _186_param = (@params).Select(_185_i);
        Dafny.ISequence<Dafny.Rune> _187_paramType;
        Dafny.ISequence<Dafny.Rune> _out55;
        _out55 = DCOMP.COMP.GenType((_186_param).dtor_typ, false, false);
        _187_paramType = _out55;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_186_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _187_paramType);
        if ((_185_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _185_i = (_185_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _188_params;
      Dafny.ISequence<Dafny.Rune> _out56;
      _out56 = DCOMP.COMP.GenParams((m).dtor_params);
      _188_params = _out56;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _189_paramNames;
      _189_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _190_paramI;
      _190_paramI = BigInteger.Zero;
      while ((_190_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _189_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_189_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_190_paramI)).dtor_name));
        _190_paramI = (_190_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _188_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _188_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _191_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out57;
          _out57 = DCOMP.COMP.GenType(enclosingType, false, false);
          _191_enclosingTypeString = _out57;
          _188_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _191_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _188_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _192_retType;
      _192_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _193_typeI;
      _193_typeI = BigInteger.Zero;
      while ((_193_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_193_typeI).Sign == 1) {
          _192_retType = Dafny.Sequence<Dafny.Rune>.Concat(_192_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _194_typeString;
        Dafny.ISequence<Dafny.Rune> _out58;
        _out58 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_193_typeI), false, false);
        _194_typeString = _out58;
        _192_retType = Dafny.Sequence<Dafny.Rune>.Concat(_192_retType, _194_typeString);
        _193_typeI = (_193_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _192_retType = Dafny.Sequence<Dafny.Rune>.Concat(_192_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _195_typeParamsFiltered;
      _195_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _196_typeParamI;
      _196_typeParamI = BigInteger.Zero;
      while ((_196_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _197_typeParam;
        _197_typeParam = ((m).dtor_typeParams).Select(_196_typeParamI);
        if (!((enclosingTypeParams).Contains(_197_typeParam))) {
          _195_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_195_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_197_typeParam));
        }
        _196_typeParamI = (_196_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_195_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _198_i;
        _198_i = BigInteger.Zero;
        while ((_198_i) < (new BigInteger((_195_typeParamsFiltered).Count))) {
          if ((_198_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _199_typeString;
          Dafny.ISequence<Dafny.Rune> _out59;
          _out59 = DCOMP.COMP.GenType((_195_typeParamsFiltered).Select(_198_i), false, false);
          _199_typeString = _out59;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _199_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _199_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _198_i = (_198_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _188_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _192_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _200_earlyReturn;
        _200_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _201___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _202_outVars = _201___mcc_h0;
          {
            _200_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _203_outI;
            _203_outI = BigInteger.Zero;
            while ((_203_outI) < (new BigInteger((_202_outVars).Count))) {
              if ((_203_outI).Sign == 1) {
                _200_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_200_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _204_outVar;
              _204_outVar = (_202_outVars).Select(_203_outI);
              _200_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_200_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_204_outVar));
              _203_outI = (_203_outI) + (BigInteger.One);
            }
            _200_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_200_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _205_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _206___v12;
        Dafny.ISequence<Dafny.Rune> _out60;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out61;
        DCOMP.COMP.GenStmts((m).dtor_body, (((m).dtor_isStatic) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None()) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self")))), _189_paramNames, true, _200_earlyReturn, out _out60, out _out61);
        _205_body = _out60;
        _206___v12 = _out61;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source12 = (m).dtor_outVars;
        if (_source12.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _207___mcc_h1 = _source12.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _208_outVars = _207___mcc_h1;
          {
            _205_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_205_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _200_earlyReturn);
          }
        } else {
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _205_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      }
      return s;
    }
    public static void GenStmts(Dafny.ISequence<DAST._IStatement> stmts, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _209_declarations;
      _209_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _210_i;
      _210_i = BigInteger.Zero;
      while ((_210_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _211_stmt;
        _211_stmt = (stmts).Select(_210_i);
        Dafny.ISequence<Dafny.Rune> _212_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _213_recIdents;
        Dafny.ISequence<Dafny.Rune> _out62;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out63;
        DCOMP.COMP.GenStmt(_211_stmt, selfIdent, @params, (isLast) && ((_210_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out62, out _out63);
        _212_stmtString = _out62;
        _213_recIdents = _out63;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_213_recIdents, _209_declarations));
        DAST._IStatement _source13 = _211_stmt;
        if (_source13.is_DeclareVar) {
          Dafny.ISequence<Dafny.Rune> _214___mcc_h0 = _source13.dtor_name;
          DAST._IType _215___mcc_h1 = _source13.dtor_typ;
          DAST._IOptional<DAST._IExpression> _216___mcc_h2 = _source13.dtor_maybeValue;
          Dafny.ISequence<Dafny.Rune> _217_name = _214___mcc_h0;
          {
            _209_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_209_declarations, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_217_name));
          }
        } else if (_source13.is_Assign) {
          DAST._IAssignLhs _218___mcc_h6 = _source13.dtor_lhs;
          DAST._IExpression _219___mcc_h7 = _source13.dtor_value;
        } else if (_source13.is_If) {
          DAST._IExpression _220___mcc_h10 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _221___mcc_h11 = _source13.dtor_thn;
          Dafny.ISequence<DAST._IStatement> _222___mcc_h12 = _source13.dtor_els;
        } else if (_source13.is_Labeled) {
          Dafny.ISequence<Dafny.Rune> _223___mcc_h16 = _source13.dtor_lbl;
          Dafny.ISequence<DAST._IStatement> _224___mcc_h17 = _source13.dtor_body;
        } else if (_source13.is_While) {
          DAST._IExpression _225___mcc_h20 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _226___mcc_h21 = _source13.dtor_body;
        } else if (_source13.is_Foreach) {
          Dafny.ISequence<Dafny.Rune> _227___mcc_h24 = _source13.dtor_boundName;
          DAST._IType _228___mcc_h25 = _source13.dtor_boundType;
          DAST._IExpression _229___mcc_h26 = _source13.dtor_over;
          Dafny.ISequence<DAST._IStatement> _230___mcc_h27 = _source13.dtor_body;
        } else if (_source13.is_Call) {
          DAST._IExpression _231___mcc_h32 = _source13.dtor_on;
          Dafny.ISequence<Dafny.Rune> _232___mcc_h33 = _source13.dtor_name;
          Dafny.ISequence<DAST._IType> _233___mcc_h34 = _source13.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _234___mcc_h35 = _source13.dtor_args;
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _235___mcc_h36 = _source13.dtor_outs;
        } else if (_source13.is_Return) {
          DAST._IExpression _236___mcc_h42 = _source13.dtor_expr;
        } else if (_source13.is_EarlyReturn) {
        } else if (_source13.is_Break) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _237___mcc_h44 = _source13.dtor_toLabel;
        } else if (_source13.is_TailRecursive) {
          Dafny.ISequence<DAST._IStatement> _238___mcc_h46 = _source13.dtor_body;
        } else if (_source13.is_JumpTailCallStart) {
        } else if (_source13.is_Halt) {
        } else {
          DAST._IExpression _239___mcc_h48 = _source13.dtor_Print_a0;
        }
        if ((_210_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _212_stmtString);
        _210_i = (_210_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.Rune> rhs, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source14 = lhs;
      if (_source14.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _240___mcc_h0 = _source14.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source15 = _240___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _241___mcc_h1 = _source15;
        Dafny.ISequence<Dafny.Rune> _242_id = _241___mcc_h1;
        {
          if ((@params).Contains(_242_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _242_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _242_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_242_id);
          needsIIFE = false;
        }
      } else if (_source14.is_Select) {
        DAST._IExpression _243___mcc_h2 = _source14.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _244___mcc_h3 = _source14.dtor_field;
        Dafny.ISequence<Dafny.Rune> _245_field = _244___mcc_h3;
        DAST._IExpression _246_on = _243___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _247_onExpr;
          bool _248_onOwned;
          bool _249_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _250_recIdents;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          bool _out66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out67;
          DCOMP.COMP.GenExpr(_246_on, selfIdent, @params, false, out _out64, out _out65, out _out66, out _out67);
          _247_onExpr = _out64;
          _248_onOwned = _out65;
          _249_onErased = _out66;
          _250_recIdents = _out67;
          if (!(_249_onErased)) {
            Dafny.ISequence<Dafny.Rune> _251_eraseFn;
            _251_eraseFn = ((_248_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _247_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _251_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _247_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _247_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _245_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _250_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _252___mcc_h4 = _source14.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _253___mcc_h5 = _source14.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _254_indices = _253___mcc_h5;
        DAST._IExpression _255_on = _252___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _256_onExpr;
          bool _257_onOwned;
          bool _258_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _259_recIdents;
          Dafny.ISequence<Dafny.Rune> _out68;
          bool _out69;
          bool _out70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
          DCOMP.COMP.GenExpr(_255_on, selfIdent, @params, false, out _out68, out _out69, out _out70, out _out71);
          _256_onExpr = _out68;
          _257_onOwned = _out69;
          _258_onErased = _out70;
          _259_recIdents = _out71;
          readIdents = _259_recIdents;
          if (!(_258_onErased)) {
            Dafny.ISequence<Dafny.Rune> _260_eraseFn;
            _260_eraseFn = ((_257_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _256_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _260_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _256_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          BigInteger _261_i;
          _261_i = BigInteger.Zero;
          while ((_261_i) < (new BigInteger((_254_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _262_idx;
            bool _263___v16;
            bool _264_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _265_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            bool _out74;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
            DCOMP.COMP.GenExpr((_254_indices).Select(_261_i), selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
            _262_idx = _out72;
            _263___v16 = _out73;
            _264_idxErased = _out74;
            _265_recIdentsIdx = _out75;
            if (!(_264_idxErased)) {
              _262_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _262_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let __idx")), DCOMP.__default.natToString(_261_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <usize as ::dafny_runtime::NumCast>::from(")), _262_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _265_recIdentsIdx);
            _261_i = (_261_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _256_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()"));
          _261_i = BigInteger.Zero;
          while ((_261_i) < (new BigInteger((_254_indices).Count))) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[__idx")), DCOMP.__default.natToString(_261_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            _261_i = (_261_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n}"));
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source16 = stmt;
      if (_source16.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _266___mcc_h0 = _source16.dtor_name;
        DAST._IType _267___mcc_h1 = _source16.dtor_typ;
        DAST._IOptional<DAST._IExpression> _268___mcc_h2 = _source16.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source17 = _268___mcc_h2;
        if (_source17.is_Some) {
          DAST._IExpression _269___mcc_h3 = _source17.dtor_Some_a0;
          DAST._IExpression _270_expression = _269___mcc_h3;
          DAST._IType _271_typ = _267___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _272_name = _266___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _273_expr;
            bool _274___v17;
            bool _275_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _276_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_270_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _273_expr = _out76;
            _274___v17 = _out77;
            _275_recErased = _out78;
            _276_recIdents = _out79;
            if (_275_recErased) {
              _273_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _273_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _277_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_271_typ, true, false);
            _277_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _272_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _277_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _273_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _276_recIdents;
          }
        } else {
          DAST._IType _278_typ = _267___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _279_name = _266___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _280_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_278_typ, true, false);
            _280_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _279_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _280_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source16.is_Assign) {
        DAST._IAssignLhs _281___mcc_h4 = _source16.dtor_lhs;
        DAST._IExpression _282___mcc_h5 = _source16.dtor_value;
        DAST._IExpression _283_expression = _282___mcc_h5;
        DAST._IAssignLhs _284_lhs = _281___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _285_lhsGen;
          bool _286_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _287_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_284_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _285_lhsGen = _out82;
          _286_needsIIFE = _out83;
          _287_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _288_exprGen;
          bool _289___v18;
          bool _290_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _291_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_283_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _288_exprGen = _out85;
          _289___v18 = _out86;
          _290_exprErased = _out87;
          _291_exprIdents = _out88;
          if (_290_exprErased) {
            _288_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _288_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_286_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _288_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _285_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_285_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _288_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_287_recIdents, _291_exprIdents);
        }
      } else if (_source16.is_If) {
        DAST._IExpression _292___mcc_h6 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _293___mcc_h7 = _source16.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _294___mcc_h8 = _source16.dtor_els;
        Dafny.ISequence<DAST._IStatement> _295_els = _294___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _296_thn = _293___mcc_h7;
        DAST._IExpression _297_cond = _292___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _298_condString;
          bool _299___v19;
          bool _300_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _301_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_297_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _298_condString = _out89;
          _299___v19 = _out90;
          _300_condErased = _out91;
          _301_recIdents = _out92;
          if (!(_300_condErased)) {
            _298_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _298_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _301_recIdents;
          Dafny.ISequence<Dafny.Rune> _302_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _303_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_296_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _302_thnString = _out93;
          _303_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _303_thnIdents);
          Dafny.ISequence<Dafny.Rune> _304_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _305_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_295_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _304_elsString = _out95;
          _305_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _305_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _298_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _302_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _304_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Labeled) {
        Dafny.ISequence<Dafny.Rune> _306___mcc_h9 = _source16.dtor_lbl;
        Dafny.ISequence<DAST._IStatement> _307___mcc_h10 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _308_body = _307___mcc_h10;
        Dafny.ISequence<Dafny.Rune> _309_lbl = _306___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _310_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _311_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out98;
          DCOMP.COMP.GenStmts(_308_body, selfIdent, @params, isLast, earlyReturn, out _out97, out _out98);
          _310_bodyString = _out97;
          _311_bodyIdents = _out98;
          readIdents = _311_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _309_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": loop {\n")), _310_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_While) {
        DAST._IExpression _312___mcc_h11 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _313___mcc_h12 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _314_body = _313___mcc_h12;
        DAST._IExpression _315_cond = _312___mcc_h11;
        {
          Dafny.ISequence<Dafny.Rune> _316_condString;
          bool _317___v20;
          bool _318_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _319_recIdents;
          Dafny.ISequence<Dafny.Rune> _out99;
          bool _out100;
          bool _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenExpr(_315_cond, selfIdent, @params, true, out _out99, out _out100, out _out101, out _out102);
          _316_condString = _out99;
          _317___v20 = _out100;
          _318_condErased = _out101;
          _319_recIdents = _out102;
          if (!(_318_condErased)) {
            _316_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _316_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _319_recIdents;
          Dafny.ISequence<Dafny.Rune> _320_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _321_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out103;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out104;
          DCOMP.COMP.GenStmts(_314_body, selfIdent, @params, false, earlyReturn, out _out103, out _out104);
          _320_bodyString = _out103;
          _321_bodyIdents = _out104;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _321_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _316_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _320_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Foreach) {
        Dafny.ISequence<Dafny.Rune> _322___mcc_h13 = _source16.dtor_boundName;
        DAST._IType _323___mcc_h14 = _source16.dtor_boundType;
        DAST._IExpression _324___mcc_h15 = _source16.dtor_over;
        Dafny.ISequence<DAST._IStatement> _325___mcc_h16 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _326_body = _325___mcc_h16;
        DAST._IExpression _327_over = _324___mcc_h15;
        DAST._IType _328_boundType = _323___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _329_boundName = _322___mcc_h13;
        {
          Dafny.ISequence<Dafny.Rune> _330_overString;
          bool _331___v21;
          bool _332_overErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _333_recIdents;
          Dafny.ISequence<Dafny.Rune> _out105;
          bool _out106;
          bool _out107;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out108;
          DCOMP.COMP.GenExpr(_327_over, selfIdent, @params, true, out _out105, out _out106, out _out107, out _out108);
          _330_overString = _out105;
          _331___v21 = _out106;
          _332_overErased = _out107;
          _333_recIdents = _out108;
          if (!(_332_overErased)) {
            _330_overString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _330_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _334_boundTypeStr;
          Dafny.ISequence<Dafny.Rune> _out109;
          _out109 = DCOMP.COMP.GenType(_328_boundType, false, false);
          _334_boundTypeStr = _out109;
          readIdents = _333_recIdents;
          Dafny.ISequence<Dafny.Rune> _335_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _336_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenStmts(_326_body, selfIdent, @params, false, earlyReturn, out _out110, out _out111);
          _335_bodyString = _out110;
          _336_bodyIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _336_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("for _iter_erased in "), _330_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _329_boundName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <")), _334_boundTypeStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::unerase_owned(_iter_erased);\n")), _335_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Call) {
        DAST._IExpression _337___mcc_h17 = _source16.dtor_on;
        Dafny.ISequence<Dafny.Rune> _338___mcc_h18 = _source16.dtor_name;
        Dafny.ISequence<DAST._IType> _339___mcc_h19 = _source16.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _340___mcc_h20 = _source16.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _341___mcc_h21 = _source16.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _342_maybeOutVars = _341___mcc_h21;
        Dafny.ISequence<DAST._IExpression> _343_args = _340___mcc_h20;
        Dafny.ISequence<DAST._IType> _344_typeArgs = _339___mcc_h19;
        Dafny.ISequence<Dafny.Rune> _345_name = _338___mcc_h18;
        DAST._IExpression _346_on = _337___mcc_h17;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _347_typeArgString;
          _347_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_344_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _348_typeI;
            _348_typeI = BigInteger.Zero;
            _347_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_348_typeI) < (new BigInteger((_344_typeArgs).Count))) {
              if ((_348_typeI).Sign == 1) {
                _347_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_347_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _349_typeString;
              Dafny.ISequence<Dafny.Rune> _out112;
              _out112 = DCOMP.COMP.GenType((_344_typeArgs).Select(_348_typeI), false, false);
              _349_typeString = _out112;
              _347_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_347_typeArgString, _349_typeString);
              _348_typeI = (_348_typeI) + (BigInteger.One);
            }
            _347_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_347_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _350_argString;
          _350_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _351_i;
          _351_i = BigInteger.Zero;
          while ((_351_i) < (new BigInteger((_343_args).Count))) {
            if ((_351_i).Sign == 1) {
              _350_argString = Dafny.Sequence<Dafny.Rune>.Concat(_350_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _352_argExpr;
            bool _353_isOwned;
            bool _354_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _355_argIdents;
            Dafny.ISequence<Dafny.Rune> _out113;
            bool _out114;
            bool _out115;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out116;
            DCOMP.COMP.GenExpr((_343_args).Select(_351_i), selfIdent, @params, false, out _out113, out _out114, out _out115, out _out116);
            _352_argExpr = _out113;
            _353_isOwned = _out114;
            _354_argErased = _out115;
            _355_argIdents = _out116;
            if (_353_isOwned) {
              _352_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _352_argExpr);
            }
            _350_argString = Dafny.Sequence<Dafny.Rune>.Concat(_350_argString, _352_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _355_argIdents);
            _351_i = (_351_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _356_enclosingString;
          bool _357___v22;
          bool _358___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _359_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out117;
          bool _out118;
          bool _out119;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out120;
          DCOMP.COMP.GenExpr(_346_on, selfIdent, @params, false, out _out117, out _out118, out _out119, out _out120);
          _356_enclosingString = _out117;
          _357___v22 = _out118;
          _358___v23 = _out119;
          _359_enclosingIdents = _out120;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _359_enclosingIdents);
          DAST._IExpression _source18 = _346_on;
          if (_source18.is_Literal) {
            DAST._ILiteral _360___mcc_h26 = _source18.dtor_Literal_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _361___mcc_h28 = _source18.dtor_Ident_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _362___mcc_h30 = _source18.dtor_Companion_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_356_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source18.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _363___mcc_h32 = _source18.dtor_Tuple_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _364___mcc_h34 = _source18.dtor_path;
            Dafny.ISequence<DAST._IExpression> _365___mcc_h35 = _source18.dtor_args;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _366___mcc_h38 = _source18.dtor_dims;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _367___mcc_h40 = _source18.dtor_path;
            Dafny.ISequence<Dafny.Rune> _368___mcc_h41 = _source18.dtor_variant;
            bool _369___mcc_h42 = _source18.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _370___mcc_h43 = _source18.dtor_contents;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Convert) {
            DAST._IExpression _371___mcc_h48 = _source18.dtor_value;
            DAST._IType _372___mcc_h49 = _source18.dtor_from;
            DAST._IType _373___mcc_h50 = _source18.dtor_typ;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _374___mcc_h54 = _source18.dtor_elements;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _375___mcc_h56 = _source18.dtor_elements;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _376___mcc_h58 = _source18.dtor_mapElems;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_This) {
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ite) {
            DAST._IExpression _377___mcc_h60 = _source18.dtor_cond;
            DAST._IExpression _378___mcc_h61 = _source18.dtor_thn;
            DAST._IExpression _379___mcc_h62 = _source18.dtor_els;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_UnOp) {
            DAST._IUnaryOp _380___mcc_h66 = _source18.dtor_unOp;
            DAST._IExpression _381___mcc_h67 = _source18.dtor_expr;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _382___mcc_h70 = _source18.dtor_op;
            DAST._IExpression _383___mcc_h71 = _source18.dtor_left;
            DAST._IExpression _384___mcc_h72 = _source18.dtor_right;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_ArrayLen) {
            DAST._IExpression _385___mcc_h76 = _source18.dtor_expr;
            BigInteger _386___mcc_h77 = _source18.dtor_dim;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Select) {
            DAST._IExpression _387___mcc_h80 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _388___mcc_h81 = _source18.dtor_field;
            bool _389___mcc_h82 = _source18.dtor_isConstant;
            bool _390___mcc_h83 = _source18.dtor_onDatatype;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SelectFn) {
            DAST._IExpression _391___mcc_h88 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _392___mcc_h89 = _source18.dtor_field;
            bool _393___mcc_h90 = _source18.dtor_onDatatype;
            bool _394___mcc_h91 = _source18.dtor_isStatic;
            BigInteger _395___mcc_h92 = _source18.dtor_arity;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Index) {
            DAST._IExpression _396___mcc_h98 = _source18.dtor_expr;
            DAST._ICollKind _397___mcc_h99 = _source18.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _398___mcc_h100 = _source18.dtor_indices;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IndexRange) {
            DAST._IExpression _399___mcc_h104 = _source18.dtor_expr;
            bool _400___mcc_h105 = _source18.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _401___mcc_h106 = _source18.dtor_low;
            DAST._IOptional<DAST._IExpression> _402___mcc_h107 = _source18.dtor_high;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TupleSelect) {
            DAST._IExpression _403___mcc_h112 = _source18.dtor_expr;
            BigInteger _404___mcc_h113 = _source18.dtor_index;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Call) {
            DAST._IExpression _405___mcc_h116 = _source18.dtor_on;
            Dafny.ISequence<Dafny.Rune> _406___mcc_h117 = _source18.dtor_name;
            Dafny.ISequence<DAST._IType> _407___mcc_h118 = _source18.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _408___mcc_h119 = _source18.dtor_args;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _409___mcc_h124 = _source18.dtor_params;
            DAST._IType _410___mcc_h125 = _source18.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _411___mcc_h126 = _source18.dtor_body;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _412___mcc_h130 = _source18.dtor_values;
            DAST._IType _413___mcc_h131 = _source18.dtor_retType;
            DAST._IExpression _414___mcc_h132 = _source18.dtor_expr;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _415___mcc_h136 = _source18.dtor_name;
            DAST._IType _416___mcc_h137 = _source18.dtor_typ;
            DAST._IExpression _417___mcc_h138 = _source18.dtor_value;
            DAST._IExpression _418___mcc_h139 = _source18.dtor_iifeBody;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Apply) {
            DAST._IExpression _419___mcc_h144 = _source18.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _420___mcc_h145 = _source18.dtor_args;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TypeTest) {
            DAST._IExpression _421___mcc_h148 = _source18.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _422___mcc_h149 = _source18.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _423___mcc_h150 = _source18.dtor_variant;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_InitializationValue) {
            DAST._IType _424___mcc_h154 = _source18.dtor_typ;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BoolBoundedPool) {
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IExpression _425___mcc_h156 = _source18.dtor_lo;
            DAST._IExpression _426___mcc_h157 = _source18.dtor_hi;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _427_receiver;
          _427_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source19 = _342_maybeOutVars;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _428___mcc_h160 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _429_outVars = _428___mcc_h160;
            {
              if ((new BigInteger((_429_outVars).Count)) > (BigInteger.One)) {
                _427_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _430_outI;
              _430_outI = BigInteger.Zero;
              while ((_430_outI) < (new BigInteger((_429_outVars).Count))) {
                if ((_430_outI).Sign == 1) {
                  _427_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_427_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _431_outVar;
                _431_outVar = (_429_outVars).Select(_430_outI);
                _427_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_427_receiver, (_431_outVar));
                _430_outI = (_430_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_429_outVars).Count)) > (BigInteger.One)) {
                _427_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_427_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_427_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_427_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _345_name), _347_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _350_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source16.is_Return) {
        DAST._IExpression _432___mcc_h22 = _source16.dtor_expr;
        DAST._IExpression _433_expr = _432___mcc_h22;
        {
          Dafny.ISequence<Dafny.Rune> _434_exprString;
          bool _435___v26;
          bool _436_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _437_recIdents;
          Dafny.ISequence<Dafny.Rune> _out121;
          bool _out122;
          bool _out123;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out124;
          DCOMP.COMP.GenExpr(_433_expr, selfIdent, @params, true, out _out121, out _out122, out _out123, out _out124);
          _434_exprString = _out121;
          _435___v26 = _out122;
          _436_recErased = _out123;
          _437_recIdents = _out124;
          _434_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _434_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _437_recIdents;
          if (isLast) {
            generated = _434_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _434_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source16.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_Break) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _438___mcc_h23 = _source16.dtor_toLabel;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _439_toLabel = _438___mcc_h23;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source20 = _439_toLabel;
          if (_source20.is_Some) {
            Dafny.ISequence<Dafny.Rune> _440___mcc_h161 = _source20.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _441_lbl = _440___mcc_h161;
            {
              generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _441_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            }
          } else {
            {
              generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;");
            }
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _442___mcc_h24 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _443_body = _442___mcc_h24;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _444_paramI;
          _444_paramI = BigInteger.Zero;
          while ((_444_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _445_param;
            _445_param = (@params).Select(_444_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _445_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _445_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _444_paramI = (_444_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _446_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _447_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out125;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
          DCOMP.COMP.GenStmts(_443_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out125, out _out126);
          _446_bodyString = _out125;
          _447_bodyIdents = _out126;
          readIdents = _447_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _446_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_JumpTailCallStart) {
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("continue 'TAIL_CALL_START;");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_Halt) {
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("panic!(\"Halt\");");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else {
        DAST._IExpression _448___mcc_h25 = _source16.dtor_Print_a0;
        DAST._IExpression _449_e = _448___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _450_printedExpr;
          bool _451_isOwned;
          bool _452___v27;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _453_recIdents;
          Dafny.ISequence<Dafny.Rune> _out127;
          bool _out128;
          bool _out129;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
          DCOMP.COMP.GenExpr(_449_e, selfIdent, @params, false, out _out127, out _out128, out _out129, out _out130);
          _450_printedExpr = _out127;
          _451_isOwned = _out128;
          _452___v27 = _out129;
          _453_recIdents = _out130;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_451_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _450_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _453_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source21 = e;
      if (_source21.is_Literal) {
        DAST._ILiteral _454___mcc_h0 = _source21.dtor_Literal_a0;
        DAST._ILiteral _source22 = _454___mcc_h0;
        if (_source22.is_BoolLiteral) {
          bool _455___mcc_h1 = _source22.dtor_BoolLiteral_a0;
          if ((_455___mcc_h1) == (false)) {
            {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("false");
              isOwned = true;
              isErased = true;
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
            }
          } else {
            {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("true");
              isOwned = true;
              isErased = true;
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
            }
          }
        } else if (_source22.is_IntLiteral) {
          Dafny.ISequence<Dafny.Rune> _456___mcc_h2 = _source22.dtor_IntLiteral_a0;
          DAST._IType _457___mcc_h3 = _source22.dtor_IntLiteral_a1;
          DAST._IType _458_t = _457___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _459_i = _456___mcc_h2;
          {
            DAST._IType _source23 = _458_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _460___mcc_h209 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _461___mcc_h210 = _source23.dtor_typeArgs;
              DAST._IResolvedType _462___mcc_h211 = _source23.dtor_resolved;
              {
                s = _459_i;
              }
            } else if (_source23.is_Nullable) {
              DAST._IType _463___mcc_h215 = _source23.dtor_Nullable_a0;
              {
                s = _459_i;
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _464___mcc_h217 = _source23.dtor_Tuple_a0;
              {
                s = _459_i;
              }
            } else if (_source23.is_Array) {
              DAST._IType _465___mcc_h219 = _source23.dtor_element;
              BigInteger _466___mcc_h220 = _source23.dtor_dims;
              {
                s = _459_i;
              }
            } else if (_source23.is_Seq) {
              DAST._IType _467___mcc_h223 = _source23.dtor_element;
              {
                s = _459_i;
              }
            } else if (_source23.is_Set) {
              DAST._IType _468___mcc_h225 = _source23.dtor_element;
              {
                s = _459_i;
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _469___mcc_h227 = _source23.dtor_element;
              {
                s = _459_i;
              }
            } else if (_source23.is_Map) {
              DAST._IType _470___mcc_h229 = _source23.dtor_key;
              DAST._IType _471___mcc_h230 = _source23.dtor_value;
              {
                s = _459_i;
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _472___mcc_h233 = _source23.dtor_args;
              DAST._IType _473___mcc_h234 = _source23.dtor_result;
              {
                s = _459_i;
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _474___mcc_h237 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _474___mcc_h237;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _459_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source24.is_Real) {
                {
                  s = _459_i;
                }
              } else if (_source24.is_String) {
                {
                  s = _459_i;
                }
              } else if (_source24.is_Bool) {
                {
                  s = _459_i;
                }
              } else {
                {
                  s = _459_i;
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _475___mcc_h239 = _source23.dtor_Passthrough_a0;
              {
                s = _459_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _476___mcc_h241 = _source23.dtor_TypeArg_a0;
              {
                s = _459_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _477___mcc_h4 = _source22.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _478___mcc_h5 = _source22.dtor_DecLiteral_a1;
          DAST._IType _479___mcc_h6 = _source22.dtor_DecLiteral_a2;
          DAST._IType _480_t = _479___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _481_d = _478___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _482_n = _477___mcc_h4;
          {
            DAST._IType _source25 = _480_t;
            if (_source25.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _483___mcc_h243 = _source25.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _484___mcc_h244 = _source25.dtor_typeArgs;
              DAST._IResolvedType _485___mcc_h245 = _source25.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Nullable) {
              DAST._IType _486___mcc_h249 = _source25.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Tuple) {
              Dafny.ISequence<DAST._IType> _487___mcc_h251 = _source25.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Array) {
              DAST._IType _488___mcc_h253 = _source25.dtor_element;
              BigInteger _489___mcc_h254 = _source25.dtor_dims;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Seq) {
              DAST._IType _490___mcc_h257 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Set) {
              DAST._IType _491___mcc_h259 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Multiset) {
              DAST._IType _492___mcc_h261 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Map) {
              DAST._IType _493___mcc_h263 = _source25.dtor_key;
              DAST._IType _494___mcc_h264 = _source25.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Arrow) {
              Dafny.ISequence<DAST._IType> _495___mcc_h267 = _source25.dtor_args;
              DAST._IType _496___mcc_h268 = _source25.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Primitive) {
              DAST._IPrimitive _497___mcc_h271 = _source25.dtor_Primitive_a0;
              DAST._IPrimitive _source26 = _497___mcc_h271;
              if (_source26.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source26.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _482_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source26.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source26.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source25.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _498___mcc_h273 = _source25.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _499___mcc_h275 = _source25.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_482_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _481_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _500___mcc_h7 = _source22.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _501_l = _500___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _501_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_CharLiteral) {
          Dafny.Rune _502___mcc_h8 = _source22.dtor_CharLiteral_a0;
          Dafny.Rune _503_c = _502___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_503_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else {
          {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("None");
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source21.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _504___mcc_h9 = _source21.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _505_name = _504___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _505_name);
          if (!((@params).Contains(_505_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_505_name);
        }
      } else if (_source21.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _506___mcc_h10 = _source21.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _507_path = _506___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_507_path);
          s = _out131;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source21.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _508___mcc_h11 = _source21.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _509_values = _508___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _510_i;
          _510_i = BigInteger.Zero;
          bool _511_allErased;
          _511_allErased = true;
          while ((_510_i) < (new BigInteger((_509_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _512___v30;
            bool _513___v31;
            bool _514_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _515___v32;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_509_values).Select(_510_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _512___v30 = _out132;
            _513___v31 = _out133;
            _514_isErased = _out134;
            _515___v32 = _out135;
            _511_allErased = (_511_allErased) && (_514_isErased);
            _510_i = (_510_i) + (BigInteger.One);
          }
          _510_i = BigInteger.Zero;
          while ((_510_i) < (new BigInteger((_509_values).Count))) {
            if ((_510_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _516_recursiveGen;
            bool _517___v33;
            bool _518_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _519_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_509_values).Select(_510_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _516_recursiveGen = _out136;
            _517___v33 = _out137;
            _518_isErased = _out138;
            _519_recIdents = _out139;
            if ((_518_isErased) && (!(_511_allErased))) {
              _516_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _516_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _516_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _519_recIdents);
            _510_i = (_510_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _511_allErased;
        }
      } else if (_source21.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _520___mcc_h12 = _source21.dtor_path;
        Dafny.ISequence<DAST._IExpression> _521___mcc_h13 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _522_args = _521___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _523_path = _520___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _524_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_523_path);
          _524_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _524_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _525_i;
          _525_i = BigInteger.Zero;
          while ((_525_i) < (new BigInteger((_522_args).Count))) {
            if ((_525_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _526_recursiveGen;
            bool _527___v34;
            bool _528_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _529_recIdents;
            Dafny.ISequence<Dafny.Rune> _out141;
            bool _out142;
            bool _out143;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
            DCOMP.COMP.GenExpr((_522_args).Select(_525_i), selfIdent, @params, true, out _out141, out _out142, out _out143, out _out144);
            _526_recursiveGen = _out141;
            _527___v34 = _out142;
            _528_isErased = _out143;
            _529_recIdents = _out144;
            if (_528_isErased) {
              _526_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _526_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _526_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _529_recIdents);
            _525_i = (_525_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _530___mcc_h14 = _source21.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _531_dims = _530___mcc_h14;
        {
          BigInteger _532_i;
          _532_i = (new BigInteger((_531_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_532_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _533_recursiveGen;
            bool _534___v35;
            bool _535_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _536_recIdents;
            Dafny.ISequence<Dafny.Rune> _out145;
            bool _out146;
            bool _out147;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
            DCOMP.COMP.GenExpr((_531_dims).Select(_532_i), selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
            _533_recursiveGen = _out145;
            _534___v35 = _out146;
            _535_isErased = _out147;
            _536_recIdents = _out148;
            if (!(_535_isErased)) {
              _533_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _533_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _533_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _536_recIdents);
            _532_i = (_532_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _537___mcc_h15 = _source21.dtor_path;
        Dafny.ISequence<Dafny.Rune> _538___mcc_h16 = _source21.dtor_variant;
        bool _539___mcc_h17 = _source21.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _540___mcc_h18 = _source21.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _541_values = _540___mcc_h18;
        bool _542_isCo = _539___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _543_variant = _538___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _544_path = _537___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _545_path;
          Dafny.ISequence<Dafny.Rune> _out149;
          _out149 = DCOMP.COMP.GenPath(_544_path);
          _545_path = _out149;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _545_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _543_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _546_i;
          _546_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_546_i) < (new BigInteger((_541_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_541_values).Select(_546_i);
            Dafny.ISequence<Dafny.Rune> _547_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _548_value = _let_tmp_rhs0.dtor__1;
            if ((_546_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_542_isCo) {
              Dafny.ISequence<Dafny.Rune> _549_recursiveGen;
              bool _550___v36;
              bool _551_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _552_recIdents;
              Dafny.ISequence<Dafny.Rune> _out150;
              bool _out151;
              bool _out152;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out153;
              DCOMP.COMP.GenExpr(_548_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out150, out _out151, out _out152, out _out153);
              _549_recursiveGen = _out150;
              _550___v36 = _out151;
              _551_isErased = _out152;
              _552_recIdents = _out153;
              if (!(_551_isErased)) {
                _549_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _549_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _552_recIdents);
              Dafny.ISequence<Dafny.Rune> _553_allReadCloned;
              _553_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_552_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _554_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_552_recIdents).Elements) {
                  _554_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_552_recIdents).Contains(_554_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1185)");
              after__ASSIGN_SUCH_THAT_0:;
                _553_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_553_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _554_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _554_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _552_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_552_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_554_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _547_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _553_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _555_recursiveGen;
              bool _556___v37;
              bool _557_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _558_recIdents;
              Dafny.ISequence<Dafny.Rune> _out154;
              bool _out155;
              bool _out156;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out157;
              DCOMP.COMP.GenExpr(_548_value, selfIdent, @params, true, out _out154, out _out155, out _out156, out _out157);
              _555_recursiveGen = _out154;
              _556___v37 = _out155;
              _557_isErased = _out156;
              _558_recIdents = _out157;
              if (!(_557_isErased)) {
                _555_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _555_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _547_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _555_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _558_recIdents);
            }
            _546_i = (_546_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_Convert) {
        DAST._IExpression _559___mcc_h19 = _source21.dtor_value;
        DAST._IType _560___mcc_h20 = _source21.dtor_from;
        DAST._IType _561___mcc_h21 = _source21.dtor_typ;
        DAST._IType _562_toTpe = _561___mcc_h21;
        DAST._IType _563_fromTpe = _560___mcc_h20;
        DAST._IExpression _564_expr = _559___mcc_h19;
        {
          if (object.Equals(_563_fromTpe, _562_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _565_recursiveGen;
            bool _566_recOwned;
            bool _567_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _568_recIdents;
            Dafny.ISequence<Dafny.Rune> _out158;
            bool _out159;
            bool _out160;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out161;
            DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out158, out _out159, out _out160, out _out161);
            _565_recursiveGen = _out158;
            _566_recOwned = _out159;
            _567_recErased = _out160;
            _568_recIdents = _out161;
            s = _565_recursiveGen;
            isOwned = _566_recOwned;
            isErased = _567_recErased;
            readIdents = _568_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source27 = _System.Tuple2<DAST._IType, DAST._IType>.create(_563_fromTpe, _562_toTpe);
            DAST._IType _569___mcc_h277 = _source27.dtor__0;
            DAST._IType _570___mcc_h278 = _source27.dtor__1;
            DAST._IType _source28 = _569___mcc_h277;
            if (_source28.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _571___mcc_h281 = _source28.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _572___mcc_h282 = _source28.dtor_typeArgs;
              DAST._IResolvedType _573___mcc_h283 = _source28.dtor_resolved;
              DAST._IResolvedType _source29 = _573___mcc_h283;
              if (_source29.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _574___mcc_h293 = _source29.dtor_path;
                DAST._IType _source30 = _570___mcc_h278;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _575___mcc_h297 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _576___mcc_h298 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _577___mcc_h299 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _577___mcc_h299;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _578___mcc_h303 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _579_recursiveGen;
                      bool _580_recOwned;
                      bool _581_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _582_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out162;
                      bool _out163;
                      bool _out164;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out165;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out162, out _out163, out _out164, out _out165);
                      _579_recursiveGen = _out162;
                      _580_recOwned = _out163;
                      _581_recErased = _out164;
                      _582_recIdents = _out165;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _579_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _580_recOwned;
                      isErased = _581_recErased;
                      readIdents = _582_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _583___mcc_h305 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _584_recursiveGen;
                      bool _585_recOwned;
                      bool _586_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _587_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out166;
                      bool _out167;
                      bool _out168;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                      _584_recursiveGen = _out166;
                      _585_recOwned = _out167;
                      _586_recErased = _out168;
                      _587_recIdents = _out169;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _584_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _585_recOwned;
                      isErased = _586_recErased;
                      readIdents = _587_recIdents;
                    }
                  } else {
                    DAST._IType _588___mcc_h307 = _source31.dtor_Newtype_a0;
                    DAST._IType _589_b = _588___mcc_h307;
                    {
                      if (object.Equals(_563_fromTpe, _589_b)) {
                        Dafny.ISequence<Dafny.Rune> _590_recursiveGen;
                        bool _591_recOwned;
                        bool _592_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _593_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out170;
                        bool _out171;
                        bool _out172;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                        _590_recursiveGen = _out170;
                        _591_recOwned = _out171;
                        _592_recErased = _out172;
                        _593_recIdents = _out173;
                        Dafny.ISequence<Dafny.Rune> _594_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out174;
                        _out174 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _594_rhsType = _out174;
                        Dafny.ISequence<Dafny.Rune> _595_uneraseFn;
                        _595_uneraseFn = ((_591_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _594_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _595_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _590_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _591_recOwned;
                        isErased = false;
                        readIdents = _593_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out175;
                        bool _out176;
                        bool _out177;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out178;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _589_b), _589_b, _562_toTpe), selfIdent, @params, mustOwn, out _out175, out _out176, out _out177, out _out178);
                        s = _out175;
                        isOwned = _out176;
                        isErased = _out177;
                        readIdents = _out178;
                      }
                    }
                  }
                } else if (_source30.is_Nullable) {
                  DAST._IType _596___mcc_h309 = _source30.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _597_recursiveGen;
                    bool _598_recOwned;
                    bool _599_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _600_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out179;
                    bool _out180;
                    bool _out181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out182;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out179, out _out180, out _out181, out _out182);
                    _597_recursiveGen = _out179;
                    _598_recOwned = _out180;
                    _599_recErased = _out181;
                    _600_recIdents = _out182;
                    if (!(_598_recOwned)) {
                      _597_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_597_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _597_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _599_recErased;
                    readIdents = _600_recIdents;
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _601___mcc_h311 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _602_recursiveGen;
                    bool _603_recOwned;
                    bool _604_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _605_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out183;
                    bool _out184;
                    bool _out185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out186;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out183, out _out184, out _out185, out _out186);
                    _602_recursiveGen = _out183;
                    _603_recOwned = _out184;
                    _604_recErased = _out185;
                    _605_recIdents = _out186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _602_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _603_recOwned;
                    isErased = _604_recErased;
                    readIdents = _605_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _606___mcc_h313 = _source30.dtor_element;
                  BigInteger _607___mcc_h314 = _source30.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _608_recursiveGen;
                    bool _609_recOwned;
                    bool _610_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _611_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out187;
                    bool _out188;
                    bool _out189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out190;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out187, out _out188, out _out189, out _out190);
                    _608_recursiveGen = _out187;
                    _609_recOwned = _out188;
                    _610_recErased = _out189;
                    _611_recIdents = _out190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _608_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _609_recOwned;
                    isErased = _610_recErased;
                    readIdents = _611_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _612___mcc_h317 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                    bool _614_recOwned;
                    bool _615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out191;
                    bool _out192;
                    bool _out193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out194;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out191, out _out192, out _out193, out _out194);
                    _613_recursiveGen = _out191;
                    _614_recOwned = _out192;
                    _615_recErased = _out193;
                    _616_recIdents = _out194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _614_recOwned;
                    isErased = _615_recErased;
                    readIdents = _616_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _617___mcc_h319 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _618_recursiveGen;
                    bool _619_recOwned;
                    bool _620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out195;
                    bool _out196;
                    bool _out197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out198;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out195, out _out196, out _out197, out _out198);
                    _618_recursiveGen = _out195;
                    _619_recOwned = _out196;
                    _620_recErased = _out197;
                    _621_recIdents = _out198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _619_recOwned;
                    isErased = _620_recErased;
                    readIdents = _621_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _622___mcc_h321 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _623_recursiveGen;
                    bool _624_recOwned;
                    bool _625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out199;
                    bool _out200;
                    bool _out201;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out202;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out199, out _out200, out _out201, out _out202);
                    _623_recursiveGen = _out199;
                    _624_recOwned = _out200;
                    _625_recErased = _out201;
                    _626_recIdents = _out202;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _624_recOwned;
                    isErased = _625_recErased;
                    readIdents = _626_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _627___mcc_h323 = _source30.dtor_key;
                  DAST._IType _628___mcc_h324 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _629_recursiveGen;
                    bool _630_recOwned;
                    bool _631_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _632_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out203;
                    bool _out204;
                    bool _out205;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out206;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out203, out _out204, out _out205, out _out206);
                    _629_recursiveGen = _out203;
                    _630_recOwned = _out204;
                    _631_recErased = _out205;
                    _632_recIdents = _out206;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _630_recOwned;
                    isErased = _631_recErased;
                    readIdents = _632_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _633___mcc_h327 = _source30.dtor_args;
                  DAST._IType _634___mcc_h328 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _635_recursiveGen;
                    bool _636_recOwned;
                    bool _637_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _638_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out207;
                    bool _out208;
                    bool _out209;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out210;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out207, out _out208, out _out209, out _out210);
                    _635_recursiveGen = _out207;
                    _636_recOwned = _out208;
                    _637_recErased = _out209;
                    _638_recIdents = _out210;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _636_recOwned;
                    isErased = _637_recErased;
                    readIdents = _638_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _639___mcc_h331 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _640_recursiveGen;
                    bool _641_recOwned;
                    bool _642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out211;
                    bool _out212;
                    bool _out213;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out214;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out211, out _out212, out _out213, out _out214);
                    _640_recursiveGen = _out211;
                    _641_recOwned = _out212;
                    _642_recErased = _out213;
                    _643_recIdents = _out214;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _641_recOwned;
                    isErased = _642_recErased;
                    readIdents = _643_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _644___mcc_h333 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _645_recursiveGen;
                    bool _646_recOwned;
                    bool _647_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _648_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out215;
                    bool _out216;
                    bool _out217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out218;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out215, out _out216, out _out217, out _out218);
                    _645_recursiveGen = _out215;
                    _646_recOwned = _out216;
                    _647_recErased = _out217;
                    _648_recIdents = _out218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _646_recOwned;
                    isErased = _647_recErased;
                    readIdents = _648_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _649___mcc_h335 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _650_recursiveGen;
                    bool _651_recOwned;
                    bool _652_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _653_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out219;
                    bool _out220;
                    bool _out221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out222;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out219, out _out220, out _out221, out _out222);
                    _650_recursiveGen = _out219;
                    _651_recOwned = _out220;
                    _652_recErased = _out221;
                    _653_recIdents = _out222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _651_recOwned;
                    isErased = _652_recErased;
                    readIdents = _653_recIdents;
                  }
                }
              } else if (_source29.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _654___mcc_h337 = _source29.dtor_path;
                DAST._IType _source32 = _570___mcc_h278;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _655___mcc_h341 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _656___mcc_h342 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _657___mcc_h343 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _657___mcc_h343;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _658___mcc_h347 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _659_recursiveGen;
                      bool _660_recOwned;
                      bool _661_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _662_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out223;
                      bool _out224;
                      bool _out225;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out226;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out223, out _out224, out _out225, out _out226);
                      _659_recursiveGen = _out223;
                      _660_recOwned = _out224;
                      _661_recErased = _out225;
                      _662_recIdents = _out226;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _659_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _660_recOwned;
                      isErased = _661_recErased;
                      readIdents = _662_recIdents;
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _663___mcc_h349 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _664_recursiveGen;
                      bool _665_recOwned;
                      bool _666_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _667_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out227;
                      bool _out228;
                      bool _out229;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                      _664_recursiveGen = _out227;
                      _665_recOwned = _out228;
                      _666_recErased = _out229;
                      _667_recIdents = _out230;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _664_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _665_recOwned;
                      isErased = _666_recErased;
                      readIdents = _667_recIdents;
                    }
                  } else {
                    DAST._IType _668___mcc_h351 = _source33.dtor_Newtype_a0;
                    DAST._IType _669_b = _668___mcc_h351;
                    {
                      if (object.Equals(_563_fromTpe, _669_b)) {
                        Dafny.ISequence<Dafny.Rune> _670_recursiveGen;
                        bool _671_recOwned;
                        bool _672_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _673_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out231;
                        bool _out232;
                        bool _out233;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                        _670_recursiveGen = _out231;
                        _671_recOwned = _out232;
                        _672_recErased = _out233;
                        _673_recIdents = _out234;
                        Dafny.ISequence<Dafny.Rune> _674_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out235;
                        _out235 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _674_rhsType = _out235;
                        Dafny.ISequence<Dafny.Rune> _675_uneraseFn;
                        _675_uneraseFn = ((_671_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _674_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _675_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _670_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _671_recOwned;
                        isErased = false;
                        readIdents = _673_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out236;
                        bool _out237;
                        bool _out238;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out239;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _669_b), _669_b, _562_toTpe), selfIdent, @params, mustOwn, out _out236, out _out237, out _out238, out _out239);
                        s = _out236;
                        isOwned = _out237;
                        isErased = _out238;
                        readIdents = _out239;
                      }
                    }
                  }
                } else if (_source32.is_Nullable) {
                  DAST._IType _676___mcc_h353 = _source32.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _677_recursiveGen;
                    bool _678_recOwned;
                    bool _679_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _680_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out240;
                    bool _out241;
                    bool _out242;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out243;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out240, out _out241, out _out242, out _out243);
                    _677_recursiveGen = _out240;
                    _678_recOwned = _out241;
                    _679_recErased = _out242;
                    _680_recIdents = _out243;
                    if (!(_678_recOwned)) {
                      _677_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_677_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _677_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _679_recErased;
                    readIdents = _680_recIdents;
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _681___mcc_h355 = _source32.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                    bool _683_recOwned;
                    bool _684_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out244;
                    bool _out245;
                    bool _out246;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out247;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out244, out _out245, out _out246, out _out247);
                    _682_recursiveGen = _out244;
                    _683_recOwned = _out245;
                    _684_recErased = _out246;
                    _685_recIdents = _out247;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _683_recOwned;
                    isErased = _684_recErased;
                    readIdents = _685_recIdents;
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _686___mcc_h357 = _source32.dtor_element;
                  BigInteger _687___mcc_h358 = _source32.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _688_recursiveGen;
                    bool _689_recOwned;
                    bool _690_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _691_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out248;
                    bool _out249;
                    bool _out250;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out251;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out248, out _out249, out _out250, out _out251);
                    _688_recursiveGen = _out248;
                    _689_recOwned = _out249;
                    _690_recErased = _out250;
                    _691_recIdents = _out251;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _688_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _689_recOwned;
                    isErased = _690_recErased;
                    readIdents = _691_recIdents;
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _692___mcc_h361 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _693_recursiveGen;
                    bool _694_recOwned;
                    bool _695_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _696_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out252;
                    bool _out253;
                    bool _out254;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out255;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out252, out _out253, out _out254, out _out255);
                    _693_recursiveGen = _out252;
                    _694_recOwned = _out253;
                    _695_recErased = _out254;
                    _696_recIdents = _out255;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _693_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _694_recOwned;
                    isErased = _695_recErased;
                    readIdents = _696_recIdents;
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _697___mcc_h363 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _698_recursiveGen;
                    bool _699_recOwned;
                    bool _700_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _701_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out256;
                    bool _out257;
                    bool _out258;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out259;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out256, out _out257, out _out258, out _out259);
                    _698_recursiveGen = _out256;
                    _699_recOwned = _out257;
                    _700_recErased = _out258;
                    _701_recIdents = _out259;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _699_recOwned;
                    isErased = _700_recErased;
                    readIdents = _701_recIdents;
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _702___mcc_h365 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                    bool _704_recOwned;
                    bool _705_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out260;
                    bool _out261;
                    bool _out262;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out263;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out260, out _out261, out _out262, out _out263);
                    _703_recursiveGen = _out260;
                    _704_recOwned = _out261;
                    _705_recErased = _out262;
                    _706_recIdents = _out263;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _704_recOwned;
                    isErased = _705_recErased;
                    readIdents = _706_recIdents;
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _707___mcc_h367 = _source32.dtor_key;
                  DAST._IType _708___mcc_h368 = _source32.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _709_recursiveGen;
                    bool _710_recOwned;
                    bool _711_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _712_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out264;
                    bool _out265;
                    bool _out266;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out267;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out264, out _out265, out _out266, out _out267);
                    _709_recursiveGen = _out264;
                    _710_recOwned = _out265;
                    _711_recErased = _out266;
                    _712_recIdents = _out267;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _710_recOwned;
                    isErased = _711_recErased;
                    readIdents = _712_recIdents;
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _713___mcc_h371 = _source32.dtor_args;
                  DAST._IType _714___mcc_h372 = _source32.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _715_recursiveGen;
                    bool _716_recOwned;
                    bool _717_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _718_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out268;
                    bool _out269;
                    bool _out270;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out271;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out268, out _out269, out _out270, out _out271);
                    _715_recursiveGen = _out268;
                    _716_recOwned = _out269;
                    _717_recErased = _out270;
                    _718_recIdents = _out271;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _715_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _716_recOwned;
                    isErased = _717_recErased;
                    readIdents = _718_recIdents;
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _719___mcc_h375 = _source32.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _720_recursiveGen;
                    bool _721_recOwned;
                    bool _722_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _723_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out272;
                    bool _out273;
                    bool _out274;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out275;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out272, out _out273, out _out274, out _out275);
                    _720_recursiveGen = _out272;
                    _721_recOwned = _out273;
                    _722_recErased = _out274;
                    _723_recIdents = _out275;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _720_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _721_recOwned;
                    isErased = _722_recErased;
                    readIdents = _723_recIdents;
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _724___mcc_h377 = _source32.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _725_recursiveGen;
                    bool _726_recOwned;
                    bool _727_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _728_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out276;
                    bool _out277;
                    bool _out278;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out279;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out276, out _out277, out _out278, out _out279);
                    _725_recursiveGen = _out276;
                    _726_recOwned = _out277;
                    _727_recErased = _out278;
                    _728_recIdents = _out279;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _726_recOwned;
                    isErased = _727_recErased;
                    readIdents = _728_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _729___mcc_h379 = _source32.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _730_recursiveGen;
                    bool _731_recOwned;
                    bool _732_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _733_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out280;
                    bool _out281;
                    bool _out282;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out283;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out280, out _out281, out _out282, out _out283);
                    _730_recursiveGen = _out280;
                    _731_recOwned = _out281;
                    _732_recErased = _out282;
                    _733_recIdents = _out283;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _731_recOwned;
                    isErased = _732_recErased;
                    readIdents = _733_recIdents;
                  }
                }
              } else {
                DAST._IType _734___mcc_h381 = _source29.dtor_Newtype_a0;
                DAST._IType _source34 = _570___mcc_h278;
                if (_source34.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _735___mcc_h385 = _source34.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _736___mcc_h386 = _source34.dtor_typeArgs;
                  DAST._IResolvedType _737___mcc_h387 = _source34.dtor_resolved;
                  DAST._IResolvedType _source35 = _737___mcc_h387;
                  if (_source35.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _738___mcc_h394 = _source35.dtor_path;
                    DAST._IType _739_b = _734___mcc_h381;
                    {
                      if (object.Equals(_739_b, _562_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _740_recursiveGen;
                        bool _741_recOwned;
                        bool _742_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _743_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out284;
                        bool _out285;
                        bool _out286;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out287;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out284, out _out285, out _out286, out _out287);
                        _740_recursiveGen = _out284;
                        _741_recOwned = _out285;
                        _742_recErased = _out286;
                        _743_recIdents = _out287;
                        Dafny.ISequence<Dafny.Rune> _744_uneraseFn;
                        _744_uneraseFn = ((_741_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _744_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _740_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _741_recOwned;
                        isErased = true;
                        readIdents = _743_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out288;
                        bool _out289;
                        bool _out290;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out291;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _739_b), _739_b, _562_toTpe), selfIdent, @params, mustOwn, out _out288, out _out289, out _out290, out _out291);
                        s = _out288;
                        isOwned = _out289;
                        isErased = _out290;
                        readIdents = _out291;
                      }
                    }
                  } else if (_source35.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _745___mcc_h397 = _source35.dtor_path;
                    DAST._IType _746_b = _734___mcc_h381;
                    {
                      if (object.Equals(_746_b, _562_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _747_recursiveGen;
                        bool _748_recOwned;
                        bool _749_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _750_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out292;
                        bool _out293;
                        bool _out294;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out295;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out292, out _out293, out _out294, out _out295);
                        _747_recursiveGen = _out292;
                        _748_recOwned = _out293;
                        _749_recErased = _out294;
                        _750_recIdents = _out295;
                        Dafny.ISequence<Dafny.Rune> _751_uneraseFn;
                        _751_uneraseFn = ((_748_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _751_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _747_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _748_recOwned;
                        isErased = true;
                        readIdents = _750_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _746_b), _746_b, _562_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  } else {
                    DAST._IType _752___mcc_h400 = _source35.dtor_Newtype_a0;
                    DAST._IType _753_b = _752___mcc_h400;
                    {
                      if (object.Equals(_563_fromTpe, _753_b)) {
                        Dafny.ISequence<Dafny.Rune> _754_recursiveGen;
                        bool _755_recOwned;
                        bool _756_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _757_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out300;
                        bool _out301;
                        bool _out302;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                        _754_recursiveGen = _out300;
                        _755_recOwned = _out301;
                        _756_recErased = _out302;
                        _757_recIdents = _out303;
                        Dafny.ISequence<Dafny.Rune> _758_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out304;
                        _out304 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _758_rhsType = _out304;
                        Dafny.ISequence<Dafny.Rune> _759_uneraseFn;
                        _759_uneraseFn = ((_755_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _758_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _759_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _755_recOwned;
                        isErased = false;
                        readIdents = _757_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out305;
                        bool _out306;
                        bool _out307;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out308;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _753_b), _753_b, _562_toTpe), selfIdent, @params, mustOwn, out _out305, out _out306, out _out307, out _out308);
                        s = _out305;
                        isOwned = _out306;
                        isErased = _out307;
                        readIdents = _out308;
                      }
                    }
                  }
                } else if (_source34.is_Nullable) {
                  DAST._IType _760___mcc_h403 = _source34.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _761_recursiveGen;
                    bool _762_recOwned;
                    bool _763_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _764_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out309;
                    bool _out310;
                    bool _out311;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out312;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out309, out _out310, out _out311, out _out312);
                    _761_recursiveGen = _out309;
                    _762_recOwned = _out310;
                    _763_recErased = _out311;
                    _764_recIdents = _out312;
                    if (!(_762_recOwned)) {
                      _761_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_761_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _761_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _763_recErased;
                    readIdents = _764_recIdents;
                  }
                } else if (_source34.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _765___mcc_h406 = _source34.dtor_Tuple_a0;
                  DAST._IType _766_b = _734___mcc_h381;
                  {
                    if (object.Equals(_766_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _767_recursiveGen;
                      bool _768_recOwned;
                      bool _769_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _770_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out313;
                      bool _out314;
                      bool _out315;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out316;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out313, out _out314, out _out315, out _out316);
                      _767_recursiveGen = _out313;
                      _768_recOwned = _out314;
                      _769_recErased = _out315;
                      _770_recIdents = _out316;
                      Dafny.ISequence<Dafny.Rune> _771_uneraseFn;
                      _771_uneraseFn = ((_768_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _771_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _768_recOwned;
                      isErased = true;
                      readIdents = _770_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out317;
                      bool _out318;
                      bool _out319;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out320;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _766_b), _766_b, _562_toTpe), selfIdent, @params, mustOwn, out _out317, out _out318, out _out319, out _out320);
                      s = _out317;
                      isOwned = _out318;
                      isErased = _out319;
                      readIdents = _out320;
                    }
                  }
                } else if (_source34.is_Array) {
                  DAST._IType _772___mcc_h409 = _source34.dtor_element;
                  BigInteger _773___mcc_h410 = _source34.dtor_dims;
                  DAST._IType _774_b = _734___mcc_h381;
                  {
                    if (object.Equals(_774_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _775_recursiveGen;
                      bool _776_recOwned;
                      bool _777_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _778_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out321;
                      bool _out322;
                      bool _out323;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out324;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out321, out _out322, out _out323, out _out324);
                      _775_recursiveGen = _out321;
                      _776_recOwned = _out322;
                      _777_recErased = _out323;
                      _778_recIdents = _out324;
                      Dafny.ISequence<Dafny.Rune> _779_uneraseFn;
                      _779_uneraseFn = ((_776_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _779_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _775_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _776_recOwned;
                      isErased = true;
                      readIdents = _778_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out325;
                      bool _out326;
                      bool _out327;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out328;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _774_b), _774_b, _562_toTpe), selfIdent, @params, mustOwn, out _out325, out _out326, out _out327, out _out328);
                      s = _out325;
                      isOwned = _out326;
                      isErased = _out327;
                      readIdents = _out328;
                    }
                  }
                } else if (_source34.is_Seq) {
                  DAST._IType _780___mcc_h415 = _source34.dtor_element;
                  DAST._IType _781_b = _734___mcc_h381;
                  {
                    if (object.Equals(_781_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _782_recursiveGen;
                      bool _783_recOwned;
                      bool _784_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _785_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out329;
                      bool _out330;
                      bool _out331;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out332;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out329, out _out330, out _out331, out _out332);
                      _782_recursiveGen = _out329;
                      _783_recOwned = _out330;
                      _784_recErased = _out331;
                      _785_recIdents = _out332;
                      Dafny.ISequence<Dafny.Rune> _786_uneraseFn;
                      _786_uneraseFn = ((_783_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _786_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _782_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _783_recOwned;
                      isErased = true;
                      readIdents = _785_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out333;
                      bool _out334;
                      bool _out335;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out336;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _781_b), _781_b, _562_toTpe), selfIdent, @params, mustOwn, out _out333, out _out334, out _out335, out _out336);
                      s = _out333;
                      isOwned = _out334;
                      isErased = _out335;
                      readIdents = _out336;
                    }
                  }
                } else if (_source34.is_Set) {
                  DAST._IType _787___mcc_h418 = _source34.dtor_element;
                  DAST._IType _788_b = _734___mcc_h381;
                  {
                    if (object.Equals(_788_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _789_recursiveGen;
                      bool _790_recOwned;
                      bool _791_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _792_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out337;
                      bool _out338;
                      bool _out339;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out340;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out337, out _out338, out _out339, out _out340);
                      _789_recursiveGen = _out337;
                      _790_recOwned = _out338;
                      _791_recErased = _out339;
                      _792_recIdents = _out340;
                      Dafny.ISequence<Dafny.Rune> _793_uneraseFn;
                      _793_uneraseFn = ((_790_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _793_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _789_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _790_recOwned;
                      isErased = true;
                      readIdents = _792_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out341;
                      bool _out342;
                      bool _out343;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out344;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _788_b), _788_b, _562_toTpe), selfIdent, @params, mustOwn, out _out341, out _out342, out _out343, out _out344);
                      s = _out341;
                      isOwned = _out342;
                      isErased = _out343;
                      readIdents = _out344;
                    }
                  }
                } else if (_source34.is_Multiset) {
                  DAST._IType _794___mcc_h421 = _source34.dtor_element;
                  DAST._IType _795_b = _734___mcc_h381;
                  {
                    if (object.Equals(_795_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _796_recursiveGen;
                      bool _797_recOwned;
                      bool _798_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _799_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out345;
                      bool _out346;
                      bool _out347;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out348;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out345, out _out346, out _out347, out _out348);
                      _796_recursiveGen = _out345;
                      _797_recOwned = _out346;
                      _798_recErased = _out347;
                      _799_recIdents = _out348;
                      Dafny.ISequence<Dafny.Rune> _800_uneraseFn;
                      _800_uneraseFn = ((_797_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _800_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _796_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _797_recOwned;
                      isErased = true;
                      readIdents = _799_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out349;
                      bool _out350;
                      bool _out351;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out352;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _795_b), _795_b, _562_toTpe), selfIdent, @params, mustOwn, out _out349, out _out350, out _out351, out _out352);
                      s = _out349;
                      isOwned = _out350;
                      isErased = _out351;
                      readIdents = _out352;
                    }
                  }
                } else if (_source34.is_Map) {
                  DAST._IType _801___mcc_h424 = _source34.dtor_key;
                  DAST._IType _802___mcc_h425 = _source34.dtor_value;
                  DAST._IType _803_b = _734___mcc_h381;
                  {
                    if (object.Equals(_803_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _804_recursiveGen;
                      bool _805_recOwned;
                      bool _806_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _807_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out353;
                      bool _out354;
                      bool _out355;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out356;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out353, out _out354, out _out355, out _out356);
                      _804_recursiveGen = _out353;
                      _805_recOwned = _out354;
                      _806_recErased = _out355;
                      _807_recIdents = _out356;
                      Dafny.ISequence<Dafny.Rune> _808_uneraseFn;
                      _808_uneraseFn = ((_805_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _808_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _804_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _805_recOwned;
                      isErased = true;
                      readIdents = _807_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out357;
                      bool _out358;
                      bool _out359;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _803_b), _803_b, _562_toTpe), selfIdent, @params, mustOwn, out _out357, out _out358, out _out359, out _out360);
                      s = _out357;
                      isOwned = _out358;
                      isErased = _out359;
                      readIdents = _out360;
                    }
                  }
                } else if (_source34.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _809___mcc_h430 = _source34.dtor_args;
                  DAST._IType _810___mcc_h431 = _source34.dtor_result;
                  DAST._IType _811_b = _734___mcc_h381;
                  {
                    if (object.Equals(_811_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _812_recursiveGen;
                      bool _813_recOwned;
                      bool _814_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _815_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out361;
                      bool _out362;
                      bool _out363;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out361, out _out362, out _out363, out _out364);
                      _812_recursiveGen = _out361;
                      _813_recOwned = _out362;
                      _814_recErased = _out363;
                      _815_recIdents = _out364;
                      Dafny.ISequence<Dafny.Rune> _816_uneraseFn;
                      _816_uneraseFn = ((_813_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _816_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _812_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _813_recOwned;
                      isErased = true;
                      readIdents = _815_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out365;
                      bool _out366;
                      bool _out367;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _811_b), _811_b, _562_toTpe), selfIdent, @params, mustOwn, out _out365, out _out366, out _out367, out _out368);
                      s = _out365;
                      isOwned = _out366;
                      isErased = _out367;
                      readIdents = _out368;
                    }
                  }
                } else if (_source34.is_Primitive) {
                  DAST._IPrimitive _817___mcc_h436 = _source34.dtor_Primitive_a0;
                  DAST._IType _818_b = _734___mcc_h381;
                  {
                    if (object.Equals(_818_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _819_recursiveGen;
                      bool _820_recOwned;
                      bool _821_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _822_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out369;
                      bool _out370;
                      bool _out371;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out369, out _out370, out _out371, out _out372);
                      _819_recursiveGen = _out369;
                      _820_recOwned = _out370;
                      _821_recErased = _out371;
                      _822_recIdents = _out372;
                      Dafny.ISequence<Dafny.Rune> _823_uneraseFn;
                      _823_uneraseFn = ((_820_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _823_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _819_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _820_recOwned;
                      isErased = true;
                      readIdents = _822_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out373;
                      bool _out374;
                      bool _out375;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out376;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _818_b), _818_b, _562_toTpe), selfIdent, @params, mustOwn, out _out373, out _out374, out _out375, out _out376);
                      s = _out373;
                      isOwned = _out374;
                      isErased = _out375;
                      readIdents = _out376;
                    }
                  }
                } else if (_source34.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _824___mcc_h439 = _source34.dtor_Passthrough_a0;
                  DAST._IType _825_b = _734___mcc_h381;
                  {
                    if (object.Equals(_825_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _826_recursiveGen;
                      bool _827_recOwned;
                      bool _828_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _829_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out377;
                      bool _out378;
                      bool _out379;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out380;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out377, out _out378, out _out379, out _out380);
                      _826_recursiveGen = _out377;
                      _827_recOwned = _out378;
                      _828_recErased = _out379;
                      _829_recIdents = _out380;
                      Dafny.ISequence<Dafny.Rune> _830_uneraseFn;
                      _830_uneraseFn = ((_827_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _830_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _826_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _827_recOwned;
                      isErased = true;
                      readIdents = _829_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out381;
                      bool _out382;
                      bool _out383;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out384;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _825_b), _825_b, _562_toTpe), selfIdent, @params, mustOwn, out _out381, out _out382, out _out383, out _out384);
                      s = _out381;
                      isOwned = _out382;
                      isErased = _out383;
                      readIdents = _out384;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _831___mcc_h442 = _source34.dtor_TypeArg_a0;
                  DAST._IType _832_b = _734___mcc_h381;
                  {
                    if (object.Equals(_832_b, _562_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _833_recursiveGen;
                      bool _834_recOwned;
                      bool _835_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _836_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out385;
                      bool _out386;
                      bool _out387;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out388;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out385, out _out386, out _out387, out _out388);
                      _833_recursiveGen = _out385;
                      _834_recOwned = _out386;
                      _835_recErased = _out387;
                      _836_recIdents = _out388;
                      Dafny.ISequence<Dafny.Rune> _837_uneraseFn;
                      _837_uneraseFn = ((_834_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _837_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _833_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _834_recOwned;
                      isErased = true;
                      readIdents = _836_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out389;
                      bool _out390;
                      bool _out391;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out392;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _832_b), _832_b, _562_toTpe), selfIdent, @params, mustOwn, out _out389, out _out390, out _out391, out _out392);
                      s = _out389;
                      isOwned = _out390;
                      isErased = _out391;
                      readIdents = _out392;
                    }
                  }
                }
              }
            } else if (_source28.is_Nullable) {
              DAST._IType _838___mcc_h445 = _source28.dtor_Nullable_a0;
              DAST._IType _source36 = _570___mcc_h278;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _839___mcc_h449 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _840___mcc_h450 = _source36.dtor_typeArgs;
                DAST._IResolvedType _841___mcc_h451 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _841___mcc_h451;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _842___mcc_h458 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _843_recursiveGen;
                    bool _844_recOwned;
                    bool _845_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _846_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out393;
                    bool _out394;
                    bool _out395;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out396;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out393, out _out394, out _out395, out _out396);
                    _843_recursiveGen = _out393;
                    _844_recOwned = _out394;
                    _845_recErased = _out395;
                    _846_recIdents = _out396;
                    if (!(_844_recOwned)) {
                      _843_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_843_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_843_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _844_recOwned;
                    isErased = _845_recErased;
                    readIdents = _846_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _847___mcc_h461 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _848_recursiveGen;
                    bool _849_recOwned;
                    bool _850_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _851_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out397;
                    bool _out398;
                    bool _out399;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out400;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out397, out _out398, out _out399, out _out400);
                    _848_recursiveGen = _out397;
                    _849_recOwned = _out398;
                    _850_recErased = _out399;
                    _851_recIdents = _out400;
                    if (!(_849_recOwned)) {
                      _848_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_848_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_848_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _849_recOwned;
                    isErased = _850_recErased;
                    readIdents = _851_recIdents;
                  }
                } else {
                  DAST._IType _852___mcc_h464 = _source37.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _853_recursiveGen;
                    bool _854_recOwned;
                    bool _855_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _856_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out401;
                    bool _out402;
                    bool _out403;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out404;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out401, out _out402, out _out403, out _out404);
                    _853_recursiveGen = _out401;
                    _854_recOwned = _out402;
                    _855_recErased = _out403;
                    _856_recIdents = _out404;
                    if (!(_854_recOwned)) {
                      _853_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_853_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_853_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _854_recOwned;
                    isErased = _855_recErased;
                    readIdents = _856_recIdents;
                  }
                }
              } else if (_source36.is_Nullable) {
                DAST._IType _857___mcc_h467 = _source36.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _858_recursiveGen;
                  bool _859_recOwned;
                  bool _860_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _861_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out405;
                  bool _out406;
                  bool _out407;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out408;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out405, out _out406, out _out407, out _out408);
                  _858_recursiveGen = _out405;
                  _859_recOwned = _out406;
                  _860_recErased = _out407;
                  _861_recIdents = _out408;
                  if (!(_859_recOwned)) {
                    _858_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _859_recOwned;
                  isErased = _860_recErased;
                  readIdents = _861_recIdents;
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _862___mcc_h470 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _863_recursiveGen;
                  bool _864_recOwned;
                  bool _865_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _866_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out409;
                  bool _out410;
                  bool _out411;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out412;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out409, out _out410, out _out411, out _out412);
                  _863_recursiveGen = _out409;
                  _864_recOwned = _out410;
                  _865_recErased = _out411;
                  _866_recIdents = _out412;
                  if (!(_864_recOwned)) {
                    _863_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_863_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_863_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _864_recOwned;
                  isErased = _865_recErased;
                  readIdents = _866_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _867___mcc_h473 = _source36.dtor_element;
                BigInteger _868___mcc_h474 = _source36.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _869_recursiveGen;
                  bool _870_recOwned;
                  bool _871_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _872_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out413;
                  bool _out414;
                  bool _out415;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out416;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out413, out _out414, out _out415, out _out416);
                  _869_recursiveGen = _out413;
                  _870_recOwned = _out414;
                  _871_recErased = _out415;
                  _872_recIdents = _out416;
                  if (!(_870_recOwned)) {
                    _869_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_869_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_869_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _870_recOwned;
                  isErased = _871_recErased;
                  readIdents = _872_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _873___mcc_h479 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _874_recursiveGen;
                  bool _875_recOwned;
                  bool _876_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _877_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out417;
                  bool _out418;
                  bool _out419;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out420;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out417, out _out418, out _out419, out _out420);
                  _874_recursiveGen = _out417;
                  _875_recOwned = _out418;
                  _876_recErased = _out419;
                  _877_recIdents = _out420;
                  if (!(_875_recOwned)) {
                    _874_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_874_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_874_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _875_recOwned;
                  isErased = _876_recErased;
                  readIdents = _877_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _878___mcc_h482 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _879_recursiveGen;
                  bool _880_recOwned;
                  bool _881_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _882_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out421;
                  bool _out422;
                  bool _out423;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out424;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out421, out _out422, out _out423, out _out424);
                  _879_recursiveGen = _out421;
                  _880_recOwned = _out422;
                  _881_recErased = _out423;
                  _882_recIdents = _out424;
                  if (!(_880_recOwned)) {
                    _879_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_879_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_879_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _880_recOwned;
                  isErased = _881_recErased;
                  readIdents = _882_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _883___mcc_h485 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _884_recursiveGen;
                  bool _885_recOwned;
                  bool _886_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _887_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out425;
                  bool _out426;
                  bool _out427;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out428;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out425, out _out426, out _out427, out _out428);
                  _884_recursiveGen = _out425;
                  _885_recOwned = _out426;
                  _886_recErased = _out427;
                  _887_recIdents = _out428;
                  if (!(_885_recOwned)) {
                    _884_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_884_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_884_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _885_recOwned;
                  isErased = _886_recErased;
                  readIdents = _887_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _888___mcc_h488 = _source36.dtor_key;
                DAST._IType _889___mcc_h489 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _890_recursiveGen;
                  bool _891_recOwned;
                  bool _892_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _893_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out429;
                  bool _out430;
                  bool _out431;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out432;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out429, out _out430, out _out431, out _out432);
                  _890_recursiveGen = _out429;
                  _891_recOwned = _out430;
                  _892_recErased = _out431;
                  _893_recIdents = _out432;
                  if (!(_891_recOwned)) {
                    _890_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_890_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_890_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _891_recOwned;
                  isErased = _892_recErased;
                  readIdents = _893_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _894___mcc_h494 = _source36.dtor_args;
                DAST._IType _895___mcc_h495 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _896_recursiveGen;
                  bool _897_recOwned;
                  bool _898_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _899_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out433;
                  bool _out434;
                  bool _out435;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out436;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out433, out _out434, out _out435, out _out436);
                  _896_recursiveGen = _out433;
                  _897_recOwned = _out434;
                  _898_recErased = _out435;
                  _899_recIdents = _out436;
                  if (!(_897_recOwned)) {
                    _896_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_896_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_896_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _897_recOwned;
                  isErased = _898_recErased;
                  readIdents = _899_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _900___mcc_h500 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _901_recursiveGen;
                  bool _902_recOwned;
                  bool _903_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _904_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out437;
                  bool _out438;
                  bool _out439;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out440;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out437, out _out438, out _out439, out _out440);
                  _901_recursiveGen = _out437;
                  _902_recOwned = _out438;
                  _903_recErased = _out439;
                  _904_recIdents = _out440;
                  if (!(_902_recOwned)) {
                    _901_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_901_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_901_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _902_recOwned;
                  isErased = _903_recErased;
                  readIdents = _904_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _905___mcc_h503 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _906_recursiveGen;
                  bool _907_recOwned;
                  bool _908_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _909_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out441;
                  bool _out442;
                  bool _out443;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out444;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out441, out _out442, out _out443, out _out444);
                  _906_recursiveGen = _out441;
                  _907_recOwned = _out442;
                  _908_recErased = _out443;
                  _909_recIdents = _out444;
                  if (!(_907_recOwned)) {
                    _906_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_906_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_906_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _907_recOwned;
                  isErased = _908_recErased;
                  readIdents = _909_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _910___mcc_h506 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _911_recursiveGen;
                  bool _912_recOwned;
                  bool _913_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _914_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out445;
                  bool _out446;
                  bool _out447;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out448;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out445, out _out446, out _out447, out _out448);
                  _911_recursiveGen = _out445;
                  _912_recOwned = _out446;
                  _913_recErased = _out447;
                  _914_recIdents = _out448;
                  if (!(_912_recOwned)) {
                    _911_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_911_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_911_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _912_recOwned;
                  isErased = _913_recErased;
                  readIdents = _914_recIdents;
                }
              }
            } else if (_source28.is_Tuple) {
              Dafny.ISequence<DAST._IType> _915___mcc_h509 = _source28.dtor_Tuple_a0;
              DAST._IType _source38 = _570___mcc_h278;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _916___mcc_h513 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _917___mcc_h514 = _source38.dtor_typeArgs;
                DAST._IResolvedType _918___mcc_h515 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _918___mcc_h515;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _919___mcc_h519 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _920_recursiveGen;
                    bool _921_recOwned;
                    bool _922_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _923_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out449;
                    bool _out450;
                    bool _out451;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out452;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out449, out _out450, out _out451, out _out452);
                    _920_recursiveGen = _out449;
                    _921_recOwned = _out450;
                    _922_recErased = _out451;
                    _923_recIdents = _out452;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _920_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _921_recOwned;
                    isErased = _922_recErased;
                    readIdents = _923_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _924___mcc_h521 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                    bool _926_recOwned;
                    bool _927_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out453;
                    bool _out454;
                    bool _out455;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                    _925_recursiveGen = _out453;
                    _926_recOwned = _out454;
                    _927_recErased = _out455;
                    _928_recIdents = _out456;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _926_recOwned;
                    isErased = _927_recErased;
                    readIdents = _928_recIdents;
                  }
                } else {
                  DAST._IType _929___mcc_h523 = _source39.dtor_Newtype_a0;
                  DAST._IType _930_b = _929___mcc_h523;
                  {
                    if (object.Equals(_563_fromTpe, _930_b)) {
                      Dafny.ISequence<Dafny.Rune> _931_recursiveGen;
                      bool _932_recOwned;
                      bool _933_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _934_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out457;
                      bool _out458;
                      bool _out459;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                      _931_recursiveGen = _out457;
                      _932_recOwned = _out458;
                      _933_recErased = _out459;
                      _934_recIdents = _out460;
                      Dafny.ISequence<Dafny.Rune> _935_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out461;
                      _out461 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _935_rhsType = _out461;
                      Dafny.ISequence<Dafny.Rune> _936_uneraseFn;
                      _936_uneraseFn = ((_932_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _935_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _936_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _931_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _932_recOwned;
                      isErased = false;
                      readIdents = _934_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out462;
                      bool _out463;
                      bool _out464;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out465;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _930_b), _930_b, _562_toTpe), selfIdent, @params, mustOwn, out _out462, out _out463, out _out464, out _out465);
                      s = _out462;
                      isOwned = _out463;
                      isErased = _out464;
                      readIdents = _out465;
                    }
                  }
                }
              } else if (_source38.is_Nullable) {
                DAST._IType _937___mcc_h525 = _source38.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _938_recursiveGen;
                  bool _939_recOwned;
                  bool _940_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _941_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out466;
                  bool _out467;
                  bool _out468;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out469;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out466, out _out467, out _out468, out _out469);
                  _938_recursiveGen = _out466;
                  _939_recOwned = _out467;
                  _940_recErased = _out468;
                  _941_recIdents = _out469;
                  if (!(_939_recOwned)) {
                    _938_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_938_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _938_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _940_recErased;
                  readIdents = _941_recIdents;
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _942___mcc_h527 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _943_recursiveGen;
                  bool _944_recOwned;
                  bool _945_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _946_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out470;
                  bool _out471;
                  bool _out472;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out473;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out470, out _out471, out _out472, out _out473);
                  _943_recursiveGen = _out470;
                  _944_recOwned = _out471;
                  _945_recErased = _out472;
                  _946_recIdents = _out473;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _944_recOwned;
                  isErased = _945_recErased;
                  readIdents = _946_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _947___mcc_h529 = _source38.dtor_element;
                BigInteger _948___mcc_h530 = _source38.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _949_recursiveGen;
                  bool _950_recOwned;
                  bool _951_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _952_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out474;
                  bool _out475;
                  bool _out476;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out477;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out474, out _out475, out _out476, out _out477);
                  _949_recursiveGen = _out474;
                  _950_recOwned = _out475;
                  _951_recErased = _out476;
                  _952_recIdents = _out477;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _949_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _950_recOwned;
                  isErased = _951_recErased;
                  readIdents = _952_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _953___mcc_h533 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _954_recursiveGen;
                  bool _955_recOwned;
                  bool _956_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _957_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out478;
                  bool _out479;
                  bool _out480;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out481;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out478, out _out479, out _out480, out _out481);
                  _954_recursiveGen = _out478;
                  _955_recOwned = _out479;
                  _956_recErased = _out480;
                  _957_recIdents = _out481;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _954_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _955_recOwned;
                  isErased = _956_recErased;
                  readIdents = _957_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _958___mcc_h535 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _959_recursiveGen;
                  bool _960_recOwned;
                  bool _961_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _962_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out482;
                  bool _out483;
                  bool _out484;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out485;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out482, out _out483, out _out484, out _out485);
                  _959_recursiveGen = _out482;
                  _960_recOwned = _out483;
                  _961_recErased = _out484;
                  _962_recIdents = _out485;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _959_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _960_recOwned;
                  isErased = _961_recErased;
                  readIdents = _962_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _963___mcc_h537 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _964_recursiveGen;
                  bool _965_recOwned;
                  bool _966_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _967_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out486;
                  bool _out487;
                  bool _out488;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out489;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out486, out _out487, out _out488, out _out489);
                  _964_recursiveGen = _out486;
                  _965_recOwned = _out487;
                  _966_recErased = _out488;
                  _967_recIdents = _out489;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _964_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _965_recOwned;
                  isErased = _966_recErased;
                  readIdents = _967_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _968___mcc_h539 = _source38.dtor_key;
                DAST._IType _969___mcc_h540 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _970_recursiveGen;
                  bool _971_recOwned;
                  bool _972_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _973_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out490;
                  bool _out491;
                  bool _out492;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out493;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out490, out _out491, out _out492, out _out493);
                  _970_recursiveGen = _out490;
                  _971_recOwned = _out491;
                  _972_recErased = _out492;
                  _973_recIdents = _out493;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _971_recOwned;
                  isErased = _972_recErased;
                  readIdents = _973_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _974___mcc_h543 = _source38.dtor_args;
                DAST._IType _975___mcc_h544 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _976_recursiveGen;
                  bool _977_recOwned;
                  bool _978_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _979_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out494;
                  bool _out495;
                  bool _out496;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out497;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out494, out _out495, out _out496, out _out497);
                  _976_recursiveGen = _out494;
                  _977_recOwned = _out495;
                  _978_recErased = _out496;
                  _979_recIdents = _out497;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _976_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _977_recOwned;
                  isErased = _978_recErased;
                  readIdents = _979_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _980___mcc_h547 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _981_recursiveGen;
                  bool _982_recOwned;
                  bool _983_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _984_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out498;
                  bool _out499;
                  bool _out500;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out501;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out498, out _out499, out _out500, out _out501);
                  _981_recursiveGen = _out498;
                  _982_recOwned = _out499;
                  _983_recErased = _out500;
                  _984_recIdents = _out501;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _981_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _982_recOwned;
                  isErased = _983_recErased;
                  readIdents = _984_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _985___mcc_h549 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _986_recursiveGen;
                  bool _987_recOwned;
                  bool _988_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _989_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out502;
                  bool _out503;
                  bool _out504;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out505;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out502, out _out503, out _out504, out _out505);
                  _986_recursiveGen = _out502;
                  _987_recOwned = _out503;
                  _988_recErased = _out504;
                  _989_recIdents = _out505;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _986_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _987_recOwned;
                  isErased = _988_recErased;
                  readIdents = _989_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _990___mcc_h551 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _991_recursiveGen;
                  bool _992_recOwned;
                  bool _993_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _994_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out506;
                  bool _out507;
                  bool _out508;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out509;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out506, out _out507, out _out508, out _out509);
                  _991_recursiveGen = _out506;
                  _992_recOwned = _out507;
                  _993_recErased = _out508;
                  _994_recIdents = _out509;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _992_recOwned;
                  isErased = _993_recErased;
                  readIdents = _994_recIdents;
                }
              }
            } else if (_source28.is_Array) {
              DAST._IType _995___mcc_h553 = _source28.dtor_element;
              BigInteger _996___mcc_h554 = _source28.dtor_dims;
              DAST._IType _source40 = _570___mcc_h278;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _997___mcc_h561 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _998___mcc_h562 = _source40.dtor_typeArgs;
                DAST._IResolvedType _999___mcc_h563 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _999___mcc_h563;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1000___mcc_h567 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1001_recursiveGen;
                    bool _1002_recOwned;
                    bool _1003_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1004_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out510;
                    bool _out511;
                    bool _out512;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out513;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out510, out _out511, out _out512, out _out513);
                    _1001_recursiveGen = _out510;
                    _1002_recOwned = _out511;
                    _1003_recErased = _out512;
                    _1004_recIdents = _out513;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1001_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1002_recOwned;
                    isErased = _1003_recErased;
                    readIdents = _1004_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1005___mcc_h569 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1006_recursiveGen;
                    bool _1007_recOwned;
                    bool _1008_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1009_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out514;
                    bool _out515;
                    bool _out516;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                    _1006_recursiveGen = _out514;
                    _1007_recOwned = _out515;
                    _1008_recErased = _out516;
                    _1009_recIdents = _out517;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1006_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1007_recOwned;
                    isErased = _1008_recErased;
                    readIdents = _1009_recIdents;
                  }
                } else {
                  DAST._IType _1010___mcc_h571 = _source41.dtor_Newtype_a0;
                  DAST._IType _1011_b = _1010___mcc_h571;
                  {
                    if (object.Equals(_563_fromTpe, _1011_b)) {
                      Dafny.ISequence<Dafny.Rune> _1012_recursiveGen;
                      bool _1013_recOwned;
                      bool _1014_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1015_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out518;
                      bool _out519;
                      bool _out520;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                      _1012_recursiveGen = _out518;
                      _1013_recOwned = _out519;
                      _1014_recErased = _out520;
                      _1015_recIdents = _out521;
                      Dafny.ISequence<Dafny.Rune> _1016_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out522;
                      _out522 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1016_rhsType = _out522;
                      Dafny.ISequence<Dafny.Rune> _1017_uneraseFn;
                      _1017_uneraseFn = ((_1013_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1016_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1017_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1012_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1013_recOwned;
                      isErased = false;
                      readIdents = _1015_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out523;
                      bool _out524;
                      bool _out525;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out526;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1011_b), _1011_b, _562_toTpe), selfIdent, @params, mustOwn, out _out523, out _out524, out _out525, out _out526);
                      s = _out523;
                      isOwned = _out524;
                      isErased = _out525;
                      readIdents = _out526;
                    }
                  }
                }
              } else if (_source40.is_Nullable) {
                DAST._IType _1018___mcc_h573 = _source40.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1019_recursiveGen;
                  bool _1020_recOwned;
                  bool _1021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out527;
                  bool _out528;
                  bool _out529;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out530;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out527, out _out528, out _out529, out _out530);
                  _1019_recursiveGen = _out527;
                  _1020_recOwned = _out528;
                  _1021_recErased = _out529;
                  _1022_recIdents = _out530;
                  if (!(_1020_recOwned)) {
                    _1019_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1019_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1021_recErased;
                  readIdents = _1022_recIdents;
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1023___mcc_h575 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1024_recursiveGen;
                  bool _1025_recOwned;
                  bool _1026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out531;
                  bool _out532;
                  bool _out533;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out534;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out531, out _out532, out _out533, out _out534);
                  _1024_recursiveGen = _out531;
                  _1025_recOwned = _out532;
                  _1026_recErased = _out533;
                  _1027_recIdents = _out534;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1025_recOwned;
                  isErased = _1026_recErased;
                  readIdents = _1027_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _1028___mcc_h577 = _source40.dtor_element;
                BigInteger _1029___mcc_h578 = _source40.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1030_recursiveGen;
                  bool _1031_recOwned;
                  bool _1032_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1033_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out535;
                  bool _out536;
                  bool _out537;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out538;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out535, out _out536, out _out537, out _out538);
                  _1030_recursiveGen = _out535;
                  _1031_recOwned = _out536;
                  _1032_recErased = _out537;
                  _1033_recIdents = _out538;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1030_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1031_recOwned;
                  isErased = _1032_recErased;
                  readIdents = _1033_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _1034___mcc_h581 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1035_recursiveGen;
                  bool _1036_recOwned;
                  bool _1037_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1038_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out539;
                  bool _out540;
                  bool _out541;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out542;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out539, out _out540, out _out541, out _out542);
                  _1035_recursiveGen = _out539;
                  _1036_recOwned = _out540;
                  _1037_recErased = _out541;
                  _1038_recIdents = _out542;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1036_recOwned;
                  isErased = _1037_recErased;
                  readIdents = _1038_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _1039___mcc_h583 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1040_recursiveGen;
                  bool _1041_recOwned;
                  bool _1042_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1043_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out543;
                  bool _out544;
                  bool _out545;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out546;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out543, out _out544, out _out545, out _out546);
                  _1040_recursiveGen = _out543;
                  _1041_recOwned = _out544;
                  _1042_recErased = _out545;
                  _1043_recIdents = _out546;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1041_recOwned;
                  isErased = _1042_recErased;
                  readIdents = _1043_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1044___mcc_h585 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1045_recursiveGen;
                  bool _1046_recOwned;
                  bool _1047_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1048_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out547;
                  bool _out548;
                  bool _out549;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out550;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out547, out _out548, out _out549, out _out550);
                  _1045_recursiveGen = _out547;
                  _1046_recOwned = _out548;
                  _1047_recErased = _out549;
                  _1048_recIdents = _out550;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1045_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1046_recOwned;
                  isErased = _1047_recErased;
                  readIdents = _1048_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1049___mcc_h587 = _source40.dtor_key;
                DAST._IType _1050___mcc_h588 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                  bool _1052_recOwned;
                  bool _1053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out551;
                  bool _out552;
                  bool _out553;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out554;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out551, out _out552, out _out553, out _out554);
                  _1051_recursiveGen = _out551;
                  _1052_recOwned = _out552;
                  _1053_recErased = _out553;
                  _1054_recIdents = _out554;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1052_recOwned;
                  isErased = _1053_recErased;
                  readIdents = _1054_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1055___mcc_h591 = _source40.dtor_args;
                DAST._IType _1056___mcc_h592 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1057_recursiveGen;
                  bool _1058_recOwned;
                  bool _1059_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1060_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out555;
                  bool _out556;
                  bool _out557;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out558;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out555, out _out556, out _out557, out _out558);
                  _1057_recursiveGen = _out555;
                  _1058_recOwned = _out556;
                  _1059_recErased = _out557;
                  _1060_recIdents = _out558;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1057_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1058_recOwned;
                  isErased = _1059_recErased;
                  readIdents = _1060_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1061___mcc_h595 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1062_recursiveGen;
                  bool _1063_recOwned;
                  bool _1064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out559;
                  bool _out560;
                  bool _out561;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out562;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out559, out _out560, out _out561, out _out562);
                  _1062_recursiveGen = _out559;
                  _1063_recOwned = _out560;
                  _1064_recErased = _out561;
                  _1065_recIdents = _out562;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1063_recOwned;
                  isErased = _1064_recErased;
                  readIdents = _1065_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1066___mcc_h597 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1067_recursiveGen;
                  bool _1068_recOwned;
                  bool _1069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out563;
                  bool _out564;
                  bool _out565;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out566;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out563, out _out564, out _out565, out _out566);
                  _1067_recursiveGen = _out563;
                  _1068_recOwned = _out564;
                  _1069_recErased = _out565;
                  _1070_recIdents = _out566;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1068_recOwned;
                  isErased = _1069_recErased;
                  readIdents = _1070_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1071___mcc_h599 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1072_recursiveGen;
                  bool _1073_recOwned;
                  bool _1074_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1075_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out567;
                  bool _out568;
                  bool _out569;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out570;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out567, out _out568, out _out569, out _out570);
                  _1072_recursiveGen = _out567;
                  _1073_recOwned = _out568;
                  _1074_recErased = _out569;
                  _1075_recIdents = _out570;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1073_recOwned;
                  isErased = _1074_recErased;
                  readIdents = _1075_recIdents;
                }
              }
            } else if (_source28.is_Seq) {
              DAST._IType _1076___mcc_h601 = _source28.dtor_element;
              DAST._IType _source42 = _570___mcc_h278;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1077___mcc_h605 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1078___mcc_h606 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1079___mcc_h607 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1079___mcc_h607;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1080___mcc_h611 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1081_recursiveGen;
                    bool _1082_recOwned;
                    bool _1083_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1084_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out571;
                    bool _out572;
                    bool _out573;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out574;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out571, out _out572, out _out573, out _out574);
                    _1081_recursiveGen = _out571;
                    _1082_recOwned = _out572;
                    _1083_recErased = _out573;
                    _1084_recIdents = _out574;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1081_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1082_recOwned;
                    isErased = _1083_recErased;
                    readIdents = _1084_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1085___mcc_h613 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1086_recursiveGen;
                    bool _1087_recOwned;
                    bool _1088_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1089_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out575;
                    bool _out576;
                    bool _out577;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                    _1086_recursiveGen = _out575;
                    _1087_recOwned = _out576;
                    _1088_recErased = _out577;
                    _1089_recIdents = _out578;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1086_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1087_recOwned;
                    isErased = _1088_recErased;
                    readIdents = _1089_recIdents;
                  }
                } else {
                  DAST._IType _1090___mcc_h615 = _source43.dtor_Newtype_a0;
                  DAST._IType _1091_b = _1090___mcc_h615;
                  {
                    if (object.Equals(_563_fromTpe, _1091_b)) {
                      Dafny.ISequence<Dafny.Rune> _1092_recursiveGen;
                      bool _1093_recOwned;
                      bool _1094_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1095_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out579;
                      bool _out580;
                      bool _out581;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                      _1092_recursiveGen = _out579;
                      _1093_recOwned = _out580;
                      _1094_recErased = _out581;
                      _1095_recIdents = _out582;
                      Dafny.ISequence<Dafny.Rune> _1096_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out583;
                      _out583 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1096_rhsType = _out583;
                      Dafny.ISequence<Dafny.Rune> _1097_uneraseFn;
                      _1097_uneraseFn = ((_1093_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1096_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1097_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1092_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1093_recOwned;
                      isErased = false;
                      readIdents = _1095_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out584;
                      bool _out585;
                      bool _out586;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out587;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1091_b), _1091_b, _562_toTpe), selfIdent, @params, mustOwn, out _out584, out _out585, out _out586, out _out587);
                      s = _out584;
                      isOwned = _out585;
                      isErased = _out586;
                      readIdents = _out587;
                    }
                  }
                }
              } else if (_source42.is_Nullable) {
                DAST._IType _1098___mcc_h617 = _source42.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1099_recursiveGen;
                  bool _1100_recOwned;
                  bool _1101_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1102_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out588;
                  bool _out589;
                  bool _out590;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out591;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out588, out _out589, out _out590, out _out591);
                  _1099_recursiveGen = _out588;
                  _1100_recOwned = _out589;
                  _1101_recErased = _out590;
                  _1102_recIdents = _out591;
                  if (!(_1100_recOwned)) {
                    _1099_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1099_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1099_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1101_recErased;
                  readIdents = _1102_recIdents;
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1103___mcc_h619 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1104_recursiveGen;
                  bool _1105_recOwned;
                  bool _1106_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1107_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out592;
                  bool _out593;
                  bool _out594;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out595;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out592, out _out593, out _out594, out _out595);
                  _1104_recursiveGen = _out592;
                  _1105_recOwned = _out593;
                  _1106_recErased = _out594;
                  _1107_recIdents = _out595;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1104_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1105_recOwned;
                  isErased = _1106_recErased;
                  readIdents = _1107_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1108___mcc_h621 = _source42.dtor_element;
                BigInteger _1109___mcc_h622 = _source42.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1110_recursiveGen;
                  bool _1111_recOwned;
                  bool _1112_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1113_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out596;
                  bool _out597;
                  bool _out598;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out599;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out596, out _out597, out _out598, out _out599);
                  _1110_recursiveGen = _out596;
                  _1111_recOwned = _out597;
                  _1112_recErased = _out598;
                  _1113_recIdents = _out599;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1110_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1111_recOwned;
                  isErased = _1112_recErased;
                  readIdents = _1113_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1114___mcc_h625 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1115_recursiveGen;
                  bool _1116_recOwned;
                  bool _1117_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1118_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out600;
                  bool _out601;
                  bool _out602;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out603;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out600, out _out601, out _out602, out _out603);
                  _1115_recursiveGen = _out600;
                  _1116_recOwned = _out601;
                  _1117_recErased = _out602;
                  _1118_recIdents = _out603;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1115_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1116_recOwned;
                  isErased = _1117_recErased;
                  readIdents = _1118_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1119___mcc_h627 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1120_recursiveGen;
                  bool _1121_recOwned;
                  bool _1122_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1123_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out604;
                  bool _out605;
                  bool _out606;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out607;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out604, out _out605, out _out606, out _out607);
                  _1120_recursiveGen = _out604;
                  _1121_recOwned = _out605;
                  _1122_recErased = _out606;
                  _1123_recIdents = _out607;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1120_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1121_recOwned;
                  isErased = _1122_recErased;
                  readIdents = _1123_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1124___mcc_h629 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1125_recursiveGen;
                  bool _1126_recOwned;
                  bool _1127_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1128_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out608;
                  bool _out609;
                  bool _out610;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out611;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out608, out _out609, out _out610, out _out611);
                  _1125_recursiveGen = _out608;
                  _1126_recOwned = _out609;
                  _1127_recErased = _out610;
                  _1128_recIdents = _out611;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1125_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1126_recOwned;
                  isErased = _1127_recErased;
                  readIdents = _1128_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1129___mcc_h631 = _source42.dtor_key;
                DAST._IType _1130___mcc_h632 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1131_recursiveGen;
                  bool _1132_recOwned;
                  bool _1133_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1134_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out612;
                  bool _out613;
                  bool _out614;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out615;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out612, out _out613, out _out614, out _out615);
                  _1131_recursiveGen = _out612;
                  _1132_recOwned = _out613;
                  _1133_recErased = _out614;
                  _1134_recIdents = _out615;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1131_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1132_recOwned;
                  isErased = _1133_recErased;
                  readIdents = _1134_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1135___mcc_h635 = _source42.dtor_args;
                DAST._IType _1136___mcc_h636 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1137_recursiveGen;
                  bool _1138_recOwned;
                  bool _1139_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1140_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out616;
                  bool _out617;
                  bool _out618;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out619;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out616, out _out617, out _out618, out _out619);
                  _1137_recursiveGen = _out616;
                  _1138_recOwned = _out617;
                  _1139_recErased = _out618;
                  _1140_recIdents = _out619;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1137_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1138_recOwned;
                  isErased = _1139_recErased;
                  readIdents = _1140_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1141___mcc_h639 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1142_recursiveGen;
                  bool _1143_recOwned;
                  bool _1144_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1145_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out620;
                  bool _out621;
                  bool _out622;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out623;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out620, out _out621, out _out622, out _out623);
                  _1142_recursiveGen = _out620;
                  _1143_recOwned = _out621;
                  _1144_recErased = _out622;
                  _1145_recIdents = _out623;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1143_recOwned;
                  isErased = _1144_recErased;
                  readIdents = _1145_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1146___mcc_h641 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1147_recursiveGen;
                  bool _1148_recOwned;
                  bool _1149_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1150_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out624;
                  bool _out625;
                  bool _out626;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out627;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out624, out _out625, out _out626, out _out627);
                  _1147_recursiveGen = _out624;
                  _1148_recOwned = _out625;
                  _1149_recErased = _out626;
                  _1150_recIdents = _out627;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1148_recOwned;
                  isErased = _1149_recErased;
                  readIdents = _1150_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1151___mcc_h643 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1152_recursiveGen;
                  bool _1153_recOwned;
                  bool _1154_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1155_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out628;
                  bool _out629;
                  bool _out630;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out631;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out628, out _out629, out _out630, out _out631);
                  _1152_recursiveGen = _out628;
                  _1153_recOwned = _out629;
                  _1154_recErased = _out630;
                  _1155_recIdents = _out631;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1152_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1153_recOwned;
                  isErased = _1154_recErased;
                  readIdents = _1155_recIdents;
                }
              }
            } else if (_source28.is_Set) {
              DAST._IType _1156___mcc_h645 = _source28.dtor_element;
              DAST._IType _source44 = _570___mcc_h278;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1157___mcc_h649 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1158___mcc_h650 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1159___mcc_h651 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1159___mcc_h651;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1160___mcc_h655 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1161_recursiveGen;
                    bool _1162_recOwned;
                    bool _1163_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1164_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out632;
                    bool _out633;
                    bool _out634;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out635;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out632, out _out633, out _out634, out _out635);
                    _1161_recursiveGen = _out632;
                    _1162_recOwned = _out633;
                    _1163_recErased = _out634;
                    _1164_recIdents = _out635;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1161_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1162_recOwned;
                    isErased = _1163_recErased;
                    readIdents = _1164_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1165___mcc_h657 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1166_recursiveGen;
                    bool _1167_recOwned;
                    bool _1168_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1169_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out636;
                    bool _out637;
                    bool _out638;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                    _1166_recursiveGen = _out636;
                    _1167_recOwned = _out637;
                    _1168_recErased = _out638;
                    _1169_recIdents = _out639;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1166_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1167_recOwned;
                    isErased = _1168_recErased;
                    readIdents = _1169_recIdents;
                  }
                } else {
                  DAST._IType _1170___mcc_h659 = _source45.dtor_Newtype_a0;
                  DAST._IType _1171_b = _1170___mcc_h659;
                  {
                    if (object.Equals(_563_fromTpe, _1171_b)) {
                      Dafny.ISequence<Dafny.Rune> _1172_recursiveGen;
                      bool _1173_recOwned;
                      bool _1174_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1175_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out640;
                      bool _out641;
                      bool _out642;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                      _1172_recursiveGen = _out640;
                      _1173_recOwned = _out641;
                      _1174_recErased = _out642;
                      _1175_recIdents = _out643;
                      Dafny.ISequence<Dafny.Rune> _1176_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out644;
                      _out644 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1176_rhsType = _out644;
                      Dafny.ISequence<Dafny.Rune> _1177_uneraseFn;
                      _1177_uneraseFn = ((_1173_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1176_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1177_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1172_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1173_recOwned;
                      isErased = false;
                      readIdents = _1175_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out645;
                      bool _out646;
                      bool _out647;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out648;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1171_b), _1171_b, _562_toTpe), selfIdent, @params, mustOwn, out _out645, out _out646, out _out647, out _out648);
                      s = _out645;
                      isOwned = _out646;
                      isErased = _out647;
                      readIdents = _out648;
                    }
                  }
                }
              } else if (_source44.is_Nullable) {
                DAST._IType _1178___mcc_h661 = _source44.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1179_recursiveGen;
                  bool _1180_recOwned;
                  bool _1181_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1182_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out649;
                  bool _out650;
                  bool _out651;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out652;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out649, out _out650, out _out651, out _out652);
                  _1179_recursiveGen = _out649;
                  _1180_recOwned = _out650;
                  _1181_recErased = _out651;
                  _1182_recIdents = _out652;
                  if (!(_1180_recOwned)) {
                    _1179_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1179_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1179_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1181_recErased;
                  readIdents = _1182_recIdents;
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1183___mcc_h663 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1184_recursiveGen;
                  bool _1185_recOwned;
                  bool _1186_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1187_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out653;
                  bool _out654;
                  bool _out655;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out656;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out653, out _out654, out _out655, out _out656);
                  _1184_recursiveGen = _out653;
                  _1185_recOwned = _out654;
                  _1186_recErased = _out655;
                  _1187_recIdents = _out656;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1184_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1185_recOwned;
                  isErased = _1186_recErased;
                  readIdents = _1187_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1188___mcc_h665 = _source44.dtor_element;
                BigInteger _1189___mcc_h666 = _source44.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1190_recursiveGen;
                  bool _1191_recOwned;
                  bool _1192_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1193_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out657;
                  bool _out658;
                  bool _out659;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out660;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out657, out _out658, out _out659, out _out660);
                  _1190_recursiveGen = _out657;
                  _1191_recOwned = _out658;
                  _1192_recErased = _out659;
                  _1193_recIdents = _out660;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1190_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1191_recOwned;
                  isErased = _1192_recErased;
                  readIdents = _1193_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1194___mcc_h669 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1195_recursiveGen;
                  bool _1196_recOwned;
                  bool _1197_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1198_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out661;
                  bool _out662;
                  bool _out663;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out664;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out661, out _out662, out _out663, out _out664);
                  _1195_recursiveGen = _out661;
                  _1196_recOwned = _out662;
                  _1197_recErased = _out663;
                  _1198_recIdents = _out664;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1195_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1196_recOwned;
                  isErased = _1197_recErased;
                  readIdents = _1198_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1199___mcc_h671 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1200_recursiveGen;
                  bool _1201_recOwned;
                  bool _1202_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1203_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out665;
                  bool _out666;
                  bool _out667;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out668;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out665, out _out666, out _out667, out _out668);
                  _1200_recursiveGen = _out665;
                  _1201_recOwned = _out666;
                  _1202_recErased = _out667;
                  _1203_recIdents = _out668;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1200_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1201_recOwned;
                  isErased = _1202_recErased;
                  readIdents = _1203_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1204___mcc_h673 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                  bool _1206_recOwned;
                  bool _1207_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out669;
                  bool _out670;
                  bool _out671;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out672;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out669, out _out670, out _out671, out _out672);
                  _1205_recursiveGen = _out669;
                  _1206_recOwned = _out670;
                  _1207_recErased = _out671;
                  _1208_recIdents = _out672;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1206_recOwned;
                  isErased = _1207_recErased;
                  readIdents = _1208_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1209___mcc_h675 = _source44.dtor_key;
                DAST._IType _1210___mcc_h676 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1211_recursiveGen;
                  bool _1212_recOwned;
                  bool _1213_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1214_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out673;
                  bool _out674;
                  bool _out675;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out676;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out673, out _out674, out _out675, out _out676);
                  _1211_recursiveGen = _out673;
                  _1212_recOwned = _out674;
                  _1213_recErased = _out675;
                  _1214_recIdents = _out676;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1211_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1212_recOwned;
                  isErased = _1213_recErased;
                  readIdents = _1214_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1215___mcc_h679 = _source44.dtor_args;
                DAST._IType _1216___mcc_h680 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1217_recursiveGen;
                  bool _1218_recOwned;
                  bool _1219_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1220_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out677;
                  bool _out678;
                  bool _out679;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out680;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out677, out _out678, out _out679, out _out680);
                  _1217_recursiveGen = _out677;
                  _1218_recOwned = _out678;
                  _1219_recErased = _out679;
                  _1220_recIdents = _out680;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1218_recOwned;
                  isErased = _1219_recErased;
                  readIdents = _1220_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1221___mcc_h683 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1222_recursiveGen;
                  bool _1223_recOwned;
                  bool _1224_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1225_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out681;
                  bool _out682;
                  bool _out683;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out684;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out681, out _out682, out _out683, out _out684);
                  _1222_recursiveGen = _out681;
                  _1223_recOwned = _out682;
                  _1224_recErased = _out683;
                  _1225_recIdents = _out684;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1222_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1223_recOwned;
                  isErased = _1224_recErased;
                  readIdents = _1225_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1226___mcc_h685 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1227_recursiveGen;
                  bool _1228_recOwned;
                  bool _1229_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1230_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out685;
                  bool _out686;
                  bool _out687;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out688;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out685, out _out686, out _out687, out _out688);
                  _1227_recursiveGen = _out685;
                  _1228_recOwned = _out686;
                  _1229_recErased = _out687;
                  _1230_recIdents = _out688;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1227_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1228_recOwned;
                  isErased = _1229_recErased;
                  readIdents = _1230_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1231___mcc_h687 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1232_recursiveGen;
                  bool _1233_recOwned;
                  bool _1234_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1235_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out689;
                  bool _out690;
                  bool _out691;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out692;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out689, out _out690, out _out691, out _out692);
                  _1232_recursiveGen = _out689;
                  _1233_recOwned = _out690;
                  _1234_recErased = _out691;
                  _1235_recIdents = _out692;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1232_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1233_recOwned;
                  isErased = _1234_recErased;
                  readIdents = _1235_recIdents;
                }
              }
            } else if (_source28.is_Multiset) {
              DAST._IType _1236___mcc_h689 = _source28.dtor_element;
              DAST._IType _source46 = _570___mcc_h278;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1237___mcc_h693 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1238___mcc_h694 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1239___mcc_h695 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1239___mcc_h695;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1240___mcc_h699 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1241_recursiveGen;
                    bool _1242_recOwned;
                    bool _1243_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1244_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out693;
                    bool _out694;
                    bool _out695;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out696;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out693, out _out694, out _out695, out _out696);
                    _1241_recursiveGen = _out693;
                    _1242_recOwned = _out694;
                    _1243_recErased = _out695;
                    _1244_recIdents = _out696;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1241_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1242_recOwned;
                    isErased = _1243_recErased;
                    readIdents = _1244_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1245___mcc_h701 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1246_recursiveGen;
                    bool _1247_recOwned;
                    bool _1248_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1249_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out697;
                    bool _out698;
                    bool _out699;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                    _1246_recursiveGen = _out697;
                    _1247_recOwned = _out698;
                    _1248_recErased = _out699;
                    _1249_recIdents = _out700;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1246_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1247_recOwned;
                    isErased = _1248_recErased;
                    readIdents = _1249_recIdents;
                  }
                } else {
                  DAST._IType _1250___mcc_h703 = _source47.dtor_Newtype_a0;
                  DAST._IType _1251_b = _1250___mcc_h703;
                  {
                    if (object.Equals(_563_fromTpe, _1251_b)) {
                      Dafny.ISequence<Dafny.Rune> _1252_recursiveGen;
                      bool _1253_recOwned;
                      bool _1254_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1255_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out701;
                      bool _out702;
                      bool _out703;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                      _1252_recursiveGen = _out701;
                      _1253_recOwned = _out702;
                      _1254_recErased = _out703;
                      _1255_recIdents = _out704;
                      Dafny.ISequence<Dafny.Rune> _1256_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out705;
                      _out705 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1256_rhsType = _out705;
                      Dafny.ISequence<Dafny.Rune> _1257_uneraseFn;
                      _1257_uneraseFn = ((_1253_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1256_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1257_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1252_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1253_recOwned;
                      isErased = false;
                      readIdents = _1255_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out706;
                      bool _out707;
                      bool _out708;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out709;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1251_b), _1251_b, _562_toTpe), selfIdent, @params, mustOwn, out _out706, out _out707, out _out708, out _out709);
                      s = _out706;
                      isOwned = _out707;
                      isErased = _out708;
                      readIdents = _out709;
                    }
                  }
                }
              } else if (_source46.is_Nullable) {
                DAST._IType _1258___mcc_h705 = _source46.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1259_recursiveGen;
                  bool _1260_recOwned;
                  bool _1261_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1262_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out710;
                  bool _out711;
                  bool _out712;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out713;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out710, out _out711, out _out712, out _out713);
                  _1259_recursiveGen = _out710;
                  _1260_recOwned = _out711;
                  _1261_recErased = _out712;
                  _1262_recIdents = _out713;
                  if (!(_1260_recOwned)) {
                    _1259_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1259_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1259_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1261_recErased;
                  readIdents = _1262_recIdents;
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1263___mcc_h707 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1264_recursiveGen;
                  bool _1265_recOwned;
                  bool _1266_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1267_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out714;
                  bool _out715;
                  bool _out716;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out717;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out714, out _out715, out _out716, out _out717);
                  _1264_recursiveGen = _out714;
                  _1265_recOwned = _out715;
                  _1266_recErased = _out716;
                  _1267_recIdents = _out717;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1264_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1265_recOwned;
                  isErased = _1266_recErased;
                  readIdents = _1267_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1268___mcc_h709 = _source46.dtor_element;
                BigInteger _1269___mcc_h710 = _source46.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1270_recursiveGen;
                  bool _1271_recOwned;
                  bool _1272_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1273_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out718;
                  bool _out719;
                  bool _out720;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out721;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out718, out _out719, out _out720, out _out721);
                  _1270_recursiveGen = _out718;
                  _1271_recOwned = _out719;
                  _1272_recErased = _out720;
                  _1273_recIdents = _out721;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1270_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1271_recOwned;
                  isErased = _1272_recErased;
                  readIdents = _1273_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1274___mcc_h713 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1275_recursiveGen;
                  bool _1276_recOwned;
                  bool _1277_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1278_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out722;
                  bool _out723;
                  bool _out724;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out725;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out722, out _out723, out _out724, out _out725);
                  _1275_recursiveGen = _out722;
                  _1276_recOwned = _out723;
                  _1277_recErased = _out724;
                  _1278_recIdents = _out725;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1275_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1276_recOwned;
                  isErased = _1277_recErased;
                  readIdents = _1278_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1279___mcc_h715 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1280_recursiveGen;
                  bool _1281_recOwned;
                  bool _1282_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1283_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out726;
                  bool _out727;
                  bool _out728;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out729;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out726, out _out727, out _out728, out _out729);
                  _1280_recursiveGen = _out726;
                  _1281_recOwned = _out727;
                  _1282_recErased = _out728;
                  _1283_recIdents = _out729;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1280_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1281_recOwned;
                  isErased = _1282_recErased;
                  readIdents = _1283_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1284___mcc_h717 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1285_recursiveGen;
                  bool _1286_recOwned;
                  bool _1287_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1288_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out730;
                  bool _out731;
                  bool _out732;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out733;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out730, out _out731, out _out732, out _out733);
                  _1285_recursiveGen = _out730;
                  _1286_recOwned = _out731;
                  _1287_recErased = _out732;
                  _1288_recIdents = _out733;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1285_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1286_recOwned;
                  isErased = _1287_recErased;
                  readIdents = _1288_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1289___mcc_h719 = _source46.dtor_key;
                DAST._IType _1290___mcc_h720 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1291_recursiveGen;
                  bool _1292_recOwned;
                  bool _1293_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1294_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out734;
                  bool _out735;
                  bool _out736;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out737;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out734, out _out735, out _out736, out _out737);
                  _1291_recursiveGen = _out734;
                  _1292_recOwned = _out735;
                  _1293_recErased = _out736;
                  _1294_recIdents = _out737;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1291_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1292_recOwned;
                  isErased = _1293_recErased;
                  readIdents = _1294_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1295___mcc_h723 = _source46.dtor_args;
                DAST._IType _1296___mcc_h724 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1297_recursiveGen;
                  bool _1298_recOwned;
                  bool _1299_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1300_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out738;
                  bool _out739;
                  bool _out740;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out741;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out738, out _out739, out _out740, out _out741);
                  _1297_recursiveGen = _out738;
                  _1298_recOwned = _out739;
                  _1299_recErased = _out740;
                  _1300_recIdents = _out741;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1297_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1298_recOwned;
                  isErased = _1299_recErased;
                  readIdents = _1300_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1301___mcc_h727 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1302_recursiveGen;
                  bool _1303_recOwned;
                  bool _1304_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1305_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out742;
                  bool _out743;
                  bool _out744;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out745;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out742, out _out743, out _out744, out _out745);
                  _1302_recursiveGen = _out742;
                  _1303_recOwned = _out743;
                  _1304_recErased = _out744;
                  _1305_recIdents = _out745;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1302_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1303_recOwned;
                  isErased = _1304_recErased;
                  readIdents = _1305_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1306___mcc_h729 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1307_recursiveGen;
                  bool _1308_recOwned;
                  bool _1309_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1310_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out746;
                  bool _out747;
                  bool _out748;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out749;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out746, out _out747, out _out748, out _out749);
                  _1307_recursiveGen = _out746;
                  _1308_recOwned = _out747;
                  _1309_recErased = _out748;
                  _1310_recIdents = _out749;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1307_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1308_recOwned;
                  isErased = _1309_recErased;
                  readIdents = _1310_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1311___mcc_h731 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1312_recursiveGen;
                  bool _1313_recOwned;
                  bool _1314_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1315_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out750;
                  bool _out751;
                  bool _out752;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out753;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out750, out _out751, out _out752, out _out753);
                  _1312_recursiveGen = _out750;
                  _1313_recOwned = _out751;
                  _1314_recErased = _out752;
                  _1315_recIdents = _out753;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1312_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1313_recOwned;
                  isErased = _1314_recErased;
                  readIdents = _1315_recIdents;
                }
              }
            } else if (_source28.is_Map) {
              DAST._IType _1316___mcc_h733 = _source28.dtor_key;
              DAST._IType _1317___mcc_h734 = _source28.dtor_value;
              DAST._IType _source48 = _570___mcc_h278;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1318___mcc_h741 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1319___mcc_h742 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1320___mcc_h743 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1320___mcc_h743;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1321___mcc_h747 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1322_recursiveGen;
                    bool _1323_recOwned;
                    bool _1324_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1325_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out754;
                    bool _out755;
                    bool _out756;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out757;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out754, out _out755, out _out756, out _out757);
                    _1322_recursiveGen = _out754;
                    _1323_recOwned = _out755;
                    _1324_recErased = _out756;
                    _1325_recIdents = _out757;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1322_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1323_recOwned;
                    isErased = _1324_recErased;
                    readIdents = _1325_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1326___mcc_h749 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                    bool _1328_recOwned;
                    bool _1329_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out758;
                    bool _out759;
                    bool _out760;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                    _1327_recursiveGen = _out758;
                    _1328_recOwned = _out759;
                    _1329_recErased = _out760;
                    _1330_recIdents = _out761;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1328_recOwned;
                    isErased = _1329_recErased;
                    readIdents = _1330_recIdents;
                  }
                } else {
                  DAST._IType _1331___mcc_h751 = _source49.dtor_Newtype_a0;
                  DAST._IType _1332_b = _1331___mcc_h751;
                  {
                    if (object.Equals(_563_fromTpe, _1332_b)) {
                      Dafny.ISequence<Dafny.Rune> _1333_recursiveGen;
                      bool _1334_recOwned;
                      bool _1335_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1336_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out762;
                      bool _out763;
                      bool _out764;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                      _1333_recursiveGen = _out762;
                      _1334_recOwned = _out763;
                      _1335_recErased = _out764;
                      _1336_recIdents = _out765;
                      Dafny.ISequence<Dafny.Rune> _1337_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out766;
                      _out766 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1337_rhsType = _out766;
                      Dafny.ISequence<Dafny.Rune> _1338_uneraseFn;
                      _1338_uneraseFn = ((_1334_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1337_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1338_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1333_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1334_recOwned;
                      isErased = false;
                      readIdents = _1336_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out767;
                      bool _out768;
                      bool _out769;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out770;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1332_b), _1332_b, _562_toTpe), selfIdent, @params, mustOwn, out _out767, out _out768, out _out769, out _out770);
                      s = _out767;
                      isOwned = _out768;
                      isErased = _out769;
                      readIdents = _out770;
                    }
                  }
                }
              } else if (_source48.is_Nullable) {
                DAST._IType _1339___mcc_h753 = _source48.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1340_recursiveGen;
                  bool _1341_recOwned;
                  bool _1342_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1343_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out771;
                  bool _out772;
                  bool _out773;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out774;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out771, out _out772, out _out773, out _out774);
                  _1340_recursiveGen = _out771;
                  _1341_recOwned = _out772;
                  _1342_recErased = _out773;
                  _1343_recIdents = _out774;
                  if (!(_1341_recOwned)) {
                    _1340_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1340_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1340_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1342_recErased;
                  readIdents = _1343_recIdents;
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1344___mcc_h755 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1345_recursiveGen;
                  bool _1346_recOwned;
                  bool _1347_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1348_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out775;
                  bool _out776;
                  bool _out777;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out778;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out775, out _out776, out _out777, out _out778);
                  _1345_recursiveGen = _out775;
                  _1346_recOwned = _out776;
                  _1347_recErased = _out777;
                  _1348_recIdents = _out778;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1345_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1346_recOwned;
                  isErased = _1347_recErased;
                  readIdents = _1348_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1349___mcc_h757 = _source48.dtor_element;
                BigInteger _1350___mcc_h758 = _source48.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1351_recursiveGen;
                  bool _1352_recOwned;
                  bool _1353_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1354_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out779;
                  bool _out780;
                  bool _out781;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out782;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out779, out _out780, out _out781, out _out782);
                  _1351_recursiveGen = _out779;
                  _1352_recOwned = _out780;
                  _1353_recErased = _out781;
                  _1354_recIdents = _out782;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1351_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1352_recOwned;
                  isErased = _1353_recErased;
                  readIdents = _1354_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1355___mcc_h761 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1356_recursiveGen;
                  bool _1357_recOwned;
                  bool _1358_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1359_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out783;
                  bool _out784;
                  bool _out785;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out786;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out783, out _out784, out _out785, out _out786);
                  _1356_recursiveGen = _out783;
                  _1357_recOwned = _out784;
                  _1358_recErased = _out785;
                  _1359_recIdents = _out786;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1356_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1357_recOwned;
                  isErased = _1358_recErased;
                  readIdents = _1359_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1360___mcc_h763 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1361_recursiveGen;
                  bool _1362_recOwned;
                  bool _1363_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1364_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out787;
                  bool _out788;
                  bool _out789;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out790;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out787, out _out788, out _out789, out _out790);
                  _1361_recursiveGen = _out787;
                  _1362_recOwned = _out788;
                  _1363_recErased = _out789;
                  _1364_recIdents = _out790;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1361_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1362_recOwned;
                  isErased = _1363_recErased;
                  readIdents = _1364_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1365___mcc_h765 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1366_recursiveGen;
                  bool _1367_recOwned;
                  bool _1368_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1369_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out791;
                  bool _out792;
                  bool _out793;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out794;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out791, out _out792, out _out793, out _out794);
                  _1366_recursiveGen = _out791;
                  _1367_recOwned = _out792;
                  _1368_recErased = _out793;
                  _1369_recIdents = _out794;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1366_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1367_recOwned;
                  isErased = _1368_recErased;
                  readIdents = _1369_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1370___mcc_h767 = _source48.dtor_key;
                DAST._IType _1371___mcc_h768 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1372_recursiveGen;
                  bool _1373_recOwned;
                  bool _1374_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1375_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out795;
                  bool _out796;
                  bool _out797;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out798;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out795, out _out796, out _out797, out _out798);
                  _1372_recursiveGen = _out795;
                  _1373_recOwned = _out796;
                  _1374_recErased = _out797;
                  _1375_recIdents = _out798;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1372_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1373_recOwned;
                  isErased = _1374_recErased;
                  readIdents = _1375_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1376___mcc_h771 = _source48.dtor_args;
                DAST._IType _1377___mcc_h772 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1378_recursiveGen;
                  bool _1379_recOwned;
                  bool _1380_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1381_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out799;
                  bool _out800;
                  bool _out801;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out802;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out799, out _out800, out _out801, out _out802);
                  _1378_recursiveGen = _out799;
                  _1379_recOwned = _out800;
                  _1380_recErased = _out801;
                  _1381_recIdents = _out802;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1378_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1379_recOwned;
                  isErased = _1380_recErased;
                  readIdents = _1381_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1382___mcc_h775 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1383_recursiveGen;
                  bool _1384_recOwned;
                  bool _1385_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1386_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out803;
                  bool _out804;
                  bool _out805;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out806;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out803, out _out804, out _out805, out _out806);
                  _1383_recursiveGen = _out803;
                  _1384_recOwned = _out804;
                  _1385_recErased = _out805;
                  _1386_recIdents = _out806;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1383_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1384_recOwned;
                  isErased = _1385_recErased;
                  readIdents = _1386_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1387___mcc_h777 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1388_recursiveGen;
                  bool _1389_recOwned;
                  bool _1390_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1391_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out807;
                  bool _out808;
                  bool _out809;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out810;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out807, out _out808, out _out809, out _out810);
                  _1388_recursiveGen = _out807;
                  _1389_recOwned = _out808;
                  _1390_recErased = _out809;
                  _1391_recIdents = _out810;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1388_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1389_recOwned;
                  isErased = _1390_recErased;
                  readIdents = _1391_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1392___mcc_h779 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1393_recursiveGen;
                  bool _1394_recOwned;
                  bool _1395_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1396_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out811;
                  bool _out812;
                  bool _out813;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out814;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out811, out _out812, out _out813, out _out814);
                  _1393_recursiveGen = _out811;
                  _1394_recOwned = _out812;
                  _1395_recErased = _out813;
                  _1396_recIdents = _out814;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1393_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1394_recOwned;
                  isErased = _1395_recErased;
                  readIdents = _1396_recIdents;
                }
              }
            } else if (_source28.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1397___mcc_h781 = _source28.dtor_args;
              DAST._IType _1398___mcc_h782 = _source28.dtor_result;
              DAST._IType _source50 = _570___mcc_h278;
              if (_source50.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1399___mcc_h789 = _source50.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1400___mcc_h790 = _source50.dtor_typeArgs;
                DAST._IResolvedType _1401___mcc_h791 = _source50.dtor_resolved;
                DAST._IResolvedType _source51 = _1401___mcc_h791;
                if (_source51.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1402___mcc_h795 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1403_recursiveGen;
                    bool _1404_recOwned;
                    bool _1405_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1406_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out815;
                    bool _out816;
                    bool _out817;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out818;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out815, out _out816, out _out817, out _out818);
                    _1403_recursiveGen = _out815;
                    _1404_recOwned = _out816;
                    _1405_recErased = _out817;
                    _1406_recIdents = _out818;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1403_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1404_recOwned;
                    isErased = _1405_recErased;
                    readIdents = _1406_recIdents;
                  }
                } else if (_source51.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1407___mcc_h797 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1408_recursiveGen;
                    bool _1409_recOwned;
                    bool _1410_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1411_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out819;
                    bool _out820;
                    bool _out821;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                    _1408_recursiveGen = _out819;
                    _1409_recOwned = _out820;
                    _1410_recErased = _out821;
                    _1411_recIdents = _out822;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1408_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1409_recOwned;
                    isErased = _1410_recErased;
                    readIdents = _1411_recIdents;
                  }
                } else {
                  DAST._IType _1412___mcc_h799 = _source51.dtor_Newtype_a0;
                  DAST._IType _1413_b = _1412___mcc_h799;
                  {
                    if (object.Equals(_563_fromTpe, _1413_b)) {
                      Dafny.ISequence<Dafny.Rune> _1414_recursiveGen;
                      bool _1415_recOwned;
                      bool _1416_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1417_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out823;
                      bool _out824;
                      bool _out825;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                      _1414_recursiveGen = _out823;
                      _1415_recOwned = _out824;
                      _1416_recErased = _out825;
                      _1417_recIdents = _out826;
                      Dafny.ISequence<Dafny.Rune> _1418_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out827;
                      _out827 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1418_rhsType = _out827;
                      Dafny.ISequence<Dafny.Rune> _1419_uneraseFn;
                      _1419_uneraseFn = ((_1415_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1418_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1419_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1414_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1415_recOwned;
                      isErased = false;
                      readIdents = _1417_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out828;
                      bool _out829;
                      bool _out830;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out831;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1413_b), _1413_b, _562_toTpe), selfIdent, @params, mustOwn, out _out828, out _out829, out _out830, out _out831);
                      s = _out828;
                      isOwned = _out829;
                      isErased = _out830;
                      readIdents = _out831;
                    }
                  }
                }
              } else if (_source50.is_Nullable) {
                DAST._IType _1420___mcc_h801 = _source50.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1421_recursiveGen;
                  bool _1422_recOwned;
                  bool _1423_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1424_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out832;
                  bool _out833;
                  bool _out834;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out835;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out832, out _out833, out _out834, out _out835);
                  _1421_recursiveGen = _out832;
                  _1422_recOwned = _out833;
                  _1423_recErased = _out834;
                  _1424_recIdents = _out835;
                  if (!(_1422_recOwned)) {
                    _1421_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1421_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1421_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1423_recErased;
                  readIdents = _1424_recIdents;
                }
              } else if (_source50.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1425___mcc_h803 = _source50.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1426_recursiveGen;
                  bool _1427_recOwned;
                  bool _1428_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1429_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out836;
                  bool _out837;
                  bool _out838;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out839;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out836, out _out837, out _out838, out _out839);
                  _1426_recursiveGen = _out836;
                  _1427_recOwned = _out837;
                  _1428_recErased = _out838;
                  _1429_recIdents = _out839;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1426_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1427_recOwned;
                  isErased = _1428_recErased;
                  readIdents = _1429_recIdents;
                }
              } else if (_source50.is_Array) {
                DAST._IType _1430___mcc_h805 = _source50.dtor_element;
                BigInteger _1431___mcc_h806 = _source50.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1432_recursiveGen;
                  bool _1433_recOwned;
                  bool _1434_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1435_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out840;
                  bool _out841;
                  bool _out842;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out843;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out840, out _out841, out _out842, out _out843);
                  _1432_recursiveGen = _out840;
                  _1433_recOwned = _out841;
                  _1434_recErased = _out842;
                  _1435_recIdents = _out843;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1432_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1433_recOwned;
                  isErased = _1434_recErased;
                  readIdents = _1435_recIdents;
                }
              } else if (_source50.is_Seq) {
                DAST._IType _1436___mcc_h809 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1437_recursiveGen;
                  bool _1438_recOwned;
                  bool _1439_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1440_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out844;
                  bool _out845;
                  bool _out846;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out847;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out844, out _out845, out _out846, out _out847);
                  _1437_recursiveGen = _out844;
                  _1438_recOwned = _out845;
                  _1439_recErased = _out846;
                  _1440_recIdents = _out847;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1437_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1438_recOwned;
                  isErased = _1439_recErased;
                  readIdents = _1440_recIdents;
                }
              } else if (_source50.is_Set) {
                DAST._IType _1441___mcc_h811 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1442_recursiveGen;
                  bool _1443_recOwned;
                  bool _1444_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1445_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out848;
                  bool _out849;
                  bool _out850;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out851;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out848, out _out849, out _out850, out _out851);
                  _1442_recursiveGen = _out848;
                  _1443_recOwned = _out849;
                  _1444_recErased = _out850;
                  _1445_recIdents = _out851;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1442_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1443_recOwned;
                  isErased = _1444_recErased;
                  readIdents = _1445_recIdents;
                }
              } else if (_source50.is_Multiset) {
                DAST._IType _1446___mcc_h813 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1447_recursiveGen;
                  bool _1448_recOwned;
                  bool _1449_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1450_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out852;
                  bool _out853;
                  bool _out854;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out855;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out852, out _out853, out _out854, out _out855);
                  _1447_recursiveGen = _out852;
                  _1448_recOwned = _out853;
                  _1449_recErased = _out854;
                  _1450_recIdents = _out855;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1447_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1448_recOwned;
                  isErased = _1449_recErased;
                  readIdents = _1450_recIdents;
                }
              } else if (_source50.is_Map) {
                DAST._IType _1451___mcc_h815 = _source50.dtor_key;
                DAST._IType _1452___mcc_h816 = _source50.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1453_recursiveGen;
                  bool _1454_recOwned;
                  bool _1455_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1456_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out856;
                  bool _out857;
                  bool _out858;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out859;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out856, out _out857, out _out858, out _out859);
                  _1453_recursiveGen = _out856;
                  _1454_recOwned = _out857;
                  _1455_recErased = _out858;
                  _1456_recIdents = _out859;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1454_recOwned;
                  isErased = _1455_recErased;
                  readIdents = _1456_recIdents;
                }
              } else if (_source50.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1457___mcc_h819 = _source50.dtor_args;
                DAST._IType _1458___mcc_h820 = _source50.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1459_recursiveGen;
                  bool _1460_recOwned;
                  bool _1461_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1462_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out860;
                  bool _out861;
                  bool _out862;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out863;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out860, out _out861, out _out862, out _out863);
                  _1459_recursiveGen = _out860;
                  _1460_recOwned = _out861;
                  _1461_recErased = _out862;
                  _1462_recIdents = _out863;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1459_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1460_recOwned;
                  isErased = _1461_recErased;
                  readIdents = _1462_recIdents;
                }
              } else if (_source50.is_Primitive) {
                DAST._IPrimitive _1463___mcc_h823 = _source50.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1464_recursiveGen;
                  bool _1465_recOwned;
                  bool _1466_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1467_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out864;
                  bool _out865;
                  bool _out866;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out867;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out864, out _out865, out _out866, out _out867);
                  _1464_recursiveGen = _out864;
                  _1465_recOwned = _out865;
                  _1466_recErased = _out866;
                  _1467_recIdents = _out867;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1464_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1465_recOwned;
                  isErased = _1466_recErased;
                  readIdents = _1467_recIdents;
                }
              } else if (_source50.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1468___mcc_h825 = _source50.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1469_recursiveGen;
                  bool _1470_recOwned;
                  bool _1471_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1472_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out868;
                  bool _out869;
                  bool _out870;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out871;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out868, out _out869, out _out870, out _out871);
                  _1469_recursiveGen = _out868;
                  _1470_recOwned = _out869;
                  _1471_recErased = _out870;
                  _1472_recIdents = _out871;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1469_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1470_recOwned;
                  isErased = _1471_recErased;
                  readIdents = _1472_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1473___mcc_h827 = _source50.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1474_recursiveGen;
                  bool _1475_recOwned;
                  bool _1476_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1477_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out872;
                  bool _out873;
                  bool _out874;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                  _1474_recursiveGen = _out872;
                  _1475_recOwned = _out873;
                  _1476_recErased = _out874;
                  _1477_recIdents = _out875;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1474_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1475_recOwned;
                  isErased = _1476_recErased;
                  readIdents = _1477_recIdents;
                }
              }
            } else if (_source28.is_Primitive) {
              DAST._IPrimitive _1478___mcc_h829 = _source28.dtor_Primitive_a0;
              DAST._IPrimitive _source52 = _1478___mcc_h829;
              if (_source52.is_Int) {
                DAST._IType _source53 = _570___mcc_h278;
                if (_source53.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1479___mcc_h833 = _source53.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1480___mcc_h834 = _source53.dtor_typeArgs;
                  DAST._IResolvedType _1481___mcc_h835 = _source53.dtor_resolved;
                  DAST._IResolvedType _source54 = _1481___mcc_h835;
                  if (_source54.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1482___mcc_h839 = _source54.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1483_recursiveGen;
                      bool _1484_recOwned;
                      bool _1485_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1486_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out876;
                      bool _out877;
                      bool _out878;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                      _1483_recursiveGen = _out876;
                      _1484_recOwned = _out877;
                      _1485_recErased = _out878;
                      _1486_recIdents = _out879;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1483_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1484_recOwned;
                      isErased = _1485_recErased;
                      readIdents = _1486_recIdents;
                    }
                  } else if (_source54.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1487___mcc_h841 = _source54.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1488_recursiveGen;
                      bool _1489_recOwned;
                      bool _1490_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1491_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out880;
                      bool _out881;
                      bool _out882;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                      _1488_recursiveGen = _out880;
                      _1489_recOwned = _out881;
                      _1490_recErased = _out882;
                      _1491_recIdents = _out883;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1488_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1489_recOwned;
                      isErased = _1490_recErased;
                      readIdents = _1491_recIdents;
                    }
                  } else {
                    DAST._IType _1492___mcc_h843 = _source54.dtor_Newtype_a0;
                    DAST._IType _1493_b = _1492___mcc_h843;
                    {
                      if (object.Equals(_563_fromTpe, _1493_b)) {
                        Dafny.ISequence<Dafny.Rune> _1494_recursiveGen;
                        bool _1495_recOwned;
                        bool _1496_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1497_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out884;
                        bool _out885;
                        bool _out886;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                        _1494_recursiveGen = _out884;
                        _1495_recOwned = _out885;
                        _1496_recErased = _out886;
                        _1497_recIdents = _out887;
                        Dafny.ISequence<Dafny.Rune> _1498_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out888;
                        _out888 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _1498_rhsType = _out888;
                        Dafny.ISequence<Dafny.Rune> _1499_uneraseFn;
                        _1499_uneraseFn = ((_1495_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1498_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1499_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1494_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1495_recOwned;
                        isErased = false;
                        readIdents = _1497_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out889;
                        bool _out890;
                        bool _out891;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out892;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1493_b), _1493_b, _562_toTpe), selfIdent, @params, mustOwn, out _out889, out _out890, out _out891, out _out892);
                        s = _out889;
                        isOwned = _out890;
                        isErased = _out891;
                        readIdents = _out892;
                      }
                    }
                  }
                } else if (_source53.is_Nullable) {
                  DAST._IType _1500___mcc_h845 = _source53.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1501_recursiveGen;
                    bool _1502_recOwned;
                    bool _1503_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1504_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out893;
                    bool _out894;
                    bool _out895;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out896;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out893, out _out894, out _out895, out _out896);
                    _1501_recursiveGen = _out893;
                    _1502_recOwned = _out894;
                    _1503_recErased = _out895;
                    _1504_recIdents = _out896;
                    if (!(_1502_recOwned)) {
                      _1501_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1501_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1501_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1503_recErased;
                    readIdents = _1504_recIdents;
                  }
                } else if (_source53.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1505___mcc_h847 = _source53.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1506_recursiveGen;
                    bool _1507_recOwned;
                    bool _1508_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1509_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out897;
                    bool _out898;
                    bool _out899;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out900;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out897, out _out898, out _out899, out _out900);
                    _1506_recursiveGen = _out897;
                    _1507_recOwned = _out898;
                    _1508_recErased = _out899;
                    _1509_recIdents = _out900;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1506_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1507_recOwned;
                    isErased = _1508_recErased;
                    readIdents = _1509_recIdents;
                  }
                } else if (_source53.is_Array) {
                  DAST._IType _1510___mcc_h849 = _source53.dtor_element;
                  BigInteger _1511___mcc_h850 = _source53.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1512_recursiveGen;
                    bool _1513_recOwned;
                    bool _1514_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1515_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out901;
                    bool _out902;
                    bool _out903;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out904;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out901, out _out902, out _out903, out _out904);
                    _1512_recursiveGen = _out901;
                    _1513_recOwned = _out902;
                    _1514_recErased = _out903;
                    _1515_recIdents = _out904;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1512_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1513_recOwned;
                    isErased = _1514_recErased;
                    readIdents = _1515_recIdents;
                  }
                } else if (_source53.is_Seq) {
                  DAST._IType _1516___mcc_h853 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1517_recursiveGen;
                    bool _1518_recOwned;
                    bool _1519_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1520_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out905;
                    bool _out906;
                    bool _out907;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out908;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out905, out _out906, out _out907, out _out908);
                    _1517_recursiveGen = _out905;
                    _1518_recOwned = _out906;
                    _1519_recErased = _out907;
                    _1520_recIdents = _out908;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1517_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1518_recOwned;
                    isErased = _1519_recErased;
                    readIdents = _1520_recIdents;
                  }
                } else if (_source53.is_Set) {
                  DAST._IType _1521___mcc_h855 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                    bool _1523_recOwned;
                    bool _1524_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out909;
                    bool _out910;
                    bool _out911;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out912;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out909, out _out910, out _out911, out _out912);
                    _1522_recursiveGen = _out909;
                    _1523_recOwned = _out910;
                    _1524_recErased = _out911;
                    _1525_recIdents = _out912;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1523_recOwned;
                    isErased = _1524_recErased;
                    readIdents = _1525_recIdents;
                  }
                } else if (_source53.is_Multiset) {
                  DAST._IType _1526___mcc_h857 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1527_recursiveGen;
                    bool _1528_recOwned;
                    bool _1529_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1530_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out913;
                    bool _out914;
                    bool _out915;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out916;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out913, out _out914, out _out915, out _out916);
                    _1527_recursiveGen = _out913;
                    _1528_recOwned = _out914;
                    _1529_recErased = _out915;
                    _1530_recIdents = _out916;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1528_recOwned;
                    isErased = _1529_recErased;
                    readIdents = _1530_recIdents;
                  }
                } else if (_source53.is_Map) {
                  DAST._IType _1531___mcc_h859 = _source53.dtor_key;
                  DAST._IType _1532___mcc_h860 = _source53.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1533_recursiveGen;
                    bool _1534_recOwned;
                    bool _1535_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1536_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out917;
                    bool _out918;
                    bool _out919;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out920;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out917, out _out918, out _out919, out _out920);
                    _1533_recursiveGen = _out917;
                    _1534_recOwned = _out918;
                    _1535_recErased = _out919;
                    _1536_recIdents = _out920;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1533_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1534_recOwned;
                    isErased = _1535_recErased;
                    readIdents = _1536_recIdents;
                  }
                } else if (_source53.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1537___mcc_h863 = _source53.dtor_args;
                  DAST._IType _1538___mcc_h864 = _source53.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1539_recursiveGen;
                    bool _1540_recOwned;
                    bool _1541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out921;
                    bool _out922;
                    bool _out923;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out924;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out921, out _out922, out _out923, out _out924);
                    _1539_recursiveGen = _out921;
                    _1540_recOwned = _out922;
                    _1541_recErased = _out923;
                    _1542_recIdents = _out924;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1540_recOwned;
                    isErased = _1541_recErased;
                    readIdents = _1542_recIdents;
                  }
                } else if (_source53.is_Primitive) {
                  DAST._IPrimitive _1543___mcc_h867 = _source53.dtor_Primitive_a0;
                  DAST._IPrimitive _source55 = _1543___mcc_h867;
                  if (_source55.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                      bool _1545_recOwned;
                      bool _1546_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out925;
                      bool _out926;
                      bool _out927;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out928;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out925, out _out926, out _out927, out _out928);
                      _1544_recursiveGen = _out925;
                      _1545_recOwned = _out926;
                      _1546_recErased = _out927;
                      _1547_recIdents = _out928;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1545_recOwned;
                      isErased = _1546_recErased;
                      readIdents = _1547_recIdents;
                    }
                  } else if (_source55.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1548_recursiveGen;
                      bool _1549___v48;
                      bool _1550___v49;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1551_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out929;
                      bool _out930;
                      bool _out931;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out932;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, true, out _out929, out _out930, out _out931, out _out932);
                      _1548_recursiveGen = _out929;
                      _1549___v48 = _out930;
                      _1550___v49 = _out931;
                      _1551_recIdents = _out932;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1548_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1551_recIdents;
                    }
                  } else if (_source55.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1552_recursiveGen;
                      bool _1553_recOwned;
                      bool _1554_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1555_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out933, out _out934, out _out935, out _out936);
                      _1552_recursiveGen = _out933;
                      _1553_recOwned = _out934;
                      _1554_recErased = _out935;
                      _1555_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1553_recOwned;
                      isErased = _1554_recErased;
                      readIdents = _1555_recIdents;
                    }
                  } else if (_source55.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1556_recursiveGen;
                      bool _1557_recOwned;
                      bool _1558_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1559_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out937;
                      bool _out938;
                      bool _out939;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out940;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out937, out _out938, out _out939, out _out940);
                      _1556_recursiveGen = _out937;
                      _1557_recOwned = _out938;
                      _1558_recErased = _out939;
                      _1559_recIdents = _out940;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1556_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1557_recOwned;
                      isErased = _1558_recErased;
                      readIdents = _1559_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1560_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out941;
                      _out941 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1560_rhsType = _out941;
                      Dafny.ISequence<Dafny.Rune> _1561_recursiveGen;
                      bool _1562___v58;
                      bool _1563___v59;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1564_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out942;
                      bool _out943;
                      bool _out944;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, true, out _out942, out _out943, out _out944, out _out945);
                      _1561_recursiveGen = _out942;
                      _1562___v58 = _out943;
                      _1563___v59 = _out944;
                      _1564_recIdents = _out945;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1561_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1564_recIdents;
                    }
                  }
                } else if (_source53.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1565___mcc_h869 = _source53.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1566_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out946;
                    _out946 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                    _1566_rhsType = _out946;
                    Dafny.ISequence<Dafny.Rune> _1567_recursiveGen;
                    bool _1568___v53;
                    bool _1569___v54;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1570_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out947;
                    bool _out948;
                    bool _out949;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out950;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, true, out _out947, out _out948, out _out949, out _out950);
                    _1567_recursiveGen = _out947;
                    _1568___v53 = _out948;
                    _1569___v54 = _out949;
                    _1570_recIdents = _out950;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1566_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1567_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1570_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1571___mcc_h871 = _source53.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1572_recursiveGen;
                    bool _1573_recOwned;
                    bool _1574_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1575_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out951;
                    bool _out952;
                    bool _out953;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out954;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out951, out _out952, out _out953, out _out954);
                    _1572_recursiveGen = _out951;
                    _1573_recOwned = _out952;
                    _1574_recErased = _out953;
                    _1575_recIdents = _out954;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1573_recOwned;
                    isErased = _1574_recErased;
                    readIdents = _1575_recIdents;
                  }
                }
              } else if (_source52.is_Real) {
                DAST._IType _source56 = _570___mcc_h278;
                if (_source56.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1576___mcc_h873 = _source56.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1577___mcc_h874 = _source56.dtor_typeArgs;
                  DAST._IResolvedType _1578___mcc_h875 = _source56.dtor_resolved;
                  DAST._IResolvedType _source57 = _1578___mcc_h875;
                  if (_source57.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1579___mcc_h879 = _source57.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1580_recursiveGen;
                      bool _1581_recOwned;
                      bool _1582_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1583_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out955;
                      bool _out956;
                      bool _out957;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out958;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out955, out _out956, out _out957, out _out958);
                      _1580_recursiveGen = _out955;
                      _1581_recOwned = _out956;
                      _1582_recErased = _out957;
                      _1583_recIdents = _out958;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1580_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1581_recOwned;
                      isErased = _1582_recErased;
                      readIdents = _1583_recIdents;
                    }
                  } else if (_source57.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1584___mcc_h881 = _source57.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1585_recursiveGen;
                      bool _1586_recOwned;
                      bool _1587_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1588_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out959;
                      bool _out960;
                      bool _out961;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                      _1585_recursiveGen = _out959;
                      _1586_recOwned = _out960;
                      _1587_recErased = _out961;
                      _1588_recIdents = _out962;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1585_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1586_recOwned;
                      isErased = _1587_recErased;
                      readIdents = _1588_recIdents;
                    }
                  } else {
                    DAST._IType _1589___mcc_h883 = _source57.dtor_Newtype_a0;
                    DAST._IType _1590_b = _1589___mcc_h883;
                    {
                      if (object.Equals(_563_fromTpe, _1590_b)) {
                        Dafny.ISequence<Dafny.Rune> _1591_recursiveGen;
                        bool _1592_recOwned;
                        bool _1593_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1594_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out963;
                        bool _out964;
                        bool _out965;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                        _1591_recursiveGen = _out963;
                        _1592_recOwned = _out964;
                        _1593_recErased = _out965;
                        _1594_recIdents = _out966;
                        Dafny.ISequence<Dafny.Rune> _1595_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out967;
                        _out967 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _1595_rhsType = _out967;
                        Dafny.ISequence<Dafny.Rune> _1596_uneraseFn;
                        _1596_uneraseFn = ((_1592_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1595_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1596_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1592_recOwned;
                        isErased = false;
                        readIdents = _1594_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out968;
                        bool _out969;
                        bool _out970;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out971;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1590_b), _1590_b, _562_toTpe), selfIdent, @params, mustOwn, out _out968, out _out969, out _out970, out _out971);
                        s = _out968;
                        isOwned = _out969;
                        isErased = _out970;
                        readIdents = _out971;
                      }
                    }
                  }
                } else if (_source56.is_Nullable) {
                  DAST._IType _1597___mcc_h885 = _source56.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1598_recursiveGen;
                    bool _1599_recOwned;
                    bool _1600_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1601_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out972;
                    bool _out973;
                    bool _out974;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out975;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out972, out _out973, out _out974, out _out975);
                    _1598_recursiveGen = _out972;
                    _1599_recOwned = _out973;
                    _1600_recErased = _out974;
                    _1601_recIdents = _out975;
                    if (!(_1599_recOwned)) {
                      _1598_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1598_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1598_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1600_recErased;
                    readIdents = _1601_recIdents;
                  }
                } else if (_source56.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1602___mcc_h887 = _source56.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1603_recursiveGen;
                    bool _1604_recOwned;
                    bool _1605_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1606_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out976;
                    bool _out977;
                    bool _out978;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out979;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out976, out _out977, out _out978, out _out979);
                    _1603_recursiveGen = _out976;
                    _1604_recOwned = _out977;
                    _1605_recErased = _out978;
                    _1606_recIdents = _out979;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1604_recOwned;
                    isErased = _1605_recErased;
                    readIdents = _1606_recIdents;
                  }
                } else if (_source56.is_Array) {
                  DAST._IType _1607___mcc_h889 = _source56.dtor_element;
                  BigInteger _1608___mcc_h890 = _source56.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                    bool _1610_recOwned;
                    bool _1611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out980;
                    bool _out981;
                    bool _out982;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out983;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out980, out _out981, out _out982, out _out983);
                    _1609_recursiveGen = _out980;
                    _1610_recOwned = _out981;
                    _1611_recErased = _out982;
                    _1612_recIdents = _out983;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1610_recOwned;
                    isErased = _1611_recErased;
                    readIdents = _1612_recIdents;
                  }
                } else if (_source56.is_Seq) {
                  DAST._IType _1613___mcc_h893 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1614_recursiveGen;
                    bool _1615_recOwned;
                    bool _1616_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out984;
                    bool _out985;
                    bool _out986;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out987;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out984, out _out985, out _out986, out _out987);
                    _1614_recursiveGen = _out984;
                    _1615_recOwned = _out985;
                    _1616_recErased = _out986;
                    _1617_recIdents = _out987;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1615_recOwned;
                    isErased = _1616_recErased;
                    readIdents = _1617_recIdents;
                  }
                } else if (_source56.is_Set) {
                  DAST._IType _1618___mcc_h895 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1619_recursiveGen;
                    bool _1620_recOwned;
                    bool _1621_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1622_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out988;
                    bool _out989;
                    bool _out990;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out991;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out988, out _out989, out _out990, out _out991);
                    _1619_recursiveGen = _out988;
                    _1620_recOwned = _out989;
                    _1621_recErased = _out990;
                    _1622_recIdents = _out991;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1619_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1620_recOwned;
                    isErased = _1621_recErased;
                    readIdents = _1622_recIdents;
                  }
                } else if (_source56.is_Multiset) {
                  DAST._IType _1623___mcc_h897 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1624_recursiveGen;
                    bool _1625_recOwned;
                    bool _1626_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1627_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out992;
                    bool _out993;
                    bool _out994;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out995;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out992, out _out993, out _out994, out _out995);
                    _1624_recursiveGen = _out992;
                    _1625_recOwned = _out993;
                    _1626_recErased = _out994;
                    _1627_recIdents = _out995;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1624_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1625_recOwned;
                    isErased = _1626_recErased;
                    readIdents = _1627_recIdents;
                  }
                } else if (_source56.is_Map) {
                  DAST._IType _1628___mcc_h899 = _source56.dtor_key;
                  DAST._IType _1629___mcc_h900 = _source56.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1630_recursiveGen;
                    bool _1631_recOwned;
                    bool _1632_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1633_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out996;
                    bool _out997;
                    bool _out998;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out999;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out996, out _out997, out _out998, out _out999);
                    _1630_recursiveGen = _out996;
                    _1631_recOwned = _out997;
                    _1632_recErased = _out998;
                    _1633_recIdents = _out999;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1631_recOwned;
                    isErased = _1632_recErased;
                    readIdents = _1633_recIdents;
                  }
                } else if (_source56.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1634___mcc_h903 = _source56.dtor_args;
                  DAST._IType _1635___mcc_h904 = _source56.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1636_recursiveGen;
                    bool _1637_recOwned;
                    bool _1638_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1639_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1000;
                    bool _out1001;
                    bool _out1002;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1003;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1000, out _out1001, out _out1002, out _out1003);
                    _1636_recursiveGen = _out1000;
                    _1637_recOwned = _out1001;
                    _1638_recErased = _out1002;
                    _1639_recIdents = _out1003;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1637_recOwned;
                    isErased = _1638_recErased;
                    readIdents = _1639_recIdents;
                  }
                } else if (_source56.is_Primitive) {
                  DAST._IPrimitive _1640___mcc_h907 = _source56.dtor_Primitive_a0;
                  DAST._IPrimitive _source58 = _1640___mcc_h907;
                  if (_source58.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1641_recursiveGen;
                      bool _1642___v50;
                      bool _1643___v51;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1644_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1004;
                      bool _out1005;
                      bool _out1006;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1007;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, false, out _out1004, out _out1005, out _out1006, out _out1007);
                      _1641_recursiveGen = _out1004;
                      _1642___v50 = _out1005;
                      _1643___v51 = _out1006;
                      _1644_recIdents = _out1007;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1641_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1644_recIdents;
                    }
                  } else if (_source58.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1645_recursiveGen;
                      bool _1646_recOwned;
                      bool _1647_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1648_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1008;
                      bool _out1009;
                      bool _out1010;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1011;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1008, out _out1009, out _out1010, out _out1011);
                      _1645_recursiveGen = _out1008;
                      _1646_recOwned = _out1009;
                      _1647_recErased = _out1010;
                      _1648_recIdents = _out1011;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1646_recOwned;
                      isErased = _1647_recErased;
                      readIdents = _1648_recIdents;
                    }
                  } else if (_source58.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1649_recursiveGen;
                      bool _1650_recOwned;
                      bool _1651_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1652_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1012;
                      bool _out1013;
                      bool _out1014;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1015;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1012, out _out1013, out _out1014, out _out1015);
                      _1649_recursiveGen = _out1012;
                      _1650_recOwned = _out1013;
                      _1651_recErased = _out1014;
                      _1652_recIdents = _out1015;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1649_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1650_recOwned;
                      isErased = _1651_recErased;
                      readIdents = _1652_recIdents;
                    }
                  } else if (_source58.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1653_recursiveGen;
                      bool _1654_recOwned;
                      bool _1655_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1656_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1016;
                      bool _out1017;
                      bool _out1018;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1019;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1016, out _out1017, out _out1018, out _out1019);
                      _1653_recursiveGen = _out1016;
                      _1654_recOwned = _out1017;
                      _1655_recErased = _out1018;
                      _1656_recIdents = _out1019;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1654_recOwned;
                      isErased = _1655_recErased;
                      readIdents = _1656_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1657_recursiveGen;
                      bool _1658_recOwned;
                      bool _1659_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1660_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1020;
                      bool _out1021;
                      bool _out1022;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1023;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1020, out _out1021, out _out1022, out _out1023);
                      _1657_recursiveGen = _out1020;
                      _1658_recOwned = _out1021;
                      _1659_recErased = _out1022;
                      _1660_recIdents = _out1023;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1657_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1658_recOwned;
                      isErased = _1659_recErased;
                      readIdents = _1660_recIdents;
                    }
                  }
                } else if (_source56.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1661___mcc_h909 = _source56.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1662_recursiveGen;
                    bool _1663_recOwned;
                    bool _1664_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1665_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1024;
                    bool _out1025;
                    bool _out1026;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1027;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1024, out _out1025, out _out1026, out _out1027);
                    _1662_recursiveGen = _out1024;
                    _1663_recOwned = _out1025;
                    _1664_recErased = _out1026;
                    _1665_recIdents = _out1027;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1663_recOwned;
                    isErased = _1664_recErased;
                    readIdents = _1665_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1666___mcc_h911 = _source56.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1667_recursiveGen;
                    bool _1668_recOwned;
                    bool _1669_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1670_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1028;
                    bool _out1029;
                    bool _out1030;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1031;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1028, out _out1029, out _out1030, out _out1031);
                    _1667_recursiveGen = _out1028;
                    _1668_recOwned = _out1029;
                    _1669_recErased = _out1030;
                    _1670_recIdents = _out1031;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1668_recOwned;
                    isErased = _1669_recErased;
                    readIdents = _1670_recIdents;
                  }
                }
              } else if (_source52.is_String) {
                DAST._IType _source59 = _570___mcc_h278;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1671___mcc_h913 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1672___mcc_h914 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1673___mcc_h915 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1673___mcc_h915;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1674___mcc_h919 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1675_recursiveGen;
                      bool _1676_recOwned;
                      bool _1677_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1678_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1032;
                      bool _out1033;
                      bool _out1034;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1035;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1032, out _out1033, out _out1034, out _out1035);
                      _1675_recursiveGen = _out1032;
                      _1676_recOwned = _out1033;
                      _1677_recErased = _out1034;
                      _1678_recIdents = _out1035;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1676_recOwned;
                      isErased = _1677_recErased;
                      readIdents = _1678_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1679___mcc_h921 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1680_recursiveGen;
                      bool _1681_recOwned;
                      bool _1682_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1036;
                      bool _out1037;
                      bool _out1038;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                      _1680_recursiveGen = _out1036;
                      _1681_recOwned = _out1037;
                      _1682_recErased = _out1038;
                      _1683_recIdents = _out1039;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1681_recOwned;
                      isErased = _1682_recErased;
                      readIdents = _1683_recIdents;
                    }
                  } else {
                    DAST._IType _1684___mcc_h923 = _source60.dtor_Newtype_a0;
                    DAST._IType _1685_b = _1684___mcc_h923;
                    {
                      if (object.Equals(_563_fromTpe, _1685_b)) {
                        Dafny.ISequence<Dafny.Rune> _1686_recursiveGen;
                        bool _1687_recOwned;
                        bool _1688_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1689_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1040;
                        bool _out1041;
                        bool _out1042;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                        _1686_recursiveGen = _out1040;
                        _1687_recOwned = _out1041;
                        _1688_recErased = _out1042;
                        _1689_recIdents = _out1043;
                        Dafny.ISequence<Dafny.Rune> _1690_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1044;
                        _out1044 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _1690_rhsType = _out1044;
                        Dafny.ISequence<Dafny.Rune> _1691_uneraseFn;
                        _1691_uneraseFn = ((_1687_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1690_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1691_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1686_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1687_recOwned;
                        isErased = false;
                        readIdents = _1689_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1045;
                        bool _out1046;
                        bool _out1047;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1048;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1685_b), _1685_b, _562_toTpe), selfIdent, @params, mustOwn, out _out1045, out _out1046, out _out1047, out _out1048);
                        s = _out1045;
                        isOwned = _out1046;
                        isErased = _out1047;
                        readIdents = _out1048;
                      }
                    }
                  }
                } else if (_source59.is_Nullable) {
                  DAST._IType _1692___mcc_h925 = _source59.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1693_recursiveGen;
                    bool _1694_recOwned;
                    bool _1695_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1696_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1049;
                    bool _out1050;
                    bool _out1051;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1052;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1049, out _out1050, out _out1051, out _out1052);
                    _1693_recursiveGen = _out1049;
                    _1694_recOwned = _out1050;
                    _1695_recErased = _out1051;
                    _1696_recIdents = _out1052;
                    if (!(_1694_recOwned)) {
                      _1693_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1693_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1693_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1695_recErased;
                    readIdents = _1696_recIdents;
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1697___mcc_h927 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1698_recursiveGen;
                    bool _1699_recOwned;
                    bool _1700_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1701_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1053;
                    bool _out1054;
                    bool _out1055;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1056;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1053, out _out1054, out _out1055, out _out1056);
                    _1698_recursiveGen = _out1053;
                    _1699_recOwned = _out1054;
                    _1700_recErased = _out1055;
                    _1701_recIdents = _out1056;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1699_recOwned;
                    isErased = _1700_recErased;
                    readIdents = _1701_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1702___mcc_h929 = _source59.dtor_element;
                  BigInteger _1703___mcc_h930 = _source59.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1704_recursiveGen;
                    bool _1705_recOwned;
                    bool _1706_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1707_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1057;
                    bool _out1058;
                    bool _out1059;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1060;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1057, out _out1058, out _out1059, out _out1060);
                    _1704_recursiveGen = _out1057;
                    _1705_recOwned = _out1058;
                    _1706_recErased = _out1059;
                    _1707_recIdents = _out1060;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1704_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1705_recOwned;
                    isErased = _1706_recErased;
                    readIdents = _1707_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1708___mcc_h933 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1709_recursiveGen;
                    bool _1710_recOwned;
                    bool _1711_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1712_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1061;
                    bool _out1062;
                    bool _out1063;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1064;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1061, out _out1062, out _out1063, out _out1064);
                    _1709_recursiveGen = _out1061;
                    _1710_recOwned = _out1062;
                    _1711_recErased = _out1063;
                    _1712_recIdents = _out1064;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1710_recOwned;
                    isErased = _1711_recErased;
                    readIdents = _1712_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1713___mcc_h935 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1714_recursiveGen;
                    bool _1715_recOwned;
                    bool _1716_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1717_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1065;
                    bool _out1066;
                    bool _out1067;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1068;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1065, out _out1066, out _out1067, out _out1068);
                    _1714_recursiveGen = _out1065;
                    _1715_recOwned = _out1066;
                    _1716_recErased = _out1067;
                    _1717_recIdents = _out1068;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1715_recOwned;
                    isErased = _1716_recErased;
                    readIdents = _1717_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1718___mcc_h937 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1719_recursiveGen;
                    bool _1720_recOwned;
                    bool _1721_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1722_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1069;
                    bool _out1070;
                    bool _out1071;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1072;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1069, out _out1070, out _out1071, out _out1072);
                    _1719_recursiveGen = _out1069;
                    _1720_recOwned = _out1070;
                    _1721_recErased = _out1071;
                    _1722_recIdents = _out1072;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1719_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1720_recOwned;
                    isErased = _1721_recErased;
                    readIdents = _1722_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1723___mcc_h939 = _source59.dtor_key;
                  DAST._IType _1724___mcc_h940 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1725_recursiveGen;
                    bool _1726_recOwned;
                    bool _1727_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1728_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1073;
                    bool _out1074;
                    bool _out1075;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1076;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1073, out _out1074, out _out1075, out _out1076);
                    _1725_recursiveGen = _out1073;
                    _1726_recOwned = _out1074;
                    _1727_recErased = _out1075;
                    _1728_recIdents = _out1076;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1726_recOwned;
                    isErased = _1727_recErased;
                    readIdents = _1728_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1729___mcc_h943 = _source59.dtor_args;
                  DAST._IType _1730___mcc_h944 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1731_recursiveGen;
                    bool _1732_recOwned;
                    bool _1733_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1734_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1077;
                    bool _out1078;
                    bool _out1079;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1080;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1077, out _out1078, out _out1079, out _out1080);
                    _1731_recursiveGen = _out1077;
                    _1732_recOwned = _out1078;
                    _1733_recErased = _out1079;
                    _1734_recIdents = _out1080;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1731_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1732_recOwned;
                    isErased = _1733_recErased;
                    readIdents = _1734_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1735___mcc_h947 = _source59.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1736_recursiveGen;
                    bool _1737_recOwned;
                    bool _1738_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1739_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1081;
                    bool _out1082;
                    bool _out1083;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1084;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1081, out _out1082, out _out1083, out _out1084);
                    _1736_recursiveGen = _out1081;
                    _1737_recOwned = _out1082;
                    _1738_recErased = _out1083;
                    _1739_recIdents = _out1084;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1736_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1737_recOwned;
                    isErased = _1738_recErased;
                    readIdents = _1739_recIdents;
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1740___mcc_h949 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1741_recursiveGen;
                    bool _1742_recOwned;
                    bool _1743_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1744_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1085;
                    bool _out1086;
                    bool _out1087;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1088;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1085, out _out1086, out _out1087, out _out1088);
                    _1741_recursiveGen = _out1085;
                    _1742_recOwned = _out1086;
                    _1743_recErased = _out1087;
                    _1744_recIdents = _out1088;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1742_recOwned;
                    isErased = _1743_recErased;
                    readIdents = _1744_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1745___mcc_h951 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1746_recursiveGen;
                    bool _1747_recOwned;
                    bool _1748_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1749_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1089;
                    bool _out1090;
                    bool _out1091;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1092;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1089, out _out1090, out _out1091, out _out1092);
                    _1746_recursiveGen = _out1089;
                    _1747_recOwned = _out1090;
                    _1748_recErased = _out1091;
                    _1749_recIdents = _out1092;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1747_recOwned;
                    isErased = _1748_recErased;
                    readIdents = _1749_recIdents;
                  }
                }
              } else if (_source52.is_Bool) {
                DAST._IType _source61 = _570___mcc_h278;
                if (_source61.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1750___mcc_h953 = _source61.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1751___mcc_h954 = _source61.dtor_typeArgs;
                  DAST._IResolvedType _1752___mcc_h955 = _source61.dtor_resolved;
                  DAST._IResolvedType _source62 = _1752___mcc_h955;
                  if (_source62.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1753___mcc_h959 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1754_recursiveGen;
                      bool _1755_recOwned;
                      bool _1756_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1757_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1093;
                      bool _out1094;
                      bool _out1095;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1096;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1093, out _out1094, out _out1095, out _out1096);
                      _1754_recursiveGen = _out1093;
                      _1755_recOwned = _out1094;
                      _1756_recErased = _out1095;
                      _1757_recIdents = _out1096;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1755_recOwned;
                      isErased = _1756_recErased;
                      readIdents = _1757_recIdents;
                    }
                  } else if (_source62.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1758___mcc_h961 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1759_recursiveGen;
                      bool _1760_recOwned;
                      bool _1761_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1762_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1097;
                      bool _out1098;
                      bool _out1099;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                      _1759_recursiveGen = _out1097;
                      _1760_recOwned = _out1098;
                      _1761_recErased = _out1099;
                      _1762_recIdents = _out1100;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1760_recOwned;
                      isErased = _1761_recErased;
                      readIdents = _1762_recIdents;
                    }
                  } else {
                    DAST._IType _1763___mcc_h963 = _source62.dtor_Newtype_a0;
                    DAST._IType _1764_b = _1763___mcc_h963;
                    {
                      if (object.Equals(_563_fromTpe, _1764_b)) {
                        Dafny.ISequence<Dafny.Rune> _1765_recursiveGen;
                        bool _1766_recOwned;
                        bool _1767_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1768_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1101;
                        bool _out1102;
                        bool _out1103;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                        _1765_recursiveGen = _out1101;
                        _1766_recOwned = _out1102;
                        _1767_recErased = _out1103;
                        _1768_recIdents = _out1104;
                        Dafny.ISequence<Dafny.Rune> _1769_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1105;
                        _out1105 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _1769_rhsType = _out1105;
                        Dafny.ISequence<Dafny.Rune> _1770_uneraseFn;
                        _1770_uneraseFn = ((_1766_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1769_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1770_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1765_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1766_recOwned;
                        isErased = false;
                        readIdents = _1768_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1106;
                        bool _out1107;
                        bool _out1108;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1109;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1764_b), _1764_b, _562_toTpe), selfIdent, @params, mustOwn, out _out1106, out _out1107, out _out1108, out _out1109);
                        s = _out1106;
                        isOwned = _out1107;
                        isErased = _out1108;
                        readIdents = _out1109;
                      }
                    }
                  }
                } else if (_source61.is_Nullable) {
                  DAST._IType _1771___mcc_h965 = _source61.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1772_recursiveGen;
                    bool _1773_recOwned;
                    bool _1774_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1775_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1110;
                    bool _out1111;
                    bool _out1112;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1113;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1110, out _out1111, out _out1112, out _out1113);
                    _1772_recursiveGen = _out1110;
                    _1773_recOwned = _out1111;
                    _1774_recErased = _out1112;
                    _1775_recIdents = _out1113;
                    if (!(_1773_recOwned)) {
                      _1772_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1772_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1772_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1774_recErased;
                    readIdents = _1775_recIdents;
                  }
                } else if (_source61.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1776___mcc_h967 = _source61.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1777_recursiveGen;
                    bool _1778_recOwned;
                    bool _1779_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1780_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1114;
                    bool _out1115;
                    bool _out1116;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1117;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1114, out _out1115, out _out1116, out _out1117);
                    _1777_recursiveGen = _out1114;
                    _1778_recOwned = _out1115;
                    _1779_recErased = _out1116;
                    _1780_recIdents = _out1117;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1778_recOwned;
                    isErased = _1779_recErased;
                    readIdents = _1780_recIdents;
                  }
                } else if (_source61.is_Array) {
                  DAST._IType _1781___mcc_h969 = _source61.dtor_element;
                  BigInteger _1782___mcc_h970 = _source61.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1783_recursiveGen;
                    bool _1784_recOwned;
                    bool _1785_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1786_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1118;
                    bool _out1119;
                    bool _out1120;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1121;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1118, out _out1119, out _out1120, out _out1121);
                    _1783_recursiveGen = _out1118;
                    _1784_recOwned = _out1119;
                    _1785_recErased = _out1120;
                    _1786_recIdents = _out1121;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1783_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1784_recOwned;
                    isErased = _1785_recErased;
                    readIdents = _1786_recIdents;
                  }
                } else if (_source61.is_Seq) {
                  DAST._IType _1787___mcc_h973 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1788_recursiveGen;
                    bool _1789_recOwned;
                    bool _1790_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1791_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1122;
                    bool _out1123;
                    bool _out1124;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1125;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1122, out _out1123, out _out1124, out _out1125);
                    _1788_recursiveGen = _out1122;
                    _1789_recOwned = _out1123;
                    _1790_recErased = _out1124;
                    _1791_recIdents = _out1125;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1788_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1789_recOwned;
                    isErased = _1790_recErased;
                    readIdents = _1791_recIdents;
                  }
                } else if (_source61.is_Set) {
                  DAST._IType _1792___mcc_h975 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1793_recursiveGen;
                    bool _1794_recOwned;
                    bool _1795_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1796_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1126;
                    bool _out1127;
                    bool _out1128;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1129;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1126, out _out1127, out _out1128, out _out1129);
                    _1793_recursiveGen = _out1126;
                    _1794_recOwned = _out1127;
                    _1795_recErased = _out1128;
                    _1796_recIdents = _out1129;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1793_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1794_recOwned;
                    isErased = _1795_recErased;
                    readIdents = _1796_recIdents;
                  }
                } else if (_source61.is_Multiset) {
                  DAST._IType _1797___mcc_h977 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1798_recursiveGen;
                    bool _1799_recOwned;
                    bool _1800_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1801_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1130;
                    bool _out1131;
                    bool _out1132;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1133;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1130, out _out1131, out _out1132, out _out1133);
                    _1798_recursiveGen = _out1130;
                    _1799_recOwned = _out1131;
                    _1800_recErased = _out1132;
                    _1801_recIdents = _out1133;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1798_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1799_recOwned;
                    isErased = _1800_recErased;
                    readIdents = _1801_recIdents;
                  }
                } else if (_source61.is_Map) {
                  DAST._IType _1802___mcc_h979 = _source61.dtor_key;
                  DAST._IType _1803___mcc_h980 = _source61.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1804_recursiveGen;
                    bool _1805_recOwned;
                    bool _1806_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1807_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1134;
                    bool _out1135;
                    bool _out1136;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1137;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1134, out _out1135, out _out1136, out _out1137);
                    _1804_recursiveGen = _out1134;
                    _1805_recOwned = _out1135;
                    _1806_recErased = _out1136;
                    _1807_recIdents = _out1137;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1804_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1805_recOwned;
                    isErased = _1806_recErased;
                    readIdents = _1807_recIdents;
                  }
                } else if (_source61.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1808___mcc_h983 = _source61.dtor_args;
                  DAST._IType _1809___mcc_h984 = _source61.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1810_recursiveGen;
                    bool _1811_recOwned;
                    bool _1812_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1813_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1138;
                    bool _out1139;
                    bool _out1140;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1141;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1138, out _out1139, out _out1140, out _out1141);
                    _1810_recursiveGen = _out1138;
                    _1811_recOwned = _out1139;
                    _1812_recErased = _out1140;
                    _1813_recIdents = _out1141;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1810_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1811_recOwned;
                    isErased = _1812_recErased;
                    readIdents = _1813_recIdents;
                  }
                } else if (_source61.is_Primitive) {
                  DAST._IPrimitive _1814___mcc_h987 = _source61.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1815_recursiveGen;
                    bool _1816_recOwned;
                    bool _1817_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1818_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1142;
                    bool _out1143;
                    bool _out1144;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1145;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1142, out _out1143, out _out1144, out _out1145);
                    _1815_recursiveGen = _out1142;
                    _1816_recOwned = _out1143;
                    _1817_recErased = _out1144;
                    _1818_recIdents = _out1145;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1815_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1816_recOwned;
                    isErased = _1817_recErased;
                    readIdents = _1818_recIdents;
                  }
                } else if (_source61.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1819___mcc_h989 = _source61.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1820_recursiveGen;
                    bool _1821_recOwned;
                    bool _1822_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1823_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1146;
                    bool _out1147;
                    bool _out1148;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1149;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1146, out _out1147, out _out1148, out _out1149);
                    _1820_recursiveGen = _out1146;
                    _1821_recOwned = _out1147;
                    _1822_recErased = _out1148;
                    _1823_recIdents = _out1149;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1820_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1821_recOwned;
                    isErased = _1822_recErased;
                    readIdents = _1823_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1824___mcc_h991 = _source61.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1825_recursiveGen;
                    bool _1826_recOwned;
                    bool _1827_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1828_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1150;
                    bool _out1151;
                    bool _out1152;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1150, out _out1151, out _out1152, out _out1153);
                    _1825_recursiveGen = _out1150;
                    _1826_recOwned = _out1151;
                    _1827_recErased = _out1152;
                    _1828_recIdents = _out1153;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1825_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1826_recOwned;
                    isErased = _1827_recErased;
                    readIdents = _1828_recIdents;
                  }
                }
              } else {
                DAST._IType _source63 = _570___mcc_h278;
                if (_source63.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1829___mcc_h993 = _source63.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1830___mcc_h994 = _source63.dtor_typeArgs;
                  DAST._IResolvedType _1831___mcc_h995 = _source63.dtor_resolved;
                  DAST._IResolvedType _source64 = _1831___mcc_h995;
                  if (_source64.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1832___mcc_h999 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1833_recursiveGen;
                      bool _1834_recOwned;
                      bool _1835_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1836_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1154;
                      bool _out1155;
                      bool _out1156;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                      _1833_recursiveGen = _out1154;
                      _1834_recOwned = _out1155;
                      _1835_recErased = _out1156;
                      _1836_recIdents = _out1157;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1833_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1834_recOwned;
                      isErased = _1835_recErased;
                      readIdents = _1836_recIdents;
                    }
                  } else if (_source64.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1837___mcc_h1001 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1838_recursiveGen;
                      bool _1839_recOwned;
                      bool _1840_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1841_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1158;
                      bool _out1159;
                      bool _out1160;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                      _1838_recursiveGen = _out1158;
                      _1839_recOwned = _out1159;
                      _1840_recErased = _out1160;
                      _1841_recIdents = _out1161;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1838_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1839_recOwned;
                      isErased = _1840_recErased;
                      readIdents = _1841_recIdents;
                    }
                  } else {
                    DAST._IType _1842___mcc_h1003 = _source64.dtor_Newtype_a0;
                    DAST._IType _1843_b = _1842___mcc_h1003;
                    {
                      if (object.Equals(_563_fromTpe, _1843_b)) {
                        Dafny.ISequence<Dafny.Rune> _1844_recursiveGen;
                        bool _1845_recOwned;
                        bool _1846_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1847_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1162;
                        bool _out1163;
                        bool _out1164;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                        DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                        _1844_recursiveGen = _out1162;
                        _1845_recOwned = _out1163;
                        _1846_recErased = _out1164;
                        _1847_recIdents = _out1165;
                        Dafny.ISequence<Dafny.Rune> _1848_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1166;
                        _out1166 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                        _1848_rhsType = _out1166;
                        Dafny.ISequence<Dafny.Rune> _1849_uneraseFn;
                        _1849_uneraseFn = ((_1845_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1848_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1849_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1844_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1845_recOwned;
                        isErased = false;
                        readIdents = _1847_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1167;
                        bool _out1168;
                        bool _out1169;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1170;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1843_b), _1843_b, _562_toTpe), selfIdent, @params, mustOwn, out _out1167, out _out1168, out _out1169, out _out1170);
                        s = _out1167;
                        isOwned = _out1168;
                        isErased = _out1169;
                        readIdents = _out1170;
                      }
                    }
                  }
                } else if (_source63.is_Nullable) {
                  DAST._IType _1850___mcc_h1005 = _source63.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1851_recursiveGen;
                    bool _1852_recOwned;
                    bool _1853_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1854_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1171;
                    bool _out1172;
                    bool _out1173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1174;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1171, out _out1172, out _out1173, out _out1174);
                    _1851_recursiveGen = _out1171;
                    _1852_recOwned = _out1172;
                    _1853_recErased = _out1173;
                    _1854_recIdents = _out1174;
                    if (!(_1852_recOwned)) {
                      _1851_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1851_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1851_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1853_recErased;
                    readIdents = _1854_recIdents;
                  }
                } else if (_source63.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1855___mcc_h1007 = _source63.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1856_recursiveGen;
                    bool _1857_recOwned;
                    bool _1858_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1859_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1175;
                    bool _out1176;
                    bool _out1177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1178;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1175, out _out1176, out _out1177, out _out1178);
                    _1856_recursiveGen = _out1175;
                    _1857_recOwned = _out1176;
                    _1858_recErased = _out1177;
                    _1859_recIdents = _out1178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1856_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1857_recOwned;
                    isErased = _1858_recErased;
                    readIdents = _1859_recIdents;
                  }
                } else if (_source63.is_Array) {
                  DAST._IType _1860___mcc_h1009 = _source63.dtor_element;
                  BigInteger _1861___mcc_h1010 = _source63.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1862_recursiveGen;
                    bool _1863_recOwned;
                    bool _1864_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1865_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1179;
                    bool _out1180;
                    bool _out1181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1182;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1179, out _out1180, out _out1181, out _out1182);
                    _1862_recursiveGen = _out1179;
                    _1863_recOwned = _out1180;
                    _1864_recErased = _out1181;
                    _1865_recIdents = _out1182;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1862_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1863_recOwned;
                    isErased = _1864_recErased;
                    readIdents = _1865_recIdents;
                  }
                } else if (_source63.is_Seq) {
                  DAST._IType _1866___mcc_h1013 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1867_recursiveGen;
                    bool _1868_recOwned;
                    bool _1869_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1870_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1183;
                    bool _out1184;
                    bool _out1185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1186;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1183, out _out1184, out _out1185, out _out1186);
                    _1867_recursiveGen = _out1183;
                    _1868_recOwned = _out1184;
                    _1869_recErased = _out1185;
                    _1870_recIdents = _out1186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1867_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1868_recOwned;
                    isErased = _1869_recErased;
                    readIdents = _1870_recIdents;
                  }
                } else if (_source63.is_Set) {
                  DAST._IType _1871___mcc_h1015 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1872_recursiveGen;
                    bool _1873_recOwned;
                    bool _1874_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1875_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1187;
                    bool _out1188;
                    bool _out1189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1190;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1187, out _out1188, out _out1189, out _out1190);
                    _1872_recursiveGen = _out1187;
                    _1873_recOwned = _out1188;
                    _1874_recErased = _out1189;
                    _1875_recIdents = _out1190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1872_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1873_recOwned;
                    isErased = _1874_recErased;
                    readIdents = _1875_recIdents;
                  }
                } else if (_source63.is_Multiset) {
                  DAST._IType _1876___mcc_h1017 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1877_recursiveGen;
                    bool _1878_recOwned;
                    bool _1879_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1880_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1191;
                    bool _out1192;
                    bool _out1193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1194;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1191, out _out1192, out _out1193, out _out1194);
                    _1877_recursiveGen = _out1191;
                    _1878_recOwned = _out1192;
                    _1879_recErased = _out1193;
                    _1880_recIdents = _out1194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1877_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1878_recOwned;
                    isErased = _1879_recErased;
                    readIdents = _1880_recIdents;
                  }
                } else if (_source63.is_Map) {
                  DAST._IType _1881___mcc_h1019 = _source63.dtor_key;
                  DAST._IType _1882___mcc_h1020 = _source63.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1883_recursiveGen;
                    bool _1884_recOwned;
                    bool _1885_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1886_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1195;
                    bool _out1196;
                    bool _out1197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1195, out _out1196, out _out1197, out _out1198);
                    _1883_recursiveGen = _out1195;
                    _1884_recOwned = _out1196;
                    _1885_recErased = _out1197;
                    _1886_recIdents = _out1198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1884_recOwned;
                    isErased = _1885_recErased;
                    readIdents = _1886_recIdents;
                  }
                } else if (_source63.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1887___mcc_h1023 = _source63.dtor_args;
                  DAST._IType _1888___mcc_h1024 = _source63.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1889_recursiveGen;
                    bool _1890_recOwned;
                    bool _1891_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1892_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1199;
                    bool _out1200;
                    bool _out1201;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                    _1889_recursiveGen = _out1199;
                    _1890_recOwned = _out1200;
                    _1891_recErased = _out1201;
                    _1892_recIdents = _out1202;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1889_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1890_recOwned;
                    isErased = _1891_recErased;
                    readIdents = _1892_recIdents;
                  }
                } else if (_source63.is_Primitive) {
                  DAST._IPrimitive _1893___mcc_h1027 = _source63.dtor_Primitive_a0;
                  DAST._IPrimitive _source65 = _1893___mcc_h1027;
                  if (_source65.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1894_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      _out1203 = DCOMP.COMP.GenType(_563_fromTpe, true, false);
                      _1894_rhsType = _out1203;
                      Dafny.ISequence<Dafny.Rune> _1895_recursiveGen;
                      bool _1896___v60;
                      bool _1897___v61;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1898_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1204;
                      bool _out1205;
                      bool _out1206;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1207;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, true, out _out1204, out _out1205, out _out1206, out _out1207);
                      _1895_recursiveGen = _out1204;
                      _1896___v60 = _out1205;
                      _1897___v61 = _out1206;
                      _1898_recIdents = _out1207;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1895_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1898_recIdents;
                    }
                  } else if (_source65.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1899_recursiveGen;
                      bool _1900_recOwned;
                      bool _1901_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1902_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1208;
                      bool _out1209;
                      bool _out1210;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1211;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1208, out _out1209, out _out1210, out _out1211);
                      _1899_recursiveGen = _out1208;
                      _1900_recOwned = _out1209;
                      _1901_recErased = _out1210;
                      _1902_recIdents = _out1211;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1899_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1900_recOwned;
                      isErased = _1901_recErased;
                      readIdents = _1902_recIdents;
                    }
                  } else if (_source65.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1903_recursiveGen;
                      bool _1904_recOwned;
                      bool _1905_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1906_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1212;
                      bool _out1213;
                      bool _out1214;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1215;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1212, out _out1213, out _out1214, out _out1215);
                      _1903_recursiveGen = _out1212;
                      _1904_recOwned = _out1213;
                      _1905_recErased = _out1214;
                      _1906_recIdents = _out1215;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1903_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1904_recOwned;
                      isErased = _1905_recErased;
                      readIdents = _1906_recIdents;
                    }
                  } else if (_source65.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1907_recursiveGen;
                      bool _1908_recOwned;
                      bool _1909_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1910_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1216;
                      bool _out1217;
                      bool _out1218;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1219;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1216, out _out1217, out _out1218, out _out1219);
                      _1907_recursiveGen = _out1216;
                      _1908_recOwned = _out1217;
                      _1909_recErased = _out1218;
                      _1910_recIdents = _out1219;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1907_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1908_recOwned;
                      isErased = _1909_recErased;
                      readIdents = _1910_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1911_recursiveGen;
                      bool _1912_recOwned;
                      bool _1913_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1914_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1220;
                      bool _out1221;
                      bool _out1222;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1223;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1220, out _out1221, out _out1222, out _out1223);
                      _1911_recursiveGen = _out1220;
                      _1912_recOwned = _out1221;
                      _1913_recErased = _out1222;
                      _1914_recIdents = _out1223;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1911_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1912_recOwned;
                      isErased = _1913_recErased;
                      readIdents = _1914_recIdents;
                    }
                  }
                } else if (_source63.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1915___mcc_h1029 = _source63.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1916_recursiveGen;
                    bool _1917_recOwned;
                    bool _1918_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1919_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1224;
                    bool _out1225;
                    bool _out1226;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1227;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1224, out _out1225, out _out1226, out _out1227);
                    _1916_recursiveGen = _out1224;
                    _1917_recOwned = _out1225;
                    _1918_recErased = _out1226;
                    _1919_recIdents = _out1227;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1916_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1917_recOwned;
                    isErased = _1918_recErased;
                    readIdents = _1919_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1920___mcc_h1031 = _source63.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1921_recursiveGen;
                    bool _1922_recOwned;
                    bool _1923_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1924_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1228;
                    bool _out1229;
                    bool _out1230;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1228, out _out1229, out _out1230, out _out1231);
                    _1921_recursiveGen = _out1228;
                    _1922_recOwned = _out1229;
                    _1923_recErased = _out1230;
                    _1924_recIdents = _out1231;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1921_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1922_recOwned;
                    isErased = _1923_recErased;
                    readIdents = _1924_recIdents;
                  }
                }
              }
            } else if (_source28.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1925___mcc_h1033 = _source28.dtor_Passthrough_a0;
              DAST._IType _source66 = _570___mcc_h278;
              if (_source66.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1926___mcc_h1037 = _source66.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1927___mcc_h1038 = _source66.dtor_typeArgs;
                DAST._IResolvedType _1928___mcc_h1039 = _source66.dtor_resolved;
                DAST._IResolvedType _source67 = _1928___mcc_h1039;
                if (_source67.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1929___mcc_h1043 = _source67.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1930_recursiveGen;
                    bool _1931_recOwned;
                    bool _1932_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1933_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1232;
                    bool _out1233;
                    bool _out1234;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1232, out _out1233, out _out1234, out _out1235);
                    _1930_recursiveGen = _out1232;
                    _1931_recOwned = _out1233;
                    _1932_recErased = _out1234;
                    _1933_recIdents = _out1235;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1931_recOwned;
                    isErased = _1932_recErased;
                    readIdents = _1933_recIdents;
                  }
                } else if (_source67.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1934___mcc_h1045 = _source67.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1935_recursiveGen;
                    bool _1936_recOwned;
                    bool _1937_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1938_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1236;
                    bool _out1237;
                    bool _out1238;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                    _1935_recursiveGen = _out1236;
                    _1936_recOwned = _out1237;
                    _1937_recErased = _out1238;
                    _1938_recIdents = _out1239;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1936_recOwned;
                    isErased = _1937_recErased;
                    readIdents = _1938_recIdents;
                  }
                } else {
                  DAST._IType _1939___mcc_h1047 = _source67.dtor_Newtype_a0;
                  DAST._IType _1940_b = _1939___mcc_h1047;
                  {
                    if (object.Equals(_563_fromTpe, _1940_b)) {
                      Dafny.ISequence<Dafny.Rune> _1941_recursiveGen;
                      bool _1942_recOwned;
                      bool _1943_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1944_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1240;
                      bool _out1241;
                      bool _out1242;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                      _1941_recursiveGen = _out1240;
                      _1942_recOwned = _out1241;
                      _1943_recErased = _out1242;
                      _1944_recIdents = _out1243;
                      Dafny.ISequence<Dafny.Rune> _1945_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1244;
                      _out1244 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _1945_rhsType = _out1244;
                      Dafny.ISequence<Dafny.Rune> _1946_uneraseFn;
                      _1946_uneraseFn = ((_1942_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1945_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1946_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1941_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1942_recOwned;
                      isErased = false;
                      readIdents = _1944_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1245;
                      bool _out1246;
                      bool _out1247;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1248;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _1940_b), _1940_b, _562_toTpe), selfIdent, @params, mustOwn, out _out1245, out _out1246, out _out1247, out _out1248);
                      s = _out1245;
                      isOwned = _out1246;
                      isErased = _out1247;
                      readIdents = _out1248;
                    }
                  }
                }
              } else if (_source66.is_Nullable) {
                DAST._IType _1947___mcc_h1049 = _source66.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1948_recursiveGen;
                  bool _1949_recOwned;
                  bool _1950_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1951_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1249;
                  bool _out1250;
                  bool _out1251;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1252;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1249, out _out1250, out _out1251, out _out1252);
                  _1948_recursiveGen = _out1249;
                  _1949_recOwned = _out1250;
                  _1950_recErased = _out1251;
                  _1951_recIdents = _out1252;
                  if (!(_1949_recOwned)) {
                    _1948_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1948_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1948_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1950_recErased;
                  readIdents = _1951_recIdents;
                }
              } else if (_source66.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1952___mcc_h1051 = _source66.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1953_recursiveGen;
                  bool _1954_recOwned;
                  bool _1955_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1956_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1253;
                  bool _out1254;
                  bool _out1255;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1256;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1253, out _out1254, out _out1255, out _out1256);
                  _1953_recursiveGen = _out1253;
                  _1954_recOwned = _out1254;
                  _1955_recErased = _out1255;
                  _1956_recIdents = _out1256;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1953_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1954_recOwned;
                  isErased = _1955_recErased;
                  readIdents = _1956_recIdents;
                }
              } else if (_source66.is_Array) {
                DAST._IType _1957___mcc_h1053 = _source66.dtor_element;
                BigInteger _1958___mcc_h1054 = _source66.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1959_recursiveGen;
                  bool _1960_recOwned;
                  bool _1961_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1962_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1257;
                  bool _out1258;
                  bool _out1259;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1260;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1257, out _out1258, out _out1259, out _out1260);
                  _1959_recursiveGen = _out1257;
                  _1960_recOwned = _out1258;
                  _1961_recErased = _out1259;
                  _1962_recIdents = _out1260;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1959_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1960_recOwned;
                  isErased = _1961_recErased;
                  readIdents = _1962_recIdents;
                }
              } else if (_source66.is_Seq) {
                DAST._IType _1963___mcc_h1057 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1964_recursiveGen;
                  bool _1965_recOwned;
                  bool _1966_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1967_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1261;
                  bool _out1262;
                  bool _out1263;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1264;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1261, out _out1262, out _out1263, out _out1264);
                  _1964_recursiveGen = _out1261;
                  _1965_recOwned = _out1262;
                  _1966_recErased = _out1263;
                  _1967_recIdents = _out1264;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1964_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1965_recOwned;
                  isErased = _1966_recErased;
                  readIdents = _1967_recIdents;
                }
              } else if (_source66.is_Set) {
                DAST._IType _1968___mcc_h1059 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1969_recursiveGen;
                  bool _1970_recOwned;
                  bool _1971_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1972_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1265;
                  bool _out1266;
                  bool _out1267;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1268;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1265, out _out1266, out _out1267, out _out1268);
                  _1969_recursiveGen = _out1265;
                  _1970_recOwned = _out1266;
                  _1971_recErased = _out1267;
                  _1972_recIdents = _out1268;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1970_recOwned;
                  isErased = _1971_recErased;
                  readIdents = _1972_recIdents;
                }
              } else if (_source66.is_Multiset) {
                DAST._IType _1973___mcc_h1061 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1974_recursiveGen;
                  bool _1975_recOwned;
                  bool _1976_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1977_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1269;
                  bool _out1270;
                  bool _out1271;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1272;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1269, out _out1270, out _out1271, out _out1272);
                  _1974_recursiveGen = _out1269;
                  _1975_recOwned = _out1270;
                  _1976_recErased = _out1271;
                  _1977_recIdents = _out1272;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1974_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1975_recOwned;
                  isErased = _1976_recErased;
                  readIdents = _1977_recIdents;
                }
              } else if (_source66.is_Map) {
                DAST._IType _1978___mcc_h1063 = _source66.dtor_key;
                DAST._IType _1979___mcc_h1064 = _source66.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1980_recursiveGen;
                  bool _1981_recOwned;
                  bool _1982_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1983_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1273;
                  bool _out1274;
                  bool _out1275;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1273, out _out1274, out _out1275, out _out1276);
                  _1980_recursiveGen = _out1273;
                  _1981_recOwned = _out1274;
                  _1982_recErased = _out1275;
                  _1983_recIdents = _out1276;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1980_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1981_recOwned;
                  isErased = _1982_recErased;
                  readIdents = _1983_recIdents;
                }
              } else if (_source66.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1984___mcc_h1067 = _source66.dtor_args;
                DAST._IType _1985___mcc_h1068 = _source66.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1986_recursiveGen;
                  bool _1987_recOwned;
                  bool _1988_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1989_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1277;
                  bool _out1278;
                  bool _out1279;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                  _1986_recursiveGen = _out1277;
                  _1987_recOwned = _out1278;
                  _1988_recErased = _out1279;
                  _1989_recIdents = _out1280;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1986_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1987_recOwned;
                  isErased = _1988_recErased;
                  readIdents = _1989_recIdents;
                }
              } else if (_source66.is_Primitive) {
                DAST._IPrimitive _1990___mcc_h1071 = _source66.dtor_Primitive_a0;
                DAST._IPrimitive _source68 = _1990___mcc_h1071;
                if (_source68.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1991_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    _out1281 = DCOMP.COMP.GenType(_563_fromTpe, true, false);
                    _1991_rhsType = _out1281;
                    Dafny.ISequence<Dafny.Rune> _1992_recursiveGen;
                    bool _1993___v56;
                    bool _1994___v57;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1995_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1282;
                    bool _out1283;
                    bool _out1284;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1285;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, true, out _out1282, out _out1283, out _out1284, out _out1285);
                    _1992_recursiveGen = _out1282;
                    _1993___v56 = _out1283;
                    _1994___v57 = _out1284;
                    _1995_recIdents = _out1285;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1992_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1995_recIdents;
                  }
                } else if (_source68.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1996_recursiveGen;
                    bool _1997_recOwned;
                    bool _1998_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1999_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1286;
                    bool _out1287;
                    bool _out1288;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1289;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1286, out _out1287, out _out1288, out _out1289);
                    _1996_recursiveGen = _out1286;
                    _1997_recOwned = _out1287;
                    _1998_recErased = _out1288;
                    _1999_recIdents = _out1289;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1996_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1997_recOwned;
                    isErased = _1998_recErased;
                    readIdents = _1999_recIdents;
                  }
                } else if (_source68.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _2000_recursiveGen;
                    bool _2001_recOwned;
                    bool _2002_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2003_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1290;
                    bool _out1291;
                    bool _out1292;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1293;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1290, out _out1291, out _out1292, out _out1293);
                    _2000_recursiveGen = _out1290;
                    _2001_recOwned = _out1291;
                    _2002_recErased = _out1292;
                    _2003_recIdents = _out1293;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2000_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2001_recOwned;
                    isErased = _2002_recErased;
                    readIdents = _2003_recIdents;
                  }
                } else if (_source68.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _2004_recursiveGen;
                    bool _2005_recOwned;
                    bool _2006_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2007_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1294;
                    bool _out1295;
                    bool _out1296;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1297;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1294, out _out1295, out _out1296, out _out1297);
                    _2004_recursiveGen = _out1294;
                    _2005_recOwned = _out1295;
                    _2006_recErased = _out1296;
                    _2007_recIdents = _out1297;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2005_recOwned;
                    isErased = _2006_recErased;
                    readIdents = _2007_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _2008_recursiveGen;
                    bool _2009_recOwned;
                    bool _2010_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2011_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1298;
                    bool _out1299;
                    bool _out1300;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                    _2008_recursiveGen = _out1298;
                    _2009_recOwned = _out1299;
                    _2010_recErased = _out1300;
                    _2011_recIdents = _out1301;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2008_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2009_recOwned;
                    isErased = _2010_recErased;
                    readIdents = _2011_recIdents;
                  }
                }
              } else if (_source66.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2012___mcc_h1073 = _source66.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2013_recursiveGen;
                  bool _2014___v64;
                  bool _2015___v65;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2016_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1302;
                  bool _out1303;
                  bool _out1304;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, true, out _out1302, out _out1303, out _out1304, out _out1305);
                  _2013_recursiveGen = _out1302;
                  _2014___v64 = _out1303;
                  _2015___v65 = _out1304;
                  _2016_recIdents = _out1305;
                  Dafny.ISequence<Dafny.Rune> _2017_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1306;
                  _out1306 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                  _2017_toTpeGen = _out1306;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2013_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _2017_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _2016_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2018___mcc_h1075 = _source66.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2019_recursiveGen;
                  bool _2020_recOwned;
                  bool _2021_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2022_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1307;
                  bool _out1308;
                  bool _out1309;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1310;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1307, out _out1308, out _out1309, out _out1310);
                  _2019_recursiveGen = _out1307;
                  _2020_recOwned = _out1308;
                  _2021_recErased = _out1309;
                  _2022_recIdents = _out1310;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2020_recOwned;
                  isErased = _2021_recErased;
                  readIdents = _2022_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _2023___mcc_h1077 = _source28.dtor_TypeArg_a0;
              DAST._IType _source69 = _570___mcc_h278;
              if (_source69.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2024___mcc_h1081 = _source69.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _2025___mcc_h1082 = _source69.dtor_typeArgs;
                DAST._IResolvedType _2026___mcc_h1083 = _source69.dtor_resolved;
                DAST._IResolvedType _source70 = _2026___mcc_h1083;
                if (_source70.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2027___mcc_h1087 = _source70.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2028_recursiveGen;
                    bool _2029_recOwned;
                    bool _2030_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2031_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1311;
                    bool _out1312;
                    bool _out1313;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1314;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1311, out _out1312, out _out1313, out _out1314);
                    _2028_recursiveGen = _out1311;
                    _2029_recOwned = _out1312;
                    _2030_recErased = _out1313;
                    _2031_recIdents = _out1314;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2028_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2029_recOwned;
                    isErased = _2030_recErased;
                    readIdents = _2031_recIdents;
                  }
                } else if (_source70.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2032___mcc_h1089 = _source70.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2033_recursiveGen;
                    bool _2034_recOwned;
                    bool _2035_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2036_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1315;
                    bool _out1316;
                    bool _out1317;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                    DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                    _2033_recursiveGen = _out1315;
                    _2034_recOwned = _out1316;
                    _2035_recErased = _out1317;
                    _2036_recIdents = _out1318;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2033_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2034_recOwned;
                    isErased = _2035_recErased;
                    readIdents = _2036_recIdents;
                  }
                } else {
                  DAST._IType _2037___mcc_h1091 = _source70.dtor_Newtype_a0;
                  DAST._IType _2038_b = _2037___mcc_h1091;
                  {
                    if (object.Equals(_563_fromTpe, _2038_b)) {
                      Dafny.ISequence<Dafny.Rune> _2039_recursiveGen;
                      bool _2040_recOwned;
                      bool _2041_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2042_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1319;
                      bool _out1320;
                      bool _out1321;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                      DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                      _2039_recursiveGen = _out1319;
                      _2040_recOwned = _out1320;
                      _2041_recErased = _out1321;
                      _2042_recIdents = _out1322;
                      Dafny.ISequence<Dafny.Rune> _2043_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1323;
                      _out1323 = DCOMP.COMP.GenType(_562_toTpe, true, false);
                      _2043_rhsType = _out1323;
                      Dafny.ISequence<Dafny.Rune> _2044_uneraseFn;
                      _2044_uneraseFn = ((_2040_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2043_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _2044_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2039_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _2040_recOwned;
                      isErased = false;
                      readIdents = _2042_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1324;
                      bool _out1325;
                      bool _out1326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_564_expr, _563_fromTpe, _2038_b), _2038_b, _562_toTpe), selfIdent, @params, mustOwn, out _out1324, out _out1325, out _out1326, out _out1327);
                      s = _out1324;
                      isOwned = _out1325;
                      isErased = _out1326;
                      readIdents = _out1327;
                    }
                  }
                }
              } else if (_source69.is_Nullable) {
                DAST._IType _2045___mcc_h1093 = _source69.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2046_recursiveGen;
                  bool _2047_recOwned;
                  bool _2048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1328;
                  bool _out1329;
                  bool _out1330;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1331;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1328, out _out1329, out _out1330, out _out1331);
                  _2046_recursiveGen = _out1328;
                  _2047_recOwned = _out1329;
                  _2048_recErased = _out1330;
                  _2049_recIdents = _out1331;
                  if (!(_2047_recOwned)) {
                    _2046_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_2046_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _2046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _2048_recErased;
                  readIdents = _2049_recIdents;
                }
              } else if (_source69.is_Tuple) {
                Dafny.ISequence<DAST._IType> _2050___mcc_h1095 = _source69.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2051_recursiveGen;
                  bool _2052_recOwned;
                  bool _2053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1332;
                  bool _out1333;
                  bool _out1334;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1335;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1332, out _out1333, out _out1334, out _out1335);
                  _2051_recursiveGen = _out1332;
                  _2052_recOwned = _out1333;
                  _2053_recErased = _out1334;
                  _2054_recIdents = _out1335;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2052_recOwned;
                  isErased = _2053_recErased;
                  readIdents = _2054_recIdents;
                }
              } else if (_source69.is_Array) {
                DAST._IType _2055___mcc_h1097 = _source69.dtor_element;
                BigInteger _2056___mcc_h1098 = _source69.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _2057_recursiveGen;
                  bool _2058_recOwned;
                  bool _2059_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2060_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1336;
                  bool _out1337;
                  bool _out1338;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1339;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1336, out _out1337, out _out1338, out _out1339);
                  _2057_recursiveGen = _out1336;
                  _2058_recOwned = _out1337;
                  _2059_recErased = _out1338;
                  _2060_recIdents = _out1339;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2057_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2058_recOwned;
                  isErased = _2059_recErased;
                  readIdents = _2060_recIdents;
                }
              } else if (_source69.is_Seq) {
                DAST._IType _2061___mcc_h1101 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2062_recursiveGen;
                  bool _2063_recOwned;
                  bool _2064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1340;
                  bool _out1341;
                  bool _out1342;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1343;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1340, out _out1341, out _out1342, out _out1343);
                  _2062_recursiveGen = _out1340;
                  _2063_recOwned = _out1341;
                  _2064_recErased = _out1342;
                  _2065_recIdents = _out1343;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2063_recOwned;
                  isErased = _2064_recErased;
                  readIdents = _2065_recIdents;
                }
              } else if (_source69.is_Set) {
                DAST._IType _2066___mcc_h1103 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2067_recursiveGen;
                  bool _2068_recOwned;
                  bool _2069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1344;
                  bool _out1345;
                  bool _out1346;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1347;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1344, out _out1345, out _out1346, out _out1347);
                  _2067_recursiveGen = _out1344;
                  _2068_recOwned = _out1345;
                  _2069_recErased = _out1346;
                  _2070_recIdents = _out1347;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2068_recOwned;
                  isErased = _2069_recErased;
                  readIdents = _2070_recIdents;
                }
              } else if (_source69.is_Multiset) {
                DAST._IType _2071___mcc_h1105 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2072_recursiveGen;
                  bool _2073_recOwned;
                  bool _2074_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2075_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1348;
                  bool _out1349;
                  bool _out1350;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1351;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1348, out _out1349, out _out1350, out _out1351);
                  _2072_recursiveGen = _out1348;
                  _2073_recOwned = _out1349;
                  _2074_recErased = _out1350;
                  _2075_recIdents = _out1351;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2073_recOwned;
                  isErased = _2074_recErased;
                  readIdents = _2075_recIdents;
                }
              } else if (_source69.is_Map) {
                DAST._IType _2076___mcc_h1107 = _source69.dtor_key;
                DAST._IType _2077___mcc_h1108 = _source69.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2078_recursiveGen;
                  bool _2079_recOwned;
                  bool _2080_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2081_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1352;
                  bool _out1353;
                  bool _out1354;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1355;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1352, out _out1353, out _out1354, out _out1355);
                  _2078_recursiveGen = _out1352;
                  _2079_recOwned = _out1353;
                  _2080_recErased = _out1354;
                  _2081_recIdents = _out1355;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2078_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2079_recOwned;
                  isErased = _2080_recErased;
                  readIdents = _2081_recIdents;
                }
              } else if (_source69.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2082___mcc_h1111 = _source69.dtor_args;
                DAST._IType _2083___mcc_h1112 = _source69.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2084_recursiveGen;
                  bool _2085_recOwned;
                  bool _2086_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2087_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1356;
                  bool _out1357;
                  bool _out1358;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1359;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1356, out _out1357, out _out1358, out _out1359);
                  _2084_recursiveGen = _out1356;
                  _2085_recOwned = _out1357;
                  _2086_recErased = _out1358;
                  _2087_recIdents = _out1359;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2084_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2085_recOwned;
                  isErased = _2086_recErased;
                  readIdents = _2087_recIdents;
                }
              } else if (_source69.is_Primitive) {
                DAST._IPrimitive _2088___mcc_h1115 = _source69.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2089_recursiveGen;
                  bool _2090_recOwned;
                  bool _2091_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2092_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1360;
                  bool _out1361;
                  bool _out1362;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1363;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1360, out _out1361, out _out1362, out _out1363);
                  _2089_recursiveGen = _out1360;
                  _2090_recOwned = _out1361;
                  _2091_recErased = _out1362;
                  _2092_recIdents = _out1363;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2089_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2090_recOwned;
                  isErased = _2091_recErased;
                  readIdents = _2092_recIdents;
                }
              } else if (_source69.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2093___mcc_h1117 = _source69.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2094_recursiveGen;
                  bool _2095_recOwned;
                  bool _2096_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2097_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1364;
                  bool _out1365;
                  bool _out1366;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1367;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1364, out _out1365, out _out1366, out _out1367);
                  _2094_recursiveGen = _out1364;
                  _2095_recOwned = _out1365;
                  _2096_recErased = _out1366;
                  _2097_recIdents = _out1367;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2094_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2095_recOwned;
                  isErased = _2096_recErased;
                  readIdents = _2097_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2098___mcc_h1119 = _source69.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2099_recursiveGen;
                  bool _2100_recOwned;
                  bool _2101_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2102_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1368;
                  bool _out1369;
                  bool _out1370;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1371;
                  DCOMP.COMP.GenExpr(_564_expr, selfIdent, @params, mustOwn, out _out1368, out _out1369, out _out1370, out _out1371);
                  _2099_recursiveGen = _out1368;
                  _2100_recOwned = _out1369;
                  _2101_recErased = _out1370;
                  _2102_recIdents = _out1371;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2099_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2100_recOwned;
                  isErased = _2101_recErased;
                  readIdents = _2102_recIdents;
                }
              }
            }
          }
        }
      } else if (_source21.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2103___mcc_h22 = _source21.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2104_exprs = _2103___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2105_generatedValues;
          _2105_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2106_i;
          _2106_i = BigInteger.Zero;
          bool _2107_allErased;
          _2107_allErased = true;
          while ((_2106_i) < (new BigInteger((_2104_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2108_recursiveGen;
            bool _2109___v67;
            bool _2110_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2111_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1372;
            bool _out1373;
            bool _out1374;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1375;
            DCOMP.COMP.GenExpr((_2104_exprs).Select(_2106_i), selfIdent, @params, true, out _out1372, out _out1373, out _out1374, out _out1375);
            _2108_recursiveGen = _out1372;
            _2109___v67 = _out1373;
            _2110_isErased = _out1374;
            _2111_recIdents = _out1375;
            _2107_allErased = (_2107_allErased) && (_2110_isErased);
            _2105_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2105_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2108_recursiveGen, _2110_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2111_recIdents);
            _2106_i = (_2106_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2106_i = BigInteger.Zero;
          while ((_2106_i) < (new BigInteger((_2105_generatedValues).Count))) {
            if ((_2106_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2112_gen;
            _2112_gen = ((_2105_generatedValues).Select(_2106_i)).dtor__0;
            if ((((_2105_generatedValues).Select(_2106_i)).dtor__1) && (!(_2107_allErased))) {
              _2112_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2112_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2112_gen);
            _2106_i = (_2106_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2107_allErased;
        }
      } else if (_source21.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2113___mcc_h23 = _source21.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2114_exprs = _2113___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2115_generatedValues;
          _2115_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2116_i;
          _2116_i = BigInteger.Zero;
          bool _2117_allErased;
          _2117_allErased = true;
          while ((_2116_i) < (new BigInteger((_2114_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2118_recursiveGen;
            bool _2119___v68;
            bool _2120_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2121_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1376;
            bool _out1377;
            bool _out1378;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1379;
            DCOMP.COMP.GenExpr((_2114_exprs).Select(_2116_i), selfIdent, @params, true, out _out1376, out _out1377, out _out1378, out _out1379);
            _2118_recursiveGen = _out1376;
            _2119___v68 = _out1377;
            _2120_isErased = _out1378;
            _2121_recIdents = _out1379;
            _2117_allErased = (_2117_allErased) && (_2120_isErased);
            _2115_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2115_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2118_recursiveGen, _2120_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2121_recIdents);
            _2116_i = (_2116_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2116_i = BigInteger.Zero;
          while ((_2116_i) < (new BigInteger((_2115_generatedValues).Count))) {
            if ((_2116_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2122_gen;
            _2122_gen = ((_2115_generatedValues).Select(_2116_i)).dtor__0;
            if ((((_2115_generatedValues).Select(_2116_i)).dtor__1) && (!(_2117_allErased))) {
              _2122_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2122_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2122_gen);
            _2116_i = (_2116_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = _2117_allErased;
        }
      } else if (_source21.is_MapValue) {
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2123___mcc_h24 = _source21.dtor_mapElems;
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2124_mapElems = _2123___mcc_h24;
        {
          Dafny.ISequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>> _2125_generatedValues;
          _2125_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2126_i;
          _2126_i = BigInteger.Zero;
          bool _2127_allErased;
          _2127_allErased = true;
          while ((_2126_i) < (new BigInteger((_2124_mapElems).Count))) {
            Dafny.ISequence<Dafny.Rune> _2128_recursiveGenKey;
            bool _2129___v69;
            bool _2130_isErasedKey;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2131_recIdentsKey;
            Dafny.ISequence<Dafny.Rune> _out1380;
            bool _out1381;
            bool _out1382;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1383;
            DCOMP.COMP.GenExpr(((_2124_mapElems).Select(_2126_i)).dtor__0, selfIdent, @params, true, out _out1380, out _out1381, out _out1382, out _out1383);
            _2128_recursiveGenKey = _out1380;
            _2129___v69 = _out1381;
            _2130_isErasedKey = _out1382;
            _2131_recIdentsKey = _out1383;
            Dafny.ISequence<Dafny.Rune> _2132_recursiveGenValue;
            bool _2133___v70;
            bool _2134_isErasedValue;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2135_recIdentsValue;
            Dafny.ISequence<Dafny.Rune> _out1384;
            bool _out1385;
            bool _out1386;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1387;
            DCOMP.COMP.GenExpr(((_2124_mapElems).Select(_2126_i)).dtor__1, selfIdent, @params, true, out _out1384, out _out1385, out _out1386, out _out1387);
            _2132_recursiveGenValue = _out1384;
            _2133___v70 = _out1385;
            _2134_isErasedValue = _out1386;
            _2135_recIdentsValue = _out1387;
            _2127_allErased = ((_2127_allErased) && (_2130_isErasedKey)) && (_2134_isErasedValue);
            _2125_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.Concat(_2125_generatedValues, Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements(_System.Tuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>.create(_2128_recursiveGenKey, _2132_recursiveGenValue, _2130_isErasedKey, _2134_isErasedValue)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2131_recIdentsKey), _2135_recIdentsValue);
            _2126_i = (_2126_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2126_i = BigInteger.Zero;
          while ((_2126_i) < (new BigInteger((_2125_generatedValues).Count))) {
            if ((_2126_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2136_genKey;
            _2136_genKey = ((_2125_generatedValues).Select(_2126_i)).dtor__0;
            Dafny.ISequence<Dafny.Rune> _2137_genValue;
            _2137_genValue = ((_2125_generatedValues).Select(_2126_i)).dtor__1;
            if ((((_2125_generatedValues).Select(_2126_i)).dtor__2) && (!(_2127_allErased))) {
              _2136_genKey = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2136_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((((_2125_generatedValues).Select(_2126_i)).dtor__3) && (!(_2127_allErased))) {
              _2137_genValue = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2137_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2136_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2137_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            _2126_i = (_2126_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashMap<_, _>>()"));
          isOwned = true;
          isErased = _2127_allErased;
        }
      } else if (_source21.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source71 = selfIdent;
          if (_source71.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2138___mcc_h1121 = _source71.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2139_id = _2138___mcc_h1121;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2139_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2139_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2139_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2139_id);
              isErased = false;
            }
          } else {
            {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("panic!(\"this outside of a method\")");
              isOwned = true;
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
              isErased = true;
            }
          }
        }
      } else if (_source21.is_Ite) {
        DAST._IExpression _2140___mcc_h25 = _source21.dtor_cond;
        DAST._IExpression _2141___mcc_h26 = _source21.dtor_thn;
        DAST._IExpression _2142___mcc_h27 = _source21.dtor_els;
        DAST._IExpression _2143_f = _2142___mcc_h27;
        DAST._IExpression _2144_t = _2141___mcc_h26;
        DAST._IExpression _2145_cond = _2140___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _2146_condString;
          bool _2147___v71;
          bool _2148_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2149_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1388;
          bool _out1389;
          bool _out1390;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1391;
          DCOMP.COMP.GenExpr(_2145_cond, selfIdent, @params, true, out _out1388, out _out1389, out _out1390, out _out1391);
          _2146_condString = _out1388;
          _2147___v71 = _out1389;
          _2148_condErased = _out1390;
          _2149_recIdentsCond = _out1391;
          if (!(_2148_condErased)) {
            _2146_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2146_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2150___v72;
          bool _2151_tHasToBeOwned;
          bool _2152___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2153___v74;
          Dafny.ISequence<Dafny.Rune> _out1392;
          bool _out1393;
          bool _out1394;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1395;
          DCOMP.COMP.GenExpr(_2144_t, selfIdent, @params, mustOwn, out _out1392, out _out1393, out _out1394, out _out1395);
          _2150___v72 = _out1392;
          _2151_tHasToBeOwned = _out1393;
          _2152___v73 = _out1394;
          _2153___v74 = _out1395;
          Dafny.ISequence<Dafny.Rune> _2154_fString;
          bool _2155_fOwned;
          bool _2156_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2157_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1396;
          bool _out1397;
          bool _out1398;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1399;
          DCOMP.COMP.GenExpr(_2143_f, selfIdent, @params, _2151_tHasToBeOwned, out _out1396, out _out1397, out _out1398, out _out1399);
          _2154_fString = _out1396;
          _2155_fOwned = _out1397;
          _2156_fErased = _out1398;
          _2157_recIdentsF = _out1399;
          Dafny.ISequence<Dafny.Rune> _2158_tString;
          bool _2159___v75;
          bool _2160_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2161_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1400;
          bool _out1401;
          bool _out1402;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1403;
          DCOMP.COMP.GenExpr(_2144_t, selfIdent, @params, _2155_fOwned, out _out1400, out _out1401, out _out1402, out _out1403);
          _2158_tString = _out1400;
          _2159___v75 = _out1401;
          _2160_tErased = _out1402;
          _2161_recIdentsT = _out1403;
          if ((!(_2156_fErased)) || (!(_2160_tErased))) {
            if (_2156_fErased) {
              _2154_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2154_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2160_tErased) {
              _2158_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2158_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2146_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2158_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2154_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2155_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2149_recIdentsCond, _2161_recIdentsT), _2157_recIdentsF);
          isErased = (_2156_fErased) || (_2160_tErased);
        }
      } else if (_source21.is_UnOp) {
        DAST._IUnaryOp _2162___mcc_h28 = _source21.dtor_unOp;
        DAST._IExpression _2163___mcc_h29 = _source21.dtor_expr;
        DAST._IUnaryOp _source72 = _2162___mcc_h28;
        if (_source72.is_Not) {
          DAST._IExpression _2164_e = _2163___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2165_recursiveGen;
            bool _2166___v76;
            bool _2167_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2168_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1404;
            bool _out1405;
            bool _out1406;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1407;
            DCOMP.COMP.GenExpr(_2164_e, selfIdent, @params, true, out _out1404, out _out1405, out _out1406, out _out1407);
            _2165_recursiveGen = _out1404;
            _2166___v76 = _out1405;
            _2167_recErased = _out1406;
            _2168_recIdents = _out1407;
            if (!(_2167_recErased)) {
              _2165_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2165_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2165_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2168_recIdents;
            isErased = true;
          }
        } else if (_source72.is_BitwiseNot) {
          DAST._IExpression _2169_e = _2163___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2170_recursiveGen;
            bool _2171___v77;
            bool _2172_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2173_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1408;
            bool _out1409;
            bool _out1410;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1411;
            DCOMP.COMP.GenExpr(_2169_e, selfIdent, @params, true, out _out1408, out _out1409, out _out1410, out _out1411);
            _2170_recursiveGen = _out1408;
            _2171___v77 = _out1409;
            _2172_recErased = _out1410;
            _2173_recIdents = _out1411;
            if (!(_2172_recErased)) {
              _2170_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2170_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2170_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2173_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2174_e = _2163___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2175_recursiveGen;
            bool _2176_recOwned;
            bool _2177_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2178_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1412;
            bool _out1413;
            bool _out1414;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1415;
            DCOMP.COMP.GenExpr(_2174_e, selfIdent, @params, false, out _out1412, out _out1413, out _out1414, out _out1415);
            _2175_recursiveGen = _out1412;
            _2176_recOwned = _out1413;
            _2177_recErased = _out1414;
            _2178_recIdents = _out1415;
            if (!(_2177_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2179_eraseFn;
              _2179_eraseFn = ((_2176_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2175_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2179_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2175_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2175_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2178_recIdents;
            isErased = true;
          }
        }
      } else if (_source21.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2180___mcc_h30 = _source21.dtor_op;
        DAST._IExpression _2181___mcc_h31 = _source21.dtor_left;
        DAST._IExpression _2182___mcc_h32 = _source21.dtor_right;
        DAST._IExpression _2183_r = _2182___mcc_h32;
        DAST._IExpression _2184_l = _2181___mcc_h31;
        Dafny.ISequence<Dafny.Rune> _2185_op = _2180___mcc_h30;
        {
          Dafny.ISequence<Dafny.Rune> _2186_left;
          bool _2187___v78;
          bool _2188_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2189_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1416;
          bool _out1417;
          bool _out1418;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1419;
          DCOMP.COMP.GenExpr(_2184_l, selfIdent, @params, true, out _out1416, out _out1417, out _out1418, out _out1419);
          _2186_left = _out1416;
          _2187___v78 = _out1417;
          _2188_leftErased = _out1418;
          _2189_recIdentsL = _out1419;
          Dafny.ISequence<Dafny.Rune> _2190_right;
          bool _2191___v79;
          bool _2192_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2193_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1420;
          bool _out1421;
          bool _out1422;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1423;
          DCOMP.COMP.GenExpr(_2183_r, selfIdent, @params, true, out _out1420, out _out1421, out _out1422, out _out1423);
          _2190_right = _out1420;
          _2191___v79 = _out1421;
          _2192_rightErased = _out1422;
          _2193_recIdentsR = _out1423;
          if (!(_2188_leftErased)) {
            _2186_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2186_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2192_rightErased)) {
            _2190_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2190_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2185_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2186_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2190_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2185_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2186_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2190_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2186_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2185_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2190_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2189_recIdentsL, _2193_recIdentsR);
          isErased = true;
        }
      } else if (_source21.is_ArrayLen) {
        DAST._IExpression _2194___mcc_h33 = _source21.dtor_expr;
        BigInteger _2195___mcc_h34 = _source21.dtor_dim;
        BigInteger _2196_dim = _2195___mcc_h34;
        DAST._IExpression _2197_expr = _2194___mcc_h33;
        {
          Dafny.ISequence<Dafny.Rune> _2198_recursiveGen;
          bool _2199___v80;
          bool _2200_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2201_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1424;
          bool _out1425;
          bool _out1426;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1427;
          DCOMP.COMP.GenExpr(_2197_expr, selfIdent, @params, true, out _out1424, out _out1425, out _out1426, out _out1427);
          _2198_recursiveGen = _out1424;
          _2199___v80 = _out1425;
          _2200_recErased = _out1426;
          _2201_recIdents = _out1427;
          if (!(_2200_recErased)) {
            _2198_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2198_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2196_dim).Sign == 0) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2198_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(m.borrow().len())");
            BigInteger _2202_i;
            _2202_i = BigInteger.One;
            while ((_2202_i) < (_2196_dim)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("m.borrow().get(0).map(|m| "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap_or(::dafny_runtime::BigInt::from(0))"));
              _2202_i = (_2202_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2198_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow().get(0).map(|m| ")), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap_or(::dafny_runtime::BigInt::from(0))"));
          }
          isOwned = true;
          readIdents = _2201_recIdents;
          isErased = true;
        }
      } else if (_source21.is_Select) {
        DAST._IExpression _2203___mcc_h35 = _source21.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2204___mcc_h36 = _source21.dtor_field;
        bool _2205___mcc_h37 = _source21.dtor_isConstant;
        bool _2206___mcc_h38 = _source21.dtor_onDatatype;
        DAST._IExpression _source73 = _2203___mcc_h35;
        if (_source73.is_Literal) {
          DAST._ILiteral _2207___mcc_h39 = _source73.dtor_Literal_a0;
          bool _2208_isDatatype = _2206___mcc_h38;
          bool _2209_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2210_field = _2204___mcc_h36;
          DAST._IExpression _2211_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2212_onString;
            bool _2213_onOwned;
            bool _2214_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2215_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1428;
            bool _out1429;
            bool _out1430;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1431;
            DCOMP.COMP.GenExpr(_2211_on, selfIdent, @params, false, out _out1428, out _out1429, out _out1430, out _out1431);
            _2212_onString = _out1428;
            _2213_onOwned = _out1429;
            _2214_onErased = _out1430;
            _2215_recIdents = _out1431;
            if (!(_2214_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2216_eraseFn;
              _2216_eraseFn = ((_2213_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2212_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2216_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2212_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2208_isDatatype) || (_2209_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2212_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2210_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2209_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2212_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2210_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2215_recIdents;
          }
        } else if (_source73.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2217___mcc_h41 = _source73.dtor_Ident_a0;
          bool _2218_isDatatype = _2206___mcc_h38;
          bool _2219_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2220_field = _2204___mcc_h36;
          DAST._IExpression _2221_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2222_onString;
            bool _2223_onOwned;
            bool _2224_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2225_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1432;
            bool _out1433;
            bool _out1434;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1435;
            DCOMP.COMP.GenExpr(_2221_on, selfIdent, @params, false, out _out1432, out _out1433, out _out1434, out _out1435);
            _2222_onString = _out1432;
            _2223_onOwned = _out1433;
            _2224_onErased = _out1434;
            _2225_recIdents = _out1435;
            if (!(_2224_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2226_eraseFn;
              _2226_eraseFn = ((_2223_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2222_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2226_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2222_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2218_isDatatype) || (_2219_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2222_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2220_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2219_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2222_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2220_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2225_recIdents;
          }
        } else if (_source73.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2227___mcc_h43 = _source73.dtor_Companion_a0;
          bool _2228_isDatatype = _2206___mcc_h38;
          bool _2229_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2230_field = _2204___mcc_h36;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2231_c = _2227___mcc_h43;
          {
            Dafny.ISequence<Dafny.Rune> _2232_onString;
            bool _2233_onOwned;
            bool _2234_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2235_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1436;
            bool _out1437;
            bool _out1438;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1439;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2231_c), selfIdent, @params, false, out _out1436, out _out1437, out _out1438, out _out1439);
            _2232_onString = _out1436;
            _2233_onOwned = _out1437;
            _2234_onErased = _out1438;
            _2235_recIdents = _out1439;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2232_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2230_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2235_recIdents;
          }
        } else if (_source73.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2236___mcc_h45 = _source73.dtor_Tuple_a0;
          bool _2237_isDatatype = _2206___mcc_h38;
          bool _2238_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2239_field = _2204___mcc_h36;
          DAST._IExpression _2240_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2241_onString;
            bool _2242_onOwned;
            bool _2243_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2244_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1440;
            bool _out1441;
            bool _out1442;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1443;
            DCOMP.COMP.GenExpr(_2240_on, selfIdent, @params, false, out _out1440, out _out1441, out _out1442, out _out1443);
            _2241_onString = _out1440;
            _2242_onOwned = _out1441;
            _2243_onErased = _out1442;
            _2244_recIdents = _out1443;
            if (!(_2243_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2245_eraseFn;
              _2245_eraseFn = ((_2242_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2241_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2245_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2241_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2237_isDatatype) || (_2238_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2241_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2239_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2238_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2241_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2239_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2244_recIdents;
          }
        } else if (_source73.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2246___mcc_h47 = _source73.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2247___mcc_h48 = _source73.dtor_args;
          bool _2248_isDatatype = _2206___mcc_h38;
          bool _2249_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2250_field = _2204___mcc_h36;
          DAST._IExpression _2251_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2252_onString;
            bool _2253_onOwned;
            bool _2254_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2255_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1444;
            bool _out1445;
            bool _out1446;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1447;
            DCOMP.COMP.GenExpr(_2251_on, selfIdent, @params, false, out _out1444, out _out1445, out _out1446, out _out1447);
            _2252_onString = _out1444;
            _2253_onOwned = _out1445;
            _2254_onErased = _out1446;
            _2255_recIdents = _out1447;
            if (!(_2254_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2256_eraseFn;
              _2256_eraseFn = ((_2253_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2252_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2256_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2252_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2248_isDatatype) || (_2249_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2252_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2250_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2249_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2252_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2250_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2255_recIdents;
          }
        } else if (_source73.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2257___mcc_h51 = _source73.dtor_dims;
          bool _2258_isDatatype = _2206___mcc_h38;
          bool _2259_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2260_field = _2204___mcc_h36;
          DAST._IExpression _2261_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2262_onString;
            bool _2263_onOwned;
            bool _2264_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2265_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1448;
            bool _out1449;
            bool _out1450;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1451;
            DCOMP.COMP.GenExpr(_2261_on, selfIdent, @params, false, out _out1448, out _out1449, out _out1450, out _out1451);
            _2262_onString = _out1448;
            _2263_onOwned = _out1449;
            _2264_onErased = _out1450;
            _2265_recIdents = _out1451;
            if (!(_2264_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2266_eraseFn;
              _2266_eraseFn = ((_2263_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2262_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2266_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2262_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2258_isDatatype) || (_2259_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2262_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2260_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2259_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2262_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2260_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2265_recIdents;
          }
        } else if (_source73.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2267___mcc_h53 = _source73.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2268___mcc_h54 = _source73.dtor_variant;
          bool _2269___mcc_h55 = _source73.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2270___mcc_h56 = _source73.dtor_contents;
          bool _2271_isDatatype = _2206___mcc_h38;
          bool _2272_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2273_field = _2204___mcc_h36;
          DAST._IExpression _2274_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2275_onString;
            bool _2276_onOwned;
            bool _2277_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2278_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1452;
            bool _out1453;
            bool _out1454;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1455;
            DCOMP.COMP.GenExpr(_2274_on, selfIdent, @params, false, out _out1452, out _out1453, out _out1454, out _out1455);
            _2275_onString = _out1452;
            _2276_onOwned = _out1453;
            _2277_onErased = _out1454;
            _2278_recIdents = _out1455;
            if (!(_2277_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2279_eraseFn;
              _2279_eraseFn = ((_2276_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2275_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2279_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2275_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2271_isDatatype) || (_2272_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2275_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2273_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2272_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2275_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2273_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2278_recIdents;
          }
        } else if (_source73.is_Convert) {
          DAST._IExpression _2280___mcc_h61 = _source73.dtor_value;
          DAST._IType _2281___mcc_h62 = _source73.dtor_from;
          DAST._IType _2282___mcc_h63 = _source73.dtor_typ;
          bool _2283_isDatatype = _2206___mcc_h38;
          bool _2284_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2285_field = _2204___mcc_h36;
          DAST._IExpression _2286_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2287_onString;
            bool _2288_onOwned;
            bool _2289_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2290_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1456;
            bool _out1457;
            bool _out1458;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1459;
            DCOMP.COMP.GenExpr(_2286_on, selfIdent, @params, false, out _out1456, out _out1457, out _out1458, out _out1459);
            _2287_onString = _out1456;
            _2288_onOwned = _out1457;
            _2289_onErased = _out1458;
            _2290_recIdents = _out1459;
            if (!(_2289_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2291_eraseFn;
              _2291_eraseFn = ((_2288_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2287_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2291_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2287_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2283_isDatatype) || (_2284_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2287_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2285_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2284_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2287_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2285_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2290_recIdents;
          }
        } else if (_source73.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2292___mcc_h67 = _source73.dtor_elements;
          bool _2293_isDatatype = _2206___mcc_h38;
          bool _2294_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2295_field = _2204___mcc_h36;
          DAST._IExpression _2296_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2297_onString;
            bool _2298_onOwned;
            bool _2299_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2300_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1460;
            bool _out1461;
            bool _out1462;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1463;
            DCOMP.COMP.GenExpr(_2296_on, selfIdent, @params, false, out _out1460, out _out1461, out _out1462, out _out1463);
            _2297_onString = _out1460;
            _2298_onOwned = _out1461;
            _2299_onErased = _out1462;
            _2300_recIdents = _out1463;
            if (!(_2299_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2301_eraseFn;
              _2301_eraseFn = ((_2298_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2297_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2301_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2297_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2293_isDatatype) || (_2294_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2297_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2295_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2294_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2297_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2295_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2300_recIdents;
          }
        } else if (_source73.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2302___mcc_h69 = _source73.dtor_elements;
          bool _2303_isDatatype = _2206___mcc_h38;
          bool _2304_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2305_field = _2204___mcc_h36;
          DAST._IExpression _2306_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2307_onString;
            bool _2308_onOwned;
            bool _2309_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2310_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1464;
            bool _out1465;
            bool _out1466;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1467;
            DCOMP.COMP.GenExpr(_2306_on, selfIdent, @params, false, out _out1464, out _out1465, out _out1466, out _out1467);
            _2307_onString = _out1464;
            _2308_onOwned = _out1465;
            _2309_onErased = _out1466;
            _2310_recIdents = _out1467;
            if (!(_2309_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2311_eraseFn;
              _2311_eraseFn = ((_2308_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2307_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2311_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2307_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2303_isDatatype) || (_2304_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2307_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2305_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2304_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2307_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2305_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2310_recIdents;
          }
        } else if (_source73.is_MapValue) {
          Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2312___mcc_h71 = _source73.dtor_mapElems;
          bool _2313_isDatatype = _2206___mcc_h38;
          bool _2314_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2315_field = _2204___mcc_h36;
          DAST._IExpression _2316_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2317_onString;
            bool _2318_onOwned;
            bool _2319_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2320_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1468;
            bool _out1469;
            bool _out1470;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1471;
            DCOMP.COMP.GenExpr(_2316_on, selfIdent, @params, false, out _out1468, out _out1469, out _out1470, out _out1471);
            _2317_onString = _out1468;
            _2318_onOwned = _out1469;
            _2319_onErased = _out1470;
            _2320_recIdents = _out1471;
            if (!(_2319_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2321_eraseFn;
              _2321_eraseFn = ((_2318_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2317_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2321_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2313_isDatatype) || (_2314_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2315_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2314_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2315_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2320_recIdents;
          }
        } else if (_source73.is_This) {
          bool _2322_isDatatype = _2206___mcc_h38;
          bool _2323_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2324_field = _2204___mcc_h36;
          DAST._IExpression _2325_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2326_onString;
            bool _2327_onOwned;
            bool _2328_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2329_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1472;
            bool _out1473;
            bool _out1474;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1475;
            DCOMP.COMP.GenExpr(_2325_on, selfIdent, @params, false, out _out1472, out _out1473, out _out1474, out _out1475);
            _2326_onString = _out1472;
            _2327_onOwned = _out1473;
            _2328_onErased = _out1474;
            _2329_recIdents = _out1475;
            if (!(_2328_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2330_eraseFn;
              _2330_eraseFn = ((_2327_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2326_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2330_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2326_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2322_isDatatype) || (_2323_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2326_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2324_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2323_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2326_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2324_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2329_recIdents;
          }
        } else if (_source73.is_Ite) {
          DAST._IExpression _2331___mcc_h73 = _source73.dtor_cond;
          DAST._IExpression _2332___mcc_h74 = _source73.dtor_thn;
          DAST._IExpression _2333___mcc_h75 = _source73.dtor_els;
          bool _2334_isDatatype = _2206___mcc_h38;
          bool _2335_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2336_field = _2204___mcc_h36;
          DAST._IExpression _2337_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2338_onString;
            bool _2339_onOwned;
            bool _2340_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2341_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1476;
            bool _out1477;
            bool _out1478;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1479;
            DCOMP.COMP.GenExpr(_2337_on, selfIdent, @params, false, out _out1476, out _out1477, out _out1478, out _out1479);
            _2338_onString = _out1476;
            _2339_onOwned = _out1477;
            _2340_onErased = _out1478;
            _2341_recIdents = _out1479;
            if (!(_2340_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2342_eraseFn;
              _2342_eraseFn = ((_2339_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2338_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2342_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2338_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2334_isDatatype) || (_2335_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2338_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2336_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2335_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2338_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2336_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2341_recIdents;
          }
        } else if (_source73.is_UnOp) {
          DAST._IUnaryOp _2343___mcc_h79 = _source73.dtor_unOp;
          DAST._IExpression _2344___mcc_h80 = _source73.dtor_expr;
          bool _2345_isDatatype = _2206___mcc_h38;
          bool _2346_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2347_field = _2204___mcc_h36;
          DAST._IExpression _2348_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2349_onString;
            bool _2350_onOwned;
            bool _2351_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2352_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1480;
            bool _out1481;
            bool _out1482;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1483;
            DCOMP.COMP.GenExpr(_2348_on, selfIdent, @params, false, out _out1480, out _out1481, out _out1482, out _out1483);
            _2349_onString = _out1480;
            _2350_onOwned = _out1481;
            _2351_onErased = _out1482;
            _2352_recIdents = _out1483;
            if (!(_2351_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2353_eraseFn;
              _2353_eraseFn = ((_2350_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2349_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2353_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2349_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2345_isDatatype) || (_2346_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2349_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2347_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2346_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2349_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2347_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2352_recIdents;
          }
        } else if (_source73.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2354___mcc_h83 = _source73.dtor_op;
          DAST._IExpression _2355___mcc_h84 = _source73.dtor_left;
          DAST._IExpression _2356___mcc_h85 = _source73.dtor_right;
          bool _2357_isDatatype = _2206___mcc_h38;
          bool _2358_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2359_field = _2204___mcc_h36;
          DAST._IExpression _2360_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2361_onString;
            bool _2362_onOwned;
            bool _2363_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2364_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1484;
            bool _out1485;
            bool _out1486;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1487;
            DCOMP.COMP.GenExpr(_2360_on, selfIdent, @params, false, out _out1484, out _out1485, out _out1486, out _out1487);
            _2361_onString = _out1484;
            _2362_onOwned = _out1485;
            _2363_onErased = _out1486;
            _2364_recIdents = _out1487;
            if (!(_2363_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2365_eraseFn;
              _2365_eraseFn = ((_2362_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2361_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2365_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2361_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2357_isDatatype) || (_2358_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2361_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2359_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2358_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2361_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2359_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2364_recIdents;
          }
        } else if (_source73.is_ArrayLen) {
          DAST._IExpression _2366___mcc_h89 = _source73.dtor_expr;
          BigInteger _2367___mcc_h90 = _source73.dtor_dim;
          bool _2368_isDatatype = _2206___mcc_h38;
          bool _2369_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2370_field = _2204___mcc_h36;
          DAST._IExpression _2371_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2372_onString;
            bool _2373_onOwned;
            bool _2374_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2375_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1488;
            bool _out1489;
            bool _out1490;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1491;
            DCOMP.COMP.GenExpr(_2371_on, selfIdent, @params, false, out _out1488, out _out1489, out _out1490, out _out1491);
            _2372_onString = _out1488;
            _2373_onOwned = _out1489;
            _2374_onErased = _out1490;
            _2375_recIdents = _out1491;
            if (!(_2374_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2376_eraseFn;
              _2376_eraseFn = ((_2373_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2372_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2376_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2372_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2368_isDatatype) || (_2369_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2372_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2370_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2369_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2372_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2370_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2375_recIdents;
          }
        } else if (_source73.is_Select) {
          DAST._IExpression _2377___mcc_h93 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2378___mcc_h94 = _source73.dtor_field;
          bool _2379___mcc_h95 = _source73.dtor_isConstant;
          bool _2380___mcc_h96 = _source73.dtor_onDatatype;
          bool _2381_isDatatype = _2206___mcc_h38;
          bool _2382_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2383_field = _2204___mcc_h36;
          DAST._IExpression _2384_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2385_onString;
            bool _2386_onOwned;
            bool _2387_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2388_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1492;
            bool _out1493;
            bool _out1494;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1495;
            DCOMP.COMP.GenExpr(_2384_on, selfIdent, @params, false, out _out1492, out _out1493, out _out1494, out _out1495);
            _2385_onString = _out1492;
            _2386_onOwned = _out1493;
            _2387_onErased = _out1494;
            _2388_recIdents = _out1495;
            if (!(_2387_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2389_eraseFn;
              _2389_eraseFn = ((_2386_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2385_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2389_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2385_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2381_isDatatype) || (_2382_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2385_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2383_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2382_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2385_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2383_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2388_recIdents;
          }
        } else if (_source73.is_SelectFn) {
          DAST._IExpression _2390___mcc_h101 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2391___mcc_h102 = _source73.dtor_field;
          bool _2392___mcc_h103 = _source73.dtor_onDatatype;
          bool _2393___mcc_h104 = _source73.dtor_isStatic;
          BigInteger _2394___mcc_h105 = _source73.dtor_arity;
          bool _2395_isDatatype = _2206___mcc_h38;
          bool _2396_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2397_field = _2204___mcc_h36;
          DAST._IExpression _2398_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2399_onString;
            bool _2400_onOwned;
            bool _2401_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2402_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1496;
            bool _out1497;
            bool _out1498;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1499;
            DCOMP.COMP.GenExpr(_2398_on, selfIdent, @params, false, out _out1496, out _out1497, out _out1498, out _out1499);
            _2399_onString = _out1496;
            _2400_onOwned = _out1497;
            _2401_onErased = _out1498;
            _2402_recIdents = _out1499;
            if (!(_2401_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2403_eraseFn;
              _2403_eraseFn = ((_2400_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2399_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2403_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2399_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2395_isDatatype) || (_2396_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2399_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2397_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2396_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2399_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2397_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2402_recIdents;
          }
        } else if (_source73.is_Index) {
          DAST._IExpression _2404___mcc_h111 = _source73.dtor_expr;
          DAST._ICollKind _2405___mcc_h112 = _source73.dtor_collKind;
          Dafny.ISequence<DAST._IExpression> _2406___mcc_h113 = _source73.dtor_indices;
          bool _2407_isDatatype = _2206___mcc_h38;
          bool _2408_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2409_field = _2204___mcc_h36;
          DAST._IExpression _2410_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2411_onString;
            bool _2412_onOwned;
            bool _2413_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2414_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1500;
            bool _out1501;
            bool _out1502;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1503;
            DCOMP.COMP.GenExpr(_2410_on, selfIdent, @params, false, out _out1500, out _out1501, out _out1502, out _out1503);
            _2411_onString = _out1500;
            _2412_onOwned = _out1501;
            _2413_onErased = _out1502;
            _2414_recIdents = _out1503;
            if (!(_2413_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2415_eraseFn;
              _2415_eraseFn = ((_2412_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2411_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2415_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2411_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2407_isDatatype) || (_2408_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2411_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2409_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2408_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2411_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2409_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2414_recIdents;
          }
        } else if (_source73.is_IndexRange) {
          DAST._IExpression _2416___mcc_h117 = _source73.dtor_expr;
          bool _2417___mcc_h118 = _source73.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2418___mcc_h119 = _source73.dtor_low;
          DAST._IOptional<DAST._IExpression> _2419___mcc_h120 = _source73.dtor_high;
          bool _2420_isDatatype = _2206___mcc_h38;
          bool _2421_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2422_field = _2204___mcc_h36;
          DAST._IExpression _2423_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2424_onString;
            bool _2425_onOwned;
            bool _2426_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2427_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1504;
            bool _out1505;
            bool _out1506;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1507;
            DCOMP.COMP.GenExpr(_2423_on, selfIdent, @params, false, out _out1504, out _out1505, out _out1506, out _out1507);
            _2424_onString = _out1504;
            _2425_onOwned = _out1505;
            _2426_onErased = _out1506;
            _2427_recIdents = _out1507;
            if (!(_2426_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2428_eraseFn;
              _2428_eraseFn = ((_2425_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2424_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2428_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2424_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2420_isDatatype) || (_2421_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2424_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2422_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2421_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2424_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2422_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2427_recIdents;
          }
        } else if (_source73.is_TupleSelect) {
          DAST._IExpression _2429___mcc_h125 = _source73.dtor_expr;
          BigInteger _2430___mcc_h126 = _source73.dtor_index;
          bool _2431_isDatatype = _2206___mcc_h38;
          bool _2432_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2433_field = _2204___mcc_h36;
          DAST._IExpression _2434_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2435_onString;
            bool _2436_onOwned;
            bool _2437_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2438_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1508;
            bool _out1509;
            bool _out1510;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1511;
            DCOMP.COMP.GenExpr(_2434_on, selfIdent, @params, false, out _out1508, out _out1509, out _out1510, out _out1511);
            _2435_onString = _out1508;
            _2436_onOwned = _out1509;
            _2437_onErased = _out1510;
            _2438_recIdents = _out1511;
            if (!(_2437_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2439_eraseFn;
              _2439_eraseFn = ((_2436_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2435_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2439_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2435_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2431_isDatatype) || (_2432_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2435_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2433_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2432_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2435_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2433_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2438_recIdents;
          }
        } else if (_source73.is_Call) {
          DAST._IExpression _2440___mcc_h129 = _source73.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2441___mcc_h130 = _source73.dtor_name;
          Dafny.ISequence<DAST._IType> _2442___mcc_h131 = _source73.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2443___mcc_h132 = _source73.dtor_args;
          bool _2444_isDatatype = _2206___mcc_h38;
          bool _2445_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2446_field = _2204___mcc_h36;
          DAST._IExpression _2447_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2448_onString;
            bool _2449_onOwned;
            bool _2450_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2451_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1512;
            bool _out1513;
            bool _out1514;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1515;
            DCOMP.COMP.GenExpr(_2447_on, selfIdent, @params, false, out _out1512, out _out1513, out _out1514, out _out1515);
            _2448_onString = _out1512;
            _2449_onOwned = _out1513;
            _2450_onErased = _out1514;
            _2451_recIdents = _out1515;
            if (!(_2450_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2452_eraseFn;
              _2452_eraseFn = ((_2449_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2448_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2452_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2448_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2444_isDatatype) || (_2445_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2448_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2446_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2445_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2448_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2446_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2451_recIdents;
          }
        } else if (_source73.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2453___mcc_h137 = _source73.dtor_params;
          DAST._IType _2454___mcc_h138 = _source73.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2455___mcc_h139 = _source73.dtor_body;
          bool _2456_isDatatype = _2206___mcc_h38;
          bool _2457_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2458_field = _2204___mcc_h36;
          DAST._IExpression _2459_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2460_onString;
            bool _2461_onOwned;
            bool _2462_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2463_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1516;
            bool _out1517;
            bool _out1518;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1519;
            DCOMP.COMP.GenExpr(_2459_on, selfIdent, @params, false, out _out1516, out _out1517, out _out1518, out _out1519);
            _2460_onString = _out1516;
            _2461_onOwned = _out1517;
            _2462_onErased = _out1518;
            _2463_recIdents = _out1519;
            if (!(_2462_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2464_eraseFn;
              _2464_eraseFn = ((_2461_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2460_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2464_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2460_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2456_isDatatype) || (_2457_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2460_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2458_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2457_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2460_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2458_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2463_recIdents;
          }
        } else if (_source73.is_BetaRedex) {
          Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2465___mcc_h143 = _source73.dtor_values;
          DAST._IType _2466___mcc_h144 = _source73.dtor_retType;
          DAST._IExpression _2467___mcc_h145 = _source73.dtor_expr;
          bool _2468_isDatatype = _2206___mcc_h38;
          bool _2469_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2470_field = _2204___mcc_h36;
          DAST._IExpression _2471_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2472_onString;
            bool _2473_onOwned;
            bool _2474_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2475_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1520;
            bool _out1521;
            bool _out1522;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1523;
            DCOMP.COMP.GenExpr(_2471_on, selfIdent, @params, false, out _out1520, out _out1521, out _out1522, out _out1523);
            _2472_onString = _out1520;
            _2473_onOwned = _out1521;
            _2474_onErased = _out1522;
            _2475_recIdents = _out1523;
            if (!(_2474_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2476_eraseFn;
              _2476_eraseFn = ((_2473_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2472_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2476_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2472_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2468_isDatatype) || (_2469_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2472_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2470_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2469_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2472_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2470_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2475_recIdents;
          }
        } else if (_source73.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2477___mcc_h149 = _source73.dtor_name;
          DAST._IType _2478___mcc_h150 = _source73.dtor_typ;
          DAST._IExpression _2479___mcc_h151 = _source73.dtor_value;
          DAST._IExpression _2480___mcc_h152 = _source73.dtor_iifeBody;
          bool _2481_isDatatype = _2206___mcc_h38;
          bool _2482_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2483_field = _2204___mcc_h36;
          DAST._IExpression _2484_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2485_onString;
            bool _2486_onOwned;
            bool _2487_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2488_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1524;
            bool _out1525;
            bool _out1526;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1527;
            DCOMP.COMP.GenExpr(_2484_on, selfIdent, @params, false, out _out1524, out _out1525, out _out1526, out _out1527);
            _2485_onString = _out1524;
            _2486_onOwned = _out1525;
            _2487_onErased = _out1526;
            _2488_recIdents = _out1527;
            if (!(_2487_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2489_eraseFn;
              _2489_eraseFn = ((_2486_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2485_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2489_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2485_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2481_isDatatype) || (_2482_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2485_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2483_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2482_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2485_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2483_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2488_recIdents;
          }
        } else if (_source73.is_Apply) {
          DAST._IExpression _2490___mcc_h157 = _source73.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2491___mcc_h158 = _source73.dtor_args;
          bool _2492_isDatatype = _2206___mcc_h38;
          bool _2493_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2494_field = _2204___mcc_h36;
          DAST._IExpression _2495_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2496_onString;
            bool _2497_onOwned;
            bool _2498_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2499_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1528;
            bool _out1529;
            bool _out1530;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1531;
            DCOMP.COMP.GenExpr(_2495_on, selfIdent, @params, false, out _out1528, out _out1529, out _out1530, out _out1531);
            _2496_onString = _out1528;
            _2497_onOwned = _out1529;
            _2498_onErased = _out1530;
            _2499_recIdents = _out1531;
            if (!(_2498_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2500_eraseFn;
              _2500_eraseFn = ((_2497_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2496_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2500_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2496_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2492_isDatatype) || (_2493_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2496_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2494_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2493_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2496_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2494_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2499_recIdents;
          }
        } else if (_source73.is_TypeTest) {
          DAST._IExpression _2501___mcc_h161 = _source73.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2502___mcc_h162 = _source73.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2503___mcc_h163 = _source73.dtor_variant;
          bool _2504_isDatatype = _2206___mcc_h38;
          bool _2505_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2506_field = _2204___mcc_h36;
          DAST._IExpression _2507_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2508_onString;
            bool _2509_onOwned;
            bool _2510_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2511_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1532;
            bool _out1533;
            bool _out1534;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1535;
            DCOMP.COMP.GenExpr(_2507_on, selfIdent, @params, false, out _out1532, out _out1533, out _out1534, out _out1535);
            _2508_onString = _out1532;
            _2509_onOwned = _out1533;
            _2510_onErased = _out1534;
            _2511_recIdents = _out1535;
            if (!(_2510_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2512_eraseFn;
              _2512_eraseFn = ((_2509_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2508_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2512_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2508_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2504_isDatatype) || (_2505_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2508_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2506_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2505_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2508_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2506_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2511_recIdents;
          }
        } else if (_source73.is_InitializationValue) {
          DAST._IType _2513___mcc_h167 = _source73.dtor_typ;
          bool _2514_isDatatype = _2206___mcc_h38;
          bool _2515_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2516_field = _2204___mcc_h36;
          DAST._IExpression _2517_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2518_onString;
            bool _2519_onOwned;
            bool _2520_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2521_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1536;
            bool _out1537;
            bool _out1538;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1539;
            DCOMP.COMP.GenExpr(_2517_on, selfIdent, @params, false, out _out1536, out _out1537, out _out1538, out _out1539);
            _2518_onString = _out1536;
            _2519_onOwned = _out1537;
            _2520_onErased = _out1538;
            _2521_recIdents = _out1539;
            if (!(_2520_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2522_eraseFn;
              _2522_eraseFn = ((_2519_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2518_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2522_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2518_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2514_isDatatype) || (_2515_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2518_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2516_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2515_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2518_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2516_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2521_recIdents;
          }
        } else if (_source73.is_BoolBoundedPool) {
          bool _2523_isDatatype = _2206___mcc_h38;
          bool _2524_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2525_field = _2204___mcc_h36;
          DAST._IExpression _2526_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2527_onString;
            bool _2528_onOwned;
            bool _2529_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2530_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1540;
            bool _out1541;
            bool _out1542;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1543;
            DCOMP.COMP.GenExpr(_2526_on, selfIdent, @params, false, out _out1540, out _out1541, out _out1542, out _out1543);
            _2527_onString = _out1540;
            _2528_onOwned = _out1541;
            _2529_onErased = _out1542;
            _2530_recIdents = _out1543;
            if (!(_2529_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2531_eraseFn;
              _2531_eraseFn = ((_2528_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2527_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2531_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2527_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2523_isDatatype) || (_2524_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2527_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2525_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2524_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2527_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2525_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2530_recIdents;
          }
        } else {
          DAST._IExpression _2532___mcc_h169 = _source73.dtor_lo;
          DAST._IExpression _2533___mcc_h170 = _source73.dtor_hi;
          bool _2534_isDatatype = _2206___mcc_h38;
          bool _2535_isConstant = _2205___mcc_h37;
          Dafny.ISequence<Dafny.Rune> _2536_field = _2204___mcc_h36;
          DAST._IExpression _2537_on = _2203___mcc_h35;
          {
            Dafny.ISequence<Dafny.Rune> _2538_onString;
            bool _2539_onOwned;
            bool _2540_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2541_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1544;
            bool _out1545;
            bool _out1546;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1547;
            DCOMP.COMP.GenExpr(_2537_on, selfIdent, @params, false, out _out1544, out _out1545, out _out1546, out _out1547);
            _2538_onString = _out1544;
            _2539_onOwned = _out1545;
            _2540_onErased = _out1546;
            _2541_recIdents = _out1547;
            if (!(_2540_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2542_eraseFn;
              _2542_eraseFn = ((_2539_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2538_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2542_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2538_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2534_isDatatype) || (_2535_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2538_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2536_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2535_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2538_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2536_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2541_recIdents;
          }
        }
      } else if (_source21.is_SelectFn) {
        DAST._IExpression _2543___mcc_h173 = _source21.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2544___mcc_h174 = _source21.dtor_field;
        bool _2545___mcc_h175 = _source21.dtor_onDatatype;
        bool _2546___mcc_h176 = _source21.dtor_isStatic;
        BigInteger _2547___mcc_h177 = _source21.dtor_arity;
        BigInteger _2548_arity = _2547___mcc_h177;
        bool _2549_isStatic = _2546___mcc_h176;
        bool _2550_isDatatype = _2545___mcc_h175;
        Dafny.ISequence<Dafny.Rune> _2551_field = _2544___mcc_h174;
        DAST._IExpression _2552_on = _2543___mcc_h173;
        {
          Dafny.ISequence<Dafny.Rune> _2553_onString;
          bool _2554_onOwned;
          bool _2555___v81;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2556_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1548;
          bool _out1549;
          bool _out1550;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1551;
          DCOMP.COMP.GenExpr(_2552_on, selfIdent, @params, false, out _out1548, out _out1549, out _out1550, out _out1551);
          _2553_onString = _out1548;
          _2554_onOwned = _out1549;
          _2555___v81 = _out1550;
          _2556_recIdents = _out1551;
          if (_2549_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2553_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2551_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2553_onString), ((_2554_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2557_args;
            _2557_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2558_i;
            _2558_i = BigInteger.Zero;
            while ((_2558_i) < (_2548_arity)) {
              if ((_2558_i).Sign == 1) {
                _2557_args = Dafny.Sequence<Dafny.Rune>.Concat(_2557_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2557_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2557_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2558_i));
              _2558_i = (_2558_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2557_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2551_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2557_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper(::std::rc::Rc::new("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
          readIdents = _2556_recIdents;
        }
      } else if (_source21.is_Index) {
        DAST._IExpression _2559___mcc_h178 = _source21.dtor_expr;
        DAST._ICollKind _2560___mcc_h179 = _source21.dtor_collKind;
        Dafny.ISequence<DAST._IExpression> _2561___mcc_h180 = _source21.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2562_indices = _2561___mcc_h180;
        DAST._ICollKind _2563_collKind = _2560___mcc_h179;
        DAST._IExpression _2564_on = _2559___mcc_h178;
        {
          Dafny.ISequence<Dafny.Rune> _2565_onString;
          bool _2566_onOwned;
          bool _2567_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2568_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1552;
          bool _out1553;
          bool _out1554;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1555;
          DCOMP.COMP.GenExpr(_2564_on, selfIdent, @params, false, out _out1552, out _out1553, out _out1554, out _out1555);
          _2565_onString = _out1552;
          _2566_onOwned = _out1553;
          _2567_onErased = _out1554;
          _2568_recIdents = _out1555;
          readIdents = _2568_recIdents;
          if (!(_2567_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2569_eraseFn;
            _2569_eraseFn = ((_2566_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2565_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2569_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2565_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2565_onString;
          BigInteger _2570_i;
          _2570_i = BigInteger.Zero;
          while ((_2570_i) < (new BigInteger((_2562_indices).Count))) {
            if (object.Equals(_2563_collKind, DAST.CollKind.create_Array())) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            if (object.Equals(_2563_collKind, DAST.CollKind.create_Map())) {
              Dafny.ISequence<Dafny.Rune> _2571_idx;
              bool _2572_idxOwned;
              bool _2573_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2574_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1556;
              bool _out1557;
              bool _out1558;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1559;
              DCOMP.COMP.GenExpr((_2562_indices).Select(_2570_i), selfIdent, @params, false, out _out1556, out _out1557, out _out1558, out _out1559);
              _2571_idx = _out1556;
              _2572_idxOwned = _out1557;
              _2573_idxErased = _out1558;
              _2574_recIdentsIdx = _out1559;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[")), ((_2572_idxOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _2571_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2574_recIdentsIdx);
            } else {
              Dafny.ISequence<Dafny.Rune> _2575_idx;
              bool _2576___v82;
              bool _2577_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2578_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1560;
              bool _out1561;
              bool _out1562;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1563;
              DCOMP.COMP.GenExpr((_2562_indices).Select(_2570_i), selfIdent, @params, true, out _out1560, out _out1561, out _out1562, out _out1563);
              _2575_idx = _out1560;
              _2576___v82 = _out1561;
              _2577_idxErased = _out1562;
              _2578_recIdentsIdx = _out1563;
              if (!(_2577_idxErased)) {
                _2575_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2575_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[<usize as ::dafny_runtime::NumCast>::from(")), _2575_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2578_recIdentsIdx);
            }
            _2570_i = (_2570_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2567_onErased;
        }
      } else if (_source21.is_IndexRange) {
        DAST._IExpression _2579___mcc_h181 = _source21.dtor_expr;
        bool _2580___mcc_h182 = _source21.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2581___mcc_h183 = _source21.dtor_low;
        DAST._IOptional<DAST._IExpression> _2582___mcc_h184 = _source21.dtor_high;
        DAST._IOptional<DAST._IExpression> _2583_high = _2582___mcc_h184;
        DAST._IOptional<DAST._IExpression> _2584_low = _2581___mcc_h183;
        bool _2585_isArray = _2580___mcc_h182;
        DAST._IExpression _2586_on = _2579___mcc_h181;
        {
          Dafny.ISequence<Dafny.Rune> _2587_onString;
          bool _2588_onOwned;
          bool _2589_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2590_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1564;
          bool _out1565;
          bool _out1566;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1567;
          DCOMP.COMP.GenExpr(_2586_on, selfIdent, @params, false, out _out1564, out _out1565, out _out1566, out _out1567);
          _2587_onString = _out1564;
          _2588_onOwned = _out1565;
          _2589_onErased = _out1566;
          _2590_recIdents = _out1567;
          readIdents = _2590_recIdents;
          if (!(_2589_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2591_eraseFn;
            _2591_eraseFn = ((_2588_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2587_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2591_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2587_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2587_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2592_lowString;
          _2592_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source74 = _2584_low;
          if (_source74.is_Some) {
            DAST._IExpression _2593___mcc_h1122 = _source74.dtor_Some_a0;
            DAST._IExpression _2594_l = _2593___mcc_h1122;
            {
              Dafny.ISequence<Dafny.Rune> _2595_lString;
              bool _2596___v83;
              bool _2597_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2598_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1568;
              bool _out1569;
              bool _out1570;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1571;
              DCOMP.COMP.GenExpr(_2594_l, selfIdent, @params, true, out _out1568, out _out1569, out _out1570, out _out1571);
              _2595_lString = _out1568;
              _2596___v83 = _out1569;
              _2597_lErased = _out1570;
              _2598_recIdentsL = _out1571;
              if (!(_2597_lErased)) {
                _2595_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2595_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2592_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2595_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2598_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2599_highString;
          _2599_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source75 = _2583_high;
          if (_source75.is_Some) {
            DAST._IExpression _2600___mcc_h1123 = _source75.dtor_Some_a0;
            DAST._IExpression _2601_h = _2600___mcc_h1123;
            {
              Dafny.ISequence<Dafny.Rune> _2602_hString;
              bool _2603___v84;
              bool _2604_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2605_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1572;
              bool _out1573;
              bool _out1574;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1575;
              DCOMP.COMP.GenExpr(_2601_h, selfIdent, @params, true, out _out1572, out _out1573, out _out1574, out _out1575);
              _2602_hString = _out1572;
              _2603___v84 = _out1573;
              _2604_hErased = _out1574;
              _2605_recIdentsH = _out1575;
              if (!(_2604_hErased)) {
                _2602_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2602_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2599_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2602_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2605_recIdentsH);
            }
          } else {
          }
          if (_2585_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source76) => {
            if (_source76.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2606___mcc_h1124 = _source76.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2606___mcc_h1124, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2607_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2607_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2592_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source77) => {
            if (_source77.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2608___mcc_h1125 = _source77.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2608___mcc_h1125, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2609_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2609_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2599_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2589_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source21.is_TupleSelect) {
        DAST._IExpression _2610___mcc_h185 = _source21.dtor_expr;
        BigInteger _2611___mcc_h186 = _source21.dtor_index;
        BigInteger _2612_idx = _2611___mcc_h186;
        DAST._IExpression _2613_on = _2610___mcc_h185;
        {
          Dafny.ISequence<Dafny.Rune> _2614_onString;
          bool _2615___v85;
          bool _2616_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2617_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1576;
          bool _out1577;
          bool _out1578;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1579;
          DCOMP.COMP.GenExpr(_2613_on, selfIdent, @params, false, out _out1576, out _out1577, out _out1578, out _out1579);
          _2614_onString = _out1576;
          _2615___v85 = _out1577;
          _2616_tupErased = _out1578;
          _2617_recIdents = _out1579;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2614_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2612_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2616_tupErased;
          readIdents = _2617_recIdents;
        }
      } else if (_source21.is_Call) {
        DAST._IExpression _2618___mcc_h187 = _source21.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2619___mcc_h188 = _source21.dtor_name;
        Dafny.ISequence<DAST._IType> _2620___mcc_h189 = _source21.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2621___mcc_h190 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2622_args = _2621___mcc_h190;
        Dafny.ISequence<DAST._IType> _2623_typeArgs = _2620___mcc_h189;
        Dafny.ISequence<Dafny.Rune> _2624_name = _2619___mcc_h188;
        DAST._IExpression _2625_on = _2618___mcc_h187;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2626_typeArgString;
          _2626_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2623_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2627_typeI;
            _2627_typeI = BigInteger.Zero;
            _2626_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2627_typeI) < (new BigInteger((_2623_typeArgs).Count))) {
              if ((_2627_typeI).Sign == 1) {
                _2626_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2626_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2628_typeString;
              Dafny.ISequence<Dafny.Rune> _out1580;
              _out1580 = DCOMP.COMP.GenType((_2623_typeArgs).Select(_2627_typeI), false, false);
              _2628_typeString = _out1580;
              _2626_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2626_typeArgString, _2628_typeString);
              _2627_typeI = (_2627_typeI) + (BigInteger.One);
            }
            _2626_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2626_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2629_argString;
          _2629_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2630_i;
          _2630_i = BigInteger.Zero;
          while ((_2630_i) < (new BigInteger((_2622_args).Count))) {
            if ((_2630_i).Sign == 1) {
              _2629_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2629_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2631_argExpr;
            bool _2632_isOwned;
            bool _2633_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2634_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1581;
            bool _out1582;
            bool _out1583;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1584;
            DCOMP.COMP.GenExpr((_2622_args).Select(_2630_i), selfIdent, @params, false, out _out1581, out _out1582, out _out1583, out _out1584);
            _2631_argExpr = _out1581;
            _2632_isOwned = _out1582;
            _2633_argErased = _out1583;
            _2634_argIdents = _out1584;
            if (_2632_isOwned) {
              _2631_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2631_argExpr);
            }
            _2629_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2629_argString, _2631_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2634_argIdents);
            _2630_i = (_2630_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2635_enclosingString;
          bool _2636___v86;
          bool _2637___v87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2638_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1585;
          bool _out1586;
          bool _out1587;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1588;
          DCOMP.COMP.GenExpr(_2625_on, selfIdent, @params, false, out _out1585, out _out1586, out _out1587, out _out1588);
          _2635_enclosingString = _out1585;
          _2636___v86 = _out1586;
          _2637___v87 = _out1587;
          _2638_recIdents = _out1588;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2638_recIdents);
          DAST._IExpression _source78 = _2625_on;
          if (_source78.is_Literal) {
            DAST._ILiteral _2639___mcc_h1126 = _source78.dtor_Literal_a0;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2640___mcc_h1128 = _source78.dtor_Ident_a0;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2641___mcc_h1130 = _source78.dtor_Companion_a0;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2635_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (_2624_name));
            }
          } else if (_source78.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2642___mcc_h1132 = _source78.dtor_Tuple_a0;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2643___mcc_h1134 = _source78.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2644___mcc_h1135 = _source78.dtor_args;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2645___mcc_h1138 = _source78.dtor_dims;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2646___mcc_h1140 = _source78.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2647___mcc_h1141 = _source78.dtor_variant;
            bool _2648___mcc_h1142 = _source78.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2649___mcc_h1143 = _source78.dtor_contents;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Convert) {
            DAST._IExpression _2650___mcc_h1148 = _source78.dtor_value;
            DAST._IType _2651___mcc_h1149 = _source78.dtor_from;
            DAST._IType _2652___mcc_h1150 = _source78.dtor_typ;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2653___mcc_h1154 = _source78.dtor_elements;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2654___mcc_h1156 = _source78.dtor_elements;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2655___mcc_h1158 = _source78.dtor_mapElems;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_This) {
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Ite) {
            DAST._IExpression _2656___mcc_h1160 = _source78.dtor_cond;
            DAST._IExpression _2657___mcc_h1161 = _source78.dtor_thn;
            DAST._IExpression _2658___mcc_h1162 = _source78.dtor_els;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_UnOp) {
            DAST._IUnaryOp _2659___mcc_h1166 = _source78.dtor_unOp;
            DAST._IExpression _2660___mcc_h1167 = _source78.dtor_expr;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2661___mcc_h1170 = _source78.dtor_op;
            DAST._IExpression _2662___mcc_h1171 = _source78.dtor_left;
            DAST._IExpression _2663___mcc_h1172 = _source78.dtor_right;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_ArrayLen) {
            DAST._IExpression _2664___mcc_h1176 = _source78.dtor_expr;
            BigInteger _2665___mcc_h1177 = _source78.dtor_dim;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Select) {
            DAST._IExpression _2666___mcc_h1180 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2667___mcc_h1181 = _source78.dtor_field;
            bool _2668___mcc_h1182 = _source78.dtor_isConstant;
            bool _2669___mcc_h1183 = _source78.dtor_onDatatype;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_SelectFn) {
            DAST._IExpression _2670___mcc_h1188 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2671___mcc_h1189 = _source78.dtor_field;
            bool _2672___mcc_h1190 = _source78.dtor_onDatatype;
            bool _2673___mcc_h1191 = _source78.dtor_isStatic;
            BigInteger _2674___mcc_h1192 = _source78.dtor_arity;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Index) {
            DAST._IExpression _2675___mcc_h1198 = _source78.dtor_expr;
            DAST._ICollKind _2676___mcc_h1199 = _source78.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _2677___mcc_h1200 = _source78.dtor_indices;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_IndexRange) {
            DAST._IExpression _2678___mcc_h1204 = _source78.dtor_expr;
            bool _2679___mcc_h1205 = _source78.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _2680___mcc_h1206 = _source78.dtor_low;
            DAST._IOptional<DAST._IExpression> _2681___mcc_h1207 = _source78.dtor_high;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_TupleSelect) {
            DAST._IExpression _2682___mcc_h1212 = _source78.dtor_expr;
            BigInteger _2683___mcc_h1213 = _source78.dtor_index;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Call) {
            DAST._IExpression _2684___mcc_h1216 = _source78.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2685___mcc_h1217 = _source78.dtor_name;
            Dafny.ISequence<DAST._IType> _2686___mcc_h1218 = _source78.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2687___mcc_h1219 = _source78.dtor_args;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2688___mcc_h1224 = _source78.dtor_params;
            DAST._IType _2689___mcc_h1225 = _source78.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2690___mcc_h1226 = _source78.dtor_body;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2691___mcc_h1230 = _source78.dtor_values;
            DAST._IType _2692___mcc_h1231 = _source78.dtor_retType;
            DAST._IExpression _2693___mcc_h1232 = _source78.dtor_expr;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2694___mcc_h1236 = _source78.dtor_name;
            DAST._IType _2695___mcc_h1237 = _source78.dtor_typ;
            DAST._IExpression _2696___mcc_h1238 = _source78.dtor_value;
            DAST._IExpression _2697___mcc_h1239 = _source78.dtor_iifeBody;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_Apply) {
            DAST._IExpression _2698___mcc_h1244 = _source78.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2699___mcc_h1245 = _source78.dtor_args;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_TypeTest) {
            DAST._IExpression _2700___mcc_h1248 = _source78.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2701___mcc_h1249 = _source78.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2702___mcc_h1250 = _source78.dtor_variant;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_InitializationValue) {
            DAST._IType _2703___mcc_h1254 = _source78.dtor_typ;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else if (_source78.is_BoolBoundedPool) {
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          } else {
            DAST._IExpression _2704___mcc_h1256 = _source78.dtor_lo;
            DAST._IExpression _2705___mcc_h1257 = _source78.dtor_hi;
            {
              _2635_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2635_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2624_name));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2635_enclosingString, _2626_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2629_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2706___mcc_h191 = _source21.dtor_params;
        DAST._IType _2707___mcc_h192 = _source21.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2708___mcc_h193 = _source21.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2709_body = _2708___mcc_h193;
        DAST._IType _2710_retType = _2707___mcc_h192;
        Dafny.ISequence<DAST._IFormal> _2711_params = _2706___mcc_h191;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2712_paramNames;
          _2712_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2713_i;
          _2713_i = BigInteger.Zero;
          while ((_2713_i) < (new BigInteger((_2711_params).Count))) {
            _2712_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2712_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2711_params).Select(_2713_i)).dtor_name));
            _2713_i = (_2713_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2714_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2715_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1589;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1590;
          DCOMP.COMP.GenStmts(_2709_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2712_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1589, out _out1590);
          _2714_recursiveGen = _out1589;
          _2715_recIdents = _out1590;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2716_allReadCloned;
          _2716_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2715_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2717_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2715_recIdents).Elements) {
              _2717_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2715_recIdents).Contains(_2717_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1813)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2712_paramNames).Contains(_2717_next))) {
              _2716_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2716_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2717_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2717_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2717_next));
            }
            _2715_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2715_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2717_next));
          }
          Dafny.ISequence<Dafny.Rune> _2718_paramsString;
          _2718_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          Dafny.ISequence<Dafny.Rune> _2719_paramTypes;
          _2719_paramTypes = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2713_i = BigInteger.Zero;
          while ((_2713_i) < (new BigInteger((_2711_params).Count))) {
            if ((_2713_i).Sign == 1) {
              _2718_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2718_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              _2719_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(_2719_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2720_typStr;
            Dafny.ISequence<Dafny.Rune> _out1591;
            _out1591 = DCOMP.COMP.GenType(((_2711_params).Select(_2713_i)).dtor_typ, false, true);
            _2720_typStr = _out1591;
            _2718_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2718_paramsString, ((_2711_params).Select(_2713_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2720_typStr);
            _2719_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2719_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _2720_typStr);
            _2713_i = (_2713_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2721_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1592;
          _out1592 = DCOMP.COMP.GenType(_2710_retType, false, true);
          _2721_retTypeGen = _out1592;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper::<::std::rc::Rc<dyn Fn("), _2719_paramTypes), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _2721_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>({\n")), _2716_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(move |")), _2718_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2721_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_BetaRedex) {
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2722___mcc_h194 = _source21.dtor_values;
        DAST._IType _2723___mcc_h195 = _source21.dtor_retType;
        DAST._IExpression _2724___mcc_h196 = _source21.dtor_expr;
        DAST._IExpression _2725_expr = _2724___mcc_h196;
        DAST._IType _2726_retType = _2723___mcc_h195;
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2727_values = _2722___mcc_h194;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2728_paramNames;
          _2728_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2729_paramNamesSet;
          _2729_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2730_i;
          _2730_i = BigInteger.Zero;
          while ((_2730_i) < (new BigInteger((_2727_values).Count))) {
            _2728_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2728_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2727_values).Select(_2730_i)).dtor__0).dtor_name));
            _2729_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2729_paramNamesSet, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2727_values).Select(_2730_i)).dtor__0).dtor_name));
            _2730_i = (_2730_i) + (BigInteger.One);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          Dafny.ISequence<Dafny.Rune> _2731_paramsString;
          _2731_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2730_i = BigInteger.Zero;
          while ((_2730_i) < (new BigInteger((_2727_values).Count))) {
            if ((_2730_i).Sign == 1) {
              _2731_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2731_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2732_typStr;
            Dafny.ISequence<Dafny.Rune> _out1593;
            _out1593 = DCOMP.COMP.GenType((((_2727_values).Select(_2730_i)).dtor__0).dtor_typ, false, true);
            _2732_typStr = _out1593;
            Dafny.ISequence<Dafny.Rune> _2733_valueGen;
            bool _2734___v90;
            bool _2735_valueErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2736_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1594;
            bool _out1595;
            bool _out1596;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1597;
            DCOMP.COMP.GenExpr(((_2727_values).Select(_2730_i)).dtor__1, selfIdent, @params, true, out _out1594, out _out1595, out _out1596, out _out1597);
            _2733_valueGen = _out1594;
            _2734___v90 = _out1595;
            _2735_valueErased = _out1596;
            _2736_recIdents = _out1597;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), (((_2727_values).Select(_2730_i)).dtor__0).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _2732_typStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2736_recIdents);
            if (_2735_valueErased) {
              _2733_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2733_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2733_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            _2730_i = (_2730_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2737_recGen;
          bool _2738_recOwned;
          bool _2739_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2740_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1598;
          bool _out1599;
          bool _out1600;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1601;
          DCOMP.COMP.GenExpr(_2725_expr, selfIdent, _2728_paramNames, mustOwn, out _out1598, out _out1599, out _out1600, out _out1601);
          _2737_recGen = _out1598;
          _2738_recOwned = _out1599;
          _2739_recErased = _out1600;
          _2740_recIdents = _out1601;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2740_recIdents, _2729_paramNamesSet);
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2737_recGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2738_recOwned;
          isErased = _2739_recErased;
        }
      } else if (_source21.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2741___mcc_h197 = _source21.dtor_name;
        DAST._IType _2742___mcc_h198 = _source21.dtor_typ;
        DAST._IExpression _2743___mcc_h199 = _source21.dtor_value;
        DAST._IExpression _2744___mcc_h200 = _source21.dtor_iifeBody;
        DAST._IExpression _2745_iifeBody = _2744___mcc_h200;
        DAST._IExpression _2746_value = _2743___mcc_h199;
        DAST._IType _2747_tpe = _2742___mcc_h198;
        Dafny.ISequence<Dafny.Rune> _2748_name = _2741___mcc_h197;
        {
          Dafny.ISequence<Dafny.Rune> _2749_valueGen;
          bool _2750_valueOwned;
          bool _2751_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2752_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1602;
          bool _out1603;
          bool _out1604;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1605;
          DCOMP.COMP.GenExpr(_2746_value, selfIdent, @params, false, out _out1602, out _out1603, out _out1604, out _out1605);
          _2749_valueGen = _out1602;
          _2750_valueOwned = _out1603;
          _2751_valueErased = _out1604;
          _2752_recIdents = _out1605;
          if (_2751_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2753_eraseFn;
            _2753_eraseFn = ((_2750_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2749_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2753_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2749_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2752_recIdents;
          Dafny.ISequence<Dafny.Rune> _2754_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1606;
          _out1606 = DCOMP.COMP.GenType(_2747_tpe, false, true);
          _2754_valueTypeGen = _out1606;
          Dafny.ISequence<Dafny.Rune> _2755_bodyGen;
          bool _2756_bodyOwned;
          bool _2757_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2758_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1607;
          bool _out1608;
          bool _out1609;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1610;
          DCOMP.COMP.GenExpr(_2745_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2750_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2748_name))))), mustOwn, out _out1607, out _out1608, out _out1609, out _out1610);
          _2755_bodyGen = _out1607;
          _2756_bodyOwned = _out1608;
          _2757_bodyErased = _out1609;
          _2758_bodyIdents = _out1610;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2758_bodyIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_2748_name))));
          Dafny.ISequence<Dafny.Rune> _2759_eraseFn;
          _2759_eraseFn = ((_2750_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2748_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2750_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2754_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2749_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2755_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2756_bodyOwned;
          isErased = _2757_bodyErased;
        }
      } else if (_source21.is_Apply) {
        DAST._IExpression _2760___mcc_h201 = _source21.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2761___mcc_h202 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2762_args = _2761___mcc_h202;
        DAST._IExpression _2763_func = _2760___mcc_h201;
        {
          Dafny.ISequence<Dafny.Rune> _2764_funcString;
          bool _2765___v91;
          bool _2766_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2767_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1611;
          bool _out1612;
          bool _out1613;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1614;
          DCOMP.COMP.GenExpr(_2763_func, selfIdent, @params, false, out _out1611, out _out1612, out _out1613, out _out1614);
          _2764_funcString = _out1611;
          _2765___v91 = _out1612;
          _2766_funcErased = _out1613;
          _2767_recIdents = _out1614;
          readIdents = _2767_recIdents;
          Dafny.ISequence<Dafny.Rune> _2768_argString;
          _2768_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2769_i;
          _2769_i = BigInteger.Zero;
          while ((_2769_i) < (new BigInteger((_2762_args).Count))) {
            if ((_2769_i).Sign == 1) {
              _2768_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2768_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2770_argExpr;
            bool _2771_isOwned;
            bool _2772_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2773_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1615;
            bool _out1616;
            bool _out1617;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1618;
            DCOMP.COMP.GenExpr((_2762_args).Select(_2769_i), selfIdent, @params, false, out _out1615, out _out1616, out _out1617, out _out1618);
            _2770_argExpr = _out1615;
            _2771_isOwned = _out1616;
            _2772_argErased = _out1617;
            _2773_argIdents = _out1618;
            if (_2771_isOwned) {
              _2770_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2770_argExpr);
            }
            _2768_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2768_argString, _2770_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2773_argIdents);
            _2769_i = (_2769_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2764_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2768_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_TypeTest) {
        DAST._IExpression _2774___mcc_h203 = _source21.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2775___mcc_h204 = _source21.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2776___mcc_h205 = _source21.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2777_variant = _2776___mcc_h205;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2778_dType = _2775___mcc_h204;
        DAST._IExpression _2779_on = _2774___mcc_h203;
        {
          Dafny.ISequence<Dafny.Rune> _2780_exprGen;
          bool _2781___v92;
          bool _2782_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2783_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1619;
          bool _out1620;
          bool _out1621;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1622;
          DCOMP.COMP.GenExpr(_2779_on, selfIdent, @params, false, out _out1619, out _out1620, out _out1621, out _out1622);
          _2780_exprGen = _out1619;
          _2781___v92 = _out1620;
          _2782_exprErased = _out1621;
          _2783_recIdents = _out1622;
          Dafny.ISequence<Dafny.Rune> _2784_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1623;
          _out1623 = DCOMP.COMP.GenPath(_2778_dType);
          _2784_dTypePath = _out1623;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2780_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2784_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2777_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2783_recIdents;
        }
      } else if (_source21.is_InitializationValue) {
        DAST._IType _2785___mcc_h206 = _source21.dtor_typ;
        DAST._IType _2786_typ = _2785___mcc_h206;
        {
          Dafny.ISequence<Dafny.Rune> _2787_typString;
          Dafny.ISequence<Dafny.Rune> _out1624;
          _out1624 = DCOMP.COMP.GenType(_2786_typ, false, false);
          _2787_typString = _out1624;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2787_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
          isOwned = true;
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source21.is_BoolBoundedPool) {
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[false, true]");
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else {
        DAST._IExpression _2788___mcc_h207 = _source21.dtor_lo;
        DAST._IExpression _2789___mcc_h208 = _source21.dtor_hi;
        DAST._IExpression _2790_hi = _2789___mcc_h208;
        DAST._IExpression _2791_lo = _2788___mcc_h207;
        {
          Dafny.ISequence<Dafny.Rune> _2792_loString;
          bool _2793___v93;
          bool _2794_loErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2795_recIdentsLo;
          Dafny.ISequence<Dafny.Rune> _out1625;
          bool _out1626;
          bool _out1627;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1628;
          DCOMP.COMP.GenExpr(_2791_lo, selfIdent, @params, true, out _out1625, out _out1626, out _out1627, out _out1628);
          _2792_loString = _out1625;
          _2793___v93 = _out1626;
          _2794_loErased = _out1627;
          _2795_recIdentsLo = _out1628;
          Dafny.ISequence<Dafny.Rune> _2796_hiString;
          bool _2797___v94;
          bool _2798_hiErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2799_recIdentsHi;
          Dafny.ISequence<Dafny.Rune> _out1629;
          bool _out1630;
          bool _out1631;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1632;
          DCOMP.COMP.GenExpr(_2790_hi, selfIdent, @params, true, out _out1629, out _out1630, out _out1631, out _out1632);
          _2796_hiString = _out1629;
          _2797___v94 = _out1630;
          _2798_hiErased = _out1631;
          _2799_recIdentsHi = _out1632;
          if (!(_2794_loErased)) {
            _2792_loString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2792_loString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2798_hiErased)) {
            _2796_hiString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2796_hiString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::integer_range("), _2792_loString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2796_hiString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2795_recIdentsLo, _2799_recIdentsHi);
        }
      }
    }
    public static Dafny.ISequence<Dafny.Rune> Compile(Dafny.ISequence<DAST._IModule> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#![allow(warnings, unconditional_panic)]\n");
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("extern crate dafny_runtime;\n"));
      BigInteger _2800_i;
      _2800_i = BigInteger.Zero;
      while ((_2800_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2801_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1633;
        _out1633 = DCOMP.COMP.GenModule((p).Select(_2800_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2801_generated = _out1633;
        if ((_2800_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2801_generated);
        _2800_i = (_2800_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2802_i;
      _2802_i = BigInteger.Zero;
      while ((_2802_i) < (new BigInteger((fullName).Count))) {
        if ((_2802_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2802_i));
        _2802_i = (_2802_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

