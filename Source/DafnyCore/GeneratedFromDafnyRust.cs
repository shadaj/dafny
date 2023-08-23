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
          } else if (_source2.is_Tuple) {
            Dafny.ISequence<DAST._IType> _48___mcc_h13 = _source2.dtor_Tuple_a0;
          } else if (_source2.is_Array) {
            DAST._IType _49___mcc_h15 = _source2.dtor_element;
          } else if (_source2.is_Seq) {
            DAST._IType _50___mcc_h17 = _source2.dtor_element;
          } else if (_source2.is_Set) {
            DAST._IType _51___mcc_h19 = _source2.dtor_element;
          } else if (_source2.is_Multiset) {
            DAST._IType _52___mcc_h21 = _source2.dtor_element;
          } else if (_source2.is_Map) {
            DAST._IType _53___mcc_h23 = _source2.dtor_key;
            DAST._IType _54___mcc_h24 = _source2.dtor_value;
          } else if (_source2.is_Arrow) {
            Dafny.ISequence<DAST._IType> _55___mcc_h27 = _source2.dtor_args;
            DAST._IType _56___mcc_h28 = _source2.dtor_result;
          } else if (_source2.is_Primitive) {
            DAST._IPrimitive _57___mcc_h31 = _source2.dtor_Primitive_a0;
          } else if (_source2.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _58___mcc_h33 = _source2.dtor_Passthrough_a0;
          } else {
            Dafny.ISequence<Dafny.Rune> _59___mcc_h35 = _source2.dtor_TypeArg_a0;
          }
          _34_i = (_34_i) + (BigInteger.One);
        }
      }
      Dafny.ISequence<Dafny.Rune> _60_defaultImpl;
      _60_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::default::Default for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _60_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn default() -> Self {\n"));
      _60_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_60_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (c).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new()\n"));
      _60_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      _60_defaultImpl = Dafny.Sequence<Dafny.Rune>.Concat(_60_defaultImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
      Dafny.ISequence<Dafny.Rune> _61_printImpl;
      _61_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::dafny_runtime::DafnyPrint for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn fmt_print(&self, __fmt_print_formatter: &mut ::std::fmt::Formatter, _in_seq: bool) -> std::fmt::Result {\n"));
      _61_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_61_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("write!(__fmt_print_formatter, \"")), ((c).dtor_enclosingModule)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), (c).dtor_name), (((new BigInteger(((c).dtor_fields).Count)).Sign == 1) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\")?;"));
      BigInteger _62_i;
      _62_i = BigInteger.Zero;
      while ((_62_i) < (new BigInteger(((c).dtor_fields).Count))) {
        DAST._IField _63_field;
        _63_field = ((c).dtor_fields).Select(_62_i);
        if ((_62_i).Sign == 1) {
          _61_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_61_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \", \")?;"));
        }
        _61_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_61_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n::dafny_runtime::DafnyPrint::fmt_print(::std::ops::Deref::deref(&(self.r#")), ((_63_field).dtor_formal).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow())), __fmt_print_formatter, false)?;"));
        _62_i = (_62_i) + (BigInteger.One);
      }
      if ((new BigInteger(((c).dtor_fields).Count)).Sign == 1) {
        _61_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_61_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nwrite!(__fmt_print_formatter, \")\")?;"));
      }
      _61_printImpl = Dafny.Sequence<Dafny.Rune>.Concat(_61_printImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nOk(())\n}\n}\n"));
      Dafny.ISequence<Dafny.Rune> _64_ptrPartialEqImpl;
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), _18_constrainedTypeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ::std::cmp::PartialEq for r#")), (c).dtor_name), _17_typeParams), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n"));
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_64_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn eq(&self, other: &Self) -> bool {\n"));
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_64_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ptr::eq(self, other)"));
      _64_ptrPartialEqImpl = Dafny.Sequence<Dafny.Rune>.Concat(_64_ptrPartialEqImpl, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n}\n"));
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _60_defaultImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _61_printImpl), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _64_ptrPartialEqImpl);
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
          DCOMP.COMP.GenExpr(_78_e, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out28, out _out29, out _out30, out _out31);
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
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _131___mcc_h16 = _source6.dtor_path;
            {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
            }
          } else if (_source6.is_Trait) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _132___mcc_h18 = _source6.dtor_path;
            {
              if (inBinding) {
                s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("_");
              } else {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("impl "), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""));
              }
            }
          } else {
            DAST._IType _133___mcc_h20 = _source6.dtor_Newtype_a0;
            DAST._IResolvedType _134_Primitive = _127_resolved;
          }
        }
      } else if (_source5.is_Tuple) {
        Dafny.ISequence<DAST._IType> _135___mcc_h3 = _source5.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IType> _136_types = _135___mcc_h3;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          BigInteger _137_i;
          _137_i = BigInteger.Zero;
          while ((_137_i) < (new BigInteger((_136_types).Count))) {
            if ((_137_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _138_generated;
            Dafny.ISequence<Dafny.Rune> _out43;
            _out43 = DCOMP.COMP.GenType((_136_types).Select(_137_i), inBinding, inFn);
            _138_generated = _out43;
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _138_generated), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            _137_i = (_137_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
        }
      } else if (_source5.is_Array) {
        DAST._IType _139___mcc_h4 = _source5.dtor_element;
        DAST._IType _140_element = _139___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _141_elemStr;
          Dafny.ISequence<Dafny.Rune> _out44;
          _out44 = DCOMP.COMP.GenType(_140_element, inBinding, inFn);
          _141_elemStr = _out44;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc<::std::cell::RefCell<::std::vec::Vec<"), _141_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">>>"));
        }
      } else if (_source5.is_Seq) {
        DAST._IType _142___mcc_h5 = _source5.dtor_element;
        DAST._IType _143_element = _142___mcc_h5;
        {
          Dafny.ISequence<Dafny.Rune> _144_elemStr;
          Dafny.ISequence<Dafny.Rune> _out45;
          _out45 = DCOMP.COMP.GenType(_143_element, inBinding, inFn);
          _144_elemStr = _out45;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _144_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Set) {
        DAST._IType _145___mcc_h6 = _source5.dtor_element;
        DAST._IType _146_element = _145___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _147_elemStr;
          Dafny.ISequence<Dafny.Rune> _out46;
          _out46 = DCOMP.COMP.GenType(_146_element, inBinding, inFn);
          _147_elemStr = _out46;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashSet<"), _147_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Multiset) {
        DAST._IType _148___mcc_h7 = _source5.dtor_element;
        DAST._IType _149_element = _148___mcc_h7;
        {
          Dafny.ISequence<Dafny.Rune> _150_elemStr;
          Dafny.ISequence<Dafny.Rune> _out47;
          _out47 = DCOMP.COMP.GenType(_149_element, inBinding, inFn);
          _150_elemStr = _out47;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _150_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", u64>"));
        }
      } else if (_source5.is_Map) {
        DAST._IType _151___mcc_h8 = _source5.dtor_key;
        DAST._IType _152___mcc_h9 = _source5.dtor_value;
        DAST._IType _153_value = _152___mcc_h9;
        DAST._IType _154_key = _151___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _155_keyStr;
          Dafny.ISequence<Dafny.Rune> _out48;
          _out48 = DCOMP.COMP.GenType(_154_key, inBinding, inFn);
          _155_keyStr = _out48;
          Dafny.ISequence<Dafny.Rune> _156_valueStr;
          Dafny.ISequence<Dafny.Rune> _out49;
          _out49 = DCOMP.COMP.GenType(_153_value, inBinding, inFn);
          _156_valueStr = _out49;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::collections::HashMap<"), _155_keyStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _156_valueStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
        }
      } else if (_source5.is_Arrow) {
        Dafny.ISequence<DAST._IType> _157___mcc_h10 = _source5.dtor_args;
        DAST._IType _158___mcc_h11 = _source5.dtor_result;
        DAST._IType _159_result = _158___mcc_h11;
        Dafny.ISequence<DAST._IType> _160_args = _157___mcc_h10;
        {
          if (inBinding) {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<_>");
          } else {
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<::std::boxed::Box<dyn ::std::ops::Fn(");
            } else {
              s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper<impl ::std::ops::Fn(");
            }
            BigInteger _161_i;
            _161_i = BigInteger.Zero;
            while ((_161_i) < (new BigInteger((_160_args).Count))) {
              if ((_161_i).Sign == 1) {
                s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _162_generated;
              Dafny.ISequence<Dafny.Rune> _out50;
              _out50 = DCOMP.COMP.GenType((_160_args).Select(_161_i), inBinding, true);
              _162_generated = _out50;
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")), _162_generated);
              _161_i = (_161_i) + (BigInteger.One);
            }
            Dafny.ISequence<Dafny.Rune> _163_resultType;
            Dafny.ISequence<Dafny.Rune> _out51;
            _out51 = DCOMP.COMP.GenType(_159_result, inBinding, inFn);
            _163_resultType = _out51;
            if (inFn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _163_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + 'static>>"));
            } else {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _163_resultType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" + Clone + 'static>"));
            }
          }
        }
      } else if (_source5.is_Primitive) {
        DAST._IPrimitive _164___mcc_h12 = _source5.dtor_Primitive_a0;
        DAST._IPrimitive _165_p = _164___mcc_h12;
        {
          DAST._IPrimitive _source7 = _165_p;
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
        Dafny.ISequence<Dafny.Rune> _166___mcc_h13 = _source5.dtor_Passthrough_a0;
        Dafny.ISequence<Dafny.Rune> _167_v = _166___mcc_h13;
        s = _167_v;
      } else {
        Dafny.ISequence<Dafny.Rune> _168___mcc_h14 = _source5.dtor_TypeArg_a0;
        Dafny.ISequence<Dafny.Rune> _source8 = _168___mcc_h14;
        Dafny.ISequence<Dafny.Rune> _169___mcc_h15 = _source8;
        Dafny.ISequence<Dafny.Rune> _170_name = _169___mcc_h15;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _170_name);
      }
      return s;
    }
    public static void GenClassImplBody(Dafny.ISequence<DAST._IMethod> body, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams, out Dafny.ISequence<Dafny.Rune> s, out Dafny.IMap<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>> traitBodies) {
      s = Dafny.Sequence<Dafny.Rune>.Empty;
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _171_i;
      _171_i = BigInteger.Zero;
      while ((_171_i) < (new BigInteger((body).Count))) {
        DAST._IMethod _source9 = (body).Select(_171_i);
        DAST._IMethod _172___mcc_h0 = _source9;
        DAST._IMethod _173_m = _172___mcc_h0;
        {
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source10 = (_173_m).dtor_overridingPath;
          if (_source10.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _174___mcc_h1 = _source10.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _175_p = _174___mcc_h1;
            {
              Dafny.ISequence<Dafny.Rune> _176_existing;
              _176_existing = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              if ((traitBodies).Contains(_175_p)) {
                _176_existing = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Select(traitBodies, _175_p);
              }
              if ((new BigInteger((_176_existing).Count)).Sign == 1) {
                _176_existing = Dafny.Sequence<Dafny.Rune>.Concat(_176_existing, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
              }
              Dafny.ISequence<Dafny.Rune> _177_genMethod;
              Dafny.ISequence<Dafny.Rune> _out52;
              _out52 = DCOMP.COMP.GenMethod(_173_m, true, enclosingType, enclosingTypeParams);
              _177_genMethod = _out52;
              _176_existing = Dafny.Sequence<Dafny.Rune>.Concat(_176_existing, _177_genMethod);
              traitBodies = Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.Merge(traitBodies, Dafny.Map<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>.FromElements(new Dafny.Pair<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>, Dafny.ISequence<Dafny.Rune>>(_175_p, _176_existing)));
            }
          } else {
            {
              Dafny.ISequence<Dafny.Rune> _178_generated;
              Dafny.ISequence<Dafny.Rune> _out53;
              _out53 = DCOMP.COMP.GenMethod(_173_m, forTrait, enclosingType, enclosingTypeParams);
              _178_generated = _out53;
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, _178_generated);
            }
          }
        }
        if ((new BigInteger((s).Count)).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        _171_i = (_171_i) + (BigInteger.One);
      }
    }
    public static Dafny.ISequence<Dafny.Rune> GenParams(Dafny.ISequence<DAST._IFormal> @params) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
      BigInteger _179_i;
      _179_i = BigInteger.Zero;
      while ((_179_i) < (new BigInteger((@params).Count))) {
        DAST._IFormal _180_param;
        _180_param = (@params).Select(_179_i);
        Dafny.ISequence<Dafny.Rune> _181_paramType;
        Dafny.ISequence<Dafny.Rune> _out54;
        _out54 = DCOMP.COMP.GenType((_180_param).dtor_typ, false, false);
        _181_paramType = _out54;
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_180_param).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _181_paramType);
        if ((_179_i) < ((new BigInteger((@params).Count)) - (BigInteger.One))) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        _179_i = (_179_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> GenMethod(DAST._IMethod m, bool forTrait, DAST._IType enclosingType, Dafny.ISet<DAST._IType> enclosingTypeParams) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      Dafny.ISequence<Dafny.Rune> _182_params;
      Dafny.ISequence<Dafny.Rune> _out55;
      _out55 = DCOMP.COMP.GenParams((m).dtor_params);
      _182_params = _out55;
      Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _183_paramNames;
      _183_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
      BigInteger _184_paramI;
      _184_paramI = BigInteger.Zero;
      while ((_184_paramI) < (new BigInteger(((m).dtor_params).Count))) {
        _183_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_183_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((((m).dtor_params).Select(_184_paramI)).dtor_name));
        _184_paramI = (_184_paramI) + (BigInteger.One);
      }
      if (!((m).dtor_isStatic)) {
        if (forTrait) {
          _182_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&self"), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _182_params);
        } else {
          Dafny.ISequence<Dafny.Rune> _185_enclosingTypeString;
          Dafny.ISequence<Dafny.Rune> _out56;
          _out56 = DCOMP.COMP.GenType(enclosingType, false, false);
          _185_enclosingTypeString = _out56;
          _182_params = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("self: &"), _185_enclosingTypeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _182_params);
        }
      }
      Dafny.ISequence<Dafny.Rune> _186_retType;
      _186_retType = (((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")));
      BigInteger _187_typeI;
      _187_typeI = BigInteger.Zero;
      while ((_187_typeI) < (new BigInteger(((m).dtor_outTypes).Count))) {
        if ((_187_typeI).Sign == 1) {
          _186_retType = Dafny.Sequence<Dafny.Rune>.Concat(_186_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
        }
        Dafny.ISequence<Dafny.Rune> _188_typeString;
        Dafny.ISequence<Dafny.Rune> _out57;
        _out57 = DCOMP.COMP.GenType(((m).dtor_outTypes).Select(_187_typeI), false, false);
        _188_typeString = _out57;
        _186_retType = Dafny.Sequence<Dafny.Rune>.Concat(_186_retType, _188_typeString);
        _187_typeI = (_187_typeI) + (BigInteger.One);
      }
      if ((new BigInteger(((m).dtor_outTypes).Count)) != (BigInteger.One)) {
        _186_retType = Dafny.Sequence<Dafny.Rune>.Concat(_186_retType, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
      }
      if (forTrait) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("fn r#"), (m).dtor_name);
      } else {
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("pub fn r#"), (m).dtor_name);
      }
      Dafny.ISequence<DAST._IType> _189_typeParamsFiltered;
      _189_typeParamsFiltered = Dafny.Sequence<DAST._IType>.FromElements();
      BigInteger _190_typeParamI;
      _190_typeParamI = BigInteger.Zero;
      while ((_190_typeParamI) < (new BigInteger(((m).dtor_typeParams).Count))) {
        DAST._IType _191_typeParam;
        _191_typeParam = ((m).dtor_typeParams).Select(_190_typeParamI);
        if (!((enclosingTypeParams).Contains(_191_typeParam))) {
          _189_typeParamsFiltered = Dafny.Sequence<DAST._IType>.Concat(_189_typeParamsFiltered, Dafny.Sequence<DAST._IType>.FromElements(_191_typeParam));
        }
        _190_typeParamI = (_190_typeParamI) + (BigInteger.One);
      }
      if ((new BigInteger((_189_typeParamsFiltered).Count)).Sign == 1) {
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"));
        BigInteger _192_i;
        _192_i = BigInteger.Zero;
        while ((_192_i) < (new BigInteger((_189_typeParamsFiltered).Count))) {
          if ((_192_i).Sign == 1) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
          }
          Dafny.ISequence<Dafny.Rune> _193_typeString;
          Dafny.ISequence<Dafny.Rune> _out58;
          _out58 = DCOMP.COMP.GenType((_189_typeParamsFiltered).Select(_192_i), false, false);
          _193_typeString = _out58;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _193_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::DafnyErasable + ::dafny_runtime::DafnyUnerasable<")), _193_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("> + Clone + ::std::cmp::PartialEq + ::dafny_runtime::DafnyPrint + ::std::default::Default + 'static"));
          _192_i = (_192_i) + (BigInteger.One);
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _182_params), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") -> ")), _186_retType);
      if ((m).dtor_hasBody) {
        Dafny.ISequence<Dafny.Rune> _194_earlyReturn;
        _194_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return;");
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source11 = (m).dtor_outVars;
        if (_source11.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _195___mcc_h0 = _source11.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _196_outVars = _195___mcc_h0;
          {
            _194_earlyReturn = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return (");
            BigInteger _197_outI;
            _197_outI = BigInteger.Zero;
            while ((_197_outI) < (new BigInteger((_196_outVars).Count))) {
              if ((_197_outI).Sign == 1) {
                _194_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_194_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _198_outVar;
              _198_outVar = (_196_outVars).Select(_197_outI);
              _194_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_194_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_198_outVar));
              _197_outI = (_197_outI) + (BigInteger.One);
            }
            _194_earlyReturn = Dafny.Sequence<Dafny.Rune>.Concat(_194_earlyReturn, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
          }
        } else {
        }
        Dafny.ISequence<Dafny.Rune> _199_body;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _200___v12;
        Dafny.ISequence<Dafny.Rune> _out59;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out60;
        DCOMP.COMP.GenStmts((m).dtor_body, _183_paramNames, true, _194_earlyReturn, out _out59, out _out60);
        _199_body = _out59;
        _200___v12 = _out60;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source12 = (m).dtor_outVars;
        if (_source12.is_Some) {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _201___mcc_h1 = _source12.dtor_Some_a0;
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _202_outVars = _201___mcc_h1;
          {
            _199_body = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_199_body, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n")), _194_earlyReturn);
          }
        } else {
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _199_body), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}\n"));
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
      BigInteger _203_i;
      _203_i = BigInteger.Zero;
      while ((_203_i) < (new BigInteger((stmts).Count))) {
        DAST._IStatement _204_stmt;
        _204_stmt = (stmts).Select(_203_i);
        Dafny.ISequence<Dafny.Rune> _205_stmtString;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _206_recIdents;
        Dafny.ISequence<Dafny.Rune> _out61;
        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out62;
        DCOMP.COMP.GenStmt(_204_stmt, @params, (isLast) && ((_203_i) == ((new BigInteger((stmts).Count)) - (BigInteger.One))), earlyReturn, out _out61, out _out62);
        _205_stmtString = _out61;
        _206_recIdents = _out62;
        readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _206_recIdents);
        if ((_203_i).Sign == 1) {
          generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        generated = Dafny.Sequence<Dafny.Rune>.Concat(generated, _205_stmtString);
        _203_i = (_203_i) + (BigInteger.One);
      }
    }
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.Rune> rhs, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      needsIIFE = false;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IAssignLhs _source13 = lhs;
      if (_source13.is_Ident) {
        Dafny.ISequence<Dafny.Rune> _207___mcc_h0 = _source13.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _source14 = _207___mcc_h0;
        Dafny.ISequence<Dafny.Rune> _208___mcc_h1 = _source14;
        Dafny.ISequence<Dafny.Rune> _209_id = _208___mcc_h1;
        {
          if ((@params).Contains(_209_id)) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*r#"), _209_id);
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _209_id);
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_209_id);
          needsIIFE = false;
        }
      } else if (_source13.is_Select) {
        DAST._IExpression _210___mcc_h2 = _source13.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _211___mcc_h3 = _source13.dtor_field;
        Dafny.ISequence<Dafny.Rune> _212_field = _211___mcc_h3;
        DAST._IExpression _213_on = _210___mcc_h2;
        {
          Dafny.ISequence<Dafny.Rune> _214_onExpr;
          bool _215_onOwned;
          bool _216_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _217_recIdents;
          Dafny.ISequence<Dafny.Rune> _out63;
          bool _out64;
          bool _out65;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out66;
          DCOMP.COMP.GenExpr(_213_on, @params, false, out _out63, out _out64, out _out65, out _out66);
          _214_onExpr = _out63;
          _215_onOwned = _out64;
          _216_onErased = _out65;
          _217_recIdents = _out66;
          if (!(_216_onErased)) {
            Dafny.ISequence<Dafny.Rune> _218_eraseFn;
            _218_eraseFn = ((_215_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _214_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _218_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _214_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _214_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _212_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()) = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          readIdents = _217_recIdents;
          needsIIFE = true;
        }
      } else {
        DAST._IExpression _219___mcc_h4 = _source13.dtor_expr;
        DAST._IExpression _220___mcc_h5 = _source13.dtor_idx;
        DAST._IExpression _221_idx = _220___mcc_h5;
        DAST._IExpression _222_on = _219___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _223_onExpr;
          bool _224_onOwned;
          bool _225_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _226_recIdents;
          Dafny.ISequence<Dafny.Rune> _out67;
          bool _out68;
          bool _out69;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out70;
          DCOMP.COMP.GenExpr(_222_on, @params, false, out _out67, out _out68, out _out69, out _out70);
          _223_onExpr = _out67;
          _224_onOwned = _out68;
          _225_onErased = _out69;
          _226_recIdents = _out70;
          if (!(_225_onErased)) {
            Dafny.ISequence<Dafny.Rune> _227_eraseFn;
            _227_eraseFn = ((_224_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _223_onExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _227_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _223_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _228_idxString;
          bool _229___v13;
          bool _230_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _231_idxIdents;
          Dafny.ISequence<Dafny.Rune> _out71;
          bool _out72;
          bool _out73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out74;
          DCOMP.COMP.GenExpr(_221_idx, @params, true, out _out71, out _out72, out _out73, out _out74);
          _228_idxString = _out71;
          _229___v13 = _out72;
          _230_idxErased = _out73;
          _231_idxIdents = _out74;
          if (!(_230_idxErased)) {
            _228_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _228_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __idx = <usize as ::dafny_runtime::NumCast>::from("), _228_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap();\n"));
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(generated, _223_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut()[__idx] = ")), rhs), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n}"));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_226_recIdents, _231_idxIdents);
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _232___mcc_h0 = _source15.dtor_name;
        DAST._IType _233___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _234___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _234___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _235___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _236_expression = _235___mcc_h3;
          DAST._IType _237_typ = _233___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _238_name = _232___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _239_expr;
            bool _240___v14;
            bool _241_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _242_recIdents;
            Dafny.ISequence<Dafny.Rune> _out75;
            bool _out76;
            bool _out77;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out78;
            DCOMP.COMP.GenExpr(_236_expression, @params, true, out _out75, out _out76, out _out77, out _out78);
            _239_expr = _out75;
            _240___v14 = _out76;
            _241_recErased = _out77;
            _242_recIdents = _out78;
            if (_241_recErased) {
              _239_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _239_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _243_typeString;
            Dafny.ISequence<Dafny.Rune> _out79;
            _out79 = DCOMP.COMP.GenType(_237_typ, true, false);
            _243_typeString = _out79;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _238_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _243_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _239_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _242_recIdents;
          }
        } else {
          DAST._IType _244_typ = _233___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _245_name = _232___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _246_typeString;
            Dafny.ISequence<Dafny.Rune> _out80;
            _out80 = DCOMP.COMP.GenType(_244_typ, true, false);
            _246_typeString = _out80;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _245_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _246_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _247___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _248___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _249_expression = _248___mcc_h5;
        DAST._IAssignLhs _250_lhs = _247___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _251_lhsGen;
          bool _252_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _253_recIdents;
          Dafny.ISequence<Dafny.Rune> _out81;
          bool _out82;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out83;
          DCOMP.COMP.GenAssignLhs(_250_lhs, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("__rhs"), @params, out _out81, out _out82, out _out83);
          _251_lhsGen = _out81;
          _252_needsIIFE = _out82;
          _253_recIdents = _out83;
          Dafny.ISequence<Dafny.Rune> _254_exprGen;
          bool _255___v15;
          bool _256_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _257_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out84;
          bool _out85;
          bool _out86;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out87;
          DCOMP.COMP.GenExpr(_249_expression, @params, true, out _out84, out _out85, out _out86, out _out87);
          _254_exprGen = _out84;
          _255___v15 = _out85;
          _256_exprErased = _out86;
          _257_exprIdents = _out87;
          if (_256_exprErased) {
            _254_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _254_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_252_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet __rhs = "), _254_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _251_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_251_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _254_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_253_recIdents, _257_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _258___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _259___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _260___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _261_els = _260___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _262_thn = _259___mcc_h7;
        DAST._IExpression _263_cond = _258___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _264_condString;
          bool _265___v16;
          bool _266_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _267_recIdents;
          Dafny.ISequence<Dafny.Rune> _out88;
          bool _out89;
          bool _out90;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out91;
          DCOMP.COMP.GenExpr(_263_cond, @params, true, out _out88, out _out89, out _out90, out _out91);
          _264_condString = _out88;
          _265___v16 = _out89;
          _266_condErased = _out90;
          _267_recIdents = _out91;
          if (!(_266_condErased)) {
            _264_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _264_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _267_recIdents;
          Dafny.ISequence<Dafny.Rune> _268_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _269_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out92;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out93;
          DCOMP.COMP.GenStmts(_262_thn, @params, isLast, earlyReturn, out _out92, out _out93);
          _268_thnString = _out92;
          _269_thnIdents = _out93;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _269_thnIdents);
          Dafny.ISequence<Dafny.Rune> _270_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _271_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out94;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out95;
          DCOMP.COMP.GenStmts(_261_els, @params, isLast, earlyReturn, out _out94, out _out95);
          _270_elsString = _out94;
          _271_elsIdents = _out95;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _271_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _264_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _268_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _270_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _272___mcc_h9 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _273___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _274_body = _273___mcc_h10;
        DAST._IExpression _275_cond = _272___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _276_condString;
          bool _277___v17;
          bool _278_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _279_recIdents;
          Dafny.ISequence<Dafny.Rune> _out96;
          bool _out97;
          bool _out98;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out99;
          DCOMP.COMP.GenExpr(_275_cond, @params, true, out _out96, out _out97, out _out98, out _out99);
          _276_condString = _out96;
          _277___v17 = _out97;
          _278_condErased = _out98;
          _279_recIdents = _out99;
          if (!(_278_condErased)) {
            _276_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _276_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _279_recIdents;
          Dafny.ISequence<Dafny.Rune> _280_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _281_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out100;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out101;
          DCOMP.COMP.GenStmts(_274_body, @params, false, earlyReturn, out _out100, out _out101);
          _280_bodyString = _out100;
          _281_bodyIdents = _out101;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _281_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _276_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _280_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _282___mcc_h11 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _283___mcc_h12 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _284___mcc_h13 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _285___mcc_h14 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _286___mcc_h15 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _287_maybeOutVars = _286___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _288_args = _285___mcc_h14;
        Dafny.ISequence<DAST._IType> _289_typeArgs = _284___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _290_name = _283___mcc_h12;
        DAST._IExpression _291_on = _282___mcc_h11;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _292_typeArgString;
          _292_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_289_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _293_typeI;
            _293_typeI = BigInteger.Zero;
            _292_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_293_typeI) < (new BigInteger((_289_typeArgs).Count))) {
              if ((_293_typeI).Sign == 1) {
                _292_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_292_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _294_typeString;
              Dafny.ISequence<Dafny.Rune> _out102;
              _out102 = DCOMP.COMP.GenType((_289_typeArgs).Select(_293_typeI), false, false);
              _294_typeString = _out102;
              _292_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_292_typeArgString, _294_typeString);
              _293_typeI = (_293_typeI) + (BigInteger.One);
            }
            _292_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_292_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _295_argString;
          _295_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _296_i;
          _296_i = BigInteger.Zero;
          while ((_296_i) < (new BigInteger((_288_args).Count))) {
            if ((_296_i).Sign == 1) {
              _295_argString = Dafny.Sequence<Dafny.Rune>.Concat(_295_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _297_argExpr;
            bool _298_isOwned;
            bool _299_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _300_argIdents;
            Dafny.ISequence<Dafny.Rune> _out103;
            bool _out104;
            bool _out105;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out106;
            DCOMP.COMP.GenExpr((_288_args).Select(_296_i), @params, false, out _out103, out _out104, out _out105, out _out106);
            _297_argExpr = _out103;
            _298_isOwned = _out104;
            _299_argErased = _out105;
            _300_argIdents = _out106;
            if (_298_isOwned) {
              _297_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _297_argExpr);
            }
            _295_argString = Dafny.Sequence<Dafny.Rune>.Concat(_295_argString, _297_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _300_argIdents);
            _296_i = (_296_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _301_enclosingString;
          bool _302___v18;
          bool _303___v19;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _304_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out107;
          bool _out108;
          bool _out109;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out110;
          DCOMP.COMP.GenExpr(_291_on, @params, false, out _out107, out _out108, out _out109, out _out110);
          _301_enclosingString = _out107;
          _302___v18 = _out108;
          _303___v19 = _out109;
          _304_enclosingIdents = _out110;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _304_enclosingIdents);
          DAST._IExpression _source17 = _291_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _305___mcc_h18 = _source17.dtor_Literal_a0;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _306___mcc_h20 = _source17.dtor_Ident_a0;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _307___mcc_h22 = _source17.dtor_Companion_a0;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_301_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _308___mcc_h24 = _source17.dtor_Tuple_a0;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _309___mcc_h26 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _310___mcc_h27 = _source17.dtor_args;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _311___mcc_h30 = _source17.dtor_dims;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _312___mcc_h32 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _313___mcc_h33 = _source17.dtor_variant;
            bool _314___mcc_h34 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _315___mcc_h35 = _source17.dtor_contents;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _316___mcc_h40 = _source17.dtor_value;
            DAST._IType _317___mcc_h41 = _source17.dtor_from;
            DAST._IType _318___mcc_h42 = _source17.dtor_typ;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _319___mcc_h46 = _source17.dtor_elements;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _320___mcc_h48 = _source17.dtor_elements;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _321___mcc_h50 = _source17.dtor_cond;
            DAST._IExpression _322___mcc_h51 = _source17.dtor_thn;
            DAST._IExpression _323___mcc_h52 = _source17.dtor_els;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _324___mcc_h56 = _source17.dtor_unOp;
            DAST._IExpression _325___mcc_h57 = _source17.dtor_expr;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _326___mcc_h60 = _source17.dtor_op;
            DAST._IExpression _327___mcc_h61 = _source17.dtor_left;
            DAST._IExpression _328___mcc_h62 = _source17.dtor_right;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _329___mcc_h66 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _330___mcc_h67 = _source17.dtor_field;
            bool _331___mcc_h68 = _source17.dtor_isConstant;
            bool _332___mcc_h69 = _source17.dtor_onDatatype;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _333___mcc_h74 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _334___mcc_h75 = _source17.dtor_field;
            bool _335___mcc_h76 = _source17.dtor_onDatatype;
            bool _336___mcc_h77 = _source17.dtor_isStatic;
            BigInteger _337___mcc_h78 = _source17.dtor_arity;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Index) {
            DAST._IExpression _338___mcc_h84 = _source17.dtor_expr;
            DAST._IExpression _339___mcc_h85 = _source17.dtor_idx;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _340___mcc_h88 = _source17.dtor_expr;
            BigInteger _341___mcc_h89 = _source17.dtor_index;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _342___mcc_h92 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _343___mcc_h93 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _344___mcc_h94 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _345___mcc_h95 = _source17.dtor_args;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _346___mcc_h100 = _source17.dtor_params;
            DAST._IType _347___mcc_h101 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _348___mcc_h102 = _source17.dtor_body;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _349___mcc_h106 = _source17.dtor_name;
            DAST._IType _350___mcc_h107 = _source17.dtor_typ;
            DAST._IExpression _351___mcc_h108 = _source17.dtor_value;
            DAST._IExpression _352___mcc_h109 = _source17.dtor_iifeBody;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _353___mcc_h114 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _354___mcc_h115 = _source17.dtor_args;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _355___mcc_h118 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _356___mcc_h119 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _357___mcc_h120 = _source17.dtor_variant;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _358___mcc_h124 = _source17.dtor_typ;
            {
              _301_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _359_receiver;
          _359_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _287_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _360___mcc_h126 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _361_outVars = _360___mcc_h126;
            {
              if ((new BigInteger((_361_outVars).Count)) > (BigInteger.One)) {
                _359_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _362_outI;
              _362_outI = BigInteger.Zero;
              while ((_362_outI) < (new BigInteger((_361_outVars).Count))) {
                if ((_362_outI).Sign == 1) {
                  _359_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_359_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _363_outVar;
                _363_outVar = (_361_outVars).Select(_362_outI);
                _359_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_359_receiver, (_363_outVar));
                _362_outI = (_362_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_361_outVars).Count)) > (BigInteger.One)) {
                _359_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_359_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_359_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_359_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _301_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _290_name), _292_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _295_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _364___mcc_h16 = _source15.dtor_expr;
        DAST._IExpression _365_expr = _364___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _366_exprString;
          bool _367___v22;
          bool _368_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _369_recIdents;
          Dafny.ISequence<Dafny.Rune> _out111;
          bool _out112;
          bool _out113;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out114;
          DCOMP.COMP.GenExpr(_365_expr, @params, true, out _out111, out _out112, out _out113, out _out114);
          _366_exprString = _out111;
          _367___v22 = _out112;
          _368_recErased = _out113;
          _369_recIdents = _out114;
          _366_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _366_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _369_recIdents;
          if (isLast) {
            generated = _366_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _366_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
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
        DAST._IExpression _370___mcc_h17 = _source15.dtor_Print_a0;
        DAST._IExpression _371_e = _370___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _372_printedExpr;
          bool _373_isOwned;
          bool _374___v23;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _375_recIdents;
          Dafny.ISequence<Dafny.Rune> _out115;
          bool _out116;
          bool _out117;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out118;
          DCOMP.COMP.GenExpr(_371_e, @params, false, out _out115, out _out116, out _out117, out _out118);
          _372_printedExpr = _out115;
          _373_isOwned = _out116;
          _374___v23 = _out117;
          _375_recIdents = _out118;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_373_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _372_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _375_recIdents;
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
        DAST._ILiteral _376___mcc_h0 = _source19.dtor_Literal_a0;
        DAST._ILiteral _source20 = _376___mcc_h0;
        if (_source20.is_BoolLiteral) {
          bool _377___mcc_h1 = _source20.dtor_BoolLiteral_a0;
          if ((_377___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _378___mcc_h2 = _source20.dtor_IntLiteral_a0;
          DAST._IType _379___mcc_h3 = _source20.dtor_IntLiteral_a1;
          DAST._IType _380_t = _379___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _381_i = _378___mcc_h2;
          {
            DAST._IType _source21 = _380_t;
            if (_source21.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _382___mcc_h62 = _source21.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _383___mcc_h63 = _source21.dtor_typeArgs;
              DAST._IResolvedType _384___mcc_h64 = _source21.dtor_resolved;
              {
                s = _381_i;
              }
            } else if (_source21.is_Tuple) {
              Dafny.ISequence<DAST._IType> _385___mcc_h68 = _source21.dtor_Tuple_a0;
              {
                s = _381_i;
              }
            } else if (_source21.is_Array) {
              DAST._IType _386___mcc_h70 = _source21.dtor_element;
              {
                s = _381_i;
              }
            } else if (_source21.is_Seq) {
              DAST._IType _387___mcc_h72 = _source21.dtor_element;
              {
                s = _381_i;
              }
            } else if (_source21.is_Set) {
              DAST._IType _388___mcc_h74 = _source21.dtor_element;
              {
                s = _381_i;
              }
            } else if (_source21.is_Multiset) {
              DAST._IType _389___mcc_h76 = _source21.dtor_element;
              {
                s = _381_i;
              }
            } else if (_source21.is_Map) {
              DAST._IType _390___mcc_h78 = _source21.dtor_key;
              DAST._IType _391___mcc_h79 = _source21.dtor_value;
              {
                s = _381_i;
              }
            } else if (_source21.is_Arrow) {
              Dafny.ISequence<DAST._IType> _392___mcc_h82 = _source21.dtor_args;
              DAST._IType _393___mcc_h83 = _source21.dtor_result;
              {
                s = _381_i;
              }
            } else if (_source21.is_Primitive) {
              DAST._IPrimitive _394___mcc_h86 = _source21.dtor_Primitive_a0;
              DAST._IPrimitive _source22 = _394___mcc_h86;
              if (_source22.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _381_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source22.is_Real) {
                {
                  s = _381_i;
                }
              } else if (_source22.is_String) {
                {
                  s = _381_i;
                }
              } else if (_source22.is_Bool) {
                {
                  s = _381_i;
                }
              } else {
                {
                  s = _381_i;
                }
              }
            } else if (_source21.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _395___mcc_h88 = _source21.dtor_Passthrough_a0;
              {
                s = _381_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _396___mcc_h90 = _source21.dtor_TypeArg_a0;
              {
                s = _381_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _397___mcc_h4 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _398___mcc_h5 = _source20.dtor_DecLiteral_a1;
          DAST._IType _399___mcc_h6 = _source20.dtor_DecLiteral_a2;
          DAST._IType _400_t = _399___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _401_d = _398___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _402_n = _397___mcc_h4;
          {
            DAST._IType _source23 = _400_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _403___mcc_h92 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _404___mcc_h93 = _source23.dtor_typeArgs;
              DAST._IResolvedType _405___mcc_h94 = _source23.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _406___mcc_h98 = _source23.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Array) {
              DAST._IType _407___mcc_h100 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Seq) {
              DAST._IType _408___mcc_h102 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Set) {
              DAST._IType _409___mcc_h104 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _410___mcc_h106 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Map) {
              DAST._IType _411___mcc_h108 = _source23.dtor_key;
              DAST._IType _412___mcc_h109 = _source23.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _413___mcc_h112 = _source23.dtor_args;
              DAST._IType _414___mcc_h113 = _source23.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _415___mcc_h116 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _415___mcc_h116;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _402_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source24.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _416___mcc_h118 = _source23.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _417___mcc_h120 = _source23.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_402_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _401_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _418___mcc_h7 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _419_l = _418___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _419_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _420___mcc_h8 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _421_c = _420___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_421_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _422___mcc_h9 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _423_name = _422___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _423_name);
          if (!((@params).Contains(_423_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_423_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _424___mcc_h10 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _425_path = _424___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out119;
          _out119 = DCOMP.COMP.GenPath(_425_path);
          s = _out119;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _426___mcc_h11 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _427_values = _426___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _428_i;
          _428_i = BigInteger.Zero;
          bool _429_allErased;
          _429_allErased = true;
          while ((_428_i) < (new BigInteger((_427_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _430___v26;
            bool _431___v27;
            bool _432_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _433___v28;
            Dafny.ISequence<Dafny.Rune> _out120;
            bool _out121;
            bool _out122;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out123;
            DCOMP.COMP.GenExpr((_427_values).Select(_428_i), @params, true, out _out120, out _out121, out _out122, out _out123);
            _430___v26 = _out120;
            _431___v27 = _out121;
            _432_isErased = _out122;
            _433___v28 = _out123;
            _429_allErased = (_429_allErased) && (_432_isErased);
            _428_i = (_428_i) + (BigInteger.One);
          }
          _428_i = BigInteger.Zero;
          while ((_428_i) < (new BigInteger((_427_values).Count))) {
            if ((_428_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _434_recursiveGen;
            bool _435___v29;
            bool _436_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _437_recIdents;
            Dafny.ISequence<Dafny.Rune> _out124;
            bool _out125;
            bool _out126;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out127;
            DCOMP.COMP.GenExpr((_427_values).Select(_428_i), @params, true, out _out124, out _out125, out _out126, out _out127);
            _434_recursiveGen = _out124;
            _435___v29 = _out125;
            _436_isErased = _out126;
            _437_recIdents = _out127;
            if ((_436_isErased) && (!(_429_allErased))) {
              _434_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _434_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _434_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _437_recIdents);
            _428_i = (_428_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _429_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _438___mcc_h12 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _439___mcc_h13 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _440_args = _439___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _441_path = _438___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _442_path;
          Dafny.ISequence<Dafny.Rune> _out128;
          _out128 = DCOMP.COMP.GenPath(_441_path);
          _442_path = _out128;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _442_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _443_i;
          _443_i = BigInteger.Zero;
          while ((_443_i) < (new BigInteger((_440_args).Count))) {
            if ((_443_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _444_recursiveGen;
            bool _445___v30;
            bool _446_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _447_recIdents;
            Dafny.ISequence<Dafny.Rune> _out129;
            bool _out130;
            bool _out131;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out132;
            DCOMP.COMP.GenExpr((_440_args).Select(_443_i), @params, true, out _out129, out _out130, out _out131, out _out132);
            _444_recursiveGen = _out129;
            _445___v30 = _out130;
            _446_isErased = _out131;
            _447_recIdents = _out132;
            if (_446_isErased) {
              _444_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _444_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _444_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _447_recIdents);
            _443_i = (_443_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _448___mcc_h14 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _449_dims = _448___mcc_h14;
        {
          BigInteger _450_i;
          _450_i = (new BigInteger((_449_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_450_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _451_recursiveGen;
            bool _452___v31;
            bool _453_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _454_recIdents;
            Dafny.ISequence<Dafny.Rune> _out133;
            bool _out134;
            bool _out135;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out136;
            DCOMP.COMP.GenExpr((_449_dims).Select(_450_i), @params, true, out _out133, out _out134, out _out135, out _out136);
            _451_recursiveGen = _out133;
            _452___v31 = _out134;
            _453_isErased = _out135;
            _454_recIdents = _out136;
            if (!(_453_isErased)) {
              _451_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new(::std::cell::RefCell::new(vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]))"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _454_recIdents);
            _450_i = (_450_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _455___mcc_h15 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _456___mcc_h16 = _source19.dtor_variant;
        bool _457___mcc_h17 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _458___mcc_h18 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _459_values = _458___mcc_h18;
        bool _460_isCo = _457___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _461_variant = _456___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _462_path = _455___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _463_path;
          Dafny.ISequence<Dafny.Rune> _out137;
          _out137 = DCOMP.COMP.GenPath(_462_path);
          _463_path = _out137;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _463_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _461_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _464_i;
          _464_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_464_i) < (new BigInteger((_459_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_459_values).Select(_464_i);
            Dafny.ISequence<Dafny.Rune> _465_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _466_value = _let_tmp_rhs0.dtor__1;
            if ((_464_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_460_isCo) {
              Dafny.ISequence<Dafny.Rune> _467_recursiveGen;
              bool _468___v32;
              bool _469_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _470_recIdents;
              Dafny.ISequence<Dafny.Rune> _out138;
              bool _out139;
              bool _out140;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out141;
              DCOMP.COMP.GenExpr(_466_value, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out138, out _out139, out _out140, out _out141);
              _467_recursiveGen = _out138;
              _468___v32 = _out139;
              _469_isErased = _out140;
              _470_recIdents = _out141;
              if (!(_469_isErased)) {
                _467_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _467_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _467_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _467_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _470_recIdents);
              Dafny.ISequence<Dafny.Rune> _471_allReadCloned;
              _471_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_470_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _472_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_470_recIdents).Elements) {
                  _472_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_470_recIdents).Contains(_472_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1113)");
              after__ASSIGN_SUCH_THAT_0:;
                _471_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_471_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _472_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _472_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _470_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_470_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_472_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _465_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _471_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _467_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _473_recursiveGen;
              bool _474___v33;
              bool _475_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _476_recIdents;
              Dafny.ISequence<Dafny.Rune> _out142;
              bool _out143;
              bool _out144;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out145;
              DCOMP.COMP.GenExpr(_466_value, @params, true, out _out142, out _out143, out _out144, out _out145);
              _473_recursiveGen = _out142;
              _474___v33 = _out143;
              _475_isErased = _out144;
              _476_recIdents = _out145;
              if (!(_475_isErased)) {
                _473_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _473_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _465_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _476_recIdents);
            }
            _464_i = (_464_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _477___mcc_h19 = _source19.dtor_value;
        DAST._IType _478___mcc_h20 = _source19.dtor_from;
        DAST._IType _479___mcc_h21 = _source19.dtor_typ;
        DAST._IType _480_toTpe = _479___mcc_h21;
        DAST._IType _481_fromTpe = _478___mcc_h20;
        DAST._IExpression _482_expr = _477___mcc_h19;
        {
          if (object.Equals(_481_fromTpe, _480_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _483_recursiveGen;
            bool _484_recOwned;
            bool _485_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _486_recIdents;
            Dafny.ISequence<Dafny.Rune> _out146;
            bool _out147;
            bool _out148;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out149;
            DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out146, out _out147, out _out148, out _out149);
            _483_recursiveGen = _out146;
            _484_recOwned = _out147;
            _485_recErased = _out148;
            _486_recIdents = _out149;
            s = _483_recursiveGen;
            isOwned = _484_recOwned;
            isErased = _485_recErased;
            readIdents = _486_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source25 = _System.Tuple2<DAST._IType, DAST._IType>.create(_481_fromTpe, _480_toTpe);
            DAST._IType _487___mcc_h122 = _source25.dtor__0;
            DAST._IType _488___mcc_h123 = _source25.dtor__1;
            DAST._IType _source26 = _487___mcc_h122;
            if (_source26.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _489___mcc_h126 = _source26.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _490___mcc_h127 = _source26.dtor_typeArgs;
              DAST._IResolvedType _491___mcc_h128 = _source26.dtor_resolved;
              DAST._IResolvedType _source27 = _491___mcc_h128;
              if (_source27.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _492___mcc_h135 = _source27.dtor_path;
                DAST._IType _source28 = _488___mcc_h123;
                if (_source28.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _493___mcc_h138 = _source28.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _494___mcc_h139 = _source28.dtor_typeArgs;
                  DAST._IResolvedType _495___mcc_h140 = _source28.dtor_resolved;
                  DAST._IResolvedType _source29 = _495___mcc_h140;
                  if (_source29.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _496___mcc_h144 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _497_recursiveGen;
                      bool _498_recOwned;
                      bool _499_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _500_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out150;
                      bool _out151;
                      bool _out152;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out153;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out150, out _out151, out _out152, out _out153);
                      _497_recursiveGen = _out150;
                      _498_recOwned = _out151;
                      _499_recErased = _out152;
                      _500_recIdents = _out153;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _497_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _498_recOwned;
                      isErased = _499_recErased;
                      readIdents = _500_recIdents;
                    }
                  } else if (_source29.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _501___mcc_h146 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _502_recursiveGen;
                      bool _503_recOwned;
                      bool _504_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _505_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out154;
                      bool _out155;
                      bool _out156;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out157;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out154, out _out155, out _out156, out _out157);
                      _502_recursiveGen = _out154;
                      _503_recOwned = _out155;
                      _504_recErased = _out156;
                      _505_recIdents = _out157;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _503_recOwned;
                      isErased = _504_recErased;
                      readIdents = _505_recIdents;
                    }
                  } else {
                    DAST._IType _506___mcc_h148 = _source29.dtor_Newtype_a0;
                    DAST._IType _507_b = _506___mcc_h148;
                    {
                      if (object.Equals(_481_fromTpe, _507_b)) {
                        Dafny.ISequence<Dafny.Rune> _508_recursiveGen;
                        bool _509_recOwned;
                        bool _510_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _511_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out158;
                        bool _out159;
                        bool _out160;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out161;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out158, out _out159, out _out160, out _out161);
                        _508_recursiveGen = _out158;
                        _509_recOwned = _out159;
                        _510_recErased = _out160;
                        _511_recIdents = _out161;
                        Dafny.ISequence<Dafny.Rune> _512_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out162;
                        _out162 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _512_rhsType = _out162;
                        Dafny.ISequence<Dafny.Rune> _513_uneraseFn;
                        _513_uneraseFn = ((_509_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _512_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _513_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _508_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _509_recOwned;
                        isErased = false;
                        readIdents = _511_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out163;
                        bool _out164;
                        bool _out165;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out166;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _507_b), _507_b, _480_toTpe), @params, mustOwn, out _out163, out _out164, out _out165, out _out166);
                        s = _out163;
                        isOwned = _out164;
                        isErased = _out165;
                        readIdents = _out166;
                      }
                    }
                  }
                } else if (_source28.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _514___mcc_h150 = _source28.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _515_recursiveGen;
                    bool _516_recOwned;
                    bool _517_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _518_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out167;
                    bool _out168;
                    bool _out169;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out170;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out167, out _out168, out _out169, out _out170);
                    _515_recursiveGen = _out167;
                    _516_recOwned = _out168;
                    _517_recErased = _out169;
                    _518_recIdents = _out170;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _515_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _516_recOwned;
                    isErased = _517_recErased;
                    readIdents = _518_recIdents;
                  }
                } else if (_source28.is_Array) {
                  DAST._IType _519___mcc_h152 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _520_recursiveGen;
                    bool _521_recOwned;
                    bool _522_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _523_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out171;
                    bool _out172;
                    bool _out173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out174;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out171, out _out172, out _out173, out _out174);
                    _520_recursiveGen = _out171;
                    _521_recOwned = _out172;
                    _522_recErased = _out173;
                    _523_recIdents = _out174;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _520_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _521_recOwned;
                    isErased = _522_recErased;
                    readIdents = _523_recIdents;
                  }
                } else if (_source28.is_Seq) {
                  DAST._IType _524___mcc_h154 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _525_recursiveGen;
                    bool _526_recOwned;
                    bool _527_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _528_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out175;
                    bool _out176;
                    bool _out177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out178;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out175, out _out176, out _out177, out _out178);
                    _525_recursiveGen = _out175;
                    _526_recOwned = _out176;
                    _527_recErased = _out177;
                    _528_recIdents = _out178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _526_recOwned;
                    isErased = _527_recErased;
                    readIdents = _528_recIdents;
                  }
                } else if (_source28.is_Set) {
                  DAST._IType _529___mcc_h156 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _530_recursiveGen;
                    bool _531_recOwned;
                    bool _532_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _533_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out179;
                    bool _out180;
                    bool _out181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out182;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out179, out _out180, out _out181, out _out182);
                    _530_recursiveGen = _out179;
                    _531_recOwned = _out180;
                    _532_recErased = _out181;
                    _533_recIdents = _out182;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _530_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _531_recOwned;
                    isErased = _532_recErased;
                    readIdents = _533_recIdents;
                  }
                } else if (_source28.is_Multiset) {
                  DAST._IType _534___mcc_h158 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _535_recursiveGen;
                    bool _536_recOwned;
                    bool _537_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _538_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out183;
                    bool _out184;
                    bool _out185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out186;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out183, out _out184, out _out185, out _out186);
                    _535_recursiveGen = _out183;
                    _536_recOwned = _out184;
                    _537_recErased = _out185;
                    _538_recIdents = _out186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _535_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _536_recOwned;
                    isErased = _537_recErased;
                    readIdents = _538_recIdents;
                  }
                } else if (_source28.is_Map) {
                  DAST._IType _539___mcc_h160 = _source28.dtor_key;
                  DAST._IType _540___mcc_h161 = _source28.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _541_recursiveGen;
                    bool _542_recOwned;
                    bool _543_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _544_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out187;
                    bool _out188;
                    bool _out189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out190;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out187, out _out188, out _out189, out _out190);
                    _541_recursiveGen = _out187;
                    _542_recOwned = _out188;
                    _543_recErased = _out189;
                    _544_recIdents = _out190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _542_recOwned;
                    isErased = _543_recErased;
                    readIdents = _544_recIdents;
                  }
                } else if (_source28.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _545___mcc_h164 = _source28.dtor_args;
                  DAST._IType _546___mcc_h165 = _source28.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _547_recursiveGen;
                    bool _548_recOwned;
                    bool _549_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _550_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out191;
                    bool _out192;
                    bool _out193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out194;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out191, out _out192, out _out193, out _out194);
                    _547_recursiveGen = _out191;
                    _548_recOwned = _out192;
                    _549_recErased = _out193;
                    _550_recIdents = _out194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _547_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _548_recOwned;
                    isErased = _549_recErased;
                    readIdents = _550_recIdents;
                  }
                } else if (_source28.is_Primitive) {
                  DAST._IPrimitive _551___mcc_h168 = _source28.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _552_recursiveGen;
                    bool _553_recOwned;
                    bool _554_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _555_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out195;
                    bool _out196;
                    bool _out197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out198;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out195, out _out196, out _out197, out _out198);
                    _552_recursiveGen = _out195;
                    _553_recOwned = _out196;
                    _554_recErased = _out197;
                    _555_recIdents = _out198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _552_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _553_recOwned;
                    isErased = _554_recErased;
                    readIdents = _555_recIdents;
                  }
                } else if (_source28.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _556___mcc_h170 = _source28.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _557_recursiveGen;
                    bool _558_recOwned;
                    bool _559_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _560_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out199;
                    bool _out200;
                    bool _out201;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out202;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out199, out _out200, out _out201, out _out202);
                    _557_recursiveGen = _out199;
                    _558_recOwned = _out200;
                    _559_recErased = _out201;
                    _560_recIdents = _out202;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _557_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _558_recOwned;
                    isErased = _559_recErased;
                    readIdents = _560_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _561___mcc_h172 = _source28.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _562_recursiveGen;
                    bool _563_recOwned;
                    bool _564_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _565_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out203;
                    bool _out204;
                    bool _out205;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out206;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out203, out _out204, out _out205, out _out206);
                    _562_recursiveGen = _out203;
                    _563_recOwned = _out204;
                    _564_recErased = _out205;
                    _565_recIdents = _out206;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _562_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _563_recOwned;
                    isErased = _564_recErased;
                    readIdents = _565_recIdents;
                  }
                }
              } else if (_source27.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _566___mcc_h174 = _source27.dtor_path;
                DAST._IType _source30 = _488___mcc_h123;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _567___mcc_h177 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _568___mcc_h178 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _569___mcc_h179 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _569___mcc_h179;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _570___mcc_h183 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _571_recursiveGen;
                      bool _572_recOwned;
                      bool _573_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _574_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out207;
                      bool _out208;
                      bool _out209;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out210;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out207, out _out208, out _out209, out _out210);
                      _571_recursiveGen = _out207;
                      _572_recOwned = _out208;
                      _573_recErased = _out209;
                      _574_recIdents = _out210;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _571_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _572_recOwned;
                      isErased = _573_recErased;
                      readIdents = _574_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _575___mcc_h185 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _576_recursiveGen;
                      bool _577_recOwned;
                      bool _578_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _579_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out211;
                      bool _out212;
                      bool _out213;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out214;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out211, out _out212, out _out213, out _out214);
                      _576_recursiveGen = _out211;
                      _577_recOwned = _out212;
                      _578_recErased = _out213;
                      _579_recIdents = _out214;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _577_recOwned;
                      isErased = _578_recErased;
                      readIdents = _579_recIdents;
                    }
                  } else {
                    DAST._IType _580___mcc_h187 = _source31.dtor_Newtype_a0;
                    DAST._IType _581_b = _580___mcc_h187;
                    {
                      if (object.Equals(_481_fromTpe, _581_b)) {
                        Dafny.ISequence<Dafny.Rune> _582_recursiveGen;
                        bool _583_recOwned;
                        bool _584_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _585_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out215;
                        bool _out216;
                        bool _out217;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out218;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out215, out _out216, out _out217, out _out218);
                        _582_recursiveGen = _out215;
                        _583_recOwned = _out216;
                        _584_recErased = _out217;
                        _585_recIdents = _out218;
                        Dafny.ISequence<Dafny.Rune> _586_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out219;
                        _out219 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _586_rhsType = _out219;
                        Dafny.ISequence<Dafny.Rune> _587_uneraseFn;
                        _587_uneraseFn = ((_583_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _586_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _587_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _582_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _583_recOwned;
                        isErased = false;
                        readIdents = _585_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out220;
                        bool _out221;
                        bool _out222;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out223;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _581_b), _581_b, _480_toTpe), @params, mustOwn, out _out220, out _out221, out _out222, out _out223);
                        s = _out220;
                        isOwned = _out221;
                        isErased = _out222;
                        readIdents = _out223;
                      }
                    }
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _588___mcc_h189 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _589_recursiveGen;
                    bool _590_recOwned;
                    bool _591_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _592_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out224;
                    bool _out225;
                    bool _out226;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out227;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out224, out _out225, out _out226, out _out227);
                    _589_recursiveGen = _out224;
                    _590_recOwned = _out225;
                    _591_recErased = _out226;
                    _592_recIdents = _out227;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _589_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _590_recOwned;
                    isErased = _591_recErased;
                    readIdents = _592_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _593___mcc_h191 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _594_recursiveGen;
                    bool _595_recOwned;
                    bool _596_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _597_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out228;
                    bool _out229;
                    bool _out230;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out231;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out228, out _out229, out _out230, out _out231);
                    _594_recursiveGen = _out228;
                    _595_recOwned = _out229;
                    _596_recErased = _out230;
                    _597_recIdents = _out231;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _594_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _595_recOwned;
                    isErased = _596_recErased;
                    readIdents = _597_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _598___mcc_h193 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _599_recursiveGen;
                    bool _600_recOwned;
                    bool _601_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _602_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out232;
                    bool _out233;
                    bool _out234;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out235;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out232, out _out233, out _out234, out _out235);
                    _599_recursiveGen = _out232;
                    _600_recOwned = _out233;
                    _601_recErased = _out234;
                    _602_recIdents = _out235;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _599_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _600_recOwned;
                    isErased = _601_recErased;
                    readIdents = _602_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _603___mcc_h195 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _604_recursiveGen;
                    bool _605_recOwned;
                    bool _606_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _607_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out236;
                    bool _out237;
                    bool _out238;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out239;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out236, out _out237, out _out238, out _out239);
                    _604_recursiveGen = _out236;
                    _605_recOwned = _out237;
                    _606_recErased = _out238;
                    _607_recIdents = _out239;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _604_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _605_recOwned;
                    isErased = _606_recErased;
                    readIdents = _607_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _608___mcc_h197 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _609_recursiveGen;
                    bool _610_recOwned;
                    bool _611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out240;
                    bool _out241;
                    bool _out242;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out243;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out240, out _out241, out _out242, out _out243);
                    _609_recursiveGen = _out240;
                    _610_recOwned = _out241;
                    _611_recErased = _out242;
                    _612_recIdents = _out243;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _610_recOwned;
                    isErased = _611_recErased;
                    readIdents = _612_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _613___mcc_h199 = _source30.dtor_key;
                  DAST._IType _614___mcc_h200 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _615_recursiveGen;
                    bool _616_recOwned;
                    bool _617_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _618_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out244;
                    bool _out245;
                    bool _out246;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out247;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out244, out _out245, out _out246, out _out247);
                    _615_recursiveGen = _out244;
                    _616_recOwned = _out245;
                    _617_recErased = _out246;
                    _618_recIdents = _out247;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _615_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _616_recOwned;
                    isErased = _617_recErased;
                    readIdents = _618_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _619___mcc_h203 = _source30.dtor_args;
                  DAST._IType _620___mcc_h204 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _621_recursiveGen;
                    bool _622_recOwned;
                    bool _623_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _624_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out248;
                    bool _out249;
                    bool _out250;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out251;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out248, out _out249, out _out250, out _out251);
                    _621_recursiveGen = _out248;
                    _622_recOwned = _out249;
                    _623_recErased = _out250;
                    _624_recIdents = _out251;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _621_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _622_recOwned;
                    isErased = _623_recErased;
                    readIdents = _624_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _625___mcc_h207 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _626_recursiveGen;
                    bool _627_recOwned;
                    bool _628_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _629_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out252;
                    bool _out253;
                    bool _out254;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out255;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out252, out _out253, out _out254, out _out255);
                    _626_recursiveGen = _out252;
                    _627_recOwned = _out253;
                    _628_recErased = _out254;
                    _629_recIdents = _out255;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _627_recOwned;
                    isErased = _628_recErased;
                    readIdents = _629_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _630___mcc_h209 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _631_recursiveGen;
                    bool _632_recOwned;
                    bool _633_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _634_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out256;
                    bool _out257;
                    bool _out258;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out259;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out256, out _out257, out _out258, out _out259);
                    _631_recursiveGen = _out256;
                    _632_recOwned = _out257;
                    _633_recErased = _out258;
                    _634_recIdents = _out259;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _631_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _632_recOwned;
                    isErased = _633_recErased;
                    readIdents = _634_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _635___mcc_h211 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _636_recursiveGen;
                    bool _637_recOwned;
                    bool _638_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _639_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out260;
                    bool _out261;
                    bool _out262;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out263;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out260, out _out261, out _out262, out _out263);
                    _636_recursiveGen = _out260;
                    _637_recOwned = _out261;
                    _638_recErased = _out262;
                    _639_recIdents = _out263;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _637_recOwned;
                    isErased = _638_recErased;
                    readIdents = _639_recIdents;
                  }
                }
              } else {
                DAST._IType _640___mcc_h213 = _source27.dtor_Newtype_a0;
                DAST._IType _source32 = _488___mcc_h123;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _641___mcc_h216 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _642___mcc_h217 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _643___mcc_h218 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _643___mcc_h218;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _644___mcc_h225 = _source33.dtor_path;
                    DAST._IType _645_b = _640___mcc_h213;
                    {
                      if (object.Equals(_645_b, _480_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _646_recursiveGen;
                        bool _647_recOwned;
                        bool _648_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _649_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out264;
                        bool _out265;
                        bool _out266;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out267;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out264, out _out265, out _out266, out _out267);
                        _646_recursiveGen = _out264;
                        _647_recOwned = _out265;
                        _648_recErased = _out266;
                        _649_recIdents = _out267;
                        Dafny.ISequence<Dafny.Rune> _650_uneraseFn;
                        _650_uneraseFn = ((_647_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _650_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _646_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _647_recOwned;
                        isErased = true;
                        readIdents = _649_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out268;
                        bool _out269;
                        bool _out270;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out271;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _645_b), _645_b, _480_toTpe), @params, mustOwn, out _out268, out _out269, out _out270, out _out271);
                        s = _out268;
                        isOwned = _out269;
                        isErased = _out270;
                        readIdents = _out271;
                      }
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _651___mcc_h228 = _source33.dtor_path;
                    DAST._IType _652_b = _640___mcc_h213;
                    {
                      if (object.Equals(_652_b, _480_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _653_recursiveGen;
                        bool _654_recOwned;
                        bool _655_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _656_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out272;
                        bool _out273;
                        bool _out274;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out275;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out272, out _out273, out _out274, out _out275);
                        _653_recursiveGen = _out272;
                        _654_recOwned = _out273;
                        _655_recErased = _out274;
                        _656_recIdents = _out275;
                        Dafny.ISequence<Dafny.Rune> _657_uneraseFn;
                        _657_uneraseFn = ((_654_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _657_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _654_recOwned;
                        isErased = true;
                        readIdents = _656_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out276;
                        bool _out277;
                        bool _out278;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out279;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _652_b), _652_b, _480_toTpe), @params, mustOwn, out _out276, out _out277, out _out278, out _out279);
                        s = _out276;
                        isOwned = _out277;
                        isErased = _out278;
                        readIdents = _out279;
                      }
                    }
                  } else {
                    DAST._IType _658___mcc_h231 = _source33.dtor_Newtype_a0;
                    DAST._IType _659_b = _658___mcc_h231;
                    {
                      if (object.Equals(_481_fromTpe, _659_b)) {
                        Dafny.ISequence<Dafny.Rune> _660_recursiveGen;
                        bool _661_recOwned;
                        bool _662_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _663_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out280;
                        bool _out281;
                        bool _out282;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out283;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out280, out _out281, out _out282, out _out283);
                        _660_recursiveGen = _out280;
                        _661_recOwned = _out281;
                        _662_recErased = _out282;
                        _663_recIdents = _out283;
                        Dafny.ISequence<Dafny.Rune> _664_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out284;
                        _out284 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _664_rhsType = _out284;
                        Dafny.ISequence<Dafny.Rune> _665_uneraseFn;
                        _665_uneraseFn = ((_661_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _664_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _665_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _660_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _661_recOwned;
                        isErased = false;
                        readIdents = _663_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out285;
                        bool _out286;
                        bool _out287;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out288;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _659_b), _659_b, _480_toTpe), @params, mustOwn, out _out285, out _out286, out _out287, out _out288);
                        s = _out285;
                        isOwned = _out286;
                        isErased = _out287;
                        readIdents = _out288;
                      }
                    }
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _666___mcc_h234 = _source32.dtor_Tuple_a0;
                  DAST._IType _667_b = _640___mcc_h213;
                  {
                    if (object.Equals(_667_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _668_recursiveGen;
                      bool _669_recOwned;
                      bool _670_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _671_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out289;
                      bool _out290;
                      bool _out291;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out292;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out289, out _out290, out _out291, out _out292);
                      _668_recursiveGen = _out289;
                      _669_recOwned = _out290;
                      _670_recErased = _out291;
                      _671_recIdents = _out292;
                      Dafny.ISequence<Dafny.Rune> _672_uneraseFn;
                      _672_uneraseFn = ((_669_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _672_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _668_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _669_recOwned;
                      isErased = true;
                      readIdents = _671_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out293;
                      bool _out294;
                      bool _out295;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out296;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _667_b), _667_b, _480_toTpe), @params, mustOwn, out _out293, out _out294, out _out295, out _out296);
                      s = _out293;
                      isOwned = _out294;
                      isErased = _out295;
                      readIdents = _out296;
                    }
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _673___mcc_h237 = _source32.dtor_element;
                  DAST._IType _674_b = _640___mcc_h213;
                  {
                    if (object.Equals(_674_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _675_recursiveGen;
                      bool _676_recOwned;
                      bool _677_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _678_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out297;
                      bool _out298;
                      bool _out299;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out300;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out297, out _out298, out _out299, out _out300);
                      _675_recursiveGen = _out297;
                      _676_recOwned = _out298;
                      _677_recErased = _out299;
                      _678_recIdents = _out300;
                      Dafny.ISequence<Dafny.Rune> _679_uneraseFn;
                      _679_uneraseFn = ((_676_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _679_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _675_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _676_recOwned;
                      isErased = true;
                      readIdents = _678_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out301;
                      bool _out302;
                      bool _out303;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out304;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _674_b), _674_b, _480_toTpe), @params, mustOwn, out _out301, out _out302, out _out303, out _out304);
                      s = _out301;
                      isOwned = _out302;
                      isErased = _out303;
                      readIdents = _out304;
                    }
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _680___mcc_h240 = _source32.dtor_element;
                  DAST._IType _681_b = _640___mcc_h213;
                  {
                    if (object.Equals(_681_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _682_recursiveGen;
                      bool _683_recOwned;
                      bool _684_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _685_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out305;
                      bool _out306;
                      bool _out307;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out308;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out305, out _out306, out _out307, out _out308);
                      _682_recursiveGen = _out305;
                      _683_recOwned = _out306;
                      _684_recErased = _out307;
                      _685_recIdents = _out308;
                      Dafny.ISequence<Dafny.Rune> _686_uneraseFn;
                      _686_uneraseFn = ((_683_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _686_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _682_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _683_recOwned;
                      isErased = true;
                      readIdents = _685_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out309;
                      bool _out310;
                      bool _out311;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out312;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _681_b), _681_b, _480_toTpe), @params, mustOwn, out _out309, out _out310, out _out311, out _out312);
                      s = _out309;
                      isOwned = _out310;
                      isErased = _out311;
                      readIdents = _out312;
                    }
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _687___mcc_h243 = _source32.dtor_element;
                  DAST._IType _688_b = _640___mcc_h213;
                  {
                    if (object.Equals(_688_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                      bool _690_recOwned;
                      bool _691_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out313;
                      bool _out314;
                      bool _out315;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out316;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out313, out _out314, out _out315, out _out316);
                      _689_recursiveGen = _out313;
                      _690_recOwned = _out314;
                      _691_recErased = _out315;
                      _692_recIdents = _out316;
                      Dafny.ISequence<Dafny.Rune> _693_uneraseFn;
                      _693_uneraseFn = ((_690_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _693_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _690_recOwned;
                      isErased = true;
                      readIdents = _692_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out317;
                      bool _out318;
                      bool _out319;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out320;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _688_b), _688_b, _480_toTpe), @params, mustOwn, out _out317, out _out318, out _out319, out _out320);
                      s = _out317;
                      isOwned = _out318;
                      isErased = _out319;
                      readIdents = _out320;
                    }
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _694___mcc_h246 = _source32.dtor_element;
                  DAST._IType _695_b = _640___mcc_h213;
                  {
                    if (object.Equals(_695_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _696_recursiveGen;
                      bool _697_recOwned;
                      bool _698_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _699_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out321;
                      bool _out322;
                      bool _out323;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out324;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out321, out _out322, out _out323, out _out324);
                      _696_recursiveGen = _out321;
                      _697_recOwned = _out322;
                      _698_recErased = _out323;
                      _699_recIdents = _out324;
                      Dafny.ISequence<Dafny.Rune> _700_uneraseFn;
                      _700_uneraseFn = ((_697_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _700_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _696_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _697_recOwned;
                      isErased = true;
                      readIdents = _699_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out325;
                      bool _out326;
                      bool _out327;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out328;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _695_b), _695_b, _480_toTpe), @params, mustOwn, out _out325, out _out326, out _out327, out _out328);
                      s = _out325;
                      isOwned = _out326;
                      isErased = _out327;
                      readIdents = _out328;
                    }
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _701___mcc_h249 = _source32.dtor_key;
                  DAST._IType _702___mcc_h250 = _source32.dtor_value;
                  DAST._IType _703_b = _640___mcc_h213;
                  {
                    if (object.Equals(_703_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _704_recursiveGen;
                      bool _705_recOwned;
                      bool _706_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _707_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out329;
                      bool _out330;
                      bool _out331;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out332;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out329, out _out330, out _out331, out _out332);
                      _704_recursiveGen = _out329;
                      _705_recOwned = _out330;
                      _706_recErased = _out331;
                      _707_recIdents = _out332;
                      Dafny.ISequence<Dafny.Rune> _708_uneraseFn;
                      _708_uneraseFn = ((_705_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _708_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _704_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _705_recOwned;
                      isErased = true;
                      readIdents = _707_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out333;
                      bool _out334;
                      bool _out335;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out336;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _703_b), _703_b, _480_toTpe), @params, mustOwn, out _out333, out _out334, out _out335, out _out336);
                      s = _out333;
                      isOwned = _out334;
                      isErased = _out335;
                      readIdents = _out336;
                    }
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _709___mcc_h255 = _source32.dtor_args;
                  DAST._IType _710___mcc_h256 = _source32.dtor_result;
                  DAST._IType _711_b = _640___mcc_h213;
                  {
                    if (object.Equals(_711_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _712_recursiveGen;
                      bool _713_recOwned;
                      bool _714_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _715_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out337;
                      bool _out338;
                      bool _out339;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out340;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out337, out _out338, out _out339, out _out340);
                      _712_recursiveGen = _out337;
                      _713_recOwned = _out338;
                      _714_recErased = _out339;
                      _715_recIdents = _out340;
                      Dafny.ISequence<Dafny.Rune> _716_uneraseFn;
                      _716_uneraseFn = ((_713_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _716_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _712_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _713_recOwned;
                      isErased = true;
                      readIdents = _715_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out341;
                      bool _out342;
                      bool _out343;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out344;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _711_b), _711_b, _480_toTpe), @params, mustOwn, out _out341, out _out342, out _out343, out _out344);
                      s = _out341;
                      isOwned = _out342;
                      isErased = _out343;
                      readIdents = _out344;
                    }
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _717___mcc_h261 = _source32.dtor_Primitive_a0;
                  DAST._IType _718_b = _640___mcc_h213;
                  {
                    if (object.Equals(_718_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _719_recursiveGen;
                      bool _720_recOwned;
                      bool _721_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _722_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out345;
                      bool _out346;
                      bool _out347;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out348;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out345, out _out346, out _out347, out _out348);
                      _719_recursiveGen = _out345;
                      _720_recOwned = _out346;
                      _721_recErased = _out347;
                      _722_recIdents = _out348;
                      Dafny.ISequence<Dafny.Rune> _723_uneraseFn;
                      _723_uneraseFn = ((_720_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _723_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _719_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _720_recOwned;
                      isErased = true;
                      readIdents = _722_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out349;
                      bool _out350;
                      bool _out351;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out352;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _718_b), _718_b, _480_toTpe), @params, mustOwn, out _out349, out _out350, out _out351, out _out352);
                      s = _out349;
                      isOwned = _out350;
                      isErased = _out351;
                      readIdents = _out352;
                    }
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _724___mcc_h264 = _source32.dtor_Passthrough_a0;
                  DAST._IType _725_b = _640___mcc_h213;
                  {
                    if (object.Equals(_725_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _726_recursiveGen;
                      bool _727_recOwned;
                      bool _728_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _729_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out353;
                      bool _out354;
                      bool _out355;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out356;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out353, out _out354, out _out355, out _out356);
                      _726_recursiveGen = _out353;
                      _727_recOwned = _out354;
                      _728_recErased = _out355;
                      _729_recIdents = _out356;
                      Dafny.ISequence<Dafny.Rune> _730_uneraseFn;
                      _730_uneraseFn = ((_727_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _730_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _726_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _727_recOwned;
                      isErased = true;
                      readIdents = _729_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out357;
                      bool _out358;
                      bool _out359;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _725_b), _725_b, _480_toTpe), @params, mustOwn, out _out357, out _out358, out _out359, out _out360);
                      s = _out357;
                      isOwned = _out358;
                      isErased = _out359;
                      readIdents = _out360;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _731___mcc_h267 = _source32.dtor_TypeArg_a0;
                  DAST._IType _732_b = _640___mcc_h213;
                  {
                    if (object.Equals(_732_b, _480_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _733_recursiveGen;
                      bool _734_recOwned;
                      bool _735_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _736_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out361;
                      bool _out362;
                      bool _out363;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out361, out _out362, out _out363, out _out364);
                      _733_recursiveGen = _out361;
                      _734_recOwned = _out362;
                      _735_recErased = _out363;
                      _736_recIdents = _out364;
                      Dafny.ISequence<Dafny.Rune> _737_uneraseFn;
                      _737_uneraseFn = ((_734_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _737_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _733_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _734_recOwned;
                      isErased = true;
                      readIdents = _736_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out365;
                      bool _out366;
                      bool _out367;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _732_b), _732_b, _480_toTpe), @params, mustOwn, out _out365, out _out366, out _out367, out _out368);
                      s = _out365;
                      isOwned = _out366;
                      isErased = _out367;
                      readIdents = _out368;
                    }
                  }
                }
              }
            } else if (_source26.is_Tuple) {
              Dafny.ISequence<DAST._IType> _738___mcc_h270 = _source26.dtor_Tuple_a0;
              DAST._IType _source34 = _488___mcc_h123;
              if (_source34.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _739___mcc_h273 = _source34.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _740___mcc_h274 = _source34.dtor_typeArgs;
                DAST._IResolvedType _741___mcc_h275 = _source34.dtor_resolved;
                DAST._IResolvedType _source35 = _741___mcc_h275;
                if (_source35.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _742___mcc_h279 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _743_recursiveGen;
                    bool _744_recOwned;
                    bool _745_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _746_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out369;
                    bool _out370;
                    bool _out371;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out369, out _out370, out _out371, out _out372);
                    _743_recursiveGen = _out369;
                    _744_recOwned = _out370;
                    _745_recErased = _out371;
                    _746_recIdents = _out372;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _743_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _744_recOwned;
                    isErased = _745_recErased;
                    readIdents = _746_recIdents;
                  }
                } else if (_source35.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _747___mcc_h281 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _748_recursiveGen;
                    bool _749_recOwned;
                    bool _750_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _751_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out373;
                    bool _out374;
                    bool _out375;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out376;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out373, out _out374, out _out375, out _out376);
                    _748_recursiveGen = _out373;
                    _749_recOwned = _out374;
                    _750_recErased = _out375;
                    _751_recIdents = _out376;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _748_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _749_recOwned;
                    isErased = _750_recErased;
                    readIdents = _751_recIdents;
                  }
                } else {
                  DAST._IType _752___mcc_h283 = _source35.dtor_Newtype_a0;
                  DAST._IType _753_b = _752___mcc_h283;
                  {
                    if (object.Equals(_481_fromTpe, _753_b)) {
                      Dafny.ISequence<Dafny.Rune> _754_recursiveGen;
                      bool _755_recOwned;
                      bool _756_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _757_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out377;
                      bool _out378;
                      bool _out379;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out380;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out377, out _out378, out _out379, out _out380);
                      _754_recursiveGen = _out377;
                      _755_recOwned = _out378;
                      _756_recErased = _out379;
                      _757_recIdents = _out380;
                      Dafny.ISequence<Dafny.Rune> _758_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out381;
                      _out381 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _758_rhsType = _out381;
                      Dafny.ISequence<Dafny.Rune> _759_uneraseFn;
                      _759_uneraseFn = ((_755_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _758_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _759_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _754_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _755_recOwned;
                      isErased = false;
                      readIdents = _757_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out382;
                      bool _out383;
                      bool _out384;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out385;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _753_b), _753_b, _480_toTpe), @params, mustOwn, out _out382, out _out383, out _out384, out _out385);
                      s = _out382;
                      isOwned = _out383;
                      isErased = _out384;
                      readIdents = _out385;
                    }
                  }
                }
              } else if (_source34.is_Tuple) {
                Dafny.ISequence<DAST._IType> _760___mcc_h285 = _source34.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _761_recursiveGen;
                  bool _762_recOwned;
                  bool _763_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _764_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out386;
                  bool _out387;
                  bool _out388;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out389;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out386, out _out387, out _out388, out _out389);
                  _761_recursiveGen = _out386;
                  _762_recOwned = _out387;
                  _763_recErased = _out388;
                  _764_recIdents = _out389;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _761_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _762_recOwned;
                  isErased = _763_recErased;
                  readIdents = _764_recIdents;
                }
              } else if (_source34.is_Array) {
                DAST._IType _765___mcc_h287 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _766_recursiveGen;
                  bool _767_recOwned;
                  bool _768_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _769_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out390;
                  bool _out391;
                  bool _out392;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out393;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out390, out _out391, out _out392, out _out393);
                  _766_recursiveGen = _out390;
                  _767_recOwned = _out391;
                  _768_recErased = _out392;
                  _769_recIdents = _out393;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _766_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _767_recOwned;
                  isErased = _768_recErased;
                  readIdents = _769_recIdents;
                }
              } else if (_source34.is_Seq) {
                DAST._IType _770___mcc_h289 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _771_recursiveGen;
                  bool _772_recOwned;
                  bool _773_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _774_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out394;
                  bool _out395;
                  bool _out396;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out397;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out394, out _out395, out _out396, out _out397);
                  _771_recursiveGen = _out394;
                  _772_recOwned = _out395;
                  _773_recErased = _out396;
                  _774_recIdents = _out397;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _771_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _772_recOwned;
                  isErased = _773_recErased;
                  readIdents = _774_recIdents;
                }
              } else if (_source34.is_Set) {
                DAST._IType _775___mcc_h291 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _776_recursiveGen;
                  bool _777_recOwned;
                  bool _778_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _779_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out398;
                  bool _out399;
                  bool _out400;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out401;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out398, out _out399, out _out400, out _out401);
                  _776_recursiveGen = _out398;
                  _777_recOwned = _out399;
                  _778_recErased = _out400;
                  _779_recIdents = _out401;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _776_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _777_recOwned;
                  isErased = _778_recErased;
                  readIdents = _779_recIdents;
                }
              } else if (_source34.is_Multiset) {
                DAST._IType _780___mcc_h293 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _781_recursiveGen;
                  bool _782_recOwned;
                  bool _783_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _784_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out402;
                  bool _out403;
                  bool _out404;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out405;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out402, out _out403, out _out404, out _out405);
                  _781_recursiveGen = _out402;
                  _782_recOwned = _out403;
                  _783_recErased = _out404;
                  _784_recIdents = _out405;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _781_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _782_recOwned;
                  isErased = _783_recErased;
                  readIdents = _784_recIdents;
                }
              } else if (_source34.is_Map) {
                DAST._IType _785___mcc_h295 = _source34.dtor_key;
                DAST._IType _786___mcc_h296 = _source34.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _787_recursiveGen;
                  bool _788_recOwned;
                  bool _789_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _790_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out406;
                  bool _out407;
                  bool _out408;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out409;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out406, out _out407, out _out408, out _out409);
                  _787_recursiveGen = _out406;
                  _788_recOwned = _out407;
                  _789_recErased = _out408;
                  _790_recIdents = _out409;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _787_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _788_recOwned;
                  isErased = _789_recErased;
                  readIdents = _790_recIdents;
                }
              } else if (_source34.is_Arrow) {
                Dafny.ISequence<DAST._IType> _791___mcc_h299 = _source34.dtor_args;
                DAST._IType _792___mcc_h300 = _source34.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _793_recursiveGen;
                  bool _794_recOwned;
                  bool _795_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _796_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out410;
                  bool _out411;
                  bool _out412;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out413;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out410, out _out411, out _out412, out _out413);
                  _793_recursiveGen = _out410;
                  _794_recOwned = _out411;
                  _795_recErased = _out412;
                  _796_recIdents = _out413;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _793_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _794_recOwned;
                  isErased = _795_recErased;
                  readIdents = _796_recIdents;
                }
              } else if (_source34.is_Primitive) {
                DAST._IPrimitive _797___mcc_h303 = _source34.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _798_recursiveGen;
                  bool _799_recOwned;
                  bool _800_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _801_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out414;
                  bool _out415;
                  bool _out416;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out417;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out414, out _out415, out _out416, out _out417);
                  _798_recursiveGen = _out414;
                  _799_recOwned = _out415;
                  _800_recErased = _out416;
                  _801_recIdents = _out417;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _798_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _799_recOwned;
                  isErased = _800_recErased;
                  readIdents = _801_recIdents;
                }
              } else if (_source34.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _802___mcc_h305 = _source34.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _803_recursiveGen;
                  bool _804_recOwned;
                  bool _805_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _806_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out418;
                  bool _out419;
                  bool _out420;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out421;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out418, out _out419, out _out420, out _out421);
                  _803_recursiveGen = _out418;
                  _804_recOwned = _out419;
                  _805_recErased = _out420;
                  _806_recIdents = _out421;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _803_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _804_recOwned;
                  isErased = _805_recErased;
                  readIdents = _806_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _807___mcc_h307 = _source34.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _808_recursiveGen;
                  bool _809_recOwned;
                  bool _810_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _811_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out422;
                  bool _out423;
                  bool _out424;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out425;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out422, out _out423, out _out424, out _out425);
                  _808_recursiveGen = _out422;
                  _809_recOwned = _out423;
                  _810_recErased = _out424;
                  _811_recIdents = _out425;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _808_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _809_recOwned;
                  isErased = _810_recErased;
                  readIdents = _811_recIdents;
                }
              }
            } else if (_source26.is_Array) {
              DAST._IType _812___mcc_h309 = _source26.dtor_element;
              DAST._IType _source36 = _488___mcc_h123;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _813___mcc_h312 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _814___mcc_h313 = _source36.dtor_typeArgs;
                DAST._IResolvedType _815___mcc_h314 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _815___mcc_h314;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _816___mcc_h318 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _817_recursiveGen;
                    bool _818_recOwned;
                    bool _819_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _820_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out426;
                    bool _out427;
                    bool _out428;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out429;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out426, out _out427, out _out428, out _out429);
                    _817_recursiveGen = _out426;
                    _818_recOwned = _out427;
                    _819_recErased = _out428;
                    _820_recIdents = _out429;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _817_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _818_recOwned;
                    isErased = _819_recErased;
                    readIdents = _820_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _821___mcc_h320 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _822_recursiveGen;
                    bool _823_recOwned;
                    bool _824_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _825_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out430;
                    bool _out431;
                    bool _out432;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out433;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out430, out _out431, out _out432, out _out433);
                    _822_recursiveGen = _out430;
                    _823_recOwned = _out431;
                    _824_recErased = _out432;
                    _825_recIdents = _out433;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _822_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _823_recOwned;
                    isErased = _824_recErased;
                    readIdents = _825_recIdents;
                  }
                } else {
                  DAST._IType _826___mcc_h322 = _source37.dtor_Newtype_a0;
                  DAST._IType _827_b = _826___mcc_h322;
                  {
                    if (object.Equals(_481_fromTpe, _827_b)) {
                      Dafny.ISequence<Dafny.Rune> _828_recursiveGen;
                      bool _829_recOwned;
                      bool _830_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _831_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out434;
                      bool _out435;
                      bool _out436;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out437;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out434, out _out435, out _out436, out _out437);
                      _828_recursiveGen = _out434;
                      _829_recOwned = _out435;
                      _830_recErased = _out436;
                      _831_recIdents = _out437;
                      Dafny.ISequence<Dafny.Rune> _832_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out438;
                      _out438 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _832_rhsType = _out438;
                      Dafny.ISequence<Dafny.Rune> _833_uneraseFn;
                      _833_uneraseFn = ((_829_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _832_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _833_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _828_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _829_recOwned;
                      isErased = false;
                      readIdents = _831_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out439;
                      bool _out440;
                      bool _out441;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out442;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _827_b), _827_b, _480_toTpe), @params, mustOwn, out _out439, out _out440, out _out441, out _out442);
                      s = _out439;
                      isOwned = _out440;
                      isErased = _out441;
                      readIdents = _out442;
                    }
                  }
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _834___mcc_h324 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _835_recursiveGen;
                  bool _836_recOwned;
                  bool _837_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _838_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out443;
                  bool _out444;
                  bool _out445;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out446;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out443, out _out444, out _out445, out _out446);
                  _835_recursiveGen = _out443;
                  _836_recOwned = _out444;
                  _837_recErased = _out445;
                  _838_recIdents = _out446;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _835_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _836_recOwned;
                  isErased = _837_recErased;
                  readIdents = _838_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _839___mcc_h326 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _840_recursiveGen;
                  bool _841_recOwned;
                  bool _842_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _843_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out447;
                  bool _out448;
                  bool _out449;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out450;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out447, out _out448, out _out449, out _out450);
                  _840_recursiveGen = _out447;
                  _841_recOwned = _out448;
                  _842_recErased = _out449;
                  _843_recIdents = _out450;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _840_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _841_recOwned;
                  isErased = _842_recErased;
                  readIdents = _843_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _844___mcc_h328 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _845_recursiveGen;
                  bool _846_recOwned;
                  bool _847_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _848_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out451;
                  bool _out452;
                  bool _out453;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out454;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out451, out _out452, out _out453, out _out454);
                  _845_recursiveGen = _out451;
                  _846_recOwned = _out452;
                  _847_recErased = _out453;
                  _848_recIdents = _out454;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _845_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _846_recOwned;
                  isErased = _847_recErased;
                  readIdents = _848_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _849___mcc_h330 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _850_recursiveGen;
                  bool _851_recOwned;
                  bool _852_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _853_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out455;
                  bool _out456;
                  bool _out457;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out458;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out455, out _out456, out _out457, out _out458);
                  _850_recursiveGen = _out455;
                  _851_recOwned = _out456;
                  _852_recErased = _out457;
                  _853_recIdents = _out458;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _850_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _851_recOwned;
                  isErased = _852_recErased;
                  readIdents = _853_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _854___mcc_h332 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _855_recursiveGen;
                  bool _856_recOwned;
                  bool _857_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _858_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out459;
                  bool _out460;
                  bool _out461;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out462;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out459, out _out460, out _out461, out _out462);
                  _855_recursiveGen = _out459;
                  _856_recOwned = _out460;
                  _857_recErased = _out461;
                  _858_recIdents = _out462;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _855_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _856_recOwned;
                  isErased = _857_recErased;
                  readIdents = _858_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _859___mcc_h334 = _source36.dtor_key;
                DAST._IType _860___mcc_h335 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _861_recursiveGen;
                  bool _862_recOwned;
                  bool _863_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _864_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out463;
                  bool _out464;
                  bool _out465;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out466;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out463, out _out464, out _out465, out _out466);
                  _861_recursiveGen = _out463;
                  _862_recOwned = _out464;
                  _863_recErased = _out465;
                  _864_recIdents = _out466;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _861_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _862_recOwned;
                  isErased = _863_recErased;
                  readIdents = _864_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _865___mcc_h338 = _source36.dtor_args;
                DAST._IType _866___mcc_h339 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _867_recursiveGen;
                  bool _868_recOwned;
                  bool _869_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _870_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out467;
                  bool _out468;
                  bool _out469;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out470;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out467, out _out468, out _out469, out _out470);
                  _867_recursiveGen = _out467;
                  _868_recOwned = _out468;
                  _869_recErased = _out469;
                  _870_recIdents = _out470;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _867_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _868_recOwned;
                  isErased = _869_recErased;
                  readIdents = _870_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _871___mcc_h342 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _872_recursiveGen;
                  bool _873_recOwned;
                  bool _874_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _875_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out471;
                  bool _out472;
                  bool _out473;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out474;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out471, out _out472, out _out473, out _out474);
                  _872_recursiveGen = _out471;
                  _873_recOwned = _out472;
                  _874_recErased = _out473;
                  _875_recIdents = _out474;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _872_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _873_recOwned;
                  isErased = _874_recErased;
                  readIdents = _875_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _876___mcc_h344 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _877_recursiveGen;
                  bool _878_recOwned;
                  bool _879_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _880_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out475;
                  bool _out476;
                  bool _out477;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out478;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out475, out _out476, out _out477, out _out478);
                  _877_recursiveGen = _out475;
                  _878_recOwned = _out476;
                  _879_recErased = _out477;
                  _880_recIdents = _out478;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _877_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _878_recOwned;
                  isErased = _879_recErased;
                  readIdents = _880_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _881___mcc_h346 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _882_recursiveGen;
                  bool _883_recOwned;
                  bool _884_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _885_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out479;
                  bool _out480;
                  bool _out481;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out482;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out479, out _out480, out _out481, out _out482);
                  _882_recursiveGen = _out479;
                  _883_recOwned = _out480;
                  _884_recErased = _out481;
                  _885_recIdents = _out482;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _882_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _883_recOwned;
                  isErased = _884_recErased;
                  readIdents = _885_recIdents;
                }
              }
            } else if (_source26.is_Seq) {
              DAST._IType _886___mcc_h348 = _source26.dtor_element;
              DAST._IType _source38 = _488___mcc_h123;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _887___mcc_h351 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _888___mcc_h352 = _source38.dtor_typeArgs;
                DAST._IResolvedType _889___mcc_h353 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _889___mcc_h353;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _890___mcc_h357 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _891_recursiveGen;
                    bool _892_recOwned;
                    bool _893_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _894_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out483;
                    bool _out484;
                    bool _out485;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out486;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out483, out _out484, out _out485, out _out486);
                    _891_recursiveGen = _out483;
                    _892_recOwned = _out484;
                    _893_recErased = _out485;
                    _894_recIdents = _out486;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _892_recOwned;
                    isErased = _893_recErased;
                    readIdents = _894_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _895___mcc_h359 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _896_recursiveGen;
                    bool _897_recOwned;
                    bool _898_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _899_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out487;
                    bool _out488;
                    bool _out489;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out490;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out487, out _out488, out _out489, out _out490);
                    _896_recursiveGen = _out487;
                    _897_recOwned = _out488;
                    _898_recErased = _out489;
                    _899_recIdents = _out490;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _896_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _897_recOwned;
                    isErased = _898_recErased;
                    readIdents = _899_recIdents;
                  }
                } else {
                  DAST._IType _900___mcc_h361 = _source39.dtor_Newtype_a0;
                  DAST._IType _901_b = _900___mcc_h361;
                  {
                    if (object.Equals(_481_fromTpe, _901_b)) {
                      Dafny.ISequence<Dafny.Rune> _902_recursiveGen;
                      bool _903_recOwned;
                      bool _904_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _905_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out491;
                      bool _out492;
                      bool _out493;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out494;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out491, out _out492, out _out493, out _out494);
                      _902_recursiveGen = _out491;
                      _903_recOwned = _out492;
                      _904_recErased = _out493;
                      _905_recIdents = _out494;
                      Dafny.ISequence<Dafny.Rune> _906_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out495;
                      _out495 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _906_rhsType = _out495;
                      Dafny.ISequence<Dafny.Rune> _907_uneraseFn;
                      _907_uneraseFn = ((_903_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _906_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _907_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _902_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _903_recOwned;
                      isErased = false;
                      readIdents = _905_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out496;
                      bool _out497;
                      bool _out498;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out499;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _901_b), _901_b, _480_toTpe), @params, mustOwn, out _out496, out _out497, out _out498, out _out499);
                      s = _out496;
                      isOwned = _out497;
                      isErased = _out498;
                      readIdents = _out499;
                    }
                  }
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _908___mcc_h363 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _909_recursiveGen;
                  bool _910_recOwned;
                  bool _911_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _912_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out500;
                  bool _out501;
                  bool _out502;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out503;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out500, out _out501, out _out502, out _out503);
                  _909_recursiveGen = _out500;
                  _910_recOwned = _out501;
                  _911_recErased = _out502;
                  _912_recIdents = _out503;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _909_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _910_recOwned;
                  isErased = _911_recErased;
                  readIdents = _912_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _913___mcc_h365 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _914_recursiveGen;
                  bool _915_recOwned;
                  bool _916_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _917_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out504;
                  bool _out505;
                  bool _out506;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out507;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out504, out _out505, out _out506, out _out507);
                  _914_recursiveGen = _out504;
                  _915_recOwned = _out505;
                  _916_recErased = _out506;
                  _917_recIdents = _out507;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _914_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _915_recOwned;
                  isErased = _916_recErased;
                  readIdents = _917_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _918___mcc_h367 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _919_recursiveGen;
                  bool _920_recOwned;
                  bool _921_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _922_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out508;
                  bool _out509;
                  bool _out510;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out511;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out508, out _out509, out _out510, out _out511);
                  _919_recursiveGen = _out508;
                  _920_recOwned = _out509;
                  _921_recErased = _out510;
                  _922_recIdents = _out511;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _919_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _920_recOwned;
                  isErased = _921_recErased;
                  readIdents = _922_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _923___mcc_h369 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _924_recursiveGen;
                  bool _925_recOwned;
                  bool _926_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _927_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out512;
                  bool _out513;
                  bool _out514;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out515;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out512, out _out513, out _out514, out _out515);
                  _924_recursiveGen = _out512;
                  _925_recOwned = _out513;
                  _926_recErased = _out514;
                  _927_recIdents = _out515;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _924_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _925_recOwned;
                  isErased = _926_recErased;
                  readIdents = _927_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _928___mcc_h371 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _929_recursiveGen;
                  bool _930_recOwned;
                  bool _931_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _932_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out516;
                  bool _out517;
                  bool _out518;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out519;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out516, out _out517, out _out518, out _out519);
                  _929_recursiveGen = _out516;
                  _930_recOwned = _out517;
                  _931_recErased = _out518;
                  _932_recIdents = _out519;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _929_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _930_recOwned;
                  isErased = _931_recErased;
                  readIdents = _932_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _933___mcc_h373 = _source38.dtor_key;
                DAST._IType _934___mcc_h374 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _935_recursiveGen;
                  bool _936_recOwned;
                  bool _937_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _938_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out520;
                  bool _out521;
                  bool _out522;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out523;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out520, out _out521, out _out522, out _out523);
                  _935_recursiveGen = _out520;
                  _936_recOwned = _out521;
                  _937_recErased = _out522;
                  _938_recIdents = _out523;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _935_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _936_recOwned;
                  isErased = _937_recErased;
                  readIdents = _938_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _939___mcc_h377 = _source38.dtor_args;
                DAST._IType _940___mcc_h378 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _941_recursiveGen;
                  bool _942_recOwned;
                  bool _943_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _944_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out524;
                  bool _out525;
                  bool _out526;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out527;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out524, out _out525, out _out526, out _out527);
                  _941_recursiveGen = _out524;
                  _942_recOwned = _out525;
                  _943_recErased = _out526;
                  _944_recIdents = _out527;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _941_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _942_recOwned;
                  isErased = _943_recErased;
                  readIdents = _944_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _945___mcc_h381 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _946_recursiveGen;
                  bool _947_recOwned;
                  bool _948_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _949_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out528;
                  bool _out529;
                  bool _out530;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out531;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out528, out _out529, out _out530, out _out531);
                  _946_recursiveGen = _out528;
                  _947_recOwned = _out529;
                  _948_recErased = _out530;
                  _949_recIdents = _out531;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _946_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _947_recOwned;
                  isErased = _948_recErased;
                  readIdents = _949_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _950___mcc_h383 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _951_recursiveGen;
                  bool _952_recOwned;
                  bool _953_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _954_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out532;
                  bool _out533;
                  bool _out534;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out535;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out532, out _out533, out _out534, out _out535);
                  _951_recursiveGen = _out532;
                  _952_recOwned = _out533;
                  _953_recErased = _out534;
                  _954_recIdents = _out535;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _951_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _952_recOwned;
                  isErased = _953_recErased;
                  readIdents = _954_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _955___mcc_h385 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _956_recursiveGen;
                  bool _957_recOwned;
                  bool _958_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _959_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out536;
                  bool _out537;
                  bool _out538;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out539;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out536, out _out537, out _out538, out _out539);
                  _956_recursiveGen = _out536;
                  _957_recOwned = _out537;
                  _958_recErased = _out538;
                  _959_recIdents = _out539;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _956_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _957_recOwned;
                  isErased = _958_recErased;
                  readIdents = _959_recIdents;
                }
              }
            } else if (_source26.is_Set) {
              DAST._IType _960___mcc_h387 = _source26.dtor_element;
              DAST._IType _source40 = _488___mcc_h123;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _961___mcc_h390 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _962___mcc_h391 = _source40.dtor_typeArgs;
                DAST._IResolvedType _963___mcc_h392 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _963___mcc_h392;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _964___mcc_h396 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _965_recursiveGen;
                    bool _966_recOwned;
                    bool _967_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _968_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out540;
                    bool _out541;
                    bool _out542;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out543;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out540, out _out541, out _out542, out _out543);
                    _965_recursiveGen = _out540;
                    _966_recOwned = _out541;
                    _967_recErased = _out542;
                    _968_recIdents = _out543;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _965_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _966_recOwned;
                    isErased = _967_recErased;
                    readIdents = _968_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _969___mcc_h398 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _970_recursiveGen;
                    bool _971_recOwned;
                    bool _972_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _973_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out544;
                    bool _out545;
                    bool _out546;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out547;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out544, out _out545, out _out546, out _out547);
                    _970_recursiveGen = _out544;
                    _971_recOwned = _out545;
                    _972_recErased = _out546;
                    _973_recIdents = _out547;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _971_recOwned;
                    isErased = _972_recErased;
                    readIdents = _973_recIdents;
                  }
                } else {
                  DAST._IType _974___mcc_h400 = _source41.dtor_Newtype_a0;
                  DAST._IType _975_b = _974___mcc_h400;
                  {
                    if (object.Equals(_481_fromTpe, _975_b)) {
                      Dafny.ISequence<Dafny.Rune> _976_recursiveGen;
                      bool _977_recOwned;
                      bool _978_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _979_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out548;
                      bool _out549;
                      bool _out550;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out551;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out548, out _out549, out _out550, out _out551);
                      _976_recursiveGen = _out548;
                      _977_recOwned = _out549;
                      _978_recErased = _out550;
                      _979_recIdents = _out551;
                      Dafny.ISequence<Dafny.Rune> _980_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out552;
                      _out552 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _980_rhsType = _out552;
                      Dafny.ISequence<Dafny.Rune> _981_uneraseFn;
                      _981_uneraseFn = ((_977_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _980_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _981_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _976_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _977_recOwned;
                      isErased = false;
                      readIdents = _979_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out553;
                      bool _out554;
                      bool _out555;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out556;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _975_b), _975_b, _480_toTpe), @params, mustOwn, out _out553, out _out554, out _out555, out _out556);
                      s = _out553;
                      isOwned = _out554;
                      isErased = _out555;
                      readIdents = _out556;
                    }
                  }
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _982___mcc_h402 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _983_recursiveGen;
                  bool _984_recOwned;
                  bool _985_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _986_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out557;
                  bool _out558;
                  bool _out559;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out560;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out557, out _out558, out _out559, out _out560);
                  _983_recursiveGen = _out557;
                  _984_recOwned = _out558;
                  _985_recErased = _out559;
                  _986_recIdents = _out560;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _983_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _984_recOwned;
                  isErased = _985_recErased;
                  readIdents = _986_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _987___mcc_h404 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _988_recursiveGen;
                  bool _989_recOwned;
                  bool _990_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _991_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out561;
                  bool _out562;
                  bool _out563;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out564;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out561, out _out562, out _out563, out _out564);
                  _988_recursiveGen = _out561;
                  _989_recOwned = _out562;
                  _990_recErased = _out563;
                  _991_recIdents = _out564;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _988_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _989_recOwned;
                  isErased = _990_recErased;
                  readIdents = _991_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _992___mcc_h406 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _993_recursiveGen;
                  bool _994_recOwned;
                  bool _995_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _996_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out565;
                  bool _out566;
                  bool _out567;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out568;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out565, out _out566, out _out567, out _out568);
                  _993_recursiveGen = _out565;
                  _994_recOwned = _out566;
                  _995_recErased = _out567;
                  _996_recIdents = _out568;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _993_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _994_recOwned;
                  isErased = _995_recErased;
                  readIdents = _996_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _997___mcc_h408 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _998_recursiveGen;
                  bool _999_recOwned;
                  bool _1000_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1001_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out569;
                  bool _out570;
                  bool _out571;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out572;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out569, out _out570, out _out571, out _out572);
                  _998_recursiveGen = _out569;
                  _999_recOwned = _out570;
                  _1000_recErased = _out571;
                  _1001_recIdents = _out572;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _998_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _999_recOwned;
                  isErased = _1000_recErased;
                  readIdents = _1001_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1002___mcc_h410 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1003_recursiveGen;
                  bool _1004_recOwned;
                  bool _1005_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1006_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out573;
                  bool _out574;
                  bool _out575;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out576;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out573, out _out574, out _out575, out _out576);
                  _1003_recursiveGen = _out573;
                  _1004_recOwned = _out574;
                  _1005_recErased = _out575;
                  _1006_recIdents = _out576;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1003_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1004_recOwned;
                  isErased = _1005_recErased;
                  readIdents = _1006_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1007___mcc_h412 = _source40.dtor_key;
                DAST._IType _1008___mcc_h413 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1009_recursiveGen;
                  bool _1010_recOwned;
                  bool _1011_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1012_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out577;
                  bool _out578;
                  bool _out579;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out580;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out577, out _out578, out _out579, out _out580);
                  _1009_recursiveGen = _out577;
                  _1010_recOwned = _out578;
                  _1011_recErased = _out579;
                  _1012_recIdents = _out580;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1009_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1010_recOwned;
                  isErased = _1011_recErased;
                  readIdents = _1012_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1013___mcc_h416 = _source40.dtor_args;
                DAST._IType _1014___mcc_h417 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1015_recursiveGen;
                  bool _1016_recOwned;
                  bool _1017_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1018_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out581;
                  bool _out582;
                  bool _out583;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out584;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out581, out _out582, out _out583, out _out584);
                  _1015_recursiveGen = _out581;
                  _1016_recOwned = _out582;
                  _1017_recErased = _out583;
                  _1018_recIdents = _out584;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1015_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1016_recOwned;
                  isErased = _1017_recErased;
                  readIdents = _1018_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1019___mcc_h420 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1020_recursiveGen;
                  bool _1021_recOwned;
                  bool _1022_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1023_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out585;
                  bool _out586;
                  bool _out587;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out588;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out585, out _out586, out _out587, out _out588);
                  _1020_recursiveGen = _out585;
                  _1021_recOwned = _out586;
                  _1022_recErased = _out587;
                  _1023_recIdents = _out588;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1020_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1021_recOwned;
                  isErased = _1022_recErased;
                  readIdents = _1023_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1024___mcc_h422 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1025_recursiveGen;
                  bool _1026_recOwned;
                  bool _1027_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1028_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out589;
                  bool _out590;
                  bool _out591;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out592;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out589, out _out590, out _out591, out _out592);
                  _1025_recursiveGen = _out589;
                  _1026_recOwned = _out590;
                  _1027_recErased = _out591;
                  _1028_recIdents = _out592;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1026_recOwned;
                  isErased = _1027_recErased;
                  readIdents = _1028_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1029___mcc_h424 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1030_recursiveGen;
                  bool _1031_recOwned;
                  bool _1032_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1033_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out593;
                  bool _out594;
                  bool _out595;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out596;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out593, out _out594, out _out595, out _out596);
                  _1030_recursiveGen = _out593;
                  _1031_recOwned = _out594;
                  _1032_recErased = _out595;
                  _1033_recIdents = _out596;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1030_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1031_recOwned;
                  isErased = _1032_recErased;
                  readIdents = _1033_recIdents;
                }
              }
            } else if (_source26.is_Multiset) {
              DAST._IType _1034___mcc_h426 = _source26.dtor_element;
              DAST._IType _source42 = _488___mcc_h123;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1035___mcc_h429 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1036___mcc_h430 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1037___mcc_h431 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1037___mcc_h431;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1038___mcc_h435 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1039_recursiveGen;
                    bool _1040_recOwned;
                    bool _1041_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1042_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out597;
                    bool _out598;
                    bool _out599;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out600;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out597, out _out598, out _out599, out _out600);
                    _1039_recursiveGen = _out597;
                    _1040_recOwned = _out598;
                    _1041_recErased = _out599;
                    _1042_recIdents = _out600;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1039_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1040_recOwned;
                    isErased = _1041_recErased;
                    readIdents = _1042_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1043___mcc_h437 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1044_recursiveGen;
                    bool _1045_recOwned;
                    bool _1046_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1047_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out601;
                    bool _out602;
                    bool _out603;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out604;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out601, out _out602, out _out603, out _out604);
                    _1044_recursiveGen = _out601;
                    _1045_recOwned = _out602;
                    _1046_recErased = _out603;
                    _1047_recIdents = _out604;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1044_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1045_recOwned;
                    isErased = _1046_recErased;
                    readIdents = _1047_recIdents;
                  }
                } else {
                  DAST._IType _1048___mcc_h439 = _source43.dtor_Newtype_a0;
                  DAST._IType _1049_b = _1048___mcc_h439;
                  {
                    if (object.Equals(_481_fromTpe, _1049_b)) {
                      Dafny.ISequence<Dafny.Rune> _1050_recursiveGen;
                      bool _1051_recOwned;
                      bool _1052_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1053_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out605;
                      bool _out606;
                      bool _out607;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out608;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out605, out _out606, out _out607, out _out608);
                      _1050_recursiveGen = _out605;
                      _1051_recOwned = _out606;
                      _1052_recErased = _out607;
                      _1053_recIdents = _out608;
                      Dafny.ISequence<Dafny.Rune> _1054_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out609;
                      _out609 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _1054_rhsType = _out609;
                      Dafny.ISequence<Dafny.Rune> _1055_uneraseFn;
                      _1055_uneraseFn = ((_1051_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1054_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1055_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1050_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1051_recOwned;
                      isErased = false;
                      readIdents = _1053_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out610;
                      bool _out611;
                      bool _out612;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out613;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1049_b), _1049_b, _480_toTpe), @params, mustOwn, out _out610, out _out611, out _out612, out _out613);
                      s = _out610;
                      isOwned = _out611;
                      isErased = _out612;
                      readIdents = _out613;
                    }
                  }
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1056___mcc_h441 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1057_recursiveGen;
                  bool _1058_recOwned;
                  bool _1059_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1060_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out614;
                  bool _out615;
                  bool _out616;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out617;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out614, out _out615, out _out616, out _out617);
                  _1057_recursiveGen = _out614;
                  _1058_recOwned = _out615;
                  _1059_recErased = _out616;
                  _1060_recIdents = _out617;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1057_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1058_recOwned;
                  isErased = _1059_recErased;
                  readIdents = _1060_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1061___mcc_h443 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1062_recursiveGen;
                  bool _1063_recOwned;
                  bool _1064_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1065_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out618;
                  bool _out619;
                  bool _out620;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out621;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out618, out _out619, out _out620, out _out621);
                  _1062_recursiveGen = _out618;
                  _1063_recOwned = _out619;
                  _1064_recErased = _out620;
                  _1065_recIdents = _out621;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1062_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1063_recOwned;
                  isErased = _1064_recErased;
                  readIdents = _1065_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1066___mcc_h445 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1067_recursiveGen;
                  bool _1068_recOwned;
                  bool _1069_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1070_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out622;
                  bool _out623;
                  bool _out624;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out625;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out622, out _out623, out _out624, out _out625);
                  _1067_recursiveGen = _out622;
                  _1068_recOwned = _out623;
                  _1069_recErased = _out624;
                  _1070_recIdents = _out625;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1067_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1068_recOwned;
                  isErased = _1069_recErased;
                  readIdents = _1070_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1071___mcc_h447 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1072_recursiveGen;
                  bool _1073_recOwned;
                  bool _1074_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1075_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out626;
                  bool _out627;
                  bool _out628;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out629;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out626, out _out627, out _out628, out _out629);
                  _1072_recursiveGen = _out626;
                  _1073_recOwned = _out627;
                  _1074_recErased = _out628;
                  _1075_recIdents = _out629;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1073_recOwned;
                  isErased = _1074_recErased;
                  readIdents = _1075_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1076___mcc_h449 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1077_recursiveGen;
                  bool _1078_recOwned;
                  bool _1079_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1080_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out630;
                  bool _out631;
                  bool _out632;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out633;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out630, out _out631, out _out632, out _out633);
                  _1077_recursiveGen = _out630;
                  _1078_recOwned = _out631;
                  _1079_recErased = _out632;
                  _1080_recIdents = _out633;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1077_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1078_recOwned;
                  isErased = _1079_recErased;
                  readIdents = _1080_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1081___mcc_h451 = _source42.dtor_key;
                DAST._IType _1082___mcc_h452 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1083_recursiveGen;
                  bool _1084_recOwned;
                  bool _1085_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1086_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out634;
                  bool _out635;
                  bool _out636;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out637;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out634, out _out635, out _out636, out _out637);
                  _1083_recursiveGen = _out634;
                  _1084_recOwned = _out635;
                  _1085_recErased = _out636;
                  _1086_recIdents = _out637;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1083_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1084_recOwned;
                  isErased = _1085_recErased;
                  readIdents = _1086_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1087___mcc_h455 = _source42.dtor_args;
                DAST._IType _1088___mcc_h456 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1089_recursiveGen;
                  bool _1090_recOwned;
                  bool _1091_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1092_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out638;
                  bool _out639;
                  bool _out640;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out641;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out638, out _out639, out _out640, out _out641);
                  _1089_recursiveGen = _out638;
                  _1090_recOwned = _out639;
                  _1091_recErased = _out640;
                  _1092_recIdents = _out641;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1089_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1090_recOwned;
                  isErased = _1091_recErased;
                  readIdents = _1092_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1093___mcc_h459 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1094_recursiveGen;
                  bool _1095_recOwned;
                  bool _1096_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1097_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out642;
                  bool _out643;
                  bool _out644;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out645;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out642, out _out643, out _out644, out _out645);
                  _1094_recursiveGen = _out642;
                  _1095_recOwned = _out643;
                  _1096_recErased = _out644;
                  _1097_recIdents = _out645;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1094_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1095_recOwned;
                  isErased = _1096_recErased;
                  readIdents = _1097_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1098___mcc_h461 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1099_recursiveGen;
                  bool _1100_recOwned;
                  bool _1101_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1102_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out646;
                  bool _out647;
                  bool _out648;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out649;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out646, out _out647, out _out648, out _out649);
                  _1099_recursiveGen = _out646;
                  _1100_recOwned = _out647;
                  _1101_recErased = _out648;
                  _1102_recIdents = _out649;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1099_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1100_recOwned;
                  isErased = _1101_recErased;
                  readIdents = _1102_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1103___mcc_h463 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1104_recursiveGen;
                  bool _1105_recOwned;
                  bool _1106_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1107_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out650;
                  bool _out651;
                  bool _out652;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out653;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out650, out _out651, out _out652, out _out653);
                  _1104_recursiveGen = _out650;
                  _1105_recOwned = _out651;
                  _1106_recErased = _out652;
                  _1107_recIdents = _out653;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1104_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1105_recOwned;
                  isErased = _1106_recErased;
                  readIdents = _1107_recIdents;
                }
              }
            } else if (_source26.is_Map) {
              DAST._IType _1108___mcc_h465 = _source26.dtor_key;
              DAST._IType _1109___mcc_h466 = _source26.dtor_value;
              DAST._IType _source44 = _488___mcc_h123;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1110___mcc_h471 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1111___mcc_h472 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1112___mcc_h473 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1112___mcc_h473;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1113___mcc_h477 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1114_recursiveGen;
                    bool _1115_recOwned;
                    bool _1116_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1117_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out654;
                    bool _out655;
                    bool _out656;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out657;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out654, out _out655, out _out656, out _out657);
                    _1114_recursiveGen = _out654;
                    _1115_recOwned = _out655;
                    _1116_recErased = _out656;
                    _1117_recIdents = _out657;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1114_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1115_recOwned;
                    isErased = _1116_recErased;
                    readIdents = _1117_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1118___mcc_h479 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1119_recursiveGen;
                    bool _1120_recOwned;
                    bool _1121_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1122_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out658;
                    bool _out659;
                    bool _out660;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out661;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out658, out _out659, out _out660, out _out661);
                    _1119_recursiveGen = _out658;
                    _1120_recOwned = _out659;
                    _1121_recErased = _out660;
                    _1122_recIdents = _out661;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1119_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1120_recOwned;
                    isErased = _1121_recErased;
                    readIdents = _1122_recIdents;
                  }
                } else {
                  DAST._IType _1123___mcc_h481 = _source45.dtor_Newtype_a0;
                  DAST._IType _1124_b = _1123___mcc_h481;
                  {
                    if (object.Equals(_481_fromTpe, _1124_b)) {
                      Dafny.ISequence<Dafny.Rune> _1125_recursiveGen;
                      bool _1126_recOwned;
                      bool _1127_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1128_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out662;
                      bool _out663;
                      bool _out664;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out665;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out662, out _out663, out _out664, out _out665);
                      _1125_recursiveGen = _out662;
                      _1126_recOwned = _out663;
                      _1127_recErased = _out664;
                      _1128_recIdents = _out665;
                      Dafny.ISequence<Dafny.Rune> _1129_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out666;
                      _out666 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _1129_rhsType = _out666;
                      Dafny.ISequence<Dafny.Rune> _1130_uneraseFn;
                      _1130_uneraseFn = ((_1126_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1129_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1130_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1125_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1126_recOwned;
                      isErased = false;
                      readIdents = _1128_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out667;
                      bool _out668;
                      bool _out669;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out670;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1124_b), _1124_b, _480_toTpe), @params, mustOwn, out _out667, out _out668, out _out669, out _out670);
                      s = _out667;
                      isOwned = _out668;
                      isErased = _out669;
                      readIdents = _out670;
                    }
                  }
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1131___mcc_h483 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1132_recursiveGen;
                  bool _1133_recOwned;
                  bool _1134_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1135_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out671;
                  bool _out672;
                  bool _out673;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out674;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out671, out _out672, out _out673, out _out674);
                  _1132_recursiveGen = _out671;
                  _1133_recOwned = _out672;
                  _1134_recErased = _out673;
                  _1135_recIdents = _out674;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1132_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1133_recOwned;
                  isErased = _1134_recErased;
                  readIdents = _1135_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1136___mcc_h485 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1137_recursiveGen;
                  bool _1138_recOwned;
                  bool _1139_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1140_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out675;
                  bool _out676;
                  bool _out677;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out678;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out675, out _out676, out _out677, out _out678);
                  _1137_recursiveGen = _out675;
                  _1138_recOwned = _out676;
                  _1139_recErased = _out677;
                  _1140_recIdents = _out678;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1137_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1138_recOwned;
                  isErased = _1139_recErased;
                  readIdents = _1140_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1141___mcc_h487 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1142_recursiveGen;
                  bool _1143_recOwned;
                  bool _1144_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1145_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out679;
                  bool _out680;
                  bool _out681;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out682;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out679, out _out680, out _out681, out _out682);
                  _1142_recursiveGen = _out679;
                  _1143_recOwned = _out680;
                  _1144_recErased = _out681;
                  _1145_recIdents = _out682;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1142_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1143_recOwned;
                  isErased = _1144_recErased;
                  readIdents = _1145_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1146___mcc_h489 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1147_recursiveGen;
                  bool _1148_recOwned;
                  bool _1149_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1150_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out683;
                  bool _out684;
                  bool _out685;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out686;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out683, out _out684, out _out685, out _out686);
                  _1147_recursiveGen = _out683;
                  _1148_recOwned = _out684;
                  _1149_recErased = _out685;
                  _1150_recIdents = _out686;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1147_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1148_recOwned;
                  isErased = _1149_recErased;
                  readIdents = _1150_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1151___mcc_h491 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1152_recursiveGen;
                  bool _1153_recOwned;
                  bool _1154_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1155_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out687;
                  bool _out688;
                  bool _out689;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out690;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out687, out _out688, out _out689, out _out690);
                  _1152_recursiveGen = _out687;
                  _1153_recOwned = _out688;
                  _1154_recErased = _out689;
                  _1155_recIdents = _out690;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1152_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1153_recOwned;
                  isErased = _1154_recErased;
                  readIdents = _1155_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1156___mcc_h493 = _source44.dtor_key;
                DAST._IType _1157___mcc_h494 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1158_recursiveGen;
                  bool _1159_recOwned;
                  bool _1160_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1161_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out691;
                  bool _out692;
                  bool _out693;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out694;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out691, out _out692, out _out693, out _out694);
                  _1158_recursiveGen = _out691;
                  _1159_recOwned = _out692;
                  _1160_recErased = _out693;
                  _1161_recIdents = _out694;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1158_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1159_recOwned;
                  isErased = _1160_recErased;
                  readIdents = _1161_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1162___mcc_h497 = _source44.dtor_args;
                DAST._IType _1163___mcc_h498 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1164_recursiveGen;
                  bool _1165_recOwned;
                  bool _1166_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1167_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out695;
                  bool _out696;
                  bool _out697;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out698;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out695, out _out696, out _out697, out _out698);
                  _1164_recursiveGen = _out695;
                  _1165_recOwned = _out696;
                  _1166_recErased = _out697;
                  _1167_recIdents = _out698;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1164_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1165_recOwned;
                  isErased = _1166_recErased;
                  readIdents = _1167_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1168___mcc_h501 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1169_recursiveGen;
                  bool _1170_recOwned;
                  bool _1171_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1172_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out699;
                  bool _out700;
                  bool _out701;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out702;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out699, out _out700, out _out701, out _out702);
                  _1169_recursiveGen = _out699;
                  _1170_recOwned = _out700;
                  _1171_recErased = _out701;
                  _1172_recIdents = _out702;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1169_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1170_recOwned;
                  isErased = _1171_recErased;
                  readIdents = _1172_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1173___mcc_h503 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1174_recursiveGen;
                  bool _1175_recOwned;
                  bool _1176_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1177_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out703;
                  bool _out704;
                  bool _out705;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out706;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out703, out _out704, out _out705, out _out706);
                  _1174_recursiveGen = _out703;
                  _1175_recOwned = _out704;
                  _1176_recErased = _out705;
                  _1177_recIdents = _out706;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1174_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1175_recOwned;
                  isErased = _1176_recErased;
                  readIdents = _1177_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1178___mcc_h505 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1179_recursiveGen;
                  bool _1180_recOwned;
                  bool _1181_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1182_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out707;
                  bool _out708;
                  bool _out709;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out710;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out707, out _out708, out _out709, out _out710);
                  _1179_recursiveGen = _out707;
                  _1180_recOwned = _out708;
                  _1181_recErased = _out709;
                  _1182_recIdents = _out710;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1179_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1180_recOwned;
                  isErased = _1181_recErased;
                  readIdents = _1182_recIdents;
                }
              }
            } else if (_source26.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1183___mcc_h507 = _source26.dtor_args;
              DAST._IType _1184___mcc_h508 = _source26.dtor_result;
              DAST._IType _source46 = _488___mcc_h123;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1185___mcc_h513 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1186___mcc_h514 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1187___mcc_h515 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1187___mcc_h515;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1188___mcc_h519 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                    bool _1190_recOwned;
                    bool _1191_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out711;
                    bool _out712;
                    bool _out713;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out714;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out711, out _out712, out _out713, out _out714);
                    _1189_recursiveGen = _out711;
                    _1190_recOwned = _out712;
                    _1191_recErased = _out713;
                    _1192_recIdents = _out714;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1190_recOwned;
                    isErased = _1191_recErased;
                    readIdents = _1192_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1193___mcc_h521 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1194_recursiveGen;
                    bool _1195_recOwned;
                    bool _1196_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1197_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out715;
                    bool _out716;
                    bool _out717;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out718;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out715, out _out716, out _out717, out _out718);
                    _1194_recursiveGen = _out715;
                    _1195_recOwned = _out716;
                    _1196_recErased = _out717;
                    _1197_recIdents = _out718;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1194_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1195_recOwned;
                    isErased = _1196_recErased;
                    readIdents = _1197_recIdents;
                  }
                } else {
                  DAST._IType _1198___mcc_h523 = _source47.dtor_Newtype_a0;
                  DAST._IType _1199_b = _1198___mcc_h523;
                  {
                    if (object.Equals(_481_fromTpe, _1199_b)) {
                      Dafny.ISequence<Dafny.Rune> _1200_recursiveGen;
                      bool _1201_recOwned;
                      bool _1202_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1203_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out719;
                      bool _out720;
                      bool _out721;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out722;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out719, out _out720, out _out721, out _out722);
                      _1200_recursiveGen = _out719;
                      _1201_recOwned = _out720;
                      _1202_recErased = _out721;
                      _1203_recIdents = _out722;
                      Dafny.ISequence<Dafny.Rune> _1204_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out723;
                      _out723 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _1204_rhsType = _out723;
                      Dafny.ISequence<Dafny.Rune> _1205_uneraseFn;
                      _1205_uneraseFn = ((_1201_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1204_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1205_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1200_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1201_recOwned;
                      isErased = false;
                      readIdents = _1203_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out724;
                      bool _out725;
                      bool _out726;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out727;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1199_b), _1199_b, _480_toTpe), @params, mustOwn, out _out724, out _out725, out _out726, out _out727);
                      s = _out724;
                      isOwned = _out725;
                      isErased = _out726;
                      readIdents = _out727;
                    }
                  }
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1206___mcc_h525 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1207_recursiveGen;
                  bool _1208_recOwned;
                  bool _1209_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1210_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out728;
                  bool _out729;
                  bool _out730;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out731;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out728, out _out729, out _out730, out _out731);
                  _1207_recursiveGen = _out728;
                  _1208_recOwned = _out729;
                  _1209_recErased = _out730;
                  _1210_recIdents = _out731;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1207_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1208_recOwned;
                  isErased = _1209_recErased;
                  readIdents = _1210_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1211___mcc_h527 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1212_recursiveGen;
                  bool _1213_recOwned;
                  bool _1214_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1215_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out732;
                  bool _out733;
                  bool _out734;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out735;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out732, out _out733, out _out734, out _out735);
                  _1212_recursiveGen = _out732;
                  _1213_recOwned = _out733;
                  _1214_recErased = _out734;
                  _1215_recIdents = _out735;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1212_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1213_recOwned;
                  isErased = _1214_recErased;
                  readIdents = _1215_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1216___mcc_h529 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1217_recursiveGen;
                  bool _1218_recOwned;
                  bool _1219_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1220_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out736;
                  bool _out737;
                  bool _out738;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out739;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out736, out _out737, out _out738, out _out739);
                  _1217_recursiveGen = _out736;
                  _1218_recOwned = _out737;
                  _1219_recErased = _out738;
                  _1220_recIdents = _out739;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1217_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1218_recOwned;
                  isErased = _1219_recErased;
                  readIdents = _1220_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1221___mcc_h531 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1222_recursiveGen;
                  bool _1223_recOwned;
                  bool _1224_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1225_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out740;
                  bool _out741;
                  bool _out742;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out743;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out740, out _out741, out _out742, out _out743);
                  _1222_recursiveGen = _out740;
                  _1223_recOwned = _out741;
                  _1224_recErased = _out742;
                  _1225_recIdents = _out743;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1222_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1223_recOwned;
                  isErased = _1224_recErased;
                  readIdents = _1225_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1226___mcc_h533 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1227_recursiveGen;
                  bool _1228_recOwned;
                  bool _1229_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1230_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out744;
                  bool _out745;
                  bool _out746;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out747;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out744, out _out745, out _out746, out _out747);
                  _1227_recursiveGen = _out744;
                  _1228_recOwned = _out745;
                  _1229_recErased = _out746;
                  _1230_recIdents = _out747;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1227_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1228_recOwned;
                  isErased = _1229_recErased;
                  readIdents = _1230_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1231___mcc_h535 = _source46.dtor_key;
                DAST._IType _1232___mcc_h536 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1233_recursiveGen;
                  bool _1234_recOwned;
                  bool _1235_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1236_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out748;
                  bool _out749;
                  bool _out750;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out751;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out748, out _out749, out _out750, out _out751);
                  _1233_recursiveGen = _out748;
                  _1234_recOwned = _out749;
                  _1235_recErased = _out750;
                  _1236_recIdents = _out751;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1233_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1234_recOwned;
                  isErased = _1235_recErased;
                  readIdents = _1236_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1237___mcc_h539 = _source46.dtor_args;
                DAST._IType _1238___mcc_h540 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1239_recursiveGen;
                  bool _1240_recOwned;
                  bool _1241_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1242_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out752;
                  bool _out753;
                  bool _out754;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out755;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out752, out _out753, out _out754, out _out755);
                  _1239_recursiveGen = _out752;
                  _1240_recOwned = _out753;
                  _1241_recErased = _out754;
                  _1242_recIdents = _out755;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1239_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1240_recOwned;
                  isErased = _1241_recErased;
                  readIdents = _1242_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1243___mcc_h543 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1244_recursiveGen;
                  bool _1245_recOwned;
                  bool _1246_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1247_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out756;
                  bool _out757;
                  bool _out758;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out759;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out756, out _out757, out _out758, out _out759);
                  _1244_recursiveGen = _out756;
                  _1245_recOwned = _out757;
                  _1246_recErased = _out758;
                  _1247_recIdents = _out759;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1244_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1245_recOwned;
                  isErased = _1246_recErased;
                  readIdents = _1247_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1248___mcc_h545 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1249_recursiveGen;
                  bool _1250_recOwned;
                  bool _1251_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1252_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out760;
                  bool _out761;
                  bool _out762;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out763;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out760, out _out761, out _out762, out _out763);
                  _1249_recursiveGen = _out760;
                  _1250_recOwned = _out761;
                  _1251_recErased = _out762;
                  _1252_recIdents = _out763;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1249_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1250_recOwned;
                  isErased = _1251_recErased;
                  readIdents = _1252_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1253___mcc_h547 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1254_recursiveGen;
                  bool _1255_recOwned;
                  bool _1256_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1257_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out764;
                  bool _out765;
                  bool _out766;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out767;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out764, out _out765, out _out766, out _out767);
                  _1254_recursiveGen = _out764;
                  _1255_recOwned = _out765;
                  _1256_recErased = _out766;
                  _1257_recIdents = _out767;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1254_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1255_recOwned;
                  isErased = _1256_recErased;
                  readIdents = _1257_recIdents;
                }
              }
            } else if (_source26.is_Primitive) {
              DAST._IPrimitive _1258___mcc_h549 = _source26.dtor_Primitive_a0;
              DAST._IPrimitive _source48 = _1258___mcc_h549;
              if (_source48.is_Int) {
                DAST._IType _source49 = _488___mcc_h123;
                if (_source49.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1259___mcc_h552 = _source49.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1260___mcc_h553 = _source49.dtor_typeArgs;
                  DAST._IResolvedType _1261___mcc_h554 = _source49.dtor_resolved;
                  DAST._IResolvedType _source50 = _1261___mcc_h554;
                  if (_source50.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1262___mcc_h558 = _source50.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1263_recursiveGen;
                      bool _1264_recOwned;
                      bool _1265_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1266_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out768;
                      bool _out769;
                      bool _out770;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out771;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out768, out _out769, out _out770, out _out771);
                      _1263_recursiveGen = _out768;
                      _1264_recOwned = _out769;
                      _1265_recErased = _out770;
                      _1266_recIdents = _out771;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1263_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1264_recOwned;
                      isErased = _1265_recErased;
                      readIdents = _1266_recIdents;
                    }
                  } else if (_source50.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1267___mcc_h560 = _source50.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1268_recursiveGen;
                      bool _1269_recOwned;
                      bool _1270_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1271_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out772;
                      bool _out773;
                      bool _out774;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out775;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out772, out _out773, out _out774, out _out775);
                      _1268_recursiveGen = _out772;
                      _1269_recOwned = _out773;
                      _1270_recErased = _out774;
                      _1271_recIdents = _out775;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1268_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1269_recOwned;
                      isErased = _1270_recErased;
                      readIdents = _1271_recIdents;
                    }
                  } else {
                    DAST._IType _1272___mcc_h562 = _source50.dtor_Newtype_a0;
                    DAST._IType _1273_b = _1272___mcc_h562;
                    {
                      if (object.Equals(_481_fromTpe, _1273_b)) {
                        Dafny.ISequence<Dafny.Rune> _1274_recursiveGen;
                        bool _1275_recOwned;
                        bool _1276_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1277_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out776;
                        bool _out777;
                        bool _out778;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out779;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out776, out _out777, out _out778, out _out779);
                        _1274_recursiveGen = _out776;
                        _1275_recOwned = _out777;
                        _1276_recErased = _out778;
                        _1277_recIdents = _out779;
                        Dafny.ISequence<Dafny.Rune> _1278_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out780;
                        _out780 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _1278_rhsType = _out780;
                        Dafny.ISequence<Dafny.Rune> _1279_uneraseFn;
                        _1279_uneraseFn = ((_1275_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1278_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1279_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1274_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1275_recOwned;
                        isErased = false;
                        readIdents = _1277_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out781;
                        bool _out782;
                        bool _out783;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out784;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1273_b), _1273_b, _480_toTpe), @params, mustOwn, out _out781, out _out782, out _out783, out _out784);
                        s = _out781;
                        isOwned = _out782;
                        isErased = _out783;
                        readIdents = _out784;
                      }
                    }
                  }
                } else if (_source49.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1280___mcc_h564 = _source49.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1281_recursiveGen;
                    bool _1282_recOwned;
                    bool _1283_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1284_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out785;
                    bool _out786;
                    bool _out787;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out788;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out785, out _out786, out _out787, out _out788);
                    _1281_recursiveGen = _out785;
                    _1282_recOwned = _out786;
                    _1283_recErased = _out787;
                    _1284_recIdents = _out788;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1281_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1282_recOwned;
                    isErased = _1283_recErased;
                    readIdents = _1284_recIdents;
                  }
                } else if (_source49.is_Array) {
                  DAST._IType _1285___mcc_h566 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1286_recursiveGen;
                    bool _1287_recOwned;
                    bool _1288_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1289_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out789;
                    bool _out790;
                    bool _out791;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out792;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out789, out _out790, out _out791, out _out792);
                    _1286_recursiveGen = _out789;
                    _1287_recOwned = _out790;
                    _1288_recErased = _out791;
                    _1289_recIdents = _out792;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1286_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1287_recOwned;
                    isErased = _1288_recErased;
                    readIdents = _1289_recIdents;
                  }
                } else if (_source49.is_Seq) {
                  DAST._IType _1290___mcc_h568 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1291_recursiveGen;
                    bool _1292_recOwned;
                    bool _1293_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1294_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out793;
                    bool _out794;
                    bool _out795;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out796;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out793, out _out794, out _out795, out _out796);
                    _1291_recursiveGen = _out793;
                    _1292_recOwned = _out794;
                    _1293_recErased = _out795;
                    _1294_recIdents = _out796;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1291_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1292_recOwned;
                    isErased = _1293_recErased;
                    readIdents = _1294_recIdents;
                  }
                } else if (_source49.is_Set) {
                  DAST._IType _1295___mcc_h570 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1296_recursiveGen;
                    bool _1297_recOwned;
                    bool _1298_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1299_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out797;
                    bool _out798;
                    bool _out799;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out800;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out797, out _out798, out _out799, out _out800);
                    _1296_recursiveGen = _out797;
                    _1297_recOwned = _out798;
                    _1298_recErased = _out799;
                    _1299_recIdents = _out800;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1296_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1297_recOwned;
                    isErased = _1298_recErased;
                    readIdents = _1299_recIdents;
                  }
                } else if (_source49.is_Multiset) {
                  DAST._IType _1300___mcc_h572 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1301_recursiveGen;
                    bool _1302_recOwned;
                    bool _1303_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1304_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out801;
                    bool _out802;
                    bool _out803;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out804;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out801, out _out802, out _out803, out _out804);
                    _1301_recursiveGen = _out801;
                    _1302_recOwned = _out802;
                    _1303_recErased = _out803;
                    _1304_recIdents = _out804;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1301_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1302_recOwned;
                    isErased = _1303_recErased;
                    readIdents = _1304_recIdents;
                  }
                } else if (_source49.is_Map) {
                  DAST._IType _1305___mcc_h574 = _source49.dtor_key;
                  DAST._IType _1306___mcc_h575 = _source49.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1307_recursiveGen;
                    bool _1308_recOwned;
                    bool _1309_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1310_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out805;
                    bool _out806;
                    bool _out807;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out808;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out805, out _out806, out _out807, out _out808);
                    _1307_recursiveGen = _out805;
                    _1308_recOwned = _out806;
                    _1309_recErased = _out807;
                    _1310_recIdents = _out808;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1307_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1308_recOwned;
                    isErased = _1309_recErased;
                    readIdents = _1310_recIdents;
                  }
                } else if (_source49.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1311___mcc_h578 = _source49.dtor_args;
                  DAST._IType _1312___mcc_h579 = _source49.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1313_recursiveGen;
                    bool _1314_recOwned;
                    bool _1315_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1316_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out809;
                    bool _out810;
                    bool _out811;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out812;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out809, out _out810, out _out811, out _out812);
                    _1313_recursiveGen = _out809;
                    _1314_recOwned = _out810;
                    _1315_recErased = _out811;
                    _1316_recIdents = _out812;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1313_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1314_recOwned;
                    isErased = _1315_recErased;
                    readIdents = _1316_recIdents;
                  }
                } else if (_source49.is_Primitive) {
                  DAST._IPrimitive _1317___mcc_h582 = _source49.dtor_Primitive_a0;
                  DAST._IPrimitive _source51 = _1317___mcc_h582;
                  if (_source51.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1318_recursiveGen;
                      bool _1319_recOwned;
                      bool _1320_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1321_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out813;
                      bool _out814;
                      bool _out815;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out816;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out813, out _out814, out _out815, out _out816);
                      _1318_recursiveGen = _out813;
                      _1319_recOwned = _out814;
                      _1320_recErased = _out815;
                      _1321_recIdents = _out816;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1318_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1319_recOwned;
                      isErased = _1320_recErased;
                      readIdents = _1321_recIdents;
                    }
                  } else if (_source51.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1322_recursiveGen;
                      bool _1323___v40;
                      bool _1324___v41;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1325_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out817;
                      bool _out818;
                      bool _out819;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out820;
                      DCOMP.COMP.GenExpr(_482_expr, @params, true, out _out817, out _out818, out _out819, out _out820);
                      _1322_recursiveGen = _out817;
                      _1323___v40 = _out818;
                      _1324___v41 = _out819;
                      _1325_recIdents = _out820;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1322_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1325_recIdents;
                    }
                  } else if (_source51.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1326_recursiveGen;
                      bool _1327_recOwned;
                      bool _1328_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1329_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out821;
                      bool _out822;
                      bool _out823;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out824;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out821, out _out822, out _out823, out _out824);
                      _1326_recursiveGen = _out821;
                      _1327_recOwned = _out822;
                      _1328_recErased = _out823;
                      _1329_recIdents = _out824;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1326_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1327_recOwned;
                      isErased = _1328_recErased;
                      readIdents = _1329_recIdents;
                    }
                  } else if (_source51.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1330_recursiveGen;
                      bool _1331_recOwned;
                      bool _1332_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1333_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out825;
                      bool _out826;
                      bool _out827;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out828;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out825, out _out826, out _out827, out _out828);
                      _1330_recursiveGen = _out825;
                      _1331_recOwned = _out826;
                      _1332_recErased = _out827;
                      _1333_recIdents = _out828;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1330_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1331_recOwned;
                      isErased = _1332_recErased;
                      readIdents = _1333_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1334_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out829;
                      _out829 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _1334_rhsType = _out829;
                      Dafny.ISequence<Dafny.Rune> _1335_recursiveGen;
                      bool _1336___v50;
                      bool _1337___v51;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1338_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out830;
                      bool _out831;
                      bool _out832;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out833;
                      DCOMP.COMP.GenExpr(_482_expr, @params, true, out _out830, out _out831, out _out832, out _out833);
                      _1335_recursiveGen = _out830;
                      _1336___v50 = _out831;
                      _1337___v51 = _out832;
                      _1338_recIdents = _out833;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1335_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1338_recIdents;
                    }
                  }
                } else if (_source49.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1339___mcc_h584 = _source49.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1340_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out834;
                    _out834 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                    _1340_rhsType = _out834;
                    Dafny.ISequence<Dafny.Rune> _1341_recursiveGen;
                    bool _1342___v45;
                    bool _1343___v46;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1344_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out835;
                    bool _out836;
                    bool _out837;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                    DCOMP.COMP.GenExpr(_482_expr, @params, true, out _out835, out _out836, out _out837, out _out838);
                    _1341_recursiveGen = _out835;
                    _1342___v45 = _out836;
                    _1343___v46 = _out837;
                    _1344_recIdents = _out838;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1340_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1341_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1344_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1345___mcc_h586 = _source49.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1346_recursiveGen;
                    bool _1347_recOwned;
                    bool _1348_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1349_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out839;
                    bool _out840;
                    bool _out841;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                    _1346_recursiveGen = _out839;
                    _1347_recOwned = _out840;
                    _1348_recErased = _out841;
                    _1349_recIdents = _out842;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1346_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1347_recOwned;
                    isErased = _1348_recErased;
                    readIdents = _1349_recIdents;
                  }
                }
              } else if (_source48.is_Real) {
                DAST._IType _source52 = _488___mcc_h123;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1350___mcc_h588 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1351___mcc_h589 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1352___mcc_h590 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1352___mcc_h590;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1353___mcc_h594 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1354_recursiveGen;
                      bool _1355_recOwned;
                      bool _1356_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1357_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out843;
                      bool _out844;
                      bool _out845;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                      _1354_recursiveGen = _out843;
                      _1355_recOwned = _out844;
                      _1356_recErased = _out845;
                      _1357_recIdents = _out846;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1354_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1355_recOwned;
                      isErased = _1356_recErased;
                      readIdents = _1357_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1358___mcc_h596 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1359_recursiveGen;
                      bool _1360_recOwned;
                      bool _1361_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1362_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out847;
                      bool _out848;
                      bool _out849;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out850;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out847, out _out848, out _out849, out _out850);
                      _1359_recursiveGen = _out847;
                      _1360_recOwned = _out848;
                      _1361_recErased = _out849;
                      _1362_recIdents = _out850;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1359_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1360_recOwned;
                      isErased = _1361_recErased;
                      readIdents = _1362_recIdents;
                    }
                  } else {
                    DAST._IType _1363___mcc_h598 = _source53.dtor_Newtype_a0;
                    DAST._IType _1364_b = _1363___mcc_h598;
                    {
                      if (object.Equals(_481_fromTpe, _1364_b)) {
                        Dafny.ISequence<Dafny.Rune> _1365_recursiveGen;
                        bool _1366_recOwned;
                        bool _1367_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1368_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out851;
                        bool _out852;
                        bool _out853;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out854;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out851, out _out852, out _out853, out _out854);
                        _1365_recursiveGen = _out851;
                        _1366_recOwned = _out852;
                        _1367_recErased = _out853;
                        _1368_recIdents = _out854;
                        Dafny.ISequence<Dafny.Rune> _1369_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out855;
                        _out855 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _1369_rhsType = _out855;
                        Dafny.ISequence<Dafny.Rune> _1370_uneraseFn;
                        _1370_uneraseFn = ((_1366_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1369_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1370_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1365_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1366_recOwned;
                        isErased = false;
                        readIdents = _1368_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out856;
                        bool _out857;
                        bool _out858;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out859;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1364_b), _1364_b, _480_toTpe), @params, mustOwn, out _out856, out _out857, out _out858, out _out859);
                        s = _out856;
                        isOwned = _out857;
                        isErased = _out858;
                        readIdents = _out859;
                      }
                    }
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1371___mcc_h600 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1372_recursiveGen;
                    bool _1373_recOwned;
                    bool _1374_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1375_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out860;
                    bool _out861;
                    bool _out862;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out863;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out860, out _out861, out _out862, out _out863);
                    _1372_recursiveGen = _out860;
                    _1373_recOwned = _out861;
                    _1374_recErased = _out862;
                    _1375_recIdents = _out863;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1372_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1373_recOwned;
                    isErased = _1374_recErased;
                    readIdents = _1375_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1376___mcc_h602 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1377_recursiveGen;
                    bool _1378_recOwned;
                    bool _1379_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1380_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out864;
                    bool _out865;
                    bool _out866;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out867;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out864, out _out865, out _out866, out _out867);
                    _1377_recursiveGen = _out864;
                    _1378_recOwned = _out865;
                    _1379_recErased = _out866;
                    _1380_recIdents = _out867;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1377_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1378_recOwned;
                    isErased = _1379_recErased;
                    readIdents = _1380_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1381___mcc_h604 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1382_recursiveGen;
                    bool _1383_recOwned;
                    bool _1384_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1385_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out868;
                    bool _out869;
                    bool _out870;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out871;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out868, out _out869, out _out870, out _out871);
                    _1382_recursiveGen = _out868;
                    _1383_recOwned = _out869;
                    _1384_recErased = _out870;
                    _1385_recIdents = _out871;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1382_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1383_recOwned;
                    isErased = _1384_recErased;
                    readIdents = _1385_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1386___mcc_h606 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1387_recursiveGen;
                    bool _1388_recOwned;
                    bool _1389_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1390_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out872;
                    bool _out873;
                    bool _out874;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                    _1387_recursiveGen = _out872;
                    _1388_recOwned = _out873;
                    _1389_recErased = _out874;
                    _1390_recIdents = _out875;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1387_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1388_recOwned;
                    isErased = _1389_recErased;
                    readIdents = _1390_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1391___mcc_h608 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1392_recursiveGen;
                    bool _1393_recOwned;
                    bool _1394_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1395_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out876;
                    bool _out877;
                    bool _out878;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                    _1392_recursiveGen = _out876;
                    _1393_recOwned = _out877;
                    _1394_recErased = _out878;
                    _1395_recIdents = _out879;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1392_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1393_recOwned;
                    isErased = _1394_recErased;
                    readIdents = _1395_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1396___mcc_h610 = _source52.dtor_key;
                  DAST._IType _1397___mcc_h611 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1398_recursiveGen;
                    bool _1399_recOwned;
                    bool _1400_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1401_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out880;
                    bool _out881;
                    bool _out882;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out880, out _out881, out _out882, out _out883);
                    _1398_recursiveGen = _out880;
                    _1399_recOwned = _out881;
                    _1400_recErased = _out882;
                    _1401_recIdents = _out883;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1398_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1399_recOwned;
                    isErased = _1400_recErased;
                    readIdents = _1401_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1402___mcc_h614 = _source52.dtor_args;
                  DAST._IType _1403___mcc_h615 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1404_recursiveGen;
                    bool _1405_recOwned;
                    bool _1406_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1407_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out884;
                    bool _out885;
                    bool _out886;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                    _1404_recursiveGen = _out884;
                    _1405_recOwned = _out885;
                    _1406_recErased = _out886;
                    _1407_recIdents = _out887;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1404_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1405_recOwned;
                    isErased = _1406_recErased;
                    readIdents = _1407_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1408___mcc_h618 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1408___mcc_h618;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1409_recursiveGen;
                      bool _1410___v42;
                      bool _1411___v43;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1412_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out888;
                      bool _out889;
                      bool _out890;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                      DCOMP.COMP.GenExpr(_482_expr, @params, false, out _out888, out _out889, out _out890, out _out891);
                      _1409_recursiveGen = _out888;
                      _1410___v42 = _out889;
                      _1411___v43 = _out890;
                      _1412_recIdents = _out891;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1409_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1412_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                      bool _1414_recOwned;
                      bool _1415_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out892;
                      bool _out893;
                      bool _out894;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                      _1413_recursiveGen = _out892;
                      _1414_recOwned = _out893;
                      _1415_recErased = _out894;
                      _1416_recIdents = _out895;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1414_recOwned;
                      isErased = _1415_recErased;
                      readIdents = _1416_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1417_recursiveGen;
                      bool _1418_recOwned;
                      bool _1419_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1420_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out896;
                      bool _out897;
                      bool _out898;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                      _1417_recursiveGen = _out896;
                      _1418_recOwned = _out897;
                      _1419_recErased = _out898;
                      _1420_recIdents = _out899;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1417_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1418_recOwned;
                      isErased = _1419_recErased;
                      readIdents = _1420_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1421_recursiveGen;
                      bool _1422_recOwned;
                      bool _1423_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1424_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out900;
                      bool _out901;
                      bool _out902;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                      _1421_recursiveGen = _out900;
                      _1422_recOwned = _out901;
                      _1423_recErased = _out902;
                      _1424_recIdents = _out903;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1421_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1422_recOwned;
                      isErased = _1423_recErased;
                      readIdents = _1424_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1425_recursiveGen;
                      bool _1426_recOwned;
                      bool _1427_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1428_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out904;
                      bool _out905;
                      bool _out906;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                      _1425_recursiveGen = _out904;
                      _1426_recOwned = _out905;
                      _1427_recErased = _out906;
                      _1428_recIdents = _out907;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1425_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1426_recOwned;
                      isErased = _1427_recErased;
                      readIdents = _1428_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1429___mcc_h620 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1430_recursiveGen;
                    bool _1431_recOwned;
                    bool _1432_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1433_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out908;
                    bool _out909;
                    bool _out910;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                    _1430_recursiveGen = _out908;
                    _1431_recOwned = _out909;
                    _1432_recErased = _out910;
                    _1433_recIdents = _out911;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1430_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1431_recOwned;
                    isErased = _1432_recErased;
                    readIdents = _1433_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1434___mcc_h622 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1435_recursiveGen;
                    bool _1436_recOwned;
                    bool _1437_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1438_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out912;
                    bool _out913;
                    bool _out914;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                    _1435_recursiveGen = _out912;
                    _1436_recOwned = _out913;
                    _1437_recErased = _out914;
                    _1438_recIdents = _out915;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1435_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1436_recOwned;
                    isErased = _1437_recErased;
                    readIdents = _1438_recIdents;
                  }
                }
              } else if (_source48.is_String) {
                DAST._IType _source55 = _488___mcc_h123;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1439___mcc_h624 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1440___mcc_h625 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1441___mcc_h626 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1441___mcc_h626;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1442___mcc_h630 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1443_recursiveGen;
                      bool _1444_recOwned;
                      bool _1445_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1446_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out916;
                      bool _out917;
                      bool _out918;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                      _1443_recursiveGen = _out916;
                      _1444_recOwned = _out917;
                      _1445_recErased = _out918;
                      _1446_recIdents = _out919;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1443_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1444_recOwned;
                      isErased = _1445_recErased;
                      readIdents = _1446_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1447___mcc_h632 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1448_recursiveGen;
                      bool _1449_recOwned;
                      bool _1450_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1451_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out920;
                      bool _out921;
                      bool _out922;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out920, out _out921, out _out922, out _out923);
                      _1448_recursiveGen = _out920;
                      _1449_recOwned = _out921;
                      _1450_recErased = _out922;
                      _1451_recIdents = _out923;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1448_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1449_recOwned;
                      isErased = _1450_recErased;
                      readIdents = _1451_recIdents;
                    }
                  } else {
                    DAST._IType _1452___mcc_h634 = _source56.dtor_Newtype_a0;
                    DAST._IType _1453_b = _1452___mcc_h634;
                    {
                      if (object.Equals(_481_fromTpe, _1453_b)) {
                        Dafny.ISequence<Dafny.Rune> _1454_recursiveGen;
                        bool _1455_recOwned;
                        bool _1456_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1457_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out924;
                        bool _out925;
                        bool _out926;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out924, out _out925, out _out926, out _out927);
                        _1454_recursiveGen = _out924;
                        _1455_recOwned = _out925;
                        _1456_recErased = _out926;
                        _1457_recIdents = _out927;
                        Dafny.ISequence<Dafny.Rune> _1458_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out928;
                        _out928 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _1458_rhsType = _out928;
                        Dafny.ISequence<Dafny.Rune> _1459_uneraseFn;
                        _1459_uneraseFn = ((_1455_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1458_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1459_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1454_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1455_recOwned;
                        isErased = false;
                        readIdents = _1457_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out929;
                        bool _out930;
                        bool _out931;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out932;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1453_b), _1453_b, _480_toTpe), @params, mustOwn, out _out929, out _out930, out _out931, out _out932);
                        s = _out929;
                        isOwned = _out930;
                        isErased = _out931;
                        readIdents = _out932;
                      }
                    }
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1460___mcc_h636 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1461_recursiveGen;
                    bool _1462_recOwned;
                    bool _1463_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1464_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out933;
                    bool _out934;
                    bool _out935;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out933, out _out934, out _out935, out _out936);
                    _1461_recursiveGen = _out933;
                    _1462_recOwned = _out934;
                    _1463_recErased = _out935;
                    _1464_recIdents = _out936;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1461_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1462_recOwned;
                    isErased = _1463_recErased;
                    readIdents = _1464_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1465___mcc_h638 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1466_recursiveGen;
                    bool _1467_recOwned;
                    bool _1468_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1469_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    bool _out938;
                    bool _out939;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out940;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out937, out _out938, out _out939, out _out940);
                    _1466_recursiveGen = _out937;
                    _1467_recOwned = _out938;
                    _1468_recErased = _out939;
                    _1469_recIdents = _out940;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1466_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1467_recOwned;
                    isErased = _1468_recErased;
                    readIdents = _1469_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1470___mcc_h640 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1471_recursiveGen;
                    bool _1472_recOwned;
                    bool _1473_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1474_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out941;
                    bool _out942;
                    bool _out943;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out944;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out941, out _out942, out _out943, out _out944);
                    _1471_recursiveGen = _out941;
                    _1472_recOwned = _out942;
                    _1473_recErased = _out943;
                    _1474_recIdents = _out944;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1471_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1472_recOwned;
                    isErased = _1473_recErased;
                    readIdents = _1474_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1475___mcc_h642 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1476_recursiveGen;
                    bool _1477_recOwned;
                    bool _1478_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1479_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out945;
                    bool _out946;
                    bool _out947;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out948;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out945, out _out946, out _out947, out _out948);
                    _1476_recursiveGen = _out945;
                    _1477_recOwned = _out946;
                    _1478_recErased = _out947;
                    _1479_recIdents = _out948;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1476_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1477_recOwned;
                    isErased = _1478_recErased;
                    readIdents = _1479_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1480___mcc_h644 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1481_recursiveGen;
                    bool _1482_recOwned;
                    bool _1483_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1484_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out949;
                    bool _out950;
                    bool _out951;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out952;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out949, out _out950, out _out951, out _out952);
                    _1481_recursiveGen = _out949;
                    _1482_recOwned = _out950;
                    _1483_recErased = _out951;
                    _1484_recIdents = _out952;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1481_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1482_recOwned;
                    isErased = _1483_recErased;
                    readIdents = _1484_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1485___mcc_h646 = _source55.dtor_key;
                  DAST._IType _1486___mcc_h647 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1487_recursiveGen;
                    bool _1488_recOwned;
                    bool _1489_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1490_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out953;
                    bool _out954;
                    bool _out955;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out956;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out953, out _out954, out _out955, out _out956);
                    _1487_recursiveGen = _out953;
                    _1488_recOwned = _out954;
                    _1489_recErased = _out955;
                    _1490_recIdents = _out956;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1487_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1488_recOwned;
                    isErased = _1489_recErased;
                    readIdents = _1490_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1491___mcc_h650 = _source55.dtor_args;
                  DAST._IType _1492___mcc_h651 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1493_recursiveGen;
                    bool _1494_recOwned;
                    bool _1495_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1496_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out957;
                    bool _out958;
                    bool _out959;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out960;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out957, out _out958, out _out959, out _out960);
                    _1493_recursiveGen = _out957;
                    _1494_recOwned = _out958;
                    _1495_recErased = _out959;
                    _1496_recIdents = _out960;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1493_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1494_recOwned;
                    isErased = _1495_recErased;
                    readIdents = _1496_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1497___mcc_h654 = _source55.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1498_recursiveGen;
                    bool _1499_recOwned;
                    bool _1500_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1501_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out961;
                    bool _out962;
                    bool _out963;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out964;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out961, out _out962, out _out963, out _out964);
                    _1498_recursiveGen = _out961;
                    _1499_recOwned = _out962;
                    _1500_recErased = _out963;
                    _1501_recIdents = _out964;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1498_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1499_recOwned;
                    isErased = _1500_recErased;
                    readIdents = _1501_recIdents;
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1502___mcc_h656 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1503_recursiveGen;
                    bool _1504_recOwned;
                    bool _1505_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1506_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out965;
                    bool _out966;
                    bool _out967;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out968;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out965, out _out966, out _out967, out _out968);
                    _1503_recursiveGen = _out965;
                    _1504_recOwned = _out966;
                    _1505_recErased = _out967;
                    _1506_recIdents = _out968;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1504_recOwned;
                    isErased = _1505_recErased;
                    readIdents = _1506_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1507___mcc_h658 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1508_recursiveGen;
                    bool _1509_recOwned;
                    bool _1510_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1511_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out969;
                    bool _out970;
                    bool _out971;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out972;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out969, out _out970, out _out971, out _out972);
                    _1508_recursiveGen = _out969;
                    _1509_recOwned = _out970;
                    _1510_recErased = _out971;
                    _1511_recIdents = _out972;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1508_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1509_recOwned;
                    isErased = _1510_recErased;
                    readIdents = _1511_recIdents;
                  }
                }
              } else if (_source48.is_Bool) {
                DAST._IType _source57 = _488___mcc_h123;
                if (_source57.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1512___mcc_h660 = _source57.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1513___mcc_h661 = _source57.dtor_typeArgs;
                  DAST._IResolvedType _1514___mcc_h662 = _source57.dtor_resolved;
                  DAST._IResolvedType _source58 = _1514___mcc_h662;
                  if (_source58.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1515___mcc_h666 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1516_recursiveGen;
                      bool _1517_recOwned;
                      bool _1518_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1519_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out973;
                      bool _out974;
                      bool _out975;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out976;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out973, out _out974, out _out975, out _out976);
                      _1516_recursiveGen = _out973;
                      _1517_recOwned = _out974;
                      _1518_recErased = _out975;
                      _1519_recIdents = _out976;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1516_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1517_recOwned;
                      isErased = _1518_recErased;
                      readIdents = _1519_recIdents;
                    }
                  } else if (_source58.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1520___mcc_h668 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1521_recursiveGen;
                      bool _1522_recOwned;
                      bool _1523_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1524_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out977;
                      bool _out978;
                      bool _out979;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out980;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out977, out _out978, out _out979, out _out980);
                      _1521_recursiveGen = _out977;
                      _1522_recOwned = _out978;
                      _1523_recErased = _out979;
                      _1524_recIdents = _out980;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1522_recOwned;
                      isErased = _1523_recErased;
                      readIdents = _1524_recIdents;
                    }
                  } else {
                    DAST._IType _1525___mcc_h670 = _source58.dtor_Newtype_a0;
                    DAST._IType _1526_b = _1525___mcc_h670;
                    {
                      if (object.Equals(_481_fromTpe, _1526_b)) {
                        Dafny.ISequence<Dafny.Rune> _1527_recursiveGen;
                        bool _1528_recOwned;
                        bool _1529_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1530_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out981;
                        bool _out982;
                        bool _out983;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out984;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out981, out _out982, out _out983, out _out984);
                        _1527_recursiveGen = _out981;
                        _1528_recOwned = _out982;
                        _1529_recErased = _out983;
                        _1530_recIdents = _out984;
                        Dafny.ISequence<Dafny.Rune> _1531_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out985;
                        _out985 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _1531_rhsType = _out985;
                        Dafny.ISequence<Dafny.Rune> _1532_uneraseFn;
                        _1532_uneraseFn = ((_1528_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1531_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1532_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1527_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1528_recOwned;
                        isErased = false;
                        readIdents = _1530_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out986;
                        bool _out987;
                        bool _out988;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out989;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1526_b), _1526_b, _480_toTpe), @params, mustOwn, out _out986, out _out987, out _out988, out _out989);
                        s = _out986;
                        isOwned = _out987;
                        isErased = _out988;
                        readIdents = _out989;
                      }
                    }
                  }
                } else if (_source57.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1533___mcc_h672 = _source57.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1534_recursiveGen;
                    bool _1535_recOwned;
                    bool _1536_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1537_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out990;
                    bool _out991;
                    bool _out992;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out993;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out990, out _out991, out _out992, out _out993);
                    _1534_recursiveGen = _out990;
                    _1535_recOwned = _out991;
                    _1536_recErased = _out992;
                    _1537_recIdents = _out993;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1535_recOwned;
                    isErased = _1536_recErased;
                    readIdents = _1537_recIdents;
                  }
                } else if (_source57.is_Array) {
                  DAST._IType _1538___mcc_h674 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1539_recursiveGen;
                    bool _1540_recOwned;
                    bool _1541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out994;
                    bool _out995;
                    bool _out996;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out997;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out994, out _out995, out _out996, out _out997);
                    _1539_recursiveGen = _out994;
                    _1540_recOwned = _out995;
                    _1541_recErased = _out996;
                    _1542_recIdents = _out997;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1540_recOwned;
                    isErased = _1541_recErased;
                    readIdents = _1542_recIdents;
                  }
                } else if (_source57.is_Seq) {
                  DAST._IType _1543___mcc_h676 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1544_recursiveGen;
                    bool _1545_recOwned;
                    bool _1546_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1547_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out998;
                    bool _out999;
                    bool _out1000;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1001;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out998, out _out999, out _out1000, out _out1001);
                    _1544_recursiveGen = _out998;
                    _1545_recOwned = _out999;
                    _1546_recErased = _out1000;
                    _1547_recIdents = _out1001;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1545_recOwned;
                    isErased = _1546_recErased;
                    readIdents = _1547_recIdents;
                  }
                } else if (_source57.is_Set) {
                  DAST._IType _1548___mcc_h678 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1549_recursiveGen;
                    bool _1550_recOwned;
                    bool _1551_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1552_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1002;
                    bool _out1003;
                    bool _out1004;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1005;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1002, out _out1003, out _out1004, out _out1005);
                    _1549_recursiveGen = _out1002;
                    _1550_recOwned = _out1003;
                    _1551_recErased = _out1004;
                    _1552_recIdents = _out1005;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1550_recOwned;
                    isErased = _1551_recErased;
                    readIdents = _1552_recIdents;
                  }
                } else if (_source57.is_Multiset) {
                  DAST._IType _1553___mcc_h680 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1554_recursiveGen;
                    bool _1555_recOwned;
                    bool _1556_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1557_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1006;
                    bool _out1007;
                    bool _out1008;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1009;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1006, out _out1007, out _out1008, out _out1009);
                    _1554_recursiveGen = _out1006;
                    _1555_recOwned = _out1007;
                    _1556_recErased = _out1008;
                    _1557_recIdents = _out1009;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1554_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1555_recOwned;
                    isErased = _1556_recErased;
                    readIdents = _1557_recIdents;
                  }
                } else if (_source57.is_Map) {
                  DAST._IType _1558___mcc_h682 = _source57.dtor_key;
                  DAST._IType _1559___mcc_h683 = _source57.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1560_recursiveGen;
                    bool _1561_recOwned;
                    bool _1562_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1563_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1010;
                    bool _out1011;
                    bool _out1012;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1013;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1010, out _out1011, out _out1012, out _out1013);
                    _1560_recursiveGen = _out1010;
                    _1561_recOwned = _out1011;
                    _1562_recErased = _out1012;
                    _1563_recIdents = _out1013;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1560_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1561_recOwned;
                    isErased = _1562_recErased;
                    readIdents = _1563_recIdents;
                  }
                } else if (_source57.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1564___mcc_h686 = _source57.dtor_args;
                  DAST._IType _1565___mcc_h687 = _source57.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1566_recursiveGen;
                    bool _1567_recOwned;
                    bool _1568_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1569_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1014;
                    bool _out1015;
                    bool _out1016;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1017;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1014, out _out1015, out _out1016, out _out1017);
                    _1566_recursiveGen = _out1014;
                    _1567_recOwned = _out1015;
                    _1568_recErased = _out1016;
                    _1569_recIdents = _out1017;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1566_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1567_recOwned;
                    isErased = _1568_recErased;
                    readIdents = _1569_recIdents;
                  }
                } else if (_source57.is_Primitive) {
                  DAST._IPrimitive _1570___mcc_h690 = _source57.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1571_recursiveGen;
                    bool _1572_recOwned;
                    bool _1573_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1574_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1018;
                    bool _out1019;
                    bool _out1020;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1021;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1018, out _out1019, out _out1020, out _out1021);
                    _1571_recursiveGen = _out1018;
                    _1572_recOwned = _out1019;
                    _1573_recErased = _out1020;
                    _1574_recIdents = _out1021;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1571_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1572_recOwned;
                    isErased = _1573_recErased;
                    readIdents = _1574_recIdents;
                  }
                } else if (_source57.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1575___mcc_h692 = _source57.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1576_recursiveGen;
                    bool _1577_recOwned;
                    bool _1578_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1579_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1022;
                    bool _out1023;
                    bool _out1024;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1025;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1022, out _out1023, out _out1024, out _out1025);
                    _1576_recursiveGen = _out1022;
                    _1577_recOwned = _out1023;
                    _1578_recErased = _out1024;
                    _1579_recIdents = _out1025;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1577_recOwned;
                    isErased = _1578_recErased;
                    readIdents = _1579_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1580___mcc_h694 = _source57.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1581_recursiveGen;
                    bool _1582_recOwned;
                    bool _1583_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1584_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1026;
                    bool _out1027;
                    bool _out1028;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1029;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1026, out _out1027, out _out1028, out _out1029);
                    _1581_recursiveGen = _out1026;
                    _1582_recOwned = _out1027;
                    _1583_recErased = _out1028;
                    _1584_recIdents = _out1029;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1582_recOwned;
                    isErased = _1583_recErased;
                    readIdents = _1584_recIdents;
                  }
                }
              } else {
                DAST._IType _source59 = _488___mcc_h123;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1585___mcc_h696 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1586___mcc_h697 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1587___mcc_h698 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1587___mcc_h698;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1588___mcc_h702 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1589_recursiveGen;
                      bool _1590_recOwned;
                      bool _1591_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1592_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1030;
                      bool _out1031;
                      bool _out1032;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1033;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1030, out _out1031, out _out1032, out _out1033);
                      _1589_recursiveGen = _out1030;
                      _1590_recOwned = _out1031;
                      _1591_recErased = _out1032;
                      _1592_recIdents = _out1033;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1589_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1590_recOwned;
                      isErased = _1591_recErased;
                      readIdents = _1592_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1593___mcc_h704 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1594_recursiveGen;
                      bool _1595_recOwned;
                      bool _1596_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1597_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1034;
                      bool _out1035;
                      bool _out1036;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1037;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1034, out _out1035, out _out1036, out _out1037);
                      _1594_recursiveGen = _out1034;
                      _1595_recOwned = _out1035;
                      _1596_recErased = _out1036;
                      _1597_recIdents = _out1037;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1594_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1595_recOwned;
                      isErased = _1596_recErased;
                      readIdents = _1597_recIdents;
                    }
                  } else {
                    DAST._IType _1598___mcc_h706 = _source60.dtor_Newtype_a0;
                    DAST._IType _1599_b = _1598___mcc_h706;
                    {
                      if (object.Equals(_481_fromTpe, _1599_b)) {
                        Dafny.ISequence<Dafny.Rune> _1600_recursiveGen;
                        bool _1601_recOwned;
                        bool _1602_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1603_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1038;
                        bool _out1039;
                        bool _out1040;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1041;
                        DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1038, out _out1039, out _out1040, out _out1041);
                        _1600_recursiveGen = _out1038;
                        _1601_recOwned = _out1039;
                        _1602_recErased = _out1040;
                        _1603_recIdents = _out1041;
                        Dafny.ISequence<Dafny.Rune> _1604_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1042;
                        _out1042 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                        _1604_rhsType = _out1042;
                        Dafny.ISequence<Dafny.Rune> _1605_uneraseFn;
                        _1605_uneraseFn = ((_1601_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1604_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1605_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1600_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1601_recOwned;
                        isErased = false;
                        readIdents = _1603_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1043;
                        bool _out1044;
                        bool _out1045;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1046;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1599_b), _1599_b, _480_toTpe), @params, mustOwn, out _out1043, out _out1044, out _out1045, out _out1046);
                        s = _out1043;
                        isOwned = _out1044;
                        isErased = _out1045;
                        readIdents = _out1046;
                      }
                    }
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1606___mcc_h708 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1607_recursiveGen;
                    bool _1608_recOwned;
                    bool _1609_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1610_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1047;
                    bool _out1048;
                    bool _out1049;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1050;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1047, out _out1048, out _out1049, out _out1050);
                    _1607_recursiveGen = _out1047;
                    _1608_recOwned = _out1048;
                    _1609_recErased = _out1049;
                    _1610_recIdents = _out1050;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1607_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1608_recOwned;
                    isErased = _1609_recErased;
                    readIdents = _1610_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1611___mcc_h710 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1612_recursiveGen;
                    bool _1613_recOwned;
                    bool _1614_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1615_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1051;
                    bool _out1052;
                    bool _out1053;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1054;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1051, out _out1052, out _out1053, out _out1054);
                    _1612_recursiveGen = _out1051;
                    _1613_recOwned = _out1052;
                    _1614_recErased = _out1053;
                    _1615_recIdents = _out1054;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1612_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1613_recOwned;
                    isErased = _1614_recErased;
                    readIdents = _1615_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1616___mcc_h712 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1617_recursiveGen;
                    bool _1618_recOwned;
                    bool _1619_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1620_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1055;
                    bool _out1056;
                    bool _out1057;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1058;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1055, out _out1056, out _out1057, out _out1058);
                    _1617_recursiveGen = _out1055;
                    _1618_recOwned = _out1056;
                    _1619_recErased = _out1057;
                    _1620_recIdents = _out1058;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1617_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1618_recOwned;
                    isErased = _1619_recErased;
                    readIdents = _1620_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1621___mcc_h714 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1622_recursiveGen;
                    bool _1623_recOwned;
                    bool _1624_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1625_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1059;
                    bool _out1060;
                    bool _out1061;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1062;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1059, out _out1060, out _out1061, out _out1062);
                    _1622_recursiveGen = _out1059;
                    _1623_recOwned = _out1060;
                    _1624_recErased = _out1061;
                    _1625_recIdents = _out1062;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1622_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1623_recOwned;
                    isErased = _1624_recErased;
                    readIdents = _1625_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1626___mcc_h716 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1627_recursiveGen;
                    bool _1628_recOwned;
                    bool _1629_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1630_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1063;
                    bool _out1064;
                    bool _out1065;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1066;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1063, out _out1064, out _out1065, out _out1066);
                    _1627_recursiveGen = _out1063;
                    _1628_recOwned = _out1064;
                    _1629_recErased = _out1065;
                    _1630_recIdents = _out1066;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1627_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1628_recOwned;
                    isErased = _1629_recErased;
                    readIdents = _1630_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1631___mcc_h718 = _source59.dtor_key;
                  DAST._IType _1632___mcc_h719 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1633_recursiveGen;
                    bool _1634_recOwned;
                    bool _1635_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1636_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1067;
                    bool _out1068;
                    bool _out1069;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1070;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1067, out _out1068, out _out1069, out _out1070);
                    _1633_recursiveGen = _out1067;
                    _1634_recOwned = _out1068;
                    _1635_recErased = _out1069;
                    _1636_recIdents = _out1070;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1634_recOwned;
                    isErased = _1635_recErased;
                    readIdents = _1636_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1637___mcc_h722 = _source59.dtor_args;
                  DAST._IType _1638___mcc_h723 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1639_recursiveGen;
                    bool _1640_recOwned;
                    bool _1641_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1642_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1071;
                    bool _out1072;
                    bool _out1073;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1074;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1071, out _out1072, out _out1073, out _out1074);
                    _1639_recursiveGen = _out1071;
                    _1640_recOwned = _out1072;
                    _1641_recErased = _out1073;
                    _1642_recIdents = _out1074;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1639_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1640_recOwned;
                    isErased = _1641_recErased;
                    readIdents = _1642_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1643___mcc_h726 = _source59.dtor_Primitive_a0;
                  DAST._IPrimitive _source61 = _1643___mcc_h726;
                  if (_source61.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1644_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1075;
                      _out1075 = DCOMP.COMP.GenType(_481_fromTpe, true, false);
                      _1644_rhsType = _out1075;
                      Dafny.ISequence<Dafny.Rune> _1645_recursiveGen;
                      bool _1646___v52;
                      bool _1647___v53;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1648_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1076;
                      bool _out1077;
                      bool _out1078;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                      DCOMP.COMP.GenExpr(_482_expr, @params, true, out _out1076, out _out1077, out _out1078, out _out1079);
                      _1645_recursiveGen = _out1076;
                      _1646___v52 = _out1077;
                      _1647___v53 = _out1078;
                      _1648_recIdents = _out1079;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1645_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1648_recIdents;
                    }
                  } else if (_source61.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1649_recursiveGen;
                      bool _1650_recOwned;
                      bool _1651_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1652_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1080;
                      bool _out1081;
                      bool _out1082;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                      _1649_recursiveGen = _out1080;
                      _1650_recOwned = _out1081;
                      _1651_recErased = _out1082;
                      _1652_recIdents = _out1083;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1649_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1650_recOwned;
                      isErased = _1651_recErased;
                      readIdents = _1652_recIdents;
                    }
                  } else if (_source61.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1653_recursiveGen;
                      bool _1654_recOwned;
                      bool _1655_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1656_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1653_recursiveGen = _out1084;
                      _1654_recOwned = _out1085;
                      _1655_recErased = _out1086;
                      _1656_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1654_recOwned;
                      isErased = _1655_recErased;
                      readIdents = _1656_recIdents;
                    }
                  } else if (_source61.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1657_recursiveGen;
                      bool _1658_recOwned;
                      bool _1659_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1660_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1088;
                      bool _out1089;
                      bool _out1090;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                      _1657_recursiveGen = _out1088;
                      _1658_recOwned = _out1089;
                      _1659_recErased = _out1090;
                      _1660_recIdents = _out1091;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1657_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1658_recOwned;
                      isErased = _1659_recErased;
                      readIdents = _1660_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1661_recursiveGen;
                      bool _1662_recOwned;
                      bool _1663_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1664_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1092;
                      bool _out1093;
                      bool _out1094;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                      _1661_recursiveGen = _out1092;
                      _1662_recOwned = _out1093;
                      _1663_recErased = _out1094;
                      _1664_recIdents = _out1095;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1661_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1662_recOwned;
                      isErased = _1663_recErased;
                      readIdents = _1664_recIdents;
                    }
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1665___mcc_h728 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1666_recursiveGen;
                    bool _1667_recOwned;
                    bool _1668_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1669_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1096;
                    bool _out1097;
                    bool _out1098;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1099;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1096, out _out1097, out _out1098, out _out1099);
                    _1666_recursiveGen = _out1096;
                    _1667_recOwned = _out1097;
                    _1668_recErased = _out1098;
                    _1669_recIdents = _out1099;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1666_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1667_recOwned;
                    isErased = _1668_recErased;
                    readIdents = _1669_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1670___mcc_h730 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1671_recursiveGen;
                    bool _1672_recOwned;
                    bool _1673_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1674_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1100;
                    bool _out1101;
                    bool _out1102;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1103;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1100, out _out1101, out _out1102, out _out1103);
                    _1671_recursiveGen = _out1100;
                    _1672_recOwned = _out1101;
                    _1673_recErased = _out1102;
                    _1674_recIdents = _out1103;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1671_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1672_recOwned;
                    isErased = _1673_recErased;
                    readIdents = _1674_recIdents;
                  }
                }
              }
            } else if (_source26.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1675___mcc_h732 = _source26.dtor_Passthrough_a0;
              DAST._IType _source62 = _488___mcc_h123;
              if (_source62.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1676___mcc_h735 = _source62.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1677___mcc_h736 = _source62.dtor_typeArgs;
                DAST._IResolvedType _1678___mcc_h737 = _source62.dtor_resolved;
                DAST._IResolvedType _source63 = _1678___mcc_h737;
                if (_source63.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1679___mcc_h741 = _source63.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1680_recursiveGen;
                    bool _1681_recOwned;
                    bool _1682_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1683_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1104;
                    bool _out1105;
                    bool _out1106;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1107;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1104, out _out1105, out _out1106, out _out1107);
                    _1680_recursiveGen = _out1104;
                    _1681_recOwned = _out1105;
                    _1682_recErased = _out1106;
                    _1683_recIdents = _out1107;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1680_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1681_recOwned;
                    isErased = _1682_recErased;
                    readIdents = _1683_recIdents;
                  }
                } else if (_source63.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1684___mcc_h743 = _source63.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1685_recursiveGen;
                    bool _1686_recOwned;
                    bool _1687_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1688_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1108;
                    bool _out1109;
                    bool _out1110;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1111;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1108, out _out1109, out _out1110, out _out1111);
                    _1685_recursiveGen = _out1108;
                    _1686_recOwned = _out1109;
                    _1687_recErased = _out1110;
                    _1688_recIdents = _out1111;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1685_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1686_recOwned;
                    isErased = _1687_recErased;
                    readIdents = _1688_recIdents;
                  }
                } else {
                  DAST._IType _1689___mcc_h745 = _source63.dtor_Newtype_a0;
                  DAST._IType _1690_b = _1689___mcc_h745;
                  {
                    if (object.Equals(_481_fromTpe, _1690_b)) {
                      Dafny.ISequence<Dafny.Rune> _1691_recursiveGen;
                      bool _1692_recOwned;
                      bool _1693_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1694_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1112;
                      bool _out1113;
                      bool _out1114;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1115;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1112, out _out1113, out _out1114, out _out1115);
                      _1691_recursiveGen = _out1112;
                      _1692_recOwned = _out1113;
                      _1693_recErased = _out1114;
                      _1694_recIdents = _out1115;
                      Dafny.ISequence<Dafny.Rune> _1695_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1116;
                      _out1116 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _1695_rhsType = _out1116;
                      Dafny.ISequence<Dafny.Rune> _1696_uneraseFn;
                      _1696_uneraseFn = ((_1692_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1695_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1696_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1691_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1692_recOwned;
                      isErased = false;
                      readIdents = _1694_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1117;
                      bool _out1118;
                      bool _out1119;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1690_b), _1690_b, _480_toTpe), @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                      s = _out1117;
                      isOwned = _out1118;
                      isErased = _out1119;
                      readIdents = _out1120;
                    }
                  }
                }
              } else if (_source62.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1697___mcc_h747 = _source62.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1698_recursiveGen;
                  bool _1699_recOwned;
                  bool _1700_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1701_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1121;
                  bool _out1122;
                  bool _out1123;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                  _1698_recursiveGen = _out1121;
                  _1699_recOwned = _out1122;
                  _1700_recErased = _out1123;
                  _1701_recIdents = _out1124;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1698_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1699_recOwned;
                  isErased = _1700_recErased;
                  readIdents = _1701_recIdents;
                }
              } else if (_source62.is_Array) {
                DAST._IType _1702___mcc_h749 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1703_recursiveGen;
                  bool _1704_recOwned;
                  bool _1705_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1706_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1125;
                  bool _out1126;
                  bool _out1127;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                  _1703_recursiveGen = _out1125;
                  _1704_recOwned = _out1126;
                  _1705_recErased = _out1127;
                  _1706_recIdents = _out1128;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1703_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1704_recOwned;
                  isErased = _1705_recErased;
                  readIdents = _1706_recIdents;
                }
              } else if (_source62.is_Seq) {
                DAST._IType _1707___mcc_h751 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1708_recursiveGen;
                  bool _1709_recOwned;
                  bool _1710_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1711_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1129;
                  bool _out1130;
                  bool _out1131;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                  _1708_recursiveGen = _out1129;
                  _1709_recOwned = _out1130;
                  _1710_recErased = _out1131;
                  _1711_recIdents = _out1132;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1708_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1709_recOwned;
                  isErased = _1710_recErased;
                  readIdents = _1711_recIdents;
                }
              } else if (_source62.is_Set) {
                DAST._IType _1712___mcc_h753 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1713_recursiveGen;
                  bool _1714_recOwned;
                  bool _1715_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1716_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1133;
                  bool _out1134;
                  bool _out1135;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                  _1713_recursiveGen = _out1133;
                  _1714_recOwned = _out1134;
                  _1715_recErased = _out1135;
                  _1716_recIdents = _out1136;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1713_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1714_recOwned;
                  isErased = _1715_recErased;
                  readIdents = _1716_recIdents;
                }
              } else if (_source62.is_Multiset) {
                DAST._IType _1717___mcc_h755 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1718_recursiveGen;
                  bool _1719_recOwned;
                  bool _1720_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1721_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1137;
                  bool _out1138;
                  bool _out1139;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                  _1718_recursiveGen = _out1137;
                  _1719_recOwned = _out1138;
                  _1720_recErased = _out1139;
                  _1721_recIdents = _out1140;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1718_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1719_recOwned;
                  isErased = _1720_recErased;
                  readIdents = _1721_recIdents;
                }
              } else if (_source62.is_Map) {
                DAST._IType _1722___mcc_h757 = _source62.dtor_key;
                DAST._IType _1723___mcc_h758 = _source62.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1724_recursiveGen;
                  bool _1725_recOwned;
                  bool _1726_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1727_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1141;
                  bool _out1142;
                  bool _out1143;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1144;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1141, out _out1142, out _out1143, out _out1144);
                  _1724_recursiveGen = _out1141;
                  _1725_recOwned = _out1142;
                  _1726_recErased = _out1143;
                  _1727_recIdents = _out1144;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1724_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1725_recOwned;
                  isErased = _1726_recErased;
                  readIdents = _1727_recIdents;
                }
              } else if (_source62.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1728___mcc_h761 = _source62.dtor_args;
                DAST._IType _1729___mcc_h762 = _source62.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1730_recursiveGen;
                  bool _1731_recOwned;
                  bool _1732_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1733_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1145;
                  bool _out1146;
                  bool _out1147;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1148;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1145, out _out1146, out _out1147, out _out1148);
                  _1730_recursiveGen = _out1145;
                  _1731_recOwned = _out1146;
                  _1732_recErased = _out1147;
                  _1733_recIdents = _out1148;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1731_recOwned;
                  isErased = _1732_recErased;
                  readIdents = _1733_recIdents;
                }
              } else if (_source62.is_Primitive) {
                DAST._IPrimitive _1734___mcc_h765 = _source62.dtor_Primitive_a0;
                DAST._IPrimitive _source64 = _1734___mcc_h765;
                if (_source64.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1735_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1149;
                    _out1149 = DCOMP.COMP.GenType(_481_fromTpe, true, false);
                    _1735_rhsType = _out1149;
                    Dafny.ISequence<Dafny.Rune> _1736_recursiveGen;
                    bool _1737___v48;
                    bool _1738___v49;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1739_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1150;
                    bool _out1151;
                    bool _out1152;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                    DCOMP.COMP.GenExpr(_482_expr, @params, true, out _out1150, out _out1151, out _out1152, out _out1153);
                    _1736_recursiveGen = _out1150;
                    _1737___v48 = _out1151;
                    _1738___v49 = _out1152;
                    _1739_recIdents = _out1153;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1736_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1739_recIdents;
                  }
                } else if (_source64.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1740_recursiveGen;
                    bool _1741_recOwned;
                    bool _1742_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1743_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1154;
                    bool _out1155;
                    bool _out1156;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                    _1740_recursiveGen = _out1154;
                    _1741_recOwned = _out1155;
                    _1742_recErased = _out1156;
                    _1743_recIdents = _out1157;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1740_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1741_recOwned;
                    isErased = _1742_recErased;
                    readIdents = _1743_recIdents;
                  }
                } else if (_source64.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1744_recursiveGen;
                    bool _1745_recOwned;
                    bool _1746_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1747_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1158;
                    bool _out1159;
                    bool _out1160;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                    _1744_recursiveGen = _out1158;
                    _1745_recOwned = _out1159;
                    _1746_recErased = _out1160;
                    _1747_recIdents = _out1161;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1744_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1745_recOwned;
                    isErased = _1746_recErased;
                    readIdents = _1747_recIdents;
                  }
                } else if (_source64.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1748_recursiveGen;
                    bool _1749_recOwned;
                    bool _1750_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1751_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1162;
                    bool _out1163;
                    bool _out1164;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1162, out _out1163, out _out1164, out _out1165);
                    _1748_recursiveGen = _out1162;
                    _1749_recOwned = _out1163;
                    _1750_recErased = _out1164;
                    _1751_recIdents = _out1165;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1748_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1749_recOwned;
                    isErased = _1750_recErased;
                    readIdents = _1751_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1752_recursiveGen;
                    bool _1753_recOwned;
                    bool _1754_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1755_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1166;
                    bool _out1167;
                    bool _out1168;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1169;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1166, out _out1167, out _out1168, out _out1169);
                    _1752_recursiveGen = _out1166;
                    _1753_recOwned = _out1167;
                    _1754_recErased = _out1168;
                    _1755_recIdents = _out1169;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1752_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1753_recOwned;
                    isErased = _1754_recErased;
                    readIdents = _1755_recIdents;
                  }
                }
              } else if (_source62.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1756___mcc_h767 = _source62.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1757_recursiveGen;
                  bool _1758___v56;
                  bool _1759___v57;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1760_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1170;
                  bool _out1171;
                  bool _out1172;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1173;
                  DCOMP.COMP.GenExpr(_482_expr, @params, true, out _out1170, out _out1171, out _out1172, out _out1173);
                  _1757_recursiveGen = _out1170;
                  _1758___v56 = _out1171;
                  _1759___v57 = _out1172;
                  _1760_recIdents = _out1173;
                  Dafny.ISequence<Dafny.Rune> _1761_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1174;
                  _out1174 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                  _1761_toTpeGen = _out1174;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1757_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1761_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1760_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1762___mcc_h769 = _source62.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1763_recursiveGen;
                  bool _1764_recOwned;
                  bool _1765_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1766_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1175;
                  bool _out1176;
                  bool _out1177;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1178;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1175, out _out1176, out _out1177, out _out1178);
                  _1763_recursiveGen = _out1175;
                  _1764_recOwned = _out1176;
                  _1765_recErased = _out1177;
                  _1766_recIdents = _out1178;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1763_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1764_recOwned;
                  isErased = _1765_recErased;
                  readIdents = _1766_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1767___mcc_h771 = _source26.dtor_TypeArg_a0;
              DAST._IType _source65 = _488___mcc_h123;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1768___mcc_h774 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1769___mcc_h775 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1770___mcc_h776 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1770___mcc_h776;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1771___mcc_h780 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1772_recursiveGen;
                    bool _1773_recOwned;
                    bool _1774_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1775_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1179;
                    bool _out1180;
                    bool _out1181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1182;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1179, out _out1180, out _out1181, out _out1182);
                    _1772_recursiveGen = _out1179;
                    _1773_recOwned = _out1180;
                    _1774_recErased = _out1181;
                    _1775_recIdents = _out1182;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1772_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1773_recOwned;
                    isErased = _1774_recErased;
                    readIdents = _1775_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1776___mcc_h782 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1777_recursiveGen;
                    bool _1778_recOwned;
                    bool _1779_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1780_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1183;
                    bool _out1184;
                    bool _out1185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1186;
                    DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1183, out _out1184, out _out1185, out _out1186);
                    _1777_recursiveGen = _out1183;
                    _1778_recOwned = _out1184;
                    _1779_recErased = _out1185;
                    _1780_recIdents = _out1186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1778_recOwned;
                    isErased = _1779_recErased;
                    readIdents = _1780_recIdents;
                  }
                } else {
                  DAST._IType _1781___mcc_h784 = _source66.dtor_Newtype_a0;
                  DAST._IType _1782_b = _1781___mcc_h784;
                  {
                    if (object.Equals(_481_fromTpe, _1782_b)) {
                      Dafny.ISequence<Dafny.Rune> _1783_recursiveGen;
                      bool _1784_recOwned;
                      bool _1785_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1786_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1187;
                      bool _out1188;
                      bool _out1189;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1190;
                      DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1187, out _out1188, out _out1189, out _out1190);
                      _1783_recursiveGen = _out1187;
                      _1784_recOwned = _out1188;
                      _1785_recErased = _out1189;
                      _1786_recIdents = _out1190;
                      Dafny.ISequence<Dafny.Rune> _1787_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1191;
                      _out1191 = DCOMP.COMP.GenType(_480_toTpe, true, false);
                      _1787_rhsType = _out1191;
                      Dafny.ISequence<Dafny.Rune> _1788_uneraseFn;
                      _1788_uneraseFn = ((_1784_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1787_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1788_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1783_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1784_recOwned;
                      isErased = false;
                      readIdents = _1786_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1192;
                      bool _out1193;
                      bool _out1194;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1195;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_482_expr, _481_fromTpe, _1782_b), _1782_b, _480_toTpe), @params, mustOwn, out _out1192, out _out1193, out _out1194, out _out1195);
                      s = _out1192;
                      isOwned = _out1193;
                      isErased = _out1194;
                      readIdents = _out1195;
                    }
                  }
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1789___mcc_h786 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1790_recursiveGen;
                  bool _1791_recOwned;
                  bool _1792_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1793_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1196;
                  bool _out1197;
                  bool _out1198;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1199;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1196, out _out1197, out _out1198, out _out1199);
                  _1790_recursiveGen = _out1196;
                  _1791_recOwned = _out1197;
                  _1792_recErased = _out1198;
                  _1793_recIdents = _out1199;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1790_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1791_recOwned;
                  isErased = _1792_recErased;
                  readIdents = _1793_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1794___mcc_h788 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1795_recursiveGen;
                  bool _1796_recOwned;
                  bool _1797_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1798_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1200;
                  bool _out1201;
                  bool _out1202;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1203;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1200, out _out1201, out _out1202, out _out1203);
                  _1795_recursiveGen = _out1200;
                  _1796_recOwned = _out1201;
                  _1797_recErased = _out1202;
                  _1798_recIdents = _out1203;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1795_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1796_recOwned;
                  isErased = _1797_recErased;
                  readIdents = _1798_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1799___mcc_h790 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1800_recursiveGen;
                  bool _1801_recOwned;
                  bool _1802_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1803_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1204;
                  bool _out1205;
                  bool _out1206;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1207;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1204, out _out1205, out _out1206, out _out1207);
                  _1800_recursiveGen = _out1204;
                  _1801_recOwned = _out1205;
                  _1802_recErased = _out1206;
                  _1803_recIdents = _out1207;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1800_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1801_recOwned;
                  isErased = _1802_recErased;
                  readIdents = _1803_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1804___mcc_h792 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1805_recursiveGen;
                  bool _1806_recOwned;
                  bool _1807_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1808_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1208;
                  bool _out1209;
                  bool _out1210;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1211;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1208, out _out1209, out _out1210, out _out1211);
                  _1805_recursiveGen = _out1208;
                  _1806_recOwned = _out1209;
                  _1807_recErased = _out1210;
                  _1808_recIdents = _out1211;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1805_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1806_recOwned;
                  isErased = _1807_recErased;
                  readIdents = _1808_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1809___mcc_h794 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1810_recursiveGen;
                  bool _1811_recOwned;
                  bool _1812_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1813_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1212;
                  bool _out1213;
                  bool _out1214;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1215;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1212, out _out1213, out _out1214, out _out1215);
                  _1810_recursiveGen = _out1212;
                  _1811_recOwned = _out1213;
                  _1812_recErased = _out1214;
                  _1813_recIdents = _out1215;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1810_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1811_recOwned;
                  isErased = _1812_recErased;
                  readIdents = _1813_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1814___mcc_h796 = _source65.dtor_key;
                DAST._IType _1815___mcc_h797 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1816_recursiveGen;
                  bool _1817_recOwned;
                  bool _1818_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1819_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1216;
                  bool _out1217;
                  bool _out1218;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1219;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1216, out _out1217, out _out1218, out _out1219);
                  _1816_recursiveGen = _out1216;
                  _1817_recOwned = _out1217;
                  _1818_recErased = _out1218;
                  _1819_recIdents = _out1219;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1816_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1817_recOwned;
                  isErased = _1818_recErased;
                  readIdents = _1819_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1820___mcc_h800 = _source65.dtor_args;
                DAST._IType _1821___mcc_h801 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1822_recursiveGen;
                  bool _1823_recOwned;
                  bool _1824_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1825_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1220;
                  bool _out1221;
                  bool _out1222;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1223;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1220, out _out1221, out _out1222, out _out1223);
                  _1822_recursiveGen = _out1220;
                  _1823_recOwned = _out1221;
                  _1824_recErased = _out1222;
                  _1825_recIdents = _out1223;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1822_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1823_recOwned;
                  isErased = _1824_recErased;
                  readIdents = _1825_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1826___mcc_h804 = _source65.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1827_recursiveGen;
                  bool _1828_recOwned;
                  bool _1829_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1830_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1224;
                  bool _out1225;
                  bool _out1226;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1227;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1224, out _out1225, out _out1226, out _out1227);
                  _1827_recursiveGen = _out1224;
                  _1828_recOwned = _out1225;
                  _1829_recErased = _out1226;
                  _1830_recIdents = _out1227;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1827_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1828_recOwned;
                  isErased = _1829_recErased;
                  readIdents = _1830_recIdents;
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1831___mcc_h806 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1832_recursiveGen;
                  bool _1833_recOwned;
                  bool _1834_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1835_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1228;
                  bool _out1229;
                  bool _out1230;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1228, out _out1229, out _out1230, out _out1231);
                  _1832_recursiveGen = _out1228;
                  _1833_recOwned = _out1229;
                  _1834_recErased = _out1230;
                  _1835_recIdents = _out1231;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1832_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1833_recOwned;
                  isErased = _1834_recErased;
                  readIdents = _1835_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1836___mcc_h808 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1837_recursiveGen;
                  bool _1838_recOwned;
                  bool _1839_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1840_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1232;
                  bool _out1233;
                  bool _out1234;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
                  DCOMP.COMP.GenExpr(_482_expr, @params, mustOwn, out _out1232, out _out1233, out _out1234, out _out1235);
                  _1837_recursiveGen = _out1232;
                  _1838_recOwned = _out1233;
                  _1839_recErased = _out1234;
                  _1840_recIdents = _out1235;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1837_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1838_recOwned;
                  isErased = _1839_recErased;
                  readIdents = _1840_recIdents;
                }
              }
            }
          }
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _1841___mcc_h22 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1842_exprs = _1841___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1843_generatedValues;
          _1843_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1844_i;
          _1844_i = BigInteger.Zero;
          bool _1845_allErased;
          _1845_allErased = true;
          while ((_1844_i) < (new BigInteger((_1842_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1846_recursiveGen;
            bool _1847___v59;
            bool _1848_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1849_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1236;
            bool _out1237;
            bool _out1238;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
            DCOMP.COMP.GenExpr((_1842_exprs).Select(_1844_i), @params, true, out _out1236, out _out1237, out _out1238, out _out1239);
            _1846_recursiveGen = _out1236;
            _1847___v59 = _out1237;
            _1848_isErased = _out1238;
            _1849_recIdents = _out1239;
            _1845_allErased = (_1845_allErased) && (_1848_isErased);
            _1843_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1843_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1846_recursiveGen, _1848_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1849_recIdents);
            _1844_i = (_1844_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1844_i = BigInteger.Zero;
          while ((_1844_i) < (new BigInteger((_1843_generatedValues).Count))) {
            if ((_1844_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1850_gen;
            _1850_gen = ((_1843_generatedValues).Select(_1844_i)).dtor__0;
            if ((((_1843_generatedValues).Select(_1844_i)).dtor__1) && (!(_1845_allErased))) {
              _1850_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1850_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1850_gen);
            _1844_i = (_1844_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _1845_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _1851___mcc_h23 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1852_exprs = _1851___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1853_generatedValues;
          _1853_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1854_i;
          _1854_i = BigInteger.Zero;
          bool _1855_allErased;
          _1855_allErased = true;
          while ((_1854_i) < (new BigInteger((_1852_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1856_recursiveGen;
            bool _1857___v60;
            bool _1858_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1859_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1240;
            bool _out1241;
            bool _out1242;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
            DCOMP.COMP.GenExpr((_1852_exprs).Select(_1854_i), @params, true, out _out1240, out _out1241, out _out1242, out _out1243);
            _1856_recursiveGen = _out1240;
            _1857___v60 = _out1241;
            _1858_isErased = _out1242;
            _1859_recIdents = _out1243;
            _1855_allErased = (_1855_allErased) && (_1858_isErased);
            _1853_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1853_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1856_recursiveGen, _1858_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1859_recIdents);
            _1854_i = (_1854_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1854_i = BigInteger.Zero;
          while ((_1854_i) < (new BigInteger((_1853_generatedValues).Count))) {
            if ((_1854_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1860_gen;
            _1860_gen = ((_1853_generatedValues).Select(_1854_i)).dtor__0;
            if ((((_1853_generatedValues).Select(_1854_i)).dtor__1) && (!(_1855_allErased))) {
              _1860_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1860_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1860_gen);
            _1854_i = (_1854_i) + (BigInteger.One);
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
        DAST._IExpression _1861___mcc_h24 = _source19.dtor_cond;
        DAST._IExpression _1862___mcc_h25 = _source19.dtor_thn;
        DAST._IExpression _1863___mcc_h26 = _source19.dtor_els;
        DAST._IExpression _1864_f = _1863___mcc_h26;
        DAST._IExpression _1865_t = _1862___mcc_h25;
        DAST._IExpression _1866_cond = _1861___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _1867_condString;
          bool _1868___v61;
          bool _1869_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1870_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1244;
          bool _out1245;
          bool _out1246;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
          DCOMP.COMP.GenExpr(_1866_cond, @params, true, out _out1244, out _out1245, out _out1246, out _out1247);
          _1867_condString = _out1244;
          _1868___v61 = _out1245;
          _1869_condErased = _out1246;
          _1870_recIdentsCond = _out1247;
          if (!(_1869_condErased)) {
            _1867_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1867_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1871___v62;
          bool _1872_tHasToBeOwned;
          bool _1873___v63;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1874___v64;
          Dafny.ISequence<Dafny.Rune> _out1248;
          bool _out1249;
          bool _out1250;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
          DCOMP.COMP.GenExpr(_1865_t, @params, mustOwn, out _out1248, out _out1249, out _out1250, out _out1251);
          _1871___v62 = _out1248;
          _1872_tHasToBeOwned = _out1249;
          _1873___v63 = _out1250;
          _1874___v64 = _out1251;
          Dafny.ISequence<Dafny.Rune> _1875_fString;
          bool _1876_fOwned;
          bool _1877_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1878_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1252;
          bool _out1253;
          bool _out1254;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
          DCOMP.COMP.GenExpr(_1864_f, @params, _1872_tHasToBeOwned, out _out1252, out _out1253, out _out1254, out _out1255);
          _1875_fString = _out1252;
          _1876_fOwned = _out1253;
          _1877_fErased = _out1254;
          _1878_recIdentsF = _out1255;
          Dafny.ISequence<Dafny.Rune> _1879_tString;
          bool _1880___v65;
          bool _1881_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1882_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1256;
          bool _out1257;
          bool _out1258;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
          DCOMP.COMP.GenExpr(_1865_t, @params, _1876_fOwned, out _out1256, out _out1257, out _out1258, out _out1259);
          _1879_tString = _out1256;
          _1880___v65 = _out1257;
          _1881_tErased = _out1258;
          _1882_recIdentsT = _out1259;
          if ((!(_1877_fErased)) || (!(_1881_tErased))) {
            if (_1877_fErased) {
              _1875_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1875_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_1881_tErased) {
              _1879_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1879_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _1867_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1879_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _1875_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _1876_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1870_recIdentsCond, _1882_recIdentsT), _1878_recIdentsF);
          isErased = (_1877_fErased) || (_1881_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _1883___mcc_h27 = _source19.dtor_unOp;
        DAST._IExpression _1884___mcc_h28 = _source19.dtor_expr;
        DAST._IUnaryOp _source67 = _1883___mcc_h27;
        if (_source67.is_Not) {
          DAST._IExpression _1885_e = _1884___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1886_recursiveGen;
            bool _1887___v66;
            bool _1888_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1889_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1260;
            bool _out1261;
            bool _out1262;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
            DCOMP.COMP.GenExpr(_1885_e, @params, true, out _out1260, out _out1261, out _out1262, out _out1263);
            _1886_recursiveGen = _out1260;
            _1887___v66 = _out1261;
            _1888_recErased = _out1262;
            _1889_recIdents = _out1263;
            if (!(_1888_recErased)) {
              _1886_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _1886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1889_recIdents;
            isErased = true;
          }
        } else if (_source67.is_BitwiseNot) {
          DAST._IExpression _1890_e = _1884___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1891_recursiveGen;
            bool _1892___v67;
            bool _1893_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1894_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1264;
            bool _out1265;
            bool _out1266;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
            DCOMP.COMP.GenExpr(_1890_e, @params, true, out _out1264, out _out1265, out _out1266, out _out1267);
            _1891_recursiveGen = _out1264;
            _1892___v67 = _out1265;
            _1893_recErased = _out1266;
            _1894_recIdents = _out1267;
            if (!(_1893_recErased)) {
              _1891_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _1891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1894_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _1895_e = _1884___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1896_recursiveGen;
            bool _1897_recOwned;
            bool _1898_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1899_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1268;
            bool _out1269;
            bool _out1270;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
            DCOMP.COMP.GenExpr(_1895_e, @params, false, out _out1268, out _out1269, out _out1270, out _out1271);
            _1896_recursiveGen = _out1268;
            _1897_recOwned = _out1269;
            _1898_recErased = _out1270;
            _1899_recIdents = _out1271;
            if (!(_1898_recErased)) {
              Dafny.ISequence<Dafny.Rune> _1900_eraseFn;
              _1900_eraseFn = ((_1897_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _1896_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1900_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1896_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _1896_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _1899_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _1901___mcc_h29 = _source19.dtor_op;
        DAST._IExpression _1902___mcc_h30 = _source19.dtor_left;
        DAST._IExpression _1903___mcc_h31 = _source19.dtor_right;
        DAST._IExpression _1904_r = _1903___mcc_h31;
        DAST._IExpression _1905_l = _1902___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _1906_op = _1901___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _1907_left;
          bool _1908___v68;
          bool _1909_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1910_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1272;
          bool _out1273;
          bool _out1274;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1275;
          DCOMP.COMP.GenExpr(_1905_l, @params, true, out _out1272, out _out1273, out _out1274, out _out1275);
          _1907_left = _out1272;
          _1908___v68 = _out1273;
          _1909_leftErased = _out1274;
          _1910_recIdentsL = _out1275;
          Dafny.ISequence<Dafny.Rune> _1911_right;
          bool _1912___v69;
          bool _1913_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1914_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1276;
          bool _out1277;
          bool _out1278;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1279;
          DCOMP.COMP.GenExpr(_1904_r, @params, true, out _out1276, out _out1277, out _out1278, out _out1279);
          _1911_right = _out1276;
          _1912___v69 = _out1277;
          _1913_rightErased = _out1278;
          _1914_recIdentsR = _out1279;
          if (!(_1909_leftErased)) {
            _1907_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1907_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_1913_rightErased)) {
            _1911_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1911_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1906_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _1907_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1911_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_1906_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _1907_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1911_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1907_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1906_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1911_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1910_recIdentsL, _1914_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _1915___mcc_h32 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1916___mcc_h33 = _source19.dtor_field;
        bool _1917___mcc_h34 = _source19.dtor_isConstant;
        bool _1918___mcc_h35 = _source19.dtor_onDatatype;
        bool _1919_isDatatype = _1918___mcc_h35;
        bool _1920_isConstant = _1917___mcc_h34;
        Dafny.ISequence<Dafny.Rune> _1921_field = _1916___mcc_h33;
        DAST._IExpression _1922_on = _1915___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _1923_onString;
          bool _1924_onOwned;
          bool _1925_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1926_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1280;
          bool _out1281;
          bool _out1282;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1283;
          DCOMP.COMP.GenExpr(_1922_on, @params, false, out _out1280, out _out1281, out _out1282, out _out1283);
          _1923_onString = _out1280;
          _1924_onOwned = _out1281;
          _1925_onErased = _out1282;
          _1926_recIdents = _out1283;
          if (!(_1925_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1927_eraseFn;
            _1927_eraseFn = ((_1924_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1923_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1927_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1923_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1919_isDatatype) || (_1920_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1923_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1921_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_1920_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _1923_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1921_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _1926_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _1928___mcc_h36 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1929___mcc_h37 = _source19.dtor_field;
        bool _1930___mcc_h38 = _source19.dtor_onDatatype;
        bool _1931___mcc_h39 = _source19.dtor_isStatic;
        BigInteger _1932___mcc_h40 = _source19.dtor_arity;
        BigInteger _1933_arity = _1932___mcc_h40;
        bool _1934_isStatic = _1931___mcc_h39;
        bool _1935_isDatatype = _1930___mcc_h38;
        Dafny.ISequence<Dafny.Rune> _1936_field = _1929___mcc_h37;
        DAST._IExpression _1937_on = _1928___mcc_h36;
        {
          Dafny.ISequence<Dafny.Rune> _1938_onString;
          bool _1939_onOwned;
          bool _1940___v70;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1941_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1284;
          bool _out1285;
          bool _out1286;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1287;
          DCOMP.COMP.GenExpr(_1937_on, @params, false, out _out1284, out _out1285, out _out1286, out _out1287);
          _1938_onString = _out1284;
          _1939_onOwned = _out1285;
          _1940___v70 = _out1286;
          _1941_recIdents = _out1287;
          if (_1934_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1938_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _1936_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _1938_onString), ((_1939_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _1942_args;
            _1942_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _1943_i;
            _1943_i = BigInteger.Zero;
            while ((_1943_i) < (_1933_arity)) {
              if ((_1943_i).Sign == 1) {
                _1942_args = Dafny.Sequence<Dafny.Rune>.Concat(_1942_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _1942_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1942_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_1943_i));
              _1943_i = (_1943_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _1942_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _1936_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1942_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _1941_recIdents;
        }
      } else if (_source19.is_Index) {
        DAST._IExpression _1944___mcc_h41 = _source19.dtor_expr;
        DAST._IExpression _1945___mcc_h42 = _source19.dtor_idx;
        DAST._IExpression _1946_idx = _1945___mcc_h42;
        DAST._IExpression _1947_on = _1944___mcc_h41;
        {
          Dafny.ISequence<Dafny.Rune> _1948_onString;
          bool _1949_onOwned;
          bool _1950_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1951_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1288;
          bool _out1289;
          bool _out1290;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1291;
          DCOMP.COMP.GenExpr(_1947_on, @params, false, out _out1288, out _out1289, out _out1290, out _out1291);
          _1948_onString = _out1288;
          _1949_onOwned = _out1289;
          _1950_onErased = _out1290;
          _1951_recIdents = _out1291;
          if (!(_1950_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1952_eraseFn;
            _1952_eraseFn = ((_1949_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1948_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1952_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1948_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1953_idxString;
          bool _1954___v71;
          bool _1955_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1956_recIdentsIdx;
          Dafny.ISequence<Dafny.Rune> _out1292;
          bool _out1293;
          bool _out1294;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1295;
          DCOMP.COMP.GenExpr(_1946_idx, @params, true, out _out1292, out _out1293, out _out1294, out _out1295);
          _1953_idxString = _out1292;
          _1954___v71 = _out1293;
          _1955_idxErased = _out1294;
          _1956_recIdentsIdx = _out1295;
          if (!(_1955_idxErased)) {
            _1953_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1953_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1948_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _1953_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1951_recIdents, _1956_recIdentsIdx);
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _1957___mcc_h43 = _source19.dtor_expr;
        BigInteger _1958___mcc_h44 = _source19.dtor_index;
        BigInteger _1959_idx = _1958___mcc_h44;
        DAST._IExpression _1960_on = _1957___mcc_h43;
        {
          Dafny.ISequence<Dafny.Rune> _1961_onString;
          bool _1962___v72;
          bool _1963_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1964_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1296;
          bool _out1297;
          bool _out1298;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1299;
          DCOMP.COMP.GenExpr(_1960_on, @params, false, out _out1296, out _out1297, out _out1298, out _out1299);
          _1961_onString = _out1296;
          _1962___v72 = _out1297;
          _1963_tupErased = _out1298;
          _1964_recIdents = _out1299;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1961_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_1959_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _1963_tupErased;
          readIdents = _1964_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _1965___mcc_h45 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _1966___mcc_h46 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _1967___mcc_h47 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _1968___mcc_h48 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1969_args = _1968___mcc_h48;
        Dafny.ISequence<DAST._IType> _1970_typeArgs = _1967___mcc_h47;
        Dafny.ISequence<Dafny.Rune> _1971_name = _1966___mcc_h46;
        DAST._IExpression _1972_on = _1965___mcc_h45;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1973_typeArgString;
          _1973_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_1970_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _1974_typeI;
            _1974_typeI = BigInteger.Zero;
            _1973_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_1974_typeI) < (new BigInteger((_1970_typeArgs).Count))) {
              if ((_1974_typeI).Sign == 1) {
                _1973_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1973_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _1975_typeString;
              Dafny.ISequence<Dafny.Rune> _out1300;
              _out1300 = DCOMP.COMP.GenType((_1970_typeArgs).Select(_1974_typeI), false, false);
              _1975_typeString = _out1300;
              _1973_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1973_typeArgString, _1975_typeString);
              _1974_typeI = (_1974_typeI) + (BigInteger.One);
            }
            _1973_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1973_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _1976_argString;
          _1976_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1977_i;
          _1977_i = BigInteger.Zero;
          while ((_1977_i) < (new BigInteger((_1969_args).Count))) {
            if ((_1977_i).Sign == 1) {
              _1976_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1976_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1978_argExpr;
            bool _1979_isOwned;
            bool _1980_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1981_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1301;
            bool _out1302;
            bool _out1303;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1304;
            DCOMP.COMP.GenExpr((_1969_args).Select(_1977_i), @params, false, out _out1301, out _out1302, out _out1303, out _out1304);
            _1978_argExpr = _out1301;
            _1979_isOwned = _out1302;
            _1980_argErased = _out1303;
            _1981_argIdents = _out1304;
            if (_1979_isOwned) {
              _1978_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1978_argExpr);
            }
            _1976_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1976_argString, _1978_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1981_argIdents);
            _1977_i = (_1977_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1982_enclosingString;
          bool _1983___v73;
          bool _1984___v74;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1985_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1305;
          bool _out1306;
          bool _out1307;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1308;
          DCOMP.COMP.GenExpr(_1972_on, @params, false, out _out1305, out _out1306, out _out1307, out _out1308);
          _1982_enclosingString = _out1305;
          _1983___v73 = _out1306;
          _1984___v74 = _out1307;
          _1985_recIdents = _out1308;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1985_recIdents);
          DAST._IExpression _source68 = _1972_on;
          if (_source68.is_Literal) {
            DAST._ILiteral _1986___mcc_h810 = _source68.dtor_Literal_a0;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _1987___mcc_h812 = _source68.dtor_Ident_a0;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1988___mcc_h814 = _source68.dtor_Companion_a0;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_1982_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source68.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _1989___mcc_h816 = _source68.dtor_Tuple_a0;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1990___mcc_h818 = _source68.dtor_path;
            Dafny.ISequence<DAST._IExpression> _1991___mcc_h819 = _source68.dtor_args;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _1992___mcc_h822 = _source68.dtor_dims;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1993___mcc_h824 = _source68.dtor_path;
            Dafny.ISequence<Dafny.Rune> _1994___mcc_h825 = _source68.dtor_variant;
            bool _1995___mcc_h826 = _source68.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _1996___mcc_h827 = _source68.dtor_contents;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Convert) {
            DAST._IExpression _1997___mcc_h832 = _source68.dtor_value;
            DAST._IType _1998___mcc_h833 = _source68.dtor_from;
            DAST._IType _1999___mcc_h834 = _source68.dtor_typ;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _2000___mcc_h838 = _source68.dtor_elements;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _2001___mcc_h840 = _source68.dtor_elements;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_This) {
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Ite) {
            DAST._IExpression _2002___mcc_h842 = _source68.dtor_cond;
            DAST._IExpression _2003___mcc_h843 = _source68.dtor_thn;
            DAST._IExpression _2004___mcc_h844 = _source68.dtor_els;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_UnOp) {
            DAST._IUnaryOp _2005___mcc_h848 = _source68.dtor_unOp;
            DAST._IExpression _2006___mcc_h849 = _source68.dtor_expr;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _2007___mcc_h852 = _source68.dtor_op;
            DAST._IExpression _2008___mcc_h853 = _source68.dtor_left;
            DAST._IExpression _2009___mcc_h854 = _source68.dtor_right;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Select) {
            DAST._IExpression _2010___mcc_h858 = _source68.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2011___mcc_h859 = _source68.dtor_field;
            bool _2012___mcc_h860 = _source68.dtor_isConstant;
            bool _2013___mcc_h861 = _source68.dtor_onDatatype;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SelectFn) {
            DAST._IExpression _2014___mcc_h866 = _source68.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2015___mcc_h867 = _source68.dtor_field;
            bool _2016___mcc_h868 = _source68.dtor_onDatatype;
            bool _2017___mcc_h869 = _source68.dtor_isStatic;
            BigInteger _2018___mcc_h870 = _source68.dtor_arity;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Index) {
            DAST._IExpression _2019___mcc_h876 = _source68.dtor_expr;
            DAST._IExpression _2020___mcc_h877 = _source68.dtor_idx;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_TupleSelect) {
            DAST._IExpression _2021___mcc_h880 = _source68.dtor_expr;
            BigInteger _2022___mcc_h881 = _source68.dtor_index;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Call) {
            DAST._IExpression _2023___mcc_h884 = _source68.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2024___mcc_h885 = _source68.dtor_name;
            Dafny.ISequence<DAST._IType> _2025___mcc_h886 = _source68.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2026___mcc_h887 = _source68.dtor_args;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2027___mcc_h892 = _source68.dtor_params;
            DAST._IType _2028___mcc_h893 = _source68.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2029___mcc_h894 = _source68.dtor_body;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2030___mcc_h898 = _source68.dtor_name;
            DAST._IType _2031___mcc_h899 = _source68.dtor_typ;
            DAST._IExpression _2032___mcc_h900 = _source68.dtor_value;
            DAST._IExpression _2033___mcc_h901 = _source68.dtor_iifeBody;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Apply) {
            DAST._IExpression _2034___mcc_h906 = _source68.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2035___mcc_h907 = _source68.dtor_args;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_TypeTest) {
            DAST._IExpression _2036___mcc_h910 = _source68.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2037___mcc_h911 = _source68.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2038___mcc_h912 = _source68.dtor_variant;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2039___mcc_h916 = _source68.dtor_typ;
            {
              _1982_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1982_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1982_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_1971_name)), _1973_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1976_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2040___mcc_h49 = _source19.dtor_params;
        DAST._IType _2041___mcc_h50 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2042___mcc_h51 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2043_body = _2042___mcc_h51;
        DAST._IType _2044_retType = _2041___mcc_h50;
        Dafny.ISequence<DAST._IFormal> _2045_params = _2040___mcc_h49;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2046_paramNames;
          _2046_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2047_i;
          _2047_i = BigInteger.Zero;
          while ((_2047_i) < (new BigInteger((_2045_params).Count))) {
            _2046_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2046_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2045_params).Select(_2047_i)).dtor_name));
            _2047_i = (_2047_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2048_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2049_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1309;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1310;
          DCOMP.COMP.GenStmts(_2043_body, _2046_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1309, out _out1310);
          _2048_recursiveGen = _out1309;
          _2049_recIdents = _out1310;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2050_allReadCloned;
          _2050_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2049_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2051_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2049_recIdents).Elements) {
              _2051_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2049_recIdents).Contains(_2051_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1559)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2046_paramNames).Contains(_2051_next))) {
              _2050_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2050_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2051_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2051_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2051_next));
            }
            _2049_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2049_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2051_next));
          }
          Dafny.ISequence<Dafny.Rune> _2052_paramsString;
          _2052_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2047_i = BigInteger.Zero;
          while ((_2047_i) < (new BigInteger((_2045_params).Count))) {
            if ((_2047_i).Sign == 1) {
              _2052_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2052_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2053_typStr;
            Dafny.ISequence<Dafny.Rune> _out1311;
            _out1311 = DCOMP.COMP.GenType(((_2045_params).Select(_2047_i)).dtor_typ, false, true);
            _2053_typStr = _out1311;
            _2052_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2052_paramsString, ((_2045_params).Select(_2047_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2053_typStr);
            _2047_i = (_2047_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2054_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1312;
          _out1312 = DCOMP.COMP.GenType(_2044_retType, false, true);
          _2054_retTypeGen = _out1312;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2050_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2052_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2054_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2048_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2055___mcc_h52 = _source19.dtor_name;
        DAST._IType _2056___mcc_h53 = _source19.dtor_typ;
        DAST._IExpression _2057___mcc_h54 = _source19.dtor_value;
        DAST._IExpression _2058___mcc_h55 = _source19.dtor_iifeBody;
        DAST._IExpression _2059_iifeBody = _2058___mcc_h55;
        DAST._IExpression _2060_value = _2057___mcc_h54;
        DAST._IType _2061_tpe = _2056___mcc_h53;
        Dafny.ISequence<Dafny.Rune> _2062_name = _2055___mcc_h52;
        {
          Dafny.ISequence<Dafny.Rune> _2063_valueGen;
          bool _2064_valueOwned;
          bool _2065_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2066_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1313;
          bool _out1314;
          bool _out1315;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1316;
          DCOMP.COMP.GenExpr(_2060_value, @params, false, out _out1313, out _out1314, out _out1315, out _out1316);
          _2063_valueGen = _out1313;
          _2064_valueOwned = _out1314;
          _2065_valueErased = _out1315;
          _2066_recIdents = _out1316;
          if (_2065_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2067_eraseFn;
            _2067_eraseFn = ((_2064_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2063_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2067_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2063_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2066_recIdents;
          Dafny.ISequence<Dafny.Rune> _2068_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1317;
          _out1317 = DCOMP.COMP.GenType(_2061_tpe, false, true);
          _2068_valueTypeGen = _out1317;
          Dafny.ISequence<Dafny.Rune> _2069_bodyGen;
          bool _2070_bodyOwned;
          bool _2071_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2072_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1318;
          bool _out1319;
          bool _out1320;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1321;
          DCOMP.COMP.GenExpr(_2059_iifeBody, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2064_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2062_name))))), mustOwn, out _out1318, out _out1319, out _out1320, out _out1321);
          _2069_bodyGen = _out1318;
          _2070_bodyOwned = _out1319;
          _2071_bodyErased = _out1320;
          _2072_bodyIdents = _out1321;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2072_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2073_eraseFn;
          _2073_eraseFn = ((_2064_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2062_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2064_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2068_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2063_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2069_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2070_bodyOwned;
          isErased = _2071_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _2074___mcc_h56 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2075___mcc_h57 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2076_args = _2075___mcc_h57;
        DAST._IExpression _2077_func = _2074___mcc_h56;
        {
          Dafny.ISequence<Dafny.Rune> _2078_funcString;
          bool _2079___v77;
          bool _2080_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2081_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1322;
          bool _out1323;
          bool _out1324;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1325;
          DCOMP.COMP.GenExpr(_2077_func, @params, false, out _out1322, out _out1323, out _out1324, out _out1325);
          _2078_funcString = _out1322;
          _2079___v77 = _out1323;
          _2080_funcErased = _out1324;
          _2081_recIdents = _out1325;
          readIdents = _2081_recIdents;
          Dafny.ISequence<Dafny.Rune> _2082_argString;
          _2082_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2083_i;
          _2083_i = BigInteger.Zero;
          while ((_2083_i) < (new BigInteger((_2076_args).Count))) {
            if ((_2083_i).Sign == 1) {
              _2082_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2082_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2084_argExpr;
            bool _2085_isOwned;
            bool _2086_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2087_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1326;
            bool _out1327;
            bool _out1328;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1329;
            DCOMP.COMP.GenExpr((_2076_args).Select(_2083_i), @params, false, out _out1326, out _out1327, out _out1328, out _out1329);
            _2084_argExpr = _out1326;
            _2085_isOwned = _out1327;
            _2086_argErased = _out1328;
            _2087_argIdents = _out1329;
            if (_2085_isOwned) {
              _2084_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2084_argExpr);
            }
            _2082_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2082_argString, _2084_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2087_argIdents);
            _2083_i = (_2083_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2078_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2082_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _2088___mcc_h58 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2089___mcc_h59 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2090___mcc_h60 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2091_variant = _2090___mcc_h60;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2092_dType = _2089___mcc_h59;
        DAST._IExpression _2093_on = _2088___mcc_h58;
        {
          Dafny.ISequence<Dafny.Rune> _2094_exprGen;
          bool _2095___v78;
          bool _2096_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2097_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1330;
          bool _out1331;
          bool _out1332;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1333;
          DCOMP.COMP.GenExpr(_2093_on, @params, false, out _out1330, out _out1331, out _out1332, out _out1333);
          _2094_exprGen = _out1330;
          _2095___v78 = _out1331;
          _2096_exprErased = _out1332;
          _2097_recIdents = _out1333;
          Dafny.ISequence<Dafny.Rune> _2098_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1334;
          _out1334 = DCOMP.COMP.GenPath(_2092_dType);
          _2098_dTypePath = _out1334;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2094_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2098_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2091_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2097_recIdents;
        }
      } else {
        DAST._IType _2099___mcc_h61 = _source19.dtor_typ;
        DAST._IType _2100_typ = _2099___mcc_h61;
        {
          Dafny.ISequence<Dafny.Rune> _2101_typString;
          Dafny.ISequence<Dafny.Rune> _out1335;
          _out1335 = DCOMP.COMP.GenType(_2100_typ, false, false);
          _2101_typString = _out1335;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2101_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2102_i;
      _2102_i = BigInteger.Zero;
      while ((_2102_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2103_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1336;
        _out1336 = DCOMP.COMP.GenModule((p).Select(_2102_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2103_generated = _out1336;
        if ((_2102_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2103_generated);
        _2102_i = (_2102_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2104_i;
      _2104_i = BigInteger.Zero;
      while ((_2104_i) < (new BigInteger((fullName).Count))) {
        if ((_2104_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2104_i));
        _2104_i = (_2104_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

