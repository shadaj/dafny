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
    Dafny.ISequence<DAST._IType> dtor_typeParams { get; }
    Dafny.ISequence<DAST._IType> dtor_superClasses { get; }
    Dafny.ISequence<DAST._IField> dtor_fields { get; }
    Dafny.ISequence<DAST._IMethod> dtor_body { get; }
    _IClass DowncastClone();
  }
  public class Class : _IClass {
    public readonly Dafny.ISequence<Dafny.Rune> _name;
    public readonly Dafny.ISequence<DAST._IType> _typeParams;
    public readonly Dafny.ISequence<DAST._IType> _superClasses;
    public readonly Dafny.ISequence<DAST._IField> _fields;
    public readonly Dafny.ISequence<DAST._IMethod> _body;
    public Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body) {
      this._name = name;
      this._typeParams = typeParams;
      this._superClasses = superClasses;
      this._fields = fields;
      this._body = body;
    }
    public _IClass DowncastClone() {
      if (this is _IClass dt) { return dt; }
      return new Class(_name, _typeParams, _superClasses, _fields, _body);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Class;
      return oth != null && object.Equals(this._name, oth._name) && object.Equals(this._typeParams, oth._typeParams) && object.Equals(this._superClasses, oth._superClasses) && object.Equals(this._fields, oth._fields) && object.Equals(this._body, oth._body);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 0;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._name));
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
    private static readonly DAST._IClass theDefault = create(Dafny.Sequence<Dafny.Rune>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IType>.Empty, Dafny.Sequence<DAST._IField>.Empty, Dafny.Sequence<DAST._IMethod>.Empty);
    public static DAST._IClass Default() {
      return theDefault;
    }
    private static readonly Dafny.TypeDescriptor<DAST._IClass> _TYPE = new Dafny.TypeDescriptor<DAST._IClass>(DAST.Class.Default());
    public static Dafny.TypeDescriptor<DAST._IClass> _TypeDescriptor() {
      return _TYPE;
    }
    public static _IClass create(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body) {
      return new Class(name, typeParams, superClasses, fields, body);
    }
    public static _IClass create_Class(Dafny.ISequence<Dafny.Rune> name, Dafny.ISequence<DAST._IType> typeParams, Dafny.ISequence<DAST._IType> superClasses, Dafny.ISequence<DAST._IField> fields, Dafny.ISequence<DAST._IMethod> body) {
      return create(name, typeParams, superClasses, fields, body);
    }
    public bool is_Class { get { return true; } }
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

  public interface _IAssignLhs {
    bool is_Ident { get; }
    bool is_Select { get; }
    Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 { get; }
    DAST._IExpression dtor_expr { get; }
    Dafny.ISequence<Dafny.Rune> dtor_field { get; }
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
    public bool is_Ident { get { return this is AssignLhs_Ident; } }
    public bool is_Select { get { return this is AssignLhs_Select; } }
    public Dafny.ISequence<Dafny.Rune> dtor_Ident_a0 {
      get {
        var d = this;
        return ((AssignLhs_Ident)d)._a0;
      }
    }
    public DAST._IExpression dtor_expr {
      get {
        var d = this;
        return ((AssignLhs_Select)d)._expr;
      }
    }
    public Dafny.ISequence<Dafny.Rune> dtor_field {
      get {
        var d = this;
        return ((AssignLhs_Select)d)._field;
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

  public interface _IExpression {
    bool is_Literal { get; }
    bool is_Ident { get; }
    bool is_Companion { get; }
    bool is_Tuple { get; }
    bool is_New { get; }
    bool is_NewArray { get; }
    bool is_DatatypeValue { get; }
    bool is_Convert { get; }
    bool is_SubsetDowngrade { get; }
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
    public static _IExpression create_SubsetDowngrade(DAST._IExpression @value) {
      return new Expression_SubsetDowngrade(@value);
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
    public bool is_SubsetDowngrade { get { return this is Expression_SubsetDowngrade; } }
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
        if (d is Expression_SubsetDowngrade) { return ((Expression_SubsetDowngrade)d)._value; }
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
  public class Expression_SubsetDowngrade : Expression {
    public readonly DAST._IExpression _value;
    public Expression_SubsetDowngrade(DAST._IExpression @value) : base() {
      this._value = @value;
    }
    public override _IExpression DowncastClone() {
      if (this is _IExpression dt) { return dt; }
      return new Expression_SubsetDowngrade(_value);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Expression_SubsetDowngrade;
      return oth != null && object.Equals(this._value, oth._value);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 8;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._value));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Expression.SubsetDowngrade";
      s += "(";
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
      hash = ((hash << 5) + hash) + 15;
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
      hash = ((hash << 5) + hash) + 16;
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
            DCOMP.COMP.GenExpr(_25_e, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out11, out _out12, out _out13, out _out14);
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
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Default)]\npub struct r#"), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _19_fields), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _30_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _31_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out15;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out16;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(path)), Dafny.Set<DAST._IType>.FromElements(), out _out15, out _out16);
      _30_implBody = _out15;
      _31_traitBodies = _out16;
      _30_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn new() -> Self {\n"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _20_fieldInits), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n")), _30_implBody);
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _30_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      if ((new BigInteger(((c).dtor_superClasses).Count)).Sign == 1) {
        BigInteger _32_i;
        _32_i = BigInteger.Zero;
        while ((_32_i) < (new BigInteger(((c).dtor_superClasses).Count))) {
          DAST._IType _33_superClass;
          _33_superClass = ((c).dtor_superClasses).Select(_32_i);
          DAST._IType _source2 = _33_superClass;
          if (_source2.is_Path) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _34___mcc_h1 = _source2.dtor_Path_a0;
            Dafny.ISequence<DAST._IType> _35___mcc_h2 = _source2.dtor_typeArgs;
            DAST._IResolvedType _36___mcc_h3 = _source2.dtor_resolved;
            DAST._IResolvedType _source3 = _36___mcc_h3;
            if (_source3.is_Datatype) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _37___mcc_h7 = _source3.dtor_path;
            } else if (_source3.is_Trait) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _38___mcc_h9 = _source3.dtor_path;
              Dafny.ISequence<DAST._IType> _39_typeArgs = _35___mcc_h2;
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _40_traitPath = _34___mcc_h1;
              {
                Dafny.ISequence<Dafny.Rune> _41_pathStr;
                Dafny.ISequence<Dafny.Rune> _out17;
                _out17 = DCOMP.COMP.GenPath(_40_traitPath);
                _41_pathStr = _out17;
                Dafny.ISequence<Dafny.Rune> _42_typeArgs;
                Dafny.ISequence<Dafny.Rune> _out18;
                _out18 = DCOMP.COMP.GenTypeArgs(_39_typeArgs, false, false);
                _42_typeArgs = _out18;
                Dafny.ISequence<Dafny.Rune> _43_body;
                _43_body = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
                if ((_31_traitBodies).Contains(_40_traitPath)) {
                  _43_body = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(_31_traitBodies, _40_traitPath);
                }
                Dafny.ISequence<Dafny.Rune> _44_genSelfPath;
                Dafny.ISequence<Dafny.Rune> _out19;
                _out19 = DCOMP.COMP.GenPath(path);
                _44_genSelfPath = _out19;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nimpl ")), _41_pathStr), _42_typeArgs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" for ::std::rc::Rc<")), _44_genSelfPath), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> {\n")), _43_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
              }
            } else {
            }
          } else if (_source2.is_Tuple) {
            Dafny.ISequence<DAST._IType> _45___mcc_h11 = _source2.dtor_Tuple_a0;
          } else if (_source2.is_Array) {
            DAST._IType _46___mcc_h13 = _source2.dtor_element;
          } else if (_source2.is_Seq) {
            DAST._IType _47___mcc_h15 = _source2.dtor_element;
          } else if (_source2.is_Set) {
            DAST._IType _48___mcc_h17 = _source2.dtor_element;
          } else if (_source2.is_Multiset) {
            DAST._IType _49___mcc_h19 = _source2.dtor_element;
          } else if (_source2.is_Map) {
            DAST._IType _50___mcc_h21 = _source2.dtor_key;
            DAST._IType _51___mcc_h22 = _source2.dtor_value;
          } else if (_source2.is_Arrow) {
            Dafny.ISequence<DAST._IType> _52___mcc_h25 = _source2.dtor_args;
            DAST._IType _53___mcc_h26 = _source2.dtor_result;
          } else if (_source2.is_Primitive) {
            DAST._IPrimitive _54___mcc_h29 = _source2.dtor_Primitive_a0;
          } else if (_source2.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _55___mcc_h31 = _source2.dtor_Passthrough_a0;
          } else {
            Dafny.ISequence<Dafny.Rune> _56___mcc_h33 = _source2.dtor_TypeArg_a0;
          }
          _32_i = (_32_i) + (BigInteger.One);
        }
      }
      Dafny.ISequence<Dafny.Rune> _57_printImpl;
      _57_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n"));
      _57_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_57_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), (((new BigInteger(((c).dtor_fields).Count)).Sign == 1) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"));
      BigInteger _58_i;
      _58_i = BigInteger.Zero;
      while ((_58_i) < (new BigInteger(((c).dtor_fields).Count))) {
        DAST._IField _59_field;
        _59_field = ((c).dtor_fields).Select(_58_i);
        if ((_58_i).Sign == 1) {
          _57_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_57_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
        }
        _57_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_57_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(::std::ops::Deref::deref(&(self.r#")), ((_59_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow())), __fmt_print_formatter, false)?;"));
        _58_i = (_58_i) + (BigInteger.One);
      }
      _57_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_57_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;\nOk(())\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _60_ptrPartialEqImpl;
      _60_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _60_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _60_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _60_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _57_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _60_ptrPartialEqImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTrait(DAST._ITrait t, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> containingPath) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _61_typeParamsSet;
      _61_typeParamsSet = Dafny.Set<DAST._IType>.FromElements();
      Dafny.ISequence<Dafny.Rune> _62_typeParams;
      _62_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _63_tpI;
      _63_tpI = BigInteger.Zero;
      if ((new BigInteger(((t).dtor_typeParams).Count)).Sign == 1) {
        _62_typeParams = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<");
        while ((_63_tpI) < (new BigInteger(((t).dtor_typeParams).Count))) {
          DAST._IType _64_tp;
          _64_tp = ((t).dtor_typeParams).Select(_63_tpI);
          _61_typeParamsSet = Dafny.Set<DAST._IType>.Union(_61_typeParamsSet, Dafny.Set<DAST._IType>.FromElements(_64_tp));
          Dafny.ISequence<Dafny.Rune> _65_genTp;
          Dafny.ISequence<Dafny.Rune> _out20;
          _out20 = DCOMP.COMP.GenType(_64_tp, false, false);
          _65_genTp = _out20;
          _62_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_62_typeParams, _65_genTp), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          _63_tpI = (_63_tpI) + (BigInteger.One);
        }
        _62_typeParams = Dafny.Sequence<Dafny.Rune>.Concat(_62_typeParams, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _66_fullPath;
      _66_fullPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(containingPath, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((t).dtor_name));
      Dafny.ISequence<Dafny.Rune> _67_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _68___v6;
      Dafny.ISequence<Dafny.Rune> _out21;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out22;
      DCOMP.COMP.GenClassImplBody((t).dtor_body, true, DAST.Type.create_Path(_66_fullPath, Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Trait(_66_fullPath)), _61_typeParamsSet, out _out21, out _out22);
      _67_implBody = _out21;
      _68___v6 = _out22;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub trait r#"), (t).dtor_name), _62_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _67_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenNewtype(DAST._INewtype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _69_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _70_typeParams;
      Dafny.ISequence<Dafny.Rune> _71_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out23;
      Dafny.ISequence<Dafny.Rune> _out24;
      Dafny.ISequence<Dafny.Rune> _out25;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out23, out _out24, out _out25);
      _69_typeParamsSet = _out23;
      _70_typeParams = _out24;
      _71_constrainedTypeParams = _out25;
      Dafny.ISequence<Dafny.Rune> _72_underlyingType;
      Dafny.ISequence<Dafny.Rune> _out26;
      _out26 = DCOMP.COMP.GenType((c).dtor_base, false, false);
      _72_underlyingType = _out26;
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(Clone, PartialEq)]\n#[repr(transparent)]\npub struct r#"), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(pub ")), _72_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _71_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = ")), _72_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase(&self) -> &Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn erase_owned(self) -> Self::Erased {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.0\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _71_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<")), _72_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &")), _72_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unsafe { &*(x as *const ")), _72_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as *const r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") }\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: ")), _72_underlyingType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(x)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _71_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase(x: &r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> &Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[inline]\nfn unerase_owned(x: r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> Self {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("x\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _71_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      DAST._IOptional<DAST._IExpression> _source4 = (c).dtor_witnessExpr;
      if (_source4.is_Some) {
        DAST._IExpression _73___mcc_h0 = _source4.dtor_Some_a0;
        DAST._IExpression _74_e = _73___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _75_eStr;
          bool _76___v7;
          bool _77___v8;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _78___v9;
          Dafny.ISequence<Dafny.Rune> _out27;
          bool _out28;
          bool _out29;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out30;
          DCOMP.COMP.GenExpr(_74_e, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out27, out _out28, out _out29, out _out30);
          _75_eStr = _out27;
          _76___v7 = _out28;
          _77___v8 = _out29;
          _78___v9 = _out30;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _75_eStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
        }
      } else {
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(::std::default::Default::default())\n"));
        }
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _71_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _70_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, in_seq: bool) -> ::std::fmt::Result {\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyPrint::fmt_print(&self.0, __fmt_print_formatter, in_seq)\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenDatatype(DAST._IDatatype c) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISet<DAST._IType> _79_typeParamsSet;
      Dafny.ISequence<Dafny.Rune> _80_typeParams;
      Dafny.ISequence<Dafny.Rune> _81_constrainedTypeParams;
      Dafny.ISet<DAST._IType> _out31;
      Dafny.ISequence<Dafny.Rune> _out32;
      Dafny.ISequence<Dafny.Rune> _out33;
      DCOMP.COMP.GenTypeParameters((c).dtor_typeParams, out _out31, out _out32, out _out33);
      _79_typeParamsSet = _out31;
      _80_typeParams = _out32;
      _81_constrainedTypeParams = _out33;
      Dafny.ISequence<Dafny.Rune> _82_ctors;
      _82_ctors = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _83_i;
      _83_i = BigInteger.Zero;
      while ((_83_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _84_ctor;
        _84_ctor = ((c).dtor_ctors).Select(_83_i);
        Dafny.ISequence<Dafny.Rune> _85_ctorBody;
        _85_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_84_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        BigInteger _86_j;
        _86_j = BigInteger.Zero;
        while ((_86_j) < (new BigInteger(((_84_ctor).dtor_args).Count))) {
          DAST._IFormal _87_formal;
          _87_formal = ((_84_ctor).dtor_args).Select(_86_j);
          Dafny.ISequence<Dafny.Rune> _88_formalType;
          Dafny.ISequence<Dafny.Rune> _out34;
          _out34 = DCOMP.COMP.GenType((_87_formal).dtor_typ, false, false);
          _88_formalType = _out34;
          if ((c).dtor_isCo) {
            _85_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_85_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_87_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper<")), _88_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">, "));
          } else {
            _85_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_85_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_87_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _88_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          _86_j = (_86_j) + (BigInteger.One);
        }
        _85_ctorBody = Dafny.Sequence<Dafny.Rune>.Concat(_85_ctorBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        _82_ctors = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_82_ctors, _85_ctorBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
        _83_i = (_83_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _89_selfPath;
      _89_selfPath = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((c).dtor_name);
      Dafny.ISequence<Dafny.Rune> _90_implBody;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _91_traitBodies;
      Dafny.ISequence<Dafny.Rune> _out35;
      Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> _out36;
      DCOMP.COMP.GenClassImplBody((c).dtor_body, false, DAST.Type.create_Path(Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), Dafny.Sequence<DAST._IType>.FromElements(), DAST.ResolvedType.create_Datatype(_89_selfPath)), _79_typeParamsSet, out _out35, out _out36);
      _90_implBody = _out35;
      _91_traitBodies = _out36;
      _83_i = BigInteger.Zero;
      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _92_emittedFields;
      _92_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      while ((_83_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _93_ctor;
        _93_ctor = ((c).dtor_ctors).Select(_83_i);
        BigInteger _94_j;
        _94_j = BigInteger.Zero;
        while ((_94_j) < (new BigInteger(((_93_ctor).dtor_args).Count))) {
          DAST._IFormal _95_formal;
          _95_formal = ((_93_ctor).dtor_args).Select(_94_j);
          if (!((_92_emittedFields).Contains((_95_formal).dtor_name))) {
            _92_emittedFields = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_92_emittedFields, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements((_95_formal).dtor_name));
            Dafny.ISequence<Dafny.Rune> _96_formalType;
            Dafny.ISequence<Dafny.Rune> _out37;
            _out37 = DCOMP.COMP.GenType((_95_formal).dtor_typ, false, false);
            _96_formalType = _out37;
            Dafny.ISequence<Dafny.Rune> _97_methodBody;
            _97_methodBody = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n");
            BigInteger _98_k;
            _98_k = BigInteger.Zero;
            while ((_98_k) < (new BigInteger(((c).dtor_ctors).Count))) {
              DAST._IDatatypeCtor _99_ctor2;
              _99_ctor2 = ((c).dtor_ctors).Select(_98_k);
              Dafny.ISequence<Dafny.Rune> _100_ctorMatch;
              _100_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_99_ctor2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
              BigInteger _101_l;
              _101_l = BigInteger.Zero;
              bool _102_hasMatchingField;
              _102_hasMatchingField = false;
              while ((_101_l) < (new BigInteger(((_99_ctor2).dtor_args).Count))) {
                DAST._IFormal _103_formal2;
                _103_formal2 = ((_99_ctor2).dtor_args).Select(_101_l);
                if (((_95_formal).dtor_name).Equals((_103_formal2).dtor_name)) {
                  _102_hasMatchingField = true;
                }
                _100_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_100_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_103_formal2).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                _101_l = (_101_l) + (BigInteger.One);
              }
              if (_102_hasMatchingField) {
                if ((c).dtor_isCo) {
                  _100_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_100_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ::std::ops::Deref::deref(&")), (_95_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0),\n"));
                } else {
                  _100_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_100_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => ")), (_95_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(",\n"));
                }
              } else {
                _100_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_100_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("} => panic!(\"field does not exist on this variant\"),\n"));
              }
              _97_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_97_methodBody, _100_ctorMatch);
              _98_k = (_98_k) + (BigInteger.One);
            }
            _97_methodBody = Dafny.Sequence<Dafny.Rune>.Concat(_97_methodBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            _90_implBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_90_implBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#")), (_95_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&self) -> &")), _96_formalType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _97_methodBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
          }
          _94_j = (_94_j) + (BigInteger.One);
        }
        _83_i = (_83_i) + (BigInteger.One);
      }
      Dafny.ISequence<Dafny.Rune> _104_enumBody;
      _104_enumBody = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("#[derive(PartialEq)]\npub enum r#"), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _82_ctors), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _81_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" r#")), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _90_implBody), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
      Dafny.ISequence<Dafny.Rune> _105_identEraseImpls;
      _105_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _81_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyErasable for r#")), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("type Erased = Self;\nfn erase(&self) -> &Self::Erased { self }\nfn erase_owned(self) -> Self::Erased { self }}\n"));
      _105_identEraseImpls = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_105_identEraseImpls, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl ")), _81_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyUnerasable<r#")), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> for r#")), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn unerase(x: &Self) -> &Self { x }\nfn unerase_owned(x: Self) -> Self { x }}\n"));
      Dafny.ISequence<Dafny.Rune> _106_printImpl;
      _106_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _81_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("match self {\n"));
      _83_i = BigInteger.Zero;
      while ((_83_i) < (new BigInteger(((c).dtor_ctors).Count))) {
        DAST._IDatatypeCtor _107_ctor;
        _107_ctor = ((c).dtor_ctors).Select(_83_i);
        Dafny.ISequence<Dafny.Rune> _108_ctorMatch;
        _108_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), (_107_ctor).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" { "));
        Dafny.ISequence<Dafny.Rune> _109_modulePrefix;
        _109_modulePrefix = (((((c).dtor_enclosingModule)).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_module"))) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.Concat(((c).dtor_enclosingModule), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("."))));
        Dafny.ISequence<Dafny.Rune> _110_printRhs;
        _110_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \""), _109_modulePrefix), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (_107_ctor).dtor_name), (((_107_ctor).dtor_hasAnyArgs) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(\")?;")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"))));
        BigInteger _111_j;
        _111_j = BigInteger.Zero;
        while ((_111_j) < (new BigInteger(((_107_ctor).dtor_args).Count))) {
          DAST._IFormal _112_formal;
          _112_formal = ((_107_ctor).dtor_args).Select(_111_j);
          _108_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_108_ctorMatch, (_112_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          if ((_111_j).Sign == 1) {
            _110_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_110_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
          }
          _110_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_110_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(")), (_112_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", __fmt_print_formatter, false)?;"));
          _111_j = (_111_j) + (BigInteger.One);
        }
        _108_ctorMatch = Dafny.Sequence<Dafny.Rune>.Concat(_108_ctorMatch, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
        if ((_107_ctor).dtor_hasAnyArgs) {
          _110_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_110_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
        }
        _110_printRhs = Dafny.Sequence<Dafny.Rune>.Concat(_110_printRhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())"));
        _106_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_106_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _108_ctorMatch), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" => {\n")), _110_printRhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
        _83_i = (_83_i) + (BigInteger.One);
      }
      _106_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_106_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _113_defaultImpl;
      _113_defaultImpl = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger(((c).dtor_ctors).Count)).Sign == 1) {
        _113_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _81_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _80_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), (((c).dtor_ctors).Select(BigInteger.Zero)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
        _83_i = BigInteger.Zero;
        while ((_83_i) < (new BigInteger(((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Count))) {
          DAST._IFormal _114_formal;
          _114_formal = ((((c).dtor_ctors).Select(BigInteger.Zero)).dtor_args).Select(_83_i);
          _113_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_113_defaultImpl, (_114_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": std::default::Default::default(),\n"));
          _83_i = (_83_i) + (BigInteger.One);
        }
        _113_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_113_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n}\n}\n"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_104_enumBody, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _105_identEraseImpls), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _106_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _113_defaultImpl);
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenPath(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> p) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      if ((new BigInteger((p).Count)).Sign == 0) {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("Self");
        return s;
      } else {
        s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("super::");
        BigInteger _115_i;
        _115_i = BigInteger.Zero;
        while ((_115_i) < (new BigInteger((p).Count))) {
          if ((_115_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), ((p).Select(_115_i)));
          _115_i = (_115_i) + (BigInteger.One);
        }
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenTypeArgs(Dafny.ISequence<DAST._IType> args, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      if ((new BigInteger((args).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _116_i;
        _116_i = BigInteger.Zero;
        while ((_116_i) < (new BigInteger((args).Count))) {
          if ((_116_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _117_genTp;
          Dafny.ISequence<Dafny.Rune> _out38;
          _out38 = DCOMP.COMP.GenType((args).Select(_116_i), inBinding, inFn);
          _117_genTp = _out38;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _117_genTp);
          _116_i = (_116_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenType(DAST._IType c, bool inBinding, bool inFn) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      DAST._IType _source5 = c;
      if (_source5.is_Path) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _118___mcc_h0 = _source5.dtor_Path_a0;
        Dafny.ISequence<DAST._IType> _119___mcc_h1 = _source5.dtor_typeArgs;
        DAST._IResolvedType _120___mcc_h2 = _source5.dtor_resolved;
        DAST._IResolvedType _121_resolved = _120___mcc_h2;
        Dafny.ISequence<DAST._IType> _122_args = _119___mcc_h1;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _123_p = _118___mcc_h0;
        {
          Dafny.ISequence<Dafny.Rune> _out39;
          _out39 = DCOMP.COMP.GenPath(_123_p);
          s = _out39;
          Dafny.ISequence<Dafny.Rune> _124_typeArgs;
          Dafny.ISequence<Dafny.Rune> _out40;
          _out40 = DCOMP.COMP.GenTypeArgs(_122_args, inBinding, inFn);
          _124_typeArgs = _out40;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, _124_typeArgs);
          DAST._IResolvedType _source6 = _121_resolved;
          if (_source6.is_Datatype) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _125___mcc_h16 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _126___mcc_h18 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IResolvedType _127_Primitive = _121_resolved;
          }
        }
      } else if (_source5.is_Tuple) {
        Dafny.ISequence<DAST._IType> _128___mcc_h3 = _source5.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _129_types = _128___mcc_h3;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _130_i;
          _130_i = BigInteger.Zero;
          while ((_130_i) < (new BigInteger((_129_types).Count))) {
            if ((_130_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _131_generated;
            Dafny.ISequence<Dafny.Rune> _out41;
            _out41 = DCOMP.COMP.GenType((_129_types).Select(_130_i), inBinding, inFn);
            _131_generated = _out41;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _131_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _130_i = (_130_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source5.is_Array) {
        DAST._IType _132___mcc_h4 = _source5.dtor_element;
        DAST._IType _133_element = _132___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _134_elemStr;
          Dafny.ISequence<Dafny.Rune> _out42;
          _out42 = DCOMP.COMP.GenType(_133_element, inBinding, inFn);
          _134_elemStr = _out42;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _134_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Seq) {
        DAST._IType _135___mcc_h5 = _source5.dtor_element;
        DAST._IType _136_element = _135___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _137_elemStr;
          Dafny.ISequence<Dafny.Rune> _out43;
          _out43 = DCOMP.COMP.GenType(_136_element, inBinding, inFn);
          _137_elemStr = _out43;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _137_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _138___mcc_h6 = _source5.dtor_element;
        DAST._IType _139_element = _138___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _140_elemStr;
          Dafny.ISequence<Dafny.Rune> _out44;
          _out44 = DCOMP.COMP.GenType(_139_element, inBinding, inFn);
          _140_elemStr = _out44;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _140_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _141___mcc_h7 = _source5.dtor_element;
        DAST._IType _142_element = _141___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _143_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_142_element, inBinding, inFn);
          _143_elemStr = _out45;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _143_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _144___mcc_h8 = _source5.dtor_key;
        DAST._IType _145___mcc_h9 = _source5.dtor_value;
        DAST._IType _146_value = _145___mcc_h9;
        DAST._IType _147_key = _144___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _148_keyStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_147_key, inBinding, inFn);
          _148_keyStr = _out46;
          Dafny.ISequence<Dafny.Rune> _149_valueStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_146_value, inBinding, inFn);
          _149_valueStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _148_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _149_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _150___mcc_h10 = _source5.dtor_args;
        DAST._IType _151___mcc_h11 = _source5.dtor_result;
        DAST._IType _152_result = _151___mcc_h11;
        Dafny.ISequence<DAST._IType> _153_args = _150___mcc_h10;
        {
          if (inBinding) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<_>");
          } else {
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::boxed::Box<dyn ::std::ops::Fn(");
            } else {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<impl ::std::ops::Fn(");
            }
            BigInteger _154_i;
            _154_i = BigInteger.Zero;
            while ((_154_i) < (new BigInteger((_153_args).Count))) {
              if ((_154_i).Sign == 1) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _155_generated;
              Dafny.ISequence<Dafny.Rune> _out48;
              _out48 = DCOMP.COMP.GenType((_153_args).Select(_154_i), inBinding, true);
              _155_generated = _out48;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _155_generated);
              _154_i = (_154_i) + (BigInteger.One);
            }
            Dafny.ISequence<Dafny.Rune> _156_resultType;
            Dafny.ISequence<Dafny.Rune> _out49;
            _out49 = DCOMP.COMP.GenType(_152_result, inBinding, inFn);
            _156_resultType = _out49;
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _156_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _156_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + Clone + 'static>"));
            }
          }
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _157___mcc_h12 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _158_p = _157___mcc_h12;
        {
          DAST._IPrimitive _source7 = _158_p;
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
        Dafny.ISequence<Dafny.Rune> _159___mcc_h13 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _160_v = _159___mcc_h13;
        s = _160_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _161___mcc_h14 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _161___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _162___mcc_h15 = _source8;
        Dafny.ISequence<Dafny.Rune> _163_name = _162___mcc_h15;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _163_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _164_i;
      _164_i = BigInteger.Zero;
      while ((_164_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_164_i);
        DAST._IMethod _165___mcc_h0 = _source9;
        DAST._IMethod _166_m = _165___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_166_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _167___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _168_p = _167___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _169_existing;
              _169_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_168_p)) {
                _169_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _168_p);
              }
              if ((new BigInteger((_169_existing).Count)).Sign == 1) {
                _169_existing = Dafny.Sequence<Dafny.Rune>.Concat(_169_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _170_genMethod;
              Dafny.ISequence<Dafny.Rune> _out50;
              _out50 = DCOMP.COMP.GenMethod(_166_m, true, enclosingType, enclosingTypeParams);
              _170_genMethod = _out50;
              _169_existing = Dafny.Sequence<Dafny.Rune>.Concat(_169_existing, _170_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_168_p, _169_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _171_generated;
              Dafny.ISequence<Dafny.Rune> _out51;
              _out51 = DCOMP.COMP.GenMethod(_166_m, forTrait, enclosingType, enclosingTypeParams);
              _171_generated = _out51;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _171_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _164_i = (_164_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _172_i;
      _172_i = BigInteger.Zero;
      while ((_172_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _173_param;
        _173_param = (@params).Select(_172_i);
        Dafny.ISequence<Dafny.Rune> _174_paramType;
        Dafny.ISequence<Dafny.Rune> _out52;
        _out52 = DCOMP.COMP.GenType((_173_param).dtor_typ, false, false);
        _174_paramType = _out52;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_173_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _174_paramType);
        if ((_172_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _172_i = (_172_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _175_params;
      Dafny.ISequence<Dafny.Rune> _out53;
      _out53 = DCOMP.COMP.GenParams((m).dtor_params);
      _175_params = _out53;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _176_paramNames;
      _176_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _177_paramI;
      _177_paramI = BigInteger.Zero;
      while ((_177_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _176_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_176_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_177_paramI)).dtor_name));
        _177_paramI = (_177_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _175_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _175_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _178_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out54;
          _out54 = DCOMP.COMP.GenType(enclosingType, false, false);
          _178_enclosingTypeString = _out54;
          _175_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _178_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _175_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _179_retType;
      _179_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _180_typeI;
      _180_typeI = BigInteger.Zero;
      while ((_180_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_180_typeI).Sign == 1) {
          _179_retType = Dafny.Sequence<Dafny.Rune>.Concat(_179_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _181_typeString;
        Dafny.ISequence<Dafny.Rune> _out55;
        _out55 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_180_typeI), false, false);
        _181_typeString = _out55;
        _179_retType = Dafny.Sequence<Dafny.Rune>.Concat(_179_retType, _181_typeString);
        _180_typeI = (_180_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _179_retType = Dafny.Sequence<Dafny.Rune>.Concat(_179_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _182_typeParamsFiltered;
      _182_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _183_typeParamI;
      _183_typeParamI = BigInteger.Zero;
      while ((_183_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _184_typeParam;
        _184_typeParam = ((m).dtor_typeParams).Select(_183_typeParamI);
        if (!((enclosingTypeParams).Contains(_184_typeParam))) {
          _182_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_182_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_184_typeParam));
        }
        _183_typeParamI = (_183_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_182_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _185_i;
        _185_i = BigInteger.Zero;
        while ((_185_i) < (new BigInteger((_182_typeParamsFiltered).Count))) {
          if ((_185_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _186_typeString;
          Dafny.ISequence<Dafny.Rune> _out56;
          _out56 = DCOMP.COMP.GenType((_182_typeParamsFiltered).Select(_185_i), false, false);
          _186_typeString = _out56;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _186_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _186_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _185_i = (_185_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _175_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _179_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _187_earlyReturn;
        _187_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _188___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _189_outVars = _188___mcc_h0;
          {
            _187_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _190_outI;
            _190_outI = BigInteger.Zero;
            while ((_190_outI) < (new BigInteger((_189_outVars).Count))) {
              if ((_190_outI).Sign == 1) {
                _187_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_187_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _191_outVar;
              _191_outVar = (_189_outVars).Select(_190_outI);
              _187_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_187_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_191_outVar));
              _190_outI = (_190_outI) + (BigInteger.One);
            }
            _187_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_187_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _192_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _193___v12;
        Dafny.ISequence<Dafny.Rune> _out57;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out58;
        DCOMP.COMP.GenStmts((m).dtor_body, _176_paramNames, true, _187_earlyReturn, out _out57, out _out58);
        _192_body = _out57;
        _193___v12 = _out58;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source12 = (m).dtor_outVars;
        if (_source12.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _194___mcc_h1 = _source12.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _195_outVars = _194___mcc_h1;
          {
            _192_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_192_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _187_earlyReturn);
          }
        } else {
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _192_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
      }
      return s;
    }
    public static void GenStmts(Dafny.ISequence<DAST._IStatement> stmts, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _196_i;
      _196_i = BigInteger.Zero;
      while ((_196_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _197_stmt;
        _197_stmt = (stmts).Select(_196_i);
        Dafny.ISequence<Dafny.Rune> _198_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _199_recIdents;
        Dafny.ISequence<Dafny.Rune> _out59;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out60;
        DCOMP.COMP.GenStmt(_197_stmt, @params, (isLast) && ((_196_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out59, out _out60);
        _198_stmtString = _out59;
        _199_recIdents = _out60;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _199_recIdents);
        if ((_196_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _198_stmtString);
        _196_i = (_196_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source13 = lhs;
      if (_source13.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _200___mcc_h0 = _source13.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source14 = _200___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _201___mcc_h1 = _source14;
        Dafny.ISequence<Dafny.Rune> _202_id = _201___mcc_h1;
        {
          if ((@params).Contains(_202_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _202_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _202_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_202_id);
          needsIIFE = false;
        }
      } else {
        DAST._IExpression _203___mcc_h2 = _source13.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _204___mcc_h3 = _source13.dtor_field;
        Dafny.ISequence<Dafny.Rune> _205_field = _204___mcc_h3;
        DAST._IExpression _206_on = _203___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _207_onExpr;
          bool _208_onOwned;
          bool _209_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _210_recIdents;
          Dafny.ISequence<Dafny.Rune> _out61;
          bool _out62;
          bool _out63;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out64;
          DCOMP.COMP.GenExpr(_206_on, @params, false, out _out61, out _out62, out _out63, out _out64);
          _207_onExpr = _out61;
          _208_onOwned = _out62;
          _209_onErased = _out63;
          _210_recIdents = _out64;
          if (!(_209_onErased)) {
            Dafny.ISequence<Dafny.Rune> _211_eraseFn;
            _211_eraseFn = ((_208_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _207_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _211_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _207_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _207_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _205_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut())"));
          readIdents = _210_recIdents;
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _212___mcc_h0 = _source15.dtor_name;
        DAST._IType _213___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _214___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _214___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _215___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _216_expression = _215___mcc_h3;
          DAST._IType _217_typ = _213___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _218_name = _212___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _219_expr;
            bool _220___v13;
            bool _221_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _222_recIdents;
            Dafny.ISequence<Dafny.Rune> _out65;
            bool _out66;
            bool _out67;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out68;
            DCOMP.COMP.GenExpr(_216_expression, @params, true, out _out65, out _out66, out _out67, out _out68);
            _219_expr = _out65;
            _220___v13 = _out66;
            _221_recErased = _out67;
            _222_recIdents = _out68;
            if (_221_recErased) {
              _219_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _219_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _223_typeString;
            Dafny.ISequence<Dafny.Rune> _out69;
            _out69 = DCOMP.COMP.GenType(_217_typ, true, false);
            _223_typeString = _out69;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _218_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _223_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _219_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _222_recIdents;
          }
        } else {
          DAST._IType _224_typ = _213___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _225_name = _212___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _226_typeString;
            Dafny.ISequence<Dafny.Rune> _out70;
            _out70 = DCOMP.COMP.GenType(_224_typ, true, false);
            _226_typeString = _out70;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _225_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _226_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _227___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _228___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _229_expression = _228___mcc_h5;
        DAST._IAssignLhs _230_lhs = _227___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _231_lhsGen;
          bool _232_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _233_recIdents;
          Dafny.ISequence<Dafny.Rune> _out71;
          bool _out72;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out73;
          DCOMP.COMP.GenAssignLhs(_230_lhs, @params, out _out71, out _out72, out _out73);
          _231_lhsGen = _out71;
          _232_needsIIFE = _out72;
          _233_recIdents = _out73;
          Dafny.ISequence<Dafny.Rune> _234_exprGen;
          bool _235___v14;
          bool _236_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _237_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out74;
          bool _out75;
          bool _out76;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out77;
          DCOMP.COMP.GenExpr(_229_expression, @params, true, out _out74, out _out75, out _out76, out _out77);
          _234_exprGen = _out74;
          _235___v14 = _out75;
          _236_exprErased = _out76;
          _237_exprIdents = _out77;
          if (_236_exprErased) {
            _234_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _234_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_232_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ let __rhs = "), _234_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; ")), _231_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = __rhs; }"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_231_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _234_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_233_recIdents, _237_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _238___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _239___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _240___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _241_els = _240___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _242_thn = _239___mcc_h7;
        DAST._IExpression _243_cond = _238___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _244_condString;
          bool _245___v15;
          bool _246_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _247_recIdents;
          Dafny.ISequence<Dafny.Rune> _out78;
          bool _out79;
          bool _out80;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out81;
          DCOMP.COMP.GenExpr(_243_cond, @params, true, out _out78, out _out79, out _out80, out _out81);
          _244_condString = _out78;
          _245___v15 = _out79;
          _246_condErased = _out80;
          _247_recIdents = _out81;
          if (!(_246_condErased)) {
            _244_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _244_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _247_recIdents;
          Dafny.ISequence<Dafny.Rune> _248_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _249_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out82;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out83;
          DCOMP.COMP.GenStmts(_242_thn, @params, isLast, earlyReturn, out _out82, out _out83);
          _248_thnString = _out82;
          _249_thnIdents = _out83;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _249_thnIdents);
          Dafny.ISequence<Dafny.Rune> _250_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _251_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out84;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out85;
          DCOMP.COMP.GenStmts(_241_els, @params, isLast, earlyReturn, out _out84, out _out85);
          _250_elsString = _out84;
          _251_elsIdents = _out85;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _251_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _244_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _248_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _250_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _252___mcc_h9 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _253___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _254_body = _253___mcc_h10;
        DAST._IExpression _255_cond = _252___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _256_condString;
          bool _257___v16;
          bool _258_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _259_recIdents;
          Dafny.ISequence<Dafny.Rune> _out86;
          bool _out87;
          bool _out88;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out89;
          DCOMP.COMP.GenExpr(_255_cond, @params, true, out _out86, out _out87, out _out88, out _out89);
          _256_condString = _out86;
          _257___v16 = _out87;
          _258_condErased = _out88;
          _259_recIdents = _out89;
          if (!(_258_condErased)) {
            _256_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _256_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _259_recIdents;
          Dafny.ISequence<Dafny.Rune> _260_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _261_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out90;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out91;
          DCOMP.COMP.GenStmts(_254_body, @params, false, earlyReturn, out _out90, out _out91);
          _260_bodyString = _out90;
          _261_bodyIdents = _out91;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _261_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _256_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _260_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _262___mcc_h11 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _263___mcc_h12 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _264___mcc_h13 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _265___mcc_h14 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _266___mcc_h15 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _267_maybeOutVars = _266___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _268_args = _265___mcc_h14;
        Dafny.ISequence<DAST._IType> _269_typeArgs = _264___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _270_name = _263___mcc_h12;
        DAST._IExpression _271_on = _262___mcc_h11;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _272_typeArgString;
          _272_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_269_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _273_typeI;
            _273_typeI = BigInteger.Zero;
            _272_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_273_typeI) < (new BigInteger((_269_typeArgs).Count))) {
              if ((_273_typeI).Sign == 1) {
                _272_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_272_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _274_typeString;
              Dafny.ISequence<Dafny.Rune> _out92;
              _out92 = DCOMP.COMP.GenType((_269_typeArgs).Select(_273_typeI), false, false);
              _274_typeString = _out92;
              _272_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_272_typeArgString, _274_typeString);
              _273_typeI = (_273_typeI) + (BigInteger.One);
            }
            _272_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_272_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _275_argString;
          _275_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _276_i;
          _276_i = BigInteger.Zero;
          while ((_276_i) < (new BigInteger((_268_args).Count))) {
            if ((_276_i).Sign == 1) {
              _275_argString = Dafny.Sequence<Dafny.Rune>.Concat(_275_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _277_argExpr;
            bool _278_isOwned;
            bool _279_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _280_argIdents;
            Dafny.ISequence<Dafny.Rune> _out93;
            bool _out94;
            bool _out95;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out96;
            DCOMP.COMP.GenExpr((_268_args).Select(_276_i), @params, false, out _out93, out _out94, out _out95, out _out96);
            _277_argExpr = _out93;
            _278_isOwned = _out94;
            _279_argErased = _out95;
            _280_argIdents = _out96;
            if (_278_isOwned) {
              _277_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _277_argExpr);
            }
            _275_argString = Dafny.Sequence<Dafny.Rune>.Concat(_275_argString, _277_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _280_argIdents);
            _276_i = (_276_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _281_enclosingString;
          bool _282___v17;
          bool _283___v18;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _284_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out97;
          bool _out98;
          bool _out99;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out100;
          DCOMP.COMP.GenExpr(_271_on, @params, false, out _out97, out _out98, out _out99, out _out100);
          _281_enclosingString = _out97;
          _282___v17 = _out98;
          _283___v18 = _out99;
          _284_enclosingIdents = _out100;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _284_enclosingIdents);
          DAST._IExpression _source17 = _271_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _285___mcc_h18 = _source17.dtor_Literal_a0;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _286___mcc_h20 = _source17.dtor_Ident_a0;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _287___mcc_h22 = _source17.dtor_Companion_a0;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_281_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _288___mcc_h24 = _source17.dtor_Tuple_a0;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _289___mcc_h26 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _290___mcc_h27 = _source17.dtor_args;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _291___mcc_h30 = _source17.dtor_dims;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _292___mcc_h32 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _293___mcc_h33 = _source17.dtor_variant;
            bool _294___mcc_h34 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _295___mcc_h35 = _source17.dtor_contents;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _296___mcc_h40 = _source17.dtor_value;
            DAST._IType _297___mcc_h41 = _source17.dtor_from;
            DAST._IType _298___mcc_h42 = _source17.dtor_typ;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SubsetDowngrade) {
            DAST._IExpression _299___mcc_h46 = _source17.dtor_value;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _300___mcc_h48 = _source17.dtor_elements;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _301___mcc_h50 = _source17.dtor_elements;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _302___mcc_h52 = _source17.dtor_cond;
            DAST._IExpression _303___mcc_h53 = _source17.dtor_thn;
            DAST._IExpression _304___mcc_h54 = _source17.dtor_els;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _305___mcc_h58 = _source17.dtor_unOp;
            DAST._IExpression _306___mcc_h59 = _source17.dtor_expr;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _307___mcc_h62 = _source17.dtor_op;
            DAST._IExpression _308___mcc_h63 = _source17.dtor_left;
            DAST._IExpression _309___mcc_h64 = _source17.dtor_right;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _310___mcc_h68 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _311___mcc_h69 = _source17.dtor_field;
            bool _312___mcc_h70 = _source17.dtor_isConstant;
            bool _313___mcc_h71 = _source17.dtor_onDatatype;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _314___mcc_h76 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _315___mcc_h77 = _source17.dtor_field;
            bool _316___mcc_h78 = _source17.dtor_onDatatype;
            bool _317___mcc_h79 = _source17.dtor_isStatic;
            BigInteger _318___mcc_h80 = _source17.dtor_arity;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _319___mcc_h86 = _source17.dtor_expr;
            BigInteger _320___mcc_h87 = _source17.dtor_index;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _321___mcc_h90 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _322___mcc_h91 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _323___mcc_h92 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _324___mcc_h93 = _source17.dtor_args;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _325___mcc_h98 = _source17.dtor_params;
            DAST._IType _326___mcc_h99 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _327___mcc_h100 = _source17.dtor_body;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _328___mcc_h104 = _source17.dtor_name;
            DAST._IType _329___mcc_h105 = _source17.dtor_typ;
            DAST._IExpression _330___mcc_h106 = _source17.dtor_value;
            DAST._IExpression _331___mcc_h107 = _source17.dtor_iifeBody;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _332___mcc_h112 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _333___mcc_h113 = _source17.dtor_args;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _334___mcc_h116 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _335___mcc_h117 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _336___mcc_h118 = _source17.dtor_variant;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _337___mcc_h122 = _source17.dtor_typ;
            {
              _281_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _338_receiver;
          _338_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _267_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _339___mcc_h124 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _340_outVars = _339___mcc_h124;
            {
              if ((new BigInteger((_340_outVars).Count)) > (BigInteger.One)) {
                _338_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _341_outI;
              _341_outI = BigInteger.Zero;
              while ((_341_outI) < (new BigInteger((_340_outVars).Count))) {
                if ((_341_outI).Sign == 1) {
                  _338_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_338_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _342_outVar;
                _342_outVar = (_340_outVars).Select(_341_outI);
                _338_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_338_receiver, (_342_outVar));
                _341_outI = (_341_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_340_outVars).Count)) > (BigInteger.One)) {
                _338_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_338_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_338_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_338_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _281_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _270_name), _272_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _275_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _343___mcc_h16 = _source15.dtor_expr;
        DAST._IExpression _344_expr = _343___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _345_exprString;
          bool _346___v21;
          bool _347_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _348_recIdents;
          Dafny.ISequence<Dafny.Rune> _out101;
          bool _out102;
          bool _out103;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out104;
          DCOMP.COMP.GenExpr(_344_expr, @params, true, out _out101, out _out102, out _out103, out _out104);
          _345_exprString = _out101;
          _346___v21 = _out102;
          _347_recErased = _out103;
          _348_recIdents = _out104;
          _345_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _345_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _348_recIdents;
          if (isLast) {
            generated = _345_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _345_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
        }
      } else if (_source15.is_EarlyReturn) {
        {
          generated = earlyReturn;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source15.is_Halt) {
        {
          generated = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("panic!(\"Halt\");");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else {
        DAST._IExpression _349___mcc_h17 = _source15.dtor_Print_a0;
        DAST._IExpression _350_e = _349___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _351_printedExpr;
          bool _352_isOwned;
          bool _353___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _354_recIdents;
          Dafny.ISequence<Dafny.Rune> _out105;
          bool _out106;
          bool _out107;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out108;
          DCOMP.COMP.GenExpr(_350_e, @params, false, out _out105, out _out106, out _out107, out _out108);
          _351_printedExpr = _out105;
          _352_isOwned = _out106;
          _353___v22 = _out107;
          _354_recIdents = _out108;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_352_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _351_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _354_recIdents;
        }
      }
    }
    public static void GenExpr(DAST._IExpression e, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool mustOwn, out Dafny.ISequence<Dafny.Rune> s, out bool isOwned, out bool isErased, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      isOwned = false;
      isErased = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IExpression _source19 = e;
      if (_source19.is_Literal) {
        DAST._ILiteral _355___mcc_h0 = _source19.dtor_Literal_a0;
        DAST._ILiteral _source20 = _355___mcc_h0;
        if (_source20.is_BoolLiteral) {
          bool _356___mcc_h1 = _source20.dtor_BoolLiteral_a0;
          if ((_356___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _357___mcc_h2 = _source20.dtor_IntLiteral_a0;
          DAST._IType _358___mcc_h3 = _source20.dtor_IntLiteral_a1;
          DAST._IType _359_t = _358___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _360_i = _357___mcc_h2;
          {
            DAST._IType _source21 = _359_t;
            if (_source21.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _361___mcc_h61 = _source21.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _362___mcc_h62 = _source21.dtor_typeArgs;
              DAST._IResolvedType _363___mcc_h63 = _source21.dtor_resolved;
              {
                s = _360_i;
              }
            } else if (_source21.is_Tuple) {
              Dafny.ISequence<DAST._IType> _364___mcc_h67 = _source21.dtor_Tuple_a0;
              {
                s = _360_i;
              }
            } else if (_source21.is_Array) {
              DAST._IType _365___mcc_h69 = _source21.dtor_element;
              {
                s = _360_i;
              }
            } else if (_source21.is_Seq) {
              DAST._IType _366___mcc_h71 = _source21.dtor_element;
              {
                s = _360_i;
              }
            } else if (_source21.is_Set) {
              DAST._IType _367___mcc_h73 = _source21.dtor_element;
              {
                s = _360_i;
              }
            } else if (_source21.is_Multiset) {
              DAST._IType _368___mcc_h75 = _source21.dtor_element;
              {
                s = _360_i;
              }
            } else if (_source21.is_Map) {
              DAST._IType _369___mcc_h77 = _source21.dtor_key;
              DAST._IType _370___mcc_h78 = _source21.dtor_value;
              {
                s = _360_i;
              }
            } else if (_source21.is_Arrow) {
              Dafny.ISequence<DAST._IType> _371___mcc_h81 = _source21.dtor_args;
              DAST._IType _372___mcc_h82 = _source21.dtor_result;
              {
                s = _360_i;
              }
            } else if (_source21.is_Primitive) {
              DAST._IPrimitive _373___mcc_h85 = _source21.dtor_Primitive_a0;
              DAST._IPrimitive _source22 = _373___mcc_h85;
              if (_source22.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _360_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source22.is_Real) {
                {
                  s = _360_i;
                }
              } else if (_source22.is_String) {
                {
                  s = _360_i;
                }
              } else if (_source22.is_Bool) {
                {
                  s = _360_i;
                }
              } else {
                {
                  s = _360_i;
                }
              }
            } else if (_source21.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _374___mcc_h87 = _source21.dtor_Passthrough_a0;
              {
                s = _360_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _375___mcc_h89 = _source21.dtor_TypeArg_a0;
              {
                s = _360_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _376___mcc_h4 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _377___mcc_h5 = _source20.dtor_DecLiteral_a1;
          DAST._IType _378___mcc_h6 = _source20.dtor_DecLiteral_a2;
          DAST._IType _379_t = _378___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _380_d = _377___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _381_n = _376___mcc_h4;
          {
            DAST._IType _source23 = _379_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _382___mcc_h91 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _383___mcc_h92 = _source23.dtor_typeArgs;
              DAST._IResolvedType _384___mcc_h93 = _source23.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _385___mcc_h97 = _source23.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Array) {
              DAST._IType _386___mcc_h99 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Seq) {
              DAST._IType _387___mcc_h101 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Set) {
              DAST._IType _388___mcc_h103 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _389___mcc_h105 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Map) {
              DAST._IType _390___mcc_h107 = _source23.dtor_key;
              DAST._IType _391___mcc_h108 = _source23.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _392___mcc_h111 = _source23.dtor_args;
              DAST._IType _393___mcc_h112 = _source23.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _394___mcc_h115 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _394___mcc_h115;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _381_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source24.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _395___mcc_h117 = _source23.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _396___mcc_h119 = _source23.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_381_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _380_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _397___mcc_h7 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _398_l = _397___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _398_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _399___mcc_h8 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _400_c = _399___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_400_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _401___mcc_h9 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _402_name = _401___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _402_name);
          if (!((@params).Contains(_402_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_402_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _403___mcc_h10 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _404_path = _403___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out109;
          _out109 = DCOMP.COMP.GenPath(_404_path);
          s = _out109;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _405___mcc_h11 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _406_values = _405___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _407_i;
          _407_i = BigInteger.Zero;
          bool _408_allErased;
          _408_allErased = true;
          while ((_407_i) < (new BigInteger((_406_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _409___v25;
            bool _410___v26;
            bool _411_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _412___v27;
            Dafny.ISequence<Dafny.Rune> _out110;
            bool _out111;
            bool _out112;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out113;
            DCOMP.COMP.GenExpr((_406_values).Select(_407_i), @params, true, out _out110, out _out111, out _out112, out _out113);
            _409___v25 = _out110;
            _410___v26 = _out111;
            _411_isErased = _out112;
            _412___v27 = _out113;
            _408_allErased = (_408_allErased) && (_411_isErased);
            _407_i = (_407_i) + (BigInteger.One);
          }
          _407_i = BigInteger.Zero;
          while ((_407_i) < (new BigInteger((_406_values).Count))) {
            if ((_407_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _413_recursiveGen;
            bool _414___v28;
            bool _415_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _416_recIdents;
            Dafny.ISequence<Dafny.Rune> _out114;
            bool _out115;
            bool _out116;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
            DCOMP.COMP.GenExpr((_406_values).Select(_407_i), @params, true, out _out114, out _out115, out _out116, out _out117);
            _413_recursiveGen = _out114;
            _414___v28 = _out115;
            _415_isErased = _out116;
            _416_recIdents = _out117;
            if ((_415_isErased) && (!(_408_allErased))) {
              _413_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _416_recIdents);
            _407_i = (_407_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _408_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _417___mcc_h12 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _418___mcc_h13 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _419_args = _418___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _420_path = _417___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _421_path;
          Dafny.ISequence<Dafny.Rune> _out118;
          _out118 = DCOMP.COMP.GenPath(_420_path);
          _421_path = _out118;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _421_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _422_i;
          _422_i = BigInteger.Zero;
          while ((_422_i) < (new BigInteger((_419_args).Count))) {
            if ((_422_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _423_recursiveGen;
            bool _424___v29;
            bool _425_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _426_recIdents;
            Dafny.ISequence<Dafny.Rune> _out119;
            bool _out120;
            bool _out121;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out122;
            DCOMP.COMP.GenExpr((_419_args).Select(_422_i), @params, true, out _out119, out _out120, out _out121, out _out122);
            _423_recursiveGen = _out119;
            _424___v29 = _out120;
            _425_isErased = _out121;
            _426_recIdents = _out122;
            if (_425_isErased) {
              _423_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _423_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _423_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _426_recIdents);
            _422_i = (_422_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _427___mcc_h14 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _428_dims = _427___mcc_h14;
        {
          BigInteger _429_i;
          _429_i = (new BigInteger((_428_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_429_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _430_recursiveGen;
            bool _431___v30;
            bool _432_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _433_recIdents;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_428_dims).Select(_429_i), @params, true, out _out123, out _out124, out _out125, out _out126);
            _430_recursiveGen = _out123;
            _431___v30 = _out124;
            _432_isErased = _out125;
            _433_recIdents = _out126;
            if (!(_432_isErased)) {
              _430_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _430_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _430_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _433_recIdents);
            _429_i = (_429_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _434___mcc_h15 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _435___mcc_h16 = _source19.dtor_variant;
        bool _436___mcc_h17 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _437___mcc_h18 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _438_values = _437___mcc_h18;
        bool _439_isCo = _436___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _440_variant = _435___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _441_path = _434___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _442_path;
          Dafny.ISequence<Dafny.Rune> _out127;
          _out127 = DCOMP.COMP.GenPath(_441_path);
          _442_path = _out127;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _442_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _440_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _443_i;
          _443_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_443_i) < (new BigInteger((_438_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_438_values).Select(_443_i);
            Dafny.ISequence<Dafny.Rune> _444_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _445_value = _let_tmp_rhs0.dtor__1;
            if ((_443_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_439_isCo) {
              Dafny.ISequence<Dafny.Rune> _446_recursiveGen;
              bool _447___v31;
              bool _448_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _449_recIdents;
              Dafny.ISequence<Dafny.Rune> _out128;
              bool _out129;
              bool _out130;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out131;
              DCOMP.COMP.GenExpr(_445_value, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out128, out _out129, out _out130, out _out131);
              _446_recursiveGen = _out128;
              _447___v31 = _out129;
              _448_isErased = _out130;
              _449_recIdents = _out131;
              if (!(_448_isErased)) {
                _446_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _446_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _449_recIdents);
              Dafny.ISequence<Dafny.Rune> _450_allReadCloned;
              _450_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_449_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _451_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_449_recIdents).Elements) {
                  _451_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_449_recIdents).Contains(_451_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1052)");
              after__ASSIGN_SUCH_THAT_0:;
                _450_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_450_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _451_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _451_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _449_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_449_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_451_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _444_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _450_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _446_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _452_recursiveGen;
              bool _453___v32;
              bool _454_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _455_recIdents;
              Dafny.ISequence<Dafny.Rune> _out132;
              bool _out133;
              bool _out134;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
              DCOMP.COMP.GenExpr(_445_value, @params, true, out _out132, out _out133, out _out134, out _out135);
              _452_recursiveGen = _out132;
              _453___v32 = _out133;
              _454_isErased = _out134;
              _455_recIdents = _out135;
              if (!(_454_isErased)) {
                _452_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _452_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _452_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _452_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _444_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _452_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _455_recIdents);
            }
            _443_i = (_443_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _456___mcc_h19 = _source19.dtor_value;
        DAST._IType _457___mcc_h20 = _source19.dtor_from;
        DAST._IType _458___mcc_h21 = _source19.dtor_typ;
        DAST._IType _459_toTpe = _458___mcc_h21;
        DAST._IType _460_fromTpe = _457___mcc_h20;
        DAST._IExpression _461_expr = _456___mcc_h19;
        {
          _System._ITuple2<DAST._IType, DAST._IType> _source25 = _System.Tuple2<DAST._IType, DAST._IType>.create(_460_fromTpe, _459_toTpe);
          DAST._IType _462___mcc_h121 = _source25.dtor__0;
          DAST._IType _463___mcc_h122 = _source25.dtor__1;
          DAST._IType _source26 = _462___mcc_h121;
          if (_source26.is_Path) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _464___mcc_h125 = _source26.dtor_Path_a0;
            Dafny.ISequence<DAST._IType> _465___mcc_h126 = _source26.dtor_typeArgs;
            DAST._IResolvedType _466___mcc_h127 = _source26.dtor_resolved;
            DAST._IType _source27 = _463___mcc_h122;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _467___mcc_h134 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _468___mcc_h135 = _source27.dtor_typeArgs;
              DAST._IResolvedType _469___mcc_h136 = _source27.dtor_resolved;
              DAST._IResolvedType _source28 = _469___mcc_h136;
              if (_source28.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _470___mcc_h140 = _source28.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _471_recursiveGen;
                  bool _472_recOwned;
                  bool _473_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _474_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out136;
                  bool _out137;
                  bool _out138;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out136, out _out137, out _out138, out _out139);
                  _471_recursiveGen = _out136;
                  _472_recOwned = _out137;
                  _473_recErased = _out138;
                  _474_recIdents = _out139;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _471_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _472_recOwned;
                  isErased = _473_recErased;
                  readIdents = _474_recIdents;
                }
              } else if (_source28.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _475___mcc_h142 = _source28.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _476_recursiveGen;
                  bool _477_recOwned;
                  bool _478_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _479_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out140;
                  bool _out141;
                  bool _out142;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out143;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out140, out _out141, out _out142, out _out143);
                  _476_recursiveGen = _out140;
                  _477_recOwned = _out141;
                  _478_recErased = _out142;
                  _479_recIdents = _out143;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _476_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _477_recOwned;
                  isErased = _478_recErased;
                  readIdents = _479_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _480_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out144;
                  _out144 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _480_tpeGen = _out144;
                  Dafny.ISequence<Dafny.Rune> _481_recursiveGen;
                  bool _482_recOwned;
                  bool _483_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _484_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out145;
                  bool _out146;
                  bool _out147;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out145, out _out146, out _out147, out _out148);
                  _481_recursiveGen = _out145;
                  _482_recOwned = _out146;
                  _483_recErased = _out147;
                  _484_recIdents = _out148;
                  Dafny.ISequence<Dafny.Rune> _485_uneraseFn;
                  _485_uneraseFn = ((_482_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _480_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _485_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _481_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _482_recOwned;
                  isErased = false;
                  readIdents = _484_recIdents;
                }
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _486___mcc_h144 = _source27.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _487_recursiveGen;
                bool _488_recOwned;
                bool _489_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _490_recIdents;
                Dafny.ISequence<Dafny.Rune> _out149;
                bool _out150;
                bool _out151;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out149, out _out150, out _out151, out _out152);
                _487_recursiveGen = _out149;
                _488_recOwned = _out150;
                _489_recErased = _out151;
                _490_recIdents = _out152;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _487_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _488_recOwned;
                isErased = _489_recErased;
                readIdents = _490_recIdents;
              }
            } else if (_source27.is_Array) {
              DAST._IType _491___mcc_h146 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _492_recursiveGen;
                bool _493_recOwned;
                bool _494_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _495_recIdents;
                Dafny.ISequence<Dafny.Rune> _out153;
                bool _out154;
                bool _out155;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out153, out _out154, out _out155, out _out156);
                _492_recursiveGen = _out153;
                _493_recOwned = _out154;
                _494_recErased = _out155;
                _495_recIdents = _out156;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _493_recOwned;
                isErased = _494_recErased;
                readIdents = _495_recIdents;
              }
            } else if (_source27.is_Seq) {
              DAST._IType _496___mcc_h148 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _497_recursiveGen;
                bool _498_recOwned;
                bool _499_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _500_recIdents;
                Dafny.ISequence<Dafny.Rune> _out157;
                bool _out158;
                bool _out159;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out157, out _out158, out _out159, out _out160);
                _497_recursiveGen = _out157;
                _498_recOwned = _out158;
                _499_recErased = _out159;
                _500_recIdents = _out160;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _497_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _498_recOwned;
                isErased = _499_recErased;
                readIdents = _500_recIdents;
              }
            } else if (_source27.is_Set) {
              DAST._IType _501___mcc_h150 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _502_recursiveGen;
                bool _503_recOwned;
                bool _504_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _505_recIdents;
                Dafny.ISequence<Dafny.Rune> _out161;
                bool _out162;
                bool _out163;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out161, out _out162, out _out163, out _out164);
                _502_recursiveGen = _out161;
                _503_recOwned = _out162;
                _504_recErased = _out163;
                _505_recIdents = _out164;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _503_recOwned;
                isErased = _504_recErased;
                readIdents = _505_recIdents;
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _506___mcc_h152 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _507_recursiveGen;
                bool _508_recOwned;
                bool _509_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _510_recIdents;
                Dafny.ISequence<Dafny.Rune> _out165;
                bool _out166;
                bool _out167;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out168;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out165, out _out166, out _out167, out _out168);
                _507_recursiveGen = _out165;
                _508_recOwned = _out166;
                _509_recErased = _out167;
                _510_recIdents = _out168;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _508_recOwned;
                isErased = _509_recErased;
                readIdents = _510_recIdents;
              }
            } else if (_source27.is_Map) {
              DAST._IType _511___mcc_h154 = _source27.dtor_key;
              DAST._IType _512___mcc_h155 = _source27.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _513_recursiveGen;
                bool _514_recOwned;
                bool _515_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _516_recIdents;
                Dafny.ISequence<Dafny.Rune> _out169;
                bool _out170;
                bool _out171;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out172;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out169, out _out170, out _out171, out _out172);
                _513_recursiveGen = _out169;
                _514_recOwned = _out170;
                _515_recErased = _out171;
                _516_recIdents = _out172;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _513_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _514_recOwned;
                isErased = _515_recErased;
                readIdents = _516_recIdents;
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _517___mcc_h158 = _source27.dtor_args;
              DAST._IType _518___mcc_h159 = _source27.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _519_recursiveGen;
                bool _520_recOwned;
                bool _521_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _522_recIdents;
                Dafny.ISequence<Dafny.Rune> _out173;
                bool _out174;
                bool _out175;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out176;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out173, out _out174, out _out175, out _out176);
                _519_recursiveGen = _out173;
                _520_recOwned = _out174;
                _521_recErased = _out175;
                _522_recIdents = _out176;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _520_recOwned;
                isErased = _521_recErased;
                readIdents = _522_recIdents;
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _523___mcc_h162 = _source27.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _524_recursiveGen;
                bool _525_recOwned;
                bool _526_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _527_recIdents;
                Dafny.ISequence<Dafny.Rune> _out177;
                bool _out178;
                bool _out179;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out180;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out177, out _out178, out _out179, out _out180);
                _524_recursiveGen = _out177;
                _525_recOwned = _out178;
                _526_recErased = _out179;
                _527_recIdents = _out180;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _525_recOwned;
                isErased = _526_recErased;
                readIdents = _527_recIdents;
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _528___mcc_h164 = _source27.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _529_recursiveGen;
                bool _530_recOwned;
                bool _531_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _532_recIdents;
                Dafny.ISequence<Dafny.Rune> _out181;
                bool _out182;
                bool _out183;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out184;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out181, out _out182, out _out183, out _out184);
                _529_recursiveGen = _out181;
                _530_recOwned = _out182;
                _531_recErased = _out183;
                _532_recIdents = _out184;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _529_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _530_recOwned;
                isErased = _531_recErased;
                readIdents = _532_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _533___mcc_h166 = _source27.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _534_recursiveGen;
                bool _535_recOwned;
                bool _536_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _537_recIdents;
                Dafny.ISequence<Dafny.Rune> _out185;
                bool _out186;
                bool _out187;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out188;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out185, out _out186, out _out187, out _out188);
                _534_recursiveGen = _out185;
                _535_recOwned = _out186;
                _536_recErased = _out187;
                _537_recIdents = _out188;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _535_recOwned;
                isErased = _536_recErased;
                readIdents = _537_recIdents;
              }
            }
          } else if (_source26.is_Tuple) {
            Dafny.ISequence<DAST._IType> _538___mcc_h168 = _source26.dtor_Tuple_a0;
            DAST._IType _source29 = _463___mcc_h122;
            if (_source29.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _539___mcc_h171 = _source29.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _540___mcc_h172 = _source29.dtor_typeArgs;
              DAST._IResolvedType _541___mcc_h173 = _source29.dtor_resolved;
              DAST._IResolvedType _source30 = _541___mcc_h173;
              if (_source30.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _542___mcc_h177 = _source30.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _543_recursiveGen;
                  bool _544_recOwned;
                  bool _545_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _546_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out189;
                  bool _out190;
                  bool _out191;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out192;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out189, out _out190, out _out191, out _out192);
                  _543_recursiveGen = _out189;
                  _544_recOwned = _out190;
                  _545_recErased = _out191;
                  _546_recIdents = _out192;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _543_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _544_recOwned;
                  isErased = _545_recErased;
                  readIdents = _546_recIdents;
                }
              } else if (_source30.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _547___mcc_h179 = _source30.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _548_recursiveGen;
                  bool _549_recOwned;
                  bool _550_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _551_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out193;
                  bool _out194;
                  bool _out195;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out196;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out193, out _out194, out _out195, out _out196);
                  _548_recursiveGen = _out193;
                  _549_recOwned = _out194;
                  _550_recErased = _out195;
                  _551_recIdents = _out196;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _548_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _549_recOwned;
                  isErased = _550_recErased;
                  readIdents = _551_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _552_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out197;
                  _out197 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _552_tpeGen = _out197;
                  Dafny.ISequence<Dafny.Rune> _553_recursiveGen;
                  bool _554_recOwned;
                  bool _555_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _556_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out198;
                  bool _out199;
                  bool _out200;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out198, out _out199, out _out200, out _out201);
                  _553_recursiveGen = _out198;
                  _554_recOwned = _out199;
                  _555_recErased = _out200;
                  _556_recIdents = _out201;
                  Dafny.ISequence<Dafny.Rune> _557_uneraseFn;
                  _557_uneraseFn = ((_554_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _552_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _557_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _553_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _554_recOwned;
                  isErased = false;
                  readIdents = _556_recIdents;
                }
              }
            } else if (_source29.is_Tuple) {
              Dafny.ISequence<DAST._IType> _558___mcc_h181 = _source29.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _559_recursiveGen;
                bool _560_recOwned;
                bool _561_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _562_recIdents;
                Dafny.ISequence<Dafny.Rune> _out202;
                bool _out203;
                bool _out204;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out202, out _out203, out _out204, out _out205);
                _559_recursiveGen = _out202;
                _560_recOwned = _out203;
                _561_recErased = _out204;
                _562_recIdents = _out205;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _559_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _560_recOwned;
                isErased = _561_recErased;
                readIdents = _562_recIdents;
              }
            } else if (_source29.is_Array) {
              DAST._IType _563___mcc_h183 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _564_recursiveGen;
                bool _565_recOwned;
                bool _566_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _567_recIdents;
                Dafny.ISequence<Dafny.Rune> _out206;
                bool _out207;
                bool _out208;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out206, out _out207, out _out208, out _out209);
                _564_recursiveGen = _out206;
                _565_recOwned = _out207;
                _566_recErased = _out208;
                _567_recIdents = _out209;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _564_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _565_recOwned;
                isErased = _566_recErased;
                readIdents = _567_recIdents;
              }
            } else if (_source29.is_Seq) {
              DAST._IType _568___mcc_h185 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _569_recursiveGen;
                bool _570_recOwned;
                bool _571_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _572_recIdents;
                Dafny.ISequence<Dafny.Rune> _out210;
                bool _out211;
                bool _out212;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out210, out _out211, out _out212, out _out213);
                _569_recursiveGen = _out210;
                _570_recOwned = _out211;
                _571_recErased = _out212;
                _572_recIdents = _out213;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _569_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _570_recOwned;
                isErased = _571_recErased;
                readIdents = _572_recIdents;
              }
            } else if (_source29.is_Set) {
              DAST._IType _573___mcc_h187 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _574_recursiveGen;
                bool _575_recOwned;
                bool _576_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _577_recIdents;
                Dafny.ISequence<Dafny.Rune> _out214;
                bool _out215;
                bool _out216;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out214, out _out215, out _out216, out _out217);
                _574_recursiveGen = _out214;
                _575_recOwned = _out215;
                _576_recErased = _out216;
                _577_recIdents = _out217;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _574_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _575_recOwned;
                isErased = _576_recErased;
                readIdents = _577_recIdents;
              }
            } else if (_source29.is_Multiset) {
              DAST._IType _578___mcc_h189 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _579_recursiveGen;
                bool _580_recOwned;
                bool _581_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _582_recIdents;
                Dafny.ISequence<Dafny.Rune> _out218;
                bool _out219;
                bool _out220;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out218, out _out219, out _out220, out _out221);
                _579_recursiveGen = _out218;
                _580_recOwned = _out219;
                _581_recErased = _out220;
                _582_recIdents = _out221;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _579_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _580_recOwned;
                isErased = _581_recErased;
                readIdents = _582_recIdents;
              }
            } else if (_source29.is_Map) {
              DAST._IType _583___mcc_h191 = _source29.dtor_key;
              DAST._IType _584___mcc_h192 = _source29.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _585_recursiveGen;
                bool _586_recOwned;
                bool _587_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _588_recIdents;
                Dafny.ISequence<Dafny.Rune> _out222;
                bool _out223;
                bool _out224;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out222, out _out223, out _out224, out _out225);
                _585_recursiveGen = _out222;
                _586_recOwned = _out223;
                _587_recErased = _out224;
                _588_recIdents = _out225;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _585_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _586_recOwned;
                isErased = _587_recErased;
                readIdents = _588_recIdents;
              }
            } else if (_source29.is_Arrow) {
              Dafny.ISequence<DAST._IType> _589___mcc_h195 = _source29.dtor_args;
              DAST._IType _590___mcc_h196 = _source29.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _591_recursiveGen;
                bool _592_recOwned;
                bool _593_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _594_recIdents;
                Dafny.ISequence<Dafny.Rune> _out226;
                bool _out227;
                bool _out228;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out229;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out226, out _out227, out _out228, out _out229);
                _591_recursiveGen = _out226;
                _592_recOwned = _out227;
                _593_recErased = _out228;
                _594_recIdents = _out229;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _592_recOwned;
                isErased = _593_recErased;
                readIdents = _594_recIdents;
              }
            } else if (_source29.is_Primitive) {
              DAST._IPrimitive _595___mcc_h199 = _source29.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _596_recursiveGen;
                bool _597_recOwned;
                bool _598_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _599_recIdents;
                Dafny.ISequence<Dafny.Rune> _out230;
                bool _out231;
                bool _out232;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out233;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out230, out _out231, out _out232, out _out233);
                _596_recursiveGen = _out230;
                _597_recOwned = _out231;
                _598_recErased = _out232;
                _599_recIdents = _out233;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _597_recOwned;
                isErased = _598_recErased;
                readIdents = _599_recIdents;
              }
            } else if (_source29.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _600___mcc_h201 = _source29.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _601_recursiveGen;
                bool _602_recOwned;
                bool _603_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _604_recIdents;
                Dafny.ISequence<Dafny.Rune> _out234;
                bool _out235;
                bool _out236;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out237;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out234, out _out235, out _out236, out _out237);
                _601_recursiveGen = _out234;
                _602_recOwned = _out235;
                _603_recErased = _out236;
                _604_recIdents = _out237;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _601_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _602_recOwned;
                isErased = _603_recErased;
                readIdents = _604_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _605___mcc_h203 = _source29.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _606_recursiveGen;
                bool _607_recOwned;
                bool _608_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _609_recIdents;
                Dafny.ISequence<Dafny.Rune> _out238;
                bool _out239;
                bool _out240;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out241;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out238, out _out239, out _out240, out _out241);
                _606_recursiveGen = _out238;
                _607_recOwned = _out239;
                _608_recErased = _out240;
                _609_recIdents = _out241;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _606_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _607_recOwned;
                isErased = _608_recErased;
                readIdents = _609_recIdents;
              }
            }
          } else if (_source26.is_Array) {
            DAST._IType _610___mcc_h205 = _source26.dtor_element;
            DAST._IType _source31 = _463___mcc_h122;
            if (_source31.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _611___mcc_h208 = _source31.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _612___mcc_h209 = _source31.dtor_typeArgs;
              DAST._IResolvedType _613___mcc_h210 = _source31.dtor_resolved;
              DAST._IResolvedType _source32 = _613___mcc_h210;
              if (_source32.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _614___mcc_h214 = _source32.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _615_recursiveGen;
                  bool _616_recOwned;
                  bool _617_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _618_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out242;
                  bool _out243;
                  bool _out244;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out245;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out242, out _out243, out _out244, out _out245);
                  _615_recursiveGen = _out242;
                  _616_recOwned = _out243;
                  _617_recErased = _out244;
                  _618_recIdents = _out245;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _615_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _616_recOwned;
                  isErased = _617_recErased;
                  readIdents = _618_recIdents;
                }
              } else if (_source32.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _619___mcc_h216 = _source32.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _620_recursiveGen;
                  bool _621_recOwned;
                  bool _622_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _623_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out246;
                  bool _out247;
                  bool _out248;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out249;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out246, out _out247, out _out248, out _out249);
                  _620_recursiveGen = _out246;
                  _621_recOwned = _out247;
                  _622_recErased = _out248;
                  _623_recIdents = _out249;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _620_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _621_recOwned;
                  isErased = _622_recErased;
                  readIdents = _623_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _624_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out250;
                  _out250 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _624_tpeGen = _out250;
                  Dafny.ISequence<Dafny.Rune> _625_recursiveGen;
                  bool _626_recOwned;
                  bool _627_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _628_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out251;
                  bool _out252;
                  bool _out253;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out251, out _out252, out _out253, out _out254);
                  _625_recursiveGen = _out251;
                  _626_recOwned = _out252;
                  _627_recErased = _out253;
                  _628_recIdents = _out254;
                  Dafny.ISequence<Dafny.Rune> _629_uneraseFn;
                  _629_uneraseFn = ((_626_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _624_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _629_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _625_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _626_recOwned;
                  isErased = false;
                  readIdents = _628_recIdents;
                }
              }
            } else if (_source31.is_Tuple) {
              Dafny.ISequence<DAST._IType> _630___mcc_h218 = _source31.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _631_recursiveGen;
                bool _632_recOwned;
                bool _633_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _634_recIdents;
                Dafny.ISequence<Dafny.Rune> _out255;
                bool _out256;
                bool _out257;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out255, out _out256, out _out257, out _out258);
                _631_recursiveGen = _out255;
                _632_recOwned = _out256;
                _633_recErased = _out257;
                _634_recIdents = _out258;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _632_recOwned;
                isErased = _633_recErased;
                readIdents = _634_recIdents;
              }
            } else if (_source31.is_Array) {
              DAST._IType _635___mcc_h220 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _636_recursiveGen;
                bool _637_recOwned;
                bool _638_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _639_recIdents;
                Dafny.ISequence<Dafny.Rune> _out259;
                bool _out260;
                bool _out261;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out259, out _out260, out _out261, out _out262);
                _636_recursiveGen = _out259;
                _637_recOwned = _out260;
                _638_recErased = _out261;
                _639_recIdents = _out262;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _637_recOwned;
                isErased = _638_recErased;
                readIdents = _639_recIdents;
              }
            } else if (_source31.is_Seq) {
              DAST._IType _640___mcc_h222 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _641_recursiveGen;
                bool _642_recOwned;
                bool _643_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _644_recIdents;
                Dafny.ISequence<Dafny.Rune> _out263;
                bool _out264;
                bool _out265;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out263, out _out264, out _out265, out _out266);
                _641_recursiveGen = _out263;
                _642_recOwned = _out264;
                _643_recErased = _out265;
                _644_recIdents = _out266;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _641_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _642_recOwned;
                isErased = _643_recErased;
                readIdents = _644_recIdents;
              }
            } else if (_source31.is_Set) {
              DAST._IType _645___mcc_h224 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _646_recursiveGen;
                bool _647_recOwned;
                bool _648_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _649_recIdents;
                Dafny.ISequence<Dafny.Rune> _out267;
                bool _out268;
                bool _out269;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out267, out _out268, out _out269, out _out270);
                _646_recursiveGen = _out267;
                _647_recOwned = _out268;
                _648_recErased = _out269;
                _649_recIdents = _out270;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _646_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _647_recOwned;
                isErased = _648_recErased;
                readIdents = _649_recIdents;
              }
            } else if (_source31.is_Multiset) {
              DAST._IType _650___mcc_h226 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _651_recursiveGen;
                bool _652_recOwned;
                bool _653_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _654_recIdents;
                Dafny.ISequence<Dafny.Rune> _out271;
                bool _out272;
                bool _out273;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out271, out _out272, out _out273, out _out274);
                _651_recursiveGen = _out271;
                _652_recOwned = _out272;
                _653_recErased = _out273;
                _654_recIdents = _out274;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _651_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _652_recOwned;
                isErased = _653_recErased;
                readIdents = _654_recIdents;
              }
            } else if (_source31.is_Map) {
              DAST._IType _655___mcc_h228 = _source31.dtor_key;
              DAST._IType _656___mcc_h229 = _source31.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _657_recursiveGen;
                bool _658_recOwned;
                bool _659_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _660_recIdents;
                Dafny.ISequence<Dafny.Rune> _out275;
                bool _out276;
                bool _out277;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out275, out _out276, out _out277, out _out278);
                _657_recursiveGen = _out275;
                _658_recOwned = _out276;
                _659_recErased = _out277;
                _660_recIdents = _out278;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _657_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _658_recOwned;
                isErased = _659_recErased;
                readIdents = _660_recIdents;
              }
            } else if (_source31.is_Arrow) {
              Dafny.ISequence<DAST._IType> _661___mcc_h232 = _source31.dtor_args;
              DAST._IType _662___mcc_h233 = _source31.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _663_recursiveGen;
                bool _664_recOwned;
                bool _665_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _666_recIdents;
                Dafny.ISequence<Dafny.Rune> _out279;
                bool _out280;
                bool _out281;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out279, out _out280, out _out281, out _out282);
                _663_recursiveGen = _out279;
                _664_recOwned = _out280;
                _665_recErased = _out281;
                _666_recIdents = _out282;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _663_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _664_recOwned;
                isErased = _665_recErased;
                readIdents = _666_recIdents;
              }
            } else if (_source31.is_Primitive) {
              DAST._IPrimitive _667___mcc_h236 = _source31.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _668_recursiveGen;
                bool _669_recOwned;
                bool _670_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _671_recIdents;
                Dafny.ISequence<Dafny.Rune> _out283;
                bool _out284;
                bool _out285;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out283, out _out284, out _out285, out _out286);
                _668_recursiveGen = _out283;
                _669_recOwned = _out284;
                _670_recErased = _out285;
                _671_recIdents = _out286;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _668_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _669_recOwned;
                isErased = _670_recErased;
                readIdents = _671_recIdents;
              }
            } else if (_source31.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _672___mcc_h238 = _source31.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _673_recursiveGen;
                bool _674_recOwned;
                bool _675_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _676_recIdents;
                Dafny.ISequence<Dafny.Rune> _out287;
                bool _out288;
                bool _out289;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out287, out _out288, out _out289, out _out290);
                _673_recursiveGen = _out287;
                _674_recOwned = _out288;
                _675_recErased = _out289;
                _676_recIdents = _out290;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _673_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _674_recOwned;
                isErased = _675_recErased;
                readIdents = _676_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _677___mcc_h240 = _source31.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _678_recursiveGen;
                bool _679_recOwned;
                bool _680_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _681_recIdents;
                Dafny.ISequence<Dafny.Rune> _out291;
                bool _out292;
                bool _out293;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out291, out _out292, out _out293, out _out294);
                _678_recursiveGen = _out291;
                _679_recOwned = _out292;
                _680_recErased = _out293;
                _681_recIdents = _out294;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _678_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _679_recOwned;
                isErased = _680_recErased;
                readIdents = _681_recIdents;
              }
            }
          } else if (_source26.is_Seq) {
            DAST._IType _682___mcc_h242 = _source26.dtor_element;
            DAST._IType _source33 = _463___mcc_h122;
            if (_source33.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _683___mcc_h245 = _source33.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _684___mcc_h246 = _source33.dtor_typeArgs;
              DAST._IResolvedType _685___mcc_h247 = _source33.dtor_resolved;
              DAST._IResolvedType _source34 = _685___mcc_h247;
              if (_source34.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _686___mcc_h251 = _source34.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _687_recursiveGen;
                  bool _688_recOwned;
                  bool _689_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _690_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out295;
                  bool _out296;
                  bool _out297;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out298;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out295, out _out296, out _out297, out _out298);
                  _687_recursiveGen = _out295;
                  _688_recOwned = _out296;
                  _689_recErased = _out297;
                  _690_recIdents = _out298;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _687_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _688_recOwned;
                  isErased = _689_recErased;
                  readIdents = _690_recIdents;
                }
              } else if (_source34.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _691___mcc_h253 = _source34.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _692_recursiveGen;
                  bool _693_recOwned;
                  bool _694_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _695_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out299;
                  bool _out300;
                  bool _out301;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out302;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out299, out _out300, out _out301, out _out302);
                  _692_recursiveGen = _out299;
                  _693_recOwned = _out300;
                  _694_recErased = _out301;
                  _695_recIdents = _out302;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _692_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _693_recOwned;
                  isErased = _694_recErased;
                  readIdents = _695_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _696_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out303;
                  _out303 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _696_tpeGen = _out303;
                  Dafny.ISequence<Dafny.Rune> _697_recursiveGen;
                  bool _698_recOwned;
                  bool _699_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _700_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out304;
                  bool _out305;
                  bool _out306;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out304, out _out305, out _out306, out _out307);
                  _697_recursiveGen = _out304;
                  _698_recOwned = _out305;
                  _699_recErased = _out306;
                  _700_recIdents = _out307;
                  Dafny.ISequence<Dafny.Rune> _701_uneraseFn;
                  _701_uneraseFn = ((_698_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _696_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _701_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _697_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _698_recOwned;
                  isErased = false;
                  readIdents = _700_recIdents;
                }
              }
            } else if (_source33.is_Tuple) {
              Dafny.ISequence<DAST._IType> _702___mcc_h255 = _source33.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _703_recursiveGen;
                bool _704_recOwned;
                bool _705_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _706_recIdents;
                Dafny.ISequence<Dafny.Rune> _out308;
                bool _out309;
                bool _out310;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out308, out _out309, out _out310, out _out311);
                _703_recursiveGen = _out308;
                _704_recOwned = _out309;
                _705_recErased = _out310;
                _706_recIdents = _out311;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _704_recOwned;
                isErased = _705_recErased;
                readIdents = _706_recIdents;
              }
            } else if (_source33.is_Array) {
              DAST._IType _707___mcc_h257 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _708_recursiveGen;
                bool _709_recOwned;
                bool _710_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _711_recIdents;
                Dafny.ISequence<Dafny.Rune> _out312;
                bool _out313;
                bool _out314;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out312, out _out313, out _out314, out _out315);
                _708_recursiveGen = _out312;
                _709_recOwned = _out313;
                _710_recErased = _out314;
                _711_recIdents = _out315;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _708_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _709_recOwned;
                isErased = _710_recErased;
                readIdents = _711_recIdents;
              }
            } else if (_source33.is_Seq) {
              DAST._IType _712___mcc_h259 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _713_recursiveGen;
                bool _714_recOwned;
                bool _715_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _716_recIdents;
                Dafny.ISequence<Dafny.Rune> _out316;
                bool _out317;
                bool _out318;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out316, out _out317, out _out318, out _out319);
                _713_recursiveGen = _out316;
                _714_recOwned = _out317;
                _715_recErased = _out318;
                _716_recIdents = _out319;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _713_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _714_recOwned;
                isErased = _715_recErased;
                readIdents = _716_recIdents;
              }
            } else if (_source33.is_Set) {
              DAST._IType _717___mcc_h261 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _718_recursiveGen;
                bool _719_recOwned;
                bool _720_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _721_recIdents;
                Dafny.ISequence<Dafny.Rune> _out320;
                bool _out321;
                bool _out322;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out320, out _out321, out _out322, out _out323);
                _718_recursiveGen = _out320;
                _719_recOwned = _out321;
                _720_recErased = _out322;
                _721_recIdents = _out323;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _719_recOwned;
                isErased = _720_recErased;
                readIdents = _721_recIdents;
              }
            } else if (_source33.is_Multiset) {
              DAST._IType _722___mcc_h263 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _723_recursiveGen;
                bool _724_recOwned;
                bool _725_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _726_recIdents;
                Dafny.ISequence<Dafny.Rune> _out324;
                bool _out325;
                bool _out326;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out324, out _out325, out _out326, out _out327);
                _723_recursiveGen = _out324;
                _724_recOwned = _out325;
                _725_recErased = _out326;
                _726_recIdents = _out327;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _724_recOwned;
                isErased = _725_recErased;
                readIdents = _726_recIdents;
              }
            } else if (_source33.is_Map) {
              DAST._IType _727___mcc_h265 = _source33.dtor_key;
              DAST._IType _728___mcc_h266 = _source33.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _729_recursiveGen;
                bool _730_recOwned;
                bool _731_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _732_recIdents;
                Dafny.ISequence<Dafny.Rune> _out328;
                bool _out329;
                bool _out330;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out328, out _out329, out _out330, out _out331);
                _729_recursiveGen = _out328;
                _730_recOwned = _out329;
                _731_recErased = _out330;
                _732_recIdents = _out331;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _729_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _730_recOwned;
                isErased = _731_recErased;
                readIdents = _732_recIdents;
              }
            } else if (_source33.is_Arrow) {
              Dafny.ISequence<DAST._IType> _733___mcc_h269 = _source33.dtor_args;
              DAST._IType _734___mcc_h270 = _source33.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _735_recursiveGen;
                bool _736_recOwned;
                bool _737_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _738_recIdents;
                Dafny.ISequence<Dafny.Rune> _out332;
                bool _out333;
                bool _out334;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out332, out _out333, out _out334, out _out335);
                _735_recursiveGen = _out332;
                _736_recOwned = _out333;
                _737_recErased = _out334;
                _738_recIdents = _out335;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _736_recOwned;
                isErased = _737_recErased;
                readIdents = _738_recIdents;
              }
            } else if (_source33.is_Primitive) {
              DAST._IPrimitive _739___mcc_h273 = _source33.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _740_recursiveGen;
                bool _741_recOwned;
                bool _742_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _743_recIdents;
                Dafny.ISequence<Dafny.Rune> _out336;
                bool _out337;
                bool _out338;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out336, out _out337, out _out338, out _out339);
                _740_recursiveGen = _out336;
                _741_recOwned = _out337;
                _742_recErased = _out338;
                _743_recIdents = _out339;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _740_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _741_recOwned;
                isErased = _742_recErased;
                readIdents = _743_recIdents;
              }
            } else if (_source33.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _744___mcc_h275 = _source33.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _745_recursiveGen;
                bool _746_recOwned;
                bool _747_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _748_recIdents;
                Dafny.ISequence<Dafny.Rune> _out340;
                bool _out341;
                bool _out342;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out340, out _out341, out _out342, out _out343);
                _745_recursiveGen = _out340;
                _746_recOwned = _out341;
                _747_recErased = _out342;
                _748_recIdents = _out343;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _745_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _746_recOwned;
                isErased = _747_recErased;
                readIdents = _748_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _749___mcc_h277 = _source33.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _750_recursiveGen;
                bool _751_recOwned;
                bool _752_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _753_recIdents;
                Dafny.ISequence<Dafny.Rune> _out344;
                bool _out345;
                bool _out346;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out344, out _out345, out _out346, out _out347);
                _750_recursiveGen = _out344;
                _751_recOwned = _out345;
                _752_recErased = _out346;
                _753_recIdents = _out347;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _750_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _751_recOwned;
                isErased = _752_recErased;
                readIdents = _753_recIdents;
              }
            }
          } else if (_source26.is_Set) {
            DAST._IType _754___mcc_h279 = _source26.dtor_element;
            DAST._IType _source35 = _463___mcc_h122;
            if (_source35.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _755___mcc_h282 = _source35.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _756___mcc_h283 = _source35.dtor_typeArgs;
              DAST._IResolvedType _757___mcc_h284 = _source35.dtor_resolved;
              DAST._IResolvedType _source36 = _757___mcc_h284;
              if (_source36.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _758___mcc_h288 = _source36.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _759_recursiveGen;
                  bool _760_recOwned;
                  bool _761_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _762_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out348;
                  bool _out349;
                  bool _out350;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out348, out _out349, out _out350, out _out351);
                  _759_recursiveGen = _out348;
                  _760_recOwned = _out349;
                  _761_recErased = _out350;
                  _762_recIdents = _out351;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _760_recOwned;
                  isErased = _761_recErased;
                  readIdents = _762_recIdents;
                }
              } else if (_source36.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _763___mcc_h290 = _source36.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _764_recursiveGen;
                  bool _765_recOwned;
                  bool _766_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _767_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out352;
                  bool _out353;
                  bool _out354;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out352, out _out353, out _out354, out _out355);
                  _764_recursiveGen = _out352;
                  _765_recOwned = _out353;
                  _766_recErased = _out354;
                  _767_recIdents = _out355;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _764_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _765_recOwned;
                  isErased = _766_recErased;
                  readIdents = _767_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _768_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out356;
                  _out356 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _768_tpeGen = _out356;
                  Dafny.ISequence<Dafny.Rune> _769_recursiveGen;
                  bool _770_recOwned;
                  bool _771_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _772_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out357;
                  bool _out358;
                  bool _out359;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out357, out _out358, out _out359, out _out360);
                  _769_recursiveGen = _out357;
                  _770_recOwned = _out358;
                  _771_recErased = _out359;
                  _772_recIdents = _out360;
                  Dafny.ISequence<Dafny.Rune> _773_uneraseFn;
                  _773_uneraseFn = ((_770_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _768_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _773_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _769_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _770_recOwned;
                  isErased = false;
                  readIdents = _772_recIdents;
                }
              }
            } else if (_source35.is_Tuple) {
              Dafny.ISequence<DAST._IType> _774___mcc_h292 = _source35.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _775_recursiveGen;
                bool _776_recOwned;
                bool _777_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _778_recIdents;
                Dafny.ISequence<Dafny.Rune> _out361;
                bool _out362;
                bool _out363;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out361, out _out362, out _out363, out _out364);
                _775_recursiveGen = _out361;
                _776_recOwned = _out362;
                _777_recErased = _out363;
                _778_recIdents = _out364;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _775_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _776_recOwned;
                isErased = _777_recErased;
                readIdents = _778_recIdents;
              }
            } else if (_source35.is_Array) {
              DAST._IType _779___mcc_h294 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _780_recursiveGen;
                bool _781_recOwned;
                bool _782_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _783_recIdents;
                Dafny.ISequence<Dafny.Rune> _out365;
                bool _out366;
                bool _out367;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out365, out _out366, out _out367, out _out368);
                _780_recursiveGen = _out365;
                _781_recOwned = _out366;
                _782_recErased = _out367;
                _783_recIdents = _out368;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _780_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _781_recOwned;
                isErased = _782_recErased;
                readIdents = _783_recIdents;
              }
            } else if (_source35.is_Seq) {
              DAST._IType _784___mcc_h296 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _785_recursiveGen;
                bool _786_recOwned;
                bool _787_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _788_recIdents;
                Dafny.ISequence<Dafny.Rune> _out369;
                bool _out370;
                bool _out371;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out369, out _out370, out _out371, out _out372);
                _785_recursiveGen = _out369;
                _786_recOwned = _out370;
                _787_recErased = _out371;
                _788_recIdents = _out372;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _785_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _786_recOwned;
                isErased = _787_recErased;
                readIdents = _788_recIdents;
              }
            } else if (_source35.is_Set) {
              DAST._IType _789___mcc_h298 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _790_recursiveGen;
                bool _791_recOwned;
                bool _792_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _793_recIdents;
                Dafny.ISequence<Dafny.Rune> _out373;
                bool _out374;
                bool _out375;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out376;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out373, out _out374, out _out375, out _out376);
                _790_recursiveGen = _out373;
                _791_recOwned = _out374;
                _792_recErased = _out375;
                _793_recIdents = _out376;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _790_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _791_recOwned;
                isErased = _792_recErased;
                readIdents = _793_recIdents;
              }
            } else if (_source35.is_Multiset) {
              DAST._IType _794___mcc_h300 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _795_recursiveGen;
                bool _796_recOwned;
                bool _797_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _798_recIdents;
                Dafny.ISequence<Dafny.Rune> _out377;
                bool _out378;
                bool _out379;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out380;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out377, out _out378, out _out379, out _out380);
                _795_recursiveGen = _out377;
                _796_recOwned = _out378;
                _797_recErased = _out379;
                _798_recIdents = _out380;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _795_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _796_recOwned;
                isErased = _797_recErased;
                readIdents = _798_recIdents;
              }
            } else if (_source35.is_Map) {
              DAST._IType _799___mcc_h302 = _source35.dtor_key;
              DAST._IType _800___mcc_h303 = _source35.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _801_recursiveGen;
                bool _802_recOwned;
                bool _803_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _804_recIdents;
                Dafny.ISequence<Dafny.Rune> _out381;
                bool _out382;
                bool _out383;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out384;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out381, out _out382, out _out383, out _out384);
                _801_recursiveGen = _out381;
                _802_recOwned = _out382;
                _803_recErased = _out383;
                _804_recIdents = _out384;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _801_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _802_recOwned;
                isErased = _803_recErased;
                readIdents = _804_recIdents;
              }
            } else if (_source35.is_Arrow) {
              Dafny.ISequence<DAST._IType> _805___mcc_h306 = _source35.dtor_args;
              DAST._IType _806___mcc_h307 = _source35.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _807_recursiveGen;
                bool _808_recOwned;
                bool _809_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _810_recIdents;
                Dafny.ISequence<Dafny.Rune> _out385;
                bool _out386;
                bool _out387;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out388;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out385, out _out386, out _out387, out _out388);
                _807_recursiveGen = _out385;
                _808_recOwned = _out386;
                _809_recErased = _out387;
                _810_recIdents = _out388;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _807_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _808_recOwned;
                isErased = _809_recErased;
                readIdents = _810_recIdents;
              }
            } else if (_source35.is_Primitive) {
              DAST._IPrimitive _811___mcc_h310 = _source35.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _812_recursiveGen;
                bool _813_recOwned;
                bool _814_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _815_recIdents;
                Dafny.ISequence<Dafny.Rune> _out389;
                bool _out390;
                bool _out391;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out392;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out389, out _out390, out _out391, out _out392);
                _812_recursiveGen = _out389;
                _813_recOwned = _out390;
                _814_recErased = _out391;
                _815_recIdents = _out392;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _812_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _813_recOwned;
                isErased = _814_recErased;
                readIdents = _815_recIdents;
              }
            } else if (_source35.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _816___mcc_h312 = _source35.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _817_recursiveGen;
                bool _818_recOwned;
                bool _819_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _820_recIdents;
                Dafny.ISequence<Dafny.Rune> _out393;
                bool _out394;
                bool _out395;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out396;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out393, out _out394, out _out395, out _out396);
                _817_recursiveGen = _out393;
                _818_recOwned = _out394;
                _819_recErased = _out395;
                _820_recIdents = _out396;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _817_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _818_recOwned;
                isErased = _819_recErased;
                readIdents = _820_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _821___mcc_h314 = _source35.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _822_recursiveGen;
                bool _823_recOwned;
                bool _824_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _825_recIdents;
                Dafny.ISequence<Dafny.Rune> _out397;
                bool _out398;
                bool _out399;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out400;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out397, out _out398, out _out399, out _out400);
                _822_recursiveGen = _out397;
                _823_recOwned = _out398;
                _824_recErased = _out399;
                _825_recIdents = _out400;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _822_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _823_recOwned;
                isErased = _824_recErased;
                readIdents = _825_recIdents;
              }
            }
          } else if (_source26.is_Multiset) {
            DAST._IType _826___mcc_h316 = _source26.dtor_element;
            DAST._IType _source37 = _463___mcc_h122;
            if (_source37.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _827___mcc_h319 = _source37.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _828___mcc_h320 = _source37.dtor_typeArgs;
              DAST._IResolvedType _829___mcc_h321 = _source37.dtor_resolved;
              DAST._IResolvedType _source38 = _829___mcc_h321;
              if (_source38.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _830___mcc_h325 = _source38.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _831_recursiveGen;
                  bool _832_recOwned;
                  bool _833_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _834_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out401;
                  bool _out402;
                  bool _out403;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out404;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out401, out _out402, out _out403, out _out404);
                  _831_recursiveGen = _out401;
                  _832_recOwned = _out402;
                  _833_recErased = _out403;
                  _834_recIdents = _out404;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _831_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _832_recOwned;
                  isErased = _833_recErased;
                  readIdents = _834_recIdents;
                }
              } else if (_source38.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _835___mcc_h327 = _source38.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _836_recursiveGen;
                  bool _837_recOwned;
                  bool _838_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _839_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out405;
                  bool _out406;
                  bool _out407;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out408;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out405, out _out406, out _out407, out _out408);
                  _836_recursiveGen = _out405;
                  _837_recOwned = _out406;
                  _838_recErased = _out407;
                  _839_recIdents = _out408;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _836_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _837_recOwned;
                  isErased = _838_recErased;
                  readIdents = _839_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _840_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out409;
                  _out409 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _840_tpeGen = _out409;
                  Dafny.ISequence<Dafny.Rune> _841_recursiveGen;
                  bool _842_recOwned;
                  bool _843_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _844_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out410;
                  bool _out411;
                  bool _out412;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out413;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out410, out _out411, out _out412, out _out413);
                  _841_recursiveGen = _out410;
                  _842_recOwned = _out411;
                  _843_recErased = _out412;
                  _844_recIdents = _out413;
                  Dafny.ISequence<Dafny.Rune> _845_uneraseFn;
                  _845_uneraseFn = ((_842_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _840_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _845_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _841_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _842_recOwned;
                  isErased = false;
                  readIdents = _844_recIdents;
                }
              }
            } else if (_source37.is_Tuple) {
              Dafny.ISequence<DAST._IType> _846___mcc_h329 = _source37.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _847_recursiveGen;
                bool _848_recOwned;
                bool _849_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _850_recIdents;
                Dafny.ISequence<Dafny.Rune> _out414;
                bool _out415;
                bool _out416;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out417;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out414, out _out415, out _out416, out _out417);
                _847_recursiveGen = _out414;
                _848_recOwned = _out415;
                _849_recErased = _out416;
                _850_recIdents = _out417;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _847_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _848_recOwned;
                isErased = _849_recErased;
                readIdents = _850_recIdents;
              }
            } else if (_source37.is_Array) {
              DAST._IType _851___mcc_h331 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _852_recursiveGen;
                bool _853_recOwned;
                bool _854_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _855_recIdents;
                Dafny.ISequence<Dafny.Rune> _out418;
                bool _out419;
                bool _out420;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out421;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out418, out _out419, out _out420, out _out421);
                _852_recursiveGen = _out418;
                _853_recOwned = _out419;
                _854_recErased = _out420;
                _855_recIdents = _out421;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _852_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _853_recOwned;
                isErased = _854_recErased;
                readIdents = _855_recIdents;
              }
            } else if (_source37.is_Seq) {
              DAST._IType _856___mcc_h333 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _857_recursiveGen;
                bool _858_recOwned;
                bool _859_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _860_recIdents;
                Dafny.ISequence<Dafny.Rune> _out422;
                bool _out423;
                bool _out424;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out425;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out422, out _out423, out _out424, out _out425);
                _857_recursiveGen = _out422;
                _858_recOwned = _out423;
                _859_recErased = _out424;
                _860_recIdents = _out425;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _857_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _858_recOwned;
                isErased = _859_recErased;
                readIdents = _860_recIdents;
              }
            } else if (_source37.is_Set) {
              DAST._IType _861___mcc_h335 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _862_recursiveGen;
                bool _863_recOwned;
                bool _864_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _865_recIdents;
                Dafny.ISequence<Dafny.Rune> _out426;
                bool _out427;
                bool _out428;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out429;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out426, out _out427, out _out428, out _out429);
                _862_recursiveGen = _out426;
                _863_recOwned = _out427;
                _864_recErased = _out428;
                _865_recIdents = _out429;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _862_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _863_recOwned;
                isErased = _864_recErased;
                readIdents = _865_recIdents;
              }
            } else if (_source37.is_Multiset) {
              DAST._IType _866___mcc_h337 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _867_recursiveGen;
                bool _868_recOwned;
                bool _869_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _870_recIdents;
                Dafny.ISequence<Dafny.Rune> _out430;
                bool _out431;
                bool _out432;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out433;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out430, out _out431, out _out432, out _out433);
                _867_recursiveGen = _out430;
                _868_recOwned = _out431;
                _869_recErased = _out432;
                _870_recIdents = _out433;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _867_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _868_recOwned;
                isErased = _869_recErased;
                readIdents = _870_recIdents;
              }
            } else if (_source37.is_Map) {
              DAST._IType _871___mcc_h339 = _source37.dtor_key;
              DAST._IType _872___mcc_h340 = _source37.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _873_recursiveGen;
                bool _874_recOwned;
                bool _875_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _876_recIdents;
                Dafny.ISequence<Dafny.Rune> _out434;
                bool _out435;
                bool _out436;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out437;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out434, out _out435, out _out436, out _out437);
                _873_recursiveGen = _out434;
                _874_recOwned = _out435;
                _875_recErased = _out436;
                _876_recIdents = _out437;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _874_recOwned;
                isErased = _875_recErased;
                readIdents = _876_recIdents;
              }
            } else if (_source37.is_Arrow) {
              Dafny.ISequence<DAST._IType> _877___mcc_h343 = _source37.dtor_args;
              DAST._IType _878___mcc_h344 = _source37.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _879_recursiveGen;
                bool _880_recOwned;
                bool _881_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _882_recIdents;
                Dafny.ISequence<Dafny.Rune> _out438;
                bool _out439;
                bool _out440;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out441;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out438, out _out439, out _out440, out _out441);
                _879_recursiveGen = _out438;
                _880_recOwned = _out439;
                _881_recErased = _out440;
                _882_recIdents = _out441;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _879_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _880_recOwned;
                isErased = _881_recErased;
                readIdents = _882_recIdents;
              }
            } else if (_source37.is_Primitive) {
              DAST._IPrimitive _883___mcc_h347 = _source37.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _884_recursiveGen;
                bool _885_recOwned;
                bool _886_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _887_recIdents;
                Dafny.ISequence<Dafny.Rune> _out442;
                bool _out443;
                bool _out444;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out445;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out442, out _out443, out _out444, out _out445);
                _884_recursiveGen = _out442;
                _885_recOwned = _out443;
                _886_recErased = _out444;
                _887_recIdents = _out445;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _884_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _885_recOwned;
                isErased = _886_recErased;
                readIdents = _887_recIdents;
              }
            } else if (_source37.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _888___mcc_h349 = _source37.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _889_recursiveGen;
                bool _890_recOwned;
                bool _891_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _892_recIdents;
                Dafny.ISequence<Dafny.Rune> _out446;
                bool _out447;
                bool _out448;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out449;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out446, out _out447, out _out448, out _out449);
                _889_recursiveGen = _out446;
                _890_recOwned = _out447;
                _891_recErased = _out448;
                _892_recIdents = _out449;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _889_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _890_recOwned;
                isErased = _891_recErased;
                readIdents = _892_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _893___mcc_h351 = _source37.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _894_recursiveGen;
                bool _895_recOwned;
                bool _896_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _897_recIdents;
                Dafny.ISequence<Dafny.Rune> _out450;
                bool _out451;
                bool _out452;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out453;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out450, out _out451, out _out452, out _out453);
                _894_recursiveGen = _out450;
                _895_recOwned = _out451;
                _896_recErased = _out452;
                _897_recIdents = _out453;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _894_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _895_recOwned;
                isErased = _896_recErased;
                readIdents = _897_recIdents;
              }
            }
          } else if (_source26.is_Map) {
            DAST._IType _898___mcc_h353 = _source26.dtor_key;
            DAST._IType _899___mcc_h354 = _source26.dtor_value;
            DAST._IType _source39 = _463___mcc_h122;
            if (_source39.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _900___mcc_h359 = _source39.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _901___mcc_h360 = _source39.dtor_typeArgs;
              DAST._IResolvedType _902___mcc_h361 = _source39.dtor_resolved;
              DAST._IResolvedType _source40 = _902___mcc_h361;
              if (_source40.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _903___mcc_h365 = _source40.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _904_recursiveGen;
                  bool _905_recOwned;
                  bool _906_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _907_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out454;
                  bool _out455;
                  bool _out456;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out457;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out454, out _out455, out _out456, out _out457);
                  _904_recursiveGen = _out454;
                  _905_recOwned = _out455;
                  _906_recErased = _out456;
                  _907_recIdents = _out457;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _904_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _905_recOwned;
                  isErased = _906_recErased;
                  readIdents = _907_recIdents;
                }
              } else if (_source40.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _908___mcc_h367 = _source40.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _909_recursiveGen;
                  bool _910_recOwned;
                  bool _911_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _912_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out458;
                  bool _out459;
                  bool _out460;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out461;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out458, out _out459, out _out460, out _out461);
                  _909_recursiveGen = _out458;
                  _910_recOwned = _out459;
                  _911_recErased = _out460;
                  _912_recIdents = _out461;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _909_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _910_recOwned;
                  isErased = _911_recErased;
                  readIdents = _912_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _913_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out462;
                  _out462 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _913_tpeGen = _out462;
                  Dafny.ISequence<Dafny.Rune> _914_recursiveGen;
                  bool _915_recOwned;
                  bool _916_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _917_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out463;
                  bool _out464;
                  bool _out465;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out466;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out463, out _out464, out _out465, out _out466);
                  _914_recursiveGen = _out463;
                  _915_recOwned = _out464;
                  _916_recErased = _out465;
                  _917_recIdents = _out466;
                  Dafny.ISequence<Dafny.Rune> _918_uneraseFn;
                  _918_uneraseFn = ((_915_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _913_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _918_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _914_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _915_recOwned;
                  isErased = false;
                  readIdents = _917_recIdents;
                }
              }
            } else if (_source39.is_Tuple) {
              Dafny.ISequence<DAST._IType> _919___mcc_h369 = _source39.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _920_recursiveGen;
                bool _921_recOwned;
                bool _922_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _923_recIdents;
                Dafny.ISequence<Dafny.Rune> _out467;
                bool _out468;
                bool _out469;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out470;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out467, out _out468, out _out469, out _out470);
                _920_recursiveGen = _out467;
                _921_recOwned = _out468;
                _922_recErased = _out469;
                _923_recIdents = _out470;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _920_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _921_recOwned;
                isErased = _922_recErased;
                readIdents = _923_recIdents;
              }
            } else if (_source39.is_Array) {
              DAST._IType _924___mcc_h371 = _source39.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _925_recursiveGen;
                bool _926_recOwned;
                bool _927_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _928_recIdents;
                Dafny.ISequence<Dafny.Rune> _out471;
                bool _out472;
                bool _out473;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out474;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out471, out _out472, out _out473, out _out474);
                _925_recursiveGen = _out471;
                _926_recOwned = _out472;
                _927_recErased = _out473;
                _928_recIdents = _out474;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _925_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _926_recOwned;
                isErased = _927_recErased;
                readIdents = _928_recIdents;
              }
            } else if (_source39.is_Seq) {
              DAST._IType _929___mcc_h373 = _source39.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _930_recursiveGen;
                bool _931_recOwned;
                bool _932_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _933_recIdents;
                Dafny.ISequence<Dafny.Rune> _out475;
                bool _out476;
                bool _out477;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out478;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out475, out _out476, out _out477, out _out478);
                _930_recursiveGen = _out475;
                _931_recOwned = _out476;
                _932_recErased = _out477;
                _933_recIdents = _out478;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _930_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _931_recOwned;
                isErased = _932_recErased;
                readIdents = _933_recIdents;
              }
            } else if (_source39.is_Set) {
              DAST._IType _934___mcc_h375 = _source39.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _935_recursiveGen;
                bool _936_recOwned;
                bool _937_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _938_recIdents;
                Dafny.ISequence<Dafny.Rune> _out479;
                bool _out480;
                bool _out481;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out482;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out479, out _out480, out _out481, out _out482);
                _935_recursiveGen = _out479;
                _936_recOwned = _out480;
                _937_recErased = _out481;
                _938_recIdents = _out482;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _936_recOwned;
                isErased = _937_recErased;
                readIdents = _938_recIdents;
              }
            } else if (_source39.is_Multiset) {
              DAST._IType _939___mcc_h377 = _source39.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _940_recursiveGen;
                bool _941_recOwned;
                bool _942_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _943_recIdents;
                Dafny.ISequence<Dafny.Rune> _out483;
                bool _out484;
                bool _out485;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out486;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out483, out _out484, out _out485, out _out486);
                _940_recursiveGen = _out483;
                _941_recOwned = _out484;
                _942_recErased = _out485;
                _943_recIdents = _out486;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _940_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _941_recOwned;
                isErased = _942_recErased;
                readIdents = _943_recIdents;
              }
            } else if (_source39.is_Map) {
              DAST._IType _944___mcc_h379 = _source39.dtor_key;
              DAST._IType _945___mcc_h380 = _source39.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _946_recursiveGen;
                bool _947_recOwned;
                bool _948_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _949_recIdents;
                Dafny.ISequence<Dafny.Rune> _out487;
                bool _out488;
                bool _out489;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out490;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out487, out _out488, out _out489, out _out490);
                _946_recursiveGen = _out487;
                _947_recOwned = _out488;
                _948_recErased = _out489;
                _949_recIdents = _out490;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _946_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _947_recOwned;
                isErased = _948_recErased;
                readIdents = _949_recIdents;
              }
            } else if (_source39.is_Arrow) {
              Dafny.ISequence<DAST._IType> _950___mcc_h383 = _source39.dtor_args;
              DAST._IType _951___mcc_h384 = _source39.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _952_recursiveGen;
                bool _953_recOwned;
                bool _954_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _955_recIdents;
                Dafny.ISequence<Dafny.Rune> _out491;
                bool _out492;
                bool _out493;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out494;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out491, out _out492, out _out493, out _out494);
                _952_recursiveGen = _out491;
                _953_recOwned = _out492;
                _954_recErased = _out493;
                _955_recIdents = _out494;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _953_recOwned;
                isErased = _954_recErased;
                readIdents = _955_recIdents;
              }
            } else if (_source39.is_Primitive) {
              DAST._IPrimitive _956___mcc_h387 = _source39.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _957_recursiveGen;
                bool _958_recOwned;
                bool _959_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _960_recIdents;
                Dafny.ISequence<Dafny.Rune> _out495;
                bool _out496;
                bool _out497;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out498;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out495, out _out496, out _out497, out _out498);
                _957_recursiveGen = _out495;
                _958_recOwned = _out496;
                _959_recErased = _out497;
                _960_recIdents = _out498;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _957_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _958_recOwned;
                isErased = _959_recErased;
                readIdents = _960_recIdents;
              }
            } else if (_source39.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _961___mcc_h389 = _source39.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _962_recursiveGen;
                bool _963_recOwned;
                bool _964_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _965_recIdents;
                Dafny.ISequence<Dafny.Rune> _out499;
                bool _out500;
                bool _out501;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out502;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out499, out _out500, out _out501, out _out502);
                _962_recursiveGen = _out499;
                _963_recOwned = _out500;
                _964_recErased = _out501;
                _965_recIdents = _out502;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _962_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _963_recOwned;
                isErased = _964_recErased;
                readIdents = _965_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _966___mcc_h391 = _source39.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _967_recursiveGen;
                bool _968_recOwned;
                bool _969_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _970_recIdents;
                Dafny.ISequence<Dafny.Rune> _out503;
                bool _out504;
                bool _out505;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out506;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out503, out _out504, out _out505, out _out506);
                _967_recursiveGen = _out503;
                _968_recOwned = _out504;
                _969_recErased = _out505;
                _970_recIdents = _out506;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _967_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _968_recOwned;
                isErased = _969_recErased;
                readIdents = _970_recIdents;
              }
            }
          } else if (_source26.is_Arrow) {
            Dafny.ISequence<DAST._IType> _971___mcc_h393 = _source26.dtor_args;
            DAST._IType _972___mcc_h394 = _source26.dtor_result;
            DAST._IType _source41 = _463___mcc_h122;
            if (_source41.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _973___mcc_h399 = _source41.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _974___mcc_h400 = _source41.dtor_typeArgs;
              DAST._IResolvedType _975___mcc_h401 = _source41.dtor_resolved;
              DAST._IResolvedType _source42 = _975___mcc_h401;
              if (_source42.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _976___mcc_h405 = _source42.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _977_recursiveGen;
                  bool _978_recOwned;
                  bool _979_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _980_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out507;
                  bool _out508;
                  bool _out509;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out510;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out507, out _out508, out _out509, out _out510);
                  _977_recursiveGen = _out507;
                  _978_recOwned = _out508;
                  _979_recErased = _out509;
                  _980_recIdents = _out510;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _977_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _978_recOwned;
                  isErased = _979_recErased;
                  readIdents = _980_recIdents;
                }
              } else if (_source42.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _981___mcc_h407 = _source42.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _982_recursiveGen;
                  bool _983_recOwned;
                  bool _984_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _985_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out511;
                  bool _out512;
                  bool _out513;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out514;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out511, out _out512, out _out513, out _out514);
                  _982_recursiveGen = _out511;
                  _983_recOwned = _out512;
                  _984_recErased = _out513;
                  _985_recIdents = _out514;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _982_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _983_recOwned;
                  isErased = _984_recErased;
                  readIdents = _985_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _986_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out515;
                  _out515 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _986_tpeGen = _out515;
                  Dafny.ISequence<Dafny.Rune> _987_recursiveGen;
                  bool _988_recOwned;
                  bool _989_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _990_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out516;
                  bool _out517;
                  bool _out518;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out519;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out516, out _out517, out _out518, out _out519);
                  _987_recursiveGen = _out516;
                  _988_recOwned = _out517;
                  _989_recErased = _out518;
                  _990_recIdents = _out519;
                  Dafny.ISequence<Dafny.Rune> _991_uneraseFn;
                  _991_uneraseFn = ((_988_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _986_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _991_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _987_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _988_recOwned;
                  isErased = false;
                  readIdents = _990_recIdents;
                }
              }
            } else if (_source41.is_Tuple) {
              Dafny.ISequence<DAST._IType> _992___mcc_h409 = _source41.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _993_recursiveGen;
                bool _994_recOwned;
                bool _995_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _996_recIdents;
                Dafny.ISequence<Dafny.Rune> _out520;
                bool _out521;
                bool _out522;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out523;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out520, out _out521, out _out522, out _out523);
                _993_recursiveGen = _out520;
                _994_recOwned = _out521;
                _995_recErased = _out522;
                _996_recIdents = _out523;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _993_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _994_recOwned;
                isErased = _995_recErased;
                readIdents = _996_recIdents;
              }
            } else if (_source41.is_Array) {
              DAST._IType _997___mcc_h411 = _source41.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _998_recursiveGen;
                bool _999_recOwned;
                bool _1000_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1001_recIdents;
                Dafny.ISequence<Dafny.Rune> _out524;
                bool _out525;
                bool _out526;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out527;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out524, out _out525, out _out526, out _out527);
                _998_recursiveGen = _out524;
                _999_recOwned = _out525;
                _1000_recErased = _out526;
                _1001_recIdents = _out527;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _998_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _999_recOwned;
                isErased = _1000_recErased;
                readIdents = _1001_recIdents;
              }
            } else if (_source41.is_Seq) {
              DAST._IType _1002___mcc_h413 = _source41.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1003_recursiveGen;
                bool _1004_recOwned;
                bool _1005_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1006_recIdents;
                Dafny.ISequence<Dafny.Rune> _out528;
                bool _out529;
                bool _out530;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out531;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out528, out _out529, out _out530, out _out531);
                _1003_recursiveGen = _out528;
                _1004_recOwned = _out529;
                _1005_recErased = _out530;
                _1006_recIdents = _out531;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1003_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1004_recOwned;
                isErased = _1005_recErased;
                readIdents = _1006_recIdents;
              }
            } else if (_source41.is_Set) {
              DAST._IType _1007___mcc_h415 = _source41.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1008_recursiveGen;
                bool _1009_recOwned;
                bool _1010_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1011_recIdents;
                Dafny.ISequence<Dafny.Rune> _out532;
                bool _out533;
                bool _out534;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out535;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out532, out _out533, out _out534, out _out535);
                _1008_recursiveGen = _out532;
                _1009_recOwned = _out533;
                _1010_recErased = _out534;
                _1011_recIdents = _out535;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1008_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1009_recOwned;
                isErased = _1010_recErased;
                readIdents = _1011_recIdents;
              }
            } else if (_source41.is_Multiset) {
              DAST._IType _1012___mcc_h417 = _source41.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1013_recursiveGen;
                bool _1014_recOwned;
                bool _1015_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1016_recIdents;
                Dafny.ISequence<Dafny.Rune> _out536;
                bool _out537;
                bool _out538;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out539;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out536, out _out537, out _out538, out _out539);
                _1013_recursiveGen = _out536;
                _1014_recOwned = _out537;
                _1015_recErased = _out538;
                _1016_recIdents = _out539;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1013_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1014_recOwned;
                isErased = _1015_recErased;
                readIdents = _1016_recIdents;
              }
            } else if (_source41.is_Map) {
              DAST._IType _1017___mcc_h419 = _source41.dtor_key;
              DAST._IType _1018___mcc_h420 = _source41.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _1019_recursiveGen;
                bool _1020_recOwned;
                bool _1021_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1022_recIdents;
                Dafny.ISequence<Dafny.Rune> _out540;
                bool _out541;
                bool _out542;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out543;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out540, out _out541, out _out542, out _out543);
                _1019_recursiveGen = _out540;
                _1020_recOwned = _out541;
                _1021_recErased = _out542;
                _1022_recIdents = _out543;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1019_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1020_recOwned;
                isErased = _1021_recErased;
                readIdents = _1022_recIdents;
              }
            } else if (_source41.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1023___mcc_h423 = _source41.dtor_args;
              DAST._IType _1024___mcc_h424 = _source41.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _1025_recursiveGen;
                bool _1026_recOwned;
                bool _1027_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1028_recIdents;
                Dafny.ISequence<Dafny.Rune> _out544;
                bool _out545;
                bool _out546;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out547;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out544, out _out545, out _out546, out _out547);
                _1025_recursiveGen = _out544;
                _1026_recOwned = _out545;
                _1027_recErased = _out546;
                _1028_recIdents = _out547;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1026_recOwned;
                isErased = _1027_recErased;
                readIdents = _1028_recIdents;
              }
            } else if (_source41.is_Primitive) {
              DAST._IPrimitive _1029___mcc_h427 = _source41.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1030_recursiveGen;
                bool _1031_recOwned;
                bool _1032_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1033_recIdents;
                Dafny.ISequence<Dafny.Rune> _out548;
                bool _out549;
                bool _out550;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out551;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out548, out _out549, out _out550, out _out551);
                _1030_recursiveGen = _out548;
                _1031_recOwned = _out549;
                _1032_recErased = _out550;
                _1033_recIdents = _out551;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1030_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1031_recOwned;
                isErased = _1032_recErased;
                readIdents = _1033_recIdents;
              }
            } else if (_source41.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1034___mcc_h429 = _source41.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1035_recursiveGen;
                bool _1036_recOwned;
                bool _1037_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1038_recIdents;
                Dafny.ISequence<Dafny.Rune> _out552;
                bool _out553;
                bool _out554;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out555;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out552, out _out553, out _out554, out _out555);
                _1035_recursiveGen = _out552;
                _1036_recOwned = _out553;
                _1037_recErased = _out554;
                _1038_recIdents = _out555;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1036_recOwned;
                isErased = _1037_recErased;
                readIdents = _1038_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1039___mcc_h431 = _source41.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1040_recursiveGen;
                bool _1041_recOwned;
                bool _1042_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1043_recIdents;
                Dafny.ISequence<Dafny.Rune> _out556;
                bool _out557;
                bool _out558;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out559;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out556, out _out557, out _out558, out _out559);
                _1040_recursiveGen = _out556;
                _1041_recOwned = _out557;
                _1042_recErased = _out558;
                _1043_recIdents = _out559;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1040_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1041_recOwned;
                isErased = _1042_recErased;
                readIdents = _1043_recIdents;
              }
            }
          } else if (_source26.is_Primitive) {
            DAST._IPrimitive _1044___mcc_h433 = _source26.dtor_Primitive_a0;
            DAST._IPrimitive _source43 = _1044___mcc_h433;
            if (_source43.is_Int) {
              DAST._IType _source44 = _463___mcc_h122;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1045___mcc_h436 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1046___mcc_h437 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1047___mcc_h438 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1047___mcc_h438;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1048___mcc_h442 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1049_recursiveGen;
                    bool _1050_recOwned;
                    bool _1051_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1052_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out560;
                    bool _out561;
                    bool _out562;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out563;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out560, out _out561, out _out562, out _out563);
                    _1049_recursiveGen = _out560;
                    _1050_recOwned = _out561;
                    _1051_recErased = _out562;
                    _1052_recIdents = _out563;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1049_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1050_recOwned;
                    isErased = _1051_recErased;
                    readIdents = _1052_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1053___mcc_h444 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1054_recursiveGen;
                    bool _1055_recOwned;
                    bool _1056_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1057_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out564;
                    bool _out565;
                    bool _out566;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out567;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out564, out _out565, out _out566, out _out567);
                    _1054_recursiveGen = _out564;
                    _1055_recOwned = _out565;
                    _1056_recErased = _out566;
                    _1057_recIdents = _out567;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1054_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1055_recOwned;
                    isErased = _1056_recErased;
                    readIdents = _1057_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1058_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out568;
                    _out568 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                    _1058_tpeGen = _out568;
                    Dafny.ISequence<Dafny.Rune> _1059_recursiveGen;
                    bool _1060_recOwned;
                    bool _1061_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1062_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out569;
                    bool _out570;
                    bool _out571;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out572;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out569, out _out570, out _out571, out _out572);
                    _1059_recursiveGen = _out569;
                    _1060_recOwned = _out570;
                    _1061_recErased = _out571;
                    _1062_recIdents = _out572;
                    Dafny.ISequence<Dafny.Rune> _1063_uneraseFn;
                    _1063_uneraseFn = ((_1060_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1058_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1063_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1059_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1060_recOwned;
                    isErased = false;
                    readIdents = _1062_recIdents;
                  }
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1064___mcc_h446 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1065_recursiveGen;
                  bool _1066_recOwned;
                  bool _1067_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1068_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out573;
                  bool _out574;
                  bool _out575;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out576;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out573, out _out574, out _out575, out _out576);
                  _1065_recursiveGen = _out573;
                  _1066_recOwned = _out574;
                  _1067_recErased = _out575;
                  _1068_recIdents = _out576;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1065_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1066_recOwned;
                  isErased = _1067_recErased;
                  readIdents = _1068_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1069___mcc_h448 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1070_recursiveGen;
                  bool _1071_recOwned;
                  bool _1072_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1073_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out577;
                  bool _out578;
                  bool _out579;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out580;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out577, out _out578, out _out579, out _out580);
                  _1070_recursiveGen = _out577;
                  _1071_recOwned = _out578;
                  _1072_recErased = _out579;
                  _1073_recIdents = _out580;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1070_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1071_recOwned;
                  isErased = _1072_recErased;
                  readIdents = _1073_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1074___mcc_h450 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1075_recursiveGen;
                  bool _1076_recOwned;
                  bool _1077_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1078_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out581;
                  bool _out582;
                  bool _out583;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out584;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out581, out _out582, out _out583, out _out584);
                  _1075_recursiveGen = _out581;
                  _1076_recOwned = _out582;
                  _1077_recErased = _out583;
                  _1078_recIdents = _out584;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1075_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1076_recOwned;
                  isErased = _1077_recErased;
                  readIdents = _1078_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1079___mcc_h452 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1080_recursiveGen;
                  bool _1081_recOwned;
                  bool _1082_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1083_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out585;
                  bool _out586;
                  bool _out587;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out588;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out585, out _out586, out _out587, out _out588);
                  _1080_recursiveGen = _out585;
                  _1081_recOwned = _out586;
                  _1082_recErased = _out587;
                  _1083_recIdents = _out588;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1080_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1081_recOwned;
                  isErased = _1082_recErased;
                  readIdents = _1083_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1084___mcc_h454 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1085_recursiveGen;
                  bool _1086_recOwned;
                  bool _1087_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1088_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out589;
                  bool _out590;
                  bool _out591;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out592;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out589, out _out590, out _out591, out _out592);
                  _1085_recursiveGen = _out589;
                  _1086_recOwned = _out590;
                  _1087_recErased = _out591;
                  _1088_recIdents = _out592;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1085_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1086_recOwned;
                  isErased = _1087_recErased;
                  readIdents = _1088_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1089___mcc_h456 = _source44.dtor_key;
                DAST._IType _1090___mcc_h457 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1091_recursiveGen;
                  bool _1092_recOwned;
                  bool _1093_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1094_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out593;
                  bool _out594;
                  bool _out595;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out596;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out593, out _out594, out _out595, out _out596);
                  _1091_recursiveGen = _out593;
                  _1092_recOwned = _out594;
                  _1093_recErased = _out595;
                  _1094_recIdents = _out596;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1091_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1092_recOwned;
                  isErased = _1093_recErased;
                  readIdents = _1094_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1095___mcc_h460 = _source44.dtor_args;
                DAST._IType _1096___mcc_h461 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1097_recursiveGen;
                  bool _1098_recOwned;
                  bool _1099_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1100_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out597;
                  bool _out598;
                  bool _out599;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out600;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out597, out _out598, out _out599, out _out600);
                  _1097_recursiveGen = _out597;
                  _1098_recOwned = _out598;
                  _1099_recErased = _out599;
                  _1100_recIdents = _out600;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1097_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1098_recOwned;
                  isErased = _1099_recErased;
                  readIdents = _1100_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1101___mcc_h464 = _source44.dtor_Primitive_a0;
                DAST._IPrimitive _source46 = _1101___mcc_h464;
                if (_source46.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1102_recursiveGen;
                    bool _1103_recOwned;
                    bool _1104_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1105_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out601;
                    bool _out602;
                    bool _out603;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out604;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out601, out _out602, out _out603, out _out604);
                    _1102_recursiveGen = _out601;
                    _1103_recOwned = _out602;
                    _1104_recErased = _out603;
                    _1105_recIdents = _out604;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1102_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1103_recOwned;
                    isErased = _1104_recErased;
                    readIdents = _1105_recIdents;
                  }
                } else if (_source46.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1106_recursiveGen;
                    bool _1107___v36;
                    bool _1108___v37;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1109_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out605;
                    bool _out606;
                    bool _out607;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out608;
                    DCOMP.COMP.GenExpr(_461_expr, @params, true, out _out605, out _out606, out _out607, out _out608);
                    _1106_recursiveGen = _out605;
                    _1107___v36 = _out606;
                    _1108___v37 = _out607;
                    _1109_recIdents = _out608;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1106_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1109_recIdents;
                  }
                } else if (_source46.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1110_recursiveGen;
                    bool _1111_recOwned;
                    bool _1112_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1113_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out609;
                    bool _out610;
                    bool _out611;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out612;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out609, out _out610, out _out611, out _out612);
                    _1110_recursiveGen = _out609;
                    _1111_recOwned = _out610;
                    _1112_recErased = _out611;
                    _1113_recIdents = _out612;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1110_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1111_recOwned;
                    isErased = _1112_recErased;
                    readIdents = _1113_recIdents;
                  }
                } else if (_source46.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1114_recursiveGen;
                    bool _1115_recOwned;
                    bool _1116_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1117_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out613;
                    bool _out614;
                    bool _out615;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out616;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out613, out _out614, out _out615, out _out616);
                    _1114_recursiveGen = _out613;
                    _1115_recOwned = _out614;
                    _1116_recErased = _out615;
                    _1117_recIdents = _out616;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1114_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1115_recOwned;
                    isErased = _1116_recErased;
                    readIdents = _1117_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1118_recursiveGen;
                    bool _1119_recOwned;
                    bool _1120_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1121_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out617;
                    bool _out618;
                    bool _out619;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out620;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out617, out _out618, out _out619, out _out620);
                    _1118_recursiveGen = _out617;
                    _1119_recOwned = _out618;
                    _1120_recErased = _out619;
                    _1121_recIdents = _out620;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1118_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1119_recOwned;
                    isErased = _1120_recErased;
                    readIdents = _1121_recIdents;
                  }
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1122___mcc_h466 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1123_recursiveGen;
                  bool _1124_recOwned;
                  bool _1125_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1126_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out621;
                  bool _out622;
                  bool _out623;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out624;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out621, out _out622, out _out623, out _out624);
                  _1123_recursiveGen = _out621;
                  _1124_recOwned = _out622;
                  _1125_recErased = _out623;
                  _1126_recIdents = _out624;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1123_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1124_recOwned;
                  isErased = _1125_recErased;
                  readIdents = _1126_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1127___mcc_h468 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1128_recursiveGen;
                  bool _1129_recOwned;
                  bool _1130_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1131_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out625;
                  bool _out626;
                  bool _out627;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out628;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out625, out _out626, out _out627, out _out628);
                  _1128_recursiveGen = _out625;
                  _1129_recOwned = _out626;
                  _1130_recErased = _out627;
                  _1131_recIdents = _out628;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1128_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1129_recOwned;
                  isErased = _1130_recErased;
                  readIdents = _1131_recIdents;
                }
              }
            } else if (_source43.is_Real) {
              DAST._IType _source47 = _463___mcc_h122;
              if (_source47.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1132___mcc_h470 = _source47.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1133___mcc_h471 = _source47.dtor_typeArgs;
                DAST._IResolvedType _1134___mcc_h472 = _source47.dtor_resolved;
                DAST._IResolvedType _source48 = _1134___mcc_h472;
                if (_source48.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1135___mcc_h476 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1136_recursiveGen;
                    bool _1137_recOwned;
                    bool _1138_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1139_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out629;
                    bool _out630;
                    bool _out631;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out632;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out629, out _out630, out _out631, out _out632);
                    _1136_recursiveGen = _out629;
                    _1137_recOwned = _out630;
                    _1138_recErased = _out631;
                    _1139_recIdents = _out632;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1136_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1137_recOwned;
                    isErased = _1138_recErased;
                    readIdents = _1139_recIdents;
                  }
                } else if (_source48.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1140___mcc_h478 = _source48.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1141_recursiveGen;
                    bool _1142_recOwned;
                    bool _1143_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1144_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out633;
                    bool _out634;
                    bool _out635;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out636;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out633, out _out634, out _out635, out _out636);
                    _1141_recursiveGen = _out633;
                    _1142_recOwned = _out634;
                    _1143_recErased = _out635;
                    _1144_recIdents = _out636;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1141_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1142_recOwned;
                    isErased = _1143_recErased;
                    readIdents = _1144_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1145_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out637;
                    _out637 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                    _1145_tpeGen = _out637;
                    Dafny.ISequence<Dafny.Rune> _1146_recursiveGen;
                    bool _1147_recOwned;
                    bool _1148_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1149_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out638;
                    bool _out639;
                    bool _out640;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out641;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out638, out _out639, out _out640, out _out641);
                    _1146_recursiveGen = _out638;
                    _1147_recOwned = _out639;
                    _1148_recErased = _out640;
                    _1149_recIdents = _out641;
                    Dafny.ISequence<Dafny.Rune> _1150_uneraseFn;
                    _1150_uneraseFn = ((_1147_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1145_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1150_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1146_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1147_recOwned;
                    isErased = false;
                    readIdents = _1149_recIdents;
                  }
                }
              } else if (_source47.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1151___mcc_h480 = _source47.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1152_recursiveGen;
                  bool _1153_recOwned;
                  bool _1154_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1155_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out642;
                  bool _out643;
                  bool _out644;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out645;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out642, out _out643, out _out644, out _out645);
                  _1152_recursiveGen = _out642;
                  _1153_recOwned = _out643;
                  _1154_recErased = _out644;
                  _1155_recIdents = _out645;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1152_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1153_recOwned;
                  isErased = _1154_recErased;
                  readIdents = _1155_recIdents;
                }
              } else if (_source47.is_Array) {
                DAST._IType _1156___mcc_h482 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1157_recursiveGen;
                  bool _1158_recOwned;
                  bool _1159_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1160_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out646;
                  bool _out647;
                  bool _out648;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out649;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out646, out _out647, out _out648, out _out649);
                  _1157_recursiveGen = _out646;
                  _1158_recOwned = _out647;
                  _1159_recErased = _out648;
                  _1160_recIdents = _out649;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1157_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1158_recOwned;
                  isErased = _1159_recErased;
                  readIdents = _1160_recIdents;
                }
              } else if (_source47.is_Seq) {
                DAST._IType _1161___mcc_h484 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1162_recursiveGen;
                  bool _1163_recOwned;
                  bool _1164_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1165_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out650;
                  bool _out651;
                  bool _out652;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out653;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out650, out _out651, out _out652, out _out653);
                  _1162_recursiveGen = _out650;
                  _1163_recOwned = _out651;
                  _1164_recErased = _out652;
                  _1165_recIdents = _out653;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1162_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1163_recOwned;
                  isErased = _1164_recErased;
                  readIdents = _1165_recIdents;
                }
              } else if (_source47.is_Set) {
                DAST._IType _1166___mcc_h486 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                  bool _1168_recOwned;
                  bool _1169_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out654;
                  bool _out655;
                  bool _out656;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out657;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out654, out _out655, out _out656, out _out657);
                  _1167_recursiveGen = _out654;
                  _1168_recOwned = _out655;
                  _1169_recErased = _out656;
                  _1170_recIdents = _out657;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1168_recOwned;
                  isErased = _1169_recErased;
                  readIdents = _1170_recIdents;
                }
              } else if (_source47.is_Multiset) {
                DAST._IType _1171___mcc_h488 = _source47.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1172_recursiveGen;
                  bool _1173_recOwned;
                  bool _1174_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1175_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out658;
                  bool _out659;
                  bool _out660;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out661;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out658, out _out659, out _out660, out _out661);
                  _1172_recursiveGen = _out658;
                  _1173_recOwned = _out659;
                  _1174_recErased = _out660;
                  _1175_recIdents = _out661;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1172_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1173_recOwned;
                  isErased = _1174_recErased;
                  readIdents = _1175_recIdents;
                }
              } else if (_source47.is_Map) {
                DAST._IType _1176___mcc_h490 = _source47.dtor_key;
                DAST._IType _1177___mcc_h491 = _source47.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1178_recursiveGen;
                  bool _1179_recOwned;
                  bool _1180_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1181_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out662;
                  bool _out663;
                  bool _out664;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out665;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out662, out _out663, out _out664, out _out665);
                  _1178_recursiveGen = _out662;
                  _1179_recOwned = _out663;
                  _1180_recErased = _out664;
                  _1181_recIdents = _out665;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1178_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1179_recOwned;
                  isErased = _1180_recErased;
                  readIdents = _1181_recIdents;
                }
              } else if (_source47.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1182___mcc_h494 = _source47.dtor_args;
                DAST._IType _1183___mcc_h495 = _source47.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1184_recursiveGen;
                  bool _1185_recOwned;
                  bool _1186_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1187_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out666;
                  bool _out667;
                  bool _out668;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out669;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out666, out _out667, out _out668, out _out669);
                  _1184_recursiveGen = _out666;
                  _1185_recOwned = _out667;
                  _1186_recErased = _out668;
                  _1187_recIdents = _out669;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1184_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1185_recOwned;
                  isErased = _1186_recErased;
                  readIdents = _1187_recIdents;
                }
              } else if (_source47.is_Primitive) {
                DAST._IPrimitive _1188___mcc_h498 = _source47.dtor_Primitive_a0;
                DAST._IPrimitive _source49 = _1188___mcc_h498;
                if (_source49.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                    bool _1190___v38;
                    bool _1191___v39;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out670;
                    bool _out671;
                    bool _out672;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out673;
                    DCOMP.COMP.GenExpr(_461_expr, @params, false, out _out670, out _out671, out _out672, out _out673);
                    _1189_recursiveGen = _out670;
                    _1190___v38 = _out671;
                    _1191___v39 = _out672;
                    _1192_recIdents = _out673;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1192_recIdents;
                  }
                } else if (_source49.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1193_recursiveGen;
                    bool _1194_recOwned;
                    bool _1195_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1196_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out674;
                    bool _out675;
                    bool _out676;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out677;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out674, out _out675, out _out676, out _out677);
                    _1193_recursiveGen = _out674;
                    _1194_recOwned = _out675;
                    _1195_recErased = _out676;
                    _1196_recIdents = _out677;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1193_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1194_recOwned;
                    isErased = _1195_recErased;
                    readIdents = _1196_recIdents;
                  }
                } else if (_source49.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1197_recursiveGen;
                    bool _1198_recOwned;
                    bool _1199_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1200_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out678;
                    bool _out679;
                    bool _out680;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out681;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out678, out _out679, out _out680, out _out681);
                    _1197_recursiveGen = _out678;
                    _1198_recOwned = _out679;
                    _1199_recErased = _out680;
                    _1200_recIdents = _out681;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1197_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1198_recOwned;
                    isErased = _1199_recErased;
                    readIdents = _1200_recIdents;
                  }
                } else if (_source49.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1201_recursiveGen;
                    bool _1202_recOwned;
                    bool _1203_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1204_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out682;
                    bool _out683;
                    bool _out684;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out685;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out682, out _out683, out _out684, out _out685);
                    _1201_recursiveGen = _out682;
                    _1202_recOwned = _out683;
                    _1203_recErased = _out684;
                    _1204_recIdents = _out685;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1201_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1202_recOwned;
                    isErased = _1203_recErased;
                    readIdents = _1204_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                    bool _1206_recOwned;
                    bool _1207_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out686;
                    bool _out687;
                    bool _out688;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out689;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out686, out _out687, out _out688, out _out689);
                    _1205_recursiveGen = _out686;
                    _1206_recOwned = _out687;
                    _1207_recErased = _out688;
                    _1208_recIdents = _out689;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1206_recOwned;
                    isErased = _1207_recErased;
                    readIdents = _1208_recIdents;
                  }
                }
              } else if (_source47.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1209___mcc_h500 = _source47.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1210_recursiveGen;
                  bool _1211_recOwned;
                  bool _1212_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1213_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out690;
                  bool _out691;
                  bool _out692;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out693;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out690, out _out691, out _out692, out _out693);
                  _1210_recursiveGen = _out690;
                  _1211_recOwned = _out691;
                  _1212_recErased = _out692;
                  _1213_recIdents = _out693;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1210_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1211_recOwned;
                  isErased = _1212_recErased;
                  readIdents = _1213_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1214___mcc_h502 = _source47.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1215_recursiveGen;
                  bool _1216_recOwned;
                  bool _1217_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1218_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out694;
                  bool _out695;
                  bool _out696;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out697;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out694, out _out695, out _out696, out _out697);
                  _1215_recursiveGen = _out694;
                  _1216_recOwned = _out695;
                  _1217_recErased = _out696;
                  _1218_recIdents = _out697;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1215_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1216_recOwned;
                  isErased = _1217_recErased;
                  readIdents = _1218_recIdents;
                }
              }
            } else if (_source43.is_String) {
              DAST._IType _source50 = _463___mcc_h122;
              if (_source50.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1219___mcc_h504 = _source50.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1220___mcc_h505 = _source50.dtor_typeArgs;
                DAST._IResolvedType _1221___mcc_h506 = _source50.dtor_resolved;
                DAST._IResolvedType _source51 = _1221___mcc_h506;
                if (_source51.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1222___mcc_h510 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1223_recursiveGen;
                    bool _1224_recOwned;
                    bool _1225_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1226_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out698;
                    bool _out699;
                    bool _out700;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out701;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out698, out _out699, out _out700, out _out701);
                    _1223_recursiveGen = _out698;
                    _1224_recOwned = _out699;
                    _1225_recErased = _out700;
                    _1226_recIdents = _out701;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1223_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1224_recOwned;
                    isErased = _1225_recErased;
                    readIdents = _1226_recIdents;
                  }
                } else if (_source51.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1227___mcc_h512 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1228_recursiveGen;
                    bool _1229_recOwned;
                    bool _1230_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1231_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out702;
                    bool _out703;
                    bool _out704;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out705;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out702, out _out703, out _out704, out _out705);
                    _1228_recursiveGen = _out702;
                    _1229_recOwned = _out703;
                    _1230_recErased = _out704;
                    _1231_recIdents = _out705;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1228_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1229_recOwned;
                    isErased = _1230_recErased;
                    readIdents = _1231_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1232_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out706;
                    _out706 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                    _1232_tpeGen = _out706;
                    Dafny.ISequence<Dafny.Rune> _1233_recursiveGen;
                    bool _1234_recOwned;
                    bool _1235_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1236_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out707;
                    bool _out708;
                    bool _out709;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out710;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out707, out _out708, out _out709, out _out710);
                    _1233_recursiveGen = _out707;
                    _1234_recOwned = _out708;
                    _1235_recErased = _out709;
                    _1236_recIdents = _out710;
                    Dafny.ISequence<Dafny.Rune> _1237_uneraseFn;
                    _1237_uneraseFn = ((_1234_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1232_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1237_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1233_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1234_recOwned;
                    isErased = false;
                    readIdents = _1236_recIdents;
                  }
                }
              } else if (_source50.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1238___mcc_h514 = _source50.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1239_recursiveGen;
                  bool _1240_recOwned;
                  bool _1241_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1242_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out711;
                  bool _out712;
                  bool _out713;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out714;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out711, out _out712, out _out713, out _out714);
                  _1239_recursiveGen = _out711;
                  _1240_recOwned = _out712;
                  _1241_recErased = _out713;
                  _1242_recIdents = _out714;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1239_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1240_recOwned;
                  isErased = _1241_recErased;
                  readIdents = _1242_recIdents;
                }
              } else if (_source50.is_Array) {
                DAST._IType _1243___mcc_h516 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1244_recursiveGen;
                  bool _1245_recOwned;
                  bool _1246_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1247_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out715;
                  bool _out716;
                  bool _out717;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out718;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out715, out _out716, out _out717, out _out718);
                  _1244_recursiveGen = _out715;
                  _1245_recOwned = _out716;
                  _1246_recErased = _out717;
                  _1247_recIdents = _out718;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1244_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1245_recOwned;
                  isErased = _1246_recErased;
                  readIdents = _1247_recIdents;
                }
              } else if (_source50.is_Seq) {
                DAST._IType _1248___mcc_h518 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1249_recursiveGen;
                  bool _1250_recOwned;
                  bool _1251_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1252_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out719;
                  bool _out720;
                  bool _out721;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out722;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out719, out _out720, out _out721, out _out722);
                  _1249_recursiveGen = _out719;
                  _1250_recOwned = _out720;
                  _1251_recErased = _out721;
                  _1252_recIdents = _out722;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1249_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1250_recOwned;
                  isErased = _1251_recErased;
                  readIdents = _1252_recIdents;
                }
              } else if (_source50.is_Set) {
                DAST._IType _1253___mcc_h520 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1254_recursiveGen;
                  bool _1255_recOwned;
                  bool _1256_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1257_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out723;
                  bool _out724;
                  bool _out725;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out726;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out723, out _out724, out _out725, out _out726);
                  _1254_recursiveGen = _out723;
                  _1255_recOwned = _out724;
                  _1256_recErased = _out725;
                  _1257_recIdents = _out726;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1254_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1255_recOwned;
                  isErased = _1256_recErased;
                  readIdents = _1257_recIdents;
                }
              } else if (_source50.is_Multiset) {
                DAST._IType _1258___mcc_h522 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1259_recursiveGen;
                  bool _1260_recOwned;
                  bool _1261_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1262_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out727;
                  bool _out728;
                  bool _out729;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out730;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out727, out _out728, out _out729, out _out730);
                  _1259_recursiveGen = _out727;
                  _1260_recOwned = _out728;
                  _1261_recErased = _out729;
                  _1262_recIdents = _out730;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1259_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1260_recOwned;
                  isErased = _1261_recErased;
                  readIdents = _1262_recIdents;
                }
              } else if (_source50.is_Map) {
                DAST._IType _1263___mcc_h524 = _source50.dtor_key;
                DAST._IType _1264___mcc_h525 = _source50.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1265_recursiveGen;
                  bool _1266_recOwned;
                  bool _1267_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1268_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out731;
                  bool _out732;
                  bool _out733;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out734;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out731, out _out732, out _out733, out _out734);
                  _1265_recursiveGen = _out731;
                  _1266_recOwned = _out732;
                  _1267_recErased = _out733;
                  _1268_recIdents = _out734;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1265_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1266_recOwned;
                  isErased = _1267_recErased;
                  readIdents = _1268_recIdents;
                }
              } else if (_source50.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1269___mcc_h528 = _source50.dtor_args;
                DAST._IType _1270___mcc_h529 = _source50.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1271_recursiveGen;
                  bool _1272_recOwned;
                  bool _1273_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1274_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out735;
                  bool _out736;
                  bool _out737;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out738;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out735, out _out736, out _out737, out _out738);
                  _1271_recursiveGen = _out735;
                  _1272_recOwned = _out736;
                  _1273_recErased = _out737;
                  _1274_recIdents = _out738;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1271_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1272_recOwned;
                  isErased = _1273_recErased;
                  readIdents = _1274_recIdents;
                }
              } else if (_source50.is_Primitive) {
                DAST._IPrimitive _1275___mcc_h532 = _source50.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1276_recursiveGen;
                  bool _1277_recOwned;
                  bool _1278_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1279_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out739;
                  bool _out740;
                  bool _out741;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out742;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out739, out _out740, out _out741, out _out742);
                  _1276_recursiveGen = _out739;
                  _1277_recOwned = _out740;
                  _1278_recErased = _out741;
                  _1279_recIdents = _out742;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1276_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1277_recOwned;
                  isErased = _1278_recErased;
                  readIdents = _1279_recIdents;
                }
              } else if (_source50.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1280___mcc_h534 = _source50.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1281_recursiveGen;
                  bool _1282_recOwned;
                  bool _1283_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1284_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out743;
                  bool _out744;
                  bool _out745;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out746;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out743, out _out744, out _out745, out _out746);
                  _1281_recursiveGen = _out743;
                  _1282_recOwned = _out744;
                  _1283_recErased = _out745;
                  _1284_recIdents = _out746;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1281_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1282_recOwned;
                  isErased = _1283_recErased;
                  readIdents = _1284_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1285___mcc_h536 = _source50.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1286_recursiveGen;
                  bool _1287_recOwned;
                  bool _1288_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1289_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out747;
                  bool _out748;
                  bool _out749;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out750;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out747, out _out748, out _out749, out _out750);
                  _1286_recursiveGen = _out747;
                  _1287_recOwned = _out748;
                  _1288_recErased = _out749;
                  _1289_recIdents = _out750;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1286_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1287_recOwned;
                  isErased = _1288_recErased;
                  readIdents = _1289_recIdents;
                }
              }
            } else if (_source43.is_Bool) {
              DAST._IType _source52 = _463___mcc_h122;
              if (_source52.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1290___mcc_h538 = _source52.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1291___mcc_h539 = _source52.dtor_typeArgs;
                DAST._IResolvedType _1292___mcc_h540 = _source52.dtor_resolved;
                DAST._IResolvedType _source53 = _1292___mcc_h540;
                if (_source53.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1293___mcc_h544 = _source53.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1294_recursiveGen;
                    bool _1295_recOwned;
                    bool _1296_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1297_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out751;
                    bool _out752;
                    bool _out753;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out754;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out751, out _out752, out _out753, out _out754);
                    _1294_recursiveGen = _out751;
                    _1295_recOwned = _out752;
                    _1296_recErased = _out753;
                    _1297_recIdents = _out754;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1294_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1295_recOwned;
                    isErased = _1296_recErased;
                    readIdents = _1297_recIdents;
                  }
                } else if (_source53.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1298___mcc_h546 = _source53.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1299_recursiveGen;
                    bool _1300_recOwned;
                    bool _1301_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1302_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out755;
                    bool _out756;
                    bool _out757;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out758;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out755, out _out756, out _out757, out _out758);
                    _1299_recursiveGen = _out755;
                    _1300_recOwned = _out756;
                    _1301_recErased = _out757;
                    _1302_recIdents = _out758;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1299_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1300_recOwned;
                    isErased = _1301_recErased;
                    readIdents = _1302_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1303_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out759;
                    _out759 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                    _1303_tpeGen = _out759;
                    Dafny.ISequence<Dafny.Rune> _1304_recursiveGen;
                    bool _1305_recOwned;
                    bool _1306_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1307_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out760;
                    bool _out761;
                    bool _out762;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out763;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out760, out _out761, out _out762, out _out763);
                    _1304_recursiveGen = _out760;
                    _1305_recOwned = _out761;
                    _1306_recErased = _out762;
                    _1307_recIdents = _out763;
                    Dafny.ISequence<Dafny.Rune> _1308_uneraseFn;
                    _1308_uneraseFn = ((_1305_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1303_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1308_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1304_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1305_recOwned;
                    isErased = false;
                    readIdents = _1307_recIdents;
                  }
                }
              } else if (_source52.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1309___mcc_h548 = _source52.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1310_recursiveGen;
                  bool _1311_recOwned;
                  bool _1312_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1313_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out764;
                  bool _out765;
                  bool _out766;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out767;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out764, out _out765, out _out766, out _out767);
                  _1310_recursiveGen = _out764;
                  _1311_recOwned = _out765;
                  _1312_recErased = _out766;
                  _1313_recIdents = _out767;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1310_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1311_recOwned;
                  isErased = _1312_recErased;
                  readIdents = _1313_recIdents;
                }
              } else if (_source52.is_Array) {
                DAST._IType _1314___mcc_h550 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1315_recursiveGen;
                  bool _1316_recOwned;
                  bool _1317_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1318_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out768;
                  bool _out769;
                  bool _out770;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out771;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out768, out _out769, out _out770, out _out771);
                  _1315_recursiveGen = _out768;
                  _1316_recOwned = _out769;
                  _1317_recErased = _out770;
                  _1318_recIdents = _out771;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1315_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1316_recOwned;
                  isErased = _1317_recErased;
                  readIdents = _1318_recIdents;
                }
              } else if (_source52.is_Seq) {
                DAST._IType _1319___mcc_h552 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1320_recursiveGen;
                  bool _1321_recOwned;
                  bool _1322_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1323_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out772;
                  bool _out773;
                  bool _out774;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out775;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out772, out _out773, out _out774, out _out775);
                  _1320_recursiveGen = _out772;
                  _1321_recOwned = _out773;
                  _1322_recErased = _out774;
                  _1323_recIdents = _out775;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1320_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1321_recOwned;
                  isErased = _1322_recErased;
                  readIdents = _1323_recIdents;
                }
              } else if (_source52.is_Set) {
                DAST._IType _1324___mcc_h554 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1325_recursiveGen;
                  bool _1326_recOwned;
                  bool _1327_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1328_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out776;
                  bool _out777;
                  bool _out778;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out779;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out776, out _out777, out _out778, out _out779);
                  _1325_recursiveGen = _out776;
                  _1326_recOwned = _out777;
                  _1327_recErased = _out778;
                  _1328_recIdents = _out779;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1325_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1326_recOwned;
                  isErased = _1327_recErased;
                  readIdents = _1328_recIdents;
                }
              } else if (_source52.is_Multiset) {
                DAST._IType _1329___mcc_h556 = _source52.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1330_recursiveGen;
                  bool _1331_recOwned;
                  bool _1332_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1333_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out780;
                  bool _out781;
                  bool _out782;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out783;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out780, out _out781, out _out782, out _out783);
                  _1330_recursiveGen = _out780;
                  _1331_recOwned = _out781;
                  _1332_recErased = _out782;
                  _1333_recIdents = _out783;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1330_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1331_recOwned;
                  isErased = _1332_recErased;
                  readIdents = _1333_recIdents;
                }
              } else if (_source52.is_Map) {
                DAST._IType _1334___mcc_h558 = _source52.dtor_key;
                DAST._IType _1335___mcc_h559 = _source52.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1336_recursiveGen;
                  bool _1337_recOwned;
                  bool _1338_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1339_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out784;
                  bool _out785;
                  bool _out786;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out787;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out784, out _out785, out _out786, out _out787);
                  _1336_recursiveGen = _out784;
                  _1337_recOwned = _out785;
                  _1338_recErased = _out786;
                  _1339_recIdents = _out787;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1336_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1337_recOwned;
                  isErased = _1338_recErased;
                  readIdents = _1339_recIdents;
                }
              } else if (_source52.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1340___mcc_h562 = _source52.dtor_args;
                DAST._IType _1341___mcc_h563 = _source52.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1342_recursiveGen;
                  bool _1343_recOwned;
                  bool _1344_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1345_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out788;
                  bool _out789;
                  bool _out790;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out791;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out788, out _out789, out _out790, out _out791);
                  _1342_recursiveGen = _out788;
                  _1343_recOwned = _out789;
                  _1344_recErased = _out790;
                  _1345_recIdents = _out791;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1342_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1343_recOwned;
                  isErased = _1344_recErased;
                  readIdents = _1345_recIdents;
                }
              } else if (_source52.is_Primitive) {
                DAST._IPrimitive _1346___mcc_h566 = _source52.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1347_recursiveGen;
                  bool _1348_recOwned;
                  bool _1349_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1350_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out792;
                  bool _out793;
                  bool _out794;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out795;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out792, out _out793, out _out794, out _out795);
                  _1347_recursiveGen = _out792;
                  _1348_recOwned = _out793;
                  _1349_recErased = _out794;
                  _1350_recIdents = _out795;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1347_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1348_recOwned;
                  isErased = _1349_recErased;
                  readIdents = _1350_recIdents;
                }
              } else if (_source52.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1351___mcc_h568 = _source52.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                  bool _1353_recOwned;
                  bool _1354_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out796;
                  bool _out797;
                  bool _out798;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out799;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out796, out _out797, out _out798, out _out799);
                  _1352_recursiveGen = _out796;
                  _1353_recOwned = _out797;
                  _1354_recErased = _out798;
                  _1355_recIdents = _out799;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1353_recOwned;
                  isErased = _1354_recErased;
                  readIdents = _1355_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1356___mcc_h570 = _source52.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1357_recursiveGen;
                  bool _1358_recOwned;
                  bool _1359_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1360_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out800;
                  bool _out801;
                  bool _out802;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out803;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out800, out _out801, out _out802, out _out803);
                  _1357_recursiveGen = _out800;
                  _1358_recOwned = _out801;
                  _1359_recErased = _out802;
                  _1360_recIdents = _out803;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1357_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1358_recOwned;
                  isErased = _1359_recErased;
                  readIdents = _1360_recIdents;
                }
              }
            } else {
              DAST._IType _source54 = _463___mcc_h122;
              if (_source54.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1361___mcc_h572 = _source54.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1362___mcc_h573 = _source54.dtor_typeArgs;
                DAST._IResolvedType _1363___mcc_h574 = _source54.dtor_resolved;
                DAST._IResolvedType _source55 = _1363___mcc_h574;
                if (_source55.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1364___mcc_h578 = _source55.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1365_recursiveGen;
                    bool _1366_recOwned;
                    bool _1367_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1368_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out804;
                    bool _out805;
                    bool _out806;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out807;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out804, out _out805, out _out806, out _out807);
                    _1365_recursiveGen = _out804;
                    _1366_recOwned = _out805;
                    _1367_recErased = _out806;
                    _1368_recIdents = _out807;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1365_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1366_recOwned;
                    isErased = _1367_recErased;
                    readIdents = _1368_recIdents;
                  }
                } else if (_source55.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1369___mcc_h580 = _source55.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1370_recursiveGen;
                    bool _1371_recOwned;
                    bool _1372_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1373_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out808;
                    bool _out809;
                    bool _out810;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out811;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out808, out _out809, out _out810, out _out811);
                    _1370_recursiveGen = _out808;
                    _1371_recOwned = _out809;
                    _1372_recErased = _out810;
                    _1373_recIdents = _out811;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1370_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1371_recOwned;
                    isErased = _1372_recErased;
                    readIdents = _1373_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1374_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out812;
                    _out812 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                    _1374_tpeGen = _out812;
                    Dafny.ISequence<Dafny.Rune> _1375_recursiveGen;
                    bool _1376_recOwned;
                    bool _1377_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1378_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out813;
                    bool _out814;
                    bool _out815;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out816;
                    DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out813, out _out814, out _out815, out _out816);
                    _1375_recursiveGen = _out813;
                    _1376_recOwned = _out814;
                    _1377_recErased = _out815;
                    _1378_recIdents = _out816;
                    Dafny.ISequence<Dafny.Rune> _1379_uneraseFn;
                    _1379_uneraseFn = ((_1376_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1374_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1379_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1375_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1376_recOwned;
                    isErased = false;
                    readIdents = _1378_recIdents;
                  }
                }
              } else if (_source54.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1380___mcc_h582 = _source54.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1381_recursiveGen;
                  bool _1382_recOwned;
                  bool _1383_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1384_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out817;
                  bool _out818;
                  bool _out819;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out820;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out817, out _out818, out _out819, out _out820);
                  _1381_recursiveGen = _out817;
                  _1382_recOwned = _out818;
                  _1383_recErased = _out819;
                  _1384_recIdents = _out820;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1381_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1382_recOwned;
                  isErased = _1383_recErased;
                  readIdents = _1384_recIdents;
                }
              } else if (_source54.is_Array) {
                DAST._IType _1385___mcc_h584 = _source54.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1386_recursiveGen;
                  bool _1387_recOwned;
                  bool _1388_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1389_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out821;
                  bool _out822;
                  bool _out823;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out824;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out821, out _out822, out _out823, out _out824);
                  _1386_recursiveGen = _out821;
                  _1387_recOwned = _out822;
                  _1388_recErased = _out823;
                  _1389_recIdents = _out824;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1386_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1387_recOwned;
                  isErased = _1388_recErased;
                  readIdents = _1389_recIdents;
                }
              } else if (_source54.is_Seq) {
                DAST._IType _1390___mcc_h586 = _source54.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1391_recursiveGen;
                  bool _1392_recOwned;
                  bool _1393_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1394_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out825;
                  bool _out826;
                  bool _out827;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out828;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out825, out _out826, out _out827, out _out828);
                  _1391_recursiveGen = _out825;
                  _1392_recOwned = _out826;
                  _1393_recErased = _out827;
                  _1394_recIdents = _out828;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1391_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1392_recOwned;
                  isErased = _1393_recErased;
                  readIdents = _1394_recIdents;
                }
              } else if (_source54.is_Set) {
                DAST._IType _1395___mcc_h588 = _source54.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1396_recursiveGen;
                  bool _1397_recOwned;
                  bool _1398_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1399_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out829;
                  bool _out830;
                  bool _out831;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out832;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out829, out _out830, out _out831, out _out832);
                  _1396_recursiveGen = _out829;
                  _1397_recOwned = _out830;
                  _1398_recErased = _out831;
                  _1399_recIdents = _out832;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1396_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1397_recOwned;
                  isErased = _1398_recErased;
                  readIdents = _1399_recIdents;
                }
              } else if (_source54.is_Multiset) {
                DAST._IType _1400___mcc_h590 = _source54.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1401_recursiveGen;
                  bool _1402_recOwned;
                  bool _1403_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1404_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out833;
                  bool _out834;
                  bool _out835;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out836;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out833, out _out834, out _out835, out _out836);
                  _1401_recursiveGen = _out833;
                  _1402_recOwned = _out834;
                  _1403_recErased = _out835;
                  _1404_recIdents = _out836;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1401_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1402_recOwned;
                  isErased = _1403_recErased;
                  readIdents = _1404_recIdents;
                }
              } else if (_source54.is_Map) {
                DAST._IType _1405___mcc_h592 = _source54.dtor_key;
                DAST._IType _1406___mcc_h593 = _source54.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1407_recursiveGen;
                  bool _1408_recOwned;
                  bool _1409_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1410_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out837;
                  bool _out838;
                  bool _out839;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out840;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out837, out _out838, out _out839, out _out840);
                  _1407_recursiveGen = _out837;
                  _1408_recOwned = _out838;
                  _1409_recErased = _out839;
                  _1410_recIdents = _out840;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1407_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1408_recOwned;
                  isErased = _1409_recErased;
                  readIdents = _1410_recIdents;
                }
              } else if (_source54.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1411___mcc_h596 = _source54.dtor_args;
                DAST._IType _1412___mcc_h597 = _source54.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                  bool _1414_recOwned;
                  bool _1415_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out841;
                  bool _out842;
                  bool _out843;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out844;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out841, out _out842, out _out843, out _out844);
                  _1413_recursiveGen = _out841;
                  _1414_recOwned = _out842;
                  _1415_recErased = _out843;
                  _1416_recIdents = _out844;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1414_recOwned;
                  isErased = _1415_recErased;
                  readIdents = _1416_recIdents;
                }
              } else if (_source54.is_Primitive) {
                DAST._IPrimitive _1417___mcc_h600 = _source54.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1418_recursiveGen;
                  bool _1419_recOwned;
                  bool _1420_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1421_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out845;
                  bool _out846;
                  bool _out847;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out848;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out845, out _out846, out _out847, out _out848);
                  _1418_recursiveGen = _out845;
                  _1419_recOwned = _out846;
                  _1420_recErased = _out847;
                  _1421_recIdents = _out848;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1419_recOwned;
                  isErased = _1420_recErased;
                  readIdents = _1421_recIdents;
                }
              } else if (_source54.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1422___mcc_h602 = _source54.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1423_recursiveGen;
                  bool _1424_recOwned;
                  bool _1425_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1426_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out849;
                  bool _out850;
                  bool _out851;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out852;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out849, out _out850, out _out851, out _out852);
                  _1423_recursiveGen = _out849;
                  _1424_recOwned = _out850;
                  _1425_recErased = _out851;
                  _1426_recIdents = _out852;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1423_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1424_recOwned;
                  isErased = _1425_recErased;
                  readIdents = _1426_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1427___mcc_h604 = _source54.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1428_recursiveGen;
                  bool _1429_recOwned;
                  bool _1430_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1431_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out853;
                  bool _out854;
                  bool _out855;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out856;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out853, out _out854, out _out855, out _out856);
                  _1428_recursiveGen = _out853;
                  _1429_recOwned = _out854;
                  _1430_recErased = _out855;
                  _1431_recIdents = _out856;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1428_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1429_recOwned;
                  isErased = _1430_recErased;
                  readIdents = _1431_recIdents;
                }
              }
            }
          } else if (_source26.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _1432___mcc_h606 = _source26.dtor_Passthrough_a0;
            DAST._IType _source56 = _463___mcc_h122;
            if (_source56.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1433___mcc_h609 = _source56.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _1434___mcc_h610 = _source56.dtor_typeArgs;
              DAST._IResolvedType _1435___mcc_h611 = _source56.dtor_resolved;
              DAST._IResolvedType _source57 = _1435___mcc_h611;
              if (_source57.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1436___mcc_h615 = _source57.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1437_recursiveGen;
                  bool _1438_recOwned;
                  bool _1439_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1440_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out857;
                  bool _out858;
                  bool _out859;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out860;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out857, out _out858, out _out859, out _out860);
                  _1437_recursiveGen = _out857;
                  _1438_recOwned = _out858;
                  _1439_recErased = _out859;
                  _1440_recIdents = _out860;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1437_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1438_recOwned;
                  isErased = _1439_recErased;
                  readIdents = _1440_recIdents;
                }
              } else if (_source57.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1441___mcc_h617 = _source57.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1442_recursiveGen;
                  bool _1443_recOwned;
                  bool _1444_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1445_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out861;
                  bool _out862;
                  bool _out863;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out864;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out861, out _out862, out _out863, out _out864);
                  _1442_recursiveGen = _out861;
                  _1443_recOwned = _out862;
                  _1444_recErased = _out863;
                  _1445_recIdents = _out864;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1442_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1443_recOwned;
                  isErased = _1444_recErased;
                  readIdents = _1445_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _1446_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out865;
                  _out865 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _1446_tpeGen = _out865;
                  Dafny.ISequence<Dafny.Rune> _1447_recursiveGen;
                  bool _1448_recOwned;
                  bool _1449_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1450_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out866;
                  bool _out867;
                  bool _out868;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out869;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out866, out _out867, out _out868, out _out869);
                  _1447_recursiveGen = _out866;
                  _1448_recOwned = _out867;
                  _1449_recErased = _out868;
                  _1450_recIdents = _out869;
                  Dafny.ISequence<Dafny.Rune> _1451_uneraseFn;
                  _1451_uneraseFn = ((_1448_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1446_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1451_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1447_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _1448_recOwned;
                  isErased = false;
                  readIdents = _1450_recIdents;
                }
              }
            } else if (_source56.is_Tuple) {
              Dafny.ISequence<DAST._IType> _1452___mcc_h619 = _source56.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1453_recursiveGen;
                bool _1454_recOwned;
                bool _1455_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1456_recIdents;
                Dafny.ISequence<Dafny.Rune> _out870;
                bool _out871;
                bool _out872;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out873;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out870, out _out871, out _out872, out _out873);
                _1453_recursiveGen = _out870;
                _1454_recOwned = _out871;
                _1455_recErased = _out872;
                _1456_recIdents = _out873;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1454_recOwned;
                isErased = _1455_recErased;
                readIdents = _1456_recIdents;
              }
            } else if (_source56.is_Array) {
              DAST._IType _1457___mcc_h621 = _source56.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1458_recursiveGen;
                bool _1459_recOwned;
                bool _1460_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1461_recIdents;
                Dafny.ISequence<Dafny.Rune> _out874;
                bool _out875;
                bool _out876;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out877;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out874, out _out875, out _out876, out _out877);
                _1458_recursiveGen = _out874;
                _1459_recOwned = _out875;
                _1460_recErased = _out876;
                _1461_recIdents = _out877;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1458_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1459_recOwned;
                isErased = _1460_recErased;
                readIdents = _1461_recIdents;
              }
            } else if (_source56.is_Seq) {
              DAST._IType _1462___mcc_h623 = _source56.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1463_recursiveGen;
                bool _1464_recOwned;
                bool _1465_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1466_recIdents;
                Dafny.ISequence<Dafny.Rune> _out878;
                bool _out879;
                bool _out880;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out881;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out878, out _out879, out _out880, out _out881);
                _1463_recursiveGen = _out878;
                _1464_recOwned = _out879;
                _1465_recErased = _out880;
                _1466_recIdents = _out881;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1464_recOwned;
                isErased = _1465_recErased;
                readIdents = _1466_recIdents;
              }
            } else if (_source56.is_Set) {
              DAST._IType _1467___mcc_h625 = _source56.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1468_recursiveGen;
                bool _1469_recOwned;
                bool _1470_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1471_recIdents;
                Dafny.ISequence<Dafny.Rune> _out882;
                bool _out883;
                bool _out884;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out885;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out882, out _out883, out _out884, out _out885);
                _1468_recursiveGen = _out882;
                _1469_recOwned = _out883;
                _1470_recErased = _out884;
                _1471_recIdents = _out885;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1468_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1469_recOwned;
                isErased = _1470_recErased;
                readIdents = _1471_recIdents;
              }
            } else if (_source56.is_Multiset) {
              DAST._IType _1472___mcc_h627 = _source56.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1473_recursiveGen;
                bool _1474_recOwned;
                bool _1475_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1476_recIdents;
                Dafny.ISequence<Dafny.Rune> _out886;
                bool _out887;
                bool _out888;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out889;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out886, out _out887, out _out888, out _out889);
                _1473_recursiveGen = _out886;
                _1474_recOwned = _out887;
                _1475_recErased = _out888;
                _1476_recIdents = _out889;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1474_recOwned;
                isErased = _1475_recErased;
                readIdents = _1476_recIdents;
              }
            } else if (_source56.is_Map) {
              DAST._IType _1477___mcc_h629 = _source56.dtor_key;
              DAST._IType _1478___mcc_h630 = _source56.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _1479_recursiveGen;
                bool _1480_recOwned;
                bool _1481_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1482_recIdents;
                Dafny.ISequence<Dafny.Rune> _out890;
                bool _out891;
                bool _out892;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out893;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out890, out _out891, out _out892, out _out893);
                _1479_recursiveGen = _out890;
                _1480_recOwned = _out891;
                _1481_recErased = _out892;
                _1482_recIdents = _out893;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1480_recOwned;
                isErased = _1481_recErased;
                readIdents = _1482_recIdents;
              }
            } else if (_source56.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1483___mcc_h633 = _source56.dtor_args;
              DAST._IType _1484___mcc_h634 = _source56.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _1485_recursiveGen;
                bool _1486_recOwned;
                bool _1487_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1488_recIdents;
                Dafny.ISequence<Dafny.Rune> _out894;
                bool _out895;
                bool _out896;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out897;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out894, out _out895, out _out896, out _out897);
                _1485_recursiveGen = _out894;
                _1486_recOwned = _out895;
                _1487_recErased = _out896;
                _1488_recIdents = _out897;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1486_recOwned;
                isErased = _1487_recErased;
                readIdents = _1488_recIdents;
              }
            } else if (_source56.is_Primitive) {
              DAST._IPrimitive _1489___mcc_h637 = _source56.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1490_recursiveGen;
                bool _1491_recOwned;
                bool _1492_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1493_recIdents;
                Dafny.ISequence<Dafny.Rune> _out898;
                bool _out899;
                bool _out900;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out901;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out898, out _out899, out _out900, out _out901);
                _1490_recursiveGen = _out898;
                _1491_recOwned = _out899;
                _1492_recErased = _out900;
                _1493_recIdents = _out901;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1490_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1491_recOwned;
                isErased = _1492_recErased;
                readIdents = _1493_recIdents;
              }
            } else if (_source56.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1494___mcc_h639 = _source56.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1495_recursiveGen;
                bool _1496___v42;
                bool _1497___v43;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1498_recIdents;
                Dafny.ISequence<Dafny.Rune> _out902;
                bool _out903;
                bool _out904;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out905;
                DCOMP.COMP.GenExpr(_461_expr, @params, true, out _out902, out _out903, out _out904, out _out905);
                _1495_recursiveGen = _out902;
                _1496___v42 = _out903;
                _1497___v43 = _out904;
                _1498_recIdents = _out905;
                Dafny.ISequence<Dafny.Rune> _1499_toTpeGen;
                Dafny.ISequence<Dafny.Rune> _out906;
                _out906 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                _1499_toTpeGen = _out906;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1495_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1499_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                isOwned = true;
                isErased = true;
                readIdents = _1498_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1500___mcc_h641 = _source56.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1501_recursiveGen;
                bool _1502_recOwned;
                bool _1503_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1504_recIdents;
                Dafny.ISequence<Dafny.Rune> _out907;
                bool _out908;
                bool _out909;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out910;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out907, out _out908, out _out909, out _out910);
                _1501_recursiveGen = _out907;
                _1502_recOwned = _out908;
                _1503_recErased = _out909;
                _1504_recIdents = _out910;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1501_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1502_recOwned;
                isErased = _1503_recErased;
                readIdents = _1504_recIdents;
              }
            }
          } else {
            Dafny.ISequence<Dafny.Rune> _1505___mcc_h643 = _source26.dtor_TypeArg_a0;
            DAST._IType _source58 = _463___mcc_h122;
            if (_source58.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1506___mcc_h646 = _source58.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _1507___mcc_h647 = _source58.dtor_typeArgs;
              DAST._IResolvedType _1508___mcc_h648 = _source58.dtor_resolved;
              DAST._IResolvedType _source59 = _1508___mcc_h648;
              if (_source59.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1509___mcc_h652 = _source59.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1510_recursiveGen;
                  bool _1511_recOwned;
                  bool _1512_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1513_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out911;
                  bool _out912;
                  bool _out913;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out914;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out911, out _out912, out _out913, out _out914);
                  _1510_recursiveGen = _out911;
                  _1511_recOwned = _out912;
                  _1512_recErased = _out913;
                  _1513_recIdents = _out914;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1510_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1511_recOwned;
                  isErased = _1512_recErased;
                  readIdents = _1513_recIdents;
                }
              } else if (_source59.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1514___mcc_h654 = _source59.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1515_recursiveGen;
                  bool _1516_recOwned;
                  bool _1517_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1518_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out915;
                  bool _out916;
                  bool _out917;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out918;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out915, out _out916, out _out917, out _out918);
                  _1515_recursiveGen = _out915;
                  _1516_recOwned = _out916;
                  _1517_recErased = _out917;
                  _1518_recIdents = _out918;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1516_recOwned;
                  isErased = _1517_recErased;
                  readIdents = _1518_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _1519_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out919;
                  _out919 = DCOMP.COMP.GenType(_459_toTpe, true, false);
                  _1519_tpeGen = _out919;
                  Dafny.ISequence<Dafny.Rune> _1520_recursiveGen;
                  bool _1521_recOwned;
                  bool _1522_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1523_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out920;
                  bool _out921;
                  bool _out922;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                  DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out920, out _out921, out _out922, out _out923);
                  _1520_recursiveGen = _out920;
                  _1521_recOwned = _out921;
                  _1522_recErased = _out922;
                  _1523_recIdents = _out923;
                  Dafny.ISequence<Dafny.Rune> _1524_uneraseFn;
                  _1524_uneraseFn = ((_1521_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1519_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1524_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _1521_recOwned;
                  isErased = false;
                  readIdents = _1523_recIdents;
                }
              }
            } else if (_source58.is_Tuple) {
              Dafny.ISequence<DAST._IType> _1525___mcc_h656 = _source58.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1526_recursiveGen;
                bool _1527_recOwned;
                bool _1528_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1529_recIdents;
                Dafny.ISequence<Dafny.Rune> _out924;
                bool _out925;
                bool _out926;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                _1526_recursiveGen = _out924;
                _1527_recOwned = _out925;
                _1528_recErased = _out926;
                _1529_recIdents = _out927;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1526_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1527_recOwned;
                isErased = _1528_recErased;
                readIdents = _1529_recIdents;
              }
            } else if (_source58.is_Array) {
              DAST._IType _1530___mcc_h658 = _source58.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1531_recursiveGen;
                bool _1532_recOwned;
                bool _1533_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1534_recIdents;
                Dafny.ISequence<Dafny.Rune> _out928;
                bool _out929;
                bool _out930;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out928, out _out929, out _out930, out _out931);
                _1531_recursiveGen = _out928;
                _1532_recOwned = _out929;
                _1533_recErased = _out930;
                _1534_recIdents = _out931;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1531_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1532_recOwned;
                isErased = _1533_recErased;
                readIdents = _1534_recIdents;
              }
            } else if (_source58.is_Seq) {
              DAST._IType _1535___mcc_h660 = _source58.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1536_recursiveGen;
                bool _1537_recOwned;
                bool _1538_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1539_recIdents;
                Dafny.ISequence<Dafny.Rune> _out932;
                bool _out933;
                bool _out934;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out935;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out932, out _out933, out _out934, out _out935);
                _1536_recursiveGen = _out932;
                _1537_recOwned = _out933;
                _1538_recErased = _out934;
                _1539_recIdents = _out935;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1537_recOwned;
                isErased = _1538_recErased;
                readIdents = _1539_recIdents;
              }
            } else if (_source58.is_Set) {
              DAST._IType _1540___mcc_h662 = _source58.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1541_recursiveGen;
                bool _1542_recOwned;
                bool _1543_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1544_recIdents;
                Dafny.ISequence<Dafny.Rune> _out936;
                bool _out937;
                bool _out938;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out939;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out936, out _out937, out _out938, out _out939);
                _1541_recursiveGen = _out936;
                _1542_recOwned = _out937;
                _1543_recErased = _out938;
                _1544_recIdents = _out939;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1542_recOwned;
                isErased = _1543_recErased;
                readIdents = _1544_recIdents;
              }
            } else if (_source58.is_Multiset) {
              DAST._IType _1545___mcc_h664 = _source58.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1546_recursiveGen;
                bool _1547_recOwned;
                bool _1548_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1549_recIdents;
                Dafny.ISequence<Dafny.Rune> _out940;
                bool _out941;
                bool _out942;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out943;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out940, out _out941, out _out942, out _out943);
                _1546_recursiveGen = _out940;
                _1547_recOwned = _out941;
                _1548_recErased = _out942;
                _1549_recIdents = _out943;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1546_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1547_recOwned;
                isErased = _1548_recErased;
                readIdents = _1549_recIdents;
              }
            } else if (_source58.is_Map) {
              DAST._IType _1550___mcc_h666 = _source58.dtor_key;
              DAST._IType _1551___mcc_h667 = _source58.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _1552_recursiveGen;
                bool _1553_recOwned;
                bool _1554_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1555_recIdents;
                Dafny.ISequence<Dafny.Rune> _out944;
                bool _out945;
                bool _out946;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out947;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out944, out _out945, out _out946, out _out947);
                _1552_recursiveGen = _out944;
                _1553_recOwned = _out945;
                _1554_recErased = _out946;
                _1555_recIdents = _out947;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1553_recOwned;
                isErased = _1554_recErased;
                readIdents = _1555_recIdents;
              }
            } else if (_source58.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1556___mcc_h670 = _source58.dtor_args;
              DAST._IType _1557___mcc_h671 = _source58.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _1558_recursiveGen;
                bool _1559_recOwned;
                bool _1560_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1561_recIdents;
                Dafny.ISequence<Dafny.Rune> _out948;
                bool _out949;
                bool _out950;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out951;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out948, out _out949, out _out950, out _out951);
                _1558_recursiveGen = _out948;
                _1559_recOwned = _out949;
                _1560_recErased = _out950;
                _1561_recIdents = _out951;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1558_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1559_recOwned;
                isErased = _1560_recErased;
                readIdents = _1561_recIdents;
              }
            } else if (_source58.is_Primitive) {
              DAST._IPrimitive _1562___mcc_h674 = _source58.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1563_recursiveGen;
                bool _1564_recOwned;
                bool _1565_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1566_recIdents;
                Dafny.ISequence<Dafny.Rune> _out952;
                bool _out953;
                bool _out954;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out955;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out952, out _out953, out _out954, out _out955);
                _1563_recursiveGen = _out952;
                _1564_recOwned = _out953;
                _1565_recErased = _out954;
                _1566_recIdents = _out955;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1564_recOwned;
                isErased = _1565_recErased;
                readIdents = _1566_recIdents;
              }
            } else if (_source58.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1567___mcc_h676 = _source58.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1568_recursiveGen;
                bool _1569_recOwned;
                bool _1570_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1571_recIdents;
                Dafny.ISequence<Dafny.Rune> _out956;
                bool _out957;
                bool _out958;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out959;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out956, out _out957, out _out958, out _out959);
                _1568_recursiveGen = _out956;
                _1569_recOwned = _out957;
                _1570_recErased = _out958;
                _1571_recIdents = _out959;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1568_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1569_recOwned;
                isErased = _1570_recErased;
                readIdents = _1571_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1572___mcc_h678 = _source58.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1573_recursiveGen;
                bool _1574_recOwned;
                bool _1575_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1576_recIdents;
                Dafny.ISequence<Dafny.Rune> _out960;
                bool _out961;
                bool _out962;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out963;
                DCOMP.COMP.GenExpr(_461_expr, @params, mustOwn, out _out960, out _out961, out _out962, out _out963);
                _1573_recursiveGen = _out960;
                _1574_recOwned = _out961;
                _1575_recErased = _out962;
                _1576_recIdents = _out963;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1573_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1574_recOwned;
                isErased = _1575_recErased;
                readIdents = _1576_recIdents;
              }
            }
          }
        }
      } else if (_source19.is_SubsetDowngrade) {
        DAST._IExpression _1577___mcc_h22 = _source19.dtor_value;
        DAST._IExpression _1578_expr = _1577___mcc_h22;
        {
          Dafny.ISequence<Dafny.Rune> _1579_recursiveGen;
          bool _1580_recOwned;
          bool _1581_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1582_recIdents;
          Dafny.ISequence<Dafny.Rune> _out964;
          bool _out965;
          bool _out966;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out967;
          DCOMP.COMP.GenExpr(_1578_expr, @params, mustOwn, out _out964, out _out965, out _out966, out _out967);
          _1579_recursiveGen = _out964;
          _1580_recOwned = _out965;
          _1581_recErased = _out966;
          _1582_recIdents = _out967;
          Dafny.ISequence<Dafny.Rune> _1583_eraseFn;
          _1583_eraseFn = ((_1580_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1583_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1579_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = _1580_recOwned;
          isErased = true;
          readIdents = _1582_recIdents;
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _1584___mcc_h23 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1585_exprs = _1584___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1586_generatedValues;
          _1586_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1587_i;
          _1587_i = BigInteger.Zero;
          bool _1588_allErased;
          _1588_allErased = true;
          while ((_1587_i) < (new BigInteger((_1585_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1589_recursiveGen;
            bool _1590___v45;
            bool _1591_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1592_recIdents;
            Dafny.ISequence<Dafny.Rune> _out968;
            bool _out969;
            bool _out970;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out971;
            DCOMP.COMP.GenExpr((_1585_exprs).Select(_1587_i), @params, true, out _out968, out _out969, out _out970, out _out971);
            _1589_recursiveGen = _out968;
            _1590___v45 = _out969;
            _1591_isErased = _out970;
            _1592_recIdents = _out971;
            _1588_allErased = (_1588_allErased) && (_1591_isErased);
            _1586_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1586_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1589_recursiveGen, _1591_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1592_recIdents);
            _1587_i = (_1587_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1587_i = BigInteger.Zero;
          while ((_1587_i) < (new BigInteger((_1586_generatedValues).Count))) {
            if ((_1587_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1593_gen;
            _1593_gen = ((_1586_generatedValues).Select(_1587_i)).dtor__0;
            if ((((_1586_generatedValues).Select(_1587_i)).dtor__1) && (!(_1588_allErased))) {
              _1593_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1593_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1593_gen);
            _1587_i = (_1587_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _1588_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _1594___mcc_h24 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1595_exprs = _1594___mcc_h24;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1596_generatedValues;
          _1596_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1597_i;
          _1597_i = BigInteger.Zero;
          bool _1598_allErased;
          _1598_allErased = true;
          while ((_1597_i) < (new BigInteger((_1595_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1599_recursiveGen;
            bool _1600___v46;
            bool _1601_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1602_recIdents;
            Dafny.ISequence<Dafny.Rune> _out972;
            bool _out973;
            bool _out974;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out975;
            DCOMP.COMP.GenExpr((_1595_exprs).Select(_1597_i), @params, true, out _out972, out _out973, out _out974, out _out975);
            _1599_recursiveGen = _out972;
            _1600___v46 = _out973;
            _1601_isErased = _out974;
            _1602_recIdents = _out975;
            _1598_allErased = (_1598_allErased) && (_1601_isErased);
            _1596_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1596_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1599_recursiveGen, _1601_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1602_recIdents);
            _1597_i = (_1597_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1597_i = BigInteger.Zero;
          while ((_1597_i) < (new BigInteger((_1596_generatedValues).Count))) {
            if ((_1597_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1603_gen;
            _1603_gen = ((_1596_generatedValues).Select(_1597_i)).dtor__0;
            if ((((_1596_generatedValues).Select(_1597_i)).dtor__1) && (!(_1598_allErased))) {
              _1603_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1603_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1603_gen);
            _1597_i = (_1597_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("].into_iter().collect::<std::collections::HashSet<_>>()"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_This) {
        {
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self.clone()");
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self");
            isOwned = false;
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self"));
          isErased = false;
        }
      } else if (_source19.is_Ite) {
        DAST._IExpression _1604___mcc_h25 = _source19.dtor_cond;
        DAST._IExpression _1605___mcc_h26 = _source19.dtor_thn;
        DAST._IExpression _1606___mcc_h27 = _source19.dtor_els;
        DAST._IExpression _1607_f = _1606___mcc_h27;
        DAST._IExpression _1608_t = _1605___mcc_h26;
        DAST._IExpression _1609_cond = _1604___mcc_h25;
        {
          Dafny.ISequence<Dafny.Rune> _1610_condString;
          bool _1611___v47;
          bool _1612_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1613_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out976;
          bool _out977;
          bool _out978;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out979;
          DCOMP.COMP.GenExpr(_1609_cond, @params, true, out _out976, out _out977, out _out978, out _out979);
          _1610_condString = _out976;
          _1611___v47 = _out977;
          _1612_condErased = _out978;
          _1613_recIdentsCond = _out979;
          if (!(_1612_condErased)) {
            _1610_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1610_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1614___v48;
          bool _1615_tHasToBeOwned;
          bool _1616___v49;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617___v50;
          Dafny.ISequence<Dafny.Rune> _out980;
          bool _out981;
          bool _out982;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out983;
          DCOMP.COMP.GenExpr(_1608_t, @params, mustOwn, out _out980, out _out981, out _out982, out _out983);
          _1614___v48 = _out980;
          _1615_tHasToBeOwned = _out981;
          _1616___v49 = _out982;
          _1617___v50 = _out983;
          Dafny.ISequence<Dafny.Rune> _1618_fString;
          bool _1619_fOwned;
          bool _1620_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1621_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out984;
          bool _out985;
          bool _out986;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out987;
          DCOMP.COMP.GenExpr(_1607_f, @params, _1615_tHasToBeOwned, out _out984, out _out985, out _out986, out _out987);
          _1618_fString = _out984;
          _1619_fOwned = _out985;
          _1620_fErased = _out986;
          _1621_recIdentsF = _out987;
          Dafny.ISequence<Dafny.Rune> _1622_tString;
          bool _1623___v51;
          bool _1624_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1625_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out988;
          bool _out989;
          bool _out990;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out991;
          DCOMP.COMP.GenExpr(_1608_t, @params, _1619_fOwned, out _out988, out _out989, out _out990, out _out991);
          _1622_tString = _out988;
          _1623___v51 = _out989;
          _1624_tErased = _out990;
          _1625_recIdentsT = _out991;
          if ((!(_1620_fErased)) || (!(_1624_tErased))) {
            if (_1620_fErased) {
              _1618_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1618_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_1624_tErased) {
              _1622_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1622_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _1610_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1622_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _1618_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _1619_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1613_recIdentsCond, _1625_recIdentsT), _1621_recIdentsF);
          isErased = (_1620_fErased) || (_1624_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _1626___mcc_h28 = _source19.dtor_unOp;
        DAST._IExpression _1627___mcc_h29 = _source19.dtor_expr;
        DAST._IUnaryOp _source60 = _1626___mcc_h28;
        if (_source60.is_Not) {
          DAST._IExpression _1628_e = _1627___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _1629_recursiveGen;
            bool _1630___v52;
            bool _1631_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1632_recIdents;
            Dafny.ISequence<Dafny.Rune> _out992;
            bool _out993;
            bool _out994;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out995;
            DCOMP.COMP.GenExpr(_1628_e, @params, true, out _out992, out _out993, out _out994, out _out995);
            _1629_recursiveGen = _out992;
            _1630___v52 = _out993;
            _1631_recErased = _out994;
            _1632_recIdents = _out995;
            if (!(_1631_recErased)) {
              _1629_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _1629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1632_recIdents;
            isErased = true;
          }
        } else if (_source60.is_BitwiseNot) {
          DAST._IExpression _1633_e = _1627___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _1634_recursiveGen;
            bool _1635___v53;
            bool _1636_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1637_recIdents;
            Dafny.ISequence<Dafny.Rune> _out996;
            bool _out997;
            bool _out998;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out999;
            DCOMP.COMP.GenExpr(_1633_e, @params, true, out _out996, out _out997, out _out998, out _out999);
            _1634_recursiveGen = _out996;
            _1635___v53 = _out997;
            _1636_recErased = _out998;
            _1637_recIdents = _out999;
            if (!(_1636_recErased)) {
              _1634_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _1634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1637_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _1638_e = _1627___mcc_h29;
          {
            Dafny.ISequence<Dafny.Rune> _1639_recursiveGen;
            bool _1640___v54;
            bool _1641_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1642_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1000;
            bool _out1001;
            bool _out1002;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1003;
            DCOMP.COMP.GenExpr(_1638_e, @params, false, out _out1000, out _out1001, out _out1002, out _out1003);
            _1639_recursiveGen = _out1000;
            _1640___v54 = _out1001;
            _1641_recErased = _out1002;
            _1642_recIdents = _out1003;
            if (!(_1641_recErased)) {
              _1639_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1639_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1639_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len()"));
            isOwned = true;
            readIdents = _1642_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _1643___mcc_h30 = _source19.dtor_op;
        DAST._IExpression _1644___mcc_h31 = _source19.dtor_left;
        DAST._IExpression _1645___mcc_h32 = _source19.dtor_right;
        DAST._IExpression _1646_r = _1645___mcc_h32;
        DAST._IExpression _1647_l = _1644___mcc_h31;
        Dafny.ISequence<Dafny.Rune> _1648_op = _1643___mcc_h30;
        {
          Dafny.ISequence<Dafny.Rune> _1649_left;
          bool _1650___v55;
          bool _1651_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1652_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1004;
          bool _out1005;
          bool _out1006;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1007;
          DCOMP.COMP.GenExpr(_1647_l, @params, true, out _out1004, out _out1005, out _out1006, out _out1007);
          _1649_left = _out1004;
          _1650___v55 = _out1005;
          _1651_leftErased = _out1006;
          _1652_recIdentsL = _out1007;
          Dafny.ISequence<Dafny.Rune> _1653_right;
          bool _1654___v56;
          bool _1655_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1656_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1008;
          bool _out1009;
          bool _out1010;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1011;
          DCOMP.COMP.GenExpr(_1646_r, @params, true, out _out1008, out _out1009, out _out1010, out _out1011);
          _1653_right = _out1008;
          _1654___v56 = _out1009;
          _1655_rightErased = _out1010;
          _1656_recIdentsR = _out1011;
          if (!(_1651_leftErased)) {
            _1649_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1649_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_1655_rightErased)) {
            _1653_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1653_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1648_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _1649_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1653_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_1648_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _1649_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1653_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1649_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1648_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1653_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1652_recIdentsL, _1656_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _1657___mcc_h33 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1658___mcc_h34 = _source19.dtor_field;
        bool _1659___mcc_h35 = _source19.dtor_isConstant;
        bool _1660___mcc_h36 = _source19.dtor_onDatatype;
        bool _1661_isDatatype = _1660___mcc_h36;
        bool _1662_isConstant = _1659___mcc_h35;
        Dafny.ISequence<Dafny.Rune> _1663_field = _1658___mcc_h34;
        DAST._IExpression _1664_on = _1657___mcc_h33;
        {
          Dafny.ISequence<Dafny.Rune> _1665_onString;
          bool _1666_onOwned;
          bool _1667_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1668_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1012;
          bool _out1013;
          bool _out1014;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1015;
          DCOMP.COMP.GenExpr(_1664_on, @params, false, out _out1012, out _out1013, out _out1014, out _out1015);
          _1665_onString = _out1012;
          _1666_onOwned = _out1013;
          _1667_onErased = _out1014;
          _1668_recIdents = _out1015;
          if (!(_1667_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1669_eraseFn;
            _1669_eraseFn = ((_1666_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1665_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1669_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1665_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1661_isDatatype) || (_1662_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1665_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1663_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_1662_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _1665_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1663_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _1668_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _1670___mcc_h37 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1671___mcc_h38 = _source19.dtor_field;
        bool _1672___mcc_h39 = _source19.dtor_onDatatype;
        bool _1673___mcc_h40 = _source19.dtor_isStatic;
        BigInteger _1674___mcc_h41 = _source19.dtor_arity;
        BigInteger _1675_arity = _1674___mcc_h41;
        bool _1676_isStatic = _1673___mcc_h40;
        bool _1677_isDatatype = _1672___mcc_h39;
        Dafny.ISequence<Dafny.Rune> _1678_field = _1671___mcc_h38;
        DAST._IExpression _1679_on = _1670___mcc_h37;
        {
          Dafny.ISequence<Dafny.Rune> _1680_onString;
          bool _1681_onOwned;
          bool _1682___v57;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1016;
          bool _out1017;
          bool _out1018;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1019;
          DCOMP.COMP.GenExpr(_1679_on, @params, false, out _out1016, out _out1017, out _out1018, out _out1019);
          _1680_onString = _out1016;
          _1681_onOwned = _out1017;
          _1682___v57 = _out1018;
          _1683_recIdents = _out1019;
          if (_1676_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1680_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _1678_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _1680_onString), ((_1681_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _1684_args;
            _1684_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _1685_i;
            _1685_i = BigInteger.Zero;
            while ((_1685_i) < (_1675_arity)) {
              if ((_1685_i).Sign == 1) {
                _1684_args = Dafny.Sequence<Dafny.Rune>.Concat(_1684_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _1684_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1684_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_1685_i));
              _1685_i = (_1685_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _1684_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _1678_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1684_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _1683_recIdents;
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _1686___mcc_h42 = _source19.dtor_expr;
        BigInteger _1687___mcc_h43 = _source19.dtor_index;
        BigInteger _1688_idx = _1687___mcc_h43;
        DAST._IExpression _1689_on = _1686___mcc_h42;
        {
          Dafny.ISequence<Dafny.Rune> _1690_onString;
          bool _1691___v58;
          bool _1692_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1693_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1020;
          bool _out1021;
          bool _out1022;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1023;
          DCOMP.COMP.GenExpr(_1689_on, @params, false, out _out1020, out _out1021, out _out1022, out _out1023);
          _1690_onString = _out1020;
          _1691___v58 = _out1021;
          _1692_tupErased = _out1022;
          _1693_recIdents = _out1023;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1690_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_1688_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _1692_tupErased;
          readIdents = _1693_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _1694___mcc_h44 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _1695___mcc_h45 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _1696___mcc_h46 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _1697___mcc_h47 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1698_args = _1697___mcc_h47;
        Dafny.ISequence<DAST._IType> _1699_typeArgs = _1696___mcc_h46;
        Dafny.ISequence<Dafny.Rune> _1700_name = _1695___mcc_h45;
        DAST._IExpression _1701_on = _1694___mcc_h44;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1702_typeArgString;
          _1702_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_1699_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _1703_typeI;
            _1703_typeI = BigInteger.Zero;
            _1702_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_1703_typeI) < (new BigInteger((_1699_typeArgs).Count))) {
              if ((_1703_typeI).Sign == 1) {
                _1702_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1702_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _1704_typeString;
              Dafny.ISequence<Dafny.Rune> _out1024;
              _out1024 = DCOMP.COMP.GenType((_1699_typeArgs).Select(_1703_typeI), false, false);
              _1704_typeString = _out1024;
              _1702_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1702_typeArgString, _1704_typeString);
              _1703_typeI = (_1703_typeI) + (BigInteger.One);
            }
            _1702_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1702_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _1705_argString;
          _1705_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1706_i;
          _1706_i = BigInteger.Zero;
          while ((_1706_i) < (new BigInteger((_1698_args).Count))) {
            if ((_1706_i).Sign == 1) {
              _1705_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1705_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1707_argExpr;
            bool _1708_isOwned;
            bool _1709_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1710_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1025;
            bool _out1026;
            bool _out1027;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1028;
            DCOMP.COMP.GenExpr((_1698_args).Select(_1706_i), @params, false, out _out1025, out _out1026, out _out1027, out _out1028);
            _1707_argExpr = _out1025;
            _1708_isOwned = _out1026;
            _1709_argErased = _out1027;
            _1710_argIdents = _out1028;
            if (_1708_isOwned) {
              _1707_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1707_argExpr);
            }
            _1705_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1705_argString, _1707_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1710_argIdents);
            _1706_i = (_1706_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1711_enclosingString;
          bool _1712___v59;
          bool _1713___v60;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1714_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1029;
          bool _out1030;
          bool _out1031;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1032;
          DCOMP.COMP.GenExpr(_1701_on, @params, false, out _out1029, out _out1030, out _out1031, out _out1032);
          _1711_enclosingString = _out1029;
          _1712___v59 = _out1030;
          _1713___v60 = _out1031;
          _1714_recIdents = _out1032;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1714_recIdents);
          DAST._IExpression _source61 = _1701_on;
          if (_source61.is_Literal) {
            DAST._ILiteral _1715___mcc_h680 = _source61.dtor_Literal_a0;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _1716___mcc_h682 = _source61.dtor_Ident_a0;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1717___mcc_h684 = _source61.dtor_Companion_a0;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_1711_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source61.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _1718___mcc_h686 = _source61.dtor_Tuple_a0;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1719___mcc_h688 = _source61.dtor_path;
            Dafny.ISequence<DAST._IExpression> _1720___mcc_h689 = _source61.dtor_args;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _1721___mcc_h692 = _source61.dtor_dims;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1722___mcc_h694 = _source61.dtor_path;
            Dafny.ISequence<Dafny.Rune> _1723___mcc_h695 = _source61.dtor_variant;
            bool _1724___mcc_h696 = _source61.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _1725___mcc_h697 = _source61.dtor_contents;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Convert) {
            DAST._IExpression _1726___mcc_h702 = _source61.dtor_value;
            DAST._IType _1727___mcc_h703 = _source61.dtor_from;
            DAST._IType _1728___mcc_h704 = _source61.dtor_typ;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_SubsetDowngrade) {
            DAST._IExpression _1729___mcc_h708 = _source61.dtor_value;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _1730___mcc_h710 = _source61.dtor_elements;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _1731___mcc_h712 = _source61.dtor_elements;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_This) {
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Ite) {
            DAST._IExpression _1732___mcc_h714 = _source61.dtor_cond;
            DAST._IExpression _1733___mcc_h715 = _source61.dtor_thn;
            DAST._IExpression _1734___mcc_h716 = _source61.dtor_els;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_UnOp) {
            DAST._IUnaryOp _1735___mcc_h720 = _source61.dtor_unOp;
            DAST._IExpression _1736___mcc_h721 = _source61.dtor_expr;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _1737___mcc_h724 = _source61.dtor_op;
            DAST._IExpression _1738___mcc_h725 = _source61.dtor_left;
            DAST._IExpression _1739___mcc_h726 = _source61.dtor_right;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Select) {
            DAST._IExpression _1740___mcc_h730 = _source61.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1741___mcc_h731 = _source61.dtor_field;
            bool _1742___mcc_h732 = _source61.dtor_isConstant;
            bool _1743___mcc_h733 = _source61.dtor_onDatatype;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_SelectFn) {
            DAST._IExpression _1744___mcc_h738 = _source61.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1745___mcc_h739 = _source61.dtor_field;
            bool _1746___mcc_h740 = _source61.dtor_onDatatype;
            bool _1747___mcc_h741 = _source61.dtor_isStatic;
            BigInteger _1748___mcc_h742 = _source61.dtor_arity;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_TupleSelect) {
            DAST._IExpression _1749___mcc_h748 = _source61.dtor_expr;
            BigInteger _1750___mcc_h749 = _source61.dtor_index;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Call) {
            DAST._IExpression _1751___mcc_h752 = _source61.dtor_on;
            Dafny.ISequence<Dafny.Rune> _1752___mcc_h753 = _source61.dtor_name;
            Dafny.ISequence<DAST._IType> _1753___mcc_h754 = _source61.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _1754___mcc_h755 = _source61.dtor_args;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _1755___mcc_h760 = _source61.dtor_params;
            DAST._IType _1756___mcc_h761 = _source61.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _1757___mcc_h762 = _source61.dtor_body;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _1758___mcc_h766 = _source61.dtor_name;
            DAST._IType _1759___mcc_h767 = _source61.dtor_typ;
            DAST._IExpression _1760___mcc_h768 = _source61.dtor_value;
            DAST._IExpression _1761___mcc_h769 = _source61.dtor_iifeBody;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_Apply) {
            DAST._IExpression _1762___mcc_h774 = _source61.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _1763___mcc_h775 = _source61.dtor_args;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source61.is_TypeTest) {
            DAST._IExpression _1764___mcc_h778 = _source61.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1765___mcc_h779 = _source61.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _1766___mcc_h780 = _source61.dtor_variant;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _1767___mcc_h784 = _source61.dtor_typ;
            {
              _1711_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1711_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_1700_name)), _1702_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1705_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _1768___mcc_h48 = _source19.dtor_params;
        DAST._IType _1769___mcc_h49 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _1770___mcc_h50 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _1771_body = _1770___mcc_h50;
        DAST._IType _1772_retType = _1769___mcc_h49;
        Dafny.ISequence<DAST._IFormal> _1773_params = _1768___mcc_h48;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1774_paramNames;
          _1774_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1775_i;
          _1775_i = BigInteger.Zero;
          while ((_1775_i) < (new BigInteger((_1773_params).Count))) {
            _1774_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_1774_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_1773_params).Select(_1775_i)).dtor_name));
            _1775_i = (_1775_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1776_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1777_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1033;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
          DCOMP.COMP.GenStmts(_1771_body, _1774_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1033, out _out1034);
          _1776_recursiveGen = _out1033;
          _1777_recIdents = _out1034;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1778_allReadCloned;
          _1778_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_1777_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _1779_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_1777_recIdents).Elements) {
              _1779_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_1777_recIdents).Contains(_1779_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1422)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_1774_paramNames).Contains(_1779_next))) {
              _1778_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1778_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _1779_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _1779_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_1779_next));
            }
            _1777_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_1777_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_1779_next));
          }
          Dafny.ISequence<Dafny.Rune> _1780_paramsString;
          _1780_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _1775_i = BigInteger.Zero;
          while ((_1775_i) < (new BigInteger((_1773_params).Count))) {
            if ((_1775_i).Sign == 1) {
              _1780_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_1780_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1781_typStr;
            Dafny.ISequence<Dafny.Rune> _out1035;
            _out1035 = DCOMP.COMP.GenType(((_1773_params).Select(_1775_i)).dtor_typ, false, true);
            _1781_typStr = _out1035;
            _1780_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1780_paramsString, ((_1773_params).Select(_1775_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _1781_typStr);
            _1775_i = (_1775_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1782_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1036;
          _out1036 = DCOMP.COMP.GenType(_1772_retType, false, true);
          _1782_retTypeGen = _out1036;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _1778_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _1780_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _1782_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1776_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _1783___mcc_h51 = _source19.dtor_name;
        DAST._IType _1784___mcc_h52 = _source19.dtor_typ;
        DAST._IExpression _1785___mcc_h53 = _source19.dtor_value;
        DAST._IExpression _1786___mcc_h54 = _source19.dtor_iifeBody;
        DAST._IExpression _1787_iifeBody = _1786___mcc_h54;
        DAST._IExpression _1788_value = _1785___mcc_h53;
        DAST._IType _1789_tpe = _1784___mcc_h52;
        Dafny.ISequence<Dafny.Rune> _1790_name = _1783___mcc_h51;
        {
          Dafny.ISequence<Dafny.Rune> _1791_valueGen;
          bool _1792_valueOwned;
          bool _1793_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1794_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1037;
          bool _out1038;
          bool _out1039;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1040;
          DCOMP.COMP.GenExpr(_1788_value, @params, false, out _out1037, out _out1038, out _out1039, out _out1040);
          _1791_valueGen = _out1037;
          _1792_valueOwned = _out1038;
          _1793_valueErased = _out1039;
          _1794_recIdents = _out1040;
          if (_1793_valueErased) {
            Dafny.ISequence<Dafny.Rune> _1795_eraseFn;
            _1795_eraseFn = ((_1792_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _1791_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _1795_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1791_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _1794_recIdents;
          Dafny.ISequence<Dafny.Rune> _1796_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1041;
          _out1041 = DCOMP.COMP.GenType(_1789_tpe, false, true);
          _1796_valueTypeGen = _out1041;
          Dafny.ISequence<Dafny.Rune> _1797_bodyGen;
          bool _1798_bodyOwned;
          bool _1799_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1800_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1042;
          bool _out1043;
          bool _out1044;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1045;
          DCOMP.COMP.GenExpr(_1787_iifeBody, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_1792_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_1790_name))))), mustOwn, out _out1042, out _out1043, out _out1044, out _out1045);
          _1797_bodyGen = _out1042;
          _1798_bodyOwned = _out1043;
          _1799_bodyErased = _out1044;
          _1800_bodyIdents = _out1045;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1800_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _1801_eraseFn;
          _1801_eraseFn = ((_1792_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_1790_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_1792_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _1796_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _1791_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _1797_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _1798_bodyOwned;
          isErased = _1799_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _1802___mcc_h55 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _1803___mcc_h56 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1804_args = _1803___mcc_h56;
        DAST._IExpression _1805_func = _1802___mcc_h55;
        {
          Dafny.ISequence<Dafny.Rune> _1806_funcString;
          bool _1807___v63;
          bool _1808_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1809_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1046;
          bool _out1047;
          bool _out1048;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1049;
          DCOMP.COMP.GenExpr(_1805_func, @params, false, out _out1046, out _out1047, out _out1048, out _out1049);
          _1806_funcString = _out1046;
          _1807___v63 = _out1047;
          _1808_funcErased = _out1048;
          _1809_recIdents = _out1049;
          readIdents = _1809_recIdents;
          Dafny.ISequence<Dafny.Rune> _1810_argString;
          _1810_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1811_i;
          _1811_i = BigInteger.Zero;
          while ((_1811_i) < (new BigInteger((_1804_args).Count))) {
            if ((_1811_i).Sign == 1) {
              _1810_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1810_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1812_argExpr;
            bool _1813_isOwned;
            bool _1814_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1815_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1050;
            bool _out1051;
            bool _out1052;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1053;
            DCOMP.COMP.GenExpr((_1804_args).Select(_1811_i), @params, false, out _out1050, out _out1051, out _out1052, out _out1053);
            _1812_argExpr = _out1050;
            _1813_isOwned = _out1051;
            _1814_argErased = _out1052;
            _1815_argIdents = _out1053;
            if (_1813_isOwned) {
              _1812_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1812_argExpr);
            }
            _1810_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1810_argString, _1812_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1815_argIdents);
            _1811_i = (_1811_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1806_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1810_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _1816___mcc_h57 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1817___mcc_h58 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _1818___mcc_h59 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _1819_variant = _1818___mcc_h59;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1820_dType = _1817___mcc_h58;
        DAST._IExpression _1821_on = _1816___mcc_h57;
        {
          Dafny.ISequence<Dafny.Rune> _1822_exprGen;
          bool _1823___v64;
          bool _1824_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1825_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1054;
          bool _out1055;
          bool _out1056;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1057;
          DCOMP.COMP.GenExpr(_1821_on, @params, false, out _out1054, out _out1055, out _out1056, out _out1057);
          _1822_exprGen = _out1054;
          _1823___v64 = _out1055;
          _1824_exprErased = _out1056;
          _1825_recIdents = _out1057;
          Dafny.ISequence<Dafny.Rune> _1826_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1058;
          _out1058 = DCOMP.COMP.GenPath(_1820_dType);
          _1826_dTypePath = _out1058;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _1822_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _1826_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _1819_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _1825_recIdents;
        }
      } else {
        DAST._IType _1827___mcc_h60 = _source19.dtor_typ;
        DAST._IType _1828_typ = _1827___mcc_h60;
        {
          Dafny.ISequence<Dafny.Rune> _1829_typString;
          Dafny.ISequence<Dafny.Rune> _out1059;
          _out1059 = DCOMP.COMP.GenType(_1828_typ, false, false);
          _1829_typString = _out1059;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1829_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _1830_i;
      _1830_i = BigInteger.Zero;
      while ((_1830_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _1831_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1060;
        _out1060 = DCOMP.COMP.GenModule((p).Select(_1830_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _1831_generated = _out1060;
        if ((_1830_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1831_generated);
        _1830_i = (_1830_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _1832_i;
      _1832_i = BigInteger.Zero;
      while ((_1832_i) < (new BigInteger((fullName).Count))) {
        if ((_1832_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_1832_i));
        _1832_i = (_1832_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

