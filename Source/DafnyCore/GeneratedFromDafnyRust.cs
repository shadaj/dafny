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
      hash = ((hash << 5) + hash) + 3;
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
    public static _IStatement create_Foreach(Dafny.ISequence<Dafny.Rune> boundName, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) {
      return new Statement_Foreach(boundName, over, body);
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
    public readonly DAST._IExpression _over;
    public readonly Dafny.ISequence<DAST._IStatement> _body;
    public Statement_Foreach(Dafny.ISequence<Dafny.Rune> boundName, DAST._IExpression over, Dafny.ISequence<DAST._IStatement> body) : base() {
      this._boundName = boundName;
      this._over = over;
      this._body = body;
    }
    public override _IStatement DowncastClone() {
      if (this is _IStatement dt) { return dt; }
      return new Statement_Foreach(_boundName, _over, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Statement_Foreach;
      return oth != null && object.Equals(this._boundName, oth._boundName) && object.Equals(this._over, oth._over) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 5;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._boundName));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._over));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._body));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Statement.Foreach";
      s += "(";
      s += this._boundName.ToVerbatimString(true);
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
    public static _IExpression create_ArrayLen(DAST._IExpression expr) {
      return new Expression_ArrayLen(expr);
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
    public Expression_ArrayLen(DAST._IExpression expr) : base() {
      this._expr = expr;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_ArrayLen(_expr);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_ArrayLen;
      return oth != null && object.Equals(this._expr, oth._expr);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 15;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.ArrayLen";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
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
          } else if (_source2.is_Seq) {
            DAST._IType _51___mcc_h19 = _source2.dtor_element;
          } else if (_source2.is_Set) {
            DAST._IType _52___mcc_h21 = _source2.dtor_element;
          } else if (_source2.is_Multiset) {
            DAST._IType _53___mcc_h23 = _source2.dtor_element;
          } else if (_source2.is_Map) {
            DAST._IType _54___mcc_h25 = _source2.dtor_key;
            DAST._IType _55___mcc_h26 = _source2.dtor_value;
          } else if (_source2.is_Arrow) {
            Dafny.ISequence<DAST._IType> _56___mcc_h29 = _source2.dtor_args;
            DAST._IType _57___mcc_h30 = _source2.dtor_result;
          } else if (_source2.is_Primitive) {
            DAST._IPrimitive _58___mcc_h33 = _source2.dtor_Primitive_a0;
          } else if (_source2.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _59___mcc_h35 = _source2.dtor_Passthrough_a0;
          } else {
            Dafny.ISequence<Dafny.Rune> _60___mcc_h37 = _source2.dtor_TypeArg_a0;
          }
          _34_i = (_34_i) + (BigInteger.One);
        }
      }
      Dafny.ISequence<Dafny.Rune> _61_defaultImpl;
      _61_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _61_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_61_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      _61_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_61_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new()\n"));
      _61_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_61_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      _61_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_61_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      Dafny.ISequence<Dafny.Rune> _62_printImpl;
      _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n"));
      _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_62_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"")), ((c).dtor_enclosingModule)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _63_ptrPartialEqImpl;
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _63_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_63_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _61_defaultImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _62_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _63_ptrPartialEqImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTrait(DAST._ITrait t, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _64_typeParamsSet;
      _64_typeParamsSet = Dafny.Set<DAST._IType>.FromElements();
      Dafny.ISequence<Dafny.Rune> _65_typeParams;
      _65_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _66_tpI;
      _66_tpI = BigInteger.Zero;
      if ((new BigInteger(((t).dtor_typeParams).Count)).Sign == 1) {
        _65_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_66_tpI) < (new BigInteger(((t).dtor_typeParams).Count))) {
          DAST._IType _67_tp;
          _67_tp = ((t).dtor_typeParams).Select(_66_tpI);
          _64_typeParamsSet = Dafny.Set<DAST._IType>.Union(_64_typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_67_tp));
          Dafny.ISequence<Dafny.Rune> _68_genTp;
          Dafny.ISequence<Dafny.Rune> _out21;
          _out21 = DCOMP.COMP.GenType(_67_tp, false, false);
          _68_genTp = _out21;
          _65_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_65_typeParams, _68_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          _66_tpI = (_66_tpI) + (BigInteger.One);
        }
        _65_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(_65_typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _69_fullPath;
      _69_fullPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((t).dtor_name));
      Dafny.ISequence<Dafny.Rune> _70_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _71___v6;
      Dafny.ISequence<Dafny.Rune> _out22;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out23;
      DCOMP.COMP.GenClassImplBody((t).dtor_body, true, DAST.Type.create_Path(_69_fullPath, Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Trait(_69_fullPath)), _64_typeParamsSet, out _out22, out _out23);
      _70_implBody = _out22;
      _71___v6 = _out23;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait r#"), (t).dtor_name), _65_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _70_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenNewtype(DAST._INewtype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _72_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _73_typeParams;
      Dafny.ISequence<Dafny.Rune> _74_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out24;
      Dafny.ISequence<Dafny.Rune> _out25;
      Dafny.ISequence<Dafny.Rune> _out26;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out24, out _out25, out _out26);
      _72_typeParamsSet = _out24;
      _73_typeParams = _out25;
      _74_constrainedTypeParams = _out26;
      Dafny.ISequence<Dafny.Rune> _75_underlyingType;
      Dafny.ISequence<Dafny.Rune> _out27;
      _out27 = DCOMP.COMP.GenType((c).dtor_base, false, false);
      _75_underlyingType = _out27;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Clone, PartialEq)]\n#[repr(transparent)]\npub struct r#"), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(pub ")), _75_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _74_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = ")), _75_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase(&self) -> &Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase_owned(self) -> Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _74_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), _75_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &")), _75_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unsafe { &*(x as *const ")), _75_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as *const r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") }\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: ")), _75_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(x)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _74_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _74_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      DAST._IOptional<DAST._IExpression> _source4 = (c).dtor_witnessExpr;
      if (_source4.is_Some) {
        DAST._IExpression _76___mcc_h0 = _source4.dtor_Some_a0;
        DAST._IExpression _77_e = _76___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _78_eStr;
          bool _79___v7;
          bool _80___v8;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _81___v9;
          Dafny.ISequence<Dafny.Rune> _out28;
          bool _out29;
          bool _out30;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out31;
          DCOMP.COMP.GenExpr(_77_e, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out28, out _out29, out _out30, out _out31);
          _78_eStr = _out28;
          _79___v7 = _out29;
          _80___v8 = _out30;
          _81___v9 = _out31;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _78_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(::std::default::Default::default())\n"));
        }
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _74_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _73_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, in_seq: bool) -> ::std::fmt::Result {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyPrint::fmt_print(&self.0, __fmt_print_formatter, in_seq)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenDatatype(DAST._IDatatype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _82_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _83_typeParams;
      Dafny.ISequence<Dafny.Rune> _84_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out32;
      Dafny.ISequence<Dafny.Rune> _out33;
      Dafny.ISequence<Dafny.Rune> _out34;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out32, out _out33, out _out34);
      _82_typeParamsSet = _out32;
      _83_typeParams = _out33;
      _84_constrainedTypeParams = _out34;
      Dafny.ISequence<Dafny.Rune> _85_ctors;
      _85_ctors = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _86_i;
      _86_i = BigInteger.Zero;
      while ((_86_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _87_ctor;
        _87_ctor = ((c).dtor_ctors).Select(_86_i);
        Dafny.ISequence<Dafny.Rune> _88_ctorBody;
        _88_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_87_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        BigInteger _89_j;
        _89_j = BigInteger.Zero;
        while ((_89_j) < (new BigInteger(((_87_ctor).dtor_args).Count))) {
          DAST._IFormal _90_formal;
          _90_formal = ((_87_ctor).dtor_args).Select(_89_j);
          Dafny.ISequence<Dafny.Rune> _91_formalType;
          Dafny.ISequence<Dafny.Rune> _out35;
          _out35 = DCOMP.COMP.GenType((_90_formal).dtor_typ, false, false);
          _91_formalType = _out35;
          if ((c).dtor_isCo) {
            _88_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_88_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_90_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper<")), _91_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">, "));
          } else {
            _88_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_88_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_90_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _91_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          _89_j = (_89_j) + (BigInteger.One);
        }
        _88_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(_88_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        _85_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_85_ctors, _88_ctorBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
        _86_i = (_86_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _92_selfPath;
      _92_selfPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((c).dtor_name);
      Dafny.ISequence<Dafny.Rune> _93_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _94_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out36;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out37;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(_92_selfPath)), _82_typeParamsSet, out _out36, out _out37);
      _93_implBody = _out36;
      _94_traitBodies = _out37;
      _86_i = BigInteger.Zero;
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _95_emittedFields;
      _95_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      while ((_86_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _96_ctor;
        _96_ctor = ((c).dtor_ctors).Select(_86_i);
        BigInteger _97_j;
        _97_j = BigInteger.Zero;
        while ((_97_j) < (new BigInteger(((_96_ctor).dtor_args).Count))) {
          DAST._IFormal _98_formal;
          _98_formal = ((_96_ctor).dtor_args).Select(_97_j);
          if (!((_95_emittedFields).Contains((_98_formal).dtor_name))) {
            _95_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_95_emittedFields, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_98_formal).dtor_name));
            Dafny.ISequence<Dafny.Rune> _99_formalType;
            Dafny.ISequence<Dafny.Rune> _out38;
            _out38 = DCOMP.COMP.GenType((_98_formal).dtor_typ, false, false);
            _99_formalType = _out38;
            Dafny.ISequence<Dafny.Rune> _100_methodBody;
            _100_methodBody = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n");
            BigInteger _101_k;
            _101_k = BigInteger.Zero;
            while ((_101_k) < (new BigInteger(((c).dtor_ctors).Count))) {
              DAST._IDatatypeCtor _102_ctor2;
              _102_ctor2 = ((c).dtor_ctors).Select(_101_k);
              Dafny.ISequence<Dafny.Rune> _103_ctorMatch;
              _103_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_102_ctor2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
              BigInteger _104_l;
              _104_l = BigInteger.Zero;
              bool _105_hasMatchingField;
              _105_hasMatchingField = false;
              while ((_104_l) < (new BigInteger(((_102_ctor2).dtor_args).Count))) {
                DAST._IFormal _106_formal2;
                _106_formal2 = ((_102_ctor2).dtor_args).Select(_104_l);
                if (((_98_formal).dtor_name).Equals((_106_formal2).dtor_name)) {
                  _105_hasMatchingField = true;
                }
                _103_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_103_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_106_formal2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                _104_l = (_104_l) + (BigInteger.One);
              }
              if (_105_hasMatchingField) {
                if ((c).dtor_isCo) {
                  _103_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_103_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ::std::ops::Deref::deref(&")), (_98_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0),\n"));
                } else {
                  _103_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_103_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ")), (_98_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
                }
              } else {
                _103_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_103_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => panic!(\"field does not exist on this variant\"),\n"));
              }
              _100_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_100_methodBody, _103_ctorMatch);
              _101_k = (_101_k) + (BigInteger.One);
            }
            if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
              _100_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_100_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => panic!(),\n"));
            }
            _100_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_100_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            _93_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_93_implBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#")), (_98_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&self) -> &")), _99_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _100_methodBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
          }
          _97_j = (_97_j) + (BigInteger.One);
        }
        _86_i = (_86_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _85_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_85_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_PhantomVariant("));
        BigInteger _107_typeI;
        _107_typeI = BigInteger.Zero;
        while ((_107_typeI) < (new BigInteger(((c).dtor_typeParams).Count))) {
          if ((_107_typeI).Sign == 1) {
            _85_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_85_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _108_genTp;
          Dafny.ISequence<Dafny.Rune> _out39;
          _out39 = DCOMP.COMP.GenType(((c).dtor_typeParams).Select(_107_typeI), false, false);
          _108_genTp = _out39;
          _85_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_85_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::marker::PhantomData::<")), _108_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          _107_typeI = (_107_typeI) + (BigInteger.One);
        }
        _85_ctors = Dafny.Sequence<Dafny.Rune>.Concat(_85_ctors, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      Dafny.ISequence<Dafny.Rune> _109_enumBody;
      _109_enumBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(PartialEq)]\npub enum r#"), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _85_ctors), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _84_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _93_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _110_identEraseImpls;
      _110_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _84_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = Self;\nfn erase(&self) -> &Self::Erased { self }\nfn erase_owned(self) -> Self::Erased { self }}\n"));
      _110_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_110_identEraseImpls, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _84_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn unerase(x: &Self) -> &Self { x }\nfn unerase_owned(x: Self) -> Self { x }}\n"));
      Dafny.ISequence<Dafny.Rune> _111_printImpl;
      _111_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _84_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n"));
      _86_i = BigInteger.Zero;
      while ((_86_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _112_ctor;
        _112_ctor = ((c).dtor_ctors).Select(_86_i);
        Dafny.ISequence<Dafny.Rune> _113_ctorMatch;
        _113_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_112_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        Dafny.ISequence<Dafny.Rune> _114_modulePrefix;
        _114_modulePrefix = (((((c).dtor_enclosingModule)).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_module"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(((c).dtor_enclosingModule), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("."))));
        Dafny.ISequence<Dafny.Rune> _115_printRhs;
        _115_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \""), _114_modulePrefix), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (_112_ctor).dtor_name), (((_112_ctor).dtor_hasAnyArgs) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(\")?;")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"))));
        BigInteger _116_j;
        _116_j = BigInteger.Zero;
        while ((_116_j) < (new BigInteger(((_112_ctor).dtor_args).Count))) {
          DAST._IFormal _117_formal;
          _117_formal = ((_112_ctor).dtor_args).Select(_116_j);
          _113_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_113_ctorMatch, (_117_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          if ((_116_j).Sign == 1) {
            _115_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_115_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
          }
          _115_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_115_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(")), (_117_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", __fmt_print_formatter, false)?;"));
          _116_j = (_116_j) + (BigInteger.One);
        }
        _113_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_113_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        if ((_112_ctor).dtor_hasAnyArgs) {
          _115_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_115_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
        }
        _115_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_115_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())"));
        _111_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_111_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _113_ctorMatch), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" => {\n")), _115_printRhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
        _86_i = (_86_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _111_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_111_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => {panic!()\n}\n"));
      }
      _111_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_111_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _118_defaultImpl;
      _118_defaultImpl = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_ctors).Count)).Sign == 1) {
        _118_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _84_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _83_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (((c).dtor_ctors).Select(BigInteger.Zero)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        _86_i = BigInteger.Zero;
        while ((_86_i) < (new BigInteger(((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Count))) {
          DAST._IFormal _119_formal;
          _119_formal = ((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Select(_86_i);
          _118_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_118_defaultImpl, (_119_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": std::default::Default::default(),\n"));
          _86_i = (_86_i) + (BigInteger.One);
        }
        _118_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_118_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_109_enumBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _110_identEraseImpls), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _111_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _118_defaultImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenPath(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      if ((new BigInteger((p).Count)).Sign == 0) {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Self");
        return s;
      } else {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("super::");
        BigInteger _120_i;
        _120_i = BigInteger.Zero;
        while ((_120_i) < (new BigInteger((p).Count))) {
          if ((_120_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((p).Select(_120_i)));
          _120_i = (_120_i) + (BigInteger.One);
        }
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTypeArgs(Dafny.ISequence<DAST._IType> args, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger((args).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _121_i;
        _121_i = BigInteger.Zero;
        while ((_121_i) < (new BigInteger((args).Count))) {
          if ((_121_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _122_genTp;
          Dafny.ISequence<Dafny.Rune> _out40;
          _out40 = DCOMP.COMP.GenType((args).Select(_121_i), inBinding, inFn);
          _122_genTp = _out40;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _122_genTp);
          _121_i = (_121_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenType(DAST._IType c, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      DAST._IType _source5 = c;
      if (_source5.is_Path) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _123___mcc_h0 = _source5.dtor_Path_a0;
        Dafny.ISequence<DAST._IType> _124___mcc_h1 = _source5.dtor_typeArgs;
        DAST._IResolvedType _125___mcc_h2 = _source5.dtor_resolved;
        DAST._IResolvedType _126_resolved = _125___mcc_h2;
        Dafny.ISequence<DAST._IType> _127_args = _124___mcc_h1;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _128_p = _123___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _out41;
          _out41 = DCOMP.COMP.GenPath(_128_p);
          s = _out41;
          Dafny.ISequence<Dafny.Rune> _129_typeArgs;
          Dafny.ISequence<Dafny.Rune> _out42;
          _out42 = DCOMP.COMP.GenTypeArgs(_127_args, inBinding, inFn);
          _129_typeArgs = _out42;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _129_typeArgs);
          DAST._IResolvedType _source6 = _126_resolved;
          if (_source6.is_Datatype) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _130___mcc_h17 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _131___mcc_h19 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IType _132___mcc_h21 = _source6.dtor_Newtype_a0;
            DAST._IResolvedType _133_Primitive = _126_resolved;
          }
        }
      } else if (_source5.is_Nullable) {
        DAST._IType _134___mcc_h3 = _source5.dtor_Nullable_a0;
        DAST._IType _135_inner = _134___mcc_h3;
        {
          Dafny.ISequence<Dafny.Rune> _136_innerStr;
          Dafny.ISequence<Dafny.Rune> _out43;
          _out43 = DCOMP.COMP.GenType(_135_inner, inBinding, inFn);
          _136_innerStr = _out43;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::option::Option<"), _136_innerStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Tuple) {
        Dafny.ISequence<DAST._IType> _137___mcc_h4 = _source5.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _138_types = _137___mcc_h4;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _139_i;
          _139_i = BigInteger.Zero;
          while ((_139_i) < (new BigInteger((_138_types).Count))) {
            if ((_139_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _140_generated;
            Dafny.ISequence<Dafny.Rune> _out44;
            _out44 = DCOMP.COMP.GenType((_138_types).Select(_139_i), inBinding, inFn);
            _140_generated = _out44;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _140_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _139_i = (_139_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source5.is_Array) {
        DAST._IType _141___mcc_h5 = _source5.dtor_element;
        DAST._IType _142_element = _141___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _143_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_142_element, inBinding, inFn);
          _143_elemStr = _out45;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<::std::cell::RefCell<::std::vec::Vec<"), _143_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>>"));
        }
      } else if (_source5.is_Seq) {
        DAST._IType _144___mcc_h6 = _source5.dtor_element;
        DAST._IType _145_element = _144___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _146_elemStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_145_element, inBinding, inFn);
          _146_elemStr = _out46;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _146_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _147___mcc_h7 = _source5.dtor_element;
        DAST._IType _148_element = _147___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _149_elemStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_148_element, inBinding, inFn);
          _149_elemStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _149_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _150___mcc_h8 = _source5.dtor_element;
        DAST._IType _151_element = _150___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _152_elemStr;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenType(_151_element, inBinding, inFn);
          _152_elemStr = _out48;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _152_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _153___mcc_h9 = _source5.dtor_key;
        DAST._IType _154___mcc_h10 = _source5.dtor_value;
        DAST._IType _155_value = _154___mcc_h10;
        DAST._IType _156_key = _153___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _157_keyStr;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenType(_156_key, inBinding, inFn);
          _157_keyStr = _out49;
          Dafny.ISequence<Dafny.Rune> _158_valueStr;
          Dafny.ISequence<Dafny.Rune> _out50;
          _out50 = DCOMP.COMP.GenType(_155_value, inBinding, inFn);
          _158_valueStr = _out50;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _157_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _158_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _159___mcc_h11 = _source5.dtor_args;
        DAST._IType _160___mcc_h12 = _source5.dtor_result;
        DAST._IType _161_result = _160___mcc_h12;
        Dafny.ISequence<DAST._IType> _162_args = _159___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::rc::Rc<dyn ::std::ops::Fn(");
          BigInteger _163_i;
          _163_i = BigInteger.Zero;
          while ((_163_i) < (new BigInteger((_162_args).Count))) {
            if ((_163_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _164_generated;
            Dafny.ISequence<Dafny.Rune> _out51;
            _out51 = DCOMP.COMP.GenType((_162_args).Select(_163_i), inBinding, true);
            _164_generated = _out51;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _164_generated);
            _163_i = (_163_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _165_resultType;
          Dafny.ISequence<Dafny.Rune> _out52;
          _out52 = DCOMP.COMP.GenType(_161_result, inBinding, (inFn) || (inBinding));
          _165_resultType = _out52;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _165_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _166___mcc_h13 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _167_p = _166___mcc_h13;
        {
          DAST._IPrimitive _source7 = _167_p;
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
        Dafny.ISequence<Dafny.Rune> _168___mcc_h14 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _169_v = _168___mcc_h14;
        s = _169_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _170___mcc_h15 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _170___mcc_h15;
        Dafny.ISequence<Dafny.Rune> _171___mcc_h16 = _source8;
        Dafny.ISequence<Dafny.Rune> _172_name = _171___mcc_h16;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _172_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _173_i;
      _173_i = BigInteger.Zero;
      while ((_173_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_173_i);
        DAST._IMethod _174___mcc_h0 = _source9;
        DAST._IMethod _175_m = _174___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_175_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _176___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _177_p = _176___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _178_existing;
              _178_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_177_p)) {
                _178_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _177_p);
              }
              if ((new BigInteger((_178_existing).Count)).Sign == 1) {
                _178_existing = Dafny.Sequence<Dafny.Rune>.Concat(_178_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _179_genMethod;
              Dafny.ISequence<Dafny.Rune> _out53;
              _out53 = DCOMP.COMP.GenMethod(_175_m, true, enclosingType, enclosingTypeParams);
              _179_genMethod = _out53;
              _178_existing = Dafny.Sequence<Dafny.Rune>.Concat(_178_existing, _179_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_177_p, _178_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _180_generated;
              Dafny.ISequence<Dafny.Rune> _out54;
              _out54 = DCOMP.COMP.GenMethod(_175_m, forTrait, enclosingType, enclosingTypeParams);
              _180_generated = _out54;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _180_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _173_i = (_173_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _181_i;
      _181_i = BigInteger.Zero;
      while ((_181_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _182_param;
        _182_param = (@params).Select(_181_i);
        Dafny.ISequence<Dafny.Rune> _183_paramType;
        Dafny.ISequence<Dafny.Rune> _out55;
        _out55 = DCOMP.COMP.GenType((_182_param).dtor_typ, false, false);
        _183_paramType = _out55;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_182_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _183_paramType);
        if ((_181_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _181_i = (_181_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _184_params;
      Dafny.ISequence<Dafny.Rune> _out56;
      _out56 = DCOMP.COMP.GenParams((m).dtor_params);
      _184_params = _out56;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _185_paramNames;
      _185_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _186_paramI;
      _186_paramI = BigInteger.Zero;
      while ((_186_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _185_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_185_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_186_paramI)).dtor_name));
        _186_paramI = (_186_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _184_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _184_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _187_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out57;
          _out57 = DCOMP.COMP.GenType(enclosingType, false, false);
          _187_enclosingTypeString = _out57;
          _184_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _187_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _184_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _188_retType;
      _188_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _189_typeI;
      _189_typeI = BigInteger.Zero;
      while ((_189_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_189_typeI).Sign == 1) {
          _188_retType = Dafny.Sequence<Dafny.Rune>.Concat(_188_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _190_typeString;
        Dafny.ISequence<Dafny.Rune> _out58;
        _out58 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_189_typeI), false, false);
        _190_typeString = _out58;
        _188_retType = Dafny.Sequence<Dafny.Rune>.Concat(_188_retType, _190_typeString);
        _189_typeI = (_189_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _188_retType = Dafny.Sequence<Dafny.Rune>.Concat(_188_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _191_typeParamsFiltered;
      _191_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _192_typeParamI;
      _192_typeParamI = BigInteger.Zero;
      while ((_192_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _193_typeParam;
        _193_typeParam = ((m).dtor_typeParams).Select(_192_typeParamI);
        if (!((enclosingTypeParams).Contains(_193_typeParam))) {
          _191_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_191_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_193_typeParam));
        }
        _192_typeParamI = (_192_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_191_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _194_i;
        _194_i = BigInteger.Zero;
        while ((_194_i) < (new BigInteger((_191_typeParamsFiltered).Count))) {
          if ((_194_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _195_typeString;
          Dafny.ISequence<Dafny.Rune> _out59;
          _out59 = DCOMP.COMP.GenType((_191_typeParamsFiltered).Select(_194_i), false, false);
          _195_typeString = _out59;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _195_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _195_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _194_i = (_194_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _184_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _188_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _196_earlyReturn;
        _196_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _197___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _198_outVars = _197___mcc_h0;
          {
            _196_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _199_outI;
            _199_outI = BigInteger.Zero;
            while ((_199_outI) < (new BigInteger((_198_outVars).Count))) {
              if ((_199_outI).Sign == 1) {
                _196_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_196_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _200_outVar;
              _200_outVar = (_198_outVars).Select(_199_outI);
              _196_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_196_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_200_outVar));
              _199_outI = (_199_outI) + (BigInteger.One);
            }
            _196_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_196_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _201_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _202___v12;
        Dafny.ISequence<Dafny.Rune> _out60;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out61;
        DCOMP.COMP.GenStmts((m).dtor_body, (((m).dtor_isStatic) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None()) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self")))), _185_paramNames, true, _196_earlyReturn, out _out60, out _out61);
        _201_body = _out60;
        _202___v12 = _out61;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source12 = (m).dtor_outVars;
        if (_source12.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _203___mcc_h1 = _source12.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _204_outVars = _203___mcc_h1;
          {
            _201_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_201_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _196_earlyReturn);
          }
        } else {
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _201_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      }
      return s;
    }
    public static void GenStmts(Dafny.ISequence<DAST._IStatement> stmts, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _205_declarations;
      _205_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _206_i;
      _206_i = BigInteger.Zero;
      while ((_206_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _207_stmt;
        _207_stmt = (stmts).Select(_206_i);
        Dafny.ISequence<Dafny.Rune> _208_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _209_recIdents;
        Dafny.ISequence<Dafny.Rune> _out62;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out63;
        DCOMP.COMP.GenStmt(_207_stmt, selfIdent, @params, (isLast) && ((_206_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out62, out _out63);
        _208_stmtString = _out62;
        _209_recIdents = _out63;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_209_recIdents, _205_declarations));
        DAST._IStatement _source13 = _207_stmt;
        if (_source13.is_DeclareVar) {
          Dafny.ISequence<Dafny.Rune> _210___mcc_h0 = _source13.dtor_name;
          DAST._IType _211___mcc_h1 = _source13.dtor_typ;
          DAST._IOptional<DAST._IExpression> _212___mcc_h2 = _source13.dtor_maybeValue;
          Dafny.ISequence<Dafny.Rune> _213_name = _210___mcc_h0;
          {
            _205_declarations = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_205_declarations, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_213_name));
          }
        } else if (_source13.is_Assign) {
          DAST._IAssignLhs _214___mcc_h6 = _source13.dtor_lhs;
          DAST._IExpression _215___mcc_h7 = _source13.dtor_value;
        } else if (_source13.is_If) {
          DAST._IExpression _216___mcc_h10 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _217___mcc_h11 = _source13.dtor_thn;
          Dafny.ISequence<DAST._IStatement> _218___mcc_h12 = _source13.dtor_els;
        } else if (_source13.is_Labeled) {
          Dafny.ISequence<Dafny.Rune> _219___mcc_h16 = _source13.dtor_lbl;
          Dafny.ISequence<DAST._IStatement> _220___mcc_h17 = _source13.dtor_body;
        } else if (_source13.is_While) {
          DAST._IExpression _221___mcc_h20 = _source13.dtor_cond;
          Dafny.ISequence<DAST._IStatement> _222___mcc_h21 = _source13.dtor_body;
        } else if (_source13.is_Foreach) {
          Dafny.ISequence<Dafny.Rune> _223___mcc_h24 = _source13.dtor_boundName;
          DAST._IExpression _224___mcc_h25 = _source13.dtor_over;
          Dafny.ISequence<DAST._IStatement> _225___mcc_h26 = _source13.dtor_body;
        } else if (_source13.is_Call) {
          DAST._IExpression _226___mcc_h30 = _source13.dtor_on;
          Dafny.ISequence<Dafny.Rune> _227___mcc_h31 = _source13.dtor_name;
          Dafny.ISequence<DAST._IType> _228___mcc_h32 = _source13.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _229___mcc_h33 = _source13.dtor_args;
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _230___mcc_h34 = _source13.dtor_outs;
        } else if (_source13.is_Return) {
          DAST._IExpression _231___mcc_h40 = _source13.dtor_expr;
        } else if (_source13.is_EarlyReturn) {
        } else if (_source13.is_Break) {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _232___mcc_h42 = _source13.dtor_toLabel;
        } else if (_source13.is_TailRecursive) {
          Dafny.ISequence<DAST._IStatement> _233___mcc_h44 = _source13.dtor_body;
        } else if (_source13.is_JumpTailCallStart) {
        } else if (_source13.is_Halt) {
        } else {
          DAST._IExpression _234___mcc_h46 = _source13.dtor_Print_a0;
        }
        if ((_206_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _208_stmtString);
        _206_i = (_206_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.Rune> rhs, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source14 = lhs;
      if (_source14.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _235___mcc_h0 = _source14.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source15 = _235___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _236___mcc_h1 = _source15;
        Dafny.ISequence<Dafny.Rune> _237_id = _236___mcc_h1;
        {
          if ((@params).Contains(_237_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _237_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _237_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_237_id);
          needsIIFE = false;
        }
      } else if (_source14.is_Select) {
        DAST._IExpression _238___mcc_h2 = _source14.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _239___mcc_h3 = _source14.dtor_field;
        Dafny.ISequence<Dafny.Rune> _240_field = _239___mcc_h3;
        DAST._IExpression _241_on = _238___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _242_onExpr;
          bool _243_onOwned;
          bool _244_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _245_recIdents;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          bool _out66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out67;
          DCOMP.COMP.GenExpr(_241_on, selfIdent, @params, false, out _out64, out _out65, out _out66, out _out67);
          _242_onExpr = _out64;
          _243_onOwned = _out65;
          _244_onErased = _out66;
          _245_recIdents = _out67;
          if (!(_244_onErased)) {
            Dafny.ISequence<Dafny.Rune> _246_eraseFn;
            _246_eraseFn = ((_243_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _242_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _246_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _242_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _242_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _240_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _245_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _247___mcc_h4 = _source14.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _248___mcc_h5 = _source14.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _249_indices = _248___mcc_h5;
        DAST._IExpression _250_on = _247___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _251_onExpr;
          bool _252_onOwned;
          bool _253_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _254_recIdents;
          Dafny.ISequence<Dafny.Rune> _out68;
          bool _out69;
          bool _out70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
          DCOMP.COMP.GenExpr(_250_on, selfIdent, @params, false, out _out68, out _out69, out _out70, out _out71);
          _251_onExpr = _out68;
          _252_onOwned = _out69;
          _253_onErased = _out70;
          _254_recIdents = _out71;
          readIdents = _254_recIdents;
          if (!(_253_onErased)) {
            Dafny.ISequence<Dafny.Rune> _255_eraseFn;
            _255_eraseFn = ((_252_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _251_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _255_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _251_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          BigInteger _256_i;
          _256_i = BigInteger.Zero;
          while ((_256_i) < (new BigInteger((_249_indices).Count))) {
            Dafny.ISequence<Dafny.Rune> _257_idx;
            bool _258___v16;
            bool _259_idxErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _260_recIdentsIdx;
            Dafny.ISequence<Dafny.Rune> _out72;
            bool _out73;
            bool _out74;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
            DCOMP.COMP.GenExpr((_249_indices).Select(_256_i), selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
            _257_idx = _out72;
            _258___v16 = _out73;
            _259_idxErased = _out74;
            _260_recIdentsIdx = _out75;
            if (!(_259_idxErased)) {
              _257_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _257_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let __idx")), DCOMP.__default.natToString(_256_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = <usize as ::dafny_runtime::NumCast>::from(")), _257_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _260_recIdentsIdx);
            _256_i = (_256_i) + (BigInteger.One);
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _251_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()"));
          _256_i = BigInteger.Zero;
          while ((_256_i) < (new BigInteger((_249_indices).Count))) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[__idx")), DCOMP.__default.natToString(_256_i)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
            _256_i = (_256_i) + (BigInteger.One);
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
        Dafny.ISequence<Dafny.Rune> _261___mcc_h0 = _source16.dtor_name;
        DAST._IType _262___mcc_h1 = _source16.dtor_typ;
        DAST._IOptional<DAST._IExpression> _263___mcc_h2 = _source16.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source17 = _263___mcc_h2;
        if (_source17.is_Some) {
          DAST._IExpression _264___mcc_h3 = _source17.dtor_Some_a0;
          DAST._IExpression _265_expression = _264___mcc_h3;
          DAST._IType _266_typ = _262___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _267_name = _261___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _268_expr;
            bool _269___v17;
            bool _270_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _271_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_265_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _268_expr = _out76;
            _269___v17 = _out77;
            _270_recErased = _out78;
            _271_recIdents = _out79;
            if (_270_recErased) {
              _268_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _268_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _272_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_266_typ, true, false);
            _272_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _267_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _272_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _268_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _271_recIdents;
          }
        } else {
          DAST._IType _273_typ = _262___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _274_name = _261___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _275_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_273_typ, true, false);
            _275_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _274_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _275_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source16.is_Assign) {
        DAST._IAssignLhs _276___mcc_h4 = _source16.dtor_lhs;
        DAST._IExpression _277___mcc_h5 = _source16.dtor_value;
        DAST._IExpression _278_expression = _277___mcc_h5;
        DAST._IAssignLhs _279_lhs = _276___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _280_lhsGen;
          bool _281_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _282_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_279_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _280_lhsGen = _out82;
          _281_needsIIFE = _out83;
          _282_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _283_exprGen;
          bool _284___v18;
          bool _285_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _286_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_278_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _283_exprGen = _out85;
          _284___v18 = _out86;
          _285_exprErased = _out87;
          _286_exprIdents = _out88;
          if (_285_exprErased) {
            _283_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _283_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_281_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _283_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _280_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_280_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _283_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_282_recIdents, _286_exprIdents);
        }
      } else if (_source16.is_If) {
        DAST._IExpression _287___mcc_h6 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _288___mcc_h7 = _source16.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _289___mcc_h8 = _source16.dtor_els;
        Dafny.ISequence<DAST._IStatement> _290_els = _289___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _291_thn = _288___mcc_h7;
        DAST._IExpression _292_cond = _287___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _293_condString;
          bool _294___v19;
          bool _295_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _296_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_292_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _293_condString = _out89;
          _294___v19 = _out90;
          _295_condErased = _out91;
          _296_recIdents = _out92;
          if (!(_295_condErased)) {
            _293_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _293_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _296_recIdents;
          Dafny.ISequence<Dafny.Rune> _297_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _298_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_291_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _297_thnString = _out93;
          _298_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _298_thnIdents);
          Dafny.ISequence<Dafny.Rune> _299_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _300_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_290_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _299_elsString = _out95;
          _300_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _300_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _293_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _297_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _299_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Labeled) {
        Dafny.ISequence<Dafny.Rune> _301___mcc_h9 = _source16.dtor_lbl;
        Dafny.ISequence<DAST._IStatement> _302___mcc_h10 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _303_body = _302___mcc_h10;
        Dafny.ISequence<Dafny.Rune> _304_lbl = _301___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _305_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _306_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out98;
          DCOMP.COMP.GenStmts(_303_body, selfIdent, @params, isLast, earlyReturn, out _out97, out _out98);
          _305_bodyString = _out97;
          _306_bodyIdents = _out98;
          readIdents = _306_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'label_"), _304_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": loop {\n")), _305_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_While) {
        DAST._IExpression _307___mcc_h11 = _source16.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _308___mcc_h12 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _309_body = _308___mcc_h12;
        DAST._IExpression _310_cond = _307___mcc_h11;
        {
          Dafny.ISequence<Dafny.Rune> _311_condString;
          bool _312___v20;
          bool _313_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _314_recIdents;
          Dafny.ISequence<Dafny.Rune> _out99;
          bool _out100;
          bool _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenExpr(_310_cond, selfIdent, @params, true, out _out99, out _out100, out _out101, out _out102);
          _311_condString = _out99;
          _312___v20 = _out100;
          _313_condErased = _out101;
          _314_recIdents = _out102;
          if (!(_313_condErased)) {
            _311_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _311_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _314_recIdents;
          Dafny.ISequence<Dafny.Rune> _315_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _316_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out103;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out104;
          DCOMP.COMP.GenStmts(_309_body, selfIdent, @params, false, earlyReturn, out _out103, out _out104);
          _315_bodyString = _out103;
          _316_bodyIdents = _out104;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _316_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _311_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _315_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Foreach) {
        Dafny.ISequence<Dafny.Rune> _317___mcc_h13 = _source16.dtor_boundName;
        DAST._IExpression _318___mcc_h14 = _source16.dtor_over;
        Dafny.ISequence<DAST._IStatement> _319___mcc_h15 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _320_body = _319___mcc_h15;
        DAST._IExpression _321_over = _318___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _322_boundName = _317___mcc_h13;
        {
          Dafny.ISequence<Dafny.Rune> _323_overString;
          bool _324___v21;
          bool _325_overErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _326_recIdents;
          Dafny.ISequence<Dafny.Rune> _out105;
          bool _out106;
          bool _out107;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out108;
          DCOMP.COMP.GenExpr(_321_over, selfIdent, @params, true, out _out105, out _out106, out _out107, out _out108);
          _323_overString = _out105;
          _324___v21 = _out106;
          _325_overErased = _out107;
          _326_recIdents = _out108;
          if (!(_325_overErased)) {
            _323_overString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _323_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _326_recIdents;
          Dafny.ISequence<Dafny.Rune> _327_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _328_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out109;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out110;
          DCOMP.COMP.GenStmts(_320_body, selfIdent, @params, false, earlyReturn, out _out109, out _out110);
          _327_bodyString = _out109;
          _328_bodyIdents = _out110;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _328_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("for r#"), _322_boundName), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" in ")), _323_overString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _327_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source16.is_Call) {
        DAST._IExpression _329___mcc_h16 = _source16.dtor_on;
        Dafny.ISequence<Dafny.Rune> _330___mcc_h17 = _source16.dtor_name;
        Dafny.ISequence<DAST._IType> _331___mcc_h18 = _source16.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _332___mcc_h19 = _source16.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _333___mcc_h20 = _source16.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _334_maybeOutVars = _333___mcc_h20;
        Dafny.ISequence<DAST._IExpression> _335_args = _332___mcc_h19;
        Dafny.ISequence<DAST._IType> _336_typeArgs = _331___mcc_h18;
        Dafny.ISequence<Dafny.Rune> _337_name = _330___mcc_h17;
        DAST._IExpression _338_on = _329___mcc_h16;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _339_typeArgString;
          _339_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_336_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _340_typeI;
            _340_typeI = BigInteger.Zero;
            _339_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_340_typeI) < (new BigInteger((_336_typeArgs).Count))) {
              if ((_340_typeI).Sign == 1) {
                _339_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_339_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _341_typeString;
              Dafny.ISequence<Dafny.Rune> _out111;
              _out111 = DCOMP.COMP.GenType((_336_typeArgs).Select(_340_typeI), false, false);
              _341_typeString = _out111;
              _339_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_339_typeArgString, _341_typeString);
              _340_typeI = (_340_typeI) + (BigInteger.One);
            }
            _339_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_339_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _342_argString;
          _342_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _343_i;
          _343_i = BigInteger.Zero;
          while ((_343_i) < (new BigInteger((_335_args).Count))) {
            if ((_343_i).Sign == 1) {
              _342_argString = Dafny.Sequence<Dafny.Rune>.Concat(_342_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _344_argExpr;
            bool _345_isOwned;
            bool _346_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _347_argIdents;
            Dafny.ISequence<Dafny.Rune> _out112;
            bool _out113;
            bool _out114;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
            DCOMP.COMP.GenExpr((_335_args).Select(_343_i), selfIdent, @params, false, out _out112, out _out113, out _out114, out _out115);
            _344_argExpr = _out112;
            _345_isOwned = _out113;
            _346_argErased = _out114;
            _347_argIdents = _out115;
            if (_345_isOwned) {
              _344_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _344_argExpr);
            }
            _342_argString = Dafny.Sequence<Dafny.Rune>.Concat(_342_argString, _344_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _347_argIdents);
            _343_i = (_343_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _348_enclosingString;
          bool _349___v22;
          bool _350___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _351_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out116;
          bool _out117;
          bool _out118;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out119;
          DCOMP.COMP.GenExpr(_338_on, selfIdent, @params, false, out _out116, out _out117, out _out118, out _out119);
          _348_enclosingString = _out116;
          _349___v22 = _out117;
          _350___v23 = _out118;
          _351_enclosingIdents = _out119;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _351_enclosingIdents);
          DAST._IExpression _source18 = _338_on;
          if (_source18.is_Literal) {
            DAST._ILiteral _352___mcc_h25 = _source18.dtor_Literal_a0;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _353___mcc_h27 = _source18.dtor_Ident_a0;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _354___mcc_h29 = _source18.dtor_Companion_a0;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_348_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source18.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _355___mcc_h31 = _source18.dtor_Tuple_a0;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _356___mcc_h33 = _source18.dtor_path;
            Dafny.ISequence<DAST._IExpression> _357___mcc_h34 = _source18.dtor_args;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _358___mcc_h37 = _source18.dtor_dims;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _359___mcc_h39 = _source18.dtor_path;
            Dafny.ISequence<Dafny.Rune> _360___mcc_h40 = _source18.dtor_variant;
            bool _361___mcc_h41 = _source18.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _362___mcc_h42 = _source18.dtor_contents;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Convert) {
            DAST._IExpression _363___mcc_h47 = _source18.dtor_value;
            DAST._IType _364___mcc_h48 = _source18.dtor_from;
            DAST._IType _365___mcc_h49 = _source18.dtor_typ;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _366___mcc_h53 = _source18.dtor_elements;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _367___mcc_h55 = _source18.dtor_elements;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _368___mcc_h57 = _source18.dtor_mapElems;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_This) {
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Ite) {
            DAST._IExpression _369___mcc_h59 = _source18.dtor_cond;
            DAST._IExpression _370___mcc_h60 = _source18.dtor_thn;
            DAST._IExpression _371___mcc_h61 = _source18.dtor_els;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_UnOp) {
            DAST._IUnaryOp _372___mcc_h65 = _source18.dtor_unOp;
            DAST._IExpression _373___mcc_h66 = _source18.dtor_expr;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _374___mcc_h69 = _source18.dtor_op;
            DAST._IExpression _375___mcc_h70 = _source18.dtor_left;
            DAST._IExpression _376___mcc_h71 = _source18.dtor_right;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_ArrayLen) {
            DAST._IExpression _377___mcc_h75 = _source18.dtor_expr;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Select) {
            DAST._IExpression _378___mcc_h77 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _379___mcc_h78 = _source18.dtor_field;
            bool _380___mcc_h79 = _source18.dtor_isConstant;
            bool _381___mcc_h80 = _source18.dtor_onDatatype;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_SelectFn) {
            DAST._IExpression _382___mcc_h85 = _source18.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _383___mcc_h86 = _source18.dtor_field;
            bool _384___mcc_h87 = _source18.dtor_onDatatype;
            bool _385___mcc_h88 = _source18.dtor_isStatic;
            BigInteger _386___mcc_h89 = _source18.dtor_arity;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Index) {
            DAST._IExpression _387___mcc_h95 = _source18.dtor_expr;
            DAST._ICollKind _388___mcc_h96 = _source18.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _389___mcc_h97 = _source18.dtor_indices;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IndexRange) {
            DAST._IExpression _390___mcc_h101 = _source18.dtor_expr;
            bool _391___mcc_h102 = _source18.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _392___mcc_h103 = _source18.dtor_low;
            DAST._IOptional<DAST._IExpression> _393___mcc_h104 = _source18.dtor_high;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TupleSelect) {
            DAST._IExpression _394___mcc_h109 = _source18.dtor_expr;
            BigInteger _395___mcc_h110 = _source18.dtor_index;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Call) {
            DAST._IExpression _396___mcc_h113 = _source18.dtor_on;
            Dafny.ISequence<Dafny.Rune> _397___mcc_h114 = _source18.dtor_name;
            Dafny.ISequence<DAST._IType> _398___mcc_h115 = _source18.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _399___mcc_h116 = _source18.dtor_args;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _400___mcc_h121 = _source18.dtor_params;
            DAST._IType _401___mcc_h122 = _source18.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _402___mcc_h123 = _source18.dtor_body;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _403___mcc_h127 = _source18.dtor_values;
            DAST._IType _404___mcc_h128 = _source18.dtor_retType;
            DAST._IExpression _405___mcc_h129 = _source18.dtor_expr;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _406___mcc_h133 = _source18.dtor_name;
            DAST._IType _407___mcc_h134 = _source18.dtor_typ;
            DAST._IExpression _408___mcc_h135 = _source18.dtor_value;
            DAST._IExpression _409___mcc_h136 = _source18.dtor_iifeBody;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_Apply) {
            DAST._IExpression _410___mcc_h141 = _source18.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _411___mcc_h142 = _source18.dtor_args;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_TypeTest) {
            DAST._IExpression _412___mcc_h145 = _source18.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _413___mcc_h146 = _source18.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _414___mcc_h147 = _source18.dtor_variant;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source18.is_InitializationValue) {
            DAST._IType _415___mcc_h151 = _source18.dtor_typ;
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            {
              _348_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _416_receiver;
          _416_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source19 = _334_maybeOutVars;
          if (_source19.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _417___mcc_h153 = _source19.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _418_outVars = _417___mcc_h153;
            {
              if ((new BigInteger((_418_outVars).Count)) > (BigInteger.One)) {
                _416_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _419_outI;
              _419_outI = BigInteger.Zero;
              while ((_419_outI) < (new BigInteger((_418_outVars).Count))) {
                if ((_419_outI).Sign == 1) {
                  _416_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_416_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _420_outVar;
                _420_outVar = (_418_outVars).Select(_419_outI);
                _416_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_416_receiver, (_420_outVar));
                _419_outI = (_419_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_418_outVars).Count)) > (BigInteger.One)) {
                _416_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_416_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_416_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_416_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _348_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _337_name), _339_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _342_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source16.is_Return) {
        DAST._IExpression _421___mcc_h21 = _source16.dtor_expr;
        DAST._IExpression _422_expr = _421___mcc_h21;
        {
          Dafny.ISequence<Dafny.Rune> _423_exprString;
          bool _424___v26;
          bool _425_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _426_recIdents;
          Dafny.ISequence<Dafny.Rune> _out120;
          bool _out121;
          bool _out122;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out123;
          DCOMP.COMP.GenExpr(_422_expr, selfIdent, @params, true, out _out120, out _out121, out _out122, out _out123);
          _423_exprString = _out120;
          _424___v26 = _out121;
          _425_recErased = _out122;
          _426_recIdents = _out123;
          _423_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _423_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _426_recIdents;
          if (isLast) {
            generated = _423_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _423_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source16.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_Break) {
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _427___mcc_h22 = _source16.dtor_toLabel;
        DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _428_toLabel = _427___mcc_h22;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source20 = _428_toLabel;
          if (_source20.is_Some) {
            Dafny.ISequence<Dafny.Rune> _429___mcc_h154 = _source20.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _430_lbl = _429___mcc_h154;
            {
              generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break 'label_"), _430_lbl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            }
          } else {
            {
              generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("break;");
            }
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source16.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _431___mcc_h23 = _source16.dtor_body;
        Dafny.ISequence<DAST._IStatement> _432_body = _431___mcc_h23;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _433_paramI;
          _433_paramI = BigInteger.Zero;
          while ((_433_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _434_param;
            _434_param = (@params).Select(_433_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _434_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _434_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _433_paramI = (_433_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _435_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _436_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out124;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out125;
          DCOMP.COMP.GenStmts(_432_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out124, out _out125);
          _435_bodyString = _out124;
          _436_bodyIdents = _out125;
          readIdents = _436_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _435_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _437___mcc_h24 = _source16.dtor_Print_a0;
        DAST._IExpression _438_e = _437___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _439_printedExpr;
          bool _440_isOwned;
          bool _441___v27;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _442_recIdents;
          Dafny.ISequence<Dafny.Rune> _out126;
          bool _out127;
          bool _out128;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out129;
          DCOMP.COMP.GenExpr(_438_e, selfIdent, @params, false, out _out126, out _out127, out _out128, out _out129);
          _439_printedExpr = _out126;
          _440_isOwned = _out127;
          _441___v27 = _out128;
          _442_recIdents = _out129;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_440_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _439_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _442_recIdents;
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
        DAST._ILiteral _443___mcc_h0 = _source21.dtor_Literal_a0;
        DAST._ILiteral _source22 = _443___mcc_h0;
        if (_source22.is_BoolLiteral) {
          bool _444___mcc_h1 = _source22.dtor_BoolLiteral_a0;
          if ((_444___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _445___mcc_h2 = _source22.dtor_IntLiteral_a0;
          DAST._IType _446___mcc_h3 = _source22.dtor_IntLiteral_a1;
          DAST._IType _447_t = _446___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _448_i = _445___mcc_h2;
          {
            DAST._IType _source23 = _447_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _449___mcc_h200 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _450___mcc_h201 = _source23.dtor_typeArgs;
              DAST._IResolvedType _451___mcc_h202 = _source23.dtor_resolved;
              {
                s = _448_i;
              }
            } else if (_source23.is_Nullable) {
              DAST._IType _452___mcc_h206 = _source23.dtor_Nullable_a0;
              {
                s = _448_i;
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _453___mcc_h208 = _source23.dtor_Tuple_a0;
              {
                s = _448_i;
              }
            } else if (_source23.is_Array) {
              DAST._IType _454___mcc_h210 = _source23.dtor_element;
              {
                s = _448_i;
              }
            } else if (_source23.is_Seq) {
              DAST._IType _455___mcc_h212 = _source23.dtor_element;
              {
                s = _448_i;
              }
            } else if (_source23.is_Set) {
              DAST._IType _456___mcc_h214 = _source23.dtor_element;
              {
                s = _448_i;
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _457___mcc_h216 = _source23.dtor_element;
              {
                s = _448_i;
              }
            } else if (_source23.is_Map) {
              DAST._IType _458___mcc_h218 = _source23.dtor_key;
              DAST._IType _459___mcc_h219 = _source23.dtor_value;
              {
                s = _448_i;
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _460___mcc_h222 = _source23.dtor_args;
              DAST._IType _461___mcc_h223 = _source23.dtor_result;
              {
                s = _448_i;
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _462___mcc_h226 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _462___mcc_h226;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _448_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source24.is_Real) {
                {
                  s = _448_i;
                }
              } else if (_source24.is_String) {
                {
                  s = _448_i;
                }
              } else if (_source24.is_Bool) {
                {
                  s = _448_i;
                }
              } else {
                {
                  s = _448_i;
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _463___mcc_h228 = _source23.dtor_Passthrough_a0;
              {
                s = _448_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _464___mcc_h230 = _source23.dtor_TypeArg_a0;
              {
                s = _448_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _465___mcc_h4 = _source22.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _466___mcc_h5 = _source22.dtor_DecLiteral_a1;
          DAST._IType _467___mcc_h6 = _source22.dtor_DecLiteral_a2;
          DAST._IType _468_t = _467___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _469_d = _466___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _470_n = _465___mcc_h4;
          {
            DAST._IType _source25 = _468_t;
            if (_source25.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _471___mcc_h232 = _source25.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _472___mcc_h233 = _source25.dtor_typeArgs;
              DAST._IResolvedType _473___mcc_h234 = _source25.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Nullable) {
              DAST._IType _474___mcc_h238 = _source25.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Tuple) {
              Dafny.ISequence<DAST._IType> _475___mcc_h240 = _source25.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Array) {
              DAST._IType _476___mcc_h242 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Seq) {
              DAST._IType _477___mcc_h244 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Set) {
              DAST._IType _478___mcc_h246 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Multiset) {
              DAST._IType _479___mcc_h248 = _source25.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Map) {
              DAST._IType _480___mcc_h250 = _source25.dtor_key;
              DAST._IType _481___mcc_h251 = _source25.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Arrow) {
              Dafny.ISequence<DAST._IType> _482___mcc_h254 = _source25.dtor_args;
              DAST._IType _483___mcc_h255 = _source25.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source25.is_Primitive) {
              DAST._IPrimitive _484___mcc_h258 = _source25.dtor_Primitive_a0;
              DAST._IPrimitive _source26 = _484___mcc_h258;
              if (_source26.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source26.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _470_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source26.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source26.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source25.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _485___mcc_h260 = _source25.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _486___mcc_h262 = _source25.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_470_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _469_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _487___mcc_h7 = _source22.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _488_l = _487___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _488_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source22.is_CharLiteral) {
          Dafny.Rune _489___mcc_h8 = _source22.dtor_CharLiteral_a0;
          Dafny.Rune _490_c = _489___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_490_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _491___mcc_h9 = _source21.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _492_name = _491___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _492_name);
          if (!((@params).Contains(_492_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_492_name);
        }
      } else if (_source21.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _493___mcc_h10 = _source21.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _494_path = _493___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out130;
          _out130 = DCOMP.COMP.GenPath(_494_path);
          s = _out130;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source21.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _495___mcc_h11 = _source21.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _496_values = _495___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _497_i;
          _497_i = BigInteger.Zero;
          bool _498_allErased;
          _498_allErased = true;
          while ((_497_i) < (new BigInteger((_496_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _499___v30;
            bool _500___v31;
            bool _501_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _502___v32;
            Dafny.ISequence<Dafny.Rune> _out131;
            bool _out132;
            bool _out133;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out134;
            DCOMP.COMP.GenExpr((_496_values).Select(_497_i), selfIdent, @params, true, out _out131, out _out132, out _out133, out _out134);
            _499___v30 = _out131;
            _500___v31 = _out132;
            _501_isErased = _out133;
            _502___v32 = _out134;
            _498_allErased = (_498_allErased) && (_501_isErased);
            _497_i = (_497_i) + (BigInteger.One);
          }
          _497_i = BigInteger.Zero;
          while ((_497_i) < (new BigInteger((_496_values).Count))) {
            if ((_497_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _503_recursiveGen;
            bool _504___v33;
            bool _505_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _506_recIdents;
            Dafny.ISequence<Dafny.Rune> _out135;
            bool _out136;
            bool _out137;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out138;
            DCOMP.COMP.GenExpr((_496_values).Select(_497_i), selfIdent, @params, true, out _out135, out _out136, out _out137, out _out138);
            _503_recursiveGen = _out135;
            _504___v33 = _out136;
            _505_isErased = _out137;
            _506_recIdents = _out138;
            if ((_505_isErased) && (!(_498_allErased))) {
              _503_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _506_recIdents);
            _497_i = (_497_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _498_allErased;
        }
      } else if (_source21.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _507___mcc_h12 = _source21.dtor_path;
        Dafny.ISequence<DAST._IExpression> _508___mcc_h13 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _509_args = _508___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _510_path = _507___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _511_path;
          Dafny.ISequence<Dafny.Rune> _out139;
          _out139 = DCOMP.COMP.GenPath(_510_path);
          _511_path = _out139;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _511_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _512_i;
          _512_i = BigInteger.Zero;
          while ((_512_i) < (new BigInteger((_509_args).Count))) {
            if ((_512_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _513_recursiveGen;
            bool _514___v34;
            bool _515_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _516_recIdents;
            Dafny.ISequence<Dafny.Rune> _out140;
            bool _out141;
            bool _out142;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out143;
            DCOMP.COMP.GenExpr((_509_args).Select(_512_i), selfIdent, @params, true, out _out140, out _out141, out _out142, out _out143);
            _513_recursiveGen = _out140;
            _514___v34 = _out141;
            _515_isErased = _out142;
            _516_recIdents = _out143;
            if (_515_isErased) {
              _513_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _513_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _513_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _516_recIdents);
            _512_i = (_512_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _517___mcc_h14 = _source21.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _518_dims = _517___mcc_h14;
        {
          BigInteger _519_i;
          _519_i = (new BigInteger((_518_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_519_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _520_recursiveGen;
            bool _521___v35;
            bool _522_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _523_recIdents;
            Dafny.ISequence<Dafny.Rune> _out144;
            bool _out145;
            bool _out146;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out147;
            DCOMP.COMP.GenExpr((_518_dims).Select(_519_i), selfIdent, @params, true, out _out144, out _out145, out _out146, out _out147);
            _520_recursiveGen = _out144;
            _521___v35 = _out145;
            _522_isErased = _out146;
            _523_recIdents = _out147;
            if (!(_522_isErased)) {
              _520_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _523_recIdents);
            _519_i = (_519_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _524___mcc_h15 = _source21.dtor_path;
        Dafny.ISequence<Dafny.Rune> _525___mcc_h16 = _source21.dtor_variant;
        bool _526___mcc_h17 = _source21.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _527___mcc_h18 = _source21.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _528_values = _527___mcc_h18;
        bool _529_isCo = _526___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _530_variant = _525___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _531_path = _524___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _532_path;
          Dafny.ISequence<Dafny.Rune> _out148;
          _out148 = DCOMP.COMP.GenPath(_531_path);
          _532_path = _out148;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _532_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _530_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _533_i;
          _533_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_533_i) < (new BigInteger((_528_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_528_values).Select(_533_i);
            Dafny.ISequence<Dafny.Rune> _534_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _535_value = _let_tmp_rhs0.dtor__1;
            if ((_533_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_529_isCo) {
              Dafny.ISequence<Dafny.Rune> _536_recursiveGen;
              bool _537___v36;
              bool _538_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _539_recIdents;
              Dafny.ISequence<Dafny.Rune> _out149;
              bool _out150;
              bool _out151;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
              DCOMP.COMP.GenExpr(_535_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out149, out _out150, out _out151, out _out152);
              _536_recursiveGen = _out149;
              _537___v36 = _out150;
              _538_isErased = _out151;
              _539_recIdents = _out152;
              if (!(_538_isErased)) {
                _536_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _536_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _539_recIdents);
              Dafny.ISequence<Dafny.Rune> _540_allReadCloned;
              _540_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_539_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _541_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_539_recIdents).Elements) {
                  _541_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_539_recIdents).Contains(_541_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1177)");
              after__ASSIGN_SUCH_THAT_0:;
                _540_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_540_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _541_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _541_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _539_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_539_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_541_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _534_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _540_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _542_recursiveGen;
              bool _543___v37;
              bool _544_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _545_recIdents;
              Dafny.ISequence<Dafny.Rune> _out153;
              bool _out154;
              bool _out155;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
              DCOMP.COMP.GenExpr(_535_value, selfIdent, @params, true, out _out153, out _out154, out _out155, out _out156);
              _542_recursiveGen = _out153;
              _543___v37 = _out154;
              _544_isErased = _out155;
              _545_recIdents = _out156;
              if (!(_544_isErased)) {
                _542_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _542_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _542_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _542_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _534_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _542_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _545_recIdents);
            }
            _533_i = (_533_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source21.is_Convert) {
        DAST._IExpression _546___mcc_h19 = _source21.dtor_value;
        DAST._IType _547___mcc_h20 = _source21.dtor_from;
        DAST._IType _548___mcc_h21 = _source21.dtor_typ;
        DAST._IType _549_toTpe = _548___mcc_h21;
        DAST._IType _550_fromTpe = _547___mcc_h20;
        DAST._IExpression _551_expr = _546___mcc_h19;
        {
          if (object.Equals(_550_fromTpe, _549_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _552_recursiveGen;
            bool _553_recOwned;
            bool _554_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _555_recIdents;
            Dafny.ISequence<Dafny.Rune> _out157;
            bool _out158;
            bool _out159;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
            DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
            _552_recursiveGen = _out157;
            _553_recOwned = _out158;
            _554_recErased = _out159;
            _555_recIdents = _out160;
            s = _552_recursiveGen;
            isOwned = _553_recOwned;
            isErased = _554_recErased;
            readIdents = _555_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source27 = _System.Tuple2<DAST._IType, DAST._IType>.create(_550_fromTpe, _549_toTpe);
            DAST._IType _556___mcc_h264 = _source27.dtor__0;
            DAST._IType _557___mcc_h265 = _source27.dtor__1;
            DAST._IType _source28 = _556___mcc_h264;
            if (_source28.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _558___mcc_h268 = _source28.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _559___mcc_h269 = _source28.dtor_typeArgs;
              DAST._IResolvedType _560___mcc_h270 = _source28.dtor_resolved;
              DAST._IResolvedType _source29 = _560___mcc_h270;
              if (_source29.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _561___mcc_h280 = _source29.dtor_path;
                DAST._IType _source30 = _557___mcc_h265;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _562___mcc_h284 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _563___mcc_h285 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _564___mcc_h286 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _564___mcc_h286;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _565___mcc_h290 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _566_recursiveGen;
                      bool _567_recOwned;
                      bool _568_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _569_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out161;
                      bool _out162;
                      bool _out163;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                      _566_recursiveGen = _out161;
                      _567_recOwned = _out162;
                      _568_recErased = _out163;
                      _569_recIdents = _out164;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _567_recOwned;
                      isErased = _568_recErased;
                      readIdents = _569_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _570___mcc_h292 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _571_recursiveGen;
                      bool _572_recOwned;
                      bool _573_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _574_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out165;
                      bool _out166;
                      bool _out167;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out168;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out165, out _out166, out _out167, out _out168);
                      _571_recursiveGen = _out165;
                      _572_recOwned = _out166;
                      _573_recErased = _out167;
                      _574_recIdents = _out168;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _571_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _572_recOwned;
                      isErased = _573_recErased;
                      readIdents = _574_recIdents;
                    }
                  } else {
                    DAST._IType _575___mcc_h294 = _source31.dtor_Newtype_a0;
                    DAST._IType _576_b = _575___mcc_h294;
                    {
                      if (object.Equals(_550_fromTpe, _576_b)) {
                        Dafny.ISequence<Dafny.Rune> _577_recursiveGen;
                        bool _578_recOwned;
                        bool _579_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _580_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out169;
                        bool _out170;
                        bool _out171;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out172;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out169, out _out170, out _out171, out _out172);
                        _577_recursiveGen = _out169;
                        _578_recOwned = _out170;
                        _579_recErased = _out171;
                        _580_recIdents = _out172;
                        Dafny.ISequence<Dafny.Rune> _581_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out173;
                        _out173 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _581_rhsType = _out173;
                        Dafny.ISequence<Dafny.Rune> _582_uneraseFn;
                        _582_uneraseFn = ((_578_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _581_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _582_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _577_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _578_recOwned;
                        isErased = false;
                        readIdents = _580_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out174;
                        bool _out175;
                        bool _out176;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _576_b), _576_b, _549_toTpe), selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                        s = _out174;
                        isOwned = _out175;
                        isErased = _out176;
                        readIdents = _out177;
                      }
                    }
                  }
                } else if (_source30.is_Nullable) {
                  DAST._IType _583___mcc_h296 = _source30.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _584_recursiveGen;
                    bool _585_recOwned;
                    bool _586_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _587_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _584_recursiveGen = _out178;
                    _585_recOwned = _out179;
                    _586_recErased = _out180;
                    _587_recIdents = _out181;
                    if (!(_585_recOwned)) {
                      _584_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_584_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _584_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _586_recErased;
                    readIdents = _587_recIdents;
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _588___mcc_h298 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _589_recursiveGen;
                    bool _590_recOwned;
                    bool _591_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _592_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _589_recursiveGen = _out182;
                    _590_recOwned = _out183;
                    _591_recErased = _out184;
                    _592_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _589_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _590_recOwned;
                    isErased = _591_recErased;
                    readIdents = _592_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _593___mcc_h300 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _594_recursiveGen;
                    bool _595_recOwned;
                    bool _596_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _597_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _594_recursiveGen = _out186;
                    _595_recOwned = _out187;
                    _596_recErased = _out188;
                    _597_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _594_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _595_recOwned;
                    isErased = _596_recErased;
                    readIdents = _597_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _598___mcc_h302 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _599_recursiveGen;
                    bool _600_recOwned;
                    bool _601_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _602_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _599_recursiveGen = _out190;
                    _600_recOwned = _out191;
                    _601_recErased = _out192;
                    _602_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _599_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _600_recOwned;
                    isErased = _601_recErased;
                    readIdents = _602_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _603___mcc_h304 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _604_recursiveGen;
                    bool _605_recOwned;
                    bool _606_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _607_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _604_recursiveGen = _out194;
                    _605_recOwned = _out195;
                    _606_recErased = _out196;
                    _607_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _604_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _605_recOwned;
                    isErased = _606_recErased;
                    readIdents = _607_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _608___mcc_h306 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _609_recursiveGen;
                    bool _610_recOwned;
                    bool _611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _609_recursiveGen = _out198;
                    _610_recOwned = _out199;
                    _611_recErased = _out200;
                    _612_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _610_recOwned;
                    isErased = _611_recErased;
                    readIdents = _612_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _613___mcc_h308 = _source30.dtor_key;
                  DAST._IType _614___mcc_h309 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _615_recursiveGen;
                    bool _616_recOwned;
                    bool _617_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _618_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _615_recursiveGen = _out202;
                    _616_recOwned = _out203;
                    _617_recErased = _out204;
                    _618_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _615_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _616_recOwned;
                    isErased = _617_recErased;
                    readIdents = _618_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _619___mcc_h312 = _source30.dtor_args;
                  DAST._IType _620___mcc_h313 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _621_recursiveGen;
                    bool _622_recOwned;
                    bool _623_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _624_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out206;
                    bool _out207;
                    bool _out208;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                    _621_recursiveGen = _out206;
                    _622_recOwned = _out207;
                    _623_recErased = _out208;
                    _624_recIdents = _out209;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _621_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _622_recOwned;
                    isErased = _623_recErased;
                    readIdents = _624_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _625___mcc_h316 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _626_recursiveGen;
                    bool _627_recOwned;
                    bool _628_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _629_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out210;
                    bool _out211;
                    bool _out212;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                    _626_recursiveGen = _out210;
                    _627_recOwned = _out211;
                    _628_recErased = _out212;
                    _629_recIdents = _out213;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _627_recOwned;
                    isErased = _628_recErased;
                    readIdents = _629_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _630___mcc_h318 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _631_recursiveGen;
                    bool _632_recOwned;
                    bool _633_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _634_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out214;
                    bool _out215;
                    bool _out216;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                    _631_recursiveGen = _out214;
                    _632_recOwned = _out215;
                    _633_recErased = _out216;
                    _634_recIdents = _out217;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _632_recOwned;
                    isErased = _633_recErased;
                    readIdents = _634_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _635___mcc_h320 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _636_recursiveGen;
                    bool _637_recOwned;
                    bool _638_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _639_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out218;
                    bool _out219;
                    bool _out220;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                    _636_recursiveGen = _out218;
                    _637_recOwned = _out219;
                    _638_recErased = _out220;
                    _639_recIdents = _out221;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _637_recOwned;
                    isErased = _638_recErased;
                    readIdents = _639_recIdents;
                  }
                }
              } else if (_source29.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _640___mcc_h322 = _source29.dtor_path;
                DAST._IType _source32 = _557___mcc_h265;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _641___mcc_h326 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _642___mcc_h327 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _643___mcc_h328 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _643___mcc_h328;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _644___mcc_h332 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _645_recursiveGen;
                      bool _646_recOwned;
                      bool _647_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _648_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out222;
                      bool _out223;
                      bool _out224;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                      _645_recursiveGen = _out222;
                      _646_recOwned = _out223;
                      _647_recErased = _out224;
                      _648_recIdents = _out225;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _646_recOwned;
                      isErased = _647_recErased;
                      readIdents = _648_recIdents;
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _649___mcc_h334 = _source33.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _650_recursiveGen;
                      bool _651_recOwned;
                      bool _652_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _653_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out226;
                      bool _out227;
                      bool _out228;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out229;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out226, out _out227, out _out228, out _out229);
                      _650_recursiveGen = _out226;
                      _651_recOwned = _out227;
                      _652_recErased = _out228;
                      _653_recIdents = _out229;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _650_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _651_recOwned;
                      isErased = _652_recErased;
                      readIdents = _653_recIdents;
                    }
                  } else {
                    DAST._IType _654___mcc_h336 = _source33.dtor_Newtype_a0;
                    DAST._IType _655_b = _654___mcc_h336;
                    {
                      if (object.Equals(_550_fromTpe, _655_b)) {
                        Dafny.ISequence<Dafny.Rune> _656_recursiveGen;
                        bool _657_recOwned;
                        bool _658_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _659_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out230;
                        bool _out231;
                        bool _out232;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out233;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out230, out _out231, out _out232, out _out233);
                        _656_recursiveGen = _out230;
                        _657_recOwned = _out231;
                        _658_recErased = _out232;
                        _659_recIdents = _out233;
                        Dafny.ISequence<Dafny.Rune> _660_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out234;
                        _out234 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _660_rhsType = _out234;
                        Dafny.ISequence<Dafny.Rune> _661_uneraseFn;
                        _661_uneraseFn = ((_657_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _660_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _661_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _656_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _657_recOwned;
                        isErased = false;
                        readIdents = _659_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out235;
                        bool _out236;
                        bool _out237;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _655_b), _655_b, _549_toTpe), selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                        s = _out235;
                        isOwned = _out236;
                        isErased = _out237;
                        readIdents = _out238;
                      }
                    }
                  }
                } else if (_source32.is_Nullable) {
                  DAST._IType _662___mcc_h338 = _source32.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _663_recursiveGen;
                    bool _664_recOwned;
                    bool _665_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _666_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _663_recursiveGen = _out239;
                    _664_recOwned = _out240;
                    _665_recErased = _out241;
                    _666_recIdents = _out242;
                    if (!(_664_recOwned)) {
                      _663_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_663_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _663_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _665_recErased;
                    readIdents = _666_recIdents;
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _667___mcc_h340 = _source32.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _668_recursiveGen;
                    bool _669_recOwned;
                    bool _670_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _671_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _668_recursiveGen = _out243;
                    _669_recOwned = _out244;
                    _670_recErased = _out245;
                    _671_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _668_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _669_recOwned;
                    isErased = _670_recErased;
                    readIdents = _671_recIdents;
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _672___mcc_h342 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _673_recursiveGen;
                    bool _674_recOwned;
                    bool _675_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _676_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _673_recursiveGen = _out247;
                    _674_recOwned = _out248;
                    _675_recErased = _out249;
                    _676_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _673_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _674_recOwned;
                    isErased = _675_recErased;
                    readIdents = _676_recIdents;
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _677___mcc_h344 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _678_recursiveGen;
                    bool _679_recOwned;
                    bool _680_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _681_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _678_recursiveGen = _out251;
                    _679_recOwned = _out252;
                    _680_recErased = _out253;
                    _681_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _678_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _679_recOwned;
                    isErased = _680_recErased;
                    readIdents = _681_recIdents;
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _682___mcc_h346 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _683_recursiveGen;
                    bool _684_recOwned;
                    bool _685_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _686_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _683_recursiveGen = _out255;
                    _684_recOwned = _out256;
                    _685_recErased = _out257;
                    _686_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _683_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _684_recOwned;
                    isErased = _685_recErased;
                    readIdents = _686_recIdents;
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _687___mcc_h348 = _source32.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _688_recursiveGen;
                    bool _689_recOwned;
                    bool _690_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _691_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _688_recursiveGen = _out259;
                    _689_recOwned = _out260;
                    _690_recErased = _out261;
                    _691_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _688_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _689_recOwned;
                    isErased = _690_recErased;
                    readIdents = _691_recIdents;
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _692___mcc_h350 = _source32.dtor_key;
                  DAST._IType _693___mcc_h351 = _source32.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _694_recursiveGen;
                    bool _695_recOwned;
                    bool _696_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _697_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _694_recursiveGen = _out263;
                    _695_recOwned = _out264;
                    _696_recErased = _out265;
                    _697_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _694_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _695_recOwned;
                    isErased = _696_recErased;
                    readIdents = _697_recIdents;
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _698___mcc_h354 = _source32.dtor_args;
                  DAST._IType _699___mcc_h355 = _source32.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _700_recursiveGen;
                    bool _701_recOwned;
                    bool _702_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _703_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out267;
                    bool _out268;
                    bool _out269;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                    _700_recursiveGen = _out267;
                    _701_recOwned = _out268;
                    _702_recErased = _out269;
                    _703_recIdents = _out270;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _700_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _701_recOwned;
                    isErased = _702_recErased;
                    readIdents = _703_recIdents;
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _704___mcc_h358 = _source32.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _705_recursiveGen;
                    bool _706_recOwned;
                    bool _707_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _708_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out271;
                    bool _out272;
                    bool _out273;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                    _705_recursiveGen = _out271;
                    _706_recOwned = _out272;
                    _707_recErased = _out273;
                    _708_recIdents = _out274;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _705_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _706_recOwned;
                    isErased = _707_recErased;
                    readIdents = _708_recIdents;
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _709___mcc_h360 = _source32.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _710_recursiveGen;
                    bool _711_recOwned;
                    bool _712_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _713_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out275;
                    bool _out276;
                    bool _out277;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                    _710_recursiveGen = _out275;
                    _711_recOwned = _out276;
                    _712_recErased = _out277;
                    _713_recIdents = _out278;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _710_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _711_recOwned;
                    isErased = _712_recErased;
                    readIdents = _713_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _714___mcc_h362 = _source32.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _715_recursiveGen;
                    bool _716_recOwned;
                    bool _717_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _718_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out279;
                    bool _out280;
                    bool _out281;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                    _715_recursiveGen = _out279;
                    _716_recOwned = _out280;
                    _717_recErased = _out281;
                    _718_recIdents = _out282;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _715_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _716_recOwned;
                    isErased = _717_recErased;
                    readIdents = _718_recIdents;
                  }
                }
              } else {
                DAST._IType _719___mcc_h364 = _source29.dtor_Newtype_a0;
                DAST._IType _source34 = _557___mcc_h265;
                if (_source34.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _720___mcc_h368 = _source34.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _721___mcc_h369 = _source34.dtor_typeArgs;
                  DAST._IResolvedType _722___mcc_h370 = _source34.dtor_resolved;
                  DAST._IResolvedType _source35 = _722___mcc_h370;
                  if (_source35.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _723___mcc_h377 = _source35.dtor_path;
                    DAST._IType _724_b = _719___mcc_h364;
                    {
                      if (object.Equals(_724_b, _549_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _725_recursiveGen;
                        bool _726_recOwned;
                        bool _727_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _728_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _725_recursiveGen = _out283;
                        _726_recOwned = _out284;
                        _727_recErased = _out285;
                        _728_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _729_uneraseFn;
                        _729_uneraseFn = ((_726_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _729_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _726_recOwned;
                        isErased = true;
                        readIdents = _728_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out287;
                        bool _out288;
                        bool _out289;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _724_b), _724_b, _549_toTpe), selfIdent, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                        s = _out287;
                        isOwned = _out288;
                        isErased = _out289;
                        readIdents = _out290;
                      }
                    }
                  } else if (_source35.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _730___mcc_h380 = _source35.dtor_path;
                    DAST._IType _731_b = _719___mcc_h364;
                    {
                      if (object.Equals(_731_b, _549_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _732_recursiveGen;
                        bool _733_recOwned;
                        bool _734_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _735_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out291;
                        bool _out292;
                        bool _out293;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                        _732_recursiveGen = _out291;
                        _733_recOwned = _out292;
                        _734_recErased = _out293;
                        _735_recIdents = _out294;
                        Dafny.ISequence<Dafny.Rune> _736_uneraseFn;
                        _736_uneraseFn = ((_733_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _736_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _732_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _733_recOwned;
                        isErased = true;
                        readIdents = _735_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out295;
                        bool _out296;
                        bool _out297;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out298;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _731_b), _731_b, _549_toTpe), selfIdent, @params, mustOwn, out _out295, out _out296, out _out297, out _out298);
                        s = _out295;
                        isOwned = _out296;
                        isErased = _out297;
                        readIdents = _out298;
                      }
                    }
                  } else {
                    DAST._IType _737___mcc_h383 = _source35.dtor_Newtype_a0;
                    DAST._IType _738_b = _737___mcc_h383;
                    {
                      if (object.Equals(_550_fromTpe, _738_b)) {
                        Dafny.ISequence<Dafny.Rune> _739_recursiveGen;
                        bool _740_recOwned;
                        bool _741_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _742_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out299;
                        bool _out300;
                        bool _out301;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out302;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out299, out _out300, out _out301, out _out302);
                        _739_recursiveGen = _out299;
                        _740_recOwned = _out300;
                        _741_recErased = _out301;
                        _742_recIdents = _out302;
                        Dafny.ISequence<Dafny.Rune> _743_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out303;
                        _out303 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _743_rhsType = _out303;
                        Dafny.ISequence<Dafny.Rune> _744_uneraseFn;
                        _744_uneraseFn = ((_740_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _743_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _744_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _739_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _740_recOwned;
                        isErased = false;
                        readIdents = _742_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out304;
                        bool _out305;
                        bool _out306;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _738_b), _738_b, _549_toTpe), selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                        s = _out304;
                        isOwned = _out305;
                        isErased = _out306;
                        readIdents = _out307;
                      }
                    }
                  }
                } else if (_source34.is_Nullable) {
                  DAST._IType _745___mcc_h386 = _source34.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _746_recursiveGen;
                    bool _747_recOwned;
                    bool _748_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _749_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out308;
                    bool _out309;
                    bool _out310;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                    _746_recursiveGen = _out308;
                    _747_recOwned = _out309;
                    _748_recErased = _out310;
                    _749_recIdents = _out311;
                    if (!(_747_recOwned)) {
                      _746_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_746_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _748_recErased;
                    readIdents = _749_recIdents;
                  }
                } else if (_source34.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _750___mcc_h389 = _source34.dtor_Tuple_a0;
                  DAST._IType _751_b = _719___mcc_h364;
                  {
                    if (object.Equals(_751_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _752_recursiveGen;
                      bool _753_recOwned;
                      bool _754_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _755_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _752_recursiveGen = _out312;
                      _753_recOwned = _out313;
                      _754_recErased = _out314;
                      _755_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _756_uneraseFn;
                      _756_uneraseFn = ((_753_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _756_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _753_recOwned;
                      isErased = true;
                      readIdents = _755_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _751_b), _751_b, _549_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source34.is_Array) {
                  DAST._IType _757___mcc_h392 = _source34.dtor_element;
                  DAST._IType _758_b = _719___mcc_h364;
                  {
                    if (object.Equals(_758_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _759_recursiveGen;
                      bool _760_recOwned;
                      bool _761_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _762_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _759_recursiveGen = _out320;
                      _760_recOwned = _out321;
                      _761_recErased = _out322;
                      _762_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _763_uneraseFn;
                      _763_uneraseFn = ((_760_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _763_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _760_recOwned;
                      isErased = true;
                      readIdents = _762_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _758_b), _758_b, _549_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source34.is_Seq) {
                  DAST._IType _764___mcc_h395 = _source34.dtor_element;
                  DAST._IType _765_b = _719___mcc_h364;
                  {
                    if (object.Equals(_765_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _766_recursiveGen;
                      bool _767_recOwned;
                      bool _768_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _769_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _766_recursiveGen = _out328;
                      _767_recOwned = _out329;
                      _768_recErased = _out330;
                      _769_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _770_uneraseFn;
                      _770_uneraseFn = ((_767_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _770_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _766_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _767_recOwned;
                      isErased = true;
                      readIdents = _769_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _765_b), _765_b, _549_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source34.is_Set) {
                  DAST._IType _771___mcc_h398 = _source34.dtor_element;
                  DAST._IType _772_b = _719___mcc_h364;
                  {
                    if (object.Equals(_772_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _773_recursiveGen;
                      bool _774_recOwned;
                      bool _775_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _776_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _773_recursiveGen = _out336;
                      _774_recOwned = _out337;
                      _775_recErased = _out338;
                      _776_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _777_uneraseFn;
                      _777_uneraseFn = ((_774_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _777_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _773_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _774_recOwned;
                      isErased = true;
                      readIdents = _776_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _772_b), _772_b, _549_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source34.is_Multiset) {
                  DAST._IType _778___mcc_h401 = _source34.dtor_element;
                  DAST._IType _779_b = _719___mcc_h364;
                  {
                    if (object.Equals(_779_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _780_recursiveGen;
                      bool _781_recOwned;
                      bool _782_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _783_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _780_recursiveGen = _out344;
                      _781_recOwned = _out345;
                      _782_recErased = _out346;
                      _783_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _784_uneraseFn;
                      _784_uneraseFn = ((_781_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _784_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _780_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _781_recOwned;
                      isErased = true;
                      readIdents = _783_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _779_b), _779_b, _549_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source34.is_Map) {
                  DAST._IType _785___mcc_h404 = _source34.dtor_key;
                  DAST._IType _786___mcc_h405 = _source34.dtor_value;
                  DAST._IType _787_b = _719___mcc_h364;
                  {
                    if (object.Equals(_787_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _788_recursiveGen;
                      bool _789_recOwned;
                      bool _790_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _791_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _788_recursiveGen = _out352;
                      _789_recOwned = _out353;
                      _790_recErased = _out354;
                      _791_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _792_uneraseFn;
                      _792_uneraseFn = ((_789_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _792_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _788_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _789_recOwned;
                      isErased = true;
                      readIdents = _791_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _787_b), _787_b, _549_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source34.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _793___mcc_h410 = _source34.dtor_args;
                  DAST._IType _794___mcc_h411 = _source34.dtor_result;
                  DAST._IType _795_b = _719___mcc_h364;
                  {
                    if (object.Equals(_795_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _796_recursiveGen;
                      bool _797_recOwned;
                      bool _798_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _799_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _796_recursiveGen = _out360;
                      _797_recOwned = _out361;
                      _798_recErased = _out362;
                      _799_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _800_uneraseFn;
                      _800_uneraseFn = ((_797_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _800_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _796_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _797_recOwned;
                      isErased = true;
                      readIdents = _799_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _795_b), _795_b, _549_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else if (_source34.is_Primitive) {
                  DAST._IPrimitive _801___mcc_h416 = _source34.dtor_Primitive_a0;
                  DAST._IType _802_b = _719___mcc_h364;
                  {
                    if (object.Equals(_802_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _803_recursiveGen;
                      bool _804_recOwned;
                      bool _805_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _806_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _803_recursiveGen = _out368;
                      _804_recOwned = _out369;
                      _805_recErased = _out370;
                      _806_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _807_uneraseFn;
                      _807_uneraseFn = ((_804_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _807_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _803_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _804_recOwned;
                      isErased = true;
                      readIdents = _806_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _802_b), _802_b, _549_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                } else if (_source34.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _808___mcc_h419 = _source34.dtor_Passthrough_a0;
                  DAST._IType _809_b = _719___mcc_h364;
                  {
                    if (object.Equals(_809_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _810_recursiveGen;
                      bool _811_recOwned;
                      bool _812_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _813_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out376;
                      bool _out377;
                      bool _out378;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                      _810_recursiveGen = _out376;
                      _811_recOwned = _out377;
                      _812_recErased = _out378;
                      _813_recIdents = _out379;
                      Dafny.ISequence<Dafny.Rune> _814_uneraseFn;
                      _814_uneraseFn = ((_811_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _814_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _810_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _811_recOwned;
                      isErased = true;
                      readIdents = _813_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out380;
                      bool _out381;
                      bool _out382;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _809_b), _809_b, _549_toTpe), selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                      s = _out380;
                      isOwned = _out381;
                      isErased = _out382;
                      readIdents = _out383;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _815___mcc_h422 = _source34.dtor_TypeArg_a0;
                  DAST._IType _816_b = _719___mcc_h364;
                  {
                    if (object.Equals(_816_b, _549_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _817_recursiveGen;
                      bool _818_recOwned;
                      bool _819_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _820_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out384;
                      bool _out385;
                      bool _out386;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                      _817_recursiveGen = _out384;
                      _818_recOwned = _out385;
                      _819_recErased = _out386;
                      _820_recIdents = _out387;
                      Dafny.ISequence<Dafny.Rune> _821_uneraseFn;
                      _821_uneraseFn = ((_818_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _821_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _817_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _818_recOwned;
                      isErased = true;
                      readIdents = _820_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out388;
                      bool _out389;
                      bool _out390;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _816_b), _816_b, _549_toTpe), selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                      s = _out388;
                      isOwned = _out389;
                      isErased = _out390;
                      readIdents = _out391;
                    }
                  }
                }
              }
            } else if (_source28.is_Nullable) {
              DAST._IType _822___mcc_h425 = _source28.dtor_Nullable_a0;
              DAST._IType _source36 = _557___mcc_h265;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _823___mcc_h429 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _824___mcc_h430 = _source36.dtor_typeArgs;
                DAST._IResolvedType _825___mcc_h431 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _825___mcc_h431;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _826___mcc_h438 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _827_recursiveGen;
                    bool _828_recOwned;
                    bool _829_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _830_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out392;
                    bool _out393;
                    bool _out394;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                    _827_recursiveGen = _out392;
                    _828_recOwned = _out393;
                    _829_recErased = _out394;
                    _830_recIdents = _out395;
                    if (!(_828_recOwned)) {
                      _827_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_827_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_827_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _828_recOwned;
                    isErased = _829_recErased;
                    readIdents = _830_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _831___mcc_h441 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _832_recursiveGen;
                    bool _833_recOwned;
                    bool _834_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _835_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out396;
                    bool _out397;
                    bool _out398;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                    _832_recursiveGen = _out396;
                    _833_recOwned = _out397;
                    _834_recErased = _out398;
                    _835_recIdents = _out399;
                    if (!(_833_recOwned)) {
                      _832_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_832_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_832_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _833_recOwned;
                    isErased = _834_recErased;
                    readIdents = _835_recIdents;
                  }
                } else {
                  DAST._IType _836___mcc_h444 = _source37.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _837_recursiveGen;
                    bool _838_recOwned;
                    bool _839_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _840_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out400;
                    bool _out401;
                    bool _out402;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                    _837_recursiveGen = _out400;
                    _838_recOwned = _out401;
                    _839_recErased = _out402;
                    _840_recIdents = _out403;
                    if (!(_838_recOwned)) {
                      _837_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_837_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_837_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _838_recOwned;
                    isErased = _839_recErased;
                    readIdents = _840_recIdents;
                  }
                }
              } else if (_source36.is_Nullable) {
                DAST._IType _841___mcc_h447 = _source36.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _842_recursiveGen;
                  bool _843_recOwned;
                  bool _844_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _845_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _842_recursiveGen = _out404;
                  _843_recOwned = _out405;
                  _844_recErased = _out406;
                  _845_recIdents = _out407;
                  if (!(_843_recOwned)) {
                    _842_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_842_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_842_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _843_recOwned;
                  isErased = _844_recErased;
                  readIdents = _845_recIdents;
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _846___mcc_h450 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _847_recursiveGen;
                  bool _848_recOwned;
                  bool _849_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _850_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _847_recursiveGen = _out408;
                  _848_recOwned = _out409;
                  _849_recErased = _out410;
                  _850_recIdents = _out411;
                  if (!(_848_recOwned)) {
                    _847_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_847_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_847_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _848_recOwned;
                  isErased = _849_recErased;
                  readIdents = _850_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _851___mcc_h453 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _852_recursiveGen;
                  bool _853_recOwned;
                  bool _854_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _855_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _852_recursiveGen = _out412;
                  _853_recOwned = _out413;
                  _854_recErased = _out414;
                  _855_recIdents = _out415;
                  if (!(_853_recOwned)) {
                    _852_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_852_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_852_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _853_recOwned;
                  isErased = _854_recErased;
                  readIdents = _855_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _856___mcc_h456 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _857_recursiveGen;
                  bool _858_recOwned;
                  bool _859_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _860_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _857_recursiveGen = _out416;
                  _858_recOwned = _out417;
                  _859_recErased = _out418;
                  _860_recIdents = _out419;
                  if (!(_858_recOwned)) {
                    _857_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_857_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_857_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _858_recOwned;
                  isErased = _859_recErased;
                  readIdents = _860_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _861___mcc_h459 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _862_recursiveGen;
                  bool _863_recOwned;
                  bool _864_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _865_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _862_recursiveGen = _out420;
                  _863_recOwned = _out421;
                  _864_recErased = _out422;
                  _865_recIdents = _out423;
                  if (!(_863_recOwned)) {
                    _862_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_862_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_862_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _863_recOwned;
                  isErased = _864_recErased;
                  readIdents = _865_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _866___mcc_h462 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _867_recursiveGen;
                  bool _868_recOwned;
                  bool _869_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _870_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _867_recursiveGen = _out424;
                  _868_recOwned = _out425;
                  _869_recErased = _out426;
                  _870_recIdents = _out427;
                  if (!(_868_recOwned)) {
                    _867_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_867_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_867_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _868_recOwned;
                  isErased = _869_recErased;
                  readIdents = _870_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _871___mcc_h465 = _source36.dtor_key;
                DAST._IType _872___mcc_h466 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _873_recursiveGen;
                  bool _874_recOwned;
                  bool _875_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _876_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _873_recursiveGen = _out428;
                  _874_recOwned = _out429;
                  _875_recErased = _out430;
                  _876_recIdents = _out431;
                  if (!(_874_recOwned)) {
                    _873_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_873_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_873_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _874_recOwned;
                  isErased = _875_recErased;
                  readIdents = _876_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _877___mcc_h471 = _source36.dtor_args;
                DAST._IType _878___mcc_h472 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _879_recursiveGen;
                  bool _880_recOwned;
                  bool _881_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _882_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out432;
                  bool _out433;
                  bool _out434;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                  _879_recursiveGen = _out432;
                  _880_recOwned = _out433;
                  _881_recErased = _out434;
                  _882_recIdents = _out435;
                  if (!(_880_recOwned)) {
                    _879_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_879_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_879_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _880_recOwned;
                  isErased = _881_recErased;
                  readIdents = _882_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _883___mcc_h477 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _884_recursiveGen;
                  bool _885_recOwned;
                  bool _886_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _887_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out436;
                  bool _out437;
                  bool _out438;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                  _884_recursiveGen = _out436;
                  _885_recOwned = _out437;
                  _886_recErased = _out438;
                  _887_recIdents = _out439;
                  if (!(_885_recOwned)) {
                    _884_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_884_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_884_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _885_recOwned;
                  isErased = _886_recErased;
                  readIdents = _887_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _888___mcc_h480 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _889_recursiveGen;
                  bool _890_recOwned;
                  bool _891_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _892_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out440;
                  bool _out441;
                  bool _out442;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                  _889_recursiveGen = _out440;
                  _890_recOwned = _out441;
                  _891_recErased = _out442;
                  _892_recIdents = _out443;
                  if (!(_890_recOwned)) {
                    _889_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_889_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_889_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _890_recOwned;
                  isErased = _891_recErased;
                  readIdents = _892_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _893___mcc_h483 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _894_recursiveGen;
                  bool _895_recOwned;
                  bool _896_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _897_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out444;
                  bool _out445;
                  bool _out446;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out447;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out444, out _out445, out _out446, out _out447);
                  _894_recursiveGen = _out444;
                  _895_recOwned = _out445;
                  _896_recErased = _out446;
                  _897_recIdents = _out447;
                  if (!(_895_recOwned)) {
                    _894_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_894_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_894_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _895_recOwned;
                  isErased = _896_recErased;
                  readIdents = _897_recIdents;
                }
              }
            } else if (_source28.is_Tuple) {
              Dafny.ISequence<DAST._IType> _898___mcc_h486 = _source28.dtor_Tuple_a0;
              DAST._IType _source38 = _557___mcc_h265;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _899___mcc_h490 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _900___mcc_h491 = _source38.dtor_typeArgs;
                DAST._IResolvedType _901___mcc_h492 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _901___mcc_h492;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _902___mcc_h496 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _903_recursiveGen;
                    bool _904_recOwned;
                    bool _905_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _906_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out448;
                    bool _out449;
                    bool _out450;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out451;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out448, out _out449, out _out450, out _out451);
                    _903_recursiveGen = _out448;
                    _904_recOwned = _out449;
                    _905_recErased = _out450;
                    _906_recIdents = _out451;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _903_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _904_recOwned;
                    isErased = _905_recErased;
                    readIdents = _906_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _907___mcc_h498 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _908_recursiveGen;
                    bool _909_recOwned;
                    bool _910_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _911_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out452;
                    bool _out453;
                    bool _out454;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out455;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out452, out _out453, out _out454, out _out455);
                    _908_recursiveGen = _out452;
                    _909_recOwned = _out453;
                    _910_recErased = _out454;
                    _911_recIdents = _out455;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _908_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _909_recOwned;
                    isErased = _910_recErased;
                    readIdents = _911_recIdents;
                  }
                } else {
                  DAST._IType _912___mcc_h500 = _source39.dtor_Newtype_a0;
                  DAST._IType _913_b = _912___mcc_h500;
                  {
                    if (object.Equals(_550_fromTpe, _913_b)) {
                      Dafny.ISequence<Dafny.Rune> _914_recursiveGen;
                      bool _915_recOwned;
                      bool _916_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _917_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out456;
                      bool _out457;
                      bool _out458;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out459;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out456, out _out457, out _out458, out _out459);
                      _914_recursiveGen = _out456;
                      _915_recOwned = _out457;
                      _916_recErased = _out458;
                      _917_recIdents = _out459;
                      Dafny.ISequence<Dafny.Rune> _918_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out460;
                      _out460 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _918_rhsType = _out460;
                      Dafny.ISequence<Dafny.Rune> _919_uneraseFn;
                      _919_uneraseFn = ((_915_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _918_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _919_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _914_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _915_recOwned;
                      isErased = false;
                      readIdents = _917_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out461;
                      bool _out462;
                      bool _out463;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _913_b), _913_b, _549_toTpe), selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                      s = _out461;
                      isOwned = _out462;
                      isErased = _out463;
                      readIdents = _out464;
                    }
                  }
                }
              } else if (_source38.is_Nullable) {
                DAST._IType _920___mcc_h502 = _source38.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _921_recursiveGen;
                  bool _922_recOwned;
                  bool _923_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _924_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _921_recursiveGen = _out465;
                  _922_recOwned = _out466;
                  _923_recErased = _out467;
                  _924_recIdents = _out468;
                  if (!(_922_recOwned)) {
                    _921_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_921_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _921_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _923_recErased;
                  readIdents = _924_recIdents;
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _925___mcc_h504 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _926_recursiveGen;
                  bool _927_recOwned;
                  bool _928_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _929_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _926_recursiveGen = _out469;
                  _927_recOwned = _out470;
                  _928_recErased = _out471;
                  _929_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _926_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _927_recOwned;
                  isErased = _928_recErased;
                  readIdents = _929_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _930___mcc_h506 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _931_recursiveGen;
                  bool _932_recOwned;
                  bool _933_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _934_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _931_recursiveGen = _out473;
                  _932_recOwned = _out474;
                  _933_recErased = _out475;
                  _934_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _931_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _932_recOwned;
                  isErased = _933_recErased;
                  readIdents = _934_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _935___mcc_h508 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _936_recursiveGen;
                  bool _937_recOwned;
                  bool _938_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _939_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _936_recursiveGen = _out477;
                  _937_recOwned = _out478;
                  _938_recErased = _out479;
                  _939_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _936_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _937_recOwned;
                  isErased = _938_recErased;
                  readIdents = _939_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _940___mcc_h510 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _941_recursiveGen;
                  bool _942_recOwned;
                  bool _943_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _944_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _941_recursiveGen = _out481;
                  _942_recOwned = _out482;
                  _943_recErased = _out483;
                  _944_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _941_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _942_recOwned;
                  isErased = _943_recErased;
                  readIdents = _944_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _945___mcc_h512 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _946_recursiveGen;
                  bool _947_recOwned;
                  bool _948_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _949_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _946_recursiveGen = _out485;
                  _947_recOwned = _out486;
                  _948_recErased = _out487;
                  _949_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _946_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _947_recOwned;
                  isErased = _948_recErased;
                  readIdents = _949_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _950___mcc_h514 = _source38.dtor_key;
                DAST._IType _951___mcc_h515 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _952_recursiveGen;
                  bool _953_recOwned;
                  bool _954_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _955_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _952_recursiveGen = _out489;
                  _953_recOwned = _out490;
                  _954_recErased = _out491;
                  _955_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _953_recOwned;
                  isErased = _954_recErased;
                  readIdents = _955_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _956___mcc_h518 = _source38.dtor_args;
                DAST._IType _957___mcc_h519 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _958_recursiveGen;
                  bool _959_recOwned;
                  bool _960_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _961_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out493;
                  bool _out494;
                  bool _out495;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                  _958_recursiveGen = _out493;
                  _959_recOwned = _out494;
                  _960_recErased = _out495;
                  _961_recIdents = _out496;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _958_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _959_recOwned;
                  isErased = _960_recErased;
                  readIdents = _961_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _962___mcc_h522 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _963_recursiveGen;
                  bool _964_recOwned;
                  bool _965_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _966_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out497;
                  bool _out498;
                  bool _out499;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                  _963_recursiveGen = _out497;
                  _964_recOwned = _out498;
                  _965_recErased = _out499;
                  _966_recIdents = _out500;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _963_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _964_recOwned;
                  isErased = _965_recErased;
                  readIdents = _966_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _967___mcc_h524 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _968_recursiveGen;
                  bool _969_recOwned;
                  bool _970_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _971_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out501;
                  bool _out502;
                  bool _out503;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                  _968_recursiveGen = _out501;
                  _969_recOwned = _out502;
                  _970_recErased = _out503;
                  _971_recIdents = _out504;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _968_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _969_recOwned;
                  isErased = _970_recErased;
                  readIdents = _971_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _972___mcc_h526 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _973_recursiveGen;
                  bool _974_recOwned;
                  bool _975_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _976_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out505;
                  bool _out506;
                  bool _out507;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out508;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out505, out _out506, out _out507, out _out508);
                  _973_recursiveGen = _out505;
                  _974_recOwned = _out506;
                  _975_recErased = _out507;
                  _976_recIdents = _out508;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _973_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _974_recOwned;
                  isErased = _975_recErased;
                  readIdents = _976_recIdents;
                }
              }
            } else if (_source28.is_Array) {
              DAST._IType _977___mcc_h528 = _source28.dtor_element;
              DAST._IType _source40 = _557___mcc_h265;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _978___mcc_h532 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _979___mcc_h533 = _source40.dtor_typeArgs;
                DAST._IResolvedType _980___mcc_h534 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _980___mcc_h534;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _981___mcc_h538 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _982_recursiveGen;
                    bool _983_recOwned;
                    bool _984_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _985_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out509;
                    bool _out510;
                    bool _out511;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out512;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out509, out _out510, out _out511, out _out512);
                    _982_recursiveGen = _out509;
                    _983_recOwned = _out510;
                    _984_recErased = _out511;
                    _985_recIdents = _out512;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _983_recOwned;
                    isErased = _984_recErased;
                    readIdents = _985_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _986___mcc_h540 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _987_recursiveGen;
                    bool _988_recOwned;
                    bool _989_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _990_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out513;
                    bool _out514;
                    bool _out515;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out516;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out513, out _out514, out _out515, out _out516);
                    _987_recursiveGen = _out513;
                    _988_recOwned = _out514;
                    _989_recErased = _out515;
                    _990_recIdents = _out516;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _988_recOwned;
                    isErased = _989_recErased;
                    readIdents = _990_recIdents;
                  }
                } else {
                  DAST._IType _991___mcc_h542 = _source41.dtor_Newtype_a0;
                  DAST._IType _992_b = _991___mcc_h542;
                  {
                    if (object.Equals(_550_fromTpe, _992_b)) {
                      Dafny.ISequence<Dafny.Rune> _993_recursiveGen;
                      bool _994_recOwned;
                      bool _995_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _996_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out517;
                      bool _out518;
                      bool _out519;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out520;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out517, out _out518, out _out519, out _out520);
                      _993_recursiveGen = _out517;
                      _994_recOwned = _out518;
                      _995_recErased = _out519;
                      _996_recIdents = _out520;
                      Dafny.ISequence<Dafny.Rune> _997_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out521;
                      _out521 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _997_rhsType = _out521;
                      Dafny.ISequence<Dafny.Rune> _998_uneraseFn;
                      _998_uneraseFn = ((_994_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _997_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _998_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _993_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _994_recOwned;
                      isErased = false;
                      readIdents = _996_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out522;
                      bool _out523;
                      bool _out524;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _992_b), _992_b, _549_toTpe), selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                      s = _out522;
                      isOwned = _out523;
                      isErased = _out524;
                      readIdents = _out525;
                    }
                  }
                }
              } else if (_source40.is_Nullable) {
                DAST._IType _999___mcc_h544 = _source40.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1000_recursiveGen;
                  bool _1001_recOwned;
                  bool _1002_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1003_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _1000_recursiveGen = _out526;
                  _1001_recOwned = _out527;
                  _1002_recErased = _out528;
                  _1003_recIdents = _out529;
                  if (!(_1001_recOwned)) {
                    _1000_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1000_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1000_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1002_recErased;
                  readIdents = _1003_recIdents;
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1004___mcc_h546 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1005_recursiveGen;
                  bool _1006_recOwned;
                  bool _1007_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1008_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _1005_recursiveGen = _out530;
                  _1006_recOwned = _out531;
                  _1007_recErased = _out532;
                  _1008_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1005_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1006_recOwned;
                  isErased = _1007_recErased;
                  readIdents = _1008_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _1009___mcc_h548 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1010_recursiveGen;
                  bool _1011_recOwned;
                  bool _1012_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1013_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _1010_recursiveGen = _out534;
                  _1011_recOwned = _out535;
                  _1012_recErased = _out536;
                  _1013_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1010_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1011_recOwned;
                  isErased = _1012_recErased;
                  readIdents = _1013_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _1014___mcc_h550 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1015_recursiveGen;
                  bool _1016_recOwned;
                  bool _1017_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1018_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _1015_recursiveGen = _out538;
                  _1016_recOwned = _out539;
                  _1017_recErased = _out540;
                  _1018_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1015_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1016_recOwned;
                  isErased = _1017_recErased;
                  readIdents = _1018_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _1019___mcc_h552 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1020_recursiveGen;
                  bool _1021_recOwned;
                  bool _1022_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1023_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _1020_recursiveGen = _out542;
                  _1021_recOwned = _out543;
                  _1022_recErased = _out544;
                  _1023_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1020_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1021_recOwned;
                  isErased = _1022_recErased;
                  readIdents = _1023_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1024___mcc_h554 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1025_recursiveGen;
                  bool _1026_recOwned;
                  bool _1027_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1028_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _1025_recursiveGen = _out546;
                  _1026_recOwned = _out547;
                  _1027_recErased = _out548;
                  _1028_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1026_recOwned;
                  isErased = _1027_recErased;
                  readIdents = _1028_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1029___mcc_h556 = _source40.dtor_key;
                DAST._IType _1030___mcc_h557 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1031_recursiveGen;
                  bool _1032_recOwned;
                  bool _1033_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1034_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _1031_recursiveGen = _out550;
                  _1032_recOwned = _out551;
                  _1033_recErased = _out552;
                  _1034_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1031_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1032_recOwned;
                  isErased = _1033_recErased;
                  readIdents = _1034_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1035___mcc_h560 = _source40.dtor_args;
                DAST._IType _1036___mcc_h561 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1037_recursiveGen;
                  bool _1038_recOwned;
                  bool _1039_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1040_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out554;
                  bool _out555;
                  bool _out556;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                  _1037_recursiveGen = _out554;
                  _1038_recOwned = _out555;
                  _1039_recErased = _out556;
                  _1040_recIdents = _out557;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1037_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1038_recOwned;
                  isErased = _1039_recErased;
                  readIdents = _1040_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1041___mcc_h564 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1042_recursiveGen;
                  bool _1043_recOwned;
                  bool _1044_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1045_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out558;
                  bool _out559;
                  bool _out560;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                  _1042_recursiveGen = _out558;
                  _1043_recOwned = _out559;
                  _1044_recErased = _out560;
                  _1045_recIdents = _out561;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1042_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1043_recOwned;
                  isErased = _1044_recErased;
                  readIdents = _1045_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1046___mcc_h566 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1047_recursiveGen;
                  bool _1048_recOwned;
                  bool _1049_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1050_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out562;
                  bool _out563;
                  bool _out564;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                  _1047_recursiveGen = _out562;
                  _1048_recOwned = _out563;
                  _1049_recErased = _out564;
                  _1050_recIdents = _out565;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1047_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1048_recOwned;
                  isErased = _1049_recErased;
                  readIdents = _1050_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1051___mcc_h568 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1052_recursiveGen;
                  bool _1053_recOwned;
                  bool _1054_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1055_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out566;
                  bool _out567;
                  bool _out568;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out569;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out566, out _out567, out _out568, out _out569);
                  _1052_recursiveGen = _out566;
                  _1053_recOwned = _out567;
                  _1054_recErased = _out568;
                  _1055_recIdents = _out569;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1052_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1053_recOwned;
                  isErased = _1054_recErased;
                  readIdents = _1055_recIdents;
                }
              }
            } else if (_source28.is_Seq) {
              DAST._IType _1056___mcc_h570 = _source28.dtor_element;
              DAST._IType _source42 = _557___mcc_h265;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1057___mcc_h574 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1058___mcc_h575 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1059___mcc_h576 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1059___mcc_h576;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1060___mcc_h580 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1061_recursiveGen;
                    bool _1062_recOwned;
                    bool _1063_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1064_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out570;
                    bool _out571;
                    bool _out572;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out573;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out570, out _out571, out _out572, out _out573);
                    _1061_recursiveGen = _out570;
                    _1062_recOwned = _out571;
                    _1063_recErased = _out572;
                    _1064_recIdents = _out573;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1062_recOwned;
                    isErased = _1063_recErased;
                    readIdents = _1064_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1065___mcc_h582 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1066_recursiveGen;
                    bool _1067_recOwned;
                    bool _1068_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1069_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out574;
                    bool _out575;
                    bool _out576;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out577;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out574, out _out575, out _out576, out _out577);
                    _1066_recursiveGen = _out574;
                    _1067_recOwned = _out575;
                    _1068_recErased = _out576;
                    _1069_recIdents = _out577;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1066_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1067_recOwned;
                    isErased = _1068_recErased;
                    readIdents = _1069_recIdents;
                  }
                } else {
                  DAST._IType _1070___mcc_h584 = _source43.dtor_Newtype_a0;
                  DAST._IType _1071_b = _1070___mcc_h584;
                  {
                    if (object.Equals(_550_fromTpe, _1071_b)) {
                      Dafny.ISequence<Dafny.Rune> _1072_recursiveGen;
                      bool _1073_recOwned;
                      bool _1074_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1075_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out578;
                      bool _out579;
                      bool _out580;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out581;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out578, out _out579, out _out580, out _out581);
                      _1072_recursiveGen = _out578;
                      _1073_recOwned = _out579;
                      _1074_recErased = _out580;
                      _1075_recIdents = _out581;
                      Dafny.ISequence<Dafny.Rune> _1076_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out582;
                      _out582 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1076_rhsType = _out582;
                      Dafny.ISequence<Dafny.Rune> _1077_uneraseFn;
                      _1077_uneraseFn = ((_1073_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1076_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1077_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1073_recOwned;
                      isErased = false;
                      readIdents = _1075_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out583;
                      bool _out584;
                      bool _out585;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1071_b), _1071_b, _549_toTpe), selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                      s = _out583;
                      isOwned = _out584;
                      isErased = _out585;
                      readIdents = _out586;
                    }
                  }
                }
              } else if (_source42.is_Nullable) {
                DAST._IType _1078___mcc_h586 = _source42.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1079_recursiveGen;
                  bool _1080_recOwned;
                  bool _1081_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1082_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1079_recursiveGen = _out587;
                  _1080_recOwned = _out588;
                  _1081_recErased = _out589;
                  _1082_recIdents = _out590;
                  if (!(_1080_recOwned)) {
                    _1079_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1079_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1079_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1081_recErased;
                  readIdents = _1082_recIdents;
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1083___mcc_h588 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1084_recursiveGen;
                  bool _1085_recOwned;
                  bool _1086_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1087_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1084_recursiveGen = _out591;
                  _1085_recOwned = _out592;
                  _1086_recErased = _out593;
                  _1087_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1084_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1085_recOwned;
                  isErased = _1086_recErased;
                  readIdents = _1087_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1088___mcc_h590 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1089_recursiveGen;
                  bool _1090_recOwned;
                  bool _1091_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1092_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1089_recursiveGen = _out595;
                  _1090_recOwned = _out596;
                  _1091_recErased = _out597;
                  _1092_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1089_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1090_recOwned;
                  isErased = _1091_recErased;
                  readIdents = _1092_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1093___mcc_h592 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1094_recursiveGen;
                  bool _1095_recOwned;
                  bool _1096_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1097_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1094_recursiveGen = _out599;
                  _1095_recOwned = _out600;
                  _1096_recErased = _out601;
                  _1097_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1094_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1095_recOwned;
                  isErased = _1096_recErased;
                  readIdents = _1097_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1098___mcc_h594 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1099_recursiveGen;
                  bool _1100_recOwned;
                  bool _1101_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1102_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1099_recursiveGen = _out603;
                  _1100_recOwned = _out604;
                  _1101_recErased = _out605;
                  _1102_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1099_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1100_recOwned;
                  isErased = _1101_recErased;
                  readIdents = _1102_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1103___mcc_h596 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1104_recursiveGen;
                  bool _1105_recOwned;
                  bool _1106_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1107_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1104_recursiveGen = _out607;
                  _1105_recOwned = _out608;
                  _1106_recErased = _out609;
                  _1107_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1104_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1105_recOwned;
                  isErased = _1106_recErased;
                  readIdents = _1107_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1108___mcc_h598 = _source42.dtor_key;
                DAST._IType _1109___mcc_h599 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1110_recursiveGen;
                  bool _1111_recOwned;
                  bool _1112_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1113_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1110_recursiveGen = _out611;
                  _1111_recOwned = _out612;
                  _1112_recErased = _out613;
                  _1113_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1110_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1111_recOwned;
                  isErased = _1112_recErased;
                  readIdents = _1113_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1114___mcc_h602 = _source42.dtor_args;
                DAST._IType _1115___mcc_h603 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1116_recursiveGen;
                  bool _1117_recOwned;
                  bool _1118_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1119_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out615;
                  bool _out616;
                  bool _out617;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                  _1116_recursiveGen = _out615;
                  _1117_recOwned = _out616;
                  _1118_recErased = _out617;
                  _1119_recIdents = _out618;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1116_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1117_recOwned;
                  isErased = _1118_recErased;
                  readIdents = _1119_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1120___mcc_h606 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1121_recursiveGen;
                  bool _1122_recOwned;
                  bool _1123_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1124_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out619;
                  bool _out620;
                  bool _out621;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                  _1121_recursiveGen = _out619;
                  _1122_recOwned = _out620;
                  _1123_recErased = _out621;
                  _1124_recIdents = _out622;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1121_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1122_recOwned;
                  isErased = _1123_recErased;
                  readIdents = _1124_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1125___mcc_h608 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1126_recursiveGen;
                  bool _1127_recOwned;
                  bool _1128_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1129_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out623;
                  bool _out624;
                  bool _out625;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                  _1126_recursiveGen = _out623;
                  _1127_recOwned = _out624;
                  _1128_recErased = _out625;
                  _1129_recIdents = _out626;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1126_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1127_recOwned;
                  isErased = _1128_recErased;
                  readIdents = _1129_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1130___mcc_h610 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1131_recursiveGen;
                  bool _1132_recOwned;
                  bool _1133_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1134_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out627;
                  bool _out628;
                  bool _out629;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out630;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out627, out _out628, out _out629, out _out630);
                  _1131_recursiveGen = _out627;
                  _1132_recOwned = _out628;
                  _1133_recErased = _out629;
                  _1134_recIdents = _out630;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1131_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1132_recOwned;
                  isErased = _1133_recErased;
                  readIdents = _1134_recIdents;
                }
              }
            } else if (_source28.is_Set) {
              DAST._IType _1135___mcc_h612 = _source28.dtor_element;
              DAST._IType _source44 = _557___mcc_h265;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1136___mcc_h616 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1137___mcc_h617 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1138___mcc_h618 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1138___mcc_h618;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1139___mcc_h622 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1140_recursiveGen;
                    bool _1141_recOwned;
                    bool _1142_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1143_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out631;
                    bool _out632;
                    bool _out633;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out634;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out631, out _out632, out _out633, out _out634);
                    _1140_recursiveGen = _out631;
                    _1141_recOwned = _out632;
                    _1142_recErased = _out633;
                    _1143_recIdents = _out634;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1140_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1141_recOwned;
                    isErased = _1142_recErased;
                    readIdents = _1143_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1144___mcc_h624 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1145_recursiveGen;
                    bool _1146_recOwned;
                    bool _1147_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1148_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out635;
                    bool _out636;
                    bool _out637;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out638;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out635, out _out636, out _out637, out _out638);
                    _1145_recursiveGen = _out635;
                    _1146_recOwned = _out636;
                    _1147_recErased = _out637;
                    _1148_recIdents = _out638;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1145_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1146_recOwned;
                    isErased = _1147_recErased;
                    readIdents = _1148_recIdents;
                  }
                } else {
                  DAST._IType _1149___mcc_h626 = _source45.dtor_Newtype_a0;
                  DAST._IType _1150_b = _1149___mcc_h626;
                  {
                    if (object.Equals(_550_fromTpe, _1150_b)) {
                      Dafny.ISequence<Dafny.Rune> _1151_recursiveGen;
                      bool _1152_recOwned;
                      bool _1153_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1154_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out639;
                      bool _out640;
                      bool _out641;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out642;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out639, out _out640, out _out641, out _out642);
                      _1151_recursiveGen = _out639;
                      _1152_recOwned = _out640;
                      _1153_recErased = _out641;
                      _1154_recIdents = _out642;
                      Dafny.ISequence<Dafny.Rune> _1155_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out643;
                      _out643 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1155_rhsType = _out643;
                      Dafny.ISequence<Dafny.Rune> _1156_uneraseFn;
                      _1156_uneraseFn = ((_1152_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1155_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1156_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1151_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1152_recOwned;
                      isErased = false;
                      readIdents = _1154_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out644;
                      bool _out645;
                      bool _out646;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1150_b), _1150_b, _549_toTpe), selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                      s = _out644;
                      isOwned = _out645;
                      isErased = _out646;
                      readIdents = _out647;
                    }
                  }
                }
              } else if (_source44.is_Nullable) {
                DAST._IType _1157___mcc_h628 = _source44.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1158_recursiveGen;
                  bool _1159_recOwned;
                  bool _1160_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1161_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1158_recursiveGen = _out648;
                  _1159_recOwned = _out649;
                  _1160_recErased = _out650;
                  _1161_recIdents = _out651;
                  if (!(_1159_recOwned)) {
                    _1158_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1158_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1158_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1160_recErased;
                  readIdents = _1161_recIdents;
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1162___mcc_h630 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1163_recursiveGen;
                  bool _1164_recOwned;
                  bool _1165_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1166_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1163_recursiveGen = _out652;
                  _1164_recOwned = _out653;
                  _1165_recErased = _out654;
                  _1166_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1163_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1164_recOwned;
                  isErased = _1165_recErased;
                  readIdents = _1166_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1167___mcc_h632 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1168_recursiveGen;
                  bool _1169_recOwned;
                  bool _1170_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1171_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1168_recursiveGen = _out656;
                  _1169_recOwned = _out657;
                  _1170_recErased = _out658;
                  _1171_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1168_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1169_recOwned;
                  isErased = _1170_recErased;
                  readIdents = _1171_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1172___mcc_h634 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1173_recursiveGen;
                  bool _1174_recOwned;
                  bool _1175_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1176_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1173_recursiveGen = _out660;
                  _1174_recOwned = _out661;
                  _1175_recErased = _out662;
                  _1176_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1173_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1174_recOwned;
                  isErased = _1175_recErased;
                  readIdents = _1176_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1177___mcc_h636 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1178_recursiveGen;
                  bool _1179_recOwned;
                  bool _1180_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1181_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1178_recursiveGen = _out664;
                  _1179_recOwned = _out665;
                  _1180_recErased = _out666;
                  _1181_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1178_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1179_recOwned;
                  isErased = _1180_recErased;
                  readIdents = _1181_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1182___mcc_h638 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1183_recursiveGen;
                  bool _1184_recOwned;
                  bool _1185_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1186_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1183_recursiveGen = _out668;
                  _1184_recOwned = _out669;
                  _1185_recErased = _out670;
                  _1186_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1183_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1184_recOwned;
                  isErased = _1185_recErased;
                  readIdents = _1186_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1187___mcc_h640 = _source44.dtor_key;
                DAST._IType _1188___mcc_h641 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                  bool _1190_recOwned;
                  bool _1191_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1189_recursiveGen = _out672;
                  _1190_recOwned = _out673;
                  _1191_recErased = _out674;
                  _1192_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1190_recOwned;
                  isErased = _1191_recErased;
                  readIdents = _1192_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1193___mcc_h644 = _source44.dtor_args;
                DAST._IType _1194___mcc_h645 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1195_recursiveGen;
                  bool _1196_recOwned;
                  bool _1197_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1198_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out676;
                  bool _out677;
                  bool _out678;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                  _1195_recursiveGen = _out676;
                  _1196_recOwned = _out677;
                  _1197_recErased = _out678;
                  _1198_recIdents = _out679;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1195_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1196_recOwned;
                  isErased = _1197_recErased;
                  readIdents = _1198_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1199___mcc_h648 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1200_recursiveGen;
                  bool _1201_recOwned;
                  bool _1202_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1203_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out680;
                  bool _out681;
                  bool _out682;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                  _1200_recursiveGen = _out680;
                  _1201_recOwned = _out681;
                  _1202_recErased = _out682;
                  _1203_recIdents = _out683;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1200_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1201_recOwned;
                  isErased = _1202_recErased;
                  readIdents = _1203_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1204___mcc_h650 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                  bool _1206_recOwned;
                  bool _1207_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out684;
                  bool _out685;
                  bool _out686;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                  _1205_recursiveGen = _out684;
                  _1206_recOwned = _out685;
                  _1207_recErased = _out686;
                  _1208_recIdents = _out687;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1206_recOwned;
                  isErased = _1207_recErased;
                  readIdents = _1208_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1209___mcc_h652 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1210_recursiveGen;
                  bool _1211_recOwned;
                  bool _1212_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1213_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out688;
                  bool _out689;
                  bool _out690;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out691;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out688, out _out689, out _out690, out _out691);
                  _1210_recursiveGen = _out688;
                  _1211_recOwned = _out689;
                  _1212_recErased = _out690;
                  _1213_recIdents = _out691;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1210_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1211_recOwned;
                  isErased = _1212_recErased;
                  readIdents = _1213_recIdents;
                }
              }
            } else if (_source28.is_Multiset) {
              DAST._IType _1214___mcc_h654 = _source28.dtor_element;
              DAST._IType _source46 = _557___mcc_h265;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1215___mcc_h658 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1216___mcc_h659 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1217___mcc_h660 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1217___mcc_h660;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1218___mcc_h664 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1219_recursiveGen;
                    bool _1220_recOwned;
                    bool _1221_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1222_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out692;
                    bool _out693;
                    bool _out694;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out695;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out692, out _out693, out _out694, out _out695);
                    _1219_recursiveGen = _out692;
                    _1220_recOwned = _out693;
                    _1221_recErased = _out694;
                    _1222_recIdents = _out695;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1219_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1220_recOwned;
                    isErased = _1221_recErased;
                    readIdents = _1222_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1223___mcc_h666 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1224_recursiveGen;
                    bool _1225_recOwned;
                    bool _1226_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1227_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out696;
                    bool _out697;
                    bool _out698;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out699;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out696, out _out697, out _out698, out _out699);
                    _1224_recursiveGen = _out696;
                    _1225_recOwned = _out697;
                    _1226_recErased = _out698;
                    _1227_recIdents = _out699;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1224_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1225_recOwned;
                    isErased = _1226_recErased;
                    readIdents = _1227_recIdents;
                  }
                } else {
                  DAST._IType _1228___mcc_h668 = _source47.dtor_Newtype_a0;
                  DAST._IType _1229_b = _1228___mcc_h668;
                  {
                    if (object.Equals(_550_fromTpe, _1229_b)) {
                      Dafny.ISequence<Dafny.Rune> _1230_recursiveGen;
                      bool _1231_recOwned;
                      bool _1232_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1233_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out700;
                      bool _out701;
                      bool _out702;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out703;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out700, out _out701, out _out702, out _out703);
                      _1230_recursiveGen = _out700;
                      _1231_recOwned = _out701;
                      _1232_recErased = _out702;
                      _1233_recIdents = _out703;
                      Dafny.ISequence<Dafny.Rune> _1234_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out704;
                      _out704 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1234_rhsType = _out704;
                      Dafny.ISequence<Dafny.Rune> _1235_uneraseFn;
                      _1235_uneraseFn = ((_1231_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1234_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1235_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1230_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1231_recOwned;
                      isErased = false;
                      readIdents = _1233_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out705;
                      bool _out706;
                      bool _out707;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1229_b), _1229_b, _549_toTpe), selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                      s = _out705;
                      isOwned = _out706;
                      isErased = _out707;
                      readIdents = _out708;
                    }
                  }
                }
              } else if (_source46.is_Nullable) {
                DAST._IType _1236___mcc_h670 = _source46.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1237_recursiveGen;
                  bool _1238_recOwned;
                  bool _1239_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1240_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1237_recursiveGen = _out709;
                  _1238_recOwned = _out710;
                  _1239_recErased = _out711;
                  _1240_recIdents = _out712;
                  if (!(_1238_recOwned)) {
                    _1237_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1237_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1237_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1239_recErased;
                  readIdents = _1240_recIdents;
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1241___mcc_h672 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1242_recursiveGen;
                  bool _1243_recOwned;
                  bool _1244_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1245_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1242_recursiveGen = _out713;
                  _1243_recOwned = _out714;
                  _1244_recErased = _out715;
                  _1245_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1242_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1243_recOwned;
                  isErased = _1244_recErased;
                  readIdents = _1245_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1246___mcc_h674 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                  bool _1248_recOwned;
                  bool _1249_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1247_recursiveGen = _out717;
                  _1248_recOwned = _out718;
                  _1249_recErased = _out719;
                  _1250_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1248_recOwned;
                  isErased = _1249_recErased;
                  readIdents = _1250_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1251___mcc_h676 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1252_recursiveGen;
                  bool _1253_recOwned;
                  bool _1254_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1255_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1252_recursiveGen = _out721;
                  _1253_recOwned = _out722;
                  _1254_recErased = _out723;
                  _1255_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1252_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1253_recOwned;
                  isErased = _1254_recErased;
                  readIdents = _1255_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1256___mcc_h678 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1257_recursiveGen;
                  bool _1258_recOwned;
                  bool _1259_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1260_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1257_recursiveGen = _out725;
                  _1258_recOwned = _out726;
                  _1259_recErased = _out727;
                  _1260_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1257_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1258_recOwned;
                  isErased = _1259_recErased;
                  readIdents = _1260_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1261___mcc_h680 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1262_recursiveGen;
                  bool _1263_recOwned;
                  bool _1264_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1265_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1262_recursiveGen = _out729;
                  _1263_recOwned = _out730;
                  _1264_recErased = _out731;
                  _1265_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1262_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1263_recOwned;
                  isErased = _1264_recErased;
                  readIdents = _1265_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1266___mcc_h682 = _source46.dtor_key;
                DAST._IType _1267___mcc_h683 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1268_recursiveGen;
                  bool _1269_recOwned;
                  bool _1270_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1271_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1268_recursiveGen = _out733;
                  _1269_recOwned = _out734;
                  _1270_recErased = _out735;
                  _1271_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1268_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1269_recOwned;
                  isErased = _1270_recErased;
                  readIdents = _1271_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1272___mcc_h686 = _source46.dtor_args;
                DAST._IType _1273___mcc_h687 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1274_recursiveGen;
                  bool _1275_recOwned;
                  bool _1276_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1277_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out737;
                  bool _out738;
                  bool _out739;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                  _1274_recursiveGen = _out737;
                  _1275_recOwned = _out738;
                  _1276_recErased = _out739;
                  _1277_recIdents = _out740;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1274_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1275_recOwned;
                  isErased = _1276_recErased;
                  readIdents = _1277_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1278___mcc_h690 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1279_recursiveGen;
                  bool _1280_recOwned;
                  bool _1281_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1282_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out741;
                  bool _out742;
                  bool _out743;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                  _1279_recursiveGen = _out741;
                  _1280_recOwned = _out742;
                  _1281_recErased = _out743;
                  _1282_recIdents = _out744;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1279_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1280_recOwned;
                  isErased = _1281_recErased;
                  readIdents = _1282_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1283___mcc_h692 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1284_recursiveGen;
                  bool _1285_recOwned;
                  bool _1286_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1287_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out745;
                  bool _out746;
                  bool _out747;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                  _1284_recursiveGen = _out745;
                  _1285_recOwned = _out746;
                  _1286_recErased = _out747;
                  _1287_recIdents = _out748;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1284_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1285_recOwned;
                  isErased = _1286_recErased;
                  readIdents = _1287_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1288___mcc_h694 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1289_recursiveGen;
                  bool _1290_recOwned;
                  bool _1291_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1292_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out749;
                  bool _out750;
                  bool _out751;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out752;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out749, out _out750, out _out751, out _out752);
                  _1289_recursiveGen = _out749;
                  _1290_recOwned = _out750;
                  _1291_recErased = _out751;
                  _1292_recIdents = _out752;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1289_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1290_recOwned;
                  isErased = _1291_recErased;
                  readIdents = _1292_recIdents;
                }
              }
            } else if (_source28.is_Map) {
              DAST._IType _1293___mcc_h696 = _source28.dtor_key;
              DAST._IType _1294___mcc_h697 = _source28.dtor_value;
              DAST._IType _source48 = _557___mcc_h265;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1295___mcc_h704 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1296___mcc_h705 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1297___mcc_h706 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1297___mcc_h706;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1298___mcc_h710 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1299_recursiveGen;
                    bool _1300_recOwned;
                    bool _1301_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1302_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out753;
                    bool _out754;
                    bool _out755;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out756;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out753, out _out754, out _out755, out _out756);
                    _1299_recursiveGen = _out753;
                    _1300_recOwned = _out754;
                    _1301_recErased = _out755;
                    _1302_recIdents = _out756;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1299_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1300_recOwned;
                    isErased = _1301_recErased;
                    readIdents = _1302_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1303___mcc_h712 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1304_recursiveGen;
                    bool _1305_recOwned;
                    bool _1306_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1307_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out757;
                    bool _out758;
                    bool _out759;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out760;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out757, out _out758, out _out759, out _out760);
                    _1304_recursiveGen = _out757;
                    _1305_recOwned = _out758;
                    _1306_recErased = _out759;
                    _1307_recIdents = _out760;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1304_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1305_recOwned;
                    isErased = _1306_recErased;
                    readIdents = _1307_recIdents;
                  }
                } else {
                  DAST._IType _1308___mcc_h714 = _source49.dtor_Newtype_a0;
                  DAST._IType _1309_b = _1308___mcc_h714;
                  {
                    if (object.Equals(_550_fromTpe, _1309_b)) {
                      Dafny.ISequence<Dafny.Rune> _1310_recursiveGen;
                      bool _1311_recOwned;
                      bool _1312_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1313_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out761;
                      bool _out762;
                      bool _out763;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out764;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out761, out _out762, out _out763, out _out764);
                      _1310_recursiveGen = _out761;
                      _1311_recOwned = _out762;
                      _1312_recErased = _out763;
                      _1313_recIdents = _out764;
                      Dafny.ISequence<Dafny.Rune> _1314_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out765;
                      _out765 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1314_rhsType = _out765;
                      Dafny.ISequence<Dafny.Rune> _1315_uneraseFn;
                      _1315_uneraseFn = ((_1311_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1314_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1315_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1310_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1311_recOwned;
                      isErased = false;
                      readIdents = _1313_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out766;
                      bool _out767;
                      bool _out768;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1309_b), _1309_b, _549_toTpe), selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                      s = _out766;
                      isOwned = _out767;
                      isErased = _out768;
                      readIdents = _out769;
                    }
                  }
                }
              } else if (_source48.is_Nullable) {
                DAST._IType _1316___mcc_h716 = _source48.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1317_recursiveGen;
                  bool _1318_recOwned;
                  bool _1319_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1320_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1317_recursiveGen = _out770;
                  _1318_recOwned = _out771;
                  _1319_recErased = _out772;
                  _1320_recIdents = _out773;
                  if (!(_1318_recOwned)) {
                    _1317_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1317_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1317_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1319_recErased;
                  readIdents = _1320_recIdents;
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1321___mcc_h718 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1322_recursiveGen;
                  bool _1323_recOwned;
                  bool _1324_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1325_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1322_recursiveGen = _out774;
                  _1323_recOwned = _out775;
                  _1324_recErased = _out776;
                  _1325_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1322_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1323_recOwned;
                  isErased = _1324_recErased;
                  readIdents = _1325_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1326___mcc_h720 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                  bool _1328_recOwned;
                  bool _1329_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1327_recursiveGen = _out778;
                  _1328_recOwned = _out779;
                  _1329_recErased = _out780;
                  _1330_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1328_recOwned;
                  isErased = _1329_recErased;
                  readIdents = _1330_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1331___mcc_h722 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1332_recursiveGen;
                  bool _1333_recOwned;
                  bool _1334_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1335_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1332_recursiveGen = _out782;
                  _1333_recOwned = _out783;
                  _1334_recErased = _out784;
                  _1335_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1332_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1333_recOwned;
                  isErased = _1334_recErased;
                  readIdents = _1335_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1336___mcc_h724 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1337_recursiveGen;
                  bool _1338_recOwned;
                  bool _1339_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1340_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1337_recursiveGen = _out786;
                  _1338_recOwned = _out787;
                  _1339_recErased = _out788;
                  _1340_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1337_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1338_recOwned;
                  isErased = _1339_recErased;
                  readIdents = _1340_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1341___mcc_h726 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1342_recursiveGen;
                  bool _1343_recOwned;
                  bool _1344_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1345_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1342_recursiveGen = _out790;
                  _1343_recOwned = _out791;
                  _1344_recErased = _out792;
                  _1345_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1342_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1343_recOwned;
                  isErased = _1344_recErased;
                  readIdents = _1345_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1346___mcc_h728 = _source48.dtor_key;
                DAST._IType _1347___mcc_h729 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1348_recursiveGen;
                  bool _1349_recOwned;
                  bool _1350_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1351_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1348_recursiveGen = _out794;
                  _1349_recOwned = _out795;
                  _1350_recErased = _out796;
                  _1351_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1348_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1349_recOwned;
                  isErased = _1350_recErased;
                  readIdents = _1351_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1352___mcc_h732 = _source48.dtor_args;
                DAST._IType _1353___mcc_h733 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1354_recursiveGen;
                  bool _1355_recOwned;
                  bool _1356_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1357_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out798;
                  bool _out799;
                  bool _out800;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                  _1354_recursiveGen = _out798;
                  _1355_recOwned = _out799;
                  _1356_recErased = _out800;
                  _1357_recIdents = _out801;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1354_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1355_recOwned;
                  isErased = _1356_recErased;
                  readIdents = _1357_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1358___mcc_h736 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1359_recursiveGen;
                  bool _1360_recOwned;
                  bool _1361_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1362_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out802;
                  bool _out803;
                  bool _out804;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                  _1359_recursiveGen = _out802;
                  _1360_recOwned = _out803;
                  _1361_recErased = _out804;
                  _1362_recIdents = _out805;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1359_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1360_recOwned;
                  isErased = _1361_recErased;
                  readIdents = _1362_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1363___mcc_h738 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1364_recursiveGen;
                  bool _1365_recOwned;
                  bool _1366_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1367_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out806;
                  bool _out807;
                  bool _out808;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                  _1364_recursiveGen = _out806;
                  _1365_recOwned = _out807;
                  _1366_recErased = _out808;
                  _1367_recIdents = _out809;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1364_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1365_recOwned;
                  isErased = _1366_recErased;
                  readIdents = _1367_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1368___mcc_h740 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1369_recursiveGen;
                  bool _1370_recOwned;
                  bool _1371_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1372_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out810;
                  bool _out811;
                  bool _out812;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out813;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out810, out _out811, out _out812, out _out813);
                  _1369_recursiveGen = _out810;
                  _1370_recOwned = _out811;
                  _1371_recErased = _out812;
                  _1372_recIdents = _out813;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1369_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1370_recOwned;
                  isErased = _1371_recErased;
                  readIdents = _1372_recIdents;
                }
              }
            } else if (_source28.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1373___mcc_h742 = _source28.dtor_args;
              DAST._IType _1374___mcc_h743 = _source28.dtor_result;
              DAST._IType _source50 = _557___mcc_h265;
              if (_source50.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1375___mcc_h750 = _source50.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1376___mcc_h751 = _source50.dtor_typeArgs;
                DAST._IResolvedType _1377___mcc_h752 = _source50.dtor_resolved;
                DAST._IResolvedType _source51 = _1377___mcc_h752;
                if (_source51.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1378___mcc_h756 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1379_recursiveGen;
                    bool _1380_recOwned;
                    bool _1381_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1382_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out814;
                    bool _out815;
                    bool _out816;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out817;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out814, out _out815, out _out816, out _out817);
                    _1379_recursiveGen = _out814;
                    _1380_recOwned = _out815;
                    _1381_recErased = _out816;
                    _1382_recIdents = _out817;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1380_recOwned;
                    isErased = _1381_recErased;
                    readIdents = _1382_recIdents;
                  }
                } else if (_source51.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1383___mcc_h758 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1384_recursiveGen;
                    bool _1385_recOwned;
                    bool _1386_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1387_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out818;
                    bool _out819;
                    bool _out820;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out821;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out818, out _out819, out _out820, out _out821);
                    _1384_recursiveGen = _out818;
                    _1385_recOwned = _out819;
                    _1386_recErased = _out820;
                    _1387_recIdents = _out821;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1384_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1385_recOwned;
                    isErased = _1386_recErased;
                    readIdents = _1387_recIdents;
                  }
                } else {
                  DAST._IType _1388___mcc_h760 = _source51.dtor_Newtype_a0;
                  DAST._IType _1389_b = _1388___mcc_h760;
                  {
                    if (object.Equals(_550_fromTpe, _1389_b)) {
                      Dafny.ISequence<Dafny.Rune> _1390_recursiveGen;
                      bool _1391_recOwned;
                      bool _1392_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1393_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out822;
                      bool _out823;
                      bool _out824;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out825;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out822, out _out823, out _out824, out _out825);
                      _1390_recursiveGen = _out822;
                      _1391_recOwned = _out823;
                      _1392_recErased = _out824;
                      _1393_recIdents = _out825;
                      Dafny.ISequence<Dafny.Rune> _1394_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out826;
                      _out826 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1394_rhsType = _out826;
                      Dafny.ISequence<Dafny.Rune> _1395_uneraseFn;
                      _1395_uneraseFn = ((_1391_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1394_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1395_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1390_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1391_recOwned;
                      isErased = false;
                      readIdents = _1393_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out827;
                      bool _out828;
                      bool _out829;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1389_b), _1389_b, _549_toTpe), selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                      s = _out827;
                      isOwned = _out828;
                      isErased = _out829;
                      readIdents = _out830;
                    }
                  }
                }
              } else if (_source50.is_Nullable) {
                DAST._IType _1396___mcc_h762 = _source50.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1397_recursiveGen;
                  bool _1398_recOwned;
                  bool _1399_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1400_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1397_recursiveGen = _out831;
                  _1398_recOwned = _out832;
                  _1399_recErased = _out833;
                  _1400_recIdents = _out834;
                  if (!(_1398_recOwned)) {
                    _1397_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1397_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1397_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1399_recErased;
                  readIdents = _1400_recIdents;
                }
              } else if (_source50.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1401___mcc_h764 = _source50.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1402_recursiveGen;
                  bool _1403_recOwned;
                  bool _1404_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1405_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1402_recursiveGen = _out835;
                  _1403_recOwned = _out836;
                  _1404_recErased = _out837;
                  _1405_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1402_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1403_recOwned;
                  isErased = _1404_recErased;
                  readIdents = _1405_recIdents;
                }
              } else if (_source50.is_Array) {
                DAST._IType _1406___mcc_h766 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1407_recursiveGen;
                  bool _1408_recOwned;
                  bool _1409_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1410_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1407_recursiveGen = _out839;
                  _1408_recOwned = _out840;
                  _1409_recErased = _out841;
                  _1410_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1407_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1408_recOwned;
                  isErased = _1409_recErased;
                  readIdents = _1410_recIdents;
                }
              } else if (_source50.is_Seq) {
                DAST._IType _1411___mcc_h768 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1412_recursiveGen;
                  bool _1413_recOwned;
                  bool _1414_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1415_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1412_recursiveGen = _out843;
                  _1413_recOwned = _out844;
                  _1414_recErased = _out845;
                  _1415_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1412_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1413_recOwned;
                  isErased = _1414_recErased;
                  readIdents = _1415_recIdents;
                }
              } else if (_source50.is_Set) {
                DAST._IType _1416___mcc_h770 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1417_recursiveGen;
                  bool _1418_recOwned;
                  bool _1419_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1420_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1417_recursiveGen = _out847;
                  _1418_recOwned = _out848;
                  _1419_recErased = _out849;
                  _1420_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1417_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1418_recOwned;
                  isErased = _1419_recErased;
                  readIdents = _1420_recIdents;
                }
              } else if (_source50.is_Multiset) {
                DAST._IType _1421___mcc_h772 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1422_recursiveGen;
                  bool _1423_recOwned;
                  bool _1424_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1425_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1422_recursiveGen = _out851;
                  _1423_recOwned = _out852;
                  _1424_recErased = _out853;
                  _1425_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1422_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1423_recOwned;
                  isErased = _1424_recErased;
                  readIdents = _1425_recIdents;
                }
              } else if (_source50.is_Map) {
                DAST._IType _1426___mcc_h774 = _source50.dtor_key;
                DAST._IType _1427___mcc_h775 = _source50.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1428_recursiveGen;
                  bool _1429_recOwned;
                  bool _1430_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1431_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1428_recursiveGen = _out855;
                  _1429_recOwned = _out856;
                  _1430_recErased = _out857;
                  _1431_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1428_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1429_recOwned;
                  isErased = _1430_recErased;
                  readIdents = _1431_recIdents;
                }
              } else if (_source50.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1432___mcc_h778 = _source50.dtor_args;
                DAST._IType _1433___mcc_h779 = _source50.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1434_recursiveGen;
                  bool _1435_recOwned;
                  bool _1436_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1437_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out859;
                  bool _out860;
                  bool _out861;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                  _1434_recursiveGen = _out859;
                  _1435_recOwned = _out860;
                  _1436_recErased = _out861;
                  _1437_recIdents = _out862;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1434_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1435_recOwned;
                  isErased = _1436_recErased;
                  readIdents = _1437_recIdents;
                }
              } else if (_source50.is_Primitive) {
                DAST._IPrimitive _1438___mcc_h782 = _source50.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1439_recursiveGen;
                  bool _1440_recOwned;
                  bool _1441_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1442_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out863;
                  bool _out864;
                  bool _out865;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                  _1439_recursiveGen = _out863;
                  _1440_recOwned = _out864;
                  _1441_recErased = _out865;
                  _1442_recIdents = _out866;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1439_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1440_recOwned;
                  isErased = _1441_recErased;
                  readIdents = _1442_recIdents;
                }
              } else if (_source50.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1443___mcc_h784 = _source50.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1444_recursiveGen;
                  bool _1445_recOwned;
                  bool _1446_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1447_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out867;
                  bool _out868;
                  bool _out869;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                  _1444_recursiveGen = _out867;
                  _1445_recOwned = _out868;
                  _1446_recErased = _out869;
                  _1447_recIdents = _out870;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1444_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1445_recOwned;
                  isErased = _1446_recErased;
                  readIdents = _1447_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1448___mcc_h786 = _source50.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1449_recursiveGen;
                  bool _1450_recOwned;
                  bool _1451_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1452_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out871;
                  bool _out872;
                  bool _out873;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out874;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out871, out _out872, out _out873, out _out874);
                  _1449_recursiveGen = _out871;
                  _1450_recOwned = _out872;
                  _1451_recErased = _out873;
                  _1452_recIdents = _out874;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1449_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1450_recOwned;
                  isErased = _1451_recErased;
                  readIdents = _1452_recIdents;
                }
              }
            } else if (_source28.is_Primitive) {
              DAST._IPrimitive _1453___mcc_h788 = _source28.dtor_Primitive_a0;
              DAST._IPrimitive _source52 = _1453___mcc_h788;
              if (_source52.is_Int) {
                DAST._IType _source53 = _557___mcc_h265;
                if (_source53.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1454___mcc_h792 = _source53.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1455___mcc_h793 = _source53.dtor_typeArgs;
                  DAST._IResolvedType _1456___mcc_h794 = _source53.dtor_resolved;
                  DAST._IResolvedType _source54 = _1456___mcc_h794;
                  if (_source54.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1457___mcc_h798 = _source54.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1458_recursiveGen;
                      bool _1459_recOwned;
                      bool _1460_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1461_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out875;
                      bool _out876;
                      bool _out877;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out878;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out875, out _out876, out _out877, out _out878);
                      _1458_recursiveGen = _out875;
                      _1459_recOwned = _out876;
                      _1460_recErased = _out877;
                      _1461_recIdents = _out878;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1458_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1459_recOwned;
                      isErased = _1460_recErased;
                      readIdents = _1461_recIdents;
                    }
                  } else if (_source54.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1462___mcc_h800 = _source54.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1463_recursiveGen;
                      bool _1464_recOwned;
                      bool _1465_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1466_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out879;
                      bool _out880;
                      bool _out881;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out882;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out879, out _out880, out _out881, out _out882);
                      _1463_recursiveGen = _out879;
                      _1464_recOwned = _out880;
                      _1465_recErased = _out881;
                      _1466_recIdents = _out882;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1464_recOwned;
                      isErased = _1465_recErased;
                      readIdents = _1466_recIdents;
                    }
                  } else {
                    DAST._IType _1467___mcc_h802 = _source54.dtor_Newtype_a0;
                    DAST._IType _1468_b = _1467___mcc_h802;
                    {
                      if (object.Equals(_550_fromTpe, _1468_b)) {
                        Dafny.ISequence<Dafny.Rune> _1469_recursiveGen;
                        bool _1470_recOwned;
                        bool _1471_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1472_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out883;
                        bool _out884;
                        bool _out885;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out886;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out883, out _out884, out _out885, out _out886);
                        _1469_recursiveGen = _out883;
                        _1470_recOwned = _out884;
                        _1471_recErased = _out885;
                        _1472_recIdents = _out886;
                        Dafny.ISequence<Dafny.Rune> _1473_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out887;
                        _out887 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _1473_rhsType = _out887;
                        Dafny.ISequence<Dafny.Rune> _1474_uneraseFn;
                        _1474_uneraseFn = ((_1470_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1473_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1474_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1469_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1470_recOwned;
                        isErased = false;
                        readIdents = _1472_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out888;
                        bool _out889;
                        bool _out890;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1468_b), _1468_b, _549_toTpe), selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                        s = _out888;
                        isOwned = _out889;
                        isErased = _out890;
                        readIdents = _out891;
                      }
                    }
                  }
                } else if (_source53.is_Nullable) {
                  DAST._IType _1475___mcc_h804 = _source53.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1476_recursiveGen;
                    bool _1477_recOwned;
                    bool _1478_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1479_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1476_recursiveGen = _out892;
                    _1477_recOwned = _out893;
                    _1478_recErased = _out894;
                    _1479_recIdents = _out895;
                    if (!(_1477_recOwned)) {
                      _1476_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1476_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1476_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1478_recErased;
                    readIdents = _1479_recIdents;
                  }
                } else if (_source53.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1480___mcc_h806 = _source53.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1481_recursiveGen;
                    bool _1482_recOwned;
                    bool _1483_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1484_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1481_recursiveGen = _out896;
                    _1482_recOwned = _out897;
                    _1483_recErased = _out898;
                    _1484_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1481_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1482_recOwned;
                    isErased = _1483_recErased;
                    readIdents = _1484_recIdents;
                  }
                } else if (_source53.is_Array) {
                  DAST._IType _1485___mcc_h808 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1486_recursiveGen;
                    bool _1487_recOwned;
                    bool _1488_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1489_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1486_recursiveGen = _out900;
                    _1487_recOwned = _out901;
                    _1488_recErased = _out902;
                    _1489_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1487_recOwned;
                    isErased = _1488_recErased;
                    readIdents = _1489_recIdents;
                  }
                } else if (_source53.is_Seq) {
                  DAST._IType _1490___mcc_h810 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1491_recursiveGen;
                    bool _1492_recOwned;
                    bool _1493_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1494_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1491_recursiveGen = _out904;
                    _1492_recOwned = _out905;
                    _1493_recErased = _out906;
                    _1494_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1491_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1492_recOwned;
                    isErased = _1493_recErased;
                    readIdents = _1494_recIdents;
                  }
                } else if (_source53.is_Set) {
                  DAST._IType _1495___mcc_h812 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1496_recursiveGen;
                    bool _1497_recOwned;
                    bool _1498_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1499_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1496_recursiveGen = _out908;
                    _1497_recOwned = _out909;
                    _1498_recErased = _out910;
                    _1499_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1496_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1497_recOwned;
                    isErased = _1498_recErased;
                    readIdents = _1499_recIdents;
                  }
                } else if (_source53.is_Multiset) {
                  DAST._IType _1500___mcc_h814 = _source53.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1501_recursiveGen;
                    bool _1502_recOwned;
                    bool _1503_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1504_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1501_recursiveGen = _out912;
                    _1502_recOwned = _out913;
                    _1503_recErased = _out914;
                    _1504_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1501_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1502_recOwned;
                    isErased = _1503_recErased;
                    readIdents = _1504_recIdents;
                  }
                } else if (_source53.is_Map) {
                  DAST._IType _1505___mcc_h816 = _source53.dtor_key;
                  DAST._IType _1506___mcc_h817 = _source53.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1507_recursiveGen;
                    bool _1508_recOwned;
                    bool _1509_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1510_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out916;
                    bool _out917;
                    bool _out918;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                    _1507_recursiveGen = _out916;
                    _1508_recOwned = _out917;
                    _1509_recErased = _out918;
                    _1510_recIdents = _out919;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1508_recOwned;
                    isErased = _1509_recErased;
                    readIdents = _1510_recIdents;
                  }
                } else if (_source53.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1511___mcc_h820 = _source53.dtor_args;
                  DAST._IType _1512___mcc_h821 = _source53.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1513_recursiveGen;
                    bool _1514_recOwned;
                    bool _1515_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1516_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out920;
                    bool _out921;
                    bool _out922;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out920, out _out921, out _out922, out _out923);
                    _1513_recursiveGen = _out920;
                    _1514_recOwned = _out921;
                    _1515_recErased = _out922;
                    _1516_recIdents = _out923;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1513_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1514_recOwned;
                    isErased = _1515_recErased;
                    readIdents = _1516_recIdents;
                  }
                } else if (_source53.is_Primitive) {
                  DAST._IPrimitive _1517___mcc_h824 = _source53.dtor_Primitive_a0;
                  DAST._IPrimitive _source55 = _1517___mcc_h824;
                  if (_source55.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1518_recursiveGen;
                      bool _1519_recOwned;
                      bool _1520_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1521_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      bool _out925;
                      bool _out926;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                      _1518_recursiveGen = _out924;
                      _1519_recOwned = _out925;
                      _1520_recErased = _out926;
                      _1521_recIdents = _out927;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1518_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1519_recOwned;
                      isErased = _1520_recErased;
                      readIdents = _1521_recIdents;
                    }
                  } else if (_source55.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1522_recursiveGen;
                      bool _1523___v48;
                      bool _1524___v49;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1525_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out928;
                      bool _out929;
                      bool _out930;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, true, out _out928, out _out929, out _out930, out _out931);
                      _1522_recursiveGen = _out928;
                      _1523___v48 = _out929;
                      _1524___v49 = _out930;
                      _1525_recIdents = _out931;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1525_recIdents;
                    }
                  } else if (_source55.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1526_recursiveGen;
                      bool _1527_recOwned;
                      bool _1528_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1529_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out932;
                      bool _out933;
                      bool _out934;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out935;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out932, out _out933, out _out934, out _out935);
                      _1526_recursiveGen = _out932;
                      _1527_recOwned = _out933;
                      _1528_recErased = _out934;
                      _1529_recIdents = _out935;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1526_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1527_recOwned;
                      isErased = _1528_recErased;
                      readIdents = _1529_recIdents;
                    }
                  } else if (_source55.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1530_recursiveGen;
                      bool _1531_recOwned;
                      bool _1532_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1533_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out936;
                      bool _out937;
                      bool _out938;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out939;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out936, out _out937, out _out938, out _out939);
                      _1530_recursiveGen = _out936;
                      _1531_recOwned = _out937;
                      _1532_recErased = _out938;
                      _1533_recIdents = _out939;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1530_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1531_recOwned;
                      isErased = _1532_recErased;
                      readIdents = _1533_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1534_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out940;
                      _out940 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1534_rhsType = _out940;
                      Dafny.ISequence<Dafny.Rune> _1535_recursiveGen;
                      bool _1536___v58;
                      bool _1537___v59;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1538_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out941;
                      bool _out942;
                      bool _out943;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out944;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, true, out _out941, out _out942, out _out943, out _out944);
                      _1535_recursiveGen = _out941;
                      _1536___v58 = _out942;
                      _1537___v59 = _out943;
                      _1538_recIdents = _out944;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1535_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1538_recIdents;
                    }
                  }
                } else if (_source53.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1539___mcc_h826 = _source53.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1540_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out945;
                    _out945 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                    _1540_rhsType = _out945;
                    Dafny.ISequence<Dafny.Rune> _1541_recursiveGen;
                    bool _1542___v53;
                    bool _1543___v54;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1544_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out946;
                    bool _out947;
                    bool _out948;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, true, out _out946, out _out947, out _out948, out _out949);
                    _1541_recursiveGen = _out946;
                    _1542___v53 = _out947;
                    _1543___v54 = _out948;
                    _1544_recIdents = _out949;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1540_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1544_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1545___mcc_h828 = _source53.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1546_recursiveGen;
                    bool _1547_recOwned;
                    bool _1548_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1549_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out950;
                    bool _out951;
                    bool _out952;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out953;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out950, out _out951, out _out952, out _out953);
                    _1546_recursiveGen = _out950;
                    _1547_recOwned = _out951;
                    _1548_recErased = _out952;
                    _1549_recIdents = _out953;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1547_recOwned;
                    isErased = _1548_recErased;
                    readIdents = _1549_recIdents;
                  }
                }
              } else if (_source52.is_Real) {
                DAST._IType _source56 = _557___mcc_h265;
                if (_source56.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1550___mcc_h830 = _source56.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1551___mcc_h831 = _source56.dtor_typeArgs;
                  DAST._IResolvedType _1552___mcc_h832 = _source56.dtor_resolved;
                  DAST._IResolvedType _source57 = _1552___mcc_h832;
                  if (_source57.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1553___mcc_h836 = _source57.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1554_recursiveGen;
                      bool _1555_recOwned;
                      bool _1556_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1557_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out954;
                      bool _out955;
                      bool _out956;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out957;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out954, out _out955, out _out956, out _out957);
                      _1554_recursiveGen = _out954;
                      _1555_recOwned = _out955;
                      _1556_recErased = _out956;
                      _1557_recIdents = _out957;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1555_recOwned;
                      isErased = _1556_recErased;
                      readIdents = _1557_recIdents;
                    }
                  } else if (_source57.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1558___mcc_h838 = _source57.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1559_recursiveGen;
                      bool _1560_recOwned;
                      bool _1561_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1562_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out958;
                      bool _out959;
                      bool _out960;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out961;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out958, out _out959, out _out960, out _out961);
                      _1559_recursiveGen = _out958;
                      _1560_recOwned = _out959;
                      _1561_recErased = _out960;
                      _1562_recIdents = _out961;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1559_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1560_recOwned;
                      isErased = _1561_recErased;
                      readIdents = _1562_recIdents;
                    }
                  } else {
                    DAST._IType _1563___mcc_h840 = _source57.dtor_Newtype_a0;
                    DAST._IType _1564_b = _1563___mcc_h840;
                    {
                      if (object.Equals(_550_fromTpe, _1564_b)) {
                        Dafny.ISequence<Dafny.Rune> _1565_recursiveGen;
                        bool _1566_recOwned;
                        bool _1567_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1568_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out962;
                        bool _out963;
                        bool _out964;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out965;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out962, out _out963, out _out964, out _out965);
                        _1565_recursiveGen = _out962;
                        _1566_recOwned = _out963;
                        _1567_recErased = _out964;
                        _1568_recIdents = _out965;
                        Dafny.ISequence<Dafny.Rune> _1569_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out966;
                        _out966 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _1569_rhsType = _out966;
                        Dafny.ISequence<Dafny.Rune> _1570_uneraseFn;
                        _1570_uneraseFn = ((_1566_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1569_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1570_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1565_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1566_recOwned;
                        isErased = false;
                        readIdents = _1568_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out967;
                        bool _out968;
                        bool _out969;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1564_b), _1564_b, _549_toTpe), selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                        s = _out967;
                        isOwned = _out968;
                        isErased = _out969;
                        readIdents = _out970;
                      }
                    }
                  }
                } else if (_source56.is_Nullable) {
                  DAST._IType _1571___mcc_h842 = _source56.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1572_recursiveGen;
                    bool _1573_recOwned;
                    bool _1574_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1575_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1572_recursiveGen = _out971;
                    _1573_recOwned = _out972;
                    _1574_recErased = _out973;
                    _1575_recIdents = _out974;
                    if (!(_1573_recOwned)) {
                      _1572_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1572_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1574_recErased;
                    readIdents = _1575_recIdents;
                  }
                } else if (_source56.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1576___mcc_h844 = _source56.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1577_recursiveGen;
                    bool _1578_recOwned;
                    bool _1579_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1580_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1577_recursiveGen = _out975;
                    _1578_recOwned = _out976;
                    _1579_recErased = _out977;
                    _1580_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1577_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1578_recOwned;
                    isErased = _1579_recErased;
                    readIdents = _1580_recIdents;
                  }
                } else if (_source56.is_Array) {
                  DAST._IType _1581___mcc_h846 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1582_recursiveGen;
                    bool _1583_recOwned;
                    bool _1584_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1585_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1582_recursiveGen = _out979;
                    _1583_recOwned = _out980;
                    _1584_recErased = _out981;
                    _1585_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1582_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1583_recOwned;
                    isErased = _1584_recErased;
                    readIdents = _1585_recIdents;
                  }
                } else if (_source56.is_Seq) {
                  DAST._IType _1586___mcc_h848 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1587_recursiveGen;
                    bool _1588_recOwned;
                    bool _1589_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1590_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1587_recursiveGen = _out983;
                    _1588_recOwned = _out984;
                    _1589_recErased = _out985;
                    _1590_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1587_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1588_recOwned;
                    isErased = _1589_recErased;
                    readIdents = _1590_recIdents;
                  }
                } else if (_source56.is_Set) {
                  DAST._IType _1591___mcc_h850 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1592_recursiveGen;
                    bool _1593_recOwned;
                    bool _1594_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1595_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out987;
                    bool _out988;
                    bool _out989;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out987, out _out988, out _out989, out _out990);
                    _1592_recursiveGen = _out987;
                    _1593_recOwned = _out988;
                    _1594_recErased = _out989;
                    _1595_recIdents = _out990;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1592_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1593_recOwned;
                    isErased = _1594_recErased;
                    readIdents = _1595_recIdents;
                  }
                } else if (_source56.is_Multiset) {
                  DAST._IType _1596___mcc_h852 = _source56.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1597_recursiveGen;
                    bool _1598_recOwned;
                    bool _1599_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1600_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out991;
                    bool _out992;
                    bool _out993;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                    _1597_recursiveGen = _out991;
                    _1598_recOwned = _out992;
                    _1599_recErased = _out993;
                    _1600_recIdents = _out994;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1597_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1598_recOwned;
                    isErased = _1599_recErased;
                    readIdents = _1600_recIdents;
                  }
                } else if (_source56.is_Map) {
                  DAST._IType _1601___mcc_h854 = _source56.dtor_key;
                  DAST._IType _1602___mcc_h855 = _source56.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1603_recursiveGen;
                    bool _1604_recOwned;
                    bool _1605_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1606_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out995;
                    bool _out996;
                    bool _out997;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out995, out _out996, out _out997, out _out998);
                    _1603_recursiveGen = _out995;
                    _1604_recOwned = _out996;
                    _1605_recErased = _out997;
                    _1606_recIdents = _out998;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1603_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1604_recOwned;
                    isErased = _1605_recErased;
                    readIdents = _1606_recIdents;
                  }
                } else if (_source56.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1607___mcc_h858 = _source56.dtor_args;
                  DAST._IType _1608___mcc_h859 = _source56.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                    bool _1610_recOwned;
                    bool _1611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out999;
                    bool _out1000;
                    bool _out1001;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                    _1609_recursiveGen = _out999;
                    _1610_recOwned = _out1000;
                    _1611_recErased = _out1001;
                    _1612_recIdents = _out1002;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1610_recOwned;
                    isErased = _1611_recErased;
                    readIdents = _1612_recIdents;
                  }
                } else if (_source56.is_Primitive) {
                  DAST._IPrimitive _1613___mcc_h862 = _source56.dtor_Primitive_a0;
                  DAST._IPrimitive _source58 = _1613___mcc_h862;
                  if (_source58.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1614_recursiveGen;
                      bool _1615___v50;
                      bool _1616___v51;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, false, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1614_recursiveGen = _out1003;
                      _1615___v50 = _out1004;
                      _1616___v51 = _out1005;
                      _1617_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1617_recIdents;
                    }
                  } else if (_source58.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1618_recursiveGen;
                      bool _1619_recOwned;
                      bool _1620_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1621_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1007;
                      bool _out1008;
                      bool _out1009;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                      _1618_recursiveGen = _out1007;
                      _1619_recOwned = _out1008;
                      _1620_recErased = _out1009;
                      _1621_recIdents = _out1010;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1619_recOwned;
                      isErased = _1620_recErased;
                      readIdents = _1621_recIdents;
                    }
                  } else if (_source58.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1622_recursiveGen;
                      bool _1623_recOwned;
                      bool _1624_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1625_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1011;
                      bool _out1012;
                      bool _out1013;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                      _1622_recursiveGen = _out1011;
                      _1623_recOwned = _out1012;
                      _1624_recErased = _out1013;
                      _1625_recIdents = _out1014;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1622_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1623_recOwned;
                      isErased = _1624_recErased;
                      readIdents = _1625_recIdents;
                    }
                  } else if (_source58.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1626_recursiveGen;
                      bool _1627_recOwned;
                      bool _1628_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1629_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1015;
                      bool _out1016;
                      bool _out1017;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                      _1626_recursiveGen = _out1015;
                      _1627_recOwned = _out1016;
                      _1628_recErased = _out1017;
                      _1629_recIdents = _out1018;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1627_recOwned;
                      isErased = _1628_recErased;
                      readIdents = _1629_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1630_recursiveGen;
                      bool _1631_recOwned;
                      bool _1632_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1633_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1019;
                      bool _out1020;
                      bool _out1021;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                      _1630_recursiveGen = _out1019;
                      _1631_recOwned = _out1020;
                      _1632_recErased = _out1021;
                      _1633_recIdents = _out1022;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1630_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1631_recOwned;
                      isErased = _1632_recErased;
                      readIdents = _1633_recIdents;
                    }
                  }
                } else if (_source56.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1634___mcc_h864 = _source56.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1635_recursiveGen;
                    bool _1636_recOwned;
                    bool _1637_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1638_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1023;
                    bool _out1024;
                    bool _out1025;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                    _1635_recursiveGen = _out1023;
                    _1636_recOwned = _out1024;
                    _1637_recErased = _out1025;
                    _1638_recIdents = _out1026;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1635_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1636_recOwned;
                    isErased = _1637_recErased;
                    readIdents = _1638_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1639___mcc_h866 = _source56.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1640_recursiveGen;
                    bool _1641_recOwned;
                    bool _1642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1027;
                    bool _out1028;
                    bool _out1029;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1030;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1027, out _out1028, out _out1029, out _out1030);
                    _1640_recursiveGen = _out1027;
                    _1641_recOwned = _out1028;
                    _1642_recErased = _out1029;
                    _1643_recIdents = _out1030;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1641_recOwned;
                    isErased = _1642_recErased;
                    readIdents = _1643_recIdents;
                  }
                }
              } else if (_source52.is_String) {
                DAST._IType _source59 = _557___mcc_h265;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1644___mcc_h868 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1645___mcc_h869 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1646___mcc_h870 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1646___mcc_h870;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1647___mcc_h874 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1648_recursiveGen;
                      bool _1649_recOwned;
                      bool _1650_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1651_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1031;
                      bool _out1032;
                      bool _out1033;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1031, out _out1032, out _out1033, out _out1034);
                      _1648_recursiveGen = _out1031;
                      _1649_recOwned = _out1032;
                      _1650_recErased = _out1033;
                      _1651_recIdents = _out1034;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1648_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1649_recOwned;
                      isErased = _1650_recErased;
                      readIdents = _1651_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1652___mcc_h876 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1653_recursiveGen;
                      bool _1654_recOwned;
                      bool _1655_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1656_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1035;
                      bool _out1036;
                      bool _out1037;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1038;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1035, out _out1036, out _out1037, out _out1038);
                      _1653_recursiveGen = _out1035;
                      _1654_recOwned = _out1036;
                      _1655_recErased = _out1037;
                      _1656_recIdents = _out1038;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1654_recOwned;
                      isErased = _1655_recErased;
                      readIdents = _1656_recIdents;
                    }
                  } else {
                    DAST._IType _1657___mcc_h878 = _source60.dtor_Newtype_a0;
                    DAST._IType _1658_b = _1657___mcc_h878;
                    {
                      if (object.Equals(_550_fromTpe, _1658_b)) {
                        Dafny.ISequence<Dafny.Rune> _1659_recursiveGen;
                        bool _1660_recOwned;
                        bool _1661_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1662_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1039;
                        bool _out1040;
                        bool _out1041;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1042;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1039, out _out1040, out _out1041, out _out1042);
                        _1659_recursiveGen = _out1039;
                        _1660_recOwned = _out1040;
                        _1661_recErased = _out1041;
                        _1662_recIdents = _out1042;
                        Dafny.ISequence<Dafny.Rune> _1663_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1043;
                        _out1043 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _1663_rhsType = _out1043;
                        Dafny.ISequence<Dafny.Rune> _1664_uneraseFn;
                        _1664_uneraseFn = ((_1660_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1663_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1664_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1659_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1660_recOwned;
                        isErased = false;
                        readIdents = _1662_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1044;
                        bool _out1045;
                        bool _out1046;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1658_b), _1658_b, _549_toTpe), selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                        s = _out1044;
                        isOwned = _out1045;
                        isErased = _out1046;
                        readIdents = _out1047;
                      }
                    }
                  }
                } else if (_source59.is_Nullable) {
                  DAST._IType _1665___mcc_h880 = _source59.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1666_recursiveGen;
                    bool _1667_recOwned;
                    bool _1668_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1669_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1666_recursiveGen = _out1048;
                    _1667_recOwned = _out1049;
                    _1668_recErased = _out1050;
                    _1669_recIdents = _out1051;
                    if (!(_1667_recOwned)) {
                      _1666_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1666_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1666_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1668_recErased;
                    readIdents = _1669_recIdents;
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1670___mcc_h882 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1671_recursiveGen;
                    bool _1672_recOwned;
                    bool _1673_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1674_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1671_recursiveGen = _out1052;
                    _1672_recOwned = _out1053;
                    _1673_recErased = _out1054;
                    _1674_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1671_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1672_recOwned;
                    isErased = _1673_recErased;
                    readIdents = _1674_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1675___mcc_h884 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1676_recursiveGen;
                    bool _1677_recOwned;
                    bool _1678_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1679_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1676_recursiveGen = _out1056;
                    _1677_recOwned = _out1057;
                    _1678_recErased = _out1058;
                    _1679_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1676_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1677_recOwned;
                    isErased = _1678_recErased;
                    readIdents = _1679_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1680___mcc_h886 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1681_recursiveGen;
                    bool _1682_recOwned;
                    bool _1683_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1684_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1681_recursiveGen = _out1060;
                    _1682_recOwned = _out1061;
                    _1683_recErased = _out1062;
                    _1684_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1681_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1682_recOwned;
                    isErased = _1683_recErased;
                    readIdents = _1684_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1685___mcc_h888 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1686_recursiveGen;
                    bool _1687_recOwned;
                    bool _1688_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1689_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1686_recursiveGen = _out1064;
                    _1687_recOwned = _out1065;
                    _1688_recErased = _out1066;
                    _1689_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1686_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1687_recOwned;
                    isErased = _1688_recErased;
                    readIdents = _1689_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1690___mcc_h890 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1691_recursiveGen;
                    bool _1692_recOwned;
                    bool _1693_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1694_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1691_recursiveGen = _out1068;
                    _1692_recOwned = _out1069;
                    _1693_recErased = _out1070;
                    _1694_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1691_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1692_recOwned;
                    isErased = _1693_recErased;
                    readIdents = _1694_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1695___mcc_h892 = _source59.dtor_key;
                  DAST._IType _1696___mcc_h893 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1697_recursiveGen;
                    bool _1698_recOwned;
                    bool _1699_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1700_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1697_recursiveGen = _out1072;
                    _1698_recOwned = _out1073;
                    _1699_recErased = _out1074;
                    _1700_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1697_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1698_recOwned;
                    isErased = _1699_recErased;
                    readIdents = _1700_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1701___mcc_h896 = _source59.dtor_args;
                  DAST._IType _1702___mcc_h897 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1703_recursiveGen;
                    bool _1704_recOwned;
                    bool _1705_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1706_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1076;
                    bool _out1077;
                    bool _out1078;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                    _1703_recursiveGen = _out1076;
                    _1704_recOwned = _out1077;
                    _1705_recErased = _out1078;
                    _1706_recIdents = _out1079;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1704_recOwned;
                    isErased = _1705_recErased;
                    readIdents = _1706_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1707___mcc_h900 = _source59.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1708_recursiveGen;
                    bool _1709_recOwned;
                    bool _1710_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1711_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1080;
                    bool _out1081;
                    bool _out1082;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                    _1708_recursiveGen = _out1080;
                    _1709_recOwned = _out1081;
                    _1710_recErased = _out1082;
                    _1711_recIdents = _out1083;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1708_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1709_recOwned;
                    isErased = _1710_recErased;
                    readIdents = _1711_recIdents;
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1712___mcc_h902 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1713_recursiveGen;
                    bool _1714_recOwned;
                    bool _1715_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1716_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1084;
                    bool _out1085;
                    bool _out1086;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                    _1713_recursiveGen = _out1084;
                    _1714_recOwned = _out1085;
                    _1715_recErased = _out1086;
                    _1716_recIdents = _out1087;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1713_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1714_recOwned;
                    isErased = _1715_recErased;
                    readIdents = _1716_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1717___mcc_h904 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1718_recursiveGen;
                    bool _1719_recOwned;
                    bool _1720_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1721_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1088;
                    bool _out1089;
                    bool _out1090;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                    _1718_recursiveGen = _out1088;
                    _1719_recOwned = _out1089;
                    _1720_recErased = _out1090;
                    _1721_recIdents = _out1091;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1719_recOwned;
                    isErased = _1720_recErased;
                    readIdents = _1721_recIdents;
                  }
                }
              } else if (_source52.is_Bool) {
                DAST._IType _source61 = _557___mcc_h265;
                if (_source61.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1722___mcc_h906 = _source61.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1723___mcc_h907 = _source61.dtor_typeArgs;
                  DAST._IResolvedType _1724___mcc_h908 = _source61.dtor_resolved;
                  DAST._IResolvedType _source62 = _1724___mcc_h908;
                  if (_source62.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1725___mcc_h912 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1726_recursiveGen;
                      bool _1727_recOwned;
                      bool _1728_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1729_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1092;
                      bool _out1093;
                      bool _out1094;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                      _1726_recursiveGen = _out1092;
                      _1727_recOwned = _out1093;
                      _1728_recErased = _out1094;
                      _1729_recIdents = _out1095;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1726_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1727_recOwned;
                      isErased = _1728_recErased;
                      readIdents = _1729_recIdents;
                    }
                  } else if (_source62.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1730___mcc_h914 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1731_recursiveGen;
                      bool _1732_recOwned;
                      bool _1733_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1734_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1096;
                      bool _out1097;
                      bool _out1098;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1099;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1096, out _out1097, out _out1098, out _out1099);
                      _1731_recursiveGen = _out1096;
                      _1732_recOwned = _out1097;
                      _1733_recErased = _out1098;
                      _1734_recIdents = _out1099;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1731_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1732_recOwned;
                      isErased = _1733_recErased;
                      readIdents = _1734_recIdents;
                    }
                  } else {
                    DAST._IType _1735___mcc_h916 = _source62.dtor_Newtype_a0;
                    DAST._IType _1736_b = _1735___mcc_h916;
                    {
                      if (object.Equals(_550_fromTpe, _1736_b)) {
                        Dafny.ISequence<Dafny.Rune> _1737_recursiveGen;
                        bool _1738_recOwned;
                        bool _1739_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1740_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1100;
                        bool _out1101;
                        bool _out1102;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1103;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1100, out _out1101, out _out1102, out _out1103);
                        _1737_recursiveGen = _out1100;
                        _1738_recOwned = _out1101;
                        _1739_recErased = _out1102;
                        _1740_recIdents = _out1103;
                        Dafny.ISequence<Dafny.Rune> _1741_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1104;
                        _out1104 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _1741_rhsType = _out1104;
                        Dafny.ISequence<Dafny.Rune> _1742_uneraseFn;
                        _1742_uneraseFn = ((_1738_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1741_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1742_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1737_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1738_recOwned;
                        isErased = false;
                        readIdents = _1740_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1105;
                        bool _out1106;
                        bool _out1107;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1736_b), _1736_b, _549_toTpe), selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                        s = _out1105;
                        isOwned = _out1106;
                        isErased = _out1107;
                        readIdents = _out1108;
                      }
                    }
                  }
                } else if (_source61.is_Nullable) {
                  DAST._IType _1743___mcc_h918 = _source61.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1744_recursiveGen;
                    bool _1745_recOwned;
                    bool _1746_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1747_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1744_recursiveGen = _out1109;
                    _1745_recOwned = _out1110;
                    _1746_recErased = _out1111;
                    _1747_recIdents = _out1112;
                    if (!(_1745_recOwned)) {
                      _1744_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1744_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1744_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1746_recErased;
                    readIdents = _1747_recIdents;
                  }
                } else if (_source61.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1748___mcc_h920 = _source61.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1749_recursiveGen;
                    bool _1750_recOwned;
                    bool _1751_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1752_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1749_recursiveGen = _out1113;
                    _1750_recOwned = _out1114;
                    _1751_recErased = _out1115;
                    _1752_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1749_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1750_recOwned;
                    isErased = _1751_recErased;
                    readIdents = _1752_recIdents;
                  }
                } else if (_source61.is_Array) {
                  DAST._IType _1753___mcc_h922 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1754_recursiveGen;
                    bool _1755_recOwned;
                    bool _1756_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1757_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1754_recursiveGen = _out1117;
                    _1755_recOwned = _out1118;
                    _1756_recErased = _out1119;
                    _1757_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1755_recOwned;
                    isErased = _1756_recErased;
                    readIdents = _1757_recIdents;
                  }
                } else if (_source61.is_Seq) {
                  DAST._IType _1758___mcc_h924 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1759_recursiveGen;
                    bool _1760_recOwned;
                    bool _1761_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1762_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1759_recursiveGen = _out1121;
                    _1760_recOwned = _out1122;
                    _1761_recErased = _out1123;
                    _1762_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1760_recOwned;
                    isErased = _1761_recErased;
                    readIdents = _1762_recIdents;
                  }
                } else if (_source61.is_Set) {
                  DAST._IType _1763___mcc_h926 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1764_recursiveGen;
                    bool _1765_recOwned;
                    bool _1766_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1767_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1764_recursiveGen = _out1125;
                    _1765_recOwned = _out1126;
                    _1766_recErased = _out1127;
                    _1767_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1764_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1765_recOwned;
                    isErased = _1766_recErased;
                    readIdents = _1767_recIdents;
                  }
                } else if (_source61.is_Multiset) {
                  DAST._IType _1768___mcc_h928 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1769_recursiveGen;
                    bool _1770_recOwned;
                    bool _1771_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1772_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1769_recursiveGen = _out1129;
                    _1770_recOwned = _out1130;
                    _1771_recErased = _out1131;
                    _1772_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1769_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1770_recOwned;
                    isErased = _1771_recErased;
                    readIdents = _1772_recIdents;
                  }
                } else if (_source61.is_Map) {
                  DAST._IType _1773___mcc_h930 = _source61.dtor_key;
                  DAST._IType _1774___mcc_h931 = _source61.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1775_recursiveGen;
                    bool _1776_recOwned;
                    bool _1777_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1778_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1775_recursiveGen = _out1133;
                    _1776_recOwned = _out1134;
                    _1777_recErased = _out1135;
                    _1778_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1775_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1776_recOwned;
                    isErased = _1777_recErased;
                    readIdents = _1778_recIdents;
                  }
                } else if (_source61.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1779___mcc_h934 = _source61.dtor_args;
                  DAST._IType _1780___mcc_h935 = _source61.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1781_recursiveGen;
                    bool _1782_recOwned;
                    bool _1783_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1784_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1137;
                    bool _out1138;
                    bool _out1139;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                    _1781_recursiveGen = _out1137;
                    _1782_recOwned = _out1138;
                    _1783_recErased = _out1139;
                    _1784_recIdents = _out1140;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1781_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1782_recOwned;
                    isErased = _1783_recErased;
                    readIdents = _1784_recIdents;
                  }
                } else if (_source61.is_Primitive) {
                  DAST._IPrimitive _1785___mcc_h938 = _source61.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1786_recursiveGen;
                    bool _1787_recOwned;
                    bool _1788_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1789_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    bool _out1142;
                    bool _out1143;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                    _1786_recursiveGen = _out1141;
                    _1787_recOwned = _out1142;
                    _1788_recErased = _out1143;
                    _1789_recIdents = _out1144;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1786_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1787_recOwned;
                    isErased = _1788_recErased;
                    readIdents = _1789_recIdents;
                  }
                } else if (_source61.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1790___mcc_h940 = _source61.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1791_recursiveGen;
                    bool _1792_recOwned;
                    bool _1793_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1794_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1145;
                    bool _out1146;
                    bool _out1147;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                    _1791_recursiveGen = _out1145;
                    _1792_recOwned = _out1146;
                    _1793_recErased = _out1147;
                    _1794_recIdents = _out1148;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1791_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1792_recOwned;
                    isErased = _1793_recErased;
                    readIdents = _1794_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1795___mcc_h942 = _source61.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1796_recursiveGen;
                    bool _1797_recOwned;
                    bool _1798_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1799_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1149;
                    bool _out1150;
                    bool _out1151;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1152;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1149, out _out1150, out _out1151, out _out1152);
                    _1796_recursiveGen = _out1149;
                    _1797_recOwned = _out1150;
                    _1798_recErased = _out1151;
                    _1799_recIdents = _out1152;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1796_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1797_recOwned;
                    isErased = _1798_recErased;
                    readIdents = _1799_recIdents;
                  }
                }
              } else {
                DAST._IType _source63 = _557___mcc_h265;
                if (_source63.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1800___mcc_h944 = _source63.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1801___mcc_h945 = _source63.dtor_typeArgs;
                  DAST._IResolvedType _1802___mcc_h946 = _source63.dtor_resolved;
                  DAST._IResolvedType _source64 = _1802___mcc_h946;
                  if (_source64.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1803___mcc_h950 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1804_recursiveGen;
                      bool _1805_recOwned;
                      bool _1806_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1807_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1153;
                      bool _out1154;
                      bool _out1155;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1156;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1153, out _out1154, out _out1155, out _out1156);
                      _1804_recursiveGen = _out1153;
                      _1805_recOwned = _out1154;
                      _1806_recErased = _out1155;
                      _1807_recIdents = _out1156;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1804_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1805_recOwned;
                      isErased = _1806_recErased;
                      readIdents = _1807_recIdents;
                    }
                  } else if (_source64.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1808___mcc_h952 = _source64.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1809_recursiveGen;
                      bool _1810_recOwned;
                      bool _1811_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1812_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1157;
                      bool _out1158;
                      bool _out1159;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1160;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1157, out _out1158, out _out1159, out _out1160);
                      _1809_recursiveGen = _out1157;
                      _1810_recOwned = _out1158;
                      _1811_recErased = _out1159;
                      _1812_recIdents = _out1160;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1809_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1810_recOwned;
                      isErased = _1811_recErased;
                      readIdents = _1812_recIdents;
                    }
                  } else {
                    DAST._IType _1813___mcc_h954 = _source64.dtor_Newtype_a0;
                    DAST._IType _1814_b = _1813___mcc_h954;
                    {
                      if (object.Equals(_550_fromTpe, _1814_b)) {
                        Dafny.ISequence<Dafny.Rune> _1815_recursiveGen;
                        bool _1816_recOwned;
                        bool _1817_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1818_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1161;
                        bool _out1162;
                        bool _out1163;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1164;
                        DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1161, out _out1162, out _out1163, out _out1164);
                        _1815_recursiveGen = _out1161;
                        _1816_recOwned = _out1162;
                        _1817_recErased = _out1163;
                        _1818_recIdents = _out1164;
                        Dafny.ISequence<Dafny.Rune> _1819_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1165;
                        _out1165 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                        _1819_rhsType = _out1165;
                        Dafny.ISequence<Dafny.Rune> _1820_uneraseFn;
                        _1820_uneraseFn = ((_1816_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1819_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1820_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1815_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1816_recOwned;
                        isErased = false;
                        readIdents = _1818_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1166;
                        bool _out1167;
                        bool _out1168;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1814_b), _1814_b, _549_toTpe), selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                        s = _out1166;
                        isOwned = _out1167;
                        isErased = _out1168;
                        readIdents = _out1169;
                      }
                    }
                  }
                } else if (_source63.is_Nullable) {
                  DAST._IType _1821___mcc_h956 = _source63.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1822_recursiveGen;
                    bool _1823_recOwned;
                    bool _1824_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1825_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1822_recursiveGen = _out1170;
                    _1823_recOwned = _out1171;
                    _1824_recErased = _out1172;
                    _1825_recIdents = _out1173;
                    if (!(_1823_recOwned)) {
                      _1822_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1822_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1822_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1824_recErased;
                    readIdents = _1825_recIdents;
                  }
                } else if (_source63.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1826___mcc_h958 = _source63.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1827_recursiveGen;
                    bool _1828_recOwned;
                    bool _1829_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1830_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1827_recursiveGen = _out1174;
                    _1828_recOwned = _out1175;
                    _1829_recErased = _out1176;
                    _1830_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1827_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1828_recOwned;
                    isErased = _1829_recErased;
                    readIdents = _1830_recIdents;
                  }
                } else if (_source63.is_Array) {
                  DAST._IType _1831___mcc_h960 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1832_recursiveGen;
                    bool _1833_recOwned;
                    bool _1834_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1835_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1832_recursiveGen = _out1178;
                    _1833_recOwned = _out1179;
                    _1834_recErased = _out1180;
                    _1835_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1832_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1833_recOwned;
                    isErased = _1834_recErased;
                    readIdents = _1835_recIdents;
                  }
                } else if (_source63.is_Seq) {
                  DAST._IType _1836___mcc_h962 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1837_recursiveGen;
                    bool _1838_recOwned;
                    bool _1839_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1840_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1837_recursiveGen = _out1182;
                    _1838_recOwned = _out1183;
                    _1839_recErased = _out1184;
                    _1840_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1837_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1838_recOwned;
                    isErased = _1839_recErased;
                    readIdents = _1840_recIdents;
                  }
                } else if (_source63.is_Set) {
                  DAST._IType _1841___mcc_h964 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1842_recursiveGen;
                    bool _1843_recOwned;
                    bool _1844_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1845_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1186;
                    bool _out1187;
                    bool _out1188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1189;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1186, out _out1187, out _out1188, out _out1189);
                    _1842_recursiveGen = _out1186;
                    _1843_recOwned = _out1187;
                    _1844_recErased = _out1188;
                    _1845_recIdents = _out1189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1842_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1843_recOwned;
                    isErased = _1844_recErased;
                    readIdents = _1845_recIdents;
                  }
                } else if (_source63.is_Multiset) {
                  DAST._IType _1846___mcc_h966 = _source63.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1847_recursiveGen;
                    bool _1848_recOwned;
                    bool _1849_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1850_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1190;
                    bool _out1191;
                    bool _out1192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1193;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1190, out _out1191, out _out1192, out _out1193);
                    _1847_recursiveGen = _out1190;
                    _1848_recOwned = _out1191;
                    _1849_recErased = _out1192;
                    _1850_recIdents = _out1193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1847_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1848_recOwned;
                    isErased = _1849_recErased;
                    readIdents = _1850_recIdents;
                  }
                } else if (_source63.is_Map) {
                  DAST._IType _1851___mcc_h968 = _source63.dtor_key;
                  DAST._IType _1852___mcc_h969 = _source63.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1853_recursiveGen;
                    bool _1854_recOwned;
                    bool _1855_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1856_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1194;
                    bool _out1195;
                    bool _out1196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1197;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1194, out _out1195, out _out1196, out _out1197);
                    _1853_recursiveGen = _out1194;
                    _1854_recOwned = _out1195;
                    _1855_recErased = _out1196;
                    _1856_recIdents = _out1197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1853_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1854_recOwned;
                    isErased = _1855_recErased;
                    readIdents = _1856_recIdents;
                  }
                } else if (_source63.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1857___mcc_h972 = _source63.dtor_args;
                  DAST._IType _1858___mcc_h973 = _source63.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1859_recursiveGen;
                    bool _1860_recOwned;
                    bool _1861_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1862_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1198;
                    bool _out1199;
                    bool _out1200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1201;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1198, out _out1199, out _out1200, out _out1201);
                    _1859_recursiveGen = _out1198;
                    _1860_recOwned = _out1199;
                    _1861_recErased = _out1200;
                    _1862_recIdents = _out1201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1859_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1860_recOwned;
                    isErased = _1861_recErased;
                    readIdents = _1862_recIdents;
                  }
                } else if (_source63.is_Primitive) {
                  DAST._IPrimitive _1863___mcc_h976 = _source63.dtor_Primitive_a0;
                  DAST._IPrimitive _source65 = _1863___mcc_h976;
                  if (_source65.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1864_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1202;
                      _out1202 = DCOMP.COMP.GenType(_550_fromTpe, true, false);
                      _1864_rhsType = _out1202;
                      Dafny.ISequence<Dafny.Rune> _1865_recursiveGen;
                      bool _1866___v60;
                      bool _1867___v61;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1868_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, true, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1865_recursiveGen = _out1203;
                      _1866___v60 = _out1204;
                      _1867___v61 = _out1205;
                      _1868_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1865_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1868_recIdents;
                    }
                  } else if (_source65.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1869_recursiveGen;
                      bool _1870_recOwned;
                      bool _1871_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1872_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1207;
                      bool _out1208;
                      bool _out1209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                      _1869_recursiveGen = _out1207;
                      _1870_recOwned = _out1208;
                      _1871_recErased = _out1209;
                      _1872_recIdents = _out1210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1869_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1870_recOwned;
                      isErased = _1871_recErased;
                      readIdents = _1872_recIdents;
                    }
                  } else if (_source65.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1873_recursiveGen;
                      bool _1874_recOwned;
                      bool _1875_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1876_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1211;
                      bool _out1212;
                      bool _out1213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                      _1873_recursiveGen = _out1211;
                      _1874_recOwned = _out1212;
                      _1875_recErased = _out1213;
                      _1876_recIdents = _out1214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1874_recOwned;
                      isErased = _1875_recErased;
                      readIdents = _1876_recIdents;
                    }
                  } else if (_source65.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1877_recursiveGen;
                      bool _1878_recOwned;
                      bool _1879_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1880_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1215;
                      bool _out1216;
                      bool _out1217;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                      _1877_recursiveGen = _out1215;
                      _1878_recOwned = _out1216;
                      _1879_recErased = _out1217;
                      _1880_recIdents = _out1218;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1877_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1878_recOwned;
                      isErased = _1879_recErased;
                      readIdents = _1880_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1881_recursiveGen;
                      bool _1882_recOwned;
                      bool _1883_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1884_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1219;
                      bool _out1220;
                      bool _out1221;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                      _1881_recursiveGen = _out1219;
                      _1882_recOwned = _out1220;
                      _1883_recErased = _out1221;
                      _1884_recIdents = _out1222;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1881_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1882_recOwned;
                      isErased = _1883_recErased;
                      readIdents = _1884_recIdents;
                    }
                  }
                } else if (_source63.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1885___mcc_h978 = _source63.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1886_recursiveGen;
                    bool _1887_recOwned;
                    bool _1888_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1889_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1223;
                    bool _out1224;
                    bool _out1225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                    _1886_recursiveGen = _out1223;
                    _1887_recOwned = _out1224;
                    _1888_recErased = _out1225;
                    _1889_recIdents = _out1226;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1887_recOwned;
                    isErased = _1888_recErased;
                    readIdents = _1889_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1890___mcc_h980 = _source63.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1891_recursiveGen;
                    bool _1892_recOwned;
                    bool _1893_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1894_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1227;
                    bool _out1228;
                    bool _out1229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1230;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1227, out _out1228, out _out1229, out _out1230);
                    _1891_recursiveGen = _out1227;
                    _1892_recOwned = _out1228;
                    _1893_recErased = _out1229;
                    _1894_recIdents = _out1230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1892_recOwned;
                    isErased = _1893_recErased;
                    readIdents = _1894_recIdents;
                  }
                }
              }
            } else if (_source28.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1895___mcc_h982 = _source28.dtor_Passthrough_a0;
              DAST._IType _source66 = _557___mcc_h265;
              if (_source66.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1896___mcc_h986 = _source66.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1897___mcc_h987 = _source66.dtor_typeArgs;
                DAST._IResolvedType _1898___mcc_h988 = _source66.dtor_resolved;
                DAST._IResolvedType _source67 = _1898___mcc_h988;
                if (_source67.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1899___mcc_h992 = _source67.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1900_recursiveGen;
                    bool _1901_recOwned;
                    bool _1902_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1903_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1231;
                    bool _out1232;
                    bool _out1233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1234;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1231, out _out1232, out _out1233, out _out1234);
                    _1900_recursiveGen = _out1231;
                    _1901_recOwned = _out1232;
                    _1902_recErased = _out1233;
                    _1903_recIdents = _out1234;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1900_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1901_recOwned;
                    isErased = _1902_recErased;
                    readIdents = _1903_recIdents;
                  }
                } else if (_source67.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1904___mcc_h994 = _source67.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1905_recursiveGen;
                    bool _1906_recOwned;
                    bool _1907_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1908_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1235;
                    bool _out1236;
                    bool _out1237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1238;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1235, out _out1236, out _out1237, out _out1238);
                    _1905_recursiveGen = _out1235;
                    _1906_recOwned = _out1236;
                    _1907_recErased = _out1237;
                    _1908_recIdents = _out1238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1905_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1906_recOwned;
                    isErased = _1907_recErased;
                    readIdents = _1908_recIdents;
                  }
                } else {
                  DAST._IType _1909___mcc_h996 = _source67.dtor_Newtype_a0;
                  DAST._IType _1910_b = _1909___mcc_h996;
                  {
                    if (object.Equals(_550_fromTpe, _1910_b)) {
                      Dafny.ISequence<Dafny.Rune> _1911_recursiveGen;
                      bool _1912_recOwned;
                      bool _1913_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1914_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1239;
                      bool _out1240;
                      bool _out1241;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1242;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1239, out _out1240, out _out1241, out _out1242);
                      _1911_recursiveGen = _out1239;
                      _1912_recOwned = _out1240;
                      _1913_recErased = _out1241;
                      _1914_recIdents = _out1242;
                      Dafny.ISequence<Dafny.Rune> _1915_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1243;
                      _out1243 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _1915_rhsType = _out1243;
                      Dafny.ISequence<Dafny.Rune> _1916_uneraseFn;
                      _1916_uneraseFn = ((_1912_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1915_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1916_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1911_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1912_recOwned;
                      isErased = false;
                      readIdents = _1914_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1244;
                      bool _out1245;
                      bool _out1246;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _1910_b), _1910_b, _549_toTpe), selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                      s = _out1244;
                      isOwned = _out1245;
                      isErased = _out1246;
                      readIdents = _out1247;
                    }
                  }
                }
              } else if (_source66.is_Nullable) {
                DAST._IType _1917___mcc_h998 = _source66.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1918_recursiveGen;
                  bool _1919_recOwned;
                  bool _1920_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1921_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1918_recursiveGen = _out1248;
                  _1919_recOwned = _out1249;
                  _1920_recErased = _out1250;
                  _1921_recIdents = _out1251;
                  if (!(_1919_recOwned)) {
                    _1918_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1918_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1918_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1920_recErased;
                  readIdents = _1921_recIdents;
                }
              } else if (_source66.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1922___mcc_h1000 = _source66.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1923_recursiveGen;
                  bool _1924_recOwned;
                  bool _1925_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1926_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1923_recursiveGen = _out1252;
                  _1924_recOwned = _out1253;
                  _1925_recErased = _out1254;
                  _1926_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1923_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1924_recOwned;
                  isErased = _1925_recErased;
                  readIdents = _1926_recIdents;
                }
              } else if (_source66.is_Array) {
                DAST._IType _1927___mcc_h1002 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1928_recursiveGen;
                  bool _1929_recOwned;
                  bool _1930_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1931_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1928_recursiveGen = _out1256;
                  _1929_recOwned = _out1257;
                  _1930_recErased = _out1258;
                  _1931_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1928_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1929_recOwned;
                  isErased = _1930_recErased;
                  readIdents = _1931_recIdents;
                }
              } else if (_source66.is_Seq) {
                DAST._IType _1932___mcc_h1004 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1933_recursiveGen;
                  bool _1934_recOwned;
                  bool _1935_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1936_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1933_recursiveGen = _out1260;
                  _1934_recOwned = _out1261;
                  _1935_recErased = _out1262;
                  _1936_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1933_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1934_recOwned;
                  isErased = _1935_recErased;
                  readIdents = _1936_recIdents;
                }
              } else if (_source66.is_Set) {
                DAST._IType _1937___mcc_h1006 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1938_recursiveGen;
                  bool _1939_recOwned;
                  bool _1940_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1941_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1264;
                  bool _out1265;
                  bool _out1266;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1264, out _out1265, out _out1266, out _out1267);
                  _1938_recursiveGen = _out1264;
                  _1939_recOwned = _out1265;
                  _1940_recErased = _out1266;
                  _1941_recIdents = _out1267;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1938_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1939_recOwned;
                  isErased = _1940_recErased;
                  readIdents = _1941_recIdents;
                }
              } else if (_source66.is_Multiset) {
                DAST._IType _1942___mcc_h1008 = _source66.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1943_recursiveGen;
                  bool _1944_recOwned;
                  bool _1945_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1946_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1268;
                  bool _out1269;
                  bool _out1270;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1268, out _out1269, out _out1270, out _out1271);
                  _1943_recursiveGen = _out1268;
                  _1944_recOwned = _out1269;
                  _1945_recErased = _out1270;
                  _1946_recIdents = _out1271;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1944_recOwned;
                  isErased = _1945_recErased;
                  readIdents = _1946_recIdents;
                }
              } else if (_source66.is_Map) {
                DAST._IType _1947___mcc_h1010 = _source66.dtor_key;
                DAST._IType _1948___mcc_h1011 = _source66.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1949_recursiveGen;
                  bool _1950_recOwned;
                  bool _1951_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1952_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1272;
                  bool _out1273;
                  bool _out1274;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1275;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1272, out _out1273, out _out1274, out _out1275);
                  _1949_recursiveGen = _out1272;
                  _1950_recOwned = _out1273;
                  _1951_recErased = _out1274;
                  _1952_recIdents = _out1275;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1949_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1950_recOwned;
                  isErased = _1951_recErased;
                  readIdents = _1952_recIdents;
                }
              } else if (_source66.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1953___mcc_h1014 = _source66.dtor_args;
                DAST._IType _1954___mcc_h1015 = _source66.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1955_recursiveGen;
                  bool _1956_recOwned;
                  bool _1957_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1958_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1276;
                  bool _out1277;
                  bool _out1278;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1279;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1276, out _out1277, out _out1278, out _out1279);
                  _1955_recursiveGen = _out1276;
                  _1956_recOwned = _out1277;
                  _1957_recErased = _out1278;
                  _1958_recIdents = _out1279;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1955_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1956_recOwned;
                  isErased = _1957_recErased;
                  readIdents = _1958_recIdents;
                }
              } else if (_source66.is_Primitive) {
                DAST._IPrimitive _1959___mcc_h1018 = _source66.dtor_Primitive_a0;
                DAST._IPrimitive _source68 = _1959___mcc_h1018;
                if (_source68.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1960_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1280;
                    _out1280 = DCOMP.COMP.GenType(_550_fromTpe, true, false);
                    _1960_rhsType = _out1280;
                    Dafny.ISequence<Dafny.Rune> _1961_recursiveGen;
                    bool _1962___v56;
                    bool _1963___v57;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1964_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, true, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1961_recursiveGen = _out1281;
                    _1962___v56 = _out1282;
                    _1963___v57 = _out1283;
                    _1964_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1961_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1964_recIdents;
                  }
                } else if (_source68.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1965_recursiveGen;
                    bool _1966_recOwned;
                    bool _1967_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1285;
                    bool _out1286;
                    bool _out1287;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1285, out _out1286, out _out1287, out _out1288);
                    _1965_recursiveGen = _out1285;
                    _1966_recOwned = _out1286;
                    _1967_recErased = _out1287;
                    _1968_recIdents = _out1288;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1966_recOwned;
                    isErased = _1967_recErased;
                    readIdents = _1968_recIdents;
                  }
                } else if (_source68.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1969_recursiveGen;
                    bool _1970_recOwned;
                    bool _1971_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1972_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1289;
                    bool _out1290;
                    bool _out1291;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1289, out _out1290, out _out1291, out _out1292);
                    _1969_recursiveGen = _out1289;
                    _1970_recOwned = _out1290;
                    _1971_recErased = _out1291;
                    _1972_recIdents = _out1292;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1970_recOwned;
                    isErased = _1971_recErased;
                    readIdents = _1972_recIdents;
                  }
                } else if (_source68.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1973_recursiveGen;
                    bool _1974_recOwned;
                    bool _1975_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1976_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1293;
                    bool _out1294;
                    bool _out1295;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1293, out _out1294, out _out1295, out _out1296);
                    _1973_recursiveGen = _out1293;
                    _1974_recOwned = _out1294;
                    _1975_recErased = _out1295;
                    _1976_recIdents = _out1296;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1973_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1974_recOwned;
                    isErased = _1975_recErased;
                    readIdents = _1976_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1977_recursiveGen;
                    bool _1978_recOwned;
                    bool _1979_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1980_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1297;
                    bool _out1298;
                    bool _out1299;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1300;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1297, out _out1298, out _out1299, out _out1300);
                    _1977_recursiveGen = _out1297;
                    _1978_recOwned = _out1298;
                    _1979_recErased = _out1299;
                    _1980_recIdents = _out1300;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1978_recOwned;
                    isErased = _1979_recErased;
                    readIdents = _1980_recIdents;
                  }
                }
              } else if (_source66.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1981___mcc_h1020 = _source66.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1982_recursiveGen;
                  bool _1983___v64;
                  bool _1984___v65;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1301;
                  bool _out1302;
                  bool _out1303;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1304;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, true, out _out1301, out _out1302, out _out1303, out _out1304);
                  _1982_recursiveGen = _out1301;
                  _1983___v64 = _out1302;
                  _1984___v65 = _out1303;
                  _1985_recIdents = _out1304;
                  Dafny.ISequence<Dafny.Rune> _1986_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1305;
                  _out1305 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                  _1986_toTpeGen = _out1305;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1986_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1985_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1987___mcc_h1022 = _source66.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1988_recursiveGen;
                  bool _1989_recOwned;
                  bool _1990_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1991_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1306;
                  bool _out1307;
                  bool _out1308;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1306, out _out1307, out _out1308, out _out1309);
                  _1988_recursiveGen = _out1306;
                  _1989_recOwned = _out1307;
                  _1990_recErased = _out1308;
                  _1991_recIdents = _out1309;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1988_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1989_recOwned;
                  isErased = _1990_recErased;
                  readIdents = _1991_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1992___mcc_h1024 = _source28.dtor_TypeArg_a0;
              DAST._IType _source69 = _557___mcc_h265;
              if (_source69.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1993___mcc_h1028 = _source69.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1994___mcc_h1029 = _source69.dtor_typeArgs;
                DAST._IResolvedType _1995___mcc_h1030 = _source69.dtor_resolved;
                DAST._IResolvedType _source70 = _1995___mcc_h1030;
                if (_source70.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1996___mcc_h1034 = _source70.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1997_recursiveGen;
                    bool _1998_recOwned;
                    bool _1999_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2000_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1310;
                    bool _out1311;
                    bool _out1312;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
                    _1997_recursiveGen = _out1310;
                    _1998_recOwned = _out1311;
                    _1999_recErased = _out1312;
                    _2000_recIdents = _out1313;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1997_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1998_recOwned;
                    isErased = _1999_recErased;
                    readIdents = _2000_recIdents;
                  }
                } else if (_source70.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2001___mcc_h1036 = _source70.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _2002_recursiveGen;
                    bool _2003_recOwned;
                    bool _2004_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2005_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1314;
                    bool _out1315;
                    bool _out1316;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1317;
                    DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1314, out _out1315, out _out1316, out _out1317);
                    _2002_recursiveGen = _out1314;
                    _2003_recOwned = _out1315;
                    _2004_recErased = _out1316;
                    _2005_recIdents = _out1317;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2002_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _2003_recOwned;
                    isErased = _2004_recErased;
                    readIdents = _2005_recIdents;
                  }
                } else {
                  DAST._IType _2006___mcc_h1038 = _source70.dtor_Newtype_a0;
                  DAST._IType _2007_b = _2006___mcc_h1038;
                  {
                    if (object.Equals(_550_fromTpe, _2007_b)) {
                      Dafny.ISequence<Dafny.Rune> _2008_recursiveGen;
                      bool _2009_recOwned;
                      bool _2010_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2011_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1318;
                      bool _out1319;
                      bool _out1320;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1321;
                      DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1318, out _out1319, out _out1320, out _out1321);
                      _2008_recursiveGen = _out1318;
                      _2009_recOwned = _out1319;
                      _2010_recErased = _out1320;
                      _2011_recIdents = _out1321;
                      Dafny.ISequence<Dafny.Rune> _2012_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1322;
                      _out1322 = DCOMP.COMP.GenType(_549_toTpe, true, false);
                      _2012_rhsType = _out1322;
                      Dafny.ISequence<Dafny.Rune> _2013_uneraseFn;
                      _2013_uneraseFn = ((_2009_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2012_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _2013_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2008_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _2009_recOwned;
                      isErased = false;
                      readIdents = _2011_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1323;
                      bool _out1324;
                      bool _out1325;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_551_expr, _550_fromTpe, _2007_b), _2007_b, _549_toTpe), selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                      s = _out1323;
                      isOwned = _out1324;
                      isErased = _out1325;
                      readIdents = _out1326;
                    }
                  }
                }
              } else if (_source69.is_Nullable) {
                DAST._IType _2014___mcc_h1040 = _source69.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2015_recursiveGen;
                  bool _2016_recOwned;
                  bool _2017_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2018_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _2015_recursiveGen = _out1327;
                  _2016_recOwned = _out1328;
                  _2017_recErased = _out1329;
                  _2018_recIdents = _out1330;
                  if (!(_2016_recOwned)) {
                    _2015_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_2015_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _2015_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _2017_recErased;
                  readIdents = _2018_recIdents;
                }
              } else if (_source69.is_Tuple) {
                Dafny.ISequence<DAST._IType> _2019___mcc_h1042 = _source69.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2020_recursiveGen;
                  bool _2021_recOwned;
                  bool _2022_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2023_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _2020_recursiveGen = _out1331;
                  _2021_recOwned = _out1332;
                  _2022_recErased = _out1333;
                  _2023_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2020_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2021_recOwned;
                  isErased = _2022_recErased;
                  readIdents = _2023_recIdents;
                }
              } else if (_source69.is_Array) {
                DAST._IType _2024___mcc_h1044 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2025_recursiveGen;
                  bool _2026_recOwned;
                  bool _2027_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2028_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _2025_recursiveGen = _out1335;
                  _2026_recOwned = _out1336;
                  _2027_recErased = _out1337;
                  _2028_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2026_recOwned;
                  isErased = _2027_recErased;
                  readIdents = _2028_recIdents;
                }
              } else if (_source69.is_Seq) {
                DAST._IType _2029___mcc_h1046 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2030_recursiveGen;
                  bool _2031_recOwned;
                  bool _2032_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2033_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _2030_recursiveGen = _out1339;
                  _2031_recOwned = _out1340;
                  _2032_recErased = _out1341;
                  _2033_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2030_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2031_recOwned;
                  isErased = _2032_recErased;
                  readIdents = _2033_recIdents;
                }
              } else if (_source69.is_Set) {
                DAST._IType _2034___mcc_h1048 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2035_recursiveGen;
                  bool _2036_recOwned;
                  bool _2037_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2038_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _2035_recursiveGen = _out1343;
                  _2036_recOwned = _out1344;
                  _2037_recErased = _out1345;
                  _2038_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2036_recOwned;
                  isErased = _2037_recErased;
                  readIdents = _2038_recIdents;
                }
              } else if (_source69.is_Multiset) {
                DAST._IType _2039___mcc_h1050 = _source69.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _2040_recursiveGen;
                  bool _2041_recOwned;
                  bool _2042_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2043_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _2040_recursiveGen = _out1347;
                  _2041_recOwned = _out1348;
                  _2042_recErased = _out1349;
                  _2043_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2041_recOwned;
                  isErased = _2042_recErased;
                  readIdents = _2043_recIdents;
                }
              } else if (_source69.is_Map) {
                DAST._IType _2044___mcc_h1052 = _source69.dtor_key;
                DAST._IType _2045___mcc_h1053 = _source69.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _2046_recursiveGen;
                  bool _2047_recOwned;
                  bool _2048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2046_recursiveGen = _out1351;
                  _2047_recOwned = _out1352;
                  _2048_recErased = _out1353;
                  _2049_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2047_recOwned;
                  isErased = _2048_recErased;
                  readIdents = _2049_recIdents;
                }
              } else if (_source69.is_Arrow) {
                Dafny.ISequence<DAST._IType> _2050___mcc_h1056 = _source69.dtor_args;
                DAST._IType _2051___mcc_h1057 = _source69.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _2052_recursiveGen;
                  bool _2053_recOwned;
                  bool _2054_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2055_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1355;
                  bool _out1356;
                  bool _out1357;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1355, out _out1356, out _out1357, out _out1358);
                  _2052_recursiveGen = _out1355;
                  _2053_recOwned = _out1356;
                  _2054_recErased = _out1357;
                  _2055_recIdents = _out1358;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2052_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2053_recOwned;
                  isErased = _2054_recErased;
                  readIdents = _2055_recIdents;
                }
              } else if (_source69.is_Primitive) {
                DAST._IPrimitive _2056___mcc_h1060 = _source69.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2057_recursiveGen;
                  bool _2058_recOwned;
                  bool _2059_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2060_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1359;
                  bool _out1360;
                  bool _out1361;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1359, out _out1360, out _out1361, out _out1362);
                  _2057_recursiveGen = _out1359;
                  _2058_recOwned = _out1360;
                  _2059_recErased = _out1361;
                  _2060_recIdents = _out1362;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2057_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2058_recOwned;
                  isErased = _2059_recErased;
                  readIdents = _2060_recIdents;
                }
              } else if (_source69.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2061___mcc_h1062 = _source69.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2062_recursiveGen;
                  bool _2063_recOwned;
                  bool _2064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1363;
                  bool _out1364;
                  bool _out1365;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1363, out _out1364, out _out1365, out _out1366);
                  _2062_recursiveGen = _out1363;
                  _2063_recOwned = _out1364;
                  _2064_recErased = _out1365;
                  _2065_recIdents = _out1366;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2063_recOwned;
                  isErased = _2064_recErased;
                  readIdents = _2065_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2066___mcc_h1064 = _source69.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2067_recursiveGen;
                  bool _2068_recOwned;
                  bool _2069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1367;
                  bool _out1368;
                  bool _out1369;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
                  DCOMP.COMP.GenExpr(_551_expr, selfIdent, @params, mustOwn, out _out1367, out _out1368, out _out1369, out _out1370);
                  _2067_recursiveGen = _out1367;
                  _2068_recOwned = _out1368;
                  _2069_recErased = _out1369;
                  _2070_recIdents = _out1370;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2068_recOwned;
                  isErased = _2069_recErased;
                  readIdents = _2070_recIdents;
                }
              }
            }
          }
        }
      } else if (_source21.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2071___mcc_h22 = _source21.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2072_exprs = _2071___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2073_generatedValues;
          _2073_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2074_i;
          _2074_i = BigInteger.Zero;
          bool _2075_allErased;
          _2075_allErased = true;
          while ((_2074_i) < (new BigInteger((_2072_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2076_recursiveGen;
            bool _2077___v67;
            bool _2078_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2079_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1371;
            bool _out1372;
            bool _out1373;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
            DCOMP.COMP.GenExpr((_2072_exprs).Select(_2074_i), selfIdent, @params, true, out _out1371, out _out1372, out _out1373, out _out1374);
            _2076_recursiveGen = _out1371;
            _2077___v67 = _out1372;
            _2078_isErased = _out1373;
            _2079_recIdents = _out1374;
            _2075_allErased = (_2075_allErased) && (_2078_isErased);
            _2073_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2073_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2076_recursiveGen, _2078_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2079_recIdents);
            _2074_i = (_2074_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2074_i = BigInteger.Zero;
          while ((_2074_i) < (new BigInteger((_2073_generatedValues).Count))) {
            if ((_2074_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2080_gen;
            _2080_gen = ((_2073_generatedValues).Select(_2074_i)).dtor__0;
            if ((((_2073_generatedValues).Select(_2074_i)).dtor__1) && (!(_2075_allErased))) {
              _2080_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2080_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2080_gen);
            _2074_i = (_2074_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2075_allErased;
        }
      } else if (_source21.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2081___mcc_h23 = _source21.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2082_exprs = _2081___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2083_generatedValues;
          _2083_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2084_i;
          _2084_i = BigInteger.Zero;
          bool _2085_allErased;
          _2085_allErased = true;
          while ((_2084_i) < (new BigInteger((_2082_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2086_recursiveGen;
            bool _2087___v68;
            bool _2088_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2089_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1375;
            bool _out1376;
            bool _out1377;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
            DCOMP.COMP.GenExpr((_2082_exprs).Select(_2084_i), selfIdent, @params, true, out _out1375, out _out1376, out _out1377, out _out1378);
            _2086_recursiveGen = _out1375;
            _2087___v68 = _out1376;
            _2088_isErased = _out1377;
            _2089_recIdents = _out1378;
            _2085_allErased = (_2085_allErased) && (_2088_isErased);
            _2083_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2083_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2086_recursiveGen, _2088_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2089_recIdents);
            _2084_i = (_2084_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2084_i = BigInteger.Zero;
          while ((_2084_i) < (new BigInteger((_2083_generatedValues).Count))) {
            if ((_2084_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2090_gen;
            _2090_gen = ((_2083_generatedValues).Select(_2084_i)).dtor__0;
            if ((((_2083_generatedValues).Select(_2084_i)).dtor__1) && (!(_2085_allErased))) {
              _2090_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2090_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2090_gen);
            _2084_i = (_2084_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = _2085_allErased;
        }
      } else if (_source21.is_MapValue) {
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2091___mcc_h24 = _source21.dtor_mapElems;
        Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2092_mapElems = _2091___mcc_h24;
        {
          Dafny.ISequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>> _2093_generatedValues;
          _2093_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2094_i;
          _2094_i = BigInteger.Zero;
          bool _2095_allErased;
          _2095_allErased = true;
          while ((_2094_i) < (new BigInteger((_2092_mapElems).Count))) {
            Dafny.ISequence<Dafny.Rune> _2096_recursiveGenKey;
            bool _2097___v69;
            bool _2098_isErasedKey;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2099_recIdentsKey;
            Dafny.ISequence<Dafny.Rune> _out1379;
            bool _out1380;
            bool _out1381;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
            DCOMP.COMP.GenExpr(((_2092_mapElems).Select(_2094_i)).dtor__0, selfIdent, @params, true, out _out1379, out _out1380, out _out1381, out _out1382);
            _2096_recursiveGenKey = _out1379;
            _2097___v69 = _out1380;
            _2098_isErasedKey = _out1381;
            _2099_recIdentsKey = _out1382;
            Dafny.ISequence<Dafny.Rune> _2100_recursiveGenValue;
            bool _2101___v70;
            bool _2102_isErasedValue;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2103_recIdentsValue;
            Dafny.ISequence<Dafny.Rune> _out1383;
            bool _out1384;
            bool _out1385;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
            DCOMP.COMP.GenExpr(((_2092_mapElems).Select(_2094_i)).dtor__1, selfIdent, @params, true, out _out1383, out _out1384, out _out1385, out _out1386);
            _2100_recursiveGenValue = _out1383;
            _2101___v70 = _out1384;
            _2102_isErasedValue = _out1385;
            _2103_recIdentsValue = _out1386;
            _2095_allErased = ((_2095_allErased) && (_2098_isErasedKey)) && (_2102_isErasedValue);
            _2093_generatedValues = Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.Concat(_2093_generatedValues, Dafny.Sequence<_System._ITuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>>.FromElements(_System.Tuple4<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>, bool, bool>.create(_2096_recursiveGenKey, _2100_recursiveGenValue, _2098_isErasedKey, _2102_isErasedValue)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2099_recIdentsKey), _2103_recIdentsValue);
            _2094_i = (_2094_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2094_i = BigInteger.Zero;
          while ((_2094_i) < (new BigInteger((_2093_generatedValues).Count))) {
            if ((_2094_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2104_genKey;
            _2104_genKey = ((_2093_generatedValues).Select(_2094_i)).dtor__0;
            Dafny.ISequence<Dafny.Rune> _2105_genValue;
            _2105_genValue = ((_2093_generatedValues).Select(_2094_i)).dtor__1;
            if ((((_2093_generatedValues).Select(_2094_i)).dtor__2) && (!(_2095_allErased))) {
              _2104_genKey = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2104_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((((_2093_generatedValues).Select(_2094_i)).dtor__3) && (!(_2095_allErased))) {
              _2105_genValue = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2105_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2104_genKey), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2105_genValue), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            _2094_i = (_2094_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashMap<_, _>>()"));
          isOwned = true;
          isErased = _2095_allErased;
        }
      } else if (_source21.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source71 = selfIdent;
          if (_source71.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2106___mcc_h1066 = _source71.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2107_id = _2106___mcc_h1066;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2107_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2107_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2107_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2107_id);
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
        DAST._IExpression _2108___mcc_h25 = _source21.dtor_cond;
        DAST._IExpression _2109___mcc_h26 = _source21.dtor_thn;
        DAST._IExpression _2110___mcc_h27 = _source21.dtor_els;
        DAST._IExpression _2111_f = _2110___mcc_h27;
        DAST._IExpression _2112_t = _2109___mcc_h26;
        DAST._IExpression _2113_cond = _2108___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _2114_condString;
          bool _2115___v71;
          bool _2116_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2117_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1387;
          bool _out1388;
          bool _out1389;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
          DCOMP.COMP.GenExpr(_2113_cond, selfIdent, @params, true, out _out1387, out _out1388, out _out1389, out _out1390);
          _2114_condString = _out1387;
          _2115___v71 = _out1388;
          _2116_condErased = _out1389;
          _2117_recIdentsCond = _out1390;
          if (!(_2116_condErased)) {
            _2114_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2114_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2118___v72;
          bool _2119_tHasToBeOwned;
          bool _2120___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2121___v74;
          Dafny.ISequence<Dafny.Rune> _out1391;
          bool _out1392;
          bool _out1393;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
          DCOMP.COMP.GenExpr(_2112_t, selfIdent, @params, mustOwn, out _out1391, out _out1392, out _out1393, out _out1394);
          _2118___v72 = _out1391;
          _2119_tHasToBeOwned = _out1392;
          _2120___v73 = _out1393;
          _2121___v74 = _out1394;
          Dafny.ISequence<Dafny.Rune> _2122_fString;
          bool _2123_fOwned;
          bool _2124_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2125_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1395;
          bool _out1396;
          bool _out1397;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
          DCOMP.COMP.GenExpr(_2111_f, selfIdent, @params, _2119_tHasToBeOwned, out _out1395, out _out1396, out _out1397, out _out1398);
          _2122_fString = _out1395;
          _2123_fOwned = _out1396;
          _2124_fErased = _out1397;
          _2125_recIdentsF = _out1398;
          Dafny.ISequence<Dafny.Rune> _2126_tString;
          bool _2127___v75;
          bool _2128_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2129_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1399;
          bool _out1400;
          bool _out1401;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
          DCOMP.COMP.GenExpr(_2112_t, selfIdent, @params, _2123_fOwned, out _out1399, out _out1400, out _out1401, out _out1402);
          _2126_tString = _out1399;
          _2127___v75 = _out1400;
          _2128_tErased = _out1401;
          _2129_recIdentsT = _out1402;
          if ((!(_2124_fErased)) || (!(_2128_tErased))) {
            if (_2124_fErased) {
              _2122_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2122_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2128_tErased) {
              _2126_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2126_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2114_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2126_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2122_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2123_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2117_recIdentsCond, _2129_recIdentsT), _2125_recIdentsF);
          isErased = (_2124_fErased) || (_2128_tErased);
        }
      } else if (_source21.is_UnOp) {
        DAST._IUnaryOp _2130___mcc_h28 = _source21.dtor_unOp;
        DAST._IExpression _2131___mcc_h29 = _source21.dtor_expr;
        DAST._IUnaryOp _source72 = _2130___mcc_h28;
        if (_source72.is_Not) {
          DAST._IExpression _2132_e = _2131___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2133_recursiveGen;
            bool _2134___v76;
            bool _2135_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2136_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1403;
            bool _out1404;
            bool _out1405;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
            DCOMP.COMP.GenExpr(_2132_e, selfIdent, @params, true, out _out1403, out _out1404, out _out1405, out _out1406);
            _2133_recursiveGen = _out1403;
            _2134___v76 = _out1404;
            _2135_recErased = _out1405;
            _2136_recIdents = _out1406;
            if (!(_2135_recErased)) {
              _2133_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2133_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2133_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2136_recIdents;
            isErased = true;
          }
        } else if (_source72.is_BitwiseNot) {
          DAST._IExpression _2137_e = _2131___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2138_recursiveGen;
            bool _2139___v77;
            bool _2140_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2141_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1407;
            bool _out1408;
            bool _out1409;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
            DCOMP.COMP.GenExpr(_2137_e, selfIdent, @params, true, out _out1407, out _out1408, out _out1409, out _out1410);
            _2138_recursiveGen = _out1407;
            _2139___v77 = _out1408;
            _2140_recErased = _out1409;
            _2141_recIdents = _out1410;
            if (!(_2140_recErased)) {
              _2138_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2138_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2138_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2141_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2142_e = _2131___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _2143_recursiveGen;
            bool _2144_recOwned;
            bool _2145_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2146_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1411;
            bool _out1412;
            bool _out1413;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
            DCOMP.COMP.GenExpr(_2142_e, selfIdent, @params, false, out _out1411, out _out1412, out _out1413, out _out1414);
            _2143_recursiveGen = _out1411;
            _2144_recOwned = _out1412;
            _2145_recErased = _out1413;
            _2146_recIdents = _out1414;
            if (!(_2145_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2147_eraseFn;
              _2147_eraseFn = ((_2144_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2143_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2147_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2143_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2143_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2146_recIdents;
            isErased = true;
          }
        }
      } else if (_source21.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2148___mcc_h30 = _source21.dtor_op;
        DAST._IExpression _2149___mcc_h31 = _source21.dtor_left;
        DAST._IExpression _2150___mcc_h32 = _source21.dtor_right;
        DAST._IExpression _2151_r = _2150___mcc_h32;
        DAST._IExpression _2152_l = _2149___mcc_h31;
        Dafny.ISequence<Dafny.Rune> _2153_op = _2148___mcc_h30;
        {
          Dafny.ISequence<Dafny.Rune> _2154_left;
          bool _2155___v78;
          bool _2156_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2157_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1415;
          bool _out1416;
          bool _out1417;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
          DCOMP.COMP.GenExpr(_2152_l, selfIdent, @params, true, out _out1415, out _out1416, out _out1417, out _out1418);
          _2154_left = _out1415;
          _2155___v78 = _out1416;
          _2156_leftErased = _out1417;
          _2157_recIdentsL = _out1418;
          Dafny.ISequence<Dafny.Rune> _2158_right;
          bool _2159___v79;
          bool _2160_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2161_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1419;
          bool _out1420;
          bool _out1421;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
          DCOMP.COMP.GenExpr(_2151_r, selfIdent, @params, true, out _out1419, out _out1420, out _out1421, out _out1422);
          _2158_right = _out1419;
          _2159___v79 = _out1420;
          _2160_rightErased = _out1421;
          _2161_recIdentsR = _out1422;
          if (!(_2156_leftErased)) {
            _2154_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2154_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2160_rightErased)) {
            _2158_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2158_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2153_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2154_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2158_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2153_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2154_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2158_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2154_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2153_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2158_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2157_recIdentsL, _2161_recIdentsR);
          isErased = true;
        }
      } else if (_source21.is_ArrayLen) {
        DAST._IExpression _2162___mcc_h33 = _source21.dtor_expr;
        DAST._IExpression _2163_expr = _2162___mcc_h33;
        {
          Dafny.ISequence<Dafny.Rune> _2164_recursiveGen;
          bool _2165___v80;
          bool _2166_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2167_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1423;
          bool _out1424;
          bool _out1425;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1426;
          DCOMP.COMP.GenExpr(_2163_expr, selfIdent, @params, true, out _out1423, out _out1424, out _out1425, out _out1426);
          _2164_recursiveGen = _out1423;
          _2165___v80 = _out1424;
          _2166_recErased = _out1425;
          _2167_recIdents = _out1426;
          if (!(_2166_recErased)) {
            _2164_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2164_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2164_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow().len())"));
          isOwned = true;
          readIdents = _2167_recIdents;
          isErased = true;
        }
      } else if (_source21.is_Select) {
        DAST._IExpression _2168___mcc_h34 = _source21.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2169___mcc_h35 = _source21.dtor_field;
        bool _2170___mcc_h36 = _source21.dtor_isConstant;
        bool _2171___mcc_h37 = _source21.dtor_onDatatype;
        DAST._IExpression _source73 = _2168___mcc_h34;
        if (_source73.is_Literal) {
          DAST._ILiteral _2172___mcc_h38 = _source73.dtor_Literal_a0;
          bool _2173_isDatatype = _2171___mcc_h37;
          bool _2174_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2175_field = _2169___mcc_h35;
          DAST._IExpression _2176_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2177_onString;
            bool _2178_onOwned;
            bool _2179_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2180_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1427;
            bool _out1428;
            bool _out1429;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1430;
            DCOMP.COMP.GenExpr(_2176_on, selfIdent, @params, false, out _out1427, out _out1428, out _out1429, out _out1430);
            _2177_onString = _out1427;
            _2178_onOwned = _out1428;
            _2179_onErased = _out1429;
            _2180_recIdents = _out1430;
            if (!(_2179_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2181_eraseFn;
              _2181_eraseFn = ((_2178_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2177_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2181_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2177_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2173_isDatatype) || (_2174_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2177_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2175_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2174_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2177_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2175_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2180_recIdents;
          }
        } else if (_source73.is_Ident) {
          Dafny.ISequence<Dafny.Rune> _2182___mcc_h40 = _source73.dtor_Ident_a0;
          bool _2183_isDatatype = _2171___mcc_h37;
          bool _2184_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2185_field = _2169___mcc_h35;
          DAST._IExpression _2186_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2187_onString;
            bool _2188_onOwned;
            bool _2189_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2190_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1431;
            bool _out1432;
            bool _out1433;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1434;
            DCOMP.COMP.GenExpr(_2186_on, selfIdent, @params, false, out _out1431, out _out1432, out _out1433, out _out1434);
            _2187_onString = _out1431;
            _2188_onOwned = _out1432;
            _2189_onErased = _out1433;
            _2190_recIdents = _out1434;
            if (!(_2189_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2191_eraseFn;
              _2191_eraseFn = ((_2188_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2187_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2191_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2187_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2183_isDatatype) || (_2184_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2187_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2185_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2184_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2187_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2185_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2190_recIdents;
          }
        } else if (_source73.is_Companion) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2192___mcc_h42 = _source73.dtor_Companion_a0;
          bool _2193_isDatatype = _2171___mcc_h37;
          bool _2194_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2195_field = _2169___mcc_h35;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2196_c = _2192___mcc_h42;
          {
            Dafny.ISequence<Dafny.Rune> _2197_onString;
            bool _2198_onOwned;
            bool _2199_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2200_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1435;
            bool _out1436;
            bool _out1437;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1438;
            DCOMP.COMP.GenExpr(DAST.Expression.create_Companion(_2196_c), selfIdent, @params, false, out _out1435, out _out1436, out _out1437, out _out1438);
            _2197_onString = _out1435;
            _2198_onOwned = _out1436;
            _2199_onErased = _out1437;
            _2200_recIdents = _out1438;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2197_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2195_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            isOwned = true;
            isErased = false;
            readIdents = _2200_recIdents;
          }
        } else if (_source73.is_Tuple) {
          Dafny.ISequence<DAST._IExpression> _2201___mcc_h44 = _source73.dtor_Tuple_a0;
          bool _2202_isDatatype = _2171___mcc_h37;
          bool _2203_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2204_field = _2169___mcc_h35;
          DAST._IExpression _2205_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2206_onString;
            bool _2207_onOwned;
            bool _2208_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2209_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1439;
            bool _out1440;
            bool _out1441;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1442;
            DCOMP.COMP.GenExpr(_2205_on, selfIdent, @params, false, out _out1439, out _out1440, out _out1441, out _out1442);
            _2206_onString = _out1439;
            _2207_onOwned = _out1440;
            _2208_onErased = _out1441;
            _2209_recIdents = _out1442;
            if (!(_2208_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2210_eraseFn;
              _2210_eraseFn = ((_2207_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2206_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2210_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2206_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2202_isDatatype) || (_2203_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2206_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2204_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2203_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2206_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2204_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2209_recIdents;
          }
        } else if (_source73.is_New) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2211___mcc_h46 = _source73.dtor_path;
          Dafny.ISequence<DAST._IExpression> _2212___mcc_h47 = _source73.dtor_args;
          bool _2213_isDatatype = _2171___mcc_h37;
          bool _2214_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2215_field = _2169___mcc_h35;
          DAST._IExpression _2216_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2217_onString;
            bool _2218_onOwned;
            bool _2219_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2220_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1443;
            bool _out1444;
            bool _out1445;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1446;
            DCOMP.COMP.GenExpr(_2216_on, selfIdent, @params, false, out _out1443, out _out1444, out _out1445, out _out1446);
            _2217_onString = _out1443;
            _2218_onOwned = _out1444;
            _2219_onErased = _out1445;
            _2220_recIdents = _out1446;
            if (!(_2219_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2221_eraseFn;
              _2221_eraseFn = ((_2218_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2217_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2221_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2217_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2213_isDatatype) || (_2214_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2217_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2215_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2214_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2217_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2215_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2220_recIdents;
          }
        } else if (_source73.is_NewArray) {
          Dafny.ISequence<DAST._IExpression> _2222___mcc_h50 = _source73.dtor_dims;
          bool _2223_isDatatype = _2171___mcc_h37;
          bool _2224_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2225_field = _2169___mcc_h35;
          DAST._IExpression _2226_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2227_onString;
            bool _2228_onOwned;
            bool _2229_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2230_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1447;
            bool _out1448;
            bool _out1449;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1450;
            DCOMP.COMP.GenExpr(_2226_on, selfIdent, @params, false, out _out1447, out _out1448, out _out1449, out _out1450);
            _2227_onString = _out1447;
            _2228_onOwned = _out1448;
            _2229_onErased = _out1449;
            _2230_recIdents = _out1450;
            if (!(_2229_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2231_eraseFn;
              _2231_eraseFn = ((_2228_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2227_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2231_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2227_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2223_isDatatype) || (_2224_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2227_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2225_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2224_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2227_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2225_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2230_recIdents;
          }
        } else if (_source73.is_DatatypeValue) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2232___mcc_h52 = _source73.dtor_path;
          Dafny.ISequence<Dafny.Rune> _2233___mcc_h53 = _source73.dtor_variant;
          bool _2234___mcc_h54 = _source73.dtor_isCo;
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2235___mcc_h55 = _source73.dtor_contents;
          bool _2236_isDatatype = _2171___mcc_h37;
          bool _2237_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2238_field = _2169___mcc_h35;
          DAST._IExpression _2239_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2240_onString;
            bool _2241_onOwned;
            bool _2242_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2243_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1451;
            bool _out1452;
            bool _out1453;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1454;
            DCOMP.COMP.GenExpr(_2239_on, selfIdent, @params, false, out _out1451, out _out1452, out _out1453, out _out1454);
            _2240_onString = _out1451;
            _2241_onOwned = _out1452;
            _2242_onErased = _out1453;
            _2243_recIdents = _out1454;
            if (!(_2242_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2244_eraseFn;
              _2244_eraseFn = ((_2241_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2240_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2244_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2240_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2236_isDatatype) || (_2237_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2240_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2238_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2237_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2240_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2238_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2243_recIdents;
          }
        } else if (_source73.is_Convert) {
          DAST._IExpression _2245___mcc_h60 = _source73.dtor_value;
          DAST._IType _2246___mcc_h61 = _source73.dtor_from;
          DAST._IType _2247___mcc_h62 = _source73.dtor_typ;
          bool _2248_isDatatype = _2171___mcc_h37;
          bool _2249_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2250_field = _2169___mcc_h35;
          DAST._IExpression _2251_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2252_onString;
            bool _2253_onOwned;
            bool _2254_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2255_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1455;
            bool _out1456;
            bool _out1457;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1458;
            DCOMP.COMP.GenExpr(_2251_on, selfIdent, @params, false, out _out1455, out _out1456, out _out1457, out _out1458);
            _2252_onString = _out1455;
            _2253_onOwned = _out1456;
            _2254_onErased = _out1457;
            _2255_recIdents = _out1458;
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
        } else if (_source73.is_SeqValue) {
          Dafny.ISequence<DAST._IExpression> _2257___mcc_h66 = _source73.dtor_elements;
          bool _2258_isDatatype = _2171___mcc_h37;
          bool _2259_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2260_field = _2169___mcc_h35;
          DAST._IExpression _2261_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2262_onString;
            bool _2263_onOwned;
            bool _2264_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2265_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1459;
            bool _out1460;
            bool _out1461;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1462;
            DCOMP.COMP.GenExpr(_2261_on, selfIdent, @params, false, out _out1459, out _out1460, out _out1461, out _out1462);
            _2262_onString = _out1459;
            _2263_onOwned = _out1460;
            _2264_onErased = _out1461;
            _2265_recIdents = _out1462;
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
        } else if (_source73.is_SetValue) {
          Dafny.ISequence<DAST._IExpression> _2267___mcc_h68 = _source73.dtor_elements;
          bool _2268_isDatatype = _2171___mcc_h37;
          bool _2269_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2270_field = _2169___mcc_h35;
          DAST._IExpression _2271_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2272_onString;
            bool _2273_onOwned;
            bool _2274_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2275_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1463;
            bool _out1464;
            bool _out1465;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1466;
            DCOMP.COMP.GenExpr(_2271_on, selfIdent, @params, false, out _out1463, out _out1464, out _out1465, out _out1466);
            _2272_onString = _out1463;
            _2273_onOwned = _out1464;
            _2274_onErased = _out1465;
            _2275_recIdents = _out1466;
            if (!(_2274_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2276_eraseFn;
              _2276_eraseFn = ((_2273_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2272_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2276_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2272_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2268_isDatatype) || (_2269_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2272_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2270_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2269_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2272_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2270_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2275_recIdents;
          }
        } else if (_source73.is_MapValue) {
          Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2277___mcc_h70 = _source73.dtor_mapElems;
          bool _2278_isDatatype = _2171___mcc_h37;
          bool _2279_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2280_field = _2169___mcc_h35;
          DAST._IExpression _2281_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2282_onString;
            bool _2283_onOwned;
            bool _2284_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2285_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1467;
            bool _out1468;
            bool _out1469;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1470;
            DCOMP.COMP.GenExpr(_2281_on, selfIdent, @params, false, out _out1467, out _out1468, out _out1469, out _out1470);
            _2282_onString = _out1467;
            _2283_onOwned = _out1468;
            _2284_onErased = _out1469;
            _2285_recIdents = _out1470;
            if (!(_2284_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2286_eraseFn;
              _2286_eraseFn = ((_2283_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2282_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2286_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2282_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2278_isDatatype) || (_2279_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2282_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2280_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2279_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2282_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2280_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2285_recIdents;
          }
        } else if (_source73.is_This) {
          bool _2287_isDatatype = _2171___mcc_h37;
          bool _2288_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2289_field = _2169___mcc_h35;
          DAST._IExpression _2290_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2291_onString;
            bool _2292_onOwned;
            bool _2293_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2294_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1471;
            bool _out1472;
            bool _out1473;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1474;
            DCOMP.COMP.GenExpr(_2290_on, selfIdent, @params, false, out _out1471, out _out1472, out _out1473, out _out1474);
            _2291_onString = _out1471;
            _2292_onOwned = _out1472;
            _2293_onErased = _out1473;
            _2294_recIdents = _out1474;
            if (!(_2293_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2295_eraseFn;
              _2295_eraseFn = ((_2292_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2291_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2295_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2291_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2287_isDatatype) || (_2288_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2291_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2289_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2288_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2291_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2289_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2294_recIdents;
          }
        } else if (_source73.is_Ite) {
          DAST._IExpression _2296___mcc_h72 = _source73.dtor_cond;
          DAST._IExpression _2297___mcc_h73 = _source73.dtor_thn;
          DAST._IExpression _2298___mcc_h74 = _source73.dtor_els;
          bool _2299_isDatatype = _2171___mcc_h37;
          bool _2300_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2301_field = _2169___mcc_h35;
          DAST._IExpression _2302_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2303_onString;
            bool _2304_onOwned;
            bool _2305_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2306_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1475;
            bool _out1476;
            bool _out1477;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1478;
            DCOMP.COMP.GenExpr(_2302_on, selfIdent, @params, false, out _out1475, out _out1476, out _out1477, out _out1478);
            _2303_onString = _out1475;
            _2304_onOwned = _out1476;
            _2305_onErased = _out1477;
            _2306_recIdents = _out1478;
            if (!(_2305_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2307_eraseFn;
              _2307_eraseFn = ((_2304_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2303_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2307_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2303_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2299_isDatatype) || (_2300_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2303_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2301_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2300_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2303_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2301_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2306_recIdents;
          }
        } else if (_source73.is_UnOp) {
          DAST._IUnaryOp _2308___mcc_h78 = _source73.dtor_unOp;
          DAST._IExpression _2309___mcc_h79 = _source73.dtor_expr;
          bool _2310_isDatatype = _2171___mcc_h37;
          bool _2311_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2312_field = _2169___mcc_h35;
          DAST._IExpression _2313_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2314_onString;
            bool _2315_onOwned;
            bool _2316_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2317_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1479;
            bool _out1480;
            bool _out1481;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1482;
            DCOMP.COMP.GenExpr(_2313_on, selfIdent, @params, false, out _out1479, out _out1480, out _out1481, out _out1482);
            _2314_onString = _out1479;
            _2315_onOwned = _out1480;
            _2316_onErased = _out1481;
            _2317_recIdents = _out1482;
            if (!(_2316_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2318_eraseFn;
              _2318_eraseFn = ((_2315_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2314_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2318_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2314_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2310_isDatatype) || (_2311_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2314_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2312_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2311_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2314_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2312_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2317_recIdents;
          }
        } else if (_source73.is_BinOp) {
          Dafny.ISequence<Dafny.Rune> _2319___mcc_h82 = _source73.dtor_op;
          DAST._IExpression _2320___mcc_h83 = _source73.dtor_left;
          DAST._IExpression _2321___mcc_h84 = _source73.dtor_right;
          bool _2322_isDatatype = _2171___mcc_h37;
          bool _2323_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2324_field = _2169___mcc_h35;
          DAST._IExpression _2325_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2326_onString;
            bool _2327_onOwned;
            bool _2328_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2329_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1483;
            bool _out1484;
            bool _out1485;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1486;
            DCOMP.COMP.GenExpr(_2325_on, selfIdent, @params, false, out _out1483, out _out1484, out _out1485, out _out1486);
            _2326_onString = _out1483;
            _2327_onOwned = _out1484;
            _2328_onErased = _out1485;
            _2329_recIdents = _out1486;
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
        } else if (_source73.is_ArrayLen) {
          DAST._IExpression _2331___mcc_h88 = _source73.dtor_expr;
          bool _2332_isDatatype = _2171___mcc_h37;
          bool _2333_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2334_field = _2169___mcc_h35;
          DAST._IExpression _2335_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2336_onString;
            bool _2337_onOwned;
            bool _2338_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2339_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1487;
            bool _out1488;
            bool _out1489;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1490;
            DCOMP.COMP.GenExpr(_2335_on, selfIdent, @params, false, out _out1487, out _out1488, out _out1489, out _out1490);
            _2336_onString = _out1487;
            _2337_onOwned = _out1488;
            _2338_onErased = _out1489;
            _2339_recIdents = _out1490;
            if (!(_2338_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2340_eraseFn;
              _2340_eraseFn = ((_2337_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2336_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2340_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2336_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2332_isDatatype) || (_2333_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2336_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2334_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2333_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2336_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2334_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2339_recIdents;
          }
        } else if (_source73.is_Select) {
          DAST._IExpression _2341___mcc_h90 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2342___mcc_h91 = _source73.dtor_field;
          bool _2343___mcc_h92 = _source73.dtor_isConstant;
          bool _2344___mcc_h93 = _source73.dtor_onDatatype;
          bool _2345_isDatatype = _2171___mcc_h37;
          bool _2346_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2347_field = _2169___mcc_h35;
          DAST._IExpression _2348_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2349_onString;
            bool _2350_onOwned;
            bool _2351_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2352_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1491;
            bool _out1492;
            bool _out1493;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1494;
            DCOMP.COMP.GenExpr(_2348_on, selfIdent, @params, false, out _out1491, out _out1492, out _out1493, out _out1494);
            _2349_onString = _out1491;
            _2350_onOwned = _out1492;
            _2351_onErased = _out1493;
            _2352_recIdents = _out1494;
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
        } else if (_source73.is_SelectFn) {
          DAST._IExpression _2354___mcc_h98 = _source73.dtor_expr;
          Dafny.ISequence<Dafny.Rune> _2355___mcc_h99 = _source73.dtor_field;
          bool _2356___mcc_h100 = _source73.dtor_onDatatype;
          bool _2357___mcc_h101 = _source73.dtor_isStatic;
          BigInteger _2358___mcc_h102 = _source73.dtor_arity;
          bool _2359_isDatatype = _2171___mcc_h37;
          bool _2360_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2361_field = _2169___mcc_h35;
          DAST._IExpression _2362_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2363_onString;
            bool _2364_onOwned;
            bool _2365_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2366_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1495;
            bool _out1496;
            bool _out1497;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1498;
            DCOMP.COMP.GenExpr(_2362_on, selfIdent, @params, false, out _out1495, out _out1496, out _out1497, out _out1498);
            _2363_onString = _out1495;
            _2364_onOwned = _out1496;
            _2365_onErased = _out1497;
            _2366_recIdents = _out1498;
            if (!(_2365_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2367_eraseFn;
              _2367_eraseFn = ((_2364_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2363_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2367_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2363_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2359_isDatatype) || (_2360_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2363_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2361_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2360_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2363_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2361_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2366_recIdents;
          }
        } else if (_source73.is_Index) {
          DAST._IExpression _2368___mcc_h108 = _source73.dtor_expr;
          DAST._ICollKind _2369___mcc_h109 = _source73.dtor_collKind;
          Dafny.ISequence<DAST._IExpression> _2370___mcc_h110 = _source73.dtor_indices;
          bool _2371_isDatatype = _2171___mcc_h37;
          bool _2372_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2373_field = _2169___mcc_h35;
          DAST._IExpression _2374_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2375_onString;
            bool _2376_onOwned;
            bool _2377_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2378_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1499;
            bool _out1500;
            bool _out1501;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1502;
            DCOMP.COMP.GenExpr(_2374_on, selfIdent, @params, false, out _out1499, out _out1500, out _out1501, out _out1502);
            _2375_onString = _out1499;
            _2376_onOwned = _out1500;
            _2377_onErased = _out1501;
            _2378_recIdents = _out1502;
            if (!(_2377_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2379_eraseFn;
              _2379_eraseFn = ((_2376_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2375_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2379_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2375_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2371_isDatatype) || (_2372_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2375_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2373_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2372_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2375_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2373_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2378_recIdents;
          }
        } else if (_source73.is_IndexRange) {
          DAST._IExpression _2380___mcc_h114 = _source73.dtor_expr;
          bool _2381___mcc_h115 = _source73.dtor_isArray;
          DAST._IOptional<DAST._IExpression> _2382___mcc_h116 = _source73.dtor_low;
          DAST._IOptional<DAST._IExpression> _2383___mcc_h117 = _source73.dtor_high;
          bool _2384_isDatatype = _2171___mcc_h37;
          bool _2385_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2386_field = _2169___mcc_h35;
          DAST._IExpression _2387_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2388_onString;
            bool _2389_onOwned;
            bool _2390_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2391_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1503;
            bool _out1504;
            bool _out1505;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1506;
            DCOMP.COMP.GenExpr(_2387_on, selfIdent, @params, false, out _out1503, out _out1504, out _out1505, out _out1506);
            _2388_onString = _out1503;
            _2389_onOwned = _out1504;
            _2390_onErased = _out1505;
            _2391_recIdents = _out1506;
            if (!(_2390_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2392_eraseFn;
              _2392_eraseFn = ((_2389_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2388_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2392_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2388_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2384_isDatatype) || (_2385_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2388_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2386_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2385_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2388_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2386_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2391_recIdents;
          }
        } else if (_source73.is_TupleSelect) {
          DAST._IExpression _2393___mcc_h122 = _source73.dtor_expr;
          BigInteger _2394___mcc_h123 = _source73.dtor_index;
          bool _2395_isDatatype = _2171___mcc_h37;
          bool _2396_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2397_field = _2169___mcc_h35;
          DAST._IExpression _2398_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2399_onString;
            bool _2400_onOwned;
            bool _2401_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2402_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1507;
            bool _out1508;
            bool _out1509;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1510;
            DCOMP.COMP.GenExpr(_2398_on, selfIdent, @params, false, out _out1507, out _out1508, out _out1509, out _out1510);
            _2399_onString = _out1507;
            _2400_onOwned = _out1508;
            _2401_onErased = _out1509;
            _2402_recIdents = _out1510;
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
        } else if (_source73.is_Call) {
          DAST._IExpression _2404___mcc_h126 = _source73.dtor_on;
          Dafny.ISequence<Dafny.Rune> _2405___mcc_h127 = _source73.dtor_name;
          Dafny.ISequence<DAST._IType> _2406___mcc_h128 = _source73.dtor_typeArgs;
          Dafny.ISequence<DAST._IExpression> _2407___mcc_h129 = _source73.dtor_args;
          bool _2408_isDatatype = _2171___mcc_h37;
          bool _2409_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2410_field = _2169___mcc_h35;
          DAST._IExpression _2411_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2412_onString;
            bool _2413_onOwned;
            bool _2414_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2415_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1511;
            bool _out1512;
            bool _out1513;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1514;
            DCOMP.COMP.GenExpr(_2411_on, selfIdent, @params, false, out _out1511, out _out1512, out _out1513, out _out1514);
            _2412_onString = _out1511;
            _2413_onOwned = _out1512;
            _2414_onErased = _out1513;
            _2415_recIdents = _out1514;
            if (!(_2414_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2416_eraseFn;
              _2416_eraseFn = ((_2413_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2412_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2416_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2412_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2408_isDatatype) || (_2409_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2412_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2410_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2409_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2412_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2410_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2415_recIdents;
          }
        } else if (_source73.is_Lambda) {
          Dafny.ISequence<DAST._IFormal> _2417___mcc_h134 = _source73.dtor_params;
          DAST._IType _2418___mcc_h135 = _source73.dtor_retType;
          Dafny.ISequence<DAST._IStatement> _2419___mcc_h136 = _source73.dtor_body;
          bool _2420_isDatatype = _2171___mcc_h37;
          bool _2421_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2422_field = _2169___mcc_h35;
          DAST._IExpression _2423_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2424_onString;
            bool _2425_onOwned;
            bool _2426_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2427_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1515;
            bool _out1516;
            bool _out1517;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1518;
            DCOMP.COMP.GenExpr(_2423_on, selfIdent, @params, false, out _out1515, out _out1516, out _out1517, out _out1518);
            _2424_onString = _out1515;
            _2425_onOwned = _out1516;
            _2426_onErased = _out1517;
            _2427_recIdents = _out1518;
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
        } else if (_source73.is_BetaRedex) {
          Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2429___mcc_h140 = _source73.dtor_values;
          DAST._IType _2430___mcc_h141 = _source73.dtor_retType;
          DAST._IExpression _2431___mcc_h142 = _source73.dtor_expr;
          bool _2432_isDatatype = _2171___mcc_h37;
          bool _2433_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2434_field = _2169___mcc_h35;
          DAST._IExpression _2435_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2436_onString;
            bool _2437_onOwned;
            bool _2438_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2439_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1519;
            bool _out1520;
            bool _out1521;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1522;
            DCOMP.COMP.GenExpr(_2435_on, selfIdent, @params, false, out _out1519, out _out1520, out _out1521, out _out1522);
            _2436_onString = _out1519;
            _2437_onOwned = _out1520;
            _2438_onErased = _out1521;
            _2439_recIdents = _out1522;
            if (!(_2438_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2440_eraseFn;
              _2440_eraseFn = ((_2437_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2436_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2440_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2436_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2432_isDatatype) || (_2433_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2436_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2434_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2433_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2436_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2434_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2439_recIdents;
          }
        } else if (_source73.is_IIFE) {
          Dafny.ISequence<Dafny.Rune> _2441___mcc_h146 = _source73.dtor_name;
          DAST._IType _2442___mcc_h147 = _source73.dtor_typ;
          DAST._IExpression _2443___mcc_h148 = _source73.dtor_value;
          DAST._IExpression _2444___mcc_h149 = _source73.dtor_iifeBody;
          bool _2445_isDatatype = _2171___mcc_h37;
          bool _2446_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2447_field = _2169___mcc_h35;
          DAST._IExpression _2448_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2449_onString;
            bool _2450_onOwned;
            bool _2451_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2452_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1523;
            bool _out1524;
            bool _out1525;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1526;
            DCOMP.COMP.GenExpr(_2448_on, selfIdent, @params, false, out _out1523, out _out1524, out _out1525, out _out1526);
            _2449_onString = _out1523;
            _2450_onOwned = _out1524;
            _2451_onErased = _out1525;
            _2452_recIdents = _out1526;
            if (!(_2451_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2453_eraseFn;
              _2453_eraseFn = ((_2450_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2449_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2453_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2449_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2445_isDatatype) || (_2446_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2449_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2447_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2446_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2449_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2447_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2452_recIdents;
          }
        } else if (_source73.is_Apply) {
          DAST._IExpression _2454___mcc_h154 = _source73.dtor_expr;
          Dafny.ISequence<DAST._IExpression> _2455___mcc_h155 = _source73.dtor_args;
          bool _2456_isDatatype = _2171___mcc_h37;
          bool _2457_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2458_field = _2169___mcc_h35;
          DAST._IExpression _2459_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2460_onString;
            bool _2461_onOwned;
            bool _2462_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2463_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1527;
            bool _out1528;
            bool _out1529;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1530;
            DCOMP.COMP.GenExpr(_2459_on, selfIdent, @params, false, out _out1527, out _out1528, out _out1529, out _out1530);
            _2460_onString = _out1527;
            _2461_onOwned = _out1528;
            _2462_onErased = _out1529;
            _2463_recIdents = _out1530;
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
        } else if (_source73.is_TypeTest) {
          DAST._IExpression _2465___mcc_h158 = _source73.dtor_on;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2466___mcc_h159 = _source73.dtor_dType;
          Dafny.ISequence<Dafny.Rune> _2467___mcc_h160 = _source73.dtor_variant;
          bool _2468_isDatatype = _2171___mcc_h37;
          bool _2469_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2470_field = _2169___mcc_h35;
          DAST._IExpression _2471_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2472_onString;
            bool _2473_onOwned;
            bool _2474_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2475_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1531;
            bool _out1532;
            bool _out1533;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1534;
            DCOMP.COMP.GenExpr(_2471_on, selfIdent, @params, false, out _out1531, out _out1532, out _out1533, out _out1534);
            _2472_onString = _out1531;
            _2473_onOwned = _out1532;
            _2474_onErased = _out1533;
            _2475_recIdents = _out1534;
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
        } else if (_source73.is_InitializationValue) {
          DAST._IType _2477___mcc_h164 = _source73.dtor_typ;
          bool _2478_isDatatype = _2171___mcc_h37;
          bool _2479_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2480_field = _2169___mcc_h35;
          DAST._IExpression _2481_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2482_onString;
            bool _2483_onOwned;
            bool _2484_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2485_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1535;
            bool _out1536;
            bool _out1537;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1538;
            DCOMP.COMP.GenExpr(_2481_on, selfIdent, @params, false, out _out1535, out _out1536, out _out1537, out _out1538);
            _2482_onString = _out1535;
            _2483_onOwned = _out1536;
            _2484_onErased = _out1537;
            _2485_recIdents = _out1538;
            if (!(_2484_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2486_eraseFn;
              _2486_eraseFn = ((_2483_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2482_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2486_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2482_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2478_isDatatype) || (_2479_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2482_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2480_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2479_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2482_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2480_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2485_recIdents;
          }
        } else {
          bool _2487_isDatatype = _2171___mcc_h37;
          bool _2488_isConstant = _2170___mcc_h36;
          Dafny.ISequence<Dafny.Rune> _2489_field = _2169___mcc_h35;
          DAST._IExpression _2490_on = _2168___mcc_h34;
          {
            Dafny.ISequence<Dafny.Rune> _2491_onString;
            bool _2492_onOwned;
            bool _2493_onErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2494_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1539;
            bool _out1540;
            bool _out1541;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1542;
            DCOMP.COMP.GenExpr(_2490_on, selfIdent, @params, false, out _out1539, out _out1540, out _out1541, out _out1542);
            _2491_onString = _out1539;
            _2492_onOwned = _out1540;
            _2493_onErased = _out1541;
            _2494_recIdents = _out1542;
            if (!(_2493_onErased)) {
              Dafny.ISequence<Dafny.Rune> _2495_eraseFn;
              _2495_eraseFn = ((_2492_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2491_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2495_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2491_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if ((_2487_isDatatype) || (_2488_isConstant)) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2491_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2489_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
              if (_2488_isConstant) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
              }
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
                isOwned = true;
              } else {
                isOwned = false;
              }
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2491_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2489_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            }
            isErased = false;
            readIdents = _2494_recIdents;
          }
        }
      } else if (_source21.is_SelectFn) {
        DAST._IExpression _2496___mcc_h166 = _source21.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2497___mcc_h167 = _source21.dtor_field;
        bool _2498___mcc_h168 = _source21.dtor_onDatatype;
        bool _2499___mcc_h169 = _source21.dtor_isStatic;
        BigInteger _2500___mcc_h170 = _source21.dtor_arity;
        BigInteger _2501_arity = _2500___mcc_h170;
        bool _2502_isStatic = _2499___mcc_h169;
        bool _2503_isDatatype = _2498___mcc_h168;
        Dafny.ISequence<Dafny.Rune> _2504_field = _2497___mcc_h167;
        DAST._IExpression _2505_on = _2496___mcc_h166;
        {
          Dafny.ISequence<Dafny.Rune> _2506_onString;
          bool _2507_onOwned;
          bool _2508___v81;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2509_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1543;
          bool _out1544;
          bool _out1545;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1546;
          DCOMP.COMP.GenExpr(_2505_on, selfIdent, @params, false, out _out1543, out _out1544, out _out1545, out _out1546);
          _2506_onString = _out1543;
          _2507_onOwned = _out1544;
          _2508___v81 = _out1545;
          _2509_recIdents = _out1546;
          if (_2502_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2506_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2504_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2506_onString), ((_2507_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2510_args;
            _2510_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2511_i;
            _2511_i = BigInteger.Zero;
            while ((_2511_i) < (_2501_arity)) {
              if ((_2511_i).Sign == 1) {
                _2510_args = Dafny.Sequence<Dafny.Rune>.Concat(_2510_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2510_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2510_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2511_i));
              _2511_i = (_2511_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2510_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2504_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2510_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper(::std::rc::Rc::new("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
          readIdents = _2509_recIdents;
        }
      } else if (_source21.is_Index) {
        DAST._IExpression _2512___mcc_h171 = _source21.dtor_expr;
        DAST._ICollKind _2513___mcc_h172 = _source21.dtor_collKind;
        Dafny.ISequence<DAST._IExpression> _2514___mcc_h173 = _source21.dtor_indices;
        Dafny.ISequence<DAST._IExpression> _2515_indices = _2514___mcc_h173;
        DAST._ICollKind _2516_collKind = _2513___mcc_h172;
        DAST._IExpression _2517_on = _2512___mcc_h171;
        {
          Dafny.ISequence<Dafny.Rune> _2518_onString;
          bool _2519_onOwned;
          bool _2520_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2521_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1547;
          bool _out1548;
          bool _out1549;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1550;
          DCOMP.COMP.GenExpr(_2517_on, selfIdent, @params, false, out _out1547, out _out1548, out _out1549, out _out1550);
          _2518_onString = _out1547;
          _2519_onOwned = _out1548;
          _2520_onErased = _out1549;
          _2521_recIdents = _out1550;
          readIdents = _2521_recIdents;
          if (!(_2520_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2522_eraseFn;
            _2522_eraseFn = ((_2519_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2518_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2522_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2518_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2518_onString;
          BigInteger _2523_i;
          _2523_i = BigInteger.Zero;
          while ((_2523_i) < (new BigInteger((_2515_indices).Count))) {
            if (object.Equals(_2516_collKind, DAST.CollKind.create_Array())) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
            }
            if (object.Equals(_2516_collKind, DAST.CollKind.create_Map())) {
              Dafny.ISequence<Dafny.Rune> _2524_idx;
              bool _2525_idxOwned;
              bool _2526_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2527_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1551;
              bool _out1552;
              bool _out1553;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1554;
              DCOMP.COMP.GenExpr((_2515_indices).Select(_2523_i), selfIdent, @params, false, out _out1551, out _out1552, out _out1553, out _out1554);
              _2524_idx = _out1551;
              _2525_idxOwned = _out1552;
              _2526_idxErased = _out1553;
              _2527_recIdentsIdx = _out1554;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[")), ((_2525_idxOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _2524_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2527_recIdentsIdx);
            } else {
              Dafny.ISequence<Dafny.Rune> _2528_idx;
              bool _2529___v82;
              bool _2530_idxErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2531_recIdentsIdx;
              Dafny.ISequence<Dafny.Rune> _out1555;
              bool _out1556;
              bool _out1557;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1558;
              DCOMP.COMP.GenExpr((_2515_indices).Select(_2523_i), selfIdent, @params, true, out _out1555, out _out1556, out _out1557, out _out1558);
              _2528_idx = _out1555;
              _2529___v82 = _out1556;
              _2530_idxErased = _out1557;
              _2531_recIdentsIdx = _out1558;
              if (!(_2530_idxErased)) {
                _2528_idx = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2528_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")[<usize as ::dafny_runtime::NumCast>::from(")), _2528_idx), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2531_recIdentsIdx);
            }
            _2523_i = (_2523_i) + (BigInteger.One);
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = _2520_onErased;
        }
      } else if (_source21.is_IndexRange) {
        DAST._IExpression _2532___mcc_h174 = _source21.dtor_expr;
        bool _2533___mcc_h175 = _source21.dtor_isArray;
        DAST._IOptional<DAST._IExpression> _2534___mcc_h176 = _source21.dtor_low;
        DAST._IOptional<DAST._IExpression> _2535___mcc_h177 = _source21.dtor_high;
        DAST._IOptional<DAST._IExpression> _2536_high = _2535___mcc_h177;
        DAST._IOptional<DAST._IExpression> _2537_low = _2534___mcc_h176;
        bool _2538_isArray = _2533___mcc_h175;
        DAST._IExpression _2539_on = _2532___mcc_h174;
        {
          Dafny.ISequence<Dafny.Rune> _2540_onString;
          bool _2541_onOwned;
          bool _2542_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2543_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1559;
          bool _out1560;
          bool _out1561;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1562;
          DCOMP.COMP.GenExpr(_2539_on, selfIdent, @params, false, out _out1559, out _out1560, out _out1561, out _out1562);
          _2540_onString = _out1559;
          _2541_onOwned = _out1560;
          _2542_onErased = _out1561;
          _2543_recIdents = _out1562;
          readIdents = _2543_recIdents;
          if (!(_2542_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2544_eraseFn;
            _2544_eraseFn = ((_2541_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2540_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2544_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2540_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = _2540_onString;
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2545_lowString;
          _2545_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source74 = _2537_low;
          if (_source74.is_Some) {
            DAST._IExpression _2546___mcc_h1067 = _source74.dtor_Some_a0;
            DAST._IExpression _2547_l = _2546___mcc_h1067;
            {
              Dafny.ISequence<Dafny.Rune> _2548_lString;
              bool _2549___v83;
              bool _2550_lErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2551_recIdentsL;
              Dafny.ISequence<Dafny.Rune> _out1563;
              bool _out1564;
              bool _out1565;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1566;
              DCOMP.COMP.GenExpr(_2547_l, selfIdent, @params, true, out _out1563, out _out1564, out _out1565, out _out1566);
              _2548_lString = _out1563;
              _2549___v83 = _out1564;
              _2550_lErased = _out1565;
              _2551_recIdentsL = _out1566;
              if (!(_2550_lErased)) {
                _2548_lString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2548_lString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2545_lowString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2548_lString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2551_recIdentsL);
            }
          } else {
          }
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _2552_highString;
          _2552_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None();
          DAST._IOptional<DAST._IExpression> _source75 = _2536_high;
          if (_source75.is_Some) {
            DAST._IExpression _2553___mcc_h1068 = _source75.dtor_Some_a0;
            DAST._IExpression _2554_h = _2553___mcc_h1068;
            {
              Dafny.ISequence<Dafny.Rune> _2555_hString;
              bool _2556___v84;
              bool _2557_hErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2558_recIdentsH;
              Dafny.ISequence<Dafny.Rune> _out1567;
              bool _out1568;
              bool _out1569;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1570;
              DCOMP.COMP.GenExpr(_2554_h, selfIdent, @params, true, out _out1567, out _out1568, out _out1569, out _out1570);
              _2555_hString = _out1567;
              _2556___v84 = _out1568;
              _2557_hErased = _out1569;
              _2558_recIdentsH = _out1570;
              if (!(_2557_hErased)) {
                _2555_hString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2555_hString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _2552_highString = DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(_2555_hString);
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2558_recIdentsH);
            }
          } else {
          }
          if (_2538_isArray) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").borrow()"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source76) => {
            if (_source76.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2559___mcc_h1069 = _source76.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2559___mcc_h1069, _pat_let0_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let0_0, _2560_l => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2560_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2545_lowString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("..")), ((System.Func<DAST._IOptional<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>)((_source77) => {
            if (_source77.is_Some) {
              Dafny.ISequence<Dafny.Rune> _2561___mcc_h1070 = _source77.dtor_Some_a0;
              return Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_2561___mcc_h1070, _pat_let1_0 => Dafny.Helpers.Let<Dafny.ISequence<Dafny.Rune>, Dafny.ISequence<Dafny.Rune>>(_pat_let1_0, _2562_h => Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<usize as ::dafny_runtime::NumCast>::from("), _2562_h), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"))));
            } else {
              return Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            }
          }))(_2552_highString)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isErased = _2542_onErased;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".to_vec())"));
          isOwned = true;
        }
      } else if (_source21.is_TupleSelect) {
        DAST._IExpression _2563___mcc_h178 = _source21.dtor_expr;
        BigInteger _2564___mcc_h179 = _source21.dtor_index;
        BigInteger _2565_idx = _2564___mcc_h179;
        DAST._IExpression _2566_on = _2563___mcc_h178;
        {
          Dafny.ISequence<Dafny.Rune> _2567_onString;
          bool _2568___v85;
          bool _2569_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2570_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1571;
          bool _out1572;
          bool _out1573;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1574;
          DCOMP.COMP.GenExpr(_2566_on, selfIdent, @params, false, out _out1571, out _out1572, out _out1573, out _out1574);
          _2567_onString = _out1571;
          _2568___v85 = _out1572;
          _2569_tupErased = _out1573;
          _2570_recIdents = _out1574;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2567_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2565_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2569_tupErased;
          readIdents = _2570_recIdents;
        }
      } else if (_source21.is_Call) {
        DAST._IExpression _2571___mcc_h180 = _source21.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2572___mcc_h181 = _source21.dtor_name;
        Dafny.ISequence<DAST._IType> _2573___mcc_h182 = _source21.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2574___mcc_h183 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2575_args = _2574___mcc_h183;
        Dafny.ISequence<DAST._IType> _2576_typeArgs = _2573___mcc_h182;
        Dafny.ISequence<Dafny.Rune> _2577_name = _2572___mcc_h181;
        DAST._IExpression _2578_on = _2571___mcc_h180;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2579_typeArgString;
          _2579_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2576_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2580_typeI;
            _2580_typeI = BigInteger.Zero;
            _2579_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2580_typeI) < (new BigInteger((_2576_typeArgs).Count))) {
              if ((_2580_typeI).Sign == 1) {
                _2579_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2579_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2581_typeString;
              Dafny.ISequence<Dafny.Rune> _out1575;
              _out1575 = DCOMP.COMP.GenType((_2576_typeArgs).Select(_2580_typeI), false, false);
              _2581_typeString = _out1575;
              _2579_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2579_typeArgString, _2581_typeString);
              _2580_typeI = (_2580_typeI) + (BigInteger.One);
            }
            _2579_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2579_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2582_argString;
          _2582_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2583_i;
          _2583_i = BigInteger.Zero;
          while ((_2583_i) < (new BigInteger((_2575_args).Count))) {
            if ((_2583_i).Sign == 1) {
              _2582_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2582_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2584_argExpr;
            bool _2585_isOwned;
            bool _2586_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2587_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1576;
            bool _out1577;
            bool _out1578;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1579;
            DCOMP.COMP.GenExpr((_2575_args).Select(_2583_i), selfIdent, @params, false, out _out1576, out _out1577, out _out1578, out _out1579);
            _2584_argExpr = _out1576;
            _2585_isOwned = _out1577;
            _2586_argErased = _out1578;
            _2587_argIdents = _out1579;
            if (_2585_isOwned) {
              _2584_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2584_argExpr);
            }
            _2582_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2582_argString, _2584_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2587_argIdents);
            _2583_i = (_2583_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2588_enclosingString;
          bool _2589___v86;
          bool _2590___v87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2591_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1580;
          bool _out1581;
          bool _out1582;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1583;
          DCOMP.COMP.GenExpr(_2578_on, selfIdent, @params, false, out _out1580, out _out1581, out _out1582, out _out1583);
          _2588_enclosingString = _out1580;
          _2589___v86 = _out1581;
          _2590___v87 = _out1582;
          _2591_recIdents = _out1583;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2591_recIdents);
          DAST._IExpression _source78 = _2578_on;
          if (_source78.is_Literal) {
            DAST._ILiteral _2592___mcc_h1071 = _source78.dtor_Literal_a0;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2593___mcc_h1073 = _source78.dtor_Ident_a0;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2594___mcc_h1075 = _source78.dtor_Companion_a0;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2588_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (_2577_name));
            }
          } else if (_source78.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2595___mcc_h1077 = _source78.dtor_Tuple_a0;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2596___mcc_h1079 = _source78.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2597___mcc_h1080 = _source78.dtor_args;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2598___mcc_h1083 = _source78.dtor_dims;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2599___mcc_h1085 = _source78.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2600___mcc_h1086 = _source78.dtor_variant;
            bool _2601___mcc_h1087 = _source78.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2602___mcc_h1088 = _source78.dtor_contents;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Convert) {
            DAST._IExpression _2603___mcc_h1093 = _source78.dtor_value;
            DAST._IType _2604___mcc_h1094 = _source78.dtor_from;
            DAST._IType _2605___mcc_h1095 = _source78.dtor_typ;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2606___mcc_h1099 = _source78.dtor_elements;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2607___mcc_h1101 = _source78.dtor_elements;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_MapValue) {
            Dafny.ISequence<_System._ITuple2<DAST._IExpression, DAST._IExpression>> _2608___mcc_h1103 = _source78.dtor_mapElems;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_This) {
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Ite) {
            DAST._IExpression _2609___mcc_h1105 = _source78.dtor_cond;
            DAST._IExpression _2610___mcc_h1106 = _source78.dtor_thn;
            DAST._IExpression _2611___mcc_h1107 = _source78.dtor_els;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_UnOp) {
            DAST._IUnaryOp _2612___mcc_h1111 = _source78.dtor_unOp;
            DAST._IExpression _2613___mcc_h1112 = _source78.dtor_expr;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2614___mcc_h1115 = _source78.dtor_op;
            DAST._IExpression _2615___mcc_h1116 = _source78.dtor_left;
            DAST._IExpression _2616___mcc_h1117 = _source78.dtor_right;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_ArrayLen) {
            DAST._IExpression _2617___mcc_h1121 = _source78.dtor_expr;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Select) {
            DAST._IExpression _2618___mcc_h1123 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2619___mcc_h1124 = _source78.dtor_field;
            bool _2620___mcc_h1125 = _source78.dtor_isConstant;
            bool _2621___mcc_h1126 = _source78.dtor_onDatatype;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_SelectFn) {
            DAST._IExpression _2622___mcc_h1131 = _source78.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2623___mcc_h1132 = _source78.dtor_field;
            bool _2624___mcc_h1133 = _source78.dtor_onDatatype;
            bool _2625___mcc_h1134 = _source78.dtor_isStatic;
            BigInteger _2626___mcc_h1135 = _source78.dtor_arity;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Index) {
            DAST._IExpression _2627___mcc_h1141 = _source78.dtor_expr;
            DAST._ICollKind _2628___mcc_h1142 = _source78.dtor_collKind;
            Dafny.ISequence<DAST._IExpression> _2629___mcc_h1143 = _source78.dtor_indices;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_IndexRange) {
            DAST._IExpression _2630___mcc_h1147 = _source78.dtor_expr;
            bool _2631___mcc_h1148 = _source78.dtor_isArray;
            DAST._IOptional<DAST._IExpression> _2632___mcc_h1149 = _source78.dtor_low;
            DAST._IOptional<DAST._IExpression> _2633___mcc_h1150 = _source78.dtor_high;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_TupleSelect) {
            DAST._IExpression _2634___mcc_h1155 = _source78.dtor_expr;
            BigInteger _2635___mcc_h1156 = _source78.dtor_index;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Call) {
            DAST._IExpression _2636___mcc_h1159 = _source78.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2637___mcc_h1160 = _source78.dtor_name;
            Dafny.ISequence<DAST._IType> _2638___mcc_h1161 = _source78.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2639___mcc_h1162 = _source78.dtor_args;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2640___mcc_h1167 = _source78.dtor_params;
            DAST._IType _2641___mcc_h1168 = _source78.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2642___mcc_h1169 = _source78.dtor_body;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_BetaRedex) {
            Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2643___mcc_h1173 = _source78.dtor_values;
            DAST._IType _2644___mcc_h1174 = _source78.dtor_retType;
            DAST._IExpression _2645___mcc_h1175 = _source78.dtor_expr;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2646___mcc_h1179 = _source78.dtor_name;
            DAST._IType _2647___mcc_h1180 = _source78.dtor_typ;
            DAST._IExpression _2648___mcc_h1181 = _source78.dtor_value;
            DAST._IExpression _2649___mcc_h1182 = _source78.dtor_iifeBody;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_Apply) {
            DAST._IExpression _2650___mcc_h1187 = _source78.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2651___mcc_h1188 = _source78.dtor_args;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_TypeTest) {
            DAST._IExpression _2652___mcc_h1191 = _source78.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2653___mcc_h1192 = _source78.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2654___mcc_h1193 = _source78.dtor_variant;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else if (_source78.is_InitializationValue) {
            DAST._IType _2655___mcc_h1197 = _source78.dtor_typ;
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          } else {
            {
              _2588_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2588_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").r#")), (_2577_name));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2588_enclosingString, _2579_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2582_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2656___mcc_h184 = _source21.dtor_params;
        DAST._IType _2657___mcc_h185 = _source21.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2658___mcc_h186 = _source21.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2659_body = _2658___mcc_h186;
        DAST._IType _2660_retType = _2657___mcc_h185;
        Dafny.ISequence<DAST._IFormal> _2661_params = _2656___mcc_h184;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2662_paramNames;
          _2662_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2663_i;
          _2663_i = BigInteger.Zero;
          while ((_2663_i) < (new BigInteger((_2661_params).Count))) {
            _2662_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2662_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2661_params).Select(_2663_i)).dtor_name));
            _2663_i = (_2663_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2664_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2665_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1584;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1585;
          DCOMP.COMP.GenStmts(_2659_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2662_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1584, out _out1585);
          _2664_recursiveGen = _out1584;
          _2665_recIdents = _out1585;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2666_allReadCloned;
          _2666_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2665_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2667_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2665_recIdents).Elements) {
              _2667_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2665_recIdents).Contains(_2667_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1793)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2662_paramNames).Contains(_2667_next))) {
              _2666_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2666_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2667_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2667_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2667_next));
            }
            _2665_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2665_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2667_next));
          }
          Dafny.ISequence<Dafny.Rune> _2668_paramsString;
          _2668_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          Dafny.ISequence<Dafny.Rune> _2669_paramTypes;
          _2669_paramTypes = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2663_i = BigInteger.Zero;
          while ((_2663_i) < (new BigInteger((_2661_params).Count))) {
            if ((_2663_i).Sign == 1) {
              _2668_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2668_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              _2669_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(_2669_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2670_typStr;
            Dafny.ISequence<Dafny.Rune> _out1586;
            _out1586 = DCOMP.COMP.GenType(((_2661_params).Select(_2663_i)).dtor_typ, false, true);
            _2670_typStr = _out1586;
            _2668_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2668_paramsString, ((_2661_params).Select(_2663_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2670_typStr);
            _2669_paramTypes = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2669_paramTypes, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _2670_typStr);
            _2663_i = (_2663_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2671_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1587;
          _out1587 = DCOMP.COMP.GenType(_2660_retType, false, true);
          _2671_retTypeGen = _out1587;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper::<::std::rc::Rc<dyn Fn("), _2669_paramTypes), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _2671_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>({\n")), _2666_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(move |")), _2668_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2671_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2664_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_BetaRedex) {
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2672___mcc_h187 = _source21.dtor_values;
        DAST._IType _2673___mcc_h188 = _source21.dtor_retType;
        DAST._IExpression _2674___mcc_h189 = _source21.dtor_expr;
        DAST._IExpression _2675_expr = _2674___mcc_h189;
        DAST._IType _2676_retType = _2673___mcc_h188;
        Dafny.ISequence<_System._ITuple2<DAST._IFormal, DAST._IExpression>> _2677_values = _2672___mcc_h187;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2678_paramNames;
          _2678_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2679_paramNamesSet;
          _2679_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2680_i;
          _2680_i = BigInteger.Zero;
          while ((_2680_i) < (new BigInteger((_2677_values).Count))) {
            _2678_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2678_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2677_values).Select(_2680_i)).dtor__0).dtor_name));
            _2679_paramNamesSet = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2679_paramNamesSet, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((((_2677_values).Select(_2680_i)).dtor__0).dtor_name));
            _2680_i = (_2680_i) + (BigInteger.One);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
          Dafny.ISequence<Dafny.Rune> _2681_paramsString;
          _2681_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2680_i = BigInteger.Zero;
          while ((_2680_i) < (new BigInteger((_2677_values).Count))) {
            if ((_2680_i).Sign == 1) {
              _2681_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2681_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2682_typStr;
            Dafny.ISequence<Dafny.Rune> _out1588;
            _out1588 = DCOMP.COMP.GenType((((_2677_values).Select(_2680_i)).dtor__0).dtor_typ, false, true);
            _2682_typStr = _out1588;
            Dafny.ISequence<Dafny.Rune> _2683_valueGen;
            bool _2684___v90;
            bool _2685_valueErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2686_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1589;
            bool _out1590;
            bool _out1591;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1592;
            DCOMP.COMP.GenExpr(((_2677_values).Select(_2680_i)).dtor__1, selfIdent, @params, true, out _out1589, out _out1590, out _out1591, out _out1592);
            _2683_valueGen = _out1589;
            _2684___v90 = _out1590;
            _2685_valueErased = _out1591;
            _2686_recIdents = _out1592;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), (((_2677_values).Select(_2680_i)).dtor__0).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _2682_typStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2686_recIdents);
            if (_2685_valueErased) {
              _2683_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2683_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2683_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            _2680_i = (_2680_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2687_recGen;
          bool _2688_recOwned;
          bool _2689_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2690_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1593;
          bool _out1594;
          bool _out1595;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1596;
          DCOMP.COMP.GenExpr(_2675_expr, selfIdent, _2678_paramNames, mustOwn, out _out1593, out _out1594, out _out1595, out _out1596);
          _2687_recGen = _out1593;
          _2688_recOwned = _out1594;
          _2689_recErased = _out1595;
          _2690_recIdents = _out1596;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2690_recIdents, _2679_paramNamesSet);
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _2687_recGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2688_recOwned;
          isErased = _2689_recErased;
        }
      } else if (_source21.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2691___mcc_h190 = _source21.dtor_name;
        DAST._IType _2692___mcc_h191 = _source21.dtor_typ;
        DAST._IExpression _2693___mcc_h192 = _source21.dtor_value;
        DAST._IExpression _2694___mcc_h193 = _source21.dtor_iifeBody;
        DAST._IExpression _2695_iifeBody = _2694___mcc_h193;
        DAST._IExpression _2696_value = _2693___mcc_h192;
        DAST._IType _2697_tpe = _2692___mcc_h191;
        Dafny.ISequence<Dafny.Rune> _2698_name = _2691___mcc_h190;
        {
          Dafny.ISequence<Dafny.Rune> _2699_valueGen;
          bool _2700_valueOwned;
          bool _2701_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2702_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1597;
          bool _out1598;
          bool _out1599;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1600;
          DCOMP.COMP.GenExpr(_2696_value, selfIdent, @params, false, out _out1597, out _out1598, out _out1599, out _out1600);
          _2699_valueGen = _out1597;
          _2700_valueOwned = _out1598;
          _2701_valueErased = _out1599;
          _2702_recIdents = _out1600;
          if (_2701_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2703_eraseFn;
            _2703_eraseFn = ((_2700_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2699_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2703_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2699_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2702_recIdents;
          Dafny.ISequence<Dafny.Rune> _2704_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1601;
          _out1601 = DCOMP.COMP.GenType(_2697_tpe, false, true);
          _2704_valueTypeGen = _out1601;
          Dafny.ISequence<Dafny.Rune> _2705_bodyGen;
          bool _2706_bodyOwned;
          bool _2707_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2708_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1602;
          bool _out1603;
          bool _out1604;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1605;
          DCOMP.COMP.GenExpr(_2695_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2700_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2698_name))))), mustOwn, out _out1602, out _out1603, out _out1604, out _out1605);
          _2705_bodyGen = _out1602;
          _2706_bodyOwned = _out1603;
          _2707_bodyErased = _out1604;
          _2708_bodyIdents = _out1605;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2708_bodyIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_2698_name))));
          Dafny.ISequence<Dafny.Rune> _2709_eraseFn;
          _2709_eraseFn = ((_2700_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2698_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2700_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2704_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2699_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2705_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2706_bodyOwned;
          isErased = _2707_bodyErased;
        }
      } else if (_source21.is_Apply) {
        DAST._IExpression _2710___mcc_h194 = _source21.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2711___mcc_h195 = _source21.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2712_args = _2711___mcc_h195;
        DAST._IExpression _2713_func = _2710___mcc_h194;
        {
          Dafny.ISequence<Dafny.Rune> _2714_funcString;
          bool _2715___v91;
          bool _2716_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2717_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1606;
          bool _out1607;
          bool _out1608;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1609;
          DCOMP.COMP.GenExpr(_2713_func, selfIdent, @params, false, out _out1606, out _out1607, out _out1608, out _out1609);
          _2714_funcString = _out1606;
          _2715___v91 = _out1607;
          _2716_funcErased = _out1608;
          _2717_recIdents = _out1609;
          readIdents = _2717_recIdents;
          Dafny.ISequence<Dafny.Rune> _2718_argString;
          _2718_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2719_i;
          _2719_i = BigInteger.Zero;
          while ((_2719_i) < (new BigInteger((_2712_args).Count))) {
            if ((_2719_i).Sign == 1) {
              _2718_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2718_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2720_argExpr;
            bool _2721_isOwned;
            bool _2722_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2723_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1610;
            bool _out1611;
            bool _out1612;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1613;
            DCOMP.COMP.GenExpr((_2712_args).Select(_2719_i), selfIdent, @params, false, out _out1610, out _out1611, out _out1612, out _out1613);
            _2720_argExpr = _out1610;
            _2721_isOwned = _out1611;
            _2722_argErased = _out1612;
            _2723_argIdents = _out1613;
            if (_2721_isOwned) {
              _2720_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2720_argExpr);
            }
            _2718_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2718_argString, _2720_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2723_argIdents);
            _2719_i = (_2719_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2714_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2718_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source21.is_TypeTest) {
        DAST._IExpression _2724___mcc_h196 = _source21.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2725___mcc_h197 = _source21.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2726___mcc_h198 = _source21.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2727_variant = _2726___mcc_h198;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2728_dType = _2725___mcc_h197;
        DAST._IExpression _2729_on = _2724___mcc_h196;
        {
          Dafny.ISequence<Dafny.Rune> _2730_exprGen;
          bool _2731___v92;
          bool _2732_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2733_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1614;
          bool _out1615;
          bool _out1616;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1617;
          DCOMP.COMP.GenExpr(_2729_on, selfIdent, @params, false, out _out1614, out _out1615, out _out1616, out _out1617);
          _2730_exprGen = _out1614;
          _2731___v92 = _out1615;
          _2732_exprErased = _out1616;
          _2733_recIdents = _out1617;
          Dafny.ISequence<Dafny.Rune> _2734_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1618;
          _out1618 = DCOMP.COMP.GenPath(_2728_dType);
          _2734_dTypePath = _out1618;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2730_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2734_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2727_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2733_recIdents;
        }
      } else if (_source21.is_InitializationValue) {
        DAST._IType _2735___mcc_h199 = _source21.dtor_typ;
        DAST._IType _2736_typ = _2735___mcc_h199;
        {
          Dafny.ISequence<Dafny.Rune> _2737_typString;
          Dafny.ISequence<Dafny.Rune> _out1619;
          _out1619 = DCOMP.COMP.GenType(_2736_typ, false, false);
          _2737_typString = _out1619;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2737_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
          isOwned = true;
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[false, true]");
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      }
    }
    public static Dafny.ISequence<Dafny.Rune> Compile(Dafny.ISequence<DAST._IModule> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#![allow(warnings, unconditional_panic)]\n");
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("extern crate dafny_runtime;\n"));
      BigInteger _2738_i;
      _2738_i = BigInteger.Zero;
      while ((_2738_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2739_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1620;
        _out1620 = DCOMP.COMP.GenModule((p).Select(_2738_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2739_generated = _out1620;
        if ((_2738_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2739_generated);
        _2738_i = (_2738_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2740_i;
      _2740_i = BigInteger.Zero;
      while ((_2740_i) < (new BigInteger((fullName).Count))) {
        if ((_2740_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2740_i));
        _2740_i = (_2740_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

