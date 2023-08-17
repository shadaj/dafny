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
    Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a0 { get; }
    Dafny.ISequence<Dafny.Rune> dtor_DecLiteral_a1 { get; }
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
    public static _ILiteral create_IntLiteral(Dafny.ISequence<Dafny.Rune> _a0) {
      return new Literal_IntLiteral(_a0);
    }
    public static _ILiteral create_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0, Dafny.ISequence<Dafny.Rune> _a1) {
      return new Literal_DecLiteral(_a0, _a1);
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
    public Literal_IntLiteral(Dafny.ISequence<Dafny.Rune> _a0) : base() {
      this._a0 = _a0;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_IntLiteral(_a0);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_IntLiteral;
      return oth != null && object.Equals(this._a0, oth._a0);
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
      s += this._a0.ToVerbatimString(true);
      s += ")";
      return s;
    }
  }
  public class Literal_DecLiteral : Literal {
    public readonly Dafny.ISequence<Dafny.Rune> _a0;
    public readonly Dafny.ISequence<Dafny.Rune> _a1;
    public Literal_DecLiteral(Dafny.ISequence<Dafny.Rune> _a0, Dafny.ISequence<Dafny.Rune> _a1) : base() {
      this._a0 = _a0;
      this._a1 = _a1;
    }
    public override _ILiteral DowncastClone() {
      if (this is _ILiteral dt) { return dt; }
      return new Literal_DecLiteral(_a0, _a1);
    }
    public override bool Equals(object other) {
      var oth = other as DAST.Literal_DecLiteral;
      return oth != null && object.Equals(this._a0, oth._a0) && object.Equals(this._a1, oth._a1);
    }
    public override int GetHashCode() {
      ulong hash = 5381;
      hash = ((hash << 5) + hash) + 2;
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a0));
      hash = ((hash << 5) + hash) + ((ulong)Dafny.Helpers.GetHashCode(this._a1));
      return (int)hash;
    }
    public override string ToString() {
      string s = "DAST.Literal.DecLiteral";
      s += "(";
      s += this._a0.ToVerbatimString(true);
      s += ", ";
      s += this._a1.ToVerbatimString(true);
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
          Dafny.ISequence<Dafny.Rune> _358_i = _357___mcc_h2;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigInt::parse_bytes(b\""), _358_i), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_DecLiteral) {
          Dafny.ISequence<Dafny.Rune> _359___mcc_h3 = _source20.dtor_DecLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _360___mcc_h4 = _source20.dtor_DecLiteral_a1;
          Dafny.ISequence<Dafny.Rune> _361_d = _360___mcc_h4;
          Dafny.ISequence<Dafny.Rune> _362_n = _359___mcc_h3;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::new(::dafny_runtime::BigInt::parse_bytes(b\""), _362_n), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap(), ::dafny_runtime::BigInt::parse_bytes(b\"")), _361_d), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\", 10).unwrap())"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_StringLiteral) {
          Dafny.ISequence<Dafny.Rune> _363___mcc_h5 = _source20.dtor_StringLiteral_a0;
          Dafny.ISequence<Dafny.Rune> _364_l = _363___mcc_h5;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\""), _364_l), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\".chars().collect::<Vec<char>>()"));
            isOwned = true;
            isErased = true;
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          }
        } else if (_source20.is_CharLiteral) {
          Dafny.Rune _365___mcc_h6 = _source20.dtor_CharLiteral_a0;
          Dafny.Rune _366_c = _365___mcc_h6;
          {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::primitive::char::from_u32("), DCOMP.__default.natToString(new BigInteger((_366_c).Value))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").unwrap()"));
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
        Dafny.ISequence<Dafny.Rune> _367___mcc_h7 = _source19.dtor_Ident_a0;
        Dafny.ISequence<Dafny.Rune> _368_name = _367___mcc_h7;
        {
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#"), _368_name);
          if (!((@params).Contains(_368_name))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(&"), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            isOwned = false;
          }
          isErased = false;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_368_name);
        }
      } else if (_source19.is_Companion) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _369___mcc_h8 = _source19.dtor_Companion_a0;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _370_path = _369___mcc_h8;
        {
          Dafny.ISequence<Dafny.Rune> _out109;
          _out109 = DCOMP.COMP.GenPath(_370_path);
          s = _out109;
          isOwned = true;
          isErased = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
        }
      } else if (_source19.is_Tuple) {
        Dafny.ISequence<DAST._IExpression> _371___mcc_h9 = _source19.dtor_Tuple_a0;
        Dafny.ISequence<DAST._IExpression> _372_values = _371___mcc_h9;
        {
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _373_i;
          _373_i = BigInteger.Zero;
          bool _374_allErased;
          _374_allErased = true;
          while ((_373_i) < (new BigInteger((_372_values).Count))) {
            Dafny.ISequence<Dafny.Rune> _375___v23;
            bool _376___v24;
            bool _377_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _378___v25;
            Dafny.ISequence<Dafny.Rune> _out110;
            bool _out111;
            bool _out112;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out113;
            DCOMP.COMP.GenExpr((_372_values).Select(_373_i), @params, true, out _out110, out _out111, out _out112, out _out113);
            _375___v23 = _out110;
            _376___v24 = _out111;
            _377_isErased = _out112;
            _378___v25 = _out113;
            _374_allErased = (_374_allErased) && (_377_isErased);
            _373_i = (_373_i) + (BigInteger.One);
          }
          _373_i = BigInteger.Zero;
          while ((_373_i) < (new BigInteger((_372_values).Count))) {
            if ((_373_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" "));
            }
            Dafny.ISequence<Dafny.Rune> _379_recursiveGen;
            bool _380___v26;
            bool _381_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _382_recIdents;
            Dafny.ISequence<Dafny.Rune> _out114;
            bool _out115;
            bool _out116;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out117;
            DCOMP.COMP.GenExpr((_372_values).Select(_373_i), @params, true, out _out114, out _out115, out _out116, out _out117);
            _379_recursiveGen = _out114;
            _380___v26 = _out115;
            _381_isErased = _out116;
            _382_recIdents = _out117;
            if ((_381_isErased) && (!(_374_allErased))) {
              _379_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, _379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(","));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _382_recIdents);
            _373_i = (_373_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = _374_allErased;
        }
      } else if (_source19.is_New) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _383___mcc_h10 = _source19.dtor_path;
        Dafny.ISequence<DAST._IExpression> _384___mcc_h11 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _385_args = _384___mcc_h11;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _386_path = _383___mcc_h10;
        {
          Dafny.ISequence<Dafny.Rune> _387_path;
          Dafny.ISequence<Dafny.Rune> _out118;
          _out118 = DCOMP.COMP.GenPath(_386_path);
          _387_path = _out118;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _387_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::new("));
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _388_i;
          _388_i = BigInteger.Zero;
          while ((_388_i) < (new BigInteger((_385_args).Count))) {
            if ((_388_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _389_recursiveGen;
            bool _390___v27;
            bool _391_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _392_recIdents;
            Dafny.ISequence<Dafny.Rune> _out119;
            bool _out120;
            bool _out121;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out122;
            DCOMP.COMP.GenExpr((_385_args).Select(_388_i), @params, true, out _out119, out _out120, out _out121, out _out122);
            _389_recursiveGen = _out119;
            _390___v27 = _out120;
            _391_isErased = _out121;
            _392_recIdents = _out122;
            if (_391_isErased) {
              _389_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _389_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _389_recursiveGen);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _392_recIdents);
            _388_i = (_388_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_NewArray) {
        Dafny.ISequence<DAST._IExpression> _393___mcc_h12 = _source19.dtor_dims;
        Dafny.ISequence<DAST._IExpression> _394_dims = _393___mcc_h12;
        {
          BigInteger _395_i;
          _395_i = (new BigInteger((_394_dims).Count)) - (BigInteger.One);
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::default::Default::default()");
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          while ((_395_i).Sign != -1) {
            Dafny.ISequence<Dafny.Rune> _396_recursiveGen;
            bool _397___v28;
            bool _398_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _399_recIdents;
            Dafny.ISequence<Dafny.Rune> _out123;
            bool _out124;
            bool _out125;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out126;
            DCOMP.COMP.GenExpr((_394_dims).Select(_395_i), @params, true, out _out123, out _out124, out _out125, out _out126);
            _396_recursiveGen = _out123;
            _397___v28 = _out124;
            _398_isErased = _out125;
            _399_recIdents = _out126;
            if (!(_398_isErased)) {
              _396_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _396_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec!["), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("; (")), _396_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as usize]"));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _399_recIdents);
            _395_i = (_395_i) - (BigInteger.One);
          }
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_DatatypeValue) {
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _400___mcc_h13 = _source19.dtor_path;
        Dafny.ISequence<Dafny.Rune> _401___mcc_h14 = _source19.dtor_variant;
        bool _402___mcc_h15 = _source19.dtor_isCo;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _403___mcc_h16 = _source19.dtor_contents;
        Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _404_values = _403___mcc_h16;
        bool _405_isCo = _402___mcc_h15;
        Dafny.ISequence<Dafny.Rune> _406_variant = _401___mcc_h14;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _407_path = _400___mcc_h13;
        {
          Dafny.ISequence<Dafny.Rune> _408_path;
          Dafny.ISequence<Dafny.Rune> _out127;
          _out127 = DCOMP.COMP.GenPath(_407_path);
          _408_path = _out127;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::rc::Rc::new("), _408_path), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _406_variant);
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _409_i;
          _409_i = BigInteger.Zero;
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {"));
          while ((_409_i) < (new BigInteger((_404_values).Count))) {
            _System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression> _let_tmp_rhs0 = (_404_values).Select(_409_i);
            Dafny.ISequence<Dafny.Rune> _410_name = _let_tmp_rhs0.dtor__0;
            DAST._IExpression _411_value = _let_tmp_rhs0.dtor__1;
            if ((_409_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            if (_405_isCo) {
              Dafny.ISequence<Dafny.Rune> _412_recursiveGen;
              bool _413___v29;
              bool _414_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _415_recIdents;
              Dafny.ISequence<Dafny.Rune> _out128;
              bool _out129;
              bool _out130;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out131;
              DCOMP.COMP.GenExpr(_411_value, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(), true, out _out128, out _out129, out _out130, out _out131);
              _412_recursiveGen = _out128;
              _413___v29 = _out129;
              _414_isErased = _out130;
              _415_recIdents = _out131;
              if (!(_414_isErased)) {
                _412_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _412_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _412_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _412_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _415_recIdents);
              Dafny.ISequence<Dafny.Rune> _416_allReadCloned;
              _416_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
              while (!(_415_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
                Dafny.ISequence<Dafny.Rune> _417_next;
                foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_0 in (_415_recIdents).Elements) {
                  _417_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_0;
                  if ((_415_recIdents).Contains(_417_next)) {
                    goto after__ASSIGN_SUCH_THAT_0;
                  }
                }
                throw new System.Exception("assign-such-that search produced no value (line 1037)");
              after__ASSIGN_SUCH_THAT_0:;
                _416_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_416_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _417_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _417_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
                _415_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_415_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_417_next));
              }
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _410_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ::dafny_runtime::LazyFieldWrapper(::dafny_runtime::Lazy::new(::std::boxed::Box::new({\n")), _416_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move || (")), _412_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")})))"));
            } else {
              Dafny.ISequence<Dafny.Rune> _418_recursiveGen;
              bool _419___v30;
              bool _420_isErased;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _421_recIdents;
              Dafny.ISequence<Dafny.Rune> _out132;
              bool _out133;
              bool _out134;
              Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out135;
              DCOMP.COMP.GenExpr(_411_value, @params, true, out _out132, out _out133, out _out134, out _out135);
              _418_recursiveGen = _out132;
              _419___v30 = _out133;
              _420_isErased = _out134;
              _421_recIdents = _out135;
              if (!(_420_isErased)) {
                _418_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              }
              _418_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), _410_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _418_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _421_recIdents);
            }
            _409_i = (_409_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" })"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_Convert) {
        DAST._IExpression _422___mcc_h17 = _source19.dtor_value;
        DAST._IType _423___mcc_h18 = _source19.dtor_from;
        DAST._IType _424___mcc_h19 = _source19.dtor_typ;
        DAST._IType _425_toTpe = _424___mcc_h19;
        DAST._IType _426_fromTpe = _423___mcc_h18;
        DAST._IExpression _427_expr = _422___mcc_h17;
        {
          _System._ITuple2<DAST._IType, DAST._IType> _source21 = _System.Tuple2<DAST._IType, DAST._IType>.create(_426_fromTpe, _425_toTpe);
          DAST._IType _428___mcc_h59 = _source21.dtor__0;
          DAST._IType _429___mcc_h60 = _source21.dtor__1;
          DAST._IType _source22 = _428___mcc_h59;
          if (_source22.is_Path) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _430___mcc_h63 = _source22.dtor_Path_a0;
            Dafny.ISequence<DAST._IType> _431___mcc_h64 = _source22.dtor_typeArgs;
            DAST._IResolvedType _432___mcc_h65 = _source22.dtor_resolved;
            DAST._IType _source23 = _429___mcc_h60;
            if (_source23.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _433___mcc_h72 = _source23.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _434___mcc_h73 = _source23.dtor_typeArgs;
              DAST._IResolvedType _435___mcc_h74 = _source23.dtor_resolved;
              DAST._IResolvedType _source24 = _435___mcc_h74;
              if (_source24.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _436___mcc_h78 = _source24.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _437_recursiveGen;
                  bool _438_recOwned;
                  bool _439_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _440_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out136;
                  bool _out137;
                  bool _out138;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out139;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out136, out _out137, out _out138, out _out139);
                  _437_recursiveGen = _out136;
                  _438_recOwned = _out137;
                  _439_recErased = _out138;
                  _440_recIdents = _out139;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _437_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _438_recOwned;
                  isErased = _439_recErased;
                  readIdents = _440_recIdents;
                }
              } else if (_source24.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _441___mcc_h80 = _source24.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _442_recursiveGen;
                  bool _443_recOwned;
                  bool _444_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _445_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out140;
                  bool _out141;
                  bool _out142;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out143;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out140, out _out141, out _out142, out _out143);
                  _442_recursiveGen = _out140;
                  _443_recOwned = _out141;
                  _444_recErased = _out142;
                  _445_recIdents = _out143;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _442_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _443_recOwned;
                  isErased = _444_recErased;
                  readIdents = _445_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _446_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out144;
                  _out144 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _446_tpeGen = _out144;
                  Dafny.ISequence<Dafny.Rune> _447_recursiveGen;
                  bool _448_recOwned;
                  bool _449_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _450_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out145;
                  bool _out146;
                  bool _out147;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out148;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out145, out _out146, out _out147, out _out148);
                  _447_recursiveGen = _out145;
                  _448_recOwned = _out146;
                  _449_recErased = _out147;
                  _450_recIdents = _out148;
                  Dafny.ISequence<Dafny.Rune> _451_uneraseFn;
                  _451_uneraseFn = ((_448_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _446_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _451_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _447_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _448_recOwned;
                  isErased = false;
                  readIdents = _450_recIdents;
                }
              }
            } else if (_source23.is_Tuple) {
              Dafny.ISequence<DAST._IType> _452___mcc_h82 = _source23.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _453_recursiveGen;
                bool _454_recOwned;
                bool _455_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _456_recIdents;
                Dafny.ISequence<Dafny.Rune> _out149;
                bool _out150;
                bool _out151;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out152;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out149, out _out150, out _out151, out _out152);
                _453_recursiveGen = _out149;
                _454_recOwned = _out150;
                _455_recErased = _out151;
                _456_recIdents = _out152;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _453_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _454_recOwned;
                isErased = _455_recErased;
                readIdents = _456_recIdents;
              }
            } else if (_source23.is_Array) {
              DAST._IType _457___mcc_h84 = _source23.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _458_recursiveGen;
                bool _459_recOwned;
                bool _460_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _461_recIdents;
                Dafny.ISequence<Dafny.Rune> _out153;
                bool _out154;
                bool _out155;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out156;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out153, out _out154, out _out155, out _out156);
                _458_recursiveGen = _out153;
                _459_recOwned = _out154;
                _460_recErased = _out155;
                _461_recIdents = _out156;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _458_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _459_recOwned;
                isErased = _460_recErased;
                readIdents = _461_recIdents;
              }
            } else if (_source23.is_Seq) {
              DAST._IType _462___mcc_h86 = _source23.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _463_recursiveGen;
                bool _464_recOwned;
                bool _465_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _466_recIdents;
                Dafny.ISequence<Dafny.Rune> _out157;
                bool _out158;
                bool _out159;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out160;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out157, out _out158, out _out159, out _out160);
                _463_recursiveGen = _out157;
                _464_recOwned = _out158;
                _465_recErased = _out159;
                _466_recIdents = _out160;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _463_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _464_recOwned;
                isErased = _465_recErased;
                readIdents = _466_recIdents;
              }
            } else if (_source23.is_Set) {
              DAST._IType _467___mcc_h88 = _source23.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _468_recursiveGen;
                bool _469_recOwned;
                bool _470_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _471_recIdents;
                Dafny.ISequence<Dafny.Rune> _out161;
                bool _out162;
                bool _out163;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out164;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out161, out _out162, out _out163, out _out164);
                _468_recursiveGen = _out161;
                _469_recOwned = _out162;
                _470_recErased = _out163;
                _471_recIdents = _out164;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _468_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _469_recOwned;
                isErased = _470_recErased;
                readIdents = _471_recIdents;
              }
            } else if (_source23.is_Multiset) {
              DAST._IType _472___mcc_h90 = _source23.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _473_recursiveGen;
                bool _474_recOwned;
                bool _475_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _476_recIdents;
                Dafny.ISequence<Dafny.Rune> _out165;
                bool _out166;
                bool _out167;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out168;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out165, out _out166, out _out167, out _out168);
                _473_recursiveGen = _out165;
                _474_recOwned = _out166;
                _475_recErased = _out167;
                _476_recIdents = _out168;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _473_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _474_recOwned;
                isErased = _475_recErased;
                readIdents = _476_recIdents;
              }
            } else if (_source23.is_Map) {
              DAST._IType _477___mcc_h92 = _source23.dtor_key;
              DAST._IType _478___mcc_h93 = _source23.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _479_recursiveGen;
                bool _480_recOwned;
                bool _481_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _482_recIdents;
                Dafny.ISequence<Dafny.Rune> _out169;
                bool _out170;
                bool _out171;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out172;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out169, out _out170, out _out171, out _out172);
                _479_recursiveGen = _out169;
                _480_recOwned = _out170;
                _481_recErased = _out171;
                _482_recIdents = _out172;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _479_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _480_recOwned;
                isErased = _481_recErased;
                readIdents = _482_recIdents;
              }
            } else if (_source23.is_Arrow) {
              Dafny.ISequence<DAST._IType> _483___mcc_h96 = _source23.dtor_args;
              DAST._IType _484___mcc_h97 = _source23.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _485_recursiveGen;
                bool _486_recOwned;
                bool _487_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _488_recIdents;
                Dafny.ISequence<Dafny.Rune> _out173;
                bool _out174;
                bool _out175;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out176;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out173, out _out174, out _out175, out _out176);
                _485_recursiveGen = _out173;
                _486_recOwned = _out174;
                _487_recErased = _out175;
                _488_recIdents = _out176;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _485_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _486_recOwned;
                isErased = _487_recErased;
                readIdents = _488_recIdents;
              }
            } else if (_source23.is_Primitive) {
              DAST._IPrimitive _489___mcc_h100 = _source23.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _490_recursiveGen;
                bool _491_recOwned;
                bool _492_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _493_recIdents;
                Dafny.ISequence<Dafny.Rune> _out177;
                bool _out178;
                bool _out179;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out180;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out177, out _out178, out _out179, out _out180);
                _490_recursiveGen = _out177;
                _491_recOwned = _out178;
                _492_recErased = _out179;
                _493_recIdents = _out180;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _490_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _491_recOwned;
                isErased = _492_recErased;
                readIdents = _493_recIdents;
              }
            } else if (_source23.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _494___mcc_h102 = _source23.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _495_recursiveGen;
                bool _496_recOwned;
                bool _497_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _498_recIdents;
                Dafny.ISequence<Dafny.Rune> _out181;
                bool _out182;
                bool _out183;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out184;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out181, out _out182, out _out183, out _out184);
                _495_recursiveGen = _out181;
                _496_recOwned = _out182;
                _497_recErased = _out183;
                _498_recIdents = _out184;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _495_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _496_recOwned;
                isErased = _497_recErased;
                readIdents = _498_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _499___mcc_h104 = _source23.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _500_recursiveGen;
                bool _501_recOwned;
                bool _502_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _503_recIdents;
                Dafny.ISequence<Dafny.Rune> _out185;
                bool _out186;
                bool _out187;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out188;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out185, out _out186, out _out187, out _out188);
                _500_recursiveGen = _out185;
                _501_recOwned = _out186;
                _502_recErased = _out187;
                _503_recIdents = _out188;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _500_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _501_recOwned;
                isErased = _502_recErased;
                readIdents = _503_recIdents;
              }
            }
          } else if (_source22.is_Tuple) {
            Dafny.ISequence<DAST._IType> _504___mcc_h106 = _source22.dtor_Tuple_a0;
            DAST._IType _source25 = _429___mcc_h60;
            if (_source25.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _505___mcc_h109 = _source25.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _506___mcc_h110 = _source25.dtor_typeArgs;
              DAST._IResolvedType _507___mcc_h111 = _source25.dtor_resolved;
              DAST._IResolvedType _source26 = _507___mcc_h111;
              if (_source26.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _508___mcc_h115 = _source26.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _509_recursiveGen;
                  bool _510_recOwned;
                  bool _511_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _512_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out189;
                  bool _out190;
                  bool _out191;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out192;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out189, out _out190, out _out191, out _out192);
                  _509_recursiveGen = _out189;
                  _510_recOwned = _out190;
                  _511_recErased = _out191;
                  _512_recIdents = _out192;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _509_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _510_recOwned;
                  isErased = _511_recErased;
                  readIdents = _512_recIdents;
                }
              } else if (_source26.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _513___mcc_h117 = _source26.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _514_recursiveGen;
                  bool _515_recOwned;
                  bool _516_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _517_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out193;
                  bool _out194;
                  bool _out195;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out196;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out193, out _out194, out _out195, out _out196);
                  _514_recursiveGen = _out193;
                  _515_recOwned = _out194;
                  _516_recErased = _out195;
                  _517_recIdents = _out196;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _514_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _515_recOwned;
                  isErased = _516_recErased;
                  readIdents = _517_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _518_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out197;
                  _out197 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _518_tpeGen = _out197;
                  Dafny.ISequence<Dafny.Rune> _519_recursiveGen;
                  bool _520_recOwned;
                  bool _521_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _522_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out198;
                  bool _out199;
                  bool _out200;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out201;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out198, out _out199, out _out200, out _out201);
                  _519_recursiveGen = _out198;
                  _520_recOwned = _out199;
                  _521_recErased = _out200;
                  _522_recIdents = _out201;
                  Dafny.ISequence<Dafny.Rune> _523_uneraseFn;
                  _523_uneraseFn = ((_520_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _518_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _523_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _519_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _520_recOwned;
                  isErased = false;
                  readIdents = _522_recIdents;
                }
              }
            } else if (_source25.is_Tuple) {
              Dafny.ISequence<DAST._IType> _524___mcc_h119 = _source25.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _525_recursiveGen;
                bool _526_recOwned;
                bool _527_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _528_recIdents;
                Dafny.ISequence<Dafny.Rune> _out202;
                bool _out203;
                bool _out204;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out205;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out202, out _out203, out _out204, out _out205);
                _525_recursiveGen = _out202;
                _526_recOwned = _out203;
                _527_recErased = _out204;
                _528_recIdents = _out205;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _525_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _526_recOwned;
                isErased = _527_recErased;
                readIdents = _528_recIdents;
              }
            } else if (_source25.is_Array) {
              DAST._IType _529___mcc_h121 = _source25.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _530_recursiveGen;
                bool _531_recOwned;
                bool _532_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _533_recIdents;
                Dafny.ISequence<Dafny.Rune> _out206;
                bool _out207;
                bool _out208;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out209;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out206, out _out207, out _out208, out _out209);
                _530_recursiveGen = _out206;
                _531_recOwned = _out207;
                _532_recErased = _out208;
                _533_recIdents = _out209;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _530_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _531_recOwned;
                isErased = _532_recErased;
                readIdents = _533_recIdents;
              }
            } else if (_source25.is_Seq) {
              DAST._IType _534___mcc_h123 = _source25.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _535_recursiveGen;
                bool _536_recOwned;
                bool _537_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _538_recIdents;
                Dafny.ISequence<Dafny.Rune> _out210;
                bool _out211;
                bool _out212;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out213;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out210, out _out211, out _out212, out _out213);
                _535_recursiveGen = _out210;
                _536_recOwned = _out211;
                _537_recErased = _out212;
                _538_recIdents = _out213;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _535_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _536_recOwned;
                isErased = _537_recErased;
                readIdents = _538_recIdents;
              }
            } else if (_source25.is_Set) {
              DAST._IType _539___mcc_h125 = _source25.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _540_recursiveGen;
                bool _541_recOwned;
                bool _542_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _543_recIdents;
                Dafny.ISequence<Dafny.Rune> _out214;
                bool _out215;
                bool _out216;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out217;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out214, out _out215, out _out216, out _out217);
                _540_recursiveGen = _out214;
                _541_recOwned = _out215;
                _542_recErased = _out216;
                _543_recIdents = _out217;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _540_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _541_recOwned;
                isErased = _542_recErased;
                readIdents = _543_recIdents;
              }
            } else if (_source25.is_Multiset) {
              DAST._IType _544___mcc_h127 = _source25.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _545_recursiveGen;
                bool _546_recOwned;
                bool _547_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _548_recIdents;
                Dafny.ISequence<Dafny.Rune> _out218;
                bool _out219;
                bool _out220;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out221;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out218, out _out219, out _out220, out _out221);
                _545_recursiveGen = _out218;
                _546_recOwned = _out219;
                _547_recErased = _out220;
                _548_recIdents = _out221;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _545_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _546_recOwned;
                isErased = _547_recErased;
                readIdents = _548_recIdents;
              }
            } else if (_source25.is_Map) {
              DAST._IType _549___mcc_h129 = _source25.dtor_key;
              DAST._IType _550___mcc_h130 = _source25.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _551_recursiveGen;
                bool _552_recOwned;
                bool _553_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _554_recIdents;
                Dafny.ISequence<Dafny.Rune> _out222;
                bool _out223;
                bool _out224;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out225;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out222, out _out223, out _out224, out _out225);
                _551_recursiveGen = _out222;
                _552_recOwned = _out223;
                _553_recErased = _out224;
                _554_recIdents = _out225;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _551_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _552_recOwned;
                isErased = _553_recErased;
                readIdents = _554_recIdents;
              }
            } else if (_source25.is_Arrow) {
              Dafny.ISequence<DAST._IType> _555___mcc_h133 = _source25.dtor_args;
              DAST._IType _556___mcc_h134 = _source25.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _557_recursiveGen;
                bool _558_recOwned;
                bool _559_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _560_recIdents;
                Dafny.ISequence<Dafny.Rune> _out226;
                bool _out227;
                bool _out228;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out229;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out226, out _out227, out _out228, out _out229);
                _557_recursiveGen = _out226;
                _558_recOwned = _out227;
                _559_recErased = _out228;
                _560_recIdents = _out229;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _557_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _558_recOwned;
                isErased = _559_recErased;
                readIdents = _560_recIdents;
              }
            } else if (_source25.is_Primitive) {
              DAST._IPrimitive _561___mcc_h137 = _source25.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _562_recursiveGen;
                bool _563_recOwned;
                bool _564_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _565_recIdents;
                Dafny.ISequence<Dafny.Rune> _out230;
                bool _out231;
                bool _out232;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out233;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out230, out _out231, out _out232, out _out233);
                _562_recursiveGen = _out230;
                _563_recOwned = _out231;
                _564_recErased = _out232;
                _565_recIdents = _out233;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _562_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _563_recOwned;
                isErased = _564_recErased;
                readIdents = _565_recIdents;
              }
            } else if (_source25.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _566___mcc_h139 = _source25.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _567_recursiveGen;
                bool _568_recOwned;
                bool _569_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _570_recIdents;
                Dafny.ISequence<Dafny.Rune> _out234;
                bool _out235;
                bool _out236;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out237;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out234, out _out235, out _out236, out _out237);
                _567_recursiveGen = _out234;
                _568_recOwned = _out235;
                _569_recErased = _out236;
                _570_recIdents = _out237;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _567_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _568_recOwned;
                isErased = _569_recErased;
                readIdents = _570_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _571___mcc_h141 = _source25.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _572_recursiveGen;
                bool _573_recOwned;
                bool _574_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _575_recIdents;
                Dafny.ISequence<Dafny.Rune> _out238;
                bool _out239;
                bool _out240;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out241;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out238, out _out239, out _out240, out _out241);
                _572_recursiveGen = _out238;
                _573_recOwned = _out239;
                _574_recErased = _out240;
                _575_recIdents = _out241;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _572_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _573_recOwned;
                isErased = _574_recErased;
                readIdents = _575_recIdents;
              }
            }
          } else if (_source22.is_Array) {
            DAST._IType _576___mcc_h143 = _source22.dtor_element;
            DAST._IType _source27 = _429___mcc_h60;
            if (_source27.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _577___mcc_h146 = _source27.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _578___mcc_h147 = _source27.dtor_typeArgs;
              DAST._IResolvedType _579___mcc_h148 = _source27.dtor_resolved;
              DAST._IResolvedType _source28 = _579___mcc_h148;
              if (_source28.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _580___mcc_h152 = _source28.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _581_recursiveGen;
                  bool _582_recOwned;
                  bool _583_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _584_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out242;
                  bool _out243;
                  bool _out244;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out245;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out242, out _out243, out _out244, out _out245);
                  _581_recursiveGen = _out242;
                  _582_recOwned = _out243;
                  _583_recErased = _out244;
                  _584_recIdents = _out245;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _581_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _582_recOwned;
                  isErased = _583_recErased;
                  readIdents = _584_recIdents;
                }
              } else if (_source28.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _585___mcc_h154 = _source28.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _586_recursiveGen;
                  bool _587_recOwned;
                  bool _588_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _589_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out246;
                  bool _out247;
                  bool _out248;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out249;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out246, out _out247, out _out248, out _out249);
                  _586_recursiveGen = _out246;
                  _587_recOwned = _out247;
                  _588_recErased = _out248;
                  _589_recIdents = _out249;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _586_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _587_recOwned;
                  isErased = _588_recErased;
                  readIdents = _589_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _590_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out250;
                  _out250 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _590_tpeGen = _out250;
                  Dafny.ISequence<Dafny.Rune> _591_recursiveGen;
                  bool _592_recOwned;
                  bool _593_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _594_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out251;
                  bool _out252;
                  bool _out253;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out254;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out251, out _out252, out _out253, out _out254);
                  _591_recursiveGen = _out251;
                  _592_recOwned = _out252;
                  _593_recErased = _out253;
                  _594_recIdents = _out254;
                  Dafny.ISequence<Dafny.Rune> _595_uneraseFn;
                  _595_uneraseFn = ((_592_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _590_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _595_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _591_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _592_recOwned;
                  isErased = false;
                  readIdents = _594_recIdents;
                }
              }
            } else if (_source27.is_Tuple) {
              Dafny.ISequence<DAST._IType> _596___mcc_h156 = _source27.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _597_recursiveGen;
                bool _598_recOwned;
                bool _599_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _600_recIdents;
                Dafny.ISequence<Dafny.Rune> _out255;
                bool _out256;
                bool _out257;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out258;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out255, out _out256, out _out257, out _out258);
                _597_recursiveGen = _out255;
                _598_recOwned = _out256;
                _599_recErased = _out257;
                _600_recIdents = _out258;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _597_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _598_recOwned;
                isErased = _599_recErased;
                readIdents = _600_recIdents;
              }
            } else if (_source27.is_Array) {
              DAST._IType _601___mcc_h158 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _602_recursiveGen;
                bool _603_recOwned;
                bool _604_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _605_recIdents;
                Dafny.ISequence<Dafny.Rune> _out259;
                bool _out260;
                bool _out261;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out262;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out259, out _out260, out _out261, out _out262);
                _602_recursiveGen = _out259;
                _603_recOwned = _out260;
                _604_recErased = _out261;
                _605_recIdents = _out262;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _602_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _603_recOwned;
                isErased = _604_recErased;
                readIdents = _605_recIdents;
              }
            } else if (_source27.is_Seq) {
              DAST._IType _606___mcc_h160 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _607_recursiveGen;
                bool _608_recOwned;
                bool _609_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _610_recIdents;
                Dafny.ISequence<Dafny.Rune> _out263;
                bool _out264;
                bool _out265;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out266;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out263, out _out264, out _out265, out _out266);
                _607_recursiveGen = _out263;
                _608_recOwned = _out264;
                _609_recErased = _out265;
                _610_recIdents = _out266;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _607_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _608_recOwned;
                isErased = _609_recErased;
                readIdents = _610_recIdents;
              }
            } else if (_source27.is_Set) {
              DAST._IType _611___mcc_h162 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _612_recursiveGen;
                bool _613_recOwned;
                bool _614_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _615_recIdents;
                Dafny.ISequence<Dafny.Rune> _out267;
                bool _out268;
                bool _out269;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out270;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out267, out _out268, out _out269, out _out270);
                _612_recursiveGen = _out267;
                _613_recOwned = _out268;
                _614_recErased = _out269;
                _615_recIdents = _out270;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _612_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _613_recOwned;
                isErased = _614_recErased;
                readIdents = _615_recIdents;
              }
            } else if (_source27.is_Multiset) {
              DAST._IType _616___mcc_h164 = _source27.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _617_recursiveGen;
                bool _618_recOwned;
                bool _619_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _620_recIdents;
                Dafny.ISequence<Dafny.Rune> _out271;
                bool _out272;
                bool _out273;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out274;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out271, out _out272, out _out273, out _out274);
                _617_recursiveGen = _out271;
                _618_recOwned = _out272;
                _619_recErased = _out273;
                _620_recIdents = _out274;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _617_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _618_recOwned;
                isErased = _619_recErased;
                readIdents = _620_recIdents;
              }
            } else if (_source27.is_Map) {
              DAST._IType _621___mcc_h166 = _source27.dtor_key;
              DAST._IType _622___mcc_h167 = _source27.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _623_recursiveGen;
                bool _624_recOwned;
                bool _625_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _626_recIdents;
                Dafny.ISequence<Dafny.Rune> _out275;
                bool _out276;
                bool _out277;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out278;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out275, out _out276, out _out277, out _out278);
                _623_recursiveGen = _out275;
                _624_recOwned = _out276;
                _625_recErased = _out277;
                _626_recIdents = _out278;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _623_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _624_recOwned;
                isErased = _625_recErased;
                readIdents = _626_recIdents;
              }
            } else if (_source27.is_Arrow) {
              Dafny.ISequence<DAST._IType> _627___mcc_h170 = _source27.dtor_args;
              DAST._IType _628___mcc_h171 = _source27.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _629_recursiveGen;
                bool _630_recOwned;
                bool _631_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _632_recIdents;
                Dafny.ISequence<Dafny.Rune> _out279;
                bool _out280;
                bool _out281;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out282;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out279, out _out280, out _out281, out _out282);
                _629_recursiveGen = _out279;
                _630_recOwned = _out280;
                _631_recErased = _out281;
                _632_recIdents = _out282;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _629_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _630_recOwned;
                isErased = _631_recErased;
                readIdents = _632_recIdents;
              }
            } else if (_source27.is_Primitive) {
              DAST._IPrimitive _633___mcc_h174 = _source27.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _634_recursiveGen;
                bool _635_recOwned;
                bool _636_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _637_recIdents;
                Dafny.ISequence<Dafny.Rune> _out283;
                bool _out284;
                bool _out285;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out286;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out283, out _out284, out _out285, out _out286);
                _634_recursiveGen = _out283;
                _635_recOwned = _out284;
                _636_recErased = _out285;
                _637_recIdents = _out286;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _634_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _635_recOwned;
                isErased = _636_recErased;
                readIdents = _637_recIdents;
              }
            } else if (_source27.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _638___mcc_h176 = _source27.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _639_recursiveGen;
                bool _640_recOwned;
                bool _641_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _642_recIdents;
                Dafny.ISequence<Dafny.Rune> _out287;
                bool _out288;
                bool _out289;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out290;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out287, out _out288, out _out289, out _out290);
                _639_recursiveGen = _out287;
                _640_recOwned = _out288;
                _641_recErased = _out289;
                _642_recIdents = _out290;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _639_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _640_recOwned;
                isErased = _641_recErased;
                readIdents = _642_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _643___mcc_h178 = _source27.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _644_recursiveGen;
                bool _645_recOwned;
                bool _646_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _647_recIdents;
                Dafny.ISequence<Dafny.Rune> _out291;
                bool _out292;
                bool _out293;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out294;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out291, out _out292, out _out293, out _out294);
                _644_recursiveGen = _out291;
                _645_recOwned = _out292;
                _646_recErased = _out293;
                _647_recIdents = _out294;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _644_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _645_recOwned;
                isErased = _646_recErased;
                readIdents = _647_recIdents;
              }
            }
          } else if (_source22.is_Seq) {
            DAST._IType _648___mcc_h180 = _source22.dtor_element;
            DAST._IType _source29 = _429___mcc_h60;
            if (_source29.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _649___mcc_h183 = _source29.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _650___mcc_h184 = _source29.dtor_typeArgs;
              DAST._IResolvedType _651___mcc_h185 = _source29.dtor_resolved;
              DAST._IResolvedType _source30 = _651___mcc_h185;
              if (_source30.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _652___mcc_h189 = _source30.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _653_recursiveGen;
                  bool _654_recOwned;
                  bool _655_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _656_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out295;
                  bool _out296;
                  bool _out297;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out298;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out295, out _out296, out _out297, out _out298);
                  _653_recursiveGen = _out295;
                  _654_recOwned = _out296;
                  _655_recErased = _out297;
                  _656_recIdents = _out298;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _653_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _654_recOwned;
                  isErased = _655_recErased;
                  readIdents = _656_recIdents;
                }
              } else if (_source30.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _657___mcc_h191 = _source30.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _658_recursiveGen;
                  bool _659_recOwned;
                  bool _660_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _661_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out299;
                  bool _out300;
                  bool _out301;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out302;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out299, out _out300, out _out301, out _out302);
                  _658_recursiveGen = _out299;
                  _659_recOwned = _out300;
                  _660_recErased = _out301;
                  _661_recIdents = _out302;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _658_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _659_recOwned;
                  isErased = _660_recErased;
                  readIdents = _661_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _662_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out303;
                  _out303 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _662_tpeGen = _out303;
                  Dafny.ISequence<Dafny.Rune> _663_recursiveGen;
                  bool _664_recOwned;
                  bool _665_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _666_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out304;
                  bool _out305;
                  bool _out306;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out307;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out304, out _out305, out _out306, out _out307);
                  _663_recursiveGen = _out304;
                  _664_recOwned = _out305;
                  _665_recErased = _out306;
                  _666_recIdents = _out307;
                  Dafny.ISequence<Dafny.Rune> _667_uneraseFn;
                  _667_uneraseFn = ((_664_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _662_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _667_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _663_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _664_recOwned;
                  isErased = false;
                  readIdents = _666_recIdents;
                }
              }
            } else if (_source29.is_Tuple) {
              Dafny.ISequence<DAST._IType> _668___mcc_h193 = _source29.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _669_recursiveGen;
                bool _670_recOwned;
                bool _671_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _672_recIdents;
                Dafny.ISequence<Dafny.Rune> _out308;
                bool _out309;
                bool _out310;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out311;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out308, out _out309, out _out310, out _out311);
                _669_recursiveGen = _out308;
                _670_recOwned = _out309;
                _671_recErased = _out310;
                _672_recIdents = _out311;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _669_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _670_recOwned;
                isErased = _671_recErased;
                readIdents = _672_recIdents;
              }
            } else if (_source29.is_Array) {
              DAST._IType _673___mcc_h195 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _674_recursiveGen;
                bool _675_recOwned;
                bool _676_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _677_recIdents;
                Dafny.ISequence<Dafny.Rune> _out312;
                bool _out313;
                bool _out314;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out315;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out312, out _out313, out _out314, out _out315);
                _674_recursiveGen = _out312;
                _675_recOwned = _out313;
                _676_recErased = _out314;
                _677_recIdents = _out315;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _674_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _675_recOwned;
                isErased = _676_recErased;
                readIdents = _677_recIdents;
              }
            } else if (_source29.is_Seq) {
              DAST._IType _678___mcc_h197 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _679_recursiveGen;
                bool _680_recOwned;
                bool _681_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _682_recIdents;
                Dafny.ISequence<Dafny.Rune> _out316;
                bool _out317;
                bool _out318;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out319;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out316, out _out317, out _out318, out _out319);
                _679_recursiveGen = _out316;
                _680_recOwned = _out317;
                _681_recErased = _out318;
                _682_recIdents = _out319;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _679_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _680_recOwned;
                isErased = _681_recErased;
                readIdents = _682_recIdents;
              }
            } else if (_source29.is_Set) {
              DAST._IType _683___mcc_h199 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _684_recursiveGen;
                bool _685_recOwned;
                bool _686_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _687_recIdents;
                Dafny.ISequence<Dafny.Rune> _out320;
                bool _out321;
                bool _out322;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out323;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out320, out _out321, out _out322, out _out323);
                _684_recursiveGen = _out320;
                _685_recOwned = _out321;
                _686_recErased = _out322;
                _687_recIdents = _out323;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _684_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _685_recOwned;
                isErased = _686_recErased;
                readIdents = _687_recIdents;
              }
            } else if (_source29.is_Multiset) {
              DAST._IType _688___mcc_h201 = _source29.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _689_recursiveGen;
                bool _690_recOwned;
                bool _691_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _692_recIdents;
                Dafny.ISequence<Dafny.Rune> _out324;
                bool _out325;
                bool _out326;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out327;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out324, out _out325, out _out326, out _out327);
                _689_recursiveGen = _out324;
                _690_recOwned = _out325;
                _691_recErased = _out326;
                _692_recIdents = _out327;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _689_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _690_recOwned;
                isErased = _691_recErased;
                readIdents = _692_recIdents;
              }
            } else if (_source29.is_Map) {
              DAST._IType _693___mcc_h203 = _source29.dtor_key;
              DAST._IType _694___mcc_h204 = _source29.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _695_recursiveGen;
                bool _696_recOwned;
                bool _697_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _698_recIdents;
                Dafny.ISequence<Dafny.Rune> _out328;
                bool _out329;
                bool _out330;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out331;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out328, out _out329, out _out330, out _out331);
                _695_recursiveGen = _out328;
                _696_recOwned = _out329;
                _697_recErased = _out330;
                _698_recIdents = _out331;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _695_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _696_recOwned;
                isErased = _697_recErased;
                readIdents = _698_recIdents;
              }
            } else if (_source29.is_Arrow) {
              Dafny.ISequence<DAST._IType> _699___mcc_h207 = _source29.dtor_args;
              DAST._IType _700___mcc_h208 = _source29.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _701_recursiveGen;
                bool _702_recOwned;
                bool _703_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _704_recIdents;
                Dafny.ISequence<Dafny.Rune> _out332;
                bool _out333;
                bool _out334;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out335;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out332, out _out333, out _out334, out _out335);
                _701_recursiveGen = _out332;
                _702_recOwned = _out333;
                _703_recErased = _out334;
                _704_recIdents = _out335;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _701_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _702_recOwned;
                isErased = _703_recErased;
                readIdents = _704_recIdents;
              }
            } else if (_source29.is_Primitive) {
              DAST._IPrimitive _705___mcc_h211 = _source29.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _706_recursiveGen;
                bool _707_recOwned;
                bool _708_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _709_recIdents;
                Dafny.ISequence<Dafny.Rune> _out336;
                bool _out337;
                bool _out338;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out339;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out336, out _out337, out _out338, out _out339);
                _706_recursiveGen = _out336;
                _707_recOwned = _out337;
                _708_recErased = _out338;
                _709_recIdents = _out339;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _706_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _707_recOwned;
                isErased = _708_recErased;
                readIdents = _709_recIdents;
              }
            } else if (_source29.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _710___mcc_h213 = _source29.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _711_recursiveGen;
                bool _712_recOwned;
                bool _713_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _714_recIdents;
                Dafny.ISequence<Dafny.Rune> _out340;
                bool _out341;
                bool _out342;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out343;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out340, out _out341, out _out342, out _out343);
                _711_recursiveGen = _out340;
                _712_recOwned = _out341;
                _713_recErased = _out342;
                _714_recIdents = _out343;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _711_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _712_recOwned;
                isErased = _713_recErased;
                readIdents = _714_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _715___mcc_h215 = _source29.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _716_recursiveGen;
                bool _717_recOwned;
                bool _718_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _719_recIdents;
                Dafny.ISequence<Dafny.Rune> _out344;
                bool _out345;
                bool _out346;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out347;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out344, out _out345, out _out346, out _out347);
                _716_recursiveGen = _out344;
                _717_recOwned = _out345;
                _718_recErased = _out346;
                _719_recIdents = _out347;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _716_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _717_recOwned;
                isErased = _718_recErased;
                readIdents = _719_recIdents;
              }
            }
          } else if (_source22.is_Set) {
            DAST._IType _720___mcc_h217 = _source22.dtor_element;
            DAST._IType _source31 = _429___mcc_h60;
            if (_source31.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _721___mcc_h220 = _source31.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _722___mcc_h221 = _source31.dtor_typeArgs;
              DAST._IResolvedType _723___mcc_h222 = _source31.dtor_resolved;
              DAST._IResolvedType _source32 = _723___mcc_h222;
              if (_source32.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _724___mcc_h226 = _source32.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _725_recursiveGen;
                  bool _726_recOwned;
                  bool _727_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _728_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out348;
                  bool _out349;
                  bool _out350;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out351;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out348, out _out349, out _out350, out _out351);
                  _725_recursiveGen = _out348;
                  _726_recOwned = _out349;
                  _727_recErased = _out350;
                  _728_recIdents = _out351;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _725_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _726_recOwned;
                  isErased = _727_recErased;
                  readIdents = _728_recIdents;
                }
              } else if (_source32.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _729___mcc_h228 = _source32.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _730_recursiveGen;
                  bool _731_recOwned;
                  bool _732_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _733_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out352;
                  bool _out353;
                  bool _out354;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out355;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out352, out _out353, out _out354, out _out355);
                  _730_recursiveGen = _out352;
                  _731_recOwned = _out353;
                  _732_recErased = _out354;
                  _733_recIdents = _out355;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _730_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _731_recOwned;
                  isErased = _732_recErased;
                  readIdents = _733_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _734_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out356;
                  _out356 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _734_tpeGen = _out356;
                  Dafny.ISequence<Dafny.Rune> _735_recursiveGen;
                  bool _736_recOwned;
                  bool _737_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _738_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out357;
                  bool _out358;
                  bool _out359;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out360;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out357, out _out358, out _out359, out _out360);
                  _735_recursiveGen = _out357;
                  _736_recOwned = _out358;
                  _737_recErased = _out359;
                  _738_recIdents = _out360;
                  Dafny.ISequence<Dafny.Rune> _739_uneraseFn;
                  _739_uneraseFn = ((_736_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _734_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _739_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _735_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _736_recOwned;
                  isErased = false;
                  readIdents = _738_recIdents;
                }
              }
            } else if (_source31.is_Tuple) {
              Dafny.ISequence<DAST._IType> _740___mcc_h230 = _source31.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _741_recursiveGen;
                bool _742_recOwned;
                bool _743_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _744_recIdents;
                Dafny.ISequence<Dafny.Rune> _out361;
                bool _out362;
                bool _out363;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out364;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out361, out _out362, out _out363, out _out364);
                _741_recursiveGen = _out361;
                _742_recOwned = _out362;
                _743_recErased = _out363;
                _744_recIdents = _out364;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _741_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _742_recOwned;
                isErased = _743_recErased;
                readIdents = _744_recIdents;
              }
            } else if (_source31.is_Array) {
              DAST._IType _745___mcc_h232 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _746_recursiveGen;
                bool _747_recOwned;
                bool _748_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _749_recIdents;
                Dafny.ISequence<Dafny.Rune> _out365;
                bool _out366;
                bool _out367;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out368;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out365, out _out366, out _out367, out _out368);
                _746_recursiveGen = _out365;
                _747_recOwned = _out366;
                _748_recErased = _out367;
                _749_recIdents = _out368;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _746_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _747_recOwned;
                isErased = _748_recErased;
                readIdents = _749_recIdents;
              }
            } else if (_source31.is_Seq) {
              DAST._IType _750___mcc_h234 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _751_recursiveGen;
                bool _752_recOwned;
                bool _753_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _754_recIdents;
                Dafny.ISequence<Dafny.Rune> _out369;
                bool _out370;
                bool _out371;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out372;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out369, out _out370, out _out371, out _out372);
                _751_recursiveGen = _out369;
                _752_recOwned = _out370;
                _753_recErased = _out371;
                _754_recIdents = _out372;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _751_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _752_recOwned;
                isErased = _753_recErased;
                readIdents = _754_recIdents;
              }
            } else if (_source31.is_Set) {
              DAST._IType _755___mcc_h236 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _756_recursiveGen;
                bool _757_recOwned;
                bool _758_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _759_recIdents;
                Dafny.ISequence<Dafny.Rune> _out373;
                bool _out374;
                bool _out375;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out376;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out373, out _out374, out _out375, out _out376);
                _756_recursiveGen = _out373;
                _757_recOwned = _out374;
                _758_recErased = _out375;
                _759_recIdents = _out376;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _756_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _757_recOwned;
                isErased = _758_recErased;
                readIdents = _759_recIdents;
              }
            } else if (_source31.is_Multiset) {
              DAST._IType _760___mcc_h238 = _source31.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _761_recursiveGen;
                bool _762_recOwned;
                bool _763_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _764_recIdents;
                Dafny.ISequence<Dafny.Rune> _out377;
                bool _out378;
                bool _out379;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out380;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out377, out _out378, out _out379, out _out380);
                _761_recursiveGen = _out377;
                _762_recOwned = _out378;
                _763_recErased = _out379;
                _764_recIdents = _out380;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _761_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _762_recOwned;
                isErased = _763_recErased;
                readIdents = _764_recIdents;
              }
            } else if (_source31.is_Map) {
              DAST._IType _765___mcc_h240 = _source31.dtor_key;
              DAST._IType _766___mcc_h241 = _source31.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _767_recursiveGen;
                bool _768_recOwned;
                bool _769_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _770_recIdents;
                Dafny.ISequence<Dafny.Rune> _out381;
                bool _out382;
                bool _out383;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out384;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out381, out _out382, out _out383, out _out384);
                _767_recursiveGen = _out381;
                _768_recOwned = _out382;
                _769_recErased = _out383;
                _770_recIdents = _out384;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _767_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _768_recOwned;
                isErased = _769_recErased;
                readIdents = _770_recIdents;
              }
            } else if (_source31.is_Arrow) {
              Dafny.ISequence<DAST._IType> _771___mcc_h244 = _source31.dtor_args;
              DAST._IType _772___mcc_h245 = _source31.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _773_recursiveGen;
                bool _774_recOwned;
                bool _775_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _776_recIdents;
                Dafny.ISequence<Dafny.Rune> _out385;
                bool _out386;
                bool _out387;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out388;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out385, out _out386, out _out387, out _out388);
                _773_recursiveGen = _out385;
                _774_recOwned = _out386;
                _775_recErased = _out387;
                _776_recIdents = _out388;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _773_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _774_recOwned;
                isErased = _775_recErased;
                readIdents = _776_recIdents;
              }
            } else if (_source31.is_Primitive) {
              DAST._IPrimitive _777___mcc_h248 = _source31.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _778_recursiveGen;
                bool _779_recOwned;
                bool _780_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _781_recIdents;
                Dafny.ISequence<Dafny.Rune> _out389;
                bool _out390;
                bool _out391;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out392;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out389, out _out390, out _out391, out _out392);
                _778_recursiveGen = _out389;
                _779_recOwned = _out390;
                _780_recErased = _out391;
                _781_recIdents = _out392;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _778_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _779_recOwned;
                isErased = _780_recErased;
                readIdents = _781_recIdents;
              }
            } else if (_source31.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _782___mcc_h250 = _source31.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _783_recursiveGen;
                bool _784_recOwned;
                bool _785_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _786_recIdents;
                Dafny.ISequence<Dafny.Rune> _out393;
                bool _out394;
                bool _out395;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out396;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out393, out _out394, out _out395, out _out396);
                _783_recursiveGen = _out393;
                _784_recOwned = _out394;
                _785_recErased = _out395;
                _786_recIdents = _out396;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _783_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _784_recOwned;
                isErased = _785_recErased;
                readIdents = _786_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _787___mcc_h252 = _source31.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _788_recursiveGen;
                bool _789_recOwned;
                bool _790_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _791_recIdents;
                Dafny.ISequence<Dafny.Rune> _out397;
                bool _out398;
                bool _out399;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out400;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out397, out _out398, out _out399, out _out400);
                _788_recursiveGen = _out397;
                _789_recOwned = _out398;
                _790_recErased = _out399;
                _791_recIdents = _out400;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _788_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _789_recOwned;
                isErased = _790_recErased;
                readIdents = _791_recIdents;
              }
            }
          } else if (_source22.is_Multiset) {
            DAST._IType _792___mcc_h254 = _source22.dtor_element;
            DAST._IType _source33 = _429___mcc_h60;
            if (_source33.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _793___mcc_h257 = _source33.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _794___mcc_h258 = _source33.dtor_typeArgs;
              DAST._IResolvedType _795___mcc_h259 = _source33.dtor_resolved;
              DAST._IResolvedType _source34 = _795___mcc_h259;
              if (_source34.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _796___mcc_h263 = _source34.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _797_recursiveGen;
                  bool _798_recOwned;
                  bool _799_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _800_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out401;
                  bool _out402;
                  bool _out403;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out404;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out401, out _out402, out _out403, out _out404);
                  _797_recursiveGen = _out401;
                  _798_recOwned = _out402;
                  _799_recErased = _out403;
                  _800_recIdents = _out404;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _797_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _798_recOwned;
                  isErased = _799_recErased;
                  readIdents = _800_recIdents;
                }
              } else if (_source34.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _801___mcc_h265 = _source34.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _802_recursiveGen;
                  bool _803_recOwned;
                  bool _804_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _805_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out405;
                  bool _out406;
                  bool _out407;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out408;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out405, out _out406, out _out407, out _out408);
                  _802_recursiveGen = _out405;
                  _803_recOwned = _out406;
                  _804_recErased = _out407;
                  _805_recIdents = _out408;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _802_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _803_recOwned;
                  isErased = _804_recErased;
                  readIdents = _805_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _806_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out409;
                  _out409 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _806_tpeGen = _out409;
                  Dafny.ISequence<Dafny.Rune> _807_recursiveGen;
                  bool _808_recOwned;
                  bool _809_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _810_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out410;
                  bool _out411;
                  bool _out412;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out413;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out410, out _out411, out _out412, out _out413);
                  _807_recursiveGen = _out410;
                  _808_recOwned = _out411;
                  _809_recErased = _out412;
                  _810_recIdents = _out413;
                  Dafny.ISequence<Dafny.Rune> _811_uneraseFn;
                  _811_uneraseFn = ((_808_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _806_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _811_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _807_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _808_recOwned;
                  isErased = false;
                  readIdents = _810_recIdents;
                }
              }
            } else if (_source33.is_Tuple) {
              Dafny.ISequence<DAST._IType> _812___mcc_h267 = _source33.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _813_recursiveGen;
                bool _814_recOwned;
                bool _815_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _816_recIdents;
                Dafny.ISequence<Dafny.Rune> _out414;
                bool _out415;
                bool _out416;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out417;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out414, out _out415, out _out416, out _out417);
                _813_recursiveGen = _out414;
                _814_recOwned = _out415;
                _815_recErased = _out416;
                _816_recIdents = _out417;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _813_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _814_recOwned;
                isErased = _815_recErased;
                readIdents = _816_recIdents;
              }
            } else if (_source33.is_Array) {
              DAST._IType _817___mcc_h269 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _818_recursiveGen;
                bool _819_recOwned;
                bool _820_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _821_recIdents;
                Dafny.ISequence<Dafny.Rune> _out418;
                bool _out419;
                bool _out420;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out421;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out418, out _out419, out _out420, out _out421);
                _818_recursiveGen = _out418;
                _819_recOwned = _out419;
                _820_recErased = _out420;
                _821_recIdents = _out421;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _818_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _819_recOwned;
                isErased = _820_recErased;
                readIdents = _821_recIdents;
              }
            } else if (_source33.is_Seq) {
              DAST._IType _822___mcc_h271 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _823_recursiveGen;
                bool _824_recOwned;
                bool _825_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _826_recIdents;
                Dafny.ISequence<Dafny.Rune> _out422;
                bool _out423;
                bool _out424;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out425;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out422, out _out423, out _out424, out _out425);
                _823_recursiveGen = _out422;
                _824_recOwned = _out423;
                _825_recErased = _out424;
                _826_recIdents = _out425;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _823_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _824_recOwned;
                isErased = _825_recErased;
                readIdents = _826_recIdents;
              }
            } else if (_source33.is_Set) {
              DAST._IType _827___mcc_h273 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _828_recursiveGen;
                bool _829_recOwned;
                bool _830_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _831_recIdents;
                Dafny.ISequence<Dafny.Rune> _out426;
                bool _out427;
                bool _out428;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out429;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out426, out _out427, out _out428, out _out429);
                _828_recursiveGen = _out426;
                _829_recOwned = _out427;
                _830_recErased = _out428;
                _831_recIdents = _out429;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _828_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _829_recOwned;
                isErased = _830_recErased;
                readIdents = _831_recIdents;
              }
            } else if (_source33.is_Multiset) {
              DAST._IType _832___mcc_h275 = _source33.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _833_recursiveGen;
                bool _834_recOwned;
                bool _835_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _836_recIdents;
                Dafny.ISequence<Dafny.Rune> _out430;
                bool _out431;
                bool _out432;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out433;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out430, out _out431, out _out432, out _out433);
                _833_recursiveGen = _out430;
                _834_recOwned = _out431;
                _835_recErased = _out432;
                _836_recIdents = _out433;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _833_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _834_recOwned;
                isErased = _835_recErased;
                readIdents = _836_recIdents;
              }
            } else if (_source33.is_Map) {
              DAST._IType _837___mcc_h277 = _source33.dtor_key;
              DAST._IType _838___mcc_h278 = _source33.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _839_recursiveGen;
                bool _840_recOwned;
                bool _841_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _842_recIdents;
                Dafny.ISequence<Dafny.Rune> _out434;
                bool _out435;
                bool _out436;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out437;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out434, out _out435, out _out436, out _out437);
                _839_recursiveGen = _out434;
                _840_recOwned = _out435;
                _841_recErased = _out436;
                _842_recIdents = _out437;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _839_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _840_recOwned;
                isErased = _841_recErased;
                readIdents = _842_recIdents;
              }
            } else if (_source33.is_Arrow) {
              Dafny.ISequence<DAST._IType> _843___mcc_h281 = _source33.dtor_args;
              DAST._IType _844___mcc_h282 = _source33.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _845_recursiveGen;
                bool _846_recOwned;
                bool _847_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _848_recIdents;
                Dafny.ISequence<Dafny.Rune> _out438;
                bool _out439;
                bool _out440;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out441;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out438, out _out439, out _out440, out _out441);
                _845_recursiveGen = _out438;
                _846_recOwned = _out439;
                _847_recErased = _out440;
                _848_recIdents = _out441;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _845_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _846_recOwned;
                isErased = _847_recErased;
                readIdents = _848_recIdents;
              }
            } else if (_source33.is_Primitive) {
              DAST._IPrimitive _849___mcc_h285 = _source33.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _850_recursiveGen;
                bool _851_recOwned;
                bool _852_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _853_recIdents;
                Dafny.ISequence<Dafny.Rune> _out442;
                bool _out443;
                bool _out444;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out445;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out442, out _out443, out _out444, out _out445);
                _850_recursiveGen = _out442;
                _851_recOwned = _out443;
                _852_recErased = _out444;
                _853_recIdents = _out445;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _850_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _851_recOwned;
                isErased = _852_recErased;
                readIdents = _853_recIdents;
              }
            } else if (_source33.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _854___mcc_h287 = _source33.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _855_recursiveGen;
                bool _856_recOwned;
                bool _857_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _858_recIdents;
                Dafny.ISequence<Dafny.Rune> _out446;
                bool _out447;
                bool _out448;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out449;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out446, out _out447, out _out448, out _out449);
                _855_recursiveGen = _out446;
                _856_recOwned = _out447;
                _857_recErased = _out448;
                _858_recIdents = _out449;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _855_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _856_recOwned;
                isErased = _857_recErased;
                readIdents = _858_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _859___mcc_h289 = _source33.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _860_recursiveGen;
                bool _861_recOwned;
                bool _862_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _863_recIdents;
                Dafny.ISequence<Dafny.Rune> _out450;
                bool _out451;
                bool _out452;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out453;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out450, out _out451, out _out452, out _out453);
                _860_recursiveGen = _out450;
                _861_recOwned = _out451;
                _862_recErased = _out452;
                _863_recIdents = _out453;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _860_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _861_recOwned;
                isErased = _862_recErased;
                readIdents = _863_recIdents;
              }
            }
          } else if (_source22.is_Map) {
            DAST._IType _864___mcc_h291 = _source22.dtor_key;
            DAST._IType _865___mcc_h292 = _source22.dtor_value;
            DAST._IType _source35 = _429___mcc_h60;
            if (_source35.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _866___mcc_h297 = _source35.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _867___mcc_h298 = _source35.dtor_typeArgs;
              DAST._IResolvedType _868___mcc_h299 = _source35.dtor_resolved;
              DAST._IResolvedType _source36 = _868___mcc_h299;
              if (_source36.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _869___mcc_h303 = _source36.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _870_recursiveGen;
                  bool _871_recOwned;
                  bool _872_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _873_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out454;
                  bool _out455;
                  bool _out456;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out457;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out454, out _out455, out _out456, out _out457);
                  _870_recursiveGen = _out454;
                  _871_recOwned = _out455;
                  _872_recErased = _out456;
                  _873_recIdents = _out457;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _870_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _871_recOwned;
                  isErased = _872_recErased;
                  readIdents = _873_recIdents;
                }
              } else if (_source36.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _874___mcc_h305 = _source36.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _875_recursiveGen;
                  bool _876_recOwned;
                  bool _877_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _878_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out458;
                  bool _out459;
                  bool _out460;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out461;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out458, out _out459, out _out460, out _out461);
                  _875_recursiveGen = _out458;
                  _876_recOwned = _out459;
                  _877_recErased = _out460;
                  _878_recIdents = _out461;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _875_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _876_recOwned;
                  isErased = _877_recErased;
                  readIdents = _878_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _879_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out462;
                  _out462 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _879_tpeGen = _out462;
                  Dafny.ISequence<Dafny.Rune> _880_recursiveGen;
                  bool _881_recOwned;
                  bool _882_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _883_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out463;
                  bool _out464;
                  bool _out465;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out466;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out463, out _out464, out _out465, out _out466);
                  _880_recursiveGen = _out463;
                  _881_recOwned = _out464;
                  _882_recErased = _out465;
                  _883_recIdents = _out466;
                  Dafny.ISequence<Dafny.Rune> _884_uneraseFn;
                  _884_uneraseFn = ((_881_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _879_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _884_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _880_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _881_recOwned;
                  isErased = false;
                  readIdents = _883_recIdents;
                }
              }
            } else if (_source35.is_Tuple) {
              Dafny.ISequence<DAST._IType> _885___mcc_h307 = _source35.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _886_recursiveGen;
                bool _887_recOwned;
                bool _888_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _889_recIdents;
                Dafny.ISequence<Dafny.Rune> _out467;
                bool _out468;
                bool _out469;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out470;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out467, out _out468, out _out469, out _out470);
                _886_recursiveGen = _out467;
                _887_recOwned = _out468;
                _888_recErased = _out469;
                _889_recIdents = _out470;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _886_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _887_recOwned;
                isErased = _888_recErased;
                readIdents = _889_recIdents;
              }
            } else if (_source35.is_Array) {
              DAST._IType _890___mcc_h309 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _891_recursiveGen;
                bool _892_recOwned;
                bool _893_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _894_recIdents;
                Dafny.ISequence<Dafny.Rune> _out471;
                bool _out472;
                bool _out473;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out474;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out471, out _out472, out _out473, out _out474);
                _891_recursiveGen = _out471;
                _892_recOwned = _out472;
                _893_recErased = _out473;
                _894_recIdents = _out474;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _891_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _892_recOwned;
                isErased = _893_recErased;
                readIdents = _894_recIdents;
              }
            } else if (_source35.is_Seq) {
              DAST._IType _895___mcc_h311 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _896_recursiveGen;
                bool _897_recOwned;
                bool _898_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _899_recIdents;
                Dafny.ISequence<Dafny.Rune> _out475;
                bool _out476;
                bool _out477;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out478;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out475, out _out476, out _out477, out _out478);
                _896_recursiveGen = _out475;
                _897_recOwned = _out476;
                _898_recErased = _out477;
                _899_recIdents = _out478;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _896_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _897_recOwned;
                isErased = _898_recErased;
                readIdents = _899_recIdents;
              }
            } else if (_source35.is_Set) {
              DAST._IType _900___mcc_h313 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _901_recursiveGen;
                bool _902_recOwned;
                bool _903_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _904_recIdents;
                Dafny.ISequence<Dafny.Rune> _out479;
                bool _out480;
                bool _out481;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out482;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out479, out _out480, out _out481, out _out482);
                _901_recursiveGen = _out479;
                _902_recOwned = _out480;
                _903_recErased = _out481;
                _904_recIdents = _out482;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _901_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _902_recOwned;
                isErased = _903_recErased;
                readIdents = _904_recIdents;
              }
            } else if (_source35.is_Multiset) {
              DAST._IType _905___mcc_h315 = _source35.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _906_recursiveGen;
                bool _907_recOwned;
                bool _908_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _909_recIdents;
                Dafny.ISequence<Dafny.Rune> _out483;
                bool _out484;
                bool _out485;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out486;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out483, out _out484, out _out485, out _out486);
                _906_recursiveGen = _out483;
                _907_recOwned = _out484;
                _908_recErased = _out485;
                _909_recIdents = _out486;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _906_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _907_recOwned;
                isErased = _908_recErased;
                readIdents = _909_recIdents;
              }
            } else if (_source35.is_Map) {
              DAST._IType _910___mcc_h317 = _source35.dtor_key;
              DAST._IType _911___mcc_h318 = _source35.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _912_recursiveGen;
                bool _913_recOwned;
                bool _914_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _915_recIdents;
                Dafny.ISequence<Dafny.Rune> _out487;
                bool _out488;
                bool _out489;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out490;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out487, out _out488, out _out489, out _out490);
                _912_recursiveGen = _out487;
                _913_recOwned = _out488;
                _914_recErased = _out489;
                _915_recIdents = _out490;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _912_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _913_recOwned;
                isErased = _914_recErased;
                readIdents = _915_recIdents;
              }
            } else if (_source35.is_Arrow) {
              Dafny.ISequence<DAST._IType> _916___mcc_h321 = _source35.dtor_args;
              DAST._IType _917___mcc_h322 = _source35.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _918_recursiveGen;
                bool _919_recOwned;
                bool _920_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _921_recIdents;
                Dafny.ISequence<Dafny.Rune> _out491;
                bool _out492;
                bool _out493;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out494;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out491, out _out492, out _out493, out _out494);
                _918_recursiveGen = _out491;
                _919_recOwned = _out492;
                _920_recErased = _out493;
                _921_recIdents = _out494;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _918_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _919_recOwned;
                isErased = _920_recErased;
                readIdents = _921_recIdents;
              }
            } else if (_source35.is_Primitive) {
              DAST._IPrimitive _922___mcc_h325 = _source35.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _923_recursiveGen;
                bool _924_recOwned;
                bool _925_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _926_recIdents;
                Dafny.ISequence<Dafny.Rune> _out495;
                bool _out496;
                bool _out497;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out498;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out495, out _out496, out _out497, out _out498);
                _923_recursiveGen = _out495;
                _924_recOwned = _out496;
                _925_recErased = _out497;
                _926_recIdents = _out498;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _923_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _924_recOwned;
                isErased = _925_recErased;
                readIdents = _926_recIdents;
              }
            } else if (_source35.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _927___mcc_h327 = _source35.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _928_recursiveGen;
                bool _929_recOwned;
                bool _930_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _931_recIdents;
                Dafny.ISequence<Dafny.Rune> _out499;
                bool _out500;
                bool _out501;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out502;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out499, out _out500, out _out501, out _out502);
                _928_recursiveGen = _out499;
                _929_recOwned = _out500;
                _930_recErased = _out501;
                _931_recIdents = _out502;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _928_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _929_recOwned;
                isErased = _930_recErased;
                readIdents = _931_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _932___mcc_h329 = _source35.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _933_recursiveGen;
                bool _934_recOwned;
                bool _935_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _936_recIdents;
                Dafny.ISequence<Dafny.Rune> _out503;
                bool _out504;
                bool _out505;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out506;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out503, out _out504, out _out505, out _out506);
                _933_recursiveGen = _out503;
                _934_recOwned = _out504;
                _935_recErased = _out505;
                _936_recIdents = _out506;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _933_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _934_recOwned;
                isErased = _935_recErased;
                readIdents = _936_recIdents;
              }
            }
          } else if (_source22.is_Arrow) {
            Dafny.ISequence<DAST._IType> _937___mcc_h331 = _source22.dtor_args;
            DAST._IType _938___mcc_h332 = _source22.dtor_result;
            DAST._IType _source37 = _429___mcc_h60;
            if (_source37.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _939___mcc_h337 = _source37.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _940___mcc_h338 = _source37.dtor_typeArgs;
              DAST._IResolvedType _941___mcc_h339 = _source37.dtor_resolved;
              DAST._IResolvedType _source38 = _941___mcc_h339;
              if (_source38.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _942___mcc_h343 = _source38.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _943_recursiveGen;
                  bool _944_recOwned;
                  bool _945_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _946_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out507;
                  bool _out508;
                  bool _out509;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out510;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out507, out _out508, out _out509, out _out510);
                  _943_recursiveGen = _out507;
                  _944_recOwned = _out508;
                  _945_recErased = _out509;
                  _946_recIdents = _out510;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _943_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _944_recOwned;
                  isErased = _945_recErased;
                  readIdents = _946_recIdents;
                }
              } else if (_source38.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _947___mcc_h345 = _source38.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _948_recursiveGen;
                  bool _949_recOwned;
                  bool _950_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _951_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out511;
                  bool _out512;
                  bool _out513;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out514;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out511, out _out512, out _out513, out _out514);
                  _948_recursiveGen = _out511;
                  _949_recOwned = _out512;
                  _950_recErased = _out513;
                  _951_recIdents = _out514;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _948_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _949_recOwned;
                  isErased = _950_recErased;
                  readIdents = _951_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _952_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out515;
                  _out515 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _952_tpeGen = _out515;
                  Dafny.ISequence<Dafny.Rune> _953_recursiveGen;
                  bool _954_recOwned;
                  bool _955_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _956_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out516;
                  bool _out517;
                  bool _out518;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out519;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out516, out _out517, out _out518, out _out519);
                  _953_recursiveGen = _out516;
                  _954_recOwned = _out517;
                  _955_recErased = _out518;
                  _956_recIdents = _out519;
                  Dafny.ISequence<Dafny.Rune> _957_uneraseFn;
                  _957_uneraseFn = ((_954_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _952_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _957_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _953_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _954_recOwned;
                  isErased = false;
                  readIdents = _956_recIdents;
                }
              }
            } else if (_source37.is_Tuple) {
              Dafny.ISequence<DAST._IType> _958___mcc_h347 = _source37.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _959_recursiveGen;
                bool _960_recOwned;
                bool _961_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _962_recIdents;
                Dafny.ISequence<Dafny.Rune> _out520;
                bool _out521;
                bool _out522;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out523;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out520, out _out521, out _out522, out _out523);
                _959_recursiveGen = _out520;
                _960_recOwned = _out521;
                _961_recErased = _out522;
                _962_recIdents = _out523;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _959_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _960_recOwned;
                isErased = _961_recErased;
                readIdents = _962_recIdents;
              }
            } else if (_source37.is_Array) {
              DAST._IType _963___mcc_h349 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _964_recursiveGen;
                bool _965_recOwned;
                bool _966_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _967_recIdents;
                Dafny.ISequence<Dafny.Rune> _out524;
                bool _out525;
                bool _out526;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out527;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out524, out _out525, out _out526, out _out527);
                _964_recursiveGen = _out524;
                _965_recOwned = _out525;
                _966_recErased = _out526;
                _967_recIdents = _out527;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _964_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _965_recOwned;
                isErased = _966_recErased;
                readIdents = _967_recIdents;
              }
            } else if (_source37.is_Seq) {
              DAST._IType _968___mcc_h351 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _969_recursiveGen;
                bool _970_recOwned;
                bool _971_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _972_recIdents;
                Dafny.ISequence<Dafny.Rune> _out528;
                bool _out529;
                bool _out530;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out531;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out528, out _out529, out _out530, out _out531);
                _969_recursiveGen = _out528;
                _970_recOwned = _out529;
                _971_recErased = _out530;
                _972_recIdents = _out531;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _969_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _970_recOwned;
                isErased = _971_recErased;
                readIdents = _972_recIdents;
              }
            } else if (_source37.is_Set) {
              DAST._IType _973___mcc_h353 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _974_recursiveGen;
                bool _975_recOwned;
                bool _976_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _977_recIdents;
                Dafny.ISequence<Dafny.Rune> _out532;
                bool _out533;
                bool _out534;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out535;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out532, out _out533, out _out534, out _out535);
                _974_recursiveGen = _out532;
                _975_recOwned = _out533;
                _976_recErased = _out534;
                _977_recIdents = _out535;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _974_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _975_recOwned;
                isErased = _976_recErased;
                readIdents = _977_recIdents;
              }
            } else if (_source37.is_Multiset) {
              DAST._IType _978___mcc_h355 = _source37.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _979_recursiveGen;
                bool _980_recOwned;
                bool _981_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _982_recIdents;
                Dafny.ISequence<Dafny.Rune> _out536;
                bool _out537;
                bool _out538;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out539;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out536, out _out537, out _out538, out _out539);
                _979_recursiveGen = _out536;
                _980_recOwned = _out537;
                _981_recErased = _out538;
                _982_recIdents = _out539;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _979_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _980_recOwned;
                isErased = _981_recErased;
                readIdents = _982_recIdents;
              }
            } else if (_source37.is_Map) {
              DAST._IType _983___mcc_h357 = _source37.dtor_key;
              DAST._IType _984___mcc_h358 = _source37.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _985_recursiveGen;
                bool _986_recOwned;
                bool _987_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _988_recIdents;
                Dafny.ISequence<Dafny.Rune> _out540;
                bool _out541;
                bool _out542;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out543;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out540, out _out541, out _out542, out _out543);
                _985_recursiveGen = _out540;
                _986_recOwned = _out541;
                _987_recErased = _out542;
                _988_recIdents = _out543;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _985_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _986_recOwned;
                isErased = _987_recErased;
                readIdents = _988_recIdents;
              }
            } else if (_source37.is_Arrow) {
              Dafny.ISequence<DAST._IType> _989___mcc_h361 = _source37.dtor_args;
              DAST._IType _990___mcc_h362 = _source37.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _991_recursiveGen;
                bool _992_recOwned;
                bool _993_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _994_recIdents;
                Dafny.ISequence<Dafny.Rune> _out544;
                bool _out545;
                bool _out546;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out547;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out544, out _out545, out _out546, out _out547);
                _991_recursiveGen = _out544;
                _992_recOwned = _out545;
                _993_recErased = _out546;
                _994_recIdents = _out547;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _991_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _992_recOwned;
                isErased = _993_recErased;
                readIdents = _994_recIdents;
              }
            } else if (_source37.is_Primitive) {
              DAST._IPrimitive _995___mcc_h365 = _source37.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _996_recursiveGen;
                bool _997_recOwned;
                bool _998_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _999_recIdents;
                Dafny.ISequence<Dafny.Rune> _out548;
                bool _out549;
                bool _out550;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out551;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out548, out _out549, out _out550, out _out551);
                _996_recursiveGen = _out548;
                _997_recOwned = _out549;
                _998_recErased = _out550;
                _999_recIdents = _out551;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _996_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _997_recOwned;
                isErased = _998_recErased;
                readIdents = _999_recIdents;
              }
            } else if (_source37.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1000___mcc_h367 = _source37.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1001_recursiveGen;
                bool _1002_recOwned;
                bool _1003_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1004_recIdents;
                Dafny.ISequence<Dafny.Rune> _out552;
                bool _out553;
                bool _out554;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out555;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out552, out _out553, out _out554, out _out555);
                _1001_recursiveGen = _out552;
                _1002_recOwned = _out553;
                _1003_recErased = _out554;
                _1004_recIdents = _out555;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1001_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1002_recOwned;
                isErased = _1003_recErased;
                readIdents = _1004_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1005___mcc_h369 = _source37.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1006_recursiveGen;
                bool _1007_recOwned;
                bool _1008_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1009_recIdents;
                Dafny.ISequence<Dafny.Rune> _out556;
                bool _out557;
                bool _out558;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out559;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out556, out _out557, out _out558, out _out559);
                _1006_recursiveGen = _out556;
                _1007_recOwned = _out557;
                _1008_recErased = _out558;
                _1009_recIdents = _out559;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1006_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1007_recOwned;
                isErased = _1008_recErased;
                readIdents = _1009_recIdents;
              }
            }
          } else if (_source22.is_Primitive) {
            DAST._IPrimitive _1010___mcc_h371 = _source22.dtor_Primitive_a0;
            DAST._IPrimitive _source39 = _1010___mcc_h371;
            if (_source39.is_Int) {
              DAST._IType _source40 = _429___mcc_h60;
              if (_source40.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1011___mcc_h374 = _source40.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1012___mcc_h375 = _source40.dtor_typeArgs;
                DAST._IResolvedType _1013___mcc_h376 = _source40.dtor_resolved;
                DAST._IResolvedType _source41 = _1013___mcc_h376;
                if (_source41.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1014___mcc_h380 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1015_recursiveGen;
                    bool _1016_recOwned;
                    bool _1017_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1018_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out560;
                    bool _out561;
                    bool _out562;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out563;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out560, out _out561, out _out562, out _out563);
                    _1015_recursiveGen = _out560;
                    _1016_recOwned = _out561;
                    _1017_recErased = _out562;
                    _1018_recIdents = _out563;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1015_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1016_recOwned;
                    isErased = _1017_recErased;
                    readIdents = _1018_recIdents;
                  }
                } else if (_source41.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1019___mcc_h382 = _source41.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1020_recursiveGen;
                    bool _1021_recOwned;
                    bool _1022_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1023_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out564;
                    bool _out565;
                    bool _out566;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out567;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out564, out _out565, out _out566, out _out567);
                    _1020_recursiveGen = _out564;
                    _1021_recOwned = _out565;
                    _1022_recErased = _out566;
                    _1023_recIdents = _out567;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1020_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1021_recOwned;
                    isErased = _1022_recErased;
                    readIdents = _1023_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1024_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out568;
                    _out568 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                    _1024_tpeGen = _out568;
                    Dafny.ISequence<Dafny.Rune> _1025_recursiveGen;
                    bool _1026_recOwned;
                    bool _1027_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1028_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out569;
                    bool _out570;
                    bool _out571;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out572;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out569, out _out570, out _out571, out _out572);
                    _1025_recursiveGen = _out569;
                    _1026_recOwned = _out570;
                    _1027_recErased = _out571;
                    _1028_recIdents = _out572;
                    Dafny.ISequence<Dafny.Rune> _1029_uneraseFn;
                    _1029_uneraseFn = ((_1026_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1024_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1029_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1025_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1026_recOwned;
                    isErased = false;
                    readIdents = _1028_recIdents;
                  }
                }
              } else if (_source40.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1030___mcc_h384 = _source40.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1031_recursiveGen;
                  bool _1032_recOwned;
                  bool _1033_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1034_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out573;
                  bool _out574;
                  bool _out575;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out576;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out573, out _out574, out _out575, out _out576);
                  _1031_recursiveGen = _out573;
                  _1032_recOwned = _out574;
                  _1033_recErased = _out575;
                  _1034_recIdents = _out576;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1031_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1032_recOwned;
                  isErased = _1033_recErased;
                  readIdents = _1034_recIdents;
                }
              } else if (_source40.is_Array) {
                DAST._IType _1035___mcc_h386 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1036_recursiveGen;
                  bool _1037_recOwned;
                  bool _1038_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1039_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out577;
                  bool _out578;
                  bool _out579;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out580;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out577, out _out578, out _out579, out _out580);
                  _1036_recursiveGen = _out577;
                  _1037_recOwned = _out578;
                  _1038_recErased = _out579;
                  _1039_recIdents = _out580;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1036_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1037_recOwned;
                  isErased = _1038_recErased;
                  readIdents = _1039_recIdents;
                }
              } else if (_source40.is_Seq) {
                DAST._IType _1040___mcc_h388 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1041_recursiveGen;
                  bool _1042_recOwned;
                  bool _1043_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1044_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out581;
                  bool _out582;
                  bool _out583;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out584;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out581, out _out582, out _out583, out _out584);
                  _1041_recursiveGen = _out581;
                  _1042_recOwned = _out582;
                  _1043_recErased = _out583;
                  _1044_recIdents = _out584;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1041_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1042_recOwned;
                  isErased = _1043_recErased;
                  readIdents = _1044_recIdents;
                }
              } else if (_source40.is_Set) {
                DAST._IType _1045___mcc_h390 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1046_recursiveGen;
                  bool _1047_recOwned;
                  bool _1048_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1049_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out585;
                  bool _out586;
                  bool _out587;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out588;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out585, out _out586, out _out587, out _out588);
                  _1046_recursiveGen = _out585;
                  _1047_recOwned = _out586;
                  _1048_recErased = _out587;
                  _1049_recIdents = _out588;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1046_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1047_recOwned;
                  isErased = _1048_recErased;
                  readIdents = _1049_recIdents;
                }
              } else if (_source40.is_Multiset) {
                DAST._IType _1050___mcc_h392 = _source40.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1051_recursiveGen;
                  bool _1052_recOwned;
                  bool _1053_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1054_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out589;
                  bool _out590;
                  bool _out591;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out592;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out589, out _out590, out _out591, out _out592);
                  _1051_recursiveGen = _out589;
                  _1052_recOwned = _out590;
                  _1053_recErased = _out591;
                  _1054_recIdents = _out592;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1051_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1052_recOwned;
                  isErased = _1053_recErased;
                  readIdents = _1054_recIdents;
                }
              } else if (_source40.is_Map) {
                DAST._IType _1055___mcc_h394 = _source40.dtor_key;
                DAST._IType _1056___mcc_h395 = _source40.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1057_recursiveGen;
                  bool _1058_recOwned;
                  bool _1059_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1060_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out593;
                  bool _out594;
                  bool _out595;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out596;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out593, out _out594, out _out595, out _out596);
                  _1057_recursiveGen = _out593;
                  _1058_recOwned = _out594;
                  _1059_recErased = _out595;
                  _1060_recIdents = _out596;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1057_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1058_recOwned;
                  isErased = _1059_recErased;
                  readIdents = _1060_recIdents;
                }
              } else if (_source40.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1061___mcc_h398 = _source40.dtor_args;
                DAST._IType _1062___mcc_h399 = _source40.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1063_recursiveGen;
                  bool _1064_recOwned;
                  bool _1065_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1066_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out597;
                  bool _out598;
                  bool _out599;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out600;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out597, out _out598, out _out599, out _out600);
                  _1063_recursiveGen = _out597;
                  _1064_recOwned = _out598;
                  _1065_recErased = _out599;
                  _1066_recIdents = _out600;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1063_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1064_recOwned;
                  isErased = _1065_recErased;
                  readIdents = _1066_recIdents;
                }
              } else if (_source40.is_Primitive) {
                DAST._IPrimitive _1067___mcc_h402 = _source40.dtor_Primitive_a0;
                DAST._IPrimitive _source42 = _1067___mcc_h402;
                if (_source42.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1068_recursiveGen;
                    bool _1069_recOwned;
                    bool _1070_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1071_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out601;
                    bool _out602;
                    bool _out603;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out604;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out601, out _out602, out _out603, out _out604);
                    _1068_recursiveGen = _out601;
                    _1069_recOwned = _out602;
                    _1070_recErased = _out603;
                    _1071_recIdents = _out604;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1068_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1069_recOwned;
                    isErased = _1070_recErased;
                    readIdents = _1071_recIdents;
                  }
                } else if (_source42.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1072_recursiveGen;
                    bool _1073___v34;
                    bool _1074___v35;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1075_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out605;
                    bool _out606;
                    bool _out607;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out608;
                    DCOMP.COMP.GenExpr(_427_expr, @params, true, out _out605, out _out606, out _out607, out _out608);
                    _1072_recursiveGen = _out605;
                    _1073___v34 = _out606;
                    _1074___v35 = _out607;
                    _1075_recIdents = _out608;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::BigRational::from_integer("), _1072_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1075_recIdents;
                  }
                } else if (_source42.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1076_recursiveGen;
                    bool _1077_recOwned;
                    bool _1078_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1079_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out609;
                    bool _out610;
                    bool _out611;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out612;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out609, out _out610, out _out611, out _out612);
                    _1076_recursiveGen = _out609;
                    _1077_recOwned = _out610;
                    _1078_recErased = _out611;
                    _1079_recIdents = _out612;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1076_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1077_recOwned;
                    isErased = _1078_recErased;
                    readIdents = _1079_recIdents;
                  }
                } else if (_source42.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1080_recursiveGen;
                    bool _1081_recOwned;
                    bool _1082_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1083_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out613;
                    bool _out614;
                    bool _out615;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out616;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out613, out _out614, out _out615, out _out616);
                    _1080_recursiveGen = _out613;
                    _1081_recOwned = _out614;
                    _1082_recErased = _out615;
                    _1083_recIdents = _out616;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1080_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1081_recOwned;
                    isErased = _1082_recErased;
                    readIdents = _1083_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1084_recursiveGen;
                    bool _1085_recOwned;
                    bool _1086_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1087_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out617;
                    bool _out618;
                    bool _out619;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out620;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out617, out _out618, out _out619, out _out620);
                    _1084_recursiveGen = _out617;
                    _1085_recOwned = _out618;
                    _1086_recErased = _out619;
                    _1087_recIdents = _out620;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1084_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1085_recOwned;
                    isErased = _1086_recErased;
                    readIdents = _1087_recIdents;
                  }
                }
              } else if (_source40.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1088___mcc_h404 = _source40.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1089_recursiveGen;
                  bool _1090_recOwned;
                  bool _1091_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1092_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out621;
                  bool _out622;
                  bool _out623;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out624;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out621, out _out622, out _out623, out _out624);
                  _1089_recursiveGen = _out621;
                  _1090_recOwned = _out622;
                  _1091_recErased = _out623;
                  _1092_recIdents = _out624;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1089_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1090_recOwned;
                  isErased = _1091_recErased;
                  readIdents = _1092_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1093___mcc_h406 = _source40.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1094_recursiveGen;
                  bool _1095_recOwned;
                  bool _1096_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1097_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out625;
                  bool _out626;
                  bool _out627;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out628;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out625, out _out626, out _out627, out _out628);
                  _1094_recursiveGen = _out625;
                  _1095_recOwned = _out626;
                  _1096_recErased = _out627;
                  _1097_recIdents = _out628;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1094_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1095_recOwned;
                  isErased = _1096_recErased;
                  readIdents = _1097_recIdents;
                }
              }
            } else if (_source39.is_Real) {
              DAST._IType _source43 = _429___mcc_h60;
              if (_source43.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1098___mcc_h408 = _source43.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1099___mcc_h409 = _source43.dtor_typeArgs;
                DAST._IResolvedType _1100___mcc_h410 = _source43.dtor_resolved;
                DAST._IResolvedType _source44 = _1100___mcc_h410;
                if (_source44.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1101___mcc_h414 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1102_recursiveGen;
                    bool _1103_recOwned;
                    bool _1104_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1105_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out629;
                    bool _out630;
                    bool _out631;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out632;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out629, out _out630, out _out631, out _out632);
                    _1102_recursiveGen = _out629;
                    _1103_recOwned = _out630;
                    _1104_recErased = _out631;
                    _1105_recIdents = _out632;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1102_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1103_recOwned;
                    isErased = _1104_recErased;
                    readIdents = _1105_recIdents;
                  }
                } else if (_source44.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1106___mcc_h416 = _source44.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1107_recursiveGen;
                    bool _1108_recOwned;
                    bool _1109_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1110_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out633;
                    bool _out634;
                    bool _out635;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out636;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out633, out _out634, out _out635, out _out636);
                    _1107_recursiveGen = _out633;
                    _1108_recOwned = _out634;
                    _1109_recErased = _out635;
                    _1110_recIdents = _out636;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1107_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1108_recOwned;
                    isErased = _1109_recErased;
                    readIdents = _1110_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1111_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out637;
                    _out637 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                    _1111_tpeGen = _out637;
                    Dafny.ISequence<Dafny.Rune> _1112_recursiveGen;
                    bool _1113_recOwned;
                    bool _1114_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1115_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out638;
                    bool _out639;
                    bool _out640;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out641;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out638, out _out639, out _out640, out _out641);
                    _1112_recursiveGen = _out638;
                    _1113_recOwned = _out639;
                    _1114_recErased = _out640;
                    _1115_recIdents = _out641;
                    Dafny.ISequence<Dafny.Rune> _1116_uneraseFn;
                    _1116_uneraseFn = ((_1113_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1111_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1116_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1112_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1113_recOwned;
                    isErased = false;
                    readIdents = _1115_recIdents;
                  }
                }
              } else if (_source43.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1117___mcc_h418 = _source43.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1118_recursiveGen;
                  bool _1119_recOwned;
                  bool _1120_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1121_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out642;
                  bool _out643;
                  bool _out644;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out645;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out642, out _out643, out _out644, out _out645);
                  _1118_recursiveGen = _out642;
                  _1119_recOwned = _out643;
                  _1120_recErased = _out644;
                  _1121_recIdents = _out645;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1118_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1119_recOwned;
                  isErased = _1120_recErased;
                  readIdents = _1121_recIdents;
                }
              } else if (_source43.is_Array) {
                DAST._IType _1122___mcc_h420 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1123_recursiveGen;
                  bool _1124_recOwned;
                  bool _1125_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1126_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out646;
                  bool _out647;
                  bool _out648;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out649;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out646, out _out647, out _out648, out _out649);
                  _1123_recursiveGen = _out646;
                  _1124_recOwned = _out647;
                  _1125_recErased = _out648;
                  _1126_recIdents = _out649;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1123_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1124_recOwned;
                  isErased = _1125_recErased;
                  readIdents = _1126_recIdents;
                }
              } else if (_source43.is_Seq) {
                DAST._IType _1127___mcc_h422 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1128_recursiveGen;
                  bool _1129_recOwned;
                  bool _1130_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1131_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out650;
                  bool _out651;
                  bool _out652;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out653;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out650, out _out651, out _out652, out _out653);
                  _1128_recursiveGen = _out650;
                  _1129_recOwned = _out651;
                  _1130_recErased = _out652;
                  _1131_recIdents = _out653;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1128_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1129_recOwned;
                  isErased = _1130_recErased;
                  readIdents = _1131_recIdents;
                }
              } else if (_source43.is_Set) {
                DAST._IType _1132___mcc_h424 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1133_recursiveGen;
                  bool _1134_recOwned;
                  bool _1135_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1136_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out654;
                  bool _out655;
                  bool _out656;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out657;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out654, out _out655, out _out656, out _out657);
                  _1133_recursiveGen = _out654;
                  _1134_recOwned = _out655;
                  _1135_recErased = _out656;
                  _1136_recIdents = _out657;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1133_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1134_recOwned;
                  isErased = _1135_recErased;
                  readIdents = _1136_recIdents;
                }
              } else if (_source43.is_Multiset) {
                DAST._IType _1137___mcc_h426 = _source43.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1138_recursiveGen;
                  bool _1139_recOwned;
                  bool _1140_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1141_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out658;
                  bool _out659;
                  bool _out660;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out661;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out658, out _out659, out _out660, out _out661);
                  _1138_recursiveGen = _out658;
                  _1139_recOwned = _out659;
                  _1140_recErased = _out660;
                  _1141_recIdents = _out661;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1138_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1139_recOwned;
                  isErased = _1140_recErased;
                  readIdents = _1141_recIdents;
                }
              } else if (_source43.is_Map) {
                DAST._IType _1142___mcc_h428 = _source43.dtor_key;
                DAST._IType _1143___mcc_h429 = _source43.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1144_recursiveGen;
                  bool _1145_recOwned;
                  bool _1146_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1147_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out662;
                  bool _out663;
                  bool _out664;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out665;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out662, out _out663, out _out664, out _out665);
                  _1144_recursiveGen = _out662;
                  _1145_recOwned = _out663;
                  _1146_recErased = _out664;
                  _1147_recIdents = _out665;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1144_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1145_recOwned;
                  isErased = _1146_recErased;
                  readIdents = _1147_recIdents;
                }
              } else if (_source43.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1148___mcc_h432 = _source43.dtor_args;
                DAST._IType _1149___mcc_h433 = _source43.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1150_recursiveGen;
                  bool _1151_recOwned;
                  bool _1152_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1153_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out666;
                  bool _out667;
                  bool _out668;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out669;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out666, out _out667, out _out668, out _out669);
                  _1150_recursiveGen = _out666;
                  _1151_recOwned = _out667;
                  _1152_recErased = _out668;
                  _1153_recIdents = _out669;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1150_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1151_recOwned;
                  isErased = _1152_recErased;
                  readIdents = _1153_recIdents;
                }
              } else if (_source43.is_Primitive) {
                DAST._IPrimitive _1154___mcc_h436 = _source43.dtor_Primitive_a0;
                DAST._IPrimitive _source45 = _1154___mcc_h436;
                if (_source45.is_Int) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1155_recursiveGen;
                    bool _1156___v36;
                    bool _1157___v37;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1158_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out670;
                    bool _out671;
                    bool _out672;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out673;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out670, out _out671, out _out672, out _out673);
                    _1155_recursiveGen = _out670;
                    _1156___v36 = _out671;
                    _1157___v37 = _out672;
                    _1158_recIdents = _out673;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::dafny_rational_to_int("), _1155_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = true;
                    isErased = true;
                    readIdents = _1158_recIdents;
                  }
                } else if (_source45.is_Real) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1159_recursiveGen;
                    bool _1160_recOwned;
                    bool _1161_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1162_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out674;
                    bool _out675;
                    bool _out676;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out677;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out674, out _out675, out _out676, out _out677);
                    _1159_recursiveGen = _out674;
                    _1160_recOwned = _out675;
                    _1161_recErased = _out676;
                    _1162_recIdents = _out677;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1159_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1160_recOwned;
                    isErased = _1161_recErased;
                    readIdents = _1162_recIdents;
                  }
                } else if (_source45.is_String) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1163_recursiveGen;
                    bool _1164_recOwned;
                    bool _1165_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1166_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out678;
                    bool _out679;
                    bool _out680;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out681;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out678, out _out679, out _out680, out _out681);
                    _1163_recursiveGen = _out678;
                    _1164_recOwned = _out679;
                    _1165_recErased = _out680;
                    _1166_recIdents = _out681;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1163_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1164_recOwned;
                    isErased = _1165_recErased;
                    readIdents = _1166_recIdents;
                  }
                } else if (_source45.is_Bool) {
                  {
                    Dafny.ISequence<Dafny.Rune> _1167_recursiveGen;
                    bool _1168_recOwned;
                    bool _1169_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1170_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out682;
                    bool _out683;
                    bool _out684;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out685;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out682, out _out683, out _out684, out _out685);
                    _1167_recursiveGen = _out682;
                    _1168_recOwned = _out683;
                    _1169_recErased = _out684;
                    _1170_recIdents = _out685;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1167_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1168_recOwned;
                    isErased = _1169_recErased;
                    readIdents = _1170_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1171_recursiveGen;
                    bool _1172_recOwned;
                    bool _1173_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1174_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out686;
                    bool _out687;
                    bool _out688;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out689;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out686, out _out687, out _out688, out _out689);
                    _1171_recursiveGen = _out686;
                    _1172_recOwned = _out687;
                    _1173_recErased = _out688;
                    _1174_recIdents = _out689;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1171_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1172_recOwned;
                    isErased = _1173_recErased;
                    readIdents = _1174_recIdents;
                  }
                }
              } else if (_source43.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1175___mcc_h438 = _source43.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1176_recursiveGen;
                  bool _1177_recOwned;
                  bool _1178_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1179_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out690;
                  bool _out691;
                  bool _out692;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out693;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out690, out _out691, out _out692, out _out693);
                  _1176_recursiveGen = _out690;
                  _1177_recOwned = _out691;
                  _1178_recErased = _out692;
                  _1179_recIdents = _out693;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1176_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1177_recOwned;
                  isErased = _1178_recErased;
                  readIdents = _1179_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1180___mcc_h440 = _source43.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1181_recursiveGen;
                  bool _1182_recOwned;
                  bool _1183_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1184_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out694;
                  bool _out695;
                  bool _out696;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out697;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out694, out _out695, out _out696, out _out697);
                  _1181_recursiveGen = _out694;
                  _1182_recOwned = _out695;
                  _1183_recErased = _out696;
                  _1184_recIdents = _out697;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1181_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1182_recOwned;
                  isErased = _1183_recErased;
                  readIdents = _1184_recIdents;
                }
              }
            } else if (_source39.is_String) {
              DAST._IType _source46 = _429___mcc_h60;
              if (_source46.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1185___mcc_h442 = _source46.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1186___mcc_h443 = _source46.dtor_typeArgs;
                DAST._IResolvedType _1187___mcc_h444 = _source46.dtor_resolved;
                DAST._IResolvedType _source47 = _1187___mcc_h444;
                if (_source47.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1188___mcc_h448 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1189_recursiveGen;
                    bool _1190_recOwned;
                    bool _1191_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1192_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out698;
                    bool _out699;
                    bool _out700;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out701;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out698, out _out699, out _out700, out _out701);
                    _1189_recursiveGen = _out698;
                    _1190_recOwned = _out699;
                    _1191_recErased = _out700;
                    _1192_recIdents = _out701;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1189_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1190_recOwned;
                    isErased = _1191_recErased;
                    readIdents = _1192_recIdents;
                  }
                } else if (_source47.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1193___mcc_h450 = _source47.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1194_recursiveGen;
                    bool _1195_recOwned;
                    bool _1196_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1197_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out702;
                    bool _out703;
                    bool _out704;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out705;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out702, out _out703, out _out704, out _out705);
                    _1194_recursiveGen = _out702;
                    _1195_recOwned = _out703;
                    _1196_recErased = _out704;
                    _1197_recIdents = _out705;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1194_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1195_recOwned;
                    isErased = _1196_recErased;
                    readIdents = _1197_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1198_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out706;
                    _out706 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                    _1198_tpeGen = _out706;
                    Dafny.ISequence<Dafny.Rune> _1199_recursiveGen;
                    bool _1200_recOwned;
                    bool _1201_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1202_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out707;
                    bool _out708;
                    bool _out709;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out710;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out707, out _out708, out _out709, out _out710);
                    _1199_recursiveGen = _out707;
                    _1200_recOwned = _out708;
                    _1201_recErased = _out709;
                    _1202_recIdents = _out710;
                    Dafny.ISequence<Dafny.Rune> _1203_uneraseFn;
                    _1203_uneraseFn = ((_1200_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1198_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1203_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1199_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1200_recOwned;
                    isErased = false;
                    readIdents = _1202_recIdents;
                  }
                }
              } else if (_source46.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1204___mcc_h452 = _source46.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1205_recursiveGen;
                  bool _1206_recOwned;
                  bool _1207_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1208_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out711;
                  bool _out712;
                  bool _out713;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out714;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out711, out _out712, out _out713, out _out714);
                  _1205_recursiveGen = _out711;
                  _1206_recOwned = _out712;
                  _1207_recErased = _out713;
                  _1208_recIdents = _out714;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1205_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1206_recOwned;
                  isErased = _1207_recErased;
                  readIdents = _1208_recIdents;
                }
              } else if (_source46.is_Array) {
                DAST._IType _1209___mcc_h454 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1210_recursiveGen;
                  bool _1211_recOwned;
                  bool _1212_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1213_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out715;
                  bool _out716;
                  bool _out717;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out718;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out715, out _out716, out _out717, out _out718);
                  _1210_recursiveGen = _out715;
                  _1211_recOwned = _out716;
                  _1212_recErased = _out717;
                  _1213_recIdents = _out718;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1210_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1211_recOwned;
                  isErased = _1212_recErased;
                  readIdents = _1213_recIdents;
                }
              } else if (_source46.is_Seq) {
                DAST._IType _1214___mcc_h456 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1215_recursiveGen;
                  bool _1216_recOwned;
                  bool _1217_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1218_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out719;
                  bool _out720;
                  bool _out721;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out722;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out719, out _out720, out _out721, out _out722);
                  _1215_recursiveGen = _out719;
                  _1216_recOwned = _out720;
                  _1217_recErased = _out721;
                  _1218_recIdents = _out722;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1215_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1216_recOwned;
                  isErased = _1217_recErased;
                  readIdents = _1218_recIdents;
                }
              } else if (_source46.is_Set) {
                DAST._IType _1219___mcc_h458 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1220_recursiveGen;
                  bool _1221_recOwned;
                  bool _1222_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1223_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out723;
                  bool _out724;
                  bool _out725;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out726;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out723, out _out724, out _out725, out _out726);
                  _1220_recursiveGen = _out723;
                  _1221_recOwned = _out724;
                  _1222_recErased = _out725;
                  _1223_recIdents = _out726;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1220_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1221_recOwned;
                  isErased = _1222_recErased;
                  readIdents = _1223_recIdents;
                }
              } else if (_source46.is_Multiset) {
                DAST._IType _1224___mcc_h460 = _source46.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1225_recursiveGen;
                  bool _1226_recOwned;
                  bool _1227_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1228_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out727;
                  bool _out728;
                  bool _out729;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out730;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out727, out _out728, out _out729, out _out730);
                  _1225_recursiveGen = _out727;
                  _1226_recOwned = _out728;
                  _1227_recErased = _out729;
                  _1228_recIdents = _out730;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1225_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1226_recOwned;
                  isErased = _1227_recErased;
                  readIdents = _1228_recIdents;
                }
              } else if (_source46.is_Map) {
                DAST._IType _1229___mcc_h462 = _source46.dtor_key;
                DAST._IType _1230___mcc_h463 = _source46.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1231_recursiveGen;
                  bool _1232_recOwned;
                  bool _1233_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1234_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out731;
                  bool _out732;
                  bool _out733;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out734;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out731, out _out732, out _out733, out _out734);
                  _1231_recursiveGen = _out731;
                  _1232_recOwned = _out732;
                  _1233_recErased = _out733;
                  _1234_recIdents = _out734;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1231_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1232_recOwned;
                  isErased = _1233_recErased;
                  readIdents = _1234_recIdents;
                }
              } else if (_source46.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1235___mcc_h466 = _source46.dtor_args;
                DAST._IType _1236___mcc_h467 = _source46.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1237_recursiveGen;
                  bool _1238_recOwned;
                  bool _1239_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1240_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out735;
                  bool _out736;
                  bool _out737;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out738;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out735, out _out736, out _out737, out _out738);
                  _1237_recursiveGen = _out735;
                  _1238_recOwned = _out736;
                  _1239_recErased = _out737;
                  _1240_recIdents = _out738;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1237_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1238_recOwned;
                  isErased = _1239_recErased;
                  readIdents = _1240_recIdents;
                }
              } else if (_source46.is_Primitive) {
                DAST._IPrimitive _1241___mcc_h470 = _source46.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1242_recursiveGen;
                  bool _1243_recOwned;
                  bool _1244_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1245_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out739;
                  bool _out740;
                  bool _out741;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out742;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out739, out _out740, out _out741, out _out742);
                  _1242_recursiveGen = _out739;
                  _1243_recOwned = _out740;
                  _1244_recErased = _out741;
                  _1245_recIdents = _out742;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1242_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1243_recOwned;
                  isErased = _1244_recErased;
                  readIdents = _1245_recIdents;
                }
              } else if (_source46.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1246___mcc_h472 = _source46.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1247_recursiveGen;
                  bool _1248_recOwned;
                  bool _1249_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1250_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out743;
                  bool _out744;
                  bool _out745;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out746;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out743, out _out744, out _out745, out _out746);
                  _1247_recursiveGen = _out743;
                  _1248_recOwned = _out744;
                  _1249_recErased = _out745;
                  _1250_recIdents = _out746;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1247_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1248_recOwned;
                  isErased = _1249_recErased;
                  readIdents = _1250_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1251___mcc_h474 = _source46.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1252_recursiveGen;
                  bool _1253_recOwned;
                  bool _1254_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1255_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out747;
                  bool _out748;
                  bool _out749;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out750;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out747, out _out748, out _out749, out _out750);
                  _1252_recursiveGen = _out747;
                  _1253_recOwned = _out748;
                  _1254_recErased = _out749;
                  _1255_recIdents = _out750;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1252_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1253_recOwned;
                  isErased = _1254_recErased;
                  readIdents = _1255_recIdents;
                }
              }
            } else if (_source39.is_Bool) {
              DAST._IType _source48 = _429___mcc_h60;
              if (_source48.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1256___mcc_h476 = _source48.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1257___mcc_h477 = _source48.dtor_typeArgs;
                DAST._IResolvedType _1258___mcc_h478 = _source48.dtor_resolved;
                DAST._IResolvedType _source49 = _1258___mcc_h478;
                if (_source49.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1259___mcc_h482 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1260_recursiveGen;
                    bool _1261_recOwned;
                    bool _1262_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1263_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out751;
                    bool _out752;
                    bool _out753;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out754;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out751, out _out752, out _out753, out _out754);
                    _1260_recursiveGen = _out751;
                    _1261_recOwned = _out752;
                    _1262_recErased = _out753;
                    _1263_recIdents = _out754;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1260_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1261_recOwned;
                    isErased = _1262_recErased;
                    readIdents = _1263_recIdents;
                  }
                } else if (_source49.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1264___mcc_h484 = _source49.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1265_recursiveGen;
                    bool _1266_recOwned;
                    bool _1267_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1268_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out755;
                    bool _out756;
                    bool _out757;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out758;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out755, out _out756, out _out757, out _out758);
                    _1265_recursiveGen = _out755;
                    _1266_recOwned = _out756;
                    _1267_recErased = _out757;
                    _1268_recIdents = _out758;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1265_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1266_recOwned;
                    isErased = _1267_recErased;
                    readIdents = _1268_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1269_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out759;
                    _out759 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                    _1269_tpeGen = _out759;
                    Dafny.ISequence<Dafny.Rune> _1270_recursiveGen;
                    bool _1271_recOwned;
                    bool _1272_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1273_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out760;
                    bool _out761;
                    bool _out762;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out763;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out760, out _out761, out _out762, out _out763);
                    _1270_recursiveGen = _out760;
                    _1271_recOwned = _out761;
                    _1272_recErased = _out762;
                    _1273_recIdents = _out763;
                    Dafny.ISequence<Dafny.Rune> _1274_uneraseFn;
                    _1274_uneraseFn = ((_1271_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1269_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1274_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1270_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1271_recOwned;
                    isErased = false;
                    readIdents = _1273_recIdents;
                  }
                }
              } else if (_source48.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1275___mcc_h486 = _source48.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1276_recursiveGen;
                  bool _1277_recOwned;
                  bool _1278_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1279_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out764;
                  bool _out765;
                  bool _out766;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out767;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out764, out _out765, out _out766, out _out767);
                  _1276_recursiveGen = _out764;
                  _1277_recOwned = _out765;
                  _1278_recErased = _out766;
                  _1279_recIdents = _out767;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1276_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1277_recOwned;
                  isErased = _1278_recErased;
                  readIdents = _1279_recIdents;
                }
              } else if (_source48.is_Array) {
                DAST._IType _1280___mcc_h488 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1281_recursiveGen;
                  bool _1282_recOwned;
                  bool _1283_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1284_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out768;
                  bool _out769;
                  bool _out770;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out771;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out768, out _out769, out _out770, out _out771);
                  _1281_recursiveGen = _out768;
                  _1282_recOwned = _out769;
                  _1283_recErased = _out770;
                  _1284_recIdents = _out771;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1281_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1282_recOwned;
                  isErased = _1283_recErased;
                  readIdents = _1284_recIdents;
                }
              } else if (_source48.is_Seq) {
                DAST._IType _1285___mcc_h490 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1286_recursiveGen;
                  bool _1287_recOwned;
                  bool _1288_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1289_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out772;
                  bool _out773;
                  bool _out774;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out775;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out772, out _out773, out _out774, out _out775);
                  _1286_recursiveGen = _out772;
                  _1287_recOwned = _out773;
                  _1288_recErased = _out774;
                  _1289_recIdents = _out775;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1286_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1287_recOwned;
                  isErased = _1288_recErased;
                  readIdents = _1289_recIdents;
                }
              } else if (_source48.is_Set) {
                DAST._IType _1290___mcc_h492 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1291_recursiveGen;
                  bool _1292_recOwned;
                  bool _1293_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1294_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out776;
                  bool _out777;
                  bool _out778;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out779;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out776, out _out777, out _out778, out _out779);
                  _1291_recursiveGen = _out776;
                  _1292_recOwned = _out777;
                  _1293_recErased = _out778;
                  _1294_recIdents = _out779;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1291_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1292_recOwned;
                  isErased = _1293_recErased;
                  readIdents = _1294_recIdents;
                }
              } else if (_source48.is_Multiset) {
                DAST._IType _1295___mcc_h494 = _source48.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1296_recursiveGen;
                  bool _1297_recOwned;
                  bool _1298_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1299_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out780;
                  bool _out781;
                  bool _out782;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out783;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out780, out _out781, out _out782, out _out783);
                  _1296_recursiveGen = _out780;
                  _1297_recOwned = _out781;
                  _1298_recErased = _out782;
                  _1299_recIdents = _out783;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1296_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1297_recOwned;
                  isErased = _1298_recErased;
                  readIdents = _1299_recIdents;
                }
              } else if (_source48.is_Map) {
                DAST._IType _1300___mcc_h496 = _source48.dtor_key;
                DAST._IType _1301___mcc_h497 = _source48.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1302_recursiveGen;
                  bool _1303_recOwned;
                  bool _1304_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1305_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out784;
                  bool _out785;
                  bool _out786;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out787;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out784, out _out785, out _out786, out _out787);
                  _1302_recursiveGen = _out784;
                  _1303_recOwned = _out785;
                  _1304_recErased = _out786;
                  _1305_recIdents = _out787;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1302_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1303_recOwned;
                  isErased = _1304_recErased;
                  readIdents = _1305_recIdents;
                }
              } else if (_source48.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1306___mcc_h500 = _source48.dtor_args;
                DAST._IType _1307___mcc_h501 = _source48.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1308_recursiveGen;
                  bool _1309_recOwned;
                  bool _1310_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1311_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out788;
                  bool _out789;
                  bool _out790;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out791;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out788, out _out789, out _out790, out _out791);
                  _1308_recursiveGen = _out788;
                  _1309_recOwned = _out789;
                  _1310_recErased = _out790;
                  _1311_recIdents = _out791;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1308_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1309_recOwned;
                  isErased = _1310_recErased;
                  readIdents = _1311_recIdents;
                }
              } else if (_source48.is_Primitive) {
                DAST._IPrimitive _1312___mcc_h504 = _source48.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1313_recursiveGen;
                  bool _1314_recOwned;
                  bool _1315_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1316_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out792;
                  bool _out793;
                  bool _out794;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out795;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out792, out _out793, out _out794, out _out795);
                  _1313_recursiveGen = _out792;
                  _1314_recOwned = _out793;
                  _1315_recErased = _out794;
                  _1316_recIdents = _out795;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1313_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1314_recOwned;
                  isErased = _1315_recErased;
                  readIdents = _1316_recIdents;
                }
              } else if (_source48.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1317___mcc_h506 = _source48.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1318_recursiveGen;
                  bool _1319_recOwned;
                  bool _1320_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1321_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out796;
                  bool _out797;
                  bool _out798;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out799;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out796, out _out797, out _out798, out _out799);
                  _1318_recursiveGen = _out796;
                  _1319_recOwned = _out797;
                  _1320_recErased = _out798;
                  _1321_recIdents = _out799;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1318_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1319_recOwned;
                  isErased = _1320_recErased;
                  readIdents = _1321_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1322___mcc_h508 = _source48.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1323_recursiveGen;
                  bool _1324_recOwned;
                  bool _1325_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1326_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out800;
                  bool _out801;
                  bool _out802;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out803;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out800, out _out801, out _out802, out _out803);
                  _1323_recursiveGen = _out800;
                  _1324_recOwned = _out801;
                  _1325_recErased = _out802;
                  _1326_recIdents = _out803;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1323_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1324_recOwned;
                  isErased = _1325_recErased;
                  readIdents = _1326_recIdents;
                }
              }
            } else {
              DAST._IType _source50 = _429___mcc_h60;
              if (_source50.is_Path) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1327___mcc_h510 = _source50.dtor_Path_a0;
                Dafny.ISequence<DAST._IType> _1328___mcc_h511 = _source50.dtor_typeArgs;
                DAST._IResolvedType _1329___mcc_h512 = _source50.dtor_resolved;
                DAST._IResolvedType _source51 = _1329___mcc_h512;
                if (_source51.is_Datatype) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1330___mcc_h516 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1331_recursiveGen;
                    bool _1332_recOwned;
                    bool _1333_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1334_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out804;
                    bool _out805;
                    bool _out806;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out807;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out804, out _out805, out _out806, out _out807);
                    _1331_recursiveGen = _out804;
                    _1332_recOwned = _out805;
                    _1333_recErased = _out806;
                    _1334_recIdents = _out807;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1331_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1332_recOwned;
                    isErased = _1333_recErased;
                    readIdents = _1334_recIdents;
                  }
                } else if (_source51.is_Trait) {
                  Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1335___mcc_h518 = _source51.dtor_path;
                  {
                    Dafny.ISequence<Dafny.Rune> _1336_recursiveGen;
                    bool _1337_recOwned;
                    bool _1338_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1339_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out808;
                    bool _out809;
                    bool _out810;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out811;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out808, out _out809, out _out810, out _out811);
                    _1336_recursiveGen = _out808;
                    _1337_recOwned = _out809;
                    _1338_recErased = _out810;
                    _1339_recIdents = _out811;
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1336_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                    isOwned = _1337_recOwned;
                    isErased = _1338_recErased;
                    readIdents = _1339_recIdents;
                  }
                } else {
                  {
                    Dafny.ISequence<Dafny.Rune> _1340_tpeGen;
                    Dafny.ISequence<Dafny.Rune> _out812;
                    _out812 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                    _1340_tpeGen = _out812;
                    Dafny.ISequence<Dafny.Rune> _1341_recursiveGen;
                    bool _1342_recOwned;
                    bool _1343_recErased;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1344_recIdents;
                    Dafny.ISequence<Dafny.Rune> _out813;
                    bool _out814;
                    bool _out815;
                    Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out816;
                    DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out813, out _out814, out _out815, out _out816);
                    _1341_recursiveGen = _out813;
                    _1342_recOwned = _out814;
                    _1343_recErased = _out815;
                    _1344_recIdents = _out816;
                    Dafny.ISequence<Dafny.Rune> _1345_uneraseFn;
                    _1345_uneraseFn = ((_1342_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                    s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1340_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1345_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1341_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                    isOwned = _1342_recOwned;
                    isErased = false;
                    readIdents = _1344_recIdents;
                  }
                }
              } else if (_source50.is_Tuple) {
                Dafny.ISequence<DAST._IType> _1346___mcc_h520 = _source50.dtor_Tuple_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1347_recursiveGen;
                  bool _1348_recOwned;
                  bool _1349_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1350_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out817;
                  bool _out818;
                  bool _out819;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out820;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out817, out _out818, out _out819, out _out820);
                  _1347_recursiveGen = _out817;
                  _1348_recOwned = _out818;
                  _1349_recErased = _out819;
                  _1350_recIdents = _out820;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1347_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1348_recOwned;
                  isErased = _1349_recErased;
                  readIdents = _1350_recIdents;
                }
              } else if (_source50.is_Array) {
                DAST._IType _1351___mcc_h522 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1352_recursiveGen;
                  bool _1353_recOwned;
                  bool _1354_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1355_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out821;
                  bool _out822;
                  bool _out823;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out824;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out821, out _out822, out _out823, out _out824);
                  _1352_recursiveGen = _out821;
                  _1353_recOwned = _out822;
                  _1354_recErased = _out823;
                  _1355_recIdents = _out824;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1352_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1353_recOwned;
                  isErased = _1354_recErased;
                  readIdents = _1355_recIdents;
                }
              } else if (_source50.is_Seq) {
                DAST._IType _1356___mcc_h524 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1357_recursiveGen;
                  bool _1358_recOwned;
                  bool _1359_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1360_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out825;
                  bool _out826;
                  bool _out827;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out828;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out825, out _out826, out _out827, out _out828);
                  _1357_recursiveGen = _out825;
                  _1358_recOwned = _out826;
                  _1359_recErased = _out827;
                  _1360_recIdents = _out828;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1357_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1358_recOwned;
                  isErased = _1359_recErased;
                  readIdents = _1360_recIdents;
                }
              } else if (_source50.is_Set) {
                DAST._IType _1361___mcc_h526 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1362_recursiveGen;
                  bool _1363_recOwned;
                  bool _1364_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1365_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out829;
                  bool _out830;
                  bool _out831;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out832;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out829, out _out830, out _out831, out _out832);
                  _1362_recursiveGen = _out829;
                  _1363_recOwned = _out830;
                  _1364_recErased = _out831;
                  _1365_recIdents = _out832;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1362_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1363_recOwned;
                  isErased = _1364_recErased;
                  readIdents = _1365_recIdents;
                }
              } else if (_source50.is_Multiset) {
                DAST._IType _1366___mcc_h528 = _source50.dtor_element;
                {
                  Dafny.ISequence<Dafny.Rune> _1367_recursiveGen;
                  bool _1368_recOwned;
                  bool _1369_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1370_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out833;
                  bool _out834;
                  bool _out835;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out836;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out833, out _out834, out _out835, out _out836);
                  _1367_recursiveGen = _out833;
                  _1368_recOwned = _out834;
                  _1369_recErased = _out835;
                  _1370_recIdents = _out836;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1367_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1368_recOwned;
                  isErased = _1369_recErased;
                  readIdents = _1370_recIdents;
                }
              } else if (_source50.is_Map) {
                DAST._IType _1371___mcc_h530 = _source50.dtor_key;
                DAST._IType _1372___mcc_h531 = _source50.dtor_value;
                {
                  Dafny.ISequence<Dafny.Rune> _1373_recursiveGen;
                  bool _1374_recOwned;
                  bool _1375_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1376_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out837;
                  bool _out838;
                  bool _out839;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out840;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out837, out _out838, out _out839, out _out840);
                  _1373_recursiveGen = _out837;
                  _1374_recOwned = _out838;
                  _1375_recErased = _out839;
                  _1376_recIdents = _out840;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1373_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1374_recOwned;
                  isErased = _1375_recErased;
                  readIdents = _1376_recIdents;
                }
              } else if (_source50.is_Arrow) {
                Dafny.ISequence<DAST._IType> _1377___mcc_h534 = _source50.dtor_args;
                DAST._IType _1378___mcc_h535 = _source50.dtor_result;
                {
                  Dafny.ISequence<Dafny.Rune> _1379_recursiveGen;
                  bool _1380_recOwned;
                  bool _1381_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1382_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out841;
                  bool _out842;
                  bool _out843;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out844;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out841, out _out842, out _out843, out _out844);
                  _1379_recursiveGen = _out841;
                  _1380_recOwned = _out842;
                  _1381_recErased = _out843;
                  _1382_recIdents = _out844;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1379_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1380_recOwned;
                  isErased = _1381_recErased;
                  readIdents = _1382_recIdents;
                }
              } else if (_source50.is_Primitive) {
                DAST._IPrimitive _1383___mcc_h538 = _source50.dtor_Primitive_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1384_recursiveGen;
                  bool _1385_recOwned;
                  bool _1386_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1387_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out845;
                  bool _out846;
                  bool _out847;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out848;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out845, out _out846, out _out847, out _out848);
                  _1384_recursiveGen = _out845;
                  _1385_recOwned = _out846;
                  _1386_recErased = _out847;
                  _1387_recIdents = _out848;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1384_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1385_recOwned;
                  isErased = _1386_recErased;
                  readIdents = _1387_recIdents;
                }
              } else if (_source50.is_Passthrough) {
                Dafny.ISequence<Dafny.Rune> _1388___mcc_h540 = _source50.dtor_Passthrough_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1389_recursiveGen;
                  bool _1390_recOwned;
                  bool _1391_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1392_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out849;
                  bool _out850;
                  bool _out851;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out852;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out849, out _out850, out _out851, out _out852);
                  _1389_recursiveGen = _out849;
                  _1390_recOwned = _out850;
                  _1391_recErased = _out851;
                  _1392_recIdents = _out852;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1389_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1390_recOwned;
                  isErased = _1391_recErased;
                  readIdents = _1392_recIdents;
                }
              } else {
                Dafny.ISequence<Dafny.Rune> _1393___mcc_h542 = _source50.dtor_TypeArg_a0;
                {
                  Dafny.ISequence<Dafny.Rune> _1394_recursiveGen;
                  bool _1395_recOwned;
                  bool _1396_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1397_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out853;
                  bool _out854;
                  bool _out855;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out856;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out853, out _out854, out _out855, out _out856);
                  _1394_recursiveGen = _out853;
                  _1395_recOwned = _out854;
                  _1396_recErased = _out855;
                  _1397_recIdents = _out856;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1394_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1395_recOwned;
                  isErased = _1396_recErased;
                  readIdents = _1397_recIdents;
                }
              }
            }
          } else if (_source22.is_Passthrough) {
            Dafny.ISequence<Dafny.Rune> _1398___mcc_h544 = _source22.dtor_Passthrough_a0;
            DAST._IType _source52 = _429___mcc_h60;
            if (_source52.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1399___mcc_h547 = _source52.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _1400___mcc_h548 = _source52.dtor_typeArgs;
              DAST._IResolvedType _1401___mcc_h549 = _source52.dtor_resolved;
              DAST._IResolvedType _source53 = _1401___mcc_h549;
              if (_source53.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1402___mcc_h553 = _source53.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1403_recursiveGen;
                  bool _1404_recOwned;
                  bool _1405_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1406_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out857;
                  bool _out858;
                  bool _out859;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out860;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out857, out _out858, out _out859, out _out860);
                  _1403_recursiveGen = _out857;
                  _1404_recOwned = _out858;
                  _1405_recErased = _out859;
                  _1406_recIdents = _out860;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1403_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1404_recOwned;
                  isErased = _1405_recErased;
                  readIdents = _1406_recIdents;
                }
              } else if (_source53.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1407___mcc_h555 = _source53.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1408_recursiveGen;
                  bool _1409_recOwned;
                  bool _1410_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1411_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out861;
                  bool _out862;
                  bool _out863;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out864;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out861, out _out862, out _out863, out _out864);
                  _1408_recursiveGen = _out861;
                  _1409_recOwned = _out862;
                  _1410_recErased = _out863;
                  _1411_recIdents = _out864;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1408_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1409_recOwned;
                  isErased = _1410_recErased;
                  readIdents = _1411_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _1412_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out865;
                  _out865 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _1412_tpeGen = _out865;
                  Dafny.ISequence<Dafny.Rune> _1413_recursiveGen;
                  bool _1414_recOwned;
                  bool _1415_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1416_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out866;
                  bool _out867;
                  bool _out868;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out869;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out866, out _out867, out _out868, out _out869);
                  _1413_recursiveGen = _out866;
                  _1414_recOwned = _out867;
                  _1415_recErased = _out868;
                  _1416_recIdents = _out869;
                  Dafny.ISequence<Dafny.Rune> _1417_uneraseFn;
                  _1417_uneraseFn = ((_1414_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1412_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1417_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1413_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _1414_recOwned;
                  isErased = false;
                  readIdents = _1416_recIdents;
                }
              }
            } else if (_source52.is_Tuple) {
              Dafny.ISequence<DAST._IType> _1418___mcc_h557 = _source52.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1419_recursiveGen;
                bool _1420_recOwned;
                bool _1421_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1422_recIdents;
                Dafny.ISequence<Dafny.Rune> _out870;
                bool _out871;
                bool _out872;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out873;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out870, out _out871, out _out872, out _out873);
                _1419_recursiveGen = _out870;
                _1420_recOwned = _out871;
                _1421_recErased = _out872;
                _1422_recIdents = _out873;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1419_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1420_recOwned;
                isErased = _1421_recErased;
                readIdents = _1422_recIdents;
              }
            } else if (_source52.is_Array) {
              DAST._IType _1423___mcc_h559 = _source52.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1424_recursiveGen;
                bool _1425_recOwned;
                bool _1426_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1427_recIdents;
                Dafny.ISequence<Dafny.Rune> _out874;
                bool _out875;
                bool _out876;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out877;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out874, out _out875, out _out876, out _out877);
                _1424_recursiveGen = _out874;
                _1425_recOwned = _out875;
                _1426_recErased = _out876;
                _1427_recIdents = _out877;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1424_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1425_recOwned;
                isErased = _1426_recErased;
                readIdents = _1427_recIdents;
              }
            } else if (_source52.is_Seq) {
              DAST._IType _1428___mcc_h561 = _source52.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1429_recursiveGen;
                bool _1430_recOwned;
                bool _1431_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1432_recIdents;
                Dafny.ISequence<Dafny.Rune> _out878;
                bool _out879;
                bool _out880;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out881;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out878, out _out879, out _out880, out _out881);
                _1429_recursiveGen = _out878;
                _1430_recOwned = _out879;
                _1431_recErased = _out880;
                _1432_recIdents = _out881;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1429_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1430_recOwned;
                isErased = _1431_recErased;
                readIdents = _1432_recIdents;
              }
            } else if (_source52.is_Set) {
              DAST._IType _1433___mcc_h563 = _source52.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1434_recursiveGen;
                bool _1435_recOwned;
                bool _1436_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1437_recIdents;
                Dafny.ISequence<Dafny.Rune> _out882;
                bool _out883;
                bool _out884;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out885;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out882, out _out883, out _out884, out _out885);
                _1434_recursiveGen = _out882;
                _1435_recOwned = _out883;
                _1436_recErased = _out884;
                _1437_recIdents = _out885;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1434_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1435_recOwned;
                isErased = _1436_recErased;
                readIdents = _1437_recIdents;
              }
            } else if (_source52.is_Multiset) {
              DAST._IType _1438___mcc_h565 = _source52.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1439_recursiveGen;
                bool _1440_recOwned;
                bool _1441_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1442_recIdents;
                Dafny.ISequence<Dafny.Rune> _out886;
                bool _out887;
                bool _out888;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out889;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out886, out _out887, out _out888, out _out889);
                _1439_recursiveGen = _out886;
                _1440_recOwned = _out887;
                _1441_recErased = _out888;
                _1442_recIdents = _out889;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1439_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1440_recOwned;
                isErased = _1441_recErased;
                readIdents = _1442_recIdents;
              }
            } else if (_source52.is_Map) {
              DAST._IType _1443___mcc_h567 = _source52.dtor_key;
              DAST._IType _1444___mcc_h568 = _source52.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _1445_recursiveGen;
                bool _1446_recOwned;
                bool _1447_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1448_recIdents;
                Dafny.ISequence<Dafny.Rune> _out890;
                bool _out891;
                bool _out892;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out893;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out890, out _out891, out _out892, out _out893);
                _1445_recursiveGen = _out890;
                _1446_recOwned = _out891;
                _1447_recErased = _out892;
                _1448_recIdents = _out893;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1445_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1446_recOwned;
                isErased = _1447_recErased;
                readIdents = _1448_recIdents;
              }
            } else if (_source52.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1449___mcc_h571 = _source52.dtor_args;
              DAST._IType _1450___mcc_h572 = _source52.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _1451_recursiveGen;
                bool _1452_recOwned;
                bool _1453_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1454_recIdents;
                Dafny.ISequence<Dafny.Rune> _out894;
                bool _out895;
                bool _out896;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out897;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out894, out _out895, out _out896, out _out897);
                _1451_recursiveGen = _out894;
                _1452_recOwned = _out895;
                _1453_recErased = _out896;
                _1454_recIdents = _out897;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1451_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1452_recOwned;
                isErased = _1453_recErased;
                readIdents = _1454_recIdents;
              }
            } else if (_source52.is_Primitive) {
              DAST._IPrimitive _1455___mcc_h575 = _source52.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1456_recursiveGen;
                bool _1457_recOwned;
                bool _1458_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1459_recIdents;
                Dafny.ISequence<Dafny.Rune> _out898;
                bool _out899;
                bool _out900;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out901;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out898, out _out899, out _out900, out _out901);
                _1456_recursiveGen = _out898;
                _1457_recOwned = _out899;
                _1458_recErased = _out900;
                _1459_recIdents = _out901;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1456_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1457_recOwned;
                isErased = _1458_recErased;
                readIdents = _1459_recIdents;
              }
            } else if (_source52.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1460___mcc_h577 = _source52.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1461_recursiveGen;
                bool _1462___v40;
                bool _1463___v41;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1464_recIdents;
                Dafny.ISequence<Dafny.Rune> _out902;
                bool _out903;
                bool _out904;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out905;
                DCOMP.COMP.GenExpr(_427_expr, @params, true, out _out902, out _out903, out _out904, out _out905);
                _1461_recursiveGen = _out902;
                _1462___v40 = _out903;
                _1463___v41 = _out904;
                _1464_recIdents = _out905;
                Dafny.ISequence<Dafny.Rune> _1465_toTpeGen;
                Dafny.ISequence<Dafny.Rune> _out906;
                _out906 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                _1465_toTpeGen = _out906;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1461_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(") as ")), _1465_toTpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                isOwned = true;
                isErased = true;
                readIdents = _1464_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1466___mcc_h579 = _source52.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1467_recursiveGen;
                bool _1468_recOwned;
                bool _1469_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1470_recIdents;
                Dafny.ISequence<Dafny.Rune> _out907;
                bool _out908;
                bool _out909;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out910;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out907, out _out908, out _out909, out _out910);
                _1467_recursiveGen = _out907;
                _1468_recOwned = _out908;
                _1469_recErased = _out909;
                _1470_recIdents = _out910;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1467_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1468_recOwned;
                isErased = _1469_recErased;
                readIdents = _1470_recIdents;
              }
            }
          } else {
            Dafny.ISequence<Dafny.Rune> _1471___mcc_h581 = _source22.dtor_TypeArg_a0;
            DAST._IType _source54 = _429___mcc_h60;
            if (_source54.is_Path) {
              Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1472___mcc_h584 = _source54.dtor_Path_a0;
              Dafny.ISequence<DAST._IType> _1473___mcc_h585 = _source54.dtor_typeArgs;
              DAST._IResolvedType _1474___mcc_h586 = _source54.dtor_resolved;
              DAST._IResolvedType _source55 = _1474___mcc_h586;
              if (_source55.is_Datatype) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1475___mcc_h590 = _source55.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1476_recursiveGen;
                  bool _1477_recOwned;
                  bool _1478_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1479_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out911;
                  bool _out912;
                  bool _out913;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out914;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out911, out _out912, out _out913, out _out914);
                  _1476_recursiveGen = _out911;
                  _1477_recOwned = _out912;
                  _1478_recErased = _out913;
                  _1479_recIdents = _out914;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1476_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1477_recOwned;
                  isErased = _1478_recErased;
                  readIdents = _1479_recIdents;
                }
              } else if (_source55.is_Trait) {
                Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1480___mcc_h592 = _source55.dtor_path;
                {
                  Dafny.ISequence<Dafny.Rune> _1481_recursiveGen;
                  bool _1482_recOwned;
                  bool _1483_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1484_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out915;
                  bool _out916;
                  bool _out917;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out918;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out915, out _out916, out _out917, out _out918);
                  _1481_recursiveGen = _out915;
                  _1482_recOwned = _out916;
                  _1483_recErased = _out917;
                  _1484_recIdents = _out918;
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1481_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                  isOwned = _1482_recOwned;
                  isErased = _1483_recErased;
                  readIdents = _1484_recIdents;
                }
              } else {
                {
                  Dafny.ISequence<Dafny.Rune> _1485_tpeGen;
                  Dafny.ISequence<Dafny.Rune> _out919;
                  _out919 = DCOMP.COMP.GenType(_425_toTpe, true, false);
                  _1485_tpeGen = _out919;
                  Dafny.ISequence<Dafny.Rune> _1486_recursiveGen;
                  bool _1487_recOwned;
                  bool _1488_recErased;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1489_recIdents;
                  Dafny.ISequence<Dafny.Rune> _out920;
                  bool _out921;
                  bool _out922;
                  Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out923;
                  DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out920, out _out921, out _out922, out _out923);
                  _1486_recursiveGen = _out920;
                  _1487_recOwned = _out921;
                  _1488_recErased = _out922;
                  _1489_recIdents = _out923;
                  Dafny.ISequence<Dafny.Rune> _1490_uneraseFn;
                  _1490_uneraseFn = ((_1487_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
                  s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1485_tpeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as ::dafny_runtime::DafnyUnerasable<_>>::")), _1490_uneraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1486_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
                  isOwned = _1487_recOwned;
                  isErased = false;
                  readIdents = _1489_recIdents;
                }
              }
            } else if (_source54.is_Tuple) {
              Dafny.ISequence<DAST._IType> _1491___mcc_h594 = _source54.dtor_Tuple_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1492_recursiveGen;
                bool _1493_recOwned;
                bool _1494_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1495_recIdents;
                Dafny.ISequence<Dafny.Rune> _out924;
                bool _out925;
                bool _out926;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out927;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out924, out _out925, out _out926, out _out927);
                _1492_recursiveGen = _out924;
                _1493_recOwned = _out925;
                _1494_recErased = _out926;
                _1495_recIdents = _out927;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1492_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1493_recOwned;
                isErased = _1494_recErased;
                readIdents = _1495_recIdents;
              }
            } else if (_source54.is_Array) {
              DAST._IType _1496___mcc_h596 = _source54.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1497_recursiveGen;
                bool _1498_recOwned;
                bool _1499_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1500_recIdents;
                Dafny.ISequence<Dafny.Rune> _out928;
                bool _out929;
                bool _out930;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out931;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out928, out _out929, out _out930, out _out931);
                _1497_recursiveGen = _out928;
                _1498_recOwned = _out929;
                _1499_recErased = _out930;
                _1500_recIdents = _out931;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1497_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1498_recOwned;
                isErased = _1499_recErased;
                readIdents = _1500_recIdents;
              }
            } else if (_source54.is_Seq) {
              DAST._IType _1501___mcc_h598 = _source54.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1502_recursiveGen;
                bool _1503_recOwned;
                bool _1504_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1505_recIdents;
                Dafny.ISequence<Dafny.Rune> _out932;
                bool _out933;
                bool _out934;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out935;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out932, out _out933, out _out934, out _out935);
                _1502_recursiveGen = _out932;
                _1503_recOwned = _out933;
                _1504_recErased = _out934;
                _1505_recIdents = _out935;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1502_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1503_recOwned;
                isErased = _1504_recErased;
                readIdents = _1505_recIdents;
              }
            } else if (_source54.is_Set) {
              DAST._IType _1506___mcc_h600 = _source54.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1507_recursiveGen;
                bool _1508_recOwned;
                bool _1509_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1510_recIdents;
                Dafny.ISequence<Dafny.Rune> _out936;
                bool _out937;
                bool _out938;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out939;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out936, out _out937, out _out938, out _out939);
                _1507_recursiveGen = _out936;
                _1508_recOwned = _out937;
                _1509_recErased = _out938;
                _1510_recIdents = _out939;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1507_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1508_recOwned;
                isErased = _1509_recErased;
                readIdents = _1510_recIdents;
              }
            } else if (_source54.is_Multiset) {
              DAST._IType _1511___mcc_h602 = _source54.dtor_element;
              {
                Dafny.ISequence<Dafny.Rune> _1512_recursiveGen;
                bool _1513_recOwned;
                bool _1514_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1515_recIdents;
                Dafny.ISequence<Dafny.Rune> _out940;
                bool _out941;
                bool _out942;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out943;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out940, out _out941, out _out942, out _out943);
                _1512_recursiveGen = _out940;
                _1513_recOwned = _out941;
                _1514_recErased = _out942;
                _1515_recIdents = _out943;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1512_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1513_recOwned;
                isErased = _1514_recErased;
                readIdents = _1515_recIdents;
              }
            } else if (_source54.is_Map) {
              DAST._IType _1516___mcc_h604 = _source54.dtor_key;
              DAST._IType _1517___mcc_h605 = _source54.dtor_value;
              {
                Dafny.ISequence<Dafny.Rune> _1518_recursiveGen;
                bool _1519_recOwned;
                bool _1520_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1521_recIdents;
                Dafny.ISequence<Dafny.Rune> _out944;
                bool _out945;
                bool _out946;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out947;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out944, out _out945, out _out946, out _out947);
                _1518_recursiveGen = _out944;
                _1519_recOwned = _out945;
                _1520_recErased = _out946;
                _1521_recIdents = _out947;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1518_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1519_recOwned;
                isErased = _1520_recErased;
                readIdents = _1521_recIdents;
              }
            } else if (_source54.is_Arrow) {
              Dafny.ISequence<DAST._IType> _1522___mcc_h608 = _source54.dtor_args;
              DAST._IType _1523___mcc_h609 = _source54.dtor_result;
              {
                Dafny.ISequence<Dafny.Rune> _1524_recursiveGen;
                bool _1525_recOwned;
                bool _1526_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1527_recIdents;
                Dafny.ISequence<Dafny.Rune> _out948;
                bool _out949;
                bool _out950;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out951;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out948, out _out949, out _out950, out _out951);
                _1524_recursiveGen = _out948;
                _1525_recOwned = _out949;
                _1526_recErased = _out950;
                _1527_recIdents = _out951;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1524_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1525_recOwned;
                isErased = _1526_recErased;
                readIdents = _1527_recIdents;
              }
            } else if (_source54.is_Primitive) {
              DAST._IPrimitive _1528___mcc_h612 = _source54.dtor_Primitive_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1529_recursiveGen;
                bool _1530_recOwned;
                bool _1531_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1532_recIdents;
                Dafny.ISequence<Dafny.Rune> _out952;
                bool _out953;
                bool _out954;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out955;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out952, out _out953, out _out954, out _out955);
                _1529_recursiveGen = _out952;
                _1530_recOwned = _out953;
                _1531_recErased = _out954;
                _1532_recIdents = _out955;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1529_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1530_recOwned;
                isErased = _1531_recErased;
                readIdents = _1532_recIdents;
              }
            } else if (_source54.is_Passthrough) {
              Dafny.ISequence<Dafny.Rune> _1533___mcc_h614 = _source54.dtor_Passthrough_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1534_recursiveGen;
                bool _1535_recOwned;
                bool _1536_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1537_recIdents;
                Dafny.ISequence<Dafny.Rune> _out956;
                bool _out957;
                bool _out958;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out959;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out956, out _out957, out _out958, out _out959);
                _1534_recursiveGen = _out956;
                _1535_recOwned = _out957;
                _1536_recErased = _out958;
                _1537_recIdents = _out959;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1534_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1535_recOwned;
                isErased = _1536_recErased;
                readIdents = _1537_recIdents;
              }
            } else {
              Dafny.ISequence<Dafny.Rune> _1538___mcc_h616 = _source54.dtor_TypeArg_a0;
              {
                Dafny.ISequence<Dafny.Rune> _1539_recursiveGen;
                bool _1540_recOwned;
                bool _1541_recErased;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1542_recIdents;
                Dafny.ISequence<Dafny.Rune> _out960;
                bool _out961;
                bool _out962;
                Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out963;
                DCOMP.COMP.GenExpr(_427_expr, @params, false, out _out960, out _out961, out _out962, out _out963);
                _1539_recursiveGen = _out960;
                _1540_recOwned = _out961;
                _1541_recErased = _out962;
                _1542_recIdents = _out963;
                s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1539_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/* conversion not yet implemented */)"));
                isOwned = _1540_recOwned;
                isErased = _1541_recErased;
                readIdents = _1542_recIdents;
              }
            }
          }
        }
      } else if (_source19.is_SubsetDowngrade) {
        DAST._IExpression _1543___mcc_h20 = _source19.dtor_value;
        DAST._IExpression _1544_expr = _1543___mcc_h20;
        {
          Dafny.ISequence<Dafny.Rune> _1545_recursiveGen;
          bool _1546_recOwned;
          bool _1547_recErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1548_recIdents;
          Dafny.ISequence<Dafny.Rune> _out964;
          bool _out965;
          bool _out966;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out967;
          DCOMP.COMP.GenExpr(_1544_expr, @params, false, out _out964, out _out965, out _out966, out _out967);
          _1545_recursiveGen = _out964;
          _1546_recOwned = _out965;
          _1547_recErased = _out966;
          _1548_recIdents = _out967;
          Dafny.ISequence<Dafny.Rune> _1549_eraseFn;
          _1549_eraseFn = ((_1546_recOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1549_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1545_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = _1546_recOwned;
          isErased = true;
          readIdents = _1548_recIdents;
        }
      } else if (_source19.is_SeqValue) {
        Dafny.ISequence<DAST._IExpression> _1550___mcc_h21 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1551_exprs = _1550___mcc_h21;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1552_generatedValues;
          _1552_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1553_i;
          _1553_i = BigInteger.Zero;
          bool _1554_allErased;
          _1554_allErased = true;
          while ((_1553_i) < (new BigInteger((_1551_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1555_recursiveGen;
            bool _1556___v43;
            bool _1557_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1558_recIdents;
            Dafny.ISequence<Dafny.Rune> _out968;
            bool _out969;
            bool _out970;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out971;
            DCOMP.COMP.GenExpr((_1551_exprs).Select(_1553_i), @params, true, out _out968, out _out969, out _out970, out _out971);
            _1555_recursiveGen = _out968;
            _1556___v43 = _out969;
            _1557_isErased = _out970;
            _1558_recIdents = _out971;
            _1554_allErased = (_1554_allErased) && (_1557_isErased);
            _1552_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1552_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1555_recursiveGen, _1557_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1558_recIdents);
            _1553_i = (_1553_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1553_i = BigInteger.Zero;
          while ((_1553_i) < (new BigInteger((_1552_generatedValues).Count))) {
            if ((_1553_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1559_gen;
            _1559_gen = ((_1552_generatedValues).Select(_1553_i)).dtor__0;
            if ((((_1552_generatedValues).Select(_1553_i)).dtor__1) && (!(_1554_allErased))) {
              _1559_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1559_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1559_gen);
            _1553_i = (_1553_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("]"));
          isOwned = true;
          isErased = _1554_allErased;
        }
      } else if (_source19.is_SetValue) {
        Dafny.ISequence<DAST._IExpression> _1560___mcc_h22 = _source19.dtor_elements;
        Dafny.ISequence<DAST._IExpression> _1561_exprs = _1560___mcc_h22;
        {
          Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>> _1562_generatedValues;
          _1562_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements();
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1563_i;
          _1563_i = BigInteger.Zero;
          bool _1564_allErased;
          _1564_allErased = true;
          while ((_1563_i) < (new BigInteger((_1561_exprs).Count))) {
            Dafny.ISequence<Dafny.Rune> _1565_recursiveGen;
            bool _1566___v44;
            bool _1567_isErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1568_recIdents;
            Dafny.ISequence<Dafny.Rune> _out972;
            bool _out973;
            bool _out974;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out975;
            DCOMP.COMP.GenExpr((_1561_exprs).Select(_1563_i), @params, true, out _out972, out _out973, out _out974, out _out975);
            _1565_recursiveGen = _out972;
            _1566___v44 = _out973;
            _1567_isErased = _out974;
            _1568_recIdents = _out975;
            _1564_allErased = (_1564_allErased) && (_1567_isErased);
            _1562_generatedValues = Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.Concat(_1562_generatedValues, Dafny.Sequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, bool>>.FromElements(_System.Tuple2<Dafny.ISequence<Dafny.Rune>, bool>.create(_1565_recursiveGen, _1567_isErased)));
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1568_recIdents);
            _1563_i = (_1563_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("vec![");
          _1563_i = BigInteger.Zero;
          while ((_1563_i) < (new BigInteger((_1562_generatedValues).Count))) {
            if ((_1563_i).Sign == 1) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1569_gen;
            _1569_gen = ((_1562_generatedValues).Select(_1563_i)).dtor__0;
            if ((((_1562_generatedValues).Select(_1563_i)).dtor__1) && (!(_1564_allErased))) {
              _1569_gen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::unerase_owned("), _1569_gen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1569_gen);
            _1563_i = (_1563_i) + (BigInteger.One);
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
        DAST._IExpression _1570___mcc_h23 = _source19.dtor_cond;
        DAST._IExpression _1571___mcc_h24 = _source19.dtor_thn;
        DAST._IExpression _1572___mcc_h25 = _source19.dtor_els;
        DAST._IExpression _1573_f = _1572___mcc_h25;
        DAST._IExpression _1574_t = _1571___mcc_h24;
        DAST._IExpression _1575_cond = _1570___mcc_h23;
        {
          Dafny.ISequence<Dafny.Rune> _1576_condString;
          bool _1577___v45;
          bool _1578_condErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1579_recIdentsCond;
          Dafny.ISequence<Dafny.Rune> _out976;
          bool _out977;
          bool _out978;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out979;
          DCOMP.COMP.GenExpr(_1575_cond, @params, true, out _out976, out _out977, out _out978, out _out979);
          _1576_condString = _out976;
          _1577___v45 = _out977;
          _1578_condErased = _out978;
          _1579_recIdentsCond = _out979;
          if (!(_1578_condErased)) {
            _1576_condString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1576_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          Dafny.ISequence<Dafny.Rune> _1580___v46;
          bool _1581_tHasToBeOwned;
          bool _1582___v47;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1583___v48;
          Dafny.ISequence<Dafny.Rune> _out980;
          bool _out981;
          bool _out982;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out983;
          DCOMP.COMP.GenExpr(_1574_t, @params, mustOwn, out _out980, out _out981, out _out982, out _out983);
          _1580___v46 = _out980;
          _1581_tHasToBeOwned = _out981;
          _1582___v47 = _out982;
          _1583___v48 = _out983;
          Dafny.ISequence<Dafny.Rune> _1584_fString;
          bool _1585_fOwned;
          bool _1586_fErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1587_recIdentsF;
          Dafny.ISequence<Dafny.Rune> _out984;
          bool _out985;
          bool _out986;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out987;
          DCOMP.COMP.GenExpr(_1573_f, @params, _1581_tHasToBeOwned, out _out984, out _out985, out _out986, out _out987);
          _1584_fString = _out984;
          _1585_fOwned = _out985;
          _1586_fErased = _out986;
          _1587_recIdentsF = _out987;
          Dafny.ISequence<Dafny.Rune> _1588_tString;
          bool _1589___v49;
          bool _1590_tErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1591_recIdentsT;
          Dafny.ISequence<Dafny.Rune> _out988;
          bool _out989;
          bool _out990;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out991;
          DCOMP.COMP.GenExpr(_1574_t, @params, _1585_fOwned, out _out988, out _out989, out _out990, out _out991);
          _1588_tString = _out988;
          _1589___v49 = _out989;
          _1590_tErased = _out990;
          _1591_recIdentsT = _out991;
          if ((!(_1586_fErased)) || (!(_1590_tErased))) {
            if (_1586_fErased) {
              _1584_fString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1584_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            if (_1590_tErased) {
              _1588_tString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1588_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(if "), _1576_condString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1588_tString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n} else {\n")), _1584_fString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})"));
          isOwned = _1585_fOwned;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1579_recIdentsCond, _1591_recIdentsT), _1587_recIdentsF);
          isErased = (_1586_fErased) || (_1590_tErased);
        }
      } else if (_source19.is_UnOp) {
        DAST._IUnaryOp _1592___mcc_h26 = _source19.dtor_unOp;
        DAST._IExpression _1593___mcc_h27 = _source19.dtor_expr;
        DAST._IUnaryOp _source56 = _1592___mcc_h26;
        if (_source56.is_Not) {
          DAST._IExpression _1594_e = _1593___mcc_h27;
          {
            Dafny.ISequence<Dafny.Rune> _1595_recursiveGen;
            bool _1596___v50;
            bool _1597_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1598_recIdents;
            Dafny.ISequence<Dafny.Rune> _out992;
            bool _out993;
            bool _out994;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out995;
            DCOMP.COMP.GenExpr(_1594_e, @params, true, out _out992, out _out993, out _out994, out _out995);
            _1595_recursiveGen = _out992;
            _1596___v50 = _out993;
            _1597_recErased = _out994;
            _1598_recIdents = _out995;
            if (!(_1597_recErased)) {
              _1595_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1595_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("!("), _1595_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1598_recIdents;
            isErased = true;
          }
        } else if (_source56.is_BitwiseNot) {
          DAST._IExpression _1599_e = _1593___mcc_h27;
          {
            Dafny.ISequence<Dafny.Rune> _1600_recursiveGen;
            bool _1601___v51;
            bool _1602_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1603_recIdents;
            Dafny.ISequence<Dafny.Rune> _out996;
            bool _out997;
            bool _out998;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out999;
            DCOMP.COMP.GenExpr(_1599_e, @params, true, out _out996, out _out997, out _out998, out _out999);
            _1600_recursiveGen = _out996;
            _1601___v51 = _out997;
            _1602_recErased = _out998;
            _1603_recIdents = _out999;
            if (!(_1602_recErased)) {
              _1600_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1600_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("~("), _1600_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            isOwned = true;
            readIdents = _1603_recIdents;
            isErased = true;
          }
        } else {
          DAST._IExpression _1604_e = _1593___mcc_h27;
          {
            Dafny.ISequence<Dafny.Rune> _1605_recursiveGen;
            bool _1606___v52;
            bool _1607_recErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1608_recIdents;
            Dafny.ISequence<Dafny.Rune> _out1000;
            bool _out1001;
            bool _out1002;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1003;
            DCOMP.COMP.GenExpr(_1604_e, @params, false, out _out1000, out _out1001, out _out1002, out _out1003);
            _1605_recursiveGen = _out1000;
            _1606___v52 = _out1001;
            _1607_recErased = _out1002;
            _1608_recIdents = _out1003;
            if (!(_1607_recErased)) {
              _1605_recursiveGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1605_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").len()"));
            isOwned = true;
            readIdents = _1608_recIdents;
            isErased = true;
          }
        }
      } else if (_source19.is_BinOp) {
        Dafny.ISequence<Dafny.Rune> _1609___mcc_h28 = _source19.dtor_op;
        DAST._IExpression _1610___mcc_h29 = _source19.dtor_left;
        DAST._IExpression _1611___mcc_h30 = _source19.dtor_right;
        DAST._IExpression _1612_r = _1611___mcc_h30;
        DAST._IExpression _1613_l = _1610___mcc_h29;
        Dafny.ISequence<Dafny.Rune> _1614_op = _1609___mcc_h28;
        {
          Dafny.ISequence<Dafny.Rune> _1615_left;
          bool _1616___v53;
          bool _1617_leftErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1618_recIdentsL;
          Dafny.ISequence<Dafny.Rune> _out1004;
          bool _out1005;
          bool _out1006;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1007;
          DCOMP.COMP.GenExpr(_1613_l, @params, true, out _out1004, out _out1005, out _out1006, out _out1007);
          _1615_left = _out1004;
          _1616___v53 = _out1005;
          _1617_leftErased = _out1006;
          _1618_recIdentsL = _out1007;
          Dafny.ISequence<Dafny.Rune> _1619_right;
          bool _1620___v54;
          bool _1621_rightErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1622_recIdentsR;
          Dafny.ISequence<Dafny.Rune> _out1008;
          bool _out1009;
          bool _out1010;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1011;
          DCOMP.COMP.GenExpr(_1612_r, @params, true, out _out1008, out _out1009, out _out1010, out _out1011);
          _1619_right = _out1008;
          _1620___v54 = _out1009;
          _1621_rightErased = _out1010;
          _1622_recIdentsR = _out1011;
          if (!(_1617_leftErased)) {
            _1615_left = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1615_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if (!(_1621_rightErased)) {
            _1619_right = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::erase_owned("), _1619_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1614_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("/"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_division("), _1615_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1619_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else if ((_1614_op).Equals(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("%"))) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::euclidian_modulo("), _1615_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", ")), _1619_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1615_left), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1614_op), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" ")), _1619_right), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          isOwned = true;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(_1618_recIdentsL, _1622_recIdentsR);
          isErased = true;
        }
      } else if (_source19.is_Select) {
        DAST._IExpression _1623___mcc_h31 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1624___mcc_h32 = _source19.dtor_field;
        bool _1625___mcc_h33 = _source19.dtor_isConstant;
        bool _1626___mcc_h34 = _source19.dtor_onDatatype;
        bool _1627_isDatatype = _1626___mcc_h34;
        bool _1628_isConstant = _1625___mcc_h33;
        Dafny.ISequence<Dafny.Rune> _1629_field = _1624___mcc_h32;
        DAST._IExpression _1630_on = _1623___mcc_h31;
        {
          Dafny.ISequence<Dafny.Rune> _1631_onString;
          bool _1632_onOwned;
          bool _1633_onErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1634_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1012;
          bool _out1013;
          bool _out1014;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1015;
          DCOMP.COMP.GenExpr(_1630_on, @params, false, out _out1012, out _out1013, out _out1014, out _out1015);
          _1631_onString = _out1012;
          _1632_onOwned = _out1013;
          _1633_onErased = _out1014;
          _1634_recIdents = _out1015;
          if (!(_1633_onErased)) {
            Dafny.ISequence<Dafny.Rune> _1635_eraseFn;
            _1635_eraseFn = ((_1632_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("erase")));
            _1631_onString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyErasable::"), _1635_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1631_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          if ((_1627_isDatatype) || (_1628_isConstant)) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1631_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1629_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("()"));
            if (_1628_isConstant) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            }
            if (mustOwn) {
              s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
              isOwned = true;
            } else {
              isOwned = false;
            }
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::ops::Deref::deref(&(("), _1631_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".r#")), _1629_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".borrow()))"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()"));
            isOwned = true;
          }
          isErased = false;
          readIdents = _1634_recIdents;
        }
      } else if (_source19.is_SelectFn) {
        DAST._IExpression _1636___mcc_h35 = _source19.dtor_expr;
        Dafny.ISequence<Dafny.Rune> _1637___mcc_h36 = _source19.dtor_field;
        bool _1638___mcc_h37 = _source19.dtor_onDatatype;
        bool _1639___mcc_h38 = _source19.dtor_isStatic;
        BigInteger _1640___mcc_h39 = _source19.dtor_arity;
        BigInteger _1641_arity = _1640___mcc_h39;
        bool _1642_isStatic = _1639___mcc_h38;
        bool _1643_isDatatype = _1638___mcc_h37;
        Dafny.ISequence<Dafny.Rune> _1644_field = _1637___mcc_h36;
        DAST._IExpression _1645_on = _1636___mcc_h35;
        {
          Dafny.ISequence<Dafny.Rune> _1646_onString;
          bool _1647_onOwned;
          bool _1648___v55;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1649_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1016;
          bool _out1017;
          bool _out1018;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1019;
          DCOMP.COMP.GenExpr(_1645_on, @params, false, out _out1016, out _out1017, out _out1018, out _out1019);
          _1646_onString = _out1016;
          _1647_onOwned = _out1017;
          _1648___v55 = _out1018;
          _1649_recIdents = _out1019;
          if (_1642_isStatic) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1646_onString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::")), _1644_field);
          } else {
            s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\n");
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let callTarget = (")), _1646_onString), ((_1647_onOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").clone()")))), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n"));
            Dafny.ISequence<Dafny.Rune> _1650_args;
            _1650_args = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
            BigInteger _1651_i;
            _1651_i = BigInteger.Zero;
            while ((_1651_i) < (_1641_arity)) {
              if ((_1651_i).Sign == 1) {
                _1650_args = Dafny.Sequence<Dafny.Rune>.Concat(_1650_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              _1650_args = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1650_args, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("arg")), DCOMP.__default.natToString(_1651_i));
              _1651_i = (_1651_i) + (BigInteger.One);
            }
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("move |")), _1650_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| {\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("callTarget.")), _1644_field), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1650_args), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}\n"));
            s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("}"));
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = true;
          readIdents = _1649_recIdents;
        }
      } else if (_source19.is_TupleSelect) {
        DAST._IExpression _1652___mcc_h40 = _source19.dtor_expr;
        BigInteger _1653___mcc_h41 = _source19.dtor_index;
        BigInteger _1654_idx = _1653___mcc_h41;
        DAST._IExpression _1655_on = _1652___mcc_h40;
        {
          Dafny.ISequence<Dafny.Rune> _1656_onString;
          bool _1657___v56;
          bool _1658_tupErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1659_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1020;
          bool _out1021;
          bool _out1022;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1023;
          DCOMP.COMP.GenExpr(_1655_on, @params, false, out _out1020, out _out1021, out _out1022, out _out1023);
          _1656_onString = _out1020;
          _1657___v56 = _out1021;
          _1658_tupErased = _out1022;
          _1659_recIdents = _out1023;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1656_onString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").")), DCOMP.__default.natToString(_1654_idx));
          if (mustOwn) {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), s), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone()"));
            isOwned = true;
          } else {
            s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), s);
            isOwned = false;
          }
          isErased = _1658_tupErased;
          readIdents = _1659_recIdents;
        }
      } else if (_source19.is_Call) {
        DAST._IExpression _1660___mcc_h42 = _source19.dtor_on;
        Dafny.ISequence<Dafny.Rune> _1661___mcc_h43 = _source19.dtor_name;
        Dafny.ISequence<DAST._IType> _1662___mcc_h44 = _source19.dtor_typeArgs;
        Dafny.ISequence<DAST._IExpression> _1663___mcc_h45 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1664_args = _1663___mcc_h45;
        Dafny.ISequence<DAST._IType> _1665_typeArgs = _1662___mcc_h44;
        Dafny.ISequence<Dafny.Rune> _1666_name = _1661___mcc_h43;
        DAST._IExpression _1667_on = _1660___mcc_h42;
        {
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1668_typeArgString;
          _1668_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          if ((new BigInteger((_1665_typeArgs).Count)) >= (BigInteger.One)) {
            BigInteger _1669_typeI;
            _1669_typeI = BigInteger.Zero;
            _1668_typeArgString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::<");
            while ((_1669_typeI) < (new BigInteger((_1665_typeArgs).Count))) {
              if ((_1669_typeI).Sign == 1) {
                _1668_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1668_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
              }
              Dafny.ISequence<Dafny.Rune> _1670_typeString;
              Dafny.ISequence<Dafny.Rune> _out1024;
              _out1024 = DCOMP.COMP.GenType((_1665_typeArgs).Select(_1669_typeI), false, false);
              _1670_typeString = _out1024;
              _1668_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1668_typeArgString, _1670_typeString);
              _1669_typeI = (_1669_typeI) + (BigInteger.One);
            }
            _1668_typeArgString = Dafny.Sequence<Dafny.Rune>.Concat(_1668_typeArgString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(">"));
          }
          Dafny.ISequence<Dafny.Rune> _1671_argString;
          _1671_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1672_i;
          _1672_i = BigInteger.Zero;
          while ((_1672_i) < (new BigInteger((_1664_args).Count))) {
            if ((_1672_i).Sign == 1) {
              _1671_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1671_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1673_argExpr;
            bool _1674_isOwned;
            bool _1675_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1676_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1025;
            bool _out1026;
            bool _out1027;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1028;
            DCOMP.COMP.GenExpr((_1664_args).Select(_1672_i), @params, false, out _out1025, out _out1026, out _out1027, out _out1028);
            _1673_argExpr = _out1025;
            _1674_isOwned = _out1026;
            _1675_argErased = _out1027;
            _1676_argIdents = _out1028;
            if (_1674_isOwned) {
              _1673_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1673_argExpr);
            }
            _1671_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1671_argString, _1673_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1676_argIdents);
            _1672_i = (_1672_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1677_enclosingString;
          bool _1678___v57;
          bool _1679___v58;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1680_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1029;
          bool _out1030;
          bool _out1031;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1032;
          DCOMP.COMP.GenExpr(_1667_on, @params, false, out _out1029, out _out1030, out _out1031, out _out1032);
          _1677_enclosingString = _out1029;
          _1678___v57 = _out1030;
          _1679___v58 = _out1031;
          _1680_recIdents = _out1032;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1680_recIdents);
          DAST._IExpression _source57 = _1667_on;
          if (_source57.is_Literal) {
            DAST._ILiteral _1681___mcc_h618 = _source57.dtor_Literal_a0;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Ident) {
            Dafny.ISequence<Dafny.Rune> _1682___mcc_h620 = _source57.dtor_Ident_a0;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Companion) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1683___mcc_h622 = _source57.dtor_Companion_a0;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(_1677_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
            }
          } else if (_source57.is_Tuple) {
            Dafny.ISequence<DAST._IExpression> _1684___mcc_h624 = _source57.dtor_Tuple_a0;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_New) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1685___mcc_h626 = _source57.dtor_path;
            Dafny.ISequence<DAST._IExpression> _1686___mcc_h627 = _source57.dtor_args;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_NewArray) {
            Dafny.ISequence<DAST._IExpression> _1687___mcc_h630 = _source57.dtor_dims;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_DatatypeValue) {
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1688___mcc_h632 = _source57.dtor_path;
            Dafny.ISequence<Dafny.Rune> _1689___mcc_h633 = _source57.dtor_variant;
            bool _1690___mcc_h634 = _source57.dtor_isCo;
            Dafny.ISequence<_System._ITuple2<Dafny.ISequence<Dafny.Rune>, DAST._IExpression>> _1691___mcc_h635 = _source57.dtor_contents;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Convert) {
            DAST._IExpression _1692___mcc_h640 = _source57.dtor_value;
            DAST._IType _1693___mcc_h641 = _source57.dtor_from;
            DAST._IType _1694___mcc_h642 = _source57.dtor_typ;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_SubsetDowngrade) {
            DAST._IExpression _1695___mcc_h646 = _source57.dtor_value;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_SeqValue) {
            Dafny.ISequence<DAST._IExpression> _1696___mcc_h648 = _source57.dtor_elements;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_SetValue) {
            Dafny.ISequence<DAST._IExpression> _1697___mcc_h650 = _source57.dtor_elements;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_This) {
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Ite) {
            DAST._IExpression _1698___mcc_h652 = _source57.dtor_cond;
            DAST._IExpression _1699___mcc_h653 = _source57.dtor_thn;
            DAST._IExpression _1700___mcc_h654 = _source57.dtor_els;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_UnOp) {
            DAST._IUnaryOp _1701___mcc_h658 = _source57.dtor_unOp;
            DAST._IExpression _1702___mcc_h659 = _source57.dtor_expr;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_BinOp) {
            Dafny.ISequence<Dafny.Rune> _1703___mcc_h662 = _source57.dtor_op;
            DAST._IExpression _1704___mcc_h663 = _source57.dtor_left;
            DAST._IExpression _1705___mcc_h664 = _source57.dtor_right;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Select) {
            DAST._IExpression _1706___mcc_h668 = _source57.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1707___mcc_h669 = _source57.dtor_field;
            bool _1708___mcc_h670 = _source57.dtor_isConstant;
            bool _1709___mcc_h671 = _source57.dtor_onDatatype;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_SelectFn) {
            DAST._IExpression _1710___mcc_h676 = _source57.dtor_expr;
            Dafny.ISequence<Dafny.Rune> _1711___mcc_h677 = _source57.dtor_field;
            bool _1712___mcc_h678 = _source57.dtor_onDatatype;
            bool _1713___mcc_h679 = _source57.dtor_isStatic;
            BigInteger _1714___mcc_h680 = _source57.dtor_arity;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_TupleSelect) {
            DAST._IExpression _1715___mcc_h686 = _source57.dtor_expr;
            BigInteger _1716___mcc_h687 = _source57.dtor_index;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Call) {
            DAST._IExpression _1717___mcc_h690 = _source57.dtor_on;
            Dafny.ISequence<Dafny.Rune> _1718___mcc_h691 = _source57.dtor_name;
            Dafny.ISequence<DAST._IType> _1719___mcc_h692 = _source57.dtor_typeArgs;
            Dafny.ISequence<DAST._IExpression> _1720___mcc_h693 = _source57.dtor_args;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Lambda) {
            Dafny.ISequence<DAST._IFormal> _1721___mcc_h698 = _source57.dtor_params;
            DAST._IType _1722___mcc_h699 = _source57.dtor_retType;
            Dafny.ISequence<DAST._IStatement> _1723___mcc_h700 = _source57.dtor_body;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_IIFE) {
            Dafny.ISequence<Dafny.Rune> _1724___mcc_h704 = _source57.dtor_name;
            DAST._IType _1725___mcc_h705 = _source57.dtor_typ;
            DAST._IExpression _1726___mcc_h706 = _source57.dtor_value;
            DAST._IExpression _1727___mcc_h707 = _source57.dtor_iifeBody;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_Apply) {
            DAST._IExpression _1728___mcc_h712 = _source57.dtor_expr;
            Dafny.ISequence<DAST._IExpression> _1729___mcc_h713 = _source57.dtor_args;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else if (_source57.is_TypeTest) {
            DAST._IExpression _1730___mcc_h716 = _source57.dtor_on;
            Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1731___mcc_h717 = _source57.dtor_dType;
            Dafny.ISequence<Dafny.Rune> _1732___mcc_h718 = _source57.dtor_variant;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          } else {
            DAST._IType _1733___mcc_h722 = _source57.dtor_typ;
            {
              _1677_enclosingString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("("), _1677_enclosingString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")."));
            }
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1677_enclosingString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("r#")), (_1666_name)), _1668_typeArgString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1671_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_Lambda) {
        Dafny.ISequence<DAST._IFormal> _1734___mcc_h46 = _source19.dtor_params;
        DAST._IType _1735___mcc_h47 = _source19.dtor_retType;
        Dafny.ISequence<DAST._IStatement> _1736___mcc_h48 = _source19.dtor_body;
        Dafny.ISequence<DAST._IStatement> _1737_body = _1736___mcc_h48;
        DAST._IType _1738_retType = _1735___mcc_h47;
        Dafny.ISequence<DAST._IFormal> _1739_params = _1734___mcc_h46;
        {
          Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1740_paramNames;
          _1740_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements();
          BigInteger _1741_i;
          _1741_i = BigInteger.Zero;
          while ((_1741_i) < (new BigInteger((_1739_params).Count))) {
            _1740_paramNames = Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(_1740_paramNames, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements(((_1739_params).Select(_1741_i)).dtor_name));
            _1741_i = (_1741_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1742_recursiveGen;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1743_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1033;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1034;
          DCOMP.COMP.GenStmts(_1737_body, _1740_paramNames, true, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(""), out _out1033, out _out1034);
          _1742_recursiveGen = _out1033;
          _1743_recIdents = _out1034;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements();
          Dafny.ISequence<Dafny.Rune> _1744_allReadCloned;
          _1744_allReadCloned = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          while (!(_1743_recIdents).Equals(Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements())) {
            Dafny.ISequence<Dafny.Rune> _1745_next;
            foreach (Dafny.ISequence<Dafny.Rune> _assign_such_that_1 in (_1743_recIdents).Elements) {
              _1745_next = (Dafny.ISequence<Dafny.Rune>)_assign_such_that_1;
              if ((_1743_recIdents).Contains(_1745_next)) {
                goto after__ASSIGN_SUCH_THAT_1;
              }
            }
            throw new System.Exception("assign-such-that search produced no value (line 1407)");
          after__ASSIGN_SUCH_THAT_1:;
            if (!((_1740_paramNames).Contains(_1745_next))) {
              _1744_allReadCloned = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1744_allReadCloned, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("let r#")), _1745_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = r#")), _1745_next), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".clone();\n"));
              readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_1745_next));
            }
            _1743_recIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Difference(_1743_recIdents, Dafny.Set<Dafny.ISequence<Dafny.Rune>>.FromElements(_1745_next));
          }
          Dafny.ISequence<Dafny.Rune> _1746_paramsString;
          _1746_paramsString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          _1741_i = BigInteger.Zero;
          while ((_1741_i) < (new BigInteger((_1739_params).Count))) {
            if ((_1741_i).Sign == 1) {
              _1746_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(_1746_paramsString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1747_typStr;
            Dafny.ISequence<Dafny.Rune> _out1035;
            _out1035 = DCOMP.COMP.GenType(((_1739_params).Select(_1741_i)).dtor_typ, false, true);
            _1747_typStr = _out1035;
            _1746_paramsString = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(_1746_paramsString, ((_1739_params).Select(_1741_i)).dtor_name), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": &")), _1747_typStr);
            _1741_i = (_1741_i) + (BigInteger.One);
          }
          Dafny.ISequence<Dafny.Rune> _1748_retTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1036;
          _out1036 = DCOMP.COMP.GenType(_1738_retType, false, true);
          _1748_retTypeGen = _out1036;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::FunctionWrapper({\n"), _1744_allReadCloned), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::std::boxed::Box::new(move |")), _1746_paramsString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("| -> ")), _1748_retTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" {\n")), _1742_recursiveGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n})})"));
          isOwned = true;
          isErased = true;
        }
      } else if (_source19.is_IIFE) {
        Dafny.ISequence<Dafny.Rune> _1749___mcc_h49 = _source19.dtor_name;
        DAST._IType _1750___mcc_h50 = _source19.dtor_typ;
        DAST._IExpression _1751___mcc_h51 = _source19.dtor_value;
        DAST._IExpression _1752___mcc_h52 = _source19.dtor_iifeBody;
        DAST._IExpression _1753_iifeBody = _1752___mcc_h52;
        DAST._IExpression _1754_value = _1751___mcc_h51;
        DAST._IType _1755_tpe = _1750___mcc_h50;
        Dafny.ISequence<Dafny.Rune> _1756_name = _1749___mcc_h49;
        {
          Dafny.ISequence<Dafny.Rune> _1757_valueGen;
          bool _1758_valueOwned;
          bool _1759_valueErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1760_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1037;
          bool _out1038;
          bool _out1039;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1040;
          DCOMP.COMP.GenExpr(_1754_value, @params, false, out _out1037, out _out1038, out _out1039, out _out1040);
          _1757_valueGen = _out1037;
          _1758_valueOwned = _out1038;
          _1759_valueErased = _out1039;
          _1760_recIdents = _out1040;
          if (_1759_valueErased) {
            Dafny.ISequence<Dafny.Rune> _1761_eraseFn;
            _1761_eraseFn = ((_1758_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
            _1757_valueGen = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::dafny_runtime::DafnyUnerasable::<_>::"), _1761_eraseFn), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1757_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(")"));
          }
          readIdents = _1760_recIdents;
          Dafny.ISequence<Dafny.Rune> _1762_valueTypeGen;
          Dafny.ISequence<Dafny.Rune> _out1041;
          _out1041 = DCOMP.COMP.GenType(_1755_tpe, false, true);
          _1762_valueTypeGen = _out1041;
          Dafny.ISequence<Dafny.Rune> _1763_bodyGen;
          bool _1764_bodyOwned;
          bool _1765_bodyErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1766_bodyIdents;
          Dafny.ISequence<Dafny.Rune> _out1042;
          bool _out1043;
          bool _out1044;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1045;
          DCOMP.COMP.GenExpr(_1753_iifeBody, Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.Concat(@params, ((_1758_valueOwned) ? (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements()) : (Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements((_1756_name))))), mustOwn, out _out1042, out _out1043, out _out1044, out _out1045);
          _1763_bodyGen = _out1042;
          _1764_bodyOwned = _out1043;
          _1765_bodyErased = _out1044;
          _1766_bodyIdents = _out1045;
          readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1766_bodyIdents);
          Dafny.ISequence<Dafny.Rune> _1767_eraseFn;
          _1767_eraseFn = ((_1758_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase_owned")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("unerase")));
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{\nlet r#"), (_1756_name)), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(": ")), ((_1758_valueOwned) ? (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("")) : (Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&")))), _1762_valueTypeGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" = ")), _1757_valueGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(";\n")), _1763_bodyGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n}"));
          isOwned = _1764_bodyOwned;
          isErased = _1765_bodyErased;
        }
      } else if (_source19.is_Apply) {
        DAST._IExpression _1768___mcc_h53 = _source19.dtor_expr;
        Dafny.ISequence<DAST._IExpression> _1769___mcc_h54 = _source19.dtor_args;
        Dafny.ISequence<DAST._IExpression> _1770_args = _1769___mcc_h54;
        DAST._IExpression _1771_func = _1768___mcc_h53;
        {
          Dafny.ISequence<Dafny.Rune> _1772_funcString;
          bool _1773___v61;
          bool _1774_funcErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1775_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1046;
          bool _out1047;
          bool _out1048;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1049;
          DCOMP.COMP.GenExpr(_1771_func, @params, false, out _out1046, out _out1047, out _out1048, out _out1049);
          _1772_funcString = _out1046;
          _1773___v61 = _out1047;
          _1774_funcErased = _out1048;
          _1775_recIdents = _out1049;
          readIdents = _1775_recIdents;
          Dafny.ISequence<Dafny.Rune> _1776_argString;
          _1776_argString = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("");
          BigInteger _1777_i;
          _1777_i = BigInteger.Zero;
          while ((_1777_i) < (new BigInteger((_1770_args).Count))) {
            if ((_1777_i).Sign == 1) {
              _1776_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1776_argString, Dafny.Sequence<Dafny.Rune>.UnicodeFromString(", "));
            }
            Dafny.ISequence<Dafny.Rune> _1778_argExpr;
            bool _1779_isOwned;
            bool _1780_argErased;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1781_argIdents;
            Dafny.ISequence<Dafny.Rune> _out1050;
            bool _out1051;
            bool _out1052;
            Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1053;
            DCOMP.COMP.GenExpr((_1770_args).Select(_1777_i), @params, false, out _out1050, out _out1051, out _out1052, out _out1053);
            _1778_argExpr = _out1050;
            _1779_isOwned = _out1051;
            _1780_argErased = _out1052;
            _1781_argIdents = _out1053;
            if (_1779_isOwned) {
              _1778_argExpr = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("&"), _1778_argExpr);
            }
            _1776_argString = Dafny.Sequence<Dafny.Rune>.Concat(_1776_argString, _1778_argExpr);
            readIdents = Dafny.Set<Dafny.ISequence<Dafny.Rune>>.Union(readIdents, _1781_argIdents);
            _1777_i = (_1777_i) + (BigInteger.One);
          }
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(("), _1772_funcString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(").0")), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("(")), _1776_argString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("))"));
          isOwned = true;
          isErased = false;
        }
      } else if (_source19.is_TypeTest) {
        DAST._IExpression _1782___mcc_h55 = _source19.dtor_on;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1783___mcc_h56 = _source19.dtor_dType;
        Dafny.ISequence<Dafny.Rune> _1784___mcc_h57 = _source19.dtor_variant;
        Dafny.ISequence<Dafny.Rune> _1785_variant = _1784___mcc_h57;
        Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> _1786_dType = _1783___mcc_h56;
        DAST._IExpression _1787_on = _1782___mcc_h55;
        {
          Dafny.ISequence<Dafny.Rune> _1788_exprGen;
          bool _1789___v62;
          bool _1790_exprErased;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _1791_recIdents;
          Dafny.ISequence<Dafny.Rune> _out1054;
          bool _out1055;
          bool _out1056;
          Dafny.ISet<Dafny.ISequence<Dafny.Rune>> _out1057;
          DCOMP.COMP.GenExpr(_1787_on, @params, false, out _out1054, out _out1055, out _out1056, out _out1057);
          _1788_exprGen = _out1054;
          _1789___v62 = _out1055;
          _1790_exprErased = _out1056;
          _1791_recIdents = _out1057;
          Dafny.ISequence<Dafny.Rune> _1792_dTypePath;
          Dafny.ISequence<Dafny.Rune> _out1058;
          _out1058 = DCOMP.COMP.GenPath(_1786_dType);
          _1792_dTypePath = _out1058;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("matches!("), _1788_exprGen), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(".as_ref(), ")), _1792_dTypePath), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::r#")), _1785_variant), Dafny.Sequence<Dafny.Rune>.UnicodeFromString("{ .. })"));
          isOwned = true;
          isErased = true;
          readIdents = _1791_recIdents;
        }
      } else {
        DAST._IType _1793___mcc_h58 = _source19.dtor_typ;
        DAST._IType _1794_typ = _1793___mcc_h58;
        {
          Dafny.ISequence<Dafny.Rune> _1795_typString;
          Dafny.ISequence<Dafny.Rune> _out1059;
          _out1059 = DCOMP.COMP.GenType(_1794_typ, false, false);
          _1795_typString = _out1059;
          s = Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.Concat(Dafny.Sequence<Dafny.Rune>.UnicodeFromString("<"), _1795_typString), Dafny.Sequence<Dafny.Rune>.UnicodeFromString(" as std::default::Default>::default()"));
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
      BigInteger _1796_i;
      _1796_i = BigInteger.Zero;
      while ((_1796_i) < (new BigInteger((p).Count))) {
        Dafny.ISequence<Dafny.Rune> _1797_generated = Dafny.Sequence<Dafny.Rune>.Empty;
        Dafny.ISequence<Dafny.Rune> _out1060;
        _out1060 = DCOMP.COMP.GenModule((p).Select(_1796_i), Dafny.Sequence<Dafny.ISequence<Dafny.Rune>>.FromElements());
        _1797_generated = _out1060;
        if ((_1796_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\n"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, _1797_generated);
        _1796_i = (_1796_i) + (BigInteger.One);
      }
      return s;
    }
    public static Dafny.ISequence<Dafny.Rune> EmitCallToMain(Dafny.ISequence<Dafny.ISequence<Dafny.Rune>> fullName) {
      Dafny.ISequence<Dafny.Rune> s = Dafny.Sequence<Dafny.Rune>.Empty;
      s = Dafny.Sequence<Dafny.Rune>.UnicodeFromString("\nfn main() {\n");
      BigInteger _1798_i;
      _1798_i = BigInteger.Zero;
      while ((_1798_i) < (new BigInteger((fullName).Count))) {
        if ((_1798_i).Sign == 1) {
          s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("::"));
        }
        s = Dafny.Sequence<Dafny.Rune>.Concat(s, (fullName).Select(_1798_i));
        _1798_i = (_1798_i) + (BigInteger.One);
      }
      s = Dafny.Sequence<Dafny.Rune>.Concat(s, Dafny.Sequence<Dafny.Rune>.UnicodeFromString("();\n}"));
      return s;
    }
  }
} // end of namespace DCOMP

