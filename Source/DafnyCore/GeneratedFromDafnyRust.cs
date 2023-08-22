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
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::vec::Vec<"), _141_elemStr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
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
    public static void GenAssignLhs(DAST._IAssignLhs lhs, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, out Dafny.ISequence<Dafny.Rune> generated, out bool needsIIFE, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
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
      } else {
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
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("*("), _214_onExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".")), _212_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow_mut())"));
          readIdents = _217_recIdents;
          needsIIFE = true;
        }
      }
    }
    public static void GenStmt(DAST._IStatement stmt, Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> @params, bool isLast, Dafny.ISequence<Dafny.Rune> earlyReturn, out Dafny.ISequence<Dafny.Rune> generated, out Dafny.ISet<Dafny.ISequence<Dafny.Rune>> readIdents) {
      generated = Dafny.Sequence<Dafny.Rune>.Empty;
      readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Empty;
      DAST._IStatement _source15 = stmt;
      if (_source15.is_DeclareVar) {
        Dafny.ISequence<Dafny.Rune> _219___mcc_h0 = _source15.dtor_name;
        DAST._IType _220___mcc_h1 = _source15.dtor_typ;
        DAST._IOptional<DAST._IExpression> _221___mcc_h2 = _source15.dtor_maybeValue;
        DAST._IOptional<DAST._IExpression> _source16 = _221___mcc_h2;
        if (_source16.is_Some) {
          DAST._IExpression _222___mcc_h3 = _source16.dtor_Some_a0;
          DAST._IExpression _223_expression = _222___mcc_h3;
          DAST._IType _224_typ = _220___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _225_name = _219___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _226_expr;
            bool _227___v13;
            bool _228_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _229_recIdents;
            Dafny.ISequence<Dafny.Rune> _out67;
            bool _out68;
            bool _out69;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out70;
            DCOMP.COMP.GenExpr(_223_expression, @params, true, out _out67, out _out68, out _out69, out _out70);
            _226_expr = _out67;
            _227___v13 = _out68;
            _228_recErased = _out69;
            _229_recIdents = _out70;
            if (_228_recErased) {
              _226_expr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _226_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            Dafny.ISequence<Dafny.Rune> _230_typeString;
            Dafny.ISequence<Dafny.Rune> _out71;
            _out71 = DCOMP.COMP.GenType(_224_typ, true, false);
            _230_typeString = _out71;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _225_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _230_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _226_expr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = _229_recIdents;
          }
        } else {
          DAST._IType _231_typ = _220___mcc_h1;
          Dafny.ISequence<Dafny.Rune> _232_name = _219___mcc_h0;
          {
            Dafny.ISequence<Dafny.Rune> _233_typeString;
            Dafny.ISequence<Dafny.Rune> _out72;
            _out72 = DCOMP.COMP.GenType(_231_typ, true, false);
            _233_typeString = _out72;
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let mut r#"), _232_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), _233_typeString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        }
      } else if (_source15.is_Assign) {
        DAST._IAssignLhs _234___mcc_h4 = _source15.dtor_lhs;
        DAST._IExpression _235___mcc_h5 = _source15.dtor_value;
        DAST._IExpression _236_expression = _235___mcc_h5;
        DAST._IAssignLhs _237_lhs = _234___mcc_h4;
        {
          Dafny.ISequence<Dafny.Rune> _238_lhsGen;
          bool _239_needsIIFE;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _240_recIdents;
          Dafny.ISequence<Dafny.Rune> _out73;
          bool _out74;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out75;
          DCOMP.COMP.GenAssignLhs(_237_lhs, @params, out _out73, out _out74, out _out75);
          _238_lhsGen = _out73;
          _239_needsIIFE = _out74;
          _240_recIdents = _out75;
          Dafny.ISequence<Dafny.Rune> _241_exprGen;
          bool _242___v14;
          bool _243_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _244_exprIdents;
          Dafny.ISequence<Dafny.Rune> _out76;
          bool _out77;
          bool _out78;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out79;
          DCOMP.COMP.GenExpr(_236_expression, @params, true, out _out76, out _out77, out _out78, out _out79);
          _241_exprGen = _out76;
          _242___v14 = _out77;
          _243_exprErased = _out78;
          _244_exprIdents = _out79;
          if (_243_exprErased) {
            _241_exprGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _241_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (_239_needsIIFE) {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ let __rhs = "), _241_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; ")), _238_lhsGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = __rhs; }"));
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_238_lhsGen, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _241_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
          }
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_240_recIdents, _244_exprIdents);
        }
      } else if (_source15.is_If) {
        DAST._IExpression _245___mcc_h6 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _246___mcc_h7 = _source15.dtor_thn;
        Dafny.ISequence<DAST._IStatement> _247___mcc_h8 = _source15.dtor_els;
        Dafny.ISequence<DAST._IStatement> _248_els = _247___mcc_h8;
        Dafny.ISequence<DAST._IStatement> _249_thn = _246___mcc_h7;
        DAST._IExpression _250_cond = _245___mcc_h6;
        {
          Dafny.ISequence<Dafny.Rune> _251_condString;
          bool _252___v15;
          bool _253_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _254_recIdents;
          Dafny.ISequence<Dafny.Rune> _out80;
          bool _out81;
          bool _out82;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out83;
          DCOMP.COMP.GenExpr(_250_cond, @params, true, out _out80, out _out81, out _out82, out _out83);
          _251_condString = _out80;
          _252___v15 = _out81;
          _253_condErased = _out82;
          _254_recIdents = _out83;
          if (!(_253_condErased)) {
            _251_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _251_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _254_recIdents;
          Dafny.ISequence<Dafny.Rune> _255_thnString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _256_thnIdents;
          Dafny.ISequence<Dafny.Rune> _out84;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out85;
          DCOMP.COMP.GenStmts(_249_thn, @params, isLast, earlyReturn, out _out84, out _out85);
          _255_thnString = _out84;
          _256_thnIdents = _out85;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _256_thnIdents);
          Dafny.ISequence<Dafny.Rune> _257_elsString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _258_elsIdents;
          Dafny.ISequence<Dafny.Rune> _out86;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out87;
          DCOMP.COMP.GenStmts(_248_els, @params, isLast, earlyReturn, out _out86, out _out87);
          _257_elsString = _out86;
          _258_elsIdents = _out87;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _258_elsIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("if "), _251_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _255_thnString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _257_elsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_While) {
        DAST._IExpression _259___mcc_h9 = _source15.dtor_cond;
        Dafny.ISequence<DAST._IStatement> _260___mcc_h10 = _source15.dtor_body;
        Dafny.ISequence<DAST._IStatement> _261_body = _260___mcc_h10;
        DAST._IExpression _262_cond = _259___mcc_h9;
        {
          Dafny.ISequence<Dafny.Rune> _263_condString;
          bool _264___v16;
          bool _265_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _266_recIdents;
          Dafny.ISequence<Dafny.Rune> _out88;
          bool _out89;
          bool _out90;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out91;
          DCOMP.COMP.GenExpr(_262_cond, @params, true, out _out88, out _out89, out _out90, out _out91);
          _263_condString = _out88;
          _264___v16 = _out89;
          _265_condErased = _out90;
          _266_recIdents = _out91;
          if (!(_265_condErased)) {
            _263_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase("), _263_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _266_recIdents;
          Dafny.ISequence<Dafny.Rune> _267_bodyString;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _268_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out92;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out93;
          DCOMP.COMP.GenStmts(_261_body, @params, false, earlyReturn, out _out92, out _out93);
          _267_bodyString = _out92;
          _268_bodyIdents = _out93;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _268_bodyIdents);
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("while "), _263_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _267_bodyString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
        }
      } else if (_source15.is_Call) {
        DAST._IExpression _269___mcc_h11 = _source15.dtor_on;
        Dafny.ISequence<Dafny.Rune> _270___mcc_h12 = _source15.dtor_name;
        Dafny.ISequence<DAST._IType> _271___mcc_h13 = _source15.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _272___mcc_h14 = _source15.dtor_args;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _273___mcc_h15 = _source15.dtor_outs;
        DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _274_maybeOutVars = _273___mcc_h15;
        Dafny.ISequence<DAST._IExpression> _275_args = _272___mcc_h14;
        Dafny.ISequence<DAST._IType> _276_typeArgs = _271___mcc_h13;
        Dafny.ISequence<Dafny.Rune> _277_name = _270___mcc_h12;
        DAST._IExpression _278_on = _269___mcc_h11;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _279_typeArgString;
          _279_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_276_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _280_typeI;
            _280_typeI = BigInteger.Zero;
            _279_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_280_typeI) < (new BigInteger((_276_typeArgs).Count))) {
              if ((_280_typeI).Sign == 1) {
                _279_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_279_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _281_typeString;
              Dafny.ISequence<Dafny.Rune> _out94;
              _out94 = DCOMP.COMP.GenType((_276_typeArgs).Select(_280_typeI), false, false);
              _281_typeString = _out94;
              _279_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_279_typeArgString, _281_typeString);
              _280_typeI = (_280_typeI) + (BigInteger.One);
            }
            _279_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_279_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _282_argString;
          _282_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _283_i;
          _283_i = BigInteger.Zero;
          while ((_283_i) < (new BigInteger((_275_args).Count))) {
            if ((_283_i).Sign == 1) {
              _282_argString = Dafny.Sequence<Dafny.Rune>.Concat(_282_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _284_argExpr;
            bool _285_isOwned;
            bool _286_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _287_argIdents;
            Dafny.ISequence<Dafny.Rune> _out95;
            bool _out96;
            bool _out97;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out98;
            DCOMP.COMP.GenExpr((_275_args).Select(_283_i), @params, false, out _out95, out _out96, out _out97, out _out98);
            _284_argExpr = _out95;
            _285_isOwned = _out96;
            _286_argErased = _out97;
            _287_argIdents = _out98;
            if (_285_isOwned) {
              _284_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _284_argExpr);
            }
            _282_argString = Dafny.Sequence<Dafny.Rune>.Concat(_282_argString, _284_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _287_argIdents);
            _283_i = (_283_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _288_enclosingString;
          bool _289___v17;
          bool _290___v18;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _291_enclosingIdents;
          Dafny.ISequence<Dafny.Rune> _out99;
          bool _out100;
          bool _out101;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out102;
          DCOMP.COMP.GenExpr(_278_on, @params, false, out _out99, out _out100, out _out101, out _out102);
          _288_enclosingString = _out99;
          _289___v17 = _out100;
          _290___v18 = _out101;
          _291_enclosingIdents = _out102;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _291_enclosingIdents);
          DAST._IExpression _source17 = _278_on;
          if (_source17.is_Literal) {
            DAST._ILiteral _292___mcc_h18 = _source17.dtor_Literal_a0;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _293___mcc_h20 = _source17.dtor_Ident_a0;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _294___mcc_h22 = _source17.dtor_Companion_a0;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_288_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source17.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _295___mcc_h24 = _source17.dtor_Tuple_a0;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _296___mcc_h26 = _source17.dtor_path;
            Dafny.ISequence<DAST._IExpression> _297___mcc_h27 = _source17.dtor_args;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _298___mcc_h30 = _source17.dtor_dims;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _299___mcc_h32 = _source17.dtor_path;
            Dafny.ISequence<Dafny.Rune> _300___mcc_h33 = _source17.dtor_variant;
            bool _301___mcc_h34 = _source17.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _302___mcc_h35 = _source17.dtor_contents;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Convert) {
            DAST._IExpression _303___mcc_h40 = _source17.dtor_value;
            DAST._IType _304___mcc_h41 = _source17.dtor_from;
            DAST._IType _305___mcc_h42 = _source17.dtor_typ;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _306___mcc_h46 = _source17.dtor_elements;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _307___mcc_h48 = _source17.dtor_elements;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_This) {
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Ite) {
            DAST._IExpression _308___mcc_h50 = _source17.dtor_cond;
            DAST._IExpression _309___mcc_h51 = _source17.dtor_thn;
            DAST._IExpression _310___mcc_h52 = _source17.dtor_els;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_UnOp) {
            DAST._IUnaryOp _311___mcc_h56 = _source17.dtor_unOp;
            DAST._IExpression _312___mcc_h57 = _source17.dtor_expr;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _313___mcc_h60 = _source17.dtor_op;
            DAST._IExpression _314___mcc_h61 = _source17.dtor_left;
            DAST._IExpression _315___mcc_h62 = _source17.dtor_right;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Select) {
            DAST._IExpression _316___mcc_h66 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _317___mcc_h67 = _source17.dtor_field;
            bool _318___mcc_h68 = _source17.dtor_isConstant;
            bool _319___mcc_h69 = _source17.dtor_onDatatype;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_SelectFn) {
            DAST._IExpression _320___mcc_h74 = _source17.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _321___mcc_h75 = _source17.dtor_field;
            bool _322___mcc_h76 = _source17.dtor_onDatatype;
            bool _323___mcc_h77 = _source17.dtor_isStatic;
            BigInteger _324___mcc_h78 = _source17.dtor_arity;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Index) {
            DAST._IExpression _325___mcc_h84 = _source17.dtor_expr;
            DAST._IExpression _326___mcc_h85 = _source17.dtor_idx;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TupleSelect) {
            DAST._IExpression _327___mcc_h88 = _source17.dtor_expr;
            BigInteger _328___mcc_h89 = _source17.dtor_index;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Call) {
            DAST._IExpression _329___mcc_h92 = _source17.dtor_on;
            Dafny.ISequence<Dafny.Rune> _330___mcc_h93 = _source17.dtor_name;
            Dafny.ISequence<DAST._IType> _331___mcc_h94 = _source17.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _332___mcc_h95 = _source17.dtor_args;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _333___mcc_h100 = _source17.dtor_params;
            DAST._IType _334___mcc_h101 = _source17.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _335___mcc_h102 = _source17.dtor_body;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _336___mcc_h106 = _source17.dtor_name;
            DAST._IType _337___mcc_h107 = _source17.dtor_typ;
            DAST._IExpression _338___mcc_h108 = _source17.dtor_value;
            DAST._IExpression _339___mcc_h109 = _source17.dtor_iifeBody;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_Apply) {
            DAST._IExpression _340___mcc_h114 = _source17.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _341___mcc_h115 = _source17.dtor_args;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source17.is_TypeTest) {
            DAST._IExpression _342___mcc_h118 = _source17.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _343___mcc_h119 = _source17.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _344___mcc_h120 = _source17.dtor_variant;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _345___mcc_h124 = _source17.dtor_typ;
            {
              _288_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          Dafny.ISequence<Dafny.Rune> _346_receiver;
          _346_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          DAST._IOptional<Dafny.ISequence<Dafny.ISequence<Dafny.Rune>>> _source18 = _274_maybeOutVars;
          if (_source18.is_Some) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _347___mcc_h126 = _source18.dtor_Some_a0;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _348_outVars = _347___mcc_h126;
            {
              if ((new BigInteger((_348_outVars).Count)) > (BigInteger.One)) {
                _346_receiver = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
              }
              BigInteger _349_outI;
              _349_outI = BigInteger.Zero;
              while ((_349_outI) < (new BigInteger((_348_outVars).Count))) {
                if ((_349_outI).Sign == 1) {
                  _346_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_346_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
                }
                Dafny.ISequence<Dafny.Rune> _350_outVar;
                _350_outVar = (_348_outVars).Select(_349_outI);
                _346_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_346_receiver, (_350_outVar));
                _349_outI = (_349_outI) + (BigInteger.One);
              }
              if ((new BigInteger((_348_outVars).Count)) > (BigInteger.One)) {
                _346_receiver = Dafny.Sequence<Dafny.Rune>.Concat(_346_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
            }
          } else {
          }
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(((!(_346_receiver).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))) ? (Dafny.Sequence<Dafny.Rune>.Concat(_346_receiver, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = "))) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""))), _288_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _277_name), _279_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _282_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(");"));
        }
      } else if (_source15.is_Return) {
        DAST._IExpression _351___mcc_h16 = _source15.dtor_expr;
        DAST._IExpression _352_expr = _351___mcc_h16;
        {
          Dafny.ISequence<Dafny.Rune> _353_exprString;
          bool _354___v21;
          bool _355_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _356_recIdents;
          Dafny.ISequence<Dafny.Rune> _out103;
          bool _out104;
          bool _out105;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out106;
          DCOMP.COMP.GenExpr(_352_expr, @params, true, out _out103, out _out104, out _out105, out _out106);
          _353_exprString = _out103;
          _354___v21 = _out104;
          _355_recErased = _out105;
          _356_recIdents = _out106;
          _353_exprString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _353_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          readIdents = _356_recIdents;
          if (isLast) {
            generated = _353_exprString;
          } else {
            generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("return "), _353_exprString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";"));
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
        DAST._IExpression _357___mcc_h17 = _source15.dtor_Print_a0;
        DAST._IExpression _358_e = _357___mcc_h17;
        {
          Dafny.ISequence<Dafny.Rune> _359_printedExpr;
          bool _360_isOwned;
          bool _361___v22;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _362_recIdents;
          Dafny.ISequence<Dafny.Rune> _out107;
          bool _out108;
          bool _out109;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out110;
          DCOMP.COMP.GenExpr(_358_e, @params, false, out _out107, out _out108, out _out109, out _out110);
          _359_printedExpr = _out107;
          _360_isOwned = _out108;
          _361___v22 = _out109;
          _362_recIdents = _out110;
          generated = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("print!(\"{}\", ::dafny_runtime::DafnyPrintWrapper("), ((_360_isOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")))), _359_printedExpr), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("));"));
          readIdents = _362_recIdents;
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
        DAST._ILiteral _363___mcc_h0 = _source19.dtor_Literal_a0;
        DAST._ILiteral _source20 = _363___mcc_h0;
        if (_source20.is_BoolLiteral) {
          bool _364___mcc_h1 = _source20.dtor_BoolLiteral_a0;
          if ((_364___mcc_h1) == (false)) {
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
          Dafny.ISequence<Dafny.Rune> _365___mcc_h2 = _source20.dtor_IntLiteral_a0;
          DAST._IType _366___mcc_h3 = _source20.dtor_IntLiteral_a1;
          DAST._IType _367_t = _366___mcc_h3;
          Dafny.ISequence<Dafny.Rune> _368_i = _365___mcc_h2;
          {
            DAST._IType _source21 = _367_t;
            if (_source21.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _369___mcc_h62 = _source21.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _370___mcc_h63 = _source21.dtor_typeArgs;
              DAST._IResolvedType _371___mcc_h64 = _source21.dtor_resolved;
              {
                s = _368_i;
              }
            } else if (_source21.is_Tuple) {
              Dafny.ISequence<DAST._IType> _372___mcc_h68 = _source21.dtor_Tuple_a0;
              {
                s = _368_i;
              }
            } else if (_source21.is_Array) {
              DAST._IType _373___mcc_h70 = _source21.dtor_element;
              {
                s = _368_i;
              }
            } else if (_source21.is_Seq) {
              DAST._IType _374___mcc_h72 = _source21.dtor_element;
              {
                s = _368_i;
              }
            } else if (_source21.is_Set) {
              DAST._IType _375___mcc_h74 = _source21.dtor_element;
              {
                s = _368_i;
              }
            } else if (_source21.is_Multiset) {
              DAST._IType _376___mcc_h76 = _source21.dtor_element;
              {
                s = _368_i;
              }
            } else if (_source21.is_Map) {
              DAST._IType _377___mcc_h78 = _source21.dtor_key;
              DAST._IType _378___mcc_h79 = _source21.dtor_value;
              {
                s = _368_i;
              }
            } else if (_source21.is_Arrow) {
              Dafny.ISequence<DAST._IType> _379___mcc_h82 = _source21.dtor_args;
              DAST._IType _380___mcc_h83 = _source21.dtor_result;
              {
                s = _368_i;
              }
            } else if (_source21.is_Primitive) {
              DAST._IPrimitive _381___mcc_h86 = _source21.dtor_Primitive_a0;
              DAST._IPrimitive _source22 = _381___mcc_h86;
              if (_source22.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _368_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
                }
              } else if (_source22.is_Real) {
                {
                  s = _368_i;
                }
              } else if (_source22.is_String) {
                {
                  s = _368_i;
                }
              } else if (_source22.is_Bool) {
                {
                  s = _368_i;
                }
              } else {
                {
                  s = _368_i;
                }
              }
            } else if (_source21.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _382___mcc_h88 = _source21.dtor_Passthrough_a0;
              {
                s = _368_i;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _383___mcc_h90 = _source21.dtor_TypeArg_a0;
              {
                s = _368_i;
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _384___mcc_h4 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _385___mcc_h5 = _source20.dtor_DecLiteral_a1;
          DAST._IType _386___mcc_h6 = _source20.dtor_DecLiteral_a2;
          DAST._IType _387_t = _386___mcc_h6;
          Dafny.ISequence<Dafny.Rune> _388_d = _385___mcc_h5;
          Dafny.ISequence<Dafny.Rune> _389_n = _384___mcc_h4;
          {
            DAST._IType _source23 = _387_t;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _390___mcc_h92 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _391___mcc_h93 = _source23.dtor_typeArgs;
              DAST._IResolvedType _392___mcc_h94 = _source23.dtor_resolved;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _393___mcc_h98 = _source23.dtor_Tuple_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Array) {
              DAST._IType _394___mcc_h100 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Seq) {
              DAST._IType _395___mcc_h102 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Set) {
              DAST._IType _396___mcc_h104 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _397___mcc_h106 = _source23.dtor_element;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Map) {
              DAST._IType _398___mcc_h108 = _source23.dtor_key;
              DAST._IType _399___mcc_h109 = _source23.dtor_value;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _400___mcc_h112 = _source23.dtor_args;
              DAST._IType _401___mcc_h113 = _source23.dtor_result;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _402___mcc_h116 = _source23.dtor_Primitive_a0;
              DAST._IPrimitive _source24 = _402___mcc_h116;
              if (_source24.is_Int) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Real) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _389_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
                }
              } else if (_source24.is_String) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else if (_source24.is_Bool) {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              } else {
                {
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
                }
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _403___mcc_h118 = _source23.dtor_Passthrough_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _404___mcc_h120 = _source23.dtor_TypeArg_a0;
              {
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_389_n, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0 / ")), _388_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".0"));
              }
            }
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _405___mcc_h7 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _406_l = _405___mcc_h7;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _406_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _407___mcc_h8 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _408_c = _407___mcc_h8;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_408_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _409___mcc_h9 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _410_name = _409___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _410_name);
          if (!((@params).Contains(_410_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_410_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _411___mcc_h10 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _412_path = _411___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _out111;
          _out111 = DCOMP.COMP.GenPath(_412_path);
          s = _out111;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _413___mcc_h11 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _414_values = _413___mcc_h11;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _415_i;
          _415_i = BigInteger.Zero;
          bool _416_allErased;
          _416_allErased = true;
          while ((_415_i) < (new BigInteger((_414_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _417___v25;
            bool _418___v26;
            bool _419_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _420___v27;
            Dafny.ISequence<Dafny.Rune> _out112;
            bool _out113;
            bool _out114;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out115;
            DCOMP.COMP.GenExpr((_414_values).Select(_415_i), @params, true, out _out112, out _out113, out _out114, out _out115);
            _417___v25 = _out112;
            _418___v26 = _out113;
            _419_isErased = _out114;
            _420___v27 = _out115;
            _416_allErased = (_416_allErased) && (_419_isErased);
            _415_i = (_415_i) + (BigInteger.One);
          }
          _415_i = BigInteger.Zero;
          while ((_415_i) < (new BigInteger((_414_values).Count))) {
            if ((_415_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _421_recursiveGen;
            bool _422___v28;
            bool _423_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _424_recIdents;
            Dafny.ISequence<Dafny.Rune> _out116;
            bool _out117;
            bool _out118;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out119;
            DCOMP.COMP.GenExpr((_414_values).Select(_415_i), @params, true, out _out116, out _out117, out _out118, out _out119);
            _421_recursiveGen = _out116;
            _422___v28 = _out117;
            _423_isErased = _out118;
            _424_recIdents = _out119;
            if ((_423_isErased) && (!(_416_allErased))) {
              _421_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _421_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _421_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _424_recIdents);
            _415_i = (_415_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _416_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _425___mcc_h12 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _426___mcc_h13 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _427_args = _426___mcc_h13;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _428_path = _425___mcc_h12;
        {
          Dafny.ISequence<Dafny.Rune> _429_path;
          Dafny.ISequence<Dafny.Rune> _out120;
          _out120 = DCOMP.COMP.GenPath(_428_path);
          _429_path = _out120;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _429_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _430_i;
          _430_i = BigInteger.Zero;
          while ((_430_i) < (new BigInteger((_427_args).Count))) {
            if ((_430_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _431_recursiveGen;
            bool _432___v29;
            bool _433_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _434_recIdents;
            Dafny.ISequence<Dafny.Rune> _out121;
            bool _out122;
            bool _out123;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out124;
            DCOMP.COMP.GenExpr((_427_args).Select(_430_i), @params, true, out _out121, out _out122, out _out123, out _out124);
            _431_recursiveGen = _out121;
            _432___v29 = _out122;
            _433_isErased = _out123;
            _434_recIdents = _out124;
            if (_433_isErased) {
              _431_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _431_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _431_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _434_recIdents);
            _430_i = (_430_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _435___mcc_h14 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _436_dims = _435___mcc_h14;
        {
          BigInteger _437_i;
          _437_i = (new BigInteger((_436_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_437_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _438_recursiveGen;
            bool _439___v30;
            bool _440_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _441_recIdents;
            Dafny.ISequence<Dafny.Rune> _out125;
            bool _out126;
            bool _out127;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out128;
            DCOMP.COMP.GenExpr((_436_dims).Select(_437_i), @params, true, out _out125, out _out126, out _out127, out _out128);
            _438_recursiveGen = _out125;
            _439___v30 = _out126;
            _440_isErased = _out127;
            _441_recIdents = _out128;
            if (!(_440_isErased)) {
              _438_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _438_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; <usize as ::dafny_runtime::NumCast>::from(")), _438_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _441_recIdents);
            _437_i = (_437_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _442___mcc_h15 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _443___mcc_h16 = _source19.dtor_variant;
        bool _444___mcc_h17 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _445___mcc_h18 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _446_values = _445___mcc_h18;
        bool _447_isCo = _444___mcc_h17;
        Dafny.ISequence<Dafny.Rune> _448_variant = _443___mcc_h16;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _449_path = _442___mcc_h15;
        {
          Dafny.ISequence<Dafny.Rune> _450_path;
          Dafny.ISequence<Dafny.Rune> _out129;
          _out129 = DCOMP.COMP.GenPath(_449_path);
          _450_path = _out129;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _450_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _448_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _451_i;
          _451_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_451_i) < (new BigInteger((_446_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_446_values).Select(_451_i);
            Dafny.ISequence<Dafny.Rune> _452_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _453_value = _let_tmp_rhs0.dtor__1;
            if ((_451_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_447_isCo) {
              Dafny.ISequence<Dafny.Rune> _454_recursiveGen;
              bool _455___v31;
              bool _456_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _457_recIdents;
              Dafny.ISequence<Dafny.Rune> _out130;
              bool _out131;
              bool _out132;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out133;
              DCOMP.COMP.GenExpr(_453_value, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out130, out _out131, out _out132, out _out133);
              _454_recursiveGen = _out130;
              _455___v31 = _out131;
              _456_isErased = _out132;
              _457_recIdents = _out133;
              if (!(_456_isErased)) {
                _454_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _454_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _454_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _454_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _457_recIdents);
              Dafny.ISequence<Dafny.Rune> _458_allReadCloned;
              _458_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_457_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _459_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_457_recIdents).Elements) {
                  _459_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_457_recIdents).Contains(_459_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1095)");
              after__ASSIGN_SUCH_THAT_0:;
                _458_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_458_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _459_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _459_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _457_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_457_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_459_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _452_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _458_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _454_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _460_recursiveGen;
              bool _461___v32;
              bool _462_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _463_recIdents;
              Dafny.ISequence<Dafny.Rune> _out134;
              bool _out135;
              bool _out136;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out137;
              DCOMP.COMP.GenExpr(_453_value, @params, true, out _out134, out _out135, out _out136, out _out137);
              _460_recursiveGen = _out134;
              _461___v32 = _out135;
              _462_isErased = _out136;
              _463_recIdents = _out137;
              if (!(_462_isErased)) {
                _460_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _460_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _452_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _460_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _463_recIdents);
            }
            _451_i = (_451_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _464___mcc_h19 = _source19.dtor_value;
        DAST._IType _465___mcc_h20 = _source19.dtor_from;
        DAST._IType _466___mcc_h21 = _source19.dtor_typ;
        DAST._IType _467_toTpe = _466___mcc_h21;
        DAST._IType _468_fromTpe = _465___mcc_h20;
        DAST._IExpression _469_expr = _464___mcc_h19;
        {
          if (object.Equals(_468_fromTpe, _467_toTpe)) {
            Dafny.ISequence<Dafny.Rune> _470_recursiveGen;
            bool _471_recOwned;
            bool _472_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _473_recIdents;
            Dafny.ISequence<Dafny.Rune> _out138;
            bool _out139;
            bool _out140;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out141;
            DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out138, out _out139, out _out140, out _out141);
            _470_recursiveGen = _out138;
            _471_recOwned = _out139;
            _472_recErased = _out140;
            _473_recIdents = _out141;
            s = _470_recursiveGen;
            isOwned = _471_recOwned;
            isErased = _472_recErased;
            readIdents = _473_recIdents;
          } else {
            _System._ITuple2<DAST._IType, DAST._IType> _source25 = _System.Tuple2<DAST._IType, DAST._IType>.create(_468_fromTpe, _467_toTpe);
            DAST._IType _474___mcc_h122 = _source25.dtor__0;
            DAST._IType _475___mcc_h123 = _source25.dtor__1;
            DAST._IType _source26 = _474___mcc_h122;
            if (_source26.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _476___mcc_h126 = _source26.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _477___mcc_h127 = _source26.dtor_typeArgs;
              DAST._IResolvedType _478___mcc_h128 = _source26.dtor_resolved;
              DAST._IResolvedType _source27 = _478___mcc_h128;
              if (_source27.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _479___mcc_h135 = _source27.dtor_path;
                DAST._IType _source28 = _475___mcc_h123;
                if (_source28.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _480___mcc_h138 = _source28.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _481___mcc_h139 = _source28.dtor_typeArgs;
                  DAST._IResolvedType _482___mcc_h140 = _source28.dtor_resolved;
                  DAST._IResolvedType _source29 = _482___mcc_h140;
                  if (_source29.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _483___mcc_h144 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _484_recursiveGen;
                      bool _485_recOwned;
                      bool _486_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _487_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out142;
                      bool _out143;
                      bool _out144;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out145;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out142, out _out143, out _out144, out _out145);
                      _484_recursiveGen = _out142;
                      _485_recOwned = _out143;
                      _486_recErased = _out144;
                      _487_recIdents = _out145;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _484_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _485_recOwned;
                      isErased = _486_recErased;
                      readIdents = _487_recIdents;
                    }
                  } else if (_source29.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _488___mcc_h146 = _source29.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _489_recursiveGen;
                      bool _490_recOwned;
                      bool _491_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _492_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out146;
                      bool _out147;
                      bool _out148;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out149;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out146, out _out147, out _out148, out _out149);
                      _489_recursiveGen = _out146;
                      _490_recOwned = _out147;
                      _491_recErased = _out148;
                      _492_recIdents = _out149;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _489_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _490_recOwned;
                      isErased = _491_recErased;
                      readIdents = _492_recIdents;
                    }
                  } else {
                    DAST._IType _493___mcc_h148 = _source29.dtor_Newtype_a0;
                    DAST._IType _494_b = _493___mcc_h148;
                    {
                      if (object.Equals(_468_fromTpe, _494_b)) {
                        Dafny.ISequence<Dafny.Rune> _495_recursiveGen;
                        bool _496_recOwned;
                        bool _497_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _498_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out150;
                        bool _out151;
                        bool _out152;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out153;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out150, out _out151, out _out152, out _out153);
                        _495_recursiveGen = _out150;
                        _496_recOwned = _out151;
                        _497_recErased = _out152;
                        _498_recIdents = _out153;
                        Dafny.ISequence<Dafny.Rune> _499_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out154;
                        _out154 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _499_rhsType = _out154;
                        Dafny.ISequence<Dafny.Rune> _500_uneraseFn;
                        _500_uneraseFn = ((_496_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _499_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _500_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _495_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _496_recOwned;
                        isErased = false;
                        readIdents = _498_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out155;
                        bool _out156;
                        bool _out157;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out158;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _494_b), _494_b, _467_toTpe), @params, mustOwn, out _out155, out _out156, out _out157, out _out158);
                        s = _out155;
                        isOwned = _out156;
                        isErased = _out157;
                        readIdents = _out158;
                      }
                    }
                  }
                } else if (_source28.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _501___mcc_h150 = _source28.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _502_recursiveGen;
                    bool _503_recOwned;
                    bool _504_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _505_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out159;
                    bool _out160;
                    bool _out161;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out162;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out159, out _out160, out _out161, out _out162);
                    _502_recursiveGen = _out159;
                    _503_recOwned = _out160;
                    _504_recErased = _out161;
                    _505_recIdents = _out162;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _503_recOwned;
                    isErased = _504_recErased;
                    readIdents = _505_recIdents;
                  }
                } else if (_source28.is_Array) {
                  DAST._IType _506___mcc_h152 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _507_recursiveGen;
                    bool _508_recOwned;
                    bool _509_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _510_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out163;
                    bool _out164;
                    bool _out165;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out166;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out163, out _out164, out _out165, out _out166);
                    _507_recursiveGen = _out163;
                    _508_recOwned = _out164;
                    _509_recErased = _out165;
                    _510_recIdents = _out166;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _508_recOwned;
                    isErased = _509_recErased;
                    readIdents = _510_recIdents;
                  }
                } else if (_source28.is_Seq) {
                  DAST._IType _511___mcc_h154 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _512_recursiveGen;
                    bool _513_recOwned;
                    bool _514_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _515_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out167;
                    bool _out168;
                    bool _out169;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out170;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out167, out _out168, out _out169, out _out170);
                    _512_recursiveGen = _out167;
                    _513_recOwned = _out168;
                    _514_recErased = _out169;
                    _515_recIdents = _out170;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _512_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _513_recOwned;
                    isErased = _514_recErased;
                    readIdents = _515_recIdents;
                  }
                } else if (_source28.is_Set) {
                  DAST._IType _516___mcc_h156 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _517_recursiveGen;
                    bool _518_recOwned;
                    bool _519_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _520_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out171;
                    bool _out172;
                    bool _out173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out174;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out171, out _out172, out _out173, out _out174);
                    _517_recursiveGen = _out171;
                    _518_recOwned = _out172;
                    _519_recErased = _out173;
                    _520_recIdents = _out174;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _517_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _518_recOwned;
                    isErased = _519_recErased;
                    readIdents = _520_recIdents;
                  }
                } else if (_source28.is_Multiset) {
                  DAST._IType _521___mcc_h158 = _source28.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _522_recursiveGen;
                    bool _523_recOwned;
                    bool _524_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _525_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out175;
                    bool _out176;
                    bool _out177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out178;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out175, out _out176, out _out177, out _out178);
                    _522_recursiveGen = _out175;
                    _523_recOwned = _out176;
                    _524_recErased = _out177;
                    _525_recIdents = _out178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _522_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _523_recOwned;
                    isErased = _524_recErased;
                    readIdents = _525_recIdents;
                  }
                } else if (_source28.is_Map) {
                  DAST._IType _526___mcc_h160 = _source28.dtor_key;
                  DAST._IType _527___mcc_h161 = _source28.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _528_recursiveGen;
                    bool _529_recOwned;
                    bool _530_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _531_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out179;
                    bool _out180;
                    bool _out181;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out182;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out179, out _out180, out _out181, out _out182);
                    _528_recursiveGen = _out179;
                    _529_recOwned = _out180;
                    _530_recErased = _out181;
                    _531_recIdents = _out182;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _528_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _529_recOwned;
                    isErased = _530_recErased;
                    readIdents = _531_recIdents;
                  }
                } else if (_source28.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _532___mcc_h164 = _source28.dtor_args;
                  DAST._IType _533___mcc_h165 = _source28.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _534_recursiveGen;
                    bool _535_recOwned;
                    bool _536_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _537_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out183;
                    bool _out184;
                    bool _out185;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out186;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out183, out _out184, out _out185, out _out186);
                    _534_recursiveGen = _out183;
                    _535_recOwned = _out184;
                    _536_recErased = _out185;
                    _537_recIdents = _out186;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _535_recOwned;
                    isErased = _536_recErased;
                    readIdents = _537_recIdents;
                  }
                } else if (_source28.is_Primitive) {
                  DAST._IPrimitive _538___mcc_h168 = _source28.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _539_recursiveGen;
                    bool _540_recOwned;
                    bool _541_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _542_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out187;
                    bool _out188;
                    bool _out189;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out190;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out187, out _out188, out _out189, out _out190);
                    _539_recursiveGen = _out187;
                    _540_recOwned = _out188;
                    _541_recErased = _out189;
                    _542_recIdents = _out190;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _540_recOwned;
                    isErased = _541_recErased;
                    readIdents = _542_recIdents;
                  }
                } else if (_source28.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _543___mcc_h170 = _source28.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _544_recursiveGen;
                    bool _545_recOwned;
                    bool _546_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _547_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out191;
                    bool _out192;
                    bool _out193;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out194;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out191, out _out192, out _out193, out _out194);
                    _544_recursiveGen = _out191;
                    _545_recOwned = _out192;
                    _546_recErased = _out193;
                    _547_recIdents = _out194;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _544_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _545_recOwned;
                    isErased = _546_recErased;
                    readIdents = _547_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _548___mcc_h172 = _source28.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _549_recursiveGen;
                    bool _550_recOwned;
                    bool _551_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _552_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out195;
                    bool _out196;
                    bool _out197;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out198;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out195, out _out196, out _out197, out _out198);
                    _549_recursiveGen = _out195;
                    _550_recOwned = _out196;
                    _551_recErased = _out197;
                    _552_recIdents = _out198;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _549_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _550_recOwned;
                    isErased = _551_recErased;
                    readIdents = _552_recIdents;
                  }
                }
              } else if (_source27.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _553___mcc_h174 = _source27.dtor_path;
                DAST._IType _source30 = _475___mcc_h123;
                if (_source30.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _554___mcc_h177 = _source30.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _555___mcc_h178 = _source30.dtor_typeArgs;
                  DAST._IResolvedType _556___mcc_h179 = _source30.dtor_resolved;
                  DAST._IResolvedType _source31 = _556___mcc_h179;
                  if (_source31.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _557___mcc_h183 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _558_recursiveGen;
                      bool _559_recOwned;
                      bool _560_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _561_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out199;
                      bool _out200;
                      bool _out201;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out202;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out199, out _out200, out _out201, out _out202);
                      _558_recursiveGen = _out199;
                      _559_recOwned = _out200;
                      _560_recErased = _out201;
                      _561_recIdents = _out202;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _558_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _559_recOwned;
                      isErased = _560_recErased;
                      readIdents = _561_recIdents;
                    }
                  } else if (_source31.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _562___mcc_h185 = _source31.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _563_recursiveGen;
                      bool _564_recOwned;
                      bool _565_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _566_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out203;
                      bool _out204;
                      bool _out205;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out206;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out203, out _out204, out _out205, out _out206);
                      _563_recursiveGen = _out203;
                      _564_recOwned = _out204;
                      _565_recErased = _out205;
                      _566_recIdents = _out206;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _564_recOwned;
                      isErased = _565_recErased;
                      readIdents = _566_recIdents;
                    }
                  } else {
                    DAST._IType _567___mcc_h187 = _source31.dtor_Newtype_a0;
                    DAST._IType _568_b = _567___mcc_h187;
                    {
                      if (object.Equals(_468_fromTpe, _568_b)) {
                        Dafny.ISequence<Dafny.Rune> _569_recursiveGen;
                        bool _570_recOwned;
                        bool _571_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _572_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out207;
                        bool _out208;
                        bool _out209;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out210;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out207, out _out208, out _out209, out _out210);
                        _569_recursiveGen = _out207;
                        _570_recOwned = _out208;
                        _571_recErased = _out209;
                        _572_recIdents = _out210;
                        Dafny.ISequence<Dafny.Rune> _573_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out211;
                        _out211 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _573_rhsType = _out211;
                        Dafny.ISequence<Dafny.Rune> _574_uneraseFn;
                        _574_uneraseFn = ((_570_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _573_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _574_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _569_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _570_recOwned;
                        isErased = false;
                        readIdents = _572_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out212;
                        bool _out213;
                        bool _out214;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out215;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _568_b), _568_b, _467_toTpe), @params, mustOwn, out _out212, out _out213, out _out214, out _out215);
                        s = _out212;
                        isOwned = _out213;
                        isErased = _out214;
                        readIdents = _out215;
                      }
                    }
                  }
                } else if (_source30.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _575___mcc_h189 = _source30.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _576_recursiveGen;
                    bool _577_recOwned;
                    bool _578_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _579_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out216;
                    bool _out217;
                    bool _out218;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out219;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out216, out _out217, out _out218, out _out219);
                    _576_recursiveGen = _out216;
                    _577_recOwned = _out217;
                    _578_recErased = _out218;
                    _579_recIdents = _out219;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _577_recOwned;
                    isErased = _578_recErased;
                    readIdents = _579_recIdents;
                  }
                } else if (_source30.is_Array) {
                  DAST._IType _580___mcc_h191 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _581_recursiveGen;
                    bool _582_recOwned;
                    bool _583_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _584_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out220;
                    bool _out221;
                    bool _out222;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out223;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out220, out _out221, out _out222, out _out223);
                    _581_recursiveGen = _out220;
                    _582_recOwned = _out221;
                    _583_recErased = _out222;
                    _584_recIdents = _out223;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _582_recOwned;
                    isErased = _583_recErased;
                    readIdents = _584_recIdents;
                  }
                } else if (_source30.is_Seq) {
                  DAST._IType _585___mcc_h193 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _586_recursiveGen;
                    bool _587_recOwned;
                    bool _588_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _589_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out224;
                    bool _out225;
                    bool _out226;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out227;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out224, out _out225, out _out226, out _out227);
                    _586_recursiveGen = _out224;
                    _587_recOwned = _out225;
                    _588_recErased = _out226;
                    _589_recIdents = _out227;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _586_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _587_recOwned;
                    isErased = _588_recErased;
                    readIdents = _589_recIdents;
                  }
                } else if (_source30.is_Set) {
                  DAST._IType _590___mcc_h195 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _591_recursiveGen;
                    bool _592_recOwned;
                    bool _593_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _594_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out228;
                    bool _out229;
                    bool _out230;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out231;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out228, out _out229, out _out230, out _out231);
                    _591_recursiveGen = _out228;
                    _592_recOwned = _out229;
                    _593_recErased = _out230;
                    _594_recIdents = _out231;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _592_recOwned;
                    isErased = _593_recErased;
                    readIdents = _594_recIdents;
                  }
                } else if (_source30.is_Multiset) {
                  DAST._IType _595___mcc_h197 = _source30.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _596_recursiveGen;
                    bool _597_recOwned;
                    bool _598_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _599_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out232;
                    bool _out233;
                    bool _out234;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out235;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out232, out _out233, out _out234, out _out235);
                    _596_recursiveGen = _out232;
                    _597_recOwned = _out233;
                    _598_recErased = _out234;
                    _599_recIdents = _out235;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _596_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _597_recOwned;
                    isErased = _598_recErased;
                    readIdents = _599_recIdents;
                  }
                } else if (_source30.is_Map) {
                  DAST._IType _600___mcc_h199 = _source30.dtor_key;
                  DAST._IType _601___mcc_h200 = _source30.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _602_recursiveGen;
                    bool _603_recOwned;
                    bool _604_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _605_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out236;
                    bool _out237;
                    bool _out238;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out239;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out236, out _out237, out _out238, out _out239);
                    _602_recursiveGen = _out236;
                    _603_recOwned = _out237;
                    _604_recErased = _out238;
                    _605_recIdents = _out239;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _602_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _603_recOwned;
                    isErased = _604_recErased;
                    readIdents = _605_recIdents;
                  }
                } else if (_source30.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _606___mcc_h203 = _source30.dtor_args;
                  DAST._IType _607___mcc_h204 = _source30.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _608_recursiveGen;
                    bool _609_recOwned;
                    bool _610_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _611_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out240;
                    bool _out241;
                    bool _out242;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out243;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out240, out _out241, out _out242, out _out243);
                    _608_recursiveGen = _out240;
                    _609_recOwned = _out241;
                    _610_recErased = _out242;
                    _611_recIdents = _out243;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _608_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _609_recOwned;
                    isErased = _610_recErased;
                    readIdents = _611_recIdents;
                  }
                } else if (_source30.is_Primitive) {
                  DAST._IPrimitive _612___mcc_h207 = _source30.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _613_recursiveGen;
                    bool _614_recOwned;
                    bool _615_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _616_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out244;
                    bool _out245;
                    bool _out246;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out247;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out244, out _out245, out _out246, out _out247);
                    _613_recursiveGen = _out244;
                    _614_recOwned = _out245;
                    _615_recErased = _out246;
                    _616_recIdents = _out247;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _613_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _614_recOwned;
                    isErased = _615_recErased;
                    readIdents = _616_recIdents;
                  }
                } else if (_source30.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _617___mcc_h209 = _source30.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _618_recursiveGen;
                    bool _619_recOwned;
                    bool _620_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _621_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out248;
                    bool _out249;
                    bool _out250;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out251;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out248, out _out249, out _out250, out _out251);
                    _618_recursiveGen = _out248;
                    _619_recOwned = _out249;
                    _620_recErased = _out250;
                    _621_recIdents = _out251;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _618_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _619_recOwned;
                    isErased = _620_recErased;
                    readIdents = _621_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _622___mcc_h211 = _source30.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _623_recursiveGen;
                    bool _624_recOwned;
                    bool _625_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _626_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out252;
                    bool _out253;
                    bool _out254;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out255;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out252, out _out253, out _out254, out _out255);
                    _623_recursiveGen = _out252;
                    _624_recOwned = _out253;
                    _625_recErased = _out254;
                    _626_recIdents = _out255;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _624_recOwned;
                    isErased = _625_recErased;
                    readIdents = _626_recIdents;
                  }
                }
              } else {
                DAST._IType _627___mcc_h213 = _source27.dtor_Newtype_a0;
                DAST._IType _source32 = _475___mcc_h123;
                if (_source32.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _628___mcc_h216 = _source32.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _629___mcc_h217 = _source32.dtor_typeArgs;
                  DAST._IResolvedType _630___mcc_h218 = _source32.dtor_resolved;
                  DAST._IResolvedType _source33 = _630___mcc_h218;
                  if (_source33.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _631___mcc_h225 = _source33.dtor_path;
                    DAST._IType _632_b = _627___mcc_h213;
                    {
                      if (object.Equals(_632_b, _467_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _633_recursiveGen;
                        bool _634_recOwned;
                        bool _635_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _636_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out256;
                        bool _out257;
                        bool _out258;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out259;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out256, out _out257, out _out258, out _out259);
                        _633_recursiveGen = _out256;
                        _634_recOwned = _out257;
                        _635_recErased = _out258;
                        _636_recIdents = _out259;
                        Dafny.ISequence<Dafny.Rune> _637_uneraseFn;
                        _637_uneraseFn = ((_634_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _637_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _633_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _634_recOwned;
                        isErased = true;
                        readIdents = _636_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out260;
                        bool _out261;
                        bool _out262;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out263;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _632_b), _632_b, _467_toTpe), @params, mustOwn, out _out260, out _out261, out _out262, out _out263);
                        s = _out260;
                        isOwned = _out261;
                        isErased = _out262;
                        readIdents = _out263;
                      }
                    }
                  } else if (_source33.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _638___mcc_h228 = _source33.dtor_path;
                    DAST._IType _639_b = _627___mcc_h213;
                    {
                      if (object.Equals(_639_b, _467_toTpe)) {
                        Dafny.ISequence<Dafny.Rune> _640_recursiveGen;
                        bool _641_recOwned;
                        bool _642_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _643_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out264;
                        bool _out265;
                        bool _out266;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out267;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out264, out _out265, out _out266, out _out267);
                        _640_recursiveGen = _out264;
                        _641_recOwned = _out265;
                        _642_recErased = _out266;
                        _643_recIdents = _out267;
                        Dafny.ISequence<Dafny.Rune> _644_uneraseFn;
                        _644_uneraseFn = ((_641_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _644_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _641_recOwned;
                        isErased = true;
                        readIdents = _643_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out268;
                        bool _out269;
                        bool _out270;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out271;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _639_b), _639_b, _467_toTpe), @params, mustOwn, out _out268, out _out269, out _out270, out _out271);
                        s = _out268;
                        isOwned = _out269;
                        isErased = _out270;
                        readIdents = _out271;
                      }
                    }
                  } else {
                    DAST._IType _645___mcc_h231 = _source33.dtor_Newtype_a0;
                    DAST._IType _646_b = _645___mcc_h231;
                    {
                      if (object.Equals(_468_fromTpe, _646_b)) {
                        Dafny.ISequence<Dafny.Rune> _647_recursiveGen;
                        bool _648_recOwned;
                        bool _649_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _650_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out272;
                        bool _out273;
                        bool _out274;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out275;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out272, out _out273, out _out274, out _out275);
                        _647_recursiveGen = _out272;
                        _648_recOwned = _out273;
                        _649_recErased = _out274;
                        _650_recIdents = _out275;
                        Dafny.ISequence<Dafny.Rune> _651_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out276;
                        _out276 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _651_rhsType = _out276;
                        Dafny.ISequence<Dafny.Rune> _652_uneraseFn;
                        _652_uneraseFn = ((_648_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _651_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _652_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _647_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _648_recOwned;
                        isErased = false;
                        readIdents = _650_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out277;
                        bool _out278;
                        bool _out279;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out280;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _646_b), _646_b, _467_toTpe), @params, mustOwn, out _out277, out _out278, out _out279, out _out280);
                        s = _out277;
                        isOwned = _out278;
                        isErased = _out279;
                        readIdents = _out280;
                      }
                    }
                  }
                } else if (_source32.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _653___mcc_h234 = _source32.dtor_Tuple_a0;
                  DAST._IType _654_b = _627___mcc_h213;
                  {
                    if (object.Equals(_654_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _655_recursiveGen;
                      bool _656_recOwned;
                      bool _657_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _658_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out281;
                      bool _out282;
                      bool _out283;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out284;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out281, out _out282, out _out283, out _out284);
                      _655_recursiveGen = _out281;
                      _656_recOwned = _out282;
                      _657_recErased = _out283;
                      _658_recIdents = _out284;
                      Dafny.ISequence<Dafny.Rune> _659_uneraseFn;
                      _659_uneraseFn = ((_656_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _659_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _655_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _656_recOwned;
                      isErased = true;
                      readIdents = _658_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out285;
                      bool _out286;
                      bool _out287;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out288;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _654_b), _654_b, _467_toTpe), @params, mustOwn, out _out285, out _out286, out _out287, out _out288);
                      s = _out285;
                      isOwned = _out286;
                      isErased = _out287;
                      readIdents = _out288;
                    }
                  }
                } else if (_source32.is_Array) {
                  DAST._IType _660___mcc_h237 = _source32.dtor_element;
                  DAST._IType _661_b = _627___mcc_h213;
                  {
                    if (object.Equals(_661_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _662_recursiveGen;
                      bool _663_recOwned;
                      bool _664_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _665_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out289;
                      bool _out290;
                      bool _out291;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out292;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out289, out _out290, out _out291, out _out292);
                      _662_recursiveGen = _out289;
                      _663_recOwned = _out290;
                      _664_recErased = _out291;
                      _665_recIdents = _out292;
                      Dafny.ISequence<Dafny.Rune> _666_uneraseFn;
                      _666_uneraseFn = ((_663_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _666_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _662_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _663_recOwned;
                      isErased = true;
                      readIdents = _665_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out293;
                      bool _out294;
                      bool _out295;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out296;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _661_b), _661_b, _467_toTpe), @params, mustOwn, out _out293, out _out294, out _out295, out _out296);
                      s = _out293;
                      isOwned = _out294;
                      isErased = _out295;
                      readIdents = _out296;
                    }
                  }
                } else if (_source32.is_Seq) {
                  DAST._IType _667___mcc_h240 = _source32.dtor_element;
                  DAST._IType _668_b = _627___mcc_h213;
                  {
                    if (object.Equals(_668_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _669_recursiveGen;
                      bool _670_recOwned;
                      bool _671_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _672_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out297;
                      bool _out298;
                      bool _out299;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out300;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out297, out _out298, out _out299, out _out300);
                      _669_recursiveGen = _out297;
                      _670_recOwned = _out298;
                      _671_recErased = _out299;
                      _672_recIdents = _out300;
                      Dafny.ISequence<Dafny.Rune> _673_uneraseFn;
                      _673_uneraseFn = ((_670_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _673_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _670_recOwned;
                      isErased = true;
                      readIdents = _672_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out301;
                      bool _out302;
                      bool _out303;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out304;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _668_b), _668_b, _467_toTpe), @params, mustOwn, out _out301, out _out302, out _out303, out _out304);
                      s = _out301;
                      isOwned = _out302;
                      isErased = _out303;
                      readIdents = _out304;
                    }
                  }
                } else if (_source32.is_Set) {
                  DAST._IType _674___mcc_h243 = _source32.dtor_element;
                  DAST._IType _675_b = _627___mcc_h213;
                  {
                    if (object.Equals(_675_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _676_recursiveGen;
                      bool _677_recOwned;
                      bool _678_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _679_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out305;
                      bool _out306;
                      bool _out307;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out308;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out305, out _out306, out _out307, out _out308);
                      _676_recursiveGen = _out305;
                      _677_recOwned = _out306;
                      _678_recErased = _out307;
                      _679_recIdents = _out308;
                      Dafny.ISequence<Dafny.Rune> _680_uneraseFn;
                      _680_uneraseFn = ((_677_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _680_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _676_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _677_recOwned;
                      isErased = true;
                      readIdents = _679_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out309;
                      bool _out310;
                      bool _out311;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out312;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _675_b), _675_b, _467_toTpe), @params, mustOwn, out _out309, out _out310, out _out311, out _out312);
                      s = _out309;
                      isOwned = _out310;
                      isErased = _out311;
                      readIdents = _out312;
                    }
                  }
                } else if (_source32.is_Multiset) {
                  DAST._IType _681___mcc_h246 = _source32.dtor_element;
                  DAST._IType _682_b = _627___mcc_h213;
                  {
                    if (object.Equals(_682_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _683_recursiveGen;
                      bool _684_recOwned;
                      bool _685_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _686_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out313;
                      bool _out314;
                      bool _out315;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out316;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out313, out _out314, out _out315, out _out316);
                      _683_recursiveGen = _out313;
                      _684_recOwned = _out314;
                      _685_recErased = _out315;
                      _686_recIdents = _out316;
                      Dafny.ISequence<Dafny.Rune> _687_uneraseFn;
                      _687_uneraseFn = ((_684_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _687_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _683_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _684_recOwned;
                      isErased = true;
                      readIdents = _686_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out317;
                      bool _out318;
                      bool _out319;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out320;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _682_b), _682_b, _467_toTpe), @params, mustOwn, out _out317, out _out318, out _out319, out _out320);
                      s = _out317;
                      isOwned = _out318;
                      isErased = _out319;
                      readIdents = _out320;
                    }
                  }
                } else if (_source32.is_Map) {
                  DAST._IType _688___mcc_h249 = _source32.dtor_key;
                  DAST._IType _689___mcc_h250 = _source32.dtor_value;
                  DAST._IType _690_b = _627___mcc_h213;
                  {
                    if (object.Equals(_690_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _691_recursiveGen;
                      bool _692_recOwned;
                      bool _693_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _694_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out321;
                      bool _out322;
                      bool _out323;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out324;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out321, out _out322, out _out323, out _out324);
                      _691_recursiveGen = _out321;
                      _692_recOwned = _out322;
                      _693_recErased = _out323;
                      _694_recIdents = _out324;
                      Dafny.ISequence<Dafny.Rune> _695_uneraseFn;
                      _695_uneraseFn = ((_692_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _695_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _691_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _692_recOwned;
                      isErased = true;
                      readIdents = _694_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out325;
                      bool _out326;
                      bool _out327;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out328;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _690_b), _690_b, _467_toTpe), @params, mustOwn, out _out325, out _out326, out _out327, out _out328);
                      s = _out325;
                      isOwned = _out326;
                      isErased = _out327;
                      readIdents = _out328;
                    }
                  }
                } else if (_source32.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _696___mcc_h255 = _source32.dtor_args;
                  DAST._IType _697___mcc_h256 = _source32.dtor_result;
                  DAST._IType _698_b = _627___mcc_h213;
                  {
                    if (object.Equals(_698_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _699_recursiveGen;
                      bool _700_recOwned;
                      bool _701_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _702_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out329;
                      bool _out330;
                      bool _out331;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out332;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out329, out _out330, out _out331, out _out332);
                      _699_recursiveGen = _out329;
                      _700_recOwned = _out330;
                      _701_recErased = _out331;
                      _702_recIdents = _out332;
                      Dafny.ISequence<Dafny.Rune> _703_uneraseFn;
                      _703_uneraseFn = ((_700_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _703_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _699_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _700_recOwned;
                      isErased = true;
                      readIdents = _702_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out333;
                      bool _out334;
                      bool _out335;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out336;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _698_b), _698_b, _467_toTpe), @params, mustOwn, out _out333, out _out334, out _out335, out _out336);
                      s = _out333;
                      isOwned = _out334;
                      isErased = _out335;
                      readIdents = _out336;
                    }
                  }
                } else if (_source32.is_Primitive) {
                  DAST._IPrimitive _704___mcc_h261 = _source32.dtor_Primitive_a0;
                  DAST._IType _705_b = _627___mcc_h213;
                  {
                    if (object.Equals(_705_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _706_recursiveGen;
                      bool _707_recOwned;
                      bool _708_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _709_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out337;
                      bool _out338;
                      bool _out339;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out340;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out337, out _out338, out _out339, out _out340);
                      _706_recursiveGen = _out337;
                      _707_recOwned = _out338;
                      _708_recErased = _out339;
                      _709_recIdents = _out340;
                      Dafny.ISequence<Dafny.Rune> _710_uneraseFn;
                      _710_uneraseFn = ((_707_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _710_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _706_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _707_recOwned;
                      isErased = true;
                      readIdents = _709_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out341;
                      bool _out342;
                      bool _out343;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out344;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _705_b), _705_b, _467_toTpe), @params, mustOwn, out _out341, out _out342, out _out343, out _out344);
                      s = _out341;
                      isOwned = _out342;
                      isErased = _out343;
                      readIdents = _out344;
                    }
                  }
                } else if (_source32.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _711___mcc_h264 = _source32.dtor_Passthrough_a0;
                  DAST._IType _712_b = _627___mcc_h213;
                  {
                    if (object.Equals(_712_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _713_recursiveGen;
                      bool _714_recOwned;
                      bool _715_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _716_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out345;
                      bool _out346;
                      bool _out347;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out348;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out345, out _out346, out _out347, out _out348);
                      _713_recursiveGen = _out345;
                      _714_recOwned = _out346;
                      _715_recErased = _out347;
                      _716_recIdents = _out348;
                      Dafny.ISequence<Dafny.Rune> _717_uneraseFn;
                      _717_uneraseFn = ((_714_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _717_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _713_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _714_recOwned;
                      isErased = true;
                      readIdents = _716_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out349;
                      bool _out350;
                      bool _out351;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out352;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _712_b), _712_b, _467_toTpe), @params, mustOwn, out _out349, out _out350, out _out351, out _out352);
                      s = _out349;
                      isOwned = _out350;
                      isErased = _out351;
                      readIdents = _out352;
                    }
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _718___mcc_h267 = _source32.dtor_TypeArg_a0;
                  DAST._IType _719_b = _627___mcc_h213;
                  {
                    if (object.Equals(_719_b, _467_toTpe)) {
                      Dafny.ISequence<Dafny.Rune> _720_recursiveGen;
                      bool _721_recOwned;
                      bool _722_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _723_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out353;
                      bool _out354;
                      bool _out355;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out356;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out353, out _out354, out _out355, out _out356);
                      _720_recursiveGen = _out353;
                      _721_recOwned = _out354;
                      _722_recErased = _out355;
                      _723_recIdents = _out356;
                      Dafny.ISequence<Dafny.Rune> _724_uneraseFn;
                      _724_uneraseFn = ((_721_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _724_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _720_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _721_recOwned;
                      isErased = true;
                      readIdents = _723_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out357;
                      bool _out358;
                      bool _out359;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _719_b), _719_b, _467_toTpe), @params, mustOwn, out _out357, out _out358, out _out359, out _out360);
                      s = _out357;
                      isOwned = _out358;
                      isErased = _out359;
                      readIdents = _out360;
                    }
                  }
                }
              }
            } else if (_source26.is_Tuple) {
              Dafny.ISequence<DAST._IType> _725___mcc_h270 = _source26.dtor_Tuple_a0;
              DAST._IType _source34 = _475___mcc_h123;
              if (_source34.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _726___mcc_h273 = _source34.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _727___mcc_h274 = _source34.dtor_typeArgs;
                DAST._IResolvedType _728___mcc_h275 = _source34.dtor_resolved;
                DAST._IResolvedType _source35 = _728___mcc_h275;
                if (_source35.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _729___mcc_h279 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _730_recursiveGen;
                    bool _731_recOwned;
                    bool _732_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _733_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out361;
                    bool _out362;
                    bool _out363;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out361, out _out362, out _out363, out _out364);
                    _730_recursiveGen = _out361;
                    _731_recOwned = _out362;
                    _732_recErased = _out363;
                    _733_recIdents = _out364;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _731_recOwned;
                    isErased = _732_recErased;
                    readIdents = _733_recIdents;
                  }
                } else if (_source35.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _734___mcc_h281 = _source35.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _735_recursiveGen;
                    bool _736_recOwned;
                    bool _737_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _738_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out365;
                    bool _out366;
                    bool _out367;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out365, out _out366, out _out367, out _out368);
                    _735_recursiveGen = _out365;
                    _736_recOwned = _out366;
                    _737_recErased = _out367;
                    _738_recIdents = _out368;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _736_recOwned;
                    isErased = _737_recErased;
                    readIdents = _738_recIdents;
                  }
                } else {
                  DAST._IType _739___mcc_h283 = _source35.dtor_Newtype_a0;
                  DAST._IType _740_b = _739___mcc_h283;
                  {
                    if (object.Equals(_468_fromTpe, _740_b)) {
                      Dafny.ISequence<Dafny.Rune> _741_recursiveGen;
                      bool _742_recOwned;
                      bool _743_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _744_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out369;
                      bool _out370;
                      bool _out371;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out369, out _out370, out _out371, out _out372);
                      _741_recursiveGen = _out369;
                      _742_recOwned = _out370;
                      _743_recErased = _out371;
                      _744_recIdents = _out372;
                      Dafny.ISequence<Dafny.Rune> _745_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out373;
                      _out373 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _745_rhsType = _out373;
                      Dafny.ISequence<Dafny.Rune> _746_uneraseFn;
                      _746_uneraseFn = ((_742_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _745_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _746_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _742_recOwned;
                      isErased = false;
                      readIdents = _744_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out374;
                      bool _out375;
                      bool _out376;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out377;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _740_b), _740_b, _467_toTpe), @params, mustOwn, out _out374, out _out375, out _out376, out _out377);
                      s = _out374;
                      isOwned = _out375;
                      isErased = _out376;
                      readIdents = _out377;
                    }
                  }
                }
              } else if (_source34.is_Tuple) {
                Dafny.ISequence<DAST._IType> _747___mcc_h285 = _source34.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _748_recursiveGen;
                  bool _749_recOwned;
                  bool _750_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _751_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out378;
                  bool _out379;
                  bool _out380;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out381;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out378, out _out379, out _out380, out _out381);
                  _748_recursiveGen = _out378;
                  _749_recOwned = _out379;
                  _750_recErased = _out380;
                  _751_recIdents = _out381;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _748_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _749_recOwned;
                  isErased = _750_recErased;
                  readIdents = _751_recIdents;
                }
              } else if (_source34.is_Array) {
                DAST._IType _752___mcc_h287 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _753_recursiveGen;
                  bool _754_recOwned;
                  bool _755_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _756_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out382;
                  bool _out383;
                  bool _out384;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out385;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out382, out _out383, out _out384, out _out385);
                  _753_recursiveGen = _out382;
                  _754_recOwned = _out383;
                  _755_recErased = _out384;
                  _756_recIdents = _out385;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _753_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _754_recOwned;
                  isErased = _755_recErased;
                  readIdents = _756_recIdents;
                }
              } else if (_source34.is_Seq) {
                DAST._IType _757___mcc_h289 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _758_recursiveGen;
                  bool _759_recOwned;
                  bool _760_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _761_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out386;
                  bool _out387;
                  bool _out388;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out389;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out386, out _out387, out _out388, out _out389);
                  _758_recursiveGen = _out386;
                  _759_recOwned = _out387;
                  _760_recErased = _out388;
                  _761_recIdents = _out389;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _758_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _759_recOwned;
                  isErased = _760_recErased;
                  readIdents = _761_recIdents;
                }
              } else if (_source34.is_Set) {
                DAST._IType _762___mcc_h291 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _763_recursiveGen;
                  bool _764_recOwned;
                  bool _765_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _766_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out390;
                  bool _out391;
                  bool _out392;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out393;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out390, out _out391, out _out392, out _out393);
                  _763_recursiveGen = _out390;
                  _764_recOwned = _out391;
                  _765_recErased = _out392;
                  _766_recIdents = _out393;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _763_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _764_recOwned;
                  isErased = _765_recErased;
                  readIdents = _766_recIdents;
                }
              } else if (_source34.is_Multiset) {
                DAST._IType _767___mcc_h293 = _source34.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _768_recursiveGen;
                  bool _769_recOwned;
                  bool _770_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _771_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out394;
                  bool _out395;
                  bool _out396;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out397;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out394, out _out395, out _out396, out _out397);
                  _768_recursiveGen = _out394;
                  _769_recOwned = _out395;
                  _770_recErased = _out396;
                  _771_recIdents = _out397;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _768_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _769_recOwned;
                  isErased = _770_recErased;
                  readIdents = _771_recIdents;
                }
              } else if (_source34.is_Map) {
                DAST._IType _772___mcc_h295 = _source34.dtor_key;
                DAST._IType _773___mcc_h296 = _source34.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _774_recursiveGen;
                  bool _775_recOwned;
                  bool _776_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _777_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out398;
                  bool _out399;
                  bool _out400;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out401;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out398, out _out399, out _out400, out _out401);
                  _774_recursiveGen = _out398;
                  _775_recOwned = _out399;
                  _776_recErased = _out400;
                  _777_recIdents = _out401;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _774_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _775_recOwned;
                  isErased = _776_recErased;
                  readIdents = _777_recIdents;
                }
              } else if (_source34.is_Arrow) {
                Dafny.ISequence<DAST._IType> _778___mcc_h299 = _source34.dtor_args;
                DAST._IType _779___mcc_h300 = _source34.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _780_recursiveGen;
                  bool _781_recOwned;
                  bool _782_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _783_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out402;
                  bool _out403;
                  bool _out404;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out405;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out402, out _out403, out _out404, out _out405);
                  _780_recursiveGen = _out402;
                  _781_recOwned = _out403;
                  _782_recErased = _out404;
                  _783_recIdents = _out405;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _780_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _781_recOwned;
                  isErased = _782_recErased;
                  readIdents = _783_recIdents;
                }
              } else if (_source34.is_Primitive) {
                DAST._IPrimitive _784___mcc_h303 = _source34.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _785_recursiveGen;
                  bool _786_recOwned;
                  bool _787_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _788_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out406;
                  bool _out407;
                  bool _out408;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out409;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out406, out _out407, out _out408, out _out409);
                  _785_recursiveGen = _out406;
                  _786_recOwned = _out407;
                  _787_recErased = _out408;
                  _788_recIdents = _out409;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _785_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _786_recOwned;
                  isErased = _787_recErased;
                  readIdents = _788_recIdents;
                }
              } else if (_source34.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _789___mcc_h305 = _source34.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _790_recursiveGen;
                  bool _791_recOwned;
                  bool _792_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _793_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out410;
                  bool _out411;
                  bool _out412;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out413;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out410, out _out411, out _out412, out _out413);
                  _790_recursiveGen = _out410;
                  _791_recOwned = _out411;
                  _792_recErased = _out412;
                  _793_recIdents = _out413;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _790_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _791_recOwned;
                  isErased = _792_recErased;
                  readIdents = _793_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _794___mcc_h307 = _source34.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _795_recursiveGen;
                  bool _796_recOwned;
                  bool _797_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _798_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out414;
                  bool _out415;
                  bool _out416;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out417;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out414, out _out415, out _out416, out _out417);
                  _795_recursiveGen = _out414;
                  _796_recOwned = _out415;
                  _797_recErased = _out416;
                  _798_recIdents = _out417;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _795_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _796_recOwned;
                  isErased = _797_recErased;
                  readIdents = _798_recIdents;
                }
              }
            } else if (_source26.is_Array) {
              DAST._IType _799___mcc_h309 = _source26.dtor_element;
              DAST._IType _source36 = _475___mcc_h123;
              if (_source36.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _800___mcc_h312 = _source36.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _801___mcc_h313 = _source36.dtor_typeArgs;
                DAST._IResolvedType _802___mcc_h314 = _source36.dtor_resolved;
                DAST._IResolvedType _source37 = _802___mcc_h314;
                if (_source37.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _803___mcc_h318 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _804_recursiveGen;
                    bool _805_recOwned;
                    bool _806_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _807_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out418;
                    bool _out419;
                    bool _out420;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out421;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out418, out _out419, out _out420, out _out421);
                    _804_recursiveGen = _out418;
                    _805_recOwned = _out419;
                    _806_recErased = _out420;
                    _807_recIdents = _out421;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _804_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _805_recOwned;
                    isErased = _806_recErased;
                    readIdents = _807_recIdents;
                  }
                } else if (_source37.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _808___mcc_h320 = _source37.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _809_recursiveGen;
                    bool _810_recOwned;
                    bool _811_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _812_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out422;
                    bool _out423;
                    bool _out424;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out425;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out422, out _out423, out _out424, out _out425);
                    _809_recursiveGen = _out422;
                    _810_recOwned = _out423;
                    _811_recErased = _out424;
                    _812_recIdents = _out425;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _809_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _810_recOwned;
                    isErased = _811_recErased;
                    readIdents = _812_recIdents;
                  }
                } else {
                  DAST._IType _813___mcc_h322 = _source37.dtor_Newtype_a0;
                  DAST._IType _814_b = _813___mcc_h322;
                  {
                    if (object.Equals(_468_fromTpe, _814_b)) {
                      Dafny.ISequence<Dafny.Rune> _815_recursiveGen;
                      bool _816_recOwned;
                      bool _817_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _818_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out426;
                      bool _out427;
                      bool _out428;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out429;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out426, out _out427, out _out428, out _out429);
                      _815_recursiveGen = _out426;
                      _816_recOwned = _out427;
                      _817_recErased = _out428;
                      _818_recIdents = _out429;
                      Dafny.ISequence<Dafny.Rune> _819_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out430;
                      _out430 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _819_rhsType = _out430;
                      Dafny.ISequence<Dafny.Rune> _820_uneraseFn;
                      _820_uneraseFn = ((_816_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _819_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _820_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _815_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _816_recOwned;
                      isErased = false;
                      readIdents = _818_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out431;
                      bool _out432;
                      bool _out433;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out434;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _814_b), _814_b, _467_toTpe), @params, mustOwn, out _out431, out _out432, out _out433, out _out434);
                      s = _out431;
                      isOwned = _out432;
                      isErased = _out433;
                      readIdents = _out434;
                    }
                  }
                }
              } else if (_source36.is_Tuple) {
                Dafny.ISequence<DAST._IType> _821___mcc_h324 = _source36.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _822_recursiveGen;
                  bool _823_recOwned;
                  bool _824_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _825_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out435;
                  bool _out436;
                  bool _out437;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out438;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out435, out _out436, out _out437, out _out438);
                  _822_recursiveGen = _out435;
                  _823_recOwned = _out436;
                  _824_recErased = _out437;
                  _825_recIdents = _out438;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _822_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _823_recOwned;
                  isErased = _824_recErased;
                  readIdents = _825_recIdents;
                }
              } else if (_source36.is_Array) {
                DAST._IType _826___mcc_h326 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _827_recursiveGen;
                  bool _828_recOwned;
                  bool _829_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _830_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out439;
                  bool _out440;
                  bool _out441;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out442;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out439, out _out440, out _out441, out _out442);
                  _827_recursiveGen = _out439;
                  _828_recOwned = _out440;
                  _829_recErased = _out441;
                  _830_recIdents = _out442;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _827_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _828_recOwned;
                  isErased = _829_recErased;
                  readIdents = _830_recIdents;
                }
              } else if (_source36.is_Seq) {
                DAST._IType _831___mcc_h328 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _832_recursiveGen;
                  bool _833_recOwned;
                  bool _834_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _835_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out443;
                  bool _out444;
                  bool _out445;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out446;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out443, out _out444, out _out445, out _out446);
                  _832_recursiveGen = _out443;
                  _833_recOwned = _out444;
                  _834_recErased = _out445;
                  _835_recIdents = _out446;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _832_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _833_recOwned;
                  isErased = _834_recErased;
                  readIdents = _835_recIdents;
                }
              } else if (_source36.is_Set) {
                DAST._IType _836___mcc_h330 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _837_recursiveGen;
                  bool _838_recOwned;
                  bool _839_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _840_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out447;
                  bool _out448;
                  bool _out449;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out450;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out447, out _out448, out _out449, out _out450);
                  _837_recursiveGen = _out447;
                  _838_recOwned = _out448;
                  _839_recErased = _out449;
                  _840_recIdents = _out450;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _837_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _838_recOwned;
                  isErased = _839_recErased;
                  readIdents = _840_recIdents;
                }
              } else if (_source36.is_Multiset) {
                DAST._IType _841___mcc_h332 = _source36.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _842_recursiveGen;
                  bool _843_recOwned;
                  bool _844_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _845_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out451;
                  bool _out452;
                  bool _out453;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out454;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out451, out _out452, out _out453, out _out454);
                  _842_recursiveGen = _out451;
                  _843_recOwned = _out452;
                  _844_recErased = _out453;
                  _845_recIdents = _out454;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _842_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _843_recOwned;
                  isErased = _844_recErased;
                  readIdents = _845_recIdents;
                }
              } else if (_source36.is_Map) {
                DAST._IType _846___mcc_h334 = _source36.dtor_key;
                DAST._IType _847___mcc_h335 = _source36.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _848_recursiveGen;
                  bool _849_recOwned;
                  bool _850_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _851_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out455;
                  bool _out456;
                  bool _out457;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out458;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out455, out _out456, out _out457, out _out458);
                  _848_recursiveGen = _out455;
                  _849_recOwned = _out456;
                  _850_recErased = _out457;
                  _851_recIdents = _out458;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _848_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _849_recOwned;
                  isErased = _850_recErased;
                  readIdents = _851_recIdents;
                }
              } else if (_source36.is_Arrow) {
                Dafny.ISequence<DAST._IType> _852___mcc_h338 = _source36.dtor_args;
                DAST._IType _853___mcc_h339 = _source36.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _854_recursiveGen;
                  bool _855_recOwned;
                  bool _856_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _857_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out459;
                  bool _out460;
                  bool _out461;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out462;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out459, out _out460, out _out461, out _out462);
                  _854_recursiveGen = _out459;
                  _855_recOwned = _out460;
                  _856_recErased = _out461;
                  _857_recIdents = _out462;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _854_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _855_recOwned;
                  isErased = _856_recErased;
                  readIdents = _857_recIdents;
                }
              } else if (_source36.is_Primitive) {
                DAST._IPrimitive _858___mcc_h342 = _source36.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _859_recursiveGen;
                  bool _860_recOwned;
                  bool _861_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _862_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out463;
                  bool _out464;
                  bool _out465;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out466;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out463, out _out464, out _out465, out _out466);
                  _859_recursiveGen = _out463;
                  _860_recOwned = _out464;
                  _861_recErased = _out465;
                  _862_recIdents = _out466;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _859_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _860_recOwned;
                  isErased = _861_recErased;
                  readIdents = _862_recIdents;
                }
              } else if (_source36.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _863___mcc_h344 = _source36.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _864_recursiveGen;
                  bool _865_recOwned;
                  bool _866_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _867_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out467;
                  bool _out468;
                  bool _out469;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out470;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out467, out _out468, out _out469, out _out470);
                  _864_recursiveGen = _out467;
                  _865_recOwned = _out468;
                  _866_recErased = _out469;
                  _867_recIdents = _out470;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _864_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _865_recOwned;
                  isErased = _866_recErased;
                  readIdents = _867_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _868___mcc_h346 = _source36.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _869_recursiveGen;
                  bool _870_recOwned;
                  bool _871_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _872_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out471;
                  bool _out472;
                  bool _out473;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out474;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out471, out _out472, out _out473, out _out474);
                  _869_recursiveGen = _out471;
                  _870_recOwned = _out472;
                  _871_recErased = _out473;
                  _872_recIdents = _out474;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _869_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _870_recOwned;
                  isErased = _871_recErased;
                  readIdents = _872_recIdents;
                }
              }
            } else if (_source26.is_Seq) {
              DAST._IType _873___mcc_h348 = _source26.dtor_element;
              DAST._IType _source38 = _475___mcc_h123;
              if (_source38.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _874___mcc_h351 = _source38.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _875___mcc_h352 = _source38.dtor_typeArgs;
                DAST._IResolvedType _876___mcc_h353 = _source38.dtor_resolved;
                DAST._IResolvedType _source39 = _876___mcc_h353;
                if (_source39.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _877___mcc_h357 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _878_recursiveGen;
                    bool _879_recOwned;
                    bool _880_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _881_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out475;
                    bool _out476;
                    bool _out477;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out478;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out475, out _out476, out _out477, out _out478);
                    _878_recursiveGen = _out475;
                    _879_recOwned = _out476;
                    _880_recErased = _out477;
                    _881_recIdents = _out478;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _878_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _879_recOwned;
                    isErased = _880_recErased;
                    readIdents = _881_recIdents;
                  }
                } else if (_source39.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _882___mcc_h359 = _source39.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _883_recursiveGen;
                    bool _884_recOwned;
                    bool _885_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _886_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out479;
                    bool _out480;
                    bool _out481;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out482;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out479, out _out480, out _out481, out _out482);
                    _883_recursiveGen = _out479;
                    _884_recOwned = _out480;
                    _885_recErased = _out481;
                    _886_recIdents = _out482;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _884_recOwned;
                    isErased = _885_recErased;
                    readIdents = _886_recIdents;
                  }
                } else {
                  DAST._IType _887___mcc_h361 = _source39.dtor_Newtype_a0;
                  DAST._IType _888_b = _887___mcc_h361;
                  {
                    if (object.Equals(_468_fromTpe, _888_b)) {
                      Dafny.ISequence<Dafny.Rune> _889_recursiveGen;
                      bool _890_recOwned;
                      bool _891_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _892_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out483;
                      bool _out484;
                      bool _out485;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out486;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out483, out _out484, out _out485, out _out486);
                      _889_recursiveGen = _out483;
                      _890_recOwned = _out484;
                      _891_recErased = _out485;
                      _892_recIdents = _out486;
                      Dafny.ISequence<Dafny.Rune> _893_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out487;
                      _out487 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _893_rhsType = _out487;
                      Dafny.ISequence<Dafny.Rune> _894_uneraseFn;
                      _894_uneraseFn = ((_890_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _893_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _894_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _889_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _890_recOwned;
                      isErased = false;
                      readIdents = _892_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out488;
                      bool _out489;
                      bool _out490;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out491;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _888_b), _888_b, _467_toTpe), @params, mustOwn, out _out488, out _out489, out _out490, out _out491);
                      s = _out488;
                      isOwned = _out489;
                      isErased = _out490;
                      readIdents = _out491;
                    }
                  }
                }
              } else if (_source38.is_Tuple) {
                Dafny.ISequence<DAST._IType> _895___mcc_h363 = _source38.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _896_recursiveGen;
                  bool _897_recOwned;
                  bool _898_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _899_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out492;
                  bool _out493;
                  bool _out494;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out495;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out492, out _out493, out _out494, out _out495);
                  _896_recursiveGen = _out492;
                  _897_recOwned = _out493;
                  _898_recErased = _out494;
                  _899_recIdents = _out495;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _896_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _897_recOwned;
                  isErased = _898_recErased;
                  readIdents = _899_recIdents;
                }
              } else if (_source38.is_Array) {
                DAST._IType _900___mcc_h365 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _901_recursiveGen;
                  bool _902_recOwned;
                  bool _903_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _904_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out496;
                  bool _out497;
                  bool _out498;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out499;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out496, out _out497, out _out498, out _out499);
                  _901_recursiveGen = _out496;
                  _902_recOwned = _out497;
                  _903_recErased = _out498;
                  _904_recIdents = _out499;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _901_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _902_recOwned;
                  isErased = _903_recErased;
                  readIdents = _904_recIdents;
                }
              } else if (_source38.is_Seq) {
                DAST._IType _905___mcc_h367 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _906_recursiveGen;
                  bool _907_recOwned;
                  bool _908_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _909_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out500;
                  bool _out501;
                  bool _out502;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out503;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out500, out _out501, out _out502, out _out503);
                  _906_recursiveGen = _out500;
                  _907_recOwned = _out501;
                  _908_recErased = _out502;
                  _909_recIdents = _out503;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _906_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _907_recOwned;
                  isErased = _908_recErased;
                  readIdents = _909_recIdents;
                }
              } else if (_source38.is_Set) {
                DAST._IType _910___mcc_h369 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _911_recursiveGen;
                  bool _912_recOwned;
                  bool _913_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _914_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out504;
                  bool _out505;
                  bool _out506;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out507;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out504, out _out505, out _out506, out _out507);
                  _911_recursiveGen = _out504;
                  _912_recOwned = _out505;
                  _913_recErased = _out506;
                  _914_recIdents = _out507;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _911_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _912_recOwned;
                  isErased = _913_recErased;
                  readIdents = _914_recIdents;
                }
              } else if (_source38.is_Multiset) {
                DAST._IType _915___mcc_h371 = _source38.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _916_recursiveGen;
                  bool _917_recOwned;
                  bool _918_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _919_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out508;
                  bool _out509;
                  bool _out510;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out511;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out508, out _out509, out _out510, out _out511);
                  _916_recursiveGen = _out508;
                  _917_recOwned = _out509;
                  _918_recErased = _out510;
                  _919_recIdents = _out511;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _916_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _917_recOwned;
                  isErased = _918_recErased;
                  readIdents = _919_recIdents;
                }
              } else if (_source38.is_Map) {
                DAST._IType _920___mcc_h373 = _source38.dtor_key;
                DAST._IType _921___mcc_h374 = _source38.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _922_recursiveGen;
                  bool _923_recOwned;
                  bool _924_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _925_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out512;
                  bool _out513;
                  bool _out514;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out515;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out512, out _out513, out _out514, out _out515);
                  _922_recursiveGen = _out512;
                  _923_recOwned = _out513;
                  _924_recErased = _out514;
                  _925_recIdents = _out515;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _922_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _923_recOwned;
                  isErased = _924_recErased;
                  readIdents = _925_recIdents;
                }
              } else if (_source38.is_Arrow) {
                Dafny.ISequence<DAST._IType> _926___mcc_h377 = _source38.dtor_args;
                DAST._IType _927___mcc_h378 = _source38.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _928_recursiveGen;
                  bool _929_recOwned;
                  bool _930_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _931_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out516;
                  bool _out517;
                  bool _out518;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out519;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out516, out _out517, out _out518, out _out519);
                  _928_recursiveGen = _out516;
                  _929_recOwned = _out517;
                  _930_recErased = _out518;
                  _931_recIdents = _out519;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _928_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _929_recOwned;
                  isErased = _930_recErased;
                  readIdents = _931_recIdents;
                }
              } else if (_source38.is_Primitive) {
                DAST._IPrimitive _932___mcc_h381 = _source38.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _933_recursiveGen;
                  bool _934_recOwned;
                  bool _935_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _936_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out520;
                  bool _out521;
                  bool _out522;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out523;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out520, out _out521, out _out522, out _out523);
                  _933_recursiveGen = _out520;
                  _934_recOwned = _out521;
                  _935_recErased = _out522;
                  _936_recIdents = _out523;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _933_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _934_recOwned;
                  isErased = _935_recErased;
                  readIdents = _936_recIdents;
                }
              } else if (_source38.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _937___mcc_h383 = _source38.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _938_recursiveGen;
                  bool _939_recOwned;
                  bool _940_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _941_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out524;
                  bool _out525;
                  bool _out526;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out527;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out524, out _out525, out _out526, out _out527);
                  _938_recursiveGen = _out524;
                  _939_recOwned = _out525;
                  _940_recErased = _out526;
                  _941_recIdents = _out527;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _938_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _939_recOwned;
                  isErased = _940_recErased;
                  readIdents = _941_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _942___mcc_h385 = _source38.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _943_recursiveGen;
                  bool _944_recOwned;
                  bool _945_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _946_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out528;
                  bool _out529;
                  bool _out530;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out531;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out528, out _out529, out _out530, out _out531);
                  _943_recursiveGen = _out528;
                  _944_recOwned = _out529;
                  _945_recErased = _out530;
                  _946_recIdents = _out531;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _944_recOwned;
                  isErased = _945_recErased;
                  readIdents = _946_recIdents;
                }
              }
            } else if (_source26.is_Set) {
              DAST._IType _947___mcc_h387 = _source26.dtor_element;
              DAST._IType _source40 = _475___mcc_h123;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _948___mcc_h390 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _949___mcc_h391 = _source40.dtor_typeArgs;
                DAST._IResolvedType _950___mcc_h392 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _950___mcc_h392;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _951___mcc_h396 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _952_recursiveGen;
                    bool _953_recOwned;
                    bool _954_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _955_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out532;
                    bool _out533;
                    bool _out534;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out535;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out532, out _out533, out _out534, out _out535);
                    _952_recursiveGen = _out532;
                    _953_recOwned = _out533;
                    _954_recErased = _out534;
                    _955_recIdents = _out535;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _952_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _953_recOwned;
                    isErased = _954_recErased;
                    readIdents = _955_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _956___mcc_h398 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _957_recursiveGen;
                    bool _958_recOwned;
                    bool _959_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _960_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out536;
                    bool _out537;
                    bool _out538;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out539;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out536, out _out537, out _out538, out _out539);
                    _957_recursiveGen = _out536;
                    _958_recOwned = _out537;
                    _959_recErased = _out538;
                    _960_recIdents = _out539;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _957_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _958_recOwned;
                    isErased = _959_recErased;
                    readIdents = _960_recIdents;
                  }
                } else {
                  DAST._IType _961___mcc_h400 = _source41.dtor_Newtype_a0;
                  DAST._IType _962_b = _961___mcc_h400;
                  {
                    if (object.Equals(_468_fromTpe, _962_b)) {
                      Dafny.ISequence<Dafny.Rune> _963_recursiveGen;
                      bool _964_recOwned;
                      bool _965_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _966_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out540;
                      bool _out541;
                      bool _out542;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out543;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out540, out _out541, out _out542, out _out543);
                      _963_recursiveGen = _out540;
                      _964_recOwned = _out541;
                      _965_recErased = _out542;
                      _966_recIdents = _out543;
                      Dafny.ISequence<Dafny.Rune> _967_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out544;
                      _out544 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _967_rhsType = _out544;
                      Dafny.ISequence<Dafny.Rune> _968_uneraseFn;
                      _968_uneraseFn = ((_964_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _967_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _968_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _963_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _964_recOwned;
                      isErased = false;
                      readIdents = _966_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out545;
                      bool _out546;
                      bool _out547;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out548;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _962_b), _962_b, _467_toTpe), @params, mustOwn, out _out545, out _out546, out _out547, out _out548);
                      s = _out545;
                      isOwned = _out546;
                      isErased = _out547;
                      readIdents = _out548;
                    }
                  }
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _969___mcc_h402 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _970_recursiveGen;
                  bool _971_recOwned;
                  bool _972_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _973_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out549;
                  bool _out550;
                  bool _out551;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out552;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out549, out _out550, out _out551, out _out552);
                  _970_recursiveGen = _out549;
                  _971_recOwned = _out550;
                  _972_recErased = _out551;
                  _973_recIdents = _out552;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _970_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _971_recOwned;
                  isErased = _972_recErased;
                  readIdents = _973_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _974___mcc_h404 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _975_recursiveGen;
                  bool _976_recOwned;
                  bool _977_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _978_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out553;
                  bool _out554;
                  bool _out555;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out556;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out553, out _out554, out _out555, out _out556);
                  _975_recursiveGen = _out553;
                  _976_recOwned = _out554;
                  _977_recErased = _out555;
                  _978_recIdents = _out556;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _975_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _976_recOwned;
                  isErased = _977_recErased;
                  readIdents = _978_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _979___mcc_h406 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _980_recursiveGen;
                  bool _981_recOwned;
                  bool _982_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _983_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out557;
                  bool _out558;
                  bool _out559;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out560;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out557, out _out558, out _out559, out _out560);
                  _980_recursiveGen = _out557;
                  _981_recOwned = _out558;
                  _982_recErased = _out559;
                  _983_recIdents = _out560;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _980_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _981_recOwned;
                  isErased = _982_recErased;
                  readIdents = _983_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _984___mcc_h408 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _985_recursiveGen;
                  bool _986_recOwned;
                  bool _987_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _988_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out561;
                  bool _out562;
                  bool _out563;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out564;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out561, out _out562, out _out563, out _out564);
                  _985_recursiveGen = _out561;
                  _986_recOwned = _out562;
                  _987_recErased = _out563;
                  _988_recIdents = _out564;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _985_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _986_recOwned;
                  isErased = _987_recErased;
                  readIdents = _988_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _989___mcc_h410 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _990_recursiveGen;
                  bool _991_recOwned;
                  bool _992_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _993_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out565;
                  bool _out566;
                  bool _out567;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out568;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out565, out _out566, out _out567, out _out568);
                  _990_recursiveGen = _out565;
                  _991_recOwned = _out566;
                  _992_recErased = _out567;
                  _993_recIdents = _out568;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _990_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _991_recOwned;
                  isErased = _992_recErased;
                  readIdents = _993_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _994___mcc_h412 = _source40.dtor_key;
                DAST._IType _995___mcc_h413 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _996_recursiveGen;
                  bool _997_recOwned;
                  bool _998_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _999_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out569;
                  bool _out570;
                  bool _out571;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out572;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out569, out _out570, out _out571, out _out572);
                  _996_recursiveGen = _out569;
                  _997_recOwned = _out570;
                  _998_recErased = _out571;
                  _999_recIdents = _out572;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _996_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _997_recOwned;
                  isErased = _998_recErased;
                  readIdents = _999_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1000___mcc_h416 = _source40.dtor_args;
                DAST._IType _1001___mcc_h417 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1002_recursiveGen;
                  bool _1003_recOwned;
                  bool _1004_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1005_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out573;
                  bool _out574;
                  bool _out575;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out576;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out573, out _out574, out _out575, out _out576);
                  _1002_recursiveGen = _out573;
                  _1003_recOwned = _out574;
                  _1004_recErased = _out575;
                  _1005_recIdents = _out576;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1002_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1003_recOwned;
                  isErased = _1004_recErased;
                  readIdents = _1005_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1006___mcc_h420 = _source40.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1007_recursiveGen;
                  bool _1008_recOwned;
                  bool _1009_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1010_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out577;
                  bool _out578;
                  bool _out579;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out580;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out577, out _out578, out _out579, out _out580);
                  _1007_recursiveGen = _out577;
                  _1008_recOwned = _out578;
                  _1009_recErased = _out579;
                  _1010_recIdents = _out580;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1007_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1008_recOwned;
                  isErased = _1009_recErased;
                  readIdents = _1010_recIdents;
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1011___mcc_h422 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1012_recursiveGen;
                  bool _1013_recOwned;
                  bool _1014_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1015_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out581;
                  bool _out582;
                  bool _out583;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out584;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out581, out _out582, out _out583, out _out584);
                  _1012_recursiveGen = _out581;
                  _1013_recOwned = _out582;
                  _1014_recErased = _out583;
                  _1015_recIdents = _out584;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1012_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1013_recOwned;
                  isErased = _1014_recErased;
                  readIdents = _1015_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1016___mcc_h424 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1017_recursiveGen;
                  bool _1018_recOwned;
                  bool _1019_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1020_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out585;
                  bool _out586;
                  bool _out587;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out588;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out585, out _out586, out _out587, out _out588);
                  _1017_recursiveGen = _out585;
                  _1018_recOwned = _out586;
                  _1019_recErased = _out587;
                  _1020_recIdents = _out588;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1017_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1018_recOwned;
                  isErased = _1019_recErased;
                  readIdents = _1020_recIdents;
                }
              }
            } else if (_source26.is_Multiset) {
              DAST._IType _1021___mcc_h426 = _source26.dtor_element;
              DAST._IType _source42 = _475___mcc_h123;
              if (_source42.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1022___mcc_h429 = _source42.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1023___mcc_h430 = _source42.dtor_typeArgs;
                DAST._IResolvedType _1024___mcc_h431 = _source42.dtor_resolved;
                DAST._IResolvedType _source43 = _1024___mcc_h431;
                if (_source43.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1025___mcc_h435 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1026_recursiveGen;
                    bool _1027_recOwned;
                    bool _1028_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1029_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out589;
                    bool _out590;
                    bool _out591;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out592;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out589, out _out590, out _out591, out _out592);
                    _1026_recursiveGen = _out589;
                    _1027_recOwned = _out590;
                    _1028_recErased = _out591;
                    _1029_recIdents = _out592;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1026_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1027_recOwned;
                    isErased = _1028_recErased;
                    readIdents = _1029_recIdents;
                  }
                } else if (_source43.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1030___mcc_h437 = _source43.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1031_recursiveGen;
                    bool _1032_recOwned;
                    bool _1033_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1034_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out593;
                    bool _out594;
                    bool _out595;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out596;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out593, out _out594, out _out595, out _out596);
                    _1031_recursiveGen = _out593;
                    _1032_recOwned = _out594;
                    _1033_recErased = _out595;
                    _1034_recIdents = _out596;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1031_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1032_recOwned;
                    isErased = _1033_recErased;
                    readIdents = _1034_recIdents;
                  }
                } else {
                  DAST._IType _1035___mcc_h439 = _source43.dtor_Newtype_a0;
                  DAST._IType _1036_b = _1035___mcc_h439;
                  {
                    if (object.Equals(_468_fromTpe, _1036_b)) {
                      Dafny.ISequence<Dafny.Rune> _1037_recursiveGen;
                      bool _1038_recOwned;
                      bool _1039_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1040_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out597;
                      bool _out598;
                      bool _out599;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out600;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out597, out _out598, out _out599, out _out600);
                      _1037_recursiveGen = _out597;
                      _1038_recOwned = _out598;
                      _1039_recErased = _out599;
                      _1040_recIdents = _out600;
                      Dafny.ISequence<Dafny.Rune> _1041_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out601;
                      _out601 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _1041_rhsType = _out601;
                      Dafny.ISequence<Dafny.Rune> _1042_uneraseFn;
                      _1042_uneraseFn = ((_1038_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1041_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1042_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1037_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1038_recOwned;
                      isErased = false;
                      readIdents = _1040_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out602;
                      bool _out603;
                      bool _out604;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out605;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1036_b), _1036_b, _467_toTpe), @params, mustOwn, out _out602, out _out603, out _out604, out _out605);
                      s = _out602;
                      isOwned = _out603;
                      isErased = _out604;
                      readIdents = _out605;
                    }
                  }
                }
              } else if (_source42.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1043___mcc_h441 = _source42.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1044_recursiveGen;
                  bool _1045_recOwned;
                  bool _1046_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1047_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out606;
                  bool _out607;
                  bool _out608;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out609;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out606, out _out607, out _out608, out _out609);
                  _1044_recursiveGen = _out606;
                  _1045_recOwned = _out607;
                  _1046_recErased = _out608;
                  _1047_recIdents = _out609;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1044_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1045_recOwned;
                  isErased = _1046_recErased;
                  readIdents = _1047_recIdents;
                }
              } else if (_source42.is_Array) {
                DAST._IType _1048___mcc_h443 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1049_recursiveGen;
                  bool _1050_recOwned;
                  bool _1051_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1052_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out610;
                  bool _out611;
                  bool _out612;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out613;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out610, out _out611, out _out612, out _out613);
                  _1049_recursiveGen = _out610;
                  _1050_recOwned = _out611;
                  _1051_recErased = _out612;
                  _1052_recIdents = _out613;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1049_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1050_recOwned;
                  isErased = _1051_recErased;
                  readIdents = _1052_recIdents;
                }
              } else if (_source42.is_Seq) {
                DAST._IType _1053___mcc_h445 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1054_recursiveGen;
                  bool _1055_recOwned;
                  bool _1056_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1057_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out614;
                  bool _out615;
                  bool _out616;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out617;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out614, out _out615, out _out616, out _out617);
                  _1054_recursiveGen = _out614;
                  _1055_recOwned = _out615;
                  _1056_recErased = _out616;
                  _1057_recIdents = _out617;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1054_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1055_recOwned;
                  isErased = _1056_recErased;
                  readIdents = _1057_recIdents;
                }
              } else if (_source42.is_Set) {
                DAST._IType _1058___mcc_h447 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1059_recursiveGen;
                  bool _1060_recOwned;
                  bool _1061_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1062_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out618;
                  bool _out619;
                  bool _out620;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out621;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out618, out _out619, out _out620, out _out621);
                  _1059_recursiveGen = _out618;
                  _1060_recOwned = _out619;
                  _1061_recErased = _out620;
                  _1062_recIdents = _out621;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1059_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1060_recOwned;
                  isErased = _1061_recErased;
                  readIdents = _1062_recIdents;
                }
              } else if (_source42.is_Multiset) {
                DAST._IType _1063___mcc_h449 = _source42.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1064_recursiveGen;
                  bool _1065_recOwned;
                  bool _1066_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1067_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out622;
                  bool _out623;
                  bool _out624;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out625;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out622, out _out623, out _out624, out _out625);
                  _1064_recursiveGen = _out622;
                  _1065_recOwned = _out623;
                  _1066_recErased = _out624;
                  _1067_recIdents = _out625;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1064_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1065_recOwned;
                  isErased = _1066_recErased;
                  readIdents = _1067_recIdents;
                }
              } else if (_source42.is_Map) {
                DAST._IType _1068___mcc_h451 = _source42.dtor_key;
                DAST._IType _1069___mcc_h452 = _source42.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1070_recursiveGen;
                  bool _1071_recOwned;
                  bool _1072_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1073_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out626;
                  bool _out627;
                  bool _out628;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out629;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out626, out _out627, out _out628, out _out629);
                  _1070_recursiveGen = _out626;
                  _1071_recOwned = _out627;
                  _1072_recErased = _out628;
                  _1073_recIdents = _out629;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1070_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1071_recOwned;
                  isErased = _1072_recErased;
                  readIdents = _1073_recIdents;
                }
              } else if (_source42.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1074___mcc_h455 = _source42.dtor_args;
                DAST._IType _1075___mcc_h456 = _source42.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1076_recursiveGen;
                  bool _1077_recOwned;
                  bool _1078_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1079_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out630;
                  bool _out631;
                  bool _out632;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out633;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out630, out _out631, out _out632, out _out633);
                  _1076_recursiveGen = _out630;
                  _1077_recOwned = _out631;
                  _1078_recErased = _out632;
                  _1079_recIdents = _out633;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1076_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1077_recOwned;
                  isErased = _1078_recErased;
                  readIdents = _1079_recIdents;
                }
              } else if (_source42.is_Primitive) {
                DAST._IPrimitive _1080___mcc_h459 = _source42.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1081_recursiveGen;
                  bool _1082_recOwned;
                  bool _1083_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1084_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out634;
                  bool _out635;
                  bool _out636;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out637;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out634, out _out635, out _out636, out _out637);
                  _1081_recursiveGen = _out634;
                  _1082_recOwned = _out635;
                  _1083_recErased = _out636;
                  _1084_recIdents = _out637;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1081_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1082_recOwned;
                  isErased = _1083_recErased;
                  readIdents = _1084_recIdents;
                }
              } else if (_source42.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1085___mcc_h461 = _source42.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1086_recursiveGen;
                  bool _1087_recOwned;
                  bool _1088_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1089_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out638;
                  bool _out639;
                  bool _out640;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out641;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out638, out _out639, out _out640, out _out641);
                  _1086_recursiveGen = _out638;
                  _1087_recOwned = _out639;
                  _1088_recErased = _out640;
                  _1089_recIdents = _out641;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1086_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1087_recOwned;
                  isErased = _1088_recErased;
                  readIdents = _1089_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1090___mcc_h463 = _source42.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1091_recursiveGen;
                  bool _1092_recOwned;
                  bool _1093_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1094_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out642;
                  bool _out643;
                  bool _out644;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out645;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out642, out _out643, out _out644, out _out645);
                  _1091_recursiveGen = _out642;
                  _1092_recOwned = _out643;
                  _1093_recErased = _out644;
                  _1094_recIdents = _out645;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1091_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1092_recOwned;
                  isErased = _1093_recErased;
                  readIdents = _1094_recIdents;
                }
              }
            } else if (_source26.is_Map) {
              DAST._IType _1095___mcc_h465 = _source26.dtor_key;
              DAST._IType _1096___mcc_h466 = _source26.dtor_value;
              DAST._IType _source44 = _475___mcc_h123;
              if (_source44.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1097___mcc_h471 = _source44.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1098___mcc_h472 = _source44.dtor_typeArgs;
                DAST._IResolvedType _1099___mcc_h473 = _source44.dtor_resolved;
                DAST._IResolvedType _source45 = _1099___mcc_h473;
                if (_source45.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1100___mcc_h477 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1101_recursiveGen;
                    bool _1102_recOwned;
                    bool _1103_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1104_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out646;
                    bool _out647;
                    bool _out648;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out649;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out646, out _out647, out _out648, out _out649);
                    _1101_recursiveGen = _out646;
                    _1102_recOwned = _out647;
                    _1103_recErased = _out648;
                    _1104_recIdents = _out649;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1101_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1102_recOwned;
                    isErased = _1103_recErased;
                    readIdents = _1104_recIdents;
                  }
                } else if (_source45.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1105___mcc_h479 = _source45.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1106_recursiveGen;
                    bool _1107_recOwned;
                    bool _1108_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1109_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out650;
                    bool _out651;
                    bool _out652;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out653;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out650, out _out651, out _out652, out _out653);
                    _1106_recursiveGen = _out650;
                    _1107_recOwned = _out651;
                    _1108_recErased = _out652;
                    _1109_recIdents = _out653;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1106_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1107_recOwned;
                    isErased = _1108_recErased;
                    readIdents = _1109_recIdents;
                  }
                } else {
                  DAST._IType _1110___mcc_h481 = _source45.dtor_Newtype_a0;
                  DAST._IType _1111_b = _1110___mcc_h481;
                  {
                    if (object.Equals(_468_fromTpe, _1111_b)) {
                      Dafny.ISequence<Dafny.Rune> _1112_recursiveGen;
                      bool _1113_recOwned;
                      bool _1114_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1115_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out654;
                      bool _out655;
                      bool _out656;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out657;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out654, out _out655, out _out656, out _out657);
                      _1112_recursiveGen = _out654;
                      _1113_recOwned = _out655;
                      _1114_recErased = _out656;
                      _1115_recIdents = _out657;
                      Dafny.ISequence<Dafny.Rune> _1116_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out658;
                      _out658 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _1116_rhsType = _out658;
                      Dafny.ISequence<Dafny.Rune> _1117_uneraseFn;
                      _1117_uneraseFn = ((_1113_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1116_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1117_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1112_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1113_recOwned;
                      isErased = false;
                      readIdents = _1115_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out659;
                      bool _out660;
                      bool _out661;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out662;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1111_b), _1111_b, _467_toTpe), @params, mustOwn, out _out659, out _out660, out _out661, out _out662);
                      s = _out659;
                      isOwned = _out660;
                      isErased = _out661;
                      readIdents = _out662;
                    }
                  }
                }
              } else if (_source44.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1118___mcc_h483 = _source44.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1119_recursiveGen;
                  bool _1120_recOwned;
                  bool _1121_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1122_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out663;
                  bool _out664;
                  bool _out665;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out666;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out663, out _out664, out _out665, out _out666);
                  _1119_recursiveGen = _out663;
                  _1120_recOwned = _out664;
                  _1121_recErased = _out665;
                  _1122_recIdents = _out666;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1119_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1120_recOwned;
                  isErased = _1121_recErased;
                  readIdents = _1122_recIdents;
                }
              } else if (_source44.is_Array) {
                DAST._IType _1123___mcc_h485 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1124_recursiveGen;
                  bool _1125_recOwned;
                  bool _1126_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1127_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out667;
                  bool _out668;
                  bool _out669;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out670;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out667, out _out668, out _out669, out _out670);
                  _1124_recursiveGen = _out667;
                  _1125_recOwned = _out668;
                  _1126_recErased = _out669;
                  _1127_recIdents = _out670;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1124_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1125_recOwned;
                  isErased = _1126_recErased;
                  readIdents = _1127_recIdents;
                }
              } else if (_source44.is_Seq) {
                DAST._IType _1128___mcc_h487 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1129_recursiveGen;
                  bool _1130_recOwned;
                  bool _1131_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1132_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out671;
                  bool _out672;
                  bool _out673;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out674;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out671, out _out672, out _out673, out _out674);
                  _1129_recursiveGen = _out671;
                  _1130_recOwned = _out672;
                  _1131_recErased = _out673;
                  _1132_recIdents = _out674;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1129_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1130_recOwned;
                  isErased = _1131_recErased;
                  readIdents = _1132_recIdents;
                }
              } else if (_source44.is_Set) {
                DAST._IType _1133___mcc_h489 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1134_recursiveGen;
                  bool _1135_recOwned;
                  bool _1136_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1137_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out675;
                  bool _out676;
                  bool _out677;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out678;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out675, out _out676, out _out677, out _out678);
                  _1134_recursiveGen = _out675;
                  _1135_recOwned = _out676;
                  _1136_recErased = _out677;
                  _1137_recIdents = _out678;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1134_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1135_recOwned;
                  isErased = _1136_recErased;
                  readIdents = _1137_recIdents;
                }
              } else if (_source44.is_Multiset) {
                DAST._IType _1138___mcc_h491 = _source44.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1139_recursiveGen;
                  bool _1140_recOwned;
                  bool _1141_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1142_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out679;
                  bool _out680;
                  bool _out681;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out682;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out679, out _out680, out _out681, out _out682);
                  _1139_recursiveGen = _out679;
                  _1140_recOwned = _out680;
                  _1141_recErased = _out681;
                  _1142_recIdents = _out682;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1139_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1140_recOwned;
                  isErased = _1141_recErased;
                  readIdents = _1142_recIdents;
                }
              } else if (_source44.is_Map) {
                DAST._IType _1143___mcc_h493 = _source44.dtor_key;
                DAST._IType _1144___mcc_h494 = _source44.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1145_recursiveGen;
                  bool _1146_recOwned;
                  bool _1147_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1148_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out683;
                  bool _out684;
                  bool _out685;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out686;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out683, out _out684, out _out685, out _out686);
                  _1145_recursiveGen = _out683;
                  _1146_recOwned = _out684;
                  _1147_recErased = _out685;
                  _1148_recIdents = _out686;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1145_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1146_recOwned;
                  isErased = _1147_recErased;
                  readIdents = _1148_recIdents;
                }
              } else if (_source44.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1149___mcc_h497 = _source44.dtor_args;
                DAST._IType _1150___mcc_h498 = _source44.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1151_recursiveGen;
                  bool _1152_recOwned;
                  bool _1153_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1154_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out687;
                  bool _out688;
                  bool _out689;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out690;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out687, out _out688, out _out689, out _out690);
                  _1151_recursiveGen = _out687;
                  _1152_recOwned = _out688;
                  _1153_recErased = _out689;
                  _1154_recIdents = _out690;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1151_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1152_recOwned;
                  isErased = _1153_recErased;
                  readIdents = _1154_recIdents;
                }
              } else if (_source44.is_Primitive) {
                DAST._IPrimitive _1155___mcc_h501 = _source44.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1156_recursiveGen;
                  bool _1157_recOwned;
                  bool _1158_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1159_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out691;
                  bool _out692;
                  bool _out693;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out694;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out691, out _out692, out _out693, out _out694);
                  _1156_recursiveGen = _out691;
                  _1157_recOwned = _out692;
                  _1158_recErased = _out693;
                  _1159_recIdents = _out694;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1156_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1157_recOwned;
                  isErased = _1158_recErased;
                  readIdents = _1159_recIdents;
                }
              } else if (_source44.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1160___mcc_h503 = _source44.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1161_recursiveGen;
                  bool _1162_recOwned;
                  bool _1163_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1164_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out695;
                  bool _out696;
                  bool _out697;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out698;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out695, out _out696, out _out697, out _out698);
                  _1161_recursiveGen = _out695;
                  _1162_recOwned = _out696;
                  _1163_recErased = _out697;
                  _1164_recIdents = _out698;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1161_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1162_recOwned;
                  isErased = _1163_recErased;
                  readIdents = _1164_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1165___mcc_h505 = _source44.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1166_recursiveGen;
                  bool _1167_recOwned;
                  bool _1168_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1169_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out699;
                  bool _out700;
                  bool _out701;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out702;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out699, out _out700, out _out701, out _out702);
                  _1166_recursiveGen = _out699;
                  _1167_recOwned = _out700;
                  _1168_recErased = _out701;
                  _1169_recIdents = _out702;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1166_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1167_recOwned;
                  isErased = _1168_recErased;
                  readIdents = _1169_recIdents;
                }
              }
            } else if (_source26.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1170___mcc_h507 = _source26.dtor_args;
              DAST._IType _1171___mcc_h508 = _source26.dtor_result;
              DAST._IType _source46 = _475___mcc_h123;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1172___mcc_h513 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1173___mcc_h514 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1174___mcc_h515 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1174___mcc_h515;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1175___mcc_h519 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1176_recursiveGen;
                    bool _1177_recOwned;
                    bool _1178_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1179_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out703;
                    bool _out704;
                    bool _out705;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out706;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out703, out _out704, out _out705, out _out706);
                    _1176_recursiveGen = _out703;
                    _1177_recOwned = _out704;
                    _1178_recErased = _out705;
                    _1179_recIdents = _out706;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1176_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1177_recOwned;
                    isErased = _1178_recErased;
                    readIdents = _1179_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1180___mcc_h521 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1181_recursiveGen;
                    bool _1182_recOwned;
                    bool _1183_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1184_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out707;
                    bool _out708;
                    bool _out709;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out710;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out707, out _out708, out _out709, out _out710);
                    _1181_recursiveGen = _out707;
                    _1182_recOwned = _out708;
                    _1183_recErased = _out709;
                    _1184_recIdents = _out710;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1181_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1182_recOwned;
                    isErased = _1183_recErased;
                    readIdents = _1184_recIdents;
                  }
                } else {
                  DAST._IType _1185___mcc_h523 = _source47.dtor_Newtype_a0;
                  DAST._IType _1186_b = _1185___mcc_h523;
                  {
                    if (object.Equals(_468_fromTpe, _1186_b)) {
                      Dafny.ISequence<Dafny.Rune> _1187_recursiveGen;
                      bool _1188_recOwned;
                      bool _1189_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1190_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out711;
                      bool _out712;
                      bool _out713;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out714;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out711, out _out712, out _out713, out _out714);
                      _1187_recursiveGen = _out711;
                      _1188_recOwned = _out712;
                      _1189_recErased = _out713;
                      _1190_recIdents = _out714;
                      Dafny.ISequence<Dafny.Rune> _1191_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out715;
                      _out715 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _1191_rhsType = _out715;
                      Dafny.ISequence<Dafny.Rune> _1192_uneraseFn;
                      _1192_uneraseFn = ((_1188_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1191_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1192_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1187_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1188_recOwned;
                      isErased = false;
                      readIdents = _1190_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out716;
                      bool _out717;
                      bool _out718;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out719;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1186_b), _1186_b, _467_toTpe), @params, mustOwn, out _out716, out _out717, out _out718, out _out719);
                      s = _out716;
                      isOwned = _out717;
                      isErased = _out718;
                      readIdents = _out719;
                    }
                  }
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1193___mcc_h525 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1194_recursiveGen;
                  bool _1195_recOwned;
                  bool _1196_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1197_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out720;
                  bool _out721;
                  bool _out722;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out723;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out720, out _out721, out _out722, out _out723);
                  _1194_recursiveGen = _out720;
                  _1195_recOwned = _out721;
                  _1196_recErased = _out722;
                  _1197_recIdents = _out723;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1194_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1195_recOwned;
                  isErased = _1196_recErased;
                  readIdents = _1197_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1198___mcc_h527 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1199_recursiveGen;
                  bool _1200_recOwned;
                  bool _1201_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1202_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out724;
                  bool _out725;
                  bool _out726;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out727;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out724, out _out725, out _out726, out _out727);
                  _1199_recursiveGen = _out724;
                  _1200_recOwned = _out725;
                  _1201_recErased = _out726;
                  _1202_recIdents = _out727;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1199_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1200_recOwned;
                  isErased = _1201_recErased;
                  readIdents = _1202_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1203___mcc_h529 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1204_recursiveGen;
                  bool _1205_recOwned;
                  bool _1206_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1207_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out728;
                  bool _out729;
                  bool _out730;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out731;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out728, out _out729, out _out730, out _out731);
                  _1204_recursiveGen = _out728;
                  _1205_recOwned = _out729;
                  _1206_recErased = _out730;
                  _1207_recIdents = _out731;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1204_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1205_recOwned;
                  isErased = _1206_recErased;
                  readIdents = _1207_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1208___mcc_h531 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1209_recursiveGen;
                  bool _1210_recOwned;
                  bool _1211_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1212_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out732;
                  bool _out733;
                  bool _out734;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out735;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out732, out _out733, out _out734, out _out735);
                  _1209_recursiveGen = _out732;
                  _1210_recOwned = _out733;
                  _1211_recErased = _out734;
                  _1212_recIdents = _out735;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1209_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1210_recOwned;
                  isErased = _1211_recErased;
                  readIdents = _1212_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1213___mcc_h533 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1214_recursiveGen;
                  bool _1215_recOwned;
                  bool _1216_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1217_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out736;
                  bool _out737;
                  bool _out738;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out739;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out736, out _out737, out _out738, out _out739);
                  _1214_recursiveGen = _out736;
                  _1215_recOwned = _out737;
                  _1216_recErased = _out738;
                  _1217_recIdents = _out739;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1214_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1215_recOwned;
                  isErased = _1216_recErased;
                  readIdents = _1217_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1218___mcc_h535 = _source46.dtor_key;
                DAST._IType _1219___mcc_h536 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1220_recursiveGen;
                  bool _1221_recOwned;
                  bool _1222_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1223_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out740;
                  bool _out741;
                  bool _out742;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out743;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out740, out _out741, out _out742, out _out743);
                  _1220_recursiveGen = _out740;
                  _1221_recOwned = _out741;
                  _1222_recErased = _out742;
                  _1223_recIdents = _out743;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1220_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1221_recOwned;
                  isErased = _1222_recErased;
                  readIdents = _1223_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1224___mcc_h539 = _source46.dtor_args;
                DAST._IType _1225___mcc_h540 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1226_recursiveGen;
                  bool _1227_recOwned;
                  bool _1228_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1229_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out744;
                  bool _out745;
                  bool _out746;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out747;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out744, out _out745, out _out746, out _out747);
                  _1226_recursiveGen = _out744;
                  _1227_recOwned = _out745;
                  _1228_recErased = _out746;
                  _1229_recIdents = _out747;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1226_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1227_recOwned;
                  isErased = _1228_recErased;
                  readIdents = _1229_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1230___mcc_h543 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1231_recursiveGen;
                  bool _1232_recOwned;
                  bool _1233_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1234_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out748;
                  bool _out749;
                  bool _out750;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out751;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out748, out _out749, out _out750, out _out751);
                  _1231_recursiveGen = _out748;
                  _1232_recOwned = _out749;
                  _1233_recErased = _out750;
                  _1234_recIdents = _out751;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1231_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1232_recOwned;
                  isErased = _1233_recErased;
                  readIdents = _1234_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1235___mcc_h545 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1236_recursiveGen;
                  bool _1237_recOwned;
                  bool _1238_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1239_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out752;
                  bool _out753;
                  bool _out754;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out755;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out752, out _out753, out _out754, out _out755);
                  _1236_recursiveGen = _out752;
                  _1237_recOwned = _out753;
                  _1238_recErased = _out754;
                  _1239_recIdents = _out755;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1236_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1237_recOwned;
                  isErased = _1238_recErased;
                  readIdents = _1239_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1240___mcc_h547 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1241_recursiveGen;
                  bool _1242_recOwned;
                  bool _1243_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1244_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out756;
                  bool _out757;
                  bool _out758;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out759;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out756, out _out757, out _out758, out _out759);
                  _1241_recursiveGen = _out756;
                  _1242_recOwned = _out757;
                  _1243_recErased = _out758;
                  _1244_recIdents = _out759;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1241_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1242_recOwned;
                  isErased = _1243_recErased;
                  readIdents = _1244_recIdents;
                }
              }
            } else if (_source26.is_Primitive) {
              DAST._IPrimitive _1245___mcc_h549 = _source26.dtor_Primitive_a0;
              DAST._IPrimitive _source48 = _1245___mcc_h549;
              if (_source48.is_Int) {
                DAST._IType _source49 = _475___mcc_h123;
                if (_source49.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1246___mcc_h552 = _source49.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1247___mcc_h553 = _source49.dtor_typeArgs;
                  DAST._IResolvedType _1248___mcc_h554 = _source49.dtor_resolved;
                  DAST._IResolvedType _source50 = _1248___mcc_h554;
                  if (_source50.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1249___mcc_h558 = _source50.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1250_recursiveGen;
                      bool _1251_recOwned;
                      bool _1252_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1253_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out760;
                      bool _out761;
                      bool _out762;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out763;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out760, out _out761, out _out762, out _out763);
                      _1250_recursiveGen = _out760;
                      _1251_recOwned = _out761;
                      _1252_recErased = _out762;
                      _1253_recIdents = _out763;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1250_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1251_recOwned;
                      isErased = _1252_recErased;
                      readIdents = _1253_recIdents;
                    }
                  } else if (_source50.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1254___mcc_h560 = _source50.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1255_recursiveGen;
                      bool _1256_recOwned;
                      bool _1257_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1258_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out764;
                      bool _out765;
                      bool _out766;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out767;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out764, out _out765, out _out766, out _out767);
                      _1255_recursiveGen = _out764;
                      _1256_recOwned = _out765;
                      _1257_recErased = _out766;
                      _1258_recIdents = _out767;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1255_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1256_recOwned;
                      isErased = _1257_recErased;
                      readIdents = _1258_recIdents;
                    }
                  } else {
                    DAST._IType _1259___mcc_h562 = _source50.dtor_Newtype_a0;
                    DAST._IType _1260_b = _1259___mcc_h562;
                    {
                      if (object.Equals(_468_fromTpe, _1260_b)) {
                        Dafny.ISequence<Dafny.Rune> _1261_recursiveGen;
                        bool _1262_recOwned;
                        bool _1263_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1264_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out768;
                        bool _out769;
                        bool _out770;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out771;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out768, out _out769, out _out770, out _out771);
                        _1261_recursiveGen = _out768;
                        _1262_recOwned = _out769;
                        _1263_recErased = _out770;
                        _1264_recIdents = _out771;
                        Dafny.ISequence<Dafny.Rune> _1265_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out772;
                        _out772 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _1265_rhsType = _out772;
                        Dafny.ISequence<Dafny.Rune> _1266_uneraseFn;
                        _1266_uneraseFn = ((_1262_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1265_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1266_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1261_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1262_recOwned;
                        isErased = false;
                        readIdents = _1264_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out773;
                        bool _out774;
                        bool _out775;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out776;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1260_b), _1260_b, _467_toTpe), @params, mustOwn, out _out773, out _out774, out _out775, out _out776);
                        s = _out773;
                        isOwned = _out774;
                        isErased = _out775;
                        readIdents = _out776;
                      }
                    }
                  }
                } else if (_source49.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1267___mcc_h564 = _source49.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1268_recursiveGen;
                    bool _1269_recOwned;
                    bool _1270_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1271_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out777;
                    bool _out778;
                    bool _out779;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out780;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out777, out _out778, out _out779, out _out780);
                    _1268_recursiveGen = _out777;
                    _1269_recOwned = _out778;
                    _1270_recErased = _out779;
                    _1271_recIdents = _out780;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1268_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1269_recOwned;
                    isErased = _1270_recErased;
                    readIdents = _1271_recIdents;
                  }
                } else if (_source49.is_Array) {
                  DAST._IType _1272___mcc_h566 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1273_recursiveGen;
                    bool _1274_recOwned;
                    bool _1275_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1276_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out781;
                    bool _out782;
                    bool _out783;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out784;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out781, out _out782, out _out783, out _out784);
                    _1273_recursiveGen = _out781;
                    _1274_recOwned = _out782;
                    _1275_recErased = _out783;
                    _1276_recIdents = _out784;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1273_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1274_recOwned;
                    isErased = _1275_recErased;
                    readIdents = _1276_recIdents;
                  }
                } else if (_source49.is_Seq) {
                  DAST._IType _1277___mcc_h568 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1278_recursiveGen;
                    bool _1279_recOwned;
                    bool _1280_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1281_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out785;
                    bool _out786;
                    bool _out787;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out788;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out785, out _out786, out _out787, out _out788);
                    _1278_recursiveGen = _out785;
                    _1279_recOwned = _out786;
                    _1280_recErased = _out787;
                    _1281_recIdents = _out788;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1278_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1279_recOwned;
                    isErased = _1280_recErased;
                    readIdents = _1281_recIdents;
                  }
                } else if (_source49.is_Set) {
                  DAST._IType _1282___mcc_h570 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1283_recursiveGen;
                    bool _1284_recOwned;
                    bool _1285_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1286_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out789;
                    bool _out790;
                    bool _out791;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out792;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out789, out _out790, out _out791, out _out792);
                    _1283_recursiveGen = _out789;
                    _1284_recOwned = _out790;
                    _1285_recErased = _out791;
                    _1286_recIdents = _out792;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1283_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1284_recOwned;
                    isErased = _1285_recErased;
                    readIdents = _1286_recIdents;
                  }
                } else if (_source49.is_Multiset) {
                  DAST._IType _1287___mcc_h572 = _source49.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1288_recursiveGen;
                    bool _1289_recOwned;
                    bool _1290_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1291_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out793;
                    bool _out794;
                    bool _out795;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out796;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out793, out _out794, out _out795, out _out796);
                    _1288_recursiveGen = _out793;
                    _1289_recOwned = _out794;
                    _1290_recErased = _out795;
                    _1291_recIdents = _out796;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1288_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1289_recOwned;
                    isErased = _1290_recErased;
                    readIdents = _1291_recIdents;
                  }
                } else if (_source49.is_Map) {
                  DAST._IType _1292___mcc_h574 = _source49.dtor_key;
                  DAST._IType _1293___mcc_h575 = _source49.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1294_recursiveGen;
                    bool _1295_recOwned;
                    bool _1296_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1297_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out797;
                    bool _out798;
                    bool _out799;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out800;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out797, out _out798, out _out799, out _out800);
                    _1294_recursiveGen = _out797;
                    _1295_recOwned = _out798;
                    _1296_recErased = _out799;
                    _1297_recIdents = _out800;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1294_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1295_recOwned;
                    isErased = _1296_recErased;
                    readIdents = _1297_recIdents;
                  }
                } else if (_source49.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1298___mcc_h578 = _source49.dtor_args;
                  DAST._IType _1299___mcc_h579 = _source49.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1300_recursiveGen;
                    bool _1301_recOwned;
                    bool _1302_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1303_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out801;
                    bool _out802;
                    bool _out803;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out804;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out801, out _out802, out _out803, out _out804);
                    _1300_recursiveGen = _out801;
                    _1301_recOwned = _out802;
                    _1302_recErased = _out803;
                    _1303_recIdents = _out804;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1300_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1301_recOwned;
                    isErased = _1302_recErased;
                    readIdents = _1303_recIdents;
                  }
                } else if (_source49.is_Primitive) {
                  DAST._IPrimitive _1304___mcc_h582 = _source49.dtor_Primitive_a0;
                  DAST._IPrimitive _source51 = _1304___mcc_h582;
                  if (_source51.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1305_recursiveGen;
                      bool _1306_recOwned;
                      bool _1307_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1308_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out805;
                      bool _out806;
                      bool _out807;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out808;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out805, out _out806, out _out807, out _out808);
                      _1305_recursiveGen = _out805;
                      _1306_recOwned = _out806;
                      _1307_recErased = _out807;
                      _1308_recIdents = _out808;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1305_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1306_recOwned;
                      isErased = _1307_recErased;
                      readIdents = _1308_recIdents;
                    }
                  } else if (_source51.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1309_recursiveGen;
                      bool _1310___v39;
                      bool _1311___v40;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1312_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out809;
                      bool _out810;
                      bool _out811;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out812;
                      DCOMP.COMP.GenExpr(_469_expr, @params, true, out _out809, out _out810, out _out811, out _out812);
                      _1309_recursiveGen = _out809;
                      _1310___v39 = _out810;
                      _1311___v40 = _out811;
                      _1312_recIdents = _out812;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1309_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1312_recIdents;
                    }
                  } else if (_source51.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1313_recursiveGen;
                      bool _1314_recOwned;
                      bool _1315_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1316_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out813;
                      bool _out814;
                      bool _out815;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out816;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out813, out _out814, out _out815, out _out816);
                      _1313_recursiveGen = _out813;
                      _1314_recOwned = _out814;
                      _1315_recErased = _out815;
                      _1316_recIdents = _out816;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1313_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1314_recOwned;
                      isErased = _1315_recErased;
                      readIdents = _1316_recIdents;
                    }
                  } else if (_source51.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1317_recursiveGen;
                      bool _1318_recOwned;
                      bool _1319_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1320_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out817;
                      bool _out818;
                      bool _out819;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out820;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out817, out _out818, out _out819, out _out820);
                      _1317_recursiveGen = _out817;
                      _1318_recOwned = _out818;
                      _1319_recErased = _out819;
                      _1320_recIdents = _out820;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1317_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1318_recOwned;
                      isErased = _1319_recErased;
                      readIdents = _1320_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1321_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out821;
                      _out821 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _1321_rhsType = _out821;
                      Dafny.ISequence<Dafny.Rune> _1322_recursiveGen;
                      bool _1323___v49;
                      bool _1324___v50;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1325_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out822;
                      bool _out823;
                      bool _out824;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out825;
                      DCOMP.COMP.GenExpr(_469_expr, @params, true, out _out822, out _out823, out _out824, out _out825);
                      _1322_recursiveGen = _out822;
                      _1323___v49 = _out823;
                      _1324___v50 = _out824;
                      _1325_recIdents = _out825;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("char::from_u32(<u32 as ::dafny_runtime::NumCast>::from("), _1322_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()).unwrap()"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1325_recIdents;
                    }
                  }
                } else if (_source49.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1326___mcc_h584 = _source49.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1327_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out826;
                    _out826 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                    _1327_rhsType = _out826;
                    Dafny.ISequence<Dafny.Rune> _1328_recursiveGen;
                    bool _1329___v44;
                    bool _1330___v45;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1331_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out827;
                    bool _out828;
                    bool _out829;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out830;
                    DCOMP.COMP.GenExpr(_469_expr, @params, true, out _out827, out _out828, out _out829, out _out830);
                    _1328_recursiveGen = _out827;
                    _1329___v44 = _out828;
                    _1330___v45 = _out829;
                    _1331_recIdents = _out830;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1327_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::NumCast>::from(")), _1328_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1331_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1332___mcc_h586 = _source49.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1333_recursiveGen;
                    bool _1334_recOwned;
                    bool _1335_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1336_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out831;
                    bool _out832;
                    bool _out833;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out834;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out831, out _out832, out _out833, out _out834);
                    _1333_recursiveGen = _out831;
                    _1334_recOwned = _out832;
                    _1335_recErased = _out833;
                    _1336_recIdents = _out834;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1333_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1334_recOwned;
                    isErased = _1335_recErased;
                    readIdents = _1336_recIdents;
                  }
                }
              } else if (_source48.is_Real) {
                DAST._IType _source52 = _475___mcc_h123;
                if (_source52.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1337___mcc_h588 = _source52.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1338___mcc_h589 = _source52.dtor_typeArgs;
                  DAST._IResolvedType _1339___mcc_h590 = _source52.dtor_resolved;
                  DAST._IResolvedType _source53 = _1339___mcc_h590;
                  if (_source53.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1340___mcc_h594 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1341_recursiveGen;
                      bool _1342_recOwned;
                      bool _1343_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1344_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out835;
                      bool _out836;
                      bool _out837;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out838;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out835, out _out836, out _out837, out _out838);
                      _1341_recursiveGen = _out835;
                      _1342_recOwned = _out836;
                      _1343_recErased = _out837;
                      _1344_recIdents = _out838;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1341_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1342_recOwned;
                      isErased = _1343_recErased;
                      readIdents = _1344_recIdents;
                    }
                  } else if (_source53.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1345___mcc_h596 = _source53.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1346_recursiveGen;
                      bool _1347_recOwned;
                      bool _1348_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1349_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out839;
                      bool _out840;
                      bool _out841;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out842;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out839, out _out840, out _out841, out _out842);
                      _1346_recursiveGen = _out839;
                      _1347_recOwned = _out840;
                      _1348_recErased = _out841;
                      _1349_recIdents = _out842;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1346_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1347_recOwned;
                      isErased = _1348_recErased;
                      readIdents = _1349_recIdents;
                    }
                  } else {
                    DAST._IType _1350___mcc_h598 = _source53.dtor_Newtype_a0;
                    DAST._IType _1351_b = _1350___mcc_h598;
                    {
                      if (object.Equals(_468_fromTpe, _1351_b)) {
                        Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                        bool _1353_recOwned;
                        bool _1354_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out843;
                        bool _out844;
                        bool _out845;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out846;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out843, out _out844, out _out845, out _out846);
                        _1352_recursiveGen = _out843;
                        _1353_recOwned = _out844;
                        _1354_recErased = _out845;
                        _1355_recIdents = _out846;
                        Dafny.ISequence<Dafny.Rune> _1356_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out847;
                        _out847 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _1356_rhsType = _out847;
                        Dafny.ISequence<Dafny.Rune> _1357_uneraseFn;
                        _1357_uneraseFn = ((_1353_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1356_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1357_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1353_recOwned;
                        isErased = false;
                        readIdents = _1355_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out848;
                        bool _out849;
                        bool _out850;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out851;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1351_b), _1351_b, _467_toTpe), @params, mustOwn, out _out848, out _out849, out _out850, out _out851);
                        s = _out848;
                        isOwned = _out849;
                        isErased = _out850;
                        readIdents = _out851;
                      }
                    }
                  }
                } else if (_source52.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1358___mcc_h600 = _source52.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1359_recursiveGen;
                    bool _1360_recOwned;
                    bool _1361_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1362_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out852;
                    bool _out853;
                    bool _out854;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out855;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out852, out _out853, out _out854, out _out855);
                    _1359_recursiveGen = _out852;
                    _1360_recOwned = _out853;
                    _1361_recErased = _out854;
                    _1362_recIdents = _out855;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1359_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1360_recOwned;
                    isErased = _1361_recErased;
                    readIdents = _1362_recIdents;
                  }
                } else if (_source52.is_Array) {
                  DAST._IType _1363___mcc_h602 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1364_recursiveGen;
                    bool _1365_recOwned;
                    bool _1366_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1367_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out856;
                    bool _out857;
                    bool _out858;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out859;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out856, out _out857, out _out858, out _out859);
                    _1364_recursiveGen = _out856;
                    _1365_recOwned = _out857;
                    _1366_recErased = _out858;
                    _1367_recIdents = _out859;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1364_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1365_recOwned;
                    isErased = _1366_recErased;
                    readIdents = _1367_recIdents;
                  }
                } else if (_source52.is_Seq) {
                  DAST._IType _1368___mcc_h604 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1369_recursiveGen;
                    bool _1370_recOwned;
                    bool _1371_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1372_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out860;
                    bool _out861;
                    bool _out862;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out863;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out860, out _out861, out _out862, out _out863);
                    _1369_recursiveGen = _out860;
                    _1370_recOwned = _out861;
                    _1371_recErased = _out862;
                    _1372_recIdents = _out863;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1369_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1370_recOwned;
                    isErased = _1371_recErased;
                    readIdents = _1372_recIdents;
                  }
                } else if (_source52.is_Set) {
                  DAST._IType _1373___mcc_h606 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1374_recursiveGen;
                    bool _1375_recOwned;
                    bool _1376_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1377_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out864;
                    bool _out865;
                    bool _out866;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out867;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out864, out _out865, out _out866, out _out867);
                    _1374_recursiveGen = _out864;
                    _1375_recOwned = _out865;
                    _1376_recErased = _out866;
                    _1377_recIdents = _out867;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1374_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1375_recOwned;
                    isErased = _1376_recErased;
                    readIdents = _1377_recIdents;
                  }
                } else if (_source52.is_Multiset) {
                  DAST._IType _1378___mcc_h608 = _source52.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1379_recursiveGen;
                    bool _1380_recOwned;
                    bool _1381_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1382_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out868;
                    bool _out869;
                    bool _out870;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out871;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out868, out _out869, out _out870, out _out871);
                    _1379_recursiveGen = _out868;
                    _1380_recOwned = _out869;
                    _1381_recErased = _out870;
                    _1382_recIdents = _out871;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1380_recOwned;
                    isErased = _1381_recErased;
                    readIdents = _1382_recIdents;
                  }
                } else if (_source52.is_Map) {
                  DAST._IType _1383___mcc_h610 = _source52.dtor_key;
                  DAST._IType _1384___mcc_h611 = _source52.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1385_recursiveGen;
                    bool _1386_recOwned;
                    bool _1387_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1388_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out872;
                    bool _out873;
                    bool _out874;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out875;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out872, out _out873, out _out874, out _out875);
                    _1385_recursiveGen = _out872;
                    _1386_recOwned = _out873;
                    _1387_recErased = _out874;
                    _1388_recIdents = _out875;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1385_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1386_recOwned;
                    isErased = _1387_recErased;
                    readIdents = _1388_recIdents;
                  }
                } else if (_source52.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1389___mcc_h614 = _source52.dtor_args;
                  DAST._IType _1390___mcc_h615 = _source52.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1391_recursiveGen;
                    bool _1392_recOwned;
                    bool _1393_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1394_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out876;
                    bool _out877;
                    bool _out878;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out879;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out876, out _out877, out _out878, out _out879);
                    _1391_recursiveGen = _out876;
                    _1392_recOwned = _out877;
                    _1393_recErased = _out878;
                    _1394_recIdents = _out879;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1391_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1392_recOwned;
                    isErased = _1393_recErased;
                    readIdents = _1394_recIdents;
                  }
                } else if (_source52.is_Primitive) {
                  DAST._IPrimitive _1395___mcc_h618 = _source52.dtor_Primitive_a0;
                  DAST._IPrimitive _source54 = _1395___mcc_h618;
                  if (_source54.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1396_recursiveGen;
                      bool _1397___v41;
                      bool _1398___v42;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1399_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out880;
                      bool _out881;
                      bool _out882;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out883;
                      DCOMP.COMP.GenExpr(_469_expr, @params, false, out _out880, out _out881, out _out882, out _out883);
                      _1396_recursiveGen = _out880;
                      _1397___v41 = _out881;
                      _1398___v42 = _out882;
                      _1399_recIdents = _out883;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1396_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1399_recIdents;
                    }
                  } else if (_source54.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1400_recursiveGen;
                      bool _1401_recOwned;
                      bool _1402_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1403_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out884;
                      bool _out885;
                      bool _out886;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out887;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out884, out _out885, out _out886, out _out887);
                      _1400_recursiveGen = _out884;
                      _1401_recOwned = _out885;
                      _1402_recErased = _out886;
                      _1403_recIdents = _out887;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1400_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1401_recOwned;
                      isErased = _1402_recErased;
                      readIdents = _1403_recIdents;
                    }
                  } else if (_source54.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1404_recursiveGen;
                      bool _1405_recOwned;
                      bool _1406_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1407_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out888;
                      bool _out889;
                      bool _out890;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out891;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out888, out _out889, out _out890, out _out891);
                      _1404_recursiveGen = _out888;
                      _1405_recOwned = _out889;
                      _1406_recErased = _out890;
                      _1407_recIdents = _out891;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1404_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1405_recOwned;
                      isErased = _1406_recErased;
                      readIdents = _1407_recIdents;
                    }
                  } else if (_source54.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1408_recursiveGen;
                      bool _1409_recOwned;
                      bool _1410_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1411_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out892;
                      bool _out893;
                      bool _out894;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out895;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out892, out _out893, out _out894, out _out895);
                      _1408_recursiveGen = _out892;
                      _1409_recOwned = _out893;
                      _1410_recErased = _out894;
                      _1411_recIdents = _out895;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1408_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1409_recOwned;
                      isErased = _1410_recErased;
                      readIdents = _1411_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1412_recursiveGen;
                      bool _1413_recOwned;
                      bool _1414_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1415_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out896;
                      bool _out897;
                      bool _out898;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out899;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out896, out _out897, out _out898, out _out899);
                      _1412_recursiveGen = _out896;
                      _1413_recOwned = _out897;
                      _1414_recErased = _out898;
                      _1415_recIdents = _out899;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1412_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1413_recOwned;
                      isErased = _1414_recErased;
                      readIdents = _1415_recIdents;
                    }
                  }
                } else if (_source52.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1416___mcc_h620 = _source52.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1417_recursiveGen;
                    bool _1418_recOwned;
                    bool _1419_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1420_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out900;
                    bool _out901;
                    bool _out902;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out903;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out900, out _out901, out _out902, out _out903);
                    _1417_recursiveGen = _out900;
                    _1418_recOwned = _out901;
                    _1419_recErased = _out902;
                    _1420_recIdents = _out903;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1417_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1418_recOwned;
                    isErased = _1419_recErased;
                    readIdents = _1420_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1421___mcc_h622 = _source52.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1422_recursiveGen;
                    bool _1423_recOwned;
                    bool _1424_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1425_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out904;
                    bool _out905;
                    bool _out906;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out907;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out904, out _out905, out _out906, out _out907);
                    _1422_recursiveGen = _out904;
                    _1423_recOwned = _out905;
                    _1424_recErased = _out906;
                    _1425_recIdents = _out907;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1422_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1423_recOwned;
                    isErased = _1424_recErased;
                    readIdents = _1425_recIdents;
                  }
                }
              } else if (_source48.is_String) {
                DAST._IType _source55 = _475___mcc_h123;
                if (_source55.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1426___mcc_h624 = _source55.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1427___mcc_h625 = _source55.dtor_typeArgs;
                  DAST._IResolvedType _1428___mcc_h626 = _source55.dtor_resolved;
                  DAST._IResolvedType _source56 = _1428___mcc_h626;
                  if (_source56.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1429___mcc_h630 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1430_recursiveGen;
                      bool _1431_recOwned;
                      bool _1432_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1433_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out908;
                      bool _out909;
                      bool _out910;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out911;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out908, out _out909, out _out910, out _out911);
                      _1430_recursiveGen = _out908;
                      _1431_recOwned = _out909;
                      _1432_recErased = _out910;
                      _1433_recIdents = _out911;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1430_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1431_recOwned;
                      isErased = _1432_recErased;
                      readIdents = _1433_recIdents;
                    }
                  } else if (_source56.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1434___mcc_h632 = _source56.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1435_recursiveGen;
                      bool _1436_recOwned;
                      bool _1437_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1438_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out912;
                      bool _out913;
                      bool _out914;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out915;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out912, out _out913, out _out914, out _out915);
                      _1435_recursiveGen = _out912;
                      _1436_recOwned = _out913;
                      _1437_recErased = _out914;
                      _1438_recIdents = _out915;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1435_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1436_recOwned;
                      isErased = _1437_recErased;
                      readIdents = _1438_recIdents;
                    }
                  } else {
                    DAST._IType _1439___mcc_h634 = _source56.dtor_Newtype_a0;
                    DAST._IType _1440_b = _1439___mcc_h634;
                    {
                      if (object.Equals(_468_fromTpe, _1440_b)) {
                        Dafny.ISequence<Dafny.Rune> _1441_recursiveGen;
                        bool _1442_recOwned;
                        bool _1443_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1444_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out916;
                        bool _out917;
                        bool _out918;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out919;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out916, out _out917, out _out918, out _out919);
                        _1441_recursiveGen = _out916;
                        _1442_recOwned = _out917;
                        _1443_recErased = _out918;
                        _1444_recIdents = _out919;
                        Dafny.ISequence<Dafny.Rune> _1445_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out920;
                        _out920 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _1445_rhsType = _out920;
                        Dafny.ISequence<Dafny.Rune> _1446_uneraseFn;
                        _1446_uneraseFn = ((_1442_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1445_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1446_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1441_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1442_recOwned;
                        isErased = false;
                        readIdents = _1444_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out921;
                        bool _out922;
                        bool _out923;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out924;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1440_b), _1440_b, _467_toTpe), @params, mustOwn, out _out921, out _out922, out _out923, out _out924);
                        s = _out921;
                        isOwned = _out922;
                        isErased = _out923;
                        readIdents = _out924;
                      }
                    }
                  }
                } else if (_source55.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1447___mcc_h636 = _source55.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1448_recursiveGen;
                    bool _1449_recOwned;
                    bool _1450_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1451_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out925;
                    bool _out926;
                    bool _out927;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out928;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out925, out _out926, out _out927, out _out928);
                    _1448_recursiveGen = _out925;
                    _1449_recOwned = _out926;
                    _1450_recErased = _out927;
                    _1451_recIdents = _out928;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1448_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1449_recOwned;
                    isErased = _1450_recErased;
                    readIdents = _1451_recIdents;
                  }
                } else if (_source55.is_Array) {
                  DAST._IType _1452___mcc_h638 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1453_recursiveGen;
                    bool _1454_recOwned;
                    bool _1455_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1456_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out929;
                    bool _out930;
                    bool _out931;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out932;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out929, out _out930, out _out931, out _out932);
                    _1453_recursiveGen = _out929;
                    _1454_recOwned = _out930;
                    _1455_recErased = _out931;
                    _1456_recIdents = _out932;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1454_recOwned;
                    isErased = _1455_recErased;
                    readIdents = _1456_recIdents;
                  }
                } else if (_source55.is_Seq) {
                  DAST._IType _1457___mcc_h640 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1458_recursiveGen;
                    bool _1459_recOwned;
                    bool _1460_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1461_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out933;
                    bool _out934;
                    bool _out935;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out936;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out933, out _out934, out _out935, out _out936);
                    _1458_recursiveGen = _out933;
                    _1459_recOwned = _out934;
                    _1460_recErased = _out935;
                    _1461_recIdents = _out936;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1458_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1459_recOwned;
                    isErased = _1460_recErased;
                    readIdents = _1461_recIdents;
                  }
                } else if (_source55.is_Set) {
                  DAST._IType _1462___mcc_h642 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1463_recursiveGen;
                    bool _1464_recOwned;
                    bool _1465_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1466_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out937;
                    bool _out938;
                    bool _out939;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out940;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out937, out _out938, out _out939, out _out940);
                    _1463_recursiveGen = _out937;
                    _1464_recOwned = _out938;
                    _1465_recErased = _out939;
                    _1466_recIdents = _out940;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1464_recOwned;
                    isErased = _1465_recErased;
                    readIdents = _1466_recIdents;
                  }
                } else if (_source55.is_Multiset) {
                  DAST._IType _1467___mcc_h644 = _source55.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1468_recursiveGen;
                    bool _1469_recOwned;
                    bool _1470_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1471_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out941;
                    bool _out942;
                    bool _out943;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out944;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out941, out _out942, out _out943, out _out944);
                    _1468_recursiveGen = _out941;
                    _1469_recOwned = _out942;
                    _1470_recErased = _out943;
                    _1471_recIdents = _out944;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1468_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1469_recOwned;
                    isErased = _1470_recErased;
                    readIdents = _1471_recIdents;
                  }
                } else if (_source55.is_Map) {
                  DAST._IType _1472___mcc_h646 = _source55.dtor_key;
                  DAST._IType _1473___mcc_h647 = _source55.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1474_recursiveGen;
                    bool _1475_recOwned;
                    bool _1476_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1477_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out945;
                    bool _out946;
                    bool _out947;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out948;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out945, out _out946, out _out947, out _out948);
                    _1474_recursiveGen = _out945;
                    _1475_recOwned = _out946;
                    _1476_recErased = _out947;
                    _1477_recIdents = _out948;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1474_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1475_recOwned;
                    isErased = _1476_recErased;
                    readIdents = _1477_recIdents;
                  }
                } else if (_source55.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1478___mcc_h650 = _source55.dtor_args;
                  DAST._IType _1479___mcc_h651 = _source55.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1480_recursiveGen;
                    bool _1481_recOwned;
                    bool _1482_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1483_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out949;
                    bool _out950;
                    bool _out951;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out952;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out949, out _out950, out _out951, out _out952);
                    _1480_recursiveGen = _out949;
                    _1481_recOwned = _out950;
                    _1482_recErased = _out951;
                    _1483_recIdents = _out952;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1480_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1481_recOwned;
                    isErased = _1482_recErased;
                    readIdents = _1483_recIdents;
                  }
                } else if (_source55.is_Primitive) {
                  DAST._IPrimitive _1484___mcc_h654 = _source55.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1485_recursiveGen;
                    bool _1486_recOwned;
                    bool _1487_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1488_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out953;
                    bool _out954;
                    bool _out955;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out956;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out953, out _out954, out _out955, out _out956);
                    _1485_recursiveGen = _out953;
                    _1486_recOwned = _out954;
                    _1487_recErased = _out955;
                    _1488_recIdents = _out956;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1486_recOwned;
                    isErased = _1487_recErased;
                    readIdents = _1488_recIdents;
                  }
                } else if (_source55.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1489___mcc_h656 = _source55.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1490_recursiveGen;
                    bool _1491_recOwned;
                    bool _1492_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1493_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out957;
                    bool _out958;
                    bool _out959;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out960;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out957, out _out958, out _out959, out _out960);
                    _1490_recursiveGen = _out957;
                    _1491_recOwned = _out958;
                    _1492_recErased = _out959;
                    _1493_recIdents = _out960;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1490_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1491_recOwned;
                    isErased = _1492_recErased;
                    readIdents = _1493_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1494___mcc_h658 = _source55.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1495_recursiveGen;
                    bool _1496_recOwned;
                    bool _1497_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1498_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out961;
                    bool _out962;
                    bool _out963;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out964;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out961, out _out962, out _out963, out _out964);
                    _1495_recursiveGen = _out961;
                    _1496_recOwned = _out962;
                    _1497_recErased = _out963;
                    _1498_recIdents = _out964;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1495_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1496_recOwned;
                    isErased = _1497_recErased;
                    readIdents = _1498_recIdents;
                  }
                }
              } else if (_source48.is_Bool) {
                DAST._IType _source57 = _475___mcc_h123;
                if (_source57.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1499___mcc_h660 = _source57.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1500___mcc_h661 = _source57.dtor_typeArgs;
                  DAST._IResolvedType _1501___mcc_h662 = _source57.dtor_resolved;
                  DAST._IResolvedType _source58 = _1501___mcc_h662;
                  if (_source58.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1502___mcc_h666 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1503_recursiveGen;
                      bool _1504_recOwned;
                      bool _1505_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1506_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out965;
                      bool _out966;
                      bool _out967;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out968;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out965, out _out966, out _out967, out _out968);
                      _1503_recursiveGen = _out965;
                      _1504_recOwned = _out966;
                      _1505_recErased = _out967;
                      _1506_recIdents = _out968;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1503_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1504_recOwned;
                      isErased = _1505_recErased;
                      readIdents = _1506_recIdents;
                    }
                  } else if (_source58.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1507___mcc_h668 = _source58.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1508_recursiveGen;
                      bool _1509_recOwned;
                      bool _1510_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1511_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out969;
                      bool _out970;
                      bool _out971;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out972;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out969, out _out970, out _out971, out _out972);
                      _1508_recursiveGen = _out969;
                      _1509_recOwned = _out970;
                      _1510_recErased = _out971;
                      _1511_recIdents = _out972;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1508_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1509_recOwned;
                      isErased = _1510_recErased;
                      readIdents = _1511_recIdents;
                    }
                  } else {
                    DAST._IType _1512___mcc_h670 = _source58.dtor_Newtype_a0;
                    DAST._IType _1513_b = _1512___mcc_h670;
                    {
                      if (object.Equals(_468_fromTpe, _1513_b)) {
                        Dafny.ISequence<Dafny.Rune> _1514_recursiveGen;
                        bool _1515_recOwned;
                        bool _1516_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1517_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out973;
                        bool _out974;
                        bool _out975;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out976;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out973, out _out974, out _out975, out _out976);
                        _1514_recursiveGen = _out973;
                        _1515_recOwned = _out974;
                        _1516_recErased = _out975;
                        _1517_recIdents = _out976;
                        Dafny.ISequence<Dafny.Rune> _1518_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out977;
                        _out977 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _1518_rhsType = _out977;
                        Dafny.ISequence<Dafny.Rune> _1519_uneraseFn;
                        _1519_uneraseFn = ((_1515_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1518_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1519_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1515_recOwned;
                        isErased = false;
                        readIdents = _1517_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out978;
                        bool _out979;
                        bool _out980;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out981;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1513_b), _1513_b, _467_toTpe), @params, mustOwn, out _out978, out _out979, out _out980, out _out981);
                        s = _out978;
                        isOwned = _out979;
                        isErased = _out980;
                        readIdents = _out981;
                      }
                    }
                  }
                } else if (_source57.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1520___mcc_h672 = _source57.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1521_recursiveGen;
                    bool _1522_recOwned;
                    bool _1523_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1524_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out982;
                    bool _out983;
                    bool _out984;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out985;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out982, out _out983, out _out984, out _out985);
                    _1521_recursiveGen = _out982;
                    _1522_recOwned = _out983;
                    _1523_recErased = _out984;
                    _1524_recIdents = _out985;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1521_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1522_recOwned;
                    isErased = _1523_recErased;
                    readIdents = _1524_recIdents;
                  }
                } else if (_source57.is_Array) {
                  DAST._IType _1525___mcc_h674 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1526_recursiveGen;
                    bool _1527_recOwned;
                    bool _1528_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1529_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out986;
                    bool _out987;
                    bool _out988;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out989;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out986, out _out987, out _out988, out _out989);
                    _1526_recursiveGen = _out986;
                    _1527_recOwned = _out987;
                    _1528_recErased = _out988;
                    _1529_recIdents = _out989;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1526_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1527_recOwned;
                    isErased = _1528_recErased;
                    readIdents = _1529_recIdents;
                  }
                } else if (_source57.is_Seq) {
                  DAST._IType _1530___mcc_h676 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1531_recursiveGen;
                    bool _1532_recOwned;
                    bool _1533_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1534_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out990;
                    bool _out991;
                    bool _out992;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out993;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out990, out _out991, out _out992, out _out993);
                    _1531_recursiveGen = _out990;
                    _1532_recOwned = _out991;
                    _1533_recErased = _out992;
                    _1534_recIdents = _out993;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1531_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1532_recOwned;
                    isErased = _1533_recErased;
                    readIdents = _1534_recIdents;
                  }
                } else if (_source57.is_Set) {
                  DAST._IType _1535___mcc_h678 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1536_recursiveGen;
                    bool _1537_recOwned;
                    bool _1538_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1539_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out994;
                    bool _out995;
                    bool _out996;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out997;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out994, out _out995, out _out996, out _out997);
                    _1536_recursiveGen = _out994;
                    _1537_recOwned = _out995;
                    _1538_recErased = _out996;
                    _1539_recIdents = _out997;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1536_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1537_recOwned;
                    isErased = _1538_recErased;
                    readIdents = _1539_recIdents;
                  }
                } else if (_source57.is_Multiset) {
                  DAST._IType _1540___mcc_h680 = _source57.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1541_recursiveGen;
                    bool _1542_recOwned;
                    bool _1543_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1544_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out998;
                    bool _out999;
                    bool _out1000;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1001;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out998, out _out999, out _out1000, out _out1001);
                    _1541_recursiveGen = _out998;
                    _1542_recOwned = _out999;
                    _1543_recErased = _out1000;
                    _1544_recIdents = _out1001;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1541_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1542_recOwned;
                    isErased = _1543_recErased;
                    readIdents = _1544_recIdents;
                  }
                } else if (_source57.is_Map) {
                  DAST._IType _1545___mcc_h682 = _source57.dtor_key;
                  DAST._IType _1546___mcc_h683 = _source57.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1547_recursiveGen;
                    bool _1548_recOwned;
                    bool _1549_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1550_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1002;
                    bool _out1003;
                    bool _out1004;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1005;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1002, out _out1003, out _out1004, out _out1005);
                    _1547_recursiveGen = _out1002;
                    _1548_recOwned = _out1003;
                    _1549_recErased = _out1004;
                    _1550_recIdents = _out1005;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1547_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1548_recOwned;
                    isErased = _1549_recErased;
                    readIdents = _1550_recIdents;
                  }
                } else if (_source57.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1551___mcc_h686 = _source57.dtor_args;
                  DAST._IType _1552___mcc_h687 = _source57.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1553_recursiveGen;
                    bool _1554_recOwned;
                    bool _1555_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1556_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1006;
                    bool _out1007;
                    bool _out1008;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1009;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1006, out _out1007, out _out1008, out _out1009);
                    _1553_recursiveGen = _out1006;
                    _1554_recOwned = _out1007;
                    _1555_recErased = _out1008;
                    _1556_recIdents = _out1009;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1553_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1554_recOwned;
                    isErased = _1555_recErased;
                    readIdents = _1556_recIdents;
                  }
                } else if (_source57.is_Primitive) {
                  DAST._IPrimitive _1557___mcc_h690 = _source57.dtor_Primitive_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1558_recursiveGen;
                    bool _1559_recOwned;
                    bool _1560_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1561_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1010;
                    bool _out1011;
                    bool _out1012;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1013;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1010, out _out1011, out _out1012, out _out1013);
                    _1558_recursiveGen = _out1010;
                    _1559_recOwned = _out1011;
                    _1560_recErased = _out1012;
                    _1561_recIdents = _out1013;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1558_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1559_recOwned;
                    isErased = _1560_recErased;
                    readIdents = _1561_recIdents;
                  }
                } else if (_source57.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1562___mcc_h692 = _source57.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1563_recursiveGen;
                    bool _1564_recOwned;
                    bool _1565_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1566_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1014;
                    bool _out1015;
                    bool _out1016;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1017;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1014, out _out1015, out _out1016, out _out1017);
                    _1563_recursiveGen = _out1014;
                    _1564_recOwned = _out1015;
                    _1565_recErased = _out1016;
                    _1566_recIdents = _out1017;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1563_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1564_recOwned;
                    isErased = _1565_recErased;
                    readIdents = _1566_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1567___mcc_h694 = _source57.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1568_recursiveGen;
                    bool _1569_recOwned;
                    bool _1570_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1571_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1018;
                    bool _out1019;
                    bool _out1020;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1021;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1018, out _out1019, out _out1020, out _out1021);
                    _1568_recursiveGen = _out1018;
                    _1569_recOwned = _out1019;
                    _1570_recErased = _out1020;
                    _1571_recIdents = _out1021;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1568_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1569_recOwned;
                    isErased = _1570_recErased;
                    readIdents = _1571_recIdents;
                  }
                }
              } else {
                DAST._IType _source59 = _475___mcc_h123;
                if (_source59.is_Path) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1572___mcc_h696 = _source59.dtor_Path_a0;
                  Dafny.ISequence<DAST._IType> _1573___mcc_h697 = _source59.dtor_typeArgs;
                  DAST._IResolvedType _1574___mcc_h698 = _source59.dtor_resolved;
                  DAST._IResolvedType _source60 = _1574___mcc_h698;
                  if (_source60.is_Datatype) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1575___mcc_h702 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1576_recursiveGen;
                      bool _1577_recOwned;
                      bool _1578_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1579_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1022;
                      bool _out1023;
                      bool _out1024;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1025;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1022, out _out1023, out _out1024, out _out1025);
                      _1576_recursiveGen = _out1022;
                      _1577_recOwned = _out1023;
                      _1578_recErased = _out1024;
                      _1579_recIdents = _out1025;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1576_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1577_recOwned;
                      isErased = _1578_recErased;
                      readIdents = _1579_recIdents;
                    }
                  } else if (_source60.is_Trait) {
                    Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1580___mcc_h704 = _source60.dtor_path;
                    {
                      Dafny.ISequence<Dafny.Rune> _1581_recursiveGen;
                      bool _1582_recOwned;
                      bool _1583_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1584_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1026;
                      bool _out1027;
                      bool _out1028;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1029;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1026, out _out1027, out _out1028, out _out1029);
                      _1581_recursiveGen = _out1026;
                      _1582_recOwned = _out1027;
                      _1583_recErased = _out1028;
                      _1584_recIdents = _out1029;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1582_recOwned;
                      isErased = _1583_recErased;
                      readIdents = _1584_recIdents;
                    }
                  } else {
                    DAST._IType _1585___mcc_h706 = _source60.dtor_Newtype_a0;
                    DAST._IType _1586_b = _1585___mcc_h706;
                    {
                      if (object.Equals(_468_fromTpe, _1586_b)) {
                        Dafny.ISequence<Dafny.Rune> _1587_recursiveGen;
                        bool _1588_recOwned;
                        bool _1589_recErased;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1590_recIdents;
                        Dafny.ISequence<Dafny.Rune> _out1030;
                        bool _out1031;
                        bool _out1032;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1033;
                        DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1030, out _out1031, out _out1032, out _out1033);
                        _1587_recursiveGen = _out1030;
                        _1588_recOwned = _out1031;
                        _1589_recErased = _out1032;
                        _1590_recIdents = _out1033;
                        Dafny.ISequence<Dafny.Rune> _1591_rhsType;
                        Dafny.ISequence<Dafny.Rune> _out1034;
                        _out1034 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                        _1591_rhsType = _out1034;
                        Dafny.ISequence<Dafny.Rune> _1592_uneraseFn;
                        _1592_uneraseFn = ((_1588_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                        s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1591_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1592_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1587_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                        isOwned = _1588_recOwned;
                        isErased = false;
                        readIdents = _1590_recIdents;
                      } else {
                        Dafny.ISequence<Dafny.Rune> _out1035;
                        bool _out1036;
                        bool _out1037;
                        Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1038;
                        DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1586_b), _1586_b, _467_toTpe), @params, mustOwn, out _out1035, out _out1036, out _out1037, out _out1038);
                        s = _out1035;
                        isOwned = _out1036;
                        isErased = _out1037;
                        readIdents = _out1038;
                      }
                    }
                  }
                } else if (_source59.is_Tuple) {
                  Dafny.ISequence<DAST._IType> _1593___mcc_h708 = _source59.dtor_Tuple_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1594_recursiveGen;
                    bool _1595_recOwned;
                    bool _1596_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1597_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1039;
                    bool _out1040;
                    bool _out1041;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1042;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1039, out _out1040, out _out1041, out _out1042);
                    _1594_recursiveGen = _out1039;
                    _1595_recOwned = _out1040;
                    _1596_recErased = _out1041;
                    _1597_recIdents = _out1042;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1594_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1595_recOwned;
                    isErased = _1596_recErased;
                    readIdents = _1597_recIdents;
                  }
                } else if (_source59.is_Array) {
                  DAST._IType _1598___mcc_h710 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1599_recursiveGen;
                    bool _1600_recOwned;
                    bool _1601_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1602_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1043;
                    bool _out1044;
                    bool _out1045;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1046;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1043, out _out1044, out _out1045, out _out1046);
                    _1599_recursiveGen = _out1043;
                    _1600_recOwned = _out1044;
                    _1601_recErased = _out1045;
                    _1602_recIdents = _out1046;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1599_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1600_recOwned;
                    isErased = _1601_recErased;
                    readIdents = _1602_recIdents;
                  }
                } else if (_source59.is_Seq) {
                  DAST._IType _1603___mcc_h712 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1604_recursiveGen;
                    bool _1605_recOwned;
                    bool _1606_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1607_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1047;
                    bool _out1048;
                    bool _out1049;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1050;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1047, out _out1048, out _out1049, out _out1050);
                    _1604_recursiveGen = _out1047;
                    _1605_recOwned = _out1048;
                    _1606_recErased = _out1049;
                    _1607_recIdents = _out1050;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1604_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1605_recOwned;
                    isErased = _1606_recErased;
                    readIdents = _1607_recIdents;
                  }
                } else if (_source59.is_Set) {
                  DAST._IType _1608___mcc_h714 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1609_recursiveGen;
                    bool _1610_recOwned;
                    bool _1611_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1612_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1051;
                    bool _out1052;
                    bool _out1053;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1054;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1051, out _out1052, out _out1053, out _out1054);
                    _1609_recursiveGen = _out1051;
                    _1610_recOwned = _out1052;
                    _1611_recErased = _out1053;
                    _1612_recIdents = _out1054;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1609_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1610_recOwned;
                    isErased = _1611_recErased;
                    readIdents = _1612_recIdents;
                  }
                } else if (_source59.is_Multiset) {
                  DAST._IType _1613___mcc_h716 = _source59.dtor_element;
                  {
                    Dafny.ISequence<Dafny.Rune> _1614_recursiveGen;
                    bool _1615_recOwned;
                    bool _1616_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1617_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1055;
                    bool _out1056;
                    bool _out1057;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1058;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1055, out _out1056, out _out1057, out _out1058);
                    _1614_recursiveGen = _out1055;
                    _1615_recOwned = _out1056;
                    _1616_recErased = _out1057;
                    _1617_recIdents = _out1058;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1614_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1615_recOwned;
                    isErased = _1616_recErased;
                    readIdents = _1617_recIdents;
                  }
                } else if (_source59.is_Map) {
                  DAST._IType _1618___mcc_h718 = _source59.dtor_key;
                  DAST._IType _1619___mcc_h719 = _source59.dtor_value;
                  {
                    Dafny.ISequence<Dafny.Rune> _1620_recursiveGen;
                    bool _1621_recOwned;
                    bool _1622_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1623_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1059;
                    bool _out1060;
                    bool _out1061;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1062;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1059, out _out1060, out _out1061, out _out1062);
                    _1620_recursiveGen = _out1059;
                    _1621_recOwned = _out1060;
                    _1622_recErased = _out1061;
                    _1623_recIdents = _out1062;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1620_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1621_recOwned;
                    isErased = _1622_recErased;
                    readIdents = _1623_recIdents;
                  }
                } else if (_source59.is_Arrow) {
                  Dafny.ISequence<DAST._IType> _1624___mcc_h722 = _source59.dtor_args;
                  DAST._IType _1625___mcc_h723 = _source59.dtor_result;
                  {
                    Dafny.ISequence<Dafny.Rune> _1626_recursiveGen;
                    bool _1627_recOwned;
                    bool _1628_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1629_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1063;
                    bool _out1064;
                    bool _out1065;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1066;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1063, out _out1064, out _out1065, out _out1066);
                    _1626_recursiveGen = _out1063;
                    _1627_recOwned = _out1064;
                    _1628_recErased = _out1065;
                    _1629_recIdents = _out1066;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1626_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1627_recOwned;
                    isErased = _1628_recErased;
                    readIdents = _1629_recIdents;
                  }
                } else if (_source59.is_Primitive) {
                  DAST._IPrimitive _1630___mcc_h726 = _source59.dtor_Primitive_a0;
                  DAST._IPrimitive _source61 = _1630___mcc_h726;
                  if (_source61.is_Int) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1631_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1067;
                      _out1067 = DCOMP.COMP.GenType(_468_fromTpe, true, false);
                      _1631_rhsType = _out1067;
                      Dafny.ISequence<Dafny.Rune> _1632_recursiveGen;
                      bool _1633___v51;
                      bool _1634___v52;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1635_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1068;
                      bool _out1069;
                      bool _out1070;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1071;
                      DCOMP.COMP.GenExpr(_469_expr, @params, true, out _out1068, out _out1069, out _out1070, out _out1071);
                      _1632_recursiveGen = _out1068;
                      _1633___v51 = _out1069;
                      _1634___v52 = _out1070;
                      _1635_recIdents = _out1071;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1632_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as u32)"));
                      isOwned = true;
                      isErased = true;
                      readIdents = _1635_recIdents;
                    }
                  } else if (_source61.is_Real) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1636_recursiveGen;
                      bool _1637_recOwned;
                      bool _1638_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1639_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1072;
                      bool _out1073;
                      bool _out1074;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1075;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1072, out _out1073, out _out1074, out _out1075);
                      _1636_recursiveGen = _out1072;
                      _1637_recOwned = _out1073;
                      _1638_recErased = _out1074;
                      _1639_recIdents = _out1075;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1636_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1637_recOwned;
                      isErased = _1638_recErased;
                      readIdents = _1639_recIdents;
                    }
                  } else if (_source61.is_String) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1640_recursiveGen;
                      bool _1641_recOwned;
                      bool _1642_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1643_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1076;
                      bool _out1077;
                      bool _out1078;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1079;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1076, out _out1077, out _out1078, out _out1079);
                      _1640_recursiveGen = _out1076;
                      _1641_recOwned = _out1077;
                      _1642_recErased = _out1078;
                      _1643_recIdents = _out1079;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1640_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1641_recOwned;
                      isErased = _1642_recErased;
                      readIdents = _1643_recIdents;
                    }
                  } else if (_source61.is_Bool) {
                    {
                      Dafny.ISequence<Dafny.Rune> _1644_recursiveGen;
                      bool _1645_recOwned;
                      bool _1646_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1647_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1080;
                      bool _out1081;
                      bool _out1082;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1083;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1080, out _out1081, out _out1082, out _out1083);
                      _1644_recursiveGen = _out1080;
                      _1645_recOwned = _out1081;
                      _1646_recErased = _out1082;
                      _1647_recIdents = _out1083;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1644_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1645_recOwned;
                      isErased = _1646_recErased;
                      readIdents = _1647_recIdents;
                    }
                  } else {
                    {
                      Dafny.ISequence<Dafny.Rune> _1648_recursiveGen;
                      bool _1649_recOwned;
                      bool _1650_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1651_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1084;
                      bool _out1085;
                      bool _out1086;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1087;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1084, out _out1085, out _out1086, out _out1087);
                      _1648_recursiveGen = _out1084;
                      _1649_recOwned = _out1085;
                      _1650_recErased = _out1086;
                      _1651_recIdents = _out1087;
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1648_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                      isOwned = _1649_recOwned;
                      isErased = _1650_recErased;
                      readIdents = _1651_recIdents;
                    }
                  }
                } else if (_source59.is_Passthrough) {
                  Dafny.ISequence<Dafny.Rune> _1652___mcc_h728 = _source59.dtor_Passthrough_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1653_recursiveGen;
                    bool _1654_recOwned;
                    bool _1655_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1656_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1088;
                    bool _out1089;
                    bool _out1090;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1091;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1088, out _out1089, out _out1090, out _out1091);
                    _1653_recursiveGen = _out1088;
                    _1654_recOwned = _out1089;
                    _1655_recErased = _out1090;
                    _1656_recIdents = _out1091;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1654_recOwned;
                    isErased = _1655_recErased;
                    readIdents = _1656_recIdents;
                  }
                } else {
                  Dafny.ISequence<Dafny.Rune> _1657___mcc_h730 = _source59.dtor_TypeArg_a0;
                  {
                    Dafny.ISequence<Dafny.Rune> _1658_recursiveGen;
                    bool _1659_recOwned;
                    bool _1660_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1661_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1092;
                    bool _out1093;
                    bool _out1094;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1095;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1092, out _out1093, out _out1094, out _out1095);
                    _1658_recursiveGen = _out1092;
                    _1659_recOwned = _out1093;
                    _1660_recErased = _out1094;
                    _1661_recIdents = _out1095;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1658_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1659_recOwned;
                    isErased = _1660_recErased;
                    readIdents = _1661_recIdents;
                  }
                }
              }
            } else if (_source26.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1662___mcc_h732 = _source26.dtor_Passthrough_a0;
              DAST._IType _source62 = _475___mcc_h123;
              if (_source62.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1663___mcc_h735 = _source62.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1664___mcc_h736 = _source62.dtor_typeArgs;
                DAST._IResolvedType _1665___mcc_h737 = _source62.dtor_resolved;
                DAST._IResolvedType _source63 = _1665___mcc_h737;
                if (_source63.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1666___mcc_h741 = _source63.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1667_recursiveGen;
                    bool _1668_recOwned;
                    bool _1669_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1670_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1096;
                    bool _out1097;
                    bool _out1098;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1099;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1096, out _out1097, out _out1098, out _out1099);
                    _1667_recursiveGen = _out1096;
                    _1668_recOwned = _out1097;
                    _1669_recErased = _out1098;
                    _1670_recIdents = _out1099;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1667_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1668_recOwned;
                    isErased = _1669_recErased;
                    readIdents = _1670_recIdents;
                  }
                } else if (_source63.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1671___mcc_h743 = _source63.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1672_recursiveGen;
                    bool _1673_recOwned;
                    bool _1674_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1675_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1100;
                    bool _out1101;
                    bool _out1102;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1103;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1100, out _out1101, out _out1102, out _out1103);
                    _1672_recursiveGen = _out1100;
                    _1673_recOwned = _out1101;
                    _1674_recErased = _out1102;
                    _1675_recIdents = _out1103;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1672_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1673_recOwned;
                    isErased = _1674_recErased;
                    readIdents = _1675_recIdents;
                  }
                } else {
                  DAST._IType _1676___mcc_h745 = _source63.dtor_Newtype_a0;
                  DAST._IType _1677_b = _1676___mcc_h745;
                  {
                    if (object.Equals(_468_fromTpe, _1677_b)) {
                      Dafny.ISequence<Dafny.Rune> _1678_recursiveGen;
                      bool _1679_recOwned;
                      bool _1680_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1681_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1104;
                      bool _out1105;
                      bool _out1106;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1107;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1104, out _out1105, out _out1106, out _out1107);
                      _1678_recursiveGen = _out1104;
                      _1679_recOwned = _out1105;
                      _1680_recErased = _out1106;
                      _1681_recIdents = _out1107;
                      Dafny.ISequence<Dafny.Rune> _1682_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1108;
                      _out1108 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _1682_rhsType = _out1108;
                      Dafny.ISequence<Dafny.Rune> _1683_uneraseFn;
                      _1683_uneraseFn = ((_1679_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1682_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1683_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1678_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1679_recOwned;
                      isErased = false;
                      readIdents = _1681_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1109;
                      bool _out1110;
                      bool _out1111;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1112;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1677_b), _1677_b, _467_toTpe), @params, mustOwn, out _out1109, out _out1110, out _out1111, out _out1112);
                      s = _out1109;
                      isOwned = _out1110;
                      isErased = _out1111;
                      readIdents = _out1112;
                    }
                  }
                }
              } else if (_source62.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1684___mcc_h747 = _source62.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1685_recursiveGen;
                  bool _1686_recOwned;
                  bool _1687_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1688_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1113;
                  bool _out1114;
                  bool _out1115;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1116;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1113, out _out1114, out _out1115, out _out1116);
                  _1685_recursiveGen = _out1113;
                  _1686_recOwned = _out1114;
                  _1687_recErased = _out1115;
                  _1688_recIdents = _out1116;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1685_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1686_recOwned;
                  isErased = _1687_recErased;
                  readIdents = _1688_recIdents;
                }
              } else if (_source62.is_Array) {
                DAST._IType _1689___mcc_h749 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1690_recursiveGen;
                  bool _1691_recOwned;
                  bool _1692_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1693_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1117;
                  bool _out1118;
                  bool _out1119;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1120;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1117, out _out1118, out _out1119, out _out1120);
                  _1690_recursiveGen = _out1117;
                  _1691_recOwned = _out1118;
                  _1692_recErased = _out1119;
                  _1693_recIdents = _out1120;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1690_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1691_recOwned;
                  isErased = _1692_recErased;
                  readIdents = _1693_recIdents;
                }
              } else if (_source62.is_Seq) {
                DAST._IType _1694___mcc_h751 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1695_recursiveGen;
                  bool _1696_recOwned;
                  bool _1697_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1698_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1121;
                  bool _out1122;
                  bool _out1123;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1124;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1121, out _out1122, out _out1123, out _out1124);
                  _1695_recursiveGen = _out1121;
                  _1696_recOwned = _out1122;
                  _1697_recErased = _out1123;
                  _1698_recIdents = _out1124;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1695_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1696_recOwned;
                  isErased = _1697_recErased;
                  readIdents = _1698_recIdents;
                }
              } else if (_source62.is_Set) {
                DAST._IType _1699___mcc_h753 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1700_recursiveGen;
                  bool _1701_recOwned;
                  bool _1702_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1703_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1125;
                  bool _out1126;
                  bool _out1127;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1128;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1125, out _out1126, out _out1127, out _out1128);
                  _1700_recursiveGen = _out1125;
                  _1701_recOwned = _out1126;
                  _1702_recErased = _out1127;
                  _1703_recIdents = _out1128;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1700_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1701_recOwned;
                  isErased = _1702_recErased;
                  readIdents = _1703_recIdents;
                }
              } else if (_source62.is_Multiset) {
                DAST._IType _1704___mcc_h755 = _source62.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1705_recursiveGen;
                  bool _1706_recOwned;
                  bool _1707_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1708_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1129;
                  bool _out1130;
                  bool _out1131;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1132;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1129, out _out1130, out _out1131, out _out1132);
                  _1705_recursiveGen = _out1129;
                  _1706_recOwned = _out1130;
                  _1707_recErased = _out1131;
                  _1708_recIdents = _out1132;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1705_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1706_recOwned;
                  isErased = _1707_recErased;
                  readIdents = _1708_recIdents;
                }
              } else if (_source62.is_Map) {
                DAST._IType _1709___mcc_h757 = _source62.dtor_key;
                DAST._IType _1710___mcc_h758 = _source62.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1711_recursiveGen;
                  bool _1712_recOwned;
                  bool _1713_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1714_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1133;
                  bool _out1134;
                  bool _out1135;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1136;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1133, out _out1134, out _out1135, out _out1136);
                  _1711_recursiveGen = _out1133;
                  _1712_recOwned = _out1134;
                  _1713_recErased = _out1135;
                  _1714_recIdents = _out1136;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1711_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1712_recOwned;
                  isErased = _1713_recErased;
                  readIdents = _1714_recIdents;
                }
              } else if (_source62.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1715___mcc_h761 = _source62.dtor_args;
                DAST._IType _1716___mcc_h762 = _source62.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1717_recursiveGen;
                  bool _1718_recOwned;
                  bool _1719_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1720_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1137;
                  bool _out1138;
                  bool _out1139;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1140;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1137, out _out1138, out _out1139, out _out1140);
                  _1717_recursiveGen = _out1137;
                  _1718_recOwned = _out1138;
                  _1719_recErased = _out1139;
                  _1720_recIdents = _out1140;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1717_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1718_recOwned;
                  isErased = _1719_recErased;
                  readIdents = _1720_recIdents;
                }
              } else if (_source62.is_Primitive) {
                DAST._IPrimitive _1721___mcc_h765 = _source62.dtor_Primitive_a0;
                DAST._IPrimitive _source64 = _1721___mcc_h765;
                if (_source64.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1722_rhsType;
                    Dafny.ISequence<Dafny.Rune> _out1141;
                    _out1141 = DCOMP.COMP.GenType(_468_fromTpe, true, false);
                    _1722_rhsType = _out1141;
                    Dafny.ISequence<Dafny.Rune> _1723_recursiveGen;
                    bool _1724___v47;
                    bool _1725___v48;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1726_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1142;
                    bool _out1143;
                    bool _out1144;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1145;
                    DCOMP.COMP.GenExpr(_469_expr, @params, true, out _out1142, out _out1143, out _out1144, out _out1145);
                    _1723_recursiveGen = _out1142;
                    _1724___v47 = _out1143;
                    _1725___v48 = _out1144;
                    _1726_recIdents = _out1145;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from("), _1723_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1726_recIdents;
                  }
                } else if (_source64.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1727_recursiveGen;
                    bool _1728_recOwned;
                    bool _1729_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1730_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1146;
                    bool _out1147;
                    bool _out1148;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1149;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1146, out _out1147, out _out1148, out _out1149);
                    _1727_recursiveGen = _out1146;
                    _1728_recOwned = _out1147;
                    _1729_recErased = _out1148;
                    _1730_recIdents = _out1149;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1727_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1728_recOwned;
                    isErased = _1729_recErased;
                    readIdents = _1730_recIdents;
                  }
                } else if (_source64.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1731_recursiveGen;
                    bool _1732_recOwned;
                    bool _1733_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1734_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1150;
                    bool _out1151;
                    bool _out1152;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1153;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1150, out _out1151, out _out1152, out _out1153);
                    _1731_recursiveGen = _out1150;
                    _1732_recOwned = _out1151;
                    _1733_recErased = _out1152;
                    _1734_recIdents = _out1153;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1731_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1732_recOwned;
                    isErased = _1733_recErased;
                    readIdents = _1734_recIdents;
                  }
                } else if (_source64.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1735_recursiveGen;
                    bool _1736_recOwned;
                    bool _1737_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1738_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1154;
                    bool _out1155;
                    bool _out1156;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1157;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1154, out _out1155, out _out1156, out _out1157);
                    _1735_recursiveGen = _out1154;
                    _1736_recOwned = _out1155;
                    _1737_recErased = _out1156;
                    _1738_recIdents = _out1157;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1736_recOwned;
                    isErased = _1737_recErased;
                    readIdents = _1738_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1739_recursiveGen;
                    bool _1740_recOwned;
                    bool _1741_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1742_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1158;
                    bool _out1159;
                    bool _out1160;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1161;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1158, out _out1159, out _out1160, out _out1161);
                    _1739_recursiveGen = _out1158;
                    _1740_recOwned = _out1159;
                    _1741_recErased = _out1160;
                    _1742_recIdents = _out1161;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1739_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1740_recOwned;
                    isErased = _1741_recErased;
                    readIdents = _1742_recIdents;
                  }
                }
              } else if (_source62.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1743___mcc_h767 = _source62.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1744_recursiveGen;
                  bool _1745___v55;
                  bool _1746___v56;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1747_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1162;
                  bool _out1163;
                  bool _out1164;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1165;
                  DCOMP.COMP.GenExpr(_469_expr, @params, true, out _out1162, out _out1163, out _out1164, out _out1165);
                  _1744_recursiveGen = _out1162;
                  _1745___v55 = _out1163;
                  _1746___v56 = _out1164;
                  _1747_recIdents = _out1165;
                  Dafny.ISequence<Dafny.Rune> _1748_toTpeGen;
                  Dafny.ISequence<Dafny.Rune> _out1166;
                  _out1166 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                  _1748_toTpeGen = _out1166;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1744_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1748_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = true;
                  isErased = true;
                  readIdents = _1747_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1749___mcc_h769 = _source62.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1750_recursiveGen;
                  bool _1751_recOwned;
                  bool _1752_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1753_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1167;
                  bool _out1168;
                  bool _out1169;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1170;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1167, out _out1168, out _out1169, out _out1170);
                  _1750_recursiveGen = _out1167;
                  _1751_recOwned = _out1168;
                  _1752_recErased = _out1169;
                  _1753_recIdents = _out1170;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1750_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1751_recOwned;
                  isErased = _1752_recErased;
                  readIdents = _1753_recIdents;
                }
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1754___mcc_h771 = _source26.dtor_TypeArg_a0;
              DAST._IType _source65 = _475___mcc_h123;
              if (_source65.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1755___mcc_h774 = _source65.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1756___mcc_h775 = _source65.dtor_typeArgs;
                DAST._IResolvedType _1757___mcc_h776 = _source65.dtor_resolved;
                DAST._IResolvedType _source66 = _1757___mcc_h776;
                if (_source66.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1758___mcc_h780 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1759_recursiveGen;
                    bool _1760_recOwned;
                    bool _1761_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1762_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1171;
                    bool _out1172;
                    bool _out1173;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1174;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1171, out _out1172, out _out1173, out _out1174);
                    _1759_recursiveGen = _out1171;
                    _1760_recOwned = _out1172;
                    _1761_recErased = _out1173;
                    _1762_recIdents = _out1174;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1759_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1760_recOwned;
                    isErased = _1761_recErased;
                    readIdents = _1762_recIdents;
                  }
                } else if (_source66.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1763___mcc_h782 = _source66.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1764_recursiveGen;
                    bool _1765_recOwned;
                    bool _1766_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1767_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out1175;
                    bool _out1176;
                    bool _out1177;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1178;
                    DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1175, out _out1176, out _out1177, out _out1178);
                    _1764_recursiveGen = _out1175;
                    _1765_recOwned = _out1176;
                    _1766_recErased = _out1177;
                    _1767_recIdents = _out1178;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1764_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1765_recOwned;
                    isErased = _1766_recErased;
                    readIdents = _1767_recIdents;
                  }
                } else {
                  DAST._IType _1768___mcc_h784 = _source66.dtor_Newtype_a0;
                  DAST._IType _1769_b = _1768___mcc_h784;
                  {
                    if (object.Equals(_468_fromTpe, _1769_b)) {
                      Dafny.ISequence<Dafny.Rune> _1770_recursiveGen;
                      bool _1771_recOwned;
                      bool _1772_recErased;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1773_recIdents;
                      Dafny.ISequence<Dafny.Rune> _out1179;
                      bool _out1180;
                      bool _out1181;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1182;
                      DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1179, out _out1180, out _out1181, out _out1182);
                      _1770_recursiveGen = _out1179;
                      _1771_recOwned = _out1180;
                      _1772_recErased = _out1181;
                      _1773_recIdents = _out1182;
                      Dafny.ISequence<Dafny.Rune> _1774_rhsType;
                      Dafny.ISequence<Dafny.Rune> _out1183;
                      _out1183 = DCOMP.COMP.GenType(_467_toTpe, true, false);
                      _1774_rhsType = _out1183;
                      Dafny.ISequence<Dafny.Rune> _1775_uneraseFn;
                      _1775_uneraseFn = ((_1771_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                      s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1774_rhsType), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1775_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1770_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                      isOwned = _1771_recOwned;
                      isErased = false;
                      readIdents = _1773_recIdents;
                    } else {
                      Dafny.ISequence<Dafny.Rune> _out1184;
                      bool _out1185;
                      bool _out1186;
                      Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1187;
                      DCOMP.COMP.GenExpr(DAST.Expression.create_Convert(DAST.Expression.create_Convert(_469_expr, _468_fromTpe, _1769_b), _1769_b, _467_toTpe), @params, mustOwn, out _out1184, out _out1185, out _out1186, out _out1187);
                      s = _out1184;
                      isOwned = _out1185;
                      isErased = _out1186;
                      readIdents = _out1187;
                    }
                  }
                }
              } else if (_source65.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1776___mcc_h786 = _source65.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1777_recursiveGen;
                  bool _1778_recOwned;
                  bool _1779_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1780_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1188;
                  bool _out1189;
                  bool _out1190;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1191;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1188, out _out1189, out _out1190, out _out1191);
                  _1777_recursiveGen = _out1188;
                  _1778_recOwned = _out1189;
                  _1779_recErased = _out1190;
                  _1780_recIdents = _out1191;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1777_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1778_recOwned;
                  isErased = _1779_recErased;
                  readIdents = _1780_recIdents;
                }
              } else if (_source65.is_Array) {
                DAST._IType _1781___mcc_h788 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1782_recursiveGen;
                  bool _1783_recOwned;
                  bool _1784_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1785_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1192;
                  bool _out1193;
                  bool _out1194;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1195;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1192, out _out1193, out _out1194, out _out1195);
                  _1782_recursiveGen = _out1192;
                  _1783_recOwned = _out1193;
                  _1784_recErased = _out1194;
                  _1785_recIdents = _out1195;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1782_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1783_recOwned;
                  isErased = _1784_recErased;
                  readIdents = _1785_recIdents;
                }
              } else if (_source65.is_Seq) {
                DAST._IType _1786___mcc_h790 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1787_recursiveGen;
                  bool _1788_recOwned;
                  bool _1789_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1790_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1196;
                  bool _out1197;
                  bool _out1198;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1199;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1196, out _out1197, out _out1198, out _out1199);
                  _1787_recursiveGen = _out1196;
                  _1788_recOwned = _out1197;
                  _1789_recErased = _out1198;
                  _1790_recIdents = _out1199;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1787_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1788_recOwned;
                  isErased = _1789_recErased;
                  readIdents = _1790_recIdents;
                }
              } else if (_source65.is_Set) {
                DAST._IType _1791___mcc_h792 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1792_recursiveGen;
                  bool _1793_recOwned;
                  bool _1794_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1795_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1200;
                  bool _out1201;
                  bool _out1202;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1203;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1200, out _out1201, out _out1202, out _out1203);
                  _1792_recursiveGen = _out1200;
                  _1793_recOwned = _out1201;
                  _1794_recErased = _out1202;
                  _1795_recIdents = _out1203;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1792_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1793_recOwned;
                  isErased = _1794_recErased;
                  readIdents = _1795_recIdents;
                }
              } else if (_source65.is_Multiset) {
                DAST._IType _1796___mcc_h794 = _source65.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1797_recursiveGen;
                  bool _1798_recOwned;
                  bool _1799_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1800_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1204;
                  bool _out1205;
                  bool _out1206;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1207;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1204, out _out1205, out _out1206, out _out1207);
                  _1797_recursiveGen = _out1204;
                  _1798_recOwned = _out1205;
                  _1799_recErased = _out1206;
                  _1800_recIdents = _out1207;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1797_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1798_recOwned;
                  isErased = _1799_recErased;
                  readIdents = _1800_recIdents;
                }
              } else if (_source65.is_Map) {
                DAST._IType _1801___mcc_h796 = _source65.dtor_key;
                DAST._IType _1802___mcc_h797 = _source65.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1803_recursiveGen;
                  bool _1804_recOwned;
                  bool _1805_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1806_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1208;
                  bool _out1209;
                  bool _out1210;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1211;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1208, out _out1209, out _out1210, out _out1211);
                  _1803_recursiveGen = _out1208;
                  _1804_recOwned = _out1209;
                  _1805_recErased = _out1210;
                  _1806_recIdents = _out1211;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1803_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1804_recOwned;
                  isErased = _1805_recErased;
                  readIdents = _1806_recIdents;
                }
              } else if (_source65.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1807___mcc_h800 = _source65.dtor_args;
                DAST._IType _1808___mcc_h801 = _source65.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1809_recursiveGen;
                  bool _1810_recOwned;
                  bool _1811_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1812_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1212;
                  bool _out1213;
                  bool _out1214;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1215;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1212, out _out1213, out _out1214, out _out1215);
                  _1809_recursiveGen = _out1212;
                  _1810_recOwned = _out1213;
                  _1811_recErased = _out1214;
                  _1812_recIdents = _out1215;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1809_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1810_recOwned;
                  isErased = _1811_recErased;
                  readIdents = _1812_recIdents;
                }
              } else if (_source65.is_Primitive) {
                DAST._IPrimitive _1813___mcc_h804 = _source65.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1814_recursiveGen;
                  bool _1815_recOwned;
                  bool _1816_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1817_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1216;
                  bool _out1217;
                  bool _out1218;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1219;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1216, out _out1217, out _out1218, out _out1219);
                  _1814_recursiveGen = _out1216;
                  _1815_recOwned = _out1217;
                  _1816_recErased = _out1218;
                  _1817_recIdents = _out1219;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1814_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1815_recOwned;
                  isErased = _1816_recErased;
                  readIdents = _1817_recIdents;
                }
              } else if (_source65.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1818___mcc_h806 = _source65.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1819_recursiveGen;
                  bool _1820_recOwned;
                  bool _1821_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1822_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1220;
                  bool _out1221;
                  bool _out1222;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1223;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1220, out _out1221, out _out1222, out _out1223);
                  _1819_recursiveGen = _out1220;
                  _1820_recOwned = _out1221;
                  _1821_recErased = _out1222;
                  _1822_recIdents = _out1223;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1819_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1820_recOwned;
                  isErased = _1821_recErased;
                  readIdents = _1822_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1823___mcc_h808 = _source65.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1824_recursiveGen;
                  bool _1825_recOwned;
                  bool _1826_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1827_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out1224;
                  bool _out1225;
                  bool _out1226;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1227;
                  DCOMP.COMP.GenExpr(_469_expr, @params, mustOwn, out _out1224, out _out1225, out _out1226, out _out1227);
                  _1824_recursiveGen = _out1224;
                  _1825_recOwned = _out1225;
                  _1826_recErased = _out1226;
                  _1827_recIdents = _out1227;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1824_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1825_recOwned;
                  isErased = _1826_recErased;
                  readIdents = _1827_recIdents;
                }
              }
            }
          }
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _1828___mcc_h22 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1829_exprs = _1828___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1830_generatedValues;
          _1830_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1831_i;
          _1831_i = BigInteger.Zero;
          bool _1832_allErased;
          _1832_allErased = true;
          while ((_1831_i) < (new BigInteger((_1829_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1833_recursiveGen;
            bool _1834___v58;
            bool _1835_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1836_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1228;
            bool _out1229;
            bool _out1230;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1231;
            DCOMP.COMP.GenExpr((_1829_exprs).Select(_1831_i), @params, true, out _out1228, out _out1229, out _out1230, out _out1231);
            _1833_recursiveGen = _out1228;
            _1834___v58 = _out1229;
            _1835_isErased = _out1230;
            _1836_recIdents = _out1231;
            _1832_allErased = (_1832_allErased) && (_1835_isErased);
            _1830_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1830_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1833_recursiveGen, _1835_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1836_recIdents);
            _1831_i = (_1831_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1831_i = BigInteger.Zero;
          while ((_1831_i) < (new BigInteger((_1830_generatedValues).Count))) {
            if ((_1831_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1837_gen;
            _1837_gen = ((_1830_generatedValues).Select(_1831_i)).dtor__0;
            if ((((_1830_generatedValues).Select(_1831_i)).dtor__1) && (!(_1832_allErased))) {
              _1837_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1837_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1837_gen);
            _1831_i = (_1831_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _1832_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _1838___mcc_h23 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1839_exprs = _1838___mcc_h23;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1840_generatedValues;
          _1840_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1841_i;
          _1841_i = BigInteger.Zero;
          bool _1842_allErased;
          _1842_allErased = true;
          while ((_1841_i) < (new BigInteger((_1839_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1843_recursiveGen;
            bool _1844___v59;
            bool _1845_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1846_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1232;
            bool _out1233;
            bool _out1234;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1235;
            DCOMP.COMP.GenExpr((_1839_exprs).Select(_1841_i), @params, true, out _out1232, out _out1233, out _out1234, out _out1235);
            _1843_recursiveGen = _out1232;
            _1844___v59 = _out1233;
            _1845_isErased = _out1234;
            _1846_recIdents = _out1235;
            _1842_allErased = (_1842_allErased) && (_1845_isErased);
            _1840_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1840_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1843_recursiveGen, _1845_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1846_recIdents);
            _1841_i = (_1841_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1841_i = BigInteger.Zero;
          while ((_1841_i) < (new BigInteger((_1840_generatedValues).Count))) {
            if ((_1841_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1847_gen;
            _1847_gen = ((_1840_generatedValues).Select(_1841_i)).dtor__0;
            if ((((_1840_generatedValues).Select(_1841_i)).dtor__1) && (!(_1842_allErased))) {
              _1847_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1847_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1847_gen);
            _1841_i = (_1841_i) + (BigInteger.One);
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
        DAST._IExpression _1848___mcc_h24 = _source19.dtor_cond;
        DAST._IExpression _1849___mcc_h25 = _source19.dtor_thn;
        DAST._IExpression _1850___mcc_h26 = _source19.dtor_els;
        DAST._IExpression _1851_f = _1850___mcc_h26;
        DAST._IExpression _1852_t = _1849___mcc_h25;
        DAST._IExpression _1853_cond = _1848___mcc_h24;
        {
          Dafny.ISequence<Dafny.Rune> _1854_condString;
          bool _1855___v60;
          bool _1856_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1857_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out1236;
          bool _out1237;
          bool _out1238;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1239;
          DCOMP.COMP.GenExpr(_1853_cond, @params, true, out _out1236, out _out1237, out _out1238, out _out1239);
          _1854_condString = _out1236;
          _1855___v60 = _out1237;
          _1856_condErased = _out1238;
          _1857_recIdentsCond = _out1239;
          if (!(_1856_condErased)) {
            _1854_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1854_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1858___v61;
          bool _1859_tHasToBeOwned;
          bool _1860___v62;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1861___v63;
          Dafny.ISequence<Dafny.Rune> _out1240;
          bool _out1241;
          bool _out1242;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1243;
          DCOMP.COMP.GenExpr(_1852_t, @params, mustOwn, out _out1240, out _out1241, out _out1242, out _out1243);
          _1858___v61 = _out1240;
          _1859_tHasToBeOwned = _out1241;
          _1860___v62 = _out1242;
          _1861___v63 = _out1243;
          Dafny.ISequence<Dafny.Rune> _1862_fString;
          bool _1863_fOwned;
          bool _1864_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1865_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out1244;
          bool _out1245;
          bool _out1246;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1247;
          DCOMP.COMP.GenExpr(_1851_f, @params, _1859_tHasToBeOwned, out _out1244, out _out1245, out _out1246, out _out1247);
          _1862_fString = _out1244;
          _1863_fOwned = _out1245;
          _1864_fErased = _out1246;
          _1865_recIdentsF = _out1247;
          Dafny.ISequence<Dafny.Rune> _1866_tString;
          bool _1867___v64;
          bool _1868_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1869_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out1248;
          bool _out1249;
          bool _out1250;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1251;
          DCOMP.COMP.GenExpr(_1852_t, @params, _1863_fOwned, out _out1248, out _out1249, out _out1250, out _out1251);
          _1866_tString = _out1248;
          _1867___v64 = _out1249;
          _1868_tErased = _out1250;
          _1869_recIdentsT = _out1251;
          if ((!(_1864_fErased)) || (!(_1868_tErased))) {
            if (_1864_fErased) {
              _1862_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1862_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_1868_tErased) {
              _1866_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1866_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _1854_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1866_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _1862_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _1863_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1857_recIdentsCond, _1869_recIdentsT), _1865_recIdentsF);
          isErased = (_1864_fErased) || (_1868_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _1870___mcc_h27 = _source19.dtor_unOp;
        DAST._IExpression _1871___mcc_h28 = _source19.dtor_expr;
        DAST._IUnaryOp _source67 = _1870___mcc_h27;
        if (_source67.is_Not) {
          DAST._IExpression _1872_e = _1871___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1873_recursiveGen;
            bool _1874___v65;
            bool _1875_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1876_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1252;
            bool _out1253;
            bool _out1254;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1255;
            DCOMP.COMP.GenExpr(_1872_e, @params, true, out _out1252, out _out1253, out _out1254, out _out1255);
            _1873_recursiveGen = _out1252;
            _1874___v65 = _out1253;
            _1875_recErased = _out1254;
            _1876_recIdents = _out1255;
            if (!(_1875_recErased)) {
              _1873_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _1873_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1876_recIdents;
            isErased = true;
          }
        } else if (_source67.is_BitwiseNot) {
          DAST._IExpression _1877_e = _1871___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1878_recursiveGen;
            bool _1879___v66;
            bool _1880_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1881_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1256;
            bool _out1257;
            bool _out1258;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1259;
            DCOMP.COMP.GenExpr(_1877_e, @params, true, out _out1256, out _out1257, out _out1258, out _out1259);
            _1878_recursiveGen = _out1256;
            _1879___v66 = _out1257;
            _1880_recErased = _out1258;
            _1881_recIdents = _out1259;
            if (!(_1880_recErased)) {
              _1878_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1878_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _1878_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1881_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _1882_e = _1871___mcc_h28;
          {
            Dafny.ISequence<Dafny.Rune> _1883_recursiveGen;
            bool _1884_recOwned;
            bool _1885_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1886_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1260;
            bool _out1261;
            bool _out1262;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1263;
            DCOMP.COMP.GenExpr(_1882_e, @params, false, out _out1260, out _out1261, out _out1262, out _out1263);
            _1883_recursiveGen = _out1260;
            _1884_recOwned = _out1261;
            _1885_recErased = _out1262;
            _1886_recIdents = _out1263;
            if (!(_1885_recErased)) {
              Dafny.ISequence<Dafny.Rune> _1887_eraseFn;
              _1887_eraseFn = ((_1884_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
              _1883_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1887_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::from(("), _1883_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len())"));
            isOwned = true;
            readIdents = _1886_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _1888___mcc_h29 = _source19.dtor_op;
        DAST._IExpression _1889___mcc_h30 = _source19.dtor_left;
        DAST._IExpression _1890___mcc_h31 = _source19.dtor_right;
        DAST._IExpression _1891_r = _1890___mcc_h31;
        DAST._IExpression _1892_l = _1889___mcc_h30;
        Dafny.ISequence<Dafny.Rune> _1893_op = _1888___mcc_h29;
        {
          Dafny.ISequence<Dafny.Rune> _1894_left;
          bool _1895___v67;
          bool _1896_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1897_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1264;
          bool _out1265;
          bool _out1266;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1267;
          DCOMP.COMP.GenExpr(_1892_l, @params, true, out _out1264, out _out1265, out _out1266, out _out1267);
          _1894_left = _out1264;
          _1895___v67 = _out1265;
          _1896_leftErased = _out1266;
          _1897_recIdentsL = _out1267;
          Dafny.ISequence<Dafny.Rune> _1898_right;
          bool _1899___v68;
          bool _1900_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1901_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1268;
          bool _out1269;
          bool _out1270;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1271;
          DCOMP.COMP.GenExpr(_1891_r, @params, true, out _out1268, out _out1269, out _out1270, out _out1271);
          _1898_right = _out1268;
          _1899___v68 = _out1269;
          _1900_rightErased = _out1270;
          _1901_recIdentsR = _out1271;
          if (!(_1896_leftErased)) {
            _1894_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1894_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_1900_rightErased)) {
            _1898_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1898_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1893_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _1894_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1898_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_1893_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _1894_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1898_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1894_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1893_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1898_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1897_recIdentsL, _1901_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _1902___mcc_h32 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1903___mcc_h33 = _source19.dtor_field;
        bool _1904___mcc_h34 = _source19.dtor_isConstant;
        bool _1905___mcc_h35 = _source19.dtor_onDatatype;
        bool _1906_isDatatype = _1905___mcc_h35;
        bool _1907_isConstant = _1904___mcc_h34;
        Dafny.ISequence<Dafny.Rune> _1908_field = _1903___mcc_h33;
        DAST._IExpression _1909_on = _1902___mcc_h32;
        {
          Dafny.ISequence<Dafny.Rune> _1910_onString;
          bool _1911_onOwned;
          bool _1912_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1913_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1272;
          bool _out1273;
          bool _out1274;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1275;
          DCOMP.COMP.GenExpr(_1909_on, @params, false, out _out1272, out _out1273, out _out1274, out _out1275);
          _1910_onString = _out1272;
          _1911_onOwned = _out1273;
          _1912_onErased = _out1274;
          _1913_recIdents = _out1275;
          if (!(_1912_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1914_eraseFn;
            _1914_eraseFn = ((_1911_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1910_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1914_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1910_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1906_isDatatype) || (_1907_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1910_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1908_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_1907_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _1910_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1908_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _1913_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _1915___mcc_h36 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1916___mcc_h37 = _source19.dtor_field;
        bool _1917___mcc_h38 = _source19.dtor_onDatatype;
        bool _1918___mcc_h39 = _source19.dtor_isStatic;
        BigInteger _1919___mcc_h40 = _source19.dtor_arity;
        BigInteger _1920_arity = _1919___mcc_h40;
        bool _1921_isStatic = _1918___mcc_h39;
        bool _1922_isDatatype = _1917___mcc_h38;
        Dafny.ISequence<Dafny.Rune> _1923_field = _1916___mcc_h37;
        DAST._IExpression _1924_on = _1915___mcc_h36;
        {
          Dafny.ISequence<Dafny.Rune> _1925_onString;
          bool _1926_onOwned;
          bool _1927___v69;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1928_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1276;
          bool _out1277;
          bool _out1278;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1279;
          DCOMP.COMP.GenExpr(_1924_on, @params, false, out _out1276, out _out1277, out _out1278, out _out1279);
          _1925_onString = _out1276;
          _1926_onOwned = _out1277;
          _1927___v69 = _out1278;
          _1928_recIdents = _out1279;
          if (_1921_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1925_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _1923_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _1925_onString), ((_1926_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _1929_args;
            _1929_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _1930_i;
            _1930_i = BigInteger.Zero;
            while ((_1930_i) < (_1920_arity)) {
              if ((_1930_i).Sign == 1) {
                _1929_args = Dafny.Sequence<Dafny.Rune>.Concat(_1929_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _1929_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1929_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_1930_i));
              _1930_i = (_1930_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _1929_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _1923_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1929_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _1928_recIdents;
        }
      } else if (_source19.is_Index) {
        DAST._IExpression _1931___mcc_h41 = _source19.dtor_expr;
        DAST._IExpression _1932___mcc_h42 = _source19.dtor_idx;
        DAST._IExpression _1933_idx = _1932___mcc_h42;
        DAST._IExpression _1934_on = _1931___mcc_h41;
        {
          Dafny.ISequence<Dafny.Rune> _1935_onString;
          bool _1936_onOwned;
          bool _1937_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1938_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1280;
          bool _out1281;
          bool _out1282;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1283;
          DCOMP.COMP.GenExpr(_1934_on, @params, false, out _out1280, out _out1281, out _out1282, out _out1283);
          _1935_onString = _out1280;
          _1936_onOwned = _out1281;
          _1937_onErased = _out1282;
          _1938_recIdents = _out1283;
          if (!(_1937_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1939_eraseFn;
            _1939_eraseFn = ((_1936_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1935_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1939_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1935_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1940_idxString;
          bool _1941___v70;
          bool _1942_idxErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1943_recIdentsIdx;
          Dafny.ISequence<Dafny.Rune> _out1284;
          bool _out1285;
          bool _out1286;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1287;
          DCOMP.COMP.GenExpr(_1933_idx, @params, true, out _out1284, out _out1285, out _out1286, out _out1287);
          _1940_idxString = _out1284;
          _1941___v70 = _out1285;
          _1942_idxErased = _out1286;
          _1943_recIdentsIdx = _out1287;
          if (!(_1942_idxErased)) {
            _1940_idxString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1940_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1935_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("[<usize as ::dafny_runtime::NumCast>::from(")), _1940_idxString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()]"));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1938_recIdents, _1943_recIdentsIdx);
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _1944___mcc_h43 = _source19.dtor_expr;
        BigInteger _1945___mcc_h44 = _source19.dtor_index;
        BigInteger _1946_idx = _1945___mcc_h44;
        DAST._IExpression _1947_on = _1944___mcc_h43;
        {
          Dafny.ISequence<Dafny.Rune> _1948_onString;
          bool _1949___v71;
          bool _1950_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1951_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1288;
          bool _out1289;
          bool _out1290;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1291;
          DCOMP.COMP.GenExpr(_1947_on, @params, false, out _out1288, out _out1289, out _out1290, out _out1291);
          _1948_onString = _out1288;
          _1949___v71 = _out1289;
          _1950_tupErased = _out1290;
          _1951_recIdents = _out1291;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1948_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_1946_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _1950_tupErased;
          readIdents = _1951_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _1952___mcc_h45 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _1953___mcc_h46 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _1954___mcc_h47 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _1955___mcc_h48 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1956_args = _1955___mcc_h48;
        Dafny.ISequence<DAST._IType> _1957_typeArgs = _1954___mcc_h47;
        Dafny.ISequence<Dafny.Rune> _1958_name = _1953___mcc_h46;
        DAST._IExpression _1959_on = _1952___mcc_h45;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1960_typeArgString;
          _1960_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_1957_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _1961_typeI;
            _1961_typeI = BigInteger.Zero;
            _1960_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_1961_typeI) < (new BigInteger((_1957_typeArgs).Count))) {
              if ((_1961_typeI).Sign == 1) {
                _1960_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1960_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _1962_typeString;
              Dafny.ISequence<Dafny.Rune> _out1292;
              _out1292 = DCOMP.COMP.GenType((_1957_typeArgs).Select(_1961_typeI), false, false);
              _1962_typeString = _out1292;
              _1960_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1960_typeArgString, _1962_typeString);
              _1961_typeI = (_1961_typeI) + (BigInteger.One);
            }
            _1960_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1960_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _1963_argString;
          _1963_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1964_i;
          _1964_i = BigInteger.Zero;
          while ((_1964_i) < (new BigInteger((_1956_args).Count))) {
            if ((_1964_i).Sign == 1) {
              _1963_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1963_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1965_argExpr;
            bool _1966_isOwned;
            bool _1967_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1968_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1293;
            bool _out1294;
            bool _out1295;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1296;
            DCOMP.COMP.GenExpr((_1956_args).Select(_1964_i), @params, false, out _out1293, out _out1294, out _out1295, out _out1296);
            _1965_argExpr = _out1293;
            _1966_isOwned = _out1294;
            _1967_argErased = _out1295;
            _1968_argIdents = _out1296;
            if (_1966_isOwned) {
              _1965_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1965_argExpr);
            }
            _1963_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1963_argString, _1965_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1968_argIdents);
            _1964_i = (_1964_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1969_enclosingString;
          bool _1970___v72;
          bool _1971___v73;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1972_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1297;
          bool _out1298;
          bool _out1299;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1300;
          DCOMP.COMP.GenExpr(_1959_on, @params, false, out _out1297, out _out1298, out _out1299, out _out1300);
          _1969_enclosingString = _out1297;
          _1970___v72 = _out1298;
          _1971___v73 = _out1299;
          _1972_recIdents = _out1300;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1972_recIdents);
          DAST._IExpression _source68 = _1959_on;
          if (_source68.is_Literal) {
            DAST._ILiteral _1973___mcc_h810 = _source68.dtor_Literal_a0;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _1974___mcc_h812 = _source68.dtor_Ident_a0;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1975___mcc_h814 = _source68.dtor_Companion_a0;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_1969_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source68.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _1976___mcc_h816 = _source68.dtor_Tuple_a0;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1977___mcc_h818 = _source68.dtor_path;
            Dafny.ISequence<DAST._IExpression> _1978___mcc_h819 = _source68.dtor_args;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _1979___mcc_h822 = _source68.dtor_dims;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1980___mcc_h824 = _source68.dtor_path;
            Dafny.ISequence<Dafny.Rune> _1981___mcc_h825 = _source68.dtor_variant;
            bool _1982___mcc_h826 = _source68.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _1983___mcc_h827 = _source68.dtor_contents;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Convert) {
            DAST._IExpression _1984___mcc_h832 = _source68.dtor_value;
            DAST._IType _1985___mcc_h833 = _source68.dtor_from;
            DAST._IType _1986___mcc_h834 = _source68.dtor_typ;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _1987___mcc_h838 = _source68.dtor_elements;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _1988___mcc_h840 = _source68.dtor_elements;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_This) {
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Ite) {
            DAST._IExpression _1989___mcc_h842 = _source68.dtor_cond;
            DAST._IExpression _1990___mcc_h843 = _source68.dtor_thn;
            DAST._IExpression _1991___mcc_h844 = _source68.dtor_els;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_UnOp) {
            DAST._IUnaryOp _1992___mcc_h848 = _source68.dtor_unOp;
            DAST._IExpression _1993___mcc_h849 = _source68.dtor_expr;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _1994___mcc_h852 = _source68.dtor_op;
            DAST._IExpression _1995___mcc_h853 = _source68.dtor_left;
            DAST._IExpression _1996___mcc_h854 = _source68.dtor_right;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Select) {
            DAST._IExpression _1997___mcc_h858 = _source68.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1998___mcc_h859 = _source68.dtor_field;
            bool _1999___mcc_h860 = _source68.dtor_isConstant;
            bool _2000___mcc_h861 = _source68.dtor_onDatatype;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_SelectFn) {
            DAST._IExpression _2001___mcc_h866 = _source68.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _2002___mcc_h867 = _source68.dtor_field;
            bool _2003___mcc_h868 = _source68.dtor_onDatatype;
            bool _2004___mcc_h869 = _source68.dtor_isStatic;
            BigInteger _2005___mcc_h870 = _source68.dtor_arity;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Index) {
            DAST._IExpression _2006___mcc_h876 = _source68.dtor_expr;
            DAST._IExpression _2007___mcc_h877 = _source68.dtor_idx;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_TupleSelect) {
            DAST._IExpression _2008___mcc_h880 = _source68.dtor_expr;
            BigInteger _2009___mcc_h881 = _source68.dtor_index;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Call) {
            DAST._IExpression _2010___mcc_h884 = _source68.dtor_on;
            Dafny.ISequence<Dafny.Rune> _2011___mcc_h885 = _source68.dtor_name;
            Dafny.ISequence<DAST._IType> _2012___mcc_h886 = _source68.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _2013___mcc_h887 = _source68.dtor_args;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _2014___mcc_h892 = _source68.dtor_params;
            DAST._IType _2015___mcc_h893 = _source68.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _2016___mcc_h894 = _source68.dtor_body;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _2017___mcc_h898 = _source68.dtor_name;
            DAST._IType _2018___mcc_h899 = _source68.dtor_typ;
            DAST._IExpression _2019___mcc_h900 = _source68.dtor_value;
            DAST._IExpression _2020___mcc_h901 = _source68.dtor_iifeBody;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_Apply) {
            DAST._IExpression _2021___mcc_h906 = _source68.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _2022___mcc_h907 = _source68.dtor_args;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source68.is_TypeTest) {
            DAST._IExpression _2023___mcc_h910 = _source68.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2024___mcc_h911 = _source68.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _2025___mcc_h912 = _source68.dtor_variant;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _2026___mcc_h916 = _source68.dtor_typ;
            {
              _1969_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1969_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1969_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_1958_name)), _1960_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1963_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _2027___mcc_h49 = _source19.dtor_params;
        DAST._IType _2028___mcc_h50 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _2029___mcc_h51 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _2030_body = _2029___mcc_h51;
        DAST._IType _2031_retType = _2028___mcc_h50;
        Dafny.ISequence<DAST._IFormal> _2032_params = _2027___mcc_h49;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2033_paramNames;
          _2033_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _2034_i;
          _2034_i = BigInteger.Zero;
          while ((_2034_i) < (new BigInteger((_2032_params).Count))) {
            _2033_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_2033_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_2032_params).Select(_2034_i)).dtor_name));
            _2034_i = (_2034_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2035_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2036_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1301;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1302;
          DCOMP.COMP.GenStmts(_2030_body, _2033_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1301, out _out1302);
          _2035_recursiveGen = _out1301;
          _2036_recIdents = _out1302;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _2037_allReadCloned;
          _2037_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_2036_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _2038_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_2036_recIdents).Elements) {
              _2038_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_2036_recIdents).Contains(_2038_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1541)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_2033_paramNames).Contains(_2038_next))) {
              _2037_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2037_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _2038_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _2038_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2038_next));
            }
            _2036_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_2036_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_2038_next));
          }
          Dafny.ISequence<Dafny.Rune> _2039_paramsString;
          _2039_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _2034_i = BigInteger.Zero;
          while ((_2034_i) < (new BigInteger((_2032_params).Count))) {
            if ((_2034_i).Sign == 1) {
              _2039_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_2039_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2040_typStr;
            Dafny.ISequence<Dafny.Rune> _out1303;
            _out1303 = DCOMP.COMP.GenType(((_2032_params).Select(_2034_i)).dtor_typ, false, true);
            _2040_typStr = _out1303;
            _2039_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_2039_paramsString, ((_2032_params).Select(_2034_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _2040_typStr);
            _2034_i = (_2034_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _2041_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1304;
          _out1304 = DCOMP.COMP.GenType(_2031_retType, false, true);
          _2041_retTypeGen = _out1304;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _2037_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _2039_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _2041_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _2035_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _2042___mcc_h52 = _source19.dtor_name;
        DAST._IType _2043___mcc_h53 = _source19.dtor_typ;
        DAST._IExpression _2044___mcc_h54 = _source19.dtor_value;
        DAST._IExpression _2045___mcc_h55 = _source19.dtor_iifeBody;
        DAST._IExpression _2046_iifeBody = _2045___mcc_h55;
        DAST._IExpression _2047_value = _2044___mcc_h54;
        DAST._IType _2048_tpe = _2043___mcc_h53;
        Dafny.ISequence<Dafny.Rune> _2049_name = _2042___mcc_h52;
        {
          Dafny.ISequence<Dafny.Rune> _2050_valueGen;
          bool _2051_valueOwned;
          bool _2052_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2053_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1305;
          bool _out1306;
          bool _out1307;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1308;
          DCOMP.COMP.GenExpr(_2047_value, @params, false, out _out1305, out _out1306, out _out1307, out _out1308);
          _2050_valueGen = _out1305;
          _2051_valueOwned = _out1306;
          _2052_valueErased = _out1307;
          _2053_recIdents = _out1308;
          if (_2052_valueErased) {
            Dafny.ISequence<Dafny.Rune> _2054_eraseFn;
            _2054_eraseFn = ((_2051_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _2050_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _2054_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2050_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _2053_recIdents;
          Dafny.ISequence<Dafny.Rune> _2055_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1309;
          _out1309 = DCOMP.COMP.GenType(_2048_tpe, false, true);
          _2055_valueTypeGen = _out1309;
          Dafny.ISequence<Dafny.Rune> _2056_bodyGen;
          bool _2057_bodyOwned;
          bool _2058_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2059_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1310;
          bool _out1311;
          bool _out1312;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1313;
          DCOMP.COMP.GenExpr(_2046_iifeBody, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_2051_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_2049_name))))), mustOwn, out _out1310, out _out1311, out _out1312, out _out1313);
          _2056_bodyGen = _out1310;
          _2057_bodyOwned = _out1311;
          _2058_bodyErased = _out1312;
          _2059_bodyIdents = _out1313;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2059_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _2060_eraseFn;
          _2060_eraseFn = ((_2051_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_2049_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_2051_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _2055_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _2050_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _2056_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _2057_bodyOwned;
          isErased = _2058_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _2061___mcc_h56 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _2062___mcc_h57 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _2063_args = _2062___mcc_h57;
        DAST._IExpression _2064_func = _2061___mcc_h56;
        {
          Dafny.ISequence<Dafny.Rune> _2065_funcString;
          bool _2066___v76;
          bool _2067_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2068_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1314;
          bool _out1315;
          bool _out1316;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1317;
          DCOMP.COMP.GenExpr(_2064_func, @params, false, out _out1314, out _out1315, out _out1316, out _out1317);
          _2065_funcString = _out1314;
          _2066___v76 = _out1315;
          _2067_funcErased = _out1316;
          _2068_recIdents = _out1317;
          readIdents = _2068_recIdents;
          Dafny.ISequence<Dafny.Rune> _2069_argString;
          _2069_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _2070_i;
          _2070_i = BigInteger.Zero;
          while ((_2070_i) < (new BigInteger((_2063_args).Count))) {
            if ((_2070_i).Sign == 1) {
              _2069_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2069_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _2071_argExpr;
            bool _2072_isOwned;
            bool _2073_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2074_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1318;
            bool _out1319;
            bool _out1320;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1321;
            DCOMP.COMP.GenExpr((_2063_args).Select(_2070_i), @params, false, out _out1318, out _out1319, out _out1320, out _out1321);
            _2071_argExpr = _out1318;
            _2072_isOwned = _out1319;
            _2073_argErased = _out1320;
            _2074_argIdents = _out1321;
            if (_2072_isOwned) {
              _2071_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _2071_argExpr);
            }
            _2069_argString = Dafny.Sequence<Dafny.Rune>.Concat(_2069_argString, _2071_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _2074_argIdents);
            _2070_i = (_2070_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _2065_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _2069_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _2075___mcc_h58 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2076___mcc_h59 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _2077___mcc_h60 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _2078_variant = _2077___mcc_h60;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _2079_dType = _2076___mcc_h59;
        DAST._IExpression _2080_on = _2075___mcc_h58;
        {
          Dafny.ISequence<Dafny.Rune> _2081_exprGen;
          bool _2082___v77;
          bool _2083_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _2084_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1322;
          bool _out1323;
          bool _out1324;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1325;
          DCOMP.COMP.GenExpr(_2080_on, @params, false, out _out1322, out _out1323, out _out1324, out _out1325);
          _2081_exprGen = _out1322;
          _2082___v77 = _out1323;
          _2083_exprErased = _out1324;
          _2084_recIdents = _out1325;
          Dafny.ISequence<Dafny.Rune> _2085_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1326;
          _out1326 = DCOMP.COMP.GenPath(_2079_dType);
          _2085_dTypePath = _out1326;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _2081_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _2085_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _2078_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _2084_recIdents;
        }
      } else {
        DAST._IType _2086___mcc_h61 = _source19.dtor_typ;
        DAST._IType _2087_typ = _2086___mcc_h61;
        {
          Dafny.ISequence<Dafny.Rune> _2088_typString;
          Dafny.ISequence<Dafny.Rune> _out1327;
          _out1327 = DCOMP.COMP.GenType(_2087_typ, false, false);
          _2088_typString = _out1327;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _2088_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _2089_i;
      _2089_i = BigInteger.Zero;
      while ((_2089_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _2090_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1328;
        _out1328 = DCOMP.COMP.GenModule((p).Select(_2089_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _2090_generated = _out1328;
        if ((_2089_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _2090_generated);
        _2089_i = (_2089_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _2091_i;
      _2091_i = BigInteger.Zero;
      while ((_2091_i) < (new BigInteger((fullName).Count))) {
        if ((_2091_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_2091_i));
        _2091_i = (_2091_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

