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

  public interface _IBinOp {
    bool is_In { get; }
    bool is_SetDifference { get; }
    bool is_Concat { get; }
    bool is_Passthrough { get; }
    Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0 { get; }
    _IBinOp DowncastClone();
  }
  public abstract class BinOp : _IBinOp {
    public BinOp() {
    }
    private static readonly DAST._IBinOp theDefault = create_In();
    public static DAST._IBinOp Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IBinOp> _TYPE = new Dafny.TypeDescriptor<DAST._IBinOp>(DAST.BinOp.Default());
    public static Dafny.TypeDescriptor<DAST._IBinOp> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IBinOp create_In() {
      return new BinOp_In();
    }
    public static _IBinOp create_SetDifference() {
      return new BinOp_SetDifference();
    }
    public static _IBinOp create_Concat() {
      return new BinOp_Concat();
    }
    public static _IBinOp create_Passthrough(Dafny.ISequence<Dafny.Rune> _a0) {
      return new BinOp_Passthrough(_a0);
    }
    public bool is_In { get { return this is BinOp_In; } }
    public bool is_SetDifference { get { return this is BinOp_SetDifference; } }
    public bool is_Concat { get { return this is BinOp_Concat; } }
    public bool is_Passthrough { get { return this is BinOp_Passthrough; } }
    public Dafny.ISequence<Dafny.Rune> dtor_Passthrough_a0 {
      get {
        var d = this;
        return ((BinOp_Passthrough)d)._a0;
      }
    }
    public abstract _IBinOp DowncastClone();
  }
  public class BinOp_In : BinOp {
    public BinOp_In() : base() {
    }
    public override _IBinOp DowncastClone() {
      if (this is _IBinOp dt) { return dt; }
      return new BinOp_In();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.BinOp_In;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.BinOp.In";
      return s;
    }
  }
  public class BinOp_SetDifference : BinOp {
    public BinOp_SetDifference() : base() {
    }
    public override _IBinOp DowncastClone() {
      if (this is _IBinOp dt) { return dt; }
      return new BinOp_SetDifference();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.BinOp_SetDifference;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 1;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.BinOp.SetDifference";
      return s;
    }
  }
  public class BinOp_Concat : BinOp {
    public BinOp_Concat() : base() {
    }
    public override _IBinOp DowncastClone() {
      if (this is _IBinOp dt) { return dt; }
      return new BinOp_Concat();
    }
    public override bool Equals(object other) {
      var oth = other as DAST.BinOp_Concat;
      return oth != null;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.BinOp.Concat";
      return s;
    }
  }
  public class BinOp_Passthrough : BinOp {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public BinOp_Passthrough(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _IBinOp DowncastClone() {
      if (this is _IBinOp dt) { return dt; }
      return new BinOp_Passthrough(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.BinOp_Passthrough;
      return oth != null && object.Equals(this._a0, oth._a0);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 3;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.BinOp.Passthrough";
      s += "(";
      s += this._a0.ToVerbatimString(true);
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
    bool is_Convert { get; }
    bool is_SeqConstruct { get; }
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
    bool is_SetBoundedPool { get; }
    bool is_SeqBoundedPool { get; }
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
    DAST._IExpression dtor_length { get; }
    DAST._IExpression dtor_elem { get; }
    Dafny.ISequence<DAST._IExpression> dtor_elements { get; }
    Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> dtor_mapElems { get; }
    DAST._IExpression dtor_cond { get; }
    DAST._IExpression dtor_thn { get; }
    DAST._IExpression dtor_els { get; }
    DAST._IUnaryOp dtor_unOp { get; }
    DAST._IExpression dtor_expr { get; }
    DAST._IBinOp dtor_op { get; }
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
    DAST._IExpression dtor_of { get; }
    bool dtor_includeDuplicates { get; }
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
    public static _IExpression create_SeqConstruct(DAST._IExpression length, DAST._IExpression elem) {
      return new Expression_SeqConstruct(length, elem);
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
    public static _IExpression create_BinOp(DAST._IBinOp op, DAST._IExpression left, DAST._IExpression right) {
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
    public static _IExpression create_SetBoundedPool(DAST._IExpression of) {
      return new Expression_SetBoundedPool(of);
    }
    public static _IExpression create_SeqBoundedPool(DAST._IExpression of, bool includeDuplicates) {
      return new Expression_SeqBoundedPool(of, includeDuplicates);
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
    public bool is_SeqConstruct { get { return this is Expression_SeqConstruct; } }
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
    public bool is_SetBoundedPool { get { return this is Expression_SetBoundedPool; } }
    public bool is_SeqBoundedPool { get { return this is Expression_SeqBoundedPool; } }
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
    public DAST._IExpression dtor_length {
      get {
        var d = this;
        return ((Expression_SeqConstruct)d)._length;
      }
    }
    public DAST._IExpression dtor_elem {
      get {
        var d = this;
        return ((Expression_SeqConstruct)d)._elem;
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
    public DAST._IBinOp dtor_op {
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
    public DAST._IExpression dtor_of {
      get {
        var d = this;
        if (d is Expression_SetBoundedPool) { return ((Expression_SetBoundedPool)d)._of; }
        return ((Expression_SeqBoundedPool)d)._of;
      }
    }
    public bool dtor_includeDuplicates {
      get {
        var d = this;
        return ((Expression_SeqBoundedPool)d)._includeDuplicates;
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
  public class Expression_SeqConstruct : Expression {
    public readonly DAST._IExpression _length;
    public readonly DAST._IExpression _elem;
    public Expression_SeqConstruct(DAST._IExpression length, DAST._IExpression elem) : base() {
      this._length = length;
      this._elem = elem;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SeqConstruct(_length, _elem);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SeqConstruct;
      return oth != null && object.Equals(this._length, oth._length) && object.Equals(this._elem, oth._elem);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._length));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._elem));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SeqConstruct";
      s += "(";
      s += Dafny.Helpers.ToString(this._length);
      s += ", ";
      s += Dafny.Helpers.ToString(this._elem);
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
      hash = ((hash << 5) + hash) + 9;
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
      hash = ((hash << 5) + hash) + 10;
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
      hash = ((hash << 5) + hash) + 11;
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
      hash = ((hash << 5) + hash) + 12;
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
      hash = ((hash << 5) + hash) + 13;
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
      hash = ((hash << 5) + hash) + 14;
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
    public readonly DAST._IBinOp _op;
    public readonly DAST._IExpression _left;
    public readonly DAST._IExpression _right;
    public Expression_BinOp(DAST._IBinOp op, DAST._IExpression left, DAST._IExpression right) : base() {
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
      hash = ((hash << 5) + hash) + 15;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._op));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._left));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._right));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.BinOp";
      s += "(";
      s += Dafny.Helpers.ToString(this._op);
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
      hash = ((hash << 5) + hash) + 16;
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
      hash = ((hash << 5) + hash) + 17;
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
      hash = ((hash << 5) + hash) + 18;
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
      hash = ((hash << 5) + hash) + 19;
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
      hash = ((hash << 5) + hash) + 20;
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
      hash = ((hash << 5) + hash) + 21;
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
      hash = ((hash << 5) + hash) + 22;
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
      hash = ((hash << 5) + hash) + 23;
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
      hash = ((hash << 5) + hash) + 24;
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
      hash = ((hash << 5) + hash) + 25;
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
      hash = ((hash << 5) + hash) + 26;
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
      hash = ((hash << 5) + hash) + 27;
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
      hash = ((hash << 5) + hash) + 28;
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
      hash = ((hash << 5) + hash) + 29;
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.BoolBoundedPool";
      return s;
    }
  }
  public class Expression_SetBoundedPool : Expression {
    public readonly DAST._IExpression _of;
    public Expression_SetBoundedPool(DAST._IExpression of) : base() {
      this._of = of;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SetBoundedPool(_of);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SetBoundedPool;
      return oth != null && object.Equals(this._of, oth._of);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 30;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._of));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SetBoundedPool";
      s += "(";
      s += Dafny.Helpers.ToString(this._of);
      s += ")";
      return s;
    }
  }
  public class Expression_SeqBoundedPool : Expression {
    public readonly DAST._IExpression _of;
    public readonly bool _includeDuplicates;
    public Expression_SeqBoundedPool(DAST._IExpression of, bool includeDuplicates) : base() {
      this._of = of;
      this._includeDuplicates = includeDuplicates;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SeqBoundedPool(_of, _includeDuplicates);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SeqBoundedPool;
      return oth != null && object.Equals(this._of, oth._of) && this._includeDuplicates == oth._includeDuplicates;
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 31;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._of));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._includeDuplicates));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SeqBoundedPool";
      s += "(";
      s += Dafny.Helpers.ToString(this._of);
      s += ", ";
      s += Dafny.Helpers.ToString(this._includeDuplicates);
      s += ")";
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
      hash = ((hash << 5) + hash) + 32;
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
    public static Dafny.ISequence<Dafny.Rune> replaceDots(Dafny.ISequence<Dafny.Rune> i) {
      Dafny.ISequence<Dafny.Rune> __accumulator = Dafny.Sequence<Dafny.Rune>.FromElements();
    TAIL_CALL_START:;
      if ((new BigInteger((i).Count)).Sign == 0) {
        return Dafny.Sequence<Dafny.Rune>.Concat(__accumulator, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
      } else {
        if (((i).Select(BigInteger.Zero)) == (new Dafny.Rune('.'))) {
          __accumulator = Dafny.Sequence<Dafny.Rune>.Concat(__accumulator, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_"));
          Dafny.ISequence<Dafny.Rune> _in0 = (i).Drop(BigInteger.One);
          i = _in0;
          goto TAIL_CALL_START;
        } else {
          __accumulator = Dafny.Sequence<Dafny.Rune>.Concat(__accumulator, Dafny.Sequence<Dafny.Rune>.FromElements((i).Select(BigInteger.Zero)));
          Dafny.ISequence<Dafny.Rune> _in1 = (i).Drop(BigInteger.One);
          i = _in1;
          goto TAIL_CALL_START;
        }
      }
    }
    public static Dafny.ISequence<Dafny.Rune> escapeIdent(Dafny.ISequence<Dafny.Rune> i) {
      return Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), DCOMP.__default.replaceDots(i));
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
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("mod "), DCOMP.__default.escapeIdent((mod).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
          DAST._INewtype _10___mcc_h3 = _source0.dtor_Newtype_a0;
          DAST._INewtype _11_n = _10___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _out4;
          _out4 = DCOMP.COMP.GenNewtype(_11_n);
          generated = _out4;
        } else {
          DAST._IDatatype _12___mcc_h4 = _source0.dtor_Datatype_a0;
          DAST._IDatatype _13_d = _12___mcc_h4;
          Dafny.ISequence<Dafny.Rune> _out5;
          _out5 = DCOMP.COMP.GenDatatype(_13_d);
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
      BigInteger _14_tpI;
      _14_tpI = BigInteger.Zero;
      if ((new BigInteger((@params).Count)).Sign == 1) {
        typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_14_tpI) < (new BigInteger((@params).Count))) {
          DAST._IType _15_tp;
          _15_tp = (@params).Select(_14_tpI);
          typeParamsSet = Dafny.Set<DAST._IType>.Union(typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_15_tp));
          Dafny.ISequence<Dafny.Rune> _16_genTp;
          Dafny.ISequence<Dafny.Rune> _out6;
          _out6 = DCOMP.COMP.GenType(_15_tp, false, false);
          _16_genTp = _out6;
          typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(typeParams, _16_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(constrainedTypeParams, _16_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _16_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static, "));
          _14_tpI = (_14_tpI) + (BigInteger.One);
        }
        typeParams = Dafny.Sequence<Dafny.Rune>.Concat(typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        constrainedTypeParams = Dafny.Sequence<Dafny.Rune>.Concat(constrainedTypeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenClass(DAST._IClass c, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> path) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _17_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _18_typeParams;
      Dafny.ISequence<Dafny.Rune> _19_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out7;
      Dafny.ISequence<Dafny.Rune> _out8;
      Dafny.ISequence<Dafny.Rune> _out9;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out7, out _out8, out _out9);
      _17_typeParamsSet = _out7;
      _18_typeParams = _out8;
      _19_constrainedTypeParams = _out9;
      Dafny.ISequence<Dafny.Rune> _20_fields;
      _20_fields = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      Dafny.ISequence<Dafny.Rune> _21_fieldInits;
      _21_fieldInits = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _22_fieldI;
      _22_fieldI = BigInteger.Zero;
      while ((_22_fieldI) < (new BigInteger(((c).dtor_fields).Count))) {
        DAST._IField _23_field;
        _23_field = ((c).dtor_fields).Select(_22_fieldI);
        Dafny.ISequence<Dafny.Rune> _24_fieldType;
        Dafny.ISequence<Dafny.Rune> _out10;
        _out10 = DCOMP.COMP.GenType(((_23_field).dtor_formal).dtor_typ, false, false);
        _24_fieldType = _out10;
        _20_fields = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_20_fields, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub ")), DCOMP.__default.escapeIdent(((_23_field).dtor_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::cell::RefCell<")), _24_fieldType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">,\n"));
        DAST._IOptional<DAST._IExpression> _source1 = (_23_field).dtor_defaultValue;
        if (_source1.is_Some) {
          DAST._IExpression _25___mcc_h0 = _source1.dtor_Some_a0;
          DAST._IExpression _26_e = _25___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _27_eStr;
            bool _28___v1;
            bool _29___v2;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _30___v3;
            Dafny.ISequence<Dafny.Rune> _out11;
            bool _out12;
            bool _out13;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out14;
            DCOMP.COMP.GenExpr(_26_e, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out11, out _out12, out _out13, out _out14);
            _27_eStr = _out11;
            _28___v1 = _out12;
            _29___v2 = _out13;
            _30___v3 = _out14;
            _21_fieldInits = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_21_fieldInits, DCOMP.__default.escapeIdent(((_23_field).dtor_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::cell::RefCell::new(")), _27_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("),\n"));
          }
        } else {
          {
            _21_fieldInits = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_21_fieldInits, DCOMP.__default.escapeIdent(((_23_field).dtor_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::cell::RefCell::new(::std::default::Default::default()),\n"));
          }
        }
        _22_fieldI = (_22_fieldI) + (BigInteger.One);
      }
      BigInteger _31_typeParamI;
      _31_typeParamI = BigInteger.Zero;
      while ((_31_typeParamI) < (new BigInteger(((c).dtor_typeParams).Count))) {
        Dafny.ISequence<Dafny.Rune> _32_tpeGen;
        Dafny.ISequence<Dafny.Rune> _out15;
        _out15 = DCOMP.COMP.GenType(((c).dtor_typeParams).Select(_31_typeParamI), false, false);
        _32_tpeGen = _out15;
        _20_fields = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_20_fields, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_phantom_type_param_")), DCOMP.__default.natToString(_31_typeParamI)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::marker::PhantomData<")), _32_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">,\n"));
        _21_fieldInits = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_21_fieldInits, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_phantom_type_param_")), DCOMP.__default.natToString(_31_typeParamI)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::marker::PhantomData,\n"));
        _31_typeParamI = (_31_typeParamI) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub struct "), DCOMP.__default.escapeIdent((c).dtor_name)), _18_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _20_fields), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _33_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _34_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out16;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out17;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(path)), _17_typeParamsSet, out _out16, out _out17);
      _33_implBody = _out16;
      _34_traitBodies = _out17;
      _33_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn new() -> Self {\n"), DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _21_fieldInits), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n")), _33_implBody);
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _19_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), DCOMP.__default.escapeIdent((c).dtor_name)), _18_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _33_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      if ((new BigInteger(((c).dtor_superClasses).Count)).Sign == 1) {
        BigInteger _35_i;
        _35_i = BigInteger.Zero;
        while ((_35_i) < (new BigInteger(((c).dtor_superClasses).Count))) {
          DAST._IType _36_superClass;
          _36_superClass = ((c).dtor_superClasses).Select(_35_i);
          DAST._IType _source2 = _36_superClass;
          if (_source2.is_Path) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _37___mcc_h1 = _source2.dtor_Path_a0;
            Dafny.ISequence<DAST._IType> _38___mcc_h2 = _source2.dtor_typeArgs;
            DAST._IResolvedType _39___mcc_h3 = _source2.dtor_resolved;
            DAST._IResolvedType _source3 = _39___mcc_h3;
            if (_source3.is_Datatype) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _40___mcc_h7 = _source3.dtor_path;
            } else if (_source3.is_Trait) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _41___mcc_h9 = _source3.dtor_path;
              Dafny.ISequence<DAST._IType> _42_typeArgs = _38___mcc_h2;
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _43_traitPath = _37___mcc_h1;
              {
                Dafny.ISequence<Dafny.Rune> _44_pathStr;
                Dafny.ISequence<Dafny.Rune> _out18;
                _out18 = DCOMP.COMP.GenPath(_43_traitPath);
                _44_pathStr = _out18;
                Dafny.ISequence<Dafny.Rune> _45_typeArgs;
                Dafny.ISequence<Dafny.Rune> _out19;
                _out19 = DCOMP.COMP.GenTypeArgs(_42_typeArgs, false, false);
                _45_typeArgs = _out19;
                Dafny.ISequence<Dafny.Rune> _46_body;
                _46_body = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
                if ((_34_traitBodies).Contains(_43_traitPath)) {
                  _46_body = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(_34_traitBodies, _43_traitPath);
                }
                Dafny.ISequence<Dafny.Rune> _47_genSelfPath;
                Dafny.ISequence<Dafny.Rune> _out20;
                _out20 = DCOMP.COMP.GenPath(path);
                _47_genSelfPath = _out20;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nimpl ")), _19_constrainedTypeParams), _44_pathStr), _45_typeArgs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" for ::std::rc::Rc<")), _47_genSelfPath), _18_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> {\n")), _46_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
              }
            } else {
              DAST._IType _48___mcc_h11 = _source3.dtor_Newtype_a0;
            }
          } else if (_source2.is_Nullable) {
            DAST._IType _49___mcc_h13 = _source2.dtor_Nullable_a0;
          } else if (_source2.is_Tuple) {
            Dafny.ISequence<DAST._IType> _50___mcc_h15 = _source2.dtor_Tuple_a0;
          } else if (_source2.is_Array) {
            DAST._IType _51___mcc_h17 = _source2.dtor_element;
            BigInteger _52___mcc_h18 = _source2.dtor_dims;
          } else if (_source2.is_Seq) {
            DAST._IType _53___mcc_h21 = _source2.dtor_element;
          } else if (_source2.is_Set) {
            DAST._IType _54___mcc_h23 = _source2.dtor_element;
          } else if (_source2.is_Multiset) {
            DAST._IType _55___mcc_h25 = _source2.dtor_element;
          } else if (_source2.is_Map) {
            DAST._IType _56___mcc_h27 = _source2.dtor_key;
            DAST._IType _57___mcc_h28 = _source2.dtor_value;
          } else if (_source2.is_Arrow) {
            Dafny.ISequence<DAST._IType> _58___mcc_h31 = _source2.dtor_args;
            DAST._IType _59___mcc_h32 = _source2.dtor_result;
          } else if (_source2.is_Primitive) {
            DAST._IPrimitive _60___mcc_h35 = _source2.dtor_Primitive_a0;
          } else if (_source2.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _61___mcc_h37 = _source2.dtor_Passthrough_a0;
          } else {
            Dafny.ISequence<Dafny.Rune> _62___mcc_h39 = _source2.dtor_TypeArg_a0;
          }
          _35_i = (_35_i) + (BigInteger.One);
        }
      }
      Dafny.ISequence<Dafny.Rune> _63_defaultImpl;
      _63_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _19_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _18_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _63_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      _63_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_63_defaultImpl, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new()\n"));
      _63_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      _63_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      Dafny.ISequence<Dafny.Rune> _64_printImpl;
      _64_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _19_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _18_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n"));
      _64_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_64_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"")), ((c).dtor_enclosingModule)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _65_ptrPartialEqImpl;
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _19_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _18_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_65_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_65_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_65_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _63_defaultImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _64_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _65_ptrPartialEqImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTrait(DAST._ITrait t, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _66_typeParamsSet;
      _66_typeParamsSet = Dafny.Set<DAST._IType>.FromElements();
      Dafny.ISequence<Dafny.Rune> _67_typeParams;
      _67_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _68_tpI;
      _68_tpI = BigInteger.Zero;
      if ((new BigInteger(((t).dtor_typeParams).Count)).Sign == 1) {
        _67_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_68_tpI) < (new BigInteger(((t).dtor_typeParams).Count))) {
          DAST._IType _69_tp;
          _69_tp = ((t).dtor_typeParams).Select(_68_tpI);
          _66_typeParamsSet = Dafny.Set<DAST._IType>.Union(_66_typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_69_tp));
          Dafny.ISequence<Dafny.Rune> _70_genTp;
          Dafny.ISequence<Dafny.Rune> _out21;
          _out21 = DCOMP.COMP.GenType(_69_tp, false, false);
          _70_genTp = _out21;
          _67_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_67_typeParams, _70_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          _68_tpI = (_68_tpI) + (BigInteger.One);
        }
        _67_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(_67_typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _71_fullPath;
      _71_fullPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((t).dtor_name));
      Dafny.ISequence<Dafny.Rune> _72_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _73___v6;
      Dafny.ISequence<Dafny.Rune> _out22;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out23;
      DCOMP.COMP.GenClassImplBody((t).dtor_body, true, DAST.Type.create_Path(_71_fullPath, Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Trait(_71_fullPath)), _66_typeParamsSet, out _out22, out _out23);
      _72_implBody = _out22;
      _73___v6 = _out23;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait "), DCOMP.__default.escapeIdent((t).dtor_name)), _67_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _72_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenNewtype(DAST._INewtype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _74_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _75_typeParams;
      Dafny.ISequence<Dafny.Rune> _76_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out24;
      Dafny.ISequence<Dafny.Rune> _out25;
      Dafny.ISequence<Dafny.Rune> _out26;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out24, out _out25, out _out26);
      _74_typeParamsSet = _out24;
      _75_typeParams = _out25;
      _76_constrainedTypeParams = _out26;
      Dafny.ISequence<Dafny.Rune> _77_underlyingType;
      Dafny.ISequence<Dafny.Rune> _out27;
      _out27 = DCOMP.COMP.GenType((c).dtor_base, false, false);
      _77_underlyingType = _out27;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Clone, PartialEq)]\n#[repr(transparent)]\npub struct "), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(pub ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase(&self) -> &Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase_owned(self) -> Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unsafe { &*(x as *const ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as *const ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") }\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(x)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      DAST._IOptional<DAST._IExpression> _source4 = (c).dtor_witnessExpr;
      if (_source4.is_Some) {
        DAST._IExpression _78___mcc_h0 = _source4.dtor_Some_a0;
        DAST._IExpression _79_e = _78___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _80_eStr;
          bool _81___v7;
          bool _82___v8;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _83___v9;
          Dafny.ISequence<Dafny.Rune> _out28;
          bool _out29;
          bool _out30;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out31;
          DCOMP.COMP.GenExpr(_79_e, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out28, out _out29, out _out30, out _out31);
          _80_eStr = _out28;
          _81___v7 = _out29;
          _82___v8 = _out30;
          _83___v9 = _out31;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _80_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(::std::default::Default::default())\n"));
        }
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, in_seq: bool) -> ::std::fmt::Result {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyPrint::fmt_print(&self.0, __fmt_print_formatter, in_seq)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenDatatype(DAST._IDatatype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _84_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _85_typeParams;
      Dafny.ISequence<Dafny.Rune> _86_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out32;
      Dafny.ISequence<Dafny.Rune> _out33;
      Dafny.ISequence<Dafny.Rune> _out34;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out32, out _out33, out _out34);
      _84_typeParamsSet = _out32;
      _85_typeParams = _out33;
      _86_constrainedTypeParams = _out34;
      Dafny.ISequence<Dafny.Rune> _87_ctors;
      _87_ctors = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _88_i;
      _88_i = BigInteger.Zero;
      while ((_88_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _89_ctor;
        _89_ctor = ((c).dtor_ctors).Select(_88_i);
        Dafny.ISequence<Dafny.Rune> _90_ctorBody;
        _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(DCOMP.__default.escapeIdent((_89_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        BigInteger _91_j;
        _91_j = BigInteger.Zero;
        while ((_91_j) < (new BigInteger(((_89_ctor).dtor_args).Count))) {
          DAST._IFormal _92_formal;
          _92_formal = ((_89_ctor).dtor_args).Select(_91_j);
          Dafny.ISequence<Dafny.Rune> _93_formalType;
          Dafny.ISequence<Dafny.Rune> _out35;
          _out35 = DCOMP.COMP.GenType((_92_formal).dtor_typ, false, false);
          _93_formalType = _out35;
          if ((c).dtor_isCo) {
            _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_90_ctorBody, DCOMP.__default.escapeIdent((_92_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper<")), _93_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">, "));
          } else {
            _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_90_ctorBody, DCOMP.__default.escapeIdent((_92_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _93_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          _91_j = (_91_j) + (BigInteger.One);
        }
        _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(_90_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        _87_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_87_ctors, _90_ctorBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
        _88_i = (_88_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _94_selfPath;
      _94_selfPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((c).dtor_name);
      Dafny.ISequence<Dafny.Rune> _95_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _96_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out36;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out37;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(_94_selfPath)), _84_typeParamsSet, out _out36, out _out37);
      _95_implBody = _out36;
      _96_traitBodies = _out37;
      _88_i = BigInteger.Zero;
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _97_emittedFields;
      _97_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      while ((_88_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _98_ctor;
        _98_ctor = ((c).dtor_ctors).Select(_88_i);
        BigInteger _99_j;
        _99_j = BigInteger.Zero;
        while ((_99_j) < (new BigInteger(((_98_ctor).dtor_args).Count))) {
          DAST._IFormal _100_formal;
          _100_formal = ((_98_ctor).dtor_args).Select(_99_j);
          if (!((_97_emittedFields).Contains((_100_formal).dtor_name))) {
            _97_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_97_emittedFields, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_100_formal).dtor_name));
            Dafny.ISequence<Dafny.Rune> _101_formalType;
            Dafny.ISequence<Dafny.Rune> _out38;
            _out38 = DCOMP.COMP.GenType((_100_formal).dtor_typ, false, false);
            _101_formalType = _out38;
            Dafny.ISequence<Dafny.Rune> _102_methodBody;
            _102_methodBody = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n");
            BigInteger _103_k;
            _103_k = BigInteger.Zero;
            while ((_103_k) < (new BigInteger(((c).dtor_ctors).Count))) {
              DAST._IDatatypeCtor _104_ctor2;
              _104_ctor2 = ((c).dtor_ctors).Select(_103_k);
              Dafny.ISequence<Dafny.Rune> _105_ctorMatch;
              _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(DCOMP.__default.escapeIdent((c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), DCOMP.__default.escapeIdent((_104_ctor2).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
              BigInteger _106_l;
              _106_l = BigInteger.Zero;
              bool _107_hasMatchingField;
              _107_hasMatchingField = false;
              while ((_106_l) < (new BigInteger(((_104_ctor2).dtor_args).Count))) {
                DAST._IFormal _108_formal2;
                _108_formal2 = ((_104_ctor2).dtor_args).Select(_106_l);
                if (((_100_formal).dtor_name).Equals((_108_formal2).dtor_name)) {
                  _107_hasMatchingField = true;
                }
                _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, DCOMP.__default.escapeIdent((_108_formal2).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                _106_l = (_106_l) + (BigInteger.One);
              }
              if (_107_hasMatchingField) {
                if ((c).dtor_isCo) {
                  _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ::std::ops::Deref::deref(&")), DCOMP.__default.escapeIdent((_100_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0),\n"));
                } else {
                  _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ")), DCOMP.__default.escapeIdent((_100_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
                }
              } else {
                _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => panic!(\"field does not exist on this variant\"),\n"));
              }
              _102_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_102_methodBody, _105_ctorMatch);
              _103_k = (_103_k) + (BigInteger.One);
            }
            if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
              _102_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_102_methodBody, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => panic!(),\n"));
            }
            _102_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_102_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            _95_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_95_implBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn ")), DCOMP.__default.escapeIdent((_100_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&self) -> &")), _101_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _102_methodBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
          }
          _99_j = (_99_j) + (BigInteger.One);
        }
        _88_i = (_88_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _87_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_87_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_PhantomVariant("));
        BigInteger _109_typeI;
        _109_typeI = BigInteger.Zero;
        while ((_109_typeI) < (new BigInteger(((c).dtor_typeParams).Count))) {
          if ((_109_typeI).Sign == 1) {
            _87_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_87_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _110_genTp;
          Dafny.ISequence<Dafny.Rune> _out39;
          _out39 = DCOMP.COMP.GenType(((c).dtor_typeParams).Select(_109_typeI), false, false);
          _110_genTp = _out39;
          _87_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_87_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::marker::PhantomData::<")), _110_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          _109_typeI = (_109_typeI) + (BigInteger.One);
        }
        _87_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_87_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      Dafny.ISequence<Dafny.Rune> _111_enumBody;
      _111_enumBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(PartialEq)]\npub enum "), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _87_ctors), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _95_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _112_identEraseImpls;
      _112_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = Self;\nfn erase(&self) -> &Self::Erased { self }\nfn erase_owned(self) -> Self::Erased { self }}\n"));
      _112_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_112_identEraseImpls, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn unerase(x: &Self) -> &Self { x }\nfn unerase_owned(x: Self) -> Self { x }}\n"));
      Dafny.ISequence<Dafny.Rune> _113_printImpl;
      _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n"));
      _88_i = BigInteger.Zero;
      while ((_88_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _114_ctor;
        _114_ctor = ((c).dtor_ctors).Select(_88_i);
        Dafny.ISequence<Dafny.Rune> _115_ctorMatch;
        _115_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(DCOMP.__default.escapeIdent((_114_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        Dafny.ISequence<Dafny.Rune> _116_modulePrefix;
        _116_modulePrefix = (((((c).dtor_enclosingModule)).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_module"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(((c).dtor_enclosingModule), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("."))));
        Dafny.ISequence<Dafny.Rune> _117_printRhs;
        _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \""), _116_modulePrefix), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (_114_ctor).dtor_name), (((_114_ctor).dtor_hasAnyArgs) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(\")?;")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"))));
        BigInteger _118_j;
        _118_j = BigInteger.Zero;
        while ((_118_j) < (new BigInteger(((_114_ctor).dtor_args).Count))) {
          DAST._IFormal _119_formal;
          _119_formal = ((_114_ctor).dtor_args).Select(_118_j);
          _115_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_115_ctorMatch, DCOMP.__default.escapeIdent((_119_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          if ((_118_j).Sign == 1) {
            _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
          }
          _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(")), DCOMP.__default.escapeIdent((_119_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", __fmt_print_formatter, false)?;"));
          _118_j = (_118_j) + (BigInteger.One);
        }
        _115_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_115_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        if ((_114_ctor).dtor_hasAnyArgs) {
          _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
        }
        _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())"));
        _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_113_printImpl, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _115_ctorMatch), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" => {\n")), _117_printRhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
        _88_i = (_88_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_113_printImpl, DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => {panic!()\n}\n"));
      }
      _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_113_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _120_defaultImpl;
      _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_ctors).Count)).Sign == 1) {
        _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for ")), DCOMP.__default.escapeIdent((c).dtor_name)), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n")), DCOMP.__default.escapeIdent((c).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), DCOMP.__default.escapeIdent((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        _88_i = BigInteger.Zero;
        while ((_88_i) < (new BigInteger(((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Count))) {
          DAST._IFormal _121_formal;
          _121_formal = ((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Select(_88_i);
          _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_120_defaultImpl, DCOMP.__default.escapeIdent((_121_formal).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::std::default::Default::default(),\n"));
          _88_i = (_88_i) + (BigInteger.One);
        }
        _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_120_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_111_enumBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _112_identEraseImpls), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _113_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _120_defaultImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenPath(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      if ((new BigInteger((p).Count)).Sign == 0) {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Self");
        return s;
      } else {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("super::");
        BigInteger _122_i;
        _122_i = BigInteger.Zero;
        while ((_122_i) < (new BigInteger((p).Count))) {
          if ((_122_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent(((p).Select(_122_i))));
          _122_i = (_122_i) + (BigInteger.One);
        }
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTypeArgs(Dafny.ISequence<DAST._IType> args, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger((args).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _123_i;
        _123_i = BigInteger.Zero;
        while ((_123_i) < (new BigInteger((args).Count))) {
          if ((_123_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _124_genTp;
          Dafny.ISequence<Dafny.Rune> _out40;
          _out40 = DCOMP.COMP.GenType((args).Select(_123_i), inBinding, inFn);
          _124_genTp = _out40;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _124_genTp);
          _123_i = (_123_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenType(DAST._IType c, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      DAST._IType _source5 = c;
      if (_source5.is_Path) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _125___mcc_h0 = _source5.dtor_Path_a0;
        Dafny.ISequence<DAST._IType> _126___mcc_h1 = _source5.dtor_typeArgs;
        DAST._IResolvedType _127___mcc_h2 = _source5.dtor_resolved;
        DAST._IResolvedType _128_resolved = _127___mcc_h2;
        Dafny.ISequence<DAST._IType> _129_args = _126___mcc_h1;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _130_p = _125___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _out41;
          _out41 = DCOMP.COMP.GenPath(_130_p);
          s = _out41;
          Dafny.ISequence<Dafny.Rune> _131_typeArgs;
          Dafny.ISequence<Dafny.Rune> _out42;
          _out42 = DCOMP.COMP.GenTypeArgs(_129_args, inBinding, inFn);
          _131_typeArgs = _out42;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _131_typeArgs);
          DAST._IResolvedType _source6 = _128_resolved;
          if (_source6.is_Datatype) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _132___mcc_h18 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _133___mcc_h20 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IType _134___mcc_h22 = _source6.dtor_Newtype_a0;
            DAST._IResolvedType _135_Primitive = _128_resolved;
          }
        }
      } else if (_source5.is_Nullable) {
        DAST._IType _136___mcc_h3 = _source5.dtor_Nullable_a0;
        DAST._IType _137_inner = _136___mcc_h3;
        {
          Dafny.ISequence<Dafny.Rune> _138_innerStr;
          Dafny.ISequence<Dafny.Rune> _out43;
          _out43 = DCOMP.COMP.GenType(_137_inner, inBinding, inFn);
          _138_innerStr = _out43;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::option::Option<"), _138_innerStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Tuple) {
        Dafny.ISequence<DAST._IType> _139___mcc_h4 = _source5.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _140_types = _139___mcc_h4;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _141_i;
          _141_i = BigInteger.Zero;
          while ((_141_i) < (new BigInteger((_140_types).Count))) {
            if ((_141_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _142_generated;
            Dafny.ISequence<Dafny.Rune> _out44;
            _out44 = DCOMP.COMP.GenType((_140_types).Select(_141_i), inBinding, inFn);
            _142_generated = _out44;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _142_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _141_i = (_141_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source5.is_Array) {
        DAST._IType _143___mcc_h5 = _source5.dtor_element;
        BigInteger _144___mcc_h6 = _source5.dtor_dims;
        BigInteger _145_dims = _144___mcc_h6;
        DAST._IType _146_element = _143___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _147_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_146_element, inBinding, inFn);
          _147_elemStr = _out45;
          s = _147_elemStr;
          BigInteger _148_i;
          _148_i = BigInteger.Zero;
          while ((_148_i) < (_145_dims)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<::std::cell::RefCell<::std::vec::Vec<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>>"));
            _148_i = (_148_i) + (BigInteger.One);
          }
        }
      } else if (_source5.is_Seq) {
        DAST._IType _149___mcc_h7 = _source5.dtor_element;
        DAST._IType _150_element = _149___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _151_elemStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_150_element, inBinding, inFn);
          _151_elemStr = _out46;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _151_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _152___mcc_h8 = _source5.dtor_element;
        DAST._IType _153_element = _152___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _154_elemStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_153_element, inBinding, inFn);
          _154_elemStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _154_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _155___mcc_h9 = _source5.dtor_element;
        DAST._IType _156_element = _155___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _157_elemStr;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenType(_156_element, inBinding, inFn);
          _157_elemStr = _out48;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _157_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _158___mcc_h10 = _source5.dtor_key;
        DAST._IType _159___mcc_h11 = _source5.dtor_value;
        DAST._IType _160_value = _159___mcc_h11;
        DAST._IType _161_key = _158___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _162_keyStr;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenType(_161_key, inBinding, inFn);
          _162_keyStr = _out49;
          Dafny.ISequence<Dafny.Rune> _163_valueStr;
          Dafny.ISequence<Dafny.Rune> _out50;
          _out50 = DCOMP.COMP.GenType(_160_value, inBinding, inFn);
          _163_valueStr = _out50;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _162_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _163_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _164___mcc_h12 = _source5.dtor_args;
        DAST._IType _165___mcc_h13 = _source5.dtor_result;
        DAST._IType _166_result = _165___mcc_h13;
        Dafny.ISequence<DAST._IType> _167_args = _164___mcc_h12;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::rc::Rc<dyn ::std::ops::Fn(");
          BigInteger _168_i;
          _168_i = BigInteger.Zero;
          while ((_168_i) < (new BigInteger((_167_args).Count))) {
            if ((_168_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _169_generated;
            Dafny.ISequence<Dafny.Rune> _out51;
            _out51 = DCOMP.COMP.GenType((_167_args).Select(_168_i), inBinding, true);
            _169_generated = _out51;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _169_generated);
            _168_i = (_168_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _170_resultType;
          Dafny.ISequence<Dafny.Rune> _out52;
          _out52 = DCOMP.COMP.GenType(_166_result, inBinding, (inFn) || (inBinding));
          _170_resultType = _out52;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _170_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _171___mcc_h14 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _172_p = _171___mcc_h14;
        {
          DAST._IPrimitive _source7 = _172_p;
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
        Dafny.ISequence<Dafny.Rune> _173___mcc_h15 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _174_v = _173___mcc_h15;
        s = _174_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _175___mcc_h16 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _175___mcc_h16;
        Dafny.ISequence<Dafny.Rune> _176___mcc_h17 = _source8;
        Dafny.ISequence<Dafny.Rune> _177_name = _176___mcc_h17;
        s = DCOMP.__default.escapeIdent(_177_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _178_i;
      _178_i = BigInteger.Zero;
      while ((_178_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_178_i);
        DAST._IMethod _179___mcc_h0 = _source9;
        DAST._IMethod _180_m = _179___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_180_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _181___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _182_p = _181___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _183_existing;
              _183_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_182_p)) {
                _183_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _182_p);
              }
              if ((new BigInteger((_183_existing).Count)).Sign == 1) {
                _183_existing = Dafny.Sequence<Dafny.Rune>.Concat(_183_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _184_genMethod;
              Dafny.ISequence<Dafny.Rune> _out53;
              _out53 = DCOMP.COMP.GenMethod(_180_m, true, enclosingType, enclosingTypeParams);
              _184_genMethod = _out53;
              _183_existing = Dafny.Sequence<Dafny.Rune>.Concat(_183_existing, _184_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_182_p, _183_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _185_generated;
              Dafny.ISequence<Dafny.Rune> _out54;
              _out54 = DCOMP.COMP.GenMethod(_180_m, forTrait, enclosingType, enclosingTypeParams);
              _185_generated = _out54;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _185_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _178_i = (_178_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _186_i;
      _186_i = BigInteger.Zero;
      while ((_186_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _187_param;
        _187_param = (@params).Select(_186_i);
        Dafny.ISequence<Dafny.Rune> _188_paramType;
        Dafny.ISequence<Dafny.Rune> _out55;
        _out55 = DCOMP.COMP.GenType((_187_param).dtor_typ, false, false);
        _188_paramType = _out55;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent((_187_param).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _188_paramType);
        if ((_186_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _186_i = (_186_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _189_params;
      Dafny.ISequence<Dafny.Rune> _out56;
      _out56 = DCOMP.COMP.GenParams((m).dtor_params);
      _189_params = _out56;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _190_paramNames;
      _190_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _191_paramI;
      _191_paramI = BigInteger.Zero;
      while ((_191_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _190_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_190_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_191_paramI)).dtor_name));
        _191_paramI = (_191_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _189_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _189_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _192_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out57;
          _out57 = DCOMP.COMP.GenType(enclosingType, false, false);
          _192_enclosingTypeString = _out57;
          _189_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _192_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _189_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _193_retType;
      _193_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _194_typeI;
      _194_typeI = BigInteger.Zero;
      while ((_194_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_194_typeI).Sign == 1) {
          _193_retType = Dafny.Sequence<Dafny.Rune>.Concat(_193_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _195_typeString;
        Dafny.ISequence<Dafny.Rune> _out58;
        _out58 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_194_typeI), false, false);
        _195_typeString = _out58;
        _193_retType = Dafny.Sequence<Dafny.Rune>.Concat(_193_retType, _195_typeString);
        _194_typeI = (_194_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _193_retType = Dafny.Sequence<Dafny.Rune>.Concat(_193_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn "), DCOMP.__default.escapeIdent((m).dtor_name));
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn "), DCOMP.__default.escapeIdent((m).dtor_name));
      }
      Dafny.ISequence<DAST._IType> _196_typeParamsFiltered;
      _196_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _197_typeParamI;
      _197_typeParamI = BigInteger.Zero;
      while ((_197_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _198_typeParam;
        _198_typeParam = ((m).dtor_typeParams).Select(_197_typeParamI);
        if (!((enclosingTypeParams).Contains(_198_typeParam))) {
          _196_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_196_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_198_typeParam));
        }
        _197_typeParamI = (_197_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_196_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _199_i;
        _199_i = BigInteger.Zero;
        while ((_199_i) < (new BigInteger((_196_typeParamsFiltered).Count))) {
          if ((_199_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _200_typeString;
          Dafny.ISequence<Dafny.Rune> _out59;
          _out59 = DCOMP.COMP.GenType((_196_typeParamsFiltered).Select(_199_i), false, false);
          _200_typeString = _out59;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _200_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _200_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _199_i = (_199_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _189_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _193_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _201_earlyReturn;
        _201_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _202___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _203_outVars = _202___mcc_h0;
          {
            _201_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _204_outI;
            _204_outI = BigInteger.Zero;
            while ((_204_outI) < (new BigInteger((_203_outVars).Count))) {
              if ((_204_outI).Sign == 1) {
                _201_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_201_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _205_outVar;
              _205_outVar = (_203_outVars).Select(_204_outI);
              _201_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_201_earlyReturn, DCOMP.__default.escapeIdent((_205_outVar)));
              _204_outI = (_204_outI) + (BigInteger.One);
            }
            _201_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_201_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _206_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _207___v12;
        Dafny.ISequence<Dafny.Rune> _out60;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out61;
        DCOMP.COMP.GenStmts((m).dtor_body, (((m).dtor_isStatic) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None()) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self")))), _190_paramNames, true, _201_earlyReturn, out _out60, out _out61);
        _206_body = _out60;
        _207___v12 = _out61;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _206_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      }
      return s;
    }
    public static void GenStmts(Dafny.ISequence<DAST._IStatement> stmts, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _208_declarations;
      _208_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _209_i;
      _209_i = BigInteger.Zero;
      while ((_209_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _210_stmt;
        _210_stmt = (stmts).Select(_209_i);
        Dafny.ISequence<Dafny.Rune> _211_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _212_recIdents;
        Dafny.ISequence<Dafny.Rune> _out62;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out63;
        DCOMP.COMP.GenStmt(_210_stmt, selfIdent, @params, (isLast) && ((_209_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out62, out _out63);
        _211_stmtString = _out62;
        _212_recIdents = _out63;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_212_recIdents, _208_declarations));
        DAST._IStatement _source12 = _210_stmt;
        if (_source12.is_DeclareVar) {
          Dafny.ISequence<Dafny.Rune> _213___mcc_h0 = _source12.dtor_name;
          DAST._IType _214___mcc_h1 = _source12.dtor_typ;
          DAST._IOptional<DAST._IExpression> _215___mcc_h2 = _source12.dtor_maybeValue;
          Dafny.ISequence<Dafny.Rune> _216_name = _213___mcc_h0;
          {
            _208_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_208_declarations, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_216_name));
          }
        } else if (_source12.is_Assign) {
          DAST._IAssignLhs _217___mcc_h6 = _source12.dtor_lhs;
          DAST._IExpression _218___mcc_h7 = _source12.dtor_value;
        } else if (_source12.is_If) {
          DAST._IExpression _219___mcc_h10 = _source12.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _220___mcc_h11 = _source12.dtor_thn;
          Dafny.ISequence<DAST._IStatement> _221___mcc_h12 = _source12.dtor_els;
        } else if (_source12.is_Labeled) {
          Dafny.ISequence<Dafny.Rune> _222___mcc_h16 = _source12.dtor_lbl;
          Dafny.ISequence<DAST._IStatement> _223___mcc_h17 = _source12.dtor_body;
        } else if (_source12.is_While) {
          DAST._IExpression _224___mcc_h20 = _source12.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _225___mcc_h21 = _source12.dtor_body;
        } else if (_source12.is_Foreach) {
          Dafny.ISequence<Dafny.Rune> _226___mcc_h24 = _source12.dtor_boundName;
          DAST._IType _227___mcc_h25 = _source12.dtor_boundType;
          DAST._IExpression _228___mcc_h26 = _source12.dtor_over;
          Dafny.ISequence<DAST._IStatement> _229___mcc_h27 = _source12.dtor_body;
        } else if (_source12.is_Call) {
          DAST._IExpression _230___mcc_h32 = _source12.dtor_on;
          Dafny.ISequence<Dafny.Rune> _231___mcc_h33 = _source12.dtor_name;
          Dafny.ISequence<DAST._IType> _232___mcc_h34 = _source12.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _233___mcc_h35 = _source12.dtor_args;
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _234___mcc_h36 = _source12.dtor_outs;
        } else if (_source12.is_Return) {
          DAST._IExpression _235___mcc_h42 = _source12.dtor_expr;
        } else if (_source12.is_EarlyReturn) {
        } else if (_source12.is_Break) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _236___mcc_h44 = _source12.dtor_toLabel;
        } else if (_source12.is_TailRecursive) {
          Dafny.ISequence<DAST._IStatement> _237___mcc_h46 = _source12.dtor_body;
        } else if (_source12.is_JumpTailCallStart) {
        } else if (_source12.is_Halt) {
        } else {
          DAST._IExpression _238___mcc_h48 = _source12.dtor_Print_a0;
        }
        if ((_209_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _211_stmtString);
        _209_i = (_209_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.Rune> rhs, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source13 = lhs;
      if (_source13.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _239___mcc_h0 = _source13.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source14 = _239___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _240___mcc_h1 = _source14;
        Dafny.ISequence<Dafny.Rune> _241_id = _240___mcc_h1;
        {
          if ((@params).Contains(_241_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*"), DCOMP.__default.escapeIdent(_241_id));
          } else {
            generated = DCOMP.__default.escapeIdent(_241_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_241_id);
          needsIIFE = false;
        }
      } else if (_source13.is_Select) {
        DAST._IExpression _242___mcc_h2 = _source13.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _243___mcc_h3 = _source13.dtor_field;
        Dafny.ISequence<Dafny.Rune> _244_field = _243___mcc_h3;
        DAST._IExpression _245_on = _242___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _246_onExpr;
          bool _247_onOwned;
          bool _248_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _249_recIdents;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          bool _out66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out67;
          DCOMP.COMP.GenExpr(_245_on, selfIdent, @params, false, out _out64, out _out65, out _out66, out _out67);
          _246_onExpr = _out64;
          _247_onOwned = _out65;
          _248_onErased = _out66;
          _249_recIdents = _out67;
          if (!(_248_onErased)) {
            Dafny.ISequence<Dafny.Rune> _250_eraseFn;
            _250_eraseFn = ((_247_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _246_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _250_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _246_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _246_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _244_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _249_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _251___mcc_h4 = _source13.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _252___mcc_h5 = _source13.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _253_indices = _252___mcc_h5;
        DAST._IExpression _254_on = _251___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _255_onExpr;
          bool _256_onOwned;
          bool _257_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _258_recIdents;
          Dafny.ISequence<Dafny.Rune> _out68;
          bool _out69;
          bool _out70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
          DCOMP.COMP.GenExpr(_254_on, selfIdent, @params, false, out _out68, out _out69, out _out70, out _out71);
          _255_onExpr = _out68;
          _256_onOwned = _out69;
          _257_onErased = _out70;
          _258_recIdents = _out71;
          readIdents = _258_recIdents;
          if (!(_257_onErased)) {
            Dafny.ISequence<Dafny.Rune> _259_eraseFn;
            _259_eraseFn = ((_256_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _255_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _259_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _255_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          BigInteger _260_i;
          _260_i = BigInteger.Zero;
          while ((_260_i) < (new BigInteger((_253_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _261_idx;
            bool _262___v16;
            bool _263_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _264_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            bool _out74;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
            DCOMP.COMP.GenExpr((_253_indices).Select(_260_i), selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
            _261_idx = _out72;
            _262___v16 = _out73;
            _263_idxErased = _out74;
            _264_recIdentsIdx = _out75;
            if (!(_263_idxErased)) {
              _261_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _261_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let __idx")), DCOMP.__default.natToString(_260_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <usize as ::dafny_runtime::NumCast>::from(")), _261_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _264_recIdentsIdx);
            _260_i = (_260_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _255_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()"));
          _260_i = BigInteger.Zero;
          while ((_260_i) < (new BigInteger((_253_indices).Count))) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[__idx")), DCOMP.__default.natToString(_260_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            _260_i = (_260_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n}"));
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _265___mcc_h0 = _source15.dtor_name;
        DAST._IType _266___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _267___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _267___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _268___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _269_expression = _268___mcc_h3;
          DAST._IType _270_typ = _266___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _271_name = _265___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _272_expr;
            bool _273___v17;
            bool _274_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _275_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_269_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _272_expr = _out76;
            _273___v17 = _out77;
            _274_recErased = _out78;
            _275_recIdents = _out79;
            if (_274_recErased) {
              _272_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _272_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _276_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_270_typ, true, false);
            _276_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut "), DCOMP.__default.escapeIdent(_271_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _276_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _272_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _275_recIdents;
          }
        } else {
          DAST._IType _277_typ = _266___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _278_name = _265___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _279_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_277_typ, true, false);
            _279_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut "), DCOMP.__default.escapeIdent(_278_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _279_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _280___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _281___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _282_expression = _281___mcc_h5;
        DAST._IAssignLhs _283_lhs = _280___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _284_lhsGen;
          bool _285_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _286_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_283_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _284_lhsGen = _out82;
          _285_needsIIFE = _out83;
          _286_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _287_exprGen;
          bool _288___v18;
          bool _289_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _290_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_282_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _287_exprGen = _out85;
          _288___v18 = _out86;
          _289_exprErased = _out87;
          _290_exprIdents = _out88;
          if (_289_exprErased) {
            _287_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _287_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_285_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _287_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _284_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_284_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _287_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_286_recIdents, _290_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _291___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _292___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _293___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _294_els = _293___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _295_thn = _292___mcc_h7;
        DAST._IExpression _296_cond = _291___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _297_condString;
          bool _298___v19;
          bool _299_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _300_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_296_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _297_condString = _out89;
          _298___v19 = _out90;
          _299_condErased = _out91;
          _300_recIdents = _out92;
          if (!(_299_condErased)) {
            _297_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _297_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _300_recIdents;
          Dafny.ISequence<Dafny.Rune> _301_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _302_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_295_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _301_thnString = _out93;
          _302_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _302_thnIdents);
          Dafny.ISequence<Dafny.Rune> _303_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _304_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_294_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _303_elsString = _out95;
          _304_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _304_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _297_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _301_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _303_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Labeled) {
        Dafny.ISequence<Dafny.Rune> _305___mcc_h9 = _source15.dtor_lbl;
        Dafny.ISequence<DAST._IStatement> _306___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _307_body = _306___mcc_h10;
        Dafny.ISequence<Dafny.Rune> _308_lbl = _305___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _309_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _310_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out98;
          DCOMP.COMP.GenStmts(_307_body, selfIdent, @params, isLast, earlyReturn, out _out97, out _out98);
          _309_bodyString = _out97;
          _310_bodyIdents = _out98;
          readIdents = _310_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _308_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": loop {\n")), _309_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _311___mcc_h11 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _312___mcc_h12 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _313_body = _312___mcc_h12;
        DAST._IExpression _314_cond = _311___mcc_h11;
        {
          Dafny.ISequence<Dafny.Rune> _315_condString;
          bool _316___v20;
          bool _317_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _318_recIdents;
          Dafny.ISequence<Dafny.Rune> _out99;
          bool _out100;
          bool _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenExpr(_314_cond, selfIdent, @params, true, out _out99, out _out100, out _out101, out _out102);
          _315_condString = _out99;
          _316___v20 = _out100;
          _317_condErased = _out101;
          _318_recIdents = _out102;
          if (!(_317_condErased)) {
            _315_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _315_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _318_recIdents;
          Dafny.ISequence<Dafny.Rune> _319_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _320_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out103;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out104;
          DCOMP.COMP.GenStmts(_313_body, selfIdent, @params, false, earlyReturn, out _out103, out _out104);
          _319_bodyString = _out103;
          _320_bodyIdents = _out104;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _320_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _315_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _319_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Foreach) {
        Dafny.ISequence<Dafny.Rune> _321___mcc_h13 = _source15.dtor_boundName;
        DAST._IType _322___mcc_h14 = _source15.dtor_boundType;
        DAST._IExpression _323___mcc_h15 = _source15.dtor_over;
        Dafny.ISequence<DAST._IStatement> _324___mcc_h16 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _325_body = _324___mcc_h16;
        DAST._IExpression _326_over = _323___mcc_h15;
        DAST._IType _327_boundType = _322___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _328_boundName = _321___mcc_h13;
        {
          Dafny.ISequence<Dafny.Rune> _329_overString;
          bool _330___v21;
          bool _331_overErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _332_recIdents;
          Dafny.ISequence<Dafny.Rune> _out105;
          bool _out106;
          bool _out107;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out108;
          DCOMP.COMP.GenExpr(_326_over, selfIdent, @params, true, out _out105, out _out106, out _out107, out _out108);
          _329_overString = _out105;
          _330___v21 = _out106;
          _331_overErased = _out107;
          _332_recIdents = _out108;
          Dafny.ISequence<Dafny.Rune> _333_boundTypeStr;
          Dafny.ISequence<Dafny.Rune> _out109;
          _out109 = DCOMP.COMP.GenType(_327_boundType, false, false);
          _333_boundTypeStr = _out109;
          readIdents = _332_recIdents;
          Dafny.ISequence<Dafny.Rune> _334_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _335_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenStmts(_325_body, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(_328_boundName)), false, earlyReturn, out _out110, out _out111);
          _334_bodyString = _out110;
          _335_bodyIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _335_bodyIdents), Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_328_boundName));
          Dafny.ISequence<Dafny.Rune> _336_unerasedIter;
          _336_unerasedIter = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_iter_erased");
          if (_331_overErased) {
            _336_unerasedIter = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _333_boundTypeStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::unerase_owned(")), _336_unerasedIter), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("for _iter_erased in "), _329_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let ")), DCOMP.__default.escapeIdent(_328_boundName)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _336_unerasedIter), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _334_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _337___mcc_h17 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _338___mcc_h18 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _339___mcc_h19 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _340___mcc_h20 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _341___mcc_h21 = _source15.dtor_outs;
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
          DAST._IExpression _source17 = _346_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _360___mcc_h26 = _source17.dtor_Literal_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _361___mcc_h28 = _source17.dtor_Ident_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _362___mcc_h30 = _source17.dtor_Companion_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_356_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _363___mcc_h32 = _source17.dtor_Tuple_a0;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _364___mcc_h34 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _365___mcc_h35 = _source17.dtor_args;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _366___mcc_h38 = _source17.dtor_dims;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _367___mcc_h40 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _368___mcc_h41 = _source17.dtor_variant;
            bool _369___mcc_h42 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _370___mcc_h43 = _source17.dtor_contents;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _371___mcc_h48 = _source17.dtor_value;
            DAST._IType _372___mcc_h49 = _source17.dtor_from;
            DAST._IType _373___mcc_h50 = _source17.dtor_typ;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqConstruct) {
            DAST._IExpression _374___mcc_h54 = _source17.dtor_length;
            DAST._IExpression _375___mcc_h55 = _source17.dtor_elem;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _376___mcc_h58 = _source17.dtor_elements;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _377___mcc_h60 = _source17.dtor_elements;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _378___mcc_h62 = _source17.dtor_mapElems;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _379___mcc_h64 = _source17.dtor_cond;
            DAST._IExpression _380___mcc_h65 = _source17.dtor_thn;
            DAST._IExpression _381___mcc_h66 = _source17.dtor_els;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _382___mcc_h70 = _source17.dtor_unOp;
            DAST._IExpression _383___mcc_h71 = _source17.dtor_expr;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            DAST._IBinOp _384___mcc_h74 = _source17.dtor_op;
            DAST._IExpression _385___mcc_h75 = _source17.dtor_left;
            DAST._IExpression _386___mcc_h76 = _source17.dtor_right;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_ArrayLen) {
            DAST._IExpression _387___mcc_h80 = _source17.dtor_expr;
            BigInteger _388___mcc_h81 = _source17.dtor_dim;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _389___mcc_h84 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _390___mcc_h85 = _source17.dtor_field;
            bool _391___mcc_h86 = _source17.dtor_isConstant;
            bool _392___mcc_h87 = _source17.dtor_onDatatype;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _393___mcc_h92 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _394___mcc_h93 = _source17.dtor_field;
            bool _395___mcc_h94 = _source17.dtor_onDatatype;
            bool _396___mcc_h95 = _source17.dtor_isStatic;
            BigInteger _397___mcc_h96 = _source17.dtor_arity;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Index) {
            DAST._IExpression _398___mcc_h102 = _source17.dtor_expr;
            DAST._ICollKind _399___mcc_h103 = _source17.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _400___mcc_h104 = _source17.dtor_indices;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IndexRange) {
            DAST._IExpression _401___mcc_h108 = _source17.dtor_expr;
            bool _402___mcc_h109 = _source17.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _403___mcc_h110 = _source17.dtor_low;
            DAST._IOptional<DAST._IExpression> _404___mcc_h111 = _source17.dtor_high;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _405___mcc_h116 = _source17.dtor_expr;
            BigInteger _406___mcc_h117 = _source17.dtor_index;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _407___mcc_h120 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _408___mcc_h121 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _409___mcc_h122 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _410___mcc_h123 = _source17.dtor_args;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _411___mcc_h128 = _source17.dtor_params;
            DAST._IType _412___mcc_h129 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _413___mcc_h130 = _source17.dtor_body;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _414___mcc_h134 = _source17.dtor_values;
            DAST._IType _415___mcc_h135 = _source17.dtor_retType;
            DAST._IExpression _416___mcc_h136 = _source17.dtor_expr;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _417___mcc_h140 = _source17.dtor_name;
            DAST._IType _418___mcc_h141 = _source17.dtor_typ;
            DAST._IExpression _419___mcc_h142 = _source17.dtor_value;
            DAST._IExpression _420___mcc_h143 = _source17.dtor_iifeBody;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _421___mcc_h148 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _422___mcc_h149 = _source17.dtor_args;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _423___mcc_h152 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _424___mcc_h153 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _425___mcc_h154 = _source17.dtor_variant;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_InitializationValue) {
            DAST._IType _426___mcc_h158 = _source17.dtor_typ;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BoolBoundedPool) {
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetBoundedPool) {
            DAST._IExpression _427___mcc_h160 = _source17.dtor_of;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqBoundedPool) {
            DAST._IExpression _428___mcc_h162 = _source17.dtor_of;
            bool _429___mcc_h163 = _source17.dtor_includeDuplicates;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IExpression _430___mcc_h166 = _source17.dtor_lo;
            DAST._IExpression _431___mcc_h167 = _source17.dtor_hi;
            {
              _356_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _356_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _432_receiver;
          _432_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _342_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _433___mcc_h170 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _434_outVars = _433___mcc_h170;
            {
              if ((new BigInteger((_434_outVars).Count)) > (BigInteger.One)) {
                _432_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _435_outI;
              _435_outI = BigInteger.Zero;
              while ((_435_outI) < (new BigInteger((_434_outVars).Count))) {
                if ((_435_outI).Sign == 1) {
                  _432_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_432_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _436_outVar;
                _436_outVar = (_434_outVars).Select(_435_outI);
                _432_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_432_receiver, (_436_outVar));
                _435_outI = (_435_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_434_outVars).Count)) > (BigInteger.One)) {
                _432_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_432_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_432_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_432_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _356_enclosingString), DCOMP.__default.escapeIdent(_345_name)), _347_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _350_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _437___mcc_h22 = _source15.dtor_expr;
        DAST._IExpression _438_expr = _437___mcc_h22;
        {
          Dafny.ISequence<Dafny.Rune> _439_exprString;
          bool _440___v26;
          bool _441_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _442_recIdents;
          Dafny.ISequence<Dafny.Rune> _out121;
          bool _out122;
          bool _out123;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out124;
          DCOMP.COMP.GenExpr(_438_expr, selfIdent, @params, true, out _out121, out _out122, out _out123, out _out124);
          _439_exprString = _out121;
          _440___v26 = _out122;
          _441_recErased = _out123;
          _442_recIdents = _out124;
          _439_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _439_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _442_recIdents;
          if (isLast) {
            generated = _439_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _439_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Break) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _443___mcc_h23 = _source15.dtor_toLabel;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _444_toLabel = _443___mcc_h23;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source19 = _444_toLabel;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.Rune> _445___mcc_h171 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _446_lbl = _445___mcc_h171;
            {
              generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _446_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            }
          } else {
            {
              generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;");
            }
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _447___mcc_h24 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _448_body = _447___mcc_h24;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut _this = self.clone();\n"));
          }
          BigInteger _449_paramI;
          _449_paramI = BigInteger.Zero;
          while ((_449_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _450_param;
            _450_param = (@params).Select(_449_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut ")), DCOMP.__default.escapeIdent(_450_param)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), DCOMP.__default.escapeIdent(_450_param)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _449_paramI = (_449_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _451_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _452_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out125;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
          DCOMP.COMP.GenStmts(_448_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out125, out _out126);
          _451_bodyString = _out125;
          _452_bodyIdents = _out126;
          readIdents = _452_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _451_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_JumpTailCallStart) {
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("continue 'TAIL_CALL_START;");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Halt) {
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("panic!(\"Halt\");");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else {
        DAST._IExpression _453___mcc_h25 = _source15.dtor_Print_a0;
        DAST._IExpression _454_e = _453___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _455_printedExpr;
          bool _456_isOwned;
          bool _457___v27;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _458_recIdents;
          Dafny.ISequence<Dafny.Rune> _out127;
          bool _out128;
          bool _out129;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
          DCOMP.COMP.GenExpr(_454_e, selfIdent, @params, false, out _out127, out _out128, out _out129, out _out130);
          _455_printedExpr = _out127;
          _456_isOwned = _out128;
          _457___v27 = _out129;
          _458_recIdents = _out130;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_456_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _455_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _458_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source20 = e;
      if (_source20.is_Literal) {
        DAST._ILiteral _459___mcc_h0 = _source20.dtor_Literal_a0;
        DAST._ILiteral _source21 = _459___mcc_h0;
        if (_source21.is_BoolLiteral) {
          bool _460___mcc_h1 = _source21.dtor_BoolLiteral_a0;
          if ((_460___mcc_h1) == (false)) {
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
        } else if (_source21.is_IntLiteral) {
          Dafny.ISequence<Dafny.Rune> _461___mcc_h2 = _source21.dtor_IntLiteral_a0;
          DAST._IType _462___mcc_h3 = _source21.dtor_IntLiteral_a1;
          DAST._IType _463_t = _462___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _464_i = _461___mcc_h2;
          {
            DAST._IType _source22 = _463_t;
            if (_source22.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _465___mcc_h224 = _source22.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _466___mcc_h225 = _source22.dtor_typeArgs;
              DAST._IResolvedType _467___mcc_h226 = _source22.dtor_resolved;
              {
                s = _464_i;
              }
            } else if (_source22.is_Nullable) {
              DAST._IType _468___mcc_h230 = _source22.dtor_Nullable_a0;
              {
                s = _464_i;
              }
            } else if (_source22.is_Tuple) {
              Dafny.ISequence<DAST._IType> _469___mcc_h232 = _source22.dtor_Tuple_a0;
              {
                s = _464_i;
              }
            } else if (_source22.is_Array) {
              DAST._IType _470___mcc_h234 = _source22.dtor_element;
              BigInteger _471___mcc_h235 = _source22.dtor_dims;
              {
                s = _464_i;
              }
            } else if (_source22.is_Seq) {
              DAST._IType _472___mcc_h238 = _source22.dtor_element;
              {
                s = _464_i;
              }
            } else if (_source22.is_Set) {
              DAST._IType _473___mcc_h240 = _source22.dtor_element;
              {
                s = _464_i;
              }
            } else if (_source22.is_Multiset) {
              DAST._IType _474___mcc_h242 = _source22.dtor_element;
              {
                s = _464_i;
              }
            } else if (_source22.is_Map) {
              DAST._IType _475___mcc_h244 = _source22.dtor_key;
              DAST._IType _476___mcc_h245 = _source22.dtor_value;
              {
                s = _464_i;
              }
            } else if (_source22.is_Arrow) {
              Dafny.ISequence<DAST._IType> _477___mcc_h248 = _source22.dtor_args;
              DAST._IType _478___mcc_h249 = _source22.dtor_result;
              {
                s = _464_i;
              }
            } else if (_source22.is_Primitive) {
              DAST._IPrimitive _479___mcc_h252 = _source22.dtor_Primitive_a0;
              DAST._IPrimitive _source23 = _479___mcc_h252;
              if (_source23.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _464_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source23.is_Real) {
                {
                  s = _464_i;
                }
              } else if (_source23.is_String) {
                {
                  s = _464_i;
                }
              } else if (_source23.is_Bool) {
                {
                  s = _464_i;
                }
              } else {
                {
                  s = _464_i;
                }
              }
            } else if (_source22.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _480___mcc_h254 = _source22.dtor_Passthrough_a0;
              {
                s = _464_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _481___mcc_h256 = _source22.dtor_TypeArg_a0;
              {
                s = _464_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _482___mcc_h4 = _source21.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _483___mcc_h5 = _source21.dtor_DecLiteral_a1;
          DAST._IType _484___mcc_h6 = _source21.dtor_DecLiteral_a2;
          DAST._IType _485_t = _484___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _486_d = _483___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _487_n = _482___mcc_h4;
          {
            DAST._IType _source24 = _485_t;
            if (_source24.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _488___mcc_h258 = _source24.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _489___mcc_h259 = _source24.dtor_typeArgs;
              DAST._IResolvedType _490___mcc_h260 = _source24.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Nullable) {
              DAST._IType _491___mcc_h264 = _source24.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Tuple) {
              Dafny.ISequence<DAST._IType> _492___mcc_h266 = _source24.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Array) {
              DAST._IType _493___mcc_h268 = _source24.dtor_element;
              BigInteger _494___mcc_h269 = _source24.dtor_dims;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Seq) {
              DAST._IType _495___mcc_h272 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Set) {
              DAST._IType _496___mcc_h274 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Multiset) {
              DAST._IType _497___mcc_h276 = _source24.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Map) {
              DAST._IType _498___mcc_h278 = _source24.dtor_key;
              DAST._IType _499___mcc_h279 = _source24.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Arrow) {
              Dafny.ISequence<DAST._IType> _500___mcc_h282 = _source24.dtor_args;
              DAST._IType _501___mcc_h283 = _source24.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source24.is_Primitive) {
              DAST._IPrimitive _502___mcc_h286 = _source24.dtor_Primitive_a0;
              DAST._IPrimitive _source25 = _502___mcc_h286;
              if (_source25.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _487_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source25.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source25.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source24.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _503___mcc_h288 = _source24.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _504___mcc_h290 = _source24.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_487_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _486_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _505___mcc_h7 = _source21.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _506_l = _505___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _506_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source21.is_CharLiteral) {
          Dafny.Rune _507___mcc_h8 = _source21.dtor_CharLiteral_a0;
          Dafny.Rune _508_c = _507___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_508_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
      } else if (_source20.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _509___mcc_h9 = _source20.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _510_name = _509___mcc_h9;
        {
          s = DCOMP.__default.escapeIdent(_510_name);
          if (!((@params).Contains(_510_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_510_name);
        }
      } else if (_source20.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _511___mcc_h10 = _source20.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _512_path = _511___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_512_path);
          s = _out131;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source20.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _513___mcc_h11 = _source20.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _514_values = _513___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _515_i;
          _515_i = BigInteger.Zero;
          bool _516_allErased;
          _516_allErased = true;
          while ((_515_i) < (new BigInteger((_514_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _517___v30;
            bool _518___v31;
            bool _519_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _520___v32;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_514_values).Select(_515_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _517___v30 = _out132;
            _518___v31 = _out133;
            _519_isErased = _out134;
            _520___v32 = _out135;
            _516_allErased = (_516_allErased) && (_519_isErased);
            _515_i = (_515_i) + (BigInteger.One);
          }
          _515_i = BigInteger.Zero;
          while ((_515_i) < (new BigInteger((_514_values).Count))) {
            if ((_515_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _521_recursiveGen;
            bool _522___v33;
            bool _523_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _524_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_514_values).Select(_515_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _521_recursiveGen = _out136;
            _522___v33 = _out137;
            _523_isErased = _out138;
            _524_recIdents = _out139;
            if ((_523_isErased) && (!(_516_allErased))) {
              _521_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _524_recIdents);
            _515_i = (_515_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _516_allErased;
        }
      } else if (_source20.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _525___mcc_h12 = _source20.dtor_path;
        Dafny.ISequence<DAST._IExpression> _526___mcc_h13 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _527_args = _526___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _528_path = _525___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _529_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_528_path);
          _529_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _529_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _530_i;
          _530_i = BigInteger.Zero;
          while ((_530_i) < (new BigInteger((_527_args).Count))) {
            if ((_530_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _531_recursiveGen;
            bool _532___v34;
            bool _533_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _534_recIdents;
            Dafny.ISequence<Dafny.Rune> _out141;
            bool _out142;
            bool _out143;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
            DCOMP.COMP.GenExpr((_527_args).Select(_530_i), selfIdent, @params, true, out _out141, out _out142, out _out143, out _out144);
            _531_recursiveGen = _out141;
            _532___v34 = _out142;
            _533_isErased = _out143;
            _534_recIdents = _out144;
            if (_533_isErased) {
              _531_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _531_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _531_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _534_recIdents);
            _530_i = (_530_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _535___mcc_h14 = _source20.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _536_dims = _535___mcc_h14;
        {
          BigInteger _537_i;
          _537_i = (new BigInteger((_536_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_537_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _538_recursiveGen;
            bool _539___v35;
            bool _540_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _541_recIdents;
            Dafny.ISequence<Dafny.Rune> _out145;
            bool _out146;
            bool _out147;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
            DCOMP.COMP.GenExpr((_536_dims).Select(_537_i), selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
            _538_recursiveGen = _out145;
            _539___v35 = _out146;
            _540_isErased = _out147;
            _541_recIdents = _out148;
            if (!(_540_isErased)) {
              _538_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _538_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _538_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _541_recIdents);
            _537_i = (_537_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _542___mcc_h15 = _source20.dtor_path;
        Dafny.ISequence<Dafny.Rune> _543___mcc_h16 = _source20.dtor_variant;
        bool _544___mcc_h17 = _source20.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _545___mcc_h18 = _source20.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _546_values = _545___mcc_h18;
        bool _547_isCo = _544___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _548_variant = _543___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _549_path = _542___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _550_path;
          Dafny.ISequence<Dafny.Rune> _out149;
          _out149 = DCOMP.COMP.GenPath(_549_path);
          _550_path = _out149;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _550_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), DCOMP.__default.escapeIdent(_548_variant));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _551_i;
          _551_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_551_i) < (new BigInteger((_546_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_546_values).Select(_551_i);
            Dafny.ISequence<Dafny.Rune> _552_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _553_value = _let_tmp_rhs0.dtor__1;
            if ((_551_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_547_isCo) {
              Dafny.ISequence<Dafny.Rune> _554_recursiveGen;
              bool _555___v36;
              bool _556_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _557_recIdents;
              Dafny.ISequence<Dafny.Rune> _out150;
              bool _out151;
              bool _out152;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out153;
              DCOMP.COMP.GenExpr(_553_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out150, out _out151, out _out152, out _out153);
              _554_recursiveGen = _out150;
              _555___v36 = _out151;
              _556_isErased = _out152;
              _557_recIdents = _out153;
              if (!(_556_isErased)) {
                _554_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _554_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _557_recIdents);
              Dafny.ISequence<Dafny.Rune> _558_allReadCloned;
              _558_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_557_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _559_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_557_recIdents).Elements) {
                  _559_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_557_recIdents).Contains(_559_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1197)");
              after__ASSIGN_SUCH_THAT_0:;
                _558_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_558_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let ")), DCOMP.__default.escapeIdent(_559_next)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), DCOMP.__default.escapeIdent(_559_next)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _557_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_557_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_559_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent(_552_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _558_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _560_recursiveGen;
              bool _561___v37;
              bool _562_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _563_recIdents;
              Dafny.ISequence<Dafny.Rune> _out154;
              bool _out155;
              bool _out156;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out157;
              DCOMP.COMP.GenExpr(_553_value, selfIdent, @params, true, out _out154, out _out155, out _out156, out _out157);
              _560_recursiveGen = _out154;
              _561___v37 = _out155;
              _562_isErased = _out156;
              _563_recIdents = _out157;
              if (!(_562_isErased)) {
                _560_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _560_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, DCOMP.__default.escapeIdent(_552_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _563_recIdents);
            }
            _551_i = (_551_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source20.is_Convert) {
        DAST._IExpression _564___mcc_h19 = _source20.dtor_value;
        DAST._IType _565___mcc_h20 = _source20.dtor_from;
        DAST._IType _566___mcc_h21 = _source20.dtor_typ;
        DAST._IType _567_toTpe = _566___mcc_h21;
        DAST._IType _568_fromTpe = _565___mcc_h20;
        DAST._IExpression _569_expr = _564___mcc_h19;
        {
          if (object.Equals(_568_fromTpe, _567_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _570_recursiveGen;
            bool _571_recOwned;
            bool _572_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _573_recIdents;
            Dafny.ISequence<Dafny.Rune> _out158;
            bool _out159;
            bool _out160;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out161;
            DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out158, out _out159, out _out160, out _out161);
            _570_recursiveGen = _out158;
            _571_recOwned = _out159;
            _572_recErased = _out160;
            _573_recIdents = _out161;
            s = _570_recursiveGen;
            isOwned = _571_recOwned;
            isErased = _572_recErased;
            readIdents = _573_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source26 = _System.Tuple2<DAST._IType, DAST._IType>.create(_568_fromTpe, _567_toTpe);
            DAST._IType _574___mcc_h292 = _source26.dtor__0;
            DAST._IType _575___mcc_h293 = _source26.dtor__1;
            DAST._IType _source27 = _574___mcc_h292;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _576___mcc_h296 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _577___mcc_h297 = _source27.dtor_typeArgs;
              DAST._IResolvedType _578___mcc_h298 = _source27.dtor_resolved;
              DAST._IResolvedType _source28 = _578___mcc_h298;
              if (_source28.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _579___mcc_h308 = _source28.dtor_path;
                DAST._IType _source29 = _575___mcc_h293;
                if (_source29.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _580___mcc_h312 = _source29.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _581___mcc_h313 = _source29.dtor_typeArgs;
                  DAST._IResolvedType _582___mcc_h314 = _source29.dtor_resolved;
                  DAST._IResolvedType _source30 = _582___mcc_h314;
                  if (_source30.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _583___mcc_h318 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _584_recursiveGen;
                      bool _585_recOwned;
                      bool _586_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _587_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out162;
                      bool _out163;
                      bool _out164;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out165;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out162, out _out163, out _out164, out _out165);
                      _584_recursiveGen = _out162;
                      _585_recOwned = _out163;
                      _586_recErased = _out164;
                      _587_recIdents = _out165;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _584_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _585_recOwned;
                      isErased = _586_recErased;
                      readIdents = _587_recIdents;
                    }
                  } else if (_source30.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _588___mcc_h320 = _source30.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _589_recursiveGen;
                      bool _590_recOwned;
                      bool _591_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _592_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out166;
                      bool _out167;
                      bool _out168;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                      _589_recursiveGen = _out166;
                      _590_recOwned = _out167;
                      _591_recErased = _out168;
                      _592_recIdents = _out169;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _589_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _590_recOwned;
                      isErased = _591_recErased;
                      readIdents = _592_recIdents;
                    }
                  } else {
                    DAST._IType _593___mcc_h322 = _source30.dtor_Newtype_a0;
                    DAST._IType _594_b = _593___mcc_h322;
                    {
                      if (object.Equals(_568_fromTpe, _594_b)) {
                        Dafny.ISequence<Dafny.Rune> _595_recursiveGen;
                        bool _596_recOwned;
                        bool _597_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _598_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out170;
                        bool _out171;
                        bool _out172;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                        _595_recursiveGen = _out170;
                        _596_recOwned = _out171;
                        _597_recErased = _out172;
                        _598_recIdents = _out173;
                        Dafny.ISequence<Dafny.Rune> _599_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out174;
                        _out174 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _599_rhsType = _out174;
                        Dafny.ISequence<Dafny.Rune> _600_uneraseFn;
                        _600_uneraseFn = ((_596_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _599_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _600_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _595_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _596_recOwned;
                        isErased = false;
                        readIdents = _598_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out175;
                        bool _out176;
                        bool _out177;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out178;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _594_b), _594_b, _567_toTpe), selfIdent, @params, mustOwn, out _out175, out _out176, out _out177, out _out178);
                        s = _out175;
                        isOwned = _out176;
                        isErased = _out177;
                        readIdents = _out178;
                      }
                    }
                  }
                } else if (_source29.is_Nullable) {
                  DAST._IType _601___mcc_h324 = _source29.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _602_recursiveGen;
                    bool _603_recOwned;
                    bool _604_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _605_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out179;
                    bool _out180;
                    bool _out181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out182;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out179, out _out180, out _out181, out _out182);
                    _602_recursiveGen = _out179;
                    _603_recOwned = _out180;
                    _604_recErased = _out181;
                    _605_recIdents = _out182;
                    if (!(_603_recOwned)) {
                      _602_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_602_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _602_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _604_recErased;
                    readIdents = _605_recIdents;
                  }
                } else if (_source29.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _606___mcc_h326 = _source29.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _607_recursiveGen;
                    bool _608_recOwned;
                    bool _609_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _610_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out183;
                    bool _out184;
                    bool _out185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out186;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out183, out _out184, out _out185, out _out186);
                    _607_recursiveGen = _out183;
                    _608_recOwned = _out184;
                    _609_recErased = _out185;
                    _610_recIdents = _out186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _607_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _608_recOwned;
                    isErased = _609_recErased;
                    readIdents = _610_recIdents;
                  }
                } else if (_source29.is_Array) {
                  DAST._IType _611___mcc_h328 = _source29.dtor_element;
                  BigInteger _612___mcc_h329 = _source29.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                    bool _614_recOwned;
                    bool _615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out187;
                    bool _out188;
                    bool _out189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out190;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out187, out _out188, out _out189, out _out190);
                    _613_recursiveGen = _out187;
                    _614_recOwned = _out188;
                    _615_recErased = _out189;
                    _616_recIdents = _out190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _614_recOwned;
                    isErased = _615_recErased;
                    readIdents = _616_recIdents;
                  }
                } else if (_source29.is_Seq) {
                  DAST._IType _617___mcc_h332 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _618_recursiveGen;
                    bool _619_recOwned;
                    bool _620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out191;
                    bool _out192;
                    bool _out193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out194;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out191, out _out192, out _out193, out _out194);
                    _618_recursiveGen = _out191;
                    _619_recOwned = _out192;
                    _620_recErased = _out193;
                    _621_recIdents = _out194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _619_recOwned;
                    isErased = _620_recErased;
                    readIdents = _621_recIdents;
                  }
                } else if (_source29.is_Set) {
                  DAST._IType _622___mcc_h334 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _623_recursiveGen;
                    bool _624_recOwned;
                    bool _625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out195;
                    bool _out196;
                    bool _out197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out198;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out195, out _out196, out _out197, out _out198);
                    _623_recursiveGen = _out195;
                    _624_recOwned = _out196;
                    _625_recErased = _out197;
                    _626_recIdents = _out198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _624_recOwned;
                    isErased = _625_recErased;
                    readIdents = _626_recIdents;
                  }
                } else if (_source29.is_Multiset) {
                  DAST._IType _627___mcc_h336 = _source29.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _628_recursiveGen;
                    bool _629_recOwned;
                    bool _630_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _631_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out199;
                    bool _out200;
                    bool _out201;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out202;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out199, out _out200, out _out201, out _out202);
                    _628_recursiveGen = _out199;
                    _629_recOwned = _out200;
                    _630_recErased = _out201;
                    _631_recIdents = _out202;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _628_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _629_recOwned;
                    isErased = _630_recErased;
                    readIdents = _631_recIdents;
                  }
                } else if (_source29.is_Map) {
                  DAST._IType _632___mcc_h338 = _source29.dtor_key;
                  DAST._IType _633___mcc_h339 = _source29.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _634_recursiveGen;
                    bool _635_recOwned;
                    bool _636_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _637_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out203;
                    bool _out204;
                    bool _out205;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out206;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out203, out _out204, out _out205, out _out206);
                    _634_recursiveGen = _out203;
                    _635_recOwned = _out204;
                    _636_recErased = _out205;
                    _637_recIdents = _out206;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _635_recOwned;
                    isErased = _636_recErased;
                    readIdents = _637_recIdents;
                  }
                } else if (_source29.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _638___mcc_h342 = _source29.dtor_args;
                  DAST._IType _639___mcc_h343 = _source29.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _640_recursiveGen;
                    bool _641_recOwned;
                    bool _642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out207;
                    bool _out208;
                    bool _out209;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out210;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out207, out _out208, out _out209, out _out210);
                    _640_recursiveGen = _out207;
                    _641_recOwned = _out208;
                    _642_recErased = _out209;
                    _643_recIdents = _out210;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _641_recOwned;
                    isErased = _642_recErased;
                    readIdents = _643_recIdents;
                  }
                } else if (_source29.is_Primitive) {
                  DAST._IPrimitive _644___mcc_h346 = _source29.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _645_recursiveGen;
                    bool _646_recOwned;
                    bool _647_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _648_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out211;
                    bool _out212;
                    bool _out213;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out214;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out211, out _out212, out _out213, out _out214);
                    _645_recursiveGen = _out211;
                    _646_recOwned = _out212;
                    _647_recErased = _out213;
                    _648_recIdents = _out214;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _646_recOwned;
                    isErased = _647_recErased;
                    readIdents = _648_recIdents;
                  }
                } else if (_source29.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _649___mcc_h348 = _source29.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _650_recursiveGen;
                    bool _651_recOwned;
                    bool _652_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _653_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out215;
                    bool _out216;
                    bool _out217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out218;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out215, out _out216, out _out217, out _out218);
                    _650_recursiveGen = _out215;
                    _651_recOwned = _out216;
                    _652_recErased = _out217;
                    _653_recIdents = _out218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _651_recOwned;
                    isErased = _652_recErased;
                    readIdents = _653_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _654___mcc_h350 = _source29.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _655_recursiveGen;
                    bool _656_recOwned;
                    bool _657_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _658_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out219;
                    bool _out220;
                    bool _out221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out222;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out219, out _out220, out _out221, out _out222);
                    _655_recursiveGen = _out219;
                    _656_recOwned = _out220;
                    _657_recErased = _out221;
                    _658_recIdents = _out222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _656_recOwned;
                    isErased = _657_recErased;
                    readIdents = _658_recIdents;
                  }
                }
              } else if (_source28.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _659___mcc_h352 = _source28.dtor_path;
                DAST._IType _source31 = _575___mcc_h293;
                if (_source31.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _660___mcc_h356 = _source31.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _661___mcc_h357 = _source31.dtor_typeArgs;
                  DAST._IResolvedType _662___mcc_h358 = _source31.dtor_resolved;
                  DAST._IResolvedType _source32 = _662___mcc_h358;
                  if (_source32.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _663___mcc_h362 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _664_recursiveGen;
                      bool _665_recOwned;
                      bool _666_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _667_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out223;
                      bool _out224;
                      bool _out225;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out226;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out223, out _out224, out _out225, out _out226);
                      _664_recursiveGen = _out223;
                      _665_recOwned = _out224;
                      _666_recErased = _out225;
                      _667_recIdents = _out226;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _664_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _665_recOwned;
                      isErased = _666_recErased;
                      readIdents = _667_recIdents;
                    }
                  } else if (_source32.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _668___mcc_h364 = _source32.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _669_recursiveGen;
                      bool _670_recOwned;
                      bool _671_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _672_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out227;
                      bool _out228;
                      bool _out229;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                      _669_recursiveGen = _out227;
                      _670_recOwned = _out228;
                      _671_recErased = _out229;
                      _672_recIdents = _out230;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _670_recOwned;
                      isErased = _671_recErased;
                      readIdents = _672_recIdents;
                    }
                  } else {
                    DAST._IType _673___mcc_h366 = _source32.dtor_Newtype_a0;
                    DAST._IType _674_b = _673___mcc_h366;
                    {
                      if (object.Equals(_568_fromTpe, _674_b)) {
                        Dafny.ISequence<Dafny.Rune> _675_recursiveGen;
                        bool _676_recOwned;
                        bool _677_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _678_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out231;
                        bool _out232;
                        bool _out233;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                        _675_recursiveGen = _out231;
                        _676_recOwned = _out232;
                        _677_recErased = _out233;
                        _678_recIdents = _out234;
                        Dafny.ISequence<Dafny.Rune> _679_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out235;
                        _out235 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _679_rhsType = _out235;
                        Dafny.ISequence<Dafny.Rune> _680_uneraseFn;
                        _680_uneraseFn = ((_676_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _679_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _680_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _676_recOwned;
                        isErased = false;
                        readIdents = _678_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out236;
                        bool _out237;
                        bool _out238;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out239;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _674_b), _674_b, _567_toTpe), selfIdent, @params, mustOwn, out _out236, out _out237, out _out238, out _out239);
                        s = _out236;
                        isOwned = _out237;
                        isErased = _out238;
                        readIdents = _out239;
                      }
                    }
                  }
                } else if (_source31.is_Nullable) {
                  DAST._IType _681___mcc_h368 = _source31.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                    bool _683_recOwned;
                    bool _684_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out240;
                    bool _out241;
                    bool _out242;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out243;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out240, out _out241, out _out242, out _out243);
                    _682_recursiveGen = _out240;
                    _683_recOwned = _out241;
                    _684_recErased = _out242;
                    _685_recIdents = _out243;
                    if (!(_683_recOwned)) {
                      _682_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_682_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _684_recErased;
                    readIdents = _685_recIdents;
                  }
                } else if (_source31.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _686___mcc_h370 = _source31.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _687_recursiveGen;
                    bool _688_recOwned;
                    bool _689_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _690_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out244;
                    bool _out245;
                    bool _out246;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out247;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out244, out _out245, out _out246, out _out247);
                    _687_recursiveGen = _out244;
                    _688_recOwned = _out245;
                    _689_recErased = _out246;
                    _690_recIdents = _out247;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _688_recOwned;
                    isErased = _689_recErased;
                    readIdents = _690_recIdents;
                  }
                } else if (_source31.is_Array) {
                  DAST._IType _691___mcc_h372 = _source31.dtor_element;
                  BigInteger _692___mcc_h373 = _source31.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _693_recursiveGen;
                    bool _694_recOwned;
                    bool _695_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _696_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out248;
                    bool _out249;
                    bool _out250;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out251;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out248, out _out249, out _out250, out _out251);
                    _693_recursiveGen = _out248;
                    _694_recOwned = _out249;
                    _695_recErased = _out250;
                    _696_recIdents = _out251;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _693_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _694_recOwned;
                    isErased = _695_recErased;
                    readIdents = _696_recIdents;
                  }
                } else if (_source31.is_Seq) {
                  DAST._IType _697___mcc_h376 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _698_recursiveGen;
                    bool _699_recOwned;
                    bool _700_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _701_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out252;
                    bool _out253;
                    bool _out254;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out255;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out252, out _out253, out _out254, out _out255);
                    _698_recursiveGen = _out252;
                    _699_recOwned = _out253;
                    _700_recErased = _out254;
                    _701_recIdents = _out255;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _699_recOwned;
                    isErased = _700_recErased;
                    readIdents = _701_recIdents;
                  }
                } else if (_source31.is_Set) {
                  DAST._IType _702___mcc_h378 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                    bool _704_recOwned;
                    bool _705_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out256;
                    bool _out257;
                    bool _out258;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out259;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out256, out _out257, out _out258, out _out259);
                    _703_recursiveGen = _out256;
                    _704_recOwned = _out257;
                    _705_recErased = _out258;
                    _706_recIdents = _out259;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _704_recOwned;
                    isErased = _705_recErased;
                    readIdents = _706_recIdents;
                  }
                } else if (_source31.is_Multiset) {
                  DAST._IType _707___mcc_h380 = _source31.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _708_recursiveGen;
                    bool _709_recOwned;
                    bool _710_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _711_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out260;
                    bool _out261;
                    bool _out262;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out263;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out260, out _out261, out _out262, out _out263);
                    _708_recursiveGen = _out260;
                    _709_recOwned = _out261;
                    _710_recErased = _out262;
                    _711_recIdents = _out263;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _708_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _709_recOwned;
                    isErased = _710_recErased;
                    readIdents = _711_recIdents;
                  }
                } else if (_source31.is_Map) {
                  DAST._IType _712___mcc_h382 = _source31.dtor_key;
                  DAST._IType _713___mcc_h383 = _source31.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _714_recursiveGen;
                    bool _715_recOwned;
                    bool _716_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _717_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out264;
                    bool _out265;
                    bool _out266;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out267;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out264, out _out265, out _out266, out _out267);
                    _714_recursiveGen = _out264;
                    _715_recOwned = _out265;
                    _716_recErased = _out266;
                    _717_recIdents = _out267;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _715_recOwned;
                    isErased = _716_recErased;
                    readIdents = _717_recIdents;
                  }
                } else if (_source31.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _718___mcc_h386 = _source31.dtor_args;
                  DAST._IType _719___mcc_h387 = _source31.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _720_recursiveGen;
                    bool _721_recOwned;
                    bool _722_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _723_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out268;
                    bool _out269;
                    bool _out270;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out271;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out268, out _out269, out _out270, out _out271);
                    _720_recursiveGen = _out268;
                    _721_recOwned = _out269;
                    _722_recErased = _out270;
                    _723_recIdents = _out271;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _720_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _721_recOwned;
                    isErased = _722_recErased;
                    readIdents = _723_recIdents;
                  }
                } else if (_source31.is_Primitive) {
                  DAST._IPrimitive _724___mcc_h390 = _source31.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _725_recursiveGen;
                    bool _726_recOwned;
                    bool _727_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _728_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out272;
                    bool _out273;
                    bool _out274;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out275;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out272, out _out273, out _out274, out _out275);
                    _725_recursiveGen = _out272;
                    _726_recOwned = _out273;
                    _727_recErased = _out274;
                    _728_recIdents = _out275;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _726_recOwned;
                    isErased = _727_recErased;
                    readIdents = _728_recIdents;
                  }
                } else if (_source31.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _729___mcc_h392 = _source31.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _730_recursiveGen;
                    bool _731_recOwned;
                    bool _732_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _733_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out276;
                    bool _out277;
                    bool _out278;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out279;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out276, out _out277, out _out278, out _out279);
                    _730_recursiveGen = _out276;
                    _731_recOwned = _out277;
                    _732_recErased = _out278;
                    _733_recIdents = _out279;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _731_recOwned;
                    isErased = _732_recErased;
                    readIdents = _733_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _734___mcc_h394 = _source31.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _735_recursiveGen;
                    bool _736_recOwned;
                    bool _737_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _738_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out280;
                    bool _out281;
                    bool _out282;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out283;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out280, out _out281, out _out282, out _out283);
                    _735_recursiveGen = _out280;
                    _736_recOwned = _out281;
                    _737_recErased = _out282;
                    _738_recIdents = _out283;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _736_recOwned;
                    isErased = _737_recErased;
                    readIdents = _738_recIdents;
                  }
                }
              } else {
                DAST._IType _739___mcc_h396 = _source28.dtor_Newtype_a0;
                DAST._IType _source33 = _575___mcc_h293;
                if (_source33.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _740___mcc_h400 = _source33.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _741___mcc_h401 = _source33.dtor_typeArgs;
                  DAST._IResolvedType _742___mcc_h402 = _source33.dtor_resolved;
                  DAST._IResolvedType _source34 = _742___mcc_h402;
                  if (_source34.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _743___mcc_h409 = _source34.dtor_path;
                    DAST._IType _744_b = _739___mcc_h396;
                    {
                      if (object.Equals(_744_b, _567_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _745_recursiveGen;
                        bool _746_recOwned;
                        bool _747_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _748_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out284;
                        bool _out285;
                        bool _out286;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out287;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out284, out _out285, out _out286, out _out287);
                        _745_recursiveGen = _out284;
                        _746_recOwned = _out285;
                        _747_recErased = _out286;
                        _748_recIdents = _out287;
                        Dafny.ISequence<Dafny.Rune> _749_uneraseFn;
                        _749_uneraseFn = ((_746_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _749_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _745_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _746_recOwned;
                        isErased = true;
                        readIdents = _748_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out288;
                        bool _out289;
                        bool _out290;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out291;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _744_b), _744_b, _567_toTpe), selfIdent, @params, mustOwn, out _out288, out _out289, out _out290, out _out291);
                        s = _out288;
                        isOwned = _out289;
                        isErased = _out290;
                        readIdents = _out291;
                      }
                    }
                  } else if (_source34.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _750___mcc_h412 = _source34.dtor_path;
                    DAST._IType _751_b = _739___mcc_h396;
                    {
                      if (object.Equals(_751_b, _567_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _752_recursiveGen;
                        bool _753_recOwned;
                        bool _754_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _755_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out292;
                        bool _out293;
                        bool _out294;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out295;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out292, out _out293, out _out294, out _out295);
                        _752_recursiveGen = _out292;
                        _753_recOwned = _out293;
                        _754_recErased = _out294;
                        _755_recIdents = _out295;
                        Dafny.ISequence<Dafny.Rune> _756_uneraseFn;
                        _756_uneraseFn = ((_753_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _756_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _753_recOwned;
                        isErased = true;
                        readIdents = _755_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _751_b), _751_b, _567_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  } else {
                    DAST._IType _757___mcc_h415 = _source34.dtor_Newtype_a0;
                    DAST._IType _758_b = _757___mcc_h415;
                    {
                      if (object.Equals(_568_fromTpe, _758_b)) {
                        Dafny.ISequence<Dafny.Rune> _759_recursiveGen;
                        bool _760_recOwned;
                        bool _761_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _762_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out300;
                        bool _out301;
                        bool _out302;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                        _759_recursiveGen = _out300;
                        _760_recOwned = _out301;
                        _761_recErased = _out302;
                        _762_recIdents = _out303;
                        Dafny.ISequence<Dafny.Rune> _763_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out304;
                        _out304 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _763_rhsType = _out304;
                        Dafny.ISequence<Dafny.Rune> _764_uneraseFn;
                        _764_uneraseFn = ((_760_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _763_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _764_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _760_recOwned;
                        isErased = false;
                        readIdents = _762_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out305;
                        bool _out306;
                        bool _out307;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out308;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _758_b), _758_b, _567_toTpe), selfIdent, @params, mustOwn, out _out305, out _out306, out _out307, out _out308);
                        s = _out305;
                        isOwned = _out306;
                        isErased = _out307;
                        readIdents = _out308;
                      }
                    }
                  }
                } else if (_source33.is_Nullable) {
                  DAST._IType _765___mcc_h418 = _source33.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _766_recursiveGen;
                    bool _767_recOwned;
                    bool _768_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _769_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out309;
                    bool _out310;
                    bool _out311;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out312;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out309, out _out310, out _out311, out _out312);
                    _766_recursiveGen = _out309;
                    _767_recOwned = _out310;
                    _768_recErased = _out311;
                    _769_recIdents = _out312;
                    if (!(_767_recOwned)) {
                      _766_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_766_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _766_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _768_recErased;
                    readIdents = _769_recIdents;
                  }
                } else if (_source33.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _770___mcc_h421 = _source33.dtor_Tuple_a0;
                  DAST._IType _771_b = _739___mcc_h396;
                  {
                    if (object.Equals(_771_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _772_recursiveGen;
                      bool _773_recOwned;
                      bool _774_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _775_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out313;
                      bool _out314;
                      bool _out315;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out316;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out313, out _out314, out _out315, out _out316);
                      _772_recursiveGen = _out313;
                      _773_recOwned = _out314;
                      _774_recErased = _out315;
                      _775_recIdents = _out316;
                      Dafny.ISequence<Dafny.Rune> _776_uneraseFn;
                      _776_uneraseFn = ((_773_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _776_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _772_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _773_recOwned;
                      isErased = true;
                      readIdents = _775_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out317;
                      bool _out318;
                      bool _out319;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out320;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _771_b), _771_b, _567_toTpe), selfIdent, @params, mustOwn, out _out317, out _out318, out _out319, out _out320);
                      s = _out317;
                      isOwned = _out318;
                      isErased = _out319;
                      readIdents = _out320;
                    }
                  }
                } else if (_source33.is_Array) {
                  DAST._IType _777___mcc_h424 = _source33.dtor_element;
                  BigInteger _778___mcc_h425 = _source33.dtor_dims;
                  DAST._IType _779_b = _739___mcc_h396;
                  {
                    if (object.Equals(_779_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _780_recursiveGen;
                      bool _781_recOwned;
                      bool _782_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _783_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out321;
                      bool _out322;
                      bool _out323;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out324;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out321, out _out322, out _out323, out _out324);
                      _780_recursiveGen = _out321;
                      _781_recOwned = _out322;
                      _782_recErased = _out323;
                      _783_recIdents = _out324;
                      Dafny.ISequence<Dafny.Rune> _784_uneraseFn;
                      _784_uneraseFn = ((_781_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _784_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _780_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _781_recOwned;
                      isErased = true;
                      readIdents = _783_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out325;
                      bool _out326;
                      bool _out327;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out328;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _779_b), _779_b, _567_toTpe), selfIdent, @params, mustOwn, out _out325, out _out326, out _out327, out _out328);
                      s = _out325;
                      isOwned = _out326;
                      isErased = _out327;
                      readIdents = _out328;
                    }
                  }
                } else if (_source33.is_Seq) {
                  DAST._IType _785___mcc_h430 = _source33.dtor_element;
                  DAST._IType _786_b = _739___mcc_h396;
                  {
                    if (object.Equals(_786_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _787_recursiveGen;
                      bool _788_recOwned;
                      bool _789_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _790_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out329;
                      bool _out330;
                      bool _out331;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out332;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out329, out _out330, out _out331, out _out332);
                      _787_recursiveGen = _out329;
                      _788_recOwned = _out330;
                      _789_recErased = _out331;
                      _790_recIdents = _out332;
                      Dafny.ISequence<Dafny.Rune> _791_uneraseFn;
                      _791_uneraseFn = ((_788_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _791_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _787_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _788_recOwned;
                      isErased = true;
                      readIdents = _790_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out333;
                      bool _out334;
                      bool _out335;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out336;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _786_b), _786_b, _567_toTpe), selfIdent, @params, mustOwn, out _out333, out _out334, out _out335, out _out336);
                      s = _out333;
                      isOwned = _out334;
                      isErased = _out335;
                      readIdents = _out336;
                    }
                  }
                } else if (_source33.is_Set) {
                  DAST._IType _792___mcc_h433 = _source33.dtor_element;
                  DAST._IType _793_b = _739___mcc_h396;
                  {
                    if (object.Equals(_793_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _794_recursiveGen;
                      bool _795_recOwned;
                      bool _796_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _797_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out337;
                      bool _out338;
                      bool _out339;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out340;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out337, out _out338, out _out339, out _out340);
                      _794_recursiveGen = _out337;
                      _795_recOwned = _out338;
                      _796_recErased = _out339;
                      _797_recIdents = _out340;
                      Dafny.ISequence<Dafny.Rune> _798_uneraseFn;
                      _798_uneraseFn = ((_795_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _798_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _794_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _795_recOwned;
                      isErased = true;
                      readIdents = _797_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out341;
                      bool _out342;
                      bool _out343;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out344;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _793_b), _793_b, _567_toTpe), selfIdent, @params, mustOwn, out _out341, out _out342, out _out343, out _out344);
                      s = _out341;
                      isOwned = _out342;
                      isErased = _out343;
                      readIdents = _out344;
                    }
                  }
                } else if (_source33.is_Multiset) {
                  DAST._IType _799___mcc_h436 = _source33.dtor_element;
                  DAST._IType _800_b = _739___mcc_h396;
                  {
                    if (object.Equals(_800_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _801_recursiveGen;
                      bool _802_recOwned;
                      bool _803_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _804_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out345;
                      bool _out346;
                      bool _out347;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out348;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out345, out _out346, out _out347, out _out348);
                      _801_recursiveGen = _out345;
                      _802_recOwned = _out346;
                      _803_recErased = _out347;
                      _804_recIdents = _out348;
                      Dafny.ISequence<Dafny.Rune> _805_uneraseFn;
                      _805_uneraseFn = ((_802_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _805_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _801_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _802_recOwned;
                      isErased = true;
                      readIdents = _804_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out349;
                      bool _out350;
                      bool _out351;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out352;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _800_b), _800_b, _567_toTpe), selfIdent, @params, mustOwn, out _out349, out _out350, out _out351, out _out352);
                      s = _out349;
                      isOwned = _out350;
                      isErased = _out351;
                      readIdents = _out352;
                    }
                  }
                } else if (_source33.is_Map) {
                  DAST._IType _806___mcc_h439 = _source33.dtor_key;
                  DAST._IType _807___mcc_h440 = _source33.dtor_value;
                  DAST._IType _808_b = _739___mcc_h396;
                  {
                    if (object.Equals(_808_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _809_recursiveGen;
                      bool _810_recOwned;
                      bool _811_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _812_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out353;
                      bool _out354;
                      bool _out355;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out356;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out353, out _out354, out _out355, out _out356);
                      _809_recursiveGen = _out353;
                      _810_recOwned = _out354;
                      _811_recErased = _out355;
                      _812_recIdents = _out356;
                      Dafny.ISequence<Dafny.Rune> _813_uneraseFn;
                      _813_uneraseFn = ((_810_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _813_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _809_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _810_recOwned;
                      isErased = true;
                      readIdents = _812_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out357;
                      bool _out358;
                      bool _out359;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _808_b), _808_b, _567_toTpe), selfIdent, @params, mustOwn, out _out357, out _out358, out _out359, out _out360);
                      s = _out357;
                      isOwned = _out358;
                      isErased = _out359;
                      readIdents = _out360;
                    }
                  }
                } else if (_source33.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _814___mcc_h445 = _source33.dtor_args;
                  DAST._IType _815___mcc_h446 = _source33.dtor_result;
                  DAST._IType _816_b = _739___mcc_h396;
                  {
                    if (object.Equals(_816_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _817_recursiveGen;
                      bool _818_recOwned;
                      bool _819_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _820_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out361;
                      bool _out362;
                      bool _out363;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out361, out _out362, out _out363, out _out364);
                      _817_recursiveGen = _out361;
                      _818_recOwned = _out362;
                      _819_recErased = _out363;
                      _820_recIdents = _out364;
                      Dafny.ISequence<Dafny.Rune> _821_uneraseFn;
                      _821_uneraseFn = ((_818_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _821_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _817_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _818_recOwned;
                      isErased = true;
                      readIdents = _820_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out365;
                      bool _out366;
                      bool _out367;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _816_b), _816_b, _567_toTpe), selfIdent, @params, mustOwn, out _out365, out _out366, out _out367, out _out368);
                      s = _out365;
                      isOwned = _out366;
                      isErased = _out367;
                      readIdents = _out368;
                    }
                  }
                } else if (_source33.is_Primitive) {
                  DAST._IPrimitive _822___mcc_h451 = _source33.dtor_Primitive_a0;
                  DAST._IType _823_b = _739___mcc_h396;
                  {
                    if (object.Equals(_823_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _824_recursiveGen;
                      bool _825_recOwned;
                      bool _826_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _827_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out369;
                      bool _out370;
                      bool _out371;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out369, out _out370, out _out371, out _out372);
                      _824_recursiveGen = _out369;
                      _825_recOwned = _out370;
                      _826_recErased = _out371;
                      _827_recIdents = _out372;
                      Dafny.ISequence<Dafny.Rune> _828_uneraseFn;
                      _828_uneraseFn = ((_825_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _828_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _824_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _825_recOwned;
                      isErased = true;
                      readIdents = _827_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out373;
                      bool _out374;
                      bool _out375;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out376;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _823_b), _823_b, _567_toTpe), selfIdent, @params, mustOwn, out _out373, out _out374, out _out375, out _out376);
                      s = _out373;
                      isOwned = _out374;
                      isErased = _out375;
                      readIdents = _out376;
                    }
                  }
                } else if (_source33.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _829___mcc_h454 = _source33.dtor_Passthrough_a0;
                  DAST._IType _830_b = _739___mcc_h396;
                  {
                    if (object.Equals(_830_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _831_recursiveGen;
                      bool _832_recOwned;
                      bool _833_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _834_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out377;
                      bool _out378;
                      bool _out379;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out380;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out377, out _out378, out _out379, out _out380);
                      _831_recursiveGen = _out377;
                      _832_recOwned = _out378;
                      _833_recErased = _out379;
                      _834_recIdents = _out380;
                      Dafny.ISequence<Dafny.Rune> _835_uneraseFn;
                      _835_uneraseFn = ((_832_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _835_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _831_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _832_recOwned;
                      isErased = true;
                      readIdents = _834_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out381;
                      bool _out382;
                      bool _out383;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out384;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _830_b), _830_b, _567_toTpe), selfIdent, @params, mustOwn, out _out381, out _out382, out _out383, out _out384);
                      s = _out381;
                      isOwned = _out382;
                      isErased = _out383;
                      readIdents = _out384;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _836___mcc_h457 = _source33.dtor_TypeArg_a0;
                  DAST._IType _837_b = _739___mcc_h396;
                  {
                    if (object.Equals(_837_b, _567_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _838_recursiveGen;
                      bool _839_recOwned;
                      bool _840_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _841_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out385;
                      bool _out386;
                      bool _out387;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out388;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out385, out _out386, out _out387, out _out388);
                      _838_recursiveGen = _out385;
                      _839_recOwned = _out386;
                      _840_recErased = _out387;
                      _841_recIdents = _out388;
                      Dafny.ISequence<Dafny.Rune> _842_uneraseFn;
                      _842_uneraseFn = ((_839_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _842_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _838_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _839_recOwned;
                      isErased = true;
                      readIdents = _841_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out389;
                      bool _out390;
                      bool _out391;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out392;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _837_b), _837_b, _567_toTpe), selfIdent, @params, mustOwn, out _out389, out _out390, out _out391, out _out392);
                      s = _out389;
                      isOwned = _out390;
                      isErased = _out391;
                      readIdents = _out392;
                    }
                  }
                }
              }
            } else if (_source27.is_Nullable) {
              DAST._IType _843___mcc_h460 = _source27.dtor_Nullable_a0;
              DAST._IType _source35 = _575___mcc_h293;
              if (_source35.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _844___mcc_h464 = _source35.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _845___mcc_h465 = _source35.dtor_typeArgs;
                DAST._IResolvedType _846___mcc_h466 = _source35.dtor_resolved;
                DAST._IResolvedType _source36 = _846___mcc_h466;
                if (_source36.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _847___mcc_h473 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _848_recursiveGen;
                    bool _849_recOwned;
                    bool _850_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _851_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out393;
                    bool _out394;
                    bool _out395;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out396;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out393, out _out394, out _out395, out _out396);
                    _848_recursiveGen = _out393;
                    _849_recOwned = _out394;
                    _850_recErased = _out395;
                    _851_recIdents = _out396;
                    if (!(_849_recOwned)) {
                      _848_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_848_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_848_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _849_recOwned;
                    isErased = _850_recErased;
                    readIdents = _851_recIdents;
                  }
                } else if (_source36.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _852___mcc_h476 = _source36.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _853_recursiveGen;
                    bool _854_recOwned;
                    bool _855_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _856_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out397;
                    bool _out398;
                    bool _out399;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out400;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out397, out _out398, out _out399, out _out400);
                    _853_recursiveGen = _out397;
                    _854_recOwned = _out398;
                    _855_recErased = _out399;
                    _856_recIdents = _out400;
                    if (!(_854_recOwned)) {
                      _853_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_853_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_853_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _854_recOwned;
                    isErased = _855_recErased;
                    readIdents = _856_recIdents;
                  }
                } else {
                  DAST._IType _857___mcc_h479 = _source36.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _858_recursiveGen;
                    bool _859_recOwned;
                    bool _860_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _861_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out401;
                    bool _out402;
                    bool _out403;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out404;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out401, out _out402, out _out403, out _out404);
                    _858_recursiveGen = _out401;
                    _859_recOwned = _out402;
                    _860_recErased = _out403;
                    _861_recIdents = _out404;
                    if (!(_859_recOwned)) {
                      _858_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_858_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _859_recOwned;
                    isErased = _860_recErased;
                    readIdents = _861_recIdents;
                  }
                }
              } else if (_source35.is_Nullable) {
                DAST._IType _862___mcc_h482 = _source35.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _863_recursiveGen;
                  bool _864_recOwned;
                  bool _865_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _866_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out405;
                  bool _out406;
                  bool _out407;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out408;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out405, out _out406, out _out407, out _out408);
                  _863_recursiveGen = _out405;
                  _864_recOwned = _out406;
                  _865_recErased = _out407;
                  _866_recIdents = _out408;
                  if (!(_864_recOwned)) {
                    _863_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_863_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_863_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _864_recOwned;
                  isErased = _865_recErased;
                  readIdents = _866_recIdents;
                }
              } else if (_source35.is_Tuple) {
                Dafny.ISequence<DAST._IType> _867___mcc_h485 = _source35.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _868_recursiveGen;
                  bool _869_recOwned;
                  bool _870_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _871_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out409;
                  bool _out410;
                  bool _out411;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out412;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out409, out _out410, out _out411, out _out412);
                  _868_recursiveGen = _out409;
                  _869_recOwned = _out410;
                  _870_recErased = _out411;
                  _871_recIdents = _out412;
                  if (!(_869_recOwned)) {
                    _868_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_868_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_868_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _869_recOwned;
                  isErased = _870_recErased;
                  readIdents = _871_recIdents;
                }
              } else if (_source35.is_Array) {
                DAST._IType _872___mcc_h488 = _source35.dtor_element;
                BigInteger _873___mcc_h489 = _source35.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _874_recursiveGen;
                  bool _875_recOwned;
                  bool _876_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _877_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out413;
                  bool _out414;
                  bool _out415;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out416;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out413, out _out414, out _out415, out _out416);
                  _874_recursiveGen = _out413;
                  _875_recOwned = _out414;
                  _876_recErased = _out415;
                  _877_recIdents = _out416;
                  if (!(_875_recOwned)) {
                    _874_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_874_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_874_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _875_recOwned;
                  isErased = _876_recErased;
                  readIdents = _877_recIdents;
                }
              } else if (_source35.is_Seq) {
                DAST._IType _878___mcc_h494 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _879_recursiveGen;
                  bool _880_recOwned;
                  bool _881_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _882_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out417;
                  bool _out418;
                  bool _out419;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out420;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out417, out _out418, out _out419, out _out420);
                  _879_recursiveGen = _out417;
                  _880_recOwned = _out418;
                  _881_recErased = _out419;
                  _882_recIdents = _out420;
                  if (!(_880_recOwned)) {
                    _879_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_879_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_879_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _880_recOwned;
                  isErased = _881_recErased;
                  readIdents = _882_recIdents;
                }
              } else if (_source35.is_Set) {
                DAST._IType _883___mcc_h497 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _884_recursiveGen;
                  bool _885_recOwned;
                  bool _886_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _887_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out421;
                  bool _out422;
                  bool _out423;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out424;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out421, out _out422, out _out423, out _out424);
                  _884_recursiveGen = _out421;
                  _885_recOwned = _out422;
                  _886_recErased = _out423;
                  _887_recIdents = _out424;
                  if (!(_885_recOwned)) {
                    _884_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_884_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_884_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _885_recOwned;
                  isErased = _886_recErased;
                  readIdents = _887_recIdents;
                }
              } else if (_source35.is_Multiset) {
                DAST._IType _888___mcc_h500 = _source35.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _889_recursiveGen;
                  bool _890_recOwned;
                  bool _891_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _892_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out425;
                  bool _out426;
                  bool _out427;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out428;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out425, out _out426, out _out427, out _out428);
                  _889_recursiveGen = _out425;
                  _890_recOwned = _out426;
                  _891_recErased = _out427;
                  _892_recIdents = _out428;
                  if (!(_890_recOwned)) {
                    _889_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_889_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_889_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _890_recOwned;
                  isErased = _891_recErased;
                  readIdents = _892_recIdents;
                }
              } else if (_source35.is_Map) {
                DAST._IType _893___mcc_h503 = _source35.dtor_key;
                DAST._IType _894___mcc_h504 = _source35.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _895_recursiveGen;
                  bool _896_recOwned;
                  bool _897_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _898_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out429;
                  bool _out430;
                  bool _out431;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out432;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out429, out _out430, out _out431, out _out432);
                  _895_recursiveGen = _out429;
                  _896_recOwned = _out430;
                  _897_recErased = _out431;
                  _898_recIdents = _out432;
                  if (!(_896_recOwned)) {
                    _895_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_895_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_895_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _896_recOwned;
                  isErased = _897_recErased;
                  readIdents = _898_recIdents;
                }
              } else if (_source35.is_Arrow) {
                Dafny.ISequence<DAST._IType> _899___mcc_h509 = _source35.dtor_args;
                DAST._IType _900___mcc_h510 = _source35.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _901_recursiveGen;
                  bool _902_recOwned;
                  bool _903_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _904_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out433;
                  bool _out434;
                  bool _out435;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out436;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out433, out _out434, out _out435, out _out436);
                  _901_recursiveGen = _out433;
                  _902_recOwned = _out434;
                  _903_recErased = _out435;
                  _904_recIdents = _out436;
                  if (!(_902_recOwned)) {
                    _901_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_901_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_901_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _902_recOwned;
                  isErased = _903_recErased;
                  readIdents = _904_recIdents;
                }
              } else if (_source35.is_Primitive) {
                DAST._IPrimitive _905___mcc_h515 = _source35.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _906_recursiveGen;
                  bool _907_recOwned;
                  bool _908_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _909_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out437;
                  bool _out438;
                  bool _out439;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out440;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out437, out _out438, out _out439, out _out440);
                  _906_recursiveGen = _out437;
                  _907_recOwned = _out438;
                  _908_recErased = _out439;
                  _909_recIdents = _out440;
                  if (!(_907_recOwned)) {
                    _906_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_906_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_906_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _907_recOwned;
                  isErased = _908_recErased;
                  readIdents = _909_recIdents;
                }
              } else if (_source35.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _910___mcc_h518 = _source35.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _911_recursiveGen;
                  bool _912_recOwned;
                  bool _913_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _914_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out441;
                  bool _out442;
                  bool _out443;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out444;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out441, out _out442, out _out443, out _out444);
                  _911_recursiveGen = _out441;
                  _912_recOwned = _out442;
                  _913_recErased = _out443;
                  _914_recIdents = _out444;
                  if (!(_912_recOwned)) {
                    _911_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_911_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_911_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _912_recOwned;
                  isErased = _913_recErased;
                  readIdents = _914_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _915___mcc_h521 = _source35.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _916_recursiveGen;
                  bool _917_recOwned;
                  bool _918_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _919_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out445;
                  bool _out446;
                  bool _out447;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out448;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out445, out _out446, out _out447, out _out448);
                  _916_recursiveGen = _out445;
                  _917_recOwned = _out446;
                  _918_recErased = _out447;
                  _919_recIdents = _out448;
                  if (!(_917_recOwned)) {
                    _916_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_916_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_916_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _917_recOwned;
                  isErased = _918_recErased;
                  readIdents = _919_recIdents;
                }
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _920___mcc_h524 = _source27.dtor_Tuple_a0;
              DAST._IType _source37 = _575___mcc_h293;
              if (_source37.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _921___mcc_h528 = _source37.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _922___mcc_h529 = _source37.dtor_typeArgs;
                DAST._IResolvedType _923___mcc_h530 = _source37.dtor_resolved;
                DAST._IResolvedType _source38 = _923___mcc_h530;
                if (_source38.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _924___mcc_h534 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                    bool _926_recOwned;
                    bool _927_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out449;
                    bool _out450;
                    bool _out451;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out452;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out449, out _out450, out _out451, out _out452);
                    _925_recursiveGen = _out449;
                    _926_recOwned = _out450;
                    _927_recErased = _out451;
                    _928_recIdents = _out452;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _926_recOwned;
                    isErased = _927_recErased;
                    readIdents = _928_recIdents;
                  }
                } else if (_source38.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _929___mcc_h536 = _source38.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                    bool _931_recOwned;
                    bool _932_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out453;
                    bool _out454;
                    bool _out455;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                    _930_recursiveGen = _out453;
                    _931_recOwned = _out454;
                    _932_recErased = _out455;
                    _933_recIdents = _out456;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _931_recOwned;
                    isErased = _932_recErased;
                    readIdents = _933_recIdents;
                  }
                } else {
                  DAST._IType _934___mcc_h538 = _source38.dtor_Newtype_a0;
                  DAST._IType _935_b = _934___mcc_h538;
                  {
                    if (object.Equals(_568_fromTpe, _935_b)) {
                      Dafny.ISequence<Dafny.Rune> _936_recursiveGen;
                      bool _937_recOwned;
                      bool _938_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _939_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out457;
                      bool _out458;
                      bool _out459;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                      _936_recursiveGen = _out457;
                      _937_recOwned = _out458;
                      _938_recErased = _out459;
                      _939_recIdents = _out460;
                      Dafny.ISequence<Dafny.Rune> _940_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out461;
                      _out461 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _940_rhsType = _out461;
                      Dafny.ISequence<Dafny.Rune> _941_uneraseFn;
                      _941_uneraseFn = ((_937_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _940_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _941_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _936_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _937_recOwned;
                      isErased = false;
                      readIdents = _939_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out462;
                      bool _out463;
                      bool _out464;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out465;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _935_b), _935_b, _567_toTpe), selfIdent, @params, mustOwn, out _out462, out _out463, out _out464, out _out465);
                      s = _out462;
                      isOwned = _out463;
                      isErased = _out464;
                      readIdents = _out465;
                    }
                  }
                }
              } else if (_source37.is_Nullable) {
                DAST._IType _942___mcc_h540 = _source37.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _943_recursiveGen;
                  bool _944_recOwned;
                  bool _945_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _946_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out466;
                  bool _out467;
                  bool _out468;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out469;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out466, out _out467, out _out468, out _out469);
                  _943_recursiveGen = _out466;
                  _944_recOwned = _out467;
                  _945_recErased = _out468;
                  _946_recIdents = _out469;
                  if (!(_944_recOwned)) {
                    _943_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_943_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _945_recErased;
                  readIdents = _946_recIdents;
                }
              } else if (_source37.is_Tuple) {
                Dafny.ISequence<DAST._IType> _947___mcc_h542 = _source37.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _948_recursiveGen;
                  bool _949_recOwned;
                  bool _950_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _951_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out470;
                  bool _out471;
                  bool _out472;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out473;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out470, out _out471, out _out472, out _out473);
                  _948_recursiveGen = _out470;
                  _949_recOwned = _out471;
                  _950_recErased = _out472;
                  _951_recIdents = _out473;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _948_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _949_recOwned;
                  isErased = _950_recErased;
                  readIdents = _951_recIdents;
                }
              } else if (_source37.is_Array) {
                DAST._IType _952___mcc_h544 = _source37.dtor_element;
                BigInteger _953___mcc_h545 = _source37.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _954_recursiveGen;
                  bool _955_recOwned;
                  bool _956_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _957_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out474;
                  bool _out475;
                  bool _out476;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out477;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out474, out _out475, out _out476, out _out477);
                  _954_recursiveGen = _out474;
                  _955_recOwned = _out475;
                  _956_recErased = _out476;
                  _957_recIdents = _out477;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _954_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _955_recOwned;
                  isErased = _956_recErased;
                  readIdents = _957_recIdents;
                }
              } else if (_source37.is_Seq) {
                DAST._IType _958___mcc_h548 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _959_recursiveGen;
                  bool _960_recOwned;
                  bool _961_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _962_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out478;
                  bool _out479;
                  bool _out480;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out481;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out478, out _out479, out _out480, out _out481);
                  _959_recursiveGen = _out478;
                  _960_recOwned = _out479;
                  _961_recErased = _out480;
                  _962_recIdents = _out481;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _959_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _960_recOwned;
                  isErased = _961_recErased;
                  readIdents = _962_recIdents;
                }
              } else if (_source37.is_Set) {
                DAST._IType _963___mcc_h550 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _964_recursiveGen;
                  bool _965_recOwned;
                  bool _966_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _967_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out482;
                  bool _out483;
                  bool _out484;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out485;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out482, out _out483, out _out484, out _out485);
                  _964_recursiveGen = _out482;
                  _965_recOwned = _out483;
                  _966_recErased = _out484;
                  _967_recIdents = _out485;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _964_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _965_recOwned;
                  isErased = _966_recErased;
                  readIdents = _967_recIdents;
                }
              } else if (_source37.is_Multiset) {
                DAST._IType _968___mcc_h552 = _source37.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _969_recursiveGen;
                  bool _970_recOwned;
                  bool _971_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _972_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out486;
                  bool _out487;
                  bool _out488;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out489;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out486, out _out487, out _out488, out _out489);
                  _969_recursiveGen = _out486;
                  _970_recOwned = _out487;
                  _971_recErased = _out488;
                  _972_recIdents = _out489;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _969_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _970_recOwned;
                  isErased = _971_recErased;
                  readIdents = _972_recIdents;
                }
              } else if (_source37.is_Map) {
                DAST._IType _973___mcc_h554 = _source37.dtor_key;
                DAST._IType _974___mcc_h555 = _source37.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _975_recursiveGen;
                  bool _976_recOwned;
                  bool _977_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _978_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out490;
                  bool _out491;
                  bool _out492;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out493;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out490, out _out491, out _out492, out _out493);
                  _975_recursiveGen = _out490;
                  _976_recOwned = _out491;
                  _977_recErased = _out492;
                  _978_recIdents = _out493;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _975_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _976_recOwned;
                  isErased = _977_recErased;
                  readIdents = _978_recIdents;
                }
              } else if (_source37.is_Arrow) {
                Dafny.ISequence<DAST._IType> _979___mcc_h558 = _source37.dtor_args;
                DAST._IType _980___mcc_h559 = _source37.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _981_recursiveGen;
                  bool _982_recOwned;
                  bool _983_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _984_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out494;
                  bool _out495;
                  bool _out496;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out497;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out494, out _out495, out _out496, out _out497);
                  _981_recursiveGen = _out494;
                  _982_recOwned = _out495;
                  _983_recErased = _out496;
                  _984_recIdents = _out497;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _981_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _982_recOwned;
                  isErased = _983_recErased;
                  readIdents = _984_recIdents;
                }
              } else if (_source37.is_Primitive) {
                DAST._IPrimitive _985___mcc_h562 = _source37.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _986_recursiveGen;
                  bool _987_recOwned;
                  bool _988_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _989_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out498;
                  bool _out499;
                  bool _out500;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out501;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out498, out _out499, out _out500, out _out501);
                  _986_recursiveGen = _out498;
                  _987_recOwned = _out499;
                  _988_recErased = _out500;
                  _989_recIdents = _out501;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _986_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _987_recOwned;
                  isErased = _988_recErased;
                  readIdents = _989_recIdents;
                }
              } else if (_source37.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _990___mcc_h564 = _source37.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _991_recursiveGen;
                  bool _992_recOwned;
                  bool _993_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _994_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out502;
                  bool _out503;
                  bool _out504;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out505;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out502, out _out503, out _out504, out _out505);
                  _991_recursiveGen = _out502;
                  _992_recOwned = _out503;
                  _993_recErased = _out504;
                  _994_recIdents = _out505;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _992_recOwned;
                  isErased = _993_recErased;
                  readIdents = _994_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _995___mcc_h566 = _source37.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _996_recursiveGen;
                  bool _997_recOwned;
                  bool _998_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _999_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out506;
                  bool _out507;
                  bool _out508;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out509;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out506, out _out507, out _out508, out _out509);
                  _996_recursiveGen = _out506;
                  _997_recOwned = _out507;
                  _998_recErased = _out508;
                  _999_recIdents = _out509;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _996_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _997_recOwned;
                  isErased = _998_recErased;
                  readIdents = _999_recIdents;
                }
              }
            } else if (_source27.is_Array) {
              DAST._IType _1000___mcc_h568 = _source27.dtor_element;
              BigInteger _1001___mcc_h569 = _source27.dtor_dims;
              DAST._IType _source39 = _575___mcc_h293;
              if (_source39.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1002___mcc_h576 = _source39.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1003___mcc_h577 = _source39.dtor_typeArgs;
                DAST._IResolvedType _1004___mcc_h578 = _source39.dtor_resolved;
                DAST._IResolvedType _source40 = _1004___mcc_h578;
                if (_source40.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1005___mcc_h582 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1006_recursiveGen;
                    bool _1007_recOwned;
                    bool _1008_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1009_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out510;
                    bool _out511;
                    bool _out512;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out513;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out510, out _out511, out _out512, out _out513);
                    _1006_recursiveGen = _out510;
                    _1007_recOwned = _out511;
                    _1008_recErased = _out512;
                    _1009_recIdents = _out513;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1006_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1007_recOwned;
                    isErased = _1008_recErased;
                    readIdents = _1009_recIdents;
                  }
                } else if (_source40.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1010___mcc_h584 = _source40.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1011_recursiveGen;
                    bool _1012_recOwned;
                    bool _1013_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1014_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out514;
                    bool _out515;
                    bool _out516;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                    _1011_recursiveGen = _out514;
                    _1012_recOwned = _out515;
                    _1013_recErased = _out516;
                    _1014_recIdents = _out517;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1011_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1012_recOwned;
                    isErased = _1013_recErased;
                    readIdents = _1014_recIdents;
                  }
                } else {
                  DAST._IType _1015___mcc_h586 = _source40.dtor_Newtype_a0;
                  DAST._IType _1016_b = _1015___mcc_h586;
                  {
                    if (object.Equals(_568_fromTpe, _1016_b)) {
                      Dafny.ISequence<Dafny.Rune> _1017_recursiveGen;
                      bool _1018_recOwned;
                      bool _1019_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1020_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out518;
                      bool _out519;
                      bool _out520;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                      _1017_recursiveGen = _out518;
                      _1018_recOwned = _out519;
                      _1019_recErased = _out520;
                      _1020_recIdents = _out521;
                      Dafny.ISequence<Dafny.Rune> _1021_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out522;
                      _out522 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1021_rhsType = _out522;
                      Dafny.ISequence<Dafny.Rune> _1022_uneraseFn;
                      _1022_uneraseFn = ((_1018_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1021_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1022_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1017_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1018_recOwned;
                      isErased = false;
                      readIdents = _1020_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out523;
                      bool _out524;
                      bool _out525;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out526;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1016_b), _1016_b, _567_toTpe), selfIdent, @params, mustOwn, out _out523, out _out524, out _out525, out _out526);
                      s = _out523;
                      isOwned = _out524;
                      isErased = _out525;
                      readIdents = _out526;
                    }
                  }
                }
              } else if (_source39.is_Nullable) {
                DAST._IType _1023___mcc_h588 = _source39.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1024_recursiveGen;
                  bool _1025_recOwned;
                  bool _1026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out527;
                  bool _out528;
                  bool _out529;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out530;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out527, out _out528, out _out529, out _out530);
                  _1024_recursiveGen = _out527;
                  _1025_recOwned = _out528;
                  _1026_recErased = _out529;
                  _1027_recIdents = _out530;
                  if (!(_1025_recOwned)) {
                    _1024_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1024_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1026_recErased;
                  readIdents = _1027_recIdents;
                }
              } else if (_source39.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1028___mcc_h590 = _source39.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1029_recursiveGen;
                  bool _1030_recOwned;
                  bool _1031_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1032_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out531;
                  bool _out532;
                  bool _out533;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out534;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out531, out _out532, out _out533, out _out534);
                  _1029_recursiveGen = _out531;
                  _1030_recOwned = _out532;
                  _1031_recErased = _out533;
                  _1032_recIdents = _out534;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1029_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1030_recOwned;
                  isErased = _1031_recErased;
                  readIdents = _1032_recIdents;
                }
              } else if (_source39.is_Array) {
                DAST._IType _1033___mcc_h592 = _source39.dtor_element;
                BigInteger _1034___mcc_h593 = _source39.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1035_recursiveGen;
                  bool _1036_recOwned;
                  bool _1037_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1038_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out535;
                  bool _out536;
                  bool _out537;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out538;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out535, out _out536, out _out537, out _out538);
                  _1035_recursiveGen = _out535;
                  _1036_recOwned = _out536;
                  _1037_recErased = _out537;
                  _1038_recIdents = _out538;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1036_recOwned;
                  isErased = _1037_recErased;
                  readIdents = _1038_recIdents;
                }
              } else if (_source39.is_Seq) {
                DAST._IType _1039___mcc_h596 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1040_recursiveGen;
                  bool _1041_recOwned;
                  bool _1042_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1043_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out539;
                  bool _out540;
                  bool _out541;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out542;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out539, out _out540, out _out541, out _out542);
                  _1040_recursiveGen = _out539;
                  _1041_recOwned = _out540;
                  _1042_recErased = _out541;
                  _1043_recIdents = _out542;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1041_recOwned;
                  isErased = _1042_recErased;
                  readIdents = _1043_recIdents;
                }
              } else if (_source39.is_Set) {
                DAST._IType _1044___mcc_h598 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1045_recursiveGen;
                  bool _1046_recOwned;
                  bool _1047_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1048_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out543;
                  bool _out544;
                  bool _out545;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out546;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out543, out _out544, out _out545, out _out546);
                  _1045_recursiveGen = _out543;
                  _1046_recOwned = _out544;
                  _1047_recErased = _out545;
                  _1048_recIdents = _out546;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1045_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1046_recOwned;
                  isErased = _1047_recErased;
                  readIdents = _1048_recIdents;
                }
              } else if (_source39.is_Multiset) {
                DAST._IType _1049___mcc_h600 = _source39.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1050_recursiveGen;
                  bool _1051_recOwned;
                  bool _1052_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1053_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out547;
                  bool _out548;
                  bool _out549;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out550;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out547, out _out548, out _out549, out _out550);
                  _1050_recursiveGen = _out547;
                  _1051_recOwned = _out548;
                  _1052_recErased = _out549;
                  _1053_recIdents = _out550;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1050_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1051_recOwned;
                  isErased = _1052_recErased;
                  readIdents = _1053_recIdents;
                }
              } else if (_source39.is_Map) {
                DAST._IType _1054___mcc_h602 = _source39.dtor_key;
                DAST._IType _1055___mcc_h603 = _source39.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1056_recursiveGen;
                  bool _1057_recOwned;
                  bool _1058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out551;
                  bool _out552;
                  bool _out553;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out554;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out551, out _out552, out _out553, out _out554);
                  _1056_recursiveGen = _out551;
                  _1057_recOwned = _out552;
                  _1058_recErased = _out553;
                  _1059_recIdents = _out554;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1057_recOwned;
                  isErased = _1058_recErased;
                  readIdents = _1059_recIdents;
                }
              } else if (_source39.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1060___mcc_h606 = _source39.dtor_args;
                DAST._IType _1061___mcc_h607 = _source39.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1062_recursiveGen;
                  bool _1063_recOwned;
                  bool _1064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out555;
                  bool _out556;
                  bool _out557;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out558;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out555, out _out556, out _out557, out _out558);
                  _1062_recursiveGen = _out555;
                  _1063_recOwned = _out556;
                  _1064_recErased = _out557;
                  _1065_recIdents = _out558;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1063_recOwned;
                  isErased = _1064_recErased;
                  readIdents = _1065_recIdents;
                }
              } else if (_source39.is_Primitive) {
                DAST._IPrimitive _1066___mcc_h610 = _source39.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1067_recursiveGen;
                  bool _1068_recOwned;
                  bool _1069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out559;
                  bool _out560;
                  bool _out561;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out562;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out559, out _out560, out _out561, out _out562);
                  _1067_recursiveGen = _out559;
                  _1068_recOwned = _out560;
                  _1069_recErased = _out561;
                  _1070_recIdents = _out562;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1068_recOwned;
                  isErased = _1069_recErased;
                  readIdents = _1070_recIdents;
                }
              } else if (_source39.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1071___mcc_h612 = _source39.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1072_recursiveGen;
                  bool _1073_recOwned;
                  bool _1074_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1075_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out563;
                  bool _out564;
                  bool _out565;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out566;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out563, out _out564, out _out565, out _out566);
                  _1072_recursiveGen = _out563;
                  _1073_recOwned = _out564;
                  _1074_recErased = _out565;
                  _1075_recIdents = _out566;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1073_recOwned;
                  isErased = _1074_recErased;
                  readIdents = _1075_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1076___mcc_h614 = _source39.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1077_recursiveGen;
                  bool _1078_recOwned;
                  bool _1079_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1080_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out567;
                  bool _out568;
                  bool _out569;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out570;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out567, out _out568, out _out569, out _out570);
                  _1077_recursiveGen = _out567;
                  _1078_recOwned = _out568;
                  _1079_recErased = _out569;
                  _1080_recIdents = _out570;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1077_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1078_recOwned;
                  isErased = _1079_recErased;
                  readIdents = _1080_recIdents;
                }
              }
            } else if (_source27.is_Seq) {
              DAST._IType _1081___mcc_h616 = _source27.dtor_element;
              DAST._IType _source41 = _575___mcc_h293;
              if (_source41.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1082___mcc_h620 = _source41.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1083___mcc_h621 = _source41.dtor_typeArgs;
                DAST._IResolvedType _1084___mcc_h622 = _source41.dtor_resolved;
                DAST._IResolvedType _source42 = _1084___mcc_h622;
                if (_source42.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1085___mcc_h626 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1086_recursiveGen;
                    bool _1087_recOwned;
                    bool _1088_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1089_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out571;
                    bool _out572;
                    bool _out573;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out574;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out571, out _out572, out _out573, out _out574);
                    _1086_recursiveGen = _out571;
                    _1087_recOwned = _out572;
                    _1088_recErased = _out573;
                    _1089_recIdents = _out574;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1086_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1087_recOwned;
                    isErased = _1088_recErased;
                    readIdents = _1089_recIdents;
                  }
                } else if (_source42.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1090___mcc_h628 = _source42.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1091_recursiveGen;
                    bool _1092_recOwned;
                    bool _1093_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1094_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out575;
                    bool _out576;
                    bool _out577;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                    _1091_recursiveGen = _out575;
                    _1092_recOwned = _out576;
                    _1093_recErased = _out577;
                    _1094_recIdents = _out578;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1091_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1092_recOwned;
                    isErased = _1093_recErased;
                    readIdents = _1094_recIdents;
                  }
                } else {
                  DAST._IType _1095___mcc_h630 = _source42.dtor_Newtype_a0;
                  DAST._IType _1096_b = _1095___mcc_h630;
                  {
                    if (object.Equals(_568_fromTpe, _1096_b)) {
                      Dafny.ISequence<Dafny.Rune> _1097_recursiveGen;
                      bool _1098_recOwned;
                      bool _1099_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1100_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out579;
                      bool _out580;
                      bool _out581;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                      _1097_recursiveGen = _out579;
                      _1098_recOwned = _out580;
                      _1099_recErased = _out581;
                      _1100_recIdents = _out582;
                      Dafny.ISequence<Dafny.Rune> _1101_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out583;
                      _out583 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1101_rhsType = _out583;
                      Dafny.ISequence<Dafny.Rune> _1102_uneraseFn;
                      _1102_uneraseFn = ((_1098_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1101_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1102_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1097_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1098_recOwned;
                      isErased = false;
                      readIdents = _1100_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out584;
                      bool _out585;
                      bool _out586;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out587;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1096_b), _1096_b, _567_toTpe), selfIdent, @params, mustOwn, out _out584, out _out585, out _out586, out _out587);
                      s = _out584;
                      isOwned = _out585;
                      isErased = _out586;
                      readIdents = _out587;
                    }
                  }
                }
              } else if (_source41.is_Nullable) {
                DAST._IType _1103___mcc_h632 = _source41.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1104_recursiveGen;
                  bool _1105_recOwned;
                  bool _1106_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1107_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out588;
                  bool _out589;
                  bool _out590;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out591;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out588, out _out589, out _out590, out _out591);
                  _1104_recursiveGen = _out588;
                  _1105_recOwned = _out589;
                  _1106_recErased = _out590;
                  _1107_recIdents = _out591;
                  if (!(_1105_recOwned)) {
                    _1104_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1104_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1104_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1106_recErased;
                  readIdents = _1107_recIdents;
                }
              } else if (_source41.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1108___mcc_h634 = _source41.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1109_recursiveGen;
                  bool _1110_recOwned;
                  bool _1111_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1112_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out592;
                  bool _out593;
                  bool _out594;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out595;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out592, out _out593, out _out594, out _out595);
                  _1109_recursiveGen = _out592;
                  _1110_recOwned = _out593;
                  _1111_recErased = _out594;
                  _1112_recIdents = _out595;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1109_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1110_recOwned;
                  isErased = _1111_recErased;
                  readIdents = _1112_recIdents;
                }
              } else if (_source41.is_Array) {
                DAST._IType _1113___mcc_h636 = _source41.dtor_element;
                BigInteger _1114___mcc_h637 = _source41.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1115_recursiveGen;
                  bool _1116_recOwned;
                  bool _1117_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1118_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out596;
                  bool _out597;
                  bool _out598;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out599;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out596, out _out597, out _out598, out _out599);
                  _1115_recursiveGen = _out596;
                  _1116_recOwned = _out597;
                  _1117_recErased = _out598;
                  _1118_recIdents = _out599;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1115_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1116_recOwned;
                  isErased = _1117_recErased;
                  readIdents = _1118_recIdents;
                }
              } else if (_source41.is_Seq) {
                DAST._IType _1119___mcc_h640 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1120_recursiveGen;
                  bool _1121_recOwned;
                  bool _1122_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1123_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out600;
                  bool _out601;
                  bool _out602;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out603;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out600, out _out601, out _out602, out _out603);
                  _1120_recursiveGen = _out600;
                  _1121_recOwned = _out601;
                  _1122_recErased = _out602;
                  _1123_recIdents = _out603;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1120_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1121_recOwned;
                  isErased = _1122_recErased;
                  readIdents = _1123_recIdents;
                }
              } else if (_source41.is_Set) {
                DAST._IType _1124___mcc_h642 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1125_recursiveGen;
                  bool _1126_recOwned;
                  bool _1127_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1128_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out604;
                  bool _out605;
                  bool _out606;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out607;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out604, out _out605, out _out606, out _out607);
                  _1125_recursiveGen = _out604;
                  _1126_recOwned = _out605;
                  _1127_recErased = _out606;
                  _1128_recIdents = _out607;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1125_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1126_recOwned;
                  isErased = _1127_recErased;
                  readIdents = _1128_recIdents;
                }
              } else if (_source41.is_Multiset) {
                DAST._IType _1129___mcc_h644 = _source41.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1130_recursiveGen;
                  bool _1131_recOwned;
                  bool _1132_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1133_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out608;
                  bool _out609;
                  bool _out610;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out611;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out608, out _out609, out _out610, out _out611);
                  _1130_recursiveGen = _out608;
                  _1131_recOwned = _out609;
                  _1132_recErased = _out610;
                  _1133_recIdents = _out611;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1130_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1131_recOwned;
                  isErased = _1132_recErased;
                  readIdents = _1133_recIdents;
                }
              } else if (_source41.is_Map) {
                DAST._IType _1134___mcc_h646 = _source41.dtor_key;
                DAST._IType _1135___mcc_h647 = _source41.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1136_recursiveGen;
                  bool _1137_recOwned;
                  bool _1138_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1139_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out612;
                  bool _out613;
                  bool _out614;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out615;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out612, out _out613, out _out614, out _out615);
                  _1136_recursiveGen = _out612;
                  _1137_recOwned = _out613;
                  _1138_recErased = _out614;
                  _1139_recIdents = _out615;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1136_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1137_recOwned;
                  isErased = _1138_recErased;
                  readIdents = _1139_recIdents;
                }
              } else if (_source41.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1140___mcc_h650 = _source41.dtor_args;
                DAST._IType _1141___mcc_h651 = _source41.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1142_recursiveGen;
                  bool _1143_recOwned;
                  bool _1144_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1145_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out616;
                  bool _out617;
                  bool _out618;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out619;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out616, out _out617, out _out618, out _out619);
                  _1142_recursiveGen = _out616;
                  _1143_recOwned = _out617;
                  _1144_recErased = _out618;
                  _1145_recIdents = _out619;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1143_recOwned;
                  isErased = _1144_recErased;
                  readIdents = _1145_recIdents;
                }
              } else if (_source41.is_Primitive) {
                DAST._IPrimitive _1146___mcc_h654 = _source41.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1147_recursiveGen;
                  bool _1148_recOwned;
                  bool _1149_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1150_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out620;
                  bool _out621;
                  bool _out622;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out623;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out620, out _out621, out _out622, out _out623);
                  _1147_recursiveGen = _out620;
                  _1148_recOwned = _out621;
                  _1149_recErased = _out622;
                  _1150_recIdents = _out623;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1148_recOwned;
                  isErased = _1149_recErased;
                  readIdents = _1150_recIdents;
                }
              } else if (_source41.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1151___mcc_h656 = _source41.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1152_recursiveGen;
                  bool _1153_recOwned;
                  bool _1154_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1155_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out624;
                  bool _out625;
                  bool _out626;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out627;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out624, out _out625, out _out626, out _out627);
                  _1152_recursiveGen = _out624;
                  _1153_recOwned = _out625;
                  _1154_recErased = _out626;
                  _1155_recIdents = _out627;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1152_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1153_recOwned;
                  isErased = _1154_recErased;
                  readIdents = _1155_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1156___mcc_h658 = _source41.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1157_recursiveGen;
                  bool _1158_recOwned;
                  bool _1159_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1160_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out628;
                  bool _out629;
                  bool _out630;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out631;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out628, out _out629, out _out630, out _out631);
                  _1157_recursiveGen = _out628;
                  _1158_recOwned = _out629;
                  _1159_recErased = _out630;
                  _1160_recIdents = _out631;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1157_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1158_recOwned;
                  isErased = _1159_recErased;
                  readIdents = _1160_recIdents;
                }
              }
            } else if (_source27.is_Set) {
              DAST._IType _1161___mcc_h660 = _source27.dtor_element;
              DAST._IType _source43 = _575___mcc_h293;
              if (_source43.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1162___mcc_h664 = _source43.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1163___mcc_h665 = _source43.dtor_typeArgs;
                DAST._IResolvedType _1164___mcc_h666 = _source43.dtor_resolved;
                DAST._IResolvedType _source44 = _1164___mcc_h666;
                if (_source44.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1165___mcc_h670 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1166_recursiveGen;
                    bool _1167_recOwned;
                    bool _1168_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1169_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out632;
                    bool _out633;
                    bool _out634;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out635;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out632, out _out633, out _out634, out _out635);
                    _1166_recursiveGen = _out632;
                    _1167_recOwned = _out633;
                    _1168_recErased = _out634;
                    _1169_recIdents = _out635;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1166_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1167_recOwned;
                    isErased = _1168_recErased;
                    readIdents = _1169_recIdents;
                  }
                } else if (_source44.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1170___mcc_h672 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1171_recursiveGen;
                    bool _1172_recOwned;
                    bool _1173_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1174_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out636;
                    bool _out637;
                    bool _out638;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                    _1171_recursiveGen = _out636;
                    _1172_recOwned = _out637;
                    _1173_recErased = _out638;
                    _1174_recIdents = _out639;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1171_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1172_recOwned;
                    isErased = _1173_recErased;
                    readIdents = _1174_recIdents;
                  }
                } else {
                  DAST._IType _1175___mcc_h674 = _source44.dtor_Newtype_a0;
                  DAST._IType _1176_b = _1175___mcc_h674;
                  {
                    if (object.Equals(_568_fromTpe, _1176_b)) {
                      Dafny.ISequence<Dafny.Rune> _1177_recursiveGen;
                      bool _1178_recOwned;
                      bool _1179_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1180_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out640;
                      bool _out641;
                      bool _out642;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                      _1177_recursiveGen = _out640;
                      _1178_recOwned = _out641;
                      _1179_recErased = _out642;
                      _1180_recIdents = _out643;
                      Dafny.ISequence<Dafny.Rune> _1181_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out644;
                      _out644 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1181_rhsType = _out644;
                      Dafny.ISequence<Dafny.Rune> _1182_uneraseFn;
                      _1182_uneraseFn = ((_1178_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1181_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1182_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1177_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1178_recOwned;
                      isErased = false;
                      readIdents = _1180_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out645;
                      bool _out646;
                      bool _out647;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out648;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1176_b), _1176_b, _567_toTpe), selfIdent, @params, mustOwn, out _out645, out _out646, out _out647, out _out648);
                      s = _out645;
                      isOwned = _out646;
                      isErased = _out647;
                      readIdents = _out648;
                    }
                  }
                }
              } else if (_source43.is_Nullable) {
                DAST._IType _1183___mcc_h676 = _source43.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1184_recursiveGen;
                  bool _1185_recOwned;
                  bool _1186_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1187_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out649;
                  bool _out650;
                  bool _out651;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out652;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out649, out _out650, out _out651, out _out652);
                  _1184_recursiveGen = _out649;
                  _1185_recOwned = _out650;
                  _1186_recErased = _out651;
                  _1187_recIdents = _out652;
                  if (!(_1185_recOwned)) {
                    _1184_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1184_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1184_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1186_recErased;
                  readIdents = _1187_recIdents;
                }
              } else if (_source43.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1188___mcc_h678 = _source43.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                  bool _1190_recOwned;
                  bool _1191_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out653;
                  bool _out654;
                  bool _out655;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out656;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out653, out _out654, out _out655, out _out656);
                  _1189_recursiveGen = _out653;
                  _1190_recOwned = _out654;
                  _1191_recErased = _out655;
                  _1192_recIdents = _out656;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1190_recOwned;
                  isErased = _1191_recErased;
                  readIdents = _1192_recIdents;
                }
              } else if (_source43.is_Array) {
                DAST._IType _1193___mcc_h680 = _source43.dtor_element;
                BigInteger _1194___mcc_h681 = _source43.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1195_recursiveGen;
                  bool _1196_recOwned;
                  bool _1197_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1198_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out657;
                  bool _out658;
                  bool _out659;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out660;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out657, out _out658, out _out659, out _out660);
                  _1195_recursiveGen = _out657;
                  _1196_recOwned = _out658;
                  _1197_recErased = _out659;
                  _1198_recIdents = _out660;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1195_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1196_recOwned;
                  isErased = _1197_recErased;
                  readIdents = _1198_recIdents;
                }
              } else if (_source43.is_Seq) {
                DAST._IType _1199___mcc_h684 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1200_recursiveGen;
                  bool _1201_recOwned;
                  bool _1202_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1203_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out661;
                  bool _out662;
                  bool _out663;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out664;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out661, out _out662, out _out663, out _out664);
                  _1200_recursiveGen = _out661;
                  _1201_recOwned = _out662;
                  _1202_recErased = _out663;
                  _1203_recIdents = _out664;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1200_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1201_recOwned;
                  isErased = _1202_recErased;
                  readIdents = _1203_recIdents;
                }
              } else if (_source43.is_Set) {
                DAST._IType _1204___mcc_h686 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                  bool _1206_recOwned;
                  bool _1207_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out665;
                  bool _out666;
                  bool _out667;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out668;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out665, out _out666, out _out667, out _out668);
                  _1205_recursiveGen = _out665;
                  _1206_recOwned = _out666;
                  _1207_recErased = _out667;
                  _1208_recIdents = _out668;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1206_recOwned;
                  isErased = _1207_recErased;
                  readIdents = _1208_recIdents;
                }
              } else if (_source43.is_Multiset) {
                DAST._IType _1209___mcc_h688 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1210_recursiveGen;
                  bool _1211_recOwned;
                  bool _1212_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1213_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out669;
                  bool _out670;
                  bool _out671;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out672;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out669, out _out670, out _out671, out _out672);
                  _1210_recursiveGen = _out669;
                  _1211_recOwned = _out670;
                  _1212_recErased = _out671;
                  _1213_recIdents = _out672;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1210_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1211_recOwned;
                  isErased = _1212_recErased;
                  readIdents = _1213_recIdents;
                }
              } else if (_source43.is_Map) {
                DAST._IType _1214___mcc_h690 = _source43.dtor_key;
                DAST._IType _1215___mcc_h691 = _source43.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1216_recursiveGen;
                  bool _1217_recOwned;
                  bool _1218_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1219_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out673;
                  bool _out674;
                  bool _out675;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out676;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out673, out _out674, out _out675, out _out676);
                  _1216_recursiveGen = _out673;
                  _1217_recOwned = _out674;
                  _1218_recErased = _out675;
                  _1219_recIdents = _out676;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1216_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1217_recOwned;
                  isErased = _1218_recErased;
                  readIdents = _1219_recIdents;
                }
              } else if (_source43.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1220___mcc_h694 = _source43.dtor_args;
                DAST._IType _1221___mcc_h695 = _source43.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1222_recursiveGen;
                  bool _1223_recOwned;
                  bool _1224_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1225_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out677;
                  bool _out678;
                  bool _out679;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out680;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out677, out _out678, out _out679, out _out680);
                  _1222_recursiveGen = _out677;
                  _1223_recOwned = _out678;
                  _1224_recErased = _out679;
                  _1225_recIdents = _out680;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1222_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1223_recOwned;
                  isErased = _1224_recErased;
                  readIdents = _1225_recIdents;
                }
              } else if (_source43.is_Primitive) {
                DAST._IPrimitive _1226___mcc_h698 = _source43.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1227_recursiveGen;
                  bool _1228_recOwned;
                  bool _1229_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1230_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out681;
                  bool _out682;
                  bool _out683;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out684;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out681, out _out682, out _out683, out _out684);
                  _1227_recursiveGen = _out681;
                  _1228_recOwned = _out682;
                  _1229_recErased = _out683;
                  _1230_recIdents = _out684;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1227_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1228_recOwned;
                  isErased = _1229_recErased;
                  readIdents = _1230_recIdents;
                }
              } else if (_source43.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1231___mcc_h700 = _source43.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1232_recursiveGen;
                  bool _1233_recOwned;
                  bool _1234_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1235_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out685;
                  bool _out686;
                  bool _out687;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out688;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out685, out _out686, out _out687, out _out688);
                  _1232_recursiveGen = _out685;
                  _1233_recOwned = _out686;
                  _1234_recErased = _out687;
                  _1235_recIdents = _out688;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1232_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1233_recOwned;
                  isErased = _1234_recErased;
                  readIdents = _1235_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1236___mcc_h702 = _source43.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1237_recursiveGen;
                  bool _1238_recOwned;
                  bool _1239_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1240_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out689;
                  bool _out690;
                  bool _out691;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out692;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out689, out _out690, out _out691, out _out692);
                  _1237_recursiveGen = _out689;
                  _1238_recOwned = _out690;
                  _1239_recErased = _out691;
                  _1240_recIdents = _out692;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1237_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1238_recOwned;
                  isErased = _1239_recErased;
                  readIdents = _1240_recIdents;
                }
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _1241___mcc_h704 = _source27.dtor_element;
              DAST._IType _source45 = _575___mcc_h293;
              if (_source45.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1242___mcc_h708 = _source45.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1243___mcc_h709 = _source45.dtor_typeArgs;
                DAST._IResolvedType _1244___mcc_h710 = _source45.dtor_resolved;
                DAST._IResolvedType _source46 = _1244___mcc_h710;
                if (_source46.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1245___mcc_h714 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1246_recursiveGen;
                    bool _1247_recOwned;
                    bool _1248_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1249_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out693;
                    bool _out694;
                    bool _out695;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out696;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out693, out _out694, out _out695, out _out696);
                    _1246_recursiveGen = _out693;
                    _1247_recOwned = _out694;
                    _1248_recErased = _out695;
                    _1249_recIdents = _out696;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1246_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1247_recOwned;
                    isErased = _1248_recErased;
                    readIdents = _1249_recIdents;
                  }
                } else if (_source46.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1250___mcc_h716 = _source46.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1251_recursiveGen;
                    bool _1252_recOwned;
                    bool _1253_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1254_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out697;
                    bool _out698;
                    bool _out699;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                    _1251_recursiveGen = _out697;
                    _1252_recOwned = _out698;
                    _1253_recErased = _out699;
                    _1254_recIdents = _out700;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1251_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1252_recOwned;
                    isErased = _1253_recErased;
                    readIdents = _1254_recIdents;
                  }
                } else {
                  DAST._IType _1255___mcc_h718 = _source46.dtor_Newtype_a0;
                  DAST._IType _1256_b = _1255___mcc_h718;
                  {
                    if (object.Equals(_568_fromTpe, _1256_b)) {
                      Dafny.ISequence<Dafny.Rune> _1257_recursiveGen;
                      bool _1258_recOwned;
                      bool _1259_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1260_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out701;
                      bool _out702;
                      bool _out703;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                      _1257_recursiveGen = _out701;
                      _1258_recOwned = _out702;
                      _1259_recErased = _out703;
                      _1260_recIdents = _out704;
                      Dafny.ISequence<Dafny.Rune> _1261_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out705;
                      _out705 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1261_rhsType = _out705;
                      Dafny.ISequence<Dafny.Rune> _1262_uneraseFn;
                      _1262_uneraseFn = ((_1258_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1261_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1262_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1257_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1258_recOwned;
                      isErased = false;
                      readIdents = _1260_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out706;
                      bool _out707;
                      bool _out708;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out709;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1256_b), _1256_b, _567_toTpe), selfIdent, @params, mustOwn, out _out706, out _out707, out _out708, out _out709);
                      s = _out706;
                      isOwned = _out707;
                      isErased = _out708;
                      readIdents = _out709;
                    }
                  }
                }
              } else if (_source45.is_Nullable) {
                DAST._IType _1263___mcc_h720 = _source45.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1264_recursiveGen;
                  bool _1265_recOwned;
                  bool _1266_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1267_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out710;
                  bool _out711;
                  bool _out712;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out713;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out710, out _out711, out _out712, out _out713);
                  _1264_recursiveGen = _out710;
                  _1265_recOwned = _out711;
                  _1266_recErased = _out712;
                  _1267_recIdents = _out713;
                  if (!(_1265_recOwned)) {
                    _1264_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1264_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1264_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1266_recErased;
                  readIdents = _1267_recIdents;
                }
              } else if (_source45.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1268___mcc_h722 = _source45.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1269_recursiveGen;
                  bool _1270_recOwned;
                  bool _1271_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1272_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out714;
                  bool _out715;
                  bool _out716;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out717;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out714, out _out715, out _out716, out _out717);
                  _1269_recursiveGen = _out714;
                  _1270_recOwned = _out715;
                  _1271_recErased = _out716;
                  _1272_recIdents = _out717;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1269_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1270_recOwned;
                  isErased = _1271_recErased;
                  readIdents = _1272_recIdents;
                }
              } else if (_source45.is_Array) {
                DAST._IType _1273___mcc_h724 = _source45.dtor_element;
                BigInteger _1274___mcc_h725 = _source45.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1275_recursiveGen;
                  bool _1276_recOwned;
                  bool _1277_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1278_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out718;
                  bool _out719;
                  bool _out720;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out721;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out718, out _out719, out _out720, out _out721);
                  _1275_recursiveGen = _out718;
                  _1276_recOwned = _out719;
                  _1277_recErased = _out720;
                  _1278_recIdents = _out721;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1275_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1276_recOwned;
                  isErased = _1277_recErased;
                  readIdents = _1278_recIdents;
                }
              } else if (_source45.is_Seq) {
                DAST._IType _1279___mcc_h728 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1280_recursiveGen;
                  bool _1281_recOwned;
                  bool _1282_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1283_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out722;
                  bool _out723;
                  bool _out724;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out725;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out722, out _out723, out _out724, out _out725);
                  _1280_recursiveGen = _out722;
                  _1281_recOwned = _out723;
                  _1282_recErased = _out724;
                  _1283_recIdents = _out725;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1280_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1281_recOwned;
                  isErased = _1282_recErased;
                  readIdents = _1283_recIdents;
                }
              } else if (_source45.is_Set) {
                DAST._IType _1284___mcc_h730 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1285_recursiveGen;
                  bool _1286_recOwned;
                  bool _1287_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1288_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out726;
                  bool _out727;
                  bool _out728;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out729;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out726, out _out727, out _out728, out _out729);
                  _1285_recursiveGen = _out726;
                  _1286_recOwned = _out727;
                  _1287_recErased = _out728;
                  _1288_recIdents = _out729;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1285_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1286_recOwned;
                  isErased = _1287_recErased;
                  readIdents = _1288_recIdents;
                }
              } else if (_source45.is_Multiset) {
                DAST._IType _1289___mcc_h732 = _source45.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1290_recursiveGen;
                  bool _1291_recOwned;
                  bool _1292_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1293_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out730;
                  bool _out731;
                  bool _out732;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out733;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out730, out _out731, out _out732, out _out733);
                  _1290_recursiveGen = _out730;
                  _1291_recOwned = _out731;
                  _1292_recErased = _out732;
                  _1293_recIdents = _out733;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1290_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1291_recOwned;
                  isErased = _1292_recErased;
                  readIdents = _1293_recIdents;
                }
              } else if (_source45.is_Map) {
                DAST._IType _1294___mcc_h734 = _source45.dtor_key;
                DAST._IType _1295___mcc_h735 = _source45.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1296_recursiveGen;
                  bool _1297_recOwned;
                  bool _1298_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1299_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out734;
                  bool _out735;
                  bool _out736;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out737;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out734, out _out735, out _out736, out _out737);
                  _1296_recursiveGen = _out734;
                  _1297_recOwned = _out735;
                  _1298_recErased = _out736;
                  _1299_recIdents = _out737;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1296_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1297_recOwned;
                  isErased = _1298_recErased;
                  readIdents = _1299_recIdents;
                }
              } else if (_source45.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1300___mcc_h738 = _source45.dtor_args;
                DAST._IType _1301___mcc_h739 = _source45.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1302_recursiveGen;
                  bool _1303_recOwned;
                  bool _1304_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1305_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out738;
                  bool _out739;
                  bool _out740;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out741;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out738, out _out739, out _out740, out _out741);
                  _1302_recursiveGen = _out738;
                  _1303_recOwned = _out739;
                  _1304_recErased = _out740;
                  _1305_recIdents = _out741;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1302_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1303_recOwned;
                  isErased = _1304_recErased;
                  readIdents = _1305_recIdents;
                }
              } else if (_source45.is_Primitive) {
                DAST._IPrimitive _1306___mcc_h742 = _source45.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1307_recursiveGen;
                  bool _1308_recOwned;
                  bool _1309_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1310_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out742;
                  bool _out743;
                  bool _out744;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out745;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out742, out _out743, out _out744, out _out745);
                  _1307_recursiveGen = _out742;
                  _1308_recOwned = _out743;
                  _1309_recErased = _out744;
                  _1310_recIdents = _out745;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1307_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1308_recOwned;
                  isErased = _1309_recErased;
                  readIdents = _1310_recIdents;
                }
              } else if (_source45.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1311___mcc_h744 = _source45.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1312_recursiveGen;
                  bool _1313_recOwned;
                  bool _1314_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1315_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out746;
                  bool _out747;
                  bool _out748;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out749;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out746, out _out747, out _out748, out _out749);
                  _1312_recursiveGen = _out746;
                  _1313_recOwned = _out747;
                  _1314_recErased = _out748;
                  _1315_recIdents = _out749;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1312_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1313_recOwned;
                  isErased = _1314_recErased;
                  readIdents = _1315_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1316___mcc_h746 = _source45.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1317_recursiveGen;
                  bool _1318_recOwned;
                  bool _1319_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1320_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out750;
                  bool _out751;
                  bool _out752;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out753;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out750, out _out751, out _out752, out _out753);
                  _1317_recursiveGen = _out750;
                  _1318_recOwned = _out751;
                  _1319_recErased = _out752;
                  _1320_recIdents = _out753;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1317_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1318_recOwned;
                  isErased = _1319_recErased;
                  readIdents = _1320_recIdents;
                }
              }
            } else if (_source27.is_Map) {
              DAST._IType _1321___mcc_h748 = _source27.dtor_key;
              DAST._IType _1322___mcc_h749 = _source27.dtor_value;
              DAST._IType _source47 = _575___mcc_h293;
              if (_source47.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1323___mcc_h756 = _source47.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1324___mcc_h757 = _source47.dtor_typeArgs;
                DAST._IResolvedType _1325___mcc_h758 = _source47.dtor_resolved;
                DAST._IResolvedType _source48 = _1325___mcc_h758;
                if (_source48.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1326___mcc_h762 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                    bool _1328_recOwned;
                    bool _1329_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out754;
                    bool _out755;
                    bool _out756;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out757;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out754, out _out755, out _out756, out _out757);
                    _1327_recursiveGen = _out754;
                    _1328_recOwned = _out755;
                    _1329_recErased = _out756;
                    _1330_recIdents = _out757;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1328_recOwned;
                    isErased = _1329_recErased;
                    readIdents = _1330_recIdents;
                  }
                } else if (_source48.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1331___mcc_h764 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1332_recursiveGen;
                    bool _1333_recOwned;
                    bool _1334_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1335_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out758;
                    bool _out759;
                    bool _out760;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                    _1332_recursiveGen = _out758;
                    _1333_recOwned = _out759;
                    _1334_recErased = _out760;
                    _1335_recIdents = _out761;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1332_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1333_recOwned;
                    isErased = _1334_recErased;
                    readIdents = _1335_recIdents;
                  }
                } else {
                  DAST._IType _1336___mcc_h766 = _source48.dtor_Newtype_a0;
                  DAST._IType _1337_b = _1336___mcc_h766;
                  {
                    if (object.Equals(_568_fromTpe, _1337_b)) {
                      Dafny.ISequence<Dafny.Rune> _1338_recursiveGen;
                      bool _1339_recOwned;
                      bool _1340_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1341_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out762;
                      bool _out763;
                      bool _out764;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                      _1338_recursiveGen = _out762;
                      _1339_recOwned = _out763;
                      _1340_recErased = _out764;
                      _1341_recIdents = _out765;
                      Dafny.ISequence<Dafny.Rune> _1342_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out766;
                      _out766 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1342_rhsType = _out766;
                      Dafny.ISequence<Dafny.Rune> _1343_uneraseFn;
                      _1343_uneraseFn = ((_1339_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1342_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1343_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1338_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1339_recOwned;
                      isErased = false;
                      readIdents = _1341_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out767;
                      bool _out768;
                      bool _out769;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out770;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1337_b), _1337_b, _567_toTpe), selfIdent, @params, mustOwn, out _out767, out _out768, out _out769, out _out770);
                      s = _out767;
                      isOwned = _out768;
                      isErased = _out769;
                      readIdents = _out770;
                    }
                  }
                }
              } else if (_source47.is_Nullable) {
                DAST._IType _1344___mcc_h768 = _source47.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1345_recursiveGen;
                  bool _1346_recOwned;
                  bool _1347_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1348_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out771;
                  bool _out772;
                  bool _out773;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out774;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out771, out _out772, out _out773, out _out774);
                  _1345_recursiveGen = _out771;
                  _1346_recOwned = _out772;
                  _1347_recErased = _out773;
                  _1348_recIdents = _out774;
                  if (!(_1346_recOwned)) {
                    _1345_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1345_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1345_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1347_recErased;
                  readIdents = _1348_recIdents;
                }
              } else if (_source47.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1349___mcc_h770 = _source47.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1350_recursiveGen;
                  bool _1351_recOwned;
                  bool _1352_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1353_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out775;
                  bool _out776;
                  bool _out777;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out778;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out775, out _out776, out _out777, out _out778);
                  _1350_recursiveGen = _out775;
                  _1351_recOwned = _out776;
                  _1352_recErased = _out777;
                  _1353_recIdents = _out778;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1350_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1351_recOwned;
                  isErased = _1352_recErased;
                  readIdents = _1353_recIdents;
                }
              } else if (_source47.is_Array) {
                DAST._IType _1354___mcc_h772 = _source47.dtor_element;
                BigInteger _1355___mcc_h773 = _source47.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1356_recursiveGen;
                  bool _1357_recOwned;
                  bool _1358_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1359_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out779;
                  bool _out780;
                  bool _out781;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out782;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out779, out _out780, out _out781, out _out782);
                  _1356_recursiveGen = _out779;
                  _1357_recOwned = _out780;
                  _1358_recErased = _out781;
                  _1359_recIdents = _out782;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1356_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1357_recOwned;
                  isErased = _1358_recErased;
                  readIdents = _1359_recIdents;
                }
              } else if (_source47.is_Seq) {
                DAST._IType _1360___mcc_h776 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1361_recursiveGen;
                  bool _1362_recOwned;
                  bool _1363_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1364_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out783;
                  bool _out784;
                  bool _out785;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out786;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out783, out _out784, out _out785, out _out786);
                  _1361_recursiveGen = _out783;
                  _1362_recOwned = _out784;
                  _1363_recErased = _out785;
                  _1364_recIdents = _out786;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1361_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1362_recOwned;
                  isErased = _1363_recErased;
                  readIdents = _1364_recIdents;
                }
              } else if (_source47.is_Set) {
                DAST._IType _1365___mcc_h778 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1366_recursiveGen;
                  bool _1367_recOwned;
                  bool _1368_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1369_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out787;
                  bool _out788;
                  bool _out789;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out790;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out787, out _out788, out _out789, out _out790);
                  _1366_recursiveGen = _out787;
                  _1367_recOwned = _out788;
                  _1368_recErased = _out789;
                  _1369_recIdents = _out790;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1366_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1367_recOwned;
                  isErased = _1368_recErased;
                  readIdents = _1369_recIdents;
                }
              } else if (_source47.is_Multiset) {
                DAST._IType _1370___mcc_h780 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1371_recursiveGen;
                  bool _1372_recOwned;
                  bool _1373_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1374_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out791;
                  bool _out792;
                  bool _out793;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out794;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out791, out _out792, out _out793, out _out794);
                  _1371_recursiveGen = _out791;
                  _1372_recOwned = _out792;
                  _1373_recErased = _out793;
                  _1374_recIdents = _out794;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1371_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1372_recOwned;
                  isErased = _1373_recErased;
                  readIdents = _1374_recIdents;
                }
              } else if (_source47.is_Map) {
                DAST._IType _1375___mcc_h782 = _source47.dtor_key;
                DAST._IType _1376___mcc_h783 = _source47.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1377_recursiveGen;
                  bool _1378_recOwned;
                  bool _1379_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1380_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out795;
                  bool _out796;
                  bool _out797;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out798;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out795, out _out796, out _out797, out _out798);
                  _1377_recursiveGen = _out795;
                  _1378_recOwned = _out796;
                  _1379_recErased = _out797;
                  _1380_recIdents = _out798;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1377_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1378_recOwned;
                  isErased = _1379_recErased;
                  readIdents = _1380_recIdents;
                }
              } else if (_source47.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1381___mcc_h786 = _source47.dtor_args;
                DAST._IType _1382___mcc_h787 = _source47.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1383_recursiveGen;
                  bool _1384_recOwned;
                  bool _1385_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1386_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out799;
                  bool _out800;
                  bool _out801;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out802;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out799, out _out800, out _out801, out _out802);
                  _1383_recursiveGen = _out799;
                  _1384_recOwned = _out800;
                  _1385_recErased = _out801;
                  _1386_recIdents = _out802;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1383_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1384_recOwned;
                  isErased = _1385_recErased;
                  readIdents = _1386_recIdents;
                }
              } else if (_source47.is_Primitive) {
                DAST._IPrimitive _1387___mcc_h790 = _source47.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1388_recursiveGen;
                  bool _1389_recOwned;
                  bool _1390_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1391_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out803;
                  bool _out804;
                  bool _out805;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out806;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out803, out _out804, out _out805, out _out806);
                  _1388_recursiveGen = _out803;
                  _1389_recOwned = _out804;
                  _1390_recErased = _out805;
                  _1391_recIdents = _out806;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1388_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1389_recOwned;
                  isErased = _1390_recErased;
                  readIdents = _1391_recIdents;
                }
              } else if (_source47.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1392___mcc_h792 = _source47.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1393_recursiveGen;
                  bool _1394_recOwned;
                  bool _1395_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1396_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out807;
                  bool _out808;
                  bool _out809;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out810;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out807, out _out808, out _out809, out _out810);
                  _1393_recursiveGen = _out807;
                  _1394_recOwned = _out808;
                  _1395_recErased = _out809;
                  _1396_recIdents = _out810;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1393_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1394_recOwned;
                  isErased = _1395_recErased;
                  readIdents = _1396_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1397___mcc_h794 = _source47.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1398_recursiveGen;
                  bool _1399_recOwned;
                  bool _1400_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1401_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out811;
                  bool _out812;
                  bool _out813;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out814;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out811, out _out812, out _out813, out _out814);
                  _1398_recursiveGen = _out811;
                  _1399_recOwned = _out812;
                  _1400_recErased = _out813;
                  _1401_recIdents = _out814;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1398_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1399_recOwned;
                  isErased = _1400_recErased;
                  readIdents = _1401_recIdents;
                }
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1402___mcc_h796 = _source27.dtor_args;
              DAST._IType _1403___mcc_h797 = _source27.dtor_result;
              DAST._IType _source49 = _575___mcc_h293;
              if (_source49.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1404___mcc_h804 = _source49.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1405___mcc_h805 = _source49.dtor_typeArgs;
                DAST._IResolvedType _1406___mcc_h806 = _source49.dtor_resolved;
                DAST._IResolvedType _source50 = _1406___mcc_h806;
                if (_source50.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1407___mcc_h810 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1408_recursiveGen;
                    bool _1409_recOwned;
                    bool _1410_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1411_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out815;
                    bool _out816;
                    bool _out817;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out818;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out815, out _out816, out _out817, out _out818);
                    _1408_recursiveGen = _out815;
                    _1409_recOwned = _out816;
                    _1410_recErased = _out817;
                    _1411_recIdents = _out818;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1408_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1409_recOwned;
                    isErased = _1410_recErased;
                    readIdents = _1411_recIdents;
                  }
                } else if (_source50.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1412___mcc_h812 = _source50.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                    bool _1414_recOwned;
                    bool _1415_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out819;
                    bool _out820;
                    bool _out821;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                    _1413_recursiveGen = _out819;
                    _1414_recOwned = _out820;
                    _1415_recErased = _out821;
                    _1416_recIdents = _out822;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1414_recOwned;
                    isErased = _1415_recErased;
                    readIdents = _1416_recIdents;
                  }
                } else {
                  DAST._IType _1417___mcc_h814 = _source50.dtor_Newtype_a0;
                  DAST._IType _1418_b = _1417___mcc_h814;
                  {
                    if (object.Equals(_568_fromTpe, _1418_b)) {
                      Dafny.ISequence<Dafny.Rune> _1419_recursiveGen;
                      bool _1420_recOwned;
                      bool _1421_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1422_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out823;
                      bool _out824;
                      bool _out825;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                      _1419_recursiveGen = _out823;
                      _1420_recOwned = _out824;
                      _1421_recErased = _out825;
                      _1422_recIdents = _out826;
                      Dafny.ISequence<Dafny.Rune> _1423_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out827;
                      _out827 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1423_rhsType = _out827;
                      Dafny.ISequence<Dafny.Rune> _1424_uneraseFn;
                      _1424_uneraseFn = ((_1420_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1423_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1424_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1419_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1420_recOwned;
                      isErased = false;
                      readIdents = _1422_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out828;
                      bool _out829;
                      bool _out830;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out831;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1418_b), _1418_b, _567_toTpe), selfIdent, @params, mustOwn, out _out828, out _out829, out _out830, out _out831);
                      s = _out828;
                      isOwned = _out829;
                      isErased = _out830;
                      readIdents = _out831;
                    }
                  }
                }
              } else if (_source49.is_Nullable) {
                DAST._IType _1425___mcc_h816 = _source49.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1426_recursiveGen;
                  bool _1427_recOwned;
                  bool _1428_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1429_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out832;
                  bool _out833;
                  bool _out834;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out835;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out832, out _out833, out _out834, out _out835);
                  _1426_recursiveGen = _out832;
                  _1427_recOwned = _out833;
                  _1428_recErased = _out834;
                  _1429_recIdents = _out835;
                  if (!(_1427_recOwned)) {
                    _1426_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1426_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1426_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1428_recErased;
                  readIdents = _1429_recIdents;
                }
              } else if (_source49.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1430___mcc_h818 = _source49.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1431_recursiveGen;
                  bool _1432_recOwned;
                  bool _1433_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1434_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out836;
                  bool _out837;
                  bool _out838;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out839;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out836, out _out837, out _out838, out _out839);
                  _1431_recursiveGen = _out836;
                  _1432_recOwned = _out837;
                  _1433_recErased = _out838;
                  _1434_recIdents = _out839;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1431_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1432_recOwned;
                  isErased = _1433_recErased;
                  readIdents = _1434_recIdents;
                }
              } else if (_source49.is_Array) {
                DAST._IType _1435___mcc_h820 = _source49.dtor_element;
                BigInteger _1436___mcc_h821 = _source49.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1437_recursiveGen;
                  bool _1438_recOwned;
                  bool _1439_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1440_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out840;
                  bool _out841;
                  bool _out842;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out843;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out840, out _out841, out _out842, out _out843);
                  _1437_recursiveGen = _out840;
                  _1438_recOwned = _out841;
                  _1439_recErased = _out842;
                  _1440_recIdents = _out843;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1437_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1438_recOwned;
                  isErased = _1439_recErased;
                  readIdents = _1440_recIdents;
                }
              } else if (_source49.is_Seq) {
                DAST._IType _1441___mcc_h824 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1442_recursiveGen;
                  bool _1443_recOwned;
                  bool _1444_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1445_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out844;
                  bool _out845;
                  bool _out846;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out847;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out844, out _out845, out _out846, out _out847);
                  _1442_recursiveGen = _out844;
                  _1443_recOwned = _out845;
                  _1444_recErased = _out846;
                  _1445_recIdents = _out847;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1442_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1443_recOwned;
                  isErased = _1444_recErased;
                  readIdents = _1445_recIdents;
                }
              } else if (_source49.is_Set) {
                DAST._IType _1446___mcc_h826 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1447_recursiveGen;
                  bool _1448_recOwned;
                  bool _1449_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1450_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out848;
                  bool _out849;
                  bool _out850;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out851;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out848, out _out849, out _out850, out _out851);
                  _1447_recursiveGen = _out848;
                  _1448_recOwned = _out849;
                  _1449_recErased = _out850;
                  _1450_recIdents = _out851;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1447_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1448_recOwned;
                  isErased = _1449_recErased;
                  readIdents = _1450_recIdents;
                }
              } else if (_source49.is_Multiset) {
                DAST._IType _1451___mcc_h828 = _source49.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1452_recursiveGen;
                  bool _1453_recOwned;
                  bool _1454_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1455_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out852;
                  bool _out853;
                  bool _out854;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out855;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out852, out _out853, out _out854, out _out855);
                  _1452_recursiveGen = _out852;
                  _1453_recOwned = _out853;
                  _1454_recErased = _out854;
                  _1455_recIdents = _out855;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1452_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1453_recOwned;
                  isErased = _1454_recErased;
                  readIdents = _1455_recIdents;
                }
              } else if (_source49.is_Map) {
                DAST._IType _1456___mcc_h830 = _source49.dtor_key;
                DAST._IType _1457___mcc_h831 = _source49.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1458_recursiveGen;
                  bool _1459_recOwned;
                  bool _1460_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1461_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out856;
                  bool _out857;
                  bool _out858;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out859;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out856, out _out857, out _out858, out _out859);
                  _1458_recursiveGen = _out856;
                  _1459_recOwned = _out857;
                  _1460_recErased = _out858;
                  _1461_recIdents = _out859;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1458_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1459_recOwned;
                  isErased = _1460_recErased;
                  readIdents = _1461_recIdents;
                }
              } else if (_source49.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1462___mcc_h834 = _source49.dtor_args;
                DAST._IType _1463___mcc_h835 = _source49.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1464_recursiveGen;
                  bool _1465_recOwned;
                  bool _1466_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1467_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out860;
                  bool _out861;
                  bool _out862;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out863;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out860, out _out861, out _out862, out _out863);
                  _1464_recursiveGen = _out860;
                  _1465_recOwned = _out861;
                  _1466_recErased = _out862;
                  _1467_recIdents = _out863;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1464_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1465_recOwned;
                  isErased = _1466_recErased;
                  readIdents = _1467_recIdents;
                }
              } else if (_source49.is_Primitive) {
                DAST._IPrimitive _1468___mcc_h838 = _source49.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1469_recursiveGen;
                  bool _1470_recOwned;
                  bool _1471_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1472_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out864;
                  bool _out865;
                  bool _out866;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out867;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out864, out _out865, out _out866, out _out867);
                  _1469_recursiveGen = _out864;
                  _1470_recOwned = _out865;
                  _1471_recErased = _out866;
                  _1472_recIdents = _out867;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1469_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1470_recOwned;
                  isErased = _1471_recErased;
                  readIdents = _1472_recIdents;
                }
              } else if (_source49.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1473___mcc_h840 = _source49.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1474_recursiveGen;
                  bool _1475_recOwned;
                  bool _1476_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1477_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out868;
                  bool _out869;
                  bool _out870;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out871;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out868, out _out869, out _out870, out _out871);
                  _1474_recursiveGen = _out868;
                  _1475_recOwned = _out869;
                  _1476_recErased = _out870;
                  _1477_recIdents = _out871;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1474_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1475_recOwned;
                  isErased = _1476_recErased;
                  readIdents = _1477_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1478___mcc_h842 = _source49.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1479_recursiveGen;
                  bool _1480_recOwned;
                  bool _1481_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1482_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out872;
                  bool _out873;
                  bool _out874;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                  _1479_recursiveGen = _out872;
                  _1480_recOwned = _out873;
                  _1481_recErased = _out874;
                  _1482_recIdents = _out875;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1480_recOwned;
                  isErased = _1481_recErased;
                  readIdents = _1482_recIdents;
                }
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _1483___mcc_h844 = _source27.dtor_Primitive_a0;
              DAST._IPrimitive _source51 = _1483___mcc_h844;
              if (_source51.is_Int) {
                DAST._IType _source52 = _575___mcc_h293;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1484___mcc_h848 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1485___mcc_h849 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1486___mcc_h850 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1486___mcc_h850;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1487___mcc_h854 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1488_recursiveGen;
                      bool _1489_recOwned;
                      bool _1490_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1491_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out876;
                      bool _out877;
                      bool _out878;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                      _1488_recursiveGen = _out876;
                      _1489_recOwned = _out877;
                      _1490_recErased = _out878;
                      _1491_recIdents = _out879;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1488_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1489_recOwned;
                      isErased = _1490_recErased;
                      readIdents = _1491_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1492___mcc_h856 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1493_recursiveGen;
                      bool _1494_recOwned;
                      bool _1495_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1496_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out880;
                      bool _out881;
                      bool _out882;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                      _1493_recursiveGen = _out880;
                      _1494_recOwned = _out881;
                      _1495_recErased = _out882;
                      _1496_recIdents = _out883;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1493_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1494_recOwned;
                      isErased = _1495_recErased;
                      readIdents = _1496_recIdents;
                    }
                  } else {
                    DAST._IType _1497___mcc_h858 = _source53.dtor_Newtype_a0;
                    DAST._IType _1498_b = _1497___mcc_h858;
                    {
                      if (object.Equals(_568_fromTpe, _1498_b)) {
                        Dafny.ISequence<Dafny.Rune> _1499_recursiveGen;
                        bool _1500_recOwned;
                        bool _1501_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1502_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out884;
                        bool _out885;
                        bool _out886;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                        _1499_recursiveGen = _out884;
                        _1500_recOwned = _out885;
                        _1501_recErased = _out886;
                        _1502_recIdents = _out887;
                        Dafny.ISequence<Dafny.Rune> _1503_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out888;
                        _out888 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _1503_rhsType = _out888;
                        Dafny.ISequence<Dafny.Rune> _1504_uneraseFn;
                        _1504_uneraseFn = ((_1500_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1503_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1504_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1499_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1500_recOwned;
                        isErased = false;
                        readIdents = _1502_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out889;
                        bool _out890;
                        bool _out891;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out892;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1498_b), _1498_b, _567_toTpe), selfIdent, @params, mustOwn, out _out889, out _out890, out _out891, out _out892);
                        s = _out889;
                        isOwned = _out890;
                        isErased = _out891;
                        readIdents = _out892;
                      }
                    }
                  }
                } else if (_source52.is_Nullable) {
                  DAST._IType _1505___mcc_h860 = _source52.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1506_recursiveGen;
                    bool _1507_recOwned;
                    bool _1508_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1509_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out893;
                    bool _out894;
                    bool _out895;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out896;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out893, out _out894, out _out895, out _out896);
                    _1506_recursiveGen = _out893;
                    _1507_recOwned = _out894;
                    _1508_recErased = _out895;
                    _1509_recIdents = _out896;
                    if (!(_1507_recOwned)) {
                      _1506_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1506_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1506_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1508_recErased;
                    readIdents = _1509_recIdents;
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1510___mcc_h862 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1511_recursiveGen;
                    bool _1512_recOwned;
                    bool _1513_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1514_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out897;
                    bool _out898;
                    bool _out899;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out900;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out897, out _out898, out _out899, out _out900);
                    _1511_recursiveGen = _out897;
                    _1512_recOwned = _out898;
                    _1513_recErased = _out899;
                    _1514_recIdents = _out900;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1511_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1512_recOwned;
                    isErased = _1513_recErased;
                    readIdents = _1514_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1515___mcc_h864 = _source52.dtor_element;
                  BigInteger _1516___mcc_h865 = _source52.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1517_recursiveGen;
                    bool _1518_recOwned;
                    bool _1519_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1520_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out901;
                    bool _out902;
                    bool _out903;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out904;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out901, out _out902, out _out903, out _out904);
                    _1517_recursiveGen = _out901;
                    _1518_recOwned = _out902;
                    _1519_recErased = _out903;
                    _1520_recIdents = _out904;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1517_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1518_recOwned;
                    isErased = _1519_recErased;
                    readIdents = _1520_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1521___mcc_h868 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                    bool _1523_recOwned;
                    bool _1524_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out905;
                    bool _out906;
                    bool _out907;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out908;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out905, out _out906, out _out907, out _out908);
                    _1522_recursiveGen = _out905;
                    _1523_recOwned = _out906;
                    _1524_recErased = _out907;
                    _1525_recIdents = _out908;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1523_recOwned;
                    isErased = _1524_recErased;
                    readIdents = _1525_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1526___mcc_h870 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1527_recursiveGen;
                    bool _1528_recOwned;
                    bool _1529_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1530_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out909;
                    bool _out910;
                    bool _out911;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out912;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out909, out _out910, out _out911, out _out912);
                    _1527_recursiveGen = _out909;
                    _1528_recOwned = _out910;
                    _1529_recErased = _out911;
                    _1530_recIdents = _out912;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1528_recOwned;
                    isErased = _1529_recErased;
                    readIdents = _1530_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1531___mcc_h872 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1532_recursiveGen;
                    bool _1533_recOwned;
                    bool _1534_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1535_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out913;
                    bool _out914;
                    bool _out915;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out916;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out913, out _out914, out _out915, out _out916);
                    _1532_recursiveGen = _out913;
                    _1533_recOwned = _out914;
                    _1534_recErased = _out915;
                    _1535_recIdents = _out916;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1532_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1533_recOwned;
                    isErased = _1534_recErased;
                    readIdents = _1535_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1536___mcc_h874 = _source52.dtor_key;
                  DAST._IType _1537___mcc_h875 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1538_recursiveGen;
                    bool _1539_recOwned;
                    bool _1540_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1541_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out917;
                    bool _out918;
                    bool _out919;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out920;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out917, out _out918, out _out919, out _out920);
                    _1538_recursiveGen = _out917;
                    _1539_recOwned = _out918;
                    _1540_recErased = _out919;
                    _1541_recIdents = _out920;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1538_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1539_recOwned;
                    isErased = _1540_recErased;
                    readIdents = _1541_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1542___mcc_h878 = _source52.dtor_args;
                  DAST._IType _1543___mcc_h879 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                    bool _1545_recOwned;
                    bool _1546_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out921;
                    bool _out922;
                    bool _out923;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out924;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out921, out _out922, out _out923, out _out924);
                    _1544_recursiveGen = _out921;
                    _1545_recOwned = _out922;
                    _1546_recErased = _out923;
                    _1547_recIdents = _out924;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1545_recOwned;
                    isErased = _1546_recErased;
                    readIdents = _1547_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1548___mcc_h882 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1548___mcc_h882;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1549_recursiveGen;
                      bool _1550_recOwned;
                      bool _1551_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1552_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out925;
                      bool _out926;
                      bool _out927;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out928;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out925, out _out926, out _out927, out _out928);
                      _1549_recursiveGen = _out925;
                      _1550_recOwned = _out926;
                      _1551_recErased = _out927;
                      _1552_recIdents = _out928;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1550_recOwned;
                      isErased = _1551_recErased;
                      readIdents = _1552_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1553_recursiveGen;
                      bool _1554___v48;
                      bool _1555___v49;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1556_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out929;
                      bool _out930;
                      bool _out931;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out932;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, true, out _out929, out _out930, out _out931, out _out932);
                      _1553_recursiveGen = _out929;
                      _1554___v48 = _out930;
                      _1555___v49 = _out931;
                      _1556_recIdents = _out932;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1553_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1556_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1557_recursiveGen;
                      bool _1558_recOwned;
                      bool _1559_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1560_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out933, out _out934, out _out935, out _out936);
                      _1557_recursiveGen = _out933;
                      _1558_recOwned = _out934;
                      _1559_recErased = _out935;
                      _1560_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1557_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1558_recOwned;
                      isErased = _1559_recErased;
                      readIdents = _1560_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1561_recursiveGen;
                      bool _1562_recOwned;
                      bool _1563_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1564_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out937;
                      bool _out938;
                      bool _out939;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out940;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out937, out _out938, out _out939, out _out940);
                      _1561_recursiveGen = _out937;
                      _1562_recOwned = _out938;
                      _1563_recErased = _out939;
                      _1564_recIdents = _out940;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1561_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1562_recOwned;
                      isErased = _1563_recErased;
                      readIdents = _1564_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1565_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out941;
                      _out941 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1565_rhsType = _out941;
                      Dafny.ISequence<Dafny.Rune> _1566_recursiveGen;
                      bool _1567___v58;
                      bool _1568___v59;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1569_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out942;
                      bool _out943;
                      bool _out944;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, true, out _out942, out _out943, out _out944, out _out945);
                      _1566_recursiveGen = _out942;
                      _1567___v58 = _out943;
                      _1568___v59 = _out944;
                      _1569_recIdents = _out945;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1569_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1570___mcc_h884 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1571_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out946;
                    _out946 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                    _1571_rhsType = _out946;
                    Dafny.ISequence<Dafny.Rune> _1572_recursiveGen;
                    bool _1573___v53;
                    bool _1574___v54;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1575_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out947;
                    bool _out948;
                    bool _out949;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out950;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, true, out _out947, out _out948, out _out949, out _out950);
                    _1572_recursiveGen = _out947;
                    _1573___v53 = _out948;
                    _1574___v54 = _out949;
                    _1575_recIdents = _out950;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1571_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1575_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1576___mcc_h886 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1577_recursiveGen;
                    bool _1578_recOwned;
                    bool _1579_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1580_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out951;
                    bool _out952;
                    bool _out953;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out954;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out951, out _out952, out _out953, out _out954);
                    _1577_recursiveGen = _out951;
                    _1578_recOwned = _out952;
                    _1579_recErased = _out953;
                    _1580_recIdents = _out954;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1577_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1578_recOwned;
                    isErased = _1579_recErased;
                    readIdents = _1580_recIdents;
                  }
                }
              } else if (_source51.is_Real) {
                DAST._IType _source55 = _575___mcc_h293;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1581___mcc_h888 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1582___mcc_h889 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1583___mcc_h890 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1583___mcc_h890;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1584___mcc_h894 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1585_recursiveGen;
                      bool _1586_recOwned;
                      bool _1587_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1588_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out955;
                      bool _out956;
                      bool _out957;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out958;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out955, out _out956, out _out957, out _out958);
                      _1585_recursiveGen = _out955;
                      _1586_recOwned = _out956;
                      _1587_recErased = _out957;
                      _1588_recIdents = _out958;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1585_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1586_recOwned;
                      isErased = _1587_recErased;
                      readIdents = _1588_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1589___mcc_h896 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1590_recursiveGen;
                      bool _1591_recOwned;
                      bool _1592_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1593_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out959;
                      bool _out960;
                      bool _out961;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                      _1590_recursiveGen = _out959;
                      _1591_recOwned = _out960;
                      _1592_recErased = _out961;
                      _1593_recIdents = _out962;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1590_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1591_recOwned;
                      isErased = _1592_recErased;
                      readIdents = _1593_recIdents;
                    }
                  } else {
                    DAST._IType _1594___mcc_h898 = _source56.dtor_Newtype_a0;
                    DAST._IType _1595_b = _1594___mcc_h898;
                    {
                      if (object.Equals(_568_fromTpe, _1595_b)) {
                        Dafny.ISequence<Dafny.Rune> _1596_recursiveGen;
                        bool _1597_recOwned;
                        bool _1598_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1599_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out963;
                        bool _out964;
                        bool _out965;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                        _1596_recursiveGen = _out963;
                        _1597_recOwned = _out964;
                        _1598_recErased = _out965;
                        _1599_recIdents = _out966;
                        Dafny.ISequence<Dafny.Rune> _1600_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out967;
                        _out967 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _1600_rhsType = _out967;
                        Dafny.ISequence<Dafny.Rune> _1601_uneraseFn;
                        _1601_uneraseFn = ((_1597_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1600_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1601_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1597_recOwned;
                        isErased = false;
                        readIdents = _1599_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out968;
                        bool _out969;
                        bool _out970;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out971;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1595_b), _1595_b, _567_toTpe), selfIdent, @params, mustOwn, out _out968, out _out969, out _out970, out _out971);
                        s = _out968;
                        isOwned = _out969;
                        isErased = _out970;
                        readIdents = _out971;
                      }
                    }
                  }
                } else if (_source55.is_Nullable) {
                  DAST._IType _1602___mcc_h900 = _source55.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1603_recursiveGen;
                    bool _1604_recOwned;
                    bool _1605_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1606_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out972;
                    bool _out973;
                    bool _out974;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out975;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out972, out _out973, out _out974, out _out975);
                    _1603_recursiveGen = _out972;
                    _1604_recOwned = _out973;
                    _1605_recErased = _out974;
                    _1606_recIdents = _out975;
                    if (!(_1604_recOwned)) {
                      _1603_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1603_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1605_recErased;
                    readIdents = _1606_recIdents;
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1607___mcc_h902 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1608_recursiveGen;
                    bool _1609_recOwned;
                    bool _1610_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1611_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out976;
                    bool _out977;
                    bool _out978;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out979;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out976, out _out977, out _out978, out _out979);
                    _1608_recursiveGen = _out976;
                    _1609_recOwned = _out977;
                    _1610_recErased = _out978;
                    _1611_recIdents = _out979;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1608_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1609_recOwned;
                    isErased = _1610_recErased;
                    readIdents = _1611_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1612___mcc_h904 = _source55.dtor_element;
                  BigInteger _1613___mcc_h905 = _source55.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1614_recursiveGen;
                    bool _1615_recOwned;
                    bool _1616_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out980;
                    bool _out981;
                    bool _out982;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out983;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out980, out _out981, out _out982, out _out983);
                    _1614_recursiveGen = _out980;
                    _1615_recOwned = _out981;
                    _1616_recErased = _out982;
                    _1617_recIdents = _out983;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1615_recOwned;
                    isErased = _1616_recErased;
                    readIdents = _1617_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1618___mcc_h908 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1619_recursiveGen;
                    bool _1620_recOwned;
                    bool _1621_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1622_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out984;
                    bool _out985;
                    bool _out986;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out987;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out984, out _out985, out _out986, out _out987);
                    _1619_recursiveGen = _out984;
                    _1620_recOwned = _out985;
                    _1621_recErased = _out986;
                    _1622_recIdents = _out987;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1619_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1620_recOwned;
                    isErased = _1621_recErased;
                    readIdents = _1622_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1623___mcc_h910 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1624_recursiveGen;
                    bool _1625_recOwned;
                    bool _1626_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1627_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out988;
                    bool _out989;
                    bool _out990;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out991;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out988, out _out989, out _out990, out _out991);
                    _1624_recursiveGen = _out988;
                    _1625_recOwned = _out989;
                    _1626_recErased = _out990;
                    _1627_recIdents = _out991;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1624_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1625_recOwned;
                    isErased = _1626_recErased;
                    readIdents = _1627_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1628___mcc_h912 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1629_recursiveGen;
                    bool _1630_recOwned;
                    bool _1631_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1632_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out992;
                    bool _out993;
                    bool _out994;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out995;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out992, out _out993, out _out994, out _out995);
                    _1629_recursiveGen = _out992;
                    _1630_recOwned = _out993;
                    _1631_recErased = _out994;
                    _1632_recIdents = _out995;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1630_recOwned;
                    isErased = _1631_recErased;
                    readIdents = _1632_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1633___mcc_h914 = _source55.dtor_key;
                  DAST._IType _1634___mcc_h915 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1635_recursiveGen;
                    bool _1636_recOwned;
                    bool _1637_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1638_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out996;
                    bool _out997;
                    bool _out998;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out999;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out996, out _out997, out _out998, out _out999);
                    _1635_recursiveGen = _out996;
                    _1636_recOwned = _out997;
                    _1637_recErased = _out998;
                    _1638_recIdents = _out999;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1636_recOwned;
                    isErased = _1637_recErased;
                    readIdents = _1638_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1639___mcc_h918 = _source55.dtor_args;
                  DAST._IType _1640___mcc_h919 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1641_recursiveGen;
                    bool _1642_recOwned;
                    bool _1643_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1644_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1000;
                    bool _out1001;
                    bool _out1002;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1003;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1000, out _out1001, out _out1002, out _out1003);
                    _1641_recursiveGen = _out1000;
                    _1642_recOwned = _out1001;
                    _1643_recErased = _out1002;
                    _1644_recIdents = _out1003;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1641_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1642_recOwned;
                    isErased = _1643_recErased;
                    readIdents = _1644_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1645___mcc_h922 = _source55.dtor_Primitive_a0;
                  DAST._IPrimitive _source57 = _1645___mcc_h922;
                  if (_source57.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1646_recursiveGen;
                      bool _1647___v50;
                      bool _1648___v51;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1649_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1004;
                      bool _out1005;
                      bool _out1006;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1007;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, false, out _out1004, out _out1005, out _out1006, out _out1007);
                      _1646_recursiveGen = _out1004;
                      _1647___v50 = _out1005;
                      _1648___v51 = _out1006;
                      _1649_recIdents = _out1007;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1646_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1649_recIdents;
                    }
                  } else if (_source57.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1650_recursiveGen;
                      bool _1651_recOwned;
                      bool _1652_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1653_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1008;
                      bool _out1009;
                      bool _out1010;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1011;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1008, out _out1009, out _out1010, out _out1011);
                      _1650_recursiveGen = _out1008;
                      _1651_recOwned = _out1009;
                      _1652_recErased = _out1010;
                      _1653_recIdents = _out1011;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1651_recOwned;
                      isErased = _1652_recErased;
                      readIdents = _1653_recIdents;
                    }
                  } else if (_source57.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1654_recursiveGen;
                      bool _1655_recOwned;
                      bool _1656_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1657_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1012;
                      bool _out1013;
                      bool _out1014;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1015;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1012, out _out1013, out _out1014, out _out1015);
                      _1654_recursiveGen = _out1012;
                      _1655_recOwned = _out1013;
                      _1656_recErased = _out1014;
                      _1657_recIdents = _out1015;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1654_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1655_recOwned;
                      isErased = _1656_recErased;
                      readIdents = _1657_recIdents;
                    }
                  } else if (_source57.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1658_recursiveGen;
                      bool _1659_recOwned;
                      bool _1660_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1661_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1016;
                      bool _out1017;
                      bool _out1018;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1019;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1016, out _out1017, out _out1018, out _out1019);
                      _1658_recursiveGen = _out1016;
                      _1659_recOwned = _out1017;
                      _1660_recErased = _out1018;
                      _1661_recIdents = _out1019;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1658_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1659_recOwned;
                      isErased = _1660_recErased;
                      readIdents = _1661_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1662_recursiveGen;
                      bool _1663_recOwned;
                      bool _1664_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1665_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1020;
                      bool _out1021;
                      bool _out1022;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1023;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1020, out _out1021, out _out1022, out _out1023);
                      _1662_recursiveGen = _out1020;
                      _1663_recOwned = _out1021;
                      _1664_recErased = _out1022;
                      _1665_recIdents = _out1023;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1663_recOwned;
                      isErased = _1664_recErased;
                      readIdents = _1665_recIdents;
                    }
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1666___mcc_h924 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1667_recursiveGen;
                    bool _1668_recOwned;
                    bool _1669_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1670_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1024;
                    bool _out1025;
                    bool _out1026;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1027;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1024, out _out1025, out _out1026, out _out1027);
                    _1667_recursiveGen = _out1024;
                    _1668_recOwned = _out1025;
                    _1669_recErased = _out1026;
                    _1670_recIdents = _out1027;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1668_recOwned;
                    isErased = _1669_recErased;
                    readIdents = _1670_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1671___mcc_h926 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1672_recursiveGen;
                    bool _1673_recOwned;
                    bool _1674_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1675_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1028;
                    bool _out1029;
                    bool _out1030;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1031;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1028, out _out1029, out _out1030, out _out1031);
                    _1672_recursiveGen = _out1028;
                    _1673_recOwned = _out1029;
                    _1674_recErased = _out1030;
                    _1675_recIdents = _out1031;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1672_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1673_recOwned;
                    isErased = _1674_recErased;
                    readIdents = _1675_recIdents;
                  }
                }
              } else if (_source51.is_String) {
                DAST._IType _source58 = _575___mcc_h293;
                if (_source58.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1676___mcc_h928 = _source58.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1677___mcc_h929 = _source58.dtor_typeArgs;
                  DAST._IResolvedType _1678___mcc_h930 = _source58.dtor_resolved;
                  DAST._IResolvedType _source59 = _1678___mcc_h930;
                  if (_source59.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1679___mcc_h934 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1680_recursiveGen;
                      bool _1681_recOwned;
                      bool _1682_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1032;
                      bool _out1033;
                      bool _out1034;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1035;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1032, out _out1033, out _out1034, out _out1035);
                      _1680_recursiveGen = _out1032;
                      _1681_recOwned = _out1033;
                      _1682_recErased = _out1034;
                      _1683_recIdents = _out1035;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1681_recOwned;
                      isErased = _1682_recErased;
                      readIdents = _1683_recIdents;
                    }
                  } else if (_source59.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1684___mcc_h936 = _source59.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1685_recursiveGen;
                      bool _1686_recOwned;
                      bool _1687_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1688_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1036;
                      bool _out1037;
                      bool _out1038;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                      _1685_recursiveGen = _out1036;
                      _1686_recOwned = _out1037;
                      _1687_recErased = _out1038;
                      _1688_recIdents = _out1039;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1685_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1686_recOwned;
                      isErased = _1687_recErased;
                      readIdents = _1688_recIdents;
                    }
                  } else {
                    DAST._IType _1689___mcc_h938 = _source59.dtor_Newtype_a0;
                    DAST._IType _1690_b = _1689___mcc_h938;
                    {
                      if (object.Equals(_568_fromTpe, _1690_b)) {
                        Dafny.ISequence<Dafny.Rune> _1691_recursiveGen;
                        bool _1692_recOwned;
                        bool _1693_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1694_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1040;
                        bool _out1041;
                        bool _out1042;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                        _1691_recursiveGen = _out1040;
                        _1692_recOwned = _out1041;
                        _1693_recErased = _out1042;
                        _1694_recIdents = _out1043;
                        Dafny.ISequence<Dafny.Rune> _1695_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1044;
                        _out1044 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _1695_rhsType = _out1044;
                        Dafny.ISequence<Dafny.Rune> _1696_uneraseFn;
                        _1696_uneraseFn = ((_1692_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1695_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1696_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1691_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1692_recOwned;
                        isErased = false;
                        readIdents = _1694_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1045;
                        bool _out1046;
                        bool _out1047;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1048;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1690_b), _1690_b, _567_toTpe), selfIdent, @params, mustOwn, out _out1045, out _out1046, out _out1047, out _out1048);
                        s = _out1045;
                        isOwned = _out1046;
                        isErased = _out1047;
                        readIdents = _out1048;
                      }
                    }
                  }
                } else if (_source58.is_Nullable) {
                  DAST._IType _1697___mcc_h940 = _source58.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1698_recursiveGen;
                    bool _1699_recOwned;
                    bool _1700_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1701_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1049;
                    bool _out1050;
                    bool _out1051;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1052;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1049, out _out1050, out _out1051, out _out1052);
                    _1698_recursiveGen = _out1049;
                    _1699_recOwned = _out1050;
                    _1700_recErased = _out1051;
                    _1701_recIdents = _out1052;
                    if (!(_1699_recOwned)) {
                      _1698_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1698_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1700_recErased;
                    readIdents = _1701_recIdents;
                  }
                } else if (_source58.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1702___mcc_h942 = _source58.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1703_recursiveGen;
                    bool _1704_recOwned;
                    bool _1705_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1706_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1053;
                    bool _out1054;
                    bool _out1055;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1056;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1053, out _out1054, out _out1055, out _out1056);
                    _1703_recursiveGen = _out1053;
                    _1704_recOwned = _out1054;
                    _1705_recErased = _out1055;
                    _1706_recIdents = _out1056;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1704_recOwned;
                    isErased = _1705_recErased;
                    readIdents = _1706_recIdents;
                  }
                } else if (_source58.is_Array) {
                  DAST._IType _1707___mcc_h944 = _source58.dtor_element;
                  BigInteger _1708___mcc_h945 = _source58.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1709_recursiveGen;
                    bool _1710_recOwned;
                    bool _1711_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1712_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1057;
                    bool _out1058;
                    bool _out1059;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1060;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1057, out _out1058, out _out1059, out _out1060);
                    _1709_recursiveGen = _out1057;
                    _1710_recOwned = _out1058;
                    _1711_recErased = _out1059;
                    _1712_recIdents = _out1060;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1710_recOwned;
                    isErased = _1711_recErased;
                    readIdents = _1712_recIdents;
                  }
                } else if (_source58.is_Seq) {
                  DAST._IType _1713___mcc_h948 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1714_recursiveGen;
                    bool _1715_recOwned;
                    bool _1716_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1717_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1061;
                    bool _out1062;
                    bool _out1063;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1064;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1061, out _out1062, out _out1063, out _out1064);
                    _1714_recursiveGen = _out1061;
                    _1715_recOwned = _out1062;
                    _1716_recErased = _out1063;
                    _1717_recIdents = _out1064;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1714_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1715_recOwned;
                    isErased = _1716_recErased;
                    readIdents = _1717_recIdents;
                  }
                } else if (_source58.is_Set) {
                  DAST._IType _1718___mcc_h950 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1719_recursiveGen;
                    bool _1720_recOwned;
                    bool _1721_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1722_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1065;
                    bool _out1066;
                    bool _out1067;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1068;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1065, out _out1066, out _out1067, out _out1068);
                    _1719_recursiveGen = _out1065;
                    _1720_recOwned = _out1066;
                    _1721_recErased = _out1067;
                    _1722_recIdents = _out1068;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1719_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1720_recOwned;
                    isErased = _1721_recErased;
                    readIdents = _1722_recIdents;
                  }
                } else if (_source58.is_Multiset) {
                  DAST._IType _1723___mcc_h952 = _source58.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1724_recursiveGen;
                    bool _1725_recOwned;
                    bool _1726_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1727_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1069;
                    bool _out1070;
                    bool _out1071;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1072;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1069, out _out1070, out _out1071, out _out1072);
                    _1724_recursiveGen = _out1069;
                    _1725_recOwned = _out1070;
                    _1726_recErased = _out1071;
                    _1727_recIdents = _out1072;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1724_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1725_recOwned;
                    isErased = _1726_recErased;
                    readIdents = _1727_recIdents;
                  }
                } else if (_source58.is_Map) {
                  DAST._IType _1728___mcc_h954 = _source58.dtor_key;
                  DAST._IType _1729___mcc_h955 = _source58.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1730_recursiveGen;
                    bool _1731_recOwned;
                    bool _1732_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1733_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1073;
                    bool _out1074;
                    bool _out1075;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1076;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1073, out _out1074, out _out1075, out _out1076);
                    _1730_recursiveGen = _out1073;
                    _1731_recOwned = _out1074;
                    _1732_recErased = _out1075;
                    _1733_recIdents = _out1076;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1731_recOwned;
                    isErased = _1732_recErased;
                    readIdents = _1733_recIdents;
                  }
                } else if (_source58.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1734___mcc_h958 = _source58.dtor_args;
                  DAST._IType _1735___mcc_h959 = _source58.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1736_recursiveGen;
                    bool _1737_recOwned;
                    bool _1738_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1739_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1077;
                    bool _out1078;
                    bool _out1079;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1080;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1077, out _out1078, out _out1079, out _out1080);
                    _1736_recursiveGen = _out1077;
                    _1737_recOwned = _out1078;
                    _1738_recErased = _out1079;
                    _1739_recIdents = _out1080;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1736_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1737_recOwned;
                    isErased = _1738_recErased;
                    readIdents = _1739_recIdents;
                  }
                } else if (_source58.is_Primitive) {
                  DAST._IPrimitive _1740___mcc_h962 = _source58.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1741_recursiveGen;
                    bool _1742_recOwned;
                    bool _1743_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1744_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1081;
                    bool _out1082;
                    bool _out1083;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1084;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1081, out _out1082, out _out1083, out _out1084);
                    _1741_recursiveGen = _out1081;
                    _1742_recOwned = _out1082;
                    _1743_recErased = _out1083;
                    _1744_recIdents = _out1084;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1742_recOwned;
                    isErased = _1743_recErased;
                    readIdents = _1744_recIdents;
                  }
                } else if (_source58.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1745___mcc_h964 = _source58.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1746_recursiveGen;
                    bool _1747_recOwned;
                    bool _1748_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1749_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1085;
                    bool _out1086;
                    bool _out1087;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1088;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1085, out _out1086, out _out1087, out _out1088);
                    _1746_recursiveGen = _out1085;
                    _1747_recOwned = _out1086;
                    _1748_recErased = _out1087;
                    _1749_recIdents = _out1088;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1747_recOwned;
                    isErased = _1748_recErased;
                    readIdents = _1749_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1750___mcc_h966 = _source58.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1751_recursiveGen;
                    bool _1752_recOwned;
                    bool _1753_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1754_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1089;
                    bool _out1090;
                    bool _out1091;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1092;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1089, out _out1090, out _out1091, out _out1092);
                    _1751_recursiveGen = _out1089;
                    _1752_recOwned = _out1090;
                    _1753_recErased = _out1091;
                    _1754_recIdents = _out1092;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1751_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1752_recOwned;
                    isErased = _1753_recErased;
                    readIdents = _1754_recIdents;
                  }
                }
              } else if (_source51.is_Bool) {
                DAST._IType _source60 = _575___mcc_h293;
                if (_source60.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1755___mcc_h968 = _source60.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1756___mcc_h969 = _source60.dtor_typeArgs;
                  DAST._IResolvedType _1757___mcc_h970 = _source60.dtor_resolved;
                  DAST._IResolvedType _source61 = _1757___mcc_h970;
                  if (_source61.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1758___mcc_h974 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1759_recursiveGen;
                      bool _1760_recOwned;
                      bool _1761_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1762_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1093;
                      bool _out1094;
                      bool _out1095;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1096;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1093, out _out1094, out _out1095, out _out1096);
                      _1759_recursiveGen = _out1093;
                      _1760_recOwned = _out1094;
                      _1761_recErased = _out1095;
                      _1762_recIdents = _out1096;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1760_recOwned;
                      isErased = _1761_recErased;
                      readIdents = _1762_recIdents;
                    }
                  } else if (_source61.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1763___mcc_h976 = _source61.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1764_recursiveGen;
                      bool _1765_recOwned;
                      bool _1766_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1767_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1097;
                      bool _out1098;
                      bool _out1099;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                      _1764_recursiveGen = _out1097;
                      _1765_recOwned = _out1098;
                      _1766_recErased = _out1099;
                      _1767_recIdents = _out1100;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1764_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1765_recOwned;
                      isErased = _1766_recErased;
                      readIdents = _1767_recIdents;
                    }
                  } else {
                    DAST._IType _1768___mcc_h978 = _source61.dtor_Newtype_a0;
                    DAST._IType _1769_b = _1768___mcc_h978;
                    {
                      if (object.Equals(_568_fromTpe, _1769_b)) {
                        Dafny.ISequence<Dafny.Rune> _1770_recursiveGen;
                        bool _1771_recOwned;
                        bool _1772_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1773_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1101;
                        bool _out1102;
                        bool _out1103;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                        _1770_recursiveGen = _out1101;
                        _1771_recOwned = _out1102;
                        _1772_recErased = _out1103;
                        _1773_recIdents = _out1104;
                        Dafny.ISequence<Dafny.Rune> _1774_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1105;
                        _out1105 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _1774_rhsType = _out1105;
                        Dafny.ISequence<Dafny.Rune> _1775_uneraseFn;
                        _1775_uneraseFn = ((_1771_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1774_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1775_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1770_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1771_recOwned;
                        isErased = false;
                        readIdents = _1773_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1106;
                        bool _out1107;
                        bool _out1108;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1109;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1769_b), _1769_b, _567_toTpe), selfIdent, @params, mustOwn, out _out1106, out _out1107, out _out1108, out _out1109);
                        s = _out1106;
                        isOwned = _out1107;
                        isErased = _out1108;
                        readIdents = _out1109;
                      }
                    }
                  }
                } else if (_source60.is_Nullable) {
                  DAST._IType _1776___mcc_h980 = _source60.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1777_recursiveGen;
                    bool _1778_recOwned;
                    bool _1779_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1780_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1110;
                    bool _out1111;
                    bool _out1112;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1113;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1110, out _out1111, out _out1112, out _out1113);
                    _1777_recursiveGen = _out1110;
                    _1778_recOwned = _out1111;
                    _1779_recErased = _out1112;
                    _1780_recIdents = _out1113;
                    if (!(_1778_recOwned)) {
                      _1777_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1777_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1779_recErased;
                    readIdents = _1780_recIdents;
                  }
                } else if (_source60.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1781___mcc_h982 = _source60.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1782_recursiveGen;
                    bool _1783_recOwned;
                    bool _1784_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1785_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1114;
                    bool _out1115;
                    bool _out1116;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1117;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1114, out _out1115, out _out1116, out _out1117);
                    _1782_recursiveGen = _out1114;
                    _1783_recOwned = _out1115;
                    _1784_recErased = _out1116;
                    _1785_recIdents = _out1117;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1782_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1783_recOwned;
                    isErased = _1784_recErased;
                    readIdents = _1785_recIdents;
                  }
                } else if (_source60.is_Array) {
                  DAST._IType _1786___mcc_h984 = _source60.dtor_element;
                  BigInteger _1787___mcc_h985 = _source60.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1788_recursiveGen;
                    bool _1789_recOwned;
                    bool _1790_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1791_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1118;
                    bool _out1119;
                    bool _out1120;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1121;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1118, out _out1119, out _out1120, out _out1121);
                    _1788_recursiveGen = _out1118;
                    _1789_recOwned = _out1119;
                    _1790_recErased = _out1120;
                    _1791_recIdents = _out1121;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1788_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1789_recOwned;
                    isErased = _1790_recErased;
                    readIdents = _1791_recIdents;
                  }
                } else if (_source60.is_Seq) {
                  DAST._IType _1792___mcc_h988 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1793_recursiveGen;
                    bool _1794_recOwned;
                    bool _1795_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1796_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1122;
                    bool _out1123;
                    bool _out1124;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1125;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1122, out _out1123, out _out1124, out _out1125);
                    _1793_recursiveGen = _out1122;
                    _1794_recOwned = _out1123;
                    _1795_recErased = _out1124;
                    _1796_recIdents = _out1125;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1793_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1794_recOwned;
                    isErased = _1795_recErased;
                    readIdents = _1796_recIdents;
                  }
                } else if (_source60.is_Set) {
                  DAST._IType _1797___mcc_h990 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1798_recursiveGen;
                    bool _1799_recOwned;
                    bool _1800_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1801_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1126;
                    bool _out1127;
                    bool _out1128;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1129;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1126, out _out1127, out _out1128, out _out1129);
                    _1798_recursiveGen = _out1126;
                    _1799_recOwned = _out1127;
                    _1800_recErased = _out1128;
                    _1801_recIdents = _out1129;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1798_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1799_recOwned;
                    isErased = _1800_recErased;
                    readIdents = _1801_recIdents;
                  }
                } else if (_source60.is_Multiset) {
                  DAST._IType _1802___mcc_h992 = _source60.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1803_recursiveGen;
                    bool _1804_recOwned;
                    bool _1805_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1806_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1130;
                    bool _out1131;
                    bool _out1132;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1133;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1130, out _out1131, out _out1132, out _out1133);
                    _1803_recursiveGen = _out1130;
                    _1804_recOwned = _out1131;
                    _1805_recErased = _out1132;
                    _1806_recIdents = _out1133;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1803_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1804_recOwned;
                    isErased = _1805_recErased;
                    readIdents = _1806_recIdents;
                  }
                } else if (_source60.is_Map) {
                  DAST._IType _1807___mcc_h994 = _source60.dtor_key;
                  DAST._IType _1808___mcc_h995 = _source60.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1809_recursiveGen;
                    bool _1810_recOwned;
                    bool _1811_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1812_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1134;
                    bool _out1135;
                    bool _out1136;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1137;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1134, out _out1135, out _out1136, out _out1137);
                    _1809_recursiveGen = _out1134;
                    _1810_recOwned = _out1135;
                    _1811_recErased = _out1136;
                    _1812_recIdents = _out1137;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1809_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1810_recOwned;
                    isErased = _1811_recErased;
                    readIdents = _1812_recIdents;
                  }
                } else if (_source60.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1813___mcc_h998 = _source60.dtor_args;
                  DAST._IType _1814___mcc_h999 = _source60.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1815_recursiveGen;
                    bool _1816_recOwned;
                    bool _1817_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1818_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1138;
                    bool _out1139;
                    bool _out1140;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1141;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1138, out _out1139, out _out1140, out _out1141);
                    _1815_recursiveGen = _out1138;
                    _1816_recOwned = _out1139;
                    _1817_recErased = _out1140;
                    _1818_recIdents = _out1141;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1815_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1816_recOwned;
                    isErased = _1817_recErased;
                    readIdents = _1818_recIdents;
                  }
                } else if (_source60.is_Primitive) {
                  DAST._IPrimitive _1819___mcc_h1002 = _source60.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1820_recursiveGen;
                    bool _1821_recOwned;
                    bool _1822_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1823_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1142;
                    bool _out1143;
                    bool _out1144;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1145;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1142, out _out1143, out _out1144, out _out1145);
                    _1820_recursiveGen = _out1142;
                    _1821_recOwned = _out1143;
                    _1822_recErased = _out1144;
                    _1823_recIdents = _out1145;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1820_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1821_recOwned;
                    isErased = _1822_recErased;
                    readIdents = _1823_recIdents;
                  }
                } else if (_source60.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1824___mcc_h1004 = _source60.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1825_recursiveGen;
                    bool _1826_recOwned;
                    bool _1827_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1828_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1146;
                    bool _out1147;
                    bool _out1148;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1149;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1146, out _out1147, out _out1148, out _out1149);
                    _1825_recursiveGen = _out1146;
                    _1826_recOwned = _out1147;
                    _1827_recErased = _out1148;
                    _1828_recIdents = _out1149;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1825_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1826_recOwned;
                    isErased = _1827_recErased;
                    readIdents = _1828_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1829___mcc_h1006 = _source60.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1830_recursiveGen;
                    bool _1831_recOwned;
                    bool _1832_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1833_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1150;
                    bool _out1151;
                    bool _out1152;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1150, out _out1151, out _out1152, out _out1153);
                    _1830_recursiveGen = _out1150;
                    _1831_recOwned = _out1151;
                    _1832_recErased = _out1152;
                    _1833_recIdents = _out1153;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1830_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1831_recOwned;
                    isErased = _1832_recErased;
                    readIdents = _1833_recIdents;
                  }
                }
              } else {
                DAST._IType _source62 = _575___mcc_h293;
                if (_source62.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1834___mcc_h1008 = _source62.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1835___mcc_h1009 = _source62.dtor_typeArgs;
                  DAST._IResolvedType _1836___mcc_h1010 = _source62.dtor_resolved;
                  DAST._IResolvedType _source63 = _1836___mcc_h1010;
                  if (_source63.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1837___mcc_h1014 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1838_recursiveGen;
                      bool _1839_recOwned;
                      bool _1840_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1841_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1154;
                      bool _out1155;
                      bool _out1156;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                      _1838_recursiveGen = _out1154;
                      _1839_recOwned = _out1155;
                      _1840_recErased = _out1156;
                      _1841_recIdents = _out1157;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1838_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1839_recOwned;
                      isErased = _1840_recErased;
                      readIdents = _1841_recIdents;
                    }
                  } else if (_source63.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1842___mcc_h1016 = _source63.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1843_recursiveGen;
                      bool _1844_recOwned;
                      bool _1845_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1846_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1158;
                      bool _out1159;
                      bool _out1160;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                      _1843_recursiveGen = _out1158;
                      _1844_recOwned = _out1159;
                      _1845_recErased = _out1160;
                      _1846_recIdents = _out1161;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1843_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1844_recOwned;
                      isErased = _1845_recErased;
                      readIdents = _1846_recIdents;
                    }
                  } else {
                    DAST._IType _1847___mcc_h1018 = _source63.dtor_Newtype_a0;
                    DAST._IType _1848_b = _1847___mcc_h1018;
                    {
                      if (object.Equals(_568_fromTpe, _1848_b)) {
                        Dafny.ISequence<Dafny.Rune> _1849_recursiveGen;
                        bool _1850_recOwned;
                        bool _1851_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1852_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1162;
                        bool _out1163;
                        bool _out1164;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                        DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                        _1849_recursiveGen = _out1162;
                        _1850_recOwned = _out1163;
                        _1851_recErased = _out1164;
                        _1852_recIdents = _out1165;
                        Dafny.ISequence<Dafny.Rune> _1853_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1166;
                        _out1166 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                        _1853_rhsType = _out1166;
                        Dafny.ISequence<Dafny.Rune> _1854_uneraseFn;
                        _1854_uneraseFn = ((_1850_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1853_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1854_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1849_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1850_recOwned;
                        isErased = false;
                        readIdents = _1852_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1167;
                        bool _out1168;
                        bool _out1169;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1170;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1848_b), _1848_b, _567_toTpe), selfIdent, @params, mustOwn, out _out1167, out _out1168, out _out1169, out _out1170);
                        s = _out1167;
                        isOwned = _out1168;
                        isErased = _out1169;
                        readIdents = _out1170;
                      }
                    }
                  }
                } else if (_source62.is_Nullable) {
                  DAST._IType _1855___mcc_h1020 = _source62.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1856_recursiveGen;
                    bool _1857_recOwned;
                    bool _1858_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1859_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1171;
                    bool _out1172;
                    bool _out1173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1174;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1171, out _out1172, out _out1173, out _out1174);
                    _1856_recursiveGen = _out1171;
                    _1857_recOwned = _out1172;
                    _1858_recErased = _out1173;
                    _1859_recIdents = _out1174;
                    if (!(_1857_recOwned)) {
                      _1856_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1856_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1856_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1858_recErased;
                    readIdents = _1859_recIdents;
                  }
                } else if (_source62.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1860___mcc_h1022 = _source62.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1861_recursiveGen;
                    bool _1862_recOwned;
                    bool _1863_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1864_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1175;
                    bool _out1176;
                    bool _out1177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1178;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1175, out _out1176, out _out1177, out _out1178);
                    _1861_recursiveGen = _out1175;
                    _1862_recOwned = _out1176;
                    _1863_recErased = _out1177;
                    _1864_recIdents = _out1178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1861_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1862_recOwned;
                    isErased = _1863_recErased;
                    readIdents = _1864_recIdents;
                  }
                } else if (_source62.is_Array) {
                  DAST._IType _1865___mcc_h1024 = _source62.dtor_element;
                  BigInteger _1866___mcc_h1025 = _source62.dtor_dims;
                  {
                    Dafny.ISequence<Dafny.Rune> _1867_recursiveGen;
                    bool _1868_recOwned;
                    bool _1869_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1870_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1179;
                    bool _out1180;
                    bool _out1181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1182;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1179, out _out1180, out _out1181, out _out1182);
                    _1867_recursiveGen = _out1179;
                    _1868_recOwned = _out1180;
                    _1869_recErased = _out1181;
                    _1870_recIdents = _out1182;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1867_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1868_recOwned;
                    isErased = _1869_recErased;
                    readIdents = _1870_recIdents;
                  }
                } else if (_source62.is_Seq) {
                  DAST._IType _1871___mcc_h1028 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1872_recursiveGen;
                    bool _1873_recOwned;
                    bool _1874_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1875_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1183;
                    bool _out1184;
                    bool _out1185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1186;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1183, out _out1184, out _out1185, out _out1186);
                    _1872_recursiveGen = _out1183;
                    _1873_recOwned = _out1184;
                    _1874_recErased = _out1185;
                    _1875_recIdents = _out1186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1872_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1873_recOwned;
                    isErased = _1874_recErased;
                    readIdents = _1875_recIdents;
                  }
                } else if (_source62.is_Set) {
                  DAST._IType _1876___mcc_h1030 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1877_recursiveGen;
                    bool _1878_recOwned;
                    bool _1879_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1880_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1187;
                    bool _out1188;
                    bool _out1189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1190;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1187, out _out1188, out _out1189, out _out1190);
                    _1877_recursiveGen = _out1187;
                    _1878_recOwned = _out1188;
                    _1879_recErased = _out1189;
                    _1880_recIdents = _out1190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1877_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1878_recOwned;
                    isErased = _1879_recErased;
                    readIdents = _1880_recIdents;
                  }
                } else if (_source62.is_Multiset) {
                  DAST._IType _1881___mcc_h1032 = _source62.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1882_recursiveGen;
                    bool _1883_recOwned;
                    bool _1884_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1885_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1191;
                    bool _out1192;
                    bool _out1193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1194;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1191, out _out1192, out _out1193, out _out1194);
                    _1882_recursiveGen = _out1191;
                    _1883_recOwned = _out1192;
                    _1884_recErased = _out1193;
                    _1885_recIdents = _out1194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1882_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1883_recOwned;
                    isErased = _1884_recErased;
                    readIdents = _1885_recIdents;
                  }
                } else if (_source62.is_Map) {
                  DAST._IType _1886___mcc_h1034 = _source62.dtor_key;
                  DAST._IType _1887___mcc_h1035 = _source62.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1888_recursiveGen;
                    bool _1889_recOwned;
                    bool _1890_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1891_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1195;
                    bool _out1196;
                    bool _out1197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1195, out _out1196, out _out1197, out _out1198);
                    _1888_recursiveGen = _out1195;
                    _1889_recOwned = _out1196;
                    _1890_recErased = _out1197;
                    _1891_recIdents = _out1198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1888_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1889_recOwned;
                    isErased = _1890_recErased;
                    readIdents = _1891_recIdents;
                  }
                } else if (_source62.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1892___mcc_h1038 = _source62.dtor_args;
                  DAST._IType _1893___mcc_h1039 = _source62.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1894_recursiveGen;
                    bool _1895_recOwned;
                    bool _1896_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1897_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1199;
                    bool _out1200;
                    bool _out1201;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                    _1894_recursiveGen = _out1199;
                    _1895_recOwned = _out1200;
                    _1896_recErased = _out1201;
                    _1897_recIdents = _out1202;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1894_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1895_recOwned;
                    isErased = _1896_recErased;
                    readIdents = _1897_recIdents;
                  }
                } else if (_source62.is_Primitive) {
                  DAST._IPrimitive _1898___mcc_h1042 = _source62.dtor_Primitive_a0;
                  DAST._IPrimitive _source64 = _1898___mcc_h1042;
                  if (_source64.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1899_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      _out1203 = DCOMP.COMP.GenType(_568_fromTpe, true, false);
                      _1899_rhsType = _out1203;
                      Dafny.ISequence<Dafny.Rune> _1900_recursiveGen;
                      bool _1901___v60;
                      bool _1902___v61;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1903_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1204;
                      bool _out1205;
                      bool _out1206;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1207;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, true, out _out1204, out _out1205, out _out1206, out _out1207);
                      _1900_recursiveGen = _out1204;
                      _1901___v60 = _out1205;
                      _1902___v61 = _out1206;
                      _1903_recIdents = _out1207;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1900_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1903_recIdents;
                    }
                  } else if (_source64.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1904_recursiveGen;
                      bool _1905_recOwned;
                      bool _1906_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1907_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1208;
                      bool _out1209;
                      bool _out1210;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1211;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1208, out _out1209, out _out1210, out _out1211);
                      _1904_recursiveGen = _out1208;
                      _1905_recOwned = _out1209;
                      _1906_recErased = _out1210;
                      _1907_recIdents = _out1211;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1904_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1905_recOwned;
                      isErased = _1906_recErased;
                      readIdents = _1907_recIdents;
                    }
                  } else if (_source64.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1908_recursiveGen;
                      bool _1909_recOwned;
                      bool _1910_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1911_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1212;
                      bool _out1213;
                      bool _out1214;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1215;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1212, out _out1213, out _out1214, out _out1215);
                      _1908_recursiveGen = _out1212;
                      _1909_recOwned = _out1213;
                      _1910_recErased = _out1214;
                      _1911_recIdents = _out1215;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1908_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1909_recOwned;
                      isErased = _1910_recErased;
                      readIdents = _1911_recIdents;
                    }
                  } else if (_source64.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1912_recursiveGen;
                      bool _1913_recOwned;
                      bool _1914_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1915_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1216;
                      bool _out1217;
                      bool _out1218;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1219;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1216, out _out1217, out _out1218, out _out1219);
                      _1912_recursiveGen = _out1216;
                      _1913_recOwned = _out1217;
                      _1914_recErased = _out1218;
                      _1915_recIdents = _out1219;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1913_recOwned;
                      isErased = _1914_recErased;
                      readIdents = _1915_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1916_recursiveGen;
                      bool _1917_recOwned;
                      bool _1918_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1919_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1220;
                      bool _out1221;
                      bool _out1222;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1223;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1220, out _out1221, out _out1222, out _out1223);
                      _1916_recursiveGen = _out1220;
                      _1917_recOwned = _out1221;
                      _1918_recErased = _out1222;
                      _1919_recIdents = _out1223;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1916_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1917_recOwned;
                      isErased = _1918_recErased;
                      readIdents = _1919_recIdents;
                    }
                  }
                } else if (_source62.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1920___mcc_h1044 = _source62.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1921_recursiveGen;
                    bool _1922_recOwned;
                    bool _1923_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1924_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1224;
                    bool _out1225;
                    bool _out1226;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1227;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1224, out _out1225, out _out1226, out _out1227);
                    _1921_recursiveGen = _out1224;
                    _1922_recOwned = _out1225;
                    _1923_recErased = _out1226;
                    _1924_recIdents = _out1227;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1921_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1922_recOwned;
                    isErased = _1923_recErased;
                    readIdents = _1924_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1925___mcc_h1046 = _source62.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1926_recursiveGen;
                    bool _1927_recOwned;
                    bool _1928_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1929_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1228;
                    bool _out1229;
                    bool _out1230;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1228, out _out1229, out _out1230, out _out1231);
                    _1926_recursiveGen = _out1228;
                    _1927_recOwned = _out1229;
                    _1928_recErased = _out1230;
                    _1929_recIdents = _out1231;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1926_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1927_recOwned;
                    isErased = _1928_recErased;
                    readIdents = _1929_recIdents;
                  }
                }
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1930___mcc_h1048 = _source27.dtor_Passthrough_a0;
              DAST._IType _source65 = _575___mcc_h293;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1931___mcc_h1052 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1932___mcc_h1053 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1933___mcc_h1054 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1933___mcc_h1054;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1934___mcc_h1058 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1935_recursiveGen;
                    bool _1936_recOwned;
                    bool _1937_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1938_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1232;
                    bool _out1233;
                    bool _out1234;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1232, out _out1233, out _out1234, out _out1235);
                    _1935_recursiveGen = _out1232;
                    _1936_recOwned = _out1233;
                    _1937_recErased = _out1234;
                    _1938_recIdents = _out1235;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1936_recOwned;
                    isErased = _1937_recErased;
                    readIdents = _1938_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1939___mcc_h1060 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1940_recursiveGen;
                    bool _1941_recOwned;
                    bool _1942_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1943_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1236;
                    bool _out1237;
                    bool _out1238;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                    _1940_recursiveGen = _out1236;
                    _1941_recOwned = _out1237;
                    _1942_recErased = _out1238;
                    _1943_recIdents = _out1239;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1941_recOwned;
                    isErased = _1942_recErased;
                    readIdents = _1943_recIdents;
                  }
                } else {
                  DAST._IType _1944___mcc_h1062 = _source66.dtor_Newtype_a0;
                  DAST._IType _1945_b = _1944___mcc_h1062;
                  {
                    if (object.Equals(_568_fromTpe, _1945_b)) {
                      Dafny.ISequence<Dafny.Rune> _1946_recursiveGen;
                      bool _1947_recOwned;
                      bool _1948_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1949_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1240;
                      bool _out1241;
                      bool _out1242;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                      _1946_recursiveGen = _out1240;
                      _1947_recOwned = _out1241;
                      _1948_recErased = _out1242;
                      _1949_recIdents = _out1243;
                      Dafny.ISequence<Dafny.Rune> _1950_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1244;
                      _out1244 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _1950_rhsType = _out1244;
                      Dafny.ISequence<Dafny.Rune> _1951_uneraseFn;
                      _1951_uneraseFn = ((_1947_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1950_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1951_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1946_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1947_recOwned;
                      isErased = false;
                      readIdents = _1949_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1245;
                      bool _out1246;
                      bool _out1247;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1248;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _1945_b), _1945_b, _567_toTpe), selfIdent, @params, mustOwn, out _out1245, out _out1246, out _out1247, out _out1248);
                      s = _out1245;
                      isOwned = _out1246;
                      isErased = _out1247;
                      readIdents = _out1248;
                    }
                  }
                }
              } else if (_source65.is_Nullable) {
                DAST._IType _1952___mcc_h1064 = _source65.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1953_recursiveGen;
                  bool _1954_recOwned;
                  bool _1955_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1956_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1249;
                  bool _out1250;
                  bool _out1251;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1252;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1249, out _out1250, out _out1251, out _out1252);
                  _1953_recursiveGen = _out1249;
                  _1954_recOwned = _out1250;
                  _1955_recErased = _out1251;
                  _1956_recIdents = _out1252;
                  if (!(_1954_recOwned)) {
                    _1953_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1953_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1953_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1955_recErased;
                  readIdents = _1956_recIdents;
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1957___mcc_h1066 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1958_recursiveGen;
                  bool _1959_recOwned;
                  bool _1960_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1961_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1253;
                  bool _out1254;
                  bool _out1255;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1256;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1253, out _out1254, out _out1255, out _out1256);
                  _1958_recursiveGen = _out1253;
                  _1959_recOwned = _out1254;
                  _1960_recErased = _out1255;
                  _1961_recIdents = _out1256;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1958_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1959_recOwned;
                  isErased = _1960_recErased;
                  readIdents = _1961_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1962___mcc_h1068 = _source65.dtor_element;
                BigInteger _1963___mcc_h1069 = _source65.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _1964_recursiveGen;
                  bool _1965_recOwned;
                  bool _1966_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1967_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1257;
                  bool _out1258;
                  bool _out1259;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1260;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1257, out _out1258, out _out1259, out _out1260);
                  _1964_recursiveGen = _out1257;
                  _1965_recOwned = _out1258;
                  _1966_recErased = _out1259;
                  _1967_recIdents = _out1260;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1964_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1965_recOwned;
                  isErased = _1966_recErased;
                  readIdents = _1967_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1968___mcc_h1072 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1969_recursiveGen;
                  bool _1970_recOwned;
                  bool _1971_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1972_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1261;
                  bool _out1262;
                  bool _out1263;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1264;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1261, out _out1262, out _out1263, out _out1264);
                  _1969_recursiveGen = _out1261;
                  _1970_recOwned = _out1262;
                  _1971_recErased = _out1263;
                  _1972_recIdents = _out1264;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1970_recOwned;
                  isErased = _1971_recErased;
                  readIdents = _1972_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1973___mcc_h1074 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1974_recursiveGen;
                  bool _1975_recOwned;
                  bool _1976_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1977_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1265;
                  bool _out1266;
                  bool _out1267;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1268;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1265, out _out1266, out _out1267, out _out1268);
                  _1974_recursiveGen = _out1265;
                  _1975_recOwned = _out1266;
                  _1976_recErased = _out1267;
                  _1977_recIdents = _out1268;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1974_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1975_recOwned;
                  isErased = _1976_recErased;
                  readIdents = _1977_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1978___mcc_h1076 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1979_recursiveGen;
                  bool _1980_recOwned;
                  bool _1981_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1982_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1269;
                  bool _out1270;
                  bool _out1271;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1272;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1269, out _out1270, out _out1271, out _out1272);
                  _1979_recursiveGen = _out1269;
                  _1980_recOwned = _out1270;
                  _1981_recErased = _out1271;
                  _1982_recIdents = _out1272;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1979_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1980_recOwned;
                  isErased = _1981_recErased;
                  readIdents = _1982_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1983___mcc_h1078 = _source65.dtor_key;
                DAST._IType _1984___mcc_h1079 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1985_recursiveGen;
                  bool _1986_recOwned;
                  bool _1987_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1988_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1273;
                  bool _out1274;
                  bool _out1275;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1273, out _out1274, out _out1275, out _out1276);
                  _1985_recursiveGen = _out1273;
                  _1986_recOwned = _out1274;
                  _1987_recErased = _out1275;
                  _1988_recIdents = _out1276;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1985_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1986_recOwned;
                  isErased = _1987_recErased;
                  readIdents = _1988_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1989___mcc_h1082 = _source65.dtor_args;
                DAST._IType _1990___mcc_h1083 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1991_recursiveGen;
                  bool _1992_recOwned;
                  bool _1993_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1994_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1277;
                  bool _out1278;
                  bool _out1279;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                  _1991_recursiveGen = _out1277;
                  _1992_recOwned = _out1278;
                  _1993_recErased = _out1279;
                  _1994_recIdents = _out1280;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1992_recOwned;
                  isErased = _1993_recErased;
                  readIdents = _1994_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1995___mcc_h1086 = _source65.dtor_Primitive_a0;
                DAST._IPrimitive _source67 = _1995___mcc_h1086;
                if (_source67.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1996_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    _out1281 = DCOMP.COMP.GenType(_568_fromTpe, true, false);
                    _1996_rhsType = _out1281;
                    Dafny.ISequence<Dafny.Rune> _1997_recursiveGen;
                    bool _1998___v56;
                    bool _1999___v57;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2000_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1282;
                    bool _out1283;
                    bool _out1284;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1285;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, true, out _out1282, out _out1283, out _out1284, out _out1285);
                    _1997_recursiveGen = _out1282;
                    _1998___v56 = _out1283;
                    _1999___v57 = _out1284;
                    _2000_recIdents = _out1285;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1997_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _2000_recIdents;
                  }
                } else if (_source67.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _2001_recursiveGen;
                    bool _2002_recOwned;
                    bool _2003_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2004_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1286;
                    bool _out1287;
                    bool _out1288;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1289;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1286, out _out1287, out _out1288, out _out1289);
                    _2001_recursiveGen = _out1286;
                    _2002_recOwned = _out1287;
                    _2003_recErased = _out1288;
                    _2004_recIdents = _out1289;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2001_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2002_recOwned;
                    isErased = _2003_recErased;
                    readIdents = _2004_recIdents;
                  }
                } else if (_source67.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _2005_recursiveGen;
                    bool _2006_recOwned;
                    bool _2007_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2008_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1290;
                    bool _out1291;
                    bool _out1292;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1293;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1290, out _out1291, out _out1292, out _out1293);
                    _2005_recursiveGen = _out1290;
                    _2006_recOwned = _out1291;
                    _2007_recErased = _out1292;
                    _2008_recIdents = _out1293;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2005_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2006_recOwned;
                    isErased = _2007_recErased;
                    readIdents = _2008_recIdents;
                  }
                } else if (_source67.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _2009_recursiveGen;
                    bool _2010_recOwned;
                    bool _2011_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2012_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1294;
                    bool _out1295;
                    bool _out1296;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1297;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1294, out _out1295, out _out1296, out _out1297);
                    _2009_recursiveGen = _out1294;
                    _2010_recOwned = _out1295;
                    _2011_recErased = _out1296;
                    _2012_recIdents = _out1297;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2010_recOwned;
                    isErased = _2011_recErased;
                    readIdents = _2012_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _2013_recursiveGen;
                    bool _2014_recOwned;
                    bool _2015_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2016_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1298;
                    bool _out1299;
                    bool _out1300;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                    _2013_recursiveGen = _out1298;
                    _2014_recOwned = _out1299;
                    _2015_recErased = _out1300;
                    _2016_recIdents = _out1301;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2013_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2014_recOwned;
                    isErased = _2015_recErased;
                    readIdents = _2016_recIdents;
                  }
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2017___mcc_h1088 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2018_recursiveGen;
                  bool _2019___v64;
                  bool _2020___v65;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2021_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1302;
                  bool _out1303;
                  bool _out1304;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, true, out _out1302, out _out1303, out _out1304, out _out1305);
                  _2018_recursiveGen = _out1302;
                  _2019___v64 = _out1303;
                  _2020___v65 = _out1304;
                  _2021_recIdents = _out1305;
                  Dafny.ISequence<Dafny.Rune> _2022_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1306;
                  _out1306 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                  _2022_toTpeGen = _out1306;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2018_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _2022_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _2021_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2023___mcc_h1090 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2024_recursiveGen;
                  bool _2025_recOwned;
                  bool _2026_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2027_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1307;
                  bool _out1308;
                  bool _out1309;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1310;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1307, out _out1308, out _out1309, out _out1310);
                  _2024_recursiveGen = _out1307;
                  _2025_recOwned = _out1308;
                  _2026_recErased = _out1309;
                  _2027_recIdents = _out1310;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2024_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2025_recOwned;
                  isErased = _2026_recErased;
                  readIdents = _2027_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _2028___mcc_h1092 = _source27.dtor_TypeArg_a0;
              DAST._IType _source68 = _575___mcc_h293;
              if (_source68.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2029___mcc_h1096 = _source68.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _2030___mcc_h1097 = _source68.dtor_typeArgs;
                DAST._IResolvedType _2031___mcc_h1098 = _source68.dtor_resolved;
                DAST._IResolvedType _source69 = _2031___mcc_h1098;
                if (_source69.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2032___mcc_h1102 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2033_recursiveGen;
                    bool _2034_recOwned;
                    bool _2035_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2036_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1311;
                    bool _out1312;
                    bool _out1313;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1314;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1311, out _out1312, out _out1313, out _out1314);
                    _2033_recursiveGen = _out1311;
                    _2034_recOwned = _out1312;
                    _2035_recErased = _out1313;
                    _2036_recIdents = _out1314;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2033_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2034_recOwned;
                    isErased = _2035_recErased;
                    readIdents = _2036_recIdents;
                  }
                } else if (_source69.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2037___mcc_h1104 = _source69.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2038_recursiveGen;
                    bool _2039_recOwned;
                    bool _2040_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2041_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1315;
                    bool _out1316;
                    bool _out1317;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                    DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                    _2038_recursiveGen = _out1315;
                    _2039_recOwned = _out1316;
                    _2040_recErased = _out1317;
                    _2041_recIdents = _out1318;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2038_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2039_recOwned;
                    isErased = _2040_recErased;
                    readIdents = _2041_recIdents;
                  }
                } else {
                  DAST._IType _2042___mcc_h1106 = _source69.dtor_Newtype_a0;
                  DAST._IType _2043_b = _2042___mcc_h1106;
                  {
                    if (object.Equals(_568_fromTpe, _2043_b)) {
                      Dafny.ISequence<Dafny.Rune> _2044_recursiveGen;
                      bool _2045_recOwned;
                      bool _2046_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2047_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1319;
                      bool _out1320;
                      bool _out1321;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                      DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                      _2044_recursiveGen = _out1319;
                      _2045_recOwned = _out1320;
                      _2046_recErased = _out1321;
                      _2047_recIdents = _out1322;
                      Dafny.ISequence<Dafny.Rune> _2048_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1323;
                      _out1323 = DCOMP.COMP.GenType(_567_toTpe, true, false);
                      _2048_rhsType = _out1323;
                      Dafny.ISequence<Dafny.Rune> _2049_uneraseFn;
                      _2049_uneraseFn = ((_2045_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2048_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _2049_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2044_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _2045_recOwned;
                      isErased = false;
                      readIdents = _2047_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1324;
                      bool _out1325;
                      bool _out1326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_569_expr, _568_fromTpe, _2043_b), _2043_b, _567_toTpe), selfIdent, @params, mustOwn, out _out1324, out _out1325, out _out1326, out _out1327);
                      s = _out1324;
                      isOwned = _out1325;
                      isErased = _out1326;
                      readIdents = _out1327;
                    }
                  }
                }
              } else if (_source68.is_Nullable) {
                DAST._IType _2050___mcc_h1108 = _source68.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2051_recursiveGen;
                  bool _2052_recOwned;
                  bool _2053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1328;
                  bool _out1329;
                  bool _out1330;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1331;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1328, out _out1329, out _out1330, out _out1331);
                  _2051_recursiveGen = _out1328;
                  _2052_recOwned = _out1329;
                  _2053_recErased = _out1330;
                  _2054_recIdents = _out1331;
                  if (!(_2052_recOwned)) {
                    _2051_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_2051_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _2051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _2053_recErased;
                  readIdents = _2054_recIdents;
                }
              } else if (_source68.is_Tuple) {
                Dafny.ISequence<DAST._IType> _2055___mcc_h1110 = _source68.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2056_recursiveGen;
                  bool _2057_recOwned;
                  bool _2058_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2059_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1332;
                  bool _out1333;
                  bool _out1334;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1335;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1332, out _out1333, out _out1334, out _out1335);
                  _2056_recursiveGen = _out1332;
                  _2057_recOwned = _out1333;
                  _2058_recErased = _out1334;
                  _2059_recIdents = _out1335;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2056_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2057_recOwned;
                  isErased = _2058_recErased;
                  readIdents = _2059_recIdents;
                }
              } else if (_source68.is_Array) {
                DAST._IType _2060___mcc_h1112 = _source68.dtor_element;
                BigInteger _2061___mcc_h1113 = _source68.dtor_dims;
                {
                  Dafny.ISequence<Dafny.Rune> _2062_recursiveGen;
                  bool _2063_recOwned;
                  bool _2064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1336;
                  bool _out1337;
                  bool _out1338;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1339;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1336, out _out1337, out _out1338, out _out1339);
                  _2062_recursiveGen = _out1336;
                  _2063_recOwned = _out1337;
                  _2064_recErased = _out1338;
                  _2065_recIdents = _out1339;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2063_recOwned;
                  isErased = _2064_recErased;
                  readIdents = _2065_recIdents;
                }
              } else if (_source68.is_Seq) {
                DAST._IType _2066___mcc_h1116 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2067_recursiveGen;
                  bool _2068_recOwned;
                  bool _2069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1340;
                  bool _out1341;
                  bool _out1342;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1343;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1340, out _out1341, out _out1342, out _out1343);
                  _2067_recursiveGen = _out1340;
                  _2068_recOwned = _out1341;
                  _2069_recErased = _out1342;
                  _2070_recIdents = _out1343;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2068_recOwned;
                  isErased = _2069_recErased;
                  readIdents = _2070_recIdents;
                }
              } else if (_source68.is_Set) {
                DAST._IType _2071___mcc_h1118 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2072_recursiveGen;
                  bool _2073_recOwned;
                  bool _2074_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2075_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1344;
                  bool _out1345;
                  bool _out1346;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1347;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1344, out _out1345, out _out1346, out _out1347);
                  _2072_recursiveGen = _out1344;
                  _2073_recOwned = _out1345;
                  _2074_recErased = _out1346;
                  _2075_recIdents = _out1347;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2073_recOwned;
                  isErased = _2074_recErased;
                  readIdents = _2075_recIdents;
                }
              } else if (_source68.is_Multiset) {
                DAST._IType _2076___mcc_h1120 = _source68.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2077_recursiveGen;
                  bool _2078_recOwned;
                  bool _2079_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2080_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1348;
                  bool _out1349;
                  bool _out1350;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1351;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1348, out _out1349, out _out1350, out _out1351);
                  _2077_recursiveGen = _out1348;
                  _2078_recOwned = _out1349;
                  _2079_recErased = _out1350;
                  _2080_recIdents = _out1351;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2077_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2078_recOwned;
                  isErased = _2079_recErased;
                  readIdents = _2080_recIdents;
                }
              } else if (_source68.is_Map) {
                DAST._IType _2081___mcc_h1122 = _source68.dtor_key;
                DAST._IType _2082___mcc_h1123 = _source68.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2083_recursiveGen;
                  bool _2084_recOwned;
                  bool _2085_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2086_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1352;
                  bool _out1353;
                  bool _out1354;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1355;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1352, out _out1353, out _out1354, out _out1355);
                  _2083_recursiveGen = _out1352;
                  _2084_recOwned = _out1353;
                  _2085_recErased = _out1354;
                  _2086_recIdents = _out1355;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2084_recOwned;
                  isErased = _2085_recErased;
                  readIdents = _2086_recIdents;
                }
              } else if (_source68.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2087___mcc_h1126 = _source68.dtor_args;
                DAST._IType _2088___mcc_h1127 = _source68.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2089_recursiveGen;
                  bool _2090_recOwned;
                  bool _2091_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2092_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1356;
                  bool _out1357;
                  bool _out1358;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1359;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1356, out _out1357, out _out1358, out _out1359);
                  _2089_recursiveGen = _out1356;
                  _2090_recOwned = _out1357;
                  _2091_recErased = _out1358;
                  _2092_recIdents = _out1359;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2089_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2090_recOwned;
                  isErased = _2091_recErased;
                  readIdents = _2092_recIdents;
                }
              } else if (_source68.is_Primitive) {
                DAST._IPrimitive _2093___mcc_h1130 = _source68.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2094_recursiveGen;
                  bool _2095_recOwned;
                  bool _2096_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2097_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1360;
                  bool _out1361;
                  bool _out1362;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1363;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1360, out _out1361, out _out1362, out _out1363);
                  _2094_recursiveGen = _out1360;
                  _2095_recOwned = _out1361;
                  _2096_recErased = _out1362;
                  _2097_recIdents = _out1363;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2094_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2095_recOwned;
                  isErased = _2096_recErased;
                  readIdents = _2097_recIdents;
                }
              } else if (_source68.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2098___mcc_h1132 = _source68.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2099_recursiveGen;
                  bool _2100_recOwned;
                  bool _2101_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2102_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1364;
                  bool _out1365;
                  bool _out1366;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1367;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1364, out _out1365, out _out1366, out _out1367);
                  _2099_recursiveGen = _out1364;
                  _2100_recOwned = _out1365;
                  _2101_recErased = _out1366;
                  _2102_recIdents = _out1367;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2099_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2100_recOwned;
                  isErased = _2101_recErased;
                  readIdents = _2102_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2103___mcc_h1134 = _source68.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2104_recursiveGen;
                  bool _2105_recOwned;
                  bool _2106_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2107_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1368;
                  bool _out1369;
                  bool _out1370;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1371;
                  DCOMP.COMP.GenExpr(_569_expr, selfIdent, @params, mustOwn, out _out1368, out _out1369, out _out1370, out _out1371);
                  _2104_recursiveGen = _out1368;
                  _2105_recOwned = _out1369;
                  _2106_recErased = _out1370;
                  _2107_recIdents = _out1371;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2104_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2105_recOwned;
                  isErased = _2106_recErased;
                  readIdents = _2107_recIdents;
                }
              }
            }
          }
        }
      } else if (_source20.is_SeqConstruct) {
        DAST._IExpression _2108___mcc_h22 = _source20.dtor_length;
        DAST._IExpression _2109___mcc_h23 = _source20.dtor_elem;
        DAST._IExpression _2110_expr = _2109___mcc_h23;
        DAST._IExpression _2111_length = _2108___mcc_h22;
        {
          Dafny.ISequence<Dafny.Rune> _2112_recursiveGen;
          bool _2113___v67;
          bool _2114_eErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2115_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1372;
          bool _out1373;
          bool _out1374;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1375;
          DCOMP.COMP.GenExpr(_2110_expr, selfIdent, @params, true, out _out1372, out _out1373, out _out1374, out _out1375);
          _2112_recursiveGen = _out1372;
          _2113___v67 = _out1373;
          _2114_eErased = _out1374;
          _2115_recIdents = _out1375;
          Dafny.ISequence<Dafny.Rune> _2116_lengthGen;
          bool _2117___v68;
          bool _2118_lengthErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2119_lengthIdents;
          Dafny.ISequence<Dafny.Rune> _out1376;
          bool _out1377;
          bool _out1378;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1379;
          DCOMP.COMP.GenExpr(_2111_length, selfIdent, @params, true, out _out1376, out _out1377, out _out1378, out _out1379);
          _2116_lengthGen = _out1376;
          _2117___v68 = _out1377;
          _2118_lengthErased = _out1378;
          _2119_lengthIdents = _out1379;
          if (!(_2118_lengthErased)) {
            _2116_lengthGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2116_lengthGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet _initializer = "), _2112_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n::dafny_runtime::integer_range(::dafny_runtime::Zero::zero(), ")), _2116_lengthGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").map(|i| _initializer.0(&i)).collect::<Vec<_>>()\n}"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2115_recIdents, _2119_lengthIdents);
          isOwned = true;
          isErased = _2114_eErased;
        }
      } else if (_source20.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2120___mcc_h24 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2121_exprs = _2120___mcc_h24;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2122_generatedValues;
          _2122_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2123_i;
          _2123_i = BigInteger.Zero;
          bool _2124_allErased;
          _2124_allErased = true;
          while ((_2123_i) < (new BigInteger((_2121_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2125_recursiveGen;
            bool _2126___v69;
            bool _2127_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2128_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1380;
            bool _out1381;
            bool _out1382;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1383;
            DCOMP.COMP.GenExpr((_2121_exprs).Select(_2123_i), selfIdent, @params, true, out _out1380, out _out1381, out _out1382, out _out1383);
            _2125_recursiveGen = _out1380;
            _2126___v69 = _out1381;
            _2127_isErased = _out1382;
            _2128_recIdents = _out1383;
            _2124_allErased = (_2124_allErased) && (_2127_isErased);
            _2122_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2122_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2125_recursiveGen, _2127_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2128_recIdents);
            _2123_i = (_2123_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2123_i = BigInteger.Zero;
          while ((_2123_i) < (new BigInteger((_2122_generatedValues).Count))) {
            if ((_2123_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2129_gen;
            _2129_gen = ((_2122_generatedValues).Select(_2123_i)).dtor__0;
            if ((((_2122_generatedValues).Select(_2123_i)).dtor__1) && (!(_2124_allErased))) {
              _2129_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2129_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2129_gen);
            _2123_i = (_2123_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2124_allErased;
        }
      } else if (_source20.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2130___mcc_h25 = _source20.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2131_exprs = _2130___mcc_h25;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2132_generatedValues;
          _2132_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2133_i;
          _2133_i = BigInteger.Zero;
          bool _2134_allErased;
          _2134_allErased = true;
          while ((_2133_i) < (new BigInteger((_2131_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2135_recursiveGen;
            bool _2136___v70;
            bool _2137_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2138_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1384;
            bool _out1385;
            bool _out1386;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1387;
            DCOMP.COMP.GenExpr((_2131_exprs).Select(_2133_i), selfIdent, @params, true, out _out1384, out _out1385, out _out1386, out _out1387);
            _2135_recursiveGen = _out1384;
            _2136___v70 = _out1385;
            _2137_isErased = _out1386;
            _2138_recIdents = _out1387;
            _2134_allErased = (_2134_allErased) && (_2137_isErased);
            _2132_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2132_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2135_recursiveGen, _2137_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2138_recIdents);
            _2133_i = (_2133_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2133_i = BigInteger.Zero;
          while ((_2133_i) < (new BigInteger((_2132_generatedValues).Count))) {
            if ((_2133_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2139_gen;
            _2139_gen = ((_2132_generatedValues).Select(_2133_i)).dtor__0;
            if ((((_2132_generatedValues).Select(_2133_i)).dtor__1) && (!(_2134_allErased))) {
              _2139_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2139_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2139_gen);
            _2133_i = (_2133_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = _2134_allErased;
        }
      } else if (_source20.is_MapValue) {
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2140___mcc_h26 = _source20.dtor_mapElems;
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2141_mapElems = _2140___mcc_h26;
        {
          Dafny.ISequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>> _2142_generatedValues;
          _2142_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2143_i;
          _2143_i = BigInteger.Zero;
          bool _2144_allErased;
          _2144_allErased = true;
          while ((_2143_i) < (new BigInteger((_2141_mapElems).Count))) {
            Dafny.ISequence<Dafny.Rune> _2145_recursiveGenKey;
            bool _2146___v71;
            bool _2147_isErasedKey;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2148_recIdentsKey;
            Dafny.ISequence<Dafny.Rune> _out1388;
            bool _out1389;
            bool _out1390;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1391;
            DCOMP.COMP.GenExpr(((_2141_mapElems).Select(_2143_i)).dtor__0, selfIdent, @params, true, out _out1388, out _out1389, out _out1390, out _out1391);
            _2145_recursiveGenKey = _out1388;
            _2146___v71 = _out1389;
            _2147_isErasedKey = _out1390;
            _2148_recIdentsKey = _out1391;
            Dafny.ISequence<Dafny.Rune> _2149_recursiveGenValue;
            bool _2150___v72;
            bool _2151_isErasedValue;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2152_recIdentsValue;
            Dafny.ISequence<Dafny.Rune> _out1392;
            bool _out1393;
            bool _out1394;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1395;
            DCOMP.COMP.GenExpr(((_2141_mapElems).Select(_2143_i)).dtor__1, selfIdent, @params, true, out _out1392, out _out1393, out _out1394, out _out1395);
            _2149_recursiveGenValue = _out1392;
            _2150___v72 = _out1393;
            _2151_isErasedValue = _out1394;
            _2152_recIdentsValue = _out1395;
            _2144_allErased = ((_2144_allErased) && (_2147_isErasedKey)) && (_2151_isErasedValue);
            _2142_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.Concat(_2142_generatedValues, Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements(_System.Tuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>.create(_2145_recursiveGenKey, _2149_recursiveGenValue, _2147_isErasedKey, _2151_isErasedValue)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2148_recIdentsKey), _2152_recIdentsValue);
            _2143_i = (_2143_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2143_i = BigInteger.Zero;
          while ((_2143_i) < (new BigInteger((_2142_generatedValues).Count))) {
            if ((_2143_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2153_genKey;
            _2153_genKey = ((_2142_generatedValues).Select(_2143_i)).dtor__0;
            Dafny.ISequence<Dafny.Rune> _2154_genValue;
            _2154_genValue = ((_2142_generatedValues).Select(_2143_i)).dtor__1;
            if ((((_2142_generatedValues).Select(_2143_i)).dtor__2) && (!(_2144_allErased))) {
              _2153_genKey = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2153_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((((_2142_generatedValues).Select(_2143_i)).dtor__3) && (!(_2144_allErased))) {
              _2154_genValue = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2154_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2153_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2154_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            _2143_i = (_2143_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashMap<_, _>>()"));
          isOwned = true;
          isErased = _2144_allErased;
        }
      } else if (_source20.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source70 = selfIdent;
          if (_source70.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2155___mcc_h1136 = _source70.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2156_id = _2155___mcc_h1136;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2156_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2156_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2156_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2156_id);
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
      } else if (_source20.is_Ite) {
        DAST._IExpression _2157___mcc_h27 = _source20.dtor_cond;
        DAST._IExpression _2158___mcc_h28 = _source20.dtor_thn;
        DAST._IExpression _2159___mcc_h29 = _source20.dtor_els;
        DAST._IExpression _2160_f = _2159___mcc_h29;
        DAST._IExpression _2161_t = _2158___mcc_h28;
        DAST._IExpression _2162_cond = _2157___mcc_h27;
        {
          Dafny.ISequence<Dafny.Rune> _2163_condString;
          bool _2164___v73;
          bool _2165_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2166_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1396;
          bool _out1397;
          bool _out1398;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1399;
          DCOMP.COMP.GenExpr(_2162_cond, selfIdent, @params, true, out _out1396, out _out1397, out _out1398, out _out1399);
          _2163_condString = _out1396;
          _2164___v73 = _out1397;
          _2165_condErased = _out1398;
          _2166_recIdentsCond = _out1399;
          if (!(_2165_condErased)) {
            _2163_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2163_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2167___v74;
          bool _2168_tHasToBeOwned;
          bool _2169___v75;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2170___v76;
          Dafny.ISequence<Dafny.Rune> _out1400;
          bool _out1401;
          bool _out1402;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1403;
          DCOMP.COMP.GenExpr(_2161_t, selfIdent, @params, mustOwn, out _out1400, out _out1401, out _out1402, out _out1403);
          _2167___v74 = _out1400;
          _2168_tHasToBeOwned = _out1401;
          _2169___v75 = _out1402;
          _2170___v76 = _out1403;
          Dafny.ISequence<Dafny.Rune> _2171_fString;
          bool _2172_fOwned;
          bool _2173_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2174_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1404;
          bool _out1405;
          bool _out1406;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1407;
          DCOMP.COMP.GenExpr(_2160_f, selfIdent, @params, _2168_tHasToBeOwned, out _out1404, out _out1405, out _out1406, out _out1407);
          _2171_fString = _out1404;
          _2172_fOwned = _out1405;
          _2173_fErased = _out1406;
          _2174_recIdentsF = _out1407;
          Dafny.ISequence<Dafny.Rune> _2175_tString;
          bool _2176___v77;
          bool _2177_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2178_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1408;
          bool _out1409;
          bool _out1410;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1411;
          DCOMP.COMP.GenExpr(_2161_t, selfIdent, @params, _2172_fOwned, out _out1408, out _out1409, out _out1410, out _out1411);
          _2175_tString = _out1408;
          _2176___v77 = _out1409;
          _2177_tErased = _out1410;
          _2178_recIdentsT = _out1411;
          if ((!(_2173_fErased)) || (!(_2177_tErased))) {
            if (_2173_fErased) {
              _2171_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2171_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2177_tErased) {
              _2175_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2175_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2163_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2175_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2171_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2172_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2166_recIdentsCond, _2178_recIdentsT), _2174_recIdentsF);
          isErased = (_2173_fErased) || (_2177_tErased);
        }
      } else if (_source20.is_UnOp) {
        DAST._IUnaryOp _2179___mcc_h30 = _source20.dtor_unOp;
        DAST._IExpression _2180___mcc_h31 = _source20.dtor_expr;
        DAST._IUnaryOp _source71 = _2179___mcc_h30;
        if (_source71.is_Not) {
          DAST._IExpression _2181_e = _2180___mcc_h31;
          {
            Dafny.ISequence<Dafny.Rune> _2182_recursiveGen;
            bool _2183___v78;
            bool _2184_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2185_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1412;
            bool _out1413;
            bool _out1414;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1415;
            DCOMP.COMP.GenExpr(_2181_e, selfIdent, @params, true, out _out1412, out _out1413, out _out1414, out _out1415);
            _2182_recursiveGen = _out1412;
            _2183___v78 = _out1413;
            _2184_recErased = _out1414;
            _2185_recIdents = _out1415;
            if (!(_2184_recErased)) {
              _2182_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2182_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2182_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2185_recIdents;
            isErased = true;
          }
        } else if (_source71.is_BitwiseNot) {
          DAST._IExpression _2186_e = _2180___mcc_h31;
          {
            Dafny.ISequence<Dafny.Rune> _2187_recursiveGen;
            bool _2188___v79;
            bool _2189_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2190_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1416;
            bool _out1417;
            bool _out1418;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1419;
            DCOMP.COMP.GenExpr(_2186_e, selfIdent, @params, true, out _out1416, out _out1417, out _out1418, out _out1419);
            _2187_recursiveGen = _out1416;
            _2188___v79 = _out1417;
            _2189_recErased = _out1418;
            _2190_recIdents = _out1419;
            if (!(_2189_recErased)) {
              _2187_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2190_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2191_e = _2180___mcc_h31;
          {
            Dafny.ISequence<Dafny.Rune> _2192_recursiveGen;
            bool _2193_recOwned;
            bool _2194_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2195_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1420;
            bool _out1421;
            bool _out1422;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1423;
            DCOMP.COMP.GenExpr(_2191_e, selfIdent, @params, false, out _out1420, out _out1421, out _out1422, out _out1423);
            _2192_recursiveGen = _out1420;
            _2193_recOwned = _out1421;
            _2194_recErased = _out1422;
            _2195_recIdents = _out1423;
            if (!(_2194_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2196_eraseFn;
              _2196_eraseFn = ((_2193_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2192_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2196_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2192_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2192_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2195_recIdents;
            isErased = true;
          }
        }
      } else if (_source20.is_BinOp) {
        DAST._IBinOp _2197___mcc_h32 = _source20.dtor_op;
        DAST._IExpression _2198___mcc_h33 = _source20.dtor_left;
        DAST._IExpression _2199___mcc_h34 = _source20.dtor_right;
        DAST._IExpression _2200_r = _2199___mcc_h34;
        DAST._IExpression _2201_l = _2198___mcc_h33;
        DAST._IBinOp _2202_op = _2197___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _2203_left;
          bool _2204___v80;
          bool _2205_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2206_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1424;
          bool _out1425;
          bool _out1426;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1427;
          DCOMP.COMP.GenExpr(_2201_l, selfIdent, @params, true, out _out1424, out _out1425, out _out1426, out _out1427);
          _2203_left = _out1424;
          _2204___v80 = _out1425;
          _2205_leftErased = _out1426;
          _2206_recIdentsL = _out1427;
          Dafny.ISequence<Dafny.Rune> _2207_right;
          bool _2208___v81;
          bool _2209_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2210_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1428;
          bool _out1429;
          bool _out1430;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1431;
          DCOMP.COMP.GenExpr(_2200_r, selfIdent, @params, true, out _out1428, out _out1429, out _out1430, out _out1431);
          _2207_right = _out1428;
          _2208___v81 = _out1429;
          _2209_rightErased = _out1430;
          _2210_recIdentsR = _out1431;
          if (!(_2205_leftErased)) {
            _2203_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2203_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2209_rightErased)) {
            _2207_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2207_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          DAST._IBinOp _source72 = _2202_op;
          if (_source72.is_In) {
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2207_right, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".contains(&")), _2203_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          } else if (_source72.is_SetDifference) {
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2203_left, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".difference(&")), _2207_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").cloned().collect::<::std::collections::HashSet<_>>()"));
            }
          } else if (_source72.is_Concat) {
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("["), _2203_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2207_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].concat()"));
            }
          } else {
            Dafny.ISequence<Dafny.Rune> _2211___mcc_h1137 = _source72.dtor_Passthrough_a0;
            Dafny.ISequence<Dafny.Rune> _2212_op = _2211___mcc_h1137;
            {
              if ((_2212_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2203_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2207_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              } else if ((_2212_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2203_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2207_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2203_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2212_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2207_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2206_recIdentsL, _2210_recIdentsR);
          isErased = true;
        }
      } else if (_source20.is_ArrayLen) {
        DAST._IExpression _2213___mcc_h35 = _source20.dtor_expr;
        BigInteger _2214___mcc_h36 = _source20.dtor_dim;
        BigInteger _2215_dim = _2214___mcc_h36;
        DAST._IExpression _2216_expr = _2213___mcc_h35;
        {
          Dafny.ISequence<Dafny.Rune> _2217_recursiveGen;
          bool _2218___v82;
          bool _2219_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2220_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1432;
          bool _out1433;
          bool _out1434;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1435;
          DCOMP.COMP.GenExpr(_2216_expr, selfIdent, @params, true, out _out1432, out _out1433, out _out1434, out _out1435);
          _2217_recursiveGen = _out1432;
          _2218___v82 = _out1433;
          _2219_recErased = _out1434;
          _2220_recIdents = _out1435;
          if (!(_2219_recErased)) {
            _2217_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2215_dim).Sign == 0) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(m.borrow().len())");
            BigInteger _2221_i;
            _2221_i = BigInteger.One;
            while ((_2221_i) < (_2215_dim)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("m.borrow().get(0).map(|m| "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap_or(::dafny_runtime::BigInt::from(0))"));
              _2221_i = (_2221_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow().get(0).map(|m| ")), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap_or(::dafny_runtime::BigInt::from(0))"));
          }
          isOwned = true;
          readIdents = _2220_recIdents;
          isErased = true;
        }
      } else if (_source20.is_Select) {
        DAST._IExpression _2222___mcc_h37 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2223___mcc_h38 = _source20.dtor_field;
        bool _2224___mcc_h39 = _source20.dtor_isConstant;
        bool _2225___mcc_h40 = _source20.dtor_onDatatype;
        DAST._IExpression _source73 = _2222___mcc_h37;
        if (_source73.is_Literal) {
          DAST._ILiteral _2226___mcc_h41 = _source73.dtor_Literal_a0;
          bool _2227_isDatatype = _2225___mcc_h40;
          bool _2228_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2229_field = _2223___mcc_h38;
          DAST._IExpression _2230_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2231_onString;
            bool _2232_onOwned;
            bool _2233_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2234_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1436;
            bool _out1437;
            bool _out1438;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1439;
            DCOMP.COMP.GenExpr(_2230_on, selfIdent, @params, false, out _out1436, out _out1437, out _out1438, out _out1439);
            _2231_onString = _out1436;
            _2232_onOwned = _out1437;
            _2233_onErased = _out1438;
            _2234_recIdents = _out1439;
            if (!(_2233_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2235_eraseFn;
              _2235_eraseFn = ((_2232_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2231_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2235_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2231_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2227_isDatatype) || (_2228_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2231_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2229_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2228_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2231_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2229_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2234_recIdents;
          }
        } else if (_source73.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2236___mcc_h43 = _source73.dtor_Ident_a0;
          bool _2237_isDatatype = _2225___mcc_h40;
          bool _2238_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2239_field = _2223___mcc_h38;
          DAST._IExpression _2240_on = _2222___mcc_h37;
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2241_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2239_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2241_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2239_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2244_recIdents;
          }
        } else if (_source73.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2246___mcc_h45 = _source73.dtor_Companion_a0;
          bool _2247_isDatatype = _2225___mcc_h40;
          bool _2248_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2249_field = _2223___mcc_h38;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2250_c = _2246___mcc_h45;
          {
            Dafny.ISequence<Dafny.Rune> _2251_onString;
            bool _2252_onOwned;
            bool _2253_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2254_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1444;
            bool _out1445;
            bool _out1446;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1447;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2250_c), selfIdent, @params, false, out _out1444, out _out1445, out _out1446, out _out1447);
            _2251_onString = _out1444;
            _2252_onOwned = _out1445;
            _2253_onErased = _out1446;
            _2254_recIdents = _out1447;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2251_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), DCOMP.__default.escapeIdent(_2249_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2254_recIdents;
          }
        } else if (_source73.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2255___mcc_h47 = _source73.dtor_Tuple_a0;
          bool _2256_isDatatype = _2225___mcc_h40;
          bool _2257_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2258_field = _2223___mcc_h38;
          DAST._IExpression _2259_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2260_onString;
            bool _2261_onOwned;
            bool _2262_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2263_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1448;
            bool _out1449;
            bool _out1450;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1451;
            DCOMP.COMP.GenExpr(_2259_on, selfIdent, @params, false, out _out1448, out _out1449, out _out1450, out _out1451);
            _2260_onString = _out1448;
            _2261_onOwned = _out1449;
            _2262_onErased = _out1450;
            _2263_recIdents = _out1451;
            if (!(_2262_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2264_eraseFn;
              _2264_eraseFn = ((_2261_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2260_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2264_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2260_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2256_isDatatype) || (_2257_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2260_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2258_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2257_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2260_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2258_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2263_recIdents;
          }
        } else if (_source73.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2265___mcc_h49 = _source73.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2266___mcc_h50 = _source73.dtor_args;
          bool _2267_isDatatype = _2225___mcc_h40;
          bool _2268_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2269_field = _2223___mcc_h38;
          DAST._IExpression _2270_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2271_onString;
            bool _2272_onOwned;
            bool _2273_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2274_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1452;
            bool _out1453;
            bool _out1454;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1455;
            DCOMP.COMP.GenExpr(_2270_on, selfIdent, @params, false, out _out1452, out _out1453, out _out1454, out _out1455);
            _2271_onString = _out1452;
            _2272_onOwned = _out1453;
            _2273_onErased = _out1454;
            _2274_recIdents = _out1455;
            if (!(_2273_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2275_eraseFn;
              _2275_eraseFn = ((_2272_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2271_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2275_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2271_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2267_isDatatype) || (_2268_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2271_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2269_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2268_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2271_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2269_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2274_recIdents;
          }
        } else if (_source73.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2276___mcc_h53 = _source73.dtor_dims;
          bool _2277_isDatatype = _2225___mcc_h40;
          bool _2278_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2279_field = _2223___mcc_h38;
          DAST._IExpression _2280_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2281_onString;
            bool _2282_onOwned;
            bool _2283_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2284_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1456;
            bool _out1457;
            bool _out1458;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1459;
            DCOMP.COMP.GenExpr(_2280_on, selfIdent, @params, false, out _out1456, out _out1457, out _out1458, out _out1459);
            _2281_onString = _out1456;
            _2282_onOwned = _out1457;
            _2283_onErased = _out1458;
            _2284_recIdents = _out1459;
            if (!(_2283_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2285_eraseFn;
              _2285_eraseFn = ((_2282_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2281_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2285_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2281_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2277_isDatatype) || (_2278_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2281_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2279_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2278_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2281_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2279_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2284_recIdents;
          }
        } else if (_source73.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2286___mcc_h55 = _source73.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2287___mcc_h56 = _source73.dtor_variant;
          bool _2288___mcc_h57 = _source73.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2289___mcc_h58 = _source73.dtor_contents;
          bool _2290_isDatatype = _2225___mcc_h40;
          bool _2291_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2292_field = _2223___mcc_h38;
          DAST._IExpression _2293_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2294_onString;
            bool _2295_onOwned;
            bool _2296_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2297_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1460;
            bool _out1461;
            bool _out1462;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1463;
            DCOMP.COMP.GenExpr(_2293_on, selfIdent, @params, false, out _out1460, out _out1461, out _out1462, out _out1463);
            _2294_onString = _out1460;
            _2295_onOwned = _out1461;
            _2296_onErased = _out1462;
            _2297_recIdents = _out1463;
            if (!(_2296_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2298_eraseFn;
              _2298_eraseFn = ((_2295_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2294_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2298_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2294_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2290_isDatatype) || (_2291_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2294_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2292_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2291_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2294_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2292_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2297_recIdents;
          }
        } else if (_source73.is_Convert) {
          DAST._IExpression _2299___mcc_h63 = _source73.dtor_value;
          DAST._IType _2300___mcc_h64 = _source73.dtor_from;
          DAST._IType _2301___mcc_h65 = _source73.dtor_typ;
          bool _2302_isDatatype = _2225___mcc_h40;
          bool _2303_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2304_field = _2223___mcc_h38;
          DAST._IExpression _2305_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2306_onString;
            bool _2307_onOwned;
            bool _2308_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2309_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1464;
            bool _out1465;
            bool _out1466;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1467;
            DCOMP.COMP.GenExpr(_2305_on, selfIdent, @params, false, out _out1464, out _out1465, out _out1466, out _out1467);
            _2306_onString = _out1464;
            _2307_onOwned = _out1465;
            _2308_onErased = _out1466;
            _2309_recIdents = _out1467;
            if (!(_2308_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2310_eraseFn;
              _2310_eraseFn = ((_2307_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2306_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2310_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2306_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2302_isDatatype) || (_2303_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2306_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2304_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2303_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2306_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2304_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2309_recIdents;
          }
        } else if (_source73.is_SeqConstruct) {
          DAST._IExpression _2311___mcc_h69 = _source73.dtor_length;
          DAST._IExpression _2312___mcc_h70 = _source73.dtor_elem;
          bool _2313_isDatatype = _2225___mcc_h40;
          bool _2314_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2315_field = _2223___mcc_h38;
          DAST._IExpression _2316_on = _2222___mcc_h37;
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2315_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2317_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2315_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2320_recIdents;
          }
        } else if (_source73.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2322___mcc_h73 = _source73.dtor_elements;
          bool _2323_isDatatype = _2225___mcc_h40;
          bool _2324_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2325_field = _2223___mcc_h38;
          DAST._IExpression _2326_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2327_onString;
            bool _2328_onOwned;
            bool _2329_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2330_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1472;
            bool _out1473;
            bool _out1474;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1475;
            DCOMP.COMP.GenExpr(_2326_on, selfIdent, @params, false, out _out1472, out _out1473, out _out1474, out _out1475);
            _2327_onString = _out1472;
            _2328_onOwned = _out1473;
            _2329_onErased = _out1474;
            _2330_recIdents = _out1475;
            if (!(_2329_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2331_eraseFn;
              _2331_eraseFn = ((_2328_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2327_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2331_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2327_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2323_isDatatype) || (_2324_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2327_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2325_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2324_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2327_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2325_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2330_recIdents;
          }
        } else if (_source73.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2332___mcc_h75 = _source73.dtor_elements;
          bool _2333_isDatatype = _2225___mcc_h40;
          bool _2334_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2335_field = _2223___mcc_h38;
          DAST._IExpression _2336_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2337_onString;
            bool _2338_onOwned;
            bool _2339_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2340_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1476;
            bool _out1477;
            bool _out1478;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1479;
            DCOMP.COMP.GenExpr(_2336_on, selfIdent, @params, false, out _out1476, out _out1477, out _out1478, out _out1479);
            _2337_onString = _out1476;
            _2338_onOwned = _out1477;
            _2339_onErased = _out1478;
            _2340_recIdents = _out1479;
            if (!(_2339_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2341_eraseFn;
              _2341_eraseFn = ((_2338_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2337_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2341_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2337_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2333_isDatatype) || (_2334_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2337_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2335_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2334_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2337_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2335_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2340_recIdents;
          }
        } else if (_source73.is_MapValue) {
          Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2342___mcc_h77 = _source73.dtor_mapElems;
          bool _2343_isDatatype = _2225___mcc_h40;
          bool _2344_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2345_field = _2223___mcc_h38;
          DAST._IExpression _2346_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2347_onString;
            bool _2348_onOwned;
            bool _2349_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2350_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1480;
            bool _out1481;
            bool _out1482;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1483;
            DCOMP.COMP.GenExpr(_2346_on, selfIdent, @params, false, out _out1480, out _out1481, out _out1482, out _out1483);
            _2347_onString = _out1480;
            _2348_onOwned = _out1481;
            _2349_onErased = _out1482;
            _2350_recIdents = _out1483;
            if (!(_2349_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2351_eraseFn;
              _2351_eraseFn = ((_2348_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2347_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2351_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2347_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2343_isDatatype) || (_2344_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2347_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2345_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2344_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2347_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2345_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2350_recIdents;
          }
        } else if (_source73.is_This) {
          bool _2352_isDatatype = _2225___mcc_h40;
          bool _2353_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2354_field = _2223___mcc_h38;
          DAST._IExpression _2355_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2356_onString;
            bool _2357_onOwned;
            bool _2358_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2359_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1484;
            bool _out1485;
            bool _out1486;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1487;
            DCOMP.COMP.GenExpr(_2355_on, selfIdent, @params, false, out _out1484, out _out1485, out _out1486, out _out1487);
            _2356_onString = _out1484;
            _2357_onOwned = _out1485;
            _2358_onErased = _out1486;
            _2359_recIdents = _out1487;
            if (!(_2358_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2360_eraseFn;
              _2360_eraseFn = ((_2357_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2356_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2360_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2356_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2352_isDatatype) || (_2353_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2356_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2354_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2353_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2356_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2354_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2359_recIdents;
          }
        } else if (_source73.is_Ite) {
          DAST._IExpression _2361___mcc_h79 = _source73.dtor_cond;
          DAST._IExpression _2362___mcc_h80 = _source73.dtor_thn;
          DAST._IExpression _2363___mcc_h81 = _source73.dtor_els;
          bool _2364_isDatatype = _2225___mcc_h40;
          bool _2365_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2366_field = _2223___mcc_h38;
          DAST._IExpression _2367_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2368_onString;
            bool _2369_onOwned;
            bool _2370_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2371_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1488;
            bool _out1489;
            bool _out1490;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1491;
            DCOMP.COMP.GenExpr(_2367_on, selfIdent, @params, false, out _out1488, out _out1489, out _out1490, out _out1491);
            _2368_onString = _out1488;
            _2369_onOwned = _out1489;
            _2370_onErased = _out1490;
            _2371_recIdents = _out1491;
            if (!(_2370_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2372_eraseFn;
              _2372_eraseFn = ((_2369_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2368_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2372_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2368_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2364_isDatatype) || (_2365_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2368_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2366_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2365_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2368_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2366_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2371_recIdents;
          }
        } else if (_source73.is_UnOp) {
          DAST._IUnaryOp _2373___mcc_h85 = _source73.dtor_unOp;
          DAST._IExpression _2374___mcc_h86 = _source73.dtor_expr;
          bool _2375_isDatatype = _2225___mcc_h40;
          bool _2376_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2377_field = _2223___mcc_h38;
          DAST._IExpression _2378_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2379_onString;
            bool _2380_onOwned;
            bool _2381_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2382_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1492;
            bool _out1493;
            bool _out1494;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1495;
            DCOMP.COMP.GenExpr(_2378_on, selfIdent, @params, false, out _out1492, out _out1493, out _out1494, out _out1495);
            _2379_onString = _out1492;
            _2380_onOwned = _out1493;
            _2381_onErased = _out1494;
            _2382_recIdents = _out1495;
            if (!(_2381_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2383_eraseFn;
              _2383_eraseFn = ((_2380_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2379_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2383_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2379_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2375_isDatatype) || (_2376_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2379_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2377_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2376_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2379_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2377_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2382_recIdents;
          }
        } else if (_source73.is_BinOp) {
          DAST._IBinOp _2384___mcc_h89 = _source73.dtor_op;
          DAST._IExpression _2385___mcc_h90 = _source73.dtor_left;
          DAST._IExpression _2386___mcc_h91 = _source73.dtor_right;
          bool _2387_isDatatype = _2225___mcc_h40;
          bool _2388_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2389_field = _2223___mcc_h38;
          DAST._IExpression _2390_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2391_onString;
            bool _2392_onOwned;
            bool _2393_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2394_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1496;
            bool _out1497;
            bool _out1498;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1499;
            DCOMP.COMP.GenExpr(_2390_on, selfIdent, @params, false, out _out1496, out _out1497, out _out1498, out _out1499);
            _2391_onString = _out1496;
            _2392_onOwned = _out1497;
            _2393_onErased = _out1498;
            _2394_recIdents = _out1499;
            if (!(_2393_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2395_eraseFn;
              _2395_eraseFn = ((_2392_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2391_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2395_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2391_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2387_isDatatype) || (_2388_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2391_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2389_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2388_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2391_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2389_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2394_recIdents;
          }
        } else if (_source73.is_ArrayLen) {
          DAST._IExpression _2396___mcc_h95 = _source73.dtor_expr;
          BigInteger _2397___mcc_h96 = _source73.dtor_dim;
          bool _2398_isDatatype = _2225___mcc_h40;
          bool _2399_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2400_field = _2223___mcc_h38;
          DAST._IExpression _2401_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2402_onString;
            bool _2403_onOwned;
            bool _2404_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2405_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1500;
            bool _out1501;
            bool _out1502;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1503;
            DCOMP.COMP.GenExpr(_2401_on, selfIdent, @params, false, out _out1500, out _out1501, out _out1502, out _out1503);
            _2402_onString = _out1500;
            _2403_onOwned = _out1501;
            _2404_onErased = _out1502;
            _2405_recIdents = _out1503;
            if (!(_2404_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2406_eraseFn;
              _2406_eraseFn = ((_2403_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2402_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2406_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2402_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2398_isDatatype) || (_2399_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2402_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2400_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2399_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2402_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2400_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2405_recIdents;
          }
        } else if (_source73.is_Select) {
          DAST._IExpression _2407___mcc_h99 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2408___mcc_h100 = _source73.dtor_field;
          bool _2409___mcc_h101 = _source73.dtor_isConstant;
          bool _2410___mcc_h102 = _source73.dtor_onDatatype;
          bool _2411_isDatatype = _2225___mcc_h40;
          bool _2412_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2413_field = _2223___mcc_h38;
          DAST._IExpression _2414_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2415_onString;
            bool _2416_onOwned;
            bool _2417_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2418_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1504;
            bool _out1505;
            bool _out1506;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1507;
            DCOMP.COMP.GenExpr(_2414_on, selfIdent, @params, false, out _out1504, out _out1505, out _out1506, out _out1507);
            _2415_onString = _out1504;
            _2416_onOwned = _out1505;
            _2417_onErased = _out1506;
            _2418_recIdents = _out1507;
            if (!(_2417_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2419_eraseFn;
              _2419_eraseFn = ((_2416_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2415_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2419_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2415_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2411_isDatatype) || (_2412_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2415_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2413_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2412_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2415_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2413_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2418_recIdents;
          }
        } else if (_source73.is_SelectFn) {
          DAST._IExpression _2420___mcc_h107 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2421___mcc_h108 = _source73.dtor_field;
          bool _2422___mcc_h109 = _source73.dtor_onDatatype;
          bool _2423___mcc_h110 = _source73.dtor_isStatic;
          BigInteger _2424___mcc_h111 = _source73.dtor_arity;
          bool _2425_isDatatype = _2225___mcc_h40;
          bool _2426_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2427_field = _2223___mcc_h38;
          DAST._IExpression _2428_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2429_onString;
            bool _2430_onOwned;
            bool _2431_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2432_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1508;
            bool _out1509;
            bool _out1510;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1511;
            DCOMP.COMP.GenExpr(_2428_on, selfIdent, @params, false, out _out1508, out _out1509, out _out1510, out _out1511);
            _2429_onString = _out1508;
            _2430_onOwned = _out1509;
            _2431_onErased = _out1510;
            _2432_recIdents = _out1511;
            if (!(_2431_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2433_eraseFn;
              _2433_eraseFn = ((_2430_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2429_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2433_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2429_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2425_isDatatype) || (_2426_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2429_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2427_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2426_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2429_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2427_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2432_recIdents;
          }
        } else if (_source73.is_Index) {
          DAST._IExpression _2434___mcc_h117 = _source73.dtor_expr;
          DAST._ICollKind _2435___mcc_h118 = _source73.dtor_collKind;
          Dafny.ISequence<DAST._IExpression> _2436___mcc_h119 = _source73.dtor_indices;
          bool _2437_isDatatype = _2225___mcc_h40;
          bool _2438_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2439_field = _2223___mcc_h38;
          DAST._IExpression _2440_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2441_onString;
            bool _2442_onOwned;
            bool _2443_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2444_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1512;
            bool _out1513;
            bool _out1514;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1515;
            DCOMP.COMP.GenExpr(_2440_on, selfIdent, @params, false, out _out1512, out _out1513, out _out1514, out _out1515);
            _2441_onString = _out1512;
            _2442_onOwned = _out1513;
            _2443_onErased = _out1514;
            _2444_recIdents = _out1515;
            if (!(_2443_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2445_eraseFn;
              _2445_eraseFn = ((_2442_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2441_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2445_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2441_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2437_isDatatype) || (_2438_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2441_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2439_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2438_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2441_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2439_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2444_recIdents;
          }
        } else if (_source73.is_IndexRange) {
          DAST._IExpression _2446___mcc_h123 = _source73.dtor_expr;
          bool _2447___mcc_h124 = _source73.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2448___mcc_h125 = _source73.dtor_low;
          DAST._IOptional<DAST._IExpression> _2449___mcc_h126 = _source73.dtor_high;
          bool _2450_isDatatype = _2225___mcc_h40;
          bool _2451_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2452_field = _2223___mcc_h38;
          DAST._IExpression _2453_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2454_onString;
            bool _2455_onOwned;
            bool _2456_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2457_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1516;
            bool _out1517;
            bool _out1518;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1519;
            DCOMP.COMP.GenExpr(_2453_on, selfIdent, @params, false, out _out1516, out _out1517, out _out1518, out _out1519);
            _2454_onString = _out1516;
            _2455_onOwned = _out1517;
            _2456_onErased = _out1518;
            _2457_recIdents = _out1519;
            if (!(_2456_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2458_eraseFn;
              _2458_eraseFn = ((_2455_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2454_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2458_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2454_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2450_isDatatype) || (_2451_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2454_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2452_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2451_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2454_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2452_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2457_recIdents;
          }
        } else if (_source73.is_TupleSelect) {
          DAST._IExpression _2459___mcc_h131 = _source73.dtor_expr;
          BigInteger _2460___mcc_h132 = _source73.dtor_index;
          bool _2461_isDatatype = _2225___mcc_h40;
          bool _2462_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2463_field = _2223___mcc_h38;
          DAST._IExpression _2464_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2465_onString;
            bool _2466_onOwned;
            bool _2467_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2468_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1520;
            bool _out1521;
            bool _out1522;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1523;
            DCOMP.COMP.GenExpr(_2464_on, selfIdent, @params, false, out _out1520, out _out1521, out _out1522, out _out1523);
            _2465_onString = _out1520;
            _2466_onOwned = _out1521;
            _2467_onErased = _out1522;
            _2468_recIdents = _out1523;
            if (!(_2467_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2469_eraseFn;
              _2469_eraseFn = ((_2466_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2465_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2469_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2465_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2461_isDatatype) || (_2462_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2465_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2463_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2462_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2465_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2463_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2468_recIdents;
          }
        } else if (_source73.is_Call) {
          DAST._IExpression _2470___mcc_h135 = _source73.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2471___mcc_h136 = _source73.dtor_name;
          Dafny.ISequence<DAST._IType> _2472___mcc_h137 = _source73.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2473___mcc_h138 = _source73.dtor_args;
          bool _2474_isDatatype = _2225___mcc_h40;
          bool _2475_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2476_field = _2223___mcc_h38;
          DAST._IExpression _2477_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2478_onString;
            bool _2479_onOwned;
            bool _2480_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2481_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1524;
            bool _out1525;
            bool _out1526;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1527;
            DCOMP.COMP.GenExpr(_2477_on, selfIdent, @params, false, out _out1524, out _out1525, out _out1526, out _out1527);
            _2478_onString = _out1524;
            _2479_onOwned = _out1525;
            _2480_onErased = _out1526;
            _2481_recIdents = _out1527;
            if (!(_2480_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2482_eraseFn;
              _2482_eraseFn = ((_2479_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2478_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2482_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2478_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2474_isDatatype) || (_2475_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2478_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2476_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2475_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2478_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2476_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2481_recIdents;
          }
        } else if (_source73.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2483___mcc_h143 = _source73.dtor_params;
          DAST._IType _2484___mcc_h144 = _source73.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2485___mcc_h145 = _source73.dtor_body;
          bool _2486_isDatatype = _2225___mcc_h40;
          bool _2487_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2488_field = _2223___mcc_h38;
          DAST._IExpression _2489_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2490_onString;
            bool _2491_onOwned;
            bool _2492_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2493_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1528;
            bool _out1529;
            bool _out1530;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1531;
            DCOMP.COMP.GenExpr(_2489_on, selfIdent, @params, false, out _out1528, out _out1529, out _out1530, out _out1531);
            _2490_onString = _out1528;
            _2491_onOwned = _out1529;
            _2492_onErased = _out1530;
            _2493_recIdents = _out1531;
            if (!(_2492_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2494_eraseFn;
              _2494_eraseFn = ((_2491_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2490_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2494_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2490_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2486_isDatatype) || (_2487_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2490_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2488_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2487_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2490_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2488_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2493_recIdents;
          }
        } else if (_source73.is_BetaRedex) {
          Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2495___mcc_h149 = _source73.dtor_values;
          DAST._IType _2496___mcc_h150 = _source73.dtor_retType;
          DAST._IExpression _2497___mcc_h151 = _source73.dtor_expr;
          bool _2498_isDatatype = _2225___mcc_h40;
          bool _2499_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2500_field = _2223___mcc_h38;
          DAST._IExpression _2501_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2502_onString;
            bool _2503_onOwned;
            bool _2504_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2505_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1532;
            bool _out1533;
            bool _out1534;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1535;
            DCOMP.COMP.GenExpr(_2501_on, selfIdent, @params, false, out _out1532, out _out1533, out _out1534, out _out1535);
            _2502_onString = _out1532;
            _2503_onOwned = _out1533;
            _2504_onErased = _out1534;
            _2505_recIdents = _out1535;
            if (!(_2504_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2506_eraseFn;
              _2506_eraseFn = ((_2503_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2502_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2506_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2502_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2498_isDatatype) || (_2499_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2502_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2500_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2499_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2502_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2500_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2505_recIdents;
          }
        } else if (_source73.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2507___mcc_h155 = _source73.dtor_name;
          DAST._IType _2508___mcc_h156 = _source73.dtor_typ;
          DAST._IExpression _2509___mcc_h157 = _source73.dtor_value;
          DAST._IExpression _2510___mcc_h158 = _source73.dtor_iifeBody;
          bool _2511_isDatatype = _2225___mcc_h40;
          bool _2512_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2513_field = _2223___mcc_h38;
          DAST._IExpression _2514_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2515_onString;
            bool _2516_onOwned;
            bool _2517_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2518_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1536;
            bool _out1537;
            bool _out1538;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1539;
            DCOMP.COMP.GenExpr(_2514_on, selfIdent, @params, false, out _out1536, out _out1537, out _out1538, out _out1539);
            _2515_onString = _out1536;
            _2516_onOwned = _out1537;
            _2517_onErased = _out1538;
            _2518_recIdents = _out1539;
            if (!(_2517_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2519_eraseFn;
              _2519_eraseFn = ((_2516_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2515_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2519_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2515_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2511_isDatatype) || (_2512_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2515_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2513_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2512_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2515_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2513_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2518_recIdents;
          }
        } else if (_source73.is_Apply) {
          DAST._IExpression _2520___mcc_h163 = _source73.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2521___mcc_h164 = _source73.dtor_args;
          bool _2522_isDatatype = _2225___mcc_h40;
          bool _2523_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2524_field = _2223___mcc_h38;
          DAST._IExpression _2525_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2526_onString;
            bool _2527_onOwned;
            bool _2528_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2529_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1540;
            bool _out1541;
            bool _out1542;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1543;
            DCOMP.COMP.GenExpr(_2525_on, selfIdent, @params, false, out _out1540, out _out1541, out _out1542, out _out1543);
            _2526_onString = _out1540;
            _2527_onOwned = _out1541;
            _2528_onErased = _out1542;
            _2529_recIdents = _out1543;
            if (!(_2528_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2530_eraseFn;
              _2530_eraseFn = ((_2527_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2526_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2530_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2526_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2522_isDatatype) || (_2523_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2526_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2524_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2523_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2526_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2524_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2529_recIdents;
          }
        } else if (_source73.is_TypeTest) {
          DAST._IExpression _2531___mcc_h167 = _source73.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2532___mcc_h168 = _source73.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2533___mcc_h169 = _source73.dtor_variant;
          bool _2534_isDatatype = _2225___mcc_h40;
          bool _2535_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2536_field = _2223___mcc_h38;
          DAST._IExpression _2537_on = _2222___mcc_h37;
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2538_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2536_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
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
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2538_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2536_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2541_recIdents;
          }
        } else if (_source73.is_InitializationValue) {
          DAST._IType _2543___mcc_h173 = _source73.dtor_typ;
          bool _2544_isDatatype = _2225___mcc_h40;
          bool _2545_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2546_field = _2223___mcc_h38;
          DAST._IExpression _2547_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2548_onString;
            bool _2549_onOwned;
            bool _2550_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2551_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1548;
            bool _out1549;
            bool _out1550;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1551;
            DCOMP.COMP.GenExpr(_2547_on, selfIdent, @params, false, out _out1548, out _out1549, out _out1550, out _out1551);
            _2548_onString = _out1548;
            _2549_onOwned = _out1549;
            _2550_onErased = _out1550;
            _2551_recIdents = _out1551;
            if (!(_2550_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2552_eraseFn;
              _2552_eraseFn = ((_2549_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2548_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2552_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2548_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2544_isDatatype) || (_2545_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2548_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2546_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2545_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2548_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2546_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2551_recIdents;
          }
        } else if (_source73.is_BoolBoundedPool) {
          bool _2553_isDatatype = _2225___mcc_h40;
          bool _2554_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2555_field = _2223___mcc_h38;
          DAST._IExpression _2556_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2557_onString;
            bool _2558_onOwned;
            bool _2559_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2560_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1552;
            bool _out1553;
            bool _out1554;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1555;
            DCOMP.COMP.GenExpr(_2556_on, selfIdent, @params, false, out _out1552, out _out1553, out _out1554, out _out1555);
            _2557_onString = _out1552;
            _2558_onOwned = _out1553;
            _2559_onErased = _out1554;
            _2560_recIdents = _out1555;
            if (!(_2559_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2561_eraseFn;
              _2561_eraseFn = ((_2558_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2557_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2561_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2557_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2553_isDatatype) || (_2554_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2557_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2555_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2554_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2557_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2555_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2560_recIdents;
          }
        } else if (_source73.is_SetBoundedPool) {
          DAST._IExpression _2562___mcc_h175 = _source73.dtor_of;
          bool _2563_isDatatype = _2225___mcc_h40;
          bool _2564_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2565_field = _2223___mcc_h38;
          DAST._IExpression _2566_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2567_onString;
            bool _2568_onOwned;
            bool _2569_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2570_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1556;
            bool _out1557;
            bool _out1558;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1559;
            DCOMP.COMP.GenExpr(_2566_on, selfIdent, @params, false, out _out1556, out _out1557, out _out1558, out _out1559);
            _2567_onString = _out1556;
            _2568_onOwned = _out1557;
            _2569_onErased = _out1558;
            _2570_recIdents = _out1559;
            if (!(_2569_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2571_eraseFn;
              _2571_eraseFn = ((_2568_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2567_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2571_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2567_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2563_isDatatype) || (_2564_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2567_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2565_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2564_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2567_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2565_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2570_recIdents;
          }
        } else if (_source73.is_SeqBoundedPool) {
          DAST._IExpression _2572___mcc_h177 = _source73.dtor_of;
          bool _2573___mcc_h178 = _source73.dtor_includeDuplicates;
          bool _2574_isDatatype = _2225___mcc_h40;
          bool _2575_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2576_field = _2223___mcc_h38;
          DAST._IExpression _2577_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2578_onString;
            bool _2579_onOwned;
            bool _2580_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2581_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1560;
            bool _out1561;
            bool _out1562;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1563;
            DCOMP.COMP.GenExpr(_2577_on, selfIdent, @params, false, out _out1560, out _out1561, out _out1562, out _out1563);
            _2578_onString = _out1560;
            _2579_onOwned = _out1561;
            _2580_onErased = _out1562;
            _2581_recIdents = _out1563;
            if (!(_2580_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2582_eraseFn;
              _2582_eraseFn = ((_2579_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2578_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2582_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2578_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2574_isDatatype) || (_2575_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2578_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2576_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2575_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2578_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2576_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2581_recIdents;
          }
        } else {
          DAST._IExpression _2583___mcc_h181 = _source73.dtor_lo;
          DAST._IExpression _2584___mcc_h182 = _source73.dtor_hi;
          bool _2585_isDatatype = _2225___mcc_h40;
          bool _2586_isConstant = _2224___mcc_h39;
          Dafny.ISequence<Dafny.Rune> _2587_field = _2223___mcc_h38;
          DAST._IExpression _2588_on = _2222___mcc_h37;
          {
            Dafny.ISequence<Dafny.Rune> _2589_onString;
            bool _2590_onOwned;
            bool _2591_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2592_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1564;
            bool _out1565;
            bool _out1566;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1567;
            DCOMP.COMP.GenExpr(_2588_on, selfIdent, @params, false, out _out1564, out _out1565, out _out1566, out _out1567);
            _2589_onString = _out1564;
            _2590_onOwned = _out1565;
            _2591_onErased = _out1566;
            _2592_recIdents = _out1567;
            if (!(_2591_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2593_eraseFn;
              _2593_eraseFn = ((_2590_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2589_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2593_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2589_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2585_isDatatype) || (_2586_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2589_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2587_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2586_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2589_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), DCOMP.__default.escapeIdent(_2587_field)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2592_recIdents;
          }
        }
      } else if (_source20.is_SelectFn) {
        DAST._IExpression _2594___mcc_h185 = _source20.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2595___mcc_h186 = _source20.dtor_field;
        bool _2596___mcc_h187 = _source20.dtor_onDatatype;
        bool _2597___mcc_h188 = _source20.dtor_isStatic;
        BigInteger _2598___mcc_h189 = _source20.dtor_arity;
        BigInteger _2599_arity = _2598___mcc_h189;
        bool _2600_isStatic = _2597___mcc_h188;
        bool _2601_isDatatype = _2596___mcc_h187;
        Dafny.ISequence<Dafny.Rune> _2602_field = _2595___mcc_h186;
        DAST._IExpression _2603_on = _2594___mcc_h185;
        {
          Dafny.ISequence<Dafny.Rune> _2604_onString;
          bool _2605_onOwned;
          bool _2606___v83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2607_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1568;
          bool _out1569;
          bool _out1570;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1571;
          DCOMP.COMP.GenExpr(_2603_on, selfIdent, @params, false, out _out1568, out _out1569, out _out1570, out _out1571);
          _2604_onString = _out1568;
          _2605_onOwned = _out1569;
          _2606___v83 = _out1570;
          _2607_recIdents = _out1571;
          if (_2600_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2604_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2602_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2604_onString), ((_2605_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2608_args;
            _2608_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2609_i;
            _2609_i = BigInteger.Zero;
            while ((_2609_i) < (_2599_arity)) {
              if ((_2609_i).Sign == 1) {
                _2608_args = Dafny.Sequence<Dafny.Rune>.Concat(_2608_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2608_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2608_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2609_i));
              _2609_i = (_2609_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2608_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2602_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2608_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper(::std::rc::Rc::new("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
          readIdents = _2607_recIdents;
        }
      } else if (_source20.is_Index) {
        DAST._IExpression _2610___mcc_h190 = _source20.dtor_expr;
        DAST._ICollKind _2611___mcc_h191 = _source20.dtor_collKind;
        Dafny.ISequence<DAST._IExpression> _2612___mcc_h192 = _source20.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2613_indices = _2612___mcc_h192;
        DAST._ICollKind _2614_collKind = _2611___mcc_h191;
        DAST._IExpression _2615_on = _2610___mcc_h190;
        {
          Dafny.ISequence<Dafny.Rune> _2616_onString;
          bool _2617_onOwned;
          bool _2618_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2619_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1572;
          bool _out1573;
          bool _out1574;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1575;
          DCOMP.COMP.GenExpr(_2615_on, selfIdent, @params, false, out _out1572, out _out1573, out _out1574, out _out1575);
          _2616_onString = _out1572;
          _2617_onOwned = _out1573;
          _2618_onErased = _out1574;
          _2619_recIdents = _out1575;
          readIdents = _2619_recIdents;
          if (!(_2618_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2620_eraseFn;
            _2620_eraseFn = ((_2617_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2616_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2620_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2616_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2616_onString;
          BigInteger _2621_i;
          _2621_i = BigInteger.Zero;
          while ((_2621_i) < (new BigInteger((_2613_indices).Count))) {
            if (object.Equals(_2614_collKind, DAST.CollKind.create_Array())) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            if (object.Equals(_2614_collKind, DAST.CollKind.create_Map())) {
              Dafny.ISequence<Dafny.Rune> _2622_idx;
              bool _2623_idxOwned;
              bool _2624_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2625_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1576;
              bool _out1577;
              bool _out1578;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1579;
              DCOMP.COMP.GenExpr((_2613_indices).Select(_2621_i), selfIdent, @params, false, out _out1576, out _out1577, out _out1578, out _out1579);
              _2622_idx = _out1576;
              _2623_idxOwned = _out1577;
              _2624_idxErased = _out1578;
              _2625_recIdentsIdx = _out1579;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[")), ((_2623_idxOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _2622_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2625_recIdentsIdx);
            } else {
              Dafny.ISequence<Dafny.Rune> _2626_idx;
              bool _2627___v84;
              bool _2628_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2629_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1580;
              bool _out1581;
              bool _out1582;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1583;
              DCOMP.COMP.GenExpr((_2613_indices).Select(_2621_i), selfIdent, @params, true, out _out1580, out _out1581, out _out1582, out _out1583);
              _2626_idx = _out1580;
              _2627___v84 = _out1581;
              _2628_idxErased = _out1582;
              _2629_recIdentsIdx = _out1583;
              if (!(_2628_idxErased)) {
                _2626_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2626_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[<usize as ::dafny_runtime::NumCast>::from(")), _2626_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2629_recIdentsIdx);
            }
            _2621_i = (_2621_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2618_onErased;
        }
      } else if (_source20.is_IndexRange) {
        DAST._IExpression _2630___mcc_h193 = _source20.dtor_expr;
        bool _2631___mcc_h194 = _source20.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2632___mcc_h195 = _source20.dtor_low;
        DAST._IOptional<DAST._IExpression> _2633___mcc_h196 = _source20.dtor_high;
        DAST._IOptional<DAST._IExpression> _2634_high = _2633___mcc_h196;
        DAST._IOptional<DAST._IExpression> _2635_low = _2632___mcc_h195;
        bool _2636_isArray = _2631___mcc_h194;
        DAST._IExpression _2637_on = _2630___mcc_h193;
        {
          Dafny.ISequence<Dafny.Rune> _2638_onString;
          bool _2639_onOwned;
          bool _2640_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2641_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1584;
          bool _out1585;
          bool _out1586;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1587;
          DCOMP.COMP.GenExpr(_2637_on, selfIdent, @params, false, out _out1584, out _out1585, out _out1586, out _out1587);
          _2638_onString = _out1584;
          _2639_onOwned = _out1585;
          _2640_onErased = _out1586;
          _2641_recIdents = _out1587;
          readIdents = _2641_recIdents;
          if (!(_2640_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2642_eraseFn;
            _2642_eraseFn = ((_2639_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2638_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2642_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2638_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2638_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2643_lowString;
          _2643_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source74 = _2635_low;
          if (_source74.is_Some) {
            DAST._IExpression _2644___mcc_h1138 = _source74.dtor_Some_a0;
            DAST._IExpression _2645_l = _2644___mcc_h1138;
            {
              Dafny.ISequence<Dafny.Rune> _2646_lString;
              bool _2647___v85;
              bool _2648_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2649_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1588;
              bool _out1589;
              bool _out1590;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1591;
              DCOMP.COMP.GenExpr(_2645_l, selfIdent, @params, true, out _out1588, out _out1589, out _out1590, out _out1591);
              _2646_lString = _out1588;
              _2647___v85 = _out1589;
              _2648_lErased = _out1590;
              _2649_recIdentsL = _out1591;
              if (!(_2648_lErased)) {
                _2646_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2646_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2643_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2646_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2649_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2650_highString;
          _2650_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source75 = _2634_high;
          if (_source75.is_Some) {
            DAST._IExpression _2651___mcc_h1139 = _source75.dtor_Some_a0;
            DAST._IExpression _2652_h = _2651___mcc_h1139;
            {
              Dafny.ISequence<Dafny.Rune> _2653_hString;
              bool _2654___v86;
              bool _2655_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2656_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1592;
              bool _out1593;
              bool _out1594;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1595;
              DCOMP.COMP.GenExpr(_2652_h, selfIdent, @params, true, out _out1592, out _out1593, out _out1594, out _out1595);
              _2653_hString = _out1592;
              _2654___v86 = _out1593;
              _2655_hErased = _out1594;
              _2656_recIdentsH = _out1595;
              if (!(_2655_hErased)) {
                _2653_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2653_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2650_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2653_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2656_recIdentsH);
            }
          } else {
          }
          if (_2636_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source76) => {
            if (_source76.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2657___mcc_h1140 = _source76.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2657___mcc_h1140, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2658_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2658_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2643_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source77) => {
            if (_source77.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2659___mcc_h1141 = _source77.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2659___mcc_h1141, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2660_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2660_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2650_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2640_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source20.is_TupleSelect) {
        DAST._IExpression _2661___mcc_h197 = _source20.dtor_expr;
        BigInteger _2662___mcc_h198 = _source20.dtor_index;
        BigInteger _2663_idx = _2662___mcc_h198;
        DAST._IExpression _2664_on = _2661___mcc_h197;
        {
          Dafny.ISequence<Dafny.Rune> _2665_onString;
          bool _2666___v87;
          bool _2667_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2668_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1596;
          bool _out1597;
          bool _out1598;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1599;
          DCOMP.COMP.GenExpr(_2664_on, selfIdent, @params, false, out _out1596, out _out1597, out _out1598, out _out1599);
          _2665_onString = _out1596;
          _2666___v87 = _out1597;
          _2667_tupErased = _out1598;
          _2668_recIdents = _out1599;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2665_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2663_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2667_tupErased;
          readIdents = _2668_recIdents;
        }
      } else if (_source20.is_Call) {
        DAST._IExpression _2669___mcc_h199 = _source20.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2670___mcc_h200 = _source20.dtor_name;
        Dafny.ISequence<DAST._IType> _2671___mcc_h201 = _source20.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2672___mcc_h202 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2673_args = _2672___mcc_h202;
        Dafny.ISequence<DAST._IType> _2674_typeArgs = _2671___mcc_h201;
        Dafny.ISequence<Dafny.Rune> _2675_name = _2670___mcc_h200;
        DAST._IExpression _2676_on = _2669___mcc_h199;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2677_typeArgString;
          _2677_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2674_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2678_typeI;
            _2678_typeI = BigInteger.Zero;
            _2677_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2678_typeI) < (new BigInteger((_2674_typeArgs).Count))) {
              if ((_2678_typeI).Sign == 1) {
                _2677_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2677_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2679_typeString;
              Dafny.ISequence<Dafny.Rune> _out1600;
              _out1600 = DCOMP.COMP.GenType((_2674_typeArgs).Select(_2678_typeI), false, false);
              _2679_typeString = _out1600;
              _2677_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2677_typeArgString, _2679_typeString);
              _2678_typeI = (_2678_typeI) + (BigInteger.One);
            }
            _2677_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2677_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2680_argString;
          _2680_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2681_i;
          _2681_i = BigInteger.Zero;
          while ((_2681_i) < (new BigInteger((_2673_args).Count))) {
            if ((_2681_i).Sign == 1) {
              _2680_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2680_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2682_argExpr;
            bool _2683_isOwned;
            bool _2684_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2685_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1601;
            bool _out1602;
            bool _out1603;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1604;
            DCOMP.COMP.GenExpr((_2673_args).Select(_2681_i), selfIdent, @params, false, out _out1601, out _out1602, out _out1603, out _out1604);
            _2682_argExpr = _out1601;
            _2683_isOwned = _out1602;
            _2684_argErased = _out1603;
            _2685_argIdents = _out1604;
            if (_2683_isOwned) {
              _2682_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2682_argExpr);
            }
            _2680_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2680_argString, _2682_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2685_argIdents);
            _2681_i = (_2681_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2686_enclosingString;
          bool _2687___v88;
          bool _2688___v89;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2689_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1605;
          bool _out1606;
          bool _out1607;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1608;
          DCOMP.COMP.GenExpr(_2676_on, selfIdent, @params, false, out _out1605, out _out1606, out _out1607, out _out1608);
          _2686_enclosingString = _out1605;
          _2687___v88 = _out1606;
          _2688___v89 = _out1607;
          _2689_recIdents = _out1608;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2689_recIdents);
          DAST._IExpression _source78 = _2676_on;
          if (_source78.is_Literal) {
            DAST._ILiteral _2690___mcc_h1142 = _source78.dtor_Literal_a0;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2691___mcc_h1144 = _source78.dtor_Ident_a0;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2692___mcc_h1146 = _source78.dtor_Companion_a0;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2686_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2693___mcc_h1148 = _source78.dtor_Tuple_a0;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2694___mcc_h1150 = _source78.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2695___mcc_h1151 = _source78.dtor_args;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2696___mcc_h1154 = _source78.dtor_dims;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2697___mcc_h1156 = _source78.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2698___mcc_h1157 = _source78.dtor_variant;
            bool _2699___mcc_h1158 = _source78.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2700___mcc_h1159 = _source78.dtor_contents;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Convert) {
            DAST._IExpression _2701___mcc_h1164 = _source78.dtor_value;
            DAST._IType _2702___mcc_h1165 = _source78.dtor_from;
            DAST._IType _2703___mcc_h1166 = _source78.dtor_typ;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_SeqConstruct) {
            DAST._IExpression _2704___mcc_h1170 = _source78.dtor_length;
            DAST._IExpression _2705___mcc_h1171 = _source78.dtor_elem;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2706___mcc_h1174 = _source78.dtor_elements;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2707___mcc_h1176 = _source78.dtor_elements;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2708___mcc_h1178 = _source78.dtor_mapElems;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_This) {
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Ite) {
            DAST._IExpression _2709___mcc_h1180 = _source78.dtor_cond;
            DAST._IExpression _2710___mcc_h1181 = _source78.dtor_thn;
            DAST._IExpression _2711___mcc_h1182 = _source78.dtor_els;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_UnOp) {
            DAST._IUnaryOp _2712___mcc_h1186 = _source78.dtor_unOp;
            DAST._IExpression _2713___mcc_h1187 = _source78.dtor_expr;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_BinOp) {
            DAST._IBinOp _2714___mcc_h1190 = _source78.dtor_op;
            DAST._IExpression _2715___mcc_h1191 = _source78.dtor_left;
            DAST._IExpression _2716___mcc_h1192 = _source78.dtor_right;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_ArrayLen) {
            DAST._IExpression _2717___mcc_h1196 = _source78.dtor_expr;
            BigInteger _2718___mcc_h1197 = _source78.dtor_dim;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Select) {
            DAST._IExpression _2719___mcc_h1200 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2720___mcc_h1201 = _source78.dtor_field;
            bool _2721___mcc_h1202 = _source78.dtor_isConstant;
            bool _2722___mcc_h1203 = _source78.dtor_onDatatype;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_SelectFn) {
            DAST._IExpression _2723___mcc_h1208 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2724___mcc_h1209 = _source78.dtor_field;
            bool _2725___mcc_h1210 = _source78.dtor_onDatatype;
            bool _2726___mcc_h1211 = _source78.dtor_isStatic;
            BigInteger _2727___mcc_h1212 = _source78.dtor_arity;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Index) {
            DAST._IExpression _2728___mcc_h1218 = _source78.dtor_expr;
            DAST._ICollKind _2729___mcc_h1219 = _source78.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _2730___mcc_h1220 = _source78.dtor_indices;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_IndexRange) {
            DAST._IExpression _2731___mcc_h1224 = _source78.dtor_expr;
            bool _2732___mcc_h1225 = _source78.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _2733___mcc_h1226 = _source78.dtor_low;
            DAST._IOptional<DAST._IExpression> _2734___mcc_h1227 = _source78.dtor_high;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_TupleSelect) {
            DAST._IExpression _2735___mcc_h1232 = _source78.dtor_expr;
            BigInteger _2736___mcc_h1233 = _source78.dtor_index;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Call) {
            DAST._IExpression _2737___mcc_h1236 = _source78.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2738___mcc_h1237 = _source78.dtor_name;
            Dafny.ISequence<DAST._IType> _2739___mcc_h1238 = _source78.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2740___mcc_h1239 = _source78.dtor_args;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2741___mcc_h1244 = _source78.dtor_params;
            DAST._IType _2742___mcc_h1245 = _source78.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2743___mcc_h1246 = _source78.dtor_body;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2744___mcc_h1250 = _source78.dtor_values;
            DAST._IType _2745___mcc_h1251 = _source78.dtor_retType;
            DAST._IExpression _2746___mcc_h1252 = _source78.dtor_expr;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2747___mcc_h1256 = _source78.dtor_name;
            DAST._IType _2748___mcc_h1257 = _source78.dtor_typ;
            DAST._IExpression _2749___mcc_h1258 = _source78.dtor_value;
            DAST._IExpression _2750___mcc_h1259 = _source78.dtor_iifeBody;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_Apply) {
            DAST._IExpression _2751___mcc_h1264 = _source78.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2752___mcc_h1265 = _source78.dtor_args;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_TypeTest) {
            DAST._IExpression _2753___mcc_h1268 = _source78.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2754___mcc_h1269 = _source78.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2755___mcc_h1270 = _source78.dtor_variant;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_InitializationValue) {
            DAST._IType _2756___mcc_h1274 = _source78.dtor_typ;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_BoolBoundedPool) {
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_SetBoundedPool) {
            DAST._IExpression _2757___mcc_h1276 = _source78.dtor_of;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else if (_source78.is_SeqBoundedPool) {
            DAST._IExpression _2758___mcc_h1278 = _source78.dtor_of;
            bool _2759___mcc_h1279 = _source78.dtor_includeDuplicates;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          } else {
            DAST._IExpression _2760___mcc_h1282 = _source78.dtor_lo;
            DAST._IExpression _2761___mcc_h1283 = _source78.dtor_hi;
            {
              _2686_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2686_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.escapeIdent((_2675_name)));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2686_enclosingString, _2677_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2680_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2762___mcc_h203 = _source20.dtor_params;
        DAST._IType _2763___mcc_h204 = _source20.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2764___mcc_h205 = _source20.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2765_body = _2764___mcc_h205;
        DAST._IType _2766_retType = _2763___mcc_h204;
        Dafny.ISequence<DAST._IFormal> _2767_params = _2762___mcc_h203;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2768_paramNames;
          _2768_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2769_i;
          _2769_i = BigInteger.Zero;
          while ((_2769_i) < (new BigInteger((_2767_params).Count))) {
            _2768_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2768_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2767_params).Select(_2769_i)).dtor_name));
            _2769_i = (_2769_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2770_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2771_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1609;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1610;
          DCOMP.COMP.GenStmts(_2765_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2768_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1609, out _out1610);
          _2770_recursiveGen = _out1609;
          _2771_recIdents = _out1610;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2772_allReadCloned;
          _2772_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2771_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2773_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2771_recIdents).Elements) {
              _2773_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2771_recIdents).Contains(_2773_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1851)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2768_paramNames).Contains(_2773_next))) {
              _2772_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2772_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let ")), DCOMP.__default.escapeIdent(_2773_next)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), DCOMP.__default.escapeIdent(_2773_next)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2773_next));
            }
            _2771_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2771_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2773_next));
          }
          Dafny.ISequence<Dafny.Rune> _2774_paramsString;
          _2774_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          Dafny.ISequence<Dafny.Rune> _2775_paramTypes;
          _2775_paramTypes = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2769_i = BigInteger.Zero;
          while ((_2769_i) < (new BigInteger((_2767_params).Count))) {
            if ((_2769_i).Sign == 1) {
              _2774_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2774_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              _2775_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(_2775_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2776_typStr;
            Dafny.ISequence<Dafny.Rune> _out1611;
            _out1611 = DCOMP.COMP.GenType(((_2767_params).Select(_2769_i)).dtor_typ, false, true);
            _2776_typStr = _out1611;
            _2774_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2774_paramsString, ((_2767_params).Select(_2769_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2776_typStr);
            _2775_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2775_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _2776_typStr);
            _2769_i = (_2769_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2777_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1612;
          _out1612 = DCOMP.COMP.GenType(_2766_retType, false, true);
          _2777_retTypeGen = _out1612;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper::<::std::rc::Rc<dyn Fn("), _2775_paramTypes), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _2777_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>({\n")), _2772_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(move |")), _2774_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2777_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2770_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_BetaRedex) {
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2778___mcc_h206 = _source20.dtor_values;
        DAST._IType _2779___mcc_h207 = _source20.dtor_retType;
        DAST._IExpression _2780___mcc_h208 = _source20.dtor_expr;
        DAST._IExpression _2781_expr = _2780___mcc_h208;
        DAST._IType _2782_retType = _2779___mcc_h207;
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2783_values = _2778___mcc_h206;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2784_paramNames;
          _2784_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2785_paramNamesSet;
          _2785_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2786_i;
          _2786_i = BigInteger.Zero;
          while ((_2786_i) < (new BigInteger((_2783_values).Count))) {
            _2784_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2784_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2783_values).Select(_2786_i)).dtor__0).dtor_name));
            _2785_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2785_paramNamesSet, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2783_values).Select(_2786_i)).dtor__0).dtor_name));
            _2786_i = (_2786_i) + (BigInteger.One);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          Dafny.ISequence<Dafny.Rune> _2787_paramsString;
          _2787_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2786_i = BigInteger.Zero;
          while ((_2786_i) < (new BigInteger((_2783_values).Count))) {
            if ((_2786_i).Sign == 1) {
              _2787_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2787_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2788_typStr;
            Dafny.ISequence<Dafny.Rune> _out1613;
            _out1613 = DCOMP.COMP.GenType((((_2783_values).Select(_2786_i)).dtor__0).dtor_typ, false, true);
            _2788_typStr = _out1613;
            Dafny.ISequence<Dafny.Rune> _2789_valueGen;
            bool _2790___v92;
            bool _2791_valueErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2792_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1614;
            bool _out1615;
            bool _out1616;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1617;
            DCOMP.COMP.GenExpr(((_2783_values).Select(_2786_i)).dtor__1, selfIdent, @params, true, out _out1614, out _out1615, out _out1616, out _out1617);
            _2789_valueGen = _out1614;
            _2790___v92 = _out1615;
            _2791_valueErased = _out1616;
            _2792_recIdents = _out1617;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let ")), DCOMP.__default.escapeIdent((((_2783_values).Select(_2786_i)).dtor__0).dtor_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _2788_typStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2792_recIdents);
            if (_2791_valueErased) {
              _2789_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2789_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2789_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            _2786_i = (_2786_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2793_recGen;
          bool _2794_recOwned;
          bool _2795_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2796_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1618;
          bool _out1619;
          bool _out1620;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1621;
          DCOMP.COMP.GenExpr(_2781_expr, selfIdent, _2784_paramNames, mustOwn, out _out1618, out _out1619, out _out1620, out _out1621);
          _2793_recGen = _out1618;
          _2794_recOwned = _out1619;
          _2795_recErased = _out1620;
          _2796_recIdents = _out1621;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2796_recIdents, _2785_paramNamesSet);
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2793_recGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2794_recOwned;
          isErased = _2795_recErased;
        }
      } else if (_source20.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2797___mcc_h209 = _source20.dtor_name;
        DAST._IType _2798___mcc_h210 = _source20.dtor_typ;
        DAST._IExpression _2799___mcc_h211 = _source20.dtor_value;
        DAST._IExpression _2800___mcc_h212 = _source20.dtor_iifeBody;
        DAST._IExpression _2801_iifeBody = _2800___mcc_h212;
        DAST._IExpression _2802_value = _2799___mcc_h211;
        DAST._IType _2803_tpe = _2798___mcc_h210;
        Dafny.ISequence<Dafny.Rune> _2804_name = _2797___mcc_h209;
        {
          Dafny.ISequence<Dafny.Rune> _2805_valueGen;
          bool _2806___v93;
          bool _2807_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2808_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1622;
          bool _out1623;
          bool _out1624;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1625;
          DCOMP.COMP.GenExpr(_2802_value, selfIdent, @params, true, out _out1622, out _out1623, out _out1624, out _out1625);
          _2805_valueGen = _out1622;
          _2806___v93 = _out1623;
          _2807_valueErased = _out1624;
          _2808_recIdents = _out1625;
          if (_2807_valueErased) {
            _2805_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2805_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2808_recIdents;
          Dafny.ISequence<Dafny.Rune> _2809_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1626;
          _out1626 = DCOMP.COMP.GenType(_2803_tpe, false, true);
          _2809_valueTypeGen = _out1626;
          Dafny.ISequence<Dafny.Rune> _2810_bodyGen;
          bool _2811___v94;
          bool _2812_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2813_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1627;
          bool _out1628;
          bool _out1629;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1630;
          DCOMP.COMP.GenExpr(_2801_iifeBody, selfIdent, @params, true, out _out1627, out _out1628, out _out1629, out _out1630);
          _2810_bodyGen = _out1627;
          _2811___v94 = _out1628;
          _2812_bodyErased = _out1629;
          _2813_bodyIdents = _out1630;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2813_bodyIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_2804_name))));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet "), DCOMP.__default.escapeIdent((_2804_name))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _2809_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2805_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2810_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = true;
          isErased = _2812_bodyErased;
        }
      } else if (_source20.is_Apply) {
        DAST._IExpression _2814___mcc_h213 = _source20.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2815___mcc_h214 = _source20.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2816_args = _2815___mcc_h214;
        DAST._IExpression _2817_func = _2814___mcc_h213;
        {
          Dafny.ISequence<Dafny.Rune> _2818_funcString;
          bool _2819___v95;
          bool _2820_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2821_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1631;
          bool _out1632;
          bool _out1633;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1634;
          DCOMP.COMP.GenExpr(_2817_func, selfIdent, @params, false, out _out1631, out _out1632, out _out1633, out _out1634);
          _2818_funcString = _out1631;
          _2819___v95 = _out1632;
          _2820_funcErased = _out1633;
          _2821_recIdents = _out1634;
          readIdents = _2821_recIdents;
          Dafny.ISequence<Dafny.Rune> _2822_argString;
          _2822_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2823_i;
          _2823_i = BigInteger.Zero;
          while ((_2823_i) < (new BigInteger((_2816_args).Count))) {
            if ((_2823_i).Sign == 1) {
              _2822_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2822_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2824_argExpr;
            bool _2825_isOwned;
            bool _2826_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2827_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1635;
            bool _out1636;
            bool _out1637;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1638;
            DCOMP.COMP.GenExpr((_2816_args).Select(_2823_i), selfIdent, @params, false, out _out1635, out _out1636, out _out1637, out _out1638);
            _2824_argExpr = _out1635;
            _2825_isOwned = _out1636;
            _2826_argErased = _out1637;
            _2827_argIdents = _out1638;
            if (_2825_isOwned) {
              _2824_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2824_argExpr);
            }
            _2822_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2822_argString, _2824_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2827_argIdents);
            _2823_i = (_2823_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2818_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2822_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source20.is_TypeTest) {
        DAST._IExpression _2828___mcc_h215 = _source20.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2829___mcc_h216 = _source20.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2830___mcc_h217 = _source20.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2831_variant = _2830___mcc_h217;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2832_dType = _2829___mcc_h216;
        DAST._IExpression _2833_on = _2828___mcc_h215;
        {
          Dafny.ISequence<Dafny.Rune> _2834_exprGen;
          bool _2835___v96;
          bool _2836_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2837_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1639;
          bool _out1640;
          bool _out1641;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1642;
          DCOMP.COMP.GenExpr(_2833_on, selfIdent, @params, false, out _out1639, out _out1640, out _out1641, out _out1642);
          _2834_exprGen = _out1639;
          _2835___v96 = _out1640;
          _2836_exprErased = _out1641;
          _2837_recIdents = _out1642;
          Dafny.ISequence<Dafny.Rune> _2838_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1643;
          _out1643 = DCOMP.COMP.GenPath(_2832_dType);
          _2838_dTypePath = _out1643;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2834_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2838_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), DCOMP.__default.escapeIdent(_2831_variant)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2837_recIdents;
        }
      } else if (_source20.is_InitializationValue) {
        DAST._IType _2839___mcc_h218 = _source20.dtor_typ;
        DAST._IType _2840_typ = _2839___mcc_h218;
        {
          Dafny.ISequence<Dafny.Rune> _2841_typString;
          Dafny.ISequence<Dafny.Rune> _out1644;
          _out1644 = DCOMP.COMP.GenType(_2840_typ, false, false);
          _2841_typString = _out1644;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2841_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
          isOwned = true;
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source20.is_BoolBoundedPool) {
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[false, true]");
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source20.is_SetBoundedPool) {
        DAST._IExpression _2842___mcc_h219 = _source20.dtor_of;
        DAST._IExpression _2843_of = _2842___mcc_h219;
        {
          Dafny.ISequence<Dafny.Rune> _2844_exprGen;
          bool _2845___v97;
          bool _2846_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2847_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1645;
          bool _out1646;
          bool _out1647;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1648;
          DCOMP.COMP.GenExpr(_2843_of, selfIdent, @params, false, out _out1645, out _out1646, out _out1647, out _out1648);
          _2844_exprGen = _out1645;
          _2845___v97 = _out1646;
          _2846_exprErased = _out1647;
          _2847_recIdents = _out1648;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2844_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").iter()"));
          isOwned = true;
          isErased = _2846_exprErased;
          readIdents = _2847_recIdents;
        }
      } else if (_source20.is_SeqBoundedPool) {
        DAST._IExpression _2848___mcc_h220 = _source20.dtor_of;
        bool _2849___mcc_h221 = _source20.dtor_includeDuplicates;
        bool _2850_includeDuplicates = _2849___mcc_h221;
        DAST._IExpression _2851_of = _2848___mcc_h220;
        {
          Dafny.ISequence<Dafny.Rune> _2852_exprGen;
          bool _2853___v98;
          bool _2854_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2855_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1649;
          bool _out1650;
          bool _out1651;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1652;
          DCOMP.COMP.GenExpr(_2851_of, selfIdent, @params, false, out _out1649, out _out1650, out _out1651, out _out1652);
          _2852_exprGen = _out1649;
          _2853___v98 = _out1650;
          _2854_exprErased = _out1651;
          _2855_recIdents = _out1652;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2852_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").iter()"));
          if (!(_2850_includeDuplicates)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::itertools::Itertools::unique("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          isErased = _2854_exprErased;
          readIdents = _2855_recIdents;
        }
      } else {
        DAST._IExpression _2856___mcc_h222 = _source20.dtor_lo;
        DAST._IExpression _2857___mcc_h223 = _source20.dtor_hi;
        DAST._IExpression _2858_hi = _2857___mcc_h223;
        DAST._IExpression _2859_lo = _2856___mcc_h222;
        {
          Dafny.ISequence<Dafny.Rune> _2860_loString;
          bool _2861___v99;
          bool _2862_loErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2863_recIdentsLo;
          Dafny.ISequence<Dafny.Rune> _out1653;
          bool _out1654;
          bool _out1655;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1656;
          DCOMP.COMP.GenExpr(_2859_lo, selfIdent, @params, true, out _out1653, out _out1654, out _out1655, out _out1656);
          _2860_loString = _out1653;
          _2861___v99 = _out1654;
          _2862_loErased = _out1655;
          _2863_recIdentsLo = _out1656;
          Dafny.ISequence<Dafny.Rune> _2864_hiString;
          bool _2865___v100;
          bool _2866_hiErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2867_recIdentsHi;
          Dafny.ISequence<Dafny.Rune> _out1657;
          bool _out1658;
          bool _out1659;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1660;
          DCOMP.COMP.GenExpr(_2858_hi, selfIdent, @params, true, out _out1657, out _out1658, out _out1659, out _out1660);
          _2864_hiString = _out1657;
          _2865___v100 = _out1658;
          _2866_hiErased = _out1659;
          _2867_recIdentsHi = _out1660;
          if (!(_2862_loErased)) {
            _2860_loString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2860_loString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2866_hiErased)) {
            _2864_hiString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2864_hiString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::integer_range("), _2860_loString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2864_hiString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2863_recIdentsLo, _2867_recIdentsHi);
        }
      }
    }
    public static Dafny.ISequence<Dafny.Rune> Compile(Dafny.ISequence<DAST._IModule> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#![allow(warnings, unconditional_panic)]\n");
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("extern crate dafny_runtime;\n"));
      BigInteger _2868_i;
      _2868_i = BigInteger.Zero;
      while ((_2868_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2869_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1661;
        _out1661 = DCOMP.COMP.GenModule((p).Select(_2868_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2869_generated = _out1661;
        if ((_2868_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2869_generated);
        _2868_i = (_2868_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2870_i;
      _2870_i = BigInteger.Zero;
      while ((_2870_i) < (new BigInteger((fullName).Count))) {
        if ((_2870_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2870_i));
        _2870_i = (_2870_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

