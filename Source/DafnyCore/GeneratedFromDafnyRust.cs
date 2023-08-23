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
    bool is_While { get; }
    bool is_Call { get; }
    bool is_Return { get; }
    bool is_EarlyReturn { get; }
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
    public static _IStatement create_Assign(DAST._IAssignLhs lhs, DAST._IExpression @value) {
      return new Statement_Assign(lhs, @value);
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
    public bool is_While { get { return this is Statement_While; } }
    public bool is_Call { get { return this is Statement_Call; } }
    public bool is_Return { get { return this is Statement_Return; } }
    public bool is_EarlyReturn { get { return this is Statement_EarlyReturn; } }
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
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        var d = this;
        if (d is Statement_While) { return ((Statement_While)d)._body; }
        return ((Statement_TailRecursive)d)._body;
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
      hash = ((hash << 5) + hash) + 7;
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
      hash = ((hash << 5) + hash) + 8;
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
      hash = ((hash << 5) + hash) + 9;
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
      hash = ((hash << 5) + hash) + 10;
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
    DAST._IExpression dtor_idx { get; }
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
    public static _IAssignLhs create_Index(DAST._IExpression expr, DAST._IExpression idx) {
      return new AssignLhs_Index(expr, idx);
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
    public DAST._IExpression dtor_idx {
      get {
        var d = this;
        return ((AssignLhs_Index)d)._idx;
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
    public readonly DAST._IExpression _idx;
    public AssignLhs_Index(DAST._IExpression expr, DAST._IExpression idx) : base() {
      this._expr = expr;
      this._idx = idx;
    }
    public override _IAssignLhs DowncastClone() {
      if (this is _IAssignLhs dt) { return dt; }
      return new AssignLhs_Index(_expr, _idx);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.AssignLhs_Index;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._idx, oth._idx);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._idx));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.AssignLhs.Index";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._idx);
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
    bool is_SeqValue { get; }
    bool is_SetValue { get; }
    bool is_This { get; }
    bool is_Ite { get; }
    bool is_UnOp { get; }
    bool is_BinOp { get; }
    bool is_Select { get; }
    bool is_SelectFn { get; }
    bool is_Index { get; }
    bool is_TupleSelect { get; }
    bool is_Call { get; }
    bool is_Lambda { get; }
    bool is_IIFE { get; }
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
    DAST._IExpression dtor_value { get; }
    DAST._IType dtor_from { get; }
    DAST._IType dtor_typ { get; }
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
    bool dtor_isConstant { get; }
    bool dtor_onDatatype { get; }
    bool dtor_isStatic { get; }
    BigInteger dtor_arity { get; }
    DAST._IExpression dtor_idx { get; }
    BigInteger dtor_index { get; }
    DAST._IExpression dtor_on { get; }
    Dafny.ISequence<Dafny.Rune> dtor_name { get; }
    Dafny.ISequence<DAST._IType> dtor_typeArgs { get; }
    Dafny.ISequence<DAST._IFormal> dtor_params { get; }
    DAST._IType dtor_retType { get; }
    Dafny.ISequence<DAST._IStatement> dtor_body { get; }
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
    public static _IExpression create_Select(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool isConstant, bool onDatatype) {
      return new Expression_Select(expr, field, isConstant, onDatatype);
    }
    public static _IExpression create_SelectFn(DAST._IExpression expr, Dafny.ISequence<Dafny.Rune> field, bool onDatatype, bool isStatic, BigInteger arity) {
      return new Expression_SelectFn(expr, field, onDatatype, isStatic, arity);
    }
    public static _IExpression create_Index(DAST._IExpression expr, DAST._IExpression idx) {
      return new Expression_Index(expr, idx);
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
    public bool is_This { get { return this is Expression_This; } }
    public bool is_Ite { get { return this is Expression_Ite; } }
    public bool is_UnOp { get { return this is Expression_UnOp; } }
    public bool is_BinOp { get { return this is Expression_BinOp; } }
    public bool is_Select { get { return this is Expression_Select; } }
    public bool is_SelectFn { get { return this is Expression_SelectFn; } }
    public bool is_Index { get { return this is Expression_Index; } }
    public bool is_TupleSelect { get { return this is Expression_TupleSelect; } }
    public bool is_Call { get { return this is Expression_Call; } }
    public bool is_Lambda { get { return this is Expression_Lambda; } }
    public bool is_IIFE { get { return this is Expression_IIFE; } }
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
        if (d is Expression_Index) { return ((Expression_Index)d)._expr; }
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
    public DAST._IExpression dtor_idx {
      get {
        var d = this;
        return ((Expression_Index)d)._idx;
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
        return ((Expression_Lambda)d)._retType;
      }
    }
    public Dafny.ISequence<DAST._IStatement> dtor_body {
      get {
        var d = this;
        return ((Expression_Lambda)d)._body;
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
      hash = ((hash << 5) + hash) + 14;
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
      hash = ((hash << 5) + hash) + 15;
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
    public readonly DAST._IExpression _idx;
    public Expression_Index(DAST._IExpression expr, DAST._IExpression idx) : base() {
      this._expr = expr;
      this._idx = idx;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_Index(_expr, _idx);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_Index;
      return oth != null && object.Equals(this._expr, oth._expr) && object.Equals(this._idx, oth._idx);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 16;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._expr));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._idx));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.Index";
      s += "(";
      s += Dafny.Helpers.ToString(this._expr);
      s += ", ";
      s += Dafny.Helpers.ToString(this._idx);
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
      hash = ((hash << 5) + hash) + 17;
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
      hash = ((hash << 5) + hash) + 18;
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
      hash = ((hash << 5) + hash) + 19;
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
      hash = ((hash << 5) + hash) + 20;
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
      hash = ((hash << 5) + hash) + 21;
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
      hash = ((hash << 5) + hash) + 22;
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
      hash = ((hash << 5) + hash) + 23;
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
      _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_62_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"")), ((c).dtor_enclosingModule)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (c).dtor_name), (((new BigInteger(((c).dtor_fields).Count)).Sign == 1) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"));
      BigInteger _63_i;
      _63_i = BigInteger.Zero;
      while ((_63_i) < (new BigInteger(((c).dtor_fields).Count))) {
        DAST._IField _64_field;
        _64_field = ((c).dtor_fields).Select(_63_i);
        if ((_63_i).Sign == 1) {
          _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_62_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
        }
        _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_62_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(::std::ops::Deref::deref(&(self.r#")), ((_64_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow())), __fmt_print_formatter, false)?;"));
        _63_i = (_63_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_fields).Count)).Sign == 1) {
        _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_62_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
      }
      _62_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_62_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _65_ptrPartialEqImpl;
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_65_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_65_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _65_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_65_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _61_defaultImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _62_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _65_ptrPartialEqImpl);
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
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait r#"), (t).dtor_name), _67_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _72_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Clone, PartialEq)]\n#[repr(transparent)]\npub struct r#"), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(pub ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase(&self) -> &Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase_owned(self) -> Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unsafe { &*(x as *const ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as *const r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") }\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: ")), _77_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(x)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
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
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _80_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(::std::default::Default::default())\n"));
        }
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _76_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _75_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
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
        _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_89_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
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
            _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_90_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_92_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper<")), _93_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">, "));
          } else {
            _90_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_90_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_92_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _93_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
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
              _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_104_ctor2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
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
                _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_108_formal2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                _106_l = (_106_l) + (BigInteger.One);
              }
              if (_107_hasMatchingField) {
                if ((c).dtor_isCo) {
                  _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ::std::ops::Deref::deref(&")), (_100_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0),\n"));
                } else {
                  _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ")), (_100_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
                }
              } else {
                _105_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_105_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => panic!(\"field does not exist on this variant\"),\n"));
              }
              _102_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_102_methodBody, _105_ctorMatch);
              _103_k = (_103_k) + (BigInteger.One);
            }
            if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
              _102_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_102_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => panic!(),\n"));
            }
            _102_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_102_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            _95_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_95_implBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#")), (_100_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&self) -> &")), _101_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _102_methodBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
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
      _111_enumBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(PartialEq)]\npub enum r#"), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _87_ctors), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _95_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _112_identEraseImpls;
      _112_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = Self;\nfn erase(&self) -> &Self::Erased { self }\nfn erase_owned(self) -> Self::Erased { self }}\n"));
      _112_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_112_identEraseImpls, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn unerase(x: &Self) -> &Self { x }\nfn unerase_owned(x: Self) -> Self { x }}\n"));
      Dafny.ISequence<Dafny.Rune> _113_printImpl;
      _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n"));
      _88_i = BigInteger.Zero;
      while ((_88_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _114_ctor;
        _114_ctor = ((c).dtor_ctors).Select(_88_i);
        Dafny.ISequence<Dafny.Rune> _115_ctorMatch;
        _115_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_114_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        Dafny.ISequence<Dafny.Rune> _116_modulePrefix;
        _116_modulePrefix = (((((c).dtor_enclosingModule)).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_module"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(((c).dtor_enclosingModule), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("."))));
        Dafny.ISequence<Dafny.Rune> _117_printRhs;
        _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \""), _116_modulePrefix), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (_114_ctor).dtor_name), (((_114_ctor).dtor_hasAnyArgs) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(\")?;")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"))));
        BigInteger _118_j;
        _118_j = BigInteger.Zero;
        while ((_118_j) < (new BigInteger(((_114_ctor).dtor_args).Count))) {
          DAST._IFormal _119_formal;
          _119_formal = ((_114_ctor).dtor_args).Select(_118_j);
          _115_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_115_ctorMatch, (_119_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          if ((_118_j).Sign == 1) {
            _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
          }
          _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(")), (_119_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", __fmt_print_formatter, false)?;"));
          _118_j = (_118_j) + (BigInteger.One);
        }
        _115_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_115_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        if ((_114_ctor).dtor_hasAnyArgs) {
          _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
        }
        _117_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_117_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())"));
        _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_113_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _115_ctorMatch), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" => {\n")), _117_printRhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
        _88_i = (_88_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_typeParams).Count)).Sign == 1) {
        _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_113_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::_PhantomVariant(..) => {panic!()\n}\n"));
      }
      _113_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_113_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _120_defaultImpl;
      _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_ctors).Count)).Sign == 1) {
        _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _86_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _85_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (((c).dtor_ctors).Select(BigInteger.Zero)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        _88_i = BigInteger.Zero;
        while ((_88_i) < (new BigInteger(((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Count))) {
          DAST._IFormal _121_formal;
          _121_formal = ((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Select(_88_i);
          _120_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_120_defaultImpl, (_121_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": std::default::Default::default(),\n"));
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
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((p).Select(_122_i)));
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
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _132___mcc_h17 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _133___mcc_h19 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IType _134___mcc_h21 = _source6.dtor_Newtype_a0;
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
        DAST._IType _144_element = _143___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _145_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_144_element, inBinding, inFn);
          _145_elemStr = _out45;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<::std::cell::RefCell<::std::vec::Vec<"), _145_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>>"));
        }
      } else if (_source5.is_Seq) {
        DAST._IType _146___mcc_h6 = _source5.dtor_element;
        DAST._IType _147_element = _146___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _148_elemStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_147_element, inBinding, inFn);
          _148_elemStr = _out46;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _148_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _149___mcc_h7 = _source5.dtor_element;
        DAST._IType _150_element = _149___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _151_elemStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_150_element, inBinding, inFn);
          _151_elemStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _151_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _152___mcc_h8 = _source5.dtor_element;
        DAST._IType _153_element = _152___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _154_elemStr;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenType(_153_element, inBinding, inFn);
          _154_elemStr = _out48;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _154_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _155___mcc_h9 = _source5.dtor_key;
        DAST._IType _156___mcc_h10 = _source5.dtor_value;
        DAST._IType _157_value = _156___mcc_h10;
        DAST._IType _158_key = _155___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _159_keyStr;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenType(_158_key, inBinding, inFn);
          _159_keyStr = _out49;
          Dafny.ISequence<Dafny.Rune> _160_valueStr;
          Dafny.ISequence<Dafny.Rune> _out50;
          _out50 = DCOMP.COMP.GenType(_157_value, inBinding, inFn);
          _160_valueStr = _out50;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _159_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _160_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _161___mcc_h11 = _source5.dtor_args;
        DAST._IType _162___mcc_h12 = _source5.dtor_result;
        DAST._IType _163_result = _162___mcc_h12;
        Dafny.ISequence<DAST._IType> _164_args = _161___mcc_h11;
        {
          if (inBinding) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<_>");
          } else {
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::boxed::Box<dyn ::std::ops::Fn(");
            } else {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<impl ::std::ops::Fn(");
            }
            BigInteger _165_i;
            _165_i = BigInteger.Zero;
            while ((_165_i) < (new BigInteger((_164_args).Count))) {
              if ((_165_i).Sign == 1) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _166_generated;
              Dafny.ISequence<Dafny.Rune> _out51;
              _out51 = DCOMP.COMP.GenType((_164_args).Select(_165_i), inBinding, true);
              _166_generated = _out51;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _166_generated);
              _165_i = (_165_i) + (BigInteger.One);
            }
            Dafny.ISequence<Dafny.Rune> _167_resultType;
            Dafny.ISequence<Dafny.Rune> _out52;
            _out52 = DCOMP.COMP.GenType(_163_result, inBinding, inFn);
            _167_resultType = _out52;
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _167_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _167_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + Clone + 'static>"));
            }
          }
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _168___mcc_h13 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _169_p = _168___mcc_h13;
        {
          DAST._IPrimitive _source7 = _169_p;
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
        Dafny.ISequence<Dafny.Rune> _170___mcc_h14 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _171_v = _170___mcc_h14;
        s = _171_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _172___mcc_h15 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _172___mcc_h15;
        Dafny.ISequence<Dafny.Rune> _173___mcc_h16 = _source8;
        Dafny.ISequence<Dafny.Rune> _174_name = _173___mcc_h16;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _174_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _175_i;
      _175_i = BigInteger.Zero;
      while ((_175_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_175_i);
        DAST._IMethod _176___mcc_h0 = _source9;
        DAST._IMethod _177_m = _176___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_177_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _178___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _179_p = _178___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _180_existing;
              _180_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_179_p)) {
                _180_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _179_p);
              }
              if ((new BigInteger((_180_existing).Count)).Sign == 1) {
                _180_existing = Dafny.Sequence<Dafny.Rune>.Concat(_180_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _181_genMethod;
              Dafny.ISequence<Dafny.Rune> _out53;
              _out53 = DCOMP.COMP.GenMethod(_177_m, true, enclosingType, enclosingTypeParams);
              _181_genMethod = _out53;
              _180_existing = Dafny.Sequence<Dafny.Rune>.Concat(_180_existing, _181_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_179_p, _180_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _182_generated;
              Dafny.ISequence<Dafny.Rune> _out54;
              _out54 = DCOMP.COMP.GenMethod(_177_m, forTrait, enclosingType, enclosingTypeParams);
              _182_generated = _out54;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _182_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _175_i = (_175_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _183_i;
      _183_i = BigInteger.Zero;
      while ((_183_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _184_param;
        _184_param = (@params).Select(_183_i);
        Dafny.ISequence<Dafny.Rune> _185_paramType;
        Dafny.ISequence<Dafny.Rune> _out55;
        _out55 = DCOMP.COMP.GenType((_184_param).dtor_typ, false, false);
        _185_paramType = _out55;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_184_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _185_paramType);
        if ((_183_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _183_i = (_183_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _186_params;
      Dafny.ISequence<Dafny.Rune> _out56;
      _out56 = DCOMP.COMP.GenParams((m).dtor_params);
      _186_params = _out56;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _187_paramNames;
      _187_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _188_paramI;
      _188_paramI = BigInteger.Zero;
      while ((_188_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _187_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_187_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_188_paramI)).dtor_name));
        _188_paramI = (_188_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _186_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _186_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _189_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out57;
          _out57 = DCOMP.COMP.GenType(enclosingType, false, false);
          _189_enclosingTypeString = _out57;
          _186_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _189_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _186_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _190_retType;
      _190_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _191_typeI;
      _191_typeI = BigInteger.Zero;
      while ((_191_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_191_typeI).Sign == 1) {
          _190_retType = Dafny.Sequence<Dafny.Rune>.Concat(_190_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _192_typeString;
        Dafny.ISequence<Dafny.Rune> _out58;
        _out58 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_191_typeI), false, false);
        _192_typeString = _out58;
        _190_retType = Dafny.Sequence<Dafny.Rune>.Concat(_190_retType, _192_typeString);
        _191_typeI = (_191_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _190_retType = Dafny.Sequence<Dafny.Rune>.Concat(_190_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _193_typeParamsFiltered;
      _193_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _194_typeParamI;
      _194_typeParamI = BigInteger.Zero;
      while ((_194_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _195_typeParam;
        _195_typeParam = ((m).dtor_typeParams).Select(_194_typeParamI);
        if (!((enclosingTypeParams).Contains(_195_typeParam))) {
          _193_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_193_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_195_typeParam));
        }
        _194_typeParamI = (_194_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_193_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _196_i;
        _196_i = BigInteger.Zero;
        while ((_196_i) < (new BigInteger((_193_typeParamsFiltered).Count))) {
          if ((_196_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _197_typeString;
          Dafny.ISequence<Dafny.Rune> _out59;
          _out59 = DCOMP.COMP.GenType((_193_typeParamsFiltered).Select(_196_i), false, false);
          _197_typeString = _out59;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _197_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _197_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _196_i = (_196_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _186_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _190_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _198_earlyReturn;
        _198_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _199___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _200_outVars = _199___mcc_h0;
          {
            _198_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _201_outI;
            _201_outI = BigInteger.Zero;
            while ((_201_outI) < (new BigInteger((_200_outVars).Count))) {
              if ((_201_outI).Sign == 1) {
                _198_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_198_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _202_outVar;
              _202_outVar = (_200_outVars).Select(_201_outI);
              _198_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_198_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_202_outVar));
              _201_outI = (_201_outI) + (BigInteger.One);
            }
            _198_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_198_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _203_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _204___v12;
        Dafny.ISequence<Dafny.Rune> _out60;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out61;
        DCOMP.COMP.GenStmts((m).dtor_body, (((m).dtor_isStatic) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None()) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self")))), _187_paramNames, true, _198_earlyReturn, out _out60, out _out61);
        _203_body = _out60;
        _204___v12 = _out61;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source12 = (m).dtor_outVars;
        if (_source12.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _205___mcc_h1 = _source12.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _206_outVars = _205___mcc_h1;
          {
            _203_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_203_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _198_earlyReturn);
          }
        } else {
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _203_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      }
      return s;
    }
    public static void GenStmts(Dafny.ISequence<DAST._IStatement> stmts, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _207_i;
      _207_i = BigInteger.Zero;
      while ((_207_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _208_stmt;
        _208_stmt = (stmts).Select(_207_i);
        Dafny.ISequence<Dafny.Rune> _209_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _210_recIdents;
        Dafny.ISequence<Dafny.Rune> _out62;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out63;
        DCOMP.COMP.GenStmt(_208_stmt, selfIdent, @params, (isLast) && ((_207_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out62, out _out63);
        _209_stmtString = _out62;
        _210_recIdents = _out63;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _210_recIdents);
        if ((_207_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _209_stmtString);
        _207_i = (_207_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.Rune> rhs, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source13 = lhs;
      if (_source13.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _211___mcc_h0 = _source13.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source14 = _211___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _212___mcc_h1 = _source14;
        Dafny.ISequence<Dafny.Rune> _213_id = _212___mcc_h1;
        {
          if ((@params).Contains(_213_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _213_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _213_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_213_id);
          needsIIFE = false;
        }
      } else if (_source13.is_Select) {
        DAST._IExpression _214___mcc_h2 = _source13.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _215___mcc_h3 = _source13.dtor_field;
        Dafny.ISequence<Dafny.Rune> _216_field = _215___mcc_h3;
        DAST._IExpression _217_on = _214___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _218_onExpr;
          bool _219_onOwned;
          bool _220_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _221_recIdents;
          Dafny.ISequence<Dafny.Rune> _out64;
          bool _out65;
          bool _out66;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out67;
          DCOMP.COMP.GenExpr(_217_on, selfIdent, @params, false, out _out64, out _out65, out _out66, out _out67);
          _218_onExpr = _out64;
          _219_onOwned = _out65;
          _220_onErased = _out66;
          _221_recIdents = _out67;
          if (!(_220_onErased)) {
            Dafny.ISequence<Dafny.Rune> _222_eraseFn;
            _222_eraseFn = ((_219_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _218_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _222_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _218_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _218_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _216_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _221_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _223___mcc_h4 = _source13.dtor_expr;
        DAST._IExpression _224___mcc_h5 = _source13.dtor_idx;
        DAST._IExpression _225_idx = _224___mcc_h5;
        DAST._IExpression _226_on = _223___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _227_onExpr;
          bool _228_onOwned;
          bool _229_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _230_recIdents;
          Dafny.ISequence<Dafny.Rune> _out68;
          bool _out69;
          bool _out70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out71;
          DCOMP.COMP.GenExpr(_226_on, selfIdent, @params, false, out _out68, out _out69, out _out70, out _out71);
          _227_onExpr = _out68;
          _228_onOwned = _out69;
          _229_onErased = _out70;
          _230_recIdents = _out71;
          if (!(_229_onErased)) {
            Dafny.ISequence<Dafny.Rune> _231_eraseFn;
            _231_eraseFn = ((_228_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _227_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _231_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _227_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _232_idxString;
          bool _233___v13;
          bool _234_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _235_idxIdents;
          Dafny.ISequence<Dafny.Rune> _out72;
          bool _out73;
          bool _out74;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
          DCOMP.COMP.GenExpr(_225_idx, selfIdent, @params, true, out _out72, out _out73, out _out74, out _out75);
          _232_idxString = _out72;
          _233___v13 = _out73;
          _234_idxErased = _out74;
          _235_idxIdents = _out75;
          if (!(_234_idxErased)) {
            _232_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _232_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __idx = <usize as ::dafny_runtime::NumCast>::from("), _232_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _227_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()[__idx] = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n}"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_230_recIdents, _235_idxIdents);
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _236___mcc_h0 = _source15.dtor_name;
        DAST._IType _237___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _238___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _238___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _239___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _240_expression = _239___mcc_h3;
          DAST._IType _241_typ = _237___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _242_name = _236___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _243_expr;
            bool _244___v14;
            bool _245_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _246_recIdents;
            Dafny.ISequence<Dafny.Rune> _out76;
            bool _out77;
            bool _out78;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
            DCOMP.COMP.GenExpr(_240_expression, selfIdent, @params, true, out _out76, out _out77, out _out78, out _out79);
            _243_expr = _out76;
            _244___v14 = _out77;
            _245_recErased = _out78;
            _246_recIdents = _out79;
            if (_245_recErased) {
              _243_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _243_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _247_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_241_typ, true, false);
            _247_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _242_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _247_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _243_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _246_recIdents;
          }
        } else {
          DAST._IType _248_typ = _237___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _249_name = _236___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _250_typeString;
            Dafny.ISequence<Dafny.Rune> _out81;
            _out81 = DCOMP.COMP.GenType(_248_typ, true, false);
            _250_typeString = _out81;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _249_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _250_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _251___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _252___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _253_expression = _252___mcc_h5;
        DAST._IAssignLhs _254_lhs = _251___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _255_lhsGen;
          bool _256_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _257_recIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          bool _out83;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out84;
          DCOMP.COMP.GenAssignLhs(_254_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), selfIdent, @params, out _out82, out _out83, out _out84);
          _255_lhsGen = _out82;
          _256_needsIIFE = _out83;
          _257_recIdents = _out84;
          Dafny.ISequence<Dafny.Rune> _258_exprGen;
          bool _259___v15;
          bool _260_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _261_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out85;
          bool _out86;
          bool _out87;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out88;
          DCOMP.COMP.GenExpr(_253_expression, selfIdent, @params, true, out _out85, out _out86, out _out87, out _out88);
          _258_exprGen = _out85;
          _259___v15 = _out86;
          _260_exprErased = _out87;
          _261_exprIdents = _out88;
          if (_260_exprErased) {
            _258_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _258_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_256_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _258_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _255_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_255_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _258_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_257_recIdents, _261_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _262___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _263___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _264___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _265_els = _264___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _266_thn = _263___mcc_h7;
        DAST._IExpression _267_cond = _262___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _268_condString;
          bool _269___v16;
          bool _270_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _271_recIdents;
          Dafny.ISequence<Dafny.Rune> _out89;
          bool _out90;
          bool _out91;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out92;
          DCOMP.COMP.GenExpr(_267_cond, selfIdent, @params, true, out _out89, out _out90, out _out91, out _out92);
          _268_condString = _out89;
          _269___v16 = _out90;
          _270_condErased = _out91;
          _271_recIdents = _out92;
          if (!(_270_condErased)) {
            _268_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _268_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _271_recIdents;
          Dafny.ISequence<Dafny.Rune> _272_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _273_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out93;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out94;
          DCOMP.COMP.GenStmts(_266_thn, selfIdent, @params, isLast, earlyReturn, out _out93, out _out94);
          _272_thnString = _out93;
          _273_thnIdents = _out94;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _273_thnIdents);
          Dafny.ISequence<Dafny.Rune> _274_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _275_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out95;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
          DCOMP.COMP.GenStmts(_265_els, selfIdent, @params, isLast, earlyReturn, out _out95, out _out96);
          _274_elsString = _out95;
          _275_elsIdents = _out96;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _275_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _268_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _272_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _274_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _276___mcc_h9 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _277___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _278_body = _277___mcc_h10;
        DAST._IExpression _279_cond = _276___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _280_condString;
          bool _281___v17;
          bool _282_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _283_recIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_279_cond, selfIdent, @params, true, out _out97, out _out98, out _out99, out _out100);
          _280_condString = _out97;
          _281___v17 = _out98;
          _282_condErased = _out99;
          _283_recIdents = _out100;
          if (!(_282_condErased)) {
            _280_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _280_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _283_recIdents;
          Dafny.ISequence<Dafny.Rune> _284_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _285_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenStmts(_278_body, selfIdent, @params, false, earlyReturn, out _out101, out _out102);
          _284_bodyString = _out101;
          _285_bodyIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _285_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _280_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _284_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _286___mcc_h11 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _287___mcc_h12 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _288___mcc_h13 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _289___mcc_h14 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _290___mcc_h15 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _291_maybeOutVars = _290___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _292_args = _289___mcc_h14;
        Dafny.ISequence<DAST._IType> _293_typeArgs = _288___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _294_name = _287___mcc_h12;
        DAST._IExpression _295_on = _286___mcc_h11;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _296_typeArgString;
          _296_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_293_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _297_typeI;
            _297_typeI = BigInteger.Zero;
            _296_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_297_typeI) < (new BigInteger((_293_typeArgs).Count))) {
              if ((_297_typeI).Sign == 1) {
                _296_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_296_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _298_typeString;
              Dafny.ISequence<Dafny.Rune> _out103;
              _out103 = DCOMP.COMP.GenType((_293_typeArgs).Select(_297_typeI), false, false);
              _298_typeString = _out103;
              _296_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_296_typeArgString, _298_typeString);
              _297_typeI = (_297_typeI) + (BigInteger.One);
            }
            _296_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_296_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _299_argString;
          _299_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _300_i;
          _300_i = BigInteger.Zero;
          while ((_300_i) < (new BigInteger((_292_args).Count))) {
            if ((_300_i).Sign == 1) {
              _299_argString = Dafny.Sequence<Dafny.Rune>.Concat(_299_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _301_argExpr;
            bool _302_isOwned;
            bool _303_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _304_argIdents;
            Dafny.ISequence<Dafny.Rune> _out104;
            bool _out105;
            bool _out106;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out107;
            DCOMP.COMP.GenExpr((_292_args).Select(_300_i), selfIdent, @params, false, out _out104, out _out105, out _out106, out _out107);
            _301_argExpr = _out104;
            _302_isOwned = _out105;
            _303_argErased = _out106;
            _304_argIdents = _out107;
            if (_302_isOwned) {
              _301_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _301_argExpr);
            }
            _299_argString = Dafny.Sequence<Dafny.Rune>.Concat(_299_argString, _301_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _304_argIdents);
            _300_i = (_300_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _305_enclosingString;
          bool _306___v18;
          bool _307___v19;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _308_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out108;
          bool _out109;
          bool _out110;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out111;
          DCOMP.COMP.GenExpr(_295_on, selfIdent, @params, false, out _out108, out _out109, out _out110, out _out111);
          _305_enclosingString = _out108;
          _306___v18 = _out109;
          _307___v19 = _out110;
          _308_enclosingIdents = _out111;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _308_enclosingIdents);
          DAST._IExpression _source17 = _295_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _309___mcc_h19 = _source17.dtor_Literal_a0;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _310___mcc_h21 = _source17.dtor_Ident_a0;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _311___mcc_h23 = _source17.dtor_Companion_a0;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_305_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _312___mcc_h25 = _source17.dtor_Tuple_a0;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _313___mcc_h27 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _314___mcc_h28 = _source17.dtor_args;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _315___mcc_h31 = _source17.dtor_dims;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _316___mcc_h33 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _317___mcc_h34 = _source17.dtor_variant;
            bool _318___mcc_h35 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _319___mcc_h36 = _source17.dtor_contents;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _320___mcc_h41 = _source17.dtor_value;
            DAST._IType _321___mcc_h42 = _source17.dtor_from;
            DAST._IType _322___mcc_h43 = _source17.dtor_typ;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _323___mcc_h47 = _source17.dtor_elements;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _324___mcc_h49 = _source17.dtor_elements;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _325___mcc_h51 = _source17.dtor_cond;
            DAST._IExpression _326___mcc_h52 = _source17.dtor_thn;
            DAST._IExpression _327___mcc_h53 = _source17.dtor_els;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _328___mcc_h57 = _source17.dtor_unOp;
            DAST._IExpression _329___mcc_h58 = _source17.dtor_expr;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _330___mcc_h61 = _source17.dtor_op;
            DAST._IExpression _331___mcc_h62 = _source17.dtor_left;
            DAST._IExpression _332___mcc_h63 = _source17.dtor_right;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _333___mcc_h67 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _334___mcc_h68 = _source17.dtor_field;
            bool _335___mcc_h69 = _source17.dtor_isConstant;
            bool _336___mcc_h70 = _source17.dtor_onDatatype;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _337___mcc_h75 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _338___mcc_h76 = _source17.dtor_field;
            bool _339___mcc_h77 = _source17.dtor_onDatatype;
            bool _340___mcc_h78 = _source17.dtor_isStatic;
            BigInteger _341___mcc_h79 = _source17.dtor_arity;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Index) {
            DAST._IExpression _342___mcc_h85 = _source17.dtor_expr;
            DAST._IExpression _343___mcc_h86 = _source17.dtor_idx;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _344___mcc_h89 = _source17.dtor_expr;
            BigInteger _345___mcc_h90 = _source17.dtor_index;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _346___mcc_h93 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _347___mcc_h94 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _348___mcc_h95 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _349___mcc_h96 = _source17.dtor_args;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _350___mcc_h101 = _source17.dtor_params;
            DAST._IType _351___mcc_h102 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _352___mcc_h103 = _source17.dtor_body;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _353___mcc_h107 = _source17.dtor_name;
            DAST._IType _354___mcc_h108 = _source17.dtor_typ;
            DAST._IExpression _355___mcc_h109 = _source17.dtor_value;
            DAST._IExpression _356___mcc_h110 = _source17.dtor_iifeBody;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _357___mcc_h115 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _358___mcc_h116 = _source17.dtor_args;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _359___mcc_h119 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _360___mcc_h120 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _361___mcc_h121 = _source17.dtor_variant;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _362___mcc_h125 = _source17.dtor_typ;
            {
              _305_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _363_receiver;
          _363_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _291_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _364___mcc_h127 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _365_outVars = _364___mcc_h127;
            {
              if ((new BigInteger((_365_outVars).Count)) > (BigInteger.One)) {
                _363_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _366_outI;
              _366_outI = BigInteger.Zero;
              while ((_366_outI) < (new BigInteger((_365_outVars).Count))) {
                if ((_366_outI).Sign == 1) {
                  _363_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_363_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _367_outVar;
                _367_outVar = (_365_outVars).Select(_366_outI);
                _363_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_363_receiver, (_367_outVar));
                _366_outI = (_366_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_365_outVars).Count)) > (BigInteger.One)) {
                _363_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_363_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_363_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_363_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _305_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _294_name), _296_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _299_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _368___mcc_h16 = _source15.dtor_expr;
        DAST._IExpression _369_expr = _368___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _370_exprString;
          bool _371___v22;
          bool _372_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _373_recIdents;
          Dafny.ISequence<Dafny.Rune> _out112;
          bool _out113;
          bool _out114;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
          DCOMP.COMP.GenExpr(_369_expr, selfIdent, @params, true, out _out112, out _out113, out _out114, out _out115);
          _370_exprString = _out112;
          _371___v22 = _out113;
          _372_recErased = _out114;
          _373_recIdents = _out115;
          _370_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _370_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _373_recIdents;
          if (isLast) {
            generated = _370_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _370_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_TailRecursive) {
        Dafny.ISequence<DAST._IStatement> _374___mcc_h17 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _375_body = _374___mcc_h17;
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if (!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#_this = self.clone();\n"));
          }
          BigInteger _376_paramI;
          _376_paramI = BigInteger.Zero;
          while ((_376_paramI) < (new BigInteger((@params).Count))) {
            Dafny.ISequence<Dafny.Rune> _377_param;
            _377_param = (@params).Select(_376_paramI);
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#")), _377_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _377_param), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
            _376_paramI = (_376_paramI) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _378_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _379_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out116;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
          DCOMP.COMP.GenStmts(_375_body, ((!object.Equals(selfIdent, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())) ? (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_Some(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_this"))) : (DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None())), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), false, earlyReturn, out _out116, out _out117);
          _378_bodyString = _out116;
          _379_bodyIdents = _out117;
          readIdents = _379_bodyIdents;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("'TAIL_CALL_START: loop {\n")), _378_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
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
        DAST._IExpression _380___mcc_h18 = _source15.dtor_Print_a0;
        DAST._IExpression _381_e = _380___mcc_h18;
        {
          Dafny.ISequence<Dafny.Rune> _382_printedExpr;
          bool _383_isOwned;
          bool _384___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _385_recIdents;
          Dafny.ISequence<Dafny.Rune> _out118;
          bool _out119;
          bool _out120;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out121;
          DCOMP.COMP.GenExpr(_381_e, selfIdent, @params, false, out _out118, out _out119, out _out120, out _out121);
          _382_printedExpr = _out118;
          _383_isOwned = _out119;
          _384___v23 = _out120;
          _385_recIdents = _out121;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_383_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _382_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _385_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, DAST._IOptional<Dafny.ISequence<Dafny.Rune>> selfIdent, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source19 = e;
      if (_source19.is_Literal) {
        DAST._ILiteral _386___mcc_h0 = _source19.dtor_Literal_a0;
        DAST._ILiteral _source20 = _386___mcc_h0;
        if (_source20.is_BoolLiteral) {
          bool _387___mcc_h1 = _source20.dtor_BoolLiteral_a0;
          if ((_387___mcc_h1) == (false)) {
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
        } else if (_source20.is_IntLiteral) {
          Dafny.ISequence<Dafny.Rune> _388___mcc_h2 = _source20.dtor_IntLiteral_a0;
          DAST._IType _389___mcc_h3 = _source20.dtor_IntLiteral_a1;
          DAST._IType _390_t = _389___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _391_i = _388___mcc_h2;
          {
            DAST._IType _source21 = _390_t;
            if (_source21.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _392___mcc_h62 = _source21.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _393___mcc_h63 = _source21.dtor_typeArgs;
              DAST._IResolvedType _394___mcc_h64 = _source21.dtor_resolved;
              {
                s = _391_i;
              }
            } else if (_source21.is_Nullable) {
              DAST._IType _395___mcc_h68 = _source21.dtor_Nullable_a0;
              {
                s = _391_i;
              }
            } else if (_source21.is_Tuple) {
              Dafny.ISequence<DAST._IType> _396___mcc_h70 = _source21.dtor_Tuple_a0;
              {
                s = _391_i;
              }
            } else if (_source21.is_Array) {
              DAST._IType _397___mcc_h72 = _source21.dtor_element;
              {
                s = _391_i;
              }
            } else if (_source21.is_Seq) {
              DAST._IType _398___mcc_h74 = _source21.dtor_element;
              {
                s = _391_i;
              }
            } else if (_source21.is_Set) {
              DAST._IType _399___mcc_h76 = _source21.dtor_element;
              {
                s = _391_i;
              }
            } else if (_source21.is_Multiset) {
              DAST._IType _400___mcc_h78 = _source21.dtor_element;
              {
                s = _391_i;
              }
            } else if (_source21.is_Map) {
              DAST._IType _401___mcc_h80 = _source21.dtor_key;
              DAST._IType _402___mcc_h81 = _source21.dtor_value;
              {
                s = _391_i;
              }
            } else if (_source21.is_Arrow) {
              Dafny.ISequence<DAST._IType> _403___mcc_h84 = _source21.dtor_args;
              DAST._IType _404___mcc_h85 = _source21.dtor_result;
              {
                s = _391_i;
              }
            } else if (_source21.is_Primitive) {
              DAST._IPrimitive _405___mcc_h88 = _source21.dtor_Primitive_a0;
              DAST._IPrimitive _source22 = _405___mcc_h88;
              if (_source22.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _391_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source22.is_Real) {
                {
                  s = _391_i;
                }
              } else if (_source22.is_String) {
                {
                  s = _391_i;
                }
              } else if (_source22.is_Bool) {
                {
                  s = _391_i;
                }
              } else {
                {
                  s = _391_i;
                }
              }
            } else if (_source21.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _406___mcc_h90 = _source21.dtor_Passthrough_a0;
              {
                s = _391_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _407___mcc_h92 = _source21.dtor_TypeArg_a0;
              {
                s = _391_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _408___mcc_h4 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _409___mcc_h5 = _source20.dtor_DecLiteral_a1;
          DAST._IType _410___mcc_h6 = _source20.dtor_DecLiteral_a2;
          DAST._IType _411_t = _410___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _412_d = _409___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _413_n = _408___mcc_h4;
          {
            DAST._IType _source23 = _411_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _414___mcc_h94 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _415___mcc_h95 = _source23.dtor_typeArgs;
              DAST._IResolvedType _416___mcc_h96 = _source23.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Nullable) {
              DAST._IType _417___mcc_h100 = _source23.dtor_Nullable_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _418___mcc_h102 = _source23.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Array) {
              DAST._IType _419___mcc_h104 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Seq) {
              DAST._IType _420___mcc_h106 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Set) {
              DAST._IType _421___mcc_h108 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _422___mcc_h110 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Map) {
              DAST._IType _423___mcc_h112 = _source23.dtor_key;
              DAST._IType _424___mcc_h113 = _source23.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _425___mcc_h116 = _source23.dtor_args;
              DAST._IType _426___mcc_h117 = _source23.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _427___mcc_h120 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _427___mcc_h120;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _413_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source24.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _428___mcc_h122 = _source23.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _429___mcc_h124 = _source23.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_413_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _412_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _430___mcc_h7 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _431_l = _430___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _431_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _432___mcc_h8 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _433_c = _432___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_433_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
      } else if (_source19.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _434___mcc_h9 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _435_name = _434___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _435_name);
          if (!((@params).Contains(_435_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_435_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _436___mcc_h10 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _437_path = _436___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out122;
          _out122 = DCOMP.COMP.GenPath(_437_path);
          s = _out122;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _438___mcc_h11 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _439_values = _438___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _440_i;
          _440_i = BigInteger.Zero;
          bool _441_allErased;
          _441_allErased = true;
          while ((_440_i) < (new BigInteger((_439_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _442___v26;
            bool _443___v27;
            bool _444_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _445___v28;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_439_values).Select(_440_i), selfIdent, @params, true, out _out123, out _out124, out _out125, out _out126);
            _442___v26 = _out123;
            _443___v27 = _out124;
            _444_isErased = _out125;
            _445___v28 = _out126;
            _441_allErased = (_441_allErased) && (_444_isErased);
            _440_i = (_440_i) + (BigInteger.One);
          }
          _440_i = BigInteger.Zero;
          while ((_440_i) < (new BigInteger((_439_values).Count))) {
            if ((_440_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _446_recursiveGen;
            bool _447___v29;
            bool _448_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _449_recIdents;
            Dafny.ISequence<Dafny.Rune> _out127;
            bool _out128;
            bool _out129;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out130;
            DCOMP.COMP.GenExpr((_439_values).Select(_440_i), selfIdent, @params, true, out _out127, out _out128, out _out129, out _out130);
            _446_recursiveGen = _out127;
            _447___v29 = _out128;
            _448_isErased = _out129;
            _449_recIdents = _out130;
            if ((_448_isErased) && (!(_441_allErased))) {
              _446_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _449_recIdents);
            _440_i = (_440_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _441_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _450___mcc_h12 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _451___mcc_h13 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _452_args = _451___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _453_path = _450___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _454_path;
          Dafny.ISequence<Dafny.Rune> _out131;
          _out131 = DCOMP.COMP.GenPath(_453_path);
          _454_path = _out131;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _454_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _455_i;
          _455_i = BigInteger.Zero;
          while ((_455_i) < (new BigInteger((_452_args).Count))) {
            if ((_455_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _456_recursiveGen;
            bool _457___v30;
            bool _458_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _459_recIdents;
            Dafny.ISequence<Dafny.Rune> _out132;
            bool _out133;
            bool _out134;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
            DCOMP.COMP.GenExpr((_452_args).Select(_455_i), selfIdent, @params, true, out _out132, out _out133, out _out134, out _out135);
            _456_recursiveGen = _out132;
            _457___v30 = _out133;
            _458_isErased = _out134;
            _459_recIdents = _out135;
            if (_458_isErased) {
              _456_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _456_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _456_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _459_recIdents);
            _455_i = (_455_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _460___mcc_h14 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _461_dims = _460___mcc_h14;
        {
          BigInteger _462_i;
          _462_i = (new BigInteger((_461_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_462_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _463_recursiveGen;
            bool _464___v31;
            bool _465_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _466_recIdents;
            Dafny.ISequence<Dafny.Rune> _out136;
            bool _out137;
            bool _out138;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
            DCOMP.COMP.GenExpr((_461_dims).Select(_462_i), selfIdent, @params, true, out _out136, out _out137, out _out138, out _out139);
            _463_recursiveGen = _out136;
            _464___v31 = _out137;
            _465_isErased = _out138;
            _466_recIdents = _out139;
            if (!(_465_isErased)) {
              _463_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _466_recIdents);
            _462_i = (_462_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _467___mcc_h15 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _468___mcc_h16 = _source19.dtor_variant;
        bool _469___mcc_h17 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _470___mcc_h18 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _471_values = _470___mcc_h18;
        bool _472_isCo = _469___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _473_variant = _468___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _474_path = _467___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _475_path;
          Dafny.ISequence<Dafny.Rune> _out140;
          _out140 = DCOMP.COMP.GenPath(_474_path);
          _475_path = _out140;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _475_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _473_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _476_i;
          _476_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_476_i) < (new BigInteger((_471_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_471_values).Select(_476_i);
            Dafny.ISequence<Dafny.Rune> _477_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _478_value = _let_tmp_rhs0.dtor__1;
            if ((_476_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_472_isCo) {
              Dafny.ISequence<Dafny.Rune> _479_recursiveGen;
              bool _480___v32;
              bool _481_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _482_recIdents;
              Dafny.ISequence<Dafny.Rune> _out141;
              bool _out142;
              bool _out143;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out144;
              DCOMP.COMP.GenExpr(_478_value, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out141, out _out142, out _out143, out _out144);
              _479_recursiveGen = _out141;
              _480___v32 = _out142;
              _481_isErased = _out143;
              _482_recIdents = _out144;
              if (!(_481_isErased)) {
                _479_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _479_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _482_recIdents);
              Dafny.ISequence<Dafny.Rune> _483_allReadCloned;
              _483_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_482_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _484_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_482_recIdents).Elements) {
                  _484_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_482_recIdents).Contains(_484_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1140)");
              after__ASSIGN_SUCH_THAT_0:;
                _483_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_483_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _484_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _484_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _482_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_482_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_484_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _477_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _483_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _485_recursiveGen;
              bool _486___v33;
              bool _487_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _488_recIdents;
              Dafny.ISequence<Dafny.Rune> _out145;
              bool _out146;
              bool _out147;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
              DCOMP.COMP.GenExpr(_478_value, selfIdent, @params, true, out _out145, out _out146, out _out147, out _out148);
              _485_recursiveGen = _out145;
              _486___v33 = _out146;
              _487_isErased = _out147;
              _488_recIdents = _out148;
              if (!(_487_isErased)) {
                _485_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _485_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _477_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _488_recIdents);
            }
            _476_i = (_476_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _489___mcc_h19 = _source19.dtor_value;
        DAST._IType _490___mcc_h20 = _source19.dtor_from;
        DAST._IType _491___mcc_h21 = _source19.dtor_typ;
        DAST._IType _492_toTpe = _491___mcc_h21;
        DAST._IType _493_fromTpe = _490___mcc_h20;
        DAST._IExpression _494_expr = _489___mcc_h19;
        {
          if (object.Equals(_493_fromTpe, _492_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _495_recursiveGen;
            bool _496_recOwned;
            bool _497_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _498_recIdents;
            Dafny.ISequence<Dafny.Rune> _out149;
            bool _out150;
            bool _out151;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
            DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
            _495_recursiveGen = _out149;
            _496_recOwned = _out150;
            _497_recErased = _out151;
            _498_recIdents = _out152;
            s = _495_recursiveGen;
            isOwned = _496_recOwned;
            isErased = _497_recErased;
            readIdents = _498_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source25 = _System.Tuple2<DAST._IType, DAST._IType>.create(_493_fromTpe, _492_toTpe);
            DAST._IType _499___mcc_h126 = _source25.dtor__0;
            DAST._IType _500___mcc_h127 = _source25.dtor__1;
            DAST._IType _source26 = _499___mcc_h126;
            if (_source26.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _501___mcc_h130 = _source26.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _502___mcc_h131 = _source26.dtor_typeArgs;
              DAST._IResolvedType _503___mcc_h132 = _source26.dtor_resolved;
              DAST._IResolvedType _source27 = _503___mcc_h132;
              if (_source27.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _504___mcc_h142 = _source27.dtor_path;
                DAST._IType _source28 = _500___mcc_h127;
                if (_source28.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _505___mcc_h146 = _source28.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _506___mcc_h147 = _source28.dtor_typeArgs;
                  DAST._IResolvedType _507___mcc_h148 = _source28.dtor_resolved;
                  DAST._IResolvedType _source29 = _507___mcc_h148;
                  if (_source29.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _508___mcc_h152 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _509_recursiveGen;
                      bool _510_recOwned;
                      bool _511_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _512_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out153;
                      bool _out154;
                      bool _out155;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                      _509_recursiveGen = _out153;
                      _510_recOwned = _out154;
                      _511_recErased = _out155;
                      _512_recIdents = _out156;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _510_recOwned;
                      isErased = _511_recErased;
                      readIdents = _512_recIdents;
                    }
                  } else if (_source29.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _513___mcc_h154 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _514_recursiveGen;
                      bool _515_recOwned;
                      bool _516_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _517_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out157;
                      bool _out158;
                      bool _out159;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
                      _514_recursiveGen = _out157;
                      _515_recOwned = _out158;
                      _516_recErased = _out159;
                      _517_recIdents = _out160;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _515_recOwned;
                      isErased = _516_recErased;
                      readIdents = _517_recIdents;
                    }
                  } else {
                    DAST._IType _518___mcc_h156 = _source29.dtor_Newtype_a0;
                    DAST._IType _519_b = _518___mcc_h156;
                    {
                      if (object.Equals(_493_fromTpe, _519_b)) {
                        Dafny.ISequence<Dafny.Rune> _520_recursiveGen;
                        bool _521_recOwned;
                        bool _522_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _523_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out161;
                        bool _out162;
                        bool _out163;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                        _520_recursiveGen = _out161;
                        _521_recOwned = _out162;
                        _522_recErased = _out163;
                        _523_recIdents = _out164;
                        Dafny.ISequence<Dafny.Rune> _524_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out165;
                        _out165 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _524_rhsType = _out165;
                        Dafny.ISequence<Dafny.Rune> _525_uneraseFn;
                        _525_uneraseFn = ((_521_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _524_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _525_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _521_recOwned;
                        isErased = false;
                        readIdents = _523_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out166;
                        bool _out167;
                        bool _out168;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out169;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _519_b), _519_b, _492_toTpe), selfIdent, @params, mustOwn, out _out166, out _out167, out _out168, out _out169);
                        s = _out166;
                        isOwned = _out167;
                        isErased = _out168;
                        readIdents = _out169;
                      }
                    }
                  }
                } else if (_source28.is_Nullable) {
                  DAST._IType _526___mcc_h158 = _source28.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _527_recursiveGen;
                    bool _528_recOwned;
                    bool _529_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _530_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out170;
                    bool _out171;
                    bool _out172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out173;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out170, out _out171, out _out172, out _out173);
                    _527_recursiveGen = _out170;
                    _528_recOwned = _out171;
                    _529_recErased = _out172;
                    _530_recIdents = _out173;
                    if (!(_528_recOwned)) {
                      _527_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_527_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _529_recErased;
                    readIdents = _530_recIdents;
                  }
                } else if (_source28.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _531___mcc_h160 = _source28.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _532_recursiveGen;
                    bool _533_recOwned;
                    bool _534_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _535_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out174;
                    bool _out175;
                    bool _out176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out177;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out174, out _out175, out _out176, out _out177);
                    _532_recursiveGen = _out174;
                    _533_recOwned = _out175;
                    _534_recErased = _out176;
                    _535_recIdents = _out177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _532_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _533_recOwned;
                    isErased = _534_recErased;
                    readIdents = _535_recIdents;
                  }
                } else if (_source28.is_Array) {
                  DAST._IType _536___mcc_h162 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _537_recursiveGen;
                    bool _538_recOwned;
                    bool _539_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _540_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out178;
                    bool _out179;
                    bool _out180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out181;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out178, out _out179, out _out180, out _out181);
                    _537_recursiveGen = _out178;
                    _538_recOwned = _out179;
                    _539_recErased = _out180;
                    _540_recIdents = _out181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _537_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _538_recOwned;
                    isErased = _539_recErased;
                    readIdents = _540_recIdents;
                  }
                } else if (_source28.is_Seq) {
                  DAST._IType _541___mcc_h164 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _542_recursiveGen;
                    bool _543_recOwned;
                    bool _544_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _545_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out182;
                    bool _out183;
                    bool _out184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out185;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out182, out _out183, out _out184, out _out185);
                    _542_recursiveGen = _out182;
                    _543_recOwned = _out183;
                    _544_recErased = _out184;
                    _545_recIdents = _out185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _542_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _543_recOwned;
                    isErased = _544_recErased;
                    readIdents = _545_recIdents;
                  }
                } else if (_source28.is_Set) {
                  DAST._IType _546___mcc_h166 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _547_recursiveGen;
                    bool _548_recOwned;
                    bool _549_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _550_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out186;
                    bool _out187;
                    bool _out188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out189;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out186, out _out187, out _out188, out _out189);
                    _547_recursiveGen = _out186;
                    _548_recOwned = _out187;
                    _549_recErased = _out188;
                    _550_recIdents = _out189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _547_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _548_recOwned;
                    isErased = _549_recErased;
                    readIdents = _550_recIdents;
                  }
                } else if (_source28.is_Multiset) {
                  DAST._IType _551___mcc_h168 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _552_recursiveGen;
                    bool _553_recOwned;
                    bool _554_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _555_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out190;
                    bool _out191;
                    bool _out192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out193;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out190, out _out191, out _out192, out _out193);
                    _552_recursiveGen = _out190;
                    _553_recOwned = _out191;
                    _554_recErased = _out192;
                    _555_recIdents = _out193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _553_recOwned;
                    isErased = _554_recErased;
                    readIdents = _555_recIdents;
                  }
                } else if (_source28.is_Map) {
                  DAST._IType _556___mcc_h170 = _source28.dtor_key;
                  DAST._IType _557___mcc_h171 = _source28.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _558_recursiveGen;
                    bool _559_recOwned;
                    bool _560_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _561_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out194;
                    bool _out195;
                    bool _out196;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out197;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out194, out _out195, out _out196, out _out197);
                    _558_recursiveGen = _out194;
                    _559_recOwned = _out195;
                    _560_recErased = _out196;
                    _561_recIdents = _out197;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _558_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _559_recOwned;
                    isErased = _560_recErased;
                    readIdents = _561_recIdents;
                  }
                } else if (_source28.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _562___mcc_h174 = _source28.dtor_args;
                  DAST._IType _563___mcc_h175 = _source28.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _564_recursiveGen;
                    bool _565_recOwned;
                    bool _566_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _567_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out198;
                    bool _out199;
                    bool _out200;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                    _564_recursiveGen = _out198;
                    _565_recOwned = _out199;
                    _566_recErased = _out200;
                    _567_recIdents = _out201;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _564_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _565_recOwned;
                    isErased = _566_recErased;
                    readIdents = _567_recIdents;
                  }
                } else if (_source28.is_Primitive) {
                  DAST._IPrimitive _568___mcc_h178 = _source28.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _569_recursiveGen;
                    bool _570_recOwned;
                    bool _571_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _572_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out202;
                    bool _out203;
                    bool _out204;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                    _569_recursiveGen = _out202;
                    _570_recOwned = _out203;
                    _571_recErased = _out204;
                    _572_recIdents = _out205;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _569_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _570_recOwned;
                    isErased = _571_recErased;
                    readIdents = _572_recIdents;
                  }
                } else if (_source28.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _573___mcc_h180 = _source28.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _574_recursiveGen;
                    bool _575_recOwned;
                    bool _576_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _577_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out206;
                    bool _out207;
                    bool _out208;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                    _574_recursiveGen = _out206;
                    _575_recOwned = _out207;
                    _576_recErased = _out208;
                    _577_recIdents = _out209;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _574_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _575_recOwned;
                    isErased = _576_recErased;
                    readIdents = _577_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _578___mcc_h182 = _source28.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _579_recursiveGen;
                    bool _580_recOwned;
                    bool _581_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _582_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out210;
                    bool _out211;
                    bool _out212;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                    _579_recursiveGen = _out210;
                    _580_recOwned = _out211;
                    _581_recErased = _out212;
                    _582_recIdents = _out213;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _579_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _580_recOwned;
                    isErased = _581_recErased;
                    readIdents = _582_recIdents;
                  }
                }
              } else if (_source27.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _583___mcc_h184 = _source27.dtor_path;
                DAST._IType _source30 = _500___mcc_h127;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _584___mcc_h188 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _585___mcc_h189 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _586___mcc_h190 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _586___mcc_h190;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _587___mcc_h194 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _588_recursiveGen;
                      bool _589_recOwned;
                      bool _590_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _591_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out214;
                      bool _out215;
                      bool _out216;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                      _588_recursiveGen = _out214;
                      _589_recOwned = _out215;
                      _590_recErased = _out216;
                      _591_recIdents = _out217;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _588_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _589_recOwned;
                      isErased = _590_recErased;
                      readIdents = _591_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _592___mcc_h196 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _593_recursiveGen;
                      bool _594_recOwned;
                      bool _595_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _596_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out218;
                      bool _out219;
                      bool _out220;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                      _593_recursiveGen = _out218;
                      _594_recOwned = _out219;
                      _595_recErased = _out220;
                      _596_recIdents = _out221;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _593_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _594_recOwned;
                      isErased = _595_recErased;
                      readIdents = _596_recIdents;
                    }
                  } else {
                    DAST._IType _597___mcc_h198 = _source31.dtor_Newtype_a0;
                    DAST._IType _598_b = _597___mcc_h198;
                    {
                      if (object.Equals(_493_fromTpe, _598_b)) {
                        Dafny.ISequence<Dafny.Rune> _599_recursiveGen;
                        bool _600_recOwned;
                        bool _601_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _602_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out222;
                        bool _out223;
                        bool _out224;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                        _599_recursiveGen = _out222;
                        _600_recOwned = _out223;
                        _601_recErased = _out224;
                        _602_recIdents = _out225;
                        Dafny.ISequence<Dafny.Rune> _603_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out226;
                        _out226 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _603_rhsType = _out226;
                        Dafny.ISequence<Dafny.Rune> _604_uneraseFn;
                        _604_uneraseFn = ((_600_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _603_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _604_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _599_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _600_recOwned;
                        isErased = false;
                        readIdents = _602_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out227;
                        bool _out228;
                        bool _out229;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out230;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _598_b), _598_b, _492_toTpe), selfIdent, @params, mustOwn, out _out227, out _out228, out _out229, out _out230);
                        s = _out227;
                        isOwned = _out228;
                        isErased = _out229;
                        readIdents = _out230;
                      }
                    }
                  }
                } else if (_source30.is_Nullable) {
                  DAST._IType _605___mcc_h200 = _source30.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _606_recursiveGen;
                    bool _607_recOwned;
                    bool _608_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _609_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out231;
                    bool _out232;
                    bool _out233;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out234;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out231, out _out232, out _out233, out _out234);
                    _606_recursiveGen = _out231;
                    _607_recOwned = _out232;
                    _608_recErased = _out233;
                    _609_recIdents = _out234;
                    if (!(_607_recOwned)) {
                      _606_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_606_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _606_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _608_recErased;
                    readIdents = _609_recIdents;
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _610___mcc_h202 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _611_recursiveGen;
                    bool _612_recOwned;
                    bool _613_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _614_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out235;
                    bool _out236;
                    bool _out237;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out238;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out235, out _out236, out _out237, out _out238);
                    _611_recursiveGen = _out235;
                    _612_recOwned = _out236;
                    _613_recErased = _out237;
                    _614_recIdents = _out238;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _611_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _612_recOwned;
                    isErased = _613_recErased;
                    readIdents = _614_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _615___mcc_h204 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _616_recursiveGen;
                    bool _617_recOwned;
                    bool _618_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _619_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out239;
                    bool _out240;
                    bool _out241;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out242;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out239, out _out240, out _out241, out _out242);
                    _616_recursiveGen = _out239;
                    _617_recOwned = _out240;
                    _618_recErased = _out241;
                    _619_recIdents = _out242;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _616_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _617_recOwned;
                    isErased = _618_recErased;
                    readIdents = _619_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _620___mcc_h206 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _621_recursiveGen;
                    bool _622_recOwned;
                    bool _623_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _624_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out243;
                    bool _out244;
                    bool _out245;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out246;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out243, out _out244, out _out245, out _out246);
                    _621_recursiveGen = _out243;
                    _622_recOwned = _out244;
                    _623_recErased = _out245;
                    _624_recIdents = _out246;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _621_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _622_recOwned;
                    isErased = _623_recErased;
                    readIdents = _624_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _625___mcc_h208 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _626_recursiveGen;
                    bool _627_recOwned;
                    bool _628_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _629_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out247;
                    bool _out248;
                    bool _out249;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out250;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out247, out _out248, out _out249, out _out250);
                    _626_recursiveGen = _out247;
                    _627_recOwned = _out248;
                    _628_recErased = _out249;
                    _629_recIdents = _out250;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _627_recOwned;
                    isErased = _628_recErased;
                    readIdents = _629_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _630___mcc_h210 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _631_recursiveGen;
                    bool _632_recOwned;
                    bool _633_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _634_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out251;
                    bool _out252;
                    bool _out253;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                    _631_recursiveGen = _out251;
                    _632_recOwned = _out252;
                    _633_recErased = _out253;
                    _634_recIdents = _out254;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _632_recOwned;
                    isErased = _633_recErased;
                    readIdents = _634_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _635___mcc_h212 = _source30.dtor_key;
                  DAST._IType _636___mcc_h213 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _637_recursiveGen;
                    bool _638_recOwned;
                    bool _639_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _640_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out255;
                    bool _out256;
                    bool _out257;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                    _637_recursiveGen = _out255;
                    _638_recOwned = _out256;
                    _639_recErased = _out257;
                    _640_recIdents = _out258;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _637_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _638_recOwned;
                    isErased = _639_recErased;
                    readIdents = _640_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _641___mcc_h216 = _source30.dtor_args;
                  DAST._IType _642___mcc_h217 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _643_recursiveGen;
                    bool _644_recOwned;
                    bool _645_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _646_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out259;
                    bool _out260;
                    bool _out261;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                    _643_recursiveGen = _out259;
                    _644_recOwned = _out260;
                    _645_recErased = _out261;
                    _646_recIdents = _out262;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _643_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _644_recOwned;
                    isErased = _645_recErased;
                    readIdents = _646_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _647___mcc_h220 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _648_recursiveGen;
                    bool _649_recOwned;
                    bool _650_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _651_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out263;
                    bool _out264;
                    bool _out265;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                    _648_recursiveGen = _out263;
                    _649_recOwned = _out264;
                    _650_recErased = _out265;
                    _651_recIdents = _out266;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _648_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _649_recOwned;
                    isErased = _650_recErased;
                    readIdents = _651_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _652___mcc_h222 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _653_recursiveGen;
                    bool _654_recOwned;
                    bool _655_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _656_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out267;
                    bool _out268;
                    bool _out269;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                    _653_recursiveGen = _out267;
                    _654_recOwned = _out268;
                    _655_recErased = _out269;
                    _656_recIdents = _out270;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _654_recOwned;
                    isErased = _655_recErased;
                    readIdents = _656_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _657___mcc_h224 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _658_recursiveGen;
                    bool _659_recOwned;
                    bool _660_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _661_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out271;
                    bool _out272;
                    bool _out273;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                    _658_recursiveGen = _out271;
                    _659_recOwned = _out272;
                    _660_recErased = _out273;
                    _661_recIdents = _out274;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _658_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _659_recOwned;
                    isErased = _660_recErased;
                    readIdents = _661_recIdents;
                  }
                }
              } else {
                DAST._IType _662___mcc_h226 = _source27.dtor_Newtype_a0;
                DAST._IType _source32 = _500___mcc_h127;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _663___mcc_h230 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _664___mcc_h231 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _665___mcc_h232 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _665___mcc_h232;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _666___mcc_h239 = _source33.dtor_path;
                    DAST._IType _667_b = _662___mcc_h226;
                    {
                      if (object.Equals(_667_b, _492_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _668_recursiveGen;
                        bool _669_recOwned;
                        bool _670_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _671_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out275;
                        bool _out276;
                        bool _out277;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                        _668_recursiveGen = _out275;
                        _669_recOwned = _out276;
                        _670_recErased = _out277;
                        _671_recIdents = _out278;
                        Dafny.ISequence<Dafny.Rune> _672_uneraseFn;
                        _672_uneraseFn = ((_669_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _672_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _668_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _669_recOwned;
                        isErased = true;
                        readIdents = _671_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out279;
                        bool _out280;
                        bool _out281;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _667_b), _667_b, _492_toTpe), selfIdent, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                        s = _out279;
                        isOwned = _out280;
                        isErased = _out281;
                        readIdents = _out282;
                      }
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _673___mcc_h242 = _source33.dtor_path;
                    DAST._IType _674_b = _662___mcc_h226;
                    {
                      if (object.Equals(_674_b, _492_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _675_recursiveGen;
                        bool _676_recOwned;
                        bool _677_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _678_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out283;
                        bool _out284;
                        bool _out285;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                        _675_recursiveGen = _out283;
                        _676_recOwned = _out284;
                        _677_recErased = _out285;
                        _678_recIdents = _out286;
                        Dafny.ISequence<Dafny.Rune> _679_uneraseFn;
                        _679_uneraseFn = ((_676_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _679_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _676_recOwned;
                        isErased = true;
                        readIdents = _678_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out287;
                        bool _out288;
                        bool _out289;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _674_b), _674_b, _492_toTpe), selfIdent, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                        s = _out287;
                        isOwned = _out288;
                        isErased = _out289;
                        readIdents = _out290;
                      }
                    }
                  } else {
                    DAST._IType _680___mcc_h245 = _source33.dtor_Newtype_a0;
                    DAST._IType _681_b = _680___mcc_h245;
                    {
                      if (object.Equals(_493_fromTpe, _681_b)) {
                        Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                        bool _683_recOwned;
                        bool _684_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out291;
                        bool _out292;
                        bool _out293;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                        _682_recursiveGen = _out291;
                        _683_recOwned = _out292;
                        _684_recErased = _out293;
                        _685_recIdents = _out294;
                        Dafny.ISequence<Dafny.Rune> _686_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out295;
                        _out295 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _686_rhsType = _out295;
                        Dafny.ISequence<Dafny.Rune> _687_uneraseFn;
                        _687_uneraseFn = ((_683_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _686_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _687_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _683_recOwned;
                        isErased = false;
                        readIdents = _685_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out296;
                        bool _out297;
                        bool _out298;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out299;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _681_b), _681_b, _492_toTpe), selfIdent, @params, mustOwn, out _out296, out _out297, out _out298, out _out299);
                        s = _out296;
                        isOwned = _out297;
                        isErased = _out298;
                        readIdents = _out299;
                      }
                    }
                  }
                } else if (_source32.is_Nullable) {
                  DAST._IType _688___mcc_h248 = _source32.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                    bool _690_recOwned;
                    bool _691_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out300;
                    bool _out301;
                    bool _out302;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out303;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out300, out _out301, out _out302, out _out303);
                    _689_recursiveGen = _out300;
                    _690_recOwned = _out301;
                    _691_recErased = _out302;
                    _692_recIdents = _out303;
                    if (!(_690_recOwned)) {
                      _689_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_689_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _691_recErased;
                    readIdents = _692_recIdents;
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _693___mcc_h251 = _source32.dtor_Tuple_a0;
                  DAST._IType _694_b = _662___mcc_h226;
                  {
                    if (object.Equals(_694_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _695_recursiveGen;
                      bool _696_recOwned;
                      bool _697_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _698_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out304;
                      bool _out305;
                      bool _out306;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                      _695_recursiveGen = _out304;
                      _696_recOwned = _out305;
                      _697_recErased = _out306;
                      _698_recIdents = _out307;
                      Dafny.ISequence<Dafny.Rune> _699_uneraseFn;
                      _699_uneraseFn = ((_696_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _699_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _695_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _696_recOwned;
                      isErased = true;
                      readIdents = _698_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out308;
                      bool _out309;
                      bool _out310;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _694_b), _694_b, _492_toTpe), selfIdent, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                      s = _out308;
                      isOwned = _out309;
                      isErased = _out310;
                      readIdents = _out311;
                    }
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _700___mcc_h254 = _source32.dtor_element;
                  DAST._IType _701_b = _662___mcc_h226;
                  {
                    if (object.Equals(_701_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _702_recursiveGen;
                      bool _703_recOwned;
                      bool _704_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _705_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out312;
                      bool _out313;
                      bool _out314;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                      _702_recursiveGen = _out312;
                      _703_recOwned = _out313;
                      _704_recErased = _out314;
                      _705_recIdents = _out315;
                      Dafny.ISequence<Dafny.Rune> _706_uneraseFn;
                      _706_uneraseFn = ((_703_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _706_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _702_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _703_recOwned;
                      isErased = true;
                      readIdents = _705_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out316;
                      bool _out317;
                      bool _out318;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _701_b), _701_b, _492_toTpe), selfIdent, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                      s = _out316;
                      isOwned = _out317;
                      isErased = _out318;
                      readIdents = _out319;
                    }
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _707___mcc_h257 = _source32.dtor_element;
                  DAST._IType _708_b = _662___mcc_h226;
                  {
                    if (object.Equals(_708_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _709_recursiveGen;
                      bool _710_recOwned;
                      bool _711_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _712_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out320;
                      bool _out321;
                      bool _out322;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                      _709_recursiveGen = _out320;
                      _710_recOwned = _out321;
                      _711_recErased = _out322;
                      _712_recIdents = _out323;
                      Dafny.ISequence<Dafny.Rune> _713_uneraseFn;
                      _713_uneraseFn = ((_710_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _713_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _709_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _710_recOwned;
                      isErased = true;
                      readIdents = _712_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out324;
                      bool _out325;
                      bool _out326;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _708_b), _708_b, _492_toTpe), selfIdent, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                      s = _out324;
                      isOwned = _out325;
                      isErased = _out326;
                      readIdents = _out327;
                    }
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _714___mcc_h260 = _source32.dtor_element;
                  DAST._IType _715_b = _662___mcc_h226;
                  {
                    if (object.Equals(_715_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _716_recursiveGen;
                      bool _717_recOwned;
                      bool _718_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _719_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out328;
                      bool _out329;
                      bool _out330;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                      _716_recursiveGen = _out328;
                      _717_recOwned = _out329;
                      _718_recErased = _out330;
                      _719_recIdents = _out331;
                      Dafny.ISequence<Dafny.Rune> _720_uneraseFn;
                      _720_uneraseFn = ((_717_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _720_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _717_recOwned;
                      isErased = true;
                      readIdents = _719_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out332;
                      bool _out333;
                      bool _out334;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _715_b), _715_b, _492_toTpe), selfIdent, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                      s = _out332;
                      isOwned = _out333;
                      isErased = _out334;
                      readIdents = _out335;
                    }
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _721___mcc_h263 = _source32.dtor_element;
                  DAST._IType _722_b = _662___mcc_h226;
                  {
                    if (object.Equals(_722_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _723_recursiveGen;
                      bool _724_recOwned;
                      bool _725_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _726_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out336;
                      bool _out337;
                      bool _out338;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                      _723_recursiveGen = _out336;
                      _724_recOwned = _out337;
                      _725_recErased = _out338;
                      _726_recIdents = _out339;
                      Dafny.ISequence<Dafny.Rune> _727_uneraseFn;
                      _727_uneraseFn = ((_724_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _727_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _724_recOwned;
                      isErased = true;
                      readIdents = _726_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out340;
                      bool _out341;
                      bool _out342;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _722_b), _722_b, _492_toTpe), selfIdent, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                      s = _out340;
                      isOwned = _out341;
                      isErased = _out342;
                      readIdents = _out343;
                    }
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _728___mcc_h266 = _source32.dtor_key;
                  DAST._IType _729___mcc_h267 = _source32.dtor_value;
                  DAST._IType _730_b = _662___mcc_h226;
                  {
                    if (object.Equals(_730_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _731_recursiveGen;
                      bool _732_recOwned;
                      bool _733_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _734_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out344;
                      bool _out345;
                      bool _out346;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                      _731_recursiveGen = _out344;
                      _732_recOwned = _out345;
                      _733_recErased = _out346;
                      _734_recIdents = _out347;
                      Dafny.ISequence<Dafny.Rune> _735_uneraseFn;
                      _735_uneraseFn = ((_732_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _735_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _731_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _732_recOwned;
                      isErased = true;
                      readIdents = _734_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out348;
                      bool _out349;
                      bool _out350;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _730_b), _730_b, _492_toTpe), selfIdent, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                      s = _out348;
                      isOwned = _out349;
                      isErased = _out350;
                      readIdents = _out351;
                    }
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _736___mcc_h272 = _source32.dtor_args;
                  DAST._IType _737___mcc_h273 = _source32.dtor_result;
                  DAST._IType _738_b = _662___mcc_h226;
                  {
                    if (object.Equals(_738_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _739_recursiveGen;
                      bool _740_recOwned;
                      bool _741_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _742_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out352;
                      bool _out353;
                      bool _out354;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                      _739_recursiveGen = _out352;
                      _740_recOwned = _out353;
                      _741_recErased = _out354;
                      _742_recIdents = _out355;
                      Dafny.ISequence<Dafny.Rune> _743_uneraseFn;
                      _743_uneraseFn = ((_740_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _743_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _739_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _740_recOwned;
                      isErased = true;
                      readIdents = _742_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out356;
                      bool _out357;
                      bool _out358;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out359;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _738_b), _738_b, _492_toTpe), selfIdent, @params, mustOwn, out _out356, out _out357, out _out358, out _out359);
                      s = _out356;
                      isOwned = _out357;
                      isErased = _out358;
                      readIdents = _out359;
                    }
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _744___mcc_h278 = _source32.dtor_Primitive_a0;
                  DAST._IType _745_b = _662___mcc_h226;
                  {
                    if (object.Equals(_745_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _746_recursiveGen;
                      bool _747_recOwned;
                      bool _748_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _749_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out360;
                      bool _out361;
                      bool _out362;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out363;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out360, out _out361, out _out362, out _out363);
                      _746_recursiveGen = _out360;
                      _747_recOwned = _out361;
                      _748_recErased = _out362;
                      _749_recIdents = _out363;
                      Dafny.ISequence<Dafny.Rune> _750_uneraseFn;
                      _750_uneraseFn = ((_747_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _750_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _747_recOwned;
                      isErased = true;
                      readIdents = _749_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out364;
                      bool _out365;
                      bool _out366;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out367;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _745_b), _745_b, _492_toTpe), selfIdent, @params, mustOwn, out _out364, out _out365, out _out366, out _out367);
                      s = _out364;
                      isOwned = _out365;
                      isErased = _out366;
                      readIdents = _out367;
                    }
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _751___mcc_h281 = _source32.dtor_Passthrough_a0;
                  DAST._IType _752_b = _662___mcc_h226;
                  {
                    if (object.Equals(_752_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _753_recursiveGen;
                      bool _754_recOwned;
                      bool _755_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _756_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out368;
                      bool _out369;
                      bool _out370;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out371;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out368, out _out369, out _out370, out _out371);
                      _753_recursiveGen = _out368;
                      _754_recOwned = _out369;
                      _755_recErased = _out370;
                      _756_recIdents = _out371;
                      Dafny.ISequence<Dafny.Rune> _757_uneraseFn;
                      _757_uneraseFn = ((_754_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _757_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _753_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _754_recOwned;
                      isErased = true;
                      readIdents = _756_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out372;
                      bool _out373;
                      bool _out374;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out375;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _752_b), _752_b, _492_toTpe), selfIdent, @params, mustOwn, out _out372, out _out373, out _out374, out _out375);
                      s = _out372;
                      isOwned = _out373;
                      isErased = _out374;
                      readIdents = _out375;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _758___mcc_h284 = _source32.dtor_TypeArg_a0;
                  DAST._IType _759_b = _662___mcc_h226;
                  {
                    if (object.Equals(_759_b, _492_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _760_recursiveGen;
                      bool _761_recOwned;
                      bool _762_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _763_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out376;
                      bool _out377;
                      bool _out378;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out379;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out376, out _out377, out _out378, out _out379);
                      _760_recursiveGen = _out376;
                      _761_recOwned = _out377;
                      _762_recErased = _out378;
                      _763_recIdents = _out379;
                      Dafny.ISequence<Dafny.Rune> _764_uneraseFn;
                      _764_uneraseFn = ((_761_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _764_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _760_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _761_recOwned;
                      isErased = true;
                      readIdents = _763_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out380;
                      bool _out381;
                      bool _out382;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out383;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _759_b), _759_b, _492_toTpe), selfIdent, @params, mustOwn, out _out380, out _out381, out _out382, out _out383);
                      s = _out380;
                      isOwned = _out381;
                      isErased = _out382;
                      readIdents = _out383;
                    }
                  }
                }
              }
            } else if (_source26.is_Nullable) {
              DAST._IType _765___mcc_h287 = _source26.dtor_Nullable_a0;
              DAST._IType _source34 = _500___mcc_h127;
              if (_source34.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _766___mcc_h291 = _source34.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _767___mcc_h292 = _source34.dtor_typeArgs;
                DAST._IResolvedType _768___mcc_h293 = _source34.dtor_resolved;
                DAST._IResolvedType _source35 = _768___mcc_h293;
                if (_source35.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _769___mcc_h300 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _770_recursiveGen;
                    bool _771_recOwned;
                    bool _772_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _773_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out384;
                    bool _out385;
                    bool _out386;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out387;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out384, out _out385, out _out386, out _out387);
                    _770_recursiveGen = _out384;
                    _771_recOwned = _out385;
                    _772_recErased = _out386;
                    _773_recIdents = _out387;
                    if (!(_771_recOwned)) {
                      _770_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_770_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_770_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _771_recOwned;
                    isErased = _772_recErased;
                    readIdents = _773_recIdents;
                  }
                } else if (_source35.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _774___mcc_h303 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _775_recursiveGen;
                    bool _776_recOwned;
                    bool _777_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _778_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out388;
                    bool _out389;
                    bool _out390;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out391;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out388, out _out389, out _out390, out _out391);
                    _775_recursiveGen = _out388;
                    _776_recOwned = _out389;
                    _777_recErased = _out390;
                    _778_recIdents = _out391;
                    if (!(_776_recOwned)) {
                      _775_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_775_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_775_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _776_recOwned;
                    isErased = _777_recErased;
                    readIdents = _778_recIdents;
                  }
                } else {
                  DAST._IType _779___mcc_h306 = _source35.dtor_Newtype_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _780_recursiveGen;
                    bool _781_recOwned;
                    bool _782_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _783_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out392;
                    bool _out393;
                    bool _out394;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out395;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out392, out _out393, out _out394, out _out395);
                    _780_recursiveGen = _out392;
                    _781_recOwned = _out393;
                    _782_recErased = _out394;
                    _783_recIdents = _out395;
                    if (!(_781_recOwned)) {
                      _780_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_780_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(_780_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                    isOwned = _781_recOwned;
                    isErased = _782_recErased;
                    readIdents = _783_recIdents;
                  }
                }
              } else if (_source34.is_Nullable) {
                DAST._IType _784___mcc_h309 = _source34.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _785_recursiveGen;
                  bool _786_recOwned;
                  bool _787_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _788_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out396;
                  bool _out397;
                  bool _out398;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out399;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out396, out _out397, out _out398, out _out399);
                  _785_recursiveGen = _out396;
                  _786_recOwned = _out397;
                  _787_recErased = _out398;
                  _788_recIdents = _out399;
                  if (!(_786_recOwned)) {
                    _785_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_785_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_785_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _786_recOwned;
                  isErased = _787_recErased;
                  readIdents = _788_recIdents;
                }
              } else if (_source34.is_Tuple) {
                Dafny.ISequence<DAST._IType> _789___mcc_h312 = _source34.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _790_recursiveGen;
                  bool _791_recOwned;
                  bool _792_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _793_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out400;
                  bool _out401;
                  bool _out402;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out403;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out400, out _out401, out _out402, out _out403);
                  _790_recursiveGen = _out400;
                  _791_recOwned = _out401;
                  _792_recErased = _out402;
                  _793_recIdents = _out403;
                  if (!(_791_recOwned)) {
                    _790_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_790_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_790_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _791_recOwned;
                  isErased = _792_recErased;
                  readIdents = _793_recIdents;
                }
              } else if (_source34.is_Array) {
                DAST._IType _794___mcc_h315 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _795_recursiveGen;
                  bool _796_recOwned;
                  bool _797_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _798_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out404;
                  bool _out405;
                  bool _out406;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out407;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out404, out _out405, out _out406, out _out407);
                  _795_recursiveGen = _out404;
                  _796_recOwned = _out405;
                  _797_recErased = _out406;
                  _798_recIdents = _out407;
                  if (!(_796_recOwned)) {
                    _795_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_795_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_795_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _796_recOwned;
                  isErased = _797_recErased;
                  readIdents = _798_recIdents;
                }
              } else if (_source34.is_Seq) {
                DAST._IType _799___mcc_h318 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _800_recursiveGen;
                  bool _801_recOwned;
                  bool _802_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _803_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out408;
                  bool _out409;
                  bool _out410;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out411;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out408, out _out409, out _out410, out _out411);
                  _800_recursiveGen = _out408;
                  _801_recOwned = _out409;
                  _802_recErased = _out410;
                  _803_recIdents = _out411;
                  if (!(_801_recOwned)) {
                    _800_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_800_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_800_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _801_recOwned;
                  isErased = _802_recErased;
                  readIdents = _803_recIdents;
                }
              } else if (_source34.is_Set) {
                DAST._IType _804___mcc_h321 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _805_recursiveGen;
                  bool _806_recOwned;
                  bool _807_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _808_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out412;
                  bool _out413;
                  bool _out414;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out415;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out412, out _out413, out _out414, out _out415);
                  _805_recursiveGen = _out412;
                  _806_recOwned = _out413;
                  _807_recErased = _out414;
                  _808_recIdents = _out415;
                  if (!(_806_recOwned)) {
                    _805_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_805_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_805_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _806_recOwned;
                  isErased = _807_recErased;
                  readIdents = _808_recIdents;
                }
              } else if (_source34.is_Multiset) {
                DAST._IType _809___mcc_h324 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _810_recursiveGen;
                  bool _811_recOwned;
                  bool _812_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _813_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out416;
                  bool _out417;
                  bool _out418;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out419;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out416, out _out417, out _out418, out _out419);
                  _810_recursiveGen = _out416;
                  _811_recOwned = _out417;
                  _812_recErased = _out418;
                  _813_recIdents = _out419;
                  if (!(_811_recOwned)) {
                    _810_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_810_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_810_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _811_recOwned;
                  isErased = _812_recErased;
                  readIdents = _813_recIdents;
                }
              } else if (_source34.is_Map) {
                DAST._IType _814___mcc_h327 = _source34.dtor_key;
                DAST._IType _815___mcc_h328 = _source34.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _816_recursiveGen;
                  bool _817_recOwned;
                  bool _818_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _819_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out420;
                  bool _out421;
                  bool _out422;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out423;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out420, out _out421, out _out422, out _out423);
                  _816_recursiveGen = _out420;
                  _817_recOwned = _out421;
                  _818_recErased = _out422;
                  _819_recIdents = _out423;
                  if (!(_817_recOwned)) {
                    _816_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_816_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_816_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _817_recOwned;
                  isErased = _818_recErased;
                  readIdents = _819_recIdents;
                }
              } else if (_source34.is_Arrow) {
                Dafny.ISequence<DAST._IType> _820___mcc_h333 = _source34.dtor_args;
                DAST._IType _821___mcc_h334 = _source34.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _822_recursiveGen;
                  bool _823_recOwned;
                  bool _824_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _825_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out424;
                  bool _out425;
                  bool _out426;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out427;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out424, out _out425, out _out426, out _out427);
                  _822_recursiveGen = _out424;
                  _823_recOwned = _out425;
                  _824_recErased = _out426;
                  _825_recIdents = _out427;
                  if (!(_823_recOwned)) {
                    _822_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_822_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_822_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _823_recOwned;
                  isErased = _824_recErased;
                  readIdents = _825_recIdents;
                }
              } else if (_source34.is_Primitive) {
                DAST._IPrimitive _826___mcc_h339 = _source34.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _827_recursiveGen;
                  bool _828_recOwned;
                  bool _829_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _830_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out428;
                  bool _out429;
                  bool _out430;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out431;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out428, out _out429, out _out430, out _out431);
                  _827_recursiveGen = _out428;
                  _828_recOwned = _out429;
                  _829_recErased = _out430;
                  _830_recIdents = _out431;
                  if (!(_828_recOwned)) {
                    _827_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_827_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_827_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _828_recOwned;
                  isErased = _829_recErased;
                  readIdents = _830_recIdents;
                }
              } else if (_source34.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _831___mcc_h342 = _source34.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _832_recursiveGen;
                  bool _833_recOwned;
                  bool _834_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _835_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out432;
                  bool _out433;
                  bool _out434;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out435;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out432, out _out433, out _out434, out _out435);
                  _832_recursiveGen = _out432;
                  _833_recOwned = _out433;
                  _834_recErased = _out434;
                  _835_recIdents = _out435;
                  if (!(_833_recOwned)) {
                    _832_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_832_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_832_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _833_recOwned;
                  isErased = _834_recErased;
                  readIdents = _835_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _836___mcc_h345 = _source34.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _837_recursiveGen;
                  bool _838_recOwned;
                  bool _839_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _840_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out436;
                  bool _out437;
                  bool _out438;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out439;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out436, out _out437, out _out438, out _out439);
                  _837_recursiveGen = _out436;
                  _838_recOwned = _out437;
                  _839_recErased = _out438;
                  _840_recIdents = _out439;
                  if (!(_838_recOwned)) {
                    _837_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_837_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(_837_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".unwrap()"));
                  isOwned = _838_recOwned;
                  isErased = _839_recErased;
                  readIdents = _840_recIdents;
                }
              }
            } else if (_source26.is_Tuple) {
              Dafny.ISequence<DAST._IType> _841___mcc_h348 = _source26.dtor_Tuple_a0;
              DAST._IType _source36 = _500___mcc_h127;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _842___mcc_h352 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _843___mcc_h353 = _source36.dtor_typeArgs;
                DAST._IResolvedType _844___mcc_h354 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _844___mcc_h354;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _845___mcc_h358 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _846_recursiveGen;
                    bool _847_recOwned;
                    bool _848_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _849_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out440;
                    bool _out441;
                    bool _out442;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out443;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out440, out _out441, out _out442, out _out443);
                    _846_recursiveGen = _out440;
                    _847_recOwned = _out441;
                    _848_recErased = _out442;
                    _849_recIdents = _out443;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _846_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _847_recOwned;
                    isErased = _848_recErased;
                    readIdents = _849_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _850___mcc_h360 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _851_recursiveGen;
                    bool _852_recOwned;
                    bool _853_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _854_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out444;
                    bool _out445;
                    bool _out446;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out447;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out444, out _out445, out _out446, out _out447);
                    _851_recursiveGen = _out444;
                    _852_recOwned = _out445;
                    _853_recErased = _out446;
                    _854_recIdents = _out447;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _851_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _852_recOwned;
                    isErased = _853_recErased;
                    readIdents = _854_recIdents;
                  }
                } else {
                  DAST._IType _855___mcc_h362 = _source37.dtor_Newtype_a0;
                  DAST._IType _856_b = _855___mcc_h362;
                  {
                    if (object.Equals(_493_fromTpe, _856_b)) {
                      Dafny.ISequence<Dafny.Rune> _857_recursiveGen;
                      bool _858_recOwned;
                      bool _859_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _860_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out448;
                      bool _out449;
                      bool _out450;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out451;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out448, out _out449, out _out450, out _out451);
                      _857_recursiveGen = _out448;
                      _858_recOwned = _out449;
                      _859_recErased = _out450;
                      _860_recIdents = _out451;
                      Dafny.ISequence<Dafny.Rune> _861_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out452;
                      _out452 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _861_rhsType = _out452;
                      Dafny.ISequence<Dafny.Rune> _862_uneraseFn;
                      _862_uneraseFn = ((_858_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _861_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _862_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _857_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _858_recOwned;
                      isErased = false;
                      readIdents = _860_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out453;
                      bool _out454;
                      bool _out455;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out456;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _856_b), _856_b, _492_toTpe), selfIdent, @params, mustOwn, out _out453, out _out454, out _out455, out _out456);
                      s = _out453;
                      isOwned = _out454;
                      isErased = _out455;
                      readIdents = _out456;
                    }
                  }
                }
              } else if (_source36.is_Nullable) {
                DAST._IType _863___mcc_h364 = _source36.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _864_recursiveGen;
                  bool _865_recOwned;
                  bool _866_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _867_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out457;
                  bool _out458;
                  bool _out459;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out460;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out457, out _out458, out _out459, out _out460);
                  _864_recursiveGen = _out457;
                  _865_recOwned = _out458;
                  _866_recErased = _out459;
                  _867_recIdents = _out460;
                  if (!(_865_recOwned)) {
                    _864_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_864_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _864_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _866_recErased;
                  readIdents = _867_recIdents;
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _868___mcc_h366 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _869_recursiveGen;
                  bool _870_recOwned;
                  bool _871_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _872_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out461;
                  bool _out462;
                  bool _out463;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out464;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out461, out _out462, out _out463, out _out464);
                  _869_recursiveGen = _out461;
                  _870_recOwned = _out462;
                  _871_recErased = _out463;
                  _872_recIdents = _out464;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _869_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _870_recOwned;
                  isErased = _871_recErased;
                  readIdents = _872_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _873___mcc_h368 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _874_recursiveGen;
                  bool _875_recOwned;
                  bool _876_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _877_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out465;
                  bool _out466;
                  bool _out467;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out468;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out465, out _out466, out _out467, out _out468);
                  _874_recursiveGen = _out465;
                  _875_recOwned = _out466;
                  _876_recErased = _out467;
                  _877_recIdents = _out468;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _874_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _875_recOwned;
                  isErased = _876_recErased;
                  readIdents = _877_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _878___mcc_h370 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _879_recursiveGen;
                  bool _880_recOwned;
                  bool _881_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _882_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out469;
                  bool _out470;
                  bool _out471;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out472;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out469, out _out470, out _out471, out _out472);
                  _879_recursiveGen = _out469;
                  _880_recOwned = _out470;
                  _881_recErased = _out471;
                  _882_recIdents = _out472;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _879_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _880_recOwned;
                  isErased = _881_recErased;
                  readIdents = _882_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _883___mcc_h372 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _884_recursiveGen;
                  bool _885_recOwned;
                  bool _886_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _887_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out473;
                  bool _out474;
                  bool _out475;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out476;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out473, out _out474, out _out475, out _out476);
                  _884_recursiveGen = _out473;
                  _885_recOwned = _out474;
                  _886_recErased = _out475;
                  _887_recIdents = _out476;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _884_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _885_recOwned;
                  isErased = _886_recErased;
                  readIdents = _887_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _888___mcc_h374 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _889_recursiveGen;
                  bool _890_recOwned;
                  bool _891_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _892_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out477;
                  bool _out478;
                  bool _out479;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out480;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out477, out _out478, out _out479, out _out480);
                  _889_recursiveGen = _out477;
                  _890_recOwned = _out478;
                  _891_recErased = _out479;
                  _892_recIdents = _out480;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _889_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _890_recOwned;
                  isErased = _891_recErased;
                  readIdents = _892_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _893___mcc_h376 = _source36.dtor_key;
                DAST._IType _894___mcc_h377 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _895_recursiveGen;
                  bool _896_recOwned;
                  bool _897_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _898_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out481;
                  bool _out482;
                  bool _out483;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out484;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out481, out _out482, out _out483, out _out484);
                  _895_recursiveGen = _out481;
                  _896_recOwned = _out482;
                  _897_recErased = _out483;
                  _898_recIdents = _out484;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _895_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _896_recOwned;
                  isErased = _897_recErased;
                  readIdents = _898_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _899___mcc_h380 = _source36.dtor_args;
                DAST._IType _900___mcc_h381 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _901_recursiveGen;
                  bool _902_recOwned;
                  bool _903_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _904_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out485;
                  bool _out486;
                  bool _out487;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out488;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out485, out _out486, out _out487, out _out488);
                  _901_recursiveGen = _out485;
                  _902_recOwned = _out486;
                  _903_recErased = _out487;
                  _904_recIdents = _out488;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _901_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _902_recOwned;
                  isErased = _903_recErased;
                  readIdents = _904_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _905___mcc_h384 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _906_recursiveGen;
                  bool _907_recOwned;
                  bool _908_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _909_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out489;
                  bool _out490;
                  bool _out491;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out492;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out489, out _out490, out _out491, out _out492);
                  _906_recursiveGen = _out489;
                  _907_recOwned = _out490;
                  _908_recErased = _out491;
                  _909_recIdents = _out492;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _906_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _907_recOwned;
                  isErased = _908_recErased;
                  readIdents = _909_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _910___mcc_h386 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _911_recursiveGen;
                  bool _912_recOwned;
                  bool _913_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _914_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out493;
                  bool _out494;
                  bool _out495;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out496;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out493, out _out494, out _out495, out _out496);
                  _911_recursiveGen = _out493;
                  _912_recOwned = _out494;
                  _913_recErased = _out495;
                  _914_recIdents = _out496;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _911_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _912_recOwned;
                  isErased = _913_recErased;
                  readIdents = _914_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _915___mcc_h388 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _916_recursiveGen;
                  bool _917_recOwned;
                  bool _918_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _919_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out497;
                  bool _out498;
                  bool _out499;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out500;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out497, out _out498, out _out499, out _out500);
                  _916_recursiveGen = _out497;
                  _917_recOwned = _out498;
                  _918_recErased = _out499;
                  _919_recIdents = _out500;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _916_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _917_recOwned;
                  isErased = _918_recErased;
                  readIdents = _919_recIdents;
                }
              }
            } else if (_source26.is_Array) {
              DAST._IType _920___mcc_h390 = _source26.dtor_element;
              DAST._IType _source38 = _500___mcc_h127;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _921___mcc_h394 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _922___mcc_h395 = _source38.dtor_typeArgs;
                DAST._IResolvedType _923___mcc_h396 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _923___mcc_h396;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _924___mcc_h400 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                    bool _926_recOwned;
                    bool _927_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out501;
                    bool _out502;
                    bool _out503;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out504;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out501, out _out502, out _out503, out _out504);
                    _925_recursiveGen = _out501;
                    _926_recOwned = _out502;
                    _927_recErased = _out503;
                    _928_recIdents = _out504;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _926_recOwned;
                    isErased = _927_recErased;
                    readIdents = _928_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _929___mcc_h402 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                    bool _931_recOwned;
                    bool _932_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out505;
                    bool _out506;
                    bool _out507;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out508;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out505, out _out506, out _out507, out _out508);
                    _930_recursiveGen = _out505;
                    _931_recOwned = _out506;
                    _932_recErased = _out507;
                    _933_recIdents = _out508;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _931_recOwned;
                    isErased = _932_recErased;
                    readIdents = _933_recIdents;
                  }
                } else {
                  DAST._IType _934___mcc_h404 = _source39.dtor_Newtype_a0;
                  DAST._IType _935_b = _934___mcc_h404;
                  {
                    if (object.Equals(_493_fromTpe, _935_b)) {
                      Dafny.ISequence<Dafny.Rune> _936_recursiveGen;
                      bool _937_recOwned;
                      bool _938_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _939_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out509;
                      bool _out510;
                      bool _out511;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out512;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out509, out _out510, out _out511, out _out512);
                      _936_recursiveGen = _out509;
                      _937_recOwned = _out510;
                      _938_recErased = _out511;
                      _939_recIdents = _out512;
                      Dafny.ISequence<Dafny.Rune> _940_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out513;
                      _out513 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _940_rhsType = _out513;
                      Dafny.ISequence<Dafny.Rune> _941_uneraseFn;
                      _941_uneraseFn = ((_937_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _940_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _941_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _936_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _937_recOwned;
                      isErased = false;
                      readIdents = _939_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out514;
                      bool _out515;
                      bool _out516;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out517;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _935_b), _935_b, _492_toTpe), selfIdent, @params, mustOwn, out _out514, out _out515, out _out516, out _out517);
                      s = _out514;
                      isOwned = _out515;
                      isErased = _out516;
                      readIdents = _out517;
                    }
                  }
                }
              } else if (_source38.is_Nullable) {
                DAST._IType _942___mcc_h406 = _source38.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _943_recursiveGen;
                  bool _944_recOwned;
                  bool _945_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _946_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out518;
                  bool _out519;
                  bool _out520;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out521;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out518, out _out519, out _out520, out _out521);
                  _943_recursiveGen = _out518;
                  _944_recOwned = _out519;
                  _945_recErased = _out520;
                  _946_recIdents = _out521;
                  if (!(_944_recOwned)) {
                    _943_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_943_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _945_recErased;
                  readIdents = _946_recIdents;
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _947___mcc_h408 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _948_recursiveGen;
                  bool _949_recOwned;
                  bool _950_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _951_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out522;
                  bool _out523;
                  bool _out524;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out525;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out522, out _out523, out _out524, out _out525);
                  _948_recursiveGen = _out522;
                  _949_recOwned = _out523;
                  _950_recErased = _out524;
                  _951_recIdents = _out525;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _948_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _949_recOwned;
                  isErased = _950_recErased;
                  readIdents = _951_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _952___mcc_h410 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _953_recursiveGen;
                  bool _954_recOwned;
                  bool _955_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _956_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out526;
                  bool _out527;
                  bool _out528;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out529;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out526, out _out527, out _out528, out _out529);
                  _953_recursiveGen = _out526;
                  _954_recOwned = _out527;
                  _955_recErased = _out528;
                  _956_recIdents = _out529;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _953_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _954_recOwned;
                  isErased = _955_recErased;
                  readIdents = _956_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _957___mcc_h412 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _958_recursiveGen;
                  bool _959_recOwned;
                  bool _960_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _961_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out530;
                  bool _out531;
                  bool _out532;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out533;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out530, out _out531, out _out532, out _out533);
                  _958_recursiveGen = _out530;
                  _959_recOwned = _out531;
                  _960_recErased = _out532;
                  _961_recIdents = _out533;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _958_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _959_recOwned;
                  isErased = _960_recErased;
                  readIdents = _961_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _962___mcc_h414 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _963_recursiveGen;
                  bool _964_recOwned;
                  bool _965_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _966_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out534;
                  bool _out535;
                  bool _out536;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out537;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out534, out _out535, out _out536, out _out537);
                  _963_recursiveGen = _out534;
                  _964_recOwned = _out535;
                  _965_recErased = _out536;
                  _966_recIdents = _out537;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _963_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _964_recOwned;
                  isErased = _965_recErased;
                  readIdents = _966_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _967___mcc_h416 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _968_recursiveGen;
                  bool _969_recOwned;
                  bool _970_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _971_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out538;
                  bool _out539;
                  bool _out540;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out541;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out538, out _out539, out _out540, out _out541);
                  _968_recursiveGen = _out538;
                  _969_recOwned = _out539;
                  _970_recErased = _out540;
                  _971_recIdents = _out541;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _968_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _969_recOwned;
                  isErased = _970_recErased;
                  readIdents = _971_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _972___mcc_h418 = _source38.dtor_key;
                DAST._IType _973___mcc_h419 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _974_recursiveGen;
                  bool _975_recOwned;
                  bool _976_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _977_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out542;
                  bool _out543;
                  bool _out544;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out545;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out542, out _out543, out _out544, out _out545);
                  _974_recursiveGen = _out542;
                  _975_recOwned = _out543;
                  _976_recErased = _out544;
                  _977_recIdents = _out545;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _974_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _975_recOwned;
                  isErased = _976_recErased;
                  readIdents = _977_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _978___mcc_h422 = _source38.dtor_args;
                DAST._IType _979___mcc_h423 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _980_recursiveGen;
                  bool _981_recOwned;
                  bool _982_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _983_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out546;
                  bool _out547;
                  bool _out548;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out549;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out546, out _out547, out _out548, out _out549);
                  _980_recursiveGen = _out546;
                  _981_recOwned = _out547;
                  _982_recErased = _out548;
                  _983_recIdents = _out549;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _980_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _981_recOwned;
                  isErased = _982_recErased;
                  readIdents = _983_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _984___mcc_h426 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _985_recursiveGen;
                  bool _986_recOwned;
                  bool _987_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _988_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out550;
                  bool _out551;
                  bool _out552;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out553;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out550, out _out551, out _out552, out _out553);
                  _985_recursiveGen = _out550;
                  _986_recOwned = _out551;
                  _987_recErased = _out552;
                  _988_recIdents = _out553;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _985_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _986_recOwned;
                  isErased = _987_recErased;
                  readIdents = _988_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _989___mcc_h428 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _990_recursiveGen;
                  bool _991_recOwned;
                  bool _992_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _993_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out554;
                  bool _out555;
                  bool _out556;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out557;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out554, out _out555, out _out556, out _out557);
                  _990_recursiveGen = _out554;
                  _991_recOwned = _out555;
                  _992_recErased = _out556;
                  _993_recIdents = _out557;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _990_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _991_recOwned;
                  isErased = _992_recErased;
                  readIdents = _993_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _994___mcc_h430 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _995_recursiveGen;
                  bool _996_recOwned;
                  bool _997_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _998_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out558;
                  bool _out559;
                  bool _out560;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out561;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out558, out _out559, out _out560, out _out561);
                  _995_recursiveGen = _out558;
                  _996_recOwned = _out559;
                  _997_recErased = _out560;
                  _998_recIdents = _out561;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _995_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _996_recOwned;
                  isErased = _997_recErased;
                  readIdents = _998_recIdents;
                }
              }
            } else if (_source26.is_Seq) {
              DAST._IType _999___mcc_h432 = _source26.dtor_element;
              DAST._IType _source40 = _500___mcc_h127;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1000___mcc_h436 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1001___mcc_h437 = _source40.dtor_typeArgs;
                DAST._IResolvedType _1002___mcc_h438 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _1002___mcc_h438;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1003___mcc_h442 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1004_recursiveGen;
                    bool _1005_recOwned;
                    bool _1006_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1007_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out562;
                    bool _out563;
                    bool _out564;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out565;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out562, out _out563, out _out564, out _out565);
                    _1004_recursiveGen = _out562;
                    _1005_recOwned = _out563;
                    _1006_recErased = _out564;
                    _1007_recIdents = _out565;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1004_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1005_recOwned;
                    isErased = _1006_recErased;
                    readIdents = _1007_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1008___mcc_h444 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                    bool _1010_recOwned;
                    bool _1011_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out566;
                    bool _out567;
                    bool _out568;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out569;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out566, out _out567, out _out568, out _out569);
                    _1009_recursiveGen = _out566;
                    _1010_recOwned = _out567;
                    _1011_recErased = _out568;
                    _1012_recIdents = _out569;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1010_recOwned;
                    isErased = _1011_recErased;
                    readIdents = _1012_recIdents;
                  }
                } else {
                  DAST._IType _1013___mcc_h446 = _source41.dtor_Newtype_a0;
                  DAST._IType _1014_b = _1013___mcc_h446;
                  {
                    if (object.Equals(_493_fromTpe, _1014_b)) {
                      Dafny.ISequence<Dafny.Rune> _1015_recursiveGen;
                      bool _1016_recOwned;
                      bool _1017_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1018_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out570;
                      bool _out571;
                      bool _out572;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out573;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out570, out _out571, out _out572, out _out573);
                      _1015_recursiveGen = _out570;
                      _1016_recOwned = _out571;
                      _1017_recErased = _out572;
                      _1018_recIdents = _out573;
                      Dafny.ISequence<Dafny.Rune> _1019_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out574;
                      _out574 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1019_rhsType = _out574;
                      Dafny.ISequence<Dafny.Rune> _1020_uneraseFn;
                      _1020_uneraseFn = ((_1016_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1019_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1020_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1015_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1016_recOwned;
                      isErased = false;
                      readIdents = _1018_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out575;
                      bool _out576;
                      bool _out577;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out578;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1014_b), _1014_b, _492_toTpe), selfIdent, @params, mustOwn, out _out575, out _out576, out _out577, out _out578);
                      s = _out575;
                      isOwned = _out576;
                      isErased = _out577;
                      readIdents = _out578;
                    }
                  }
                }
              } else if (_source40.is_Nullable) {
                DAST._IType _1021___mcc_h448 = _source40.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1022_recursiveGen;
                  bool _1023_recOwned;
                  bool _1024_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1025_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out579;
                  bool _out580;
                  bool _out581;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out582;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out579, out _out580, out _out581, out _out582);
                  _1022_recursiveGen = _out579;
                  _1023_recOwned = _out580;
                  _1024_recErased = _out581;
                  _1025_recIdents = _out582;
                  if (!(_1023_recOwned)) {
                    _1022_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1022_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1022_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1024_recErased;
                  readIdents = _1025_recIdents;
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1026___mcc_h450 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1027_recursiveGen;
                  bool _1028_recOwned;
                  bool _1029_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1030_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out583;
                  bool _out584;
                  bool _out585;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out586;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out583, out _out584, out _out585, out _out586);
                  _1027_recursiveGen = _out583;
                  _1028_recOwned = _out584;
                  _1029_recErased = _out585;
                  _1030_recIdents = _out586;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1027_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1028_recOwned;
                  isErased = _1029_recErased;
                  readIdents = _1030_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _1031___mcc_h452 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1032_recursiveGen;
                  bool _1033_recOwned;
                  bool _1034_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1035_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out587;
                  bool _out588;
                  bool _out589;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out590;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out587, out _out588, out _out589, out _out590);
                  _1032_recursiveGen = _out587;
                  _1033_recOwned = _out588;
                  _1034_recErased = _out589;
                  _1035_recIdents = _out590;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1032_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1033_recOwned;
                  isErased = _1034_recErased;
                  readIdents = _1035_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _1036___mcc_h454 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1037_recursiveGen;
                  bool _1038_recOwned;
                  bool _1039_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1040_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out591;
                  bool _out592;
                  bool _out593;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out594;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out591, out _out592, out _out593, out _out594);
                  _1037_recursiveGen = _out591;
                  _1038_recOwned = _out592;
                  _1039_recErased = _out593;
                  _1040_recIdents = _out594;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1037_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1038_recOwned;
                  isErased = _1039_recErased;
                  readIdents = _1040_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _1041___mcc_h456 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1042_recursiveGen;
                  bool _1043_recOwned;
                  bool _1044_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1045_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out595;
                  bool _out596;
                  bool _out597;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out598;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out595, out _out596, out _out597, out _out598);
                  _1042_recursiveGen = _out595;
                  _1043_recOwned = _out596;
                  _1044_recErased = _out597;
                  _1045_recIdents = _out598;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1042_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1043_recOwned;
                  isErased = _1044_recErased;
                  readIdents = _1045_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1046___mcc_h458 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1047_recursiveGen;
                  bool _1048_recOwned;
                  bool _1049_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1050_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out599;
                  bool _out600;
                  bool _out601;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out602;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out599, out _out600, out _out601, out _out602);
                  _1047_recursiveGen = _out599;
                  _1048_recOwned = _out600;
                  _1049_recErased = _out601;
                  _1050_recIdents = _out602;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1047_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1048_recOwned;
                  isErased = _1049_recErased;
                  readIdents = _1050_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1051___mcc_h460 = _source40.dtor_key;
                DAST._IType _1052___mcc_h461 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1053_recursiveGen;
                  bool _1054_recOwned;
                  bool _1055_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1056_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out603;
                  bool _out604;
                  bool _out605;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out606;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out603, out _out604, out _out605, out _out606);
                  _1053_recursiveGen = _out603;
                  _1054_recOwned = _out604;
                  _1055_recErased = _out605;
                  _1056_recIdents = _out606;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1053_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1054_recOwned;
                  isErased = _1055_recErased;
                  readIdents = _1056_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1057___mcc_h464 = _source40.dtor_args;
                DAST._IType _1058___mcc_h465 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1059_recursiveGen;
                  bool _1060_recOwned;
                  bool _1061_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1062_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out607;
                  bool _out608;
                  bool _out609;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out610;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out607, out _out608, out _out609, out _out610);
                  _1059_recursiveGen = _out607;
                  _1060_recOwned = _out608;
                  _1061_recErased = _out609;
                  _1062_recIdents = _out610;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1059_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1060_recOwned;
                  isErased = _1061_recErased;
                  readIdents = _1062_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1063___mcc_h468 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1064_recursiveGen;
                  bool _1065_recOwned;
                  bool _1066_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1067_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out611;
                  bool _out612;
                  bool _out613;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out614;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out611, out _out612, out _out613, out _out614);
                  _1064_recursiveGen = _out611;
                  _1065_recOwned = _out612;
                  _1066_recErased = _out613;
                  _1067_recIdents = _out614;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1064_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1065_recOwned;
                  isErased = _1066_recErased;
                  readIdents = _1067_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1068___mcc_h470 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1069_recursiveGen;
                  bool _1070_recOwned;
                  bool _1071_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1072_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out615;
                  bool _out616;
                  bool _out617;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out618;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out615, out _out616, out _out617, out _out618);
                  _1069_recursiveGen = _out615;
                  _1070_recOwned = _out616;
                  _1071_recErased = _out617;
                  _1072_recIdents = _out618;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1069_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1070_recOwned;
                  isErased = _1071_recErased;
                  readIdents = _1072_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1073___mcc_h472 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1074_recursiveGen;
                  bool _1075_recOwned;
                  bool _1076_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1077_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out619;
                  bool _out620;
                  bool _out621;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out622;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out619, out _out620, out _out621, out _out622);
                  _1074_recursiveGen = _out619;
                  _1075_recOwned = _out620;
                  _1076_recErased = _out621;
                  _1077_recIdents = _out622;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1074_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1075_recOwned;
                  isErased = _1076_recErased;
                  readIdents = _1077_recIdents;
                }
              }
            } else if (_source26.is_Set) {
              DAST._IType _1078___mcc_h474 = _source26.dtor_element;
              DAST._IType _source42 = _500___mcc_h127;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1079___mcc_h478 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1080___mcc_h479 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1081___mcc_h480 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1081___mcc_h480;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1082___mcc_h484 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1083_recursiveGen;
                    bool _1084_recOwned;
                    bool _1085_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1086_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out623;
                    bool _out624;
                    bool _out625;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out626;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out623, out _out624, out _out625, out _out626);
                    _1083_recursiveGen = _out623;
                    _1084_recOwned = _out624;
                    _1085_recErased = _out625;
                    _1086_recIdents = _out626;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1084_recOwned;
                    isErased = _1085_recErased;
                    readIdents = _1086_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1087___mcc_h486 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1088_recursiveGen;
                    bool _1089_recOwned;
                    bool _1090_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1091_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out627;
                    bool _out628;
                    bool _out629;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out630;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out627, out _out628, out _out629, out _out630);
                    _1088_recursiveGen = _out627;
                    _1089_recOwned = _out628;
                    _1090_recErased = _out629;
                    _1091_recIdents = _out630;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1088_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1089_recOwned;
                    isErased = _1090_recErased;
                    readIdents = _1091_recIdents;
                  }
                } else {
                  DAST._IType _1092___mcc_h488 = _source43.dtor_Newtype_a0;
                  DAST._IType _1093_b = _1092___mcc_h488;
                  {
                    if (object.Equals(_493_fromTpe, _1093_b)) {
                      Dafny.ISequence<Dafny.Rune> _1094_recursiveGen;
                      bool _1095_recOwned;
                      bool _1096_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1097_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out631;
                      bool _out632;
                      bool _out633;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out634;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out631, out _out632, out _out633, out _out634);
                      _1094_recursiveGen = _out631;
                      _1095_recOwned = _out632;
                      _1096_recErased = _out633;
                      _1097_recIdents = _out634;
                      Dafny.ISequence<Dafny.Rune> _1098_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out635;
                      _out635 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1098_rhsType = _out635;
                      Dafny.ISequence<Dafny.Rune> _1099_uneraseFn;
                      _1099_uneraseFn = ((_1095_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1098_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1099_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1094_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1095_recOwned;
                      isErased = false;
                      readIdents = _1097_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out636;
                      bool _out637;
                      bool _out638;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out639;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1093_b), _1093_b, _492_toTpe), selfIdent, @params, mustOwn, out _out636, out _out637, out _out638, out _out639);
                      s = _out636;
                      isOwned = _out637;
                      isErased = _out638;
                      readIdents = _out639;
                    }
                  }
                }
              } else if (_source42.is_Nullable) {
                DAST._IType _1100___mcc_h490 = _source42.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1101_recursiveGen;
                  bool _1102_recOwned;
                  bool _1103_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1104_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out640;
                  bool _out641;
                  bool _out642;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out643;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out640, out _out641, out _out642, out _out643);
                  _1101_recursiveGen = _out640;
                  _1102_recOwned = _out641;
                  _1103_recErased = _out642;
                  _1104_recIdents = _out643;
                  if (!(_1102_recOwned)) {
                    _1101_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1101_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1101_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1103_recErased;
                  readIdents = _1104_recIdents;
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1105___mcc_h492 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1106_recursiveGen;
                  bool _1107_recOwned;
                  bool _1108_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1109_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out644;
                  bool _out645;
                  bool _out646;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out647;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out644, out _out645, out _out646, out _out647);
                  _1106_recursiveGen = _out644;
                  _1107_recOwned = _out645;
                  _1108_recErased = _out646;
                  _1109_recIdents = _out647;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1106_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1107_recOwned;
                  isErased = _1108_recErased;
                  readIdents = _1109_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1110___mcc_h494 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1111_recursiveGen;
                  bool _1112_recOwned;
                  bool _1113_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1114_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out648;
                  bool _out649;
                  bool _out650;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out651;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out648, out _out649, out _out650, out _out651);
                  _1111_recursiveGen = _out648;
                  _1112_recOwned = _out649;
                  _1113_recErased = _out650;
                  _1114_recIdents = _out651;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1111_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1112_recOwned;
                  isErased = _1113_recErased;
                  readIdents = _1114_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1115___mcc_h496 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1116_recursiveGen;
                  bool _1117_recOwned;
                  bool _1118_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1119_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out652;
                  bool _out653;
                  bool _out654;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out655;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out652, out _out653, out _out654, out _out655);
                  _1116_recursiveGen = _out652;
                  _1117_recOwned = _out653;
                  _1118_recErased = _out654;
                  _1119_recIdents = _out655;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1116_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1117_recOwned;
                  isErased = _1118_recErased;
                  readIdents = _1119_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1120___mcc_h498 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1121_recursiveGen;
                  bool _1122_recOwned;
                  bool _1123_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1124_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out656;
                  bool _out657;
                  bool _out658;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out659;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out656, out _out657, out _out658, out _out659);
                  _1121_recursiveGen = _out656;
                  _1122_recOwned = _out657;
                  _1123_recErased = _out658;
                  _1124_recIdents = _out659;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1121_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1122_recOwned;
                  isErased = _1123_recErased;
                  readIdents = _1124_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1125___mcc_h500 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1126_recursiveGen;
                  bool _1127_recOwned;
                  bool _1128_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1129_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out660;
                  bool _out661;
                  bool _out662;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out663;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out660, out _out661, out _out662, out _out663);
                  _1126_recursiveGen = _out660;
                  _1127_recOwned = _out661;
                  _1128_recErased = _out662;
                  _1129_recIdents = _out663;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1126_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1127_recOwned;
                  isErased = _1128_recErased;
                  readIdents = _1129_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1130___mcc_h502 = _source42.dtor_key;
                DAST._IType _1131___mcc_h503 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1132_recursiveGen;
                  bool _1133_recOwned;
                  bool _1134_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1135_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out664;
                  bool _out665;
                  bool _out666;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out667;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out664, out _out665, out _out666, out _out667);
                  _1132_recursiveGen = _out664;
                  _1133_recOwned = _out665;
                  _1134_recErased = _out666;
                  _1135_recIdents = _out667;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1132_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1133_recOwned;
                  isErased = _1134_recErased;
                  readIdents = _1135_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1136___mcc_h506 = _source42.dtor_args;
                DAST._IType _1137___mcc_h507 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1138_recursiveGen;
                  bool _1139_recOwned;
                  bool _1140_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1141_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out668;
                  bool _out669;
                  bool _out670;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out671;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out668, out _out669, out _out670, out _out671);
                  _1138_recursiveGen = _out668;
                  _1139_recOwned = _out669;
                  _1140_recErased = _out670;
                  _1141_recIdents = _out671;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1138_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1139_recOwned;
                  isErased = _1140_recErased;
                  readIdents = _1141_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1142___mcc_h510 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1143_recursiveGen;
                  bool _1144_recOwned;
                  bool _1145_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1146_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out672;
                  bool _out673;
                  bool _out674;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out675;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out672, out _out673, out _out674, out _out675);
                  _1143_recursiveGen = _out672;
                  _1144_recOwned = _out673;
                  _1145_recErased = _out674;
                  _1146_recIdents = _out675;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1143_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1144_recOwned;
                  isErased = _1145_recErased;
                  readIdents = _1146_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1147___mcc_h512 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1148_recursiveGen;
                  bool _1149_recOwned;
                  bool _1150_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1151_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out676;
                  bool _out677;
                  bool _out678;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out679;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out676, out _out677, out _out678, out _out679);
                  _1148_recursiveGen = _out676;
                  _1149_recOwned = _out677;
                  _1150_recErased = _out678;
                  _1151_recIdents = _out679;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1148_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1149_recOwned;
                  isErased = _1150_recErased;
                  readIdents = _1151_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1152___mcc_h514 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1153_recursiveGen;
                  bool _1154_recOwned;
                  bool _1155_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1156_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out680;
                  bool _out681;
                  bool _out682;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out683;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out680, out _out681, out _out682, out _out683);
                  _1153_recursiveGen = _out680;
                  _1154_recOwned = _out681;
                  _1155_recErased = _out682;
                  _1156_recIdents = _out683;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1153_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1154_recOwned;
                  isErased = _1155_recErased;
                  readIdents = _1156_recIdents;
                }
              }
            } else if (_source26.is_Multiset) {
              DAST._IType _1157___mcc_h516 = _source26.dtor_element;
              DAST._IType _source44 = _500___mcc_h127;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1158___mcc_h520 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1159___mcc_h521 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1160___mcc_h522 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1160___mcc_h522;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1161___mcc_h526 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1162_recursiveGen;
                    bool _1163_recOwned;
                    bool _1164_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1165_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out684;
                    bool _out685;
                    bool _out686;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out687;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out684, out _out685, out _out686, out _out687);
                    _1162_recursiveGen = _out684;
                    _1163_recOwned = _out685;
                    _1164_recErased = _out686;
                    _1165_recIdents = _out687;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1162_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1163_recOwned;
                    isErased = _1164_recErased;
                    readIdents = _1165_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1166___mcc_h528 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                    bool _1168_recOwned;
                    bool _1169_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out688;
                    bool _out689;
                    bool _out690;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out691;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out688, out _out689, out _out690, out _out691);
                    _1167_recursiveGen = _out688;
                    _1168_recOwned = _out689;
                    _1169_recErased = _out690;
                    _1170_recIdents = _out691;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1168_recOwned;
                    isErased = _1169_recErased;
                    readIdents = _1170_recIdents;
                  }
                } else {
                  DAST._IType _1171___mcc_h530 = _source45.dtor_Newtype_a0;
                  DAST._IType _1172_b = _1171___mcc_h530;
                  {
                    if (object.Equals(_493_fromTpe, _1172_b)) {
                      Dafny.ISequence<Dafny.Rune> _1173_recursiveGen;
                      bool _1174_recOwned;
                      bool _1175_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1176_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out692;
                      bool _out693;
                      bool _out694;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out695;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out692, out _out693, out _out694, out _out695);
                      _1173_recursiveGen = _out692;
                      _1174_recOwned = _out693;
                      _1175_recErased = _out694;
                      _1176_recIdents = _out695;
                      Dafny.ISequence<Dafny.Rune> _1177_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out696;
                      _out696 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1177_rhsType = _out696;
                      Dafny.ISequence<Dafny.Rune> _1178_uneraseFn;
                      _1178_uneraseFn = ((_1174_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1177_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1178_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1173_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1174_recOwned;
                      isErased = false;
                      readIdents = _1176_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out697;
                      bool _out698;
                      bool _out699;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out700;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1172_b), _1172_b, _492_toTpe), selfIdent, @params, mustOwn, out _out697, out _out698, out _out699, out _out700);
                      s = _out697;
                      isOwned = _out698;
                      isErased = _out699;
                      readIdents = _out700;
                    }
                  }
                }
              } else if (_source44.is_Nullable) {
                DAST._IType _1179___mcc_h532 = _source44.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1180_recursiveGen;
                  bool _1181_recOwned;
                  bool _1182_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1183_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out701;
                  bool _out702;
                  bool _out703;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out704;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out701, out _out702, out _out703, out _out704);
                  _1180_recursiveGen = _out701;
                  _1181_recOwned = _out702;
                  _1182_recErased = _out703;
                  _1183_recIdents = _out704;
                  if (!(_1181_recOwned)) {
                    _1180_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1180_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1180_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1182_recErased;
                  readIdents = _1183_recIdents;
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1184___mcc_h534 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1185_recursiveGen;
                  bool _1186_recOwned;
                  bool _1187_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1188_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out705;
                  bool _out706;
                  bool _out707;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out708;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out705, out _out706, out _out707, out _out708);
                  _1185_recursiveGen = _out705;
                  _1186_recOwned = _out706;
                  _1187_recErased = _out707;
                  _1188_recIdents = _out708;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1185_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1186_recOwned;
                  isErased = _1187_recErased;
                  readIdents = _1188_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1189___mcc_h536 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1190_recursiveGen;
                  bool _1191_recOwned;
                  bool _1192_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1193_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out709;
                  bool _out710;
                  bool _out711;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out712;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out709, out _out710, out _out711, out _out712);
                  _1190_recursiveGen = _out709;
                  _1191_recOwned = _out710;
                  _1192_recErased = _out711;
                  _1193_recIdents = _out712;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1190_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1191_recOwned;
                  isErased = _1192_recErased;
                  readIdents = _1193_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1194___mcc_h538 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1195_recursiveGen;
                  bool _1196_recOwned;
                  bool _1197_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1198_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out713;
                  bool _out714;
                  bool _out715;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out716;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out713, out _out714, out _out715, out _out716);
                  _1195_recursiveGen = _out713;
                  _1196_recOwned = _out714;
                  _1197_recErased = _out715;
                  _1198_recIdents = _out716;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1195_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1196_recOwned;
                  isErased = _1197_recErased;
                  readIdents = _1198_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1199___mcc_h540 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1200_recursiveGen;
                  bool _1201_recOwned;
                  bool _1202_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1203_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out717;
                  bool _out718;
                  bool _out719;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out720;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out717, out _out718, out _out719, out _out720);
                  _1200_recursiveGen = _out717;
                  _1201_recOwned = _out718;
                  _1202_recErased = _out719;
                  _1203_recIdents = _out720;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1200_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1201_recOwned;
                  isErased = _1202_recErased;
                  readIdents = _1203_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1204___mcc_h542 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                  bool _1206_recOwned;
                  bool _1207_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out721;
                  bool _out722;
                  bool _out723;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out724;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out721, out _out722, out _out723, out _out724);
                  _1205_recursiveGen = _out721;
                  _1206_recOwned = _out722;
                  _1207_recErased = _out723;
                  _1208_recIdents = _out724;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1206_recOwned;
                  isErased = _1207_recErased;
                  readIdents = _1208_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1209___mcc_h544 = _source44.dtor_key;
                DAST._IType _1210___mcc_h545 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1211_recursiveGen;
                  bool _1212_recOwned;
                  bool _1213_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1214_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out725;
                  bool _out726;
                  bool _out727;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out728;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out725, out _out726, out _out727, out _out728);
                  _1211_recursiveGen = _out725;
                  _1212_recOwned = _out726;
                  _1213_recErased = _out727;
                  _1214_recIdents = _out728;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1211_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1212_recOwned;
                  isErased = _1213_recErased;
                  readIdents = _1214_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1215___mcc_h548 = _source44.dtor_args;
                DAST._IType _1216___mcc_h549 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1217_recursiveGen;
                  bool _1218_recOwned;
                  bool _1219_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1220_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out729;
                  bool _out730;
                  bool _out731;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out732;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out729, out _out730, out _out731, out _out732);
                  _1217_recursiveGen = _out729;
                  _1218_recOwned = _out730;
                  _1219_recErased = _out731;
                  _1220_recIdents = _out732;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1218_recOwned;
                  isErased = _1219_recErased;
                  readIdents = _1220_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1221___mcc_h552 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1222_recursiveGen;
                  bool _1223_recOwned;
                  bool _1224_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1225_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out733;
                  bool _out734;
                  bool _out735;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out736;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out733, out _out734, out _out735, out _out736);
                  _1222_recursiveGen = _out733;
                  _1223_recOwned = _out734;
                  _1224_recErased = _out735;
                  _1225_recIdents = _out736;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1222_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1223_recOwned;
                  isErased = _1224_recErased;
                  readIdents = _1225_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1226___mcc_h554 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1227_recursiveGen;
                  bool _1228_recOwned;
                  bool _1229_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1230_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out737;
                  bool _out738;
                  bool _out739;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out740;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out737, out _out738, out _out739, out _out740);
                  _1227_recursiveGen = _out737;
                  _1228_recOwned = _out738;
                  _1229_recErased = _out739;
                  _1230_recIdents = _out740;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1227_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1228_recOwned;
                  isErased = _1229_recErased;
                  readIdents = _1230_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1231___mcc_h556 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1232_recursiveGen;
                  bool _1233_recOwned;
                  bool _1234_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1235_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out741;
                  bool _out742;
                  bool _out743;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out744;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out741, out _out742, out _out743, out _out744);
                  _1232_recursiveGen = _out741;
                  _1233_recOwned = _out742;
                  _1234_recErased = _out743;
                  _1235_recIdents = _out744;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1232_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1233_recOwned;
                  isErased = _1234_recErased;
                  readIdents = _1235_recIdents;
                }
              }
            } else if (_source26.is_Map) {
              DAST._IType _1236___mcc_h558 = _source26.dtor_key;
              DAST._IType _1237___mcc_h559 = _source26.dtor_value;
              DAST._IType _source46 = _500___mcc_h127;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1238___mcc_h566 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1239___mcc_h567 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1240___mcc_h568 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1240___mcc_h568;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1241___mcc_h572 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1242_recursiveGen;
                    bool _1243_recOwned;
                    bool _1244_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1245_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out745;
                    bool _out746;
                    bool _out747;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out748;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out745, out _out746, out _out747, out _out748);
                    _1242_recursiveGen = _out745;
                    _1243_recOwned = _out746;
                    _1244_recErased = _out747;
                    _1245_recIdents = _out748;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1242_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1243_recOwned;
                    isErased = _1244_recErased;
                    readIdents = _1245_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1246___mcc_h574 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                    bool _1248_recOwned;
                    bool _1249_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out749;
                    bool _out750;
                    bool _out751;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out752;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out749, out _out750, out _out751, out _out752);
                    _1247_recursiveGen = _out749;
                    _1248_recOwned = _out750;
                    _1249_recErased = _out751;
                    _1250_recIdents = _out752;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1248_recOwned;
                    isErased = _1249_recErased;
                    readIdents = _1250_recIdents;
                  }
                } else {
                  DAST._IType _1251___mcc_h576 = _source47.dtor_Newtype_a0;
                  DAST._IType _1252_b = _1251___mcc_h576;
                  {
                    if (object.Equals(_493_fromTpe, _1252_b)) {
                      Dafny.ISequence<Dafny.Rune> _1253_recursiveGen;
                      bool _1254_recOwned;
                      bool _1255_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1256_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out753;
                      bool _out754;
                      bool _out755;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out756;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out753, out _out754, out _out755, out _out756);
                      _1253_recursiveGen = _out753;
                      _1254_recOwned = _out754;
                      _1255_recErased = _out755;
                      _1256_recIdents = _out756;
                      Dafny.ISequence<Dafny.Rune> _1257_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out757;
                      _out757 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1257_rhsType = _out757;
                      Dafny.ISequence<Dafny.Rune> _1258_uneraseFn;
                      _1258_uneraseFn = ((_1254_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1257_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1258_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1253_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1254_recOwned;
                      isErased = false;
                      readIdents = _1256_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out758;
                      bool _out759;
                      bool _out760;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out761;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1252_b), _1252_b, _492_toTpe), selfIdent, @params, mustOwn, out _out758, out _out759, out _out760, out _out761);
                      s = _out758;
                      isOwned = _out759;
                      isErased = _out760;
                      readIdents = _out761;
                    }
                  }
                }
              } else if (_source46.is_Nullable) {
                DAST._IType _1259___mcc_h578 = _source46.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1260_recursiveGen;
                  bool _1261_recOwned;
                  bool _1262_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1263_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out762;
                  bool _out763;
                  bool _out764;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out765;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out762, out _out763, out _out764, out _out765);
                  _1260_recursiveGen = _out762;
                  _1261_recOwned = _out763;
                  _1262_recErased = _out764;
                  _1263_recIdents = _out765;
                  if (!(_1261_recOwned)) {
                    _1260_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1260_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1260_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1262_recErased;
                  readIdents = _1263_recIdents;
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1264___mcc_h580 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1265_recursiveGen;
                  bool _1266_recOwned;
                  bool _1267_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1268_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out766;
                  bool _out767;
                  bool _out768;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out769;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out766, out _out767, out _out768, out _out769);
                  _1265_recursiveGen = _out766;
                  _1266_recOwned = _out767;
                  _1267_recErased = _out768;
                  _1268_recIdents = _out769;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1265_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1266_recOwned;
                  isErased = _1267_recErased;
                  readIdents = _1268_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1269___mcc_h582 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1270_recursiveGen;
                  bool _1271_recOwned;
                  bool _1272_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1273_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out770;
                  bool _out771;
                  bool _out772;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out773;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out770, out _out771, out _out772, out _out773);
                  _1270_recursiveGen = _out770;
                  _1271_recOwned = _out771;
                  _1272_recErased = _out772;
                  _1273_recIdents = _out773;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1270_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1271_recOwned;
                  isErased = _1272_recErased;
                  readIdents = _1273_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1274___mcc_h584 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1275_recursiveGen;
                  bool _1276_recOwned;
                  bool _1277_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1278_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out774;
                  bool _out775;
                  bool _out776;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out777;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out774, out _out775, out _out776, out _out777);
                  _1275_recursiveGen = _out774;
                  _1276_recOwned = _out775;
                  _1277_recErased = _out776;
                  _1278_recIdents = _out777;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1275_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1276_recOwned;
                  isErased = _1277_recErased;
                  readIdents = _1278_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1279___mcc_h586 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1280_recursiveGen;
                  bool _1281_recOwned;
                  bool _1282_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1283_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out778;
                  bool _out779;
                  bool _out780;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out781;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out778, out _out779, out _out780, out _out781);
                  _1280_recursiveGen = _out778;
                  _1281_recOwned = _out779;
                  _1282_recErased = _out780;
                  _1283_recIdents = _out781;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1280_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1281_recOwned;
                  isErased = _1282_recErased;
                  readIdents = _1283_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1284___mcc_h588 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1285_recursiveGen;
                  bool _1286_recOwned;
                  bool _1287_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1288_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out782;
                  bool _out783;
                  bool _out784;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out785;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out782, out _out783, out _out784, out _out785);
                  _1285_recursiveGen = _out782;
                  _1286_recOwned = _out783;
                  _1287_recErased = _out784;
                  _1288_recIdents = _out785;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1285_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1286_recOwned;
                  isErased = _1287_recErased;
                  readIdents = _1288_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1289___mcc_h590 = _source46.dtor_key;
                DAST._IType _1290___mcc_h591 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1291_recursiveGen;
                  bool _1292_recOwned;
                  bool _1293_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1294_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out786;
                  bool _out787;
                  bool _out788;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out789;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out786, out _out787, out _out788, out _out789);
                  _1291_recursiveGen = _out786;
                  _1292_recOwned = _out787;
                  _1293_recErased = _out788;
                  _1294_recIdents = _out789;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1291_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1292_recOwned;
                  isErased = _1293_recErased;
                  readIdents = _1294_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1295___mcc_h594 = _source46.dtor_args;
                DAST._IType _1296___mcc_h595 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1297_recursiveGen;
                  bool _1298_recOwned;
                  bool _1299_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1300_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out790;
                  bool _out791;
                  bool _out792;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out793;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out790, out _out791, out _out792, out _out793);
                  _1297_recursiveGen = _out790;
                  _1298_recOwned = _out791;
                  _1299_recErased = _out792;
                  _1300_recIdents = _out793;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1297_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1298_recOwned;
                  isErased = _1299_recErased;
                  readIdents = _1300_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1301___mcc_h598 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1302_recursiveGen;
                  bool _1303_recOwned;
                  bool _1304_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1305_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out794;
                  bool _out795;
                  bool _out796;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out797;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out794, out _out795, out _out796, out _out797);
                  _1302_recursiveGen = _out794;
                  _1303_recOwned = _out795;
                  _1304_recErased = _out796;
                  _1305_recIdents = _out797;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1302_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1303_recOwned;
                  isErased = _1304_recErased;
                  readIdents = _1305_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1306___mcc_h600 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1307_recursiveGen;
                  bool _1308_recOwned;
                  bool _1309_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1310_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out798;
                  bool _out799;
                  bool _out800;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out801;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out798, out _out799, out _out800, out _out801);
                  _1307_recursiveGen = _out798;
                  _1308_recOwned = _out799;
                  _1309_recErased = _out800;
                  _1310_recIdents = _out801;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1307_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1308_recOwned;
                  isErased = _1309_recErased;
                  readIdents = _1310_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1311___mcc_h602 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1312_recursiveGen;
                  bool _1313_recOwned;
                  bool _1314_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1315_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out802;
                  bool _out803;
                  bool _out804;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out805;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out802, out _out803, out _out804, out _out805);
                  _1312_recursiveGen = _out802;
                  _1313_recOwned = _out803;
                  _1314_recErased = _out804;
                  _1315_recIdents = _out805;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1312_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1313_recOwned;
                  isErased = _1314_recErased;
                  readIdents = _1315_recIdents;
                }
              }
            } else if (_source26.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1316___mcc_h604 = _source26.dtor_args;
              DAST._IType _1317___mcc_h605 = _source26.dtor_result;
              DAST._IType _source48 = _500___mcc_h127;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1318___mcc_h612 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1319___mcc_h613 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1320___mcc_h614 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1320___mcc_h614;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1321___mcc_h618 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1322_recursiveGen;
                    bool _1323_recOwned;
                    bool _1324_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1325_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out806;
                    bool _out807;
                    bool _out808;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out809;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out806, out _out807, out _out808, out _out809);
                    _1322_recursiveGen = _out806;
                    _1323_recOwned = _out807;
                    _1324_recErased = _out808;
                    _1325_recIdents = _out809;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1322_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1323_recOwned;
                    isErased = _1324_recErased;
                    readIdents = _1325_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1326___mcc_h620 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1327_recursiveGen;
                    bool _1328_recOwned;
                    bool _1329_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1330_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out810;
                    bool _out811;
                    bool _out812;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out813;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out810, out _out811, out _out812, out _out813);
                    _1327_recursiveGen = _out810;
                    _1328_recOwned = _out811;
                    _1329_recErased = _out812;
                    _1330_recIdents = _out813;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1327_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1328_recOwned;
                    isErased = _1329_recErased;
                    readIdents = _1330_recIdents;
                  }
                } else {
                  DAST._IType _1331___mcc_h622 = _source49.dtor_Newtype_a0;
                  DAST._IType _1332_b = _1331___mcc_h622;
                  {
                    if (object.Equals(_493_fromTpe, _1332_b)) {
                      Dafny.ISequence<Dafny.Rune> _1333_recursiveGen;
                      bool _1334_recOwned;
                      bool _1335_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1336_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out814;
                      bool _out815;
                      bool _out816;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out817;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out814, out _out815, out _out816, out _out817);
                      _1333_recursiveGen = _out814;
                      _1334_recOwned = _out815;
                      _1335_recErased = _out816;
                      _1336_recIdents = _out817;
                      Dafny.ISequence<Dafny.Rune> _1337_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out818;
                      _out818 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1337_rhsType = _out818;
                      Dafny.ISequence<Dafny.Rune> _1338_uneraseFn;
                      _1338_uneraseFn = ((_1334_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1337_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1338_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1333_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1334_recOwned;
                      isErased = false;
                      readIdents = _1336_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out819;
                      bool _out820;
                      bool _out821;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out822;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1332_b), _1332_b, _492_toTpe), selfIdent, @params, mustOwn, out _out819, out _out820, out _out821, out _out822);
                      s = _out819;
                      isOwned = _out820;
                      isErased = _out821;
                      readIdents = _out822;
                    }
                  }
                }
              } else if (_source48.is_Nullable) {
                DAST._IType _1339___mcc_h624 = _source48.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1340_recursiveGen;
                  bool _1341_recOwned;
                  bool _1342_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1343_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out823;
                  bool _out824;
                  bool _out825;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out826;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out823, out _out824, out _out825, out _out826);
                  _1340_recursiveGen = _out823;
                  _1341_recOwned = _out824;
                  _1342_recErased = _out825;
                  _1343_recIdents = _out826;
                  if (!(_1341_recOwned)) {
                    _1340_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1340_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1340_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1342_recErased;
                  readIdents = _1343_recIdents;
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1344___mcc_h626 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1345_recursiveGen;
                  bool _1346_recOwned;
                  bool _1347_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1348_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out827;
                  bool _out828;
                  bool _out829;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out827, out _out828, out _out829, out _out830);
                  _1345_recursiveGen = _out827;
                  _1346_recOwned = _out828;
                  _1347_recErased = _out829;
                  _1348_recIdents = _out830;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1345_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1346_recOwned;
                  isErased = _1347_recErased;
                  readIdents = _1348_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1349___mcc_h628 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1350_recursiveGen;
                  bool _1351_recOwned;
                  bool _1352_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1353_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out831;
                  bool _out832;
                  bool _out833;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                  _1350_recursiveGen = _out831;
                  _1351_recOwned = _out832;
                  _1352_recErased = _out833;
                  _1353_recIdents = _out834;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1350_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1351_recOwned;
                  isErased = _1352_recErased;
                  readIdents = _1353_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1354___mcc_h630 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1355_recursiveGen;
                  bool _1356_recOwned;
                  bool _1357_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1358_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out835;
                  bool _out836;
                  bool _out837;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                  _1355_recursiveGen = _out835;
                  _1356_recOwned = _out836;
                  _1357_recErased = _out837;
                  _1358_recIdents = _out838;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1355_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1356_recOwned;
                  isErased = _1357_recErased;
                  readIdents = _1358_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1359___mcc_h632 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1360_recursiveGen;
                  bool _1361_recOwned;
                  bool _1362_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1363_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out839;
                  bool _out840;
                  bool _out841;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                  _1360_recursiveGen = _out839;
                  _1361_recOwned = _out840;
                  _1362_recErased = _out841;
                  _1363_recIdents = _out842;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1360_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1361_recOwned;
                  isErased = _1362_recErased;
                  readIdents = _1363_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1364___mcc_h634 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1365_recursiveGen;
                  bool _1366_recOwned;
                  bool _1367_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1368_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out843;
                  bool _out844;
                  bool _out845;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                  _1365_recursiveGen = _out843;
                  _1366_recOwned = _out844;
                  _1367_recErased = _out845;
                  _1368_recIdents = _out846;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1365_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1366_recOwned;
                  isErased = _1367_recErased;
                  readIdents = _1368_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1369___mcc_h636 = _source48.dtor_key;
                DAST._IType _1370___mcc_h637 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1371_recursiveGen;
                  bool _1372_recOwned;
                  bool _1373_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1374_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out847;
                  bool _out848;
                  bool _out849;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                  _1371_recursiveGen = _out847;
                  _1372_recOwned = _out848;
                  _1373_recErased = _out849;
                  _1374_recIdents = _out850;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1371_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1372_recOwned;
                  isErased = _1373_recErased;
                  readIdents = _1374_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1375___mcc_h640 = _source48.dtor_args;
                DAST._IType _1376___mcc_h641 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1377_recursiveGen;
                  bool _1378_recOwned;
                  bool _1379_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1380_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out851;
                  bool _out852;
                  bool _out853;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                  _1377_recursiveGen = _out851;
                  _1378_recOwned = _out852;
                  _1379_recErased = _out853;
                  _1380_recIdents = _out854;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1377_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1378_recOwned;
                  isErased = _1379_recErased;
                  readIdents = _1380_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1381___mcc_h644 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1382_recursiveGen;
                  bool _1383_recOwned;
                  bool _1384_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1385_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out855;
                  bool _out856;
                  bool _out857;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out858;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out855, out _out856, out _out857, out _out858);
                  _1382_recursiveGen = _out855;
                  _1383_recOwned = _out856;
                  _1384_recErased = _out857;
                  _1385_recIdents = _out858;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1382_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1383_recOwned;
                  isErased = _1384_recErased;
                  readIdents = _1385_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1386___mcc_h646 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1387_recursiveGen;
                  bool _1388_recOwned;
                  bool _1389_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1390_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out859;
                  bool _out860;
                  bool _out861;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out862;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out859, out _out860, out _out861, out _out862);
                  _1387_recursiveGen = _out859;
                  _1388_recOwned = _out860;
                  _1389_recErased = _out861;
                  _1390_recIdents = _out862;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1387_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1388_recOwned;
                  isErased = _1389_recErased;
                  readIdents = _1390_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1391___mcc_h648 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1392_recursiveGen;
                  bool _1393_recOwned;
                  bool _1394_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1395_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out863;
                  bool _out864;
                  bool _out865;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out866;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out863, out _out864, out _out865, out _out866);
                  _1392_recursiveGen = _out863;
                  _1393_recOwned = _out864;
                  _1394_recErased = _out865;
                  _1395_recIdents = _out866;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1392_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1393_recOwned;
                  isErased = _1394_recErased;
                  readIdents = _1395_recIdents;
                }
              }
            } else if (_source26.is_Primitive) {
              DAST._IPrimitive _1396___mcc_h650 = _source26.dtor_Primitive_a0;
              DAST._IPrimitive _source50 = _1396___mcc_h650;
              if (_source50.is_Int) {
                DAST._IType _source51 = _500___mcc_h127;
                if (_source51.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1397___mcc_h654 = _source51.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1398___mcc_h655 = _source51.dtor_typeArgs;
                  DAST._IResolvedType _1399___mcc_h656 = _source51.dtor_resolved;
                  DAST._IResolvedType _source52 = _1399___mcc_h656;
                  if (_source52.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1400___mcc_h660 = _source52.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1401_recursiveGen;
                      bool _1402_recOwned;
                      bool _1403_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1404_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out867;
                      bool _out868;
                      bool _out869;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out870;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out867, out _out868, out _out869, out _out870);
                      _1401_recursiveGen = _out867;
                      _1402_recOwned = _out868;
                      _1403_recErased = _out869;
                      _1404_recIdents = _out870;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1401_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1402_recOwned;
                      isErased = _1403_recErased;
                      readIdents = _1404_recIdents;
                    }
                  } else if (_source52.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1405___mcc_h662 = _source52.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1406_recursiveGen;
                      bool _1407_recOwned;
                      bool _1408_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1409_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out871;
                      bool _out872;
                      bool _out873;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out874;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out871, out _out872, out _out873, out _out874);
                      _1406_recursiveGen = _out871;
                      _1407_recOwned = _out872;
                      _1408_recErased = _out873;
                      _1409_recIdents = _out874;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1406_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1407_recOwned;
                      isErased = _1408_recErased;
                      readIdents = _1409_recIdents;
                    }
                  } else {
                    DAST._IType _1410___mcc_h664 = _source52.dtor_Newtype_a0;
                    DAST._IType _1411_b = _1410___mcc_h664;
                    {
                      if (object.Equals(_493_fromTpe, _1411_b)) {
                        Dafny.ISequence<Dafny.Rune> _1412_recursiveGen;
                        bool _1413_recOwned;
                        bool _1414_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1415_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out875;
                        bool _out876;
                        bool _out877;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out878;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out875, out _out876, out _out877, out _out878);
                        _1412_recursiveGen = _out875;
                        _1413_recOwned = _out876;
                        _1414_recErased = _out877;
                        _1415_recIdents = _out878;
                        Dafny.ISequence<Dafny.Rune> _1416_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out879;
                        _out879 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _1416_rhsType = _out879;
                        Dafny.ISequence<Dafny.Rune> _1417_uneraseFn;
                        _1417_uneraseFn = ((_1413_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1416_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1417_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1412_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1413_recOwned;
                        isErased = false;
                        readIdents = _1415_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out880;
                        bool _out881;
                        bool _out882;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1411_b), _1411_b, _492_toTpe), selfIdent, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                        s = _out880;
                        isOwned = _out881;
                        isErased = _out882;
                        readIdents = _out883;
                      }
                    }
                  }
                } else if (_source51.is_Nullable) {
                  DAST._IType _1418___mcc_h666 = _source51.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1419_recursiveGen;
                    bool _1420_recOwned;
                    bool _1421_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1422_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1419_recursiveGen = _out884;
                    _1420_recOwned = _out885;
                    _1421_recErased = _out886;
                    _1422_recIdents = _out887;
                    if (!(_1420_recOwned)) {
                      _1419_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1419_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1419_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1421_recErased;
                    readIdents = _1422_recIdents;
                  }
                } else if (_source51.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1423___mcc_h668 = _source51.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1424_recursiveGen;
                    bool _1425_recOwned;
                    bool _1426_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1427_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out888;
                    bool _out889;
                    bool _out890;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                    _1424_recursiveGen = _out888;
                    _1425_recOwned = _out889;
                    _1426_recErased = _out890;
                    _1427_recIdents = _out891;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1424_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1425_recOwned;
                    isErased = _1426_recErased;
                    readIdents = _1427_recIdents;
                  }
                } else if (_source51.is_Array) {
                  DAST._IType _1428___mcc_h670 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1429_recursiveGen;
                    bool _1430_recOwned;
                    bool _1431_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1432_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out892;
                    bool _out893;
                    bool _out894;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                    _1429_recursiveGen = _out892;
                    _1430_recOwned = _out893;
                    _1431_recErased = _out894;
                    _1432_recIdents = _out895;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1429_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1430_recOwned;
                    isErased = _1431_recErased;
                    readIdents = _1432_recIdents;
                  }
                } else if (_source51.is_Seq) {
                  DAST._IType _1433___mcc_h672 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1434_recursiveGen;
                    bool _1435_recOwned;
                    bool _1436_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1437_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out896;
                    bool _out897;
                    bool _out898;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                    _1434_recursiveGen = _out896;
                    _1435_recOwned = _out897;
                    _1436_recErased = _out898;
                    _1437_recIdents = _out899;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1434_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1435_recOwned;
                    isErased = _1436_recErased;
                    readIdents = _1437_recIdents;
                  }
                } else if (_source51.is_Set) {
                  DAST._IType _1438___mcc_h674 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1439_recursiveGen;
                    bool _1440_recOwned;
                    bool _1441_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1442_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1439_recursiveGen = _out900;
                    _1440_recOwned = _out901;
                    _1441_recErased = _out902;
                    _1442_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1439_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1440_recOwned;
                    isErased = _1441_recErased;
                    readIdents = _1442_recIdents;
                  }
                } else if (_source51.is_Multiset) {
                  DAST._IType _1443___mcc_h676 = _source51.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1444_recursiveGen;
                    bool _1445_recOwned;
                    bool _1446_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1447_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1444_recursiveGen = _out904;
                    _1445_recOwned = _out905;
                    _1446_recErased = _out906;
                    _1447_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1444_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1445_recOwned;
                    isErased = _1446_recErased;
                    readIdents = _1447_recIdents;
                  }
                } else if (_source51.is_Map) {
                  DAST._IType _1448___mcc_h678 = _source51.dtor_key;
                  DAST._IType _1449___mcc_h679 = _source51.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1450_recursiveGen;
                    bool _1451_recOwned;
                    bool _1452_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1453_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1450_recursiveGen = _out908;
                    _1451_recOwned = _out909;
                    _1452_recErased = _out910;
                    _1453_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1450_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1451_recOwned;
                    isErased = _1452_recErased;
                    readIdents = _1453_recIdents;
                  }
                } else if (_source51.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1454___mcc_h682 = _source51.dtor_args;
                  DAST._IType _1455___mcc_h683 = _source51.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1456_recursiveGen;
                    bool _1457_recOwned;
                    bool _1458_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1459_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1456_recursiveGen = _out912;
                    _1457_recOwned = _out913;
                    _1458_recErased = _out914;
                    _1459_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1456_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1457_recOwned;
                    isErased = _1458_recErased;
                    readIdents = _1459_recIdents;
                  }
                } else if (_source51.is_Primitive) {
                  DAST._IPrimitive _1460___mcc_h686 = _source51.dtor_Primitive_a0;
                  DAST._IPrimitive _source53 = _1460___mcc_h686;
                  if (_source53.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1461_recursiveGen;
                      bool _1462_recOwned;
                      bool _1463_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1464_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1461_recursiveGen = _out916;
                      _1462_recOwned = _out917;
                      _1463_recErased = _out918;
                      _1464_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1461_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1462_recOwned;
                      isErased = _1463_recErased;
                      readIdents = _1464_recIdents;
                    }
                  } else if (_source53.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1465_recursiveGen;
                      bool _1466___v44;
                      bool _1467___v45;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1468_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, true, out _out920, out _out921, out _out922, out _out923);
                      _1465_recursiveGen = _out920;
                      _1466___v44 = _out921;
                      _1467___v45 = _out922;
                      _1468_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1465_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1468_recIdents;
                    }
                  } else if (_source53.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1469_recursiveGen;
                      bool _1470_recOwned;
                      bool _1471_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1472_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out924;
                      bool _out925;
                      bool _out926;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                      _1469_recursiveGen = _out924;
                      _1470_recOwned = _out925;
                      _1471_recErased = _out926;
                      _1472_recIdents = _out927;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1469_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1470_recOwned;
                      isErased = _1471_recErased;
                      readIdents = _1472_recIdents;
                    }
                  } else if (_source53.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1473_recursiveGen;
                      bool _1474_recOwned;
                      bool _1475_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1476_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out928;
                      bool _out929;
                      bool _out930;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out928, out _out929, out _out930, out _out931);
                      _1473_recursiveGen = _out928;
                      _1474_recOwned = _out929;
                      _1475_recErased = _out930;
                      _1476_recIdents = _out931;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1474_recOwned;
                      isErased = _1475_recErased;
                      readIdents = _1476_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1477_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out932;
                      _out932 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1477_rhsType = _out932;
                      Dafny.ISequence<Dafny.Rune> _1478_recursiveGen;
                      bool _1479___v54;
                      bool _1480___v55;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1481_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out933;
                      bool _out934;
                      bool _out935;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, true, out _out933, out _out934, out _out935, out _out936);
                      _1478_recursiveGen = _out933;
                      _1479___v54 = _out934;
                      _1480___v55 = _out935;
                      _1481_recIdents = _out936;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1478_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1481_recIdents;
                    }
                  }
                } else if (_source51.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1482___mcc_h688 = _source51.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1483_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    _out937 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                    _1483_rhsType = _out937;
                    Dafny.ISequence<Dafny.Rune> _1484_recursiveGen;
                    bool _1485___v49;
                    bool _1486___v50;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1487_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out938;
                    bool _out939;
                    bool _out940;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out941;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, true, out _out938, out _out939, out _out940, out _out941);
                    _1484_recursiveGen = _out938;
                    _1485___v49 = _out939;
                    _1486___v50 = _out940;
                    _1487_recIdents = _out941;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1483_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1484_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1487_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1488___mcc_h690 = _source51.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1489_recursiveGen;
                    bool _1490_recOwned;
                    bool _1491_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1492_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out942;
                    bool _out943;
                    bool _out944;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out945;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out942, out _out943, out _out944, out _out945);
                    _1489_recursiveGen = _out942;
                    _1490_recOwned = _out943;
                    _1491_recErased = _out944;
                    _1492_recIdents = _out945;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1489_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1490_recOwned;
                    isErased = _1491_recErased;
                    readIdents = _1492_recIdents;
                  }
                }
              } else if (_source50.is_Real) {
                DAST._IType _source54 = _500___mcc_h127;
                if (_source54.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1493___mcc_h692 = _source54.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1494___mcc_h693 = _source54.dtor_typeArgs;
                  DAST._IResolvedType _1495___mcc_h694 = _source54.dtor_resolved;
                  DAST._IResolvedType _source55 = _1495___mcc_h694;
                  if (_source55.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1496___mcc_h698 = _source55.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1497_recursiveGen;
                      bool _1498_recOwned;
                      bool _1499_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1500_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out946;
                      bool _out947;
                      bool _out948;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out949;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out946, out _out947, out _out948, out _out949);
                      _1497_recursiveGen = _out946;
                      _1498_recOwned = _out947;
                      _1499_recErased = _out948;
                      _1500_recIdents = _out949;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1497_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1498_recOwned;
                      isErased = _1499_recErased;
                      readIdents = _1500_recIdents;
                    }
                  } else if (_source55.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1501___mcc_h700 = _source55.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1502_recursiveGen;
                      bool _1503_recOwned;
                      bool _1504_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1505_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out950;
                      bool _out951;
                      bool _out952;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out953;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out950, out _out951, out _out952, out _out953);
                      _1502_recursiveGen = _out950;
                      _1503_recOwned = _out951;
                      _1504_recErased = _out952;
                      _1505_recIdents = _out953;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1503_recOwned;
                      isErased = _1504_recErased;
                      readIdents = _1505_recIdents;
                    }
                  } else {
                    DAST._IType _1506___mcc_h702 = _source55.dtor_Newtype_a0;
                    DAST._IType _1507_b = _1506___mcc_h702;
                    {
                      if (object.Equals(_493_fromTpe, _1507_b)) {
                        Dafny.ISequence<Dafny.Rune> _1508_recursiveGen;
                        bool _1509_recOwned;
                        bool _1510_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1511_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out954;
                        bool _out955;
                        bool _out956;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out957;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out954, out _out955, out _out956, out _out957);
                        _1508_recursiveGen = _out954;
                        _1509_recOwned = _out955;
                        _1510_recErased = _out956;
                        _1511_recIdents = _out957;
                        Dafny.ISequence<Dafny.Rune> _1512_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out958;
                        _out958 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _1512_rhsType = _out958;
                        Dafny.ISequence<Dafny.Rune> _1513_uneraseFn;
                        _1513_uneraseFn = ((_1509_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1512_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1513_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1508_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1509_recOwned;
                        isErased = false;
                        readIdents = _1511_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out959;
                        bool _out960;
                        bool _out961;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out962;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1507_b), _1507_b, _492_toTpe), selfIdent, @params, mustOwn, out _out959, out _out960, out _out961, out _out962);
                        s = _out959;
                        isOwned = _out960;
                        isErased = _out961;
                        readIdents = _out962;
                      }
                    }
                  }
                } else if (_source54.is_Nullable) {
                  DAST._IType _1514___mcc_h704 = _source54.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1515_recursiveGen;
                    bool _1516_recOwned;
                    bool _1517_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1518_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out963;
                    bool _out964;
                    bool _out965;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out966;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out963, out _out964, out _out965, out _out966);
                    _1515_recursiveGen = _out963;
                    _1516_recOwned = _out964;
                    _1517_recErased = _out965;
                    _1518_recIdents = _out966;
                    if (!(_1516_recOwned)) {
                      _1515_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1515_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1517_recErased;
                    readIdents = _1518_recIdents;
                  }
                } else if (_source54.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1519___mcc_h706 = _source54.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1520_recursiveGen;
                    bool _1521_recOwned;
                    bool _1522_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1523_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out967;
                    bool _out968;
                    bool _out969;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out970;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out967, out _out968, out _out969, out _out970);
                    _1520_recursiveGen = _out967;
                    _1521_recOwned = _out968;
                    _1522_recErased = _out969;
                    _1523_recIdents = _out970;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1521_recOwned;
                    isErased = _1522_recErased;
                    readIdents = _1523_recIdents;
                  }
                } else if (_source54.is_Array) {
                  DAST._IType _1524___mcc_h708 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1525_recursiveGen;
                    bool _1526_recOwned;
                    bool _1527_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1528_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out971;
                    bool _out972;
                    bool _out973;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out974;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out971, out _out972, out _out973, out _out974);
                    _1525_recursiveGen = _out971;
                    _1526_recOwned = _out972;
                    _1527_recErased = _out973;
                    _1528_recIdents = _out974;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1526_recOwned;
                    isErased = _1527_recErased;
                    readIdents = _1528_recIdents;
                  }
                } else if (_source54.is_Seq) {
                  DAST._IType _1529___mcc_h710 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1530_recursiveGen;
                    bool _1531_recOwned;
                    bool _1532_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1533_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out975;
                    bool _out976;
                    bool _out977;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out978;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out975, out _out976, out _out977, out _out978);
                    _1530_recursiveGen = _out975;
                    _1531_recOwned = _out976;
                    _1532_recErased = _out977;
                    _1533_recIdents = _out978;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1530_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1531_recOwned;
                    isErased = _1532_recErased;
                    readIdents = _1533_recIdents;
                  }
                } else if (_source54.is_Set) {
                  DAST._IType _1534___mcc_h712 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1535_recursiveGen;
                    bool _1536_recOwned;
                    bool _1537_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1538_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out979;
                    bool _out980;
                    bool _out981;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out982;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out979, out _out980, out _out981, out _out982);
                    _1535_recursiveGen = _out979;
                    _1536_recOwned = _out980;
                    _1537_recErased = _out981;
                    _1538_recIdents = _out982;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1535_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1536_recOwned;
                    isErased = _1537_recErased;
                    readIdents = _1538_recIdents;
                  }
                } else if (_source54.is_Multiset) {
                  DAST._IType _1539___mcc_h714 = _source54.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1540_recursiveGen;
                    bool _1541_recOwned;
                    bool _1542_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1543_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out983;
                    bool _out984;
                    bool _out985;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out986;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out983, out _out984, out _out985, out _out986);
                    _1540_recursiveGen = _out983;
                    _1541_recOwned = _out984;
                    _1542_recErased = _out985;
                    _1543_recIdents = _out986;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1540_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1541_recOwned;
                    isErased = _1542_recErased;
                    readIdents = _1543_recIdents;
                  }
                } else if (_source54.is_Map) {
                  DAST._IType _1544___mcc_h716 = _source54.dtor_key;
                  DAST._IType _1545___mcc_h717 = _source54.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1546_recursiveGen;
                    bool _1547_recOwned;
                    bool _1548_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1549_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out987;
                    bool _out988;
                    bool _out989;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out990;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out987, out _out988, out _out989, out _out990);
                    _1546_recursiveGen = _out987;
                    _1547_recOwned = _out988;
                    _1548_recErased = _out989;
                    _1549_recIdents = _out990;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1547_recOwned;
                    isErased = _1548_recErased;
                    readIdents = _1549_recIdents;
                  }
                } else if (_source54.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1550___mcc_h720 = _source54.dtor_args;
                  DAST._IType _1551___mcc_h721 = _source54.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1552_recursiveGen;
                    bool _1553_recOwned;
                    bool _1554_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1555_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out991;
                    bool _out992;
                    bool _out993;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out994;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out991, out _out992, out _out993, out _out994);
                    _1552_recursiveGen = _out991;
                    _1553_recOwned = _out992;
                    _1554_recErased = _out993;
                    _1555_recIdents = _out994;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1553_recOwned;
                    isErased = _1554_recErased;
                    readIdents = _1555_recIdents;
                  }
                } else if (_source54.is_Primitive) {
                  DAST._IPrimitive _1556___mcc_h724 = _source54.dtor_Primitive_a0;
                  DAST._IPrimitive _source56 = _1556___mcc_h724;
                  if (_source56.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1557_recursiveGen;
                      bool _1558___v46;
                      bool _1559___v47;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1560_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out995;
                      bool _out996;
                      bool _out997;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out998;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, false, out _out995, out _out996, out _out997, out _out998);
                      _1557_recursiveGen = _out995;
                      _1558___v46 = _out996;
                      _1559___v47 = _out997;
                      _1560_recIdents = _out998;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1557_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1560_recIdents;
                    }
                  } else if (_source56.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1561_recursiveGen;
                      bool _1562_recOwned;
                      bool _1563_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1564_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out999;
                      bool _out1000;
                      bool _out1001;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1002;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out999, out _out1000, out _out1001, out _out1002);
                      _1561_recursiveGen = _out999;
                      _1562_recOwned = _out1000;
                      _1563_recErased = _out1001;
                      _1564_recIdents = _out1002;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1561_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1562_recOwned;
                      isErased = _1563_recErased;
                      readIdents = _1564_recIdents;
                    }
                  } else if (_source56.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1565_recursiveGen;
                      bool _1566_recOwned;
                      bool _1567_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1568_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1003;
                      bool _out1004;
                      bool _out1005;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1006;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1003, out _out1004, out _out1005, out _out1006);
                      _1565_recursiveGen = _out1003;
                      _1566_recOwned = _out1004;
                      _1567_recErased = _out1005;
                      _1568_recIdents = _out1006;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1565_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1566_recOwned;
                      isErased = _1567_recErased;
                      readIdents = _1568_recIdents;
                    }
                  } else if (_source56.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1569_recursiveGen;
                      bool _1570_recOwned;
                      bool _1571_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1572_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1007;
                      bool _out1008;
                      bool _out1009;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1010;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1007, out _out1008, out _out1009, out _out1010);
                      _1569_recursiveGen = _out1007;
                      _1570_recOwned = _out1008;
                      _1571_recErased = _out1009;
                      _1572_recIdents = _out1010;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1569_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1570_recOwned;
                      isErased = _1571_recErased;
                      readIdents = _1572_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1573_recursiveGen;
                      bool _1574_recOwned;
                      bool _1575_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1576_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1011;
                      bool _out1012;
                      bool _out1013;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1014;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1011, out _out1012, out _out1013, out _out1014);
                      _1573_recursiveGen = _out1011;
                      _1574_recOwned = _out1012;
                      _1575_recErased = _out1013;
                      _1576_recIdents = _out1014;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1573_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1574_recOwned;
                      isErased = _1575_recErased;
                      readIdents = _1576_recIdents;
                    }
                  }
                } else if (_source54.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1577___mcc_h726 = _source54.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1578_recursiveGen;
                    bool _1579_recOwned;
                    bool _1580_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1581_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1015;
                    bool _out1016;
                    bool _out1017;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1018;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1015, out _out1016, out _out1017, out _out1018);
                    _1578_recursiveGen = _out1015;
                    _1579_recOwned = _out1016;
                    _1580_recErased = _out1017;
                    _1581_recIdents = _out1018;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1578_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1579_recOwned;
                    isErased = _1580_recErased;
                    readIdents = _1581_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1582___mcc_h728 = _source54.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1583_recursiveGen;
                    bool _1584_recOwned;
                    bool _1585_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1586_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1019;
                    bool _out1020;
                    bool _out1021;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1022;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1019, out _out1020, out _out1021, out _out1022);
                    _1583_recursiveGen = _out1019;
                    _1584_recOwned = _out1020;
                    _1585_recErased = _out1021;
                    _1586_recIdents = _out1022;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1583_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1584_recOwned;
                    isErased = _1585_recErased;
                    readIdents = _1586_recIdents;
                  }
                }
              } else if (_source50.is_String) {
                DAST._IType _source57 = _500___mcc_h127;
                if (_source57.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1587___mcc_h730 = _source57.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1588___mcc_h731 = _source57.dtor_typeArgs;
                  DAST._IResolvedType _1589___mcc_h732 = _source57.dtor_resolved;
                  DAST._IResolvedType _source58 = _1589___mcc_h732;
                  if (_source58.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1590___mcc_h736 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1591_recursiveGen;
                      bool _1592_recOwned;
                      bool _1593_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1594_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1023;
                      bool _out1024;
                      bool _out1025;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1026;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1023, out _out1024, out _out1025, out _out1026);
                      _1591_recursiveGen = _out1023;
                      _1592_recOwned = _out1024;
                      _1593_recErased = _out1025;
                      _1594_recIdents = _out1026;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1592_recOwned;
                      isErased = _1593_recErased;
                      readIdents = _1594_recIdents;
                    }
                  } else if (_source58.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1595___mcc_h738 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1596_recursiveGen;
                      bool _1597_recOwned;
                      bool _1598_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1599_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1027;
                      bool _out1028;
                      bool _out1029;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1030;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1027, out _out1028, out _out1029, out _out1030);
                      _1596_recursiveGen = _out1027;
                      _1597_recOwned = _out1028;
                      _1598_recErased = _out1029;
                      _1599_recIdents = _out1030;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1597_recOwned;
                      isErased = _1598_recErased;
                      readIdents = _1599_recIdents;
                    }
                  } else {
                    DAST._IType _1600___mcc_h740 = _source58.dtor_Newtype_a0;
                    DAST._IType _1601_b = _1600___mcc_h740;
                    {
                      if (object.Equals(_493_fromTpe, _1601_b)) {
                        Dafny.ISequence<Dafny.Rune> _1602_recursiveGen;
                        bool _1603_recOwned;
                        bool _1604_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1605_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1031;
                        bool _out1032;
                        bool _out1033;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1031, out _out1032, out _out1033, out _out1034);
                        _1602_recursiveGen = _out1031;
                        _1603_recOwned = _out1032;
                        _1604_recErased = _out1033;
                        _1605_recIdents = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1606_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        _out1035 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _1606_rhsType = _out1035;
                        Dafny.ISequence<Dafny.Rune> _1607_uneraseFn;
                        _1607_uneraseFn = ((_1603_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1606_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1607_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1602_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1603_recOwned;
                        isErased = false;
                        readIdents = _1605_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1036;
                        bool _out1037;
                        bool _out1038;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1039;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1601_b), _1601_b, _492_toTpe), selfIdent, @params, mustOwn, out _out1036, out _out1037, out _out1038, out _out1039);
                        s = _out1036;
                        isOwned = _out1037;
                        isErased = _out1038;
                        readIdents = _out1039;
                      }
                    }
                  }
                } else if (_source57.is_Nullable) {
                  DAST._IType _1608___mcc_h742 = _source57.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                    bool _1610_recOwned;
                    bool _1611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1040;
                    bool _out1041;
                    bool _out1042;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1043;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1040, out _out1041, out _out1042, out _out1043);
                    _1609_recursiveGen = _out1040;
                    _1610_recOwned = _out1041;
                    _1611_recErased = _out1042;
                    _1612_recIdents = _out1043;
                    if (!(_1610_recOwned)) {
                      _1609_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1609_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1611_recErased;
                    readIdents = _1612_recIdents;
                  }
                } else if (_source57.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1613___mcc_h744 = _source57.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1614_recursiveGen;
                    bool _1615_recOwned;
                    bool _1616_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1044;
                    bool _out1045;
                    bool _out1046;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1047;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1044, out _out1045, out _out1046, out _out1047);
                    _1614_recursiveGen = _out1044;
                    _1615_recOwned = _out1045;
                    _1616_recErased = _out1046;
                    _1617_recIdents = _out1047;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1615_recOwned;
                    isErased = _1616_recErased;
                    readIdents = _1617_recIdents;
                  }
                } else if (_source57.is_Array) {
                  DAST._IType _1618___mcc_h746 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1619_recursiveGen;
                    bool _1620_recOwned;
                    bool _1621_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1622_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1048;
                    bool _out1049;
                    bool _out1050;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1051;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1048, out _out1049, out _out1050, out _out1051);
                    _1619_recursiveGen = _out1048;
                    _1620_recOwned = _out1049;
                    _1621_recErased = _out1050;
                    _1622_recIdents = _out1051;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1619_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1620_recOwned;
                    isErased = _1621_recErased;
                    readIdents = _1622_recIdents;
                  }
                } else if (_source57.is_Seq) {
                  DAST._IType _1623___mcc_h748 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1624_recursiveGen;
                    bool _1625_recOwned;
                    bool _1626_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1627_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1052;
                    bool _out1053;
                    bool _out1054;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1055;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1052, out _out1053, out _out1054, out _out1055);
                    _1624_recursiveGen = _out1052;
                    _1625_recOwned = _out1053;
                    _1626_recErased = _out1054;
                    _1627_recIdents = _out1055;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1624_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1625_recOwned;
                    isErased = _1626_recErased;
                    readIdents = _1627_recIdents;
                  }
                } else if (_source57.is_Set) {
                  DAST._IType _1628___mcc_h750 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1629_recursiveGen;
                    bool _1630_recOwned;
                    bool _1631_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1632_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1056;
                    bool _out1057;
                    bool _out1058;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1059;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1056, out _out1057, out _out1058, out _out1059);
                    _1629_recursiveGen = _out1056;
                    _1630_recOwned = _out1057;
                    _1631_recErased = _out1058;
                    _1632_recIdents = _out1059;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1630_recOwned;
                    isErased = _1631_recErased;
                    readIdents = _1632_recIdents;
                  }
                } else if (_source57.is_Multiset) {
                  DAST._IType _1633___mcc_h752 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1634_recursiveGen;
                    bool _1635_recOwned;
                    bool _1636_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1637_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1060;
                    bool _out1061;
                    bool _out1062;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1063;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1060, out _out1061, out _out1062, out _out1063);
                    _1634_recursiveGen = _out1060;
                    _1635_recOwned = _out1061;
                    _1636_recErased = _out1062;
                    _1637_recIdents = _out1063;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1635_recOwned;
                    isErased = _1636_recErased;
                    readIdents = _1637_recIdents;
                  }
                } else if (_source57.is_Map) {
                  DAST._IType _1638___mcc_h754 = _source57.dtor_key;
                  DAST._IType _1639___mcc_h755 = _source57.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1640_recursiveGen;
                    bool _1641_recOwned;
                    bool _1642_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1643_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1064;
                    bool _out1065;
                    bool _out1066;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1067;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1064, out _out1065, out _out1066, out _out1067);
                    _1640_recursiveGen = _out1064;
                    _1641_recOwned = _out1065;
                    _1642_recErased = _out1066;
                    _1643_recIdents = _out1067;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1641_recOwned;
                    isErased = _1642_recErased;
                    readIdents = _1643_recIdents;
                  }
                } else if (_source57.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1644___mcc_h758 = _source57.dtor_args;
                  DAST._IType _1645___mcc_h759 = _source57.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1646_recursiveGen;
                    bool _1647_recOwned;
                    bool _1648_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1649_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1068;
                    bool _out1069;
                    bool _out1070;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1068, out _out1069, out _out1070, out _out1071);
                    _1646_recursiveGen = _out1068;
                    _1647_recOwned = _out1069;
                    _1648_recErased = _out1070;
                    _1649_recIdents = _out1071;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1646_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1647_recOwned;
                    isErased = _1648_recErased;
                    readIdents = _1649_recIdents;
                  }
                } else if (_source57.is_Primitive) {
                  DAST._IPrimitive _1650___mcc_h762 = _source57.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1651_recursiveGen;
                    bool _1652_recOwned;
                    bool _1653_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1654_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1072;
                    bool _out1073;
                    bool _out1074;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                    _1651_recursiveGen = _out1072;
                    _1652_recOwned = _out1073;
                    _1653_recErased = _out1074;
                    _1654_recIdents = _out1075;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1651_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1652_recOwned;
                    isErased = _1653_recErased;
                    readIdents = _1654_recIdents;
                  }
                } else if (_source57.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1655___mcc_h764 = _source57.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1656_recursiveGen;
                    bool _1657_recOwned;
                    bool _1658_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1659_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1076;
                    bool _out1077;
                    bool _out1078;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                    _1656_recursiveGen = _out1076;
                    _1657_recOwned = _out1077;
                    _1658_recErased = _out1078;
                    _1659_recIdents = _out1079;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1656_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1657_recOwned;
                    isErased = _1658_recErased;
                    readIdents = _1659_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1660___mcc_h766 = _source57.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1661_recursiveGen;
                    bool _1662_recOwned;
                    bool _1663_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1664_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1080;
                    bool _out1081;
                    bool _out1082;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                    _1661_recursiveGen = _out1080;
                    _1662_recOwned = _out1081;
                    _1663_recErased = _out1082;
                    _1664_recIdents = _out1083;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1661_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1662_recOwned;
                    isErased = _1663_recErased;
                    readIdents = _1664_recIdents;
                  }
                }
              } else if (_source50.is_Bool) {
                DAST._IType _source59 = _500___mcc_h127;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1665___mcc_h768 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1666___mcc_h769 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1667___mcc_h770 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1667___mcc_h770;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1668___mcc_h774 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1669_recursiveGen;
                      bool _1670_recOwned;
                      bool _1671_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1672_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1669_recursiveGen = _out1084;
                      _1670_recOwned = _out1085;
                      _1671_recErased = _out1086;
                      _1672_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1670_recOwned;
                      isErased = _1671_recErased;
                      readIdents = _1672_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1673___mcc_h776 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1674_recursiveGen;
                      bool _1675_recOwned;
                      bool _1676_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1677_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1088;
                      bool _out1089;
                      bool _out1090;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                      _1674_recursiveGen = _out1088;
                      _1675_recOwned = _out1089;
                      _1676_recErased = _out1090;
                      _1677_recIdents = _out1091;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1674_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1675_recOwned;
                      isErased = _1676_recErased;
                      readIdents = _1677_recIdents;
                    }
                  } else {
                    DAST._IType _1678___mcc_h778 = _source60.dtor_Newtype_a0;
                    DAST._IType _1679_b = _1678___mcc_h778;
                    {
                      if (object.Equals(_493_fromTpe, _1679_b)) {
                        Dafny.ISequence<Dafny.Rune> _1680_recursiveGen;
                        bool _1681_recOwned;
                        bool _1682_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1092;
                        bool _out1093;
                        bool _out1094;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                        _1680_recursiveGen = _out1092;
                        _1681_recOwned = _out1093;
                        _1682_recErased = _out1094;
                        _1683_recIdents = _out1095;
                        Dafny.ISequence<Dafny.Rune> _1684_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1096;
                        _out1096 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _1684_rhsType = _out1096;
                        Dafny.ISequence<Dafny.Rune> _1685_uneraseFn;
                        _1685_uneraseFn = ((_1681_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1684_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1685_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1681_recOwned;
                        isErased = false;
                        readIdents = _1683_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1097;
                        bool _out1098;
                        bool _out1099;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1100;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1679_b), _1679_b, _492_toTpe), selfIdent, @params, mustOwn, out _out1097, out _out1098, out _out1099, out _out1100);
                        s = _out1097;
                        isOwned = _out1098;
                        isErased = _out1099;
                        readIdents = _out1100;
                      }
                    }
                  }
                } else if (_source59.is_Nullable) {
                  DAST._IType _1686___mcc_h780 = _source59.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1687_recursiveGen;
                    bool _1688_recOwned;
                    bool _1689_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1690_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1101;
                    bool _out1102;
                    bool _out1103;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1104;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1101, out _out1102, out _out1103, out _out1104);
                    _1687_recursiveGen = _out1101;
                    _1688_recOwned = _out1102;
                    _1689_recErased = _out1103;
                    _1690_recIdents = _out1104;
                    if (!(_1688_recOwned)) {
                      _1687_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1687_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1689_recErased;
                    readIdents = _1690_recIdents;
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1691___mcc_h782 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1692_recursiveGen;
                    bool _1693_recOwned;
                    bool _1694_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1695_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1105;
                    bool _out1106;
                    bool _out1107;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1108;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1105, out _out1106, out _out1107, out _out1108);
                    _1692_recursiveGen = _out1105;
                    _1693_recOwned = _out1106;
                    _1694_recErased = _out1107;
                    _1695_recIdents = _out1108;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1692_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1693_recOwned;
                    isErased = _1694_recErased;
                    readIdents = _1695_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1696___mcc_h784 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1697_recursiveGen;
                    bool _1698_recOwned;
                    bool _1699_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1700_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1109;
                    bool _out1110;
                    bool _out1111;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                    _1697_recursiveGen = _out1109;
                    _1698_recOwned = _out1110;
                    _1699_recErased = _out1111;
                    _1700_recIdents = _out1112;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1697_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1698_recOwned;
                    isErased = _1699_recErased;
                    readIdents = _1700_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1701___mcc_h786 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1702_recursiveGen;
                    bool _1703_recOwned;
                    bool _1704_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1705_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1113;
                    bool _out1114;
                    bool _out1115;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                    _1702_recursiveGen = _out1113;
                    _1703_recOwned = _out1114;
                    _1704_recErased = _out1115;
                    _1705_recIdents = _out1116;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1702_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1703_recOwned;
                    isErased = _1704_recErased;
                    readIdents = _1705_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1706___mcc_h788 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1707_recursiveGen;
                    bool _1708_recOwned;
                    bool _1709_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1710_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1117;
                    bool _out1118;
                    bool _out1119;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                    _1707_recursiveGen = _out1117;
                    _1708_recOwned = _out1118;
                    _1709_recErased = _out1119;
                    _1710_recIdents = _out1120;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1707_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1708_recOwned;
                    isErased = _1709_recErased;
                    readIdents = _1710_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1711___mcc_h790 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1712_recursiveGen;
                    bool _1713_recOwned;
                    bool _1714_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1715_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1121;
                    bool _out1122;
                    bool _out1123;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                    _1712_recursiveGen = _out1121;
                    _1713_recOwned = _out1122;
                    _1714_recErased = _out1123;
                    _1715_recIdents = _out1124;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1712_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1713_recOwned;
                    isErased = _1714_recErased;
                    readIdents = _1715_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1716___mcc_h792 = _source59.dtor_key;
                  DAST._IType _1717___mcc_h793 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1718_recursiveGen;
                    bool _1719_recOwned;
                    bool _1720_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1721_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1125;
                    bool _out1126;
                    bool _out1127;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                    _1718_recursiveGen = _out1125;
                    _1719_recOwned = _out1126;
                    _1720_recErased = _out1127;
                    _1721_recIdents = _out1128;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1719_recOwned;
                    isErased = _1720_recErased;
                    readIdents = _1721_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1722___mcc_h796 = _source59.dtor_args;
                  DAST._IType _1723___mcc_h797 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1724_recursiveGen;
                    bool _1725_recOwned;
                    bool _1726_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1727_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1129;
                    bool _out1130;
                    bool _out1131;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                    _1724_recursiveGen = _out1129;
                    _1725_recOwned = _out1130;
                    _1726_recErased = _out1131;
                    _1727_recIdents = _out1132;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1724_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1725_recOwned;
                    isErased = _1726_recErased;
                    readIdents = _1727_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1728___mcc_h800 = _source59.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1729_recursiveGen;
                    bool _1730_recOwned;
                    bool _1731_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1732_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1133;
                    bool _out1134;
                    bool _out1135;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                    _1729_recursiveGen = _out1133;
                    _1730_recOwned = _out1134;
                    _1731_recErased = _out1135;
                    _1732_recIdents = _out1136;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1729_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1730_recOwned;
                    isErased = _1731_recErased;
                    readIdents = _1732_recIdents;
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1733___mcc_h802 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1734_recursiveGen;
                    bool _1735_recOwned;
                    bool _1736_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1737_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1137;
                    bool _out1138;
                    bool _out1139;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                    _1734_recursiveGen = _out1137;
                    _1735_recOwned = _out1138;
                    _1736_recErased = _out1139;
                    _1737_recIdents = _out1140;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1734_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1735_recOwned;
                    isErased = _1736_recErased;
                    readIdents = _1737_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1738___mcc_h804 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1739_recursiveGen;
                    bool _1740_recOwned;
                    bool _1741_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1742_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    bool _out1142;
                    bool _out1143;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                    _1739_recursiveGen = _out1141;
                    _1740_recOwned = _out1142;
                    _1741_recErased = _out1143;
                    _1742_recIdents = _out1144;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1739_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1740_recOwned;
                    isErased = _1741_recErased;
                    readIdents = _1742_recIdents;
                  }
                }
              } else {
                DAST._IType _source61 = _500___mcc_h127;
                if (_source61.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1743___mcc_h806 = _source61.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1744___mcc_h807 = _source61.dtor_typeArgs;
                  DAST._IResolvedType _1745___mcc_h808 = _source61.dtor_resolved;
                  DAST._IResolvedType _source62 = _1745___mcc_h808;
                  if (_source62.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1746___mcc_h812 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1747_recursiveGen;
                      bool _1748_recOwned;
                      bool _1749_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1750_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1145;
                      bool _out1146;
                      bool _out1147;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                      _1747_recursiveGen = _out1145;
                      _1748_recOwned = _out1146;
                      _1749_recErased = _out1147;
                      _1750_recIdents = _out1148;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1747_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1748_recOwned;
                      isErased = _1749_recErased;
                      readIdents = _1750_recIdents;
                    }
                  } else if (_source62.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1751___mcc_h814 = _source62.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1752_recursiveGen;
                      bool _1753_recOwned;
                      bool _1754_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1755_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1149;
                      bool _out1150;
                      bool _out1151;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1152;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1149, out _out1150, out _out1151, out _out1152);
                      _1752_recursiveGen = _out1149;
                      _1753_recOwned = _out1150;
                      _1754_recErased = _out1151;
                      _1755_recIdents = _out1152;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1753_recOwned;
                      isErased = _1754_recErased;
                      readIdents = _1755_recIdents;
                    }
                  } else {
                    DAST._IType _1756___mcc_h816 = _source62.dtor_Newtype_a0;
                    DAST._IType _1757_b = _1756___mcc_h816;
                    {
                      if (object.Equals(_493_fromTpe, _1757_b)) {
                        Dafny.ISequence<Dafny.Rune> _1758_recursiveGen;
                        bool _1759_recOwned;
                        bool _1760_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1761_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1153;
                        bool _out1154;
                        bool _out1155;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1156;
                        DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1153, out _out1154, out _out1155, out _out1156);
                        _1758_recursiveGen = _out1153;
                        _1759_recOwned = _out1154;
                        _1760_recErased = _out1155;
                        _1761_recIdents = _out1156;
                        Dafny.ISequence<Dafny.Rune> _1762_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1157;
                        _out1157 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                        _1762_rhsType = _out1157;
                        Dafny.ISequence<Dafny.Rune> _1763_uneraseFn;
                        _1763_uneraseFn = ((_1759_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1762_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1763_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1758_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1759_recOwned;
                        isErased = false;
                        readIdents = _1761_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1158;
                        bool _out1159;
                        bool _out1160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1757_b), _1757_b, _492_toTpe), selfIdent, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                        s = _out1158;
                        isOwned = _out1159;
                        isErased = _out1160;
                        readIdents = _out1161;
                      }
                    }
                  }
                } else if (_source61.is_Nullable) {
                  DAST._IType _1764___mcc_h818 = _source61.dtor_Nullable_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1765_recursiveGen;
                    bool _1766_recOwned;
                    bool _1767_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1768_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1765_recursiveGen = _out1162;
                    _1766_recOwned = _out1163;
                    _1767_recErased = _out1164;
                    _1768_recIdents = _out1165;
                    if (!(_1766_recOwned)) {
                      _1765_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1765_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                    }
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1765_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = _1767_recErased;
                    readIdents = _1768_recIdents;
                  }
                } else if (_source61.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1769___mcc_h820 = _source61.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1770_recursiveGen;
                    bool _1771_recOwned;
                    bool _1772_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1773_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1770_recursiveGen = _out1166;
                    _1771_recOwned = _out1167;
                    _1772_recErased = _out1168;
                    _1773_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1770_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1771_recOwned;
                    isErased = _1772_recErased;
                    readIdents = _1773_recIdents;
                  }
                } else if (_source61.is_Array) {
                  DAST._IType _1774___mcc_h822 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1775_recursiveGen;
                    bool _1776_recOwned;
                    bool _1777_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1778_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1170;
                    bool _out1171;
                    bool _out1172;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1170, out _out1171, out _out1172, out _out1173);
                    _1775_recursiveGen = _out1170;
                    _1776_recOwned = _out1171;
                    _1777_recErased = _out1172;
                    _1778_recIdents = _out1173;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1775_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1776_recOwned;
                    isErased = _1777_recErased;
                    readIdents = _1778_recIdents;
                  }
                } else if (_source61.is_Seq) {
                  DAST._IType _1779___mcc_h824 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1780_recursiveGen;
                    bool _1781_recOwned;
                    bool _1782_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1783_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1174;
                    bool _out1175;
                    bool _out1176;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1177;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1174, out _out1175, out _out1176, out _out1177);
                    _1780_recursiveGen = _out1174;
                    _1781_recOwned = _out1175;
                    _1782_recErased = _out1176;
                    _1783_recIdents = _out1177;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1780_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1781_recOwned;
                    isErased = _1782_recErased;
                    readIdents = _1783_recIdents;
                  }
                } else if (_source61.is_Set) {
                  DAST._IType _1784___mcc_h826 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1785_recursiveGen;
                    bool _1786_recOwned;
                    bool _1787_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1788_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1178;
                    bool _out1179;
                    bool _out1180;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1181;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1178, out _out1179, out _out1180, out _out1181);
                    _1785_recursiveGen = _out1178;
                    _1786_recOwned = _out1179;
                    _1787_recErased = _out1180;
                    _1788_recIdents = _out1181;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1785_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1786_recOwned;
                    isErased = _1787_recErased;
                    readIdents = _1788_recIdents;
                  }
                } else if (_source61.is_Multiset) {
                  DAST._IType _1789___mcc_h828 = _source61.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1790_recursiveGen;
                    bool _1791_recOwned;
                    bool _1792_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1793_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1182;
                    bool _out1183;
                    bool _out1184;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1185;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1182, out _out1183, out _out1184, out _out1185);
                    _1790_recursiveGen = _out1182;
                    _1791_recOwned = _out1183;
                    _1792_recErased = _out1184;
                    _1793_recIdents = _out1185;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1790_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1791_recOwned;
                    isErased = _1792_recErased;
                    readIdents = _1793_recIdents;
                  }
                } else if (_source61.is_Map) {
                  DAST._IType _1794___mcc_h830 = _source61.dtor_key;
                  DAST._IType _1795___mcc_h831 = _source61.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1796_recursiveGen;
                    bool _1797_recOwned;
                    bool _1798_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1799_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1186;
                    bool _out1187;
                    bool _out1188;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1189;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1186, out _out1187, out _out1188, out _out1189);
                    _1796_recursiveGen = _out1186;
                    _1797_recOwned = _out1187;
                    _1798_recErased = _out1188;
                    _1799_recIdents = _out1189;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1796_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1797_recOwned;
                    isErased = _1798_recErased;
                    readIdents = _1799_recIdents;
                  }
                } else if (_source61.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1800___mcc_h834 = _source61.dtor_args;
                  DAST._IType _1801___mcc_h835 = _source61.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1802_recursiveGen;
                    bool _1803_recOwned;
                    bool _1804_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1805_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1190;
                    bool _out1191;
                    bool _out1192;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1193;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1190, out _out1191, out _out1192, out _out1193);
                    _1802_recursiveGen = _out1190;
                    _1803_recOwned = _out1191;
                    _1804_recErased = _out1192;
                    _1805_recIdents = _out1193;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1802_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1803_recOwned;
                    isErased = _1804_recErased;
                    readIdents = _1805_recIdents;
                  }
                } else if (_source61.is_Primitive) {
                  DAST._IPrimitive _1806___mcc_h838 = _source61.dtor_Primitive_a0;
                  DAST._IPrimitive _source63 = _1806___mcc_h838;
                  if (_source63.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1807_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1194;
                      _out1194 = DCOMP.COMP.GenType(_493_fromTpe, true, false);
                      _1807_rhsType = _out1194;
                      Dafny.ISequence<Dafny.Rune> _1808_recursiveGen;
                      bool _1809___v56;
                      bool _1810___v57;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1811_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1195;
                      bool _out1196;
                      bool _out1197;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1198;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, true, out _out1195, out _out1196, out _out1197, out _out1198);
                      _1808_recursiveGen = _out1195;
                      _1809___v56 = _out1196;
                      _1810___v57 = _out1197;
                      _1811_recIdents = _out1198;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1808_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1811_recIdents;
                    }
                  } else if (_source63.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1812_recursiveGen;
                      bool _1813_recOwned;
                      bool _1814_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1815_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1199;
                      bool _out1200;
                      bool _out1201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1202;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1199, out _out1200, out _out1201, out _out1202);
                      _1812_recursiveGen = _out1199;
                      _1813_recOwned = _out1200;
                      _1814_recErased = _out1201;
                      _1815_recIdents = _out1202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1812_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1813_recOwned;
                      isErased = _1814_recErased;
                      readIdents = _1815_recIdents;
                    }
                  } else if (_source63.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1816_recursiveGen;
                      bool _1817_recOwned;
                      bool _1818_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1819_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1203;
                      bool _out1204;
                      bool _out1205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1206;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1203, out _out1204, out _out1205, out _out1206);
                      _1816_recursiveGen = _out1203;
                      _1817_recOwned = _out1204;
                      _1818_recErased = _out1205;
                      _1819_recIdents = _out1206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1816_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1817_recOwned;
                      isErased = _1818_recErased;
                      readIdents = _1819_recIdents;
                    }
                  } else if (_source63.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1820_recursiveGen;
                      bool _1821_recOwned;
                      bool _1822_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1823_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1207;
                      bool _out1208;
                      bool _out1209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1210;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1207, out _out1208, out _out1209, out _out1210);
                      _1820_recursiveGen = _out1207;
                      _1821_recOwned = _out1208;
                      _1822_recErased = _out1209;
                      _1823_recIdents = _out1210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1820_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1821_recOwned;
                      isErased = _1822_recErased;
                      readIdents = _1823_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1824_recursiveGen;
                      bool _1825_recOwned;
                      bool _1826_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1827_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1211;
                      bool _out1212;
                      bool _out1213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1214;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1211, out _out1212, out _out1213, out _out1214);
                      _1824_recursiveGen = _out1211;
                      _1825_recOwned = _out1212;
                      _1826_recErased = _out1213;
                      _1827_recIdents = _out1214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1824_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1825_recOwned;
                      isErased = _1826_recErased;
                      readIdents = _1827_recIdents;
                    }
                  }
                } else if (_source61.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1828___mcc_h840 = _source61.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1829_recursiveGen;
                    bool _1830_recOwned;
                    bool _1831_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1832_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1215;
                    bool _out1216;
                    bool _out1217;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1218;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1215, out _out1216, out _out1217, out _out1218);
                    _1829_recursiveGen = _out1215;
                    _1830_recOwned = _out1216;
                    _1831_recErased = _out1217;
                    _1832_recIdents = _out1218;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1829_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1830_recOwned;
                    isErased = _1831_recErased;
                    readIdents = _1832_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1833___mcc_h842 = _source61.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1834_recursiveGen;
                    bool _1835_recOwned;
                    bool _1836_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1837_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1219;
                    bool _out1220;
                    bool _out1221;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1222;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1219, out _out1220, out _out1221, out _out1222);
                    _1834_recursiveGen = _out1219;
                    _1835_recOwned = _out1220;
                    _1836_recErased = _out1221;
                    _1837_recIdents = _out1222;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1834_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1835_recOwned;
                    isErased = _1836_recErased;
                    readIdents = _1837_recIdents;
                  }
                }
              }
            } else if (_source26.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1838___mcc_h844 = _source26.dtor_Passthrough_a0;
              DAST._IType _source64 = _500___mcc_h127;
              if (_source64.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1839___mcc_h848 = _source64.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1840___mcc_h849 = _source64.dtor_typeArgs;
                DAST._IResolvedType _1841___mcc_h850 = _source64.dtor_resolved;
                DAST._IResolvedType _source65 = _1841___mcc_h850;
                if (_source65.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1842___mcc_h854 = _source65.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1843_recursiveGen;
                    bool _1844_recOwned;
                    bool _1845_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1846_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1223;
                    bool _out1224;
                    bool _out1225;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1226;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1223, out _out1224, out _out1225, out _out1226);
                    _1843_recursiveGen = _out1223;
                    _1844_recOwned = _out1224;
                    _1845_recErased = _out1225;
                    _1846_recIdents = _out1226;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1843_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1844_recOwned;
                    isErased = _1845_recErased;
                    readIdents = _1846_recIdents;
                  }
                } else if (_source65.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1847___mcc_h856 = _source65.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1848_recursiveGen;
                    bool _1849_recOwned;
                    bool _1850_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1851_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1227;
                    bool _out1228;
                    bool _out1229;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1230;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1227, out _out1228, out _out1229, out _out1230);
                    _1848_recursiveGen = _out1227;
                    _1849_recOwned = _out1228;
                    _1850_recErased = _out1229;
                    _1851_recIdents = _out1230;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1849_recOwned;
                    isErased = _1850_recErased;
                    readIdents = _1851_recIdents;
                  }
                } else {
                  DAST._IType _1852___mcc_h858 = _source65.dtor_Newtype_a0;
                  DAST._IType _1853_b = _1852___mcc_h858;
                  {
                    if (object.Equals(_493_fromTpe, _1853_b)) {
                      Dafny.ISequence<Dafny.Rune> _1854_recursiveGen;
                      bool _1855_recOwned;
                      bool _1856_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1857_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1231;
                      bool _out1232;
                      bool _out1233;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1234;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1231, out _out1232, out _out1233, out _out1234);
                      _1854_recursiveGen = _out1231;
                      _1855_recOwned = _out1232;
                      _1856_recErased = _out1233;
                      _1857_recIdents = _out1234;
                      Dafny.ISequence<Dafny.Rune> _1858_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1235;
                      _out1235 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1858_rhsType = _out1235;
                      Dafny.ISequence<Dafny.Rune> _1859_uneraseFn;
                      _1859_uneraseFn = ((_1855_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1858_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1859_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1854_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1855_recOwned;
                      isErased = false;
                      readIdents = _1857_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1236;
                      bool _out1237;
                      bool _out1238;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1853_b), _1853_b, _492_toTpe), selfIdent, @params, mustOwn, out _out1236, out _out1237, out _out1238, out _out1239);
                      s = _out1236;
                      isOwned = _out1237;
                      isErased = _out1238;
                      readIdents = _out1239;
                    }
                  }
                }
              } else if (_source64.is_Nullable) {
                DAST._IType _1860___mcc_h860 = _source64.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1861_recursiveGen;
                  bool _1862_recOwned;
                  bool _1863_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1864_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1240;
                  bool _out1241;
                  bool _out1242;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
                  _1861_recursiveGen = _out1240;
                  _1862_recOwned = _out1241;
                  _1863_recErased = _out1242;
                  _1864_recIdents = _out1243;
                  if (!(_1862_recOwned)) {
                    _1861_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1861_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1861_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1863_recErased;
                  readIdents = _1864_recIdents;
                }
              } else if (_source64.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1865___mcc_h862 = _source64.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1866_recursiveGen;
                  bool _1867_recOwned;
                  bool _1868_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1869_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1244;
                  bool _out1245;
                  bool _out1246;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1244, out _out1245, out _out1246, out _out1247);
                  _1866_recursiveGen = _out1244;
                  _1867_recOwned = _out1245;
                  _1868_recErased = _out1246;
                  _1869_recIdents = _out1247;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1866_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1867_recOwned;
                  isErased = _1868_recErased;
                  readIdents = _1869_recIdents;
                }
              } else if (_source64.is_Array) {
                DAST._IType _1870___mcc_h864 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1871_recursiveGen;
                  bool _1872_recOwned;
                  bool _1873_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1874_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1248;
                  bool _out1249;
                  bool _out1250;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
                  _1871_recursiveGen = _out1248;
                  _1872_recOwned = _out1249;
                  _1873_recErased = _out1250;
                  _1874_recIdents = _out1251;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1871_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1872_recOwned;
                  isErased = _1873_recErased;
                  readIdents = _1874_recIdents;
                }
              } else if (_source64.is_Seq) {
                DAST._IType _1875___mcc_h866 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1876_recursiveGen;
                  bool _1877_recOwned;
                  bool _1878_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1879_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1252;
                  bool _out1253;
                  bool _out1254;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1252, out _out1253, out _out1254, out _out1255);
                  _1876_recursiveGen = _out1252;
                  _1877_recOwned = _out1253;
                  _1878_recErased = _out1254;
                  _1879_recIdents = _out1255;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1876_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1877_recOwned;
                  isErased = _1878_recErased;
                  readIdents = _1879_recIdents;
                }
              } else if (_source64.is_Set) {
                DAST._IType _1880___mcc_h868 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1881_recursiveGen;
                  bool _1882_recOwned;
                  bool _1883_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1884_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1256;
                  bool _out1257;
                  bool _out1258;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1256, out _out1257, out _out1258, out _out1259);
                  _1881_recursiveGen = _out1256;
                  _1882_recOwned = _out1257;
                  _1883_recErased = _out1258;
                  _1884_recIdents = _out1259;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1881_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1882_recOwned;
                  isErased = _1883_recErased;
                  readIdents = _1884_recIdents;
                }
              } else if (_source64.is_Multiset) {
                DAST._IType _1885___mcc_h870 = _source64.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1886_recursiveGen;
                  bool _1887_recOwned;
                  bool _1888_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1889_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1260;
                  bool _out1261;
                  bool _out1262;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1260, out _out1261, out _out1262, out _out1263);
                  _1886_recursiveGen = _out1260;
                  _1887_recOwned = _out1261;
                  _1888_recErased = _out1262;
                  _1889_recIdents = _out1263;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1887_recOwned;
                  isErased = _1888_recErased;
                  readIdents = _1889_recIdents;
                }
              } else if (_source64.is_Map) {
                DAST._IType _1890___mcc_h872 = _source64.dtor_key;
                DAST._IType _1891___mcc_h873 = _source64.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1892_recursiveGen;
                  bool _1893_recOwned;
                  bool _1894_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1895_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1264;
                  bool _out1265;
                  bool _out1266;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1264, out _out1265, out _out1266, out _out1267);
                  _1892_recursiveGen = _out1264;
                  _1893_recOwned = _out1265;
                  _1894_recErased = _out1266;
                  _1895_recIdents = _out1267;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1892_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1893_recOwned;
                  isErased = _1894_recErased;
                  readIdents = _1895_recIdents;
                }
              } else if (_source64.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1896___mcc_h876 = _source64.dtor_args;
                DAST._IType _1897___mcc_h877 = _source64.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1898_recursiveGen;
                  bool _1899_recOwned;
                  bool _1900_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1901_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1268;
                  bool _out1269;
                  bool _out1270;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1268, out _out1269, out _out1270, out _out1271);
                  _1898_recursiveGen = _out1268;
                  _1899_recOwned = _out1269;
                  _1900_recErased = _out1270;
                  _1901_recIdents = _out1271;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1898_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1899_recOwned;
                  isErased = _1900_recErased;
                  readIdents = _1901_recIdents;
                }
              } else if (_source64.is_Primitive) {
                DAST._IPrimitive _1902___mcc_h880 = _source64.dtor_Primitive_a0;
                DAST._IPrimitive _source66 = _1902___mcc_h880;
                if (_source66.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1903_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1272;
                    _out1272 = DCOMP.COMP.GenType(_493_fromTpe, true, false);
                    _1903_rhsType = _out1272;
                    Dafny.ISequence<Dafny.Rune> _1904_recursiveGen;
                    bool _1905___v52;
                    bool _1906___v53;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1907_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1273;
                    bool _out1274;
                    bool _out1275;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1276;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, true, out _out1273, out _out1274, out _out1275, out _out1276);
                    _1904_recursiveGen = _out1273;
                    _1905___v52 = _out1274;
                    _1906___v53 = _out1275;
                    _1907_recIdents = _out1276;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1904_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1907_recIdents;
                  }
                } else if (_source66.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1908_recursiveGen;
                    bool _1909_recOwned;
                    bool _1910_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1911_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1277;
                    bool _out1278;
                    bool _out1279;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1280;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1277, out _out1278, out _out1279, out _out1280);
                    _1908_recursiveGen = _out1277;
                    _1909_recOwned = _out1278;
                    _1910_recErased = _out1279;
                    _1911_recIdents = _out1280;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1908_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1909_recOwned;
                    isErased = _1910_recErased;
                    readIdents = _1911_recIdents;
                  }
                } else if (_source66.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1912_recursiveGen;
                    bool _1913_recOwned;
                    bool _1914_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1915_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1281;
                    bool _out1282;
                    bool _out1283;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1284;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1281, out _out1282, out _out1283, out _out1284);
                    _1912_recursiveGen = _out1281;
                    _1913_recOwned = _out1282;
                    _1914_recErased = _out1283;
                    _1915_recIdents = _out1284;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1913_recOwned;
                    isErased = _1914_recErased;
                    readIdents = _1915_recIdents;
                  }
                } else if (_source66.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1916_recursiveGen;
                    bool _1917_recOwned;
                    bool _1918_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1919_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1285;
                    bool _out1286;
                    bool _out1287;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1288;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1285, out _out1286, out _out1287, out _out1288);
                    _1916_recursiveGen = _out1285;
                    _1917_recOwned = _out1286;
                    _1918_recErased = _out1287;
                    _1919_recIdents = _out1288;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1916_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1917_recOwned;
                    isErased = _1918_recErased;
                    readIdents = _1919_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1920_recursiveGen;
                    bool _1921_recOwned;
                    bool _1922_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1923_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1289;
                    bool _out1290;
                    bool _out1291;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1292;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1289, out _out1290, out _out1291, out _out1292);
                    _1920_recursiveGen = _out1289;
                    _1921_recOwned = _out1290;
                    _1922_recErased = _out1291;
                    _1923_recIdents = _out1292;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1920_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1921_recOwned;
                    isErased = _1922_recErased;
                    readIdents = _1923_recIdents;
                  }
                }
              } else if (_source64.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1924___mcc_h882 = _source64.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1925_recursiveGen;
                  bool _1926___v60;
                  bool _1927___v61;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1928_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1293;
                  bool _out1294;
                  bool _out1295;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, true, out _out1293, out _out1294, out _out1295, out _out1296);
                  _1925_recursiveGen = _out1293;
                  _1926___v60 = _out1294;
                  _1927___v61 = _out1295;
                  _1928_recIdents = _out1296;
                  Dafny.ISequence<Dafny.Rune> _1929_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1297;
                  _out1297 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                  _1929_toTpeGen = _out1297;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1929_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1928_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1930___mcc_h884 = _source64.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1931_recursiveGen;
                  bool _1932_recOwned;
                  bool _1933_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1934_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1298;
                  bool _out1299;
                  bool _out1300;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1301;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1298, out _out1299, out _out1300, out _out1301);
                  _1931_recursiveGen = _out1298;
                  _1932_recOwned = _out1299;
                  _1933_recErased = _out1300;
                  _1934_recIdents = _out1301;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1931_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1932_recOwned;
                  isErased = _1933_recErased;
                  readIdents = _1934_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1935___mcc_h886 = _source26.dtor_TypeArg_a0;
              DAST._IType _source67 = _500___mcc_h127;
              if (_source67.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1936___mcc_h890 = _source67.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1937___mcc_h891 = _source67.dtor_typeArgs;
                DAST._IResolvedType _1938___mcc_h892 = _source67.dtor_resolved;
                DAST._IResolvedType _source68 = _1938___mcc_h892;
                if (_source68.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1939___mcc_h896 = _source68.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1940_recursiveGen;
                    bool _1941_recOwned;
                    bool _1942_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1943_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1302;
                    bool _out1303;
                    bool _out1304;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1305;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1302, out _out1303, out _out1304, out _out1305);
                    _1940_recursiveGen = _out1302;
                    _1941_recOwned = _out1303;
                    _1942_recErased = _out1304;
                    _1943_recIdents = _out1305;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1941_recOwned;
                    isErased = _1942_recErased;
                    readIdents = _1943_recIdents;
                  }
                } else if (_source68.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1944___mcc_h898 = _source68.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1945_recursiveGen;
                    bool _1946_recOwned;
                    bool _1947_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1948_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1306;
                    bool _out1307;
                    bool _out1308;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1309;
                    DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1306, out _out1307, out _out1308, out _out1309);
                    _1945_recursiveGen = _out1306;
                    _1946_recOwned = _out1307;
                    _1947_recErased = _out1308;
                    _1948_recIdents = _out1309;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1945_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1946_recOwned;
                    isErased = _1947_recErased;
                    readIdents = _1948_recIdents;
                  }
                } else {
                  DAST._IType _1949___mcc_h900 = _source68.dtor_Newtype_a0;
                  DAST._IType _1950_b = _1949___mcc_h900;
                  {
                    if (object.Equals(_493_fromTpe, _1950_b)) {
                      Dafny.ISequence<Dafny.Rune> _1951_recursiveGen;
                      bool _1952_recOwned;
                      bool _1953_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1954_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1310;
                      bool _out1311;
                      bool _out1312;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
                      DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
                      _1951_recursiveGen = _out1310;
                      _1952_recOwned = _out1311;
                      _1953_recErased = _out1312;
                      _1954_recIdents = _out1313;
                      Dafny.ISequence<Dafny.Rune> _1955_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1314;
                      _out1314 = DCOMP.COMP.GenType(_492_toTpe, true, false);
                      _1955_rhsType = _out1314;
                      Dafny.ISequence<Dafny.Rune> _1956_uneraseFn;
                      _1956_uneraseFn = ((_1952_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1955_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1956_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1951_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1952_recOwned;
                      isErased = false;
                      readIdents = _1954_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1315;
                      bool _out1316;
                      bool _out1317;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1318;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_494_expr, _493_fromTpe, _1950_b), _1950_b, _492_toTpe), selfIdent, @params, mustOwn, out _out1315, out _out1316, out _out1317, out _out1318);
                      s = _out1315;
                      isOwned = _out1316;
                      isErased = _out1317;
                      readIdents = _out1318;
                    }
                  }
                }
              } else if (_source67.is_Nullable) {
                DAST._IType _1957___mcc_h902 = _source67.dtor_Nullable_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1958_recursiveGen;
                  bool _1959_recOwned;
                  bool _1960_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1961_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1319;
                  bool _out1320;
                  bool _out1321;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1322;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1319, out _out1320, out _out1321, out _out1322);
                  _1958_recursiveGen = _out1319;
                  _1959_recOwned = _out1320;
                  _1960_recErased = _out1321;
                  _1961_recIdents = _out1322;
                  if (!(_1959_recOwned)) {
                    _1958_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(_1958_recursiveGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                  }
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Some("), _1958_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = _1960_recErased;
                  readIdents = _1961_recIdents;
                }
              } else if (_source67.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1962___mcc_h904 = _source67.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1963_recursiveGen;
                  bool _1964_recOwned;
                  bool _1965_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1966_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1323;
                  bool _out1324;
                  bool _out1325;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1326;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1323, out _out1324, out _out1325, out _out1326);
                  _1963_recursiveGen = _out1323;
                  _1964_recOwned = _out1324;
                  _1965_recErased = _out1325;
                  _1966_recIdents = _out1326;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1963_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1964_recOwned;
                  isErased = _1965_recErased;
                  readIdents = _1966_recIdents;
                }
              } else if (_source67.is_Array) {
                DAST._IType _1967___mcc_h906 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1968_recursiveGen;
                  bool _1969_recOwned;
                  bool _1970_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1971_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1327;
                  bool _out1328;
                  bool _out1329;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1330;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1327, out _out1328, out _out1329, out _out1330);
                  _1968_recursiveGen = _out1327;
                  _1969_recOwned = _out1328;
                  _1970_recErased = _out1329;
                  _1971_recIdents = _out1330;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1968_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1969_recOwned;
                  isErased = _1970_recErased;
                  readIdents = _1971_recIdents;
                }
              } else if (_source67.is_Seq) {
                DAST._IType _1972___mcc_h908 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1973_recursiveGen;
                  bool _1974_recOwned;
                  bool _1975_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1976_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1331;
                  bool _out1332;
                  bool _out1333;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1334;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1331, out _out1332, out _out1333, out _out1334);
                  _1973_recursiveGen = _out1331;
                  _1974_recOwned = _out1332;
                  _1975_recErased = _out1333;
                  _1976_recIdents = _out1334;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1973_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1974_recOwned;
                  isErased = _1975_recErased;
                  readIdents = _1976_recIdents;
                }
              } else if (_source67.is_Set) {
                DAST._IType _1977___mcc_h910 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1978_recursiveGen;
                  bool _1979_recOwned;
                  bool _1980_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1981_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1335;
                  bool _out1336;
                  bool _out1337;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1338;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1335, out _out1336, out _out1337, out _out1338);
                  _1978_recursiveGen = _out1335;
                  _1979_recOwned = _out1336;
                  _1980_recErased = _out1337;
                  _1981_recIdents = _out1338;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1978_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1979_recOwned;
                  isErased = _1980_recErased;
                  readIdents = _1981_recIdents;
                }
              } else if (_source67.is_Multiset) {
                DAST._IType _1982___mcc_h912 = _source67.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1983_recursiveGen;
                  bool _1984_recOwned;
                  bool _1985_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1986_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1339;
                  bool _out1340;
                  bool _out1341;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1342;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1339, out _out1340, out _out1341, out _out1342);
                  _1983_recursiveGen = _out1339;
                  _1984_recOwned = _out1340;
                  _1985_recErased = _out1341;
                  _1986_recIdents = _out1342;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1983_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1984_recOwned;
                  isErased = _1985_recErased;
                  readIdents = _1986_recIdents;
                }
              } else if (_source67.is_Map) {
                DAST._IType _1987___mcc_h914 = _source67.dtor_key;
                DAST._IType _1988___mcc_h915 = _source67.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1989_recursiveGen;
                  bool _1990_recOwned;
                  bool _1991_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1992_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1343;
                  bool _out1344;
                  bool _out1345;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1346;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1343, out _out1344, out _out1345, out _out1346);
                  _1989_recursiveGen = _out1343;
                  _1990_recOwned = _out1344;
                  _1991_recErased = _out1345;
                  _1992_recIdents = _out1346;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1989_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1990_recOwned;
                  isErased = _1991_recErased;
                  readIdents = _1992_recIdents;
                }
              } else if (_source67.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1993___mcc_h918 = _source67.dtor_args;
                DAST._IType _1994___mcc_h919 = _source67.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1995_recursiveGen;
                  bool _1996_recOwned;
                  bool _1997_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1998_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1347;
                  bool _out1348;
                  bool _out1349;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1350;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1347, out _out1348, out _out1349, out _out1350);
                  _1995_recursiveGen = _out1347;
                  _1996_recOwned = _out1348;
                  _1997_recErased = _out1349;
                  _1998_recIdents = _out1350;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1995_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1996_recOwned;
                  isErased = _1997_recErased;
                  readIdents = _1998_recIdents;
                }
              } else if (_source67.is_Primitive) {
                DAST._IPrimitive _1999___mcc_h922 = _source67.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2000_recursiveGen;
                  bool _2001_recOwned;
                  bool _2002_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2003_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1351;
                  bool _out1352;
                  bool _out1353;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1354;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1351, out _out1352, out _out1353, out _out1354);
                  _2000_recursiveGen = _out1351;
                  _2001_recOwned = _out1352;
                  _2002_recErased = _out1353;
                  _2003_recIdents = _out1354;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2000_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2001_recOwned;
                  isErased = _2002_recErased;
                  readIdents = _2003_recIdents;
                }
              } else if (_source67.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _2004___mcc_h924 = _source67.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2005_recursiveGen;
                  bool _2006_recOwned;
                  bool _2007_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2008_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1355;
                  bool _out1356;
                  bool _out1357;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1358;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1355, out _out1356, out _out1357, out _out1358);
                  _2005_recursiveGen = _out1355;
                  _2006_recOwned = _out1356;
                  _2007_recErased = _out1357;
                  _2008_recIdents = _out1358;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2005_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2006_recOwned;
                  isErased = _2007_recErased;
                  readIdents = _2008_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _2009___mcc_h926 = _source67.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _2010_recursiveGen;
                  bool _2011_recOwned;
                  bool _2012_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2013_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1359;
                  bool _out1360;
                  bool _out1361;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1362;
                  DCOMP.COMP.GenExpr(_494_expr, selfIdent, @params, mustOwn, out _out1359, out _out1360, out _out1361, out _out1362);
                  _2010_recursiveGen = _out1359;
                  _2011_recOwned = _out1360;
                  _2012_recErased = _out1361;
                  _2013_recIdents = _out1362;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2010_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _2011_recOwned;
                  isErased = _2012_recErased;
                  readIdents = _2013_recIdents;
                }
              }
            }
          }
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _2014___mcc_h22 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2015_exprs = _2014___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2016_generatedValues;
          _2016_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2017_i;
          _2017_i = BigInteger.Zero;
          bool _2018_allErased;
          _2018_allErased = true;
          while ((_2017_i) < (new BigInteger((_2015_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2019_recursiveGen;
            bool _2020___v63;
            bool _2021_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2022_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1363;
            bool _out1364;
            bool _out1365;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1366;
            DCOMP.COMP.GenExpr((_2015_exprs).Select(_2017_i), selfIdent, @params, true, out _out1363, out _out1364, out _out1365, out _out1366);
            _2019_recursiveGen = _out1363;
            _2020___v63 = _out1364;
            _2021_isErased = _out1365;
            _2022_recIdents = _out1366;
            _2018_allErased = (_2018_allErased) && (_2021_isErased);
            _2016_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2016_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2019_recursiveGen, _2021_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2022_recIdents);
            _2017_i = (_2017_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2017_i = BigInteger.Zero;
          while ((_2017_i) < (new BigInteger((_2016_generatedValues).Count))) {
            if ((_2017_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2023_gen;
            _2023_gen = ((_2016_generatedValues).Select(_2017_i)).dtor__0;
            if ((((_2016_generatedValues).Select(_2017_i)).dtor__1) && (!(_2018_allErased))) {
              _2023_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2023_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2023_gen);
            _2017_i = (_2017_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _2018_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _2024___mcc_h23 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _2025_exprs = _2024___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _2026_generatedValues;
          _2026_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2027_i;
          _2027_i = BigInteger.Zero;
          bool _2028_allErased;
          _2028_allErased = true;
          while ((_2027_i) < (new BigInteger((_2025_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _2029_recursiveGen;
            bool _2030___v64;
            bool _2031_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2032_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1367;
            bool _out1368;
            bool _out1369;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1370;
            DCOMP.COMP.GenExpr((_2025_exprs).Select(_2027_i), selfIdent, @params, true, out _out1367, out _out1368, out _out1369, out _out1370);
            _2029_recursiveGen = _out1367;
            _2030___v64 = _out1368;
            _2031_isErased = _out1369;
            _2032_recIdents = _out1370;
            _2028_allErased = (_2028_allErased) && (_2031_isErased);
            _2026_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_2026_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_2029_recursiveGen, _2031_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2032_recIdents);
            _2027_i = (_2027_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _2027_i = BigInteger.Zero;
          while ((_2027_i) < (new BigInteger((_2026_generatedValues).Count))) {
            if ((_2027_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2033_gen;
            _2033_gen = ((_2026_generatedValues).Select(_2027_i)).dtor__0;
            if ((((_2026_generatedValues).Select(_2027_i)).dtor__1) && (!(_2028_allErased))) {
              _2033_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _2033_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2033_gen);
            _2027_i = (_2027_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_This) {
        {
          DAST._IOptional<Dafny.ISequence<Dafny.Rune>> _source69 = selfIdent;
          if (_source69.is_Some) {
            Dafny.ISequence<Dafny.Rune> _2034___mcc_h928 = _source69.dtor_Some_a0;
            Dafny.ISequence<Dafny.Rune> _2035_id = _2034___mcc_h928;
            {
              if (mustOwn) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(_2035_id, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
                isOwned = true;
              } else {
                if ((_2035_id).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"))) {
                  s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
                } else {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2035_id);
                }
                isOwned = false;
              }
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2035_id);
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
      } else if (_source19.is_Ite) {
        DAST._IExpression _2036___mcc_h24 = _source19.dtor_cond;
        DAST._IExpression _2037___mcc_h25 = _source19.dtor_thn;
        DAST._IExpression _2038___mcc_h26 = _source19.dtor_els;
        DAST._IExpression _2039_f = _2038___mcc_h26;
        DAST._IExpression _2040_t = _2037___mcc_h25;
        DAST._IExpression _2041_cond = _2036___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _2042_condString;
          bool _2043___v65;
          bool _2044_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2045_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1371;
          bool _out1372;
          bool _out1373;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1374;
          DCOMP.COMP.GenExpr(_2041_cond, selfIdent, @params, true, out _out1371, out _out1372, out _out1373, out _out1374);
          _2042_condString = _out1371;
          _2043___v65 = _out1372;
          _2044_condErased = _out1373;
          _2045_recIdentsCond = _out1374;
          if (!(_2044_condErased)) {
            _2042_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2042_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2046___v66;
          bool _2047_tHasToBeOwned;
          bool _2048___v67;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2049___v68;
          Dafny.ISequence<Dafny.Rune> _out1375;
          bool _out1376;
          bool _out1377;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1378;
          DCOMP.COMP.GenExpr(_2040_t, selfIdent, @params, mustOwn, out _out1375, out _out1376, out _out1377, out _out1378);
          _2046___v66 = _out1375;
          _2047_tHasToBeOwned = _out1376;
          _2048___v67 = _out1377;
          _2049___v68 = _out1378;
          Dafny.ISequence<Dafny.Rune> _2050_fString;
          bool _2051_fOwned;
          bool _2052_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2053_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1379;
          bool _out1380;
          bool _out1381;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1382;
          DCOMP.COMP.GenExpr(_2039_f, selfIdent, @params, _2047_tHasToBeOwned, out _out1379, out _out1380, out _out1381, out _out1382);
          _2050_fString = _out1379;
          _2051_fOwned = _out1380;
          _2052_fErased = _out1381;
          _2053_recIdentsF = _out1382;
          Dafny.ISequence<Dafny.Rune> _2054_tString;
          bool _2055___v69;
          bool _2056_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2057_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1383;
          bool _out1384;
          bool _out1385;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1386;
          DCOMP.COMP.GenExpr(_2040_t, selfIdent, @params, _2051_fOwned, out _out1383, out _out1384, out _out1385, out _out1386);
          _2054_tString = _out1383;
          _2055___v69 = _out1384;
          _2056_tErased = _out1385;
          _2057_recIdentsT = _out1386;
          if ((!(_2052_fErased)) || (!(_2056_tErased))) {
            if (_2052_fErased) {
              _2050_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2050_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_2056_tErased) {
              _2054_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2054_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _2042_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2054_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _2050_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _2051_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2045_recIdentsCond, _2057_recIdentsT), _2053_recIdentsF);
          isErased = (_2052_fErased) || (_2056_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _2058___mcc_h27 = _source19.dtor_unOp;
        DAST._IExpression _2059___mcc_h28 = _source19.dtor_expr;
        DAST._IUnaryOp _source70 = _2058___mcc_h27;
        if (_source70.is_Not) {
          DAST._IExpression _2060_e = _2059___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2061_recursiveGen;
            bool _2062___v70;
            bool _2063_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2064_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1387;
            bool _out1388;
            bool _out1389;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1390;
            DCOMP.COMP.GenExpr(_2060_e, selfIdent, @params, true, out _out1387, out _out1388, out _out1389, out _out1390);
            _2061_recursiveGen = _out1387;
            _2062___v70 = _out1388;
            _2063_recErased = _out1389;
            _2064_recIdents = _out1390;
            if (!(_2063_recErased)) {
              _2061_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _2061_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2064_recIdents;
            isErased = true;
          }
        } else if (_source70.is_BitwiseNot) {
          DAST._IExpression _2065_e = _2059___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2066_recursiveGen;
            bool _2067___v71;
            bool _2068_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2069_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1391;
            bool _out1392;
            bool _out1393;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1394;
            DCOMP.COMP.GenExpr(_2065_e, selfIdent, @params, true, out _out1391, out _out1392, out _out1393, out _out1394);
            _2066_recursiveGen = _out1391;
            _2067___v71 = _out1392;
            _2068_recErased = _out1393;
            _2069_recIdents = _out1394;
            if (!(_2068_recErased)) {
              _2066_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2066_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _2066_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _2069_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _2070_e = _2059___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _2071_recursiveGen;
            bool _2072_recOwned;
            bool _2073_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2074_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1395;
            bool _out1396;
            bool _out1397;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1398;
            DCOMP.COMP.GenExpr(_2070_e, selfIdent, @params, false, out _out1395, out _out1396, out _out1397, out _out1398);
            _2071_recursiveGen = _out1395;
            _2072_recOwned = _out1396;
            _2073_recErased = _out1397;
            _2074_recIdents = _out1398;
            if (!(_2073_recErased)) {
              Dafny.ISequence<Dafny.Rune> _2075_eraseFn;
              _2075_eraseFn = ((_2072_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _2071_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2075_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2071_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _2071_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _2074_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _2076___mcc_h29 = _source19.dtor_op;
        DAST._IExpression _2077___mcc_h30 = _source19.dtor_left;
        DAST._IExpression _2078___mcc_h31 = _source19.dtor_right;
        DAST._IExpression _2079_r = _2078___mcc_h31;
        DAST._IExpression _2080_l = _2077___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _2081_op = _2076___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _2082_left;
          bool _2083___v72;
          bool _2084_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2085_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1399;
          bool _out1400;
          bool _out1401;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1402;
          DCOMP.COMP.GenExpr(_2080_l, selfIdent, @params, true, out _out1399, out _out1400, out _out1401, out _out1402);
          _2082_left = _out1399;
          _2083___v72 = _out1400;
          _2084_leftErased = _out1401;
          _2085_recIdentsL = _out1402;
          Dafny.ISequence<Dafny.Rune> _2086_right;
          bool _2087___v73;
          bool _2088_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2089_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1403;
          bool _out1404;
          bool _out1405;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1406;
          DCOMP.COMP.GenExpr(_2079_r, selfIdent, @params, true, out _out1403, out _out1404, out _out1405, out _out1406);
          _2086_right = _out1403;
          _2087___v73 = _out1404;
          _2088_rightErased = _out1405;
          _2089_recIdentsR = _out1406;
          if (!(_2084_leftErased)) {
            _2082_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2082_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_2088_rightErased)) {
            _2086_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2086_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2081_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _2082_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2086_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_2081_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _2082_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _2086_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2082_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2081_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _2086_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2085_recIdentsL, _2089_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _2090___mcc_h32 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2091___mcc_h33 = _source19.dtor_field;
        bool _2092___mcc_h34 = _source19.dtor_isConstant;
        bool _2093___mcc_h35 = _source19.dtor_onDatatype;
        bool _2094_isDatatype = _2093___mcc_h35;
        bool _2095_isConstant = _2092___mcc_h34;
        Dafny.ISequence<Dafny.Rune> _2096_field = _2091___mcc_h33;
        DAST._IExpression _2097_on = _2090___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _2098_onString;
          bool _2099_onOwned;
          bool _2100_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2101_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1407;
          bool _out1408;
          bool _out1409;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1410;
          DCOMP.COMP.GenExpr(_2097_on, selfIdent, @params, false, out _out1407, out _out1408, out _out1409, out _out1410);
          _2098_onString = _out1407;
          _2099_onOwned = _out1408;
          _2100_onErased = _out1409;
          _2101_recIdents = _out1410;
          if (!(_2100_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2102_eraseFn;
            _2102_eraseFn = ((_2099_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2098_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2102_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2098_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_2094_isDatatype) || (_2095_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2098_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2096_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_2095_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _2098_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _2096_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _2101_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _2103___mcc_h36 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _2104___mcc_h37 = _source19.dtor_field;
        bool _2105___mcc_h38 = _source19.dtor_onDatatype;
        bool _2106___mcc_h39 = _source19.dtor_isStatic;
        BigInteger _2107___mcc_h40 = _source19.dtor_arity;
        BigInteger _2108_arity = _2107___mcc_h40;
        bool _2109_isStatic = _2106___mcc_h39;
        bool _2110_isDatatype = _2105___mcc_h38;
        Dafny.ISequence<Dafny.Rune> _2111_field = _2104___mcc_h37;
        DAST._IExpression _2112_on = _2103___mcc_h36;
        {
          Dafny.ISequence<Dafny.Rune> _2113_onString;
          bool _2114_onOwned;
          bool _2115___v74;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2116_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1411;
          bool _out1412;
          bool _out1413;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1414;
          DCOMP.COMP.GenExpr(_2112_on, selfIdent, @params, false, out _out1411, out _out1412, out _out1413, out _out1414);
          _2113_onString = _out1411;
          _2114_onOwned = _out1412;
          _2115___v74 = _out1413;
          _2116_recIdents = _out1414;
          if (_2109_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2113_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _2111_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _2113_onString), ((_2114_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _2117_args;
            _2117_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _2118_i;
            _2118_i = BigInteger.Zero;
            while ((_2118_i) < (_2108_arity)) {
              if ((_2118_i).Sign == 1) {
                _2117_args = Dafny.Sequence<Dafny.Rune>.Concat(_2117_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _2117_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2117_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_2118_i));
              _2118_i = (_2118_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _2117_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _2111_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2117_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _2116_recIdents;
        }
      } else if (_source19.is_Index) {
        DAST._IExpression _2119___mcc_h41 = _source19.dtor_expr;
        DAST._IExpression _2120___mcc_h42 = _source19.dtor_idx;
        DAST._IExpression _2121_idx = _2120___mcc_h42;
        DAST._IExpression _2122_on = _2119___mcc_h41;
        {
          Dafny.ISequence<Dafny.Rune> _2123_onString;
          bool _2124_onOwned;
          bool _2125_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2126_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1415;
          bool _out1416;
          bool _out1417;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1418;
          DCOMP.COMP.GenExpr(_2122_on, selfIdent, @params, false, out _out1415, out _out1416, out _out1417, out _out1418);
          _2123_onString = _out1415;
          _2124_onOwned = _out1416;
          _2125_onErased = _out1417;
          _2126_recIdents = _out1418;
          if (!(_2125_onErased)) {
            Dafny.ISequence<Dafny.Rune> _2127_eraseFn;
            _2127_eraseFn = ((_2124_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _2123_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _2127_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2123_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _2128_idxString;
          bool _2129___v75;
          bool _2130_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2131_recIdentsIdx;
          Dafny.ISequence<Dafny.Rune> _out1419;
          bool _out1420;
          bool _out1421;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1422;
          DCOMP.COMP.GenExpr(_2121_idx, selfIdent, @params, true, out _out1419, out _out1420, out _out1421, out _out1422);
          _2128_idxString = _out1419;
          _2129___v75 = _out1420;
          _2130_idxErased = _out1421;
          _2131_recIdentsIdx = _out1422;
          if (!(_2130_idxErased)) {
            _2128_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _2128_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2123_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _2128_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = false;
          }
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_2126_recIdents, _2131_recIdentsIdx);
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _2132___mcc_h43 = _source19.dtor_expr;
        BigInteger _2133___mcc_h44 = _source19.dtor_index;
        BigInteger _2134_idx = _2133___mcc_h44;
        DAST._IExpression _2135_on = _2132___mcc_h43;
        {
          Dafny.ISequence<Dafny.Rune> _2136_onString;
          bool _2137___v76;
          bool _2138_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2139_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1423;
          bool _out1424;
          bool _out1425;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1426;
          DCOMP.COMP.GenExpr(_2135_on, selfIdent, @params, false, out _out1423, out _out1424, out _out1425, out _out1426);
          _2136_onString = _out1423;
          _2137___v76 = _out1424;
          _2138_tupErased = _out1425;
          _2139_recIdents = _out1426;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2136_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_2134_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _2138_tupErased;
          readIdents = _2139_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _2140___mcc_h45 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _2141___mcc_h46 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _2142___mcc_h47 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _2143___mcc_h48 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2144_args = _2143___mcc_h48;
        Dafny.ISequence<DAST._IType> _2145_typeArgs = _2142___mcc_h47;
        Dafny.ISequence<Dafny.Rune> _2146_name = _2141___mcc_h46;
        DAST._IExpression _2147_on = _2140___mcc_h45;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2148_typeArgString;
          _2148_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_2145_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _2149_typeI;
            _2149_typeI = BigInteger.Zero;
            _2148_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_2149_typeI) < (new BigInteger((_2145_typeArgs).Count))) {
              if ((_2149_typeI).Sign == 1) {
                _2148_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2148_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _2150_typeString;
              Dafny.ISequence<Dafny.Rune> _out1427;
              _out1427 = DCOMP.COMP.GenType((_2145_typeArgs).Select(_2149_typeI), false, false);
              _2150_typeString = _out1427;
              _2148_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2148_typeArgString, _2150_typeString);
              _2149_typeI = (_2149_typeI) + (BigInteger.One);
            }
            _2148_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_2148_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _2151_argString;
          _2151_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2152_i;
          _2152_i = BigInteger.Zero;
          while ((_2152_i) < (new BigInteger((_2144_args).Count))) {
            if ((_2152_i).Sign == 1) {
              _2151_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2151_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2153_argExpr;
            bool _2154_isOwned;
            bool _2155_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2156_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1428;
            bool _out1429;
            bool _out1430;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1431;
            DCOMP.COMP.GenExpr((_2144_args).Select(_2152_i), selfIdent, @params, false, out _out1428, out _out1429, out _out1430, out _out1431);
            _2153_argExpr = _out1428;
            _2154_isOwned = _out1429;
            _2155_argErased = _out1430;
            _2156_argIdents = _out1431;
            if (_2154_isOwned) {
              _2153_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2153_argExpr);
            }
            _2151_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2151_argString, _2153_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2156_argIdents);
            _2152_i = (_2152_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2157_enclosingString;
          bool _2158___v77;
          bool _2159___v78;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2160_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1432;
          bool _out1433;
          bool _out1434;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1435;
          DCOMP.COMP.GenExpr(_2147_on, selfIdent, @params, false, out _out1432, out _out1433, out _out1434, out _out1435);
          _2157_enclosingString = _out1432;
          _2158___v77 = _out1433;
          _2159___v78 = _out1434;
          _2160_recIdents = _out1435;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2160_recIdents);
          DAST._IExpression _source71 = _2147_on;
          if (_source71.is_Literal) {
            DAST._ILiteral _2161___mcc_h929 = _source71.dtor_Literal_a0;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _2162___mcc_h931 = _source71.dtor_Ident_a0;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2163___mcc_h933 = _source71.dtor_Companion_a0;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_2157_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source71.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _2164___mcc_h935 = _source71.dtor_Tuple_a0;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2165___mcc_h937 = _source71.dtor_path;
            Dafny.ISequence<DAST._IExpression> _2166___mcc_h938 = _source71.dtor_args;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _2167___mcc_h941 = _source71.dtor_dims;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2168___mcc_h943 = _source71.dtor_path;
            Dafny.ISequence<Dafny.Rune> _2169___mcc_h944 = _source71.dtor_variant;
            bool _2170___mcc_h945 = _source71.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _2171___mcc_h946 = _source71.dtor_contents;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Convert) {
            DAST._IExpression _2172___mcc_h951 = _source71.dtor_value;
            DAST._IType _2173___mcc_h952 = _source71.dtor_from;
            DAST._IType _2174___mcc_h953 = _source71.dtor_typ;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2175___mcc_h957 = _source71.dtor_elements;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2176___mcc_h959 = _source71.dtor_elements;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_This) {
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Ite) {
            DAST._IExpression _2177___mcc_h961 = _source71.dtor_cond;
            DAST._IExpression _2178___mcc_h962 = _source71.dtor_thn;
            DAST._IExpression _2179___mcc_h963 = _source71.dtor_els;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_UnOp) {
            DAST._IUnaryOp _2180___mcc_h967 = _source71.dtor_unOp;
            DAST._IExpression _2181___mcc_h968 = _source71.dtor_expr;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2182___mcc_h971 = _source71.dtor_op;
            DAST._IExpression _2183___mcc_h972 = _source71.dtor_left;
            DAST._IExpression _2184___mcc_h973 = _source71.dtor_right;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Select) {
            DAST._IExpression _2185___mcc_h977 = _source71.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2186___mcc_h978 = _source71.dtor_field;
            bool _2187___mcc_h979 = _source71.dtor_isConstant;
            bool _2188___mcc_h980 = _source71.dtor_onDatatype;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_SelectFn) {
            DAST._IExpression _2189___mcc_h985 = _source71.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2190___mcc_h986 = _source71.dtor_field;
            bool _2191___mcc_h987 = _source71.dtor_onDatatype;
            bool _2192___mcc_h988 = _source71.dtor_isStatic;
            BigInteger _2193___mcc_h989 = _source71.dtor_arity;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Index) {
            DAST._IExpression _2194___mcc_h995 = _source71.dtor_expr;
            DAST._IExpression _2195___mcc_h996 = _source71.dtor_idx;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_TupleSelect) {
            DAST._IExpression _2196___mcc_h999 = _source71.dtor_expr;
            BigInteger _2197___mcc_h1000 = _source71.dtor_index;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Call) {
            DAST._IExpression _2198___mcc_h1003 = _source71.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2199___mcc_h1004 = _source71.dtor_name;
            Dafny.ISequence<DAST._IType> _2200___mcc_h1005 = _source71.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2201___mcc_h1006 = _source71.dtor_args;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2202___mcc_h1011 = _source71.dtor_params;
            DAST._IType _2203___mcc_h1012 = _source71.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2204___mcc_h1013 = _source71.dtor_body;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2205___mcc_h1017 = _source71.dtor_name;
            DAST._IType _2206___mcc_h1018 = _source71.dtor_typ;
            DAST._IExpression _2207___mcc_h1019 = _source71.dtor_value;
            DAST._IExpression _2208___mcc_h1020 = _source71.dtor_iifeBody;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_Apply) {
            DAST._IExpression _2209___mcc_h1025 = _source71.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2210___mcc_h1026 = _source71.dtor_args;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source71.is_TypeTest) {
            DAST._IExpression _2211___mcc_h1029 = _source71.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2212___mcc_h1030 = _source71.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2213___mcc_h1031 = _source71.dtor_variant;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2214___mcc_h1035 = _source71.dtor_typ;
            {
              _2157_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _2157_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2157_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_2146_name)), _2148_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2151_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2215___mcc_h49 = _source19.dtor_params;
        DAST._IType _2216___mcc_h50 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2217___mcc_h51 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2218_body = _2217___mcc_h51;
        DAST._IType _2219_retType = _2216___mcc_h50;
        Dafny.ISequence<DAST._IFormal> _2220_params = _2215___mcc_h49;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2221_paramNames;
          _2221_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2222_i;
          _2222_i = BigInteger.Zero;
          while ((_2222_i) < (new BigInteger((_2220_params).Count))) {
            _2221_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2221_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2220_params).Select(_2222_i)).dtor_name));
            _2222_i = (_2222_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2223_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2224_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1436;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1437;
          DCOMP.COMP.GenStmts(_2218_body, DAST.Optional<Dafny.ISequence<Dafny.Rune>>.create_None(), _2221_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1436, out _out1437);
          _2223_recursiveGen = _out1436;
          _2224_recIdents = _out1437;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2225_allReadCloned;
          _2225_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2224_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2226_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2224_recIdents).Elements) {
              _2226_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2224_recIdents).Contains(_2226_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1623)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2221_paramNames).Contains(_2226_next))) {
              _2225_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2225_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2226_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2226_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2226_next));
            }
            _2224_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2224_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2226_next));
          }
          Dafny.ISequence<Dafny.Rune> _2227_paramsString;
          _2227_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2222_i = BigInteger.Zero;
          while ((_2222_i) < (new BigInteger((_2220_params).Count))) {
            if ((_2222_i).Sign == 1) {
              _2227_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2227_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2228_typStr;
            Dafny.ISequence<Dafny.Rune> _out1438;
            _out1438 = DCOMP.COMP.GenType(((_2220_params).Select(_2222_i)).dtor_typ, false, true);
            _2228_typStr = _out1438;
            _2227_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2227_paramsString, ((_2220_params).Select(_2222_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2228_typStr);
            _2222_i = (_2222_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2229_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1439;
          _out1439 = DCOMP.COMP.GenType(_2219_retType, false, true);
          _2229_retTypeGen = _out1439;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2225_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2227_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2229_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2223_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2230___mcc_h52 = _source19.dtor_name;
        DAST._IType _2231___mcc_h53 = _source19.dtor_typ;
        DAST._IExpression _2232___mcc_h54 = _source19.dtor_value;
        DAST._IExpression _2233___mcc_h55 = _source19.dtor_iifeBody;
        DAST._IExpression _2234_iifeBody = _2233___mcc_h55;
        DAST._IExpression _2235_value = _2232___mcc_h54;
        DAST._IType _2236_tpe = _2231___mcc_h53;
        Dafny.ISequence<Dafny.Rune> _2237_name = _2230___mcc_h52;
        {
          Dafny.ISequence<Dafny.Rune> _2238_valueGen;
          bool _2239_valueOwned;
          bool _2240_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2241_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1440;
          bool _out1441;
          bool _out1442;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1443;
          DCOMP.COMP.GenExpr(_2235_value, selfIdent, @params, false, out _out1440, out _out1441, out _out1442, out _out1443);
          _2238_valueGen = _out1440;
          _2239_valueOwned = _out1441;
          _2240_valueErased = _out1442;
          _2241_recIdents = _out1443;
          if (_2240_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2242_eraseFn;
            _2242_eraseFn = ((_2239_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2238_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2242_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2238_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2241_recIdents;
          Dafny.ISequence<Dafny.Rune> _2243_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1444;
          _out1444 = DCOMP.COMP.GenType(_2236_tpe, false, true);
          _2243_valueTypeGen = _out1444;
          Dafny.ISequence<Dafny.Rune> _2244_bodyGen;
          bool _2245_bodyOwned;
          bool _2246_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2247_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1445;
          bool _out1446;
          bool _out1447;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1448;
          DCOMP.COMP.GenExpr(_2234_iifeBody, selfIdent, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2239_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2237_name))))), mustOwn, out _out1445, out _out1446, out _out1447, out _out1448);
          _2244_bodyGen = _out1445;
          _2245_bodyOwned = _out1446;
          _2246_bodyErased = _out1447;
          _2247_bodyIdents = _out1448;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2247_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2248_eraseFn;
          _2248_eraseFn = ((_2239_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2237_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2239_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2243_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2238_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2244_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2245_bodyOwned;
          isErased = _2246_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _2249___mcc_h56 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2250___mcc_h57 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2251_args = _2250___mcc_h57;
        DAST._IExpression _2252_func = _2249___mcc_h56;
        {
          Dafny.ISequence<Dafny.Rune> _2253_funcString;
          bool _2254___v81;
          bool _2255_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2256_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1449;
          bool _out1450;
          bool _out1451;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1452;
          DCOMP.COMP.GenExpr(_2252_func, selfIdent, @params, false, out _out1449, out _out1450, out _out1451, out _out1452);
          _2253_funcString = _out1449;
          _2254___v81 = _out1450;
          _2255_funcErased = _out1451;
          _2256_recIdents = _out1452;
          readIdents = _2256_recIdents;
          Dafny.ISequence<Dafny.Rune> _2257_argString;
          _2257_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2258_i;
          _2258_i = BigInteger.Zero;
          while ((_2258_i) < (new BigInteger((_2251_args).Count))) {
            if ((_2258_i).Sign == 1) {
              _2257_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2257_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2259_argExpr;
            bool _2260_isOwned;
            bool _2261_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2262_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1453;
            bool _out1454;
            bool _out1455;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1456;
            DCOMP.COMP.GenExpr((_2251_args).Select(_2258_i), selfIdent, @params, false, out _out1453, out _out1454, out _out1455, out _out1456);
            _2259_argExpr = _out1453;
            _2260_isOwned = _out1454;
            _2261_argErased = _out1455;
            _2262_argIdents = _out1456;
            if (_2260_isOwned) {
              _2259_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2259_argExpr);
            }
            _2257_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2257_argString, _2259_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2262_argIdents);
            _2258_i = (_2258_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2253_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2257_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _2263___mcc_h58 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2264___mcc_h59 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2265___mcc_h60 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2266_variant = _2265___mcc_h60;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2267_dType = _2264___mcc_h59;
        DAST._IExpression _2268_on = _2263___mcc_h58;
        {
          Dafny.ISequence<Dafny.Rune> _2269_exprGen;
          bool _2270___v82;
          bool _2271_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2272_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1457;
          bool _out1458;
          bool _out1459;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1460;
          DCOMP.COMP.GenExpr(_2268_on, selfIdent, @params, false, out _out1457, out _out1458, out _out1459, out _out1460);
          _2269_exprGen = _out1457;
          _2270___v82 = _out1458;
          _2271_exprErased = _out1459;
          _2272_recIdents = _out1460;
          Dafny.ISequence<Dafny.Rune> _2273_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1461;
          _out1461 = DCOMP.COMP.GenPath(_2267_dType);
          _2273_dTypePath = _out1461;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2269_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2273_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2266_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2272_recIdents;
        }
      } else {
        DAST._IType _2274___mcc_h61 = _source19.dtor_typ;
        DAST._IType _2275_typ = _2274___mcc_h61;
        {
          Dafny.ISequence<Dafny.Rune> _2276_typString;
          Dafny.ISequence<Dafny.Rune> _out1462;
          _out1462 = DCOMP.COMP.GenType(_2275_typ, false, false);
          _2276_typString = _out1462;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2276_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
          isOwned = true;
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      }
    }
    public static Dafny.ISequence<Dafny.Rune> Compile(Dafny.ISequence<DAST._IModule> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#![allow(warnings, unconditional_panic)]\n");
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("extern crate dafny_runtime;\n"));
      BigInteger _2277_i;
      _2277_i = BigInteger.Zero;
      while ((_2277_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2278_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1463;
        _out1463 = DCOMP.COMP.GenModule((p).Select(_2277_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2278_generated = _out1463;
        if ((_2277_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2278_generated);
        _2277_i = (_2277_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2279_i;
      _2279_i = BigInteger.Zero;
      while ((_2279_i) < (new BigInteger((fullName).Count))) {
        if ((_2279_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2279_i));
        _2279_i = (_2279_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

